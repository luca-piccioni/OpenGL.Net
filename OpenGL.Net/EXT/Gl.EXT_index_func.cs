
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
		/// Value of GL_INDEX_TEST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_func")]
		public const int INDEX_TEST_EXT = 0x81B5;

		/// <summary>
		/// Value of GL_INDEX_TEST_FUNC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_index_func")]
		public const int INDEX_TEST_FUNC_EXT = 0x81B6;

		/// <summary>
		/// Value of GL_INDEX_TEST_REF_EXT symbol.
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
			LogFunction("glIndexFuncEXT({0}, {1})", LogEnumName(func), @ref);
			DebugCheckErrors(null);
		}

	}

}
