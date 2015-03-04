
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
		/// Value of GL_VERTEX_ARRAY_BINDING_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		public const int VERTEX_ARRAY_BINDING_APPLE = 0x85B5;

		/// <summary>
		/// Binding for glBindVertexArrayAPPLE.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		public static void BindVertexArrayAPPLE(UInt32 array)
		{
			Debug.Assert(Delegates.pglBindVertexArrayAPPLE != null, "pglBindVertexArrayAPPLE not implemented");
			Delegates.pglBindVertexArrayAPPLE(array);
			CallLog("glBindVertexArrayAPPLE({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteVertexArraysAPPLE.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="arrays">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		public static void DeleteVertexArraysAPPLE(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglDeleteVertexArraysAPPLE != null, "pglDeleteVertexArraysAPPLE not implemented");
					Delegates.pglDeleteVertexArraysAPPLE(n, p_arrays);
					CallLog("glDeleteVertexArraysAPPLE({0}, {1})", n, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenVertexArraysAPPLE.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="arrays">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		public static void GenVertexArraysAPPLE(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglGenVertexArraysAPPLE != null, "pglGenVertexArraysAPPLE not implemented");
					Delegates.pglGenVertexArraysAPPLE(n, p_arrays);
					CallLog("glGenVertexArraysAPPLE({0}, {1})", n, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsVertexArrayAPPLE.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_array_object")]
		public static bool IsVertexArrayAPPLE(UInt32 array)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVertexArrayAPPLE != null, "pglIsVertexArrayAPPLE not implemented");
			retValue = Delegates.pglIsVertexArrayAPPLE(array);
			CallLog("glIsVertexArrayAPPLE({0}) = {1}", array, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
