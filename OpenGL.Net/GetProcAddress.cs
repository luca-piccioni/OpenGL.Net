
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Abtract an interface for interoperating with dynamically loaded libraries.
	/// </summary>
	internal static class GetProcAddress
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GetProcAddress()
		{
			_GetProcAddressOS = CreateOS();
		}

		#endregion

		#region Singleton Factory

		/// <summary>
		/// Get the most appropriate <see cref="IGetProcAddress"/> for the current platform.
		/// </summary>
		public static IGetProcAddress GetProcAddressOS { get { return (_GetProcAddressOS); } }

		/// <summary>
		/// Most appropriate <see cref="IGetProcAddress"/> for the current platform.
		/// </summary>
		private static readonly IGetProcAddress _GetProcAddressOS;

		/// <summary>
		/// Create an <see cref="IGetProcAddress"/> for the hosting platform.
		/// </summary>
		/// <returns>
		/// It returns the most appropriate <see cref="IGetProcAddress"/> for the current platform.
		/// </returns>
		private static IGetProcAddress CreateOS()
		{
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					return new GetProcAddressWindows();
				case Platform.Id.Linux:
					return new GetProcAddressX11();
				case Platform.Id.MacOS:
					return new GetProcAddressOSX();
				case Platform.Id.Android:
					return new GetProcAddressEgl();
				default:
					throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
			}
		}

		/// <summary>
		/// Get the most appropriate <see cref="IGetProcAddress"/> for for loading OpenGL functions.
		/// </summary>
		public static IGetProcAddress GetProcAddressGL
		{
			get
			{
				if (Egl.IsRequired == false) {
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.MacOS:
							if (Glx.IsRequired)
								return (GetProcAddressX11.Instance);
							else
								return (_GetProcAddressOS);
						default:
								return (_GetProcAddressOS);
					}
				} else
					return (GetProcAddressEgl.Instance);
			}
		}

		#endregion
	}

	/// <summary>
	/// Interface implemented by those classes which are able to get function pointers from dynamically loaded libraries.
	/// </summary>
	internal interface IGetProcAddress
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
		IntPtr GetProcAddress(IntPtr library, string function);

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		IntPtr GetOpenGLProcAddress(string function);
	}

	/// <summary>
	/// Class able to get function pointers on Windows platform.
	/// </summary>
	internal class GetProcAddressWindows : IGetProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetProcAddressEgl"/> singleton instance.
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

			[DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
			public static extern IntPtr wglGetProcAddress(String lpszProc);
		}

		#endregion

		#region IGetProceAddress Implementation

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
		public IntPtr GetProcAddress(IntPtr library, string function)
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
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetOpenGLProcAddress(string function)
		{
			IntPtr procAddress = UnsafeNativeMethods.wglGetProcAddress(function);
#if PLATFORM_LOG_ENABLED
			KhronosApi.LogFunction("wglGetProcAddress({0}) = 0x{1}", function, procAddress.ToString("X8"));
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
	internal class GetProcAddressX11 : IGetProcAddress
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GetProcAddressX11()
		{
			// Library libGL.so.1 is optional
			IntPtr libHandle = GetLibraryHandle(Library, false);
			if (libHandle != IntPtr.Zero) {
				IntPtr functionPtr = UnsafeNativeMethods.dlsym(libHandle, "glXGetProcAddress");
				if (functionPtr != null)
					Delegates.pglXGetProcAddress = (Delegates.glXGetProcAddress)Marshal.GetDelegateForFunctionPointer(functionPtr, typeof(Delegates.glXGetProcAddress));
			}
		}

		#endregion

		#region Singleton

		/// <summary>
		/// The <see cref="GetProcAddressEgl"/> singleton instance.
		/// </summary>
		internal static readonly GetProcAddressX11 Instance = new GetProcAddressX11();

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

		unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_VERSION_1_4")]
			public unsafe delegate IntPtr glXGetProcAddress(string procName);

			public static glXGetProcAddress pglXGetProcAddress;
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
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			if (library == IntPtr.Zero)
				throw new ArgumentNullException("library");
			if (function == null)
				throw new ArgumentNullException("function");

			return (UnsafeNativeMethods.dlsym(library, function));
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
		public IntPtr GetOpenGLProcAddress(string function)
		{
			if (Delegates.pglXGetProcAddress != null)
				return (Delegates.pglXGetProcAddress(function));
			else
				return (IntPtr.Zero);
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
		/// The OpenGL library on Unix/Linux platforms.
		/// </summary>
		private const string Library = "libGL.so.1";

		/// <summary>
		/// Currently loaded libraries.
		/// </summary>
		private static readonly Dictionary<string, IntPtr> _LibraryHandles = new Dictionary<string,IntPtr>();

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on OSX platform.
	/// </summary>
	internal class GetProcAddressOSX : IGetProcAddress
	{
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
			return (GetOpenGLProcAddress(function));
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
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			return (GetOpenGLProcAddress(function));
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
		public IntPtr GetOpenGLProcAddress(string function)
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
	}

	/// <summary>
	/// Class able to get function pointers on different platforms supporting EGL.
	/// </summary>
	internal class GetProcAddressEgl : IGetProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetProcAddressEgl"/> singleton instance.
		/// </summary>
		public static readonly IGetProcAddress Instance = new GetProcAddressEgl();

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
			return (GetProcAddress(function));
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
		public IntPtr GetProcAddress(IntPtr library, string function)
		{
			return (GetProcAddress(function));
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
		public IntPtr GetOpenGLProcAddress(string function)
		{
			return (GetProcAddress(function));
		}

		/// <summary>
		/// Static import for eglGetProcAddress.
		/// </summary>
		/// <param name="funcname"></param>
		/// <returns></returns>
		[DllImport(Egl.Library, EntryPoint = "eglGetProcAddress")]
		public static extern IntPtr GetProcAddress(string funcname);

		#endregion
	}
}
