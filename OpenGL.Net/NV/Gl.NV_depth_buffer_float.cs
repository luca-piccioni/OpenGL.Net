
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
		/// [GL] Value of GL_DEPTH_COMPONENT32F_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH_COMPONENT32F_NV = 0x8DAB;

		/// <summary>
		/// [GL] Value of GL_DEPTH32F_STENCIL8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH32F_STENCIL8_NV = 0x8DAC;

		/// <summary>
		/// [GL] Value of GL_DEPTH_BUFFER_FLOAT_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;

		/// <summary>
		/// Binding for glDepthRangedNV.
		/// </summary>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void DepthRangedNV(double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglDepthRangedNV != null, "pglDepthRangedNV not implemented");
			Delegates.pglDepthRangedNV(zNear, zFar);
			LogCommand("glDepthRangedNV", null, zNear, zFar			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearDepthdNV.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void ClearDepthdNV(double depth)
		{
			Debug.Assert(Delegates.pglClearDepthdNV != null, "pglClearDepthdNV not implemented");
			Delegates.pglClearDepthdNV(depth);
			LogCommand("glClearDepthdNV", null, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthBoundsdNV.
		/// </summary>
		/// <param name="zmin">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zmax">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void DepthBoundsdNV(double zmin, double zmax)
		{
			Debug.Assert(Delegates.pglDepthBoundsdNV != null, "pglDepthBoundsdNV not implemented");
			Delegates.pglDepthBoundsdNV(zmin, zmax);
			LogCommand("glDepthBoundsdNV", null, zmin, zmax			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangedNV", ExactSpelling = true)]
			internal extern static void glDepthRangedNV(double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepthdNV", ExactSpelling = true)]
			internal extern static void glClearDepthdNV(double depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthBoundsdNV", ExactSpelling = true)]
			internal extern static void glDepthBoundsdNV(double zmin, double zmax);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_depth_buffer_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRangedNV(double zNear, double zFar);

			[ThreadStatic]
			internal static glDepthRangedNV pglDepthRangedNV;

			[RequiredByFeature("GL_NV_depth_buffer_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepthdNV(double depth);

			[ThreadStatic]
			internal static glClearDepthdNV pglClearDepthdNV;

			[RequiredByFeature("GL_NV_depth_buffer_float")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthBoundsdNV(double zmin, double zmax);

			[ThreadStatic]
			internal static glDepthBoundsdNV pglDepthBoundsdNV;

		}
	}

}
