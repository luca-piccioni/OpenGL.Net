using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if !NETCORE
[assembly: AssemblyTitle("OpenGL.Net")]
[assembly: AssemblyDescription("Modern C# bindings for OpenGL.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Luca Piccioni")]
[assembly: AssemblyProduct("OpenGL.Net")]
[assembly: AssemblyCopyright("Copyright (C) Luca Piccioni 2015-2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7f6066fa-3136-45cb-a092-e91f0f0fc467")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
[assembly: AssemblyVersion("0.4.0")]
[assembly: AssemblyFileVersion("0.4.0")]

[assembly: InternalsVisibleTo("OpenGL.Net.VideoCore")]
[assembly: InternalsVisibleTo("OpenWF.Net")]
// Unit testing support
[assembly: InternalsVisibleTo("OpenGL.Net.Test")]
