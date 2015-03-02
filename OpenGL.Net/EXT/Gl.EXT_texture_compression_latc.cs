
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
		/// Value of GL_COMPRESSED_LUMINANCE_LATC1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_compression_latc")]
		public const int COMPRESSED_LUMINANCE_LATC1_EXT = 0x8C70;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_compression_latc")]
		public const int COMPRESSED_SIGNED_LUMINANCE_LATC1_EXT = 0x8C71;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_compression_latc")]
		public const int COMPRESSED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C72;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_compression_latc")]
		public const int COMPRESSED_SIGNED_LUMINANCE_ALPHA_LATC2_EXT = 0x8C73;

	}

}
