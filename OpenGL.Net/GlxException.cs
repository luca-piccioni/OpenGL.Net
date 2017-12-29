
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
	public sealed class GlxException : KhronosException
	{
		#region Constructors

		/// <summary>
		/// Construct a GlxException.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="errorEvent">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		internal GlxException(IntPtr displayHandle, ref Glx.XErrorEvent errorEvent) :
			base(errorEvent.error_code, GetErrorMessage(displayHandle, ref errorEvent), new Win32Exception(errorEvent.error_code, GetErrorMessage(displayHandle, ref errorEvent)))
		{

		}

		#endregion

		#region Error Messages

		/// <summary>
		/// Returns a description of the error code.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="errorEvent">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <returns>
		/// It returns a description of <paramref name="errorEvent"/>.
		/// </returns>
		private static string GetErrorMessage(IntPtr displayHandle, ref Glx.XErrorEvent errorEvent)
		{
			StringBuilder sb = new StringBuilder(1024);

			Glx.UnsafeNativeMethods.XGetErrorText(displayHandle, errorEvent.error_code, sb, 1024);

			string eventName = Enum.GetName(typeof(Glx.XEventName), errorEvent.type);
			string requestName = Enum.GetName(typeof(Glx.XRequest), errorEvent.request_code);

			if (string.IsNullOrEmpty(eventName))
				eventName = "Unknown";
			if (string.IsNullOrEmpty(requestName))
				requestName = "Unknown";

			// Additional details
			sb.AppendLine("\nX error details:");
			sb.AppendFormat("	X event name: '{0}' ({1})\n", eventName, errorEvent.type);
			sb.AppendFormat("	Display: 0x{0:x}\n", errorEvent.display.ToInt64());
			sb.AppendFormat("	Resource ID: {0:x}\n", errorEvent.resourceid.ToInt64());
			sb.AppendFormat("	Error code: {0}\n", errorEvent.error_code);
			sb.AppendFormat("	Major code: '{0}' ({1})\n", requestName, errorEvent.request_code);
			sb.AppendFormat("	Minor code: {0}", errorEvent.minor_code);

			return (sb.ToString());
		}

		#endregion
	}
}
