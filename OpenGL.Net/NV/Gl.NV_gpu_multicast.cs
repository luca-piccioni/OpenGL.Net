
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PER_GPU_STORAGE_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		[Log(BitmaskName = "GL")]
		public const int PER_GPU_STORAGE_BIT_NV = 0x0800;

		/// <summary>
		/// Value of GL_MULTICAST_GPUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public const int MULTICAST_GPUS_NV = 0x92BA;

		/// <summary>
		/// Value of GL_RENDER_GPU_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public const int RENDER_GPU_MASK_NV = 0x9558;

		/// <summary>
		/// Value of GL_PER_GPU_STORAGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public const int PER_GPU_STORAGE_NV = 0x9548;

		/// <summary>
		/// Value of GL_MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public const int MULTICAST_PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9549;

		/// <summary>
		/// Binding for glRenderGpuMaskNV.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void RenderGpuMaskNV(UInt32 mask)
		{
			Debug.Assert(Delegates.pglRenderGpuMaskNV != null, "pglRenderGpuMaskNV not implemented");
			Delegates.pglRenderGpuMaskNV(mask);
			LogFunction("glRenderGpuMaskNV({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastBufferSubDataNV.
		/// </summary>
		/// <param name="gpuMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastBufferSubDataNV(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			unsafe {
				{
					Debug.Assert(Delegates.pglMulticastBufferSubDataNV != null, "pglMulticastBufferSubDataNV not implemented");
					Delegates.pglMulticastBufferSubDataNV(gpuMask, buffer, offset, size, data.ToPointer());
					LogFunction("glMulticastBufferSubDataNV({0}, {1}, 0x{2}, {3}, 0x{4})", gpuMask, buffer, offset.ToString("X8"), size, data.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastBufferSubDataNV.
		/// </summary>
		/// <param name="gpuMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastBufferSubDataNV(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				MulticastBufferSubDataNV(gpuMask, buffer, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glMulticastCopyBufferSubDataNV.
		/// </summary>
		/// <param name="readGpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="writeGpuMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="readBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="writeBuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="readOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="writeOffset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastCopyBufferSubDataNV(UInt32 readGpu, UInt32 writeGpuMask, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglMulticastCopyBufferSubDataNV != null, "pglMulticastCopyBufferSubDataNV not implemented");
			Delegates.pglMulticastCopyBufferSubDataNV(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);
			LogFunction("glMulticastCopyBufferSubDataNV({0}, {1}, {2}, {3}, 0x{4}, 0x{5}, {6})", readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset.ToString("X8"), writeOffset.ToString("X8"), size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastCopyImageSubDataNV.
		/// </summary>
		/// <param name="srcGpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstGpuMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstName">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstTarget">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstZ">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcWidth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcHeight">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcDepth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastCopyImageSubDataNV(UInt32 srcGpu, UInt32 dstGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth)
		{
			Debug.Assert(Delegates.pglMulticastCopyImageSubDataNV != null, "pglMulticastCopyImageSubDataNV not implemented");
			Delegates.pglMulticastCopyImageSubDataNV(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			LogFunction("glMulticastCopyImageSubDataNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})", srcGpu, dstGpuMask, srcName, LogEnumName(srcTarget), srcLevel, srcX, srcY, srcZ, dstName, LogEnumName(dstTarget), dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastBlitFramebufferNV.
		/// </summary>
		/// <param name="srcGpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="dstGpu">
		/// A <see cref="T:UInt32"/>.
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
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastBlitFramebufferNV(UInt32 srcGpu, UInt32 dstGpu, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter)
		{
			Debug.Assert(Delegates.pglMulticastBlitFramebufferNV != null, "pglMulticastBlitFramebufferNV not implemented");
			Delegates.pglMulticastBlitFramebufferNV(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			LogFunction("glMulticastBlitFramebufferNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, LogEnumName(filter));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastFramebufferSampleLocationsfvNV.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastFramebufferSampleLocationsfvNV(UInt32 gpu, UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglMulticastFramebufferSampleLocationsfvNV != null, "pglMulticastFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglMulticastFramebufferSampleLocationsfvNV(gpu, framebuffer, start, count, p_v);
					LogFunction("glMulticastFramebufferSampleLocationsfvNV({0}, {1}, {2}, {3}, {4})", gpu, framebuffer, start, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastBarrierNV.
		/// </summary>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastBarrierNV()
		{
			Debug.Assert(Delegates.pglMulticastBarrierNV != null, "pglMulticastBarrierNV not implemented");
			Delegates.pglMulticastBarrierNV();
			LogFunction("glMulticastBarrierNV()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastWaitSyncNV.
		/// </summary>
		/// <param name="signalGpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="waitGpuMask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastWaitSyncNV(UInt32 signalGpu, UInt32 waitGpuMask)
		{
			Debug.Assert(Delegates.pglMulticastWaitSyncNV != null, "pglMulticastWaitSyncNV not implemented");
			Delegates.pglMulticastWaitSyncNV(signalGpu, waitGpuMask);
			LogFunction("glMulticastWaitSyncNV({0}, {1})", signalGpu, waitGpuMask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastGetQueryObjectivNV.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastGetQueryObjectivNV(UInt32 gpu, UInt32 id, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMulticastGetQueryObjectivNV != null, "pglMulticastGetQueryObjectivNV not implemented");
					Delegates.pglMulticastGetQueryObjectivNV(gpu, id, pname, p_params);
					LogFunction("glMulticastGetQueryObjectivNV({0}, {1}, {2}, {3})", gpu, id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastGetQueryObjectuivNV.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastGetQueryObjectuivNV(UInt32 gpu, UInt32 id, Int32 pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMulticastGetQueryObjectuivNV != null, "pglMulticastGetQueryObjectuivNV not implemented");
					Delegates.pglMulticastGetQueryObjectuivNV(gpu, id, pname, p_params);
					LogFunction("glMulticastGetQueryObjectuivNV({0}, {1}, {2}, {3})", gpu, id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastGetQueryObjecti64vNV.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastGetQueryObjecti64vNV(UInt32 gpu, UInt32 id, Int32 pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglMulticastGetQueryObjecti64vNV != null, "pglMulticastGetQueryObjecti64vNV not implemented");
					Delegates.pglMulticastGetQueryObjecti64vNV(gpu, id, pname, p_params);
					LogFunction("glMulticastGetQueryObjecti64vNV({0}, {1}, {2}, {3})", gpu, id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMulticastGetQueryObjectui64vNV.
		/// </summary>
		/// <param name="gpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_gpu_multicast")]
		public static void MulticastGetQueryObjectui64vNV(UInt32 gpu, UInt32 id, Int32 pname, UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglMulticastGetQueryObjectui64vNV != null, "pglMulticastGetQueryObjectui64vNV not implemented");
					Delegates.pglMulticastGetQueryObjectui64vNV(gpu, id, pname, p_params);
					LogFunction("glMulticastGetQueryObjectui64vNV({0}, {1}, {2}, {3})", gpu, id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderGpuMaskNV", ExactSpelling = true)]
			internal extern static void glRenderGpuMaskNV(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastBufferSubDataNV(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, void* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastCopyBufferSubDataNV(UInt32 readGpu, UInt32 writeGpuMask, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastCopyImageSubDataNV", ExactSpelling = true)]
			internal extern static void glMulticastCopyImageSubDataNV(UInt32 srcGpu, UInt32 dstGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastBlitFramebufferNV", ExactSpelling = true)]
			internal extern static void glMulticastBlitFramebufferNV(UInt32 srcGpu, UInt32 dstGpu, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastFramebufferSampleLocationsfvNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastFramebufferSampleLocationsfvNV(UInt32 gpu, UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastBarrierNV", ExactSpelling = true)]
			internal extern static void glMulticastBarrierNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastWaitSyncNV", ExactSpelling = true)]
			internal extern static void glMulticastWaitSyncNV(UInt32 signalGpu, UInt32 waitGpuMask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastGetQueryObjectivNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastGetQueryObjectivNV(UInt32 gpu, UInt32 id, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastGetQueryObjectuivNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastGetQueryObjectuivNV(UInt32 gpu, UInt32 id, Int32 pname, UInt32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastGetQueryObjecti64vNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastGetQueryObjecti64vNV(UInt32 gpu, UInt32 id, Int32 pname, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMulticastGetQueryObjectui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glMulticastGetQueryObjectui64vNV(UInt32 gpu, UInt32 id, Int32 pname, UInt64* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderGpuMaskNV(UInt32 mask);

			[ThreadStatic]
			internal static glRenderGpuMaskNV pglRenderGpuMaskNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastBufferSubDataNV(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, void* data);

			[ThreadStatic]
			internal static glMulticastBufferSubDataNV pglMulticastBufferSubDataNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastCopyBufferSubDataNV(UInt32 readGpu, UInt32 writeGpuMask, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[ThreadStatic]
			internal static glMulticastCopyBufferSubDataNV pglMulticastCopyBufferSubDataNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMulticastCopyImageSubDataNV(UInt32 srcGpu, UInt32 dstGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);

			[ThreadStatic]
			internal static glMulticastCopyImageSubDataNV pglMulticastCopyImageSubDataNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMulticastBlitFramebufferNV(UInt32 srcGpu, UInt32 dstGpu, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[ThreadStatic]
			internal static glMulticastBlitFramebufferNV pglMulticastBlitFramebufferNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastFramebufferSampleLocationsfvNV(UInt32 gpu, UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glMulticastFramebufferSampleLocationsfvNV pglMulticastFramebufferSampleLocationsfvNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMulticastBarrierNV();

			[ThreadStatic]
			internal static glMulticastBarrierNV pglMulticastBarrierNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMulticastWaitSyncNV(UInt32 signalGpu, UInt32 waitGpuMask);

			[ThreadStatic]
			internal static glMulticastWaitSyncNV pglMulticastWaitSyncNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastGetQueryObjectivNV(UInt32 gpu, UInt32 id, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMulticastGetQueryObjectivNV pglMulticastGetQueryObjectivNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastGetQueryObjectuivNV(UInt32 gpu, UInt32 id, Int32 pname, UInt32* @params);

			[ThreadStatic]
			internal static glMulticastGetQueryObjectuivNV pglMulticastGetQueryObjectuivNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastGetQueryObjecti64vNV(UInt32 gpu, UInt32 id, Int32 pname, Int64* @params);

			[ThreadStatic]
			internal static glMulticastGetQueryObjecti64vNV pglMulticastGetQueryObjecti64vNV;

			[RequiredByFeature("GL_NV_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMulticastGetQueryObjectui64vNV(UInt32 gpu, UInt32 id, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glMulticastGetQueryObjectui64vNV pglMulticastGetQueryObjectui64vNV;

		}
	}

}
