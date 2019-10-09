# verifytyperefs 

[![Build Status](https://dev.azure.com/vmad/GitHubBuilds/_apis/build/status/vatsanm.verifytyperefs?branchName=master)](https://dev.azure.com/vmad/GitHubBuilds/_build/latest?definitionId=7&branchName=master)

A small tool to verify type-refs in an assembly

## Usage

```
  -a, --assembly          Required. Path to assembly to be analyzed
  -f, --frameworkPaths    Paths of various frameworks
  --noMatches             (Default: false) Show only error, Do not show matches
  -v, --Verbose           (Default: false) Verbose Outputs
  --showRefs              (Default: false) Show Assembly References
  --help                  Display this help screen.
  --version               Display version information.
```

  ## Example 

```
λ  verifytyperefs -a DirectWriteForwarder.dll --noMatches --showRefs -f "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\"

Module locations:
        System.Runtime.CompilerServices.VisualC.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Runtime.CompilerServices.VisualC.dll
        System.Private.CoreLib.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Private.CoreLib.dll
        System.Private.Uri.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Private.Uri.dll
        System.Net.Requests.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Net.Requests.dll
        WindowsBase.dll: .\WindowsBase.dll
        System.IO.Packaging.dll: .\System.IO.Packaging.dll
        Microsoft.Win32.Primitives.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\Microsoft.Win32.Primitives.dll
        System.Collections.NonGeneric.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Collections.NonGeneric.dll
        System.Runtime.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Runtime.dll
        System.Runtime.Extensions.dll: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.0.0\System.Runtime.Extensions.dll

Assembly Resolve Search Directories:
        .
        bin
Assembly References:
        Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        Microsoft.VisualBasic.Core, Version=10.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        Microsoft.Win32.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.AppContext, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Buffers, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Collections.Concurrent, Version=4.0.14.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Collections.Immutable, Version=1.2.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Collections.NonGeneric, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Collections.Specialized, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ComponentModel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ComponentModel.Annotations, Version=4.3.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ComponentModel.DataAnnotations, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
        System.ComponentModel.EventBasedAsync, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ComponentModel.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ComponentModel.TypeConverter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Console, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Data.Common, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Diagnostics.Contracts, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.Debug, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.DiagnosticSource, Version=4.0.4.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Diagnostics.FileVersionInfo, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.Process, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.StackTrace, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.TextWriterTraceListener, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.Tools, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.TraceSource, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Diagnostics.Tracing, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Drawing.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Dynamic.Runtime, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Globalization, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Globalization.Calendars, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Globalization.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.Compression, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.IO.Compression.Brotli, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.IO.Compression.FileSystem, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.IO.Compression.ZipFile, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.IO.FileSystem, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.FileSystem.DriveInfo, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.FileSystem.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.FileSystem.Watcher, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.IsolatedStorage, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.MemoryMappedFiles, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.Packaging, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.Pipes, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.IO.UnmanagedMemoryStream, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Linq, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Linq.Expressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Linq.Parallel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Linq.Queryable, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Memory, Version=4.2.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.Http, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.HttpListener, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net.Mail, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net.NameResolution, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.NetworkInformation, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.Ping, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.Requests, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.Security, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.ServicePoint, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net.Sockets, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.WebClient, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net.WebHeaderCollection, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.WebProxy, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Net.WebSockets, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Net.WebSockets.Client, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Numerics.Vectors, Version=4.1.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.DispatchProxy, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Emit, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Emit.ILGeneration, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Emit.Lightweight, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Metadata, Version=1.4.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Reflection.TypeExtensions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Resources.Reader, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Resources.ResourceManager, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Resources.Writer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.CompilerServices.Unsafe, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.CompilerServices.VisualC, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Extensions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Handles, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.InteropServices, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.InteropServices.RuntimeInformation, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.InteropServices.WindowsRuntime, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Intrinsics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Runtime.Loader, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Numerics, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Runtime.Serialization.Formatters, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Serialization.Json, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Serialization.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Runtime.Serialization.Xml, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Claims, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Cryptography.Algorithms, Version=4.3.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Cryptography.Csp, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Cryptography.Encoding, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Cryptography.Primitives, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Cryptography.X509Certificates, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.Principal, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Security.SecureString, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.ServiceModel.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
        System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Text.Encoding, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Text.Encoding.CodePages, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Text.Encoding.Extensions, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Text.Encodings.Web, Version=4.0.4.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Text.Json, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Text.RegularExpressions, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Channels, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Threading.Overlapped, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Tasks, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Tasks.Dataflow, Version=4.6.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Tasks.Extensions, Version=4.3.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Threading.Tasks.Parallel, Version=4.0.3.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Thread, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.ThreadPool, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Threading.Timer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Transactions.Local, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.ValueTuple, Version=4.0.3.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Web.HttpUtility, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51
        System.Windows, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Xml.ReaderWriter, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
        System.Xml.XDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml.XmlDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml.XmlSerializer, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml.XPath, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        System.Xml.XPath.XDocument, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
        WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35

```