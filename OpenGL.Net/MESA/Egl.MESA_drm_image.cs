
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_DRM_BUFFER_FORMAT_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_FORMAT_MESA = 0x31D0;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_USE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_USE_MESA = 0x31D1;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_FORMAT_ARGB32_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_FORMAT_ARGB32_MESA = 0x31D2;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_MESA = 0x31D3;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_STRIDE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const int DRM_BUFFER_STRIDE_MESA = 0x31D4;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_USE_SCANOUT_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const uint DRM_BUFFER_USE_SCANOUT_MESA = 0x00000001;

		/// <summary>
		/// Value of EGL_DRM_BUFFER_USE_SHARE_MESA symbol.
		/// </summary>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public const uint DRM_BUFFER_USE_SHARE_MESA = 0x00000002;

		/// <summary>
		/// Binding for eglCreateDRMImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public static IntPtr CreateDRMImageMESA(IntPtr dpy, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateDRMImageMESA != null, "peglCreateDRMImageMESA not implemented");
					retValue = Delegates.peglCreateDRMImageMESA(dpy, p_attrib_list);
					CallLog("eglCreateDRMImageMESA(0x{0}, {1}) = {2}", dpy.ToString("X8"), attrib_list, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglExportDRMImageMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="handle">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_MESA_drm_image")]
		public static IntPtr ExportDRMImageMESA(IntPtr dpy, IntPtr image, int[] name, int[] handle, int[] stride)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_name = name)
				fixed (int* p_handle = handle)
				fixed (int* p_stride = stride)
				{
					Debug.Assert(Delegates.peglExportDRMImageMESA != null, "peglExportDRMImageMESA not implemented");
					retValue = Delegates.peglExportDRMImageMESA(dpy, image, p_name, p_handle, p_stride);
					CallLog("eglExportDRMImageMESA(0x{0}, 0x{1}, {2}, {3}, {4}) = {5}", dpy.ToString("X8"), image.ToString("X8"), name, handle, stride, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

	}

}
