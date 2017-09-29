
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
using System.ComponentModel;
using System.Text;

using Khronos;

namespace OpenGL
{
	/// <summary>
	/// Exception thrown by Glx class.
	/// </summary>
	class GlxException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a GlxException.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		public GlxException(IntPtr displayHandle, ref Glx.XErrorEvent error_event) :
			base(error_event.error_code, GetErrorMessage(displayHandle, ref error_event), new Win32Exception(error_event.error_code, GetErrorMessage(displayHandle, ref error_event)))
		{

		}

		/// <summary>
		/// Construct a GlxException.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		public GlxException(IntPtr displayHandle, ref Glx.XErrorEvent error_event, String message) :
			base(error_event.error_code, message, new Win32Exception(error_event.error_code, GetErrorMessage(displayHandle, ref error_event)))
		{

		}

		/// <summary>
		/// Construct a GlxException.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <param name="message">
		/// A <see cref="String"/> that specifies the exception message.
		/// </param>
		/// <param name="innerException">
		/// The <see cref="Exception"/> wrapped by this Exception.
		/// </param>
		public GlxException(IntPtr displayHandle, ref Glx.XErrorEvent error_event, String message, Exception innerException) :
			base(error_event.error_code, message, innerException)
		{

		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="DisplayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <returns>
		/// It returns a description of <paramref name="error_event"/>.
		/// </returns>
		private static string GetErrorMessage(IntPtr DisplayHandle, ref Glx.XErrorEvent error_event)
		{
			StringBuilder sb = new StringBuilder(1024);
			Glx.UnsafeNativeMethods.XGetErrorText(DisplayHandle, error_event.error_code, sb, 1024);

			string eventName = Enum.GetName(typeof(Glx.XEventName), error_event.type);
			string requestName = Enum.GetName(typeof(Glx.XRequest), error_event.request_code);

			if (String.IsNullOrEmpty(eventName))
				eventName = "Unknown";
			if (String.IsNullOrEmpty(requestName))
				requestName = "Unknown";

			// Additional details
			sb.AppendLine("\nX error details:");
			sb.AppendFormat("	X event name: '{0}' ({1})\n", eventName, error_event.type);
			sb.AppendFormat("	Display: 0x{0}\n", error_event.display.ToInt64().ToString("x"));
			sb.AppendFormat("	Resource ID: {0}\n", error_event.resourceid.ToInt64().ToString("x"));
			sb.AppendFormat("	Error code: {0}\n", error_event.error_code);
			sb.AppendFormat("	Major code: '{0}' ({1})\n", requestName, error_event.request_code);
			sb.AppendFormat("	Minor code: {0}", error_event.minor_code);

			return (sb.ToString());
		}

		#endregion
	}
}
