
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
		/// Value of GL_PN_TRIANGLES_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_ATI = 0x87F0;

		/// <summary>
		/// Value of GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_POINT_MODE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_NORMAL_MODE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_pn_triangles")]
		public const int PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;

		/// <summary>
		/// Value of GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI symbol.
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
			LogFunction("glPNTrianglesiATI({0}, {1})", LogEnumName(pname), param);
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
			LogFunction("glPNTrianglesfATI({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

	}

}
