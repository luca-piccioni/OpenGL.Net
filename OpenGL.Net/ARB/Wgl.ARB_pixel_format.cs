
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
		/// Value of WGL_NUMBER_PIXEL_FORMATS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NUMBER_PIXEL_FORMATS_ARB = 0x2000;

		/// <summary>
		/// Value of WGL_DRAW_TO_WINDOW_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_DRAW_TO_WINDOW_ARB = 0x2001;

		/// <summary>
		/// Value of WGL_DRAW_TO_BITMAP_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_DRAW_TO_BITMAP_ARB = 0x2002;

		/// <summary>
		/// Value of WGL_ACCELERATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCELERATION_ARB = 0x2003;

		/// <summary>
		/// Value of WGL_NEED_PALETTE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NEED_PALETTE_ARB = 0x2004;

		/// <summary>
		/// Value of WGL_NEED_SYSTEM_PALETTE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NEED_SYSTEM_PALETTE_ARB = 0x2005;

		/// <summary>
		/// Value of WGL_SWAP_LAYER_BUFFERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SWAP_LAYER_BUFFERS_ARB = 0x2006;

		/// <summary>
		/// Value of WGL_SWAP_METHOD_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SWAP_METHOD_ARB = 0x2007;

		/// <summary>
		/// Value of WGL_NUMBER_OVERLAYS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NUMBER_OVERLAYS_ARB = 0x2008;

		/// <summary>
		/// Value of WGL_NUMBER_UNDERLAYS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NUMBER_UNDERLAYS_ARB = 0x2009;

		/// <summary>
		/// Value of WGL_TRANSPARENT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_ARB = 0x200A;

		/// <summary>
		/// Value of WGL_TRANSPARENT_RED_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_RED_VALUE_ARB = 0x2037;

		/// <summary>
		/// Value of WGL_TRANSPARENT_GREEN_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_GREEN_VALUE_ARB = 0x2038;

		/// <summary>
		/// Value of WGL_TRANSPARENT_BLUE_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_BLUE_VALUE_ARB = 0x2039;

		/// <summary>
		/// Value of WGL_TRANSPARENT_ALPHA_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_ALPHA_VALUE_ARB = 0x203A;

		/// <summary>
		/// Value of WGL_TRANSPARENT_INDEX_VALUE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TRANSPARENT_INDEX_VALUE_ARB = 0x203B;

		/// <summary>
		/// Value of WGL_SHARE_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SHARE_DEPTH_ARB = 0x200C;

		/// <summary>
		/// Value of WGL_SHARE_STENCIL_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SHARE_STENCIL_ARB = 0x200D;

		/// <summary>
		/// Value of WGL_SHARE_ACCUM_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SHARE_ACCUM_ARB = 0x200E;

		/// <summary>
		/// Value of WGL_SUPPORT_GDI_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SUPPORT_GDI_ARB = 0x200F;

		/// <summary>
		/// Value of WGL_SUPPORT_OPENGL_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SUPPORT_OPENGL_ARB = 0x2010;

		/// <summary>
		/// Value of WGL_DOUBLE_BUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_DOUBLE_BUFFER_ARB = 0x2011;

		/// <summary>
		/// Value of WGL_STEREO_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_STEREO_ARB = 0x2012;

		/// <summary>
		/// Value of WGL_PIXEL_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_PIXEL_TYPE_ARB = 0x2013;

		/// <summary>
		/// Value of WGL_COLOR_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_COLOR_BITS_ARB = 0x2014;

		/// <summary>
		/// Value of WGL_RED_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_RED_BITS_ARB = 0x2015;

		/// <summary>
		/// Value of WGL_RED_SHIFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_RED_SHIFT_ARB = 0x2016;

		/// <summary>
		/// Value of WGL_GREEN_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_GREEN_BITS_ARB = 0x2017;

		/// <summary>
		/// Value of WGL_GREEN_SHIFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_GREEN_SHIFT_ARB = 0x2018;

		/// <summary>
		/// Value of WGL_BLUE_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_BLUE_BITS_ARB = 0x2019;

		/// <summary>
		/// Value of WGL_BLUE_SHIFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_BLUE_SHIFT_ARB = 0x201A;

		/// <summary>
		/// Value of WGL_ALPHA_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ALPHA_BITS_ARB = 0x201B;

		/// <summary>
		/// Value of WGL_ALPHA_SHIFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ALPHA_SHIFT_ARB = 0x201C;

		/// <summary>
		/// Value of WGL_ACCUM_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCUM_BITS_ARB = 0x201D;

		/// <summary>
		/// Value of WGL_ACCUM_RED_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCUM_RED_BITS_ARB = 0x201E;

		/// <summary>
		/// Value of WGL_ACCUM_GREEN_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCUM_GREEN_BITS_ARB = 0x201F;

		/// <summary>
		/// Value of WGL_ACCUM_BLUE_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCUM_BLUE_BITS_ARB = 0x2020;

		/// <summary>
		/// Value of WGL_ACCUM_ALPHA_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_ACCUM_ALPHA_BITS_ARB = 0x2021;

		/// <summary>
		/// Value of WGL_DEPTH_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_DEPTH_BITS_ARB = 0x2022;

		/// <summary>
		/// Value of WGL_STENCIL_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_STENCIL_BITS_ARB = 0x2023;

		/// <summary>
		/// Value of WGL_AUX_BUFFERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_AUX_BUFFERS_ARB = 0x2024;

		/// <summary>
		/// Value of WGL_NO_ACCELERATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_NO_ACCELERATION_ARB = 0x2025;

		/// <summary>
		/// Value of WGL_GENERIC_ACCELERATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_GENERIC_ACCELERATION_ARB = 0x2026;

		/// <summary>
		/// Value of WGL_FULL_ACCELERATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_FULL_ACCELERATION_ARB = 0x2027;

		/// <summary>
		/// Value of WGL_SWAP_EXCHANGE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SWAP_EXCHANGE_ARB = 0x2028;

		/// <summary>
		/// Value of WGL_SWAP_COPY_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SWAP_COPY_ARB = 0x2029;

		/// <summary>
		/// Value of WGL_SWAP_UNDEFINED_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_SWAP_UNDEFINED_ARB = 0x202A;

		/// <summary>
		/// Value of WGL_TYPE_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TYPE_RGBA_ARB = 0x202B;

		/// <summary>
		/// Value of WGL_TYPE_COLORINDEX_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pixel_format")]
		public const int WGL_TYPE_COLORINDEX_ARB = 0x202C;

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
		public static bool GetPixelFormatAttribARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, int[] piValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (int* p_piValues = piValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribivARB != null, "pwglGetPixelFormatAttribivARB not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_piValues);
					CallLog("wglGetPixelFormatAttribivARB({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, piValues, retValue);
				}
			}
			DebugCheckErrors();

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
		public static bool GetPixelFormatAttribARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int[] piAttributes, float[] pfValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (float* p_pfValues = pfValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribfvARB != null, "pwglGetPixelFormatAttribfvARB not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_pfValues);
					CallLog("wglGetPixelFormatAttribfvARB({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, pfValues, retValue);
				}
			}
			DebugCheckErrors();

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
					CallLog("wglChoosePixelFormatARB({0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, nNumFormats, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
