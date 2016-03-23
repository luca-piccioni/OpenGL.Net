
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
		/// Binding for glDepthRangeArrayfvNV.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void DepthRangeArrayNV(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayfvNV != null, "pglDepthRangeArrayfvNV not implemented");
					Delegates.pglDepthRangeArrayfvNV(first, count, p_v);
					LogFunction("glDepthRangeArrayfvNV({0}, {1}, {2})", first, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthRangeIndexedfNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void DepthRangeIndexedNV(UInt32 index, float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexedfNV != null, "pglDepthRangeIndexedfNV not implemented");
			Delegates.pglDepthRangeIndexedfNV(index, n, f);
			LogFunction("glDepthRangeIndexedfNV({0}, {1}, {2})", index, n, f);
			DebugCheckErrors(null);
		}

	}

}
