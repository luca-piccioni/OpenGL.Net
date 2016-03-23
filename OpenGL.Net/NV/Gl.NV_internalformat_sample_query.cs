
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
		/// Value of GL_MULTISAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		public const int MULTISAMPLES_NV = 0x9371;

		/// <summary>
		/// Value of GL_SUPERSAMPLE_SCALE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		public const int SUPERSAMPLE_SCALE_X_NV = 0x9372;

		/// <summary>
		/// Value of GL_SUPERSAMPLE_SCALE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		public const int SUPERSAMPLE_SCALE_Y_NV = 0x9373;

		/// <summary>
		/// Value of GL_CONFORMANT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		public const int CONFORMANT_NV = 0x9374;

		/// <summary>
		/// Binding for glGetInternalformatSampleivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|gles2")]
		public static void GetInternalformatSampleNV(Int32 target, Int32 internalformat, Int32 samples, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformatSampleivNV != null, "pglGetInternalformatSampleivNV not implemented");
					Delegates.pglGetInternalformatSampleivNV(target, internalformat, samples, pname, (Int32)@params.Length, p_params);
					LogFunction("glGetInternalformatSampleivNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(internalformat), samples, LogEnumName(pname), @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
