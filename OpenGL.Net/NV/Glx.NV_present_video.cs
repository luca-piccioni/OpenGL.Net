
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
		/// Value of GLX_NUM_VIDEO_SLOTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GLX_NV_present_video")]
		public const int NUM_VIDEO_SLOTS_NV = 0x20F0;

		/// <summary>
		/// Binding for glXEnumerateVideoDevicesNV.
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
		[RequiredByFeature("GLX_NV_present_video")]
		public static unsafe UInt32* EnumerateVideoDevicesNV(IntPtr dpy, int screen, int[] nelements)
		{
			UInt32* retValue;

			unsafe {
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXEnumerateVideoDevicesNV != null, "pglXEnumerateVideoDevicesNV not implemented");
					retValue = Delegates.pglXEnumerateVideoDevicesNV(dpy, screen, p_nelements);
					LogFunction("glXEnumerateVideoDevicesNV(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), screen, LogValue(nelements), retValue != null ? retValue->ToString() : "(null)");
				}
			}
			DebugCheckErrors(null);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXBindVideoDeviceNV.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="video_slot">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="video_device">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_NV_present_video")]
		public static int BindVideoDeviceNV(IntPtr dpy, UInt32 video_slot, UInt32 video_device, int[] attrib_list)
		{
			int retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXBindVideoDeviceNV != null, "pglXBindVideoDeviceNV not implemented");
					retValue = Delegates.pglXBindVideoDeviceNV(dpy, video_slot, video_device, p_attrib_list);
					LogFunction("glXBindVideoDeviceNV(0x{0}, {1}, {2}, {3}) = {4}", dpy.ToString("X8"), video_slot, video_device, LogValue(attrib_list), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXEnumerateVideoDevicesNV", ExactSpelling = true)]
			internal extern static unsafe UInt32* glXEnumerateVideoDevicesNV(IntPtr dpy, int screen, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoDeviceNV(IntPtr dpy, UInt32 video_slot, UInt32 video_device, int* attrib_list);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32* glXEnumerateVideoDevicesNV(IntPtr dpy, int screen, int* nelements);

			internal static glXEnumerateVideoDevicesNV pglXEnumerateVideoDevicesNV;

			[RequiredByFeature("GLX_NV_present_video")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindVideoDeviceNV(IntPtr dpy, UInt32 video_slot, UInt32 video_device, int* attrib_list);

			internal static glXBindVideoDeviceNV pglXBindVideoDeviceNV;

		}
	}

}
