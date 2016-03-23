
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
		/// Value of GL_DUAL_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA4_SGIS = 0x8110;

		/// <summary>
		/// Value of GL_DUAL_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA8_SGIS = 0x8111;

		/// <summary>
		/// Value of GL_DUAL_ALPHA12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA12_SGIS = 0x8112;

		/// <summary>
		/// Value of GL_DUAL_ALPHA16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA16_SGIS = 0x8113;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE4_SGIS = 0x8114;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE8_SGIS = 0x8115;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE12_SGIS = 0x8116;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE16_SGIS = 0x8117;

		/// <summary>
		/// Value of GL_DUAL_INTENSITY4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY4_SGIS = 0x8118;

		/// <summary>
		/// Value of GL_DUAL_INTENSITY8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY8_SGIS = 0x8119;

		/// <summary>
		/// Value of GL_DUAL_INTENSITY12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY12_SGIS = 0x811A;

		/// <summary>
		/// Value of GL_DUAL_INTENSITY16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY16_SGIS = 0x811B;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C;

		/// <summary>
		/// Value of GL_DUAL_LUMINANCE_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D;

		/// <summary>
		/// Value of GL_QUAD_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_ALPHA4_SGIS = 0x811E;

		/// <summary>
		/// Value of GL_QUAD_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_ALPHA8_SGIS = 0x811F;

		/// <summary>
		/// Value of GL_QUAD_LUMINANCE4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_LUMINANCE4_SGIS = 0x8120;

		/// <summary>
		/// Value of GL_QUAD_LUMINANCE8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_LUMINANCE8_SGIS = 0x8121;

		/// <summary>
		/// Value of GL_QUAD_INTENSITY4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_INTENSITY4_SGIS = 0x8122;

		/// <summary>
		/// Value of GL_QUAD_INTENSITY8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_INTENSITY8_SGIS = 0x8123;

		/// <summary>
		/// Value of GL_DUAL_TEXTURE_SELECT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_TEXTURE_SELECT_SGIS = 0x8124;

		/// <summary>
		/// Value of GL_QUAD_TEXTURE_SELECT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_TEXTURE_SELECT_SGIS = 0x8125;

	}

}
