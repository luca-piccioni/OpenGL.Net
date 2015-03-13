
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_POSITIVE_X.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X_KHR = 0x30B3;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_NEGATIVE_X.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X_KHR = 0x30B4;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_POSITIVE_Y.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y_KHR = 0x30B5;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_NEGATIVE_Y.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_KHR = 0x30B6;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_POSITIVE_Z.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z_KHR = 0x30B7;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_KHR symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_KHR_gl_texture_cubemap_image")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_KHR = 0x30B8;

	}

}
