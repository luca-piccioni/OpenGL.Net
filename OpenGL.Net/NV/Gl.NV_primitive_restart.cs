
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
		/// [GL] Value of GL_PRIMITIVE_RESTART_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_primitive_restart")]
		public const int PRIMITIVE_RESTART_NV = 0x8558;

		/// <summary>
		/// [GL] Value of GL_PRIMITIVE_RESTART_INDEX_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_primitive_restart")]
		public const int PRIMITIVE_RESTART_INDEX_NV = 0x8559;

		/// <summary>
		/// [GL] Binding for glPrimitiveRestartNV.
		/// </summary>
		[RequiredByFeature("GL_NV_primitive_restart")]
		public static void PrimitiveRestartNV()
		{
			Debug.Assert(Delegates.pglPrimitiveRestartNV != null, "pglPrimitiveRestartNV not implemented");
			Delegates.pglPrimitiveRestartNV();
			LogCommand("glPrimitiveRestartNV", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPrimitiveRestartIndexNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_primitive_restart")]
		public static void PrimitiveRestartIndexNV(UInt32 index)
		{
			Debug.Assert(Delegates.pglPrimitiveRestartIndexNV != null, "pglPrimitiveRestartIndexNV not implemented");
			Delegates.pglPrimitiveRestartIndexNV(index);
			LogCommand("glPrimitiveRestartIndexNV", null, index			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPrimitiveRestartNV", ExactSpelling = true)]
			internal extern static void glPrimitiveRestartNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPrimitiveRestartIndexNV", ExactSpelling = true)]
			internal extern static void glPrimitiveRestartIndexNV(UInt32 index);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_primitive_restart")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPrimitiveRestartNV();

			[RequiredByFeature("GL_NV_primitive_restart")]
			[ThreadStatic]
			internal static glPrimitiveRestartNV pglPrimitiveRestartNV;

			[RequiredByFeature("GL_NV_primitive_restart")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPrimitiveRestartIndexNV(UInt32 index);

			[RequiredByFeature("GL_NV_primitive_restart")]
			[ThreadStatic]
			internal static glPrimitiveRestartIndexNV pglPrimitiveRestartIndexNV;

		}
	}

}
