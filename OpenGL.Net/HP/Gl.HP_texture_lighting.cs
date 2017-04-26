
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
		/// [GL] Value of GL_TEXTURE_LIGHTING_MODE_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_texture_lighting")]
		public const int TEXTURE_LIGHTING_MODE_HP = 0x8167;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_POST_SPECULAR_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_texture_lighting")]
		public const int TEXTURE_POST_SPECULAR_HP = 0x8168;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_PRE_SPECULAR_HP symbol.
		/// </summary>
		[RequiredByFeature("GL_HP_texture_lighting")]
		public const int TEXTURE_PRE_SPECULAR_HP = 0x8169;

	}

}
