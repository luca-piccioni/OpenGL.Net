
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
		/// Binding for glMultiDrawArraysIndirectAMD.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		public static void MultiDrawArraysIndirectAMD(int mode, IntPtr indirect, Int32 primcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawArraysIndirectAMD != null, "pglMultiDrawArraysIndirectAMD not implemented");
			Delegates.pglMultiDrawArraysIndirectAMD(mode, indirect, primcount, stride);
			CallLog("glMultiDrawArraysIndirectAMD({0}, {1}, {2}, {3})", mode, indirect, primcount, stride);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawArraysIndirectAMD.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		public static void MultiDrawArraysIndirectAMD(int mode, Object indirect, Int32 primcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawArraysIndirectAMD(mode, pin_indirect.AddrOfPinnedObject(), primcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectAMD.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		public static void MultiDrawElementsIndirectAMD(int mode, int type, IntPtr indirect, Int32 primcount, Int32 stride)
		{
			Debug.Assert(Delegates.pglMultiDrawElementsIndirectAMD != null, "pglMultiDrawElementsIndirectAMD not implemented");
			Delegates.pglMultiDrawElementsIndirectAMD(mode, type, indirect, primcount, stride);
			CallLog("glMultiDrawElementsIndirectAMD({0}, {1}, {2}, {3}, {4})", mode, type, indirect, primcount, stride);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiDrawElementsIndirectAMD.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indirect">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_multi_draw_indirect")]
		public static void MultiDrawElementsIndirectAMD(int mode, int type, Object indirect, Int32 primcount, Int32 stride)
		{
			GCHandle pin_indirect = GCHandle.Alloc(indirect, GCHandleType.Pinned);
			try {
				MultiDrawElementsIndirectAMD(mode, type, pin_indirect.AddrOfPinnedObject(), primcount, stride);
			} finally {
				pin_indirect.Free();
			}
		}

	}

}
