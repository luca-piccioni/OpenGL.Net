
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
		/// Value of GL_PALETTE4_RGB8_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE4_RGB8_OES = 0x8B90;

		/// <summary>
		/// Value of GL_PALETTE4_RGBA8_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE4_RGBA8_OES = 0x8B91;

		/// <summary>
		/// Value of GL_PALETTE4_R5_G6_B5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE4_R5_G6_B5_OES = 0x8B92;

		/// <summary>
		/// Value of GL_PALETTE4_RGBA4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE4_RGBA4_OES = 0x8B93;

		/// <summary>
		/// Value of GL_PALETTE4_RGB5_A1_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE4_RGB5_A1_OES = 0x8B94;

		/// <summary>
		/// Value of GL_PALETTE8_RGB8_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE8_RGB8_OES = 0x8B95;

		/// <summary>
		/// Value of GL_PALETTE8_RGBA8_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE8_RGBA8_OES = 0x8B96;

		/// <summary>
		/// Value of GL_PALETTE8_R5_G6_B5_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE8_R5_G6_B5_OES = 0x8B97;

		/// <summary>
		/// Value of GL_PALETTE8_RGBA4_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE8_RGBA4_OES = 0x8B98;

		/// <summary>
		/// Value of GL_PALETTE8_RGB5_A1_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_compressed_paletted_texture", Api = "gl|gles1|gles2")]
		public const int PALETTE8_RGB5_A1_OES = 0x8B99;

	}

}
