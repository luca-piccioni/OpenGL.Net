
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
		/// [GL] Value of GL_TEXTURE_COMPARE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		public const int TEXTURE_COMPARE_SGIX = 0x819A;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_COMPARE_OPERATOR_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		public const int TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_LEQUAL_R_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		public const int TEXTURE_LEQUAL_R_SGIX = 0x819C;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_GEQUAL_R_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		public const int TEXTURE_GEQUAL_R_SGIX = 0x819D;

	}

}
