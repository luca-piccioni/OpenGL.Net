
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_DEVICE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int DEVICE_ID_NV = 0x20CD;

		/// <summary>
		/// [GLX] Value of GLX_UNIQUE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int UNIQUE_ID_NV = 0x20CE;

		/// <summary>
		/// [GLX] Value of GLX_NUM_VIDEO_CAPTURE_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF;

		/// <summary>
		/// [GLX] Binding for glXBindVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="video_capture_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static int BindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindVideoCaptureDeviceNV != null, "pglXBindVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pglXBindVideoCaptureDeviceNV(dpy, video_capture_slot, device);
			LogCommand("glXBindVideoCaptureDeviceNV", retValue, dpy, video_capture_slot, device			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXEnumerateVideoCaptureDevicesNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nelements">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static IntPtr EnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int[] nelements)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXEnumerateVideoCaptureDevicesNV != null, "pglXEnumerateVideoCaptureDevicesNV not implemented");
					retValue = Delegates.pglXEnumerateVideoCaptureDevicesNV(dpy, screen, p_nelements);
					LogCommand("glXEnumerateVideoCaptureDevicesNV", retValue, dpy, screen, nelements					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXLockVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static void LockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device)
		{
			Debug.Assert(Delegates.pglXLockVideoCaptureDeviceNV != null, "pglXLockVideoCaptureDeviceNV not implemented");
			Delegates.pglXLockVideoCaptureDeviceNV(dpy, device);
			LogCommand("glXLockVideoCaptureDeviceNV", null, dpy, device			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static int QueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXQueryVideoCaptureDeviceNV != null, "pglXQueryVideoCaptureDeviceNV not implemented");
					retValue = Delegates.pglXQueryVideoCaptureDeviceNV(dpy, device, attribute, p_value);
					LogCommand("glXQueryVideoCaptureDeviceNV", retValue, dpy, device, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXReleaseVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="device">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_capture")]
		public static void ReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device)
		{
			Debug.Assert(Delegates.pglXReleaseVideoCaptureDeviceNV != null, "pglXReleaseVideoCaptureDeviceNV not implemented");
			Delegates.pglXReleaseVideoCaptureDeviceNV(dpy, device);
			LogCommand("glXReleaseVideoCaptureDeviceNV", null, dpy, device			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXEnumerateVideoCaptureDevicesNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXLockVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXBindVideoCaptureDeviceNV pglXBindVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXEnumerateVideoCaptureDevicesNV pglXEnumerateVideoCaptureDevicesNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXLockVideoCaptureDeviceNV pglXLockVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXQueryVideoCaptureDeviceNV pglXQueryVideoCaptureDeviceNV;

			[RequiredByFeature("GLX_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[RequiredByFeature("GLX_NV_video_capture")]
			internal static glXReleaseVideoCaptureDeviceNV pglXReleaseVideoCaptureDeviceNV;

		}
	}

}
