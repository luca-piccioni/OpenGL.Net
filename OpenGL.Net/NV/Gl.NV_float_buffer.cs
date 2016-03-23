
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
		/// Value of GL_FLOAT_R_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_R_NV = 0x8880;

		/// <summary>
		/// Value of GL_FLOAT_RG_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RG_NV = 0x8881;

		/// <summary>
		/// Value of GL_FLOAT_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGB_NV = 0x8882;

		/// <summary>
		/// Value of GL_FLOAT_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGBA_NV = 0x8883;

		/// <summary>
		/// Value of GL_FLOAT_R16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_R16_NV = 0x8884;

		/// <summary>
		/// Value of GL_FLOAT_R32_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_R32_NV = 0x8885;

		/// <summary>
		/// Value of GL_FLOAT_RG16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RG16_NV = 0x8886;

		/// <summary>
		/// Value of GL_FLOAT_RG32_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RG32_NV = 0x8887;

		/// <summary>
		/// Value of GL_FLOAT_RGB16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGB16_NV = 0x8888;

		/// <summary>
		/// Value of GL_FLOAT_RGB32_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGB32_NV = 0x8889;

		/// <summary>
		/// Value of GL_FLOAT_RGBA16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGBA16_NV = 0x888A;

		/// <summary>
		/// Value of GL_FLOAT_RGBA32_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGBA32_NV = 0x888B;

		/// <summary>
		/// Value of GL_TEXTURE_FLOAT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int TEXTURE_FLOAT_COMPONENTS_NV = 0x888C;

		/// <summary>
		/// Value of GL_FLOAT_CLEAR_COLOR_VALUE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_CLEAR_COLOR_VALUE_NV = 0x888D;

		/// <summary>
		/// Value of GL_FLOAT_RGBA_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_float_buffer")]
		public const int FLOAT_RGBA_MODE_NV = 0x888E;

	}

}
