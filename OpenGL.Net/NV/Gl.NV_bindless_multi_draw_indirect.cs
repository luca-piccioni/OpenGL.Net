
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
		/// [GL] Binding for glMultiDrawArraysIndirectBindlessNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirectBindNV(PrimitiveType mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectBindlessNV != null, "pglMultiDrawArraysIndirectBindlessNV not implemented");
			Delegates.pglMultiDrawArraysIndirectBindlessNV((Int32)mode, indirect, drawCount, stride, vertexBufferCount);
			LogCommand("glMultiDrawArraysIndirectBindlessNV", null, mode, indirect, drawCount, stride, vertexBufferCount			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiDrawArraysIndirectBindlessNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
		public static void MultiDrawArraysIndirectBindNV(PrimitiveType mode, Object indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirectBindNV(mode, pin_indirect.AddrOfPinnedObject(), drawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glMultiDrawElementsIndirectBindlessNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirectBindNV(PrimitiveType mode, DrawElementsType type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectBindlessNV != null, "pglMultiDrawElementsIndirectBindlessNV not implemented");
			Delegates.pglMultiDrawElementsIndirectBindlessNV((Int32)mode, (Int32)type, indirect, drawCount, stride, vertexBufferCount);
			LogCommand("glMultiDrawElementsIndirectBindlessNV", null, mode, type, indirect, drawCount, stride, vertexBufferCount			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiDrawElementsIndirectBindlessNV.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:DrawElementsType"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="drawCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vertexBufferCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
		public static void MultiDrawElementsIndirectBindNV(PrimitiveType mode, DrawElementsType type, Object indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirectBindNV(mode, type, pin_indirect.AddrOfPinnedObject(), drawCount, stride, vertexBufferCount);
			} finally {
				pin_indirect.Free();
			}
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiDrawArraysIndirectBindlessNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArraysIndirectBindlessNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiDrawElementsIndirectBindlessNV", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElementsIndirectBindlessNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiDrawArraysIndirectBindlessNV(Int32 mode, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawArraysIndirectBindlessNV pglMultiDrawArraysIndirectBindlessNV;

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiDrawElementsIndirectBindlessNV(Int32 mode, Int32 type, IntPtr indirect, Int32 drawCount, Int32 stride, Int32 vertexBufferCount);

			[RequiredByFeature("GL_NV_bindless_multi_draw_indirect", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMultiDrawElementsIndirectBindlessNV pglMultiDrawElementsIndirectBindlessNV;

		}
	}

}
