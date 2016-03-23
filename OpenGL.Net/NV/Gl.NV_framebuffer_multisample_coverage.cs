
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
		/// Value of GL_RENDERBUFFER_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage")]
		public const int RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;

		/// <summary>
		/// Value of GL_RENDERBUFFER_COLOR_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage")]
		public const int RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;

		/// <summary>
		/// Value of GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage")]
		public const int MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;

		/// <summary>
		/// Value of GL_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage")]
		public const int MULTISAMPLE_COVERAGE_MODES_NV = 0x8E12;

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleCoverageNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coverageSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="colorSamples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage")]
		public static void RenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleCoverageNV != null, "pglRenderbufferStorageMultisampleCoverageNV not implemented");
			Delegates.pglRenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
			LogFunction("glRenderbufferStorageMultisampleCoverageNV({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), coverageSamples, colorSamples, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

	}

}
