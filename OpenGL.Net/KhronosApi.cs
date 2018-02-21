
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

// Preprocessor symbol for enabling function logging output
#undef DEBUG_VERBOSE

using System;

// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <summary>
	/// Base class for loading external routines in OpenGL.Net.
	/// </summary>
	public class KhronosApi : Khronos.KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static KhronosApi()
		{
#if !NETSTANDARD1_1
			EnvDebug = Environment.GetEnvironmentVariable("OPENGL_NET_DEBUG") != null;
			EnvExperimental = Environment.GetEnvironmentVariable("OPENGL_NET_EXPERIMENTAL") != null;
#endif
		}

		#endregion

		#region Options

		/// <summary>
		/// Debug environment.
		/// </summary>
		protected static readonly bool EnvDebug;

		/// <summary>
		/// Experimental environment.
		/// </summary>
		protected static readonly bool EnvExperimental;

		#endregion

		#region Platform Initialization

		/// <summary>
		/// Platform initialization. Executed only once before everything else.
		/// </summary>
		public static event EventHandler<EglEventArgs> EglInitializing;

		/// <summary>
		/// Raise the <see cref="EglInitializing"/>.
		/// </summary>
		/// <param name="e">
		/// 
		/// </param>
		protected static void RaiseEglInitializing(EglEventArgs e)
		{
			EglInitializing?.Invoke(null, e);
		}

		#endregion

		#region GL Function Linkage

		/// <summary>
		/// Utility for <see cref="GetAddressDelegate"/> for loading procedures using the GL loader.
		/// </summary>
		/// <param name="path">
		/// Ignored parameter.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the name of the procedure to be loaded.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IntPtr"/> that specifies the function pointer. If not defined, it
		/// returns <see cref="IntPtr.Zero"/>.
		/// </returns>
		protected static IntPtr GetProcAddressGL(string path, string function) { return OpenGL.GetProcAddressGL.GetProcAddress(function); }

		/// <summary>
		/// Utility for <see cref="GetAddressDelegate"/> for loading procedures using the GL loader, and eventually with the OS
		/// loader.
		/// </summary>
		/// <param name="path">
		/// Ignored parameter.
		/// </param>
		/// <param name="function">
		/// A <see cref="String"/> that specifies the name of the procedure to be loaded.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IntPtr"/> that specifies the function pointer. If not defined, it
		/// returns <see cref="IntPtr.Zero"/>.
		/// </returns>
		protected static IntPtr GetProcAddressGLOS(string path, string function)
		{
			IntPtr funcPtr = OpenGL.GetProcAddressGL.GetProcAddress(function);
			
			// Fallback to OS loader in case GL loader is unable to load function pointer
			// Note: on AppVeyor seems that wglGetProcAddress is unable to load function pointers
			if (funcPtr == IntPtr.Zero)
				funcPtr = Khronos.GetProcAddressOS.GetProcAddress(path, function);

			return funcPtr;
		}

		#endregion
	}
}
