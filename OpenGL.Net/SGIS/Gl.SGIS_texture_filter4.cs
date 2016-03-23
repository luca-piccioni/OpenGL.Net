
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
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void GetTexFilterFuncSGIS(TextureTarget target, Int32 filter, [Out] float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglGetTexFilterFuncSGIS != null, "pglGetTexFilterFuncSGIS not implemented");
					Delegates.pglGetTexFilterFuncSGIS((Int32)target, filter, p_weights);
					LogFunction("glGetTexFilterFuncSGIS({0}, {1}, {2})", target, LogEnumName(filter), LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, Int32 n, float[] weights)
		{
			Debug.Assert(weights.Length >= n);
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, n, p_weights);
					LogFunction("glTexFilterFuncSGIS({0}, {1}, {2}, {3})", target, LogEnumName(filter), n, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexFilterFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="weights">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		public static void TexFilterFuncSGIS(TextureTarget target, Int32 filter, float[] weights)
		{
			unsafe {
				fixed (float* p_weights = weights)
				{
					Debug.Assert(Delegates.pglTexFilterFuncSGIS != null, "pglTexFilterFuncSGIS not implemented");
					Delegates.pglTexFilterFuncSGIS((Int32)target, filter, (Int32)weights.Length, p_weights);
					LogFunction("glTexFilterFuncSGIS({0}, {1}, {2}, {3})", target, LogEnumName(filter), weights.Length, LogValue(weights));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
