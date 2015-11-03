
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
		/// Value of WGL_GPU_VENDOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_VENDOR_AMD = 0x1F00;

		/// <summary>
		/// Value of WGL_GPU_RENDERER_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_RENDERER_STRING_AMD = 0x1F01;

		/// <summary>
		/// Value of WGL_GPU_OPENGL_VERSION_STRING_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_OPENGL_VERSION_STRING_AMD = 0x1F02;

		/// <summary>
		/// Value of WGL_GPU_FASTEST_TARGET_GPUS_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_FASTEST_TARGET_GPUS_AMD = 0x21A2;

		/// <summary>
		/// Value of WGL_GPU_RAM_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_RAM_AMD = 0x21A3;

		/// <summary>
		/// Value of WGL_GPU_CLOCK_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_CLOCK_AMD = 0x21A4;

		/// <summary>
		/// Value of WGL_GPU_NUM_PIPES_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_PIPES_AMD = 0x21A5;

		/// <summary>
		/// Value of WGL_GPU_NUM_SIMD_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_SIMD_AMD = 0x21A6;

		/// <summary>
		/// Value of WGL_GPU_NUM_RB_AMD symbol.
		/// </summary>
		[RequiredByFeature("WGL_AMD_gpu_association")]
		public const int GPU_NUM_RB_AMD = 0x21A7;

		/// <summary>
		/// Value of WGL_GPU_NUM_SPI_AMD symbol.
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
					CallLog("wglGetGPUIDsAMD({0}, {1}) = {2}", maxCount, ids, retValue);
				}
			}

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
			CallLog("wglGetGPUInfoAMD({0}, {1}, {2}, {3}, 0x{4}) = {5}", id, property, dataType, size, data.ToString("X8"), retValue);

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
			CallLog("wglGetContextGPUIDAMD(0x{0}) = {1}", hglrc.ToString("X8"), retValue);

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
			CallLog("wglCreateAssociatedContextAMD({0}) = {1}", id, retValue.ToString("X8"));

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
					CallLog("wglCreateAssociatedContextAttribsAMD({0}, 0x{1}, {2}) = {3}", id, hShareContext.ToString("X8"), attribList, retValue.ToString("X8"));
				}
			}

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
			CallLog("wglDeleteAssociatedContextAMD(0x{0}) = {1}", hglrc.ToString("X8"), retValue);

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
			CallLog("wglMakeAssociatedContextCurrentAMD(0x{0}) = {1}", hglrc.ToString("X8"), retValue);

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
			CallLog("wglGetCurrentAssociatedContextAMD() = {0}", retValue.ToString("X8"));

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
			CallLog("wglBlitContextFramebufferAMD(0x{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", dstCtx.ToString("X8"), srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
		}

	}

}
