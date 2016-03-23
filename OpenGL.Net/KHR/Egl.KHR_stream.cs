
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
		/// Value of EGL_NO_STREAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int NO_STREAM_KHR = 0;

		/// <summary>
		/// Value of EGL_CONSUMER_LATENCY_USEC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int CONSUMER_LATENCY_USEC_KHR = 0x3210;

		/// <summary>
		/// Value of EGL_PRODUCER_FRAME_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int PRODUCER_FRAME_KHR = 0x3212;

		/// <summary>
		/// Value of EGL_CONSUMER_FRAME_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int CONSUMER_FRAME_KHR = 0x3213;

		/// <summary>
		/// Value of EGL_STREAM_STATE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_KHR = 0x3214;

		/// <summary>
		/// Value of EGL_STREAM_STATE_CREATED_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_CREATED_KHR = 0x3215;

		/// <summary>
		/// Value of EGL_STREAM_STATE_CONNECTING_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_CONNECTING_KHR = 0x3216;

		/// <summary>
		/// Value of EGL_STREAM_STATE_EMPTY_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_EMPTY_KHR = 0x3217;

		/// <summary>
		/// Value of EGL_STREAM_STATE_NEW_FRAME_AVAILABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_NEW_FRAME_AVAILABLE_KHR = 0x3218;

		/// <summary>
		/// Value of EGL_STREAM_STATE_OLD_FRAME_AVAILABLE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_OLD_FRAME_AVAILABLE_KHR = 0x3219;

		/// <summary>
		/// Value of EGL_STREAM_STATE_DISCONNECTED_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int STREAM_STATE_DISCONNECTED_KHR = 0x321A;

		/// <summary>
		/// Value of EGL_BAD_STREAM_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int BAD_STREAM_KHR = 0x321B;

		/// <summary>
		/// Value of EGL_BAD_STATE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		public const int BAD_STATE_KHR = 0x321C;

		/// <summary>
		/// Binding for eglCreateStreamKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static IntPtr CreateStreamKHR(IntPtr dpy, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamKHR != null, "peglCreateStreamKHR not implemented");
					retValue = Delegates.peglCreateStreamKHR(dpy, p_attrib_list);
					LogFunction("eglCreateStreamKHR(0x{0}, {1}) = {2}", dpy.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroyStreamKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool DestroyStreamKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroyStreamKHR != null, "peglDestroyStreamKHR not implemented");
			retValue = Delegates.peglDestroyStreamKHR(dpy, stream);
			LogFunction("eglDestroyStreamKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglStreamAttribKHR.
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
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool StreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamAttribKHR != null, "peglStreamAttribKHR not implemented");
			retValue = Delegates.peglStreamAttribKHR(dpy, stream, attribute, value);
			LogFunction("eglStreamAttribKHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryStreamKHR.
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
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool QueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamKHR != null, "peglQueryStreamKHR not implemented");
					retValue = Delegates.peglQueryStreamKHR(dpy, stream, attribute, p_value);
					LogFunction("eglQueryStreamKHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryStreamu64KHR.
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
		[RequiredByFeature("EGL_KHR_stream")]
		public static bool QueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64[] value)
		{
			bool retValue;

			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamu64KHR != null, "peglQueryStreamu64KHR not implemented");
					retValue = Delegates.peglQueryStreamu64KHR(dpy, stream, attribute, p_value);
					LogFunction("eglQueryStreamu64KHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
