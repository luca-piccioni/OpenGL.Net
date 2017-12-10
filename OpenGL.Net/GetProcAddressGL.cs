
// Copyright (C) 2017 Luca Piccioni
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
using System.Runtime.InteropServices;

using Khronos;

// ReSharper disable InheritdocConsiderUsage
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable RedundantIfElseBlock
// ReSharper disable InconsistentNaming

namespace OpenGL
{
	/// <summary>
	/// Interface implemented by those classes which are able to get OpenGK function pointers.
	/// </summary>
	internal interface IGetGLProcAddress
	{
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
		IntPtr GetProcAddress(string function);
	}

	/// <summary>
	/// Abtract an interface for loading OpenGL commands.
	/// </summary>
	internal static class GetProcAddressGL
	{
		#region Abstract Interface

		/// <summary>
		/// Get the most appropriate <see cref="IGetProcAddressOS"/> for for loading OpenGL functions.
		/// </summary>
		public static IntPtr GetProcAddress(string function)
		{
#if !MONODROID
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return GetGLProcAddressWGL.Instance.GetProcAddress(function);
					case Platform.Id.Linux:
						return GetGLProcAddressGLX.Instance.GetProcAddress(function);
					case Platform.Id.MacOS:
						return !Glx.IsRequired ? GetProcAddressOSX.Instance.GetProcAddress(function) : GetGLProcAddressGLX.Instance.GetProcAddress(function);
					default:
						throw new NotSupportedException();
				}
			} else
				return GetGLProcAddressEGL.Instance.GetProcAddress(function);
#else
			return (GetGLProcAddressEGL.Instance.GetProcAddress(function));
#endif
		}

		#endregion
	}

	/// <summary>
	/// Class able to get OpenGL function pointers on Windows platform.
	/// </summary>
	internal class GetGLProcAddressWGL : IGetGLProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetGLProcAddressEGL"/> singleton instance.
		/// </summary>
		public static readonly GetGLProcAddressWGL Instance = new GetGLProcAddressWGL();

		#endregion

		#region Windows Platform Imports

		private static class UnsafeNativeMethods
		{
			[DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
			public static extern IntPtr wglGetProcAddress(string lpszProc);
		}

		#endregion

		#region IGetGLProcAddress Implementation

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string function)
		{
			IntPtr procAddress = UnsafeNativeMethods.wglGetProcAddress(function);
#if PLATFORM_LOG_ENABLED
			KhronosApi.LogFunction("wglGetProcAddress({0}) = 0x{1}", function, procAddress.ToString("X8"));
#endif

			return procAddress;
		}

		/// <summary>
		/// The OpenGL library on Windows platform.
		/// </summary>
		private const string Library = "opengl32.dll";

		#endregion
	}

	/// <summary>
	/// Class able to get OpenGL function pointers on X11 platform.
	/// </summary>
	internal class GetGLProcAddressGLX : IGetGLProcAddress
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static GetGLProcAddressGLX()
		{
			IntPtr functionPtr = GetProcAddressOS.GetProcAddress(Library, "glXGetProcAddress");
			if (functionPtr != IntPtr.Zero)
				Delegates.pglXGetProcAddress = (Delegates.glXGetProcAddress)Marshal.GetDelegateForFunctionPointer(functionPtr, typeof(Delegates.glXGetProcAddress));
		}

		#endregion

		#region Singleton

		/// <summary>
		/// The <see cref="GetGLProcAddressGLX"/> singleton instance.
		/// </summary>
		internal static readonly GetGLProcAddressGLX Instance = new GetGLProcAddressGLX();

		#endregion

		#region X11 Platform Imports

		private static class Delegates
		{
			[RequiredByFeature("GLX_VERSION_1_4")]
			public delegate IntPtr glXGetProcAddress(string procName);

			public static glXGetProcAddress pglXGetProcAddress;
		}

		#endregion

		#region IGetProcAdress Implementation

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string function)
		{
			return Delegates.pglXGetProcAddress != null ? Delegates.pglXGetProcAddress(function) : IntPtr.Zero;
		}

		/// <summary>
		/// The OpenGL library on Unix/Linux platforms.
		/// </summary>
		private const string Library = "libGL.so.1";

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on different platforms supporting EGL.
	/// </summary>
	internal class GetGLProcAddressEGL : IGetGLProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetGLProcAddressEGL"/> singleton instance.
		/// </summary>
		public static readonly GetGLProcAddressEGL Instance = new GetGLProcAddressEGL();

		#endregion

		#region IGetGLProcAddress Implementation

		/// <summary>
		/// Get a function pointer from the OpenGL driver.
		/// </summary>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the function name.
		/// </param>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that specifies the address of the function <paramref name="function"/>.
		/// </returns>
		public IntPtr GetProcAddress(string function)
		{
			return GetProcAddressCore(function);
		}

		/// <summary>
		/// Static import for eglGetProcAddress.
		/// </summary>
		/// <param name="funcname"></param>
		/// <returns></returns>
		[DllImport("libEGL.dll", EntryPoint = "eglGetProcAddress")]
		public static extern IntPtr GetProcAddressCore(string funcname);

		#endregion
	}

	/// <summary>
	/// Class able to get function pointers on OSX platform.
	/// </summary>
	internal class GetGLProcAddressOSX : IGetGLProcAddress
	{
		#region Singleton

		/// <summary>
		/// The <see cref="GetProcAddressOSX"/> singleton instance.
		/// </summary>
		public static readonly GetProcAddressOSX Instance = new GetProcAddressOSX();

		#endregion

		#region OSX Platform Imports

		private static class UnsafeNativeMethods
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
			return GetProcAddressCore(function);
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

			return symbol;
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
			return GetProcAddressCore(function);
		}

		#endregion
	}
}
