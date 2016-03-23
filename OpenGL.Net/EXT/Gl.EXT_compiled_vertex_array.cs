
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
		/// Value of GL_ARRAY_ELEMENT_LOCK_FIRST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_compiled_vertex_array")]
		public const int ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;

		/// <summary>
		/// Value of GL_ARRAY_ELEMENT_LOCK_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_compiled_vertex_array")]
		public const int ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;

		/// <summary>
		/// Binding for glLockArraysEXT.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_compiled_vertex_array")]
		public static void LockArraysEXT(Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglLockArraysEXT != null, "pglLockArraysEXT not implemented");
			Delegates.pglLockArraysEXT(first, count);
			LogFunction("glLockArraysEXT({0}, {1})", first, count);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUnlockArraysEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_compiled_vertex_array")]
		public static void UnlockArraysEXT()
		{
			Debug.Assert(Delegates.pglUnlockArraysEXT != null, "pglUnlockArraysEXT not implemented");
			Delegates.pglUnlockArraysEXT();
			LogFunction("glUnlockArraysEXT()");
			DebugCheckErrors(null);
		}

	}

}
