
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
		/// Binding for glMultiDrawArraysEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multi_draw_arrays")]
		public static void MultiDrawArraysEXT(int mode, Int32[] first, Int32[] count, Int32 primcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawArraysEXT != null, "pglMultiDrawArraysEXT not implemented");
					Delegates.pglMultiDrawArraysEXT(mode, p_first, p_count, primcount);
					CallLog("glMultiDrawArraysEXT({0}, {1}, {2}, {3})", mode, first, count, primcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawArraysEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multi_draw_arrays")]
		public static void MultiDrawArraysEXT(PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawArraysEXT != null, "pglMultiDrawArraysEXT not implemented");
					Delegates.pglMultiDrawArraysEXT((int)mode, p_first, p_count, primcount);
					CallLog("glMultiDrawArraysEXT({0}, {1}, {2}, {3})", mode, first, count, primcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multi_draw_arrays")]
		public static void MultiDrawElementsEXT(int mode, Int32[] count, int type, IntPtr indices, Int32 primcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsEXT != null, "pglMultiDrawElementsEXT not implemented");
					Delegates.pglMultiDrawElementsEXT(mode, p_count, type, indices, primcount);
					CallLog("glMultiDrawElementsEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multi_draw_arrays")]
		public static void MultiDrawElementsEXT(PrimitiveType mode, Int32[] count, int type, IntPtr indices, Int32 primcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawElementsEXT != null, "pglMultiDrawElementsEXT not implemented");
					Delegates.pglMultiDrawElementsEXT((int)mode, p_count, type, indices, primcount);
					CallLog("glMultiDrawElementsEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, primcount);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_multi_draw_arrays")]
		public static void MultiDrawElementsEXT(int mode, Int32[] count, int type, Object indices, Int32 primcount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiDrawElementsEXT(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount);
			} finally {
				pin_indices.Free();
			}
		}

	}

}
