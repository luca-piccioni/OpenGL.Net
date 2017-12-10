
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glGenQueriesEXT: Binding for glGenQueriesEXT.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GenQueriesEXT(uint[] ids)
		{
			unsafe {
				fixed (uint* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesEXT != null, "pglGenQueriesEXT not implemented");
					Delegates.pglGenQueriesEXT(ids.Length, p_ids);
					LogCommand("glGenQueriesEXT", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenQueriesEXT: Binding for glGenQueriesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static uint GenQueryEXT()
		{
			uint retValue;
			unsafe {
				Delegates.pglGenQueriesEXT(1, &retValue);
				LogCommand("glGenQueriesEXT", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteQueriesEXT: Binding for glDeleteQueriesEXT.
		/// </summary>
		/// <param name="ids">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void DeleteQueriesEXT(params uint[] ids)
		{
			unsafe {
				fixed (uint* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesEXT != null, "pglDeleteQueriesEXT not implemented");
					Delegates.pglDeleteQueriesEXT(ids.Length, p_ids);
					LogCommand("glDeleteQueriesEXT", null, ids.Length, ids					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsQueryEXT: Binding for glIsQueryEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static bool IsQueryEXT(uint id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQueryEXT != null, "pglIsQueryEXT not implemented");
			retValue = Delegates.pglIsQueryEXT(id);
			LogCommand("glIsQueryEXT", retValue, id			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glBeginQueryEXT: Binding for glBeginQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void BeginQueryEXT(QueryTarget target, uint id)
		{
			Debug.Assert(Delegates.pglBeginQueryEXT != null, "pglBeginQueryEXT not implemented");
			Delegates.pglBeginQueryEXT((int)target, id);
			LogCommand("glBeginQueryEXT", null, target, id			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glEndQueryEXT: Binding for glEndQueryEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void EndQueryEXT(QueryTarget target)
		{
			Debug.Assert(Delegates.pglEndQueryEXT != null, "pglEndQueryEXT not implemented");
			Delegates.pglEndQueryEXT((int)target);
			LogCommand("glEndQueryEXT", null, target			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetQueryivEXT: Binding for glGetQueryivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryEXT(QueryTarget target, QueryParameterName pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT((int)target, (int)pname, p_params);
					LogCommand("glGetQueryivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetQueryivEXT: Binding for glGetQueryivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:QueryTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryEXT(QueryTarget target, QueryParameterName pname, out int @params)
		{
			unsafe {
				fixed (int* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryivEXT != null, "pglGetQueryivEXT not implemented");
					Delegates.pglGetQueryivEXT((int)target, (int)pname, p_params);
					LogCommand("glGetQueryivEXT", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetQueryObjectuivEXT: Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryObjectuivEXT(uint id, QueryObjectParameterName pname, [Out] uint[] @params)
		{
			unsafe {
				fixed (uint* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, (int)pname, p_params);
					LogCommand("glGetQueryObjectuivEXT", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetQueryObjectuivEXT: Binding for glGetQueryObjectuivEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:QueryObjectParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		public static void GetQueryObjectuivEXT(uint id, QueryObjectParameterName pname, out uint @params)
		{
			unsafe {
				fixed (uint* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivEXT != null, "pglGetQueryObjectuivEXT not implemented");
					Delegates.pglGetQueryObjectuivEXT(id, (int)pname, p_params);
					LogCommand("glGetQueryObjectuivEXT", null, id, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenQueriesEXT(int n, uint* ids);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGenQueriesEXT pglGenQueriesEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteQueriesEXT(int n, uint* ids);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glDeleteQueriesEXT pglDeleteQueriesEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsQueryEXT(uint id);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glIsQueryEXT pglIsQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glBeginQueryEXT(int target, uint id);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glBeginQueryEXT pglBeginQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glEndQueryEXT(int target);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glEndQueryEXT pglEndQueryEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetQueryivEXT(int target, int pname, int* @params);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGetQueryivEXT pglGetQueryivEXT;

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetQueryObjectuivEXT(uint id, int pname, uint* @params);

			[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
			[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
			[ThreadStatic]
			internal static glGetQueryObjectuivEXT pglGetQueryObjectuivEXT;

		}
	}

}
