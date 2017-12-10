
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
		/// [GL] Value of GL_TEXTURE_DEFORMATION_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_DEFORMATION_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		[Log(BitmaskName = "GL")]
		public const uint GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;

		/// <summary>
		/// [GL] Value of GL_GEOMETRY_DEFORMATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int GEOMETRY_DEFORMATION_SGIX = 0x8194;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_DEFORMATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int TEXTURE_DEFORMATION_SGIX = 0x8195;

		/// <summary>
		/// [GL] Value of GL_DEFORMATIONS_MASK_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int DEFORMATIONS_MASK_SGIX = 0x8196;

		/// <summary>
		/// [GL] Value of GL_MAX_DEFORMATION_ORDER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int MAX_DEFORMATION_ORDER_SGIX = 0x8197;

		/// <summary>
		/// [GL] glDeformationMap3dSGIX: Binding for glDeformationMap3dSGIX.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FfdTargetSGIX"/>.
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
		/// <param name="w1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="wstride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="worder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformationMap3SGIX(FfdTargetSGIX target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglDeformationMap3dSGIX != null, "pglDeformationMap3dSGIX not implemented");
					Delegates.pglDeformationMap3dSGIX((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, p_points);
					LogCommand("glDeformationMap3dSGIX", null, target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDeformationMap3fSGIX: Binding for glDeformationMap3fSGIX.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FfdTargetSGIX"/>.
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
		/// <param name="w1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="wstride">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="worder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformationMap3SGIX(FfdTargetSGIX target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglDeformationMap3fSGIX != null, "pglDeformationMap3fSGIX not implemented");
					Delegates.pglDeformationMap3fSGIX((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, p_points);
					LogCommand("glDeformationMap3fSGIX", null, target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glDeformSGIX: Binding for glDeformSGIX.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:FfdMaskSGIX"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformSGIX(FfdMaskSGIX mask)
		{
			Debug.Assert(Delegates.pglDeformSGIX != null, "pglDeformSGIX not implemented");
			Delegates.pglDeformSGIX((uint)mask);
			LogCommand("glDeformSGIX", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glLoadIdentityDeformationMapSGIX: Binding for glLoadIdentityDeformationMapSGIX.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:FfdMaskSGIX"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void LoadIdentityDeformationMapSGIX(FfdMaskSGIX mask)
		{
			Debug.Assert(Delegates.pglLoadIdentityDeformationMapSGIX != null, "pglLoadIdentityDeformationMapSGIX not implemented");
			Delegates.pglLoadIdentityDeformationMapSGIX((uint)mask);
			LogCommand("glLoadIdentityDeformationMapSGIX", null, mask			);
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeformationMap3dSGIX(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double w1, double w2, int wstride, int worder, double* points);

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[ThreadStatic]
			internal static glDeformationMap3dSGIX pglDeformationMap3dSGIX;

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeformationMap3fSGIX(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float w1, float w2, int wstride, int worder, float* points);

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[ThreadStatic]
			internal static glDeformationMap3fSGIX pglDeformationMap3fSGIX;

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeformSGIX(uint mask);

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[ThreadStatic]
			internal static glDeformSGIX pglDeformSGIX;

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glLoadIdentityDeformationMapSGIX(uint mask);

			[RequiredByFeature("GL_SGIX_polynomial_ffd")]
			[ThreadStatic]
			internal static glLoadIdentityDeformationMapSGIX pglLoadIdentityDeformationMapSGIX;

		}
	}

}
