
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
		public const int BUFFER_SIZE = 0x8764;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the buffer object's usage pattern. The initial value is Gl.STATIC_DRAW.
		/// </summary>
		[AliasOf("GL_BUFFER_USAGE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_USAGE = 0x8765;

		/// <summary>
		/// Gl.GetQuery: params returns the number of bits in the query counter used to accumulate passing samples. If the number of 
		/// bits returned is 0, the implementation does not support a query counter, and the results obtained from Gl.GetQueryObject 
		/// are useless.
		/// </summary>
		[AliasOf("GL_QUERY_COUNTER_BITS_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_COUNTER_BITS = 0x8864;

		/// <summary>
		/// Gl.GetQuery: params returns the name of the currently active occlusion query object. If no occlusion query is active, 0 
		/// is returned. The initial value is 0.
		/// </summary>
		[AliasOf("GL_CURRENT_QUERY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int CURRENT_QUERY = 0x8865;

		/// <summary>
		/// Gl.GetQueryObject: params returns the value of the query object's passed samples counter. The initial value is 0.
		/// </summary>
		[AliasOf("GL_QUERY_RESULT_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_RESULT = 0x8866;

		/// <summary>
		/// Gl.GetQueryObject: params returns whether the passed samples counter is immediately available. If a delay would occur 
		/// waiting for the query result, Gl.FALSE is returned. Otherwise, Gl.TRUE is returned, which also indicates that the 
		/// results of all previous queries are available as well.
		/// </summary>
		[AliasOf("GL_QUERY_RESULT_AVAILABLE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_RESULT_AVAILABLE = 0x8867;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_ARRAY_BUFFER_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ARRAY_BUFFER = 0x8892;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BUFFER_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ELEMENT_ARRAY_BUFFER = 0x8893;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target Gl.ARRAY_BUFFER. If no 
		/// buffer object is bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ARRAY_BUFFER_BINDING = 0x8894;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the target 
		/// Gl.ELEMENT_ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See 
		/// Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

		/// <summary>
		/// Gl.GetVertexAttrib: params returns a single value, the name of the buffer object currently bound to the binding point 
		/// corresponding to generic vertex attribute array index. If no buffer object is bound, 0 is returned. The initial value is 
		/// 0.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

		/// <summary>
		/// Value of GL_READ_ONLY symbol.
		/// </summary>
		[AliasOf("GL_READ_ONLY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int READ_ONLY = 0x88B8;

		/// <summary>
		/// Value of GL_WRITE_ONLY symbol.
		/// </summary>
		[AliasOf("GL_WRITE_ONLY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		public const int WRITE_ONLY = 0x88B9;

		/// <summary>
		/// Value of GL_READ_WRITE symbol.
		/// </summary>
		[AliasOf("GL_READ_WRITE_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		public const int READ_WRITE = 0x88BA;

		/// <summary>
		/// Gl.GetBufferParameter: params returns the access policy set while mapping the buffer object (the value of the access 
		/// parameter enum passed to glMapBuffer). If the buffer was mapped with glMapBufferRange, the access policy is determined 
		/// by translating the bits in that access parameter to one of the supported enums for glMapBuffer as described in the 
		/// OpenGL Specification.
		/// </summary>
		[AliasOf("GL_BUFFER_ACCESS_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_ACCESS = 0x88BB;

		/// <summary>
		/// Gl.GetBufferParameter: params returns a flag indicating whether the buffer object is currently mapped. The initial value 
		/// is Gl.FALSE.
		/// </summary>
		[AliasOf("GL_BUFFER_MAPPED_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_MAPPED = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER symbol.
		/// </summary>
		[AliasOf("GL_BUFFER_MAP_POINTER_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_MAP_POINTER = 0x88BD;

		/// <summary>
		/// Value of GL_STREAM_DRAW symbol.
		/// </summary>
		[AliasOf("GL_STREAM_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_DRAW = 0x88E0;

		/// <summary>
		/// Value of GL_STREAM_READ symbol.
		/// </summary>
		[AliasOf("GL_STREAM_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_READ = 0x88E1;

		/// <summary>
		/// Value of GL_STREAM_COPY symbol.
		/// </summary>
		[AliasOf("GL_STREAM_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_COPY = 0x88E2;

		/// <summary>
		/// Value of GL_STATIC_DRAW symbol.
		/// </summary>
		[AliasOf("GL_STATIC_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_DRAW = 0x88E4;

		/// <summary>
		/// Value of GL_STATIC_READ symbol.
		/// </summary>
		[AliasOf("GL_STATIC_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_READ = 0x88E5;

		/// <summary>
		/// Value of GL_STATIC_COPY symbol.
		/// </summary>
		[AliasOf("GL_STATIC_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_COPY = 0x88E6;

		/// <summary>
		/// Value of GL_DYNAMIC_DRAW symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_DRAW_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int DYNAMIC_DRAW = 0x88E8;

		/// <summary>
		/// Value of GL_DYNAMIC_READ symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_READ_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int DYNAMIC_READ = 0x88E9;

		/// <summary>
		/// Value of GL_DYNAMIC_COPY symbol.
		/// </summary>
		[AliasOf("GL_DYNAMIC_COPY_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int DYNAMIC_COPY = 0x88EA;

		/// <summary>
		/// Value of GL_SAMPLES_PASSED symbol.
		/// </summary>
		[AliasOf("GL_SAMPLES_PASSED_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int SAMPLES_PASSED = 0x8914;

		/// <summary>
		/// Gl.Get: params returns a single value, the name of the buffer object associated with the vertex array. This buffer 
		/// object would have been bound to the target Gl.ARRAY_BUFFER at the time of the most recent call to Gl.VertexPointer. If 
		/// no buffer object was bound to this target, 0 is returned. The initial value is 0. See Gl.BindBuffer.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;

		/// <summary>
		/// generate query object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of query object names to be generated.
		/// </param>
		/// <param name="ids">
		/// Specifies an array in which the generated query object names are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GenQueries(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueries != null, "pglGenQueries not implemented");
					Delegates.pglGenQueries((Int32)ids.Length, p_ids);
					CallLog("glGenQueries({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate query object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static UInt32 GenQuery()
		{
			UInt32[] retValue = new UInt32[1];
			GenQueries(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// delete named query objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of query objects to be deleted.
		/// </param>
		/// <param name="ids">
		/// Specifies an array of query objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void DeleteQueries(params UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueries != null, "pglDeleteQueries not implemented");
					Delegates.pglDeleteQueries((Int32)ids.Length, p_ids);
					CallLog("glDeleteQueries({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a query object
		/// </summary>
		/// <param name="id">
		/// Specifies a value that may be the name of a query object.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static bool IsQuery(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQuery != null, "pglIsQuery not implemented");
			retValue = Delegates.pglIsQuery(id);
			CallLog("glIsQuery({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic 
		/// constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BeginQuery(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQuery != null, "pglBeginQuery not implemented");
			Delegates.pglBeginQuery(target, id);
			CallLog("glBeginQuery({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic 
		/// constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void EndQuery(int target)
		{
			Debug.Assert(Delegates.pglEndQuery != null, "pglEndQuery not implemented");
			Delegates.pglEndQuery(target);
			CallLog("glEndQuery({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEGL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or 
		/// GL_TIMESTAMP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or 
		/// GL_QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetQuery(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryiv != null, "pglGetQueryiv not implemented");
					Delegates.pglGetQueryiv(target, pname, p_params);
					CallLog("glGetQueryiv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or 
		/// GL_QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the GL_QUERY_RESULT_BUFFER target, then params is treated as an offset to a location within that 
		/// buffer's data store to receive the result of the query. If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is 
		/// treated as an address in client memory of a variable to receive the resulting data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetQueryObject(UInt32 id, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectiv != null, "pglGetQueryObjectiv not implemented");
					Delegates.pglGetQueryObjectiv(id, pname, p_params);
					CallLog("glGetQueryObjectiv({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object
		/// </summary>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or 
		/// GL_QUERY_RESULT_AVAILABLE.
		/// </param>
		/// <param name="params">
		/// If a buffer is bound to the GL_QUERY_RESULT_BUFFER target, then params is treated as an offset to a location within that 
		/// buffer's data store to receive the result of the query. If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is 
		/// treated as an address in client memory of a variable to receive the resulting data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetQueryObjectuiv(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuiv != null, "pglGetQueryObjectuiv not implemented");
					Delegates.pglGetQueryObjectuiv(id, pname, p_params);
					CallLog("glGetQueryObjectuiv({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBuffer != null, "pglBindBuffer not implemented");
			Delegates.pglBindBuffer((int)target, buffer);
			CallLog("glBindBuffer({0}, {1})", target, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete named buffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of buffer objects to be deleted.
		/// </param>
		/// <param name="buffers">
		/// Specifies an array of buffer objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void DeleteBuffers(params UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglDeleteBuffers != null, "pglDeleteBuffers not implemented");
					Delegates.pglDeleteBuffers((Int32)buffers.Length, p_buffers);
					CallLog("glDeleteBuffers({0}, {1})", buffers.Length, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate buffer object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of buffer object names to be generated.
		/// </param>
		/// <param name="buffers">
		/// Specifies an array in which the generated buffer object names are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GenBuffers(UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					Debug.Assert(Delegates.pglGenBuffers != null, "pglGenBuffers not implemented");
					Delegates.pglGenBuffers((Int32)buffers.Length, p_buffers);
					CallLog("glGenBuffers({0}, {1})", buffers.Length, buffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate buffer object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static bool IsBuffer(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsBuffer != null, "pglIsBuffer not implemented");
			retValue = Delegates.pglIsBuffer(buffer);
			CallLog("glIsBuffer({0}) = {1}", buffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BufferData(int target, UInt32 size, IntPtr data, int usage)
		{
			Debug.Assert(Delegates.pglBufferData != null, "pglBufferData not implemented");
			Delegates.pglBufferData(target, size, data, usage);
			CallLog("glBufferData({0}, {1}, {2}, {3})", target, size, data, usage);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BufferData(BufferTargetARB target, UInt32 size, IntPtr data, BufferUsageARB usage)
		{
			Debug.Assert(Delegates.pglBufferData != null, "pglBufferData not implemented");
			Delegates.pglBufferData((int)target, size, data, (int)usage);
			CallLog("glBufferData({0}, {1}, {2}, {3})", target, size, data, usage);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BufferData(int target, UInt32 size, Object data, int usage)
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
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="size">
		/// Specifies the size in bytes of the buffer object's new data store.
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to data that will be copied into the data store for initialization, or NULL if no data is to be 
		/// copied.
		/// </param>
		/// <param name="usage">
		/// Specifies the expected usage pattern of the data store. The symbolic constant must be GL_STREAM_DRAW, GL_STREAM_READ, 
		/// GL_STREAM_COPY, GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding 
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglBufferSubData != null, "pglBufferSubData not implemented");
			Delegates.pglBufferSubData((int)target, offset, size, data);
			CallLog("glBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding 
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
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// Specifies the target to which the buffer object is bound for glGetBufferSubData, which must be one of the buffer binding 
		/// targets in the following table:
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, UInt32 size, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetBufferSubData != null, "pglGetBufferSubData not implemented");
			Delegates.pglGetBufferSubData((int)target, offset, size, data);
			CallLog("glGetBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// returns a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferSubData, which must be one of the buffer binding 
		/// targets in the following table:
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
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// Specifies the target to which the buffer object is bound for glMapBuffer, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="access">
		/// Specifies the access policy for glMapBuffer and glMapNamedBuffer, indicating whether it will be possible to read from, 
		/// write to, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static IntPtr MapBuffer(BufferTargetARB target, BufferAccessARB access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBuffer != null, "pglMapBuffer not implemented");
			retValue = Delegates.pglMapBuffer((int)target, (int)access);
			CallLog("glMapBuffer({0}, {1}) = {2}", target, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// release the mapping of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glUnmapBuffer, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static bool UnmapBuffer(BufferTargetARB target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglUnmapBuffer != null, "pglUnmapBuffer not implemented");
			retValue = Delegates.pglUnmapBuffer((int)target);
			CallLog("glUnmapBuffer({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferParameter(BufferTargetARB target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
					Delegates.pglGetBufferParameteriv((int)target, pname, p_params);
					CallLog("glGetBufferParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must 
		/// be one of the buffer binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferParameter(BufferTargetARB target, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetBufferParameteriv != null, "pglGetBufferParameteriv not implemented");
					Delegates.pglGetBufferParameteriv((int)target, pname, p_params);
					CallLog("glGetBufferParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be GL_BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by pname.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferPointer(BufferTargetARB target, int pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetBufferPointerv != null, "pglGetBufferPointerv not implemented");
					Delegates.pglGetBufferPointerv((int)target, pname, p_params);
					CallLog("glGetBufferPointerv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be GL_BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// Returns the pointer value specified by pname.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferPointer(BufferTargetARB target, int pname, Object @params)
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
