
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_UPLOAD_GPU_MASK_NVX symbol.
		/// </summary>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public const int UPLOAD_GPU_MASK_NVX = 0x954A;

		/// <summary>
		/// [GL] glUploadGpuMaskNVX: Binding for glUploadGpuMaskNVX.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static void UploadGpuMaskNVX(uint mask)
		{
			Debug.Assert(Delegates.pglUploadGpuMaskNVX != null, "pglUploadGpuMaskNVX not implemented");
			Delegates.pglUploadGpuMaskNVX(mask);
			LogCommand("glUploadGpuMaskNVX", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMulticastViewportArrayvNVX: Binding for glMulticastViewportArrayvNVX.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static void MulticastViewportArrayvNVX(uint gpu, uint first, int count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMulticastViewportArrayvNVX != null, "pglMulticastViewportArrayvNVX not implemented");
					Delegates.pglMulticastViewportArrayvNVX(gpu, first, count, p_v);
					LogCommand("glMulticastViewportArrayvNVX", null, gpu, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMulticastViewportPositionWScaleNVX: Binding for glMulticastViewportPositionWScaleNVX.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="xcoeff">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ycoeff">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static void MulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff)
		{
			Debug.Assert(Delegates.pglMulticastViewportPositionWScaleNVX != null, "pglMulticastViewportPositionWScaleNVX not implemented");
			Delegates.pglMulticastViewportPositionWScaleNVX(gpu, index, xcoeff, ycoeff);
			LogCommand("glMulticastViewportPositionWScaleNVX", null, gpu, index, xcoeff, ycoeff			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMulticastScissorArrayvNVX: Binding for glMulticastScissorArrayvNVX.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static void MulticastScissorArrayvNVX(uint gpu, uint first, int count, int[] v)
		{
			unsafe {
				fixed (int* p_v = v)
				{
					Debug.Assert(Delegates.pglMulticastScissorArrayvNVX != null, "pglMulticastScissorArrayvNVX not implemented");
					Delegates.pglMulticastScissorArrayvNVX(gpu, first, count, p_v);
					LogCommand("glMulticastScissorArrayvNVX", null, gpu, first, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glAsyncCopyBufferSubDataNVX: Binding for glAsyncCopyBufferSubDataNVX.
		/// </summary>
		/// <param name="waitSemaphoreArray">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="fenceValueArray">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		/// <param name="readGpu">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="writeGpuMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="readBuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="writeBuffer">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="signalSemaphoreArray">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="signalValueArray">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static uint AsyncCopyBufferSubDataNVX(uint[] waitSemaphoreArray, ulong[] fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, uint size, uint[] signalSemaphoreArray, ulong[] signalValueArray)
		{
			uint retValue;

			unsafe {
				fixed (uint* p_waitSemaphoreArray = waitSemaphoreArray)
				fixed (ulong* p_fenceValueArray = fenceValueArray)
				fixed (uint* p_signalSemaphoreArray = signalSemaphoreArray)
				fixed (ulong* p_signalValueArray = signalValueArray)
				{
					Debug.Assert(Delegates.pglAsyncCopyBufferSubDataNVX != null, "pglAsyncCopyBufferSubDataNVX not implemented");
					retValue = Delegates.pglAsyncCopyBufferSubDataNVX(waitSemaphoreArray.Length, p_waitSemaphoreArray, p_fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreArray.Length, p_signalSemaphoreArray, p_signalValueArray);
					LogCommand("glAsyncCopyBufferSubDataNVX", retValue, waitSemaphoreArray.Length, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size, signalSemaphoreArray.Length, signalSemaphoreArray, signalValueArray					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glAsyncCopyImageSubDataNVX: Binding for glAsyncCopyImageSubDataNVX.
		/// </summary>
		/// <param name="waitSemaphoreArray">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="waitValueArray">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		/// <param name="srcGpu">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="dstGpuMask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="srcName">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcWidth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcHeight">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcDepth">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="signalSemaphoreArray">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="signalValueArray">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_gpu_multicast2")]
		public static uint AsyncCopyImageSubDataNVX(uint[] waitSemaphoreArray, ulong[] waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, uint[] signalSemaphoreArray, ulong[] signalValueArray)
		{
			uint retValue;

			unsafe {
				fixed (uint* p_waitSemaphoreArray = waitSemaphoreArray)
				fixed (ulong* p_waitValueArray = waitValueArray)
				fixed (uint* p_signalSemaphoreArray = signalSemaphoreArray)
				fixed (ulong* p_signalValueArray = signalValueArray)
				{
					Debug.Assert(Delegates.pglAsyncCopyImageSubDataNVX != null, "pglAsyncCopyImageSubDataNVX not implemented");
					retValue = Delegates.pglAsyncCopyImageSubDataNVX(waitSemaphoreArray.Length, p_waitSemaphoreArray, p_waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreArray.Length, p_signalSemaphoreArray, p_signalValueArray);
					LogCommand("glAsyncCopyImageSubDataNVX", retValue, waitSemaphoreArray.Length, waitSemaphoreArray, waitValueArray, srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth, signalSemaphoreArray.Length, signalSemaphoreArray, signalValueArray					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glUploadGpuMaskNVX(uint mask);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glUploadGpuMaskNVX pglUploadGpuMaskNVX;

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMulticastViewportArrayvNVX(uint gpu, uint first, int count, float* v);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glMulticastViewportArrayvNVX pglMulticastViewportArrayvNVX;

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMulticastViewportPositionWScaleNVX(uint gpu, uint index, float xcoeff, float ycoeff);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glMulticastViewportPositionWScaleNVX pglMulticastViewportPositionWScaleNVX;

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMulticastScissorArrayvNVX(uint gpu, uint first, int count, int* v);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glMulticastScissorArrayvNVX pglMulticastScissorArrayvNVX;

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate uint glAsyncCopyBufferSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* fenceValueArray, uint readGpu, uint writeGpuMask, uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, uint size, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glAsyncCopyBufferSubDataNVX pglAsyncCopyBufferSubDataNVX;

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate uint glAsyncCopyImageSubDataNVX(int waitSemaphoreCount, uint* waitSemaphoreArray, ulong* waitValueArray, uint srcGpu, uint dstGpuMask, uint srcName, int srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, int dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth, int signalSemaphoreCount, uint* signalSemaphoreArray, ulong* signalValueArray);

			[RequiredByFeature("GL_NVX_gpu_multicast2")]
			[ThreadStatic]
			internal static glAsyncCopyImageSubDataNVX pglAsyncCopyImageSubDataNVX;

		}
	}

}