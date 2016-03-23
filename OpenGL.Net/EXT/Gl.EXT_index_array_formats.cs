
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
		/// Value of GL_IUI_V2F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int IUI_V2F_EXT = 0x81AD;

		/// <summary>
		/// Value of GL_IUI_V3F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int IUI_V3F_EXT = 0x81AE;

		/// <summary>
		/// Value of GL_IUI_N3F_V2F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int IUI_N3F_V2F_EXT = 0x81AF;

		/// <summary>
		/// Value of GL_IUI_N3F_V3F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int IUI_N3F_V3F_EXT = 0x81B0;

		/// <summary>
		/// Value of GL_T2F_IUI_V2F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int T2F_IUI_V2F_EXT = 0x81B1;

		/// <summary>
		/// Value of GL_T2F_IUI_V3F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int T2F_IUI_V3F_EXT = 0x81B2;

		/// <summary>
		/// Value of GL_T2F_IUI_N3F_V2F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int T2F_IUI_N3F_V2F_EXT = 0x81B3;

		/// <summary>
		/// Value of GL_T2F_IUI_N3F_V3F_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_array_formats")]
		public const int T2F_IUI_N3F_V3F_EXT = 0x81B4;

	}

}
