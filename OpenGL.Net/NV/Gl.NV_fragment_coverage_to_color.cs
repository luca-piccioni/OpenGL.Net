
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
		/// [GL] Value of GL_FRAGMENT_COVERAGE_TO_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|glcore|gles2")]
		public const int FRAGMENT_COVERAGE_TO_COLOR_NV = 0x92DD;

		/// <summary>
		/// [GL] Value of GL_FRAGMENT_COVERAGE_COLOR_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|glcore|gles2")]
		public const int FRAGMENT_COVERAGE_COLOR_NV = 0x92DE;

		/// <summary>
		/// Binding for glFragmentCoverageColorNV.
		/// </summary>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|glcore|gles2")]
		public static void FragmentCoverageColorNV(UInt32 color)
		{
			Debug.Assert(Delegates.pglFragmentCoverageColorNV != null, "pglFragmentCoverageColorNV not implemented");
			Delegates.pglFragmentCoverageColorNV(color);
			LogCommand("glFragmentCoverageColorNV", null, color			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFragmentCoverageColorNV", ExactSpelling = true)]
			internal extern static void glFragmentCoverageColorNV(UInt32 color);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_fragment_coverage_to_color", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFragmentCoverageColorNV(UInt32 color);

			[ThreadStatic]
			internal static glFragmentCoverageColorNV pglFragmentCoverageColorNV;

		}
	}

}
