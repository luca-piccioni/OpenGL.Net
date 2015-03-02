
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
		/// Value of GL_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int TEXTURE_RECTANGLE_NV = 0x84F5;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_RECTANGLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;

		/// <summary>
		/// Value of GL_MAX_RECTANGLE_TEXTURE_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;

	}

}
