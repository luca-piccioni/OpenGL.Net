
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
		/// Value of GL_COLOR_INDEX1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX1_EXT = 0x80E2;

		/// <summary>
		/// Value of GL_COLOR_INDEX2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX2_EXT = 0x80E3;

		/// <summary>
		/// Value of GL_COLOR_INDEX4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX4_EXT = 0x80E4;

		/// <summary>
		/// Value of GL_COLOR_INDEX8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX8_EXT = 0x80E5;

		/// <summary>
		/// Value of GL_COLOR_INDEX12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX12_EXT = 0x80E6;

		/// <summary>
		/// Value of GL_COLOR_INDEX16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX16_EXT = 0x80E7;

		/// <summary>
		/// Value of GL_TEXTURE_INDEX_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int TEXTURE_INDEX_SIZE_EXT = 0x80ED;

	}

}
