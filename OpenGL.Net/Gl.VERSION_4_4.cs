
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
		/// <remarks>
		/// glBufferStorage and glNamedBufferStorage create a new immutable data store. For glBufferStorage, the buffer object 
		/// currently bound to target will be initialized. For glNamedBufferStorage, buffer is the name of the buffer object that 
		/// will be configured. The size of the data store is specified by size. If an initial data is available, its address may be 
		/// supplied in data. Otherwise, to create an uninitialized data store, data should be NULL.
		/// The flags parameters specifies the intended usage of the buffer's data store. It must be a bitwise combination of a 
		/// subset of the following flags: GL_DYNAMIC_STORAGE_BITThe contents of the data store may be updated after creation 
		/// through calls to glBufferSubData. If this bit is not set, the buffer content may not be directly updated by the client. 
		/// The data argument may be used to specify the initial content of the buffer's data store regardless of the presence of 
		/// the GL_DYNAMIC_STORAGE_BIT. Regardless of the presence of this bit, buffers may always be updated with server-side calls 
		/// such as glCopyBufferSubData and glClearBufferSubData.GL_MAP_READ_BITThe data store may be mapped by the client for read 
		/// access and a pointer in the client's address space obtained that may be read from.GL_MAP_WRITE_BITThe data store may be 
		/// mapped by the client for write access and a pointer in the client's address space obtained that may be written 
		/// through.GL_MAP_PERSISTENT_BITThe client may request that the server read from or write to the buffer while it is mapped. 
		/// The client's pointer to the data store remains valid so long as the data store is mapped, even during execution of 
		/// drawing or dispatch commands.GL_MAP_COHERENT_BITShared access to buffers that are simultaneously mapped for client 
		/// access and are used by the server will be coherent, so long as that mapping is performed using glMapBufferRange. That 
		/// is, data written to the store by either the client or server will be immediately visible to the other with no further 
		/// action taken by the application. In particular,If GL_MAP_COHERENT_BIT is not set and the client performs a write 
		/// followed by a call to the glMemoryBarrier command with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set, then in subsequent 
		/// commands the server will see the writes.If GL_MAP_COHERENT_BIT is set and the client performs a write, then in 
		/// subsequent commands the server will see the writes.If GL_MAP_COHERENT_BIT is not set and the server performs a write, 
		/// the application must call glMemoryBarrier with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set and then call glFenceSync 
		/// with GL_SYNC_GPU_COMMANDS_COMPLETE (or glFinish). Then the CPU will see the writes after the sync is complete.If 
		/// GL_MAP_COHERENT_BIT is set and the server does a write, the app must call FenceSync with GL_SYNC_GPU_COMMANDS_COMPLETE 
		/// (or glFinish). Then the CPU will see the writes after the sync is complete.GL_CLIENT_STORAGE_BITWhen all other criteria 
		/// for the buffer storage allocation are met, this bit may be used by an implementation to determine whether to use storage 
		/// that is local to the server or to the client to serve as the backing store for the buffer.
		/// The allowed combinations of flags are subject to certain restrictions. They are as follows: If flags contains 
		/// GL_MAP_PERSISTENT_BIT, it must also contain at least one of GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.If flags contains 
		/// GL_MAP_COHERENT_BIT, it must also contain GL_MAP_PERSISTENT_BIT.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferStorage if target is not one of the accepted buffer targets.
		/// - GL_INVALID_OPERATION is generated by glNamedBufferStorage if buffer is not the name of an existing buffer object.
		/// - GL_INVALID_VALUE is generated if size is less than or equal to zero.
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the reserved buffer object name 0 is bound to target.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in flags.
		/// - GL_INVALID_VALUE is generated if flags has any bits set other than those defined above.
		/// - GL_INVALID_VALUE error is generated if flags contains GL_MAP_PERSISTENT_BIT but does not contain at least one of 
		///   GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.
		/// - GL_INVALID_VALUE is generated if flags contains GL_MAP_COHERENT_BIT, but does not also contain GL_MAP_PERSISTENT_BIT.
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		///   target is GL_TRUE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
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
		/// <remarks>
		/// glBufferStorage and glNamedBufferStorage create a new immutable data store. For glBufferStorage, the buffer object 
		/// currently bound to target will be initialized. For glNamedBufferStorage, buffer is the name of the buffer object that 
		/// will be configured. The size of the data store is specified by size. If an initial data is available, its address may be 
		/// supplied in data. Otherwise, to create an uninitialized data store, data should be NULL.
		/// The flags parameters specifies the intended usage of the buffer's data store. It must be a bitwise combination of a 
		/// subset of the following flags: GL_DYNAMIC_STORAGE_BITThe contents of the data store may be updated after creation 
		/// through calls to glBufferSubData. If this bit is not set, the buffer content may not be directly updated by the client. 
		/// The data argument may be used to specify the initial content of the buffer's data store regardless of the presence of 
		/// the GL_DYNAMIC_STORAGE_BIT. Regardless of the presence of this bit, buffers may always be updated with server-side calls 
		/// such as glCopyBufferSubData and glClearBufferSubData.GL_MAP_READ_BITThe data store may be mapped by the client for read 
		/// access and a pointer in the client's address space obtained that may be read from.GL_MAP_WRITE_BITThe data store may be 
		/// mapped by the client for write access and a pointer in the client's address space obtained that may be written 
		/// through.GL_MAP_PERSISTENT_BITThe client may request that the server read from or write to the buffer while it is mapped. 
		/// The client's pointer to the data store remains valid so long as the data store is mapped, even during execution of 
		/// drawing or dispatch commands.GL_MAP_COHERENT_BITShared access to buffers that are simultaneously mapped for client 
		/// access and are used by the server will be coherent, so long as that mapping is performed using glMapBufferRange. That 
		/// is, data written to the store by either the client or server will be immediately visible to the other with no further 
		/// action taken by the application. In particular,If GL_MAP_COHERENT_BIT is not set and the client performs a write 
		/// followed by a call to the glMemoryBarrier command with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set, then in subsequent 
		/// commands the server will see the writes.If GL_MAP_COHERENT_BIT is set and the client performs a write, then in 
		/// subsequent commands the server will see the writes.If GL_MAP_COHERENT_BIT is not set and the server performs a write, 
		/// the application must call glMemoryBarrier with the GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT set and then call glFenceSync 
		/// with GL_SYNC_GPU_COMMANDS_COMPLETE (or glFinish). Then the CPU will see the writes after the sync is complete.If 
		/// GL_MAP_COHERENT_BIT is set and the server does a write, the app must call FenceSync with GL_SYNC_GPU_COMMANDS_COMPLETE 
		/// (or glFinish). Then the CPU will see the writes after the sync is complete.GL_CLIENT_STORAGE_BITWhen all other criteria 
		/// for the buffer storage allocation are met, this bit may be used by an implementation to determine whether to use storage 
		/// that is local to the server or to the client to serve as the backing store for the buffer.
		/// The allowed combinations of flags are subject to certain restrictions. They are as follows: If flags contains 
		/// GL_MAP_PERSISTENT_BIT, it must also contain at least one of GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.If flags contains 
		/// GL_MAP_COHERENT_BIT, it must also contain GL_MAP_PERSISTENT_BIT.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferStorage if target is not one of the accepted buffer targets.
		/// - GL_INVALID_OPERATION is generated by glNamedBufferStorage if buffer is not the name of an existing buffer object.
		/// - GL_INVALID_VALUE is generated if size is less than or equal to zero.
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the reserved buffer object name 0 is bound to target.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the properties requested in flags.
		/// - GL_INVALID_VALUE is generated if flags has any bits set other than those defined above.
		/// - GL_INVALID_VALUE error is generated if flags contains GL_MAP_PERSISTENT_BIT but does not contain at least one of 
		///   GL_MAP_READ_BIT or GL_MAP_WRITE_BIT.
		/// - GL_INVALID_VALUE is generated if flags contains GL_MAP_COHERENT_BIT, but does not also contain GL_MAP_PERSISTENT_BIT.
		/// - GL_INVALID_OPERATION is generated by glBufferStorage if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer bound to 
		///   target is GL_TRUE.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData
		/// - glGetBufferParameter with argument GL_BUFFER_SIZE or GL_BUFFER_USAGE
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
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
		/// <remarks>
		/// glClearTexImage fills all an image contained in a texture with an application supplied value. texture must be the name 
		/// of an existing texture. Further, texture may not be the name of a buffer texture, nor may its internal format be 
		/// compressed.
		/// format and type specify the format and type of the source data and are interpreted as they are for glTexImage3D. 
		/// Textures with a base internal format of GL_DEPTH_COMPONENT, GL_STENCIL_INDEX, or GL_DEPTH_STENCIL require depth 
		/// component, stencil, or depth-stencil component data respectively. Textures with other base internal formats require RGBA 
		/// formats. Textures with integer internal formats require integer data.
		/// data is a pointer to an array of between one and four components of texel data that will be used as the source for the 
		/// constant fill value. The elements of data are converted by the GL into the internal format of the texture image (that 
		/// was specified when the level was defined by any of the glTexImage*, glTexStorage* or glCopyTexImage* commands), and then 
		/// used to fill the specified range of the destination texture level. If data is NULL, then the pointer is ignored and the 
		/// sub-range of the texture image is filled with zeros. If texture is a multisample texture, all the samples in a texel are 
		/// cleared to the value specified by data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if texture is zero or not the name of an existing texture object.
		/// - GL_INVALID_OPERATION is generated if texture is a buffer texture.
		/// - GL_INVALID_OPERATION is generated if texture has a compressed internal format.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_COMPONENT and format is not 
		///   GL_DEPTH_COMPONENT.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_STENCIL and format is not GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_STENCIL_INDEX and format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_RGBA and format is GL_DEPTH_COMPONENT, 
		///   GL_STENCIL_INDEX, or GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the internal format is integer and format does not specify integer data.
		/// - GL_INVALID_OPERATION is generated if the internal format is not integer and format specifies integer data.
		/// - GL_INVALID_OPERATION is generated if the image array identified by level has not previously been defined by a call to 
		///   glTexImage* or glTexStorage*.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage, glGetInternalformat
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearTexSubImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
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
		/// <remarks>
		/// glClearTexImage fills all an image contained in a texture with an application supplied value. texture must be the name 
		/// of an existing texture. Further, texture may not be the name of a buffer texture, nor may its internal format be 
		/// compressed.
		/// format and type specify the format and type of the source data and are interpreted as they are for glTexImage3D. 
		/// Textures with a base internal format of GL_DEPTH_COMPONENT, GL_STENCIL_INDEX, or GL_DEPTH_STENCIL require depth 
		/// component, stencil, or depth-stencil component data respectively. Textures with other base internal formats require RGBA 
		/// formats. Textures with integer internal formats require integer data.
		/// data is a pointer to an array of between one and four components of texel data that will be used as the source for the 
		/// constant fill value. The elements of data are converted by the GL into the internal format of the texture image (that 
		/// was specified when the level was defined by any of the glTexImage*, glTexStorage* or glCopyTexImage* commands), and then 
		/// used to fill the specified range of the destination texture level. If data is NULL, then the pointer is ignored and the 
		/// sub-range of the texture image is filled with zeros. If texture is a multisample texture, all the samples in a texel are 
		/// cleared to the value specified by data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if texture is zero or not the name of an existing texture object.
		/// - GL_INVALID_OPERATION is generated if texture is a buffer texture.
		/// - GL_INVALID_OPERATION is generated if texture has a compressed internal format.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_COMPONENT and format is not 
		///   GL_DEPTH_COMPONENT.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_STENCIL and format is not GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_STENCIL_INDEX and format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_RGBA and format is GL_DEPTH_COMPONENT, 
		///   GL_STENCIL_INDEX, or GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the internal format is integer and format does not specify integer data.
		/// - GL_INVALID_OPERATION is generated if the internal format is not integer and format specifies integer data.
		/// - GL_INVALID_OPERATION is generated if the image array identified by level has not previously been defined by a call to 
		///   glTexImage* or glTexStorage*.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage, glGetInternalformat
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearTexSubImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
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
		/// <remarks>
		/// glClearTexSubImage fills all or part of an image contained in a texture with an application supplied value. texture must 
		/// be the name of an existing texture. Further, texture may not be the name of a buffer texture, nor may its internal 
		/// format be compressed.
		/// Arguments xoffset, yoffset, and zoffset specify the lower left texel coordinates of a width-wide by height-high by 
		/// depth-deep rectangular subregion of the texel array.
		/// For one-dimensional array textures, yoffset is interpreted as the first layer to be cleared and height is the number of 
		/// layers to clear. For two-dimensional array textures, zoffset is interpreted as the first layer to be cleared and depth 
		/// is the number of layers to clear. Cube map textures are treated as an array of six slices in the z-dimension, where the 
		/// value of zoffset is interpreted as specifying the cube map face for the corresponding layer and depth is the number of 
		/// faces to clear. For cube map array textures, zoffset is the first layer-face to clear, and depth is the number of 
		/// layer-faces to clear. Each layer-face is translated into an array layer and a cube map face as described in the OpenGL 
		/// Specification.
		/// Negative values of xoffset, yoffset, and zoffset correspond to the coordinates of border texels. Taking ws, hs, ds, wb, 
		/// hb, and db to be the specified width, height, depth, and the border width, border height, and border depth of the texel 
		/// array and taking x, y, z, w, h, and d to be the xoffset, yoffset, zoffset, width, height, and depth argument values, any 
		/// of the following relationships generates a GL_INVALID_OPERATION error: 
		/// x&lt;wbx+w&gt;ws-wby&lt;-hby+h&gt;hs-hbz&lt;-dbz+d&gt;ds-db
		/// For texture types that do not have certain dimensions, this command treats those dimensions as having a size of 1. For 
		/// example, to clear a portion of a two-dimensional texture, use zoffset equal to zero and depth equal to one.
		/// format and type specify the format and type of the source data and are interpreted as they are for glTexImage3D. 
		/// Textures with a base internal format of GL_DEPTH_COMPONENT, GL_STENCIL_INDEX, or GL_DEPTH_STENCIL require depth 
		/// component, stencil, or depth-stencil component data respectively. Textures with other base internal formats require RGBA 
		/// formats. Textures with integer internal formats require integer data.
		/// data is a pointer to an array of between one and four components of texel data that will be used as the source for the 
		/// constant fill value. The elements of data are converted by the GL into the internal format of the texture image (that 
		/// was specified when the level was defined by any of the glTexImage*, glTexStorage* or glCopyTexImage* commands), and then 
		/// used to fill the specified range of the destination texture level. If data is NULL, then the pointer is ignored and the 
		/// sub-range of the texture image is filled with zeros. If texture is a multisample texture, all the samples in a texel are 
		/// cleared to the value specified by data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if texture is zero or not the name of an existing texture object.
		/// - GL_INVALID_OPERATION is generated if texture is a buffer texture.
		/// - GL_INVALID_OPERATION is generated if texture has a compressed internal format.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_COMPONENT and format is not 
		///   GL_DEPTH_COMPONENT.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_STENCIL and format is not GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_STENCIL_INDEX and format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_RGBA and format is GL_DEPTH_COMPONENT, 
		///   GL_STENCIL_INDEX, or GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the internal format is integer and format does not specify integer data.
		/// - GL_INVALID_OPERATION is generated if the internal format is not integer and format specifies integer data.
		/// - GL_INVALID_OPERATION error is generated if the xoffset, yoffset, zoffset, width, height, and depth parameters (or 
		///   combinations thereof) specify a region that falls outside the defined texture image array (including border, if any).
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage, glGetInternalformat
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearTexImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
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
		/// <remarks>
		/// glClearTexSubImage fills all or part of an image contained in a texture with an application supplied value. texture must 
		/// be the name of an existing texture. Further, texture may not be the name of a buffer texture, nor may its internal 
		/// format be compressed.
		/// Arguments xoffset, yoffset, and zoffset specify the lower left texel coordinates of a width-wide by height-high by 
		/// depth-deep rectangular subregion of the texel array.
		/// For one-dimensional array textures, yoffset is interpreted as the first layer to be cleared and height is the number of 
		/// layers to clear. For two-dimensional array textures, zoffset is interpreted as the first layer to be cleared and depth 
		/// is the number of layers to clear. Cube map textures are treated as an array of six slices in the z-dimension, where the 
		/// value of zoffset is interpreted as specifying the cube map face for the corresponding layer and depth is the number of 
		/// faces to clear. For cube map array textures, zoffset is the first layer-face to clear, and depth is the number of 
		/// layer-faces to clear. Each layer-face is translated into an array layer and a cube map face as described in the OpenGL 
		/// Specification.
		/// Negative values of xoffset, yoffset, and zoffset correspond to the coordinates of border texels. Taking ws, hs, ds, wb, 
		/// hb, and db to be the specified width, height, depth, and the border width, border height, and border depth of the texel 
		/// array and taking x, y, z, w, h, and d to be the xoffset, yoffset, zoffset, width, height, and depth argument values, any 
		/// of the following relationships generates a GL_INVALID_OPERATION error: 
		/// x&lt;wbx+w&gt;ws-wby&lt;-hby+h&gt;hs-hbz&lt;-dbz+d&gt;ds-db
		/// For texture types that do not have certain dimensions, this command treats those dimensions as having a size of 1. For 
		/// example, to clear a portion of a two-dimensional texture, use zoffset equal to zero and depth equal to one.
		/// format and type specify the format and type of the source data and are interpreted as they are for glTexImage3D. 
		/// Textures with a base internal format of GL_DEPTH_COMPONENT, GL_STENCIL_INDEX, or GL_DEPTH_STENCIL require depth 
		/// component, stencil, or depth-stencil component data respectively. Textures with other base internal formats require RGBA 
		/// formats. Textures with integer internal formats require integer data.
		/// data is a pointer to an array of between one and four components of texel data that will be used as the source for the 
		/// constant fill value. The elements of data are converted by the GL into the internal format of the texture image (that 
		/// was specified when the level was defined by any of the glTexImage*, glTexStorage* or glCopyTexImage* commands), and then 
		/// used to fill the specified range of the destination texture level. If data is NULL, then the pointer is ignored and the 
		/// sub-range of the texture image is filled with zeros. If texture is a multisample texture, all the samples in a texel are 
		/// cleared to the value specified by data.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if texture is zero or not the name of an existing texture object.
		/// - GL_INVALID_OPERATION is generated if texture is a buffer texture.
		/// - GL_INVALID_OPERATION is generated if texture has a compressed internal format.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_COMPONENT and format is not 
		///   GL_DEPTH_COMPONENT.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_DEPTH_STENCIL and format is not GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_STENCIL_INDEX and format is not GL_STENCIL_INDEX.
		/// - GL_INVALID_OPERATION is generated if the base internal format is GL_RGBA and format is GL_DEPTH_COMPONENT, 
		///   GL_STENCIL_INDEX, or GL_DEPTH_STENCIL.
		/// - GL_INVALID_OPERATION is generated if the internal format is integer and format does not specify integer data.
		/// - GL_INVALID_OPERATION is generated if the internal format is not integer and format specifies integer data.
		/// - GL_INVALID_OPERATION error is generated if the xoffset, yoffset, zoffset, width, height, and depth parameters (or 
		///   combinations thereof) specify a region that falls outside the defined texture image array (including border, if any).
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexImage, glGetInternalformat
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearTexImage"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
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
		/// <remarks>
		/// glBindBuffersBase binds a set of count buffer objects whose names are given in the array buffers to the count 
		/// consecutive binding points starting from index index of the array of targets specified by target. If buffers is NULL 
		/// then glBindBuffersBase unbinds any buffers that are currently bound to the referenced binding points. Assuming no errors 
		/// are generated, it is equivalent to the following pseudo-code, which calls glBindBufferBase:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER 
		///   or GL_SHADER_STORAGE_BUFFER.
		/// - GL_INVALID_OPERATION is generated if first + count is greater than the number of target-specific indexed binding points.
		/// - GL_INVALID_OPERATION is generated if any value in buffers is not zero or the name of an existing buffer object.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindBuffersBase(int target, UInt32 first, Int32 count, UInt32[] buffers)
		{
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
		/// <remarks>
		/// glBindBuffersRange binds a set of count ranges from buffer objects whose names are given in the array buffers to the 
		/// count consecutive binding points starting from index index of the array of targets specified by target. offsets 
		/// specifies the address of an array containing count starting offsets within the buffers, and sizes specifies the adderess 
		/// of an array of count sizes of the ranges. If buffers is NULL then offsets and sizes are ignored and glBindBuffersRange 
		/// unbinds any buffers that are currently bound to the referenced binding points. Assuming no errors are generated, it is 
		/// equivalent to the following pseudo-code, which calls glBindBufferRange:
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER 
		///   or GL_SHADER_STORAGE_BUFFER.
		/// - GL_INVALID_OPERATION is generated if first + count is greater than the number of target-specific indexed binding points.
		/// - GL_INVALID_OPERATION is generated if any value in buffers is not zero or the name of an existing buffer object.
		/// - GL_INVALID_VALUE is generated by if any value in offsets is less than zero or if any value in sizes is less than zero.
		/// - GL_INVALID_VALUE is generated if any pair of values in offsets and sizes does not respectively satisfy the constraints 
		///   described for those parameters for the specified target.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BindBuffersRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindBuffersRange(int target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, UInt32[] sizes)
		{
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
		/// <remarks>
		/// glBindTextures binds an array of existing texture objects to a specified number of consecutive texture units. count 
		/// specifies the number of texture objects whose names are stored in the array textures. That number of texture names are 
		/// read from the array and bound to the count consecutive texture units starting from first. The target, or type of texture 
		/// is deduced from the texture object and each texture is bound to the corresponding target of the texture unit. If the 
		/// name zero appears in the textures array, any existing binding to any target of the texture unit is reset and the default 
		/// texture for that target is bound in its place. Any non-zero entry in textures must be the name of an existing texture 
		/// object. If textures is NULL then it is as if an appropriately sized array containing only zeros had been specified.
		/// With the exception that the active texture selector maintains its current value, glBindTextures is equivalent to the 
		/// following pseudo code:
		/// Each entry in textures will be checked individually and if found to be invalid, the state for that texture unit will not 
		/// be changed and an error will be generated. However, the state for other texture units referenced by the command will 
		/// still be updated.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if first + count is greater than the number of texture image units supported by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if any value in textures is not zero or the name of an existing texture object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BINDING_1D, GL_TEXTURE_BINDING_2D, GL_TEXTURE_BINDING_3D, GL_TEXTURE_BINDING_1D_ARRAY, 
		///   GL_TEXTURE_BINDING_2D_ARRAY, GL_TEXTURE_BINDING_RECTANGLE, GL_TEXTURE_BINDING_BUFFER, GL_TEXTURE_BINDING_CUBE_MAP, 
		///   GL_TEXTURE_BINDING_CUBE_MAP, GL_TEXTURE_BINDING_CUBE_MAP_ARRAY, GL_TEXTURE_BINDING_2D_MULTISAMPLE, or 
		///   GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY.
		/// </para>
		/// </remarks>
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
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindTextures(UInt32 first, Int32 count, UInt32[] textures)
		{
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
		/// <remarks>
		/// glBindSamplers binds samplers from an array of existing sampler objects to a specified number of consecutive sampler 
		/// units. count specifies the number of sampler objects whose names are stored in the array samplers. That number of 
		/// sampler names is read from the array and bound to the count consecutive sampler units starting from first.
		/// If the name zero appears in the samplers array, any existing binding to the sampler unit is reset. Any non-zero entry in 
		/// samplers must be the name of an existing sampler object. When a non-zero entry in samplers is present, that sampler 
		/// object is bound to the corresponding sampler unit. If samplers is NULL then it is as if an appropriately sized array 
		/// containing only zeros had been specified.
		/// glBindSamplers is equivalent to the following pseudo code:
		/// Each entry in samplers will be checked individually and if found to be invalid, the state for that sampler unit will not 
		/// be changed and an error will be generated. However, the state for other sampler units referenced by the command will 
		/// still be updated.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if first + count is greater than the number of sampler units supported by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if any value in samplers is not zero or the name of an existing sampler object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_SAMPLER_BINDING
		/// </para>
		/// </remarks>
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
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers)
		{
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
		/// <remarks>
		/// glBindImageTextures binds images from an array of existing texture objects to a specified number of consecutive image 
		/// units. count specifies the number of texture objects whose names are stored in the array textures. That number of 
		/// texture names are read from the array and bound to the count consecutive texture units starting from first. If the name 
		/// zero appears in the textures array, any existing binding to the image unit is reset. Any non-zero entry in textures must 
		/// be the name of an existing texture object. When a non-zero entry in textures is present, the image at level zero is 
		/// bound, the binding is considered layered, with the first layer set to zero, and the image is bound for read-write 
		/// access. The image unit format parameter is taken from the internal format of the image at level zero of the texture 
		/// object. For cube map textures, the internal format of the positive X image of level zero is used. If textures is NULL 
		/// then it is as if an appropriately sized array containing only zeros had been specified.
		/// glBindImageTextures is equivalent to the following pseudo code:
		/// Each entry in textures will be checked individually and if found to be invalid, the state for that image unit will not 
		/// be changed and an error will be generated. However, the state for other texture image units referenced by the command 
		/// will still be updated.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if first + count is greater than the number of image units supported by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if any value in textures is not zero or the name of an existing texture object.
		/// - GL_INVALID_OPERATION error is generated if the internal format of the level zero texture image of any texture in 
		///   textures is not supported.
		/// - GL_INVALID_OPERATION error is generated if the width, height, or depth of the level zero texture image of any texture in 
		///   textures is zero.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_TEXTURE_BINDING_1D, GL_TEXTURE_BINDING_2D, GL_TEXTURE_BINDING_3D, GL_TEXTURE_BINDING_1D_ARRAY, 
		///   GL_TEXTURE_BINDING_2D_ARRAY, GL_TEXTURE_BINDING_RECTANGLE, GL_TEXTURE_BINDING_BUFFER, GL_TEXTURE_BINDING_CUBE_MAP, 
		///   GL_TEXTURE_BINDING_CUBE_MAP, GL_TEXTURE_BINDING_CUBE_MAP_ARRAY, GL_TEXTURE_BINDING_2D_MULTISAMPLE, or 
		///   GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY.
		/// </para>
		/// </remarks>
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
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures)
		{
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
		/// <remarks>
		/// glBindVertexBuffers and glVertexArrayVertexBuffers bind storage from an array of existing buffer objects to a specified 
		/// number of consecutive vertex buffer binding points units in a vertex array object. For glBindVertexBuffers, the vertex 
		/// array object is the currently bound vertex array object. For glVertexArrayVertexBuffers, vaobj is the name of the vertex 
		/// array object.
		/// count existing buffer objects are bound to vertex buffer binding points numbered $first$ through $first + count - 1$. If 
		/// buffers is not NULL, it specifies an array of count values, each of which must be zero or the name of an existing buffer 
		/// object. offsets and strides specify arrays of count values indicating the offset of the first element and stride between 
		/// elements in each buffer, respectively. If buffers is NULL, each affected vertex buffer binding point from $first$ 
		/// through $first + count - 1$ will be reset to have no bound buffer object. In this case, the offsets and strides 
		/// associated with the binding points are set to default values, ignoring offsets and strides.
		/// glBindVertexBuffers is equivalent (assuming no errors are generated) to: for (i = 0; i &lt; count; i++) { if (buffers == 
		/// NULL) { glBindVertexBuffer(first + i, 0, 0, 16); } else { glBindVertexBuffer(first + i, buffers[i], offsets[i], 
		/// strides[i]); } } except that buffers will not be created if they do not exist.
		/// glVertexArrayVertexBuffers is equivalent to the pseudocode above, but replacing glBindVertexBuffers(args) with 
		/// glVertexArrayVertexBuffers(vaobj, args).
		/// The values specified in buffers, offsets, and strides will be checked separately for each vertex buffer binding point. 
		/// When a value for a specific vertex buffer binding point is invalid, the state for that binding point will be unchanged 
		/// and an error will be generated. However, state for other vertex buffer binding points will still be changed if their 
		/// corresponding values are valid.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glBindVertexBuffers if no vertex array object is bound.
		/// - GL_INVALID_OPERATION is generated by glVertexArrayVertexBuffers if vaobj is not the name of the vertex array object.
		/// - GL_INVALID_OPERATION is generated if $first + count$ is greater than the value of GL_MAX_VERTEX_ATTRIB_BINDINGS.
		/// - GL_INVALID_OPERATION is generated if any value in buffers is not zero or the name of an existing buffer object.
		/// - GL_INVALID_VALUE is generated if any value in offsets or strides is negative, or if a value is stride is greater than 
		///   the value of GL_MAX_VERTEX_ATTRIB_STRIDE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_multi_bind")]
		public static void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides)
		{
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
