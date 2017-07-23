
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Binding for glAlphaFuncxOES.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:AlphaFunction"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void AlphaFuncOES(AlphaFunction func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncxOES != null, "pglAlphaFuncxOES not implemented");
			Delegates.pglAlphaFuncxOES((Int32)func, @ref);
			LogCommand("glAlphaFuncxOES", null, func, @ref			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glClearColorxOES.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ClearColorOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearColorxOES != null, "pglClearColorxOES not implemented");
			Delegates.pglClearColorxOES(red, green, blue, alpha);
			LogCommand("glClearColorxOES", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glClearDepthxOES.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ClearDepthOES(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthxOES != null, "pglClearDepthxOES not implemented");
			Delegates.pglClearDepthxOES(depth);
			LogCommand("glClearDepthxOES", null, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glClipPlanexOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ClipPlaneOES(ClipPlaneName plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanexOES != null, "pglClipPlanexOES not implemented");
					Delegates.pglClipPlanexOES((Int32)plane, p_equation);
					LogCommand("glClipPlanexOES", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4xOES.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Color4OES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglColor4xOES != null, "pglColor4xOES not implemented");
			Delegates.pglColor4xOES(red, green, blue, alpha);
			LogCommand("glColor4xOES", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glDepthRangexOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void DepthRangeOES(IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglDepthRangexOES != null, "pglDepthRangexOES not implemented");
			Delegates.pglDepthRangexOES(n, f);
			LogCommand("glDepthRangexOES", null, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FogPName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FogOES(FogPName pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogxOES != null, "pglFogxOES not implemented");
			Delegates.pglFogxOES((Int32)pname, param);
			LogCommand("glFogxOES", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFogxvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:FogPName"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FogOES(FogPName pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxvOES != null, "pglFogxvOES not implemented");
					Delegates.pglFogxvOES((Int32)pname, p_param);
					LogCommand("glFogxvOES", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFrustumxOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FrustumOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglFrustumxOES != null, "pglFrustumxOES not implemented");
			Delegates.pglFrustumxOES(l, r, b, t, n, f);
			LogCommand("glFrustumxOES", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetClipPlanexOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetClipPlaneOES(ClipPlaneName plane, [Out] IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanexOES != null, "pglGetClipPlanexOES not implemented");
					Delegates.pglGetClipPlanexOES((Int32)plane, p_equation);
					LogCommand("glGetClipPlanexOES", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetFixedvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:GetPName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetFixedOES(GetPName pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedvOES != null, "pglGetFixedvOES not implemented");
					Delegates.pglGetFixedvOES((Int32)pname, p_params);
					LogCommand("glGetFixedvOES", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTexEnvxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetTexEnvOES(TextureEnvTarget target, TextureEnvParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxvOES != null, "pglGetTexEnvxvOES not implemented");
					Delegates.pglGetTexEnvxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexEnvxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTexParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetTexParameterOES(TextureTarget target, GetTextureParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxvOES != null, "pglGetTexParameterxvOES not implemented");
					Delegates.pglGetTexParameterxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexParameterxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLightModelxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:LightModelParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightModelOES(LightModelParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelxOES != null, "pglLightModelxOES not implemented");
			Delegates.pglLightModelxOES((Int32)pname, param);
			LogCommand("glLightModelxOES", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLightModelxvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:LightModelParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightModelOES(LightModelParameter pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxvOES != null, "pglLightModelxvOES not implemented");
					Delegates.pglLightModelxvOES((Int32)pname, p_param);
					LogCommand("glLightModelxvOES", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLightxOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:LightName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:LightParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightxOES(LightName light, LightParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightxOES != null, "pglLightxOES not implemented");
			Delegates.pglLightxOES((Int32)light, (Int32)pname, param);
			LogCommand("glLightxOES", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:LightName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:LightParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightxvOES(LightName light, LightParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxvOES != null, "pglLightxvOES not implemented");
					Delegates.pglLightxvOES((Int32)light, (Int32)pname, p_params);
					LogCommand("glLightxvOES", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLineWidthxOES.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LineWidthOES(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthxOES != null, "pglLineWidthxOES not implemented");
			Delegates.pglLineWidthxOES(width);
			LogCommand("glLineWidthxOES", null, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLoadMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LoadMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixxOES != null, "pglLoadMatrixxOES not implemented");
					Delegates.pglLoadMatrixxOES(p_m);
					LogCommand("glLoadMatrixxOES", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MaterialOES(MaterialFace face, MaterialParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialxOES != null, "pglMaterialxOES not implemented");
			Delegates.pglMaterialxOES((Int32)face, (Int32)pname, param);
			LogCommand("glMaterialxOES", null, face, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MaterialOES(MaterialFace face, MaterialParameter pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxvOES != null, "pglMaterialxvOES not implemented");
					Delegates.pglMaterialxvOES((Int32)face, (Int32)pname, p_param);
					LogCommand("glMaterialxvOES", null, face, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixxOES != null, "pglMultMatrixxOES not implemented");
					Delegates.pglMultMatrixxOES(p_m);
					LogCommand("glMultMatrixxOES", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord4xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord4OES(TextureUnit texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4xOES != null, "pglMultiTexCoord4xOES not implemented");
			Delegates.pglMultiTexCoord4xOES((Int32)texture, s, t, r, q);
			LogCommand("glMultiTexCoord4xOES", null, texture, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3xOES.
		/// </summary>
		/// <param name="nx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ny">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nz">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Normal3OES(IntPtr nx, IntPtr ny, IntPtr nz)
		{
			Debug.Assert(Delegates.pglNormal3xOES != null, "pglNormal3xOES not implemented");
			Delegates.pglNormal3xOES(nx, ny, nz);
			LogCommand("glNormal3xOES", null, nx, ny, nz			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glOrthoxOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void OrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglOrthoxOES != null, "pglOrthoxOES not implemented");
			Delegates.pglOrthoxOES(l, r, b, t, n, f);
			LogCommand("glOrthoxOES", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPointParameterxvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PointParameterOES(Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterxvOES != null, "pglPointParameterxvOES not implemented");
					Delegates.pglPointParameterxvOES(pname, p_params);
					LogCommand("glPointParameterxvOES", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPointSizexOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PointSizeOES(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizexOES != null, "pglPointSizexOES not implemented");
			Delegates.pglPointSizexOES(size);
			LogCommand("glPointSizexOES", null, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPolygonOffsetxOES.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="units">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PolygonOffsetOES(IntPtr factor, IntPtr units)
		{
			Debug.Assert(Delegates.pglPolygonOffsetxOES != null, "pglPolygonOffsetxOES not implemented");
			Delegates.pglPolygonOffsetxOES(factor, units);
			LogCommand("glPolygonOffsetxOES", null, factor, units			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRotatexOES.
		/// </summary>
		/// <param name="angle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RotateOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRotatexOES != null, "pglRotatexOES not implemented");
			Delegates.pglRotatexOES(angle, x, y, z);
			LogCommand("glRotatexOES", null, angle, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glScalexOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ScaleOES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglScalexOES != null, "pglScalexOES not implemented");
			Delegates.pglScalexOES(x, y, z);
			LogCommand("glScalexOES", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexEnvxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexEnvOES(TextureEnvTarget target, TextureEnvParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvxOES != null, "pglTexEnvxOES not implemented");
			Delegates.pglTexEnvxOES((Int32)target, (Int32)pname, param);
			LogCommand("glTexEnvxOES", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexEnvxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureEnvTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureEnvParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexEnvOES(TextureEnvTarget target, TextureEnvParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxvOES != null, "pglTexEnvxvOES not implemented");
					Delegates.pglTexEnvxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexEnvxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexParameterxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexParameterOES(TextureTarget target, GetTextureParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterxOES != null, "pglTexParameterxOES not implemented");
			Delegates.pglTexParameterxOES((Int32)target, (Int32)pname, param);
			LogCommand("glTexParameterxOES", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexParameterOES(TextureTarget target, GetTextureParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxvOES != null, "pglTexParameterxvOES not implemented");
					Delegates.pglTexParameterxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexParameterxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTranslatexOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TranslateOES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglTranslatexOES != null, "pglTranslatexOES not implemented");
			Delegates.pglTranslatexOES(x, y, z);
			LogCommand("glTranslatexOES", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:LightName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:LightParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
		public static void GetLightxvOES(LightName light, LightParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxvOES != null, "pglGetLightxvOES not implemented");
					Delegates.pglGetLightxvOES((Int32)light, (Int32)pname, p_params);
					LogCommand("glGetLightxvOES", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
		public static void GetMaterialOES(MaterialFace face, MaterialParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxvOES != null, "pglGetMaterialxvOES not implemented");
					Delegates.pglGetMaterialxvOES((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetMaterialxvOES", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPointParameterxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
		public static void PointParameterOES(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterxOES != null, "pglPointParameterxOES not implemented");
			Delegates.pglPointParameterxOES(pname, param);
			LogCommand("glPointParameterxOES", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glSampleCoveragexOES.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
		public static void SampleCoverageOES(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragexOES != null, "pglSampleCoveragexOES not implemented");
			Delegates.pglSampleCoveragexOES(value, invert);
			LogCommand("glSampleCoveragexOES", null, value, invert			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glAccumxOES.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void AccumOES(Int32 op, IntPtr value)
		{
			Debug.Assert(Delegates.pglAccumxOES != null, "pglAccumxOES not implemented");
			Delegates.pglAccumxOES(op, value);
			LogCommand("glAccumxOES", null, op, value			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glBitmapxOES.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xorig">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="yorig">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="xmove">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ymove">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="bitmap">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void BitmapOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmapxOES != null, "pglBitmapxOES not implemented");
					Delegates.pglBitmapxOES(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					LogCommand("glBitmapxOES", null, width, height, xorig, yorig, xmove, ymove, bitmap					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glBlendColorxOES.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void BlendColorOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglBlendColorxOES != null, "pglBlendColorxOES not implemented");
			Delegates.pglBlendColorxOES(red, green, blue, alpha);
			LogCommand("glBlendColorxOES", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glClearAccumxOES.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void ClearAccumOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearAccumxOES != null, "pglClearAccumxOES not implemented");
			Delegates.pglClearAccumxOES(red, green, blue, alpha);
			LogCommand("glClearAccumxOES", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3xOES.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Color3OES(IntPtr red, IntPtr green, IntPtr blue)
		{
			Debug.Assert(Delegates.pglColor3xOES != null, "pglColor3xOES not implemented");
			Delegates.pglColor3xOES(red, green, blue);
			LogCommand("glColor3xOES", null, red, green, blue			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor3xvOES.
		/// </summary>
		/// <param name="components">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Color3OES(IntPtr[] components)
		{
			unsafe {
				fixed (IntPtr* p_components = components)
				{
					Debug.Assert(Delegates.pglColor3xvOES != null, "pglColor3xvOES not implemented");
					Delegates.pglColor3xvOES(p_components);
					LogCommand("glColor3xvOES", null, components					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glColor4xvOES.
		/// </summary>
		/// <param name="components">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Color4OES(IntPtr[] components)
		{
			unsafe {
				fixed (IntPtr* p_components = components)
				{
					Debug.Assert(Delegates.pglColor4xvOES != null, "pglColor4xvOES not implemented");
					Delegates.pglColor4xvOES(p_components);
					LogCommand("glColor4xvOES", null, components					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glConvolutionParameterxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void ConvolutionParameterOES(ConvolutionTarget target, ConvolutionParameterEXT pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglConvolutionParameterxOES != null, "pglConvolutionParameterxOES not implemented");
			Delegates.pglConvolutionParameterxOES((Int32)target, (Int32)pname, param);
			LogCommand("glConvolutionParameterxOES", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glConvolutionParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:ConvolutionTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:ConvolutionParameterEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void ConvolutionParameterOES(ConvolutionTarget target, ConvolutionParameterEXT pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameterxvOES != null, "pglConvolutionParameterxvOES not implemented");
					Delegates.pglConvolutionParameterxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glConvolutionParameterxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEvalCoord1xOES.
		/// </summary>
		/// <param name="u">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void EvalCoord1OES(IntPtr u)
		{
			Debug.Assert(Delegates.pglEvalCoord1xOES != null, "pglEvalCoord1xOES not implemented");
			Delegates.pglEvalCoord1xOES(u);
			LogCommand("glEvalCoord1xOES", null, u			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEvalCoord1xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void EvalCoord1OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglEvalCoord1xvOES != null, "pglEvalCoord1xvOES not implemented");
					Delegates.pglEvalCoord1xvOES(p_coords);
					LogCommand("glEvalCoord1xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEvalCoord2xOES.
		/// </summary>
		/// <param name="u">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void EvalCoord2OES(IntPtr u, IntPtr v)
		{
			Debug.Assert(Delegates.pglEvalCoord2xOES != null, "pglEvalCoord2xOES not implemented");
			Delegates.pglEvalCoord2xOES(u, v);
			LogCommand("glEvalCoord2xOES", null, u, v			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glEvalCoord2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void EvalCoord2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglEvalCoord2xvOES != null, "pglEvalCoord2xvOES not implemented");
					Delegates.pglEvalCoord2xvOES(p_coords);
					LogCommand("glEvalCoord2xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFeedbackBufferxOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void FeedbackBufferOES(Int32 type, IntPtr[] buffer)
		{
			unsafe {
				fixed (IntPtr* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBufferxOES != null, "pglFeedbackBufferxOES not implemented");
					Delegates.pglFeedbackBufferxOES((Int32)buffer.Length, type, p_buffer);
					LogCommand("glFeedbackBufferxOES", null, buffer.Length, type, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetConvolutionParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetConvolutionParameterOES(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterxvOES != null, "pglGetConvolutionParameterxvOES not implemented");
					Delegates.pglGetConvolutionParameterxvOES(target, pname, p_params);
					LogCommand("glGetConvolutionParameterxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetHistogramParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:HistogramTargetEXT"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetHistogramParameterPNameEXT"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetHistogramParameterOES(HistogramTargetEXT target, GetHistogramParameterPNameEXT pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterxvOES != null, "pglGetHistogramParameterxvOES not implemented");
					Delegates.pglGetHistogramParameterxvOES((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetHistogramParameterxvOES", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetLightxOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:LightName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:LightParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetLightxOES(LightName light, LightParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxOES != null, "pglGetLightxOES not implemented");
					Delegates.pglGetLightxOES((Int32)light, (Int32)pname, p_params);
					LogCommand("glGetLightxOES", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMapxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:GetMapQuery"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetMapOES(EvaluatorTarget target, GetMapQuery query, [Out] IntPtr[] v)
		{
			unsafe {
				fixed (IntPtr* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapxvOES != null, "pglGetMapxvOES not implemented");
					Delegates.pglGetMapxvOES((Int32)target, (Int32)query, p_v);
					LogCommand("glGetMapxvOES", null, target, query, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetMaterialOES(MaterialFace face, MaterialParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglGetMaterialxOES != null, "pglGetMaterialxOES not implemented");
			Delegates.pglGetMaterialxOES((Int32)face, (Int32)pname, param);
			LogCommand("glGetMaterialxOES", null, face, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetMaterialOES(MaterialFace face, MaterialParameter pname, Object param)
		{
			GCHandle pin_param = GCHandle.Alloc(param, GCHandleType.Pinned);
			try {
				GetMaterialOES(face, pname, pin_param.AddrOfPinnedObject());
			} finally {
				pin_param.Free();
			}
		}

		/// <summary>
		/// [GL] Binding for glGetPixelMapxv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetPixelMap(PixelMap map, Int32 size, [Out] IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapxv != null, "pglGetPixelMapxv not implemented");
					Delegates.pglGetPixelMapxv((Int32)map, size, p_values);
					LogCommand("glGetPixelMapxv", null, map, size, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetPixelMapxv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetPixelMap(PixelMap map, [Out] IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapxv != null, "pglGetPixelMapxv not implemented");
					Delegates.pglGetPixelMapxv((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glGetPixelMapxv", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTexGenxvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(TextureCoordName coord, TextureGenParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenxvOES != null, "pglGetTexGenxvOES not implemented");
					Delegates.pglGetTexGenxvOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGenxvOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetTexLevelParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void GetTexLevelParameterOES(TextureTarget target, Int32 level, GetTextureParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterxvOES != null, "pglGetTexLevelParameterxvOES not implemented");
					Delegates.pglGetTexLevelParameterxvOES((Int32)target, level, (Int32)pname, p_params);
					LogCommand("glGetTexLevelParameterxvOES", null, target, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIndexxOES.
		/// </summary>
		/// <param name="component">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void IndexOES(IntPtr component)
		{
			Debug.Assert(Delegates.pglIndexxOES != null, "pglIndexxOES not implemented");
			Delegates.pglIndexxOES(component);
			LogCommand("glIndexxOES", null, component			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glIndexxvOES.
		/// </summary>
		/// <param name="component">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void IndexOES(IntPtr[] component)
		{
			unsafe {
				fixed (IntPtr* p_component = component)
				{
					Debug.Assert(Delegates.pglIndexxvOES != null, "pglIndexxvOES not implemented");
					Delegates.pglIndexxvOES(p_component);
					LogCommand("glIndexxvOES", null, component					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glLoadTransposeMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void LoadTransposeMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixxOES != null, "pglLoadTransposeMatrixxOES not implemented");
					Delegates.pglLoadTransposeMatrixxOES(p_m);
					LogCommand("glLoadTransposeMatrixxOES", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMap1xOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="order">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Map1OES(EvaluatorTarget target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points)
		{
			Debug.Assert(Delegates.pglMap1xOES != null, "pglMap1xOES not implemented");
			Delegates.pglMap1xOES((Int32)target, u1, u2, stride, order, points);
			LogCommand("glMap1xOES", null, target, u1, u2, stride, order, points			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMap2xOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:EvaluatorTarget"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ustride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="uorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="vstride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="vorder">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Map2OES(EvaluatorTarget target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points)
		{
			Debug.Assert(Delegates.pglMap2xOES != null, "pglMap2xOES not implemented");
			Delegates.pglMap2xOES((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			LogCommand("glMap2xOES", null, target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMapGrid1xOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MapGrid1OES(Int32 n, IntPtr u1, IntPtr u2)
		{
			Debug.Assert(Delegates.pglMapGrid1xOES != null, "pglMapGrid1xOES not implemented");
			Delegates.pglMapGrid1xOES(n, u1, u2);
			LogCommand("glMapGrid1xOES", null, n, u1, u2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMapGrid2xOES.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="u1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="u2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MapGrid2OES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2)
		{
			Debug.Assert(Delegates.pglMapGrid2xOES != null, "pglMapGrid2xOES not implemented");
			Delegates.pglMapGrid2xOES(n, u1, u2, v1, v2);
			LogCommand("glMapGrid2xOES", null, n, u1, u2, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultTransposeMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultTransposeMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixxOES != null, "pglMultTransposeMatrixxOES not implemented");
					Delegates.pglMultTransposeMatrixxOES(p_m);
					LogCommand("glMultTransposeMatrixxOES", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord1xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord1OES(TextureUnit texture, IntPtr s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1xOES != null, "pglMultiTexCoord1xOES not implemented");
			Delegates.pglMultiTexCoord1xOES((Int32)texture, s);
			LogCommand("glMultiTexCoord1xOES", null, texture, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord1xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord1OES(TextureUnit texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1xvOES != null, "pglMultiTexCoord1xvOES not implemented");
					Delegates.pglMultiTexCoord1xvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord1xvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord2xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord2OES(TextureUnit texture, IntPtr s, IntPtr t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2xOES != null, "pglMultiTexCoord2xOES not implemented");
			Delegates.pglMultiTexCoord2xOES((Int32)texture, s, t);
			LogCommand("glMultiTexCoord2xOES", null, texture, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord2xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord2OES(TextureUnit texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2xvOES != null, "pglMultiTexCoord2xvOES not implemented");
					Delegates.pglMultiTexCoord2xvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord2xvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord3xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord3OES(TextureUnit texture, IntPtr s, IntPtr t, IntPtr r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3xOES != null, "pglMultiTexCoord3xOES not implemented");
			Delegates.pglMultiTexCoord3xOES((Int32)texture, s, t, r);
			LogCommand("glMultiTexCoord3xOES", null, texture, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord3xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord3OES(TextureUnit texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3xvOES != null, "pglMultiTexCoord3xvOES not implemented");
					Delegates.pglMultiTexCoord3xvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord3xvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glMultiTexCoord4xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void MultiTexCoord4OES(TextureUnit texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4xvOES != null, "pglMultiTexCoord4xvOES not implemented");
					Delegates.pglMultiTexCoord4xvOES((Int32)texture, p_coords);
					LogCommand("glMultiTexCoord4xvOES", null, texture, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glNormal3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Normal3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormal3xvOES != null, "pglNormal3xvOES not implemented");
					Delegates.pglNormal3xvOES(p_coords);
					LogCommand("glNormal3xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPassThroughxOES.
		/// </summary>
		/// <param name="token">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PassThroughOES(IntPtr token)
		{
			Debug.Assert(Delegates.pglPassThroughxOES != null, "pglPassThroughxOES not implemented");
			Delegates.pglPassThroughxOES(token);
			LogCommand("glPassThroughxOES", null, token			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelMapx.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PixelMap(PixelMap map, Int32 size, IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapx != null, "pglPixelMapx not implemented");
					Delegates.pglPixelMapx((Int32)map, size, p_values);
					LogCommand("glPixelMapx", null, map, size, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelMapx.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:PixelMap"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PixelMap(PixelMap map, IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapx != null, "pglPixelMapx not implemented");
					Delegates.pglPixelMapx((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glPixelMapx", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelStorex.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelStoreParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PixelStore(PixelStoreParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPixelStorex != null, "pglPixelStorex not implemented");
			Delegates.pglPixelStorex((Int32)pname, param);
			LogCommand("glPixelStorex", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelTransferxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:PixelTransferParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PixelTransferOES(PixelTransferParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPixelTransferxOES != null, "pglPixelTransferxOES not implemented");
			Delegates.pglPixelTransferxOES((Int32)pname, param);
			LogCommand("glPixelTransferxOES", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPixelZoomxOES.
		/// </summary>
		/// <param name="xfactor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="yfactor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PixelZoomOES(IntPtr xfactor, IntPtr yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoomxOES != null, "pglPixelZoomxOES not implemented");
			Delegates.pglPixelZoomxOES(xfactor, yfactor);
			LogCommand("glPixelZoomxOES", null, xfactor, yfactor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glPrioritizeTexturesxOES.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="priorities">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void PrioritizeTexturesOES(UInt32[] textures, IntPtr[] priorities)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (IntPtr* p_priorities = priorities)
				{
					Debug.Assert(Delegates.pglPrioritizeTexturesxOES != null, "pglPrioritizeTexturesxOES not implemented");
					Delegates.pglPrioritizeTexturesxOES((Int32)textures.Length, p_textures, p_priorities);
					LogCommand("glPrioritizeTexturesxOES", null, textures.Length, textures, priorities					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos2xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos2OES(IntPtr x, IntPtr y)
		{
			Debug.Assert(Delegates.pglRasterPos2xOES != null, "pglRasterPos2xOES not implemented");
			Delegates.pglRasterPos2xOES(x, y);
			LogCommand("glRasterPos2xOES", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos2xvOES != null, "pglRasterPos2xvOES not implemented");
					Delegates.pglRasterPos2xvOES(p_coords);
					LogCommand("glRasterPos2xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos3xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos3OES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRasterPos3xOES != null, "pglRasterPos3xOES not implemented");
			Delegates.pglRasterPos3xOES(x, y, z);
			LogCommand("glRasterPos3xOES", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos3xvOES != null, "pglRasterPos3xvOES not implemented");
					Delegates.pglRasterPos3xvOES(p_coords);
					LogCommand("glRasterPos3xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos4xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos4OES(IntPtr x, IntPtr y, IntPtr z, IntPtr w)
		{
			Debug.Assert(Delegates.pglRasterPos4xOES != null, "pglRasterPos4xOES not implemented");
			Delegates.pglRasterPos4xOES(x, y, z, w);
			LogCommand("glRasterPos4xOES", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRasterPos4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RasterPos4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos4xvOES != null, "pglRasterPos4xvOES not implemented");
					Delegates.pglRasterPos4xvOES(p_coords);
					LogCommand("glRasterPos4xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRectxOES.
		/// </summary>
		/// <param name="x1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y1">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="x2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y2">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RectOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2)
		{
			Debug.Assert(Delegates.pglRectxOES != null, "pglRectxOES not implemented");
			Delegates.pglRectxOES(x1, y1, x2, y2);
			LogCommand("glRectxOES", null, x1, y1, x2, y2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glRectxvOES.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void RectOES(IntPtr[] v1, IntPtr[] v2)
		{
			unsafe {
				fixed (IntPtr* p_v1 = v1)
				fixed (IntPtr* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectxvOES != null, "pglRectxvOES not implemented");
					Delegates.pglRectxvOES(p_v1, p_v2);
					LogCommand("glRectxvOES", null, v1, v2					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord1xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord1OES(IntPtr s)
		{
			Debug.Assert(Delegates.pglTexCoord1xOES != null, "pglTexCoord1xOES not implemented");
			Delegates.pglTexCoord1xOES(s);
			LogCommand("glTexCoord1xOES", null, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord1xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord1OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord1xvOES != null, "pglTexCoord1xvOES not implemented");
					Delegates.pglTexCoord1xvOES(p_coords);
					LogCommand("glTexCoord1xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord2OES(IntPtr s, IntPtr t)
		{
			Debug.Assert(Delegates.pglTexCoord2xOES != null, "pglTexCoord2xOES not implemented");
			Delegates.pglTexCoord2xOES(s, t);
			LogCommand("glTexCoord2xOES", null, s, t			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord2xvOES != null, "pglTexCoord2xvOES not implemented");
					Delegates.pglTexCoord2xvOES(p_coords);
					LogCommand("glTexCoord2xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord3xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord3OES(IntPtr s, IntPtr t, IntPtr r)
		{
			Debug.Assert(Delegates.pglTexCoord3xOES != null, "pglTexCoord3xOES not implemented");
			Delegates.pglTexCoord3xOES(s, t, r);
			LogCommand("glTexCoord3xOES", null, s, t, r			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord3xvOES != null, "pglTexCoord3xvOES not implemented");
					Delegates.pglTexCoord3xvOES(p_coords);
					LogCommand("glTexCoord3xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="q">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord4OES(IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglTexCoord4xOES != null, "pglTexCoord4xOES not implemented");
			Delegates.pglTexCoord4xOES(s, t, r, q);
			LogCommand("glTexCoord4xOES", null, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexCoord4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void TexCoord4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord4xvOES != null, "pglTexCoord4xvOES not implemented");
					Delegates.pglTexCoord4xvOES(p_coords);
					LogCommand("glTexCoord4xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexGenxOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexGenxOES != null, "pglTexGenxOES not implemented");
			Delegates.pglTexGenxOES((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGenxOES", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glTexGenxvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:TextureCoordName"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureGenParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(TextureCoordName coord, TextureGenParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenxvOES != null, "pglTexGenxvOES not implemented");
					Delegates.pglTexGenxvOES((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGenxvOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex2xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex2OES(IntPtr x)
		{
			Debug.Assert(Delegates.pglVertex2xOES != null, "pglVertex2xOES not implemented");
			Delegates.pglVertex2xOES(x);
			LogCommand("glVertex2xOES", null, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex2xvOES != null, "pglVertex2xvOES not implemented");
					Delegates.pglVertex2xvOES(p_coords);
					LogCommand("glVertex2xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex3xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex3OES(IntPtr x, IntPtr y)
		{
			Debug.Assert(Delegates.pglVertex3xOES != null, "pglVertex3xOES not implemented");
			Delegates.pglVertex3xOES(x, y);
			LogCommand("glVertex3xOES", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex3xvOES != null, "pglVertex3xvOES not implemented");
					Delegates.pglVertex3xvOES(p_coords);
					LogCommand("glVertex3xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex4xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex4OES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglVertex4xOES != null, "pglVertex4xOES not implemented");
			Delegates.pglVertex4xOES(x, y, z);
			LogCommand("glVertex4xOES", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glVertex4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point")]
		public static void Vertex4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex4xvOES != null, "pglVertex4xvOES not implemented");
					Delegates.pglVertex4xvOES(p_coords);
					LogCommand("glVertex4xvOES", null, coords					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glAlphaFuncxOES", ExactSpelling = true)]
			internal extern static unsafe void glAlphaFuncxOES(Int32 func, IntPtr @ref);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glClearColorxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glClearDepthxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearDepthxOES(IntPtr depth);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glClipPlanexOES", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanexOES(Int32 plane, IntPtr* equation);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glColor4xOES", ExactSpelling = true)]
			internal extern static unsafe void glColor4xOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glDepthRangexOES", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangexOES(IntPtr n, IntPtr f);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFogxOES", ExactSpelling = true)]
			internal extern static unsafe void glFogxOES(Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFogxvOES", ExactSpelling = true)]
			internal extern static unsafe void glFogxvOES(Int32 pname, IntPtr* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFrustumxOES", ExactSpelling = true)]
			internal extern static unsafe void glFrustumxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetClipPlanexOES", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanexOES(Int32 plane, IntPtr* equation);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetFixedvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetFixedvOES(Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexEnvxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLightModelxOES", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxOES(Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLightModelxvOES", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxvOES(Int32 pname, IntPtr* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLightxOES", ExactSpelling = true)]
			internal extern static unsafe void glLightxOES(Int32 light, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLightxvOES", ExactSpelling = true)]
			internal extern static unsafe void glLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLineWidthxOES", ExactSpelling = true)]
			internal extern static unsafe void glLineWidthxOES(IntPtr width);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLoadMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixxOES(IntPtr* m);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMaterialxOES", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMaterialxvOES", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxvOES(Int32 face, Int32 pname, IntPtr* param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixxOES(IntPtr* m);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord4xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glNormal3xOES", ExactSpelling = true)]
			internal extern static unsafe void glNormal3xOES(IntPtr nx, IntPtr ny, IntPtr nz);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glOrthoxOES", ExactSpelling = true)]
			internal extern static unsafe void glOrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPointParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxvOES(Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPointSizexOES", ExactSpelling = true)]
			internal extern static unsafe void glPointSizexOES(IntPtr size);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPolygonOffsetxOES", ExactSpelling = true)]
			internal extern static unsafe void glPolygonOffsetxOES(IntPtr factor, IntPtr units);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRotatexOES", ExactSpelling = true)]
			internal extern static unsafe void glRotatexOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glScalexOES", ExactSpelling = true)]
			internal extern static unsafe void glScalexOES(IntPtr x, IntPtr y, IntPtr z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexEnvxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxOES(Int32 target, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexEnvxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxOES(Int32 target, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTranslatexOES", ExactSpelling = true)]
			internal extern static unsafe void glTranslatexOES(IntPtr x, IntPtr y, IntPtr z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetLightxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMaterialxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxvOES(Int32 face, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPointParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxOES(Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glSampleCoveragexOES", ExactSpelling = true)]
			internal extern static void glSampleCoveragexOES(Int32 value, bool invert);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glAccumxOES", ExactSpelling = true)]
			internal extern static unsafe void glAccumxOES(Int32 op, IntPtr value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBitmapxOES", ExactSpelling = true)]
			internal extern static unsafe void glBitmapxOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte* bitmap);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBlendColorxOES", ExactSpelling = true)]
			internal extern static unsafe void glBlendColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glClearAccumxOES", ExactSpelling = true)]
			internal extern static unsafe void glClearAccumxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glColor3xOES", ExactSpelling = true)]
			internal extern static unsafe void glColor3xOES(IntPtr red, IntPtr green, IntPtr blue);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glColor3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glColor3xvOES(IntPtr* components);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glColor4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glColor4xvOES(IntPtr* components);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glConvolutionParameterxOES", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterxOES(Int32 target, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glConvolutionParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEvalCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1xOES(IntPtr u);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEvalCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEvalCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2xOES(IntPtr u, IntPtr v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glEvalCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFeedbackBufferxOES", ExactSpelling = true)]
			internal extern static unsafe void glFeedbackBufferxOES(Int32 n, Int32 type, IntPtr* buffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetConvolutionParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetHistogramParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetHistogramParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetLightxOES", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxOES(Int32 light, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMapxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMapxvOES(Int32 target, Int32 query, IntPtr* v);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetMaterialxOES", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetPixelMapxv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapxv(Int32 map, Int32 size, IntPtr* values);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexGenxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetTexLevelParameterxvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameterxvOES(Int32 target, Int32 level, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIndexxOES", ExactSpelling = true)]
			internal extern static unsafe void glIndexxOES(IntPtr component);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glIndexxvOES", ExactSpelling = true)]
			internal extern static unsafe void glIndexxvOES(IntPtr* component);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glLoadTransposeMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glLoadTransposeMatrixxOES(IntPtr* m);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMap1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMap1xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMap2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMap2xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMapGrid1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMapGrid1xOES(Int32 n, IntPtr u1, IntPtr u2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMapGrid2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMapGrid2xOES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultTransposeMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe void glMultTransposeMatrixxOES(IntPtr* m);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1xOES(Int32 texture, IntPtr s);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord1xvOES(Int32 texture, IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2xOES(Int32 texture, IntPtr s, IntPtr t);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord2xvOES(Int32 texture, IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord3xOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord3xvOES(Int32 texture, IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glMultiTexCoord4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4xvOES(Int32 texture, IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glNormal3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glNormal3xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPassThroughxOES", ExactSpelling = true)]
			internal extern static unsafe void glPassThroughxOES(IntPtr token);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelMapx", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapx(Int32 map, Int32 size, IntPtr* values);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelStorex", ExactSpelling = true)]
			internal extern static unsafe void glPixelStorex(Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelTransferxOES", ExactSpelling = true)]
			internal extern static unsafe void glPixelTransferxOES(Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPixelZoomxOES", ExactSpelling = true)]
			internal extern static unsafe void glPixelZoomxOES(IntPtr xfactor, IntPtr yfactor);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glPrioritizeTexturesxOES", ExactSpelling = true)]
			internal extern static unsafe void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, IntPtr* priorities);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos2xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2xOES(IntPtr x, IntPtr y);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos3xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3xOES(IntPtr x, IntPtr y, IntPtr z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos4xOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4xOES(IntPtr x, IntPtr y, IntPtr z, IntPtr w);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRasterPos4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRectxOES", ExactSpelling = true)]
			internal extern static unsafe void glRectxOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glRectxvOES", ExactSpelling = true)]
			internal extern static unsafe void glRectxvOES(IntPtr* v1, IntPtr* v2);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord1xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1xOES(IntPtr s);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord1xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord2xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2xOES(IntPtr s, IntPtr t);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord3xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3xOES(IntPtr s, IntPtr t, IntPtr r);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord4xOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4xOES(IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexCoord4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGenxOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenxOES(Int32 coord, Int32 pname, IntPtr param);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glTexGenxvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex2xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2xOES(IntPtr x);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex2xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex2xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex3xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3xOES(IntPtr x, IntPtr y);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex3xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex3xvOES(IntPtr* coords);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex4xOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4xOES(IntPtr x, IntPtr y, IntPtr z);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glVertex4xvOES", ExactSpelling = true)]
			internal extern static unsafe void glVertex4xvOES(IntPtr* coords);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glAlphaFuncxOES(Int32 func, IntPtr @ref);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glAlphaFuncxOES pglAlphaFuncxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glClearColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glClearColorxOES pglClearColorxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glClearDepthxOES(IntPtr depth);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glClearDepthxOES pglClearDepthxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glClipPlanexOES(Int32 plane, IntPtr* equation);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glClipPlanexOES pglClipPlanexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glColor4xOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glColor4xOES pglColor4xOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glDepthRangexOES(IntPtr n, IntPtr f);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glDepthRangexOES pglDepthRangexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFogxOES(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glFogxOES pglFogxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFogxvOES(Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glFogxvOES pglFogxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFrustumxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glFrustumxOES pglFrustumxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetClipPlanexOES(Int32 plane, IntPtr* equation);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glGetClipPlanexOES pglGetClipPlanexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetFixedvOES(Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glGetFixedvOES pglGetFixedvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glGetTexEnvxvOES pglGetTexEnvxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glGetTexParameterxvOES pglGetTexParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLightModelxOES(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLightModelxOES pglLightModelxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLightModelxvOES(Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLightModelxvOES pglLightModelxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLightxOES(Int32 light, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLightxOES pglLightxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLightxvOES pglLightxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLineWidthxOES(IntPtr width);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLineWidthxOES pglLineWidthxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLoadMatrixxOES(IntPtr* m);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glLoadMatrixxOES pglLoadMatrixxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glMaterialxOES pglMaterialxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMaterialxvOES(Int32 face, Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glMaterialxvOES pglMaterialxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultMatrixxOES(IntPtr* m);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glMultMatrixxOES pglMultMatrixxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord4xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glMultiTexCoord4xOES pglMultiTexCoord4xOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glNormal3xOES(IntPtr nx, IntPtr ny, IntPtr nz);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glNormal3xOES pglNormal3xOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glOrthoxOES(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glOrthoxOES pglOrthoxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPointParameterxvOES(Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glPointParameterxvOES pglPointParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPointSizexOES(IntPtr size);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glPointSizexOES pglPointSizexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPolygonOffsetxOES(IntPtr factor, IntPtr units);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glPolygonOffsetxOES pglPolygonOffsetxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRotatexOES(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glRotatexOES pglRotatexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glScalexOES(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glScalexOES pglScalexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexEnvxOES(Int32 target, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glTexEnvxOES pglTexEnvxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexEnvxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glTexEnvxvOES pglTexEnvxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glTexParameterxOES pglTexParameterxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glTexParameterxvOES pglTexParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTranslatexOES(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glTranslatexOES pglTranslatexOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetLightxvOES(Int32 light, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			[ThreadStatic]
			internal static glGetLightxvOES pglGetLightxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMaterialxvOES(Int32 face, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			[ThreadStatic]
			internal static glGetMaterialxvOES pglGetMaterialxvOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPointParameterxOES(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			[ThreadStatic]
			internal static glPointParameterxOES pglPointParameterxOES;

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glSampleCoveragexOES(Int32 value, bool invert);

			[RequiredByFeature("GL_OES_fixed_point", Api = "gles1")]
			[ThreadStatic]
			internal static glSampleCoveragexOES pglSampleCoveragexOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glAccumxOES(Int32 op, IntPtr value);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glAccumxOES pglAccumxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glBitmapxOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte* bitmap);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glBitmapxOES pglBitmapxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glBlendColorxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glBlendColorxOES pglBlendColorxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glClearAccumxOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glClearAccumxOES pglClearAccumxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glColor3xOES(IntPtr red, IntPtr green, IntPtr blue);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glColor3xOES pglColor3xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glColor3xvOES(IntPtr* components);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glColor3xvOES pglColor3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glColor4xvOES(IntPtr* components);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glColor4xvOES pglColor4xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glConvolutionParameterxOES(Int32 target, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glConvolutionParameterxOES pglConvolutionParameterxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glConvolutionParameterxvOES pglConvolutionParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glEvalCoord1xOES(IntPtr u);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glEvalCoord1xOES pglEvalCoord1xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glEvalCoord1xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glEvalCoord1xvOES pglEvalCoord1xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glEvalCoord2xOES(IntPtr u, IntPtr v);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glEvalCoord2xOES pglEvalCoord2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glEvalCoord2xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glEvalCoord2xvOES pglEvalCoord2xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFeedbackBufferxOES(Int32 n, Int32 type, IntPtr* buffer);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glFeedbackBufferxOES pglFeedbackBufferxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetConvolutionParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetConvolutionParameterxvOES pglGetConvolutionParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetHistogramParameterxvOES(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetHistogramParameterxvOES pglGetHistogramParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetLightxOES(Int32 light, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetLightxOES pglGetLightxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMapxvOES(Int32 target, Int32 query, IntPtr* v);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetMapxvOES pglGetMapxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetMaterialxOES(Int32 face, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetMaterialxOES pglGetMaterialxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetPixelMapxv(Int32 map, Int32 size, IntPtr* values);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetPixelMapxv pglGetPixelMapxv;

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glGetTexGenxvOES pglGetTexGenxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetTexLevelParameterxvOES(Int32 target, Int32 level, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glGetTexLevelParameterxvOES pglGetTexLevelParameterxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glIndexxOES(IntPtr component);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glIndexxOES pglIndexxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glIndexxvOES(IntPtr* component);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glIndexxvOES pglIndexxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glLoadTransposeMatrixxOES(IntPtr* m);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glLoadTransposeMatrixxOES pglLoadTransposeMatrixxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMap1xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMap1xOES pglMap1xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMap2xOES(Int32 target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMap2xOES pglMap2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMapGrid1xOES(Int32 n, IntPtr u1, IntPtr u2);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMapGrid1xOES pglMapGrid1xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMapGrid2xOES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMapGrid2xOES pglMapGrid2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultTransposeMatrixxOES(IntPtr* m);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultTransposeMatrixxOES pglMultTransposeMatrixxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord1xOES(Int32 texture, IntPtr s);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord1xOES pglMultiTexCoord1xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord1xvOES(Int32 texture, IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord1xvOES pglMultiTexCoord1xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord2xOES(Int32 texture, IntPtr s, IntPtr t);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord2xOES pglMultiTexCoord2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord2xvOES(Int32 texture, IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord2xvOES pglMultiTexCoord2xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord3xOES(Int32 texture, IntPtr s, IntPtr t, IntPtr r);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord3xOES pglMultiTexCoord3xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord3xvOES(Int32 texture, IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord3xvOES pglMultiTexCoord3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glMultiTexCoord4xvOES(Int32 texture, IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glMultiTexCoord4xvOES pglMultiTexCoord4xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glNormal3xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glNormal3xvOES pglNormal3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPassThroughxOES(IntPtr token);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPassThroughxOES pglPassThroughxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelMapx(Int32 map, Int32 size, IntPtr* values);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPixelMapx pglPixelMapx;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelStorex(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPixelStorex pglPixelStorex;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelTransferxOES(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPixelTransferxOES pglPixelTransferxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPixelZoomxOES(IntPtr xfactor, IntPtr yfactor);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPixelZoomxOES pglPixelZoomxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glPrioritizeTexturesxOES(Int32 n, UInt32* textures, IntPtr* priorities);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glPrioritizeTexturesxOES pglPrioritizeTexturesxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos2xOES(IntPtr x, IntPtr y);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos2xOES pglRasterPos2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos2xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos2xvOES pglRasterPos2xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos3xOES(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos3xOES pglRasterPos3xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos3xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos3xvOES pglRasterPos3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos4xOES(IntPtr x, IntPtr y, IntPtr z, IntPtr w);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos4xOES pglRasterPos4xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRasterPos4xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRasterPos4xvOES pglRasterPos4xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRectxOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRectxOES pglRectxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glRectxvOES(IntPtr* v1, IntPtr* v2);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glRectxvOES pglRectxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord1xOES(IntPtr s);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord1xOES pglTexCoord1xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord1xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord1xvOES pglTexCoord1xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord2xOES(IntPtr s, IntPtr t);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord2xOES pglTexCoord2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord2xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord2xvOES pglTexCoord2xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord3xOES(IntPtr s, IntPtr t, IntPtr r);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord3xOES pglTexCoord3xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord3xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord3xvOES pglTexCoord3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord4xOES(IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord4xOES pglTexCoord4xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexCoord4xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glTexCoord4xvOES pglTexCoord4xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexGenxOES(Int32 coord, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGenxOES pglTexGenxOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glTexGenxvOES(Int32 coord, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_OES_fixed_point")]
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[ThreadStatic]
			internal static glTexGenxvOES pglTexGenxvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex2xOES(IntPtr x);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex2xOES pglVertex2xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex2xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex2xvOES pglVertex2xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex3xOES(IntPtr x, IntPtr y);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex3xOES pglVertex3xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex3xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex3xvOES pglVertex3xvOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex4xOES(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex4xOES pglVertex4xOES;

			[RequiredByFeature("GL_OES_fixed_point")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glVertex4xvOES(IntPtr* coords);

			[RequiredByFeature("GL_OES_fixed_point")]
			[ThreadStatic]
			internal static glVertex4xvOES pglVertex4xvOES;

		}
	}

}
