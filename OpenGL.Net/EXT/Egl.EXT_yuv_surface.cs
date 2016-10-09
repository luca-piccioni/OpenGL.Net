
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
		/// Value of EGL_YUV_ORDER_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_EXT = 0x3301;

		/// <summary>
		/// Value of EGL_YUV_SUBSAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_SUBSAMPLE_EXT = 0x3312;

		/// <summary>
		/// Value of EGL_YUV_DEPTH_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_DEPTH_RANGE_EXT = 0x3317;

		/// <summary>
		/// Value of EGL_YUV_CSC_STANDARD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_CSC_STANDARD_EXT = 0x330A;

		/// <summary>
		/// Value of EGL_YUV_PLANE_BPP_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_PLANE_BPP_EXT = 0x331A;

		/// <summary>
		/// Value of EGL_YUV_ORDER_YUV_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_YUV_EXT = 0x3302;

		/// <summary>
		/// Value of EGL_YUV_ORDER_YVU_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_YVU_EXT = 0x3303;

		/// <summary>
		/// Value of EGL_YUV_ORDER_YUYV_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_YUYV_EXT = 0x3304;

		/// <summary>
		/// Value of EGL_YUV_ORDER_UYVY_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_UYVY_EXT = 0x3305;

		/// <summary>
		/// Value of EGL_YUV_ORDER_YVYU_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_YVYU_EXT = 0x3306;

		/// <summary>
		/// Value of EGL_YUV_ORDER_VYUY_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_VYUY_EXT = 0x3307;

		/// <summary>
		/// Value of EGL_YUV_ORDER_AYUV_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_ORDER_AYUV_EXT = 0x3308;

		/// <summary>
		/// Value of EGL_YUV_SUBSAMPLE_4_2_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_SUBSAMPLE_4_2_0_EXT = 0x3313;

		/// <summary>
		/// Value of EGL_YUV_SUBSAMPLE_4_2_2_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_SUBSAMPLE_4_2_2_EXT = 0x3314;

		/// <summary>
		/// Value of EGL_YUV_SUBSAMPLE_4_4_4_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_SUBSAMPLE_4_4_4_EXT = 0x3315;

		/// <summary>
		/// Value of EGL_YUV_DEPTH_RANGE_LIMITED_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_DEPTH_RANGE_LIMITED_EXT = 0x3318;

		/// <summary>
		/// Value of EGL_YUV_DEPTH_RANGE_FULL_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_DEPTH_RANGE_FULL_EXT = 0x3319;

		/// <summary>
		/// Value of EGL_YUV_CSC_STANDARD_601_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_CSC_STANDARD_601_EXT = 0x330B;

		/// <summary>
		/// Value of EGL_YUV_CSC_STANDARD_709_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_CSC_STANDARD_709_EXT = 0x330C;

		/// <summary>
		/// Value of EGL_YUV_CSC_STANDARD_2020_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_CSC_STANDARD_2020_EXT = 0x330D;

		/// <summary>
		/// Value of EGL_YUV_PLANE_BPP_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_PLANE_BPP_0_EXT = 0x331B;

		/// <summary>
		/// Value of EGL_YUV_PLANE_BPP_8_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_PLANE_BPP_8_EXT = 0x331C;

		/// <summary>
		/// Value of EGL_YUV_PLANE_BPP_10_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_yuv_surface")]
		public const int YUV_PLANE_BPP_10_EXT = 0x331D;

	}

}
