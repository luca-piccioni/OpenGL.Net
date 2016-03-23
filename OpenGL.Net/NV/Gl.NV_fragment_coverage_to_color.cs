
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
		/// Value of GL_FRAGMENT_COVERAGE_TO_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|gles2")]
		public const int FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;

		/// <summary>
		/// Value of GL_FRAGMENT_COVERAGE_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|gles2")]
		public const int FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;

		/// <summary>
		/// Binding for glFragmentCoverageColorNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|gles2")]
		public static void FragmentCoverageColorNV(UInt32 color)
		{
			Debug.Assert(Delegates.pglFragmentCoverageColorNV != null, "pglFragmentCoverageColorNV not implemented");
			Delegates.pglFragmentCoverageColorNV(color);
			LogFunction("glFragmentCoverageColorNV({0})", color);
			DebugCheckErrors(null);
		}

	}

}
