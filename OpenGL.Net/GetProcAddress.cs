
// Copyright (C) 2009-2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Abtract an interface for interoperating with dynamically loaded libraries.
	/// </summary>
	public static class GetProcAddress
	{
		#region Static Constructor

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GetProcAddress()
		{
			PlatformID pId = Environment.OSVersion.Platform;

			// Determine GetOpenGLProcAddress implementation
			if ((pId == PlatformID.Win32NT) || (pId == PlatformID.Win32S) || (pId == PlatformID.Win32Windows) || (pId == PlatformID.WinCE)) {
				sGetProcAddress = new GetProcAddressWindows();
			} else if ((pId == PlatformID.Unix) || (pId == (PlatformID)4)) {
				string pIdString = DetectUnixKernel();

				// Distinguish between Unix and Mac OS X kernels.
				switch (pIdString) {
				case "Unix":
				case "Linux":
					sGetProcAddress = new GetProcAddressX11();
					break;
				case "Darwin":
					sGetProcAddress = new GetProcAddressOSX();
					break;
				default:
					throw new PlatformNotSupportedException(pIdString + ": unknown Unix platform - cannot load extensions");
				}
			} else {
				throw new PlatformNotSupportedException("extension loading is only supported under Mac OS X, Unix/X11 and Windows");
			}
		}

		#endregion

		#region Static Implementation of IGetProcAddress

		/// <summary>
		/// Retrieves the entry point for a dynamically exported function from any valid assembly.
		/// </summary>
		/// <param name="path">
		/// A <see cref="System.String"/> that specifies the path of the assembly file.
		/// </param>
		/// <param name="function">
		/// The function string for the OpenGL function (i.e. "GetProcAddress")
		/// </param>
		/// <returns>
		/// An IntPtr contaning the address for the entry point, or IntPtr.Zero if the specified
		/// function is not dynamically exported.
		/// </returns>
		public static IntPtr GetAddress(string path, string function)
		{
			return (sGetProcAddress.GetProcAddress(path, function));
		}


		/// <summary>
		/// Retrieves the entry point for a dynamically exported OpenGL function.
		/// </summary>
		/// <param name="function">The function string for the OpenGL function (eg. "glNewList")</param>
		/// <returns>
		/// An IntPtr contaning the address for the entry point, or IntPtr.Zero if the specified
		/// OpenGL function is not dynamically exported.
		/// </returns>
		public static IntPtr GetOpenGLAddress(string function)
		{
			return (sGetProcAddress.GetOpenGLProcAddress(function));
		}

		/// <summary>
		/// Executes "uname" which returns a string representing the name of the
		/// underlying Unix kernel.
		/// </summary>
		/// <returns>
		/// "Unix", "Linux", "Darwin" or null.
		/// </returns>
		/// <remarks>
		/// Source code from "Mono: A Developer's Notebook"
		/// </remarks>
		private static string DetectUnixKernel()
		{
			ProcessStartInfo startInfo = new ProcessStartInfo();

			startInfo.Arguments = "-s";
			startInfo.RedirectStandardOutput = true;
			startInfo.RedirectStandardError = true;
			startInfo.UseShellExecute = false;

			foreach (string unameprog in new string[] { "/usr/bin/uname", "/bin/uname", "uname" })
			{
				try {
					startInfo.FileName = unameprog;
					Process uname = Process.Start(startInfo);
					StreamReader stdout = uname.StandardOutput;
					return stdout.ReadLine().Trim();
				} catch (System.IO.FileNotFoundException) {
					// The requested executable doesn't exist, try next one.
					continue;
				} catch (System.ComponentModel.Win32Exception) {
					continue;
				}
			}

			return (null);
		}

		/// <summary>
		/// Interface for loading external symbols.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		private static IGetProcAddress sGetProcAddress;

		#endregion
	}

	/// <summary>
	/// Interface implemented by those classes which are able to get function pointers from dynamically loaded libraries.
	/// </summary>
	interface IGetProcAddress
	{
		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		IntPtr GetProcAddress(string library, string function);

		/// <summary>
		/// Get a function pointer from a library, specified by handle.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		IntPtr GetProcAddress(IntPtr library, string function);

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		IntPtr GetOpenGLProcAddress(string function);
	}

	/// <summary>
	/// Class able to get function pointers on Windows platform.
	/// </summary>
	class GetProcAddressWindows : IGetProcAddress
	{
		#region Windows Platform Imports

		[DllImport("Kernel32.dll", SetLastError=true)]
		private static extern IntPtr LoadLibrary(String lpFileName);

		[DllImport("Kernel32.dll", SetLastError=true)]
		private static extern void FreeLibrary(IntPtr hModule);

		[DllImport("Kernel32.dll", EntryPoint="GetProcAddress", CharSet=CharSet.Ansi, ExactSpelling=true, SetLastError=true)]
		private static extern IntPtr Win32GetProcAddress(IntPtr hModule, String lpProcName);

		[DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true)]
		private static extern IntPtr wglGetProcAddress(String lpszProc);

		#endregion

		#region IGetProceAddress Implementation

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string library, string function)
		{
			IntPtr handle = GetLibraryHandle(library);

			return (GetProcAddress(handle, function));
		}

		/// <summary>
		/// Get a function pointer from a library, specified by handle.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			if (library == IntPtr.Zero)
				throw new ArgumentNullException("library");
			if (function == null)
				throw new ArgumentNullException("function");

			return (Win32GetProcAddress(library, function));
		}

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetOpenGLProcAddress(string function)
		{
			IntPtr libraryFunct;

			if ((libraryFunct = wglGetProcAddress(function)) == IntPtr.Zero) {
				IntPtr libraryHandle = GetLibraryHandle(Library);

				return (Win32GetProcAddress(libraryHandle, function));
			} else
				return (libraryFunct);
		}

		private IntPtr GetLibraryHandle(string libraryPath)
		{
			IntPtr libraryHandle;

			if (sLibraryHandles.TryGetValue(libraryPath, out libraryHandle) == false) {
				libraryHandle = LoadLibrary(libraryPath);
				sLibraryHandles.Add(libraryPath, libraryHandle);
			}

			if (libraryHandle == IntPtr.Zero)
				throw new InvalidOperationException(String.Format("unable to load library at {0}", libraryPath));

			return (libraryHandle);
		}

		/// <summary>
		/// The OpenGL library on Windows platform.
		/// </summary>
		private const string Library = "opengl32.dll";

		/// <summary>
		/// The OpenGL library handle.
		/// </summary>
		/// <remarks>
		/// This handle is meaningfull only in the case wglGetProcAddress fails to load a function pointer.
		/// </remarks>
		private static IntPtr mLibraryHandle = IntPtr.Zero;

		/// <summary>
		/// Currently loaded libraries.
		/// </summary>
		private static readonly Dictionary<string, IntPtr> sLibraryHandles = new Dictionary<string,IntPtr>();

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on X11 platform.
	/// </summary>
	class GetProcAddressX11 : IGetProcAddress
	{
		#region X11 Platform Imports

		const int RTLD_NOW = 2;

		[DllImport("dl")]
		static extern IntPtr dlopen([MarshalAs(UnmanagedType.LPTStr)] string filename, int flags);

		[DllImport("dl")]
		static extern IntPtr dlsym(IntPtr handle, [MarshalAs(UnmanagedType.LPTStr)] string symbol);

		[DllImport(Library, EntryPoint = "glXGetProcAddress")]
		private static extern IntPtr glxGetProcAddress([MarshalAs(UnmanagedType.LPTStr)] string procName);

		#endregion

		#region IGetProcAdress Imports

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string library, string function)
		{
			IntPtr handle = GetLibraryHandle(library);

			return (GetProcAddress(handle, function));
		}

		/// <summary>
		/// Get a function pointer from a library, specified by handle.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			if (library == IntPtr.Zero)
				throw new ArgumentNullException("library");
			if (function == null)
				throw new ArgumentNullException("function");

			return (dlsym(library, function));
		}

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetOpenGLProcAddress(string function)
		{
			return (glxGetProcAddress(function));
		}

		private IntPtr GetLibraryHandle(string libraryPath)
		{
			IntPtr libraryHandle;

			if (sLibraryHandles.TryGetValue(libraryPath, out libraryHandle) == false) {
				libraryHandle = dlopen(libraryPath, RTLD_NOW);
				sLibraryHandles.Add(libraryPath, libraryHandle);
			}

			if (libraryHandle == IntPtr.Zero)
				throw new InvalidOperationException(String.Format("unable to load library at {0}", libraryPath));

			return (libraryHandle);
		}

		/// <summary>
		/// The OpenGL library on Unix/Linux platforms.
		/// </summary>
		private const string Library = "GL.so";

		/// <summary>
		/// Currently loaded libraries.
		/// </summary>
		private static readonly Dictionary<string, IntPtr> sLibraryHandles = new Dictionary<string,IntPtr>();

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on OSX platform.
	/// </summary>
	class GetProcAddressOSX : IGetProcAddress
	{
		#region OSX Platform Imports

		[DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
		private static extern bool NSIsSymbolNameDefined(string s);

		[DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
		private static extern IntPtr NSLookupAndBindSymbol(string s);

		[DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
		private static extern IntPtr NSAddressOfSymbol(IntPtr symbol);

		#endregion

		#region IGetProcAddress Implementation

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string library, string function)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get a function pointer from a library, specified by handle.
		/// </summary>
		/// <param name="library">
		/// A <see cref="System.IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="System.String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetOpenGLProcAddress(string function)
		{
			string fname = "_" + function;
			if (!NSIsSymbolNameDefined(fname))
				return IntPtr.Zero;

			IntPtr symbol = NSLookupAndBindSymbol(fname);
			if (symbol != IntPtr.Zero)
				symbol = NSAddressOfSymbol(symbol);

			return (symbol);
		}

		/// <summary>
		/// The OpenGL library on OSX platform.
		/// </summary>
		private const string Library = "libdl.dylib";

		#endregion
	}
}
