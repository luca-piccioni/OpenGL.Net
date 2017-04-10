
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
		/// Value of GL_LGPU_SEPARATE_STORAGE_BIT_NVX symbol.
		/// </summary>
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		[Log(BitmaskName = "GL")]
		public const int LGPU_SEPARATE_STORAGE_BIT_NVX = 0x0800;

		/// <summary>
		/// Value of GL_MAX_LGPU_GPUS_NVX symbol.
		/// </summary>
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		public const int MAX_LGPU_GPUS_NVX = 0x92BA;

		/// <summary>
		/// Binding for glLGPUNamedBufferSubDataNVX.
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
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		public static void LGPUNamedBufferSubDataNVX(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglLGPUNamedBufferSubDataNVX != null, "pglLGPUNamedBufferSubDataNVX not implemented");
			Delegates.pglLGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, data);
			LogFunction("glLGPUNamedBufferSubDataNVX({0}, {1}, 0x{2}, {3}, 0x{4})", gpuMask, buffer, offset.ToString("X8"), size, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLGPUNamedBufferSubDataNVX.
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
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		public static void LGPUNamedBufferSubDataNVX(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				LGPUNamedBufferSubDataNVX(gpuMask, buffer, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glLGPUCopyImageSubDataNVX.
		/// </summary>
		/// <param name="sourceGpu">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="destinationGpuMask">
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
		/// <param name="srxY">
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
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		public static void LGPUCopyImageSubDataNVX(UInt32 sourceGpu, UInt32 destinationGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srxY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth)
		{
			Debug.Assert(Delegates.pglLGPUCopyImageSubDataNVX != null, "pglLGPUCopyImageSubDataNVX not implemented");
			Delegates.pglLGPUCopyImageSubDataNVX(sourceGpu, destinationGpuMask, srcName, srcTarget, srcLevel, srcX, srxY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, width, height, depth);
			LogFunction("glLGPUCopyImageSubDataNVX({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16})", sourceGpu, destinationGpuMask, srcName, LogEnumName(srcTarget), srcLevel, srcX, srxY, srcZ, dstName, LogEnumName(dstTarget), dstLevel, dstX, dstY, dstZ, width, height, depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLGPUInterlockNVX.
		/// </summary>
		[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
		public static void NVX()
		{
			Debug.Assert(Delegates.pglLGPUInterlockNVX != null, "pglLGPUInterlockNVX not implemented");
			Delegates.pglLGPUInterlockNVX();
			LogFunction("glLGPUInterlockNVX()");
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLGPUNamedBufferSubDataNVX", ExactSpelling = true)]
			internal extern static unsafe void glLGPUNamedBufferSubDataNVX(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLGPUCopyImageSubDataNVX", ExactSpelling = true)]
			internal extern static void glLGPUCopyImageSubDataNVX(UInt32 sourceGpu, UInt32 destinationGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srxY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLGPUInterlockNVX", ExactSpelling = true)]
			internal extern static void glLGPUInterlockNVX();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLGPUNamedBufferSubDataNVX(UInt32 gpuMask, UInt32 buffer, IntPtr offset, UInt32 size, IntPtr data);

			[ThreadStatic]
			internal static glLGPUNamedBufferSubDataNVX pglLGPUNamedBufferSubDataNVX;

			[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLGPUCopyImageSubDataNVX(UInt32 sourceGpu, UInt32 destinationGpuMask, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srxY, Int32 srcZ, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[ThreadStatic]
			internal static glLGPUCopyImageSubDataNVX pglLGPUCopyImageSubDataNVX;

			[RequiredByFeature("GL_NVX_linked_gpu_multicast")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLGPUInterlockNVX();

			[ThreadStatic]
			internal static glLGPUInterlockNVX pglLGPUInterlockNVX;

		}
	}

}
