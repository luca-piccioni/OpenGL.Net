
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
		/// [WGL] Value of WGL_BIND_TO_VIDEO_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGB_NV = 0x20C0;

		/// <summary>
		/// [WGL] Value of WGL_BIND_TO_VIDEO_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGBA_NV = 0x20C1;

		/// <summary>
		/// [WGL] Value of WGL_BIND_TO_VIDEO_RGB_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int BIND_TO_VIDEO_RGB_AND_DEPTH_NV = 0x20C2;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_NV = 0x20C3;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_ALPHA_NV = 0x20C4;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_DEPTH_NV = 0x20C5;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_COLOR_AND_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_AND_ALPHA_NV = 0x20C6;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_COLOR_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_COLOR_AND_DEPTH_NV = 0x20C7;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_FRAME symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FRAME = 0x20C8;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_FIELD_1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FIELD_1 = 0x20C9;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_FIELD_2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_FIELD_2 = 0x20CA;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_STACKED_FIELDS_1_2 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_STACKED_FIELDS_1_2 = 0x20CB;

		/// <summary>
		/// [WGL] Value of WGL_VIDEO_OUT_STACKED_FIELDS_2_1 symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_video_output")]
		public const int VIDEO_OUT_STACKED_FIELDS_2_1 = 0x20CC;

		/// <summary>
		/// [WGL] wglGetVideoDeviceNV: Binding for wglGetVideoDeviceNV.
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
					LogCommand("wglGetVideoDeviceNV", retValue, hDC, numDevices, hVideoDevice					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleaseVideoDeviceNV: Binding for wglReleaseVideoDeviceNV.
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
			LogCommand("wglReleaseVideoDeviceNV", retValue, hVideoDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglBindVideoImageNV: Binding for wglBindVideoImageNV.
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
			LogCommand("wglBindVideoImageNV", retValue, hVideoDevice, hPbuffer, iVideoBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglReleaseVideoImageNV: Binding for wglReleaseVideoImageNV.
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
			LogCommand("wglReleaseVideoImageNV", retValue, hPbuffer, iVideoBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglSendPbufferToVideoNV: Binding for wglSendPbufferToVideoNV.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBufferType">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pulCounterPbuffer">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="bBlock">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool SendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, uint[] pulCounterPbuffer, bool bBlock)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_pulCounterPbuffer = pulCounterPbuffer)
				{
					Debug.Assert(Delegates.pwglSendPbufferToVideoNV != null, "pwglSendPbufferToVideoNV not implemented");
					retValue = Delegates.pwglSendPbufferToVideoNV(hPbuffer, iBufferType, p_pulCounterPbuffer, bBlock);
					LogCommand("wglSendPbufferToVideoNV", retValue, hPbuffer, iBufferType, pulCounterPbuffer, bBlock					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] wglGetVideoInfoNV: Binding for wglGetVideoInfoNV.
		/// </summary>
		/// <param name="hpVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pulCounterOutputPbuffer">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="pulCounterOutputVideo">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_video_output")]
		public static bool GetVideoInfoNV(IntPtr hpVideoDevice, [Out] uint[] pulCounterOutputPbuffer, [Out] uint[] pulCounterOutputVideo)
		{
			bool retValue;

			unsafe {
				fixed (uint* p_pulCounterOutputPbuffer = pulCounterOutputPbuffer)
				fixed (uint* p_pulCounterOutputVideo = pulCounterOutputVideo)
				{
					Debug.Assert(Delegates.pwglGetVideoInfoNV != null, "pwglGetVideoInfoNV not implemented");
					retValue = Delegates.pwglGetVideoInfoNV(hpVideoDevice, p_pulCounterOutputPbuffer, p_pulCounterOutputVideo);
					LogCommand("wglGetVideoInfoNV", retValue, hpVideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglGetVideoDeviceNV pwglGetVideoDeviceNV;

			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglReleaseVideoDeviceNV(IntPtr hVideoDevice);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglReleaseVideoDeviceNV pwglReleaseVideoDeviceNV;

			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglBindVideoImageNV pwglBindVideoImageNV;

			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglReleaseVideoImageNV pwglReleaseVideoImageNV;

			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, uint* pulCounterPbuffer, bool bBlock);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglSendPbufferToVideoNV pwglSendPbufferToVideoNV;

			[RequiredByFeature("WGL_NV_video_output")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate bool wglGetVideoInfoNV(IntPtr hpVideoDevice, uint* pulCounterOutputPbuffer, uint* pulCounterOutputVideo);

			[RequiredByFeature("WGL_NV_video_output")]
			internal static wglGetVideoInfoNV pwglGetVideoInfoNV;

		}
	}

}
