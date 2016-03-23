
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
		/// Value of GL_DETAIL_TEXTURE_2D_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_2D_SGIS = 0x8095;

		/// <summary>
		/// Value of GL_DETAIL_TEXTURE_2D_BINDING_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_2D_BINDING_SGIS = 0x8096;

		/// <summary>
		/// Value of GL_LINEAR_DETAIL_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_SGIS = 0x8097;

		/// <summary>
		/// Value of GL_LINEAR_DETAIL_ALPHA_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_ALPHA_SGIS = 0x8098;

		/// <summary>
		/// Value of GL_LINEAR_DETAIL_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int LINEAR_DETAIL_COLOR_SGIS = 0x8099;

		/// <summary>
		/// Value of GL_DETAIL_TEXTURE_LEVEL_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_LEVEL_SGIS = 0x809A;

		/// <summary>
		/// Value of GL_DETAIL_TEXTURE_MODE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_MODE_SGIS = 0x809B;

		/// <summary>
		/// Value of GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public const int DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C;

		/// <summary>
		/// Binding for glDetailTexFuncSGIS.
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
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public static void DetailTexFuncSGIS(TextureTarget target, Int32 n, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglDetailTexFuncSGIS != null, "pglDetailTexFuncSGIS not implemented");
					Delegates.pglDetailTexFuncSGIS((Int32)target, n, p_points);
					LogFunction("glDetailTexFuncSGIS({0}, {1}, {2})", target, n, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetDetailTexFuncSGIS.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		public static void GetDetailTexFuncSGIS(TextureTarget target, [Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetDetailTexFuncSGIS != null, "pglGetDetailTexFuncSGIS not implemented");
					Delegates.pglGetDetailTexFuncSGIS((Int32)target, p_points);
					LogFunction("glGetDetailTexFuncSGIS({0}, {1})", target, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
