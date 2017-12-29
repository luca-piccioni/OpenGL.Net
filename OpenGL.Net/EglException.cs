
// Copyright (C) 2015-2017 Luca Piccioni
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

using System;

using Khronos;

// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <summary>
	/// Exception thrown by Egl class.
	/// </summary>
	public sealed class EglException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a EglException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		internal EglException(int errorCode) :
			base(errorCode, GetErrorMessage(errorCode))
		{

		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <returns>
		/// It returns a description of <paramref name="errorCode"/>.
		/// </returns>
		private static string GetErrorMessage(int errorCode)
		{
			switch (errorCode) {

				default:
					return $"unknown error code 0x{errorCode:X8}";
				case Egl.SUCCESS:
					return "no error";

				case Egl.NOT_INITIALIZED:
					return "EGL is not initialized, or could not be initialized, for the specified EGL display connection";
				case Egl.BAD_ACCESS:
					return "EGL cannot access a requested resource";
				case Egl.BAD_ALLOC:
					return "EGL failed to allocate resources for the requested operation";
				case Egl.BAD_ATTRIBUTE:
					return "an unrecognized attribute or attribute value was passed in the attribute list";
				case Egl.BAD_CONTEXT:
					return "an EGLContext argument does not name a valid EGL rendering context";
				case Egl.BAD_CONFIG:
					return "an EGLConfig argument does not name a valid EGL frame buffer configuration";
				case Egl.BAD_CURRENT_SURFACE:
					return "the current surface of the calling thread is a window, pixel buffer or pixmap that is no longer valid";
				case Egl.BAD_DISPLAY:
					return "an EGLDisplay argument does not name a valid EGL display connection";
				case Egl.BAD_SURFACE:
					return "an EGLSurface argument does not name a valid surface configured for GL rendering";
				case Egl.BAD_MATCH:
					return "arguments are inconsistent";
				case Egl.BAD_PARAMETER:
					return "one or more argument values are invalid";
				case Egl.BAD_NATIVE_PIXMAP:
					return "a NativePixmapType argument does not refer to a valid native pixmap";
				case Egl.BAD_NATIVE_WINDOW:
					return "a NativeWindowType argument does not refer to a valid native window";
				case Egl.CONTEXT_LOST:
					return "a power management event has occurred";
			}
		}

		#endregion
	}
}
