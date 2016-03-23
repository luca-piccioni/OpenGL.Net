
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
		/// Value of GL_PIXEL_TEXTURE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_TEXTURE_SGIS = 0x8353;

		/// <summary>
		/// Value of GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;

		/// <summary>
		/// Value of GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;

		/// <summary>
		/// Value of GL_PIXEL_GROUP_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_GROUP_COLOR_SGIS = 0x8356;

		/// <summary>
		/// Binding for glPixelTexGenParameteriSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTexGenParameteriSGIS != null, "pglPixelTexGenParameteriSGIS not implemented");
			Delegates.pglPixelTexGenParameteriSGIS((Int32)pname, param);
			LogFunction("glPixelTexGenParameteriSGIS({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTexGenParameterivSGIS != null, "pglPixelTexGenParameterivSGIS not implemented");
					Delegates.pglPixelTexGenParameterivSGIS((Int32)pname, p_params);
					LogFunction("glPixelTexGenParameterivSGIS({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTexGenParameterfSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTexGenParameterfSGIS != null, "pglPixelTexGenParameterfSGIS not implemented");
			Delegates.pglPixelTexGenParameterfSGIS((Int32)pname, param);
			LogFunction("glPixelTexGenParameterfSGIS({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTexGenParameterfvSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTexGenParameterfvSGIS != null, "pglPixelTexGenParameterfvSGIS not implemented");
					Delegates.pglPixelTexGenParameterfvSGIS((Int32)pname, p_params);
					LogFunction("glPixelTexGenParameterfvSGIS({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void GetPixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTexGenParameterivSGIS != null, "pglGetPixelTexGenParameterivSGIS not implemented");
					Delegates.pglGetPixelTexGenParameterivSGIS((Int32)pname, p_params);
					LogFunction("glGetPixelTexGenParameterivSGIS({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetPixelTexGenParameterfvSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void GetPixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTexGenParameterfvSGIS != null, "pglGetPixelTexGenParameterfvSGIS not implemented");
					Delegates.pglGetPixelTexGenParameterfvSGIS((Int32)pname, p_params);
					LogFunction("glGetPixelTexGenParameterfvSGIS({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
