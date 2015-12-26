
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
		public GlException(ErrorCode errorCode) :
			base((int)errorCode, GetErrorMessage((int)errorCode))
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
		public GlException(ErrorCode errorCode, String message) :
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
		public GlException(ErrorCode errorCode, String message, Exception innerException) :
			base((int)errorCode, message, innerException)
		{

		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="errorCode"></param>
		/// <returns>
		/// It returns a description of <paramref name="errorCode"/>, asssuming that is a value returned
		/// by <see cref="Gl.GetError"/>.
		/// </returns>
		private static string GetErrorMessage(int errorCode)
		{
			switch (errorCode) {

				default:
					return (String.Format("unknown error code 0x{0}", errorCode.ToString("X8")));
				case Gl.NO_ERROR:
					return ("no error");
				case Gl.INVALID_ENUM:
					return ("invalid enumeration");
				case Gl.INVALID_FRAMEBUFFER_OPERATION:
					return ("invalid framebuffer operation");
				case Gl.INVALID_OPERATION:
					return ("invalid operation");
				case Gl.INVALID_VALUE:
					return ("invalid value");
				case Gl.OUT_OF_MEMORY:
					return ("out of memory");
				case Gl.STACK_OVERFLOW:
					return ("stack overflow");
				case Gl.STACK_UNDERFLOW:
					return ("stack underflow");

				// GL_ARB_imaging
				case Gl.TABLE_TOO_LARGE:
					return ("table too large");
				// GL_EXT_texture
				case Gl.TEXTURE_TOO_LARGE_EXT:
					return ("texture too large");
			}
		}

		#endregion
	}
}
