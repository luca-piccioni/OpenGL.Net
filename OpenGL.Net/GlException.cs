
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
	/// Exception thrown by Gl class.
	/// </summary>
	public sealed class GlException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a GlException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		public GlException(ErrorCode errorCode) :
			base((int)errorCode, GetErrorMessage(errorCode))
		{
			
		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		/// <returns>
		/// It returns a description of <paramref name="errorCode"/>, asssuming that is a value returned
		/// by <see cref="Egl.GetError"/>.
		/// </returns>
		private static string GetErrorMessage(ErrorCode errorCode)
		{
			switch (errorCode) {

				default:
					return $"unknown error code {errorCode}";
				case OpenGL.ErrorCode.NoError:
					return "no error";
				case OpenGL.ErrorCode.InvalidEnum:
					return "invalid enumeration";
				case OpenGL.ErrorCode.InvalidFramebufferOperation:
					return "invalid framebuffer operation";
				case OpenGL.ErrorCode.InvalidOperation:
					return "invalid operation";
				case OpenGL.ErrorCode.InvalidValue:
					return "invalid value";
				case OpenGL.ErrorCode.OutOfMemory:
					return "out of memory";
				case OpenGL.ErrorCode.StackOverflow:
					return "stack overflow";
				case OpenGL.ErrorCode.StackUnderflow:
					return "stack underflow";

				// GL_ARB_imaging
				case OpenGL.ErrorCode.TableTooLarge:
					return "table too large";
				// GL_EXT_texture
				case OpenGL.ErrorCode.TextureTooLargeExt:
					return "texture too large";
			}
		}

		#endregion
	}
}
