
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
		/// Value of WGL_NUMBER_PIXEL_FORMATS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_PIXEL_FORMATS_EXT = 0x2000;

		/// <summary>
		/// Value of WGL_DRAW_TO_WINDOW_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DRAW_TO_WINDOW_EXT = 0x2001;

		/// <summary>
		/// Value of WGL_DRAW_TO_BITMAP_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DRAW_TO_BITMAP_EXT = 0x2002;

		/// <summary>
		/// Value of WGL_ACCELERATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCELERATION_EXT = 0x2003;

		/// <summary>
		/// Value of WGL_NEED_PALETTE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NEED_PALETTE_EXT = 0x2004;

		/// <summary>
		/// Value of WGL_NEED_SYSTEM_PALETTE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NEED_SYSTEM_PALETTE_EXT = 0x2005;

		/// <summary>
		/// Value of WGL_SWAP_LAYER_BUFFERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_LAYER_BUFFERS_EXT = 0x2006;

		/// <summary>
		/// Value of WGL_SWAP_METHOD_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_METHOD_EXT = 0x2007;

		/// <summary>
		/// Value of WGL_NUMBER_OVERLAYS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_OVERLAYS_EXT = 0x2008;

		/// <summary>
		/// Value of WGL_NUMBER_UNDERLAYS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_UNDERLAYS_EXT = 0x2009;

		/// <summary>
		/// Value of WGL_TRANSPARENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TRANSPARENT_EXT = 0x200A;

		/// <summary>
		/// Value of WGL_TRANSPARENT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TRANSPARENT_VALUE_EXT = 0x200B;

		/// <summary>
		/// Value of WGL_SHARE_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_DEPTH_EXT = 0x200C;

		/// <summary>
		/// Value of WGL_SHARE_STENCIL_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_STENCIL_EXT = 0x200D;

		/// <summary>
		/// Value of WGL_SHARE_ACCUM_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_ACCUM_EXT = 0x200E;

		/// <summary>
		/// Value of WGL_SUPPORT_GDI_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SUPPORT_GDI_EXT = 0x200F;

		/// <summary>
		/// Value of WGL_SUPPORT_OPENGL_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SUPPORT_OPENGL_EXT = 0x2010;

		/// <summary>
		/// Value of WGL_DOUBLE_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DOUBLE_BUFFER_EXT = 0x2011;

		/// <summary>
		/// Value of WGL_STEREO_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int STEREO_EXT = 0x2012;

		/// <summary>
		/// Value of WGL_PIXEL_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int PIXEL_TYPE_EXT = 0x2013;

		/// <summary>
		/// Value of WGL_COLOR_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int COLOR_BITS_EXT = 0x2014;

		/// <summary>
		/// Value of WGL_RED_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int RED_BITS_EXT = 0x2015;

		/// <summary>
		/// Value of WGL_RED_SHIFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int RED_SHIFT_EXT = 0x2016;

		/// <summary>
		/// Value of WGL_GREEN_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GREEN_BITS_EXT = 0x2017;

		/// <summary>
		/// Value of WGL_GREEN_SHIFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GREEN_SHIFT_EXT = 0x2018;

		/// <summary>
		/// Value of WGL_BLUE_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int BLUE_BITS_EXT = 0x2019;

		/// <summary>
		/// Value of WGL_BLUE_SHIFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int BLUE_SHIFT_EXT = 0x201A;

		/// <summary>
		/// Value of WGL_ALPHA_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ALPHA_BITS_EXT = 0x201B;

		/// <summary>
		/// Value of WGL_ALPHA_SHIFT_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ALPHA_SHIFT_EXT = 0x201C;

		/// <summary>
		/// Value of WGL_ACCUM_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_BITS_EXT = 0x201D;

		/// <summary>
		/// Value of WGL_ACCUM_RED_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_RED_BITS_EXT = 0x201E;

		/// <summary>
		/// Value of WGL_ACCUM_GREEN_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_GREEN_BITS_EXT = 0x201F;

		/// <summary>
		/// Value of WGL_ACCUM_BLUE_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_BLUE_BITS_EXT = 0x2020;

		/// <summary>
		/// Value of WGL_ACCUM_ALPHA_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_ALPHA_BITS_EXT = 0x2021;

		/// <summary>
		/// Value of WGL_DEPTH_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DEPTH_BITS_EXT = 0x2022;

		/// <summary>
		/// Value of WGL_STENCIL_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int STENCIL_BITS_EXT = 0x2023;

		/// <summary>
		/// Value of WGL_AUX_BUFFERS_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int AUX_BUFFERS_EXT = 0x2024;

		/// <summary>
		/// Value of WGL_NO_ACCELERATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NO_ACCELERATION_EXT = 0x2025;

		/// <summary>
		/// Value of WGL_GENERIC_ACCELERATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GENERIC_ACCELERATION_EXT = 0x2026;

		/// <summary>
		/// Value of WGL_FULL_ACCELERATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int FULL_ACCELERATION_EXT = 0x2027;

		/// <summary>
		/// Value of WGL_SWAP_EXCHANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_EXCHANGE_EXT = 0x2028;

		/// <summary>
		/// Value of WGL_SWAP_COPY_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_COPY_EXT = 0x2029;

		/// <summary>
		/// Value of WGL_SWAP_UNDEFINED_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_UNDEFINED_EXT = 0x202A;

		/// <summary>
		/// Value of WGL_TYPE_RGBA_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TYPE_RGBA_EXT = 0x202B;

		/// <summary>
		/// Value of WGL_TYPE_COLORINDEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TYPE_COLORINDEX_EXT = 0x202C;

		/// <summary>
		/// Binding for wglGetPixelFormatAttribivEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nAttributes">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="piAttributes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="piValues">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, int[] piValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (int* p_piValues = piValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribivEXT != null, "pwglGetPixelFormatAttribivEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_piValues);
					CallLog("wglGetPixelFormatAttribivEXT({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetPixelFormatAttribfvEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="nAttributes">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="piAttributes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="pfValues">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, float[] pfValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (float* p_pfValues = pfValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribfvEXT != null, "pwglGetPixelFormatAttribfvEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_pfValues);
					CallLog("wglGetPixelFormatAttribfvEXT({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for wglChoosePixelFormatEXT.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="piAttribIList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="pfAttribFList">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="nMaxFormats">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="piFormats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="nNumFormats">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public static bool ChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, UInt32 nMaxFormats, int[] piFormats, UInt32[] nNumFormats)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribIList = piAttribIList)
				fixed (float* p_pfAttribFList = pfAttribFList)
				fixed (int* p_piFormats = piFormats)
				fixed (UInt32* p_nNumFormats = nNumFormats)
				{
					Debug.Assert(Delegates.pwglChoosePixelFormatEXT != null, "pwglChoosePixelFormatEXT not implemented");
					retValue = Delegates.pwglChoosePixelFormatEXT(hdc, p_piAttribIList, p_pfAttribFList, nMaxFormats, p_piFormats, p_nNumFormats);
					CallLog("wglChoosePixelFormatEXT({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats, retValue);
				}
			}

			return (retValue);
		}

	}

}
