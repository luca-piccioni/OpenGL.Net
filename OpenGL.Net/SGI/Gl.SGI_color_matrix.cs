
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
		/// Value of GL_COLOR_MATRIX_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int COLOR_MATRIX_SGI = 0x80B1;

		/// <summary>
		/// Value of GL_COLOR_MATRIX_STACK_DEPTH_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B2;

		/// <summary>
		/// Value of GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int MAX_COLOR_MATRIX_STACK_DEPTH_SGI = 0x80B3;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_SCALE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_RED_SCALE_SGI = 0x80B4;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_GREEN_SCALE_SGI = 0x80B5;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_BLUE_SCALE_SGI = 0x80B6;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_ALPHA_SCALE_SGI = 0x80B7;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_RED_BIAS_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_RED_BIAS_SGI = 0x80B8;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_GREEN_BIAS_SGI = 0x80B9;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_BLUE_BIAS_SGI = 0x80BA;

		/// <summary>
		/// Value of GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI symbol.
		/// </summary>
		[RequiredByFeature("GL_SGI_color_matrix")]
		public const int POST_COLOR_MATRIX_ALPHA_BIAS_SGI = 0x80BB;

	}

}
