using Mono.Cecil;
using System;
using System.Collections.Generic;
using CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace verifytypes
{

    class Program
    {
        public class Options
        {
            [Option('a', "assembly", Required = true, HelpText = "Path to assembly to be analyzed")]
            public string Assembly { get; set; }

            [Option('f', "frameworkPaths", Required = false, HelpText = "Paths of various frameworks")]
            public IEnumerable<string> FrameworkPaths { get; set; }

            [Option("noMatches", Required =false, HelpText = "Show only error, Do not show matches", Default = false)]
            public bool NoMatches { get; set; }

            [Option ('v', "Verbose", Required = false, HelpText = "Verbose Outputs", Default = false)]
            public bool Verbose { get; set; }

            [Option("showRefs", Required = false, HelpText = "Show Assembly References", Default = false)]
            public bool ShowAssemblyReferences { get; set; }
        }

        static void Main(params string[] args)
        {
            CommandLine
            .Parser.Default.ParseArguments<Options>(args)
            .WithParsed<Options>(opts =>
            {
                if (opts.Verbose)
                {
                    Console.WriteLine($"Assembly: {opts.Assembly}");
                    if (opts.FrameworkPaths.Count() > 0)
                    {
                        Console.WriteLine("FrameworkPaths:");
                    }
                    foreach (var frameworkPath in opts.FrameworkPaths)
                    {
                        Console.WriteLine($"\t{frameworkPath}");
                    }
                    Console.WriteLine();
                }

                if (File.Exists(opts.Assembly))
                {
                    var a = new FileInfo(opts.Assembly);
                    List<DirectoryInfo> frameworkPaths = new List<DirectoryInfo>();
                    foreach (var d in opts.FrameworkPaths)
                    {
                        if (Directory.Exists(d))
                        {
                            frameworkPaths.Add(new DirectoryInfo(d));
                        }
                    }

                    VerifyTypesRefs(a, frameworkPaths.ToArray(), showOnlyErrors: opts.NoMatches);

                    if (opts.ShowAssemblyReferences)
                    {
                        ShowAssemblyReferences(a, frameworkPaths.ToArray());
                    }
                }
            });
        }

        private static void ShowAssemblyReferences(FileInfo a, DirectoryInfo[] frameworkPaths)
        {
            AssemblyDefinitionFromAssembly(a, frameworkPaths, out string[] searchDirectories, out AssemblyDefinition assembly);

            Console.WriteLine("Assembly References:");
            var refs = new SortedList<string, string>();
            foreach (var assemblyRef in assembly.MainModule.AssemblyReferences)
            {
                refs.Add(assemblyRef.FullName, assemblyRef.FullName);
            }

            foreach (var assemblyRef in refs)
            {
                Console.WriteLine($"\t{assemblyRef.Value}");
            }
        }

        private static void VerifyTypesRefs(FileSystemInfo f, DirectoryInfo[] frameworkPaths, bool showOnlyErrors = false)
        {
            AssemblyDefinitionFromAssembly(f, frameworkPaths, out string[] searchDirectories, out AssemblyDefinition assembly);

            // Iterate through each module in the assembly and validate type-refs
            TypeVerificationResult result1 = null;
            foreach (var module in assembly.Modules.Union(Enumerable.Repeat(assembly.MainModule, 1)))
            {
                var typeRefs = module.GetTypeReferences();
                result1 = TestTypeRefs(typeRefs);
            }

            // Iterate over assembly-level attributes and validate the type-refs 
            // that are found at [assembly:] scope
            List<TypeReference> assemblyTypeRefs = new List<TypeReference>();
            foreach (var attr in assembly.CustomAttributes)
            {
                assemblyTypeRefs.Add(attr.AttributeType);
                foreach (var cargs in attr.ConstructorArguments)
                {
                    assemblyTypeRefs.Add(cargs.Type);
                }
                foreach (var flds in attr.Fields)
                {
                    assemblyTypeRefs.Add(flds.Argument.Type);
                }
            }
            var result2 = TestTypeRefs(assemblyTypeRefs);

            // Print out the results
            //
            // Errors first
            // Successes next
            // Module -> DLL map
            // Search paths used. 
            // 
            foreach (var type in result1.UnresolvedTypes.Union(result2.UnresolvedTypes))
            {
                Console.WriteLine($"ERROR: [{type.Item1}] {type.Item2}");
            }

            Console.WriteLine();
            if (!showOnlyErrors)
            {
                foreach (var type in result1.ResolvedTypes.Union(result2.ResolvedTypes))
                {
                    Console.WriteLine($"Resolved: [{type.Item1}]->[{type.Item2}] {type.Item3}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Module locations:");
            foreach (var module in result1.ModuleLocations.Union(result2.ModuleLocations))
            {
                Console.WriteLine($"\t{module.Key}: {module.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Assembly Resolve Search Directories:");
            foreach (var dir in searchDirectories)
            {
                Console.WriteLine($"\t{dir}");
            }
        }

        private static void AssemblyDefinitionFromAssembly(FileSystemInfo f, DirectoryInfo[] frameworkPaths, out string[] searchDirectories, out AssemblyDefinition assembly)
        {
            // Use an assembly resolver. This ensures that a single resolver is used instead of instantiating
            // a new resolver per-module; it also ensures that we can insert our own search-paths supplied by the
            // caller.
            var assemblyResolver = new DefaultAssemblyResolver();
            foreach (var frameworkPath in frameworkPaths)
            {
                // string path = EnsureBalancedQuotingInString(frameworkPath);
                // if (Directory.Exists(path))
                if (frameworkPath.Exists)
                {
                    assemblyResolver.AddSearchDirectory(frameworkPath.FullName);
                }
            }

            searchDirectories = assemblyResolver.GetSearchDirectories();
            ReaderParameters parameters = new ReaderParameters()
            {
                AssemblyResolver = assemblyResolver
            };
            assembly = AssemblyDefinition.ReadAssembly(f.FullName, parameters);
        }

        private static TypeVerificationResult TestTypeRefs(IEnumerable<TypeReference> typeRefs)
        {
            TypeVerificationResult result = new TypeVerificationResult();

            foreach (var typeRef in typeRefs)
            {
                if (typeRef.Scope.MetadataScopeType == MetadataScopeType.AssemblyNameReference)
                {
                    TypeDefinition typeDef = null;
                    try
                    {
                        typeDef = typeRef.Resolve();
                    }
                    catch (AssemblyResolutionException)
                    {
                        typeDef = null;
                    }

                    var assemblyNameRef = (AssemblyNameReference)typeRef.Scope;
                    if (typeDef == null)
                    {
                        var unresolvedType = Tuple.Create(assemblyNameRef.Name, typeRef.FullName);
                        if (!result.UnresolvedTypes.Contains(unresolvedType))
                        {
                            result.UnresolvedTypes.Add(unresolvedType);
                        }
                    }
                    else
                    {
                        var resolvedType = Tuple.Create(assemblyNameRef.Name, typeDef.Module.Name, typeDef.FullName);
                        if (!result.ResolvedTypes.Contains(resolvedType))
                        {
                            result.ResolvedTypes.Add(resolvedType);
                        }
                        result.ModuleLocations[typeDef.Module.Name] = typeDef.Module.FileName;
                    }
                }
            }

            return result;
        }

    }
}
