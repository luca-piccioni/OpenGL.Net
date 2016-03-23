
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
		/// Value of GL_SAMPLER_BUFFER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int SAMPLER_BUFFER_AMD = 0x9001;

		/// <summary>
		/// Value of GL_INT_SAMPLER_BUFFER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int INT_SAMPLER_BUFFER_AMD = 0x9002;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_BUFFER_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int UNSIGNED_INT_SAMPLER_BUFFER_AMD = 0x9003;

		/// <summary>
		/// Value of GL_TESSELLATION_MODE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int TESSELLATION_MODE_AMD = 0x9004;

		/// <summary>
		/// Value of GL_TESSELLATION_FACTOR_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int TESSELLATION_FACTOR_AMD = 0x9005;

		/// <summary>
		/// Value of GL_DISCRETE_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int DISCRETE_AMD = 0x9006;

		/// <summary>
		/// Value of GL_CONTINUOUS_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public const int CONTINUOUS_AMD = 0x9007;

		/// <summary>
		/// Binding for glTessellationFactorAMD.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public static void TessellationFactorAMD(float factor)
		{
			Debug.Assert(Delegates.pglTessellationFactorAMD != null, "pglTessellationFactorAMD not implemented");
			Delegates.pglTessellationFactorAMD(factor);
			LogFunction("glTessellationFactorAMD({0})", factor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTessellationModeAMD.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_vertex_shader_tessellator")]
		public static void TessellationModeAMD(Int32 mode)
		{
			Debug.Assert(Delegates.pglTessellationModeAMD != null, "pglTessellationModeAMD not implemented");
			Delegates.pglTessellationModeAMD(mode);
			LogFunction("glTessellationModeAMD({0})", LogEnumName(mode));
			DebugCheckErrors(null);
		}

	}

}
