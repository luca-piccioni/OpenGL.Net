
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
		/// Value of GL_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BUFFER_SIZE = 0x8764;

		/// <summary>
		/// Value of GL_BUFFER_USAGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int BUFFER_USAGE = 0x8765;

		/// <summary>
		/// Value of GL_QUERY_COUNTER_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_COUNTER_BITS = 0x8864;

		/// <summary>
		/// Value of GL_CURRENT_QUERY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int CURRENT_QUERY = 0x8865;

		/// <summary>
		/// Value of GL_QUERY_RESULT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int QUERY_RESULT = 0x8866;

		/// <summary>
		/// Value of GL_QUERY_RESULT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int QUERY_RESULT_AVAILABLE = 0x8867;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ARRAY_BUFFER = 0x8892;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ELEMENT_ARRAY_BUFFER = 0x8893;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ARRAY_BUFFER_BINDING = 0x8894;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

		/// <summary>
		/// Value of GL_READ_ONLY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int READ_ONLY = 0x88B8;

		/// <summary>
		/// Value of GL_WRITE_ONLY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		public const int WRITE_ONLY = 0x88B9;

		/// <summary>
		/// Value of GL_READ_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		public const int READ_WRITE = 0x88BA;

		/// <summary>
		/// Value of GL_BUFFER_ACCESS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_ACCESS = 0x88BB;

		/// <summary>
		/// Value of GL_BUFFER_MAPPED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int BUFFER_MAPPED = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int BUFFER_MAP_POINTER = 0x88BD;

		/// <summary>
		/// Value of GL_STREAM_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STREAM_DRAW = 0x88E0;

		/// <summary>
		/// Value of GL_STREAM_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int STREAM_READ = 0x88E1;

		/// <summary>
		/// Value of GL_STREAM_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int STREAM_COPY = 0x88E2;

		/// <summary>
		/// Value of GL_STATIC_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int STATIC_DRAW = 0x88E4;

		/// <summary>
		/// Value of GL_STATIC_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int STATIC_READ = 0x88E5;

		/// <summary>
		/// Value of GL_STATIC_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int STATIC_COPY = 0x88E6;

		/// <summary>
		/// Value of GL_DYNAMIC_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int DYNAMIC_DRAW = 0x88E8;

		/// <summary>
		/// Value of GL_DYNAMIC_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DYNAMIC_READ = 0x88E9;

		/// <summary>
		/// Value of GL_DYNAMIC_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int DYNAMIC_COPY = 0x88EA;

		/// <summary>
		/// Value of GL_SAMPLES_PASSED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int SAMPLES_PASSED = 0x8914;

		/// <summary>
		/// Value of GL_SRC1_ALPHA symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE1_ALPHA.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int SRC1_ALPHA = 0x8589;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_BUFFER_BINDING = 0x8896;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_BUFFER_BINDING = 0x8897;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_ARRAY_BUFFER_BINDING = 0x8898;

		/// <summary>
		/// Value of GL_INDEX_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INDEX_ARRAY_BUFFER_BINDING = 0x8899;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_COORD_ARRAY_BUFFER_BINDING = 0x889A;

		/// <summary>
		/// Value of GL_EDGE_FLAG_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int EDGE_FLAG_ARRAY_BUFFER_BINDING = 0x889B;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_BUFFER_BINDING = 0x889C;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_BUFFER_BINDING = 0x889D;

		/// <summary>
		/// Value of GL_WEIGHT_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int WEIGHT_ARRAY_BUFFER_BINDING = 0x889E;

		/// <summary>
		/// Value of GL_FOG_COORD_SRC symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_SOURCE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_SRC = 0x8450;

		/// <summary>
		/// Value of GL_FOG_COORD symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD = 0x8451;

		/// <summary>
		/// Value of GL_CURRENT_FOG_COORD symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CURRENT_FOG_COORDINATE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_FOG_COORD = 0x8453;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_ARRAY_TYPE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_ARRAY_TYPE = 0x8454;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_ARRAY_STRIDE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_ARRAY_STRIDE = 0x8455;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_ARRAY_POINTER.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_ARRAY_POINTER = 0x8456;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_ARRAY.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_ARRAY = 0x8457;

		/// <summary>
		/// Value of GL_FOG_COORD_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to FOG_COORDINATE_ARRAY_BUFFER_BINDING.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORD_ARRAY_BUFFER_BINDING = 0x889D;

		/// <summary>
		/// Value of GL_SRC0_RGB symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE0_RGB.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SRC0_RGB = 0x8580;

		/// <summary>
		/// Value of GL_SRC1_RGB symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE1_RGB.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SRC1_RGB = 0x8581;

		/// <summary>
		/// Value of GL_SRC2_RGB symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE2_RGB.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SRC2_RGB = 0x8582;

		/// <summary>
		/// Value of GL_SRC0_ALPHA symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE0_ALPHA.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SRC0_ALPHA = 0x8588;

		/// <summary>
		/// Value of GL_SRC2_ALPHA symbol (DEPRECATED).
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SOURCE2_ALPHA.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SRC2_ALPHA = 0x858A;

		/// <summary>
		/// generate query object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of query object names to be generated. 
		/// </param>
		/// <param name="ids">
		/// Specifies an array in which the generated query object names are stored. 
		/// </param>
		/// <remarks>
		/// glGenQueries returns n query object names in ids. There is no guarantee that the names form a contiguous set of 
		/// integers;however, it is guaranteed that none of the returned names was in use immediately before the call to 
		/// glGenQueries.
		/// Query object names returned by a call to glGenQueries are not returned by subsequent calls, unless they are first 
		/// deletedwith glDeleteQueries. 
		/// No query objects are associated with the returned query object names until they are first used by calling glBeginQuery. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsQuery 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		public static void GenQueries(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglGenQueries != null) {
						Delegates.pglGenQueries(n, p_ids);
						CallLog("glGenQueries({0}, {1})", n, ids);
					} else if (Delegates.pglGenQueriesARB != null) {
						Delegates.pglGenQueriesARB(n, p_ids);
						CallLog("glGenQueriesARB({0}, {1})", n, ids);
					} else
						throw new NotImplementedException("glGenQueries (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
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
		/// <remarks>
		/// glDeleteQueries deletes n query objects named by the elements of the array ids. After a query object is deleted, it has 
		/// nocontents, and its name is free for reuse (for example by glGenQueries). 
		/// glDeleteQueries silently ignores 0's and names that do not correspond to existing query objects. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsQuery 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		public static void DeleteQueries(Int32 n, UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglDeleteQueries != null) {
						Delegates.pglDeleteQueries(n, p_ids);
						CallLog("glDeleteQueries({0}, {1})", n, ids);
					} else if (Delegates.pglDeleteQueriesARB != null) {
						Delegates.pglDeleteQueriesARB(n, p_ids);
						CallLog("glDeleteQueriesARB({0}, {1})", n, ids);
					} else
						throw new NotImplementedException("glDeleteQueries (and other aliases) are not implemented");
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
		/// <remarks>
		/// glIsQuery returns GL_TRUE if id is currently the name of a query object. If id is zero, or is a non-zero value that is 
		/// notcurrently the name of a query object, or if an error occurs, glIsQuery returns GL_FALSE. 
		/// A name returned by glGenQueries, but not yet associated with a query object by calling glBeginQuery, is not the name of 
		/// aquery object. 
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		public static bool IsQuery(UInt32 id)
		{
			bool retValue;

			if        (Delegates.pglIsQuery != null) {
				retValue = Delegates.pglIsQuery(id);
				CallLog("glIsQuery({0}) = {1}", id, retValue);
			} else if (Delegates.pglIsQueryARB != null) {
				retValue = Delegates.pglIsQueryARB(id);
				CallLog("glIsQueryARB({0}) = {1}", id, retValue);
			} else
				throw new NotImplementedException("glIsQuery (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic 
		/// constantmust be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED,GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED. 
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object. 
		/// </param>
		/// <remarks>
		/// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a 
		/// callto glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. 
		/// targetmust be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is 
		/// asfollows. 
		/// If target is GL_SAMPLES_PASSED, id must be an unused name, or the name of an existing occlusion query object. When 
		/// glBeginQueryis executed, the query object's samples-passed counter is reset to 0. Subsequent rendering will increment 
		/// thecounter for every sample that passes the depth test. If the value of GL_SAMPLE_BUFFERS is 0, then the samples-passed 
		/// countis incremented by 1 for each fragment. If the value of GL_SAMPLE_BUFFERS is 1, then the samples-passed count is 
		/// incrementedby the number of samples whose coverage bit is set. However, implementations, at their discression may 
		/// insteadincrease the samples-passed count by the value of GL_SAMPLES if any sample in the fragment is covered. When 
		/// glEndQueryis executed, the samples-passed counter is assigned to the query object's result value. This value can be 
		/// queriedby calling glGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_ANY_SAMPLES_PASSED or GL_ANY_SAMPLES_PASSED_CONSERVATIVE, id must be an unused name, or the name of an 
		/// existingboolean occlusion query object. When glBeginQuery is executed, the query object's samples-passed flag is reset 
		/// toGL_FALSE. Subsequent rendering causes the flag to be set to GL_TRUE if any sample passes the depth test in the case of 
		/// GL_ANY_SAMPLES_PASSED,or if the implementation determines that any sample might pass the depth test in the case of 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVE.The implementation may be able to provide a more efficient test in the case of 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEif some false positives are acceptable to the application. When glEndQuery is 
		/// executed,the samples-passed flag is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. 
		/// If target is GL_PRIMITIVES_GENERATED, id must be an unused name, or the name of an existing primitive query object 
		/// previouslybound to the GL_PRIMITIVES_GENERATED query binding. When glBeginQuery is executed, the query object's 
		/// primitives-generatedcounter is reset to 0. Subsequent rendering will increment the counter once for every vertex that is 
		/// emittedfrom the geometry shader, or from the vertex shader if no geometry shader is present. When glEndQuery is 
		/// executed,the primitives-generated counter is assigned to the query object's result value. This value can be queried by 
		/// callingglGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, id must be an unused name, or the name of an existing primitive 
		/// queryobject previously bound to the GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN query binding. When glBeginQuery is 
		/// executed,the query object's primitives-written counter is reset to 0. Subsequent rendering will increment the counter 
		/// oncefor every vertex that is written into the bound transform feedback buffer(s). If transform feedback mode is not 
		/// activatedbetween the call to glBeginQuery and glEndQuery, the counter will not be incremented. When glEndQuery is 
		/// executed,the primitives-written counter is assigned to the query object's result value. This value can be queried by 
		/// callingglGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_TIME_ELAPSED, id must be an unused name, or the name of an existing timer query object previously bound 
		/// tothe GL_TIME_ELAPSED query binding. When glBeginQuery is executed, the query object's time counter is reset to 0. When 
		/// glEndQueryis executed, the elapsed server time that has passed since the call to glBeginQuery is written into the query 
		/// object'stime counter. This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. 
		/// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has 
		/// completedand the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately 
		/// availableor if the rendering is not yet complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the accepted tokens. 
		/// - GL_INVALID_OPERATION is generated if glBeginQuery is executed while a query object of the same target is already active. 
		/// - GL_INVALID_OPERATION is generated if glEndQuery is executed when a query object of the same target is not active. 
		/// - GL_INVALID_OPERATION is generated if id is 0. 
		/// - GL_INVALID_OPERATION is generated if id is the name of an already active query object. 
		/// - GL_INVALID_OPERATION is generated if id refers to an existing query object whose type does not does not match target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		public static void BeginQuery(int target, UInt32 id)
		{
			if        (Delegates.pglBeginQuery != null) {
				Delegates.pglBeginQuery(target, id);
				CallLog("glBeginQuery({0}, {1})", target, id);
			} else if (Delegates.pglBeginQueryARB != null) {
				Delegates.pglBeginQueryARB(target, id);
				CallLog("glBeginQueryARB({0}, {1})", target, id);
			} else
				throw new NotImplementedException("glBeginQuery (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the boundaries of a query object
		/// </summary>
		/// <param name="target">
		/// Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic 
		/// constantmust be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED,GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED. 
		/// </param>
		/// <remarks>
		/// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a 
		/// callto glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. 
		/// targetmust be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, 
		/// GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is 
		/// asfollows. 
		/// If target is GL_SAMPLES_PASSED, id must be an unused name, or the name of an existing occlusion query object. When 
		/// glBeginQueryis executed, the query object's samples-passed counter is reset to 0. Subsequent rendering will increment 
		/// thecounter for every sample that passes the depth test. If the value of GL_SAMPLE_BUFFERS is 0, then the samples-passed 
		/// countis incremented by 1 for each fragment. If the value of GL_SAMPLE_BUFFERS is 1, then the samples-passed count is 
		/// incrementedby the number of samples whose coverage bit is set. However, implementations, at their discression may 
		/// insteadincrease the samples-passed count by the value of GL_SAMPLES if any sample in the fragment is covered. When 
		/// glEndQueryis executed, the samples-passed counter is assigned to the query object's result value. This value can be 
		/// queriedby calling glGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_ANY_SAMPLES_PASSED or GL_ANY_SAMPLES_PASSED_CONSERVATIVE, id must be an unused name, or the name of an 
		/// existingboolean occlusion query object. When glBeginQuery is executed, the query object's samples-passed flag is reset 
		/// toGL_FALSE. Subsequent rendering causes the flag to be set to GL_TRUE if any sample passes the depth test in the case of 
		/// GL_ANY_SAMPLES_PASSED,or if the implementation determines that any sample might pass the depth test in the case of 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVE.The implementation may be able to provide a more efficient test in the case of 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEif some false positives are acceptable to the application. When glEndQuery is 
		/// executed,the samples-passed flag is assigned to the query object's result value. This value can be queried by calling 
		/// glGetQueryObjectwith pnameGL_QUERY_RESULT. 
		/// If target is GL_PRIMITIVES_GENERATED, id must be an unused name, or the name of an existing primitive query object 
		/// previouslybound to the GL_PRIMITIVES_GENERATED query binding. When glBeginQuery is executed, the query object's 
		/// primitives-generatedcounter is reset to 0. Subsequent rendering will increment the counter once for every vertex that is 
		/// emittedfrom the geometry shader, or from the vertex shader if no geometry shader is present. When glEndQuery is 
		/// executed,the primitives-generated counter is assigned to the query object's result value. This value can be queried by 
		/// callingglGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, id must be an unused name, or the name of an existing primitive 
		/// queryobject previously bound to the GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN query binding. When glBeginQuery is 
		/// executed,the query object's primitives-written counter is reset to 0. Subsequent rendering will increment the counter 
		/// oncefor every vertex that is written into the bound transform feedback buffer(s). If transform feedback mode is not 
		/// activatedbetween the call to glBeginQuery and glEndQuery, the counter will not be incremented. When glEndQuery is 
		/// executed,the primitives-written counter is assigned to the query object's result value. This value can be queried by 
		/// callingglGetQueryObject with pnameGL_QUERY_RESULT. 
		/// If target is GL_TIME_ELAPSED, id must be an unused name, or the name of an existing timer query object previously bound 
		/// tothe GL_TIME_ELAPSED query binding. When glBeginQuery is executed, the query object's time counter is reset to 0. When 
		/// glEndQueryis executed, the elapsed server time that has passed since the call to glBeginQuery is written into the query 
		/// object'stime counter. This value can be queried by calling glGetQueryObject with pnameGL_QUERY_RESULT. 
		/// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has 
		/// completedand the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately 
		/// availableor if the rendering is not yet complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the accepted tokens. 
		/// - GL_INVALID_OPERATION is generated if glBeginQuery is executed while a query object of the same target is already active. 
		/// - GL_INVALID_OPERATION is generated if glEndQuery is executed when a query object of the same target is not active. 
		/// - GL_INVALID_OPERATION is generated if id is 0. 
		/// - GL_INVALID_OPERATION is generated if id is the name of an already active query object. 
		/// - GL_INVALID_OPERATION is generated if id refers to an existing query object whose type does not does not match target. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQueryIndexed"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		public static void EndQuery(int target)
		{
			if        (Delegates.pglEndQuery != null) {
				Delegates.pglEndQuery(target);
				CallLog("glEndQuery({0})", target);
			} else if (Delegates.pglEndQueryARB != null) {
				Delegates.pglEndQueryARB(target);
				CallLog("glEndQueryARB({0})", target);
			} else
				throw new NotImplementedException("glEndQuery (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return parameters of a query object target
		/// </summary>
		/// <param name="target">
		/// Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, 
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEGL_PRIMITIVES_GENERATED,GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or 
		/// GL_TIMESTAMP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or 
		/// GL_QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetQueryiv returns in params a selected parameter of the query object target specified by target. 
		/// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active 
		/// queryfor target, or zero if no query is active, will be placed in params. If pname is GL_QUERY_COUNTER_BITS, the 
		/// implementation-dependentnumber of bits used to hold the result of queries for target is returned in params. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target or pname is not an accepted value. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.IsQuery"/>
		public static void GetQuery(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetQueryiv != null) {
						Delegates.pglGetQueryiv(target, pname, p_params);
						CallLog("glGetQueryiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetQueryivARB != null) {
						Delegates.pglGetQueryivARB(target, pname, p_params);
						CallLog("glGetQueryivARB({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetQueryiv (and other aliases) are not implemented");
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
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetQueryObject returns in params a selected parameter of the query object specified by id. 
		/// pname names a specific query object parameter. pname can be as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if id is not the name of a query object. 
		/// - GL_INVALID_OPERATION is generated if id is the name of a currently active query object. 
		/// - GL_INVALID_OPERATION is generated if a buffer is currently bound to the GL_QUERY_RESULT_BUFFER target and the command 
		///   wouldcause data to be written beyond the bounds of that buffer's data store. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		public static void GetQueryObject(UInt32 id, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetQueryObjectiv != null) {
						Delegates.pglGetQueryObjectiv(id, pname, p_params);
						CallLog("glGetQueryObjectiv({0}, {1}, {2})", id, pname, @params);
					} else if (Delegates.pglGetQueryObjectivARB != null) {
						Delegates.pglGetQueryObjectivARB(id, pname, p_params);
						CallLog("glGetQueryObjectivARB({0}, {1}, {2})", id, pname, @params);
					} else if (Delegates.pglGetQueryObjectivEXT != null) {
						Delegates.pglGetQueryObjectivEXT(id, pname, p_params);
						CallLog("glGetQueryObjectivEXT({0}, {1}, {2})", id, pname, @params);
					} else
						throw new NotImplementedException("glGetQueryObjectiv (and other aliases) are not implemented");
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
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetQueryObject returns in params a selected parameter of the query object specified by id. 
		/// pname names a specific query object parameter. pname can be as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if id is not the name of a query object. 
		/// - GL_INVALID_OPERATION is generated if id is the name of a currently active query object. 
		/// - GL_INVALID_OPERATION is generated if a buffer is currently bound to the GL_QUERY_RESULT_BUFFER target and the command 
		///   wouldcause data to be written beyond the bounds of that buffer's data store. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginQuery"/>
		/// <seealso cref="Gl.EndQuery"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.IsQuery"/>
		/// <seealso cref="Gl.QueryCounter"/>
		public static void GetQueryObjectuiv(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetQueryObjectuiv != null) {
						Delegates.pglGetQueryObjectuiv(id, pname, p_params);
						CallLog("glGetQueryObjectuiv({0}, {1}, {2})", id, pname, @params);
					} else if (Delegates.pglGetQueryObjectuivARB != null) {
						Delegates.pglGetQueryObjectuivARB(id, pname, p_params);
						CallLog("glGetQueryObjectuivARB({0}, {1}, {2})", id, pname, @params);
					} else
						throw new NotImplementedException("glGetQueryObjectuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a named buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound, which must be one of the buffer binding targets in the 
		/// followingtable: 
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of a buffer object. 
		/// </param>
		/// <remarks>
		/// glBindBuffer binds a buffer object to the specified buffer binding point. Calling glBindBuffer with target set to one of 
		/// theaccepted symbolic constants and buffer set to the name of a buffer object binds that buffer object name to the 
		/// target.If no buffer object with name buffer exists, one is created with that name. When a buffer object is bound to a 
		/// target,the previous binding for that target is automatically broken. 
		/// Buffer object names are unsigned integers. The value zero is reserved, but there is no default buffer object for each 
		/// bufferobject target. Instead, buffer set to zero effectively unbinds any buffer object previously bound, and restores 
		/// clientmemory usage for that buffer object target (if supported for that target). Buffer object names and the 
		/// correspondingbuffer object contents are local to the shared object space of the current GL rendering context; two 
		/// renderingcontexts share buffer object names only if they explicitly enable sharing between contexts through the 
		/// appropriateGL windows interfaces functions. 
		/// glGenBuffers must be used to generate a set of unused buffer object names. 
		/// The state of a buffer object immediately after it is first bound is an unmapped zero-sized memory buffer with 
		/// GL_READ_WRITEaccess and GL_STATIC_DRAW usage. 
		/// While a non-zero buffer object name is bound, GL operations on the target to which it is bound affect the bound buffer 
		/// object,and queries of the target to which it is bound return state from the bound buffer object. While buffer object 
		/// namezero is bound, as in the initial state, attempts to modify or query state on the target to which it is bound 
		/// generatesan GL_INVALID_OPERATION error. 
		/// When a non-zero buffer object is bound to the GL_ARRAY_BUFFER target, the vertex array pointer parameter is interpreted 
		/// asan offset within the buffer object measured in basic machine units. 
		/// When a non-zero buffer object is bound to the GL_DRAW_INDIRECT_BUFFER target, parameters for draws issued through 
		/// glDrawArraysIndirectand glDrawElementsIndirect are sourced from the specified offset in that buffer object's data store. 
		/// When a non-zero buffer object is bound to the GL_DISPATCH_INDIRECT_BUFFER target, the parameters for compute dispatches 
		/// issuedthrough glDispatchComputeIndirect are sourced from the specified offset in that buffer object's data store. 
		/// While a non-zero buffer object is bound to the GL_ELEMENT_ARRAY_BUFFER target, the indices parameter of glDrawElements, 
		/// glDrawElementsInstanced,glDrawElementsBaseVertex, glDrawRangeElements, glDrawRangeElementsBaseVertex, 
		/// glMultiDrawElements,or glMultiDrawElementsBaseVertex is interpreted as an offset within the buffer object measured in 
		/// basicmachine units. 
		/// While a non-zero buffer object is bound to the GL_PIXEL_PACK_BUFFER target, the following commands are affected: 
		/// glGetCompressedTexImage,glGetTexImage, and glReadPixels. The pointer parameter is interpreted as an offset within the 
		/// bufferobject measured in basic machine units. 
		/// While a non-zero buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target, the following commands are affected: 
		/// glCompressedTexImage1D,glCompressedTexImage2D, glCompressedTexImage3D, glCompressedTexSubImage1D, 
		/// glCompressedTexSubImage2D,glCompressedTexSubImage3D, glTexImage1D, glTexImage2D, glTexImage3D, glTexSubImage1D, 
		/// glTexSubImage2D,and glTexSubImage3D. The pointer parameter is interpreted as an offset within the buffer object measured 
		/// inbasic machine units. 
		/// The buffer targets GL_COPY_READ_BUFFER and GL_COPY_WRITE_BUFFER are provided to allow glCopyBufferSubData to be used 
		/// withoutdisturbing the state of other bindings. However, glCopyBufferSubData may be used with any pair of buffer binding 
		/// points.
		/// The GL_TRANSFORM_FEEDBACK_BUFFER buffer binding point may be passed to glBindBuffer, but will not directly affect 
		/// transformfeedback state. Instead, the indexed GL_TRANSFORM_FEEDBACK_BUFFER bindings must be used through a call to 
		/// glBindBufferBaseor glBindBufferRange. This will affect the generic GL_TRANSFORM_FEEDBACK_BUFFER binding. 
		/// Likewise, the GL_UNIFORM_BUFFER, GL_ATOMIC_COUNTER_BUFFER and GL_SHADER_STORAGE_BUFFER buffer binding points may be 
		/// used,but do not directly affect uniform buffer, atomic counter buffer or shader storage buffer state, respectively. 
		/// glBindBufferBaseor glBindBufferRange must be used to bind a buffer to an indexed uniform buffer, atomic counter buffer 
		/// orshader storage buffer binding point. 
		/// The GL_QUERY_BUFFER binding point is used to specify a buffer object that is to receive the results of query objects 
		/// throughcalls to the glGetQueryObject family of commands. 
		/// A buffer object binding created with glBindBuffer remains active until a different buffer object name is bound to the 
		/// sametarget, or until the bound buffer object is deleted with glDeleteBuffers. 
		/// Once created, a named buffer object may be re-bound to any target as often as needed. However, the GL implementation may 
		/// makechoices about how to optimize the storage of a buffer object based on its initial binding target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of the allowable values. 
		/// - GL_INVALID_VALUE is generated if buffer is not a name previously returned from a call to glGenBuffers. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_ARRAY_BUFFER_BINDING 
		/// - glGet with argument GL_ATOMIC_COUNTER_BUFFER_BINDING 
		/// - glGet with argument GL_COPY_READ_BUFFER_BINDING 
		/// - glGet with argument GL_COPY_WRITE_BUFFER_BINDING 
		/// - glGet with argument GL_DRAW_INDIRECT_BUFFER_BINDING 
		/// - glGet with argument GL_DISPATCH_INDIRECT_BUFFER_BINDING 
		/// - glGet with argument GL_ELEMENT_ARRAY_BUFFER_BINDING 
		/// - glGet with argument GL_PIXEL_PACK_BUFFER_BINDING 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGet with argument GL_SHADER_STORAGE_BUFFER_BINDING 
		/// - glGet with argument GL_TRANSFORM_FEEDBACK_BUFFER_BINDING 
		/// - glGet with argument GL_UNIFORM_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsBuffer"/>
		public static void BindBuffer(int target, UInt32 buffer)
		{
			if        (Delegates.pglBindBuffer != null) {
				Delegates.pglBindBuffer(target, buffer);
				CallLog("glBindBuffer({0}, {1})", target, buffer);
			} else if (Delegates.pglBindBufferARB != null) {
				Delegates.pglBindBufferARB(target, buffer);
				CallLog("glBindBufferARB({0}, {1})", target, buffer);
			} else
				throw new NotImplementedException("glBindBuffer (and other aliases) are not implemented");
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
		/// <remarks>
		/// glDeleteBuffers deletes n buffer objects named by the elements of the array buffers. After a buffer object is deleted, 
		/// ithas no contents, and its name is free for reuse (for example by glGenBuffers). If a buffer object that is currently 
		/// boundis deleted, the binding reverts to 0 (the absence of any buffer object). 
		/// glDeleteBuffers silently ignores 0's and names that do not correspond to existing buffer objects. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsBuffer 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.Get"/>
		public static void DeleteBuffers(Int32 n, UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					if        (Delegates.pglDeleteBuffers != null) {
						Delegates.pglDeleteBuffers(n, p_buffers);
						CallLog("glDeleteBuffers({0}, {1})", n, buffers);
					} else if (Delegates.pglDeleteBuffersARB != null) {
						Delegates.pglDeleteBuffersARB(n, p_buffers);
						CallLog("glDeleteBuffersARB({0}, {1})", n, buffers);
					} else
						throw new NotImplementedException("glDeleteBuffers (and other aliases) are not implemented");
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
		/// <remarks>
		/// glGenBuffers returns n buffer object names in buffers. There is no guarantee that the names form a contiguous set of 
		/// integers;however, it is guaranteed that none of the returned names was in use immediately before the call to 
		/// glGenBuffers.
		/// Buffer object names returned by a call to glGenBuffers are not returned by subsequent calls, unless they are first 
		/// deletedwith glDeleteBuffers. 
		/// No buffer objects are associated with the returned buffer object names until they are first bound by calling 
		/// glBindBuffer.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glIsBuffer 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.Get"/>
		public static void GenBuffers(Int32 n, UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					if        (Delegates.pglGenBuffers != null) {
						Delegates.pglGenBuffers(n, p_buffers);
						CallLog("glGenBuffers({0}, {1})", n, buffers);
					} else if (Delegates.pglGenBuffersARB != null) {
						Delegates.pglGenBuffersARB(n, p_buffers);
						CallLog("glGenBuffersARB({0}, {1})", n, buffers);
					} else
						throw new NotImplementedException("glGenBuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a buffer object
		/// </summary>
		/// <param name="buffer">
		/// Specifies a value that may be the name of a buffer object. 
		/// </param>
		/// <remarks>
		/// glIsBuffer returns GL_TRUE if buffer is currently the name of a buffer object. If buffer is zero, or is a non-zero value 
		/// thatis not currently the name of a buffer object, or if an error occurs, glIsBuffer returns GL_FALSE. 
		/// A name returned by glGenBuffers, but not yet associated with a buffer object by calling glBindBuffer, is not the name of 
		/// abuffer object. 
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.Get"/>
		public static bool IsBuffer(UInt32 buffer)
		{
			bool retValue;

			if        (Delegates.pglIsBuffer != null) {
				retValue = Delegates.pglIsBuffer(buffer);
				CallLog("glIsBuffer({0}) = {1}", buffer, retValue);
			} else if (Delegates.pglIsBufferARB != null) {
				retValue = Delegates.pglIsBufferARB(buffer);
				CallLog("glIsBufferARB({0}) = {1}", buffer, retValue);
			} else
				throw new NotImplementedException("glIsBuffer (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targetsin the following table: 
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
		/// GL_STREAM_COPY,GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// </param>
		/// <remarks>
		/// glBufferData and glNamedBufferData create a new data store for a buffer object. In case of glBufferData, the buffer 
		/// objectcurrently bound to target is used. For glNamedBufferData, a buffer object associated with ID specified by the 
		/// callerin buffer will be used instead. 
		/// While creating the new storage, any pre-existing data store is deleted. The new data store is created with the specified 
		/// sizein bytes and usage. If data is not NULL, the data store is initialized with data from this pointer. In its initial 
		/// state,the new data store is not mapped, it has a NULL mapped pointer, and its mapped access is GL_READ_WRITE. 
		/// usage is a hint to the GL implementation as to how a buffer object's data store will be accessed. This enables the GL 
		/// implementationto make more intelligent decisions that may significantly impact buffer object performance. It does not, 
		/// however,constrain the actual usage of the data store. usage can be broken down into two parts: first, the frequency of 
		/// access(modification and usage), and second, the nature of that access. The frequency of access may be one of these: 
		/// The nature of access may be one of these: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_ENUM is generated if usage is not GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, 
		///   GL_STATIC_READ,GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// - GL_INVALID_VALUE is generated if size is negative. 
		/// - GL_INVALID_OPERATION is generated by glBufferData if the reserved buffer object name 0 is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified size. 
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
		public static void BufferData(int target, UInt32 size, IntPtr data, int usage)
		{
			if        (Delegates.pglBufferData != null) {
				Delegates.pglBufferData(target, size, data, usage);
				CallLog("glBufferData({0}, {1}, {2}, {3})", target, size, data, usage);
			} else if (Delegates.pglBufferDataARB != null) {
				Delegates.pglBufferDataARB(target, size, data, usage);
				CallLog("glBufferDataARB({0}, {1}, {2}, {3})", target, size, data, usage);
			} else
				throw new NotImplementedException("glBufferData (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// creates and initializes a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferData, which must be one of the buffer binding 
		/// targetsin the following table: 
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
		/// GL_STREAM_COPY,GL_STATIC_DRAW, GL_STATIC_READ, GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// </param>
		/// <remarks>
		/// glBufferData and glNamedBufferData create a new data store for a buffer object. In case of glBufferData, the buffer 
		/// objectcurrently bound to target is used. For glNamedBufferData, a buffer object associated with ID specified by the 
		/// callerin buffer will be used instead. 
		/// While creating the new storage, any pre-existing data store is deleted. The new data store is created with the specified 
		/// sizein bytes and usage. If data is not NULL, the data store is initialized with data from this pointer. In its initial 
		/// state,the new data store is not mapped, it has a NULL mapped pointer, and its mapped access is GL_READ_WRITE. 
		/// usage is a hint to the GL implementation as to how a buffer object's data store will be accessed. This enables the GL 
		/// implementationto make more intelligent decisions that may significantly impact buffer object performance. It does not, 
		/// however,constrain the actual usage of the data store. usage can be broken down into two parts: first, the frequency of 
		/// access(modification and usage), and second, the nature of that access. The frequency of access may be one of these: 
		/// The nature of access may be one of these: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_ENUM is generated if usage is not GL_STREAM_DRAW, GL_STREAM_READ, GL_STREAM_COPY, GL_STATIC_DRAW, 
		///   GL_STATIC_READ,GL_STATIC_COPY, GL_DYNAMIC_DRAW, GL_DYNAMIC_READ, or GL_DYNAMIC_COPY. 
		/// - GL_INVALID_VALUE is generated if size is negative. 
		/// - GL_INVALID_OPERATION is generated by glBufferData if the reserved buffer object name 0 is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store with the specified size. 
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
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding 
		/// targetsin the following table: 
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
		/// glBufferSubData and glNamedBufferSubData redefine some or all of the data store for the specified buffer object. Data 
		/// startingat byte offset offset and extending for size bytes is copied to the data store from the memory pointed to by 
		/// data.offset and size must define a range lying entirely within the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferSubData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the specified buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_OPERATION is generated if the value of the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE 
		///   andthe value of GL_BUFFER_STORAGE_FLAGS for the buffer object does not have the GL_DYNAMIC_STORAGE_BIT bit set. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void BufferSubData(int target, IntPtr offset, UInt32 size, IntPtr data)
		{
			if        (Delegates.pglBufferSubData != null) {
				Delegates.pglBufferSubData(target, offset, size, data);
				CallLog("glBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			} else if (Delegates.pglBufferSubDataARB != null) {
				Delegates.pglBufferSubDataARB(target, offset, size, data);
				CallLog("glBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			} else
				throw new NotImplementedException("glBufferSubData (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// updates a subset of a buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glBufferSubData, which must be one of the buffer binding 
		/// targetsin the following table: 
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
		/// glBufferSubData and glNamedBufferSubData redefine some or all of the data store for the specified buffer object. Data 
		/// startingat byte offset offset and extending for size bytes is copied to the data store from the memory pointed to by 
		/// data.offset and size must define a range lying entirely within the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glBufferSubData if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the specified buffer object. 
		/// - GL_INVALID_OPERATION is generated if any part of the specified range of the buffer object is mapped with 
		///   glMapBufferRangeor glMapBuffer, unless it was mapped with the GL_MAP_PERSISTENT_BIT bit set in the 
		///   glMapBufferRangeaccessflags. 
		/// - GL_INVALID_OPERATION is generated if the value of the GL_BUFFER_IMMUTABLE_STORAGE flag of the buffer object is GL_TRUE 
		///   andthe value of GL_BUFFER_STORAGE_FLAGS for the buffer object does not have the GL_DYNAMIC_STORAGE_BIT bit set. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferSubData 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void BufferSubData(int target, IntPtr offset, UInt32 size, Object data)
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
		/// targetsin the following table: 
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
		/// glGetBufferSubData and glGetNamedBufferSubData return some or all of the data contents of the data store of the 
		/// specifiedbuffer object. Data starting at byte offset offset and extending for size bytes is copied from the buffer 
		/// object'sdata store to the memory pointed to by data. An error is thrown if the buffer object is currently mapped, or if 
		/// offsetand size together define a range beyond the bounds of the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferSubData if target is not one of the generic buffer binding targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferSubData if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferSubData if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or size is negative, or if $offset + size$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is mapped with glMapBufferRange or glMapBuffer, unless it was 
		///   mappedwith the GL_MAP_PERSISTENT_BIT bit set in the glMapBufferRangeaccess flags. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void GetBufferSubData(int target, IntPtr offset, UInt32 size, IntPtr data)
		{
			if        (Delegates.pglGetBufferSubData != null) {
				Delegates.pglGetBufferSubData(target, offset, size, data);
				CallLog("glGetBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			} else if (Delegates.pglGetBufferSubDataARB != null) {
				Delegates.pglGetBufferSubDataARB(target, offset, size, data);
				CallLog("glGetBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			} else
				throw new NotImplementedException("glGetBufferSubData (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// map all of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glMapBuffer, which must be one of the buffer binding 
		/// targetsin the following table: 
		/// </param>
		/// <param name="access">
		/// Specifies the access policy for glMapBuffer and glMapNamedBuffer, indicating whether it will be possible to read from, 
		/// writeto, or both read from and write to the buffer object's mapped data store. The symbolic constant must be 
		/// GL_READ_ONLY,GL_WRITE_ONLY, or GL_READ_WRITE. 
		/// </param>
		/// <remarks>
		/// glMapBuffer and glMapNamedBuffer map the entire data store of a specified buffer object into the client's address space. 
		/// Thedata can then be directly read and/or written relative to the returned pointer, depending on the specified access 
		/// policy.
		/// A pointer to the beginning of the mapped range is returned once all pending operations on that buffer object have 
		/// completed,and may be used to modify and/or query the corresponding range of the data store according to the value of 
		/// access:GL_READ_ONLY indicates that the returned pointer may be used to read buffer object data. GL_WRITE_ONLY indicates 
		/// thatthe returned pointer may be used to modify buffer object data. GL_READ_WRITE indicates that the returned pointer may 
		/// beused to read and to modify buffer object data. 
		/// If an error is generated, a NULL pointer is returned. 
		/// If no error occurs, the returned pointer will reflect an allocation aligned to the value of GL_MIN_MAP_BUFFER_ALIGNMENT 
		/// basicmachine units. 
		/// The returned pointer values may not be passed as parameter values to GL commands. For example, they may not be used to 
		/// specifyarray pointers, or to specify or query pixel or texture image data; such actions produce undefined results, 
		/// althoughimplementations may not check for such behavior for performance reasons. 
		/// No GL error is generated if the returned pointer is accessed in a way inconsistent with access (e.g. used to read from a 
		/// mappingmade with accessGL_WRITE_ONLY or write to a mapping made with accessGL_READ_ONLY), but the result is undefined 
		/// andsystem errors (possibly including program termination) may occur. 
		/// Mappings to the data stores of buffer objects may have nonstandard performance characteristics. For example, such 
		/// mappingsmay be marked as uncacheable regions of memory, and in such cases reading from them may be very slow. To ensure 
		/// optimalperformance, the client should use the mapping in a fashion consistent with the values of GL_BUFFER_USAGE for the 
		/// bufferobject and of access. Using a mapping in a fashion inconsistent with these values is liable to be multiple orders 
		/// ofmagnitude slower than using normal memory. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glMapBuffer if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glMapBuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glMapNamedBuffer if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if access is not GL_READ_ONLY, GL_WRITE_ONLY, or GL_READ_WRITE. 
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to map the buffer object's data store. This may occur for a variety of 
		///   system-specificreasons, such as the absence of sufficient remaining virtual memory. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is in a mapped state. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferPointerv with argument GL_BUFFER_MAP_POINTER 
		/// - glGetBufferParameter with argument GL_BUFFER_MAPPED, GL_BUFFER_ACCESS, or GL_BUFFER_USAGE 
		/// - glGet with pnameGL_MIN_MAP_BUFFER_ALIGNMENT. The value must be a power of two that is at least 64. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static IntPtr MapBuffer(int target, int access)
		{
			IntPtr retValue;

			if        (Delegates.pglMapBuffer != null) {
				retValue = Delegates.pglMapBuffer(target, access);
				CallLog("glMapBuffer({0}, {1}) = {2}", target, access, retValue);
			} else if (Delegates.pglMapBufferARB != null) {
				retValue = Delegates.pglMapBufferARB(target, access);
				CallLog("glMapBufferARB({0}, {1}) = {2}", target, access, retValue);
			} else if (Delegates.pglMapBufferOES != null) {
				retValue = Delegates.pglMapBufferOES(target, access);
				CallLog("glMapBufferOES({0}, {1}) = {2}", target, access, retValue);
			} else
				throw new NotImplementedException("glMapBuffer (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// release the mapping of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glUnmapBuffer, which must be one of the buffer binding 
		/// targetsin the following table: 
		/// </param>
		/// <remarks>
		/// glUnmapBuffer and glUnmapNamedBuffer unmap (release) any mapping of a specified buffer object into the client's address 
		/// space(see glMapBufferRange and glMapBuffer). 
		/// If a mapping is not unmapped before the corresponding buffer object's data store is used by the GL, an error will be 
		/// generatedby any GL command that attempts to dereference the buffer object's data store, unless the buffer was 
		/// successfullymapped with GL_MAP_PERSISTENT_BIT (see glMapBufferRange). When a data store is unmapped, the mapped pointer 
		/// becomesinvalid. 
		/// glUnmapBuffer returns GL_TRUE unless the data store contents have become corrupt during the time the data store was 
		/// mapped.This can occur for system-specific reasons that affect the availability of graphics memory, such as screen mode 
		/// changes.In such situations, GL_FALSE is returned and the data store contents are undefined. An application must detect 
		/// thisrare condition and reinitialize the data store. 
		/// A buffer object's mapped data store is automatically unmapped when the buffer object is deleted or its data store is 
		/// recreatedwith glBufferData). 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glUnmapBuffer if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glUnmapBuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glUnmapNamedBuffer if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is not in a mapped state. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetBufferParameter with argument GL_BUFFER_MAPPED. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		public static bool UnmapBuffer(int target)
		{
			bool retValue;

			if        (Delegates.pglUnmapBuffer != null) {
				retValue = Delegates.pglUnmapBuffer(target);
				CallLog("glUnmapBuffer({0}) = {1}", target, retValue);
			} else if (Delegates.pglUnmapBufferARB != null) {
				retValue = Delegates.pglUnmapBufferARB(target);
				CallLog("glUnmapBufferARB({0}) = {1}", target, retValue);
			} else if (Delegates.pglUnmapBufferOES != null) {
				retValue = Delegates.pglUnmapBufferOES(target);
				CallLog("glUnmapBufferOES({0}) = {1}", target, retValue);
			} else
				throw new NotImplementedException("glUnmapBuffer (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return parameters of a buffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferParameteriv and glGetBufferParameteri64v. Must 
		/// beone of the buffer binding targets in the following table: 
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// These functions return in data a selected parameter of the specified buffer object. 
		/// pname names a specific buffer object parameter, as follows: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetBufferParameter* if target is not one of the accepted buffer targets. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferParameter* if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferParameter* if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the buffer object parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void GetBufferParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetBufferParameteriv != null) {
						Delegates.pglGetBufferParameteriv(target, pname, p_params);
						CallLog("glGetBufferParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetBufferParameterivARB != null) {
						Delegates.pglGetBufferParameterivARB(target, pname, p_params);
						CallLog("glGetBufferParameterivARB({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetBufferParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the pointer to a mapped buffer object's data store
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glGetBufferPointerv, which must be one of the buffer 
		/// bindingtargets in the following table: 
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be GL_BUFFER_MAP_POINTER. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetBufferPointerv and glGetNamedBufferPointerv return the buffer pointer pname, which must be GL_BUFFER_MAP_POINTER. 
		/// Thesingle buffer map pointer is returned in params. A NULL pointer is returned if the buffer object's data store is not 
		/// currentlymapped; or if the requesting context did not map the buffer object's data store, and the implementation is 
		/// unableto support mappings on multiple clients. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if by glGetBufferPointerv if target is not one of the accepted buffer targets, or if pname 
		///   isnot GL_BUFFER_MAP_POINTER. 
		/// - GL_INVALID_OPERATION is generated by glGetBufferPointerv if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedBufferPointerv if buffer is not the name of an existing buffer object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.MapBuffer"/>
		public static void GetBufferPointer(int target, int pname, IntPtr @params)
		{
			if        (Delegates.pglGetBufferPointerv != null) {
				Delegates.pglGetBufferPointerv(target, pname, @params);
				CallLog("glGetBufferPointerv({0}, {1}, {2})", target, pname, @params);
			} else if (Delegates.pglGetBufferPointervARB != null) {
				Delegates.pglGetBufferPointervARB(target, pname, @params);
				CallLog("glGetBufferPointervARB({0}, {1}, {2})", target, pname, @params);
			} else if (Delegates.pglGetBufferPointervOES != null) {
				Delegates.pglGetBufferPointervOES(target, pname, @params);
				CallLog("glGetBufferPointervOES({0}, {1}, {2})", target, pname, @params);
			} else
				throw new NotImplementedException("glGetBufferPointerv (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
