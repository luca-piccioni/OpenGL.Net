
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_DEVICE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int DEVICE_ID_NV = 0x20CD;

		/// <summary>
		/// Value of GLX_UNIQUE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int UNIQUE_ID_NV = 0x20CE;

		/// <summary>
		/// Value of GLX_NUM_VIDEO_CAPTURE_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF;

		/// <summary>
		/// Binding for glXBindVideoCaptureDeviceNV.
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
			LogFunction("glXBindVideoCaptureDeviceNV(0x{0}, {1}, 0x{2}) = {3}", dpy.ToString("X8"), video_capture_slot, device.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXEnumerateVideoCaptureDevicesNV.
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
					LogFunction("glXEnumerateVideoCaptureDevicesNV(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), screen, nelements, retValue.ToString("X8"));
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXLockVideoCaptureDeviceNV.
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
			LogFunction("glXLockVideoCaptureDeviceNV(0x{0}, 0x{1})", dpy.ToString("X8"), device.ToString("X8"));
		}

		/// <summary>
		/// Binding for glXQueryVideoCaptureDeviceNV.
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
					LogFunction("glXQueryVideoCaptureDeviceNV(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), device.ToString("X8"), attribute, value, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXReleaseVideoCaptureDeviceNV.
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
			LogFunction("glXReleaseVideoCaptureDeviceNV(0x{0}, 0x{1})", dpy.ToString("X8"), device.ToString("X8"));
		}

	}

}
