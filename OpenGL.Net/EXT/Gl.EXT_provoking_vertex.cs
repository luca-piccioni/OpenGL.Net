
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
		/// Value of GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION_EXT = 0x8E4C;

		/// <summary>
		/// Value of GL_FIRST_VERTEX_CONVENTION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int FIRST_VERTEX_CONVENTION_EXT = 0x8E4D;

		/// <summary>
		/// Value of GL_LAST_VERTEX_CONVENTION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int LAST_VERTEX_CONVENTION_EXT = 0x8E4E;

		/// <summary>
		/// Value of GL_PROVOKING_VERTEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		public const int PROVOKING_VERTEX_EXT = 0x8E4F;

		/// <summary>
		/// Binding for glProvokingVertexEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void ProvokingVertexEXT(int mode)
		{
			Debug.Assert(Delegates.pglProvokingVertexEXT != null, "pglProvokingVertexEXT not implemented");
			Delegates.pglProvokingVertexEXT(mode);
			CallLog("glProvokingVertexEXT({0})", mode);
			DebugCheckErrors();
		}

	}

}
