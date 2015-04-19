
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
		/// Value of GL_TEXTURE_DEFORMATION_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const uint TEXTURE_DEFORMATION_BIT_SGIX = 0x00000001;

		/// <summary>
		/// Value of GL_GEOMETRY_DEFORMATION_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const uint GEOMETRY_DEFORMATION_BIT_SGIX = 0x00000002;

		/// <summary>
		/// Value of GL_GEOMETRY_DEFORMATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int GEOMETRY_DEFORMATION_SGIX = 0x8194;

		/// <summary>
		/// Value of GL_TEXTURE_DEFORMATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int TEXTURE_DEFORMATION_SGIX = 0x8195;

		/// <summary>
		/// Value of GL_DEFORMATIONS_MASK_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int DEFORMATIONS_MASK_SGIX = 0x8196;

		/// <summary>
		/// Value of GL_MAX_DEFORMATION_ORDER_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public const int MAX_DEFORMATION_ORDER_SGIX = 0x8197;

		/// <summary>
		/// Binding for glDeformationMap3dSGIX.
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="wstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="worder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformationMap3SGIX(FfdTargetSGIX target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double w1, double w2, Int32 wstride, Int32 worder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglDeformationMap3dSGIX != null, "pglDeformationMap3dSGIX not implemented");
					Delegates.pglDeformationMap3dSGIX((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, p_points);
					CallLog("glDeformationMap3dSGIX({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeformationMap3fSGIX.
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w1">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w2">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="wstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="worder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformationMap3SGIX(FfdTargetSGIX target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float w1, float w2, Int32 wstride, Int32 worder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglDeformationMap3fSGIX != null, "pglDeformationMap3fSGIX not implemented");
					Delegates.pglDeformationMap3fSGIX((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, p_points);
					CallLog("glDeformationMap3fSGIX({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, w1, w2, wstride, worder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeformSGIX.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:FfdMaskSGIX"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void DeformSGIX(FfdMaskSGIX mask)
		{
			Debug.Assert(Delegates.pglDeformSGIX != null, "pglDeformSGIX not implemented");
			Delegates.pglDeformSGIX((UInt32)mask);
			CallLog("glDeformSGIX({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glLoadIdentityDeformationMapSGIX.
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:FfdMaskSGIX"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		public static void LoadIdentityDeformationMapSGIX(FfdMaskSGIX mask)
		{
			Debug.Assert(Delegates.pglLoadIdentityDeformationMapSGIX != null, "pglLoadIdentityDeformationMapSGIX not implemented");
			Delegates.pglLoadIdentityDeformationMapSGIX((UInt32)mask);
			CallLog("glLoadIdentityDeformationMapSGIX({0})", mask);
			DebugCheckErrors();
		}

	}

}
