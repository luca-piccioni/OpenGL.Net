
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
		/// Value of GL_CONSERVATIVE_RASTERIZATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|gles2")]
		public const int CONSERVATIVE_RASTERIZATION_NV = 0x9346;

		/// <summary>
		/// Value of GL_SUBPIXEL_PRECISION_BIAS_X_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|gles2")]
		public const int SUBPIXEL_PRECISION_BIAS_X_BITS_NV = 0x9347;

		/// <summary>
		/// Value of GL_SUBPIXEL_PRECISION_BIAS_Y_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|gles2")]
		public const int SUBPIXEL_PRECISION_BIAS_Y_BITS_NV = 0x9348;

		/// <summary>
		/// Value of GL_MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|gles2")]
		public const int MAX_SUBPIXEL_PRECISION_BIAS_BITS_NV = 0x9349;

		/// <summary>
		/// Binding for glSubpixelPrecisionBiasNV.
		/// </summary>
		/// <param name="xbits">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="ybits">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conservative_raster", Api = "gl|gles2")]
		public static void SubpixelPrecisionBiasNV(UInt32 xbits, UInt32 ybits)
		{
			Debug.Assert(Delegates.pglSubpixelPrecisionBiasNV != null, "pglSubpixelPrecisionBiasNV not implemented");
			Delegates.pglSubpixelPrecisionBiasNV(xbits, ybits);
			LogFunction("glSubpixelPrecisionBiasNV({0}, {1})", xbits, ybits);
			DebugCheckErrors(null);
		}

	}

}
