
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
		/// Value of WGL_FRONT_COLOR_BUFFER_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		[Log(BitmaskName = "WGLColorBufferMask")]
		public const uint FRONT_COLOR_BUFFER_BIT_ARB = 0x00000001;

		/// <summary>
		/// Value of WGL_BACK_COLOR_BUFFER_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		[Log(BitmaskName = "WGLColorBufferMask")]
		public const uint BACK_COLOR_BUFFER_BIT_ARB = 0x00000002;

		/// <summary>
		/// Value of WGL_DEPTH_BUFFER_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		[Log(BitmaskName = "WGLColorBufferMask")]
		public const uint DEPTH_BUFFER_BIT_ARB = 0x00000004;

		/// <summary>
		/// Value of WGL_STENCIL_BUFFER_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		[Log(BitmaskName = "WGLColorBufferMask")]
		public const uint STENCIL_BUFFER_BIT_ARB = 0x00000008;

		/// <summary>
		/// Binding for wglCreateBufferRegionARB.
		/// </summary>
		/// <param name="hDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iLayerPlane">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="uType">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		public static IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateBufferRegionARB != null, "pwglCreateBufferRegionARB not implemented");
			retValue = Delegates.pwglCreateBufferRegionARB(hDC, iLayerPlane, uType);
			LogCommand("wglCreateBufferRegionARB", retValue, hDC, iLayerPlane, uType			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDeleteBufferRegionARB.
		/// </summary>
		/// <param name="hRegion">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		public static void DeleteBufferRegionARB(IntPtr hRegion)
		{
			Debug.Assert(Delegates.pwglDeleteBufferRegionARB != null, "pwglDeleteBufferRegionARB not implemented");
			Delegates.pwglDeleteBufferRegionARB(hRegion);
			LogCommand("wglDeleteBufferRegionARB", null, hRegion			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for wglSaveBufferRegionARB.
		/// </summary>
		/// <param name="hRegion">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		public static bool SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglSaveBufferRegionARB != null, "pwglSaveBufferRegionARB not implemented");
			retValue = Delegates.pwglSaveBufferRegionARB(hRegion, x, y, width, height);
			LogCommand("wglSaveBufferRegionARB", retValue, hRegion, x, y, width, height			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglRestoreBufferRegionARB.
		/// </summary>
		/// <param name="hRegion">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="xSrc">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="ySrc">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("WGL_ARB_buffer_region")]
		public static bool RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglRestoreBufferRegionARB != null, "pwglRestoreBufferRegionARB not implemented");
			retValue = Delegates.pwglRestoreBufferRegionARB(hRegion, x, y, width, height, xSrc, ySrc);
			LogCommand("wglRestoreBufferRegionARB", retValue, hRegion, x, y, width, height, xSrc, ySrc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglDeleteBufferRegionARB(IntPtr hRegion);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSaveBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglRestoreBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_ARB_buffer_region")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);

			[ThreadStatic]
			internal static wglCreateBufferRegionARB pwglCreateBufferRegionARB;

			[RequiredByFeature("WGL_ARB_buffer_region")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wglDeleteBufferRegionARB(IntPtr hRegion);

			[ThreadStatic]
			internal static wglDeleteBufferRegionARB pwglDeleteBufferRegionARB;

			[RequiredByFeature("WGL_ARB_buffer_region")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);

			[ThreadStatic]
			internal static wglSaveBufferRegionARB pwglSaveBufferRegionARB;

			[RequiredByFeature("WGL_ARB_buffer_region")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);

			[ThreadStatic]
			internal static wglRestoreBufferRegionARB pwglRestoreBufferRegionARB;

		}
	}

}
