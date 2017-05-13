
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
	public partial class Egl
	{
		/// <summary>
		/// Binding for eglExportDMABUFImageQueryMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fourcc">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="num_planes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="modifiers">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
		public static bool ExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int[] fourcc, int[] num_planes, UInt64[] modifiers)
		{
			bool retValue;

			unsafe {
				fixed (int* p_fourcc = fourcc)
				fixed (int* p_num_planes = num_planes)
				fixed (UInt64* p_modifiers = modifiers)
				{
					Debug.Assert(Delegates.peglExportDMABUFImageQueryMESA != null, "peglExportDMABUFImageQueryMESA not implemented");
					retValue = Delegates.peglExportDMABUFImageQueryMESA(dpy, image, p_fourcc, p_num_planes, p_modifiers);
					LogCommand("eglExportDMABUFImageQueryMESA", retValue, dpy, image, fourcc, num_planes, modifiers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglExportDMABUFImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="fds">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="strides">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="offsets">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
		public static bool ExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int[] fds, int[] strides, int[] offsets)
		{
			bool retValue;

			unsafe {
				fixed (int* p_fds = fds)
				fixed (int* p_strides = strides)
				fixed (int* p_offsets = offsets)
				{
					Debug.Assert(Delegates.peglExportDMABUFImageMESA != null, "peglExportDMABUFImageMESA not implemented");
					retValue = Delegates.peglExportDMABUFImageMESA(dpy, image, p_fds, p_strides, p_offsets);
					LogCommand("eglExportDMABUFImageMESA", retValue, dpy, image, fds, strides, offsets					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglExportDMABUFImageQueryMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglExportDMABUFImageMESA", ExactSpelling = true)]
			internal extern static unsafe bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			internal static eglExportDMABUFImageQueryMESA peglExportDMABUFImageQueryMESA;

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

			[RequiredByFeature("EGL_MESA_image_dma_buf_export")]
			internal static eglExportDMABUFImageMESA peglExportDMABUFImageMESA;

		}
	}

}
