
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
		/// Value of GL_QUAD_MESH_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public const int QUAD_MESH_SUN = 0x8614;

		/// <summary>
		/// Value of GL_TRIANGLE_MESH_SUN symbol.
		/// </summary>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public const int TRIANGLE_MESH_SUN = 0x8615;

		/// <summary>
		/// Binding for glDrawMeshArraysSUN.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SUN_mesh_array")]
		public static void DrawMeshArraysSUN(PrimitiveType mode, Int32 first, Int32 count, Int32 width)
		{
			Debug.Assert(Delegates.pglDrawMeshArraysSUN != null, "pglDrawMeshArraysSUN not implemented");
			Delegates.pglDrawMeshArraysSUN((Int32)mode, first, count, width);
			LogFunction("glDrawMeshArraysSUN({0}, {1}, {2}, {3})", mode, first, count, width);
			DebugCheckErrors(null);
		}

	}

}
