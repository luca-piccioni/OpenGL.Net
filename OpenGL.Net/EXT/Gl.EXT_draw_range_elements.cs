
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
		/// Value of GL_MAX_ELEMENTS_VERTICES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_draw_range_elements")]
		public const int MAX_ELEMENTS_VERTICES_EXT = 0x80E8;

		/// <summary>
		/// Value of GL_MAX_ELEMENTS_INDICES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_draw_range_elements")]
		public const int MAX_ELEMENTS_INDICES_EXT = 0x80E9;

		/// <summary>
		/// Binding for glDrawRangeElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsEXT != null, "pglDrawRangeElementsEXT not implemented");
			Delegates.pglDrawRangeElementsEXT(mode, start, end, count, type, indices);
			CallLog("glDrawRangeElementsEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DrawRangeElementsEXT(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices)
		{
			Debug.Assert(Delegates.pglDrawRangeElementsEXT != null, "pglDrawRangeElementsEXT not implemented");
			Delegates.pglDrawRangeElementsEXT((int)mode, start, end, count, type, indices);
			CallLog("glDrawRangeElementsEXT({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, count, type, indices);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementsEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="end">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void DrawRangeElementsEXT(int mode, UInt32 start, UInt32 end, Int32 count, int type, Object indices)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawRangeElementsEXT(mode, start, end, count, type, pin_indices.AddrOfPinnedObject());
			} finally {
				pin_indices.Free();
			}
		}

	}

}
