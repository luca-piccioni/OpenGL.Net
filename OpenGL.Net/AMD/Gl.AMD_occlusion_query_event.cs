
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
		/// [GL] Value of GL_OCCLUSION_QUERY_EVENT_MASK_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const int OCCLUSION_QUERY_EVENT_MASK_AMD = 0x874F;

		/// <summary>
		/// [GL] Value of GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const uint QUERY_DEPTH_PASS_EVENT_BIT_AMD = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const uint QUERY_DEPTH_FAIL_EVENT_BIT_AMD = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const uint QUERY_STENCIL_FAIL_EVENT_BIT_AMD = 0x00000004;

		/// <summary>
		/// [GL] Value of GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const uint QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD = 0x00000008;

		/// <summary>
		/// [GL] Value of GL_QUERY_ALL_EVENT_BITS_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public const uint QUERY_ALL_EVENT_BITS_AMD = 0xFFFFFFFF;

		/// <summary>
		/// Binding for glQueryObjectParameteruiAMD.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:OcclusionQueryEventMaskAMD"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		public static void QueryObjectParameterAMD(QueryTarget target, UInt32 id, Int32 pname, OcclusionQueryEventMaskAMD param)
		{
			Debug.Assert(Delegates.pglQueryObjectParameteruiAMD != null, "pglQueryObjectParameteruiAMD not implemented");
			Delegates.pglQueryObjectParameteruiAMD((Int32)target, id, pname, (UInt32)param);
			LogCommand("glQueryObjectParameteruiAMD", null, target, id, pname, param			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glQueryObjectParameteruiAMD", ExactSpelling = true)]
			internal extern static void glQueryObjectParameteruiAMD(Int32 target, UInt32 id, Int32 pname, UInt32 param);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_occlusion_query_event")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glQueryObjectParameteruiAMD(Int32 target, UInt32 id, Int32 pname, UInt32 param);

			[RequiredByFeature("GL_AMD_occlusion_query_event")]
			[ThreadStatic]
			internal static glQueryObjectParameteruiAMD pglQueryObjectParameteruiAMD;

		}
	}

}
