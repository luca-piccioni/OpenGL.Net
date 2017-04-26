
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
		/// [GL] Value of GL_ASYNC_TEX_IMAGE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int ASYNC_TEX_IMAGE_SGIX = 0x835C;

		/// <summary>
		/// [GL] Value of GL_ASYNC_DRAW_PIXELS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int ASYNC_DRAW_PIXELS_SGIX = 0x835D;

		/// <summary>
		/// [GL] Value of GL_ASYNC_READ_PIXELS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int ASYNC_READ_PIXELS_SGIX = 0x835E;

		/// <summary>
		/// [GL] Value of GL_MAX_ASYNC_TEX_IMAGE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int MAX_ASYNC_TEX_IMAGE_SGIX = 0x835F;

		/// <summary>
		/// [GL] Value of GL_MAX_ASYNC_DRAW_PIXELS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int MAX_ASYNC_DRAW_PIXELS_SGIX = 0x8360;

		/// <summary>
		/// [GL] Value of GL_MAX_ASYNC_READ_PIXELS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		public const int MAX_ASYNC_READ_PIXELS_SGIX = 0x8361;

	}

}
