
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_STREAM_FIFO_LENGTH_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_FIFO_LENGTH_KHR = 0x31FC;

		/// <summary>
		/// Value of EGL_STREAM_TIME_NOW_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_NOW_KHR = 0x31FD;

		/// <summary>
		/// Value of EGL_STREAM_TIME_CONSUMER_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_CONSUMER_KHR = 0x31FE;

		/// <summary>
		/// Value of EGL_STREAM_TIME_PRODUCER_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public const int STREAM_TIME_PRODUCER_KHR = 0x31FF;

		/// <summary>
		/// Binding for eglQueryStreamTimeKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_fifo")]
		public static bool QueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64[] value)
		{
			bool retValue;

			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamTimeKHR != null, "peglQueryStreamTimeKHR not implemented");
					retValue = Delegates.peglQueryStreamTimeKHR(dpy, stream, attribute, p_value);
					LogFunction("eglQueryStreamTimeKHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
