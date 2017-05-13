
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
		/// [EGL] Value of EGL_CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR symbol.
		/// </summary>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public const int CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR = 0x321E;

		/// <summary>
		/// Binding for eglStreamConsumerGLTextureExternalKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerGLTextureExternalKHR != null, "peglStreamConsumerGLTextureExternalKHR not implemented");
			retValue = Delegates.peglStreamConsumerGLTextureExternalKHR(dpy, stream);
			LogCommand("eglStreamConsumerGLTextureExternalKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglStreamConsumerAcquireKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerAcquireKHR != null, "peglStreamConsumerAcquireKHR not implemented");
			retValue = Delegates.peglStreamConsumerAcquireKHR(dpy, stream);
			LogCommand("eglStreamConsumerAcquireKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglStreamConsumerReleaseKHR.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
		public static bool StreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerReleaseKHR != null, "peglStreamConsumerReleaseKHR not implemented");
			retValue = Delegates.peglStreamConsumerReleaseKHR(dpy, stream);
			LogCommand("eglStreamConsumerReleaseKHR", retValue, dpy, stream			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglStreamConsumerGLTextureExternalKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglStreamConsumerAcquireKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglStreamConsumerReleaseKHR", ExactSpelling = true)]
			internal extern static unsafe bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerGLTextureExternalKHR peglStreamConsumerGLTextureExternalKHR;

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerAcquireKHR peglStreamConsumerAcquireKHR;

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			[RequiredByFeature("EGL_KHR_stream_consumer_gltexture")]
			internal static eglStreamConsumerReleaseKHR peglStreamConsumerReleaseKHR;

		}
	}

}
