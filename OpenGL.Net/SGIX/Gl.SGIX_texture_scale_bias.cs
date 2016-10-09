
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
		/// Value of GL_POST_TEXTURE_FILTER_BIAS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		public const int POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179;

		/// <summary>
		/// Value of GL_POST_TEXTURE_FILTER_SCALE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		public const int POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A;

		/// <summary>
		/// Value of GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		public const int POST_TEXTURE_FILTER_BIAS_RANGE_SGIX = 0x817B;

		/// <summary>
		/// Value of GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		public const int POST_TEXTURE_FILTER_SCALE_RANGE_SGIX = 0x817C;

	}

}
