
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
		/// [GL] Value of GL_INDEX_TEST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_func")]
		public const int INDEX_TEST_EXT = 0x81B5;

		/// <summary>
		/// [GL] Value of GL_INDEX_TEST_FUNC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_func")]
		public const int INDEX_TEST_FUNC_EXT = 0x81B6;

		/// <summary>
		/// [GL] Value of GL_INDEX_TEST_REF_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_func")]
		public const int INDEX_TEST_REF_EXT = 0x81B7;

		/// <summary>
		/// Binding for glIndexFuncEXT.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_index_func")]
		public static void IndexFuncEXT(Int32 func, float @ref)
		{
			Debug.Assert(Delegates.pglIndexFuncEXT != null, "pglIndexFuncEXT not implemented");
			Delegates.pglIndexFuncEXT(func, @ref);
			LogCommand("glIndexFuncEXT", null, func, @ref			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexFuncEXT", ExactSpelling = true)]
			internal extern static void glIndexFuncEXT(Int32 func, float @ref);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_index_func")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexFuncEXT(Int32 func, float @ref);

			[ThreadStatic]
			internal static glIndexFuncEXT pglIndexFuncEXT;

		}
	}

}
