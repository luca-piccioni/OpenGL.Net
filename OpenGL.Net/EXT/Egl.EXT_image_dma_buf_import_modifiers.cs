
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
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_FD_EXT = 0x3440;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_OFFSET_EXT = 0x3441;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_PITCH_EXT = 0x3442;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE0_MODIFIER_LO_EXT = 0x3443;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE0_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE0_MODIFIER_HI_EXT = 0x3444;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE1_MODIFIER_LO_EXT = 0x3445;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE1_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE1_MODIFIER_HI_EXT = 0x3446;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE2_MODIFIER_LO_EXT = 0x3447;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE2_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE2_MODIFIER_HI_EXT = 0x3448;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_MODIFIER_LO_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_MODIFIER_LO_EXT = 0x3449;

		/// <summary>
		/// [EGL] Value of EGL_DMA_BUF_PLANE3_MODIFIER_HI_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public const int DMA_BUF_PLANE3_MODIFIER_HI_EXT = 0x344A;

		/// <summary>
		/// [EGL] Binding for eglQueryDmaBufFormatsEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="max_formats">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="formats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="num_formats">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public static bool QueryDmaBufFormatsEXT(IntPtr dpy, int max_formats, int[] formats, int[] num_formats)
		{
			bool retValue;

			unsafe {
				fixed (int* p_formats = formats)
				fixed (int* p_num_formats = num_formats)
				{
					Debug.Assert(Delegates.peglQueryDmaBufFormatsEXT != null, "peglQueryDmaBufFormatsEXT not implemented");
					retValue = Delegates.peglQueryDmaBufFormatsEXT(dpy, max_formats, p_formats, p_num_formats);
					LogCommand("eglQueryDmaBufFormatsEXT", retValue, dpy, max_formats, formats, num_formats					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Binding for eglQueryDmaBufModifiersEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="max_modifiers">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modifiers">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		/// <param name="external_only">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		/// <param name="num_modifiers">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
		public static bool QueryDmaBufModifiersEXT(IntPtr dpy, int format, int max_modifiers, UInt64[] modifiers, bool[] external_only, int[] num_modifiers)
		{
			bool retValue;

			unsafe {
				fixed (UInt64* p_modifiers = modifiers)
				fixed (bool* p_external_only = external_only)
				fixed (int* p_num_modifiers = num_modifiers)
				{
					Debug.Assert(Delegates.peglQueryDmaBufModifiersEXT != null, "peglQueryDmaBufModifiersEXT not implemented");
					retValue = Delegates.peglQueryDmaBufModifiersEXT(dpy, format, max_modifiers, p_modifiers, p_external_only, p_num_modifiers);
					LogCommand("eglQueryDmaBufModifiersEXT", retValue, dpy, format, max_modifiers, modifiers, external_only, num_modifiers					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDmaBufFormatsEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDmaBufFormatsEXT(IntPtr dpy, int max_formats, int* formats, int* num_formats);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryDmaBufModifiersEXT", ExactSpelling = true)]
			internal extern static unsafe bool eglQueryDmaBufModifiersEXT(IntPtr dpy, int format, int max_modifiers, UInt64* modifiers, bool* external_only, int* num_modifiers);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDmaBufFormatsEXT(IntPtr dpy, int max_formats, int* formats, int* num_formats);

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			internal static eglQueryDmaBufFormatsEXT peglQueryDmaBufFormatsEXT;

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDmaBufModifiersEXT(IntPtr dpy, int format, int max_modifiers, UInt64* modifiers, bool* external_only, int* num_modifiers);

			[RequiredByFeature("EGL_EXT_image_dma_buf_import_modifiers")]
			internal static eglQueryDmaBufModifiersEXT peglQueryDmaBufModifiersEXT;

		}
	}

}
