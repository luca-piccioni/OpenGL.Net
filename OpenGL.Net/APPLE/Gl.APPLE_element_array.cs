
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
		/// Value of GL_ELEMENT_ARRAY_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_element_array")]
		public const int ELEMENT_ARRAY_APPLE = 0x8A0C;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_TYPE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_element_array")]
		public const int ELEMENT_ARRAY_TYPE_APPLE = 0x8A0D;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_element_array")]
		public const int ELEMENT_ARRAY_POINTER_APPLE = 0x8A0E;

		/// <summary>
		/// Binding for glElementPointerAPPLE.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void ElementPointerAPPLE(Int32 type, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglElementPointerAPPLE != null, "pglElementPointerAPPLE not implemented");
			Delegates.pglElementPointerAPPLE(type, pointer);
			LogFunction("glElementPointerAPPLE({0}, 0x{1})", LogEnumName(type), pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glElementPointerAPPLE.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void ElementPointerAPPLE(Int32 type, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				ElementPointerAPPLE(type, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glDrawElementArrayAPPLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void DrawElementArrayAPPLE(PrimitiveType mode, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawElementArrayAPPLE != null, "pglDrawElementArrayAPPLE not implemented");
			Delegates.pglDrawElementArrayAPPLE((Int32)mode, first, count);
			LogFunction("glDrawElementArrayAPPLE({0}, {1}, {2})", mode, first, count);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDrawRangeElementArrayAPPLE.
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
		/// <param name="first">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void DrawRangeElementArrayAPPLE(PrimitiveType mode, UInt32 start, UInt32 end, Int32 first, Int32 count)
		{
			Debug.Assert(Delegates.pglDrawRangeElementArrayAPPLE != null, "pglDrawRangeElementArrayAPPLE not implemented");
			Delegates.pglDrawRangeElementArrayAPPLE((Int32)mode, start, end, first, count);
			LogFunction("glDrawRangeElementArrayAPPLE({0}, {1}, {2}, {3}, {4})", mode, start, end, first, count);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawElementArrayAPPLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
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
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void MultiDrawElementArrayAPPLE(PrimitiveType mode, Int32[] first, Int32[] count, Int32 primcount)
		{
			Debug.Assert(first.Length >= primcount);
			Debug.Assert(count.Length >= primcount);
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawElementArrayAPPLE != null, "pglMultiDrawElementArrayAPPLE not implemented");
					Delegates.pglMultiDrawElementArrayAPPLE((Int32)mode, p_first, p_count, primcount);
					LogFunction("glMultiDrawElementArrayAPPLE({0}, {1}, {2}, {3})", mode, LogValue(first), LogValue(count), primcount);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawElementArrayAPPLE.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:PrimitiveType"/>.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void MultiDrawElementArrayAPPLE(PrimitiveType mode, Int32[] first, Int32[] count)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawElementArrayAPPLE != null, "pglMultiDrawElementArrayAPPLE not implemented");
					Delegates.pglMultiDrawElementArrayAPPLE((Int32)mode, p_first, p_count, (Int32)first.Length);
					LogFunction("glMultiDrawElementArrayAPPLE({0}, {1}, {2}, {3})", mode, LogValue(first), LogValue(count), first.Length);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawRangeElementArrayAPPLE.
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
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="primcount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void MultiDrawRangeElementArrayAPPLE(PrimitiveType mode, UInt32 start, UInt32 end, Int32[] first, Int32[] count, Int32 primcount)
		{
			Debug.Assert(first.Length >= primcount);
			Debug.Assert(count.Length >= primcount);
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawRangeElementArrayAPPLE != null, "pglMultiDrawRangeElementArrayAPPLE not implemented");
					Delegates.pglMultiDrawRangeElementArrayAPPLE((Int32)mode, start, end, p_first, p_count, primcount);
					LogFunction("glMultiDrawRangeElementArrayAPPLE({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, LogValue(first), LogValue(count), primcount);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiDrawRangeElementArrayAPPLE.
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
		/// <param name="first">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_element_array")]
		public static void MultiDrawRangeElementArrayAPPLE(PrimitiveType mode, UInt32 start, UInt32 end, Int32[] first, Int32[] count)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawRangeElementArrayAPPLE != null, "pglMultiDrawRangeElementArrayAPPLE not implemented");
					Delegates.pglMultiDrawRangeElementArrayAPPLE((Int32)mode, start, end, p_first, p_count, (Int32)first.Length);
					LogFunction("glMultiDrawRangeElementArrayAPPLE({0}, {1}, {2}, {3}, {4}, {5})", mode, start, end, LogValue(first), LogValue(count), first.Length);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
