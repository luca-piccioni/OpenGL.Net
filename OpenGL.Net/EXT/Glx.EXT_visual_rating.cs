
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Value of GLX_VISUAL_CAVEAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_rating")]
		public const int VISUAL_CAVEAT_EXT = 0x20;

		/// <summary>
		/// [GLX] Value of GLX_SLOW_VISUAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_rating")]
		public const int SLOW_VISUAL_EXT = 0x8001;

		/// <summary>
		/// [GLX] Value of GLX_NON_CONFORMANT_VISUAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_rating")]
		public const int NON_CONFORMANT_VISUAL_EXT = 0x800D;

	}

}
