
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
		/// Value of GL_TEXTURE_RED_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_RED_TYPE_ARB = 0x8C10;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_GREEN_TYPE_ARB = 0x8C11;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_BLUE_TYPE_ARB = 0x8C12;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_ALPHA_TYPE_ARB = 0x8C13;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_LUMINANCE_TYPE_ARB = 0x8C14;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_INTENSITY_TYPE_ARB = 0x8C15;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int TEXTURE_DEPTH_TYPE_ARB = 0x8C16;

		/// <summary>
		/// Value of GL_UNSIGNED_NORMALIZED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int UNSIGNED_NORMALIZED_ARB = 0x8C17;

		/// <summary>
		/// Value of GL_RGBA32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int RGBA32F_ARB = 0x8814;

		/// <summary>
		/// Value of GL_RGB32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int RGB32F_ARB = 0x8815;

		/// <summary>
		/// Value of GL_ALPHA32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int ALPHA32F_ARB = 0x8816;

		/// <summary>
		/// Value of GL_INTENSITY32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int INTENSITY32F_ARB = 0x8817;

		/// <summary>
		/// Value of GL_LUMINANCE32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int LUMINANCE32F_ARB = 0x8818;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int LUMINANCE_ALPHA32F_ARB = 0x8819;

		/// <summary>
		/// Value of GL_RGBA16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int RGBA16F_ARB = 0x881A;

		/// <summary>
		/// Value of GL_RGB16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int RGB16F_ARB = 0x881B;

		/// <summary>
		/// Value of GL_ALPHA16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int ALPHA16F_ARB = 0x881C;

		/// <summary>
		/// Value of GL_INTENSITY16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int INTENSITY16F_ARB = 0x881D;

		/// <summary>
		/// Value of GL_LUMINANCE16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int LUMINANCE16F_ARB = 0x881E;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int LUMINANCE_ALPHA16F_ARB = 0x881F;

	}

}
