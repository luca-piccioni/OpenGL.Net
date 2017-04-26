
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
		/// [GL] Value of GL_PN_TRIANGLES_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_ATI = 0x87F0;

		/// <summary>
		/// [GL] Value of GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_POINT_MODE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_NORMAL_MODE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;

		/// <summary>
		/// [GL] Value of GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;

		/// <summary>
		/// Binding for glPNTrianglesiATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public static void PNTrianglesATI(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPNTrianglesiATI != null, "pglPNTrianglesiATI not implemented");
			Delegates.pglPNTrianglesiATI(pname, param);
			LogCommand("glPNTrianglesiATI", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPNTrianglesfATI.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public static void PNTrianglesATI(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglPNTrianglesfATI != null, "pglPNTrianglesfATI not implemented");
			Delegates.pglPNTrianglesfATI(pname, param);
			LogCommand("glPNTrianglesfATI", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPNTrianglesiATI", ExactSpelling = true)]
			internal extern static void glPNTrianglesiATI(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPNTrianglesfATI", ExactSpelling = true)]
			internal extern static void glPNTrianglesfATI(Int32 pname, float param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_pn_triangles")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPNTrianglesiATI(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPNTrianglesiATI pglPNTrianglesiATI;

			[RequiredByFeature("GL_ATI_pn_triangles")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPNTrianglesfATI(Int32 pname, float param);

			[ThreadStatic]
			internal static glPNTrianglesfATI pglPNTrianglesfATI;

		}
	}

}
