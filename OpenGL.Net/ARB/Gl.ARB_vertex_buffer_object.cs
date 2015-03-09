
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
		/// Value of GL_BUFFER_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_SIZE_ARB = 0x8764;

		/// <summary>
		/// Value of GL_BUFFER_USAGE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_USAGE_ARB = 0x8765;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ARRAY_BUFFER_ARB = 0x8892;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ELEMENT_ARRAY_BUFFER_ARB = 0x8893;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ARRAY_BUFFER_BINDING_ARB = 0x8894;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING_ARB = 0x8895;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int VERTEX_ARRAY_BUFFER_BINDING_ARB = 0x8896;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int NORMAL_ARRAY_BUFFER_BINDING_ARB = 0x8897;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int COLOR_ARRAY_BUFFER_BINDING_ARB = 0x8898;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int INDEX_ARRAY_BUFFER_BINDING_ARB = 0x8899;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB = 0x889A;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB = 0x889B;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB = 0x889C;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB = 0x889D;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int WEIGHT_ARRAY_BUFFER_BINDING_ARB = 0x889E;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB = 0x889F;

		/// <summary>
		/// Value of GL_READ_ONLY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int READ_ONLY_ARB = 0x88B8;

		/// <summary>
		/// Value of GL_WRITE_ONLY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int WRITE_ONLY_ARB = 0x88B9;

		/// <summary>
		/// Value of GL_READ_WRITE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int READ_WRITE_ARB = 0x88BA;

		/// <summary>
		/// Value of GL_BUFFER_ACCESS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_ACCESS_ARB = 0x88BB;

		/// <summary>
		/// Value of GL_BUFFER_MAPPED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_MAPPED_ARB = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_MAP_POINTER_ARB = 0x88BD;

		/// <summary>
		/// Value of GL_STREAM_DRAW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_DRAW_ARB = 0x88E0;

		/// <summary>
		/// Value of GL_STREAM_READ_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_READ_ARB = 0x88E1;

		/// <summary>
		/// Value of GL_STREAM_COPY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_COPY_ARB = 0x88E2;

		/// <summary>
		/// Value of GL_STATIC_DRAW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_DRAW_ARB = 0x88E4;

		/// <summary>
		/// Value of GL_STATIC_READ_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_READ_ARB = 0x88E5;

		/// <summary>
		/// Value of GL_STATIC_COPY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_COPY_ARB = 0x88E6;

		/// <summary>
		/// Value of GL_DYNAMIC_DRAW_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_DRAW_ARB = 0x88E8;

		/// <summary>
		/// Value of GL_DYNAMIC_READ_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_READ_ARB = 0x88E9;

		/// <summary>
		/// Value of GL_DYNAMIC_COPY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_COPY_ARB = 0x88EA;

		/// <summary>
		/// Binding for glBindBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BindBufferARB(int target, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferARB != null, "pglBindBufferARB not implemented");
			Delegates.pglBindBufferARB(target, buffer);
			CallLog("glBindBufferARB({0}, {1})", target, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BindBufferARB(BufferTargetARB target, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferARB != null, "pglBindBufferARB not implemented");
			Delegates.pglBindBufferARB((int)target, buffer);
			CallLog("glBindBufferARB({0}, {1})", target, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void DeleteBuffersARB(Int32 n, UInt32[] buffers)
		{
			Debug.Assert(buffers.Length >= n);
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglDeleteBuffersARB != null, "pglDeleteBuffersARB not implemented");
					Delegates.pglDeleteBuffersARB(n, p_buffers);
					CallLog("glDeleteBuffersARB({0}, {1})", n, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void DeleteBuffersARB(UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglDeleteBuffersARB != null, "pglDeleteBuffersARB not implemented");
					Delegates.pglDeleteBuffersARB((Int32)buffers.Length, p_buffers);
					CallLog("glDeleteBuffersARB({0}, {1})", buffers.Length, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GenBuffersARB(Int32 n, UInt32[] buffers)
		{
			Debug.Assert(buffers.Length >= n);
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglGenBuffersARB != null, "pglGenBuffersARB not implemented");
					Delegates.pglGenBuffersARB(n, p_buffers);
					CallLog("glGenBuffersARB({0}, {1})", n, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GenBuffersARB(UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglGenBuffersARB != null, "pglGenBuffersARB not implemented");
					Delegates.pglGenBuffersARB((Int32)buffers.Length, p_buffers);
					CallLog("glGenBuffersARB({0}, {1})", buffers.Length, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenBuffersARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static UInt32 GenBuffersARB()
		{
			UInt32[] retValue = new UInt32[1];
			GenBuffersARB(1, retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glIsBufferARB.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static bool IsBufferARB(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsBufferARB != null, "pglIsBufferARB not implemented");
			retValue = Delegates.pglIsBufferARB(buffer);
			CallLog("glIsBufferARB({0}) = {1}", buffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBufferDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferDataARB(int target, UInt32 size, IntPtr data, int usage)
		{
			Debug.Assert(Delegates.pglBufferDataARB != null, "pglBufferDataARB not implemented");
			Delegates.pglBufferDataARB(target, size, data, usage);
			CallLog("glBufferDataARB({0}, {1}, {2}, {3})", target, size, data, usage);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBufferDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:BufferUsageARB"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferDataARB(BufferTargetARB target, UInt32 size, IntPtr data, BufferUsageARB usage)
		{
			Debug.Assert(Delegates.pglBufferDataARB != null, "pglBufferDataARB not implemented");
			Delegates.pglBufferDataARB((int)target, size, data, (int)usage);
			CallLog("glBufferDataARB({0}, {1}, {2}, {3})", target, size, data, usage);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBufferDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferDataARB(int target, UInt32 size, Object data, int usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferDataARB(target, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glBufferDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="usage">
		/// A <see cref="T:BufferUsageARB"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferDataARB(BufferTargetARB target, UInt32 size, Object data, BufferUsageARB usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferDataARB(target, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubDataARB(int target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglBufferSubDataARB != null, "pglBufferSubDataARB not implemented");
			Delegates.pglBufferSubDataARB(target, offset, size, data);
			CallLog("glBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubDataARB(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglBufferSubDataARB != null, "pglBufferSubDataARB not implemented");
			Delegates.pglBufferSubDataARB((int)target, offset, size, data);
			CallLog("glBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubDataARB(int target, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferSubDataARB(target, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubDataARB(BufferTargetARB target, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferSubDataARB(target, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glGetBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferSubDataARB(int target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetBufferSubDataARB != null, "pglGetBufferSubDataARB not implemented");
			Delegates.pglGetBufferSubDataARB(target, offset, size, data);
			CallLog("glGetBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBufferSubDataARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferSubDataARB(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetBufferSubDataARB != null, "pglGetBufferSubDataARB not implemented");
			Delegates.pglGetBufferSubDataARB((int)target, offset, size, data);
			CallLog("glGetBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMapBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static IntPtr MapBufferARB(int target, int access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferARB != null, "pglMapBufferARB not implemented");
			retValue = Delegates.pglMapBufferARB(target, access);
			CallLog("glMapBufferARB({0}, {1}) = {2}", target, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMapBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static IntPtr MapBufferARB(BufferTargetARB target, int access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferARB != null, "pglMapBufferARB not implemented");
			retValue = Delegates.pglMapBufferARB((int)target, access);
			CallLog("glMapBufferARB({0}, {1}) = {2}", target, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glUnmapBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static bool UnmapBufferARB(int target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapBufferARB != null, "pglUnmapBufferARB not implemented");
			retValue = Delegates.pglUnmapBufferARB(target);
			CallLog("glUnmapBufferARB({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glUnmapBufferARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static bool UnmapBufferARB(BufferTargetARB target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapBufferARB != null, "pglUnmapBufferARB not implemented");
			retValue = Delegates.pglUnmapBufferARB((int)target);
			CallLog("glUnmapBufferARB({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetBufferParameterivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferParameterARB(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameterivARB != null, "pglGetBufferParameterivARB not implemented");
					Delegates.pglGetBufferParameterivARB(target, pname, p_params);
					CallLog("glGetBufferParameterivARB({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBufferParameterivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferParameterARB(BufferTargetARB target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameterivARB != null, "pglGetBufferParameterivARB not implemented");
					Delegates.pglGetBufferParameterivARB((int)target, pname, p_params);
					CallLog("glGetBufferParameterivARB({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBufferPointervARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferPointerARB(int target, int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetBufferPointervARB != null, "pglGetBufferPointervARB not implemented");
			Delegates.pglGetBufferPointervARB(target, pname, @params);
			CallLog("glGetBufferPointervARB({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetBufferPointervARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:BufferTargetARB"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferPointerARB(BufferTargetARB target, int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetBufferPointervARB != null, "pglGetBufferPointervARB not implemented");
			Delegates.pglGetBufferPointervARB((int)target, pname, @params);
			CallLog("glGetBufferPointervARB({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

	}

}
