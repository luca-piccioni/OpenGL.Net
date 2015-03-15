
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
		/// Value of WGL_TRANSPARENT_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("WGL_EXT_pixel_format")]
		public const int TRANSPARENT_VALUE_EXT = 0x200B;

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
