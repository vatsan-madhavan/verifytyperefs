using System;
using System.Collections.Generic;

namespace verifytypes
{
    class TypeVerificationResult
    {
        /// <summary>
        /// List of (Module, ActualModule, TypeName) 
        /// </summary>
        public List<Tuple<string, string, string>> ResolvedTypes { get; set; } = new List<Tuple<string, string, string>>();

        /// <summary>
        /// List of (Module, TypeName)
        /// </summary>
        public List<Tuple<string, string>> UnresolvedTypes { get; set; } = new List<Tuple<string, string>>();

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> ModuleLocations { get; set; } = new Dictionary<string, string>();
    }
}
