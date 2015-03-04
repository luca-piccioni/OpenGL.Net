
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
		/// Binding for glWindowPos2dMESA.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(double x, double y)
		{
			Debug.Assert(Delegates.pglWindowPos2dMESA != null, "pglWindowPos2dMESA not implemented");
			Delegates.pglWindowPos2dMESA(x, y);
			CallLog("glWindowPos2dMESA({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2dvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2dvMESA != null, "pglWindowPos2dvMESA not implemented");
					Delegates.pglWindowPos2dvMESA(p_v);
					CallLog("glWindowPos2dvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2fMESA.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(float x, float y)
		{
			Debug.Assert(Delegates.pglWindowPos2fMESA != null, "pglWindowPos2fMESA not implemented");
			Delegates.pglWindowPos2fMESA(x, y);
			CallLog("glWindowPos2fMESA({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2fvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2fvMESA != null, "pglWindowPos2fvMESA not implemented");
					Delegates.pglWindowPos2fvMESA(p_v);
					CallLog("glWindowPos2fvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2iMESA.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglWindowPos2iMESA != null, "pglWindowPos2iMESA not implemented");
			Delegates.pglWindowPos2iMESA(x, y);
			CallLog("glWindowPos2iMESA({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2ivMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2ivMESA != null, "pglWindowPos2ivMESA not implemented");
					Delegates.pglWindowPos2ivMESA(p_v);
					CallLog("glWindowPos2ivMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2sMESA.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:Int16"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglWindowPos2sMESA != null, "pglWindowPos2sMESA not implemented");
			Delegates.pglWindowPos2sMESA(x, y);
			CallLog("glWindowPos2sMESA({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos2svMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos2MESA(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2svMESA != null, "pglWindowPos2svMESA not implemented");
					Delegates.pglWindowPos2svMESA(p_v);
					CallLog("glWindowPos2svMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3dMESA.
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglWindowPos3dMESA != null, "pglWindowPos3dMESA not implemented");
			Delegates.pglWindowPos3dMESA(x, y, z);
			CallLog("glWindowPos3dMESA({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3dvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3dvMESA != null, "pglWindowPos3dvMESA not implemented");
					Delegates.pglWindowPos3dvMESA(p_v);
					CallLog("glWindowPos3dvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3fMESA.
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglWindowPos3fMESA != null, "pglWindowPos3fMESA not implemented");
			Delegates.pglWindowPos3fMESA(x, y, z);
			CallLog("glWindowPos3fMESA({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3fvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3fvMESA != null, "pglWindowPos3fvMESA not implemented");
					Delegates.pglWindowPos3fvMESA(p_v);
					CallLog("glWindowPos3fvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3iMESA.
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglWindowPos3iMESA != null, "pglWindowPos3iMESA not implemented");
			Delegates.pglWindowPos3iMESA(x, y, z);
			CallLog("glWindowPos3iMESA({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3ivMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3ivMESA != null, "pglWindowPos3ivMESA not implemented");
					Delegates.pglWindowPos3ivMESA(p_v);
					CallLog("glWindowPos3ivMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3sMESA.
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
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglWindowPos3sMESA != null, "pglWindowPos3sMESA not implemented");
			Delegates.pglWindowPos3sMESA(x, y, z);
			CallLog("glWindowPos3sMESA({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos3svMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos3MESA(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3svMESA != null, "pglWindowPos3svMESA not implemented");
					Delegates.pglWindowPos3svMESA(p_v);
					CallLog("glWindowPos3svMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4dMESA.
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
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglWindowPos4dMESA != null, "pglWindowPos4dMESA not implemented");
			Delegates.pglWindowPos4dMESA(x, y, z, w);
			CallLog("glWindowPos4dMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4dvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4dvMESA != null, "pglWindowPos4dvMESA not implemented");
					Delegates.pglWindowPos4dvMESA(p_v);
					CallLog("glWindowPos4dvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4fMESA.
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
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglWindowPos4fMESA != null, "pglWindowPos4fMESA not implemented");
			Delegates.pglWindowPos4fMESA(x, y, z, w);
			CallLog("glWindowPos4fMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4fvMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4fvMESA != null, "pglWindowPos4fvMESA not implemented");
					Delegates.pglWindowPos4fvMESA(p_v);
					CallLog("glWindowPos4fvMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4iMESA.
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
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglWindowPos4iMESA != null, "pglWindowPos4iMESA not implemented");
			Delegates.pglWindowPos4iMESA(x, y, z, w);
			CallLog("glWindowPos4iMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4ivMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4ivMESA != null, "pglWindowPos4ivMESA not implemented");
					Delegates.pglWindowPos4ivMESA(p_v);
					CallLog("glWindowPos4ivMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4sMESA.
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
		/// <param name="w">
		/// A <see cref="T:Int16"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglWindowPos4sMESA != null, "pglWindowPos4sMESA not implemented");
			Delegates.pglWindowPos4sMESA(x, y, z, w);
			CallLog("glWindowPos4sMESA({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glWindowPos4svMESA.
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_MESA_window_pos")]
		public static void WindowPos4MESA(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos4svMESA != null, "pglWindowPos4svMESA not implemented");
					Delegates.pglWindowPos4svMESA(p_v);
					CallLog("glWindowPos4svMESA({0})", v);
				}
			}
			DebugCheckErrors();
		}

	}

}
