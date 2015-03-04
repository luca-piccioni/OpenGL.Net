
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
		/// Value of GL_ALPHA4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int ALPHA4_EXT = 0x803B;

		/// <summary>
		/// Value of GL_ALPHA8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int ALPHA8_EXT = 0x803C;

		/// <summary>
		/// Value of GL_ALPHA12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int ALPHA12_EXT = 0x803D;

		/// <summary>
		/// Value of GL_ALPHA16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int ALPHA16_EXT = 0x803E;

		/// <summary>
		/// Value of GL_LUMINANCE4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE4_EXT = 0x803F;

		/// <summary>
		/// Value of GL_LUMINANCE8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE8_EXT = 0x8040;

		/// <summary>
		/// Value of GL_LUMINANCE12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE12_EXT = 0x8041;

		/// <summary>
		/// Value of GL_LUMINANCE16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE16_EXT = 0x8042;

		/// <summary>
		/// Value of GL_LUMINANCE4_ALPHA4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE4_ALPHA4_EXT = 0x8043;

		/// <summary>
		/// Value of GL_LUMINANCE6_ALPHA2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE6_ALPHA2_EXT = 0x8044;

		/// <summary>
		/// Value of GL_LUMINANCE8_ALPHA8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE8_ALPHA8_EXT = 0x8045;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE12_ALPHA4_EXT = 0x8046;

		/// <summary>
		/// Value of GL_LUMINANCE12_ALPHA12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE12_ALPHA12_EXT = 0x8047;

		/// <summary>
		/// Value of GL_LUMINANCE16_ALPHA16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int LUMINANCE16_ALPHA16_EXT = 0x8048;

		/// <summary>
		/// Value of GL_INTENSITY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int INTENSITY_EXT = 0x8049;

		/// <summary>
		/// Value of GL_INTENSITY4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int INTENSITY4_EXT = 0x804A;

		/// <summary>
		/// Value of GL_INTENSITY8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int INTENSITY8_EXT = 0x804B;

		/// <summary>
		/// Value of GL_INTENSITY12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int INTENSITY12_EXT = 0x804C;

		/// <summary>
		/// Value of GL_INTENSITY16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int INTENSITY16_EXT = 0x804D;

		/// <summary>
		/// Value of GL_RGB2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB2_EXT = 0x804E;

		/// <summary>
		/// Value of GL_RGB4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB4_EXT = 0x804F;

		/// <summary>
		/// Value of GL_RGB5_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB5_EXT = 0x8050;

		/// <summary>
		/// Value of GL_RGB8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB8_EXT = 0x8051;

		/// <summary>
		/// Value of GL_RGB10_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB10_EXT = 0x8052;

		/// <summary>
		/// Value of GL_RGB12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB12_EXT = 0x8053;

		/// <summary>
		/// Value of GL_RGB16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB16_EXT = 0x8054;

		/// <summary>
		/// Value of GL_RGBA2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA2_EXT = 0x8055;

		/// <summary>
		/// Value of GL_RGBA4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA4_EXT = 0x8056;

		/// <summary>
		/// Value of GL_RGB5_A1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB5_A1_EXT = 0x8057;

		/// <summary>
		/// Value of GL_RGBA8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA8_EXT = 0x8058;

		/// <summary>
		/// Value of GL_RGB10_A2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB10_A2_EXT = 0x8059;

		/// <summary>
		/// Value of GL_RGBA12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA12_EXT = 0x805A;

		/// <summary>
		/// Value of GL_RGBA16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGBA16_EXT = 0x805B;

		/// <summary>
		/// Value of GL_TEXTURE_RED_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_RED_SIZE_EXT = 0x805C;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_GREEN_SIZE_EXT = 0x805D;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_BLUE_SIZE_EXT = 0x805E;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_ALPHA_SIZE_EXT = 0x805F;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_LUMINANCE_SIZE_EXT = 0x8060;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_INTENSITY_SIZE_EXT = 0x8061;

		/// <summary>
		/// Value of GL_REPLACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int REPLACE_EXT = 0x8062;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_1D_EXT = 0x8063;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int PROXY_TEXTURE_2D_EXT = 0x8064;

		/// <summary>
		/// Value of GL_TEXTURE_TOO_LARGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_TOO_LARGE_EXT = 0x8065;

	}

}
