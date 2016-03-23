
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
		/// Value of GL_BLEND_EQUATION symbol.
		/// </summary>
		[AliasOf("GL_BLEND_EQUATION_EXT")]
		[AliasOf("GL_BLEND_EQUATION_OES")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		public const int BLEND_EQUATION = 0x8009;

		/// <summary>
		/// Gl.Get: data returns four values, the red, green, blue, and alpha values which are the components of the blend color. 
		/// See Gl.BlendColor.
		/// </summary>
		[AliasOf("GL_BLEND_COLOR_EXT")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int BLEND_COLOR = 0x8005;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT")]
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_OES")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9;

	}

}
