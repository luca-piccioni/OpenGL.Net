
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
		/// Value of GL_MODULATE_COLOR_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int MODULATE_COLOR_IMG = 0x8C04;

		/// <summary>
		/// Value of GL_RECIP_ADD_SIGNED_ALPHA_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int RECIP_ADD_SIGNED_ALPHA_IMG = 0x8C05;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int TEXTURE_ALPHA_MODULATE_IMG = 0x8C06;

		/// <summary>
		/// Value of GL_FACTOR_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int FACTOR_ALPHA_MODULATE_IMG = 0x8C07;

		/// <summary>
		/// Value of GL_FRAGMENT_ALPHA_MODULATE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int FRAGMENT_ALPHA_MODULATE_IMG = 0x8C08;

		/// <summary>
		/// Value of GL_ADD_BLEND_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_texture_env_enhanced_fixed_function", Api = "gles1")]
		public const int ADD_BLEND_IMG = 0x8C09;

	}

}
