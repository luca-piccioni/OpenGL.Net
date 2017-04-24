
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
		/// Value of GL_ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_DEFAULT_NV = 0x934D;

		/// <summary>
		/// Value of GL_ALPHA_TO_COVERAGE_DITHER_ENABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_ENABLE_NV = 0x934E;

		/// <summary>
		/// Value of GL_ALPHA_TO_COVERAGE_DITHER_DISABLE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_DISABLE_NV = 0x934F;

		/// <summary>
		/// Value of GL_ALPHA_TO_COVERAGE_DITHER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public const int ALPHA_TO_COVERAGE_DITHER_MODE_NV = 0x92BF;

		/// <summary>
		/// Binding for glAlphaToCoverageDitherControlNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
		public static void AlphaToCoverageDitherControlNV(Int32 mode)
		{
			Debug.Assert(Delegates.pglAlphaToCoverageDitherControlNV != null, "pglAlphaToCoverageDitherControlNV not implemented");
			Delegates.pglAlphaToCoverageDitherControlNV(mode);
			LogCommand("glAlphaToCoverageDitherControlNV", null, mode			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaToCoverageDitherControlNV", ExactSpelling = true)]
			internal extern static void glAlphaToCoverageDitherControlNV(Int32 mode);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_alpha_to_coverage_dither_control")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaToCoverageDitherControlNV(Int32 mode);

			[ThreadStatic]
			internal static glAlphaToCoverageDitherControlNV pglAlphaToCoverageDitherControlNV;

		}
	}

}
