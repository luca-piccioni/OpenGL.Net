
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_SYNC_FRAME_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		[Log(BitmaskName = "GLXSyncType")]
		public const int SYNC_FRAME_SGIX = 0x00000000;

		/// <summary>
		/// [GLX] Value of GLX_SYNC_SWAP_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		[Log(BitmaskName = "GLXSyncType")]
		public const int SYNC_SWAP_SGIX = 0x00000001;

		/// <summary>
		/// [GLX] glXBindChannelToWindowSGIX: Binding for glXBindChannelToWindowSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="channel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public static int BindChannelToWindowSGIX(IntPtr display, int screen, int channel, IntPtr window)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindChannelToWindowSGIX != null, "pglXBindChannelToWindowSGIX not implemented");
			retValue = Delegates.pglXBindChannelToWindowSGIX(display, screen, channel, window);
			LogCommand("glXBindChannelToWindowSGIX", retValue, display, screen, channel, window			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXChannelRectSGIX: Binding for glXChannelRectSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="channel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public static int ChannelRectSGIX(IntPtr display, int screen, int channel, int x, int y, int w, int h)
		{
			int retValue;

			Debug.Assert(Delegates.pglXChannelRectSGIX != null, "pglXChannelRectSGIX not implemented");
			retValue = Delegates.pglXChannelRectSGIX(display, screen, channel, x, y, w, h);
			LogCommand("glXChannelRectSGIX", retValue, display, screen, channel, x, y, w, h			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXQueryChannelRectSGIX: Binding for glXQueryChannelRectSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="channel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dx">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="dy">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="dw">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="dh">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public static int QueryChannelRectSGIX(IntPtr display, int screen, int channel, int[] dx, int[] dy, int[] dw, int[] dh)
		{
			int retValue;

			unsafe {
				fixed (int* p_dx = dx)
				fixed (int* p_dy = dy)
				fixed (int* p_dw = dw)
				fixed (int* p_dh = dh)
				{
					Debug.Assert(Delegates.pglXQueryChannelRectSGIX != null, "pglXQueryChannelRectSGIX not implemented");
					retValue = Delegates.pglXQueryChannelRectSGIX(display, screen, channel, p_dx, p_dy, p_dw, p_dh);
					LogCommand("glXQueryChannelRectSGIX", retValue, display, screen, channel, dx, dy, dw, dh					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXQueryChannelDeltasSGIX: Binding for glXQueryChannelDeltasSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="channel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public static int QueryChannelDeltasSGIX(IntPtr display, int screen, int channel, int[] x, int[] y, int[] w, int[] h)
		{
			int retValue;

			unsafe {
				fixed (int* p_x = x)
				fixed (int* p_y = y)
				fixed (int* p_w = w)
				fixed (int* p_h = h)
				{
					Debug.Assert(Delegates.pglXQueryChannelDeltasSGIX != null, "pglXQueryChannelDeltasSGIX not implemented");
					retValue = Delegates.pglXQueryChannelDeltasSGIX(display, screen, channel, p_x, p_y, p_w, p_h);
					LogCommand("glXQueryChannelDeltasSGIX", retValue, display, screen, channel, x, y, w, h					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXChannelRectSyncSGIX: Binding for glXChannelRectSyncSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="channel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="synctype">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public static int ChannelRectSyncSGIX(IntPtr display, int screen, int channel, int synctype)
		{
			int retValue;

			Debug.Assert(Delegates.pglXChannelRectSyncSGIX != null, "pglXChannelRectSyncSGIX not implemented");
			retValue = Delegates.pglXChannelRectSyncSGIX(display, screen, channel, synctype);
			LogCommand("glXChannelRectSyncSGIX", retValue, display, screen, channel, synctype			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_video_resize")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXBindChannelToWindowSGIX(IntPtr display, int screen, int channel, IntPtr window);

			[RequiredByFeature("GLX_SGIX_video_resize")]
			internal static glXBindChannelToWindowSGIX pglXBindChannelToWindowSGIX;

			[RequiredByFeature("GLX_SGIX_video_resize")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXChannelRectSGIX(IntPtr display, int screen, int channel, int x, int y, int w, int h);

			[RequiredByFeature("GLX_SGIX_video_resize")]
			internal static glXChannelRectSGIX pglXChannelRectSGIX;

			[RequiredByFeature("GLX_SGIX_video_resize")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXQueryChannelRectSGIX(IntPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh);

			[RequiredByFeature("GLX_SGIX_video_resize")]
			internal static glXQueryChannelRectSGIX pglXQueryChannelRectSGIX;

			[RequiredByFeature("GLX_SGIX_video_resize")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXQueryChannelDeltasSGIX(IntPtr display, int screen, int channel, int* x, int* y, int* w, int* h);

			[RequiredByFeature("GLX_SGIX_video_resize")]
			internal static glXQueryChannelDeltasSGIX pglXQueryChannelDeltasSGIX;

			[RequiredByFeature("GLX_SGIX_video_resize")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXChannelRectSyncSGIX(IntPtr display, int screen, int channel, int synctype);

			[RequiredByFeature("GLX_SGIX_video_resize")]
			internal static glXChannelRectSyncSGIX pglXChannelRectSyncSGIX;

		}
	}

}
