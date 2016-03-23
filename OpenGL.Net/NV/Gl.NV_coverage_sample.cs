
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
		/// Value of GL_COVERAGE_COMPONENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_COMPONENT_NV = 0x8ED0;

		/// <summary>
		/// Value of GL_COVERAGE_COMPONENT4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_COMPONENT4_NV = 0x8ED1;

		/// <summary>
		/// Value of GL_COVERAGE_ATTACHMENT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_ATTACHMENT_NV = 0x8ED2;

		/// <summary>
		/// Value of GL_COVERAGE_BUFFERS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_BUFFERS_NV = 0x8ED3;

		/// <summary>
		/// Value of GL_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_SAMPLES_NV = 0x8ED4;

		/// <summary>
		/// Value of GL_COVERAGE_ALL_FRAGMENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5;

		/// <summary>
		/// Value of GL_COVERAGE_EDGE_FRAGMENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6;

		/// <summary>
		/// Value of GL_COVERAGE_AUTOMATIC_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public const int COVERAGE_AUTOMATIC_NV = 0x8ED7;

		/// <summary>
		/// Value of GL_COVERAGE_BUFFER_BIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COVERAGE_BUFFER_BIT_NV = 0x00008000;

		/// <summary>
		/// Binding for glCoverageMaskNV.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public static void CoverageMaskNV(bool mask)
		{
			Debug.Assert(Delegates.pglCoverageMaskNV != null, "pglCoverageMaskNV not implemented");
			Delegates.pglCoverageMaskNV(mask);
			LogFunction("glCoverageMaskNV({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glCoverageOperationNV.
		/// </summary>
		/// <param name="operation">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		public static void CoverageOpNV(Int32 operation)
		{
			Debug.Assert(Delegates.pglCoverageOperationNV != null, "pglCoverageOperationNV not implemented");
			Delegates.pglCoverageOperationNV(operation);
			LogFunction("glCoverageOperationNV({0})", LogEnumName(operation));
			DebugCheckErrors(null);
		}

	}

}
