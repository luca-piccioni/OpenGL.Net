
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
		/// Value of GL_DEPTH_BOUNDS_TEST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_depth_bounds_test")]
		public const int DEPTH_BOUNDS_TEST_EXT = 0x8890;

		/// <summary>
		/// Value of GL_DEPTH_BOUNDS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_depth_bounds_test")]
		public const int DEPTH_BOUNDS_EXT = 0x8891;

		/// <summary>
		/// Binding for glDepthBoundsEXT.
		/// </summary>
		/// <param name="zmin">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zmax">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_depth_bounds_test")]
		public static void DepthBoundsEXT(double zmin, double zmax)
		{
			Debug.Assert(Delegates.pglDepthBoundsEXT != null, "pglDepthBoundsEXT not implemented");
			Delegates.pglDepthBoundsEXT(zmin, zmax);
			LogFunction("glDepthBoundsEXT({0}, {1})", zmin, zmax);
			DebugCheckErrors(null);
		}

	}

}
