
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
		/// Binding for glMultiDrawArraysIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count")]
		public static void MultiDrawArraysIndirectBindNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectBindlessCountNV != null, "pglMultiDrawArraysIndirectBindlessCountNV not implemented");
			Delegates.pglMultiDrawArraysIndirectBindlessCountNV(mode, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			LogFunction("glMultiDrawArraysIndirectBindlessCountNV({0}, 0x{1}, {2}, {3}, {4}, {5})", LogEnumName(mode), indirect.ToString("X8"), drawCount, maxDrawCount, stride, vertexBufferCount);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count")]
		public static void MultiDrawArraysIndirectBindNV(Int32 mode, Object indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirectBindNV(mode, pin_indirect.AddrOfPinnedObject(), drawCount, maxDrawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count")]
		public static void MultiDrawElementsIndirectBindNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectBindlessCountNV != null, "pglMultiDrawElementsIndirectBindlessCountNV not implemented");
			Delegates.pglMultiDrawElementsIndirectBindlessCountNV(mode, type, indirect, drawCount, maxDrawCount, stride, vertexBufferCount);
			LogFunction("glMultiDrawElementsIndirectBindlessCountNV({0}, {1}, 0x{2}, {3}, {4}, {5}, {6})", LogEnumName(mode), LogEnumName(type), indirect.ToString("X8"), drawCount, maxDrawCount, stride, vertexBufferCount);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectBindlessCountNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="maxDrawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect_count")]
		public static void MultiDrawElementsIndirectBindNV(Int32 mode, Int32 type, Object indirect, Int32 drawCount, Int32 maxDrawCount, Int32 stride, Int32 vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirectBindNV(mode, type, pin_indirect.AddrOfPinnedObject(), drawCount, maxDrawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

	}

}
