
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
		/// Value of EGL_SYNC_NATIVE_FENCE_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_ANDROID = 0x3144;

		/// <summary>
		/// Value of EGL_SYNC_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_FD_ANDROID = 0x3145;

		/// <summary>
		/// Value of EGL_SYNC_NATIVE_FENCE_SIGNALED_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int SYNC_NATIVE_FENCE_SIGNALED_ANDROID = 0x3146;

		/// <summary>
		/// Value of EGL_NO_NATIVE_FENCE_FD_ANDROID symbol.
		/// </summary>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public const int NO_NATIVE_FENCE_FD_ANDROID = -1;

		/// <summary>
		/// Binding for eglDupNativeFenceFDANDROID.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_ANDROID_native_fence_sync")]
		public static int DupNativeFenceANDROID(IntPtr dpy, IntPtr sync)
		{
			int retValue;

			Debug.Assert(Delegates.peglDupNativeFenceFDANDROID != null, "peglDupNativeFenceFDANDROID not implemented");
			retValue = Delegates.peglDupNativeFenceFDANDROID(dpy, sync);
			LogFunction("eglDupNativeFenceFDANDROID(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), sync.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
