
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_COLOR_FORMAT_HI symbol.
		/// </summary>
		[RequiredByFeature("EGL_HI_colorformats")]
		public const int COLOR_FORMAT_HI = 0x8F70;

		/// <summary>
		/// Value of EGL_COLOR_RGB_HI symbol.
		/// </summary>
		[RequiredByFeature("EGL_HI_colorformats")]
		public const int COLOR_RGB_HI = 0x8F71;

		/// <summary>
		/// Value of EGL_COLOR_RGBA_HI symbol.
		/// </summary>
		[RequiredByFeature("EGL_HI_colorformats")]
		public const int COLOR_RGBA_HI = 0x8F72;

		/// <summary>
		/// Value of EGL_COLOR_ARGB_HI symbol.
		/// </summary>
		[RequiredByFeature("EGL_HI_colorformats")]
		public const int COLOR_ARGB_HI = 0x8F73;

	}

}
