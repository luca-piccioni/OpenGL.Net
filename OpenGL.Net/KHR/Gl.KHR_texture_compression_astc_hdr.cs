
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_4x4_KHR = 0x93B0;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x4_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_5x4_KHR = 0x93B1;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_5x5_KHR = 0x93B2;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_6x5_KHR = 0x93B3;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_6x6_KHR = 0x93B4;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_8x5_KHR = 0x93B5;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_8x6_KHR = 0x93B6;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x8_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_8x8_KHR = 0x93B7;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_10x5_KHR = 0x93B8;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_10x6_KHR = 0x93B9;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x8_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_10x8_KHR = 0x93BA;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x10_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_10x10_KHR = 0x93BB;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_12x10_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_12x10_KHR = 0x93BC;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_12x12_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_RGBA_ASTC_12x12_KHR = 0x93BD;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR = 0x93D0;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR = 0x93D1;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR = 0x93D2;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR = 0x93D3;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR = 0x93D4;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR = 0x93D5;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR = 0x93D6;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR = 0x93D7;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR = 0x93D8;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR = 0x93D9;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR = 0x93DA;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR = 0x93DB;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR = 0x93DC;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr")]
		[RequiredByFeature("GL_OES_texture_compression_astc")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR = 0x93DD;

	}

}
