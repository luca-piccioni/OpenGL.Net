
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
		/// Gl.GetBufferParameter: params returns the size of the buffer object, measured in bytes. The initial value is 0.
		/// </summary>
		[AliasOf("GL_BUFFER_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_SIZE = 0x8764;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the buffer object's usage pattern. The initial value is Gl.STATIC_DRAW.
		/// </summary>
		[AliasOf("GL_BUFFER_USAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int BUFFER_USAGE = 0x8765;

		/// <summary>
		/// Gl.GetQuery: params returns the number of bits in the query counter used to accumulate passing samples. If the number of 
		/// bits returned is 0, the implementation does not support a query counter, and the results obtained from Gl.GetQueryObject 
		/// are useless.
		/// </summary>
		[AliasOf("GL_QUERY_COUNTER_BITS_ARB")]
		[AliasOf("GL_QUERY_COUNTER_BITS_EXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		public const int QUERY_COUNTER_BITS = 0x8864;

		/// <summary>
		/// Gl.GetQuery: params returns the name of the currently active occlusion query object. If no occlusion query is active, 0 
		/// is returned. The initial value is 0.
		/// </summary>
		[AliasOf("GL_CURRENT_QUERY_ARB")]
		[AliasOf("GL_CURRENT_QUERY_EXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public const int CURRENT_QUERY = 0x8865;

		/// <summary>
		/// Gl.GetQueryObject: params returns the value of the query object's passed samples counter. The initial value is 0.
		/// </summary>
		[AliasOf("GL_QUERY_RESULT_ARB")]
		[AliasOf("GL_QUERY_RESULT_EXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public const int QUERY_RESULT = 0x8866;

		/// <summary>
		/// Gl.GetQueryObject: params returns whether the passed samples counter is immediately available. If a delay would occur 
		/// waiting for the query result, Gl.FALSE is returned. Otherwise, Gl.TRUE is returned, which also indicates that the 
		/// results of all previous queries are available as well.
		/// </summary>
		[AliasOf("GL_QUERY_RESULT_AVAILABLE_ARB")]
		[AliasOf("GL_QUERY_RESULT_AVAILABLE_EXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public const int QUERY_RESULT_AVAILABLE = 0x8867;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_ARRAY_BUFFER_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ARRAY_BUFFER = 0x8892;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BUFFER_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ELEMENT_ARRAY_BUFFER = 0x8893;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target Gl.ARRAY_BUFFER. If no 
		/// buffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ARRAY_BUFFER_BINDING = 0x8894;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target 
		/// Gl.ELEMENT_ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See 
		/// Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value, the name of the buffer object currently bound to the binding point 
		/// corresponding to generic vertex attribute array index. If no buffer object is bound, 0 is returned. The initial value is 
		/// 0.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

		/// <summary>
		/// Value of GL_READ_ONLY symbol.
		/// </summary>
		[AliasOf("GL_READ_ONLY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int READ_ONLY = 0x88B8;

		/// <summary>
		/// Value of GL_WRITE_ONLY symbol.
		/// </summary>
		[AliasOf("GL_WRITE_ONLY_ARB")]
		[AliasOf("GL_WRITE_ONLY_OES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public const int WRITE_ONLY = 0x88B9;

		/// <summary>
		/// Value of GL_READ_WRITE symbol.
		/// </summary>
		[AliasOf("GL_READ_WRITE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int READ_WRITE = 0x88BA;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object (the value of the access 
		/// parameter enum passed to glMapBuffer). If the buffer was mapped with glMapBufferRange, the access policy is determined 
		/// by translating the bits in that access parameter to one of the supported enums for glMapBuffer as described in the 
		/// OpenGL Specification.
		/// </summary>
		[AliasOf("GL_BUFFER_ACCESS_ARB")]
		[AliasOf("GL_BUFFER_ACCESS_OES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public const int BUFFER_ACCESS = 0x88BB;

		/// <summary>
		/// Gl.GetBufferParameter: params returns a flag indicating whether the buffer object is currently mapped. The initial value 
		/// is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_BUFFER_MAPPED_ARB")]
		[AliasOf("GL_BUFFER_MAPPED_OES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public const int BUFFER_MAPPED = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER symbol.
		/// </summary>
		[AliasOf("GL_BUFFER_MAP_POINTER_ARB")]
		[AliasOf("GL_BUFFER_MAP_POINTER_OES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public const int BUFFER_MAP_POINTER = 0x88BD;

		/// <summary>
		/// Value of GL_STREAM_DRAW symbol.
		/// </summary>
		[AliasOf("GL_STREAM_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_DRAW = 0x88E0;

		/// <summary>
		/// Value of GL_STREAM_READ symbol.
		/// </summary>
		[AliasOf("GL_STREAM_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_READ = 0x88E1;

		/// <summary>
		/// Value of GL_STREAM_COPY symbol.
		/// </summary>
		[AliasOf("GL_STREAM_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STREAM_COPY = 0x88E2;

		/// <summary>
		/// Value of GL_STATIC_DRAW symbol.
		/// </summary>
		[AliasOf("GL_STATIC_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_DRAW = 0x88E4;

		/// <summary>
		/// Value of GL_STATIC_READ symbol.
		/// </summary>
		[AliasOf("GL_STATIC_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_READ = 0x88E5;

		/// <summary>
		/// Value of GL_STATIC_COPY symbol.
		/// </summary>
		[AliasOf("GL_STATIC_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int STATIC_COPY = 0x88E6;

		/// <summary>
		/// Value of GL_DYNAMIC_DRAW symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_DRAW = 0x88E8;

		/// <summary>
		/// Value of GL_DYNAMIC_READ symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_READ = 0x88E9;

		/// <summary>
		/// Value of GL_DYNAMIC_COPY symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public const int DYNAMIC_COPY = 0x88EA;

		/// <summary>
		/// Value of GL_SAMPLES_PASSED symbol.
		/// </summary>
		[AliasOf("GL_SAMPLES_PASSED_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int SAMPLES_PASSED = 0x8914;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the vertex array. This buffer 
		/// object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.VertexPointer. If 
		/// no buffer object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_BUFFER_BINDING = 0x8896;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the normal array. This buffer 
		/// object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.NormalPointer. If 
		/// no buffer object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_NORMAL_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_BUFFER_BINDING = 0x8897;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the color array. This buffer object 
		/// would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.ColorPointer. If no buffer 
		/// object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_COLOR_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_BUFFER_BINDING = 0x8898;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the color index array. This buffer 
		/// object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.IndexPointer. If no 
		/// buffer object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_INDEX_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_BUFFER_BINDING = 0x8899;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the texture coordinate array. This 
		/// buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to 
		/// Gl.TexCoordPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See 
		/// Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the edge flag array. This buffer 
		/// object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.EdgeFlagPointer. If 
		/// no buffer object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the secondary color array. This 
		/// buffer object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to 
		/// Gl.SecondaryColorPointer. If no buffer object was bound to this target, 0 is returned. The initial value is 0. See 
		/// Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
		[AliasOf("GL_WEIGHT_ARRAY_BUFFER_BINDING_OES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;

		/// <summary>
		/// generate query object names
		/// </summary>
		/// <param name="ids">
		/// Specifies an array in which the generated query object names are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		[AliasOf("glGenQueriesARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GenQueries(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueries != null, "pglGenQueries not implemented");
					Delegates.pglGenQueries((Int32)ids.Length, p_ids);
					LogFunction("glGenQueries({0}, {1})", ids.Length, LogValue(ids));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate query object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		[AliasOf("glGenQueriesARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static UInt32 GenQuery()
		{
			UInt32[] retValue = new UInt32[1];
			GenQueries(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// delete named query objects
		/// </summary>
		/// <param name="ids">
		/// Specifies an array of query objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		[AliasOf("glDeleteQueriesARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void DeleteQueries(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueries != null, "pglDeleteQueries not implemented");
					Delegates.pglDeleteQueries((Int32)ids.Length, p_ids);
					LogFunction("glDeleteQueries({0}, {1})", ids.Length, LogValue(ids));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// determine if a name corresponds to a query object
		/// </summary>
		/// <param name="id">
		/// Specifies a value that may be the name of a query object.
		/// </param>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		[AliasOf("glIsQueryARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static bool IsQuery(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQuery != null, "pglIsQuery not implemented");
			retValue = Delegates.pglIsQuery(id);
			LogFunction("glIsQuery({0}) = {1}", id, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between Gl.BeginQuery and the subsequent glEndQuery. The symbolic 
		/// constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// Gl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginQuery is executed while a query object of the same <paramref 
		/// name="target"/> is already active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndQuery is executed when a query object of the same <paramref name="target"/> is 
		/// not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of an already active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> refers to an existing query object whose type does not does 
		/// not match <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		[AliasOf("glBeginQueryARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void BeginQuery(Int32 target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQuery != null, "pglBeginQuery not implemented");
			Delegates.pglBeginQuery(target, id);
			LogFunction("glBeginQuery({0}, {1})", LogEnumName(target), id);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between Gl.BeginQuery and the subsequent glEndQuery. The symbolic 
		/// constant must be one of Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// Gl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or Gl.TIME_ELAPSED.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.BeginQuery is executed while a query object of the same <paramref 
		/// name="target"/> is already active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if glEndQuery is executed when a query object of the same <paramref name="target"/> is 
		/// not active.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of an already active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> refers to an existing query object whose type does not does 
		/// not match <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		[AliasOf("glEndQueryARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void EndQuery(Int32 target)
		{
			Debug.Assert(Delegates.pglEndQuery != null, "pglEndQuery not implemented");
			Delegates.pglEndQuery(target);
			LogFunction("glEndQuery({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, 
		/// Gl.ANY_SAMPLES_PASSED_CONSERVATIVEGl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, Gl.TIME_ELAPSED, or 
		/// Gl.TIMESTAMP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are Gl.CURRENT_QUERY or 
		/// Gl.QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.IsQuery"/>
		[AliasOf("glGetQueryivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQuery(Int32 target, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryiv != null, "pglGetQueryiv not implemented");
					Delegates.pglGetQueryiv(target, pname, p_params);
					LogFunction("glGetQueryiv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be Gl.SAMPLES_PASSED, Gl.ANY_SAMPLES_PASSED, 
		/// Gl.ANY_SAMPLES_PASSED_CONSERVATIVEGl.PRIMITIVES_GENERATED, Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, Gl.TIME_ELAPSED, or 
		/// Gl.TIMESTAMP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are Gl.CURRENT_QUERY or 
		/// Gl.QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.IsQuery"/>
		[AliasOf("glGetQueryivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQuery(Int32 target, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryiv != null, "pglGetQueryiv not implemented");
					Delegates.pglGetQueryiv(target, pname, p_params);
					LogFunction("glGetQueryiv({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectivARB")]
		[AliasOf("glGetQueryObjectivEXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		public static void GetQueryObject(UInt32 id, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectiv != null, "pglGetQueryObjectiv not implemented");
					Delegates.pglGetQueryObjectiv(id, pname, p_params);
					LogFunction("glGetQueryObjectiv({0}, {1}, {2})", id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectivARB")]
		[AliasOf("glGetQueryObjectivEXT")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		public static void GetQueryObject(UInt32 id, Int32 pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectiv != null, "pglGetQueryObjectiv not implemented");
					Delegates.pglGetQueryObjectiv(id, pname, p_params);
					LogFunction("glGetQueryObjectiv({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectuivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, [Out] UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuiv != null, "pglGetQueryObjectuiv not implemented");
					Delegates.pglGetQueryObjectuiv(id, pname, p_params);
					LogFunction("glGetQueryObjectuiv({0}, {1}, {2})", id, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are Gl.QUERY_RESULT or 
		/// Gl.QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the Gl.QUERY_RESULT_BUFFER target, then <paramref name="params"/> is treated as an offset to a 
		/// location within that buffer's data store to receive the result of the query. If no buffer is bound to 
		/// Gl.QUERY_RESULT_BUFFER, then <paramref name="params"/> is treated as an address in client memory of a variable to 
		/// receive the resulting data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is not the name of a query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="id"/> is the name of a currently active query object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a buffer is currently bound to the Gl.QUERY_RESULT_BUFFER target and the command 
		/// would cause data to be written beyond the bounds of that buffer's data store.
		/// </exception>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		[AliasOf("glGetQueryObjectuivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQueryObject(UInt32 id, Int32 pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuiv != null, "pglGetQueryObjectuiv not implemented");
					Delegates.pglGetQueryObjectuiv(id, pname, p_params);
					LogFunction("glGetQueryObjectuiv({0}, {1}, {2})", id, LogEnumName(pname), @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind a named buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the 
		/// following table:
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of a buffer object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not one of the allowable values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="buffer"/> is not a name previously returned from a call to 
		/// glGenBuffers.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsBuffer"/>
		[AliasOf("glBindBufferARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBuffer != null, "pglBindBuffer not implemented");
			Delegates.pglBindBuffer((Int32)target, buffer);
			LogFunction("glBindBuffer({0}, {1})", target, buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete named buffer objects
		/// </summary>
		/// <param name="buffers">
		/// Specifies an array of buffer objects to be deleted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glDeleteBuffersARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void DeleteBuffers(params UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglDeleteBuffers != null, "pglDeleteBuffers not implemented");
					Delegates.pglDeleteBuffers((Int32)buffers.Length, p_buffers);
					LogFunction("glDeleteBuffers({0}, {1})", buffers.Length, LogValue(buffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate buffer object names
		/// </summary>
		/// <param name="buffers">
		/// Specifies an array in which the generated buffer object names are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glGenBuffersARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GenBuffers(UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglGenBuffers != null, "pglGenBuffers not implemented");
					Delegates.pglGenBuffers((Int32)buffers.Length, p_buffers);
					LogFunction("glGenBuffers({0}, {1})", buffers.Length, LogValue(buffers));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate buffer object names
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glGenBuffersARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static UInt32 GenBuffer()
		{
			UInt32[] retValue = new UInt32[1];
			GenBuffers(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies a value that may be the name of a buffer object.
		/// </param>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.Get"/>
		[AliasOf("glIsBufferARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static bool IsBuffer(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsBuffer != null, "pglIsBuffer not implemented");
			retValue = Delegates.pglIsBuffer(buffer);
			LogFunction("glIsBuffer({0}) = {1}", buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferData(Int32 target, UInt32 size, IntPtr data, Int32 usage)
		{
			Debug.Assert(Delegates.pglBufferData != null, "pglBufferData not implemented");
			Delegates.pglBufferData(target, size, data, usage);
			LogFunction("glBufferData({0}, {1}, 0x{2}, {3})", LogEnumName(target), size, data.ToString("X8"), LogEnumName(usage));
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferData(BufferTargetARB target, UInt32 size, IntPtr data, BufferUsageARB usage)
		{
			Debug.Assert(Delegates.pglBufferData != null, "pglBufferData not implemented");
			Delegates.pglBufferData((Int32)target, size, data, (Int32)usage);
			LogFunction("glBufferData({0}, {1}, 0x{2}, {3})", target, size, data.ToString("X8"), usage);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferData(Int32 target, UInt32 size, Object data, Int32 usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferData(target, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or Gl.L if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be Gl.STREAM_DRAW, Gl.STREAM_READ, 
		/// Gl.STREAM_COPY, Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="usage"/> is not Gl.STREAM_DRAW, Gl.STREAM_READ, Gl.STREAM_COPY, 
		/// Gl.STATIC_DRAW, Gl.STATIC_READ, Gl.STATIC_COPY, Gl.DYNAMIC_DRAW, Gl.DYNAMIC_READ, or Gl.DYNAMIC_COPY.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferData if the reserved buffer object name 0 is bound to <paramref 
		/// name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferData if buffer is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified <paramref name="size"/>.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferData(BufferTargetARB target, UInt32 size, Object data, BufferUsageARB usage)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferData(target, size, pin_data.AddrOfPinnedObject(), usage);
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferSubData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being replaced.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the new data that will be copied into the data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferSubData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferSubData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the specified buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE 
		/// and the value of Gl.BUFFER_STORAGE_FLAGS for the buffer object does not have the Gl.DYNAMIC_STORAGE_BIT bit set.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferSubDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglBufferSubData != null, "pglBufferSubData not implemented");
			Delegates.pglBufferSubData((Int32)target, offset, size, data);
			LogFunction("glBufferSubData({0}, 0x{1}, {2}, 0x{3})", target, offset.ToString("X8"), size, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.BufferSubData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store where data replacement will begin, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being replaced.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the new data that will be copied into the data store.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.BufferSubData if <paramref name="target"/> is not one of the accepted buffer targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.BufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedBufferSubData if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the specified buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		/// glMapBufferRange or glMapBuffer, unless it was mapped with the Gl.MAP_PERSISTENT_BIT bit set in the 
		/// Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the value of the Gl.BUFFER_IMMUTABLE_STORAGE flag of the buffer object is Gl.TRUE 
		/// and the value of Gl.BUFFER_STORAGE_FLAGS for the buffer object does not have the Gl.DYNAMIC_STORAGE_BIT bit set.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glBufferSubDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void BufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				BufferSubData(target, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferSubData, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being returned.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the location where buffer object data is returned.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		/// mapped with the Gl.MAP_PERSISTENT_BIT bit set in the Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glGetBufferSubDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetBufferSubData != null, "pglGetBufferSubData not implemented");
			Delegates.pglGetBufferSubData((Int32)target, offset, size, data);
			LogFunction("glGetBufferSubData({0}, 0x{1}, {2}, 0x{3})", target, offset.ToString("X8"), size, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferSubData, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the offset into the buffer object's data store from which data will be returned, measured in bytes.
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the data store region being returned.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the location where buffer object data is returned.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferSubData if <paramref name="target"/> is not one of the generic buffer 
		/// binding targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferSubData if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferSubData if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="offset"/> or <paramref name="size"/> is negative, or if $offset + size$ 
		/// is greater than the value of Gl.BUFFER_SIZE for the buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		/// mapped with the Gl.MAP_PERSISTENT_BIT bit set in the Gl.MapBufferRange<paramref name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glGetBufferSubDataARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				GetBufferSubData(target, offset, size, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// map all of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.MapBuffer, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="access">
		/// Specifies the access policy for Gl.MapBuffer and Gl.MapNamedBuffer, indicating whether it will be possible to read from, 
		/// write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// Gl.READ_ONLY, Gl.WRITE_ONLY, or Gl.READ_WRITE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.MapBuffer if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapBuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.MapNamedBuffer if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="access"/> is not Gl.READ_ONLY, Gl.WRITE_ONLY, or Gl.READ_WRITE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.OUT_OF_MEMORY is generated if the GL is unable to map the buffer object's data store. This may occur for a variety of 
		/// system-specific reasons, such as the absence of sufficient remaining virtual memory.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is in a mapped state.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glMapBufferARB")]
		[AliasOf("glMapBufferOES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public static IntPtr MapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBuffer != null, "pglMapBuffer not implemented");
			retValue = Delegates.pglMapBuffer((Int32)target, (Int32)access);
			LogFunction("glMapBuffer({0}, {1}) = {2}", target, access, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// release the mapping of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.UnmapBuffer, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.UnmapBuffer if <paramref name="target"/> is not one of the buffer binding targets 
		/// listed above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.UnmapBuffer if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.UnmapNamedBuffer if <paramref name="buffer"/> is not the name of an existing 
		/// buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the buffer object is not in a mapped state.
		/// </exception>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		[AliasOf("glUnmapBufferARB")]
		[AliasOf("glUnmapBufferOES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public static bool UnmapBuffer(BufferTargetARB target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapBuffer != null, "pglUnmapBuffer not implemented");
			retValue = Delegates.pglUnmapBuffer((Int32)target);
			LogFunction("glUnmapBuffer({0}) = {1}", target, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferParameteriv and Gl.GetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="value">
		/// Specifies the name of the buffer object parameter to query.
		/// </param>
		/// <param name="data">
		/// Returns the requested parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glGetBufferParameterivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferParameter(BufferTargetARB target, Int32 value, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_params = data)
				{
					Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
					Delegates.pglGetBufferParameteriv((Int32)target, value, p_params);
					LogFunction("glGetBufferParameteriv({0}, {1}, {2})", target, LogEnumName(value), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferParameteriv and Gl.GetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="value">
		/// Specifies the name of the buffer object parameter to query.
		/// </param>
		/// <param name="data">
		/// Returns the requested parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetBufferParameter* if <paramref name="target"/> is not one of the accepted buffer 
		/// targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferParameter* if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferParameter* if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the buffer object parameter names described 
		/// above.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		[AliasOf("glGetBufferParameterivARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		public static void GetBufferParameter(BufferTargetARB target, Int32 value, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_params = &data)
				{
					Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
					Delegates.pglGetBufferParameteriv((Int32)target, value, p_params);
					LogFunction("glGetBufferParameteriv({0}, {1}, {2})", target, LogEnumName(value), data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferPointerv, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be Gl.BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if by Gl.GetBufferPointerv if <paramref name="target"/> is not one of the accepted buffer 
		/// targets, or if <paramref name="pname"/> is not Gl.BUFFER_MAP_POINTER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferPointerv if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferPointerv if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.MapBuffer"/>
		[AliasOf("glGetBufferPointervARB")]
		[AliasOf("glGetBufferPointervOES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public static void GetBufferPointer(BufferTargetARB target, Int32 pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetBufferPointerv != null, "pglGetBufferPointerv not implemented");
					Delegates.pglGetBufferPointerv((Int32)target, pname, p_params);
					LogFunction("glGetBufferPointerv({0}, {1}, 0x{2})", target, LogEnumName(pname), @params.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for Gl.GetBufferPointerv, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be Gl.BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if by Gl.GetBufferPointerv if <paramref name="target"/> is not one of the accepted buffer 
		/// targets, or if <paramref name="pname"/> is not Gl.BUFFER_MAP_POINTER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetBufferPointerv if zero is bound to <paramref name="target"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetNamedBufferPointerv if <paramref name="buffer"/> is not the name of an 
		/// existing buffer object.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.MapBuffer"/>
		[AliasOf("glGetBufferPointervARB")]
		[AliasOf("glGetBufferPointervOES")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		public static void GetBufferPointer(BufferTargetARB target, Int32 pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				GetBufferPointer(target, pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

	}

}
