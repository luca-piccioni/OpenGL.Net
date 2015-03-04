
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
		/// Binding for glMultiModeDrawArraysIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int[]"/>.
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
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawArraysIBM(int[] mode, Int32[] first, Int32[] count, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (int* p_mode = mode)
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiModeDrawArraysIBM != null, "pglMultiModeDrawArraysIBM not implemented");
					Delegates.pglMultiModeDrawArraysIBM(p_mode, p_first, p_count, primcount, modestride);
					CallLog("glMultiModeDrawArraysIBM({0}, {1}, {2}, {3}, {4})", mode, first, count, primcount, modestride);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiModeDrawElementsIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int[]"/>.
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
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawElementsIBM(int[] mode, Int32[] count, int type, IntPtr indices, Int32 primcount, Int32 modestride)
		{
			unsafe {
				fixed (int* p_mode = mode)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiModeDrawElementsIBM != null, "pglMultiModeDrawElementsIBM not implemented");
					Delegates.pglMultiModeDrawElementsIBM(p_mode, p_count, type, indices, primcount, modestride);
					CallLog("glMultiModeDrawElementsIBM({0}, {1}, {2}, {3}, {4}, {5})", mode, count, type, indices, primcount, modestride);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMultiModeDrawElementsIBM.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int[]"/>.
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
		/// <param name="modestride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_multimode_draw_arrays")]
		public static void MultiModeDrawElementsIBM(int[] mode, Int32[] count, int type, Object indices, Int32 primcount, Int32 modestride)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				MultiModeDrawElementsIBM(mode, count, type, pin_indices.AddrOfPinnedObject(), primcount, modestride);
			} finally {
				pin_indices.Free();
			}
		}

	}

}
