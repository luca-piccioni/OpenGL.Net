
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
		/// Value of GL_LIST_PRIORITY_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_list_priority")]
		public const int LIST_PRIORITY_SGIX = 0x8182;

		/// <summary>
		/// Binding for glGetListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetListParameterSGIX(UInt32 list, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterfvSGIX != null, "pglGetListParameterfvSGIX not implemented");
					Delegates.pglGetListParameterfvSGIX(list, pname, p_params);
					CallLog("glGetListParameterfvSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterfvSGIX != null, "pglGetListParameterfvSGIX not implemented");
					Delegates.pglGetListParameterfvSGIX(list, (int)pname, p_params);
					CallLog("glGetListParameterfvSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetListParameterSGIX(UInt32 list, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterivSGIX != null, "pglGetListParameterivSGIX not implemented");
					Delegates.pglGetListParameterivSGIX(list, pname, p_params);
					CallLog("glGetListParameterivSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void GetListParameterSGIX(UInt32 list, ListParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetListParameterivSGIX != null, "pglGetListParameterivSGIX not implemented");
					Delegates.pglGetListParameterivSGIX(list, (int)pname, p_params);
					CallLog("glGetListParameterivSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterfSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, int pname, float param)
		{
			Debug.Assert(Delegates.pglListParameterfSGIX != null, "pglListParameterfSGIX not implemented");
			Delegates.pglListParameterfSGIX(list, pname, param);
			CallLog("glListParameterfSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterfSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglListParameterfSGIX != null, "pglListParameterfSGIX not implemented");
			Delegates.pglListParameterfSGIX(list, (int)pname, param);
			CallLog("glListParameterfSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterfvSGIX != null, "pglListParameterfvSGIX not implemented");
					Delegates.pglListParameterfvSGIX(list, pname, p_params);
					CallLog("glListParameterfvSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterfvSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterfvSGIX != null, "pglListParameterfvSGIX not implemented");
					Delegates.pglListParameterfvSGIX(list, (int)pname, p_params);
					CallLog("glListParameterfvSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameteriSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglListParameteriSGIX != null, "pglListParameteriSGIX not implemented");
			Delegates.pglListParameteriSGIX(list, pname, param);
			CallLog("glListParameteriSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameteriSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglListParameteriSGIX != null, "pglListParameteriSGIX not implemented");
			Delegates.pglListParameteriSGIX(list, (int)pname, param);
			CallLog("glListParameteriSGIX({0}, {1}, {2})", list, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterivSGIX != null, "pglListParameterivSGIX not implemented");
					Delegates.pglListParameterivSGIX(list, pname, p_params);
					CallLog("glListParameterivSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glListParameterivSGIX.
		/// </summary>
		/// <param name="list">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void ListParameterSGIX(UInt32 list, ListParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglListParameterivSGIX != null, "pglListParameterivSGIX not implemented");
					Delegates.pglListParameterivSGIX(list, (int)pname, p_params);
					CallLog("glListParameterivSGIX({0}, {1}, {2})", list, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
