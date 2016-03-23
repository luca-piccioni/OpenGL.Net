
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
		/// Value of GL_OFFSET_PROJECTIVE_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_PROJECTIVE_TEXTURE_2D_NV = 0x8850;

		/// <summary>
		/// Value of GL_OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_PROJECTIVE_TEXTURE_2D_SCALE_NV = 0x8851;

		/// <summary>
		/// Value of GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8852;

		/// <summary>
		/// Value of GL_OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_PROJECTIVE_TEXTURE_RECTANGLE_SCALE_NV = 0x8853;

		/// <summary>
		/// Value of GL_OFFSET_HILO_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_HILO_TEXTURE_2D_NV = 0x8854;

		/// <summary>
		/// Value of GL_OFFSET_HILO_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_HILO_TEXTURE_RECTANGLE_NV = 0x8855;

		/// <summary>
		/// Value of GL_OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_HILO_PROJECTIVE_TEXTURE_2D_NV = 0x8856;

		/// <summary>
		/// Value of GL_OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int OFFSET_HILO_PROJECTIVE_TEXTURE_RECTANGLE_NV = 0x8857;

		/// <summary>
		/// Value of GL_DEPENDENT_HILO_TEXTURE_2D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DEPENDENT_HILO_TEXTURE_2D_NV = 0x8858;

		/// <summary>
		/// Value of GL_DEPENDENT_RGB_TEXTURE_3D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DEPENDENT_RGB_TEXTURE_3D_NV = 0x8859;

		/// <summary>
		/// Value of GL_DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DEPENDENT_RGB_TEXTURE_CUBE_MAP_NV = 0x885A;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_PASS_THROUGH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DOT_PRODUCT_PASS_THROUGH_NV = 0x885B;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_TEXTURE_1D_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DOT_PRODUCT_TEXTURE_1D_NV = 0x885C;

		/// <summary>
		/// Value of GL_DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int DOT_PRODUCT_AFFINE_DEPTH_REPLACE_NV = 0x885D;

		/// <summary>
		/// Value of GL_HILO8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int HILO8_NV = 0x885E;

		/// <summary>
		/// Value of GL_SIGNED_HILO8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int SIGNED_HILO8_NV = 0x885F;

		/// <summary>
		/// Value of GL_FORCE_BLUE_TO_ONE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_shader3")]
		public const int FORCE_BLUE_TO_ONE_NV = 0x8860;

	}

}
