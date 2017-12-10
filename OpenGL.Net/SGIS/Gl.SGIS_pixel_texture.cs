
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_PIXEL_TEXTURE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_TEXTURE_SGIS = 0x8353;

		/// <summary>
		/// [GL] Value of GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_RGB_SOURCE_SGIS = 0x8354;

		/// <summary>
		/// [GL] Value of GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS = 0x8355;

		/// <summary>
		/// [GL] Value of GL_PIXEL_GROUP_COLOR_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public const int PIXEL_GROUP_COLOR_SGIS = 0x8356;

		/// <summary>
		/// [GL] glPixelTexGenParameteriSGIS: Binding for glPixelTexGenParameteriSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, int param)
		{
			Debug.Assert(Delegates.pglPixelTexGenParameteriSGIS != null, "pglPixelTexGenParameteriSGIS not implemented");
			Delegates.pglPixelTexGenParameteriSGIS((int)pname, param);
			LogCommand("glPixelTexGenParameteriSGIS", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTexGenParameterivSGIS: Binding for glPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void PixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglPixelTexGenParameterivSGIS != null, "pglPixelTexGenParameterivSGIS not implemented");
					Delegates.pglPixelTexGenParameterivSGIS((int)pname, p_params);
					LogCommand("glPixelTexGenParameterivSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTexGenParameterfSGIS: Binding for glPixelTexGenParameterfSGIS.
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
			Delegates.pglPixelTexGenParameterfSGIS((int)pname, param);
			LogCommand("glPixelTexGenParameterfSGIS", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glPixelTexGenParameterfvSGIS: Binding for glPixelTexGenParameterfvSGIS.
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
					Delegates.pglPixelTexGenParameterfvSGIS((int)pname, p_params);
					LogCommand("glPixelTexGenParameterfvSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPixelTexGenParameterivSGIS: Binding for glGetPixelTexGenParameterivSGIS.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTexGenParameterNameSGIS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		public static void GetPixelTexGenParameterSGIS(PixelTexGenParameterNameSGIS pname, [Out] int[] @params)
		{
			unsafe {
				fixed (int* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetPixelTexGenParameterivSGIS != null, "pglGetPixelTexGenParameterivSGIS not implemented");
					Delegates.pglGetPixelTexGenParameterivSGIS((int)pname, p_params);
					LogCommand("glGetPixelTexGenParameterivSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetPixelTexGenParameterfvSGIS: Binding for glGetPixelTexGenParameterfvSGIS.
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
					Delegates.pglGetPixelTexGenParameterfvSGIS((int)pname, p_params);
					LogCommand("glGetPixelTexGenParameterfvSGIS", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glPixelTexGenParameteriSGIS(int pname, int param);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameteriSGIS pglPixelTexGenParameteriSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glPixelTexGenParameterivSGIS(int pname, int* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterivSGIS pglPixelTexGenParameterivSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glPixelTexGenParameterfSGIS(int pname, float param);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterfSGIS pglPixelTexGenParameterfSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glPixelTexGenParameterfvSGIS(int pname, float* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glPixelTexGenParameterfvSGIS pglPixelTexGenParameterfvSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPixelTexGenParameterivSGIS(int pname, int* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glGetPixelTexGenParameterivSGIS pglGetPixelTexGenParameterivSGIS;

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetPixelTexGenParameterfvSGIS(int pname, float* @params);

			[RequiredByFeature("GL_SGIS_pixel_texture")]
			[ThreadStatic]
			internal static glGetPixelTexGenParameterfvSGIS pglGetPixelTexGenParameterfvSGIS;

		}
	}

}
