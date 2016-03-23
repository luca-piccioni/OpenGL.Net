
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
		/// Value of GL_LINEAR_SHARPEN_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_SGIS = 0x80AD;

		/// <summary>
		/// Value of GL_LINEAR_SHARPEN_ALPHA_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE;

		/// <summary>
		/// Value of GL_LINEAR_SHARPEN_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int LINEAR_SHARPEN_COLOR_SGIS = 0x80AF;

		/// <summary>
		/// Value of GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public const int SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0;

		/// <summary>
		/// Binding for glSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void SharpenTexFuncSGIS(TextureTarget target, Int32 n, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglSharpenTexFuncSGIS != null, "pglSharpenTexFuncSGIS not implemented");
					Delegates.pglSharpenTexFuncSGIS((Int32)target, n, p_points);
					LogFunction("glSharpenTexFuncSGIS({0}, {1}, {2})", target, n, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetSharpenTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		public static void GetSharpenTexFuncSGIS(TextureTarget target, [Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetSharpenTexFuncSGIS != null, "pglGetSharpenTexFuncSGIS not implemented");
					Delegates.pglGetSharpenTexFuncSGIS((Int32)target, p_points);
					LogFunction("glGetSharpenTexFuncSGIS({0}, {1})", target, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
