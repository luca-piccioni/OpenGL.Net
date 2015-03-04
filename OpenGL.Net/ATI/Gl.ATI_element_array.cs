
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
		/// Value of GL_ELEMENT_ARRAY_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_ATI = 0x8768;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_TYPE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_TYPE_ATI = 0x8769;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_POINTER_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_POINTER_ATI = 0x876A;

		/// <summary>
		/// Binding for glElementPointerATI.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void ElementPointerATI(int type, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglElementPointerATI != null, "pglElementPointerATI not implemented");
			Delegates.pglElementPointerATI(type, pointer);
			CallLog("glElementPointerATI({0}, {1})", type, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glElementPointerATI.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void ElementPointerATI(int type, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ElementPointerATI(type, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementArrayATI.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void DrawElementArrayATI(int mode, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawElementArrayATI != null, "pglDrawElementArrayATI not implemented");
			Delegates.pglDrawElementArrayATI(mode, count);
			CallLog("glDrawElementArrayATI({0}, {1})", mode, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawElementArrayATI.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void DrawElementArrayATI(PrimitiveType mode, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawElementArrayATI != null, "pglDrawElementArrayATI not implemented");
			Delegates.pglDrawElementArrayATI((int)mode, count);
			CallLog("glDrawElementArrayATI({0}, {1})", mode, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementArrayATI.
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
		[RequiredByFeature("GL_ATI_element_array")]
		public static void DrawRangeElementArrayATI(int mode, UInt32 start, UInt32 end, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawRangeElementArrayATI != null, "pglDrawRangeElementArrayATI not implemented");
			Delegates.pglDrawRangeElementArrayATI(mode, start, end, count);
			CallLog("glDrawRangeElementArrayATI({0}, {1}, {2}, {3})", mode, start, end, count);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawRangeElementArrayATI.
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
		[RequiredByFeature("GL_ATI_element_array")]
		public static void DrawRangeElementArrayATI(PrimitiveType mode, UInt32 start, UInt32 end, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawRangeElementArrayATI != null, "pglDrawRangeElementArrayATI not implemented");
			Delegates.pglDrawRangeElementArrayATI((int)mode, start, end, count);
			CallLog("glDrawRangeElementArrayATI({0}, {1}, {2}, {3})", mode, start, end, count);
			DebugCheckErrors();
		}

	}

}
