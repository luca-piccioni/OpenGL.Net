
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
		/// Value of GL_IMPLEMENTATION_COLOR_READ_TYPE_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_read_format")]
		public const int IMPLEMENTATION_COLOR_READ_TYPE_OES = 0x8B9A;

		/// <summary>
		/// Value of GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_read_format")]
		public const int IMPLEMENTATION_COLOR_READ_FORMAT_OES = 0x8B9B;

	}

}
