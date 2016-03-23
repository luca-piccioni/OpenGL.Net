
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
		/// Value of GL_STENCIL_TEST_TWO_SIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public const int STENCIL_TEST_TWO_SIDE_EXT = 0x8910;

		/// <summary>
		/// Value of GL_ACTIVE_STENCIL_FACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public const int ACTIVE_STENCIL_FACE_EXT = 0x8911;

		/// <summary>
		/// Binding for glActiveStencilFaceEXT.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:StencilFaceDirection"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_stencil_two_side")]
		public static void ActiveStencilFaceEXT(StencilFaceDirection face)
		{
			Debug.Assert(Delegates.pglActiveStencilFaceEXT != null, "pglActiveStencilFaceEXT not implemented");
			Delegates.pglActiveStencilFaceEXT((Int32)face);
			LogFunction("glActiveStencilFaceEXT({0})", face);
			DebugCheckErrors(null);
		}

	}

}
