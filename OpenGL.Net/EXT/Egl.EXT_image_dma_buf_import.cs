
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_LINUX_DMA_BUF_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int LINUX_DMA_BUF_EXT = 0x3270;

		/// <summary>
		/// Value of EGL_LINUX_DRM_FOURCC_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int LINUX_DRM_FOURCC_EXT = 0x3271;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE0_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_FD_EXT = 0x3272;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE0_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_OFFSET_EXT = 0x3273;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE0_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE0_PITCH_EXT = 0x3274;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE1_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_FD_EXT = 0x3275;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE1_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_OFFSET_EXT = 0x3276;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE1_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE1_PITCH_EXT = 0x3277;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE2_FD_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_FD_EXT = 0x3278;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE2_OFFSET_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_OFFSET_EXT = 0x3279;

		/// <summary>
		/// Value of EGL_DMA_BUF_PLANE2_PITCH_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int DMA_BUF_PLANE2_PITCH_EXT = 0x327A;

		/// <summary>
		/// Value of EGL_YUV_COLOR_SPACE_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_COLOR_SPACE_HINT_EXT = 0x327B;

		/// <summary>
		/// Value of EGL_SAMPLE_RANGE_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int SAMPLE_RANGE_HINT_EXT = 0x327C;

		/// <summary>
		/// Value of EGL_YUV_CHROMA_HORIZONTAL_SITING_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_HORIZONTAL_SITING_HINT_EXT = 0x327D;

		/// <summary>
		/// Value of EGL_YUV_CHROMA_VERTICAL_SITING_HINT_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_VERTICAL_SITING_HINT_EXT = 0x327E;

		/// <summary>
		/// Value of EGL_ITU_REC601_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC601_EXT = 0x327F;

		/// <summary>
		/// Value of EGL_ITU_REC709_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC709_EXT = 0x3280;

		/// <summary>
		/// Value of EGL_ITU_REC2020_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int ITU_REC2020_EXT = 0x3281;

		/// <summary>
		/// Value of EGL_YUV_FULL_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_FULL_RANGE_EXT = 0x3282;

		/// <summary>
		/// Value of EGL_YUV_NARROW_RANGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_NARROW_RANGE_EXT = 0x3283;

		/// <summary>
		/// Value of EGL_YUV_CHROMA_SITING_0_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_SITING_0_EXT = 0x3284;

		/// <summary>
		/// Value of EGL_YUV_CHROMA_SITING_0_5_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_image_dma_buf_import")]
		public const int YUV_CHROMA_SITING_0_5_EXT = 0x3285;

	}

}
