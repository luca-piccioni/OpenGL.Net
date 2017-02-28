
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of WGL_DRAW_TO_PBUFFER_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DRAW_TO_PBUFFER_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int DRAW_TO_PBUFFER_ARB = 0x202D;

		/// <summary>
		/// Value of WGL_MAX_PBUFFER_PIXELS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_PIXELS_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_PIXELS_ARB = 0x202E;

		/// <summary>
		/// Value of WGL_MAX_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_WIDTH_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_WIDTH_ARB = 0x202F;

		/// <summary>
		/// Value of WGL_MAX_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_HEIGHT_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_HEIGHT_ARB = 0x2030;

		/// <summary>
		/// Value of WGL_PBUFFER_LARGEST_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_LARGEST_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_LARGEST_ARB = 0x2033;

		/// <summary>
		/// Value of WGL_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_WIDTH_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_WIDTH_ARB = 0x2034;

		/// <summary>
		/// Value of WGL_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_HEIGHT_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_HEIGHT_ARB = 0x2035;

		/// <summary>
		/// Value of WGL_PBUFFER_LOST_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public const int PBUFFER_LOST_ARB = 0x2036;

		/// <summary>
		/// Binding for wglCreatePbufferARB.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iPixelFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iWidth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="iHeight">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piAttribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_piAttribList = piAttribList)
				{
					Debug.Assert(Delegates.pwglCreatePbufferARB != null, "pwglCreatePbufferARB not implemented");
					retValue = Delegates.pwglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, p_piAttribList);
					LogFunction("wglCreatePbufferARB(0x{0}, {1}, {2}, {3}, {4}) = {5}", hDC.ToString("X8"), iPixelFormat, iWidth, iHeight, LogValue(piAttribList), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetPbufferDCARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static IntPtr GetPbufferDCARB(IntPtr hPbuffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetPbufferDCARB != null, "pwglGetPbufferDCARB not implemented");
			retValue = Delegates.pwglGetPbufferDCARB(hPbuffer);
			LogFunction("wglGetPbufferDCARB(0x{0}) = {1}", hPbuffer.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglReleasePbufferDCARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC)
		{
			int retValue;

			Debug.Assert(Delegates.pwglReleasePbufferDCARB != null, "pwglReleasePbufferDCARB not implemented");
			retValue = Delegates.pwglReleasePbufferDCARB(hPbuffer, hDC);
			LogFunction("wglReleasePbufferDCARB(0x{0}, 0x{1}) = {2}", hPbuffer.ToString("X8"), hDC.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDestroyPbufferARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static bool DestroyPbufferARB(IntPtr hPbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDestroyPbufferARB != null, "pwglDestroyPbufferARB not implemented");
			retValue = Delegates.pwglDestroyPbufferARB(hPbuffer);
			LogFunction("wglDestroyPbufferARB(0x{0}) = {1}", hPbuffer.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglQueryPbufferARB.
		/// </summary>
		/// <param name="hPbuffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iAttribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="piValue">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public static bool QueryPbufferARB(IntPtr hPbuffer, int iAttribute, int[] piValue)
		{
			bool retValue;

			unsafe {
				fixed (int* p_piValue = piValue)
				{
					Debug.Assert(Delegates.pwglQueryPbufferARB != null, "pwglQueryPbufferARB not implemented");
					retValue = Delegates.pwglQueryPbufferARB(hPbuffer, iAttribute, p_piValue);
					LogFunction("wglQueryPbufferARB(0x{0}, {1}, {2}) = {3}", hPbuffer.ToString("X8"), iAttribute, LogValue(piValue), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreatePbufferARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleasePbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyPbufferARB(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_pbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[ThreadStatic]
			internal static wglCreatePbufferARB pwglCreatePbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			[ThreadStatic]
			internal static wglGetPbufferDCARB pwglGetPbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			[ThreadStatic]
			internal static wglReleasePbufferDCARB pwglReleasePbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDestroyPbufferARB(IntPtr hPbuffer);

			[ThreadStatic]
			internal static wglDestroyPbufferARB pwglDestroyPbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

			[ThreadStatic]
			internal static wglQueryPbufferARB pwglQueryPbufferARB;

		}
	}

}
