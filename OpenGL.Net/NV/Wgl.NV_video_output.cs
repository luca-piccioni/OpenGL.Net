
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of WGL_BIND_TO_VIDEO_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGB_NV = 0x20C0;

		/// <summary>
		/// Value of WGL_BIND_TO_VIDEO_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGBA_NV = 0x20C1;

		/// <summary>
		/// Value of WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGB_AND_DEPTH_NV = 0x20C2;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_NV = 0x20C3;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_ALPHA_NV = 0x20C4;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_DEPTH_NV = 0x20C5;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_AND_ALPHA_NV = 0x20C6;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_AND_DEPTH_NV = 0x20C7;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_FRAME symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FRAME = 0x20C8;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_FIELD_1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FIELD_1 = 0x20C9;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_FIELD_2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FIELD_2 = 0x20CA;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_STACKED_FIELDS_1_2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_STACKED_FIELDS_1_2 = 0x20CB;

		/// <summary>
		/// Value of WGL_VIDEO_OUT_STACKED_FIELDS_2_1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_STACKED_FIELDS_2_1 = 0x20CC;

		/// <summary>
		/// Binding for wglGetVideoDeviceNV.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="numDevices">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="hVideoDevice">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool GetVideoDeviceNV(IntPtr hDC, int numDevices, [Out] IntPtr[] hVideoDevice)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hVideoDevice = hVideoDevice)
				{
					Debug.Assert(Delegates.pwglGetVideoDeviceNV != null, "pwglGetVideoDeviceNV not implemented");
					retValue = Delegates.pwglGetVideoDeviceNV(hDC, numDevices, p_hVideoDevice);
					LogFunction("wglGetVideoDeviceNV(0x{0}, {1}, {2}) = {3}", hDC.ToString("X8"), numDevices, LogValue(hVideoDevice), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleaseVideoDeviceNV.
		/// </summary>
		/// <param name="hVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool ReleaseVideoDeviceNV(IntPtr hVideoDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglReleaseVideoDeviceNV != null, "pwglReleaseVideoDeviceNV not implemented");
			retValue = Delegates.pwglReleaseVideoDeviceNV(hVideoDevice);
			LogFunction("wglReleaseVideoDeviceNV(0x{0}) = {1}", hVideoDevice.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglBindVideoImageNV.
		/// </summary>
		/// <param name="hVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iVideoBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool BindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindVideoImageNV != null, "pwglBindVideoImageNV not implemented");
			retValue = Delegates.pwglBindVideoImageNV(hVideoDevice, hPbuffer, iVideoBuffer);
			LogFunction("wglBindVideoImageNV(0x{0}, 0x{1}, {2}) = {3}", hVideoDevice.ToString("X8"), hPbuffer.ToString("X8"), iVideoBuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleaseVideoImageNV.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iVideoBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool ReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglReleaseVideoImageNV != null, "pwglReleaseVideoImageNV not implemented");
			retValue = Delegates.pwglReleaseVideoImageNV(hPbuffer, iVideoBuffer);
			LogFunction("wglReleaseVideoImageNV(0x{0}, {1}) = {2}", hPbuffer.ToString("X8"), iVideoBuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglSendPbufferToVideoNV.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBufferType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pulCounterPbuffer">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="bBlock">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool SendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, UInt32[] pulCounterPbuffer, bool bBlock)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_pulCounterPbuffer = pulCounterPbuffer)
				{
					Debug.Assert(Delegates.pwglSendPbufferToVideoNV != null, "pwglSendPbufferToVideoNV not implemented");
					retValue = Delegates.pwglSendPbufferToVideoNV(hPbuffer, iBufferType, p_pulCounterPbuffer, bBlock);
					LogFunction("wglSendPbufferToVideoNV(0x{0}, {1}, {2}, {3}) = {4}", hPbuffer.ToString("X8"), iBufferType, LogValue(pulCounterPbuffer), bBlock, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetVideoInfoNV.
		/// </summary>
		/// <param name="hpVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pulCounterOutputPbuffer">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="pulCounterOutputVideo">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool GetVideoInfoNV(IntPtr hpVideoDevice, [Out] UInt32[] pulCounterOutputPbuffer, [Out] UInt32[] pulCounterOutputVideo)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_pulCounterOutputPbuffer = pulCounterOutputPbuffer)
				fixed (UInt32* p_pulCounterOutputVideo = pulCounterOutputVideo)
				{
					Debug.Assert(Delegates.pwglGetVideoInfoNV != null, "pwglGetVideoInfoNV not implemented");
					retValue = Delegates.pwglGetVideoInfoNV(hpVideoDevice, p_pulCounterOutputPbuffer, p_pulCounterOutputVideo);
					LogFunction("wglGetVideoInfoNV(0x{0}, {1}, {2}) = {3}", hpVideoDevice.ToString("X8"), LogValue(pulCounterOutputPbuffer), LogValue(pulCounterOutputVideo), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetVideoDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoDeviceNV(IntPtr hVideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindVideoImageNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoImageNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSendPbufferToVideoNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetVideoInfoNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetVideoInfoNV(IntPtr hpVideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);

			[ThreadStatic]
			internal static wglGetVideoDeviceNV pwglGetVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoDeviceNV(IntPtr hVideoDevice);

			[ThreadStatic]
			internal static wglReleaseVideoDeviceNV pwglReleaseVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);

			[ThreadStatic]
			internal static wglBindVideoImageNV pwglBindVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);

			[ThreadStatic]
			internal static wglReleaseVideoImageNV pwglReleaseVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			[ThreadStatic]
			internal static wglSendPbufferToVideoNV pwglSendPbufferToVideoNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetVideoInfoNV(IntPtr hpVideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

			[ThreadStatic]
			internal static wglGetVideoInfoNV pwglGetVideoInfoNV;

		}
	}

}
