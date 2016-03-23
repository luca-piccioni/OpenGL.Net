
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
		/// Value of GL_OFFSET_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;

		/// <summary>
		/// Value of GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;

		/// <summary>
		/// Value of GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_S8_S8_8_8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_8_8_S8_S8_REV_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;

		/// <summary>
		/// Value of GL_DSDT_MAG_INTENSITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT_MAG_INTENSITY_NV = 0x86DC;

		/// <summary>
		/// Value of GL_SHADER_CONSISTENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SHADER_CONSISTENT_NV = 0x86DD;

		/// <summary>
		/// Value of GL_TEXTURE_SHADER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_SHADER_NV = 0x86DE;

		/// <summary>
		/// Value of GL_SHADER_OPERATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SHADER_OPERATION_NV = 0x86DF;

		/// <summary>
		/// Value of GL_CULL_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int CULL_MODES_NV = 0x86E0;

		/// <summary>
		/// Value of GL_OFFSET_TEXTURE_MATRIX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_MATRIX_NV = 0x86E1;

		/// <summary>
		/// Value of GL_OFFSET_TEXTURE_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_SCALE_NV = 0x86E2;

		/// <summary>
		/// Value of GL_OFFSET_TEXTURE_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_BIAS_NV = 0x86E3;

		/// <summary>
		/// Value of GL_PREVIOUS_TEXTURE_INPUT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;

		/// <summary>
		/// Value of GL_CONST_EYE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int CONST_EYE_NV = 0x86E5;

		/// <summary>
		/// Value of GL_PASS_THROUGH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int PASS_THROUGH_NV = 0x86E6;

		/// <summary>
		/// Value of GL_CULL_FRAGMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int CULL_FRAGMENT_NV = 0x86E7;

		/// <summary>
		/// Value of GL_OFFSET_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int OFFSET_TEXTURE_2D_NV = 0x86E8;

		/// <summary>
		/// Value of GL_DEPENDENT_AR_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;

		/// <summary>
		/// Value of GL_DEPENDENT_GB_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_NV = 0x86EC;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_DEPTH_REPLACE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;

		/// <summary>
		/// Value of GL_HILO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int HILO_NV = 0x86F4;

		/// <summary>
		/// Value of GL_DSDT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT_NV = 0x86F5;

		/// <summary>
		/// Value of GL_DSDT_MAG_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT_MAG_NV = 0x86F6;

		/// <summary>
		/// Value of GL_DSDT_MAG_VIB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT_MAG_VIB_NV = 0x86F7;

		/// <summary>
		/// Value of GL_HILO16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int HILO16_NV = 0x86F8;

		/// <summary>
		/// Value of GL_SIGNED_HILO_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_HILO_NV = 0x86F9;

		/// <summary>
		/// Value of GL_SIGNED_HILO16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_HILO16_NV = 0x86FA;

		/// <summary>
		/// Value of GL_SIGNED_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGBA_NV = 0x86FB;

		/// <summary>
		/// Value of GL_SIGNED_RGBA8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGBA8_NV = 0x86FC;

		/// <summary>
		/// Value of GL_SIGNED_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGB_NV = 0x86FE;

		/// <summary>
		/// Value of GL_SIGNED_RGB8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGB8_NV = 0x86FF;

		/// <summary>
		/// Value of GL_SIGNED_LUMINANCE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_LUMINANCE_NV = 0x8701;

		/// <summary>
		/// Value of GL_SIGNED_LUMINANCE8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_LUMINANCE8_NV = 0x8702;

		/// <summary>
		/// Value of GL_SIGNED_LUMINANCE_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_LUMINANCE_ALPHA_NV = 0x8703;

		/// <summary>
		/// Value of GL_SIGNED_LUMINANCE8_ALPHA8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;

		/// <summary>
		/// Value of GL_SIGNED_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_ALPHA_NV = 0x8705;

		/// <summary>
		/// Value of GL_SIGNED_ALPHA8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_ALPHA8_NV = 0x8706;

		/// <summary>
		/// Value of GL_SIGNED_INTENSITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_INTENSITY_NV = 0x8707;

		/// <summary>
		/// Value of GL_SIGNED_INTENSITY8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_INTENSITY8_NV = 0x8708;

		/// <summary>
		/// Value of GL_DSDT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT8_NV = 0x8709;

		/// <summary>
		/// Value of GL_DSDT8_MAG8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT8_MAG8_NV = 0x870A;

		/// <summary>
		/// Value of GL_DSDT8_MAG8_INTENSITY8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DSDT8_MAG8_INTENSITY8_NV = 0x870B;

		/// <summary>
		/// Value of GL_SIGNED_RGB_UNSIGNED_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;

		/// <summary>
		/// Value of GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;

		/// <summary>
		/// Value of GL_HI_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int HI_SCALE_NV = 0x870E;

		/// <summary>
		/// Value of GL_LO_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int LO_SCALE_NV = 0x870F;

		/// <summary>
		/// Value of GL_DS_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DS_SCALE_NV = 0x8710;

		/// <summary>
		/// Value of GL_DT_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DT_SCALE_NV = 0x8711;

		/// <summary>
		/// Value of GL_MAGNITUDE_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int MAGNITUDE_SCALE_NV = 0x8712;

		/// <summary>
		/// Value of GL_VIBRANCE_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int VIBRANCE_SCALE_NV = 0x8713;

		/// <summary>
		/// Value of GL_HI_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int HI_BIAS_NV = 0x8714;

		/// <summary>
		/// Value of GL_LO_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int LO_BIAS_NV = 0x8715;

		/// <summary>
		/// Value of GL_DS_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DS_BIAS_NV = 0x8716;

		/// <summary>
		/// Value of GL_DT_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int DT_BIAS_NV = 0x8717;

		/// <summary>
		/// Value of GL_MAGNITUDE_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int MAGNITUDE_BIAS_NV = 0x8718;

		/// <summary>
		/// Value of GL_VIBRANCE_BIAS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int VIBRANCE_BIAS_NV = 0x8719;

		/// <summary>
		/// Value of GL_TEXTURE_BORDER_VALUES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_BORDER_VALUES_NV = 0x871A;

		/// <summary>
		/// Value of GL_TEXTURE_HI_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_HI_SIZE_NV = 0x871B;

		/// <summary>
		/// Value of GL_TEXTURE_LO_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_LO_SIZE_NV = 0x871C;

		/// <summary>
		/// Value of GL_TEXTURE_DS_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_DS_SIZE_NV = 0x871D;

		/// <summary>
		/// Value of GL_TEXTURE_DT_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_DT_SIZE_NV = 0x871E;

		/// <summary>
		/// Value of GL_TEXTURE_MAG_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader")]
		public const int TEXTURE_MAG_SIZE_NV = 0x871F;

	}

}
