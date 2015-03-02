
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
		/// Value of GL_BGR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bgra")]
		public const int BGR_EXT = 0x80E0;

		/// <summary>
		/// Value of GL_BGRA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_format_BGRA8888")]
		[RequiredByFeature("GL_EXT_bgra")]
		[RequiredByFeature("GL_EXT_read_format_bgra")]
		[RequiredByFeature("GL_EXT_texture_format_BGRA8888")]
		public const int BGRA_EXT = 0x80E1;

	}

}
