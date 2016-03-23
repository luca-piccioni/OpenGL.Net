
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
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public const int MAX_VERTEX_ATTRIB_STRIDE = 0x82E5;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED symbol.
		/// </summary>
		[AliasOf("GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED_OES")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_BINDING_EXT")]
		[AliasOf("GL_TEXTURE_BUFFER_BINDING_OES")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		public const int TEXTURE_BUFFER_BINDING = 0x8C2A;

		/// <summary>
		/// Value of GL_MAP_PERSISTENT_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_PERSISTENT_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_PERSISTENT_BIT = 0x0040;

		/// <summary>
		/// Value of GL_MAP_COHERENT_BIT symbol.
		/// </summary>
		[AliasOf("GL_MAP_COHERENT_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const int MAP_COHERENT_BIT = 0x0080;

		/// <summary>
		/// Value of GL_DYNAMIC_STORAGE_BIT symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_STORAGE_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const int DYNAMIC_STORAGE_BIT = 0x0100;

		/// <summary>
		/// Value of GL_CLIENT_STORAGE_BIT symbol.
		/// </summary>
		[AliasOf("GL_CLIENT_STORAGE_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const int CLIENT_STORAGE_BIT = 0x0200;

		/// <summary>
		/// Value of GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[AliasOf("GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000;

		/// <summary>
		/// Gl.GetBufferParameter: params returns a boolean flag indicating whether the buffer object is immutable. The initial 
		/// value is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_BUFFER_IMMUTABLE_STORAGE_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		public const int BUFFER_IMMUTABLE_STORAGE = 0x821F;

		/// <summary>
		/// Gl.GetBufferParameter: params returns a bitfield indicating the storage flags for the buffer object. If the buffer 
		/// object is immutable, the value returned will be that specified when the data store was established with glBufferStorage. 
		/// If the data store was established with glBufferData, the value will be Gl.MAP_READ_BIT | Gl.MAP_WRITE_BIT | 
		/// Gl.DYNAMIC_STORAGE_BIT | Gl.MAP_WRITE_BIT. The initial value is zero.
		/// </summary>
		[AliasOf("GL_BUFFER_STORAGE_FLAGS_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		public const int BUFFER_STORAGE_FLAGS = 0x8220;

		/// <summary>
		/// Value of GL_CLEAR_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		public const int CLEAR_TEXTURE = 0x9365;

		/// <summary>
		/// Value of GL_LOCATION_COMPONENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		public const int LOCATION_COMPONENT = 0x934A;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		public const int TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		public const int TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C;

		/// <summary>
		/// Value of GL_QUERY_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BUFFER_AMD")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_query_buffer_object")]
		public const int QUERY_BUFFER = 0x9192;

		/// <summary>
		/// Value of GL_QUERY_BUFFER_BARRIER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[Log(BitmaskName = "GL")]
		public const uint QUERY_BUFFER_BARRIER_BIT = 0x00008000;

		/// <summary>
		/// Value of GL_QUERY_BUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BUFFER_BINDING_AMD")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_query_buffer_object")]
		public const int QUERY_BUFFER_BINDING = 0x9193;

		/// <summary>
		/// Gl.GetQueryObject: if the result of the query is available (that is, a query of Gl.QUERY_RESULT_AVAILABLE would return 
		/// non-zero), then params returns the value of the query object's passed samples counter, otherwise, the data referred to 
		/// by params is not modified. The initial value is 0.
		/// </summary>
		[AliasOf("GL_QUERY_RESULT_NO_WAIT_AMD")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_query_buffer_object")]
		public const int QUERY_RESULT_NO_WAIT = 0x9194;

		/// <summary>
		/// Value of GL_MIRROR_CLAMP_TO_EDGE symbol.
		/// </summary>
		[AliasOf("GL_MIRROR_CLAMP_TO_EDGE_ATI")]
		[AliasOf("GL_MIRROR_CLAMP_TO_EDGE_EXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_texture_mirror_clamp_to_edge", Api = "gl|glcore")]
		[RequiredByFeature("GL_ATI_texture_mirror_once")]
		[RequiredByFeature("GL_EXT_texture_mirror_clamp")]
		public const int MIRROR_CLAMP_TO_EDGE = 0x8743;

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferStorage, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and 
		/// Gl.CLIENT_STORAGE_BIT.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferStorage if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferStorage if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in <paramref 
		/// name="flags"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> has any bits set other than those defined above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="flags"/> contains Gl.MAP_PERSISTENT_BIT but does not contain at 
		/// least one of Gl.MAP_READ_BIT or Gl.MAP_WRITE_BIT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains Gl.MAP_COHERENT_BIT, but does not also contain 
		/// Gl.MAP_PERSISTENT_BIT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		/// <paramref name="target"/> is Gl.TRUE.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferStorageEXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		public static void BufferStorage(Int32 target, UInt32 size, IntPtr data, UInt32 flags)
		{
			Debug.Assert(Delegates.pglBufferStorage != null, "pglBufferStorage not implemented");
			Delegates.pglBufferStorage(target, size, data, flags);
			LogFunction("glBufferStorage({0}, {1}, 0x{2}, {3})", LogEnumName(target), size, data.ToString("X8"), flags);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// creates and initializes a buffer object's immutable data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferStorage, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="flags">
		/// Specifies the intended usage of the buffer's data store. Must be a bitwise combination of the following flags. 
		/// Gl.DYNAMIC_STORAGE_BIT, Gl.MAP_READ_BITGl.MAP_WRITE_BIT, Gl.MAP_PERSISTENT_BIT, Gl.MAP_COHERENT_BIT, and 
		/// Gl.CLIENT_STORAGE_BIT.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferStorage if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferStorage if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in <paramref 
		/// name="flags"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> has any bits set other than those defined above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE error is generated if <paramref name="flags"/> contains Gl.MAP_PERSISTENT_BIT but does not contain at 
		/// least one of Gl.MAP_READ_BIT or Gl.MAP_WRITE_BIT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="flags"/> contains Gl.MAP_COHERENT_BIT, but does not also contain 
		/// Gl.MAP_PERSISTENT_BIT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferStorage if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		/// <paramref name="target"/> is Gl.TRUE.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferStorageEXT")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		public static void BufferStorage(Int32 target, UInt32 size, Object data, UInt32 flags)
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
		/// The level of <paramref name="texture"/> containing the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is zero or not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has a compressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_COMPONENT and <paramref name="format"/> is not 
		/// Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_STENCIL and <paramref name="format"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.STENCIL_INDEX and <paramref name="format"/> is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.RGBA and <paramref name="format"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.STENCIL_INDEX, or Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is integer and <paramref name="format"/> does not specify 
		/// integer data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is not integer and <paramref name="format"/> specifies integer 
		/// data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the image array identified by <paramref name="level"/> has not previously been 
		/// defined by a call to Gl.TexImage* or Gl.TexStorage*.
		/// </exception>
		/// <seealso cref="Gl.ClearTexSubImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		public static void ClearTexImage(UInt32 texture, Int32 level, Int32 format, Int32 type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearTexImage != null, "pglClearTexImage not implemented");
			Delegates.pglClearTexImage(texture, level, format, type, data);
			LogFunction("glClearTexImage({0}, {1}, {2}, {3}, 0x{4})", texture, level, LogEnumName(format), LogEnumName(type), data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fills all a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of <paramref name="texture"/> containing the region to be cleared.
		/// </param>
		/// <param name="format">
		/// The format of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is zero or not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has a compressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_COMPONENT and <paramref name="format"/> is not 
		/// Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_STENCIL and <paramref name="format"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.STENCIL_INDEX and <paramref name="format"/> is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.RGBA and <paramref name="format"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.STENCIL_INDEX, or Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is integer and <paramref name="format"/> does not specify 
		/// integer data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is not integer and <paramref name="format"/> specifies integer 
		/// data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the image array identified by <paramref name="level"/> has not previously been 
		/// defined by a call to Gl.TexImage* or Gl.TexStorage*.
		/// </exception>
		/// <seealso cref="Gl.ClearTexSubImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		public static void ClearTexImage(UInt32 texture, Int32 level, Int32 format, Int32 type, Object data)
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
		/// The level of <paramref name="texture"/> containing the region to be cleared.
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
		/// The format of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is zero or not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has a compressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_COMPONENT and <paramref name="format"/> is not 
		/// Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_STENCIL and <paramref name="format"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.STENCIL_INDEX and <paramref name="format"/> is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.RGBA and <paramref name="format"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.STENCIL_INDEX, or Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is integer and <paramref name="format"/> does not specify 
		/// integer data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is not integer and <paramref name="format"/> specifies integer 
		/// data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated if the <paramref name="xoffset"/>, <paramref name="yoffset"/>, <paramref 
		/// name="zoffset"/>, <paramref name="width"/>, <paramref name="height"/>, and <paramref name="depth"/> parameters (or 
		/// combinations thereof) specify a region that falls outside the defined texture image array (including border, if any).
		/// </exception>
		/// <seealso cref="Gl.ClearTexImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		public static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, IntPtr data)
		{
			Debug.Assert(Delegates.pglClearTexSubImage != null, "pglClearTexSubImage not implemented");
			Delegates.pglClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
			LogFunction("glClearTexSubImage({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, 0x{10})", texture, level, xoffset, yoffset, zoffset, width, height, depth, LogEnumName(format), LogEnumName(type), data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// fills all or part of a texture image with a constant value
		/// </summary>
		/// <param name="texture">
		/// The name of an existing texture object containing the image to be cleared.
		/// </param>
		/// <param name="level">
		/// The level of <paramref name="texture"/> containing the region to be cleared.
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
		/// The format of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="type">
		/// The type of the data whose address in memory is given by <paramref name="data"/>.
		/// </param>
		/// <param name="data">
		/// The address in memory of the data to be used to clear the specified region.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is zero or not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> is a buffer texture.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="texture"/> has a compressed internal format.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_COMPONENT and <paramref name="format"/> is not 
		/// Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.DEPTH_STENCIL and <paramref name="format"/> is not 
		/// Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.STENCIL_INDEX and <paramref name="format"/> is not 
		/// Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the base internal format is Gl.RGBA and <paramref name="format"/> is 
		/// Gl.DEPTH_COMPONENT, Gl.STENCIL_INDEX, or Gl.DEPTH_STENCIL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is integer and <paramref name="format"/> does not specify 
		/// integer data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the internal format is not integer and <paramref name="format"/> specifies integer 
		/// data.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated if the <paramref name="xoffset"/>, <paramref name="yoffset"/>, <paramref 
		/// name="zoffset"/>, <paramref name="width"/>, <paramref name="height"/>, and <paramref name="depth"/> parameters (or 
		/// combinations thereof) specify a region that falls outside the defined texture image array (including border, if any).
		/// </exception>
		/// <seealso cref="Gl.ClearTexImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		public static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 format, Int32 type, Object data)
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
		/// Specify the target of the bind operation. <paramref name="target"/> must be one of Gl.ATOMIC_COUNTER_BUFFER, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffers">
		/// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.ATOMIC_COUNTER_BUFFER, Gl.TRANSFORM_FEEDBACK_BUFFER, 
		/// Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="first"/> + <paramref name="count"/> is greater than the number of 
		/// target-specific indexed binding points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="buffers"/> is not zero or the name of an existing 
		/// buffer object.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindBuffersBase(Int32 target, UInt32 first, UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglBindBuffersBase != null, "pglBindBuffersBase not implemented");
					Delegates.pglBindBuffersBase(target, first, (Int32)buffers.Length, p_buffers);
					LogFunction("glBindBuffersBase({0}, {1}, {2}, {3})", LogEnumName(target), first, buffers.Length, LogValue(buffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind ranges of one or more buffer objects to a sequence of indexed buffer targets
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. <paramref name="target"/> must be one of Gl.ATOMIC_COUNTER_BUFFER, 
		/// Gl.TRANSFORM_FEEDBACK_BUFFER, Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffers">
		/// A pointer to an array of names of buffer objects to bind to the targets on the specified binding point, or Gl.L.
		/// </param>
		/// <param name="offsets">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="sizes">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.ATOMIC_COUNTER_BUFFER, Gl.TRANSFORM_FEEDBACK_BUFFER, 
		/// Gl.UNIFORM_BUFFER or Gl.SHADER_STORAGE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="first"/> + <paramref name="count"/> is greater than the number of 
		/// target-specific indexed binding points.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="buffers"/> is not zero or the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by if any value in <paramref name="offsets"/> is less than zero or if any value in 
		/// <paramref name="sizes"/> is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any pair of values in <paramref name="offsets"/> and <paramref name="sizes"/> does not 
		/// respectively satisfy the constraints described for those parameters for the specified target.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindBuffersRange(Int32 target, UInt32 first, UInt32[] buffers, IntPtr[] offsets, UInt32[] sizes)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (UInt32* p_sizes = sizes)
				{
					Debug.Assert(Delegates.pglBindBuffersRange != null, "pglBindBuffersRange not implemented");
					Delegates.pglBindBuffersRange(target, first, (Int32)buffers.Length, p_buffers, p_offsets, p_sizes);
					LogFunction("glBindBuffersRange({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), first, buffers.Length, LogValue(buffers), LogValue(offsets), LogValue(sizes));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind one or more named textures to a sequence of consecutive texture units
		/// </summary>
		/// <param name="first">
		/// Specifies the first texture unit to which a texture is to be bound.
		/// </param>
		/// <param name="textures">
		/// Specifies the address of an array of names of existing texture objects.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="first"/> + <paramref name="count"/> is greater than the number of 
		/// texture image units supported by the implementation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in textures is not zero or the name of an existing texture object.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindTextures(UInt32 first, params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglBindTextures != null, "pglBindTextures not implemented");
					Delegates.pglBindTextures(first, (Int32)textures.Length, p_textures);
					LogFunction("glBindTextures({0}, {1}, {2})", first, textures.Length, LogValue(textures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind one or more named sampler objects to a sequence of consecutive sampler units
		/// </summary>
		/// <param name="first">
		/// Specifies the first sampler unit to which a sampler object is to be bound.
		/// </param>
		/// <param name="samplers">
		/// Specifies the address of an array of names of existing sampler objects.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="first"/> + <paramref name="count"/> is greater than the number of 
		/// sampler units supported by the implementation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="samplers"/> is not zero or the name of an existing 
		/// sampler object.
		/// </exception>
		/// <seealso cref="Gl.GenSamplers"/>
		/// <seealso cref="Gl.BindSampler"/>
		/// <seealso cref="Gl.DeleteSamplers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.SamplerParameter"/>
		/// <seealso cref="Gl.GetSamplerParameter"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindSamplers(UInt32 first, params UInt32[] samplers)
		{
			unsafe {
				fixed (UInt32* p_samplers = samplers)
				{
					Debug.Assert(Delegates.pglBindSamplers != null, "pglBindSamplers not implemented");
					Delegates.pglBindSamplers(first, (Int32)samplers.Length, p_samplers);
					LogFunction("glBindSamplers({0}, {1}, {2})", first, samplers.Length, LogValue(samplers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind one or more named texture images to a sequence of consecutive image units
		/// </summary>
		/// <param name="first">
		/// Specifies the first image unit to which a texture is to be bound.
		/// </param>
		/// <param name="textures">
		/// Specifies the address of an array of names of existing texture objects.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="first"/> + <paramref name="count"/> is greater than the number of 
		/// image units supported by the implementation.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in <paramref name="textures"/> is not zero or the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated if the internal format of the level zero texture image of any texture in 
		/// textures is not supported.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated if the width, height, or depth of the level zero texture image of any texture in 
		/// textures is zero.
		/// </exception>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.BindTextures"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage2DMultisample"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexStorage3DMultisample"/>
		/// <seealso cref="Gl.TexBuffer"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindImageTextures(UInt32 first, params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglBindImageTextures != null, "pglBindImageTextures not implemented");
					Delegates.pglBindImageTextures(first, (Int32)textures.Length, p_textures);
					LogFunction("glBindImageTextures({0}, {1}, {2})", first, textures.Length, LogValue(textures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// attach multiple buffer objects to a vertex array object
		/// </summary>
		/// <param name="first">
		/// Specifies the first vertex buffer binding point to which a buffer object is to be bound.
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BindVertexBuffers if no vertex array object is bound.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexArrayVertexBuffers if <paramref name="vaobj"/> is not the name of the 
		/// vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if $first + count$ is greater than the value of Gl.MAX_VERTEX_ATTRIB_BINDINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any value in Gl.fers is not zero or the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any value in <paramref name="offsets"/> or <paramref name="strides"/> is negative, or 
		/// if a value is <paramref name="stride"/> is greater than the value of Gl.MAX_VERTEX_ATTRIB_STRIDE.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind", Api = "gl|glcore")]
		public static void BindVertexBuffers(UInt32 first, UInt32[] buffers, IntPtr[] offsets, params Int32[] strides)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				fixed (IntPtr* p_offsets = offsets)
				fixed (Int32* p_strides = strides)
				{
					Debug.Assert(Delegates.pglBindVertexBuffers != null, "pglBindVertexBuffers not implemented");
					Delegates.pglBindVertexBuffers(first, (Int32)buffers.Length, p_buffers, p_offsets, p_strides);
					LogFunction("glBindVertexBuffers({0}, {1}, {2}, {3}, {4})", first, buffers.Length, LogValue(buffers), LogValue(offsets), LogValue(strides));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
