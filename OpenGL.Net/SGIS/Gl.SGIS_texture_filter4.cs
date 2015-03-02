
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
		/// Value of GL_FILTER4_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int FILTER4_SGIS = 0x8146;

		/// <summary>
		/// Value of GL_TEXTURE_FILTER4_SIZE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public const int TEXTURE_FILTER4_SIZE_SGIS = 0x8147;

		/// <summary>
		/// Binding for glGetTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetTexFilterFuncSGIS(int target, int filter, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglGetTexFilterFuncSGIS != null, "pglGetTexFilterFuncSGIS not implemented");
					Delegates.pglGetTexFilterFuncSGIS(target, filter, p_weights);
					CallLog("glGetTexFilterFuncSGIS({0}, {1}, {2})", target, filter, weights);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void GetTexFilterFuncSGIS(TextureTarget target, int filter, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglGetTexFilterFuncSGIS != null, "pglGetTexFilterFuncSGIS not implemented");
					Delegates.pglGetTexFilterFuncSGIS((int)target, filter, p_weights);
					CallLog("glGetTexFilterFuncSGIS({0}, {1}, {2})", target, filter, weights);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void TexFilterFuncSGIS(int target, int filter, Int32 n, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS(target, filter, n, p_weights);
					CallLog("glTexFilterFuncSGIS({0}, {1}, {2}, {3})", target, filter, n, weights);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void TexFilterFuncSGIS(TextureTarget target, int filter, Int32 n, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((int)target, filter, n, p_weights);
					CallLog("glTexFilterFuncSGIS({0}, {1}, {2}, {3})", target, filter, n, weights);
				}
			}
			DebugCheckErrors();
		}

	}

}
