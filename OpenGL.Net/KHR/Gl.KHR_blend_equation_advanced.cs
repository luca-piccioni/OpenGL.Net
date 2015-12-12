
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
		/// Value of GL_MULTIPLY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int MULTIPLY_KHR = 0x9294;

		/// <summary>
		/// Value of GL_SCREEN_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int SCREEN_KHR = 0x9295;

		/// <summary>
		/// Value of GL_OVERLAY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int OVERLAY_KHR = 0x9296;

		/// <summary>
		/// Value of GL_DARKEN_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int DARKEN_KHR = 0x9297;

		/// <summary>
		/// Value of GL_LIGHTEN_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int LIGHTEN_KHR = 0x9298;

		/// <summary>
		/// Value of GL_COLORDODGE_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int COLORDODGE_KHR = 0x9299;

		/// <summary>
		/// Value of GL_COLORBURN_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int COLORBURN_KHR = 0x929A;

		/// <summary>
		/// Value of GL_HARDLIGHT_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int HARDLIGHT_KHR = 0x929B;

		/// <summary>
		/// Value of GL_SOFTLIGHT_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int SOFTLIGHT_KHR = 0x929C;

		/// <summary>
		/// Value of GL_DIFFERENCE_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int DIFFERENCE_KHR = 0x929E;

		/// <summary>
		/// Value of GL_EXCLUSION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int EXCLUSION_KHR = 0x92A0;

		/// <summary>
		/// Value of GL_HSL_HUE_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int HSL_HUE_KHR = 0x92AD;

		/// <summary>
		/// Value of GL_HSL_SATURATION_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int HSL_SATURATION_KHR = 0x92AE;

		/// <summary>
		/// Value of GL_HSL_COLOR_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int HSL_COLOR_KHR = 0x92AF;

		/// <summary>
		/// Value of GL_HSL_LUMINOSITY_KHR symbol.
		/// </summary>
		[RequiredByFeature("GL_KHR_blend_equation_advanced")]
		public const int HSL_LUMINOSITY_KHR = 0x92B0;

	}

}
