
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
		/// [WGL] Value of WGL_DRAW_TO_PBUFFER_ARB symbol.
		/// </summary>
		[AliasOf("WGL_DRAW_TO_PBUFFER_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int DRAW_TO_PBUFFER_ARB = 0x202D;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_PIXELS_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_PIXELS_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_PIXELS_ARB = 0x202E;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_WIDTH_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_WIDTH_ARB = 0x202F;

		/// <summary>
		/// [WGL] Value of WGL_MAX_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_MAX_PBUFFER_HEIGHT_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int MAX_PBUFFER_HEIGHT_ARB = 0x2030;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_LARGEST_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_LARGEST_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_LARGEST_ARB = 0x2033;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_WIDTH_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_WIDTH_ARB = 0x2034;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("WGL_PBUFFER_HEIGHT_EXT")]
		[RequiredByFeature("WGL_ARB_pbuffer")]
		[RequiredByFeature("WGL_EXT_pbuffer")]
		public const int PBUFFER_HEIGHT_ARB = 0x2035;

		/// <summary>
		/// [WGL] Value of WGL_PBUFFER_LOST_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_pbuffer")]
		public const int PBUFFER_LOST_ARB = 0x2036;

		/// <summary>
		/// [WGL] Binding for wglCreatePbufferARB.
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
					LogCommand("wglCreatePbufferARB", retValue, hDC, iPixelFormat, iWidth, iHeight, piAttribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglGetPbufferDCARB.
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
			LogCommand("wglGetPbufferDCARB", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglReleasePbufferDCARB.
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
			LogCommand("wglReleasePbufferDCARB", retValue, hPbuffer, hDC			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDestroyPbufferARB.
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
			LogCommand("wglDestroyPbufferARB", retValue, hPbuffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglQueryPbufferARB.
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
					LogCommand("wglQueryPbufferARB", retValue, hPbuffer, iAttribute, piValue					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglCreatePbufferARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglGetPbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglReleasePbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglDestroyPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyPbufferARB(IntPtr hPbuffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "wglQueryPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[ThreadStatic]
			internal static wglCreatePbufferARB pwglCreatePbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[ThreadStatic]
			internal static wglGetPbufferDCARB pwglGetPbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[ThreadStatic]
			internal static wglReleasePbufferDCARB pwglReleasePbufferDCARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglDestroyPbufferARB(IntPtr hPbuffer);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[ThreadStatic]
			internal static wglDestroyPbufferARB pwglDestroyPbufferARB;

			[RequiredByFeature("WGL_ARB_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

			[RequiredByFeature("WGL_ARB_pbuffer")]
			[ThreadStatic]
			internal static wglQueryPbufferARB pwglQueryPbufferARB;

		}
	}

}
