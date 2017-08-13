
// Copyright (C) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// Macro utility for logging platform-relared function calls
#undef PLATFORM_LOG_ENABLED

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Interface implemented by those classes which are able to get function pointers from dynamically loaded libraries.
	/// </summary>
	interface IGetProcAddressOS
	{
		/// <summary>
		/// Add a path of a directory as additional path for searching libraries.
		/// </summary>
		/// <param name="libraryDirPath">
		/// A <see cref="String"/> that specify the absolute path of the directory where the libraries are loaded using
		/// <see cref="GetProcAddress(string, string)"/> method.
		/// </param>
		void AddLibraryDirectory(string libraryDirPath);

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		IntPtr GetProcAddress(string library, string function);
	}

	/// <summary>
	/// Abtract an interface for loading procedures from dynamically loaded libraries.
	/// </summary>
	internal static class GetProcAddressOS
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GetProcAddressOS()
		{
			_GetProcAddressOS = CreateOS();
		}

		/// <summary>
		/// Most appropriate <see cref="IGetProcAddressOS"/> for the current platform.
		/// </summary>
		private static readonly IGetProcAddressOS _GetProcAddressOS;

		/// <summary>
		/// Create an <see cref="IGetProcAddressOS"/> for the hosting platform.
		/// </summary>
		/// <returns>
		/// It returns the most appropriate <see cref="IGetProcAddressOS"/> for the current platform.
		/// </returns>
		private static IGetProcAddressOS CreateOS()
		{
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					return new GetProcAddressWindows();
				case Platform.Id.Linux:
					return new GetProcAddressLinux();
				case Platform.Id.MacOS:
					return new GetProcAddressOSX();
				case Platform.Id.Android:
					return new GetGLProcAddressEGL();
				default:
					throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
			}
		}

		#endregion

		#region Abstract Interface

		/// <summary>
		/// Add a path of a directory as additional path for searching libraries.
		/// </summary>
		/// <param name="libraryDirPath">
		/// A <see cref="String"/> that specify the absolute path of the directory where the libraries are loaded using
		/// <see cref="GetProcAddress(string, string)"/> method.
		/// </param>
		public static void AddLibraryDirectory(string libraryDirPath)
		{
			_GetProcAddressOS.AddLibraryDirectory(libraryDirPath);
		}

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public static IntPtr GetProcAddress(string library, string function)
		{
			return (_GetProcAddressOS.GetProcAddress(library, function));
		}

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on Windows platform.
	/// </summary>
	class GetProcAddressWindows : IGetProcAddressOS
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetGLProcAddressEGL"/> singleton instance.
		/// </summary>
		public static readonly GetProcAddressWindows Instance = new GetProcAddressWindows();

		#endregion

		#region Windows Platform Imports

		private enum LoadLibraryExFlags : uint
		{
			DONT_RESOLVE_DLL_REFERENCES =			0x00000001,

			LOAD_IGNORE_CODE_AUTHZ_LEVEL =			0x00000010,

			LOAD_LIBRARY_AS_DATAFILE =				0x00000002,

			LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE =	0x00000040,

			LOAD_LIBRARY_AS_IMAGE_RESOURCE =		0x00000020,

			LOAD_LIBRARY_SEARCH_APPLICATION_DIR =	0x00000200,

			LOAD_LIBRARY_SEARCH_DEFAULT_DIRS =		0x00001000,

			LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR =		0x00000100,

			LOAD_LIBRARY_SEARCH_SYSTEM32 =			0x00000800,

			LOAD_LIBRARY_SEARCH_USER_DIRS =			0x00000400,

			LOAD_WITH_ALTERED_SEARCH_PATH =			0x00000008,
		}

		unsafe static class UnsafeNativeMethods
		{
			[DllImport("Kernel32.dll", SetLastError = true)]
			public static extern IntPtr LoadLibrary(String lpFileName);

			[DllImport("Kernel32.dll", SetLastError = true)]
			public static extern IntPtr LoadLibraryEx(String lpFilename, IntPtr hFile, LoadLibraryExFlags dwFlags);

			[DllImport("Kernel32.dll", SetLastError = true)]
			public static extern void FreeLibrary(IntPtr hModule);

			[DllImport("Kernel32.dll", EntryPoint = "GetProcAddress", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
			public static extern IntPtr Win32GetProcAddress(IntPtr hModule, String lpProcName);
		}

		#endregion

		#region IGetProcAddress Implementation

		/// <summary>
		/// Add a path of a directory as additional path for searching libraries.
		/// </summary>
		/// <param name="libraryDirPath">
		/// A <see cref="String"/> that specify the absolute path of the directory where the libraries are loaded using
		/// <see cref="GetProcAddress(string, string)"/> method.
		/// </param>
		public void AddLibraryDirectory(string libraryDirPath)
		{
#if !NETCORE && !NETSTANDARD1_4
			string path = Environment.GetEnvironmentVariable("PATH");

			Environment.SetEnvironmentVariable("PATH", String.Format("{0};{1}", path, libraryDirPath), EnvironmentVariableTarget.Process);
#endif
		}

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
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
		/// A <see cref="IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		private IntPtr GetProcAddress(IntPtr library, string function)
		{
			if (library == IntPtr.Zero)
				throw new ArgumentNullException("library");
			if (function == null)
				throw new ArgumentNullException("function");

			IntPtr procAddress = UnsafeNativeMethods.Win32GetProcAddress(library, function);
#if PLATFORM_LOG_ENABLED
			KhronosApi.LogFunction("GetProcAddress(0x{0}, {1}) = 0x{2}", library.ToString("X8"), function, procAddress.ToString("X8"));
#endif

			return (procAddress);
		}

		/// <summary>
		/// Get the handle relative to the specified library.
		/// </summary>
		/// <param name="libraryPath">
		/// A <see cref="String"/> that specify the path of the library to load.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IntPtr"/> that represents the handle of the library loaded from <paramref name="libraryPath"/>.
		/// </returns>
		public IntPtr GetLibraryHandle(string libraryPath)
		{
			IntPtr libraryHandle;

			if (_LibraryHandles.TryGetValue(libraryPath, out libraryHandle) == false) {
				// Load library
				libraryHandle = UnsafeNativeMethods.LoadLibrary(libraryPath);
#if PLATFORM_LOG_ENABLED
				KhronosApi.LogFunction("LoadLibrary({0}) = 0x{1}", libraryPath, libraryHandle.ToString("X8"));
#endif

				_LibraryHandles.Add(libraryPath, libraryHandle);
			}

			if (libraryHandle == IntPtr.Zero)
				throw new InvalidOperationException(String.Format("unable to load library at {0}", libraryPath), new Win32Exception(Marshal.GetLastWin32Error()));

			return (libraryHandle);
		}

		/// <summary>
		/// The OpenGL library on Windows platform.
		/// </summary>
		private const string Library = "opengl32.dll";

		/// <summary>
		/// Currently loaded libraries.
		/// </summary>
		private static readonly Dictionary<string, IntPtr> _LibraryHandles = new Dictionary<string,IntPtr>();

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on X11 platform.
	/// </summary>
	class GetProcAddressLinux : IGetProcAddressOS
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetGLProcAddressEGL"/> singleton instance.
		/// </summary>
		internal static readonly GetProcAddressLinux Instance = new GetProcAddressLinux();

		#endregion

		#region X11 Platform Imports

		unsafe static class UnsafeNativeMethods
		{
			public const int RTLD_NOW = 2;

			[DllImport("dl")]
			public static extern IntPtr dlopen([MarshalAs(UnmanagedType.LPTStr)] string filename, int flags);

			[DllImport("dl")]
			public static extern IntPtr dlsym(IntPtr handle, [MarshalAs(UnmanagedType.LPTStr)] string symbol);

			[DllImport("dl")]
			public static extern string dlerror();
		}

		#endregion

		#region IGetProcAdress Implementation

		/// <summary>
		/// Add a path of a directory as additional path for searching libraries.
		/// </summary>
		/// <param name="libraryDirPath">
		/// A <see cref="String"/> that specify the absolute path of the directory where the libraries are loaded using
		/// <see cref="GetProcAddress(string, string)"/> method.
		/// </param>
		public void AddLibraryDirectory(string libraryDirPath)
		{
			
		}

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
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
		/// A <see cref="IntPtr"/> which represents an opaque handle to the library containing the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		private IntPtr GetProcAddress(IntPtr library, string function)
		{
			if (library == IntPtr.Zero)
				throw new ArgumentNullException("library");
			if (function == null)
				throw new ArgumentNullException("function");

			return (UnsafeNativeMethods.dlsym(library, function));
		}

		internal static IntPtr GetLibraryHandle(string libraryPath)
		{
			return (GetLibraryHandle(libraryPath, true));
		}

		internal static IntPtr GetLibraryHandle(string libraryPath, bool throws)
		{
			IntPtr libraryHandle;

			if (_LibraryHandles.TryGetValue(libraryPath, out libraryHandle) == false) {
				if ((libraryHandle = UnsafeNativeMethods.dlopen(libraryPath, UnsafeNativeMethods.RTLD_NOW)) == IntPtr.Zero) {
					if (throws)
						throw new InvalidOperationException(String.Format("unable to load library at {0}", libraryPath), new InvalidOperationException(UnsafeNativeMethods.dlerror()));
				}
					
				_LibraryHandles.Add(libraryPath, libraryHandle);
			}

			return (libraryHandle);
		}

		/// <summary>
		/// Currently loaded libraries.
		/// </summary>
		private static readonly Dictionary<string, IntPtr> _LibraryHandles = new Dictionary<string,IntPtr>();

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on OSX platform.
	/// </summary>
	class GetProcAddressOSX : IGetProcAddressOS, IGetGLProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetProcAddressOSX"/> singleton instance.
		/// </summary>
		public static readonly GetProcAddressOSX Instance = new GetProcAddressOSX();

		#endregion

		#region OSX Platform Imports

		unsafe static class UnsafeNativeMethods
		{
			[DllImport(Library, EntryPoint = "NSIsSymbolNameDefined")]
			public static extern bool NSIsSymbolNameDefined(string s);

			[DllImport(Library, EntryPoint = "NSLookupAndBindSymbol")]
			public static extern IntPtr NSLookupAndBindSymbol(string s);

			[DllImport(Library, EntryPoint = "NSAddressOfSymbol")]
			public static extern IntPtr NSAddressOfSymbol(IntPtr symbol);
		}

		#endregion

		#region IGetProcAddress Implementation

		/// <summary>
		/// Add a path of a directory as additional path for searching libraries.
		/// </summary>
		/// <param name="libraryDirPath">
		/// A <see cref="String"/> that specify the absolute path of the directory where the libraries are loaded using
		/// <see cref="GetProcAddress(string, string)"/> method.
		/// </param>
		public void AddLibraryDirectory(string libraryDirPath)
		{
			
		}

		/// <summary>
		/// Get a function pointer from a library, specified by path.
		/// </summary>
		/// <param name="library">
		/// A <see cref="String"/> that specifies the path of the library defining the function.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string library, string function)
		{
			return (GetProcAddressCore(function));
		}

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddressCore(string function)
		{
			string fname = "_" + function;
			if (!UnsafeNativeMethods.NSIsSymbolNameDefined(fname))
				return IntPtr.Zero;

			IntPtr symbol = UnsafeNativeMethods.NSLookupAndBindSymbol(fname);
			if (symbol != IntPtr.Zero)
				symbol = UnsafeNativeMethods.NSAddressOfSymbol(symbol);

			return (symbol);
		}

		/// <summary>
		/// The OpenGL library on OSX platform.
		/// </summary>
		private const string Library = "libdl.dylib";

		#endregion

		#region IGetGLProcAddress Implementation

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>. If not
		/// defined, it returns <see cref="IntPtr.Zero"/>.
		/// </returns>
		public IntPtr GetProcAddress(string function)
		{
			return (GetProcAddressCore(function));
		}

		#endregion
	}
}
