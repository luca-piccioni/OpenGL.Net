
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
		/// Binding for glDrawArraysInstancedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_draw_instanced")]
		public static void DrawArraysInstancedEXT(PrimitiveType mode, Int32 start, Int32 count, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstancedEXT != null, "pglDrawArraysInstancedEXT not implemented");
			Delegates.pglDrawArraysInstancedEXT((int)mode, start, count, primcount);
			CallLog("glDrawArraysInstancedEXT({0}, {1}, {2}, {3})", mode, start, count, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_draw_instanced")]
		public static void DrawElementsInstancedEXT(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 primcount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstancedEXT != null, "pglDrawElementsInstancedEXT not implemented");
			Delegates.pglDrawElementsInstancedEXT((int)mode, count, (int)type, indices, primcount);
			CallLog("glDrawElementsInstancedEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementsInstancedEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_draw_instanced")]
		public static void DrawElementsInstancedEXT(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstancedEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

	}

}
