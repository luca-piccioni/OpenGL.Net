
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
		/// Value of GL_HALF_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int HALF_APPLE = 0x140B;

		/// <summary>
		/// Value of GL_RGBA_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int RGBA_FLOAT32_APPLE = 0x8814;

		/// <summary>
		/// Value of GL_RGB_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int RGB_FLOAT32_APPLE = 0x8815;

		/// <summary>
		/// Value of GL_ALPHA_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int ALPHA_FLOAT32_APPLE = 0x8816;

		/// <summary>
		/// Value of GL_INTENSITY_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int INTENSITY_FLOAT32_APPLE = 0x8817;

		/// <summary>
		/// Value of GL_LUMINANCE_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int LUMINANCE_FLOAT32_APPLE = 0x8818;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA_FLOAT32_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int LUMINANCE_ALPHA_FLOAT32_APPLE = 0x8819;

		/// <summary>
		/// Value of GL_RGBA_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int RGBA_FLOAT16_APPLE = 0x881A;

		/// <summary>
		/// Value of GL_RGB_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int RGB_FLOAT16_APPLE = 0x881B;

		/// <summary>
		/// Value of GL_ALPHA_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int ALPHA_FLOAT16_APPLE = 0x881C;

		/// <summary>
		/// Value of GL_INTENSITY_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int INTENSITY_FLOAT16_APPLE = 0x881D;

		/// <summary>
		/// Value of GL_LUMINANCE_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int LUMINANCE_FLOAT16_APPLE = 0x881E;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA_FLOAT16_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int LUMINANCE_ALPHA_FLOAT16_APPLE = 0x881F;

		/// <summary>
		/// Value of GL_COLOR_FLOAT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_float_pixels")]
		public const int COLOR_FLOAT_APPLE = 0x8A0F;

	}

}
