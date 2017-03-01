
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_CONSUMER_LATENCY_USEC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int CONSUMER_LATENCY_USEC_KHR = 0x3210;

		/// <summary>
		/// Value of EGL_STREAM_STATE_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_KHR = 0x3214;

		/// <summary>
		/// Value of EGL_STREAM_STATE_CREATED_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_CREATED_KHR = 0x3215;

		/// <summary>
		/// Value of EGL_STREAM_STATE_CONNECTING_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream")]
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public const int STREAM_STATE_CONNECTING_KHR = 0x3216;

		/// <summary>
		/// Binding for eglCreateStreamAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static IntPtr CreateStreamAttribKHR(IntPtr dpy, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateStreamAttribKHR != null, "peglCreateStreamAttribKHR not implemented");
					retValue = Delegates.peglCreateStreamAttribKHR(dpy, p_attrib_list);
					LogFunction("eglCreateStreamAttribKHR(0x{0}, {1}) = {2}", dpy.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglSetStreamAttribKHR.
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
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool SetStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSetStreamAttribKHR != null, "peglSetStreamAttribKHR not implemented");
			retValue = Delegates.peglSetStreamAttribKHR(dpy, stream, attribute, value);
			LogFunction("eglSetStreamAttribKHR(0x{0}, 0x{1}, {2}, 0x{3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, value.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryStreamAttribKHR.
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
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool QueryStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryStreamAttribKHR != null, "peglQueryStreamAttribKHR not implemented");
					retValue = Delegates.peglQueryStreamAttribKHR(dpy, stream, attribute, p_value);
					LogFunction("eglQueryStreamAttribKHR(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), stream.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglStreamConsumerAcquireAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool StreamConsumerAcquireAttribKHR(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerAcquireAttribKHR != null, "peglStreamConsumerAcquireAttribKHR not implemented");
					retValue = Delegates.peglStreamConsumerAcquireAttribKHR(dpy, stream, p_attrib_list);
					LogFunction("eglStreamConsumerAcquireAttribKHR(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), stream.ToString("X8"), LogValue(attrib_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglStreamConsumerReleaseAttribKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_attrib")]
		public static bool StreamConsumerReleaseAttribKHR(IntPtr dpy, IntPtr stream, IntPtr[] attrib_list)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglStreamConsumerReleaseAttribKHR != null, "peglStreamConsumerReleaseAttribKHR not implemented");
					retValue = Delegates.peglStreamConsumerReleaseAttribKHR(dpy, stream, p_attrib_list);
					LogFunction("eglStreamConsumerReleaseAttribKHR(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), stream.ToString("X8"), LogValue(attrib_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglCreateStreamAttribKHR", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreateStreamAttribKHR(IntPtr dpy, IntPtr* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglSetStreamAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglSetStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryStreamAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglStreamConsumerAcquireAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerAcquireAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglStreamConsumerReleaseAttribKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerReleaseAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamAttribKHR(IntPtr dpy, IntPtr* attrib_list);

			internal static eglCreateStreamAttribKHR peglCreateStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSetStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr value);

			internal static eglSetStreamAttribKHR peglSetStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, IntPtr* value);

			internal static eglQueryStreamAttribKHR peglQueryStreamAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerAcquireAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			internal static eglStreamConsumerAcquireAttribKHR peglStreamConsumerAcquireAttribKHR;

			[RequiredByFeature("EGL_KHR_stream_attrib")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerReleaseAttribKHR(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			internal static eglStreamConsumerReleaseAttribKHR peglStreamConsumerReleaseAttribKHR;

		}
	}

}
