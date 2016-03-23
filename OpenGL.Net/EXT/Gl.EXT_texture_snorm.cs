
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
		/// Value of GL_ALPHA_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int ALPHA_SNORM = 0x9010;

		/// <summary>
		/// Value of GL_LUMINANCE_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE_SNORM = 0x9011;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE_ALPHA_SNORM = 0x9012;

		/// <summary>
		/// Value of GL_INTENSITY_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int INTENSITY_SNORM = 0x9013;

		/// <summary>
		/// Value of GL_ALPHA8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int ALPHA8_SNORM = 0x9014;

		/// <summary>
		/// Value of GL_LUMINANCE8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE8_SNORM = 0x9015;

		/// <summary>
		/// Value of GL_LUMINANCE8_ALPHA8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE8_ALPHA8_SNORM = 0x9016;

		/// <summary>
		/// Value of GL_INTENSITY8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int INTENSITY8_SNORM = 0x9017;

		/// <summary>
		/// Value of GL_ALPHA16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int ALPHA16_SNORM = 0x9018;

		/// <summary>
		/// Value of GL_LUMINANCE16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE16_SNORM = 0x9019;

		/// <summary>
		/// Value of GL_LUMINANCE16_ALPHA16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int LUMINANCE16_ALPHA16_SNORM = 0x901A;

		/// <summary>
		/// Value of GL_INTENSITY16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int INTENSITY16_SNORM = 0x901B;

		/// <summary>
		/// Value of GL_RED_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RED_SNORM = 0x8F90;

		/// <summary>
		/// Value of GL_RG_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RG_SNORM = 0x8F91;

		/// <summary>
		/// Value of GL_RGB_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGB_SNORM = 0x8F92;

		/// <summary>
		/// Value of GL_RGBA_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGBA_SNORM = 0x8F93;

	}

}
