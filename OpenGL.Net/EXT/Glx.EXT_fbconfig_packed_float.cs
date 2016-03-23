
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_RGBA_UNSIGNED_FLOAT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_fbconfig_packed_float")]
		public const int RGBA_UNSIGNED_FLOAT_TYPE_EXT = 0x20B1;

		/// <summary>
		/// Value of GLX_RGBA_UNSIGNED_FLOAT_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_fbconfig_packed_float")]
		[Log(BitmaskName = "GLXRenderTypeMask")]
		public const uint RGBA_UNSIGNED_FLOAT_BIT_EXT = 0x00000008;

	}

}
