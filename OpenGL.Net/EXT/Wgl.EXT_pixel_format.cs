
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
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
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int[] piAttributes, [Out] int[] piValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (int* p_piValues = piValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribivEXT != null, "pwglGetPixelFormatAttribivEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_piValues);
					LogFunction("wglGetPixelFormatAttribivEXT(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), iPixelFormat, iLayerPlane, nAttributes, LogValue(piAttributes), LogValue(piValues), retValue);
				}
			}
			DebugCheckErrors(retValue);

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
		public static bool GetPixelFormatAttribEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int[] piAttributes, [Out] float[] pfValues)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttributes = piAttributes)
				fixed (float* p_pfValues = pfValues)
				{
					Debug.Assert(Delegates.pwglGetPixelFormatAttribfvEXT != null, "pwglGetPixelFormatAttribfvEXT not implemented");
					retValue = Delegates.pwglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes, p_piAttributes, p_pfValues);
					LogFunction("wglGetPixelFormatAttribfvEXT(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), iPixelFormat, iLayerPlane, nAttributes, LogValue(piAttributes), LogValue(pfValues), retValue);
				}
			}
			DebugCheckErrors(retValue);

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
					LogFunction("wglChoosePixelFormatEXT(0x{0}, {1}, {2}, {3}, {4}, {5}) = {6}", hdc.ToString("X8"), LogValue(piAttribIList), LogValue(pfAttribFList), nMaxFormats, LogValue(piFormats), LogValue(nNumFormats), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribivEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribfvEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglChoosePixelFormatEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);

			[ThreadStatic]
			internal static wglGetPixelFormatAttribivEXT pwglGetPixelFormatAttribivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);

			[ThreadStatic]
			internal static wglGetPixelFormatAttribfvEXT pwglGetPixelFormatAttribfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);

			[ThreadStatic]
			internal static wglChoosePixelFormatEXT pwglChoosePixelFormatEXT;

		}
	}

}
