
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
		/// Value of GL_COMPRESSED_RGBA_ASTC_3x3x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_3x3x3_OES = 0x93C0;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x3x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_4x3x3_OES = 0x93C1;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_4x4x3_OES = 0x93C2;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_4x4x4_OES = 0x93C3;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x4x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_5x4x4_OES = 0x93C4;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_5x5x4_OES = 0x93C5;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_5x5x5_OES = 0x93C6;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x5x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_6x5x5_OES = 0x93C7;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_6x6x5_OES = 0x93C8;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6x6_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_6x6x6_OES = 0x93C9;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_3x3x3_OES = 0x93E0;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x3x3_OES = 0x93E1;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x3_OES = 0x93E2;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4x4_OES = 0x93E3;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x4x4_OES = 0x93E4;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x4_OES = 0x93E5;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5x5_OES = 0x93E6;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x5x5_OES = 0x93E7;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x5_OES = 0x93E8;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6x6_OES = 0x93E9;

	}

}
