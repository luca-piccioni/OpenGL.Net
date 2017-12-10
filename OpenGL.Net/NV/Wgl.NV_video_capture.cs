
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_UNIQUE_ID_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_capture")]
		public const int UNIQUE_ID_NV = 0x20CE;

		/// <summary>
		/// [WGL] Value of WGL_NUM_VIDEO_CAPTURE_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_capture")]
		public const int NUM_VIDEO_CAPTURE_SLOTS_NV = 0x20CF;

		/// <summary>
		/// [WGL] wglBindVideoCaptureDeviceNV: Binding for wglBindVideoCaptureDeviceNV.
		/// </summary>
		/// <param name="uVideoSlot">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static bool BindVideoCaptureDeviceNV(uint uVideoSlot, IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindVideoCaptureDeviceNV != null, "pwglBindVideoCaptureDeviceNV not implemented");
			retValue = Delegates.pwglBindVideoCaptureDeviceNV(uVideoSlot, hDevice);
			LogCommand("wglBindVideoCaptureDeviceNV", retValue, uVideoSlot, hDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglEnumerateVideoCaptureDevicesNV: Binding for wglEnumerateVideoCaptureDevicesNV.
		/// </summary>
		/// <param name="hDc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="phDeviceList">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_capture")]
		public static uint EnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr[] phDeviceList)
		{
			uint retValue;

			unsafe {
				fixed (IntPtr* p_phDeviceList = phDeviceList)
				{
					Debug.Assert(Delegates.pwglEnumerateVideoCaptureDevicesNV != null, "pwglEnumerateVideoCaptureDevicesNV not implemented");
					retValue = Delegates.pwglEnumerateVideoCaptureDevicesNV(hDc, p_phDeviceList);
					LogCommand("wglEnumerateVideoCaptureDevicesNV", retValue, hDc, phDeviceList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglLockVideoCaptureDeviceNV: Binding for wglLockVideoCaptureDeviceNV.
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
			LogCommand("wglLockVideoCaptureDeviceNV", retValue, hDc, hDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglQueryVideoCaptureDeviceNV: Binding for wglQueryVideoCaptureDeviceNV.
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
					LogCommand("wglQueryVideoCaptureDeviceNV", retValue, hDc, hDevice, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleaseVideoCaptureDeviceNV: Binding for wglReleaseVideoCaptureDeviceNV.
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
			LogCommand("wglReleaseVideoCaptureDeviceNV", retValue, hDc, hDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglBindVideoCaptureDeviceNV(uint uVideoSlot, IntPtr hDevice);

			[RequiredByFeature("WGL_NV_video_capture")]
			internal static wglBindVideoCaptureDeviceNV pwglBindVideoCaptureDeviceNV;

			[RequiredByFeature("WGL_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate uint wglEnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList);

			[RequiredByFeature("WGL_NV_video_capture")]
			internal static wglEnumerateVideoCaptureDevicesNV pwglEnumerateVideoCaptureDevicesNV;

			[RequiredByFeature("WGL_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglLockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[RequiredByFeature("WGL_NV_video_capture")]
			internal static wglLockVideoCaptureDeviceNV pwglLockVideoCaptureDeviceNV;

			[RequiredByFeature("WGL_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglQueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_NV_video_capture")]
			internal static wglQueryVideoCaptureDeviceNV pwglQueryVideoCaptureDeviceNV;

			[RequiredByFeature("WGL_NV_video_capture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[RequiredByFeature("WGL_NV_video_capture")]
			internal static wglReleaseVideoCaptureDeviceNV pwglReleaseVideoCaptureDeviceNV;

		}
	}

}
