
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
		/// Value of GL_3DC_X_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_compressed_3DC_texture", Api = "gles1|gles2")]
		public const int _3DC_X_AMD = 0x87F9;

		/// <summary>
		/// Value of GL_3DC_XY_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_compressed_3DC_texture", Api = "gles1|gles2")]
		public const int _3DC_XY_AMD = 0x87FA;

	}

}
