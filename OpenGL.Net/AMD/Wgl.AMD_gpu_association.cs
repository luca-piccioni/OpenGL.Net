
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
		/// [WGL] Value of WGL_GPU_VENDOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_VENDOR_AMD = 0x1F00;

		/// <summary>
		/// [WGL] Value of WGL_GPU_RENDERER_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_RENDERER_STRING_AMD = 0x1F01;

		/// <summary>
		/// [WGL] Value of WGL_GPU_OPENGL_VERSION_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_OPENGL_VERSION_STRING_AMD = 0x1F02;

		/// <summary>
		/// [WGL] Value of WGL_GPU_FASTEST_TARGET_GPUS_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_FASTEST_TARGET_GPUS_AMD = 0x21A2;

		/// <summary>
		/// [WGL] Value of WGL_GPU_RAM_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_RAM_AMD = 0x21A3;

		/// <summary>
		/// [WGL] Value of WGL_GPU_CLOCK_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_CLOCK_AMD = 0x21A4;

		/// <summary>
		/// [WGL] Value of WGL_GPU_NUM_PIPES_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_PIPES_AMD = 0x21A5;

		/// <summary>
		/// [WGL] Value of WGL_GPU_NUM_SIMD_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_SIMD_AMD = 0x21A6;

		/// <summary>
		/// [WGL] Value of WGL_GPU_NUM_RB_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_RB_AMD = 0x21A7;

		/// <summary>
		/// [WGL] Value of WGL_GPU_NUM_SPI_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_SPI_AMD = 0x21A8;

		/// <summary>
		/// Binding for wglGetGPUIDsAMD.
		/// </summary>
		/// <param name="maxCount">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static UInt32 GetGPUIDsAMD(UInt32 maxCount, [Out] UInt32[] ids)
		{
			UInt32 retValue;

			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pwglGetGPUIDsAMD != null, "pwglGetGPUIDsAMD not implemented");
					retValue = Delegates.pwglGetGPUIDsAMD(maxCount, p_ids);
					LogCommand("wglGetGPUIDsAMD", retValue, maxCount, ids					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetGPUInfoAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="property">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dataType">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static Int32 GetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pwglGetGPUInfoAMD != null, "pwglGetGPUInfoAMD not implemented");
			retValue = Delegates.pwglGetGPUInfoAMD(id, property, dataType, size, data);
			LogCommand("wglGetGPUInfoAMD", retValue, id, property, dataType, size, data			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetContextGPUIDAMD.
		/// </summary>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static UInt32 GetContextGPUIDAMD(IntPtr hglrc)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pwglGetContextGPUIDAMD != null, "pwglGetContextGPUIDAMD not implemented");
			retValue = Delegates.pwglGetContextGPUIDAMD(hglrc);
			LogCommand("wglGetContextGPUIDAMD", retValue, hglrc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglCreateAssociatedContextAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAMD(UInt32 id)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglCreateAssociatedContextAMD != null, "pwglCreateAssociatedContextAMD not implemented");
			retValue = Delegates.pwglCreateAssociatedContextAMD(id);
			LogCommand("wglCreateAssociatedContextAMD", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglCreateAssociatedContextAttribsAMD.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="hShareContext">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static IntPtr CreateAssociatedContextAttribsAMD(UInt32 id, IntPtr hShareContext, int[] attribList)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pwglCreateAssociatedContextAttribsAMD != null, "pwglCreateAssociatedContextAttribsAMD not implemented");
					retValue = Delegates.pwglCreateAssociatedContextAttribsAMD(id, hShareContext, p_attribList);
					LogCommand("wglCreateAssociatedContextAttribsAMD", retValue, id, hShareContext, attribList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDeleteAssociatedContextAMD.
		/// </summary>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static bool DeleteAssociatedContextAMD(IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDeleteAssociatedContextAMD != null, "pwglDeleteAssociatedContextAMD not implemented");
			retValue = Delegates.pwglDeleteAssociatedContextAMD(hglrc);
			LogCommand("wglDeleteAssociatedContextAMD", retValue, hglrc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglMakeAssociatedContextCurrentAMD.
		/// </summary>
		/// <param name="hglrc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static bool MakeAssociatedContextCurrentAMD(IntPtr hglrc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglMakeAssociatedContextCurrentAMD != null, "pwglMakeAssociatedContextCurrentAMD not implemented");
			retValue = Delegates.pwglMakeAssociatedContextCurrentAMD(hglrc);
			LogCommand("wglMakeAssociatedContextCurrentAMD", retValue, hglrc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglGetCurrentAssociatedContextAMD.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static IntPtr GetCurrentAssociatedContextAMD()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglGetCurrentAssociatedContextAMD != null, "pwglGetCurrentAssociatedContextAMD not implemented");
			retValue = Delegates.pwglGetCurrentAssociatedContextAMD();
			LogCommand("wglGetCurrentAssociatedContextAMD", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglBlitContextFramebufferAMD.
		/// </summary>
		/// <param name="dstCtx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public static void BlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter)
		{
			Debug.Assert(Delegates.pwglBlitContextFramebufferAMD != null, "pwglBlitContextFramebufferAMD not implemented");
			Delegates.pwglBlitContextFramebufferAMD(dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			LogCommand("wglBlitContextFramebufferAMD", null, dstCtx, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter			);
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGPUIDsAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGPUInfoAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int32 wglGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetContextGPUIDAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglGetContextGPUIDAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglCreateAssociatedContextAMD(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAssociatedContextAttribsAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr hShareContext, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteAssociatedContextAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeAssociatedContextCurrentAMD", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeAssociatedContextCurrentAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentAssociatedContextAMD();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBlitContextFramebufferAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			[ThreadStatic]
			internal static wglGetGPUIDsAMD pwglGetGPUIDsAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 wglGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[ThreadStatic]
			internal static wglGetGPUInfoAMD pwglGetGPUInfoAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglGetContextGPUIDAMD(IntPtr hglrc);

			[ThreadStatic]
			internal static wglGetContextGPUIDAMD pwglGetContextGPUIDAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglCreateAssociatedContextAMD(UInt32 id);

			[ThreadStatic]
			internal static wglCreateAssociatedContextAMD pwglCreateAssociatedContextAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr hShareContext, int* attribList);

			[ThreadStatic]
			internal static wglCreateAssociatedContextAttribsAMD pwglCreateAssociatedContextAttribsAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDeleteAssociatedContextAMD(IntPtr hglrc);

			[ThreadStatic]
			internal static wglDeleteAssociatedContextAMD pwglDeleteAssociatedContextAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeAssociatedContextCurrentAMD(IntPtr hglrc);

			[ThreadStatic]
			internal static wglMakeAssociatedContextCurrentAMD pwglMakeAssociatedContextCurrentAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentAssociatedContextAMD();

			[ThreadStatic]
			internal static wglGetCurrentAssociatedContextAMD pwglGetCurrentAssociatedContextAMD;

			[RequiredByFeature("WGL_AMD_gpu_association")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wglBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[ThreadStatic]
			internal static wglBlitContextFramebufferAMD pwglBlitContextFramebufferAMD;

		}
	}

}
