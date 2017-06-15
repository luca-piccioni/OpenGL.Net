
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_SAMPLER_EXTERNAL_2D_Y2Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_YUV_target", Api = "gles2")]
		public const int SAMPLER_EXTERNAL_2D_Y2Y_EXT = 0x8BE7;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_EXTERNAL_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_YUV_target", Api = "gles2")]
		[RequiredByFeature("GL_OES_EGL_image_external", Api = "gles1|gles2")]
		public const int TEXTURE_EXTERNAL_OES = 0x8D65;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_BINDING_EXTERNAL_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_YUV_target", Api = "gles2")]
		[RequiredByFeature("GL_OES_EGL_image_external", Api = "gles1|gles2")]
		public const int TEXTURE_BINDING_EXTERNAL_OES = 0x8D67;

		/// <summary>
		/// [GL] Value of GL_REQUIRED_TEXTURE_IMAGE_UNITS_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_YUV_target", Api = "gles2")]
		[RequiredByFeature("GL_OES_EGL_image_external", Api = "gles1|gles2")]
		public const int REQUIRED_TEXTURE_IMAGE_UNITS_OES = 0x8D68;

	}

}
