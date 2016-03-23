
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
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate")]
		public const int CONSERVATIVE_RASTER_DILATE_NV = 0x9379;

		/// <summary>
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate")]
		public const int CONSERVATIVE_RASTER_DILATE_RANGE_NV = 0x937A;

		/// <summary>
		/// Value of GL_CONSERVATIVE_RASTER_DILATE_GRANULARITY_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster_dilate")]
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
		[RequiredByFeature("GL_NV_conservative_raster_dilate")]
		public static void ConservativeRasterParameterfNV(Int32 pname, float value)
		{
			Debug.Assert(Delegates.pglConservativeRasterParameterfNV != null, "pglConservativeRasterParameterfNV not implemented");
			Delegates.pglConservativeRasterParameterfNV(pname, value);
			LogFunction("glConservativeRasterParameterfNV({0}, {1})", LogEnumName(pname), value);
			DebugCheckErrors(null);
		}

	}

}
