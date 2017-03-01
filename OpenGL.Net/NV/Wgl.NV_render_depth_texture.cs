
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
	public partial class Wgl
	{
		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_render_depth_texture")]
		public const int BIND_TO_TEXTURE_DEPTH_NV = 0x20A3;

		/// <summary>
		/// Value of WGL_BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_render_depth_texture")]
		public const int BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = 0x20A4;

		/// <summary>
		/// Value of WGL_DEPTH_TEXTURE_FORMAT_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_render_depth_texture")]
		public const int DEPTH_TEXTURE_FORMAT_NV = 0x20A5;

		/// <summary>
		/// Value of WGL_TEXTURE_DEPTH_COMPONENT_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_render_depth_texture")]
		public const int TEXTURE_DEPTH_COMPONENT_NV = 0x20A6;

		/// <summary>
		/// Value of WGL_DEPTH_COMPONENT_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_render_depth_texture")]
		public const int DEPTH_COMPONENT_NV = 0x20A7;

	}

}
