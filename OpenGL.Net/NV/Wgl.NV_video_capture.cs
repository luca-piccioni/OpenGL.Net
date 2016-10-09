
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
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
			LogFunction("wglBindVideoCaptureDeviceNV({0}, 0x{1}) = {2}", uVideoSlot, hDevice.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

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
					LogFunction("wglEnumerateVideoCaptureDevicesNV(0x{0}, {1}) = {2}", hDc.ToString("X8"), LogValue(phDeviceList), retValue);
				}
			}
			DebugCheckErrors(retValue);

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
			LogFunction("wglLockVideoCaptureDeviceNV(0x{0}, 0x{1}) = {2}", hDc.ToString("X8"), hDevice.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

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
					LogFunction("wglQueryVideoCaptureDeviceNV(0x{0}, 0x{1}, {2}, {3}) = {4}", hDc.ToString("X8"), hDevice.ToString("X8"), iAttribute, LogValue(piValue), retValue);
				}
			}
			DebugCheckErrors(retValue);

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
			LogFunction("wglReleaseVideoCaptureDeviceNV(0x{0}, 0x{1}) = {2}", hDc.ToString("X8"), hDevice.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindVideoCaptureDeviceNV(UInt32 uVideoSlot, IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumerateVideoCaptureDevicesNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglEnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglLockVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglLockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindVideoCaptureDeviceNV(UInt32 uVideoSlot, IntPtr hDevice);

			[ThreadStatic]
			internal static wglBindVideoCaptureDeviceNV pwglBindVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglEnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList);

			[ThreadStatic]
			internal static wglEnumerateVideoCaptureDevicesNV pwglEnumerateVideoCaptureDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglLockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[ThreadStatic]
			internal static wglLockVideoCaptureDeviceNV pwglLockVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue);

			[ThreadStatic]
			internal static wglQueryVideoCaptureDeviceNV pwglQueryVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[ThreadStatic]
			internal static wglReleaseVideoCaptureDeviceNV pwglReleaseVideoCaptureDeviceNV;

		}
	}

}
