
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
		/// Value of GL_VERTEX_DATA_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		public const int VERTEX_DATA_HINT_PGI = 0x1A22A;

		/// <summary>
		/// Value of GL_VERTEX_CONSISTENT_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		public const int VERTEX_CONSISTENT_HINT_PGI = 0x1A22B;

		/// <summary>
		/// Value of GL_MATERIAL_SIDE_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		public const int MATERIAL_SIDE_HINT_PGI = 0x1A22C;

		/// <summary>
		/// Value of GL_MAX_VERTEX_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		public const int MAX_VERTEX_HINT_PGI = 0x1A22D;

		/// <summary>
		/// Value of GL_COLOR3_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR3_BIT_PGI = 0x00010000;

		/// <summary>
		/// Value of GL_COLOR4_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR4_BIT_PGI = 0x00020000;

		/// <summary>
		/// Value of GL_EDGEFLAG_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint EDGEFLAG_BIT_PGI = 0x00040000;

		/// <summary>
		/// Value of GL_INDEX_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint INDEX_BIT_PGI = 0x00080000;

		/// <summary>
		/// Value of GL_MAT_AMBIENT_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_AMBIENT_BIT_PGI = 0x00100000;

		/// <summary>
		/// Value of GL_MAT_AMBIENT_AND_DIFFUSE_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_AMBIENT_AND_DIFFUSE_BIT_PGI = 0x00200000;

		/// <summary>
		/// Value of GL_MAT_DIFFUSE_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_DIFFUSE_BIT_PGI = 0x00400000;

		/// <summary>
		/// Value of GL_MAT_EMISSION_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_EMISSION_BIT_PGI = 0x00800000;

		/// <summary>
		/// Value of GL_MAT_COLOR_INDEXES_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_COLOR_INDEXES_BIT_PGI = 0x01000000;

		/// <summary>
		/// Value of GL_MAT_SHININESS_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_SHININESS_BIT_PGI = 0x02000000;

		/// <summary>
		/// Value of GL_MAT_SPECULAR_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint MAT_SPECULAR_BIT_PGI = 0x04000000;

		/// <summary>
		/// Value of GL_NORMAL_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint NORMAL_BIT_PGI = 0x08000000;

		/// <summary>
		/// Value of GL_TEXCOORD1_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint TEXCOORD1_BIT_PGI = 0x10000000;

		/// <summary>
		/// Value of GL_TEXCOORD2_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint TEXCOORD2_BIT_PGI = 0x20000000;

		/// <summary>
		/// Value of GL_TEXCOORD3_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint TEXCOORD3_BIT_PGI = 0x40000000;

		/// <summary>
		/// Value of GL_TEXCOORD4_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint TEXCOORD4_BIT_PGI = 0x80000000;

		/// <summary>
		/// Value of GL_VERTEX23_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX23_BIT_PGI = 0x00000004;

		/// <summary>
		/// Value of GL_VERTEX4_BIT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX4_BIT_PGI = 0x00000008;

	}

}
