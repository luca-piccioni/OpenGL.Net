
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
		/// Value of GL_QUERY_COUNTER_BITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int QUERY_COUNTER_BITS_ARB = 0x8864;

		/// <summary>
		/// Value of GL_CURRENT_QUERY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int CURRENT_QUERY_ARB = 0x8865;

		/// <summary>
		/// Value of GL_QUERY_RESULT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int QUERY_RESULT_ARB = 0x8866;

		/// <summary>
		/// Value of GL_QUERY_RESULT_AVAILABLE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int QUERY_RESULT_AVAILABLE_ARB = 0x8867;

		/// <summary>
		/// Value of GL_SAMPLES_PASSED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public const int SAMPLES_PASSED_ARB = 0x8914;

		/// <summary>
		/// Binding for glGenQueriesARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GenQueriesARB(Int32 n, UInt32[] ids)
		{
			Debug.Assert(ids.Length >= n);
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesARB != null, "pglGenQueriesARB not implemented");
					Delegates.pglGenQueriesARB(n, p_ids);
					CallLog("glGenQueriesARB({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenQueriesARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GenQueriesARB(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglGenQueriesARB != null, "pglGenQueriesARB not implemented");
					Delegates.pglGenQueriesARB((Int32)ids.Length, p_ids);
					CallLog("glGenQueriesARB({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenQueriesARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static UInt32 GenQueriesARB()
		{
			UInt32[] retValue = new UInt32[1];
			GenQueriesARB(1, retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeleteQueriesARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void DeleteQueriesARB(Int32 n, UInt32[] ids)
		{
			Debug.Assert(ids.Length >= n);
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesARB != null, "pglDeleteQueriesARB not implemented");
					Delegates.pglDeleteQueriesARB(n, p_ids);
					CallLog("glDeleteQueriesARB({0}, {1})", n, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteQueriesARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ids">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void DeleteQueriesARB(UInt32[] ids)
		{
			unsafe {
				fixed (UInt32* p_ids = ids)
				{
					Debug.Assert(Delegates.pglDeleteQueriesARB != null, "pglDeleteQueriesARB not implemented");
					Delegates.pglDeleteQueriesARB((Int32)ids.Length, p_ids);
					CallLog("glDeleteQueriesARB({0}, {1})", ids.Length, ids);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsQueryARB.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static bool IsQueryARB(UInt32 id)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsQueryARB != null, "pglIsQueryARB not implemented");
			retValue = Delegates.pglIsQueryARB(id);
			CallLog("glIsQueryARB({0}) = {1}", id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBeginQueryARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void BeginQueryARB(int target, UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginQueryARB != null, "pglBeginQueryARB not implemented");
			Delegates.pglBeginQueryARB(target, id);
			CallLog("glBeginQueryARB({0}, {1})", target, id);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndQueryARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void EndQueryARB(int target)
		{
			Debug.Assert(Delegates.pglEndQueryARB != null, "pglEndQueryARB not implemented");
			Delegates.pglEndQueryARB(target);
			CallLog("glEndQueryARB({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryivARB.
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
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQueryARB(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryivARB != null, "pglGetQueryivARB not implemented");
					Delegates.pglGetQueryivARB(target, pname, p_params);
					CallLog("glGetQueryivARB({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectivARB.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQueryObjectARB(UInt32 id, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectivARB != null, "pglGetQueryObjectivARB not implemented");
					Delegates.pglGetQueryObjectivARB(id, pname, p_params);
					CallLog("glGetQueryObjectivARB({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectuivARB.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_occlusion_query")]
		public static void GetQueryObjectuivARB(UInt32 id, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectuivARB != null, "pglGetQueryObjectuivARB not implemented");
					Delegates.pglGetQueryObjectuivARB(id, pname, p_params);
					CallLog("glGetQueryObjectuivARB({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
