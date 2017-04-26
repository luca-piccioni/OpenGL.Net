
// Copyright (C) 2015-2017 Luca Piccioni
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_DUAL_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA4_SGIS = 0x8110;

		/// <summary>
		/// [GL] Value of GL_DUAL_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA8_SGIS = 0x8111;

		/// <summary>
		/// [GL] Value of GL_DUAL_ALPHA12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA12_SGIS = 0x8112;

		/// <summary>
		/// [GL] Value of GL_DUAL_ALPHA16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_ALPHA16_SGIS = 0x8113;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE4_SGIS = 0x8114;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE8_SGIS = 0x8115;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE12_SGIS = 0x8116;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE16_SGIS = 0x8117;

		/// <summary>
		/// [GL] Value of GL_DUAL_INTENSITY4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY4_SGIS = 0x8118;

		/// <summary>
		/// [GL] Value of GL_DUAL_INTENSITY8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY8_SGIS = 0x8119;

		/// <summary>
		/// [GL] Value of GL_DUAL_INTENSITY12_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY12_SGIS = 0x811A;

		/// <summary>
		/// [GL] Value of GL_DUAL_INTENSITY16_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_INTENSITY16_SGIS = 0x811B;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C;

		/// <summary>
		/// [GL] Value of GL_DUAL_LUMINANCE_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D;

		/// <summary>
		/// [GL] Value of GL_QUAD_ALPHA4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_ALPHA4_SGIS = 0x811E;

		/// <summary>
		/// [GL] Value of GL_QUAD_ALPHA8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_ALPHA8_SGIS = 0x811F;

		/// <summary>
		/// [GL] Value of GL_QUAD_LUMINANCE4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_LUMINANCE4_SGIS = 0x8120;

		/// <summary>
		/// [GL] Value of GL_QUAD_LUMINANCE8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_LUMINANCE8_SGIS = 0x8121;

		/// <summary>
		/// [GL] Value of GL_QUAD_INTENSITY4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_INTENSITY4_SGIS = 0x8122;

		/// <summary>
		/// [GL] Value of GL_QUAD_INTENSITY8_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_INTENSITY8_SGIS = 0x8123;

		/// <summary>
		/// [GL] Value of GL_DUAL_TEXTURE_SELECT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int DUAL_TEXTURE_SELECT_SGIS = 0x8124;

		/// <summary>
		/// [GL] Value of GL_QUAD_TEXTURE_SELECT_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		public const int QUAD_TEXTURE_SELECT_SGIS = 0x8125;

	}

}
