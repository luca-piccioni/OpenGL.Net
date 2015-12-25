
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_NUMBER_PIXEL_FORMATS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NUMBER_PIXEL_FORMATS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_PIXEL_FORMATS_ARB = 0x2000;

		/// <summary>
		/// Value of WGL_DRAW_TO_WINDOW_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DRAW_TO_WINDOW_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DRAW_TO_WINDOW_ARB = 0x2001;

		/// <summary>
		/// Value of WGL_DRAW_TO_BITMAP_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DRAW_TO_BITMAP_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DRAW_TO_BITMAP_ARB = 0x2002;

		/// <summary>
		/// Value of WGL_ACCELERATION_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCELERATION_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCELERATION_ARB = 0x2003;

		/// <summary>
		/// Value of WGL_NEED_PALETTE_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NEED_PALETTE_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NEED_PALETTE_ARB = 0x2004;

		/// <summary>
		/// Value of WGL_NEED_SYSTEM_PALETTE_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NEED_SYSTEM_PALETTE_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NEED_SYSTEM_PALETTE_ARB = 0x2005;

		/// <summary>
		/// Value of WGL_SWAP_LAYER_BUFFERS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SWAP_LAYER_BUFFERS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_LAYER_BUFFERS_ARB = 0x2006;

		/// <summary>
		/// Value of WGL_SWAP_METHOD_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SWAP_METHOD_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_METHOD_ARB = 0x2007;

		/// <summary>
		/// Value of WGL_NUMBER_OVERLAYS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NUMBER_OVERLAYS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_OVERLAYS_ARB = 0x2008;

		/// <summary>
		/// Value of WGL_NUMBER_UNDERLAYS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NUMBER_UNDERLAYS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NUMBER_UNDERLAYS_ARB = 0x2009;

		/// <summary>
		/// Value of WGL_TRANSPARENT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_TRANSPARENT_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TRANSPARENT_ARB = 0x200A;

		/// <summary>
		/// Value of WGL_TRANSPARENT_RED_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int TRANSPARENT_RED_VALUE_ARB = 0x2037;

		/// <summary>
		/// Value of WGL_TRANSPARENT_GREEN_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int TRANSPARENT_GREEN_VALUE_ARB = 0x2038;

		/// <summary>
		/// Value of WGL_TRANSPARENT_BLUE_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int TRANSPARENT_BLUE_VALUE_ARB = 0x2039;

		/// <summary>
		/// Value of WGL_TRANSPARENT_ALPHA_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int TRANSPARENT_ALPHA_VALUE_ARB = 0x203A;

		/// <summary>
		/// Value of WGL_TRANSPARENT_INDEX_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int TRANSPARENT_INDEX_VALUE_ARB = 0x203B;

		/// <summary>
		/// Value of WGL_SHARE_DEPTH_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SHARE_DEPTH_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_DEPTH_ARB = 0x200C;

		/// <summary>
		/// Value of WGL_SHARE_STENCIL_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SHARE_STENCIL_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_STENCIL_ARB = 0x200D;

		/// <summary>
		/// Value of WGL_SHARE_ACCUM_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SHARE_ACCUM_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SHARE_ACCUM_ARB = 0x200E;

		/// <summary>
		/// Value of WGL_SUPPORT_GDI_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SUPPORT_GDI_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SUPPORT_GDI_ARB = 0x200F;

		/// <summary>
		/// Value of WGL_SUPPORT_OPENGL_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SUPPORT_OPENGL_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SUPPORT_OPENGL_ARB = 0x2010;

		/// <summary>
		/// Value of WGL_DOUBLE_BUFFER_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DOUBLE_BUFFER_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DOUBLE_BUFFER_ARB = 0x2011;

		/// <summary>
		/// Value of WGL_STEREO_ARB symbol.
		/// </summary>
		[AliasOf("WGL_STEREO_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int STEREO_ARB = 0x2012;

		/// <summary>
		/// Value of WGL_PIXEL_TYPE_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PIXEL_TYPE_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int PIXEL_TYPE_ARB = 0x2013;

		/// <summary>
		/// Value of WGL_COLOR_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_COLOR_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int COLOR_BITS_ARB = 0x2014;

		/// <summary>
		/// Value of WGL_RED_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_RED_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int RED_BITS_ARB = 0x2015;

		/// <summary>
		/// Value of WGL_RED_SHIFT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_RED_SHIFT_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int RED_SHIFT_ARB = 0x2016;

		/// <summary>
		/// Value of WGL_GREEN_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_GREEN_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GREEN_BITS_ARB = 0x2017;

		/// <summary>
		/// Value of WGL_GREEN_SHIFT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_GREEN_SHIFT_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GREEN_SHIFT_ARB = 0x2018;

		/// <summary>
		/// Value of WGL_BLUE_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_BLUE_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int BLUE_BITS_ARB = 0x2019;

		/// <summary>
		/// Value of WGL_BLUE_SHIFT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_BLUE_SHIFT_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int BLUE_SHIFT_ARB = 0x201A;

		/// <summary>
		/// Value of WGL_ALPHA_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ALPHA_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ALPHA_BITS_ARB = 0x201B;

		/// <summary>
		/// Value of WGL_ALPHA_SHIFT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ALPHA_SHIFT_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ALPHA_SHIFT_ARB = 0x201C;

		/// <summary>
		/// Value of WGL_ACCUM_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCUM_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_BITS_ARB = 0x201D;

		/// <summary>
		/// Value of WGL_ACCUM_RED_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCUM_RED_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_RED_BITS_ARB = 0x201E;

		/// <summary>
		/// Value of WGL_ACCUM_GREEN_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCUM_GREEN_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_GREEN_BITS_ARB = 0x201F;

		/// <summary>
		/// Value of WGL_ACCUM_BLUE_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCUM_BLUE_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_BLUE_BITS_ARB = 0x2020;

		/// <summary>
		/// Value of WGL_ACCUM_ALPHA_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_ACCUM_ALPHA_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int ACCUM_ALPHA_BITS_ARB = 0x2021;

		/// <summary>
		/// Value of WGL_DEPTH_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DEPTH_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int DEPTH_BITS_ARB = 0x2022;

		/// <summary>
		/// Value of WGL_STENCIL_BITS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_STENCIL_BITS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int STENCIL_BITS_ARB = 0x2023;

		/// <summary>
		/// Value of WGL_AUX_BUFFERS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_AUX_BUFFERS_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int AUX_BUFFERS_ARB = 0x2024;

		/// <summary>
		/// Value of WGL_NO_ACCELERATION_ARB symbol.
		/// </summary>
		[AliasOf("WGL_NO_ACCELERATION_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int NO_ACCELERATION_ARB = 0x2025;

		/// <summary>
		/// Value of WGL_GENERIC_ACCELERATION_ARB symbol.
		/// </summary>
		[AliasOf("WGL_GENERIC_ACCELERATION_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int GENERIC_ACCELERATION_ARB = 0x2026;

		/// <summary>
		/// Value of WGL_FULL_ACCELERATION_ARB symbol.
		/// </summary>
		[AliasOf("WGL_FULL_ACCELERATION_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int FULL_ACCELERATION_ARB = 0x2027;

		/// <summary>
		/// Value of WGL_SWAP_EXCHANGE_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SWAP_EXCHANGE_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_EXCHANGE_ARB = 0x2028;

		/// <summary>
		/// Value of WGL_SWAP_COPY_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SWAP_COPY_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_COPY_ARB = 0x2029;

		/// <summary>
		/// Value of WGL_SWAP_UNDEFINED_ARB symbol.
		/// </summary>
		[AliasOf("WGL_SWAP_UNDEFINED_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int SWAP_UNDEFINED_ARB = 0x202A;

		/// <summary>
		/// Value of WGL_TYPE_RGBA_ARB symbol.
		/// </summary>
		[AliasOf("WGL_TYPE_RGBA_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TYPE_RGBA_ARB = 0x202B;

		/// <summary>
		/// Value of WGL_TYPE_COLORINDEX_ARB symbol.
		/// </summary>
		[AliasOf("WGL_TYPE_COLORINDEX_EXT")]
		[RequiredByFeature("WGL_ARB_pixel_format")]
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TYPE_COLORINDEX_ARB = 0x202C;

		/// <summary>
		/// Binding for wglGetPixelFormatAttribivARB.
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
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public static bool GetPixelFormatAttribARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, [Out] int[] piValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (int* p_piValues = piValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribivARB != null, "pwglGetPixelFormatAttribivARB not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_piValues);
					LogFunction("wglGetPixelFormatAttribivARB(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetPixelFormatAttribfvARB.
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
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public static bool GetPixelFormatAttribARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, [Out] float[] pfValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (float* p_pfValues = pfValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribfvARB != null, "pwglGetPixelFormatAttribfvARB not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_pfValues);
					LogFunction("wglGetPixelFormatAttribfvARB(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglChoosePixelFormatARB.
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
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public static bool ChoosePixelFormatARB(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, UInt32 nMaxFormats, int[] piFormats, UInt32[] nNumFormats)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribIList = piAttribIList)
				fixed (float* p_pfAttribFList = pfAttribFList)
				fixed (int* p_piFormats = piFormats)
				fixed (UInt32* p_nNumFormats = nNumFormats)
				{
					Debug.Assert(Delegates.pwglChoosePixelFormatARB != null, "pwglChoosePixelFormatARB not implemented");
					retValue = Delegates.pwglChoosePixelFormatARB(hdc, p_piAttribIList, p_pfAttribFList, nMaxFormats, p_piFormats, p_nNumFormats);
					LogFunction("wglChoosePixelFormatARB(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
