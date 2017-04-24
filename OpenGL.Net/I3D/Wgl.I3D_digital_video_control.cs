
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = 0x2050;

		/// <summary>
		/// Value of WGL_DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = 0x2051;

		/// <summary>
		/// Value of WGL_DIGITAL_VIDEO_CURSOR_INCLUDED_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = 0x2052;

		/// <summary>
		/// Value of WGL_DIGITAL_VIDEO_GAMMA_CORRECTED_I3D symbol.
		/// </summary>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public const int DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = 0x2053;

		/// <summary>
		/// Binding for wglGetDigitalVideoParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public static bool GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglGetDigitalVideoParametersI3D != null, "pwglGetDigitalVideoParametersI3D not implemented");
					retValue = Delegates.pwglGetDigitalVideoParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglGetDigitalVideoParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglSetDigitalVideoParametersI3D.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_I3D_digital_video_control")]
		public static bool SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglSetDigitalVideoParametersI3D != null, "pwglSetDigitalVideoParametersI3D not implemented");
					retValue = Delegates.pwglSetDigitalVideoParametersI3D(hDC, iAttribute, p_piValue);
					LogCommand("wglSetDigitalVideoParametersI3D", retValue, hDC, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetDigitalVideoParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetDigitalVideoParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_I3D_digital_video_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[ThreadStatic]
			internal static wglGetDigitalVideoParametersI3D pwglGetDigitalVideoParametersI3D;

			[RequiredByFeature("WGL_I3D_digital_video_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[ThreadStatic]
			internal static wglSetDigitalVideoParametersI3D pwglSetDigitalVideoParametersI3D;

		}
	}

}
