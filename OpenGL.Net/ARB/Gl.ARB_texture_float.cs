
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
		/// Value of GL_ALPHA32F_ARB symbol.
		/// </summary>
		[AliasOf("GL_ALPHA32F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int ALPHA32F_ARB = 0x8816;

		/// <summary>
		/// Value of GL_INTENSITY32F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int INTENSITY32F_ARB = 0x8817;

		/// <summary>
		/// Value of GL_LUMINANCE32F_ARB symbol.
		/// </summary>
		[AliasOf("GL_LUMINANCE32F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int LUMINANCE32F_ARB = 0x8818;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA32F_ARB symbol.
		/// </summary>
		[AliasOf("GL_LUMINANCE_ALPHA32F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int LUMINANCE_ALPHA32F_ARB = 0x8819;

		/// <summary>
		/// Value of GL_ALPHA16F_ARB symbol.
		/// </summary>
		[AliasOf("GL_ALPHA16F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int ALPHA16F_ARB = 0x881C;

		/// <summary>
		/// Value of GL_INTENSITY16F_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_texture_float")]
		public const int INTENSITY16F_ARB = 0x881D;

		/// <summary>
		/// Value of GL_LUMINANCE16F_ARB symbol.
		/// </summary>
		[AliasOf("GL_LUMINANCE16F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int LUMINANCE16F_ARB = 0x881E;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA16F_ARB symbol.
		/// </summary>
		[AliasOf("GL_LUMINANCE_ALPHA16F_EXT")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		public const int LUMINANCE_ALPHA16F_ARB = 0x881F;

	}

}
