
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_ALPHA_MIN_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_blend_alpha_minmax")]
		public const int ALPHA_MIN_SGIX = 0x8320;

		/// <summary>
		/// Value of GL_ALPHA_MAX_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_blend_alpha_minmax")]
		public const int ALPHA_MAX_SGIX = 0x8321;

	}

}
