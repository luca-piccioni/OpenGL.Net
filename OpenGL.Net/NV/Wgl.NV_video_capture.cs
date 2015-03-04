
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_UNIQUE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_capture")]
		public const int UNIQUE_ID_NV = 0x20CE;

		/// <summary>
		/// Value of WGL_NUM_VIDEO_CAPTURE_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF;

		/// <summary>
		/// Binding for wglBindVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="uVideoSlot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static bool BindVideoCaptureDeviceNV(UInt32 uVideoSlot, IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindVideoCaptureDeviceNV != null, "pwglBindVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pwglBindVideoCaptureDeviceNV(uVideoSlot, hDevice);
			CallLog("wglBindVideoCaptureDeviceNV({0}, {1}) = {2}", uVideoSlot, hDevice, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglEnumerateVideoCaptureDevicesNV.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="phDeviceList">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static UInt32 EnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr[] phDeviceList)
		{
			UInt32 retValue;

			unsafe {
				fixed (IntPtr* p_phDeviceList = phDeviceList)
				{
					Debug.Assert(Delegates.pwglEnumerateVideoCaptureDevicesNV != null, "pwglEnumerateVideoCaptureDevicesNV not implemented");
					retValue = Delegates.pwglEnumerateVideoCaptureDevicesNV(hDc, p_phDeviceList);
					CallLog("wglEnumerateVideoCaptureDevicesNV({0}, {1}) = {2}", hDc, phDeviceList, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for wglLockVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static bool LockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglLockVideoCaptureDeviceNV != null, "pwglLockVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pwglLockVideoCaptureDeviceNV(hDc, hDevice);
			CallLog("wglLockVideoCaptureDeviceNV({0}, {1}) = {2}", hDc, hDevice, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static bool QueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryVideoCaptureDeviceNV != null, "pwglQueryVideoCaptureDeviceNV not implemented");
					retValue = Delegates.pwglQueryVideoCaptureDeviceNV(hDc, hDevice, iAttribute, p_piValue);
					CallLog("wglQueryVideoCaptureDeviceNV({0}, {1}, {2}, {3}) = {4}", hDc, hDevice, iAttribute, piValue, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleaseVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static bool ReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglReleaseVideoCaptureDeviceNV != null, "pwglReleaseVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pwglReleaseVideoCaptureDeviceNV(hDc, hDevice);
			CallLog("wglReleaseVideoCaptureDeviceNV({0}, {1}) = {2}", hDc, hDevice, retValue);

			return (retValue);
		}

	}

}
