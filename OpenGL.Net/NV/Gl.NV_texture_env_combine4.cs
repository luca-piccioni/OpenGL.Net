
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
		/// Value of GL_COMBINE4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_env_combine4")]
		public const int COMBINE4_NV = 0x8503;

		/// <summary>
		/// Value of GL_SOURCE3_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_env_combine4")]
		public const int SOURCE3_RGB_NV = 0x8583;

		/// <summary>
		/// Value of GL_SOURCE3_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_env_combine4")]
		public const int SOURCE3_ALPHA_NV = 0x858B;

		/// <summary>
		/// Value of GL_OPERAND3_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_env_combine4")]
		public const int OPERAND3_RGB_NV = 0x8593;

		/// <summary>
		/// Value of GL_OPERAND3_ALPHA_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_env_combine4")]
		public const int OPERAND3_ALPHA_NV = 0x859B;

	}

}
