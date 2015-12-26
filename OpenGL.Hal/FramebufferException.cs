using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Exception representing errors relative to <see cref="Framebuffer"/>.
	/// </summary>
	public sealed class FramebufferException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a FramebufferException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		public FramebufferException(int errorCode) :
			base(errorCode, GetErrorMessage(errorCode))
		{

		}

		/// <summary>
		/// Construct a FramebufferException.
		/// </summary>
		/// <param name="errorCode">
		/// A <see cref="Int32"/> that specifies the error code.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		public FramebufferException(int errorCode, String message) :
			base(errorCode, message)
		{

		}

		/// <summary>
		/// Construct a FramebufferException.
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
		public FramebufferException(int errorCode, String message, Exception innerException) :
			base(errorCode, message, innerException)
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
		/// by <see cref="Gl.CheckFramebufferStatus"/> with <see cref="Gl.FRAMEBUFFER"/> as parameter.
		/// </returns>
		private static string GetErrorMessage(int errorCode)
		{
			switch (errorCode) {

				default:
					return (String.Format("unknown error code 0x{0}", errorCode.ToString("X8")));

				case Gl.FRAMEBUFFER_COMPLETE:
					return ("no error");

				case Gl.FRAMEBUFFER_UNDEFINED:
					return ("framebuffer undefined");
				case Gl.FRAMEBUFFER_INCOMPLETE_ATTACHMENT:
					return ("framebuffer incomplete attachment");
				case Gl.FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT:
					return ("framebuffer incomplete missing attachment");
				case Gl.FRAMEBUFFER_INCOMPLETE_READ_BUFFER:
					return ("framebuffer incomplete read buffer");
				case Gl.FRAMEBUFFER_UNSUPPORTED:
					return ("framebuffer unsupported");
				case Gl.FRAMEBUFFER_INCOMPLETE_MULTISAMPLE:
					return ("framebuffer incomplete multisample");
				case Gl.FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS:
					return ("framebuffer incomplete layer targets");
			}
		}

		#endregion
	}
}
