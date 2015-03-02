
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
		/// Value of GL_COMBINE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int COMBINE_EXT = 0x8570;

		/// <summary>
		/// Value of GL_COMBINE_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int COMBINE_RGB_EXT = 0x8571;

		/// <summary>
		/// Value of GL_COMBINE_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int COMBINE_ALPHA_EXT = 0x8572;

		/// <summary>
		/// Value of GL_RGB_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int RGB_SCALE_EXT = 0x8573;

		/// <summary>
		/// Value of GL_ADD_SIGNED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int ADD_SIGNED_EXT = 0x8574;

		/// <summary>
		/// Value of GL_INTERPOLATE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int INTERPOLATE_EXT = 0x8575;

		/// <summary>
		/// Value of GL_CONSTANT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int CONSTANT_EXT = 0x8576;

		/// <summary>
		/// Value of GL_PRIMARY_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int PRIMARY_COLOR_EXT = 0x8577;

		/// <summary>
		/// Value of GL_PREVIOUS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int PREVIOUS_EXT = 0x8578;

		/// <summary>
		/// Value of GL_SOURCE0_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE0_RGB_EXT = 0x8580;

		/// <summary>
		/// Value of GL_SOURCE1_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE1_RGB_EXT = 0x8581;

		/// <summary>
		/// Value of GL_SOURCE2_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE2_RGB_EXT = 0x8582;

		/// <summary>
		/// Value of GL_SOURCE0_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE0_ALPHA_EXT = 0x8588;

		/// <summary>
		/// Value of GL_SOURCE1_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE1_ALPHA_EXT = 0x8589;

		/// <summary>
		/// Value of GL_SOURCE2_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int SOURCE2_ALPHA_EXT = 0x858A;

		/// <summary>
		/// Value of GL_OPERAND0_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND0_RGB_EXT = 0x8590;

		/// <summary>
		/// Value of GL_OPERAND1_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND1_RGB_EXT = 0x8591;

		/// <summary>
		/// Value of GL_OPERAND2_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND2_RGB_EXT = 0x8592;

		/// <summary>
		/// Value of GL_OPERAND0_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND0_ALPHA_EXT = 0x8598;

		/// <summary>
		/// Value of GL_OPERAND1_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND1_ALPHA_EXT = 0x8599;

		/// <summary>
		/// Value of GL_OPERAND2_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		public const int OPERAND2_ALPHA_EXT = 0x859A;

	}

}
