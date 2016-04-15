
// Copyright (C) 2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Exception thrown by Gl class.
	/// </summary>
	public class GlException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a GlException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		internal GlException(ErrorCode errorCode) :
			base((int)errorCode, GetErrorMessage(errorCode))
		{

		}

		/// <summary>
		/// Construct a GlException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		internal GlException(ErrorCode errorCode, String message) :
			base((int)errorCode, message)
		{

		}

		/// <summary>
		/// Construct a GlException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="ErrorCode"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		/// <param name="innerException">
		/// The <see cref="Exception"/> wrapped by this Exception.
		/// </param>
		internal GlException(ErrorCode errorCode, String message, Exception innerException) :
			base((int)errorCode, GetErrorMessage(errorCode) + message, innerException)
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
					return (String.Format("unknown error code 0x{0}", errorCode.ToString("X8")));
				case ErrorCode.NoError:
					return ("no error");
				case ErrorCode.InvalidEnum:
					return ("invalid enumeration");
				case ErrorCode.InvalidFramebufferOperation:
					return ("invalid framebuffer operation");
				case ErrorCode.InvalidOperation:
					return ("invalid operation");
				case ErrorCode.InvalidValue:
					return ("invalid value");
				case ErrorCode.OutOfMemory:
					return ("out of memory");
				case ErrorCode.StackOverflow:
					return ("stack overflow");
				case ErrorCode.StackUnderflow:
					return ("stack underflow");

				// GL_ARB_imaging
				case ErrorCode.TableTooLarge:
					return ("table too large");
				// GL_EXT_texture
				case ErrorCode.TextureTooLargeExt:
					return ("texture too large");
			}
		}

		#endregion
	}
}
