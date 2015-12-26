
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
using System.ComponentModel;

namespace OpenGL
{
	/// <summary>
	/// Exception thrown by Egl class.
	/// </summary>
	class EglException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a EglException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		public EglException(int errorCode) :
			base(errorCode, GetErrorMessage(errorCode))
		{

		}

		/// <summary>
		/// Construct a EglException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		public EglException(int errorCode, String message) :
			base(errorCode, message)
		{

		}

		/// <summary>
		/// Construct a EglException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		/// <param name="innerException">
		/// The <see cref="Exception"/> wrapped by this Exception.
		/// </param>
		public EglException(int errorCode, String message, Exception innerException) :
			base(errorCode, message, innerException)
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
					return (String.Format("unknown error code 0x{0}", errorCode.ToString("X8")));
				case Egl.SUCCESS:
					return ("no error");

				case Egl.NOT_INITIALIZED:
					return ("EGL is not initialized, or could not be initialized, for the specified EGL display connection");
				case Egl.BAD_ACCESS:
					return ("EGL cannot access a requested resource");
				case Egl.BAD_ALLOC:
					return ("EGL failed to allocate resources for the requested operation");
				case Egl.BAD_ATTRIBUTE:
					return ("an unrecognized attribute or attribute value was passed in the attribute list");
				case Egl.BAD_CONTEXT:
					return ("an EGLContext argument does not name a valid EGL rendering context");
				case Egl.BAD_CONFIG:
					return ("an EGLConfig argument does not name a valid EGL frame buffer configuration");
				case Egl.BAD_CURRENT_SURFACE:
					return ("the current surface of the calling thread is a window, pixel buffer or pixmap that is no longer valid");
				case Egl.BAD_DISPLAY:
					return ("an EGLDisplay argument does not name a valid EGL display connection");
				case Egl.BAD_SURFACE:
					return ("an EGLSurface argument does not name a valid surface configured for GL rendering");
				case Egl.BAD_MATCH:
					return ("arguments are inconsistent");
                case Egl.BAD_PARAMETER:
					return ("one or more argument values are invalid");
				case Egl.BAD_NATIVE_PIXMAP:
					return ("a NativePixmapType argument does not refer to a valid native pixmap");
				case Egl.BAD_NATIVE_WINDOW:
					return ("a NativeWindowType argument does not refer to a valid native window");
				case Egl.CONTEXT_LOST:
					return ("a power management event has occurred");
			}
		}

		#endregion
	}
}
