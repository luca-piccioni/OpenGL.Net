
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
		/// Value of EGL_CONSUMER_ACQUIRE_TIMEOUT_USEC_KHR symbol.
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
			LogFunction("eglStreamConsumerGLTextureExternalKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
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
			LogFunction("eglStreamConsumerAcquireKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
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
			LogFunction("eglStreamConsumerReleaseKHR(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), stream.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
