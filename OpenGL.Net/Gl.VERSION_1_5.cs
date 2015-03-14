
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
		public const int BUFFER_SIZE = 0x8764;

		/// <summary>
		/// Value of GL_BUFFER_USAGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		public const int CURRENT_QUERY = 0x8865;

		/// <summary>
		/// Value of GL_QUERY_RESULT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_RESULT = 0x8866;

		/// <summary>
		/// Value of GL_QUERY_RESULT_AVAILABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int QUERY_RESULT_AVAILABLE = 0x8867;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ARRAY_BUFFER = 0x8892;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ELEMENT_ARRAY_BUFFER = 0x8893;

		/// <summary>
		/// Value of GL_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ARRAY_BUFFER_BINDING = 0x8894;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int ELEMENT_ARRAY_BUFFER_BINDING = 0x8895;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F;

		/// <summary>
		/// Value of GL_READ_ONLY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int READ_ONLY = 0x88B8;

		/// <summary>
		/// Value of GL_WRITE_ONLY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_NV_shader_buffer_store")]
		public const int WRITE_ONLY = 0x88B9;

		/// <summary>
		/// Value of GL_READ_WRITE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		public const int BUFFER_MAPPED = 0x88BC;

		/// <summary>
		/// Value of GL_BUFFER_MAP_POINTER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int BUFFER_MAP_POINTER = 0x88BD;

		/// <summary>
		/// Value of GL_STREAM_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_DRAW = 0x88E0;

		/// <summary>
		/// Value of GL_STREAM_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_READ = 0x88E1;

		/// <summary>
		/// Value of GL_STREAM_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STREAM_COPY = 0x88E2;

		/// <summary>
		/// Value of GL_STATIC_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_DRAW = 0x88E4;

		/// <summary>
		/// Value of GL_STATIC_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_READ = 0x88E5;

		/// <summary>
		/// Value of GL_STATIC_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int STATIC_COPY = 0x88E6;

		/// <summary>
		/// Value of GL_DYNAMIC_DRAW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int DYNAMIC_DRAW = 0x88E8;

		/// <summary>
		/// Value of GL_DYNAMIC_READ symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		public const int DYNAMIC_READ = 0x88E9;

		/// <summary>
		/// Value of GL_DYNAMIC_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RequiredByFeature("GL_ARB_blend_func_extended")]
		public const int SRC1_ALPHA = 0x8589;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int VERTEX_ARRAY_BUFFER_BINDING = 0x8896;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_ARRAY_BUFFER_BINDING = 0x8897;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_BUFFER_BINDING symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GenQueries(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					if        (Delegates.pglGenQueries != null) {
						Delegates.pglGenQueries((Int32)ids.Length, p_ids);
						CallLog("glGenQueries({0}, {1})", ids.Length, ids);
					} else if (Delegates.pglGenQueriesARB != null) {
						Delegates.pglGenQueriesARB((Int32)ids.Length, p_ids);
						CallLog("glGenQueriesARB({0}, {1})", ids.Length, ids);
					} else
						throw new NotImplementedException("glGenQueries (and other aliases) are not implemented");
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
					if        (Delegates.pglDeleteQueries != null) {
						Delegates.pglDeleteQueries((Int32)ids.Length, p_ids);
						CallLog("glDeleteQueries({0}, {1})", ids.Length, ids);
					} else if (Delegates.pglDeleteQueriesARB != null) {
						Delegates.pglDeleteQueriesARB((Int32)ids.Length, p_ids);
						CallLog("glDeleteQueriesARB({0}, {1})", ids.Length, ids);
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
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		/// <param name="id">
		/// Specifies the name of a query object.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
		/// GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// GL_ANY_SAMPLES_PASSED_CONSERVATIVEGL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or 
		/// GL_TIMESTAMP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or 
		/// GL_QUERY_COUNTER_BITS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RequiredByFeature("GL_VERSION_1_5")]
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
		[RequiredByFeature("GL_VERSION_1_5")]
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
		/// following table:
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of a buffer object.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void BindBuffer(BufferTargetARB target, UInt32 buffer)
		{
			if        (Delegates.pglBindBuffer != null) {
				Delegates.pglBindBuffer((int)target, buffer);
				CallLog("glBindBuffer({0}, {1})", target, buffer);
			} else if (Delegates.pglBindBufferARB != null) {
				Delegates.pglBindBufferARB((int)target, buffer);
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void DeleteBuffers(params UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					if        (Delegates.pglDeleteBuffers != null) {
						Delegates.pglDeleteBuffers((Int32)buffers.Length, p_buffers);
						CallLog("glDeleteBuffers({0}, {1})", buffers.Length, buffers);
					} else if (Delegates.pglDeleteBuffersARB != null) {
						Delegates.pglDeleteBuffersARB((Int32)buffers.Length, p_buffers);
						CallLog("glDeleteBuffersARB({0}, {1})", buffers.Length, buffers);
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
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GenBuffers(UInt32[] buffers)
		{
			unsafe {
				fixed (UInt32* p_buffers = buffers)
				{
					if        (Delegates.pglGenBuffers != null) {
						Delegates.pglGenBuffers((Int32)buffers.Length, p_buffers);
						CallLog("glGenBuffers({0}, {1})", buffers.Length, buffers);
					} else if (Delegates.pglGenBuffersARB != null) {
						Delegates.pglGenBuffersARB((Int32)buffers.Length, p_buffers);
						CallLog("glGenBuffersARB({0}, {1})", buffers.Length, buffers);
					} else
						throw new NotImplementedException("glGenBuffers (and other aliases) are not implemented");
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
			if        (Delegates.pglBufferData != null) {
				Delegates.pglBufferData(target, size, data, usage);
				CallLog("glBufferData({0}, {1}, {2}, {3})", target, size, data, usage);
			} else if (Delegates.pglBufferDataARB != null) {
				Delegates.pglBufferDataARB(target, size, data, usage);
				CallLog("glBufferDataARB({0}, {1}, {2}, {3})", target, size, data, usage);
			} else
				throw new NotImplementedException("glBufferData (and other aliases) are not implemented");
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
			if        (Delegates.pglBufferData != null) {
				Delegates.pglBufferData((int)target, size, data, (int)usage);
				CallLog("glBufferData({0}, {1}, {2}, {3})", target, size, data, usage);
			} else if (Delegates.pglBufferDataARB != null) {
				Delegates.pglBufferDataARB((int)target, size, data, (int)usage);
				CallLog("glBufferDataARB({0}, {1}, {2}, {3})", target, size, data, usage);
			} else
				throw new NotImplementedException("glBufferData (and other aliases) are not implemented");
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
			if        (Delegates.pglBufferSubData != null) {
				Delegates.pglBufferSubData((int)target, offset, size, data);
				CallLog("glBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			} else if (Delegates.pglBufferSubDataARB != null) {
				Delegates.pglBufferSubDataARB((int)target, offset, size, data);
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
			if        (Delegates.pglGetBufferSubData != null) {
				Delegates.pglGetBufferSubData((int)target, offset, size, data);
				CallLog("glGetBufferSubData({0}, {1}, {2}, {3})", target, offset, size, data);
			} else if (Delegates.pglGetBufferSubDataARB != null) {
				Delegates.pglGetBufferSubDataARB((int)target, offset, size, data);
				CallLog("glGetBufferSubDataARB({0}, {1}, {2}, {3})", target, offset, size, data);
			} else
				throw new NotImplementedException("glGetBufferSubData (and other aliases) are not implemented");
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

			if        (Delegates.pglMapBuffer != null) {
				retValue = Delegates.pglMapBuffer((int)target, (int)access);
				CallLog("glMapBuffer({0}, {1}) = {2}", target, access, retValue);
			} else if (Delegates.pglMapBufferARB != null) {
				retValue = Delegates.pglMapBufferARB((int)target, (int)access);
				CallLog("glMapBufferARB({0}, {1}) = {2}", target, access, retValue);
			} else if (Delegates.pglMapBufferOES != null) {
				retValue = Delegates.pglMapBufferOES((int)target, (int)access);
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
		/// targets in the following table:
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static bool UnmapBuffer(BufferTargetARB target)
		{
			bool retValue;

			if        (Delegates.pglUnmapBuffer != null) {
				retValue = Delegates.pglUnmapBuffer((int)target);
				CallLog("glUnmapBuffer({0}) = {1}", target, retValue);
			} else if (Delegates.pglUnmapBufferARB != null) {
				retValue = Delegates.pglUnmapBufferARB((int)target);
				CallLog("glUnmapBufferARB({0}) = {1}", target, retValue);
			} else if (Delegates.pglUnmapBufferOES != null) {
				retValue = Delegates.pglUnmapBufferOES((int)target);
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
					if        (Delegates.pglGetBufferParameteriv != null) {
						Delegates.pglGetBufferParameteriv((int)target, pname, p_params);
						CallLog("glGetBufferParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetBufferParameterivARB != null) {
						Delegates.pglGetBufferParameterivARB((int)target, pname, p_params);
						CallLog("glGetBufferParameterivARB({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetBufferParameteriv (and other aliases) are not implemented");
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
					if        (Delegates.pglGetBufferParameteriv != null) {
						Delegates.pglGetBufferParameteriv((int)target, pname, p_params);
						CallLog("glGetBufferParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetBufferParameterivARB != null) {
						Delegates.pglGetBufferParameterivARB((int)target, pname, p_params);
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
		/// binding targets in the following table:
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the pointer to be returned. Must be GL_BUFFER_MAP_POINTER.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_5")]
		public static void GetBufferPointer(BufferTargetARB target, int pname, out IntPtr @params)
		{
			unsafe {
				fixed (IntPtr* p_params = &@params)
				{
					if        (Delegates.pglGetBufferPointerv != null) {
						Delegates.pglGetBufferPointerv((int)target, pname, p_params);
						CallLog("glGetBufferPointerv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetBufferPointervARB != null) {
						Delegates.pglGetBufferPointervARB((int)target, pname, p_params);
						CallLog("glGetBufferPointervARB({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetBufferPointervOES != null) {
						Delegates.pglGetBufferPointervOES((int)target, pname, p_params);
						CallLog("glGetBufferPointervOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetBufferPointerv (and other aliases) are not implemented");
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
		/// A <see cref="T:Object"/>.
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
