
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
		/// Value of GL_RED_MIN_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int RED_MIN_CLAMP_INGR = 0x8560;

		/// <summary>
		/// Value of GL_GREEN_MIN_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int GREEN_MIN_CLAMP_INGR = 0x8561;

		/// <summary>
		/// Value of GL_BLUE_MIN_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int BLUE_MIN_CLAMP_INGR = 0x8562;

		/// <summary>
		/// Value of GL_ALPHA_MIN_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int ALPHA_MIN_CLAMP_INGR = 0x8563;

		/// <summary>
		/// Value of GL_RED_MAX_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int RED_MAX_CLAMP_INGR = 0x8564;

		/// <summary>
		/// Value of GL_GREEN_MAX_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int GREEN_MAX_CLAMP_INGR = 0x8565;

		/// <summary>
		/// Value of GL_BLUE_MAX_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int BLUE_MAX_CLAMP_INGR = 0x8566;

		/// <summary>
		/// Value of GL_ALPHA_MAX_CLAMP_INGR symbol.
		/// </summary>
		[RequiredByFeature("GL_INGR_color_clamp")]
		public const int ALPHA_MAX_CLAMP_INGR = 0x8567;

	}

}
