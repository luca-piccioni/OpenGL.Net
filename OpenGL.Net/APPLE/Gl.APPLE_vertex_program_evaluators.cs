
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
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP1_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP1_APPLE = 0x8A00;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP2_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP2_APPLE = 0x8A01;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP1_SIZE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP1_SIZE_APPLE = 0x8A02;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP1_COEFF_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP1_COEFF_APPLE = 0x8A03;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP1_ORDER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP1_ORDER_APPLE = 0x8A04;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP1_DOMAIN_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP1_DOMAIN_APPLE = 0x8A05;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP2_SIZE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP2_SIZE_APPLE = 0x8A06;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP2_COEFF_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP2_COEFF_APPLE = 0x8A07;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP2_ORDER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP2_ORDER_APPLE = 0x8A08;

		/// <summary>
		/// [GL] Value of GL_VERTEX_ATTRIB_MAP2_DOMAIN_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public const int VERTEX_ATTRIB_MAP2_DOMAIN_APPLE = 0x8A09;

		/// <summary>
		/// [GL] glEnableVertexAttribAPPLE: Binding for glEnableVertexAttribAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void EnableVertexAttribAPPLE(uint index, int pname)
		{
			Debug.Assert(Delegates.pglEnableVertexAttribAPPLE != null, "pglEnableVertexAttribAPPLE not implemented");
			Delegates.pglEnableVertexAttribAPPLE(index, pname);
			LogCommand("glEnableVertexAttribAPPLE", null, index, pname			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDisableVertexAttribAPPLE: Binding for glDisableVertexAttribAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void DisableVertexAttribAPPLE(uint index, int pname)
		{
			Debug.Assert(Delegates.pglDisableVertexAttribAPPLE != null, "pglDisableVertexAttribAPPLE not implemented");
			Delegates.pglDisableVertexAttribAPPLE(index, pname);
			LogCommand("glDisableVertexAttribAPPLE", null, index, pname			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsVertexAttribEnabledAPPLE: Binding for glIsVertexAttribEnabledAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static bool IsVertexAttribEnabledAPPLE(uint index, int pname)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVertexAttribEnabledAPPLE != null, "pglIsVertexAttribEnabledAPPLE not implemented");
			retValue = Delegates.pglIsVertexAttribEnabledAPPLE(index, pname);
			LogCommand("glIsVertexAttribEnabledAPPLE", retValue, index, pname			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glMapVertexAttrib1dAPPLE: Binding for glMapVertexAttrib1dAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="order">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void MapVertexAttrib1APPLE(uint index, uint size, double u1, double u2, int stride, int order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMapVertexAttrib1dAPPLE != null, "pglMapVertexAttrib1dAPPLE not implemented");
					Delegates.pglMapVertexAttrib1dAPPLE(index, size, u1, u2, stride, order, p_points);
					LogCommand("glMapVertexAttrib1dAPPLE", null, index, size, u1, u2, stride, order, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMapVertexAttrib1fAPPLE: Binding for glMapVertexAttrib1fAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="order">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void MapVertexAttrib1APPLE(uint index, uint size, float u1, float u2, int stride, int order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMapVertexAttrib1fAPPLE != null, "pglMapVertexAttrib1fAPPLE not implemented");
					Delegates.pglMapVertexAttrib1fAPPLE(index, size, u1, u2, stride, order, p_points);
					LogCommand("glMapVertexAttrib1fAPPLE", null, index, size, u1, u2, stride, order, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMapVertexAttrib2dAPPLE: Binding for glMapVertexAttrib2dAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void MapVertexAttrib2APPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMapVertexAttrib2dAPPLE != null, "pglMapVertexAttrib2dAPPLE not implemented");
					Delegates.pglMapVertexAttrib2dAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogCommand("glMapVertexAttrib2dAPPLE", null, index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glMapVertexAttrib2fAPPLE: Binding for glMapVertexAttrib2fAPPLE.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
		public static void MapVertexAttrib2APPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMapVertexAttrib2fAPPLE != null, "pglMapVertexAttrib2fAPPLE not implemented");
					Delegates.pglMapVertexAttrib2fAPPLE(index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogCommand("glMapVertexAttrib2fAPPLE", null, index, size, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glEnableVertexAttribAPPLE(uint index, int pname);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glEnableVertexAttribAPPLE pglEnableVertexAttribAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDisableVertexAttribAPPLE(uint index, int pname);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glDisableVertexAttribAPPLE pglDisableVertexAttribAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsVertexAttribEnabledAPPLE(uint index, int pname);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glIsVertexAttribEnabledAPPLE pglIsVertexAttribEnabledAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMapVertexAttrib1dAPPLE(uint index, uint size, double u1, double u2, int stride, int order, double* points);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glMapVertexAttrib1dAPPLE pglMapVertexAttrib1dAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMapVertexAttrib1fAPPLE(uint index, uint size, float u1, float u2, int stride, int order, float* points);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glMapVertexAttrib1fAPPLE pglMapVertexAttrib1fAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMapVertexAttrib2dAPPLE(uint index, uint size, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glMapVertexAttrib2dAPPLE pglMapVertexAttrib2dAPPLE;

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glMapVertexAttrib2fAPPLE(uint index, uint size, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

			[RequiredByFeature("GL_APPLE_vertex_program_evaluators")]
			[ThreadStatic]
			internal static glMapVertexAttrib2fAPPLE pglMapVertexAttrib2fAPPLE;

		}
	}

}
