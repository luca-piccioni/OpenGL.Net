
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
		/// Value of GL_DEPTH_COMPONENT16_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int DEPTH_COMPONENT16_ARB = 0x81A5;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT24_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int DEPTH_COMPONENT24_ARB = 0x81A6;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int DEPTH_COMPONENT32_ARB = 0x81A7;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int TEXTURE_DEPTH_SIZE_ARB = 0x884A;

		/// <summary>
		/// Value of GL_DEPTH_TEXTURE_MODE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int DEPTH_TEXTURE_MODE_ARB = 0x884B;

	}

}
