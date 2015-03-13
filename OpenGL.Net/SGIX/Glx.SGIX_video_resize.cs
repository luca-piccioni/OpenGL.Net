
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_SYNC_FRAME_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public const uint SYNC_FRAME_SGIX = 0x00000000;

		/// <summary>
		/// Value of GLX_SYNC_SWAP_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_video_resize")]
		public const uint SYNC_SWAP_SGIX = 0x00000001;

		/// <summary>
		/// Binding for glXBindChannelToWindowSGIX.
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
			CallLog("glXBindChannelToWindowSGIX({0}, {1}, {2}, {3}) = {4}", display, screen, channel, window, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXChannelRectSGIX.
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
			CallLog("glXChannelRectSGIX({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", display, screen, channel, x, y, w, h, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryChannelRectSGIX.
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
					CallLog("glXQueryChannelRectSGIX({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", display, screen, channel, dx, dy, dw, dh, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryChannelDeltasSGIX.
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
					CallLog("glXQueryChannelDeltasSGIX({0}, {1}, {2}, {3}, {4}, {5}, {6}) = {7}", display, screen, channel, x, y, w, h, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXChannelRectSyncSGIX.
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
			CallLog("glXChannelRectSyncSGIX({0}, {1}, {2}, {3}) = {4}", display, screen, channel, synctype, retValue);

			return (retValue);
		}

	}

}
