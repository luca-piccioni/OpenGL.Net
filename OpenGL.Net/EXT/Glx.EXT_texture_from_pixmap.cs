
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
		/// Value of GLX_TEXTURE_1D_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const uint TEXTURE_1D_BIT_EXT = 0x00000001;

		/// <summary>
		/// Value of GLX_TEXTURE_2D_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const uint TEXTURE_2D_BIT_EXT = 0x00000002;

		/// <summary>
		/// Value of GLX_TEXTURE_RECTANGLE_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const uint TEXTURE_RECTANGLE_BIT_EXT = 0x00000004;

		/// <summary>
		/// Value of GLX_BIND_TO_TEXTURE_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_RGB_EXT = 0x20D0;

		/// <summary>
		/// Value of GLX_BIND_TO_TEXTURE_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_RGBA_EXT = 0x20D1;

		/// <summary>
		/// Value of GLX_BIND_TO_MIPMAP_TEXTURE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_MIPMAP_TEXTURE_EXT = 0x20D2;

		/// <summary>
		/// Value of GLX_BIND_TO_TEXTURE_TARGETS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BIND_TO_TEXTURE_TARGETS_EXT = 0x20D3;

		/// <summary>
		/// Value of GLX_Y_INVERTED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int Y_INVERTED_EXT = 0x20D4;

		/// <summary>
		/// Value of GLX_TEXTURE_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_EXT = 0x20D5;

		/// <summary>
		/// Value of GLX_TEXTURE_TARGET_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_TARGET_EXT = 0x20D6;

		/// <summary>
		/// Value of GLX_MIPMAP_TEXTURE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int MIPMAP_TEXTURE_EXT = 0x20D7;

		/// <summary>
		/// Value of GLX_TEXTURE_FORMAT_NONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_NONE_EXT = 0x20D8;

		/// <summary>
		/// Value of GLX_TEXTURE_FORMAT_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_RGB_EXT = 0x20D9;

		/// <summary>
		/// Value of GLX_TEXTURE_FORMAT_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_FORMAT_RGBA_EXT = 0x20DA;

		/// <summary>
		/// Value of GLX_TEXTURE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_1D_EXT = 0x20DB;

		/// <summary>
		/// Value of GLX_TEXTURE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_2D_EXT = 0x20DC;

		/// <summary>
		/// Value of GLX_TEXTURE_RECTANGLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int TEXTURE_RECTANGLE_EXT = 0x20DD;

		/// <summary>
		/// Value of GLX_FRONT_LEFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int FRONT_LEFT_EXT = 0x20DE;

		/// <summary>
		/// Value of GLX_FRONT_RIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int FRONT_RIGHT_EXT = 0x20DF;

		/// <summary>
		/// Value of GLX_BACK_LEFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BACK_LEFT_EXT = 0x20E0;

		/// <summary>
		/// Value of GLX_BACK_RIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int BACK_RIGHT_EXT = 0x20E1;

		/// <summary>
		/// Value of GLX_AUX0_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX0_EXT = 0x20E2;

		/// <summary>
		/// Value of GLX_AUX1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX1_EXT = 0x20E3;

		/// <summary>
		/// Value of GLX_AUX2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX2_EXT = 0x20E4;

		/// <summary>
		/// Value of GLX_AUX3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX3_EXT = 0x20E5;

		/// <summary>
		/// Value of GLX_AUX4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX4_EXT = 0x20E6;

		/// <summary>
		/// Value of GLX_AUX5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX5_EXT = 0x20E7;

		/// <summary>
		/// Value of GLX_AUX6_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX6_EXT = 0x20E8;

		/// <summary>
		/// Value of GLX_AUX7_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX7_EXT = 0x20E9;

		/// <summary>
		/// Value of GLX_AUX8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX8_EXT = 0x20EA;

		/// <summary>
		/// Value of GLX_AUX9_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public const int AUX9_EXT = 0x20EB;

		/// <summary>
		/// Binding for glXBindTexImageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public static void BindTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer, int[] attrib_list)
		{
			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXBindTexImageEXT != null, "pglXBindTexImageEXT not implemented");
					Delegates.pglXBindTexImageEXT(dpy, drawable, buffer, p_attrib_list);
					CallLog("glXBindTexImageEXT(0x{0}, 0x{1}, {2}, {3})", dpy.ToString("X8"), drawable.ToString("X8"), buffer, attrib_list);
				}
			}
		}

		/// <summary>
		/// Binding for glXReleaseTexImageEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_EXT_texture_from_pixmap")]
		public static void ReleaseTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer)
		{
			Debug.Assert(Delegates.pglXReleaseTexImageEXT != null, "pglXReleaseTexImageEXT not implemented");
			Delegates.pglXReleaseTexImageEXT(dpy, drawable, buffer);
			CallLog("glXReleaseTexImageEXT(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), drawable.ToString("X8"), buffer);
		}

	}

}
