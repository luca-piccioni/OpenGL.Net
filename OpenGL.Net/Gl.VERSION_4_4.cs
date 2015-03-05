
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
		/// Value of GL_MAX_VERTEX_ATTRIB_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		public const int MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		public const int PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		public const int TEXTURE_BUFFER_BINDING = 0x8C2A;

		/// <summary>
		/// Value of GL_MAP_PERSISTENT_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int MAP_PERSISTENT_BIT = 0x0040;

		/// <summary>
		/// Value of GL_MAP_COHERENT_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int MAP_COHERENT_BIT = 0x0080;

		/// <summary>
		/// Value of GL_DYNAMIC_STORAGE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int DYNAMIC_STORAGE_BIT = 0x0100;

		/// <summary>
		/// Value of GL_CLIENT_STORAGE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int CLIENT_STORAGE_BIT = 0x0200;

		/// <summary>
		/// Value of GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;

		/// <summary>
		/// Value of GL_BUFFER_IMMUTABLE_STORAGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int BUFFER_IMMUTABLE_STORAGE = 0x821F;

		/// <summary>
		/// Value of GL_BUFFER_STORAGE_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public const int BUFFER_STORAGE_FLAGS = 0x8220;

		/// <summary>
		/// Value of GL_CLEAR_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture")]
		public const int CLEAR_TEXTURE = 0x9365;

		/// <summary>
		/// Value of GL_LOCATION_COMPONENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts")]
		public const int LOCATION_COMPONENT = 0x934A;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts")]
		public const int TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts")]
		public const int TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

		/// <summary>
		/// Value of GL_QUERY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object")]
		public const int QUERY_BUFFER = 0x9192;

		/// <summary>
		/// Value of GL_QUERY_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object")]
		public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;

		/// <summary>
		/// Value of GL_QUERY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object")]
		public const int QUERY_BUFFER_BINDING = 0x9193;

		/// <summary>
		/// Value of GL_QUERY_RESULT_NO_WAIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object")]
		public const int QUERY_RESULT_NO_WAIT = 0x9194;

		/// <summary>
		/// Value of GL_MIRROR_CLAMP_TO_EDGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_texture_mirror_clamp_to_edge")]
		public const int MIRROR_CLAMP_TO_EDGE = 0x8743;

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferStorage, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// GL_DYNAMIC_STORAGE_BIT, GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public static void BufferStorage(int target, UInt32 size, IntPtr data, uint flags)
		{
			Debug.Assert(Delegates.pglBufferStorage != null, "pglBufferStorage not implemented");
			Delegates.pglBufferStorage(target, size, data, flags);
			CallLog("glBufferStorage({0}, {1}, {2}, {3})", target, size, data, flags);
			DebugCheckErrors();
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferStorage, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// GL_DYNAMIC_STORAGE_BIT, GL_MAP_READ_BITGL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, GL_MAP_COHERENT_BIT, and 
		/// GL_CLIENT_STORAGE_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		public static void BufferStorage(int target, UInt32 size, Object data, uint flags)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferStorage(target, size, pin_data.AddrOfPinnedObject(), flags);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// fills all a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of texture containing the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by data.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by data.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture")]
		public static void ClearTexImage(UInt32 texture, Int32 level, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearTexImage != null, "pglClearTexImage not implemented");
			Delegates.pglClearTexImage(texture, level, format, type, data);
			CallLog("glClearTexImage({0}, {1}, {2}, {3}, {4})", texture, level, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fills all a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of texture containing the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by data.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by data.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture")]
		public static void ClearTexImage(UInt32 texture, Int32 level, int format, int type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearTexImage(texture, level, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// fills all or part of a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of texture containing the region to be cleared.
		/// </param>
		/// <param name="xoffset">
		/// The coordinate of the left edge of the region to be cleared.
		/// </param>
		/// <param name="yoffset">
		/// The coordinate of the lower edge of the region to be cleared.
		/// </param>
		/// <param name="zoffset">
		/// The coordinate of the front of the region to be cleared.
		/// </param>
		/// <param name="width">
		/// The width of the region to be cleared.
		/// </param>
		/// <param name="height">
		/// The height of the region to be cleared.
		/// </param>
		/// <param name="depth">
		/// The depth of the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by data.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by data.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture")]
		public static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearTexSubImage != null, "pglClearTexSubImage not implemented");
			Delegates.pglClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
			CallLog("glClearTexSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// fills all or part of a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of texture containing the region to be cleared.
		/// </param>
		/// <param name="xoffset">
		/// The coordinate of the left edge of the region to be cleared.
		/// </param>
		/// <param name="yoffset">
		/// The coordinate of the lower edge of the region to be cleared.
		/// </param>
		/// <param name="zoffset">
		/// The coordinate of the front of the region to be cleared.
		/// </param>
		/// <param name="width">
		/// The width of the region to be cleared.
		/// </param>
		/// <param name="height">
		/// The height of the region to be cleared.
		/// </param>
		/// <param name="depth">
		/// The depth of the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by data.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by data.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture")]
		public static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// bind one or more buffer objects to a sequence of indexed buffer targets
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFER or GL_SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// Specify the number of contiguous binding points to which to bind buffers.
		/// </param>
		/// <param name="buffers">
		/// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or NULL.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindBuffersBase(int target, UInt32 first, Int32 count, UInt32[] buffers)
		{
			Debug.Assert(buffers.Length >= count);
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglBindBuffersBase != null, "pglBindBuffersBase not implemented");
					Delegates.pglBindBuffersBase(target, first, count, p_buffers);
					CallLog("glBindBuffersBase({0}, {1}, {2}, {3})", target, first, count, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind ranges of one or more buffer objects to a sequence of indexed buffer targets
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFER or GL_SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// Specify the number of contiguous binding points to which to bind buffers.
		/// </param>
		/// <param name="buffers">
		/// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or NULL.
		/// </param>
		/// <param name="offsets">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindBuffersRange(int target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, UInt32[] sizes)
		{
			Debug.Assert(buffers.Length >= count);
			Debug.Assert(offsets.Length >= count);
			Debug.Assert(sizes.Length >= count);
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (UInt32* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglBindBuffersRange != null, "pglBindBuffersRange not implemented");
					Delegates.pglBindBuffersRange(target, first, count, p_buffers, p_offsets, p_sizes);
					CallLog("glBindBuffersRange({0}, {1}, {2}, {3}, {4}, {5})", target, first, count, buffers, offsets, sizes);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind one or more named textures to a sequence of consecutive texture units
		/// </summary>
		/// <param name="first">
		/// Specifies the first texture unit to which a texture is to be bound.
		/// </param>
		/// <param name="count">
		/// Specifies the number of textures to bind.
		/// </param>
		/// <param name="textures">
		/// Specifies the address of an array of names of existing texture objects.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindTextures(UInt32 first, Int32 count, UInt32[] textures)
		{
			Debug.Assert(textures.Length >= count);
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglBindTextures != null, "pglBindTextures not implemented");
					Delegates.pglBindTextures(first, count, p_textures);
					CallLog("glBindTextures({0}, {1}, {2})", first, count, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind one or more named sampler objects to a sequence of consecutive sampler units
		/// </summary>
		/// <param name="first">
		/// Specifies the first sampler unit to which a sampler object is to be bound.
		/// </param>
		/// <param name="count">
		/// Specifies the number of samplers to bind.
		/// </param>
		/// <param name="samplers">
		/// Specifies the address of an array of names of existing sampler objects.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers)
		{
			Debug.Assert(samplers.Length >= count);
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglBindSamplers != null, "pglBindSamplers not implemented");
					Delegates.pglBindSamplers(first, count, p_samplers);
					CallLog("glBindSamplers({0}, {1}, {2})", first, count, samplers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind one or more named texture images to a sequence of consecutive image units
		/// </summary>
		/// <param name="first">
		/// Specifies the first image unit to which a texture is to be bound.
		/// </param>
		/// <param name="count">
		/// Specifies the number of textures to bind.
		/// </param>
		/// <param name="textures">
		/// Specifies the address of an array of names of existing texture objects.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures)
		{
			Debug.Assert(textures.Length >= count);
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglBindImageTextures != null, "pglBindImageTextures not implemented");
					Delegates.pglBindImageTextures(first, count, p_textures);
					CallLog("glBindImageTextures({0}, {1}, {2})", first, count, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// attach multiple buffer objects to a vertex array object
		/// </summary>
		/// <param name="first">
		/// Specifies the first vertex buffer binding point to which a buffer object is to be bound.
		/// </param>
		/// <param name="count">
		/// Specifies the number of buffers to bind.
		/// </param>
		/// <param name="buffers">
		/// Specifies the address of an array of names of existing buffer objects.
		/// </param>
		/// <param name="offsets">
		/// Specifies the address of an array of offsets to associate with the binding points.
		/// </param>
		/// <param name="strides">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
		{
			Debug.Assert(buffers.Length >= count);
			Debug.Assert(offsets.Length >= count);
			Debug.Assert(strides.Length >= count);
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (Int32* p_strides = strides)
				{
					Debug.Assert(Delegates.pglBindVertexBuffers != null, "pglBindVertexBuffers not implemented");
					Delegates.pglBindVertexBuffers(first, count, p_buffers, p_offsets, p_strides);
					CallLog("glBindVertexBuffers({0}, {1}, {2}, {3}, {4})", first, count, buffers, offsets, strides);
				}
			}
			DebugCheckErrors();
		}

	}

}
