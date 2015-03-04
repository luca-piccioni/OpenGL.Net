
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
		/// Binding for glWindowPos2dARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(double x, double y)
		{
			Debug.Assert(Delegates.pglWindowPos2dARB != null, "pglWindowPos2dARB not implemented");
			Delegates.pglWindowPos2dARB(x, y);
			CallLog("glWindowPos2dARB({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2dvARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2dvARB != null, "pglWindowPos2dvARB not implemented");
					Delegates.pglWindowPos2dvARB(p_v);
					CallLog("glWindowPos2dvARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2fARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(float x, float y)
		{
			Debug.Assert(Delegates.pglWindowPos2fARB != null, "pglWindowPos2fARB not implemented");
			Delegates.pglWindowPos2fARB(x, y);
			CallLog("glWindowPos2fARB({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2fvARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2fvARB != null, "pglWindowPos2fvARB not implemented");
					Delegates.pglWindowPos2fvARB(p_v);
					CallLog("glWindowPos2fvARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2iARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglWindowPos2iARB != null, "pglWindowPos2iARB not implemented");
			Delegates.pglWindowPos2iARB(x, y);
			CallLog("glWindowPos2iARB({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2ivARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2ivARB != null, "pglWindowPos2ivARB not implemented");
					Delegates.pglWindowPos2ivARB(p_v);
					CallLog("glWindowPos2ivARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2sARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglWindowPos2sARB != null, "pglWindowPos2sARB not implemented");
			Delegates.pglWindowPos2sARB(x, y);
			CallLog("glWindowPos2sARB({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2svARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos2ARB(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2svARB != null, "pglWindowPos2svARB not implemented");
					Delegates.pglWindowPos2svARB(p_v);
					CallLog("glWindowPos2svARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3dARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglWindowPos3dARB != null, "pglWindowPos3dARB not implemented");
			Delegates.pglWindowPos3dARB(x, y, z);
			CallLog("glWindowPos3dARB({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3dvARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3dvARB != null, "pglWindowPos3dvARB not implemented");
					Delegates.pglWindowPos3dvARB(p_v);
					CallLog("glWindowPos3dvARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3fARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglWindowPos3fARB != null, "pglWindowPos3fARB not implemented");
			Delegates.pglWindowPos3fARB(x, y, z);
			CallLog("glWindowPos3fARB({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3fvARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3fvARB != null, "pglWindowPos3fvARB not implemented");
					Delegates.pglWindowPos3fvARB(p_v);
					CallLog("glWindowPos3fvARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3iARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglWindowPos3iARB != null, "pglWindowPos3iARB not implemented");
			Delegates.pglWindowPos3iARB(x, y, z);
			CallLog("glWindowPos3iARB({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3ivARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3ivARB != null, "pglWindowPos3ivARB not implemented");
					Delegates.pglWindowPos3ivARB(p_v);
					CallLog("glWindowPos3ivARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3sARB.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglWindowPos3sARB != null, "pglWindowPos3sARB not implemented");
			Delegates.pglWindowPos3sARB(x, y, z);
			CallLog("glWindowPos3sARB({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3svARB.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_window_pos")]
		public static void WindowPos3ARB(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3svARB != null, "pglWindowPos3svARB not implemented");
					Delegates.pglWindowPos3svARB(p_v);
					CallLog("glWindowPos3svARB({0})", v);
				}
			}
			DebugCheckErrors();
		}

	}

}
