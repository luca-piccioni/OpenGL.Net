
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
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_LINEAR_CLIPMAP_LINEAR_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_CENTER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_FRAME_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_OFFSET_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_CLIPMAP_DEPTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176;

		/// <summary>
		/// [GL] Value of GL_MAX_CLIPMAP_DEPTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int MAX_CLIPMAP_DEPTH_SGIX = 0x8177;

		/// <summary>
		/// [GL] Value of GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8178;

		/// <summary>
		/// [GL] Value of GL_NEAREST_CLIPMAP_NEAREST_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D;

		/// <summary>
		/// [GL] Value of GL_NEAREST_CLIPMAP_LINEAR_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E;

		/// <summary>
		/// [GL] Value of GL_LINEAR_CLIPMAP_NEAREST_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		public const int LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F;

	}

}
