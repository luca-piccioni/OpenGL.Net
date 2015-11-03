
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_FLOAT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int FLOAT_COMPONENTS_NV = 0x20B0;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = 0x20B1;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = 0x20B2;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = 0x20B3;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = 0x20B4;

		/// <summary>
		/// Value of WGL_TEXTURE_FLOAT_R_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int TEXTURE_FLOAT_R_NV = 0x20B5;

		/// <summary>
		/// Value of WGL_TEXTURE_FLOAT_RG_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int TEXTURE_FLOAT_RG_NV = 0x20B6;

		/// <summary>
		/// Value of WGL_TEXTURE_FLOAT_RGB_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int TEXTURE_FLOAT_RGB_NV = 0x20B7;

		/// <summary>
		/// Value of WGL_TEXTURE_FLOAT_RGBA_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_float_buffer")]
		public const int TEXTURE_FLOAT_RGBA_NV = 0x20B8;

	}

}
