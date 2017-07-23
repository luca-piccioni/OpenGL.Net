
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
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_NV = 0x20C3;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_ALPHA_NV = 0x20C4;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_DEPTH_NV = 0x20C5;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_AND_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_AND_ALPHA_NV = 0x20C6;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_COLOR_AND_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_COLOR_AND_DEPTH_NV = 0x20C7;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FRAME_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FRAME_NV = 0x20C8;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FIELD_1_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FIELD_1_NV = 0x20C9;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_FIELD_2_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_FIELD_2_NV = 0x20CA;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_STACKED_FIELDS_1_2_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_STACKED_FIELDS_1_2_NV = 0x20CB;

		/// <summary>
		/// [GLX] Value of GLX_VIDEO_OUT_STACKED_FIELDS_2_1_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_video_out")]
		public const int VIDEO_OUT_STACKED_FIELDS_2_1_NV = 0x20CC;

		/// <summary>
		/// [GLX] Binding for glXGetVideoDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numVideoDevices">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pVideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int GetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice)
		{
			int retValue;

			Debug.Assert(Delegates.pglXGetVideoDeviceNV != null, "pglXGetVideoDeviceNV not implemented");
			retValue = Delegates.pglXGetVideoDeviceNV(dpy, screen, numVideoDevices, pVideoDevice);
			LogCommand("glXGetVideoDeviceNV", retValue, dpy, screen, numVideoDevices, pVideoDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXReleaseVideoDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int ReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice)
		{
			int retValue;

			Debug.Assert(Delegates.pglXReleaseVideoDeviceNV != null, "pglXReleaseVideoDeviceNV not implemented");
			retValue = Delegates.pglXReleaseVideoDeviceNV(dpy, screen, VideoDevice);
			LogCommand("glXReleaseVideoDeviceNV", retValue, dpy, screen, VideoDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXBindVideoImageNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iVideoBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int BindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindVideoImageNV != null, "pglXBindVideoImageNV not implemented");
			retValue = Delegates.pglXBindVideoImageNV(dpy, VideoDevice, pbuf, iVideoBuffer);
			LogCommand("glXBindVideoImageNV", retValue, dpy, VideoDevice, pbuf, iVideoBuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXReleaseVideoImageNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int ReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf)
		{
			int retValue;

			Debug.Assert(Delegates.pglXReleaseVideoImageNV != null, "pglXReleaseVideoImageNV not implemented");
			retValue = Delegates.pglXReleaseVideoImageNV(dpy, pbuf);
			LogCommand("glXReleaseVideoImageNV", retValue, dpy, pbuf			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXSendPbufferToVideoNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
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
		[RequiredByFeature("GLX_NV_video_out")]
		public static int SendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, UInt32[] pulCounterPbuffer, bool bBlock)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_pulCounterPbuffer = pulCounterPbuffer)
				{
					Debug.Assert(Delegates.pglXSendPbufferToVideoNV != null, "pglXSendPbufferToVideoNV not implemented");
					retValue = Delegates.pglXSendPbufferToVideoNV(dpy, pbuf, iBufferType, p_pulCounterPbuffer, bBlock);
					LogCommand("glXSendPbufferToVideoNV", retValue, dpy, pbuf, iBufferType, pulCounterPbuffer, bBlock					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXGetVideoInfoNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="VideoDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pulCounterOutputPbuffer">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="pulCounterOutputVideo">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_video_out")]
		public static int GetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, [Out] UInt32[] pulCounterOutputPbuffer, [Out] UInt32[] pulCounterOutputVideo)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_pulCounterOutputPbuffer = pulCounterOutputPbuffer)
				fixed (UInt32* p_pulCounterOutputVideo = pulCounterOutputVideo)
				{
					Debug.Assert(Delegates.pglXGetVideoInfoNV != null, "pglXGetVideoInfoNV not implemented");
					retValue = Delegates.pglXGetVideoInfoNV(dpy, screen, VideoDevice, p_pulCounterOutputPbuffer, p_pulCounterOutputVideo);
					LogCommand("glXGetVideoInfoNV", retValue, dpy, screen, VideoDevice, pulCounterOutputPbuffer, pulCounterOutputVideo					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXGetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXReleaseVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXBindVideoImageNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXReleaseVideoImageNV", ExactSpelling = true)]
			internal extern static unsafe int glXReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXSendPbufferToVideoNV", ExactSpelling = true)]
			internal extern static unsafe int glXSendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetVideoInfoNV", ExactSpelling = true)]
			internal extern static unsafe int glXGetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXGetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXGetVideoDeviceNV pglXGetVideoDeviceNV;

			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXReleaseVideoDeviceNV pglXReleaseVideoDeviceNV;

			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXBindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXBindVideoImageNV pglXBindVideoImageNV;

			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXReleaseVideoImageNV pglXReleaseVideoImageNV;

			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXSendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXSendPbufferToVideoNV pglXSendPbufferToVideoNV;

			[RequiredByFeature("GLX_NV_video_out")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXGetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

			[RequiredByFeature("GLX_NV_video_out")]
			internal static glXGetVideoInfoNV pglXGetVideoInfoNV;

		}
	}

}
