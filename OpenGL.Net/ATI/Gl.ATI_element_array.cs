
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void ElementPointerATI(Int32 type, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglElementPointerATI != null, "pglElementPointerATI not implemented");
			Delegates.pglElementPointerATI(type, pointer);
			LogFunction("glElementPointerATI({0}, 0x{1})", LogEnumName(type), pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glElementPointerATI.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void ElementPointerATI(Int32 type, Object pointer)
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
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_element_array")]
		public static void DrawElementArrayATI(PrimitiveType mode, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawElementArrayATI != null, "pglDrawElementArrayATI not implemented");
			Delegates.pglDrawElementArrayATI((Int32)mode, count);
			LogFunction("glDrawElementArrayATI({0}, {1})", mode, count);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawRangeElementArrayATI.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
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
			Delegates.pglDrawRangeElementArrayATI((Int32)mode, start, end, count);
			LogFunction("glDrawRangeElementArrayATI({0}, {1}, {2}, {3})", mode, start, end, count);
			DebugCheckErrors(null);
		}

	}

}
