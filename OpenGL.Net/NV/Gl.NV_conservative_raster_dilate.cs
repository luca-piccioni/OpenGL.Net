
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
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_NV = 0x9379;

		/// <summary>
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;

		/// <summary>
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public const int CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV = 0x937B;

		/// <summary>
		/// Binding for glConservativeRasterParameterfNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
		public static void ConservativeRasterParameterfNV(Int32 pname, float value)
		{
			Debug.Assert(Delegates.pglConservativeRasterParameterfNV != null, "pglConservativeRasterParameterfNV not implemented");
			Delegates.pglConservativeRasterParameterfNV(pname, value);
			LogCommand("glConservativeRasterParameterfNV", null, pname, value			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glConservativeRasterParameterfNV", ExactSpelling = true)]
			internal extern static void glConservativeRasterParameterfNV(Int32 pname, float value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_conservative_raster_dilate", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glConservativeRasterParameterfNV(Int32 pname, float value);

			[ThreadStatic]
			internal static glConservativeRasterParameterfNV pglConservativeRasterParameterfNV;

		}
	}

}
