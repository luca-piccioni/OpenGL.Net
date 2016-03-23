
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
		/// Value of GL_STATIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int STATIC_ATI = 0x8760;

		/// <summary>
		/// Value of GL_DYNAMIC_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int DYNAMIC_ATI = 0x8761;

		/// <summary>
		/// Value of GL_PRESERVE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int PRESERVE_ATI = 0x8762;

		/// <summary>
		/// Value of GL_DISCARD_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int DISCARD_ATI = 0x8763;

		/// <summary>
		/// Value of GL_OBJECT_BUFFER_SIZE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int OBJECT_BUFFER_SIZE_ATI = 0x8764;

		/// <summary>
		/// Value of GL_OBJECT_BUFFER_USAGE_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int OBJECT_BUFFER_USAGE_ATI = 0x8765;

		/// <summary>
		/// Value of GL_ARRAY_OBJECT_BUFFER_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int ARRAY_OBJECT_BUFFER_ATI = 0x8766;

		/// <summary>
		/// Value of GL_ARRAY_OBJECT_OFFSET_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public const int ARRAY_OBJECT_OFFSET_ATI = 0x8767;

		/// <summary>
		/// Binding for glNewObjectBufferATI.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static UInt32 NewObjectBufferATI(Int32 size, IntPtr pointer, Int32 usage)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglNewObjectBufferATI != null, "pglNewObjectBufferATI not implemented");
			retValue = Delegates.pglNewObjectBufferATI(size, pointer, usage);
			LogFunction("glNewObjectBufferATI({0}, 0x{1}, {2}) = {3}", size, pointer.ToString("X8"), LogEnumName(usage), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glNewObjectBufferATI.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static UInt32 NewObjectBufferATI(Int32 size, Object pointer, Int32 usage)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				return (NewObjectBufferATI(size, pin_pointer.AddrOfPinnedObject(), usage));
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glIsObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static bool IsObjectBufferATI(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsObjectBufferATI != null, "pglIsObjectBufferATI not implemented");
			retValue = Delegates.pglIsObjectBufferATI(buffer);
			LogFunction("glIsObjectBufferATI({0}) = {1}", buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glUpdateObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="preserve">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Int32 preserve)
		{
			Debug.Assert(Delegates.pglUpdateObjectBufferATI != null, "pglUpdateObjectBufferATI not implemented");
			Delegates.pglUpdateObjectBufferATI(buffer, offset, size, pointer, preserve);
			LogFunction("glUpdateObjectBufferATI({0}, {1}, {2}, 0x{3}, {4})", buffer, offset, size, pointer.ToString("X8"), LogEnumName(preserve));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUpdateObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="preserve">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, Object pointer, Int32 preserve)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				UpdateObjectBufferATI(buffer, offset, size, pin_pointer.AddrOfPinnedObject(), preserve);
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glGetObjectBufferfvATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetObjectBufferATI(UInt32 buffer, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectBufferfvATI != null, "pglGetObjectBufferfvATI not implemented");
					Delegates.pglGetObjectBufferfvATI(buffer, pname, p_params);
					LogFunction("glGetObjectBufferfvATI({0}, {1}, {2})", buffer, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetObjectBufferivATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetObjectBufferATI(UInt32 buffer, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetObjectBufferivATI != null, "pglGetObjectBufferivATI not implemented");
					Delegates.pglGetObjectBufferivATI(buffer, pname, p_params);
					LogFunction("glGetObjectBufferivATI({0}, {1}, {2})", buffer, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFreeObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void FreeObjectBufferATI(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglFreeObjectBufferATI != null, "pglFreeObjectBufferATI not implemented");
			Delegates.pglFreeObjectBufferATI(buffer);
			LogFunction("glFreeObjectBufferATI({0})", buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glArrayObjectATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void ArrayObjectATI(EnableCap array, Int32 size, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglArrayObjectATI != null, "pglArrayObjectATI not implemented");
			Delegates.pglArrayObjectATI((Int32)array, size, type, stride, buffer, offset);
			LogFunction("glArrayObjectATI({0}, {1}, {2}, {3}, {4}, {5})", array, size, LogEnumName(type), stride, buffer, offset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetArrayObjectfvATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetArrayObjectATI(EnableCap array, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetArrayObjectfvATI != null, "pglGetArrayObjectfvATI not implemented");
					Delegates.pglGetArrayObjectfvATI((Int32)array, pname, p_params);
					LogFunction("glGetArrayObjectfvATI({0}, {1}, {2})", array, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetArrayObjectivATI.
		/// </summary>
		/// <param name="array">
		/// A <see cref="T:EnableCap"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetArrayObjectATI(EnableCap array, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetArrayObjectivATI != null, "pglGetArrayObjectivATI not implemented");
					Delegates.pglGetArrayObjectivATI((Int32)array, pname, p_params);
					LogFunction("glGetArrayObjectivATI({0}, {1}, {2})", array, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVariantArrayObjectATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void VariantArrayObjectATI(UInt32 id, Int32 type, Int32 stride, UInt32 buffer, UInt32 offset)
		{
			Debug.Assert(Delegates.pglVariantArrayObjectATI != null, "pglVariantArrayObjectATI not implemented");
			Delegates.pglVariantArrayObjectATI(id, type, stride, buffer, offset);
			LogFunction("glVariantArrayObjectATI({0}, {1}, {2}, {3}, {4})", id, LogEnumName(type), stride, buffer, offset);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVariantArrayObjectfvATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetVariantArrayObjectATI(UInt32 id, Int32 pname, out float @params)
		{
			unsafe {
				fixed (float* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVariantArrayObjectfvATI != null, "pglGetVariantArrayObjectfvATI not implemented");
					Delegates.pglGetVariantArrayObjectfvATI(id, pname, p_params);
					LogFunction("glGetVariantArrayObjectfvATI({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVariantArrayObjectivATI.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_vertex_array_object")]
		public static void GetVariantArrayObjectATI(UInt32 id, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVariantArrayObjectivATI != null, "pglGetVariantArrayObjectivATI not implemented");
					Delegates.pglGetVariantArrayObjectivATI(id, pname, p_params);
					LogFunction("glGetVariantArrayObjectivATI({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
