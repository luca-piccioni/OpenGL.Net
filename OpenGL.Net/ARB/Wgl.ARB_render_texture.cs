
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
		/// Value of WGL_BIND_TO_TEXTURE_RGB_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BIND_TO_TEXTURE_RGB_ARB = 0x2070;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BIND_TO_TEXTURE_RGBA_ARB = 0x2071;

		/// <summary>
		/// Value of WGL_TEXTURE_FORMAT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_FORMAT_ARB = 0x2072;

		/// <summary>
		/// Value of WGL_TEXTURE_TARGET_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_TARGET_ARB = 0x2073;

		/// <summary>
		/// Value of WGL_MIPMAP_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int MIPMAP_TEXTURE_ARB = 0x2074;

		/// <summary>
		/// Value of WGL_TEXTURE_RGB_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_RGB_ARB = 0x2075;

		/// <summary>
		/// Value of WGL_TEXTURE_RGBA_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_RGBA_ARB = 0x2076;

		/// <summary>
		/// Value of WGL_NO_TEXTURE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int NO_TEXTURE_ARB = 0x2077;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_ARB = 0x2078;

		/// <summary>
		/// Value of WGL_TEXTURE_1D_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_1D_ARB = 0x2079;

		/// <summary>
		/// Value of WGL_TEXTURE_2D_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_2D_ARB = 0x207A;

		/// <summary>
		/// Value of WGL_MIPMAP_LEVEL_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int MIPMAP_LEVEL_ARB = 0x207B;

		/// <summary>
		/// Value of WGL_CUBE_MAP_FACE_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int CUBE_MAP_FACE_ARB = 0x207C;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x207D;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x207E;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x207F;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x2080;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x2081;

		/// <summary>
		/// Value of WGL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x2082;

		/// <summary>
		/// Value of WGL_FRONT_LEFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int FRONT_LEFT_ARB = 0x2083;

		/// <summary>
		/// Value of WGL_FRONT_RIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int FRONT_RIGHT_ARB = 0x2084;

		/// <summary>
		/// Value of WGL_BACK_LEFT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BACK_LEFT_ARB = 0x2085;

		/// <summary>
		/// Value of WGL_BACK_RIGHT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int BACK_RIGHT_ARB = 0x2086;

		/// <summary>
		/// Value of WGL_AUX0_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX0_ARB = 0x2087;

		/// <summary>
		/// Value of WGL_AUX1_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX1_ARB = 0x2088;

		/// <summary>
		/// Value of WGL_AUX2_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX2_ARB = 0x2089;

		/// <summary>
		/// Value of WGL_AUX3_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX3_ARB = 0x208A;

		/// <summary>
		/// Value of WGL_AUX4_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX4_ARB = 0x208B;

		/// <summary>
		/// Value of WGL_AUX5_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX5_ARB = 0x208C;

		/// <summary>
		/// Value of WGL_AUX6_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX6_ARB = 0x208D;

		/// <summary>
		/// Value of WGL_AUX7_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX7_ARB = 0x208E;

		/// <summary>
		/// Value of WGL_AUX8_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX8_ARB = 0x208F;

		/// <summary>
		/// Value of WGL_AUX9_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public const int AUX9_ARB = 0x2090;

		/// <summary>
		/// Binding for wglBindTexImageARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool BindTexImageARB(IntPtr hPbuffer, int iBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglBindTexImageARB != null, "pwglBindTexImageARB not implemented");
			retValue = Delegates.pwglBindTexImageARB(hPbuffer, iBuffer);
			LogFunction("wglBindTexImageARB(0x{0}, {1}) = {2}", hPbuffer.ToString("X8"), iBuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleaseTexImageARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iBuffer">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglReleaseTexImageARB != null, "pwglReleaseTexImageARB not implemented");
			retValue = Delegates.pwglReleaseTexImageARB(hPbuffer, iBuffer);
			LogFunction("wglReleaseTexImageARB(0x{0}, {1}) = {2}", hPbuffer.ToString("X8"), iBuffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglSetPbufferAttribARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_render_texture")]
		public static bool SetPbufferAttribARB(IntPtr hPbuffer, int[] piAttribList)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglSetPbufferAttribARB != null, "pwglSetPbufferAttribARB not implemented");
					retValue = Delegates.pwglSetPbufferAttribARB(hPbuffer, p_piAttribList);
					LogFunction("wglSetPbufferAttribARB(0x{0}, {1}) = {2}", hPbuffer.ToString("X8"), LogValue(piAttribList), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetPbufferAttribARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

			[ThreadStatic]
			internal static wglBindTexImageARB pwglBindTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

			[ThreadStatic]
			internal static wglReleaseTexImageARB pwglReleaseTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

			[ThreadStatic]
			internal static wglSetPbufferAttribARB pwglSetPbufferAttribARB;

		}
	}

}
