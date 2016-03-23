
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
		/// Value of GL_VERTICES_SUBMITTED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int VERTICES_SUBMITTED_ARB = 0x82EE;

		/// <summary>
		/// Value of GL_PRIMITIVES_SUBMITTED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int PRIMITIVES_SUBMITTED_ARB = 0x82EF;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_INVOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int VERTEX_SHADER_INVOCATIONS_ARB = 0x82F0;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_PATCHES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int TESS_CONTROL_SHADER_PATCHES_ARB = 0x82F1;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int TESS_EVALUATION_SHADER_INVOCATIONS_ARB = 0x82F2;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB = 0x82F3;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_INVOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int FRAGMENT_SHADER_INVOCATIONS_ARB = 0x82F4;

		/// <summary>
		/// Value of GL_COMPUTE_SHADER_INVOCATIONS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int COMPUTE_SHADER_INVOCATIONS_ARB = 0x82F5;

		/// <summary>
		/// Value of GL_CLIPPING_INPUT_PRIMITIVES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int CLIPPING_INPUT_PRIMITIVES_ARB = 0x82F6;

		/// <summary>
		/// Value of GL_CLIPPING_OUTPUT_PRIMITIVES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_pipeline_statistics_query", Api = "gl|glcore")]
		public const int CLIPPING_OUTPUT_PRIMITIVES_ARB = 0x82F7;

	}

}
