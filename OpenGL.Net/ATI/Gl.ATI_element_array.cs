
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
		/// [GL] Value of GL_ELEMENT_ARRAY_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_ATI = 0x8768;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_TYPE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_TYPE_ATI = 0x8769;

		/// <summary>
		/// [GL] Value of GL_ELEMENT_ARRAY_POINTER_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_element_array")]
		public const int ELEMENT_ARRAY_POINTER_ATI = 0x876A;

		/// <summary>
		/// [GL] Binding for glElementPointerATI.
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
			LogCommand("glElementPointerATI", null, type, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glElementPointerATI.
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
		/// [GL] Binding for glDrawElementArrayATI.
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
			LogCommand("glDrawElementArrayATI", null, mode, count			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDrawRangeElementArrayATI.
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
			LogCommand("glDrawRangeElementArrayATI", null, mode, start, end, count			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glElementPointerATI", ExactSpelling = true)]
			internal extern static unsafe void glElementPointerATI(Int32 type, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawElementArrayATI", ExactSpelling = true)]
			internal extern static void glDrawElementArrayATI(Int32 mode, Int32 count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawRangeElementArrayATI", ExactSpelling = true)]
			internal extern static void glDrawRangeElementArrayATI(Int32 mode, UInt32 start, UInt32 end, Int32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ATI_element_array")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glElementPointerATI(Int32 type, IntPtr pointer);

			[RequiredByFeature("GL_ATI_element_array")]
			[ThreadStatic]
			internal static glElementPointerATI pglElementPointerATI;

			[RequiredByFeature("GL_ATI_element_array")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawElementArrayATI(Int32 mode, Int32 count);

			[RequiredByFeature("GL_ATI_element_array")]
			[ThreadStatic]
			internal static glDrawElementArrayATI pglDrawElementArrayATI;

			[RequiredByFeature("GL_ATI_element_array")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawRangeElementArrayATI(Int32 mode, UInt32 start, UInt32 end, Int32 count);

			[RequiredByFeature("GL_ATI_element_array")]
			[ThreadStatic]
			internal static glDrawRangeElementArrayATI pglDrawRangeElementArrayATI;

		}
	}

}
