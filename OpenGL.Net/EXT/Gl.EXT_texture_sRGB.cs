
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
		/// Value of GL_SRGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_sRGB")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SRGB_EXT = 0x8C40;

		/// <summary>
		/// Value of GL_SRGB8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SRGB8_EXT = 0x8C41;

		/// <summary>
		/// Value of GL_SRGB_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_sRGB")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SRGB_ALPHA_EXT = 0x8C42;

		/// <summary>
		/// Value of GL_SRGB8_ALPHA8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_sRGB")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SRGB8_ALPHA8_EXT = 0x8C43;

		/// <summary>
		/// Value of GL_SLUMINANCE_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SLUMINANCE_ALPHA_EXT = 0x8C44;

		/// <summary>
		/// Value of GL_SLUMINANCE8_ALPHA8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SLUMINANCE8_ALPHA8_EXT = 0x8C45;

		/// <summary>
		/// Value of GL_SLUMINANCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SLUMINANCE_EXT = 0x8C46;

		/// <summary>
		/// Value of GL_SLUMINANCE8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int SLUMINANCE8_EXT = 0x8C47;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_EXT = 0x8C48;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_ALPHA_EXT = 0x8C49;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SLUMINANCE_EXT = 0x8C4A;

		/// <summary>
		/// Value of GL_COMPRESSED_SLUMINANCE_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SLUMINANCE_ALPHA_EXT = 0x8C4B;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_S3TC_DXT1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		public const int COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F;

	}

}
