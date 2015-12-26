
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
using System.Text;

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
