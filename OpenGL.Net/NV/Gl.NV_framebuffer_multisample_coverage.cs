
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
		/// [GL] Value of GL_RENDERBUFFER_COVERAGE_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int RENDERBUFFER_COVERAGE_SAMPLES_NV = 0x8CAB;

		/// <summary>
		/// [GL] Value of GL_RENDERBUFFER_COLOR_SAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int RENDERBUFFER_COLOR_SAMPLES_NV = 0x8E10;

		/// <summary>
		/// [GL] Value of GL_MAX_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public const int MAX_MULTISAMPLE_COVERAGE_MODES_NV = 0x8E11;

		/// <summary>
		/// [GL] Value of GL_MULTISAMPLE_COVERAGE_MODES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
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
		[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
		public static void RenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleCoverageNV != null, "pglRenderbufferStorageMultisampleCoverageNV not implemented");
			Delegates.pglRenderbufferStorageMultisampleCoverageNV(target, coverageSamples, colorSamples, internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleCoverageNV", null, target, coverageSamples, colorSamples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_framebuffer_multisample_coverage", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleCoverageNV(Int32 target, Int32 coverageSamples, Int32 colorSamples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleCoverageNV pglRenderbufferStorageMultisampleCoverageNV;

		}
	}

}
