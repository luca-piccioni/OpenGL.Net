
//  Copyright (C) 2009-2015 Luca Piccioni
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.ComponentModel;

namespace OpenGL
{
	/// <summary>
	/// Exception thrown from class used for rendering operations.
	/// </summary>
	public class GraphicsException : InvalidOperationException
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderException specifying the error code.
		/// </summary>
		/// <param name="err">
		/// A <see cref="Int32"/> that specifies the error code (code returned by <see cref="Gl.GetError"/>).
		/// </param>
		public GraphicsException(int err)
		{
			_ErrCode = err;
		}

		/// <summary>
		/// Construct a RenderException specifying the error code and a message.
		/// </summary>
		/// <param name="message">
		/// A <see cref="System.String"/> that specifies an additional message.
		/// </param>
		public GraphicsException(string message)
			: base(message)
		{
			
		}

		/// <summary>
		/// Construct a RenderException specifying the error code and a message.
		/// </summary>
		/// <param name="err">
		/// A <see cref="Int32"/> that specifies the error code (code returned by <see cref="Gl.GetError"/>).
		/// </param>
		/// <param name="message">
		/// A <see cref="System.String"/> that specifies an additional message.
		/// </param>
		public GraphicsException(int err, string message)
			: base(message)
		{
			_ErrCode = err;
		}

		/// <summary>
		/// Construct a RenderException specifying the inner exceptiopn.
		/// </summary>
		/// <param name="message">
		/// A <see cref="System.String"/> that specifies the exception message.
		/// </param>
		/// <param name="innerException">
		/// A <see cref="Exception"/> that represents the inner eception that has caused the exception raising.
		/// </param>
		public GraphicsException(string message, Exception innerException)
			: base(message, innerException)
		{
			
		}

		#endregion

		#region OpenGL Error Code

		/// <summary>
		/// Throw a a GraphicsException on error code.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code defining the exception thrown.
		/// </param>
		/// <exception cref="GraphicsException">
		/// Exception thrown if <paramref name="errorCode"/> is a value different from <see cref="Gl.NO_ERROR"/>.
		/// </exception>
		public static void Throw(int errorCode)
		{
			switch (errorCode) {

				default:
					throw new GraphicsException(errorCode, "unknown error 0x" + errorCode.ToString("X8"));

				case Gl.NO_ERROR:
				case Gl.FRAMEBUFFER_COMPLETE:
					// No exception
					return;

				case Gl.INVALID_ENUM:
					throw new GraphicsException(errorCode, "invalid enumeration");
				case Gl.INVALID_FRAMEBUFFER_OPERATION:
					throw new GraphicsException(errorCode, "invalid framebuffer operation");
				case Gl.INVALID_OPERATION:
					throw new GraphicsException(errorCode, "invalid operation on OpenGL call");
				case Gl.INVALID_VALUE:
					throw new GraphicsException(errorCode, "invalid value");
				case Gl.OUT_OF_MEMORY:
					throw new GraphicsException(errorCode, "out of memory");
				case Gl.STACK_OVERFLOW:
					throw new GraphicsException(errorCode, "stack overflow");
				case Gl.STACK_UNDERFLOW:
					throw new GraphicsException(errorCode, "stack underflow");

				// GL_ARB_imaging
				case Gl.TABLE_TOO_LARGE:
					throw new GraphicsException(errorCode, "table too large");
				// GL_EXT_texture
				case Gl.TEXTURE_TOO_LARGE_EXT:
					throw new GraphicsException(errorCode, "texture too large");

				// WGL_ARB_create_context
				case Wgl.ERROR_INVALID_VERSION_ARB:
					throw new GraphicsException(errorCode, "invalid version");
				// WGL_ARB_create_context_profile
				case Wgl.ERROR_INVALID_PROFILE_ARB:
					throw new GraphicsException(errorCode, "invalid profile");
				// WGL_ARB_make_current_read
				case Wgl.ERROR_INVALID_PIXEL_TYPE_ARB:
					throw new GraphicsException(errorCode, "invalid pixel type");
				case Wgl.ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB:
					throw new GraphicsException(errorCode, "incompatible device contexts");
				// WGL_NV_gpu_affinity
				case Wgl.ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV:
					throw new GraphicsException(errorCode, "incompatible affinity mask");
				case Wgl.ERROR_MISSING_AFFINITY_MASK_NV:
					throw new GraphicsException(errorCode, "missing affinity mask");

				// Framebuffer errors
				case Gl.FRAMEBUFFER_UNDEFINED:
					throw new GraphicsException(errorCode, "framebuffer undefined");
				case Gl.FRAMEBUFFER_INCOMPLETE_ATTACHMENT:
					throw new GraphicsException(errorCode, "framebuffer incomplete attachment");
				case Gl.FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT:
					throw new GraphicsException(errorCode, "framebuffer incomplete missing attachment");
				case Gl.FRAMEBUFFER_INCOMPLETE_READ_BUFFER:
					throw new GraphicsException(errorCode, "framebuffer incomplete read buffer");
				case Gl.FRAMEBUFFER_UNSUPPORTED:
					throw new GraphicsException(errorCode, "framebuffer unsupported");
				case Gl.FRAMEBUFFER_INCOMPLETE_MULTISAMPLE:
					throw new GraphicsException(errorCode, "framebuffer incomplete multisample");
				case Gl.FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS:
					throw new GraphicsException(errorCode, "framebuffer incomplete layer targets");
			}
		}

		/// <summary>
		/// Exception error code.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This error code represent the actual numeric value returned by a GL function.
		/// </para>
		/// <para>
		/// The sources of error codes are:
		/// - glGetError
		/// - glCheckFramebufferStatus
		/// - 
		/// - GetLastError
		/// </para>
		/// </remarks>
		public int Code
		{
			get { return (_ErrCode); }
		}

		/// <summary>
		/// OpenGL error code.
		/// </summary>
		private readonly int _ErrCode;

		#endregion
	}
}
