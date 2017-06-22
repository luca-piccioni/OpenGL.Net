
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
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_NV = 0x954D;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_POST_SNAP_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_POST_SNAP_NV = 0x954E;

		/// <summary>
		/// [GL] Value of GL_CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public const int CONSERVATIVE_RASTER_MODE_PRE_SNAP_TRIANGLES_NV = 0x954F;

		/// <summary>
		/// [GL] Binding for glConservativeRasterParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
		public static void ConservativeRasterParameteriNV(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglConservativeRasterParameteriNV != null, "pglConservativeRasterParameteriNV not implemented");
			Delegates.pglConservativeRasterParameteriNV(pname, param);
			LogCommand("glConservativeRasterParameteriNV", null, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glConservativeRasterParameteriNV", ExactSpelling = true)]
			internal extern static void glConservativeRasterParameteriNV(Int32 pname, Int32 param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConservativeRasterParameteriNV(Int32 pname, Int32 param);

			[RequiredByFeature("GL_NV_conservative_raster_pre_snap_triangles", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glConservativeRasterParameteriNV pglConservativeRasterParameteriNV;

		}
	}

}
