
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Exception thrown from class used for rendering operations.
	/// </summary>
	public class GraphicsException : Exception
	{
		#region Constructors

		/// <summary>
		/// Construct a RenderException specifying the error code.
		/// </summary>
		/// <param name="err">
		/// A <see cref="ErrorCode"/> that specifies the error code (code returned by <see cref="Gl.GetError"/>).
		/// </param>
		public GraphicsException(ErrorCode err)
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
		/// A <see cref="ErrorCode"/> that specifies the error code (code returned by <see cref="Gl.GetError"/>).
		/// </param>
		/// <param name="message">
		/// A <see cref="System.String"/> that specifies an additional message.
		/// </param>
		public GraphicsException(ErrorCode err, string message)
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

		#region Error Detection
		
		/// <summary>
		/// Check for OpenGL errors.
		/// </summary>
		/// <exception cref="GraphicsException">
		/// Exception thrown in the case OpenGL error has been detected by last check.
		/// </exception>
		public static bool CheckErrors()
		{
			return (CheckErrors(true));
		}

		/// <summary>
		/// Check for OpenGL errors.
		/// </summary>
		/// <exception cref="GraphicsException">
		/// Exception thrown in the case OpenGL error has been detected by last check.
		/// </exception>
		public static bool CheckErrors(bool throwOnErrors)
		{
			ErrorCode err;

			// Question: shall GetError be executed in a loop?

			if ((err = Gl.GetError()) != (ErrorCode)Gl.NO_ERROR) {
				
				switch (err) {
					case ErrorCode.InvalidEnum:
						ProcLoader.LogComment("glGetError() = INVALID_ENUM (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid enumeration on OpenGL call argument");
						return (true);
					case ErrorCode.InvalidValue:
						ProcLoader.LogComment("glGetError() = INVALID_VALUE (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid value on OpenGL call argument");
						return (true);
					case ErrorCode.InvalidOperation:
						ProcLoader.LogComment("glGetError() = INVALID_OPERATION (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid operation on OpenGL call");
						return (true);
					case ErrorCode.OutOfMemory:
						ProcLoader.LogComment("glGetError() = OUT_OF_MEMORY (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "out of memory on OpenGL call");
						return (true);
					case ErrorCode.InvalidFramebufferOperation:
						ProcLoader.LogComment("glGetError() = INVALID_FRAMEBUFFER_OPERATION (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid framebuffer operation OpenGL  call");
						return (true);
					
					case (ErrorCode)Wgl.ERROR_INVALID_PIXEL_TYPE_ARB:
						ProcLoader.LogComment("glGetError() = ERROR_INVALID_PIXEL_TYPE_ARB (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid pixel type");
						return (true);
					case (ErrorCode)Wgl.ERROR_INVALID_PROFILE_ARB:
						ProcLoader.LogComment("glGetError() = ERROR_INVALID_PROFILE_ARB (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid profile");
						return (true);
					case (ErrorCode)Wgl.ERROR_INVALID_VERSION_ARB:
						ProcLoader.LogComment("glGetError() = ERROR_INVALID_VERSION_ARB (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "invalid version");
						return (true);
					case (ErrorCode)Wgl.ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB:
						ProcLoader.LogComment("glGetError() = ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB (!)");
						if (throwOnErrors)
							throw new GraphicsException(err, "incompatible device contexts");
						return (true);
	
					default:
						ProcLoader.LogComment("glGetError() = 0x{0} (!)", err.ToString("X"));
						throw new GraphicsException(err, "unknown error 0x"+err.ToString("X"));
						return (true);
				}
			} else
				return (false);
		}

		/// <summary>
		/// Checks for OpenGL platform errors.
		/// </summary>
		public static Win32Exception CheckPlatformErrors(IDeviceContext deviceContext)
		{
			return (CheckPlatformErrors(deviceContext, true));
		}

		/// <summary>
		/// Checks for OpenGL platform errors.
		/// </summary>
		public static Win32Exception CheckPlatformErrors(IDeviceContext deviceContext, bool throwOnError)
		{
			Win32Exception platformException = (Win32Exception)Gl.GetPlatformException(deviceContext);

			if ((platformException != null) && (throwOnError == true))
				throw platformException;

			return (platformException);
		}

		/// <summary>
		/// Check for OpenGL errors (debug only).
		/// </summary>
		[Conditional("DEBUG")]
		public static void DebugCheckErrors()
		{
			// Check for errors
			CheckErrors();
		}

		/// <summary>
		/// Check for OpenGL platform errors (debug only).
		/// </summary>
		[Conditional("DEBUG")]
		public static void DebugCheckPlatformErrors(IDeviceContext deviceContext)
		{
			CheckPlatformErrors(deviceContext);
		}

		#endregion

		#region Error Clearing

		/// <summary>
		/// Clear all pending OpenGL errors.
		/// </summary>
		public static void ClearErrors()
		{
			while (Gl.GetError() != Gl.NO_ERROR)
				;
		}

		#endregion

		#region OpenGL Error Code

		/// <summary>
		/// Exception error code.
		/// </summary>
		public ErrorCode Code
		{
			get { return (_ErrCode); }
		}

		/// <summary>
		/// OpenGL error code.
		/// </summary>
		private readonly ErrorCode _ErrCode;

		#endregion
	}
}
