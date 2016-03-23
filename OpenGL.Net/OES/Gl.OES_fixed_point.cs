
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
		/// Binding for glAlphaFuncxOES.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void AlphaFuncOES(Int32 func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncxOES != null, "pglAlphaFuncxOES not implemented");
			Delegates.pglAlphaFuncxOES(func, @ref);
			LogFunction("glAlphaFuncxOES({0}, 0x{1})", LogEnumName(func), @ref.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearColorxOES.
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
			LogFunction("glClearColorxOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearDepthxOES.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ClearDepthOES(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthxOES != null, "pglClearDepthxOES not implemented");
			Delegates.pglClearDepthxOES(depth);
			LogFunction("glClearDepthxOES(0x{0})", depth.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClipPlanexOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ClipPlaneOES(Int32 plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanexOES != null, "pglClipPlanexOES not implemented");
					Delegates.pglClipPlanexOES(plane, p_equation);
					LogFunction("glClipPlanexOES({0}, {1})", LogEnumName(plane), LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColor4xOES.
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
			LogFunction("glColor4xOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthRangexOES.
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
			LogFunction("glDepthRangexOES(0x{0}, 0x{1})", n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FogOES(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogxOES != null, "pglFogxOES not implemented");
			Delegates.pglFogxOES(pname, param);
			LogFunction("glFogxOES({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFogxvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FogOES(Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxvOES != null, "pglFogxvOES not implemented");
					Delegates.pglFogxvOES(pname, p_param);
					LogFunction("glFogxvOES({0}, {1})", LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFrustumxOES.
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
			LogFunction("glFrustumxOES(0x{0}, 0x{1}, 0x{2}, 0x{3}, 0x{4}, 0x{5})", l.ToString("X8"), r.ToString("X8"), b.ToString("X8"), t.ToString("X8"), n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetClipPlanexOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetClipPlaneOES(Int32 plane, [Out] IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanexOES != null, "pglGetClipPlanexOES not implemented");
					Delegates.pglGetClipPlanexOES(plane, p_equation);
					LogFunction("glGetClipPlanexOES({0}, {1})", LogEnumName(plane), LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFixedvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetFixedOES(Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedvOES != null, "pglGetFixedvOES not implemented");
					Delegates.pglGetFixedvOES(pname, p_params);
					LogFunction("glGetFixedvOES({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexEnvxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetTexEnvOES(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxvOES != null, "pglGetTexEnvxvOES not implemented");
					Delegates.pglGetTexEnvxvOES(target, pname, p_params);
					LogFunction("glGetTexEnvxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexParameterxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetTexParameterOES(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxvOES != null, "pglGetTexParameterxvOES not implemented");
					Delegates.pglGetTexParameterxvOES(target, pname, p_params);
					LogFunction("glGetTexParameterxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightModelxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightModelOES(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelxOES != null, "pglLightModelxOES not implemented");
			Delegates.pglLightModelxOES(pname, param);
			LogFunction("glLightModelxOES({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightModelxvOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightModelOES(Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxvOES != null, "pglLightModelxvOES not implemented");
					Delegates.pglLightModelxvOES(pname, p_param);
					LogFunction("glLightModelxvOES({0}, {1})", LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightxOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightxOES(Int32 light, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightxOES != null, "pglLightxOES not implemented");
			Delegates.pglLightxOES(light, pname, param);
			LogFunction("glLightxOES({0}, {1}, 0x{2})", LogEnumName(light), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LightxvOES(Int32 light, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxvOES != null, "pglLightxvOES not implemented");
					Delegates.pglLightxvOES(light, pname, p_params);
					LogFunction("glLightxvOES({0}, {1}, {2})", LogEnumName(light), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLineWidthxOES.
		/// </summary>
		/// <param name="width">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LineWidthOES(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthxOES != null, "pglLineWidthxOES not implemented");
			Delegates.pglLineWidthxOES(width);
			LogFunction("glLineWidthxOES(0x{0})", width.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadMatrixxOES.
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
					LogFunction("glLoadMatrixxOES({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MaterialOES(Int32 face, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialxOES != null, "pglMaterialxOES not implemented");
			Delegates.pglMaterialxOES(face, pname, param);
			LogFunction("glMaterialxOES({0}, {1}, 0x{2})", LogEnumName(face), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MaterialOES(Int32 face, Int32 pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxvOES != null, "pglMaterialxvOES not implemented");
					Delegates.pglMaterialxvOES(face, pname, p_param);
					LogFunction("glMaterialxvOES({0}, {1}, {2})", LogEnumName(face), LogEnumName(pname), LogValue(param));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultMatrixxOES.
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
					LogFunction("glMultMatrixxOES({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord4xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
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
		public static void MultiTexCoord4OES(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4xOES != null, "pglMultiTexCoord4xOES not implemented");
			Delegates.pglMultiTexCoord4xOES(texture, s, t, r, q);
			LogFunction("glMultiTexCoord4xOES({0}, 0x{1}, 0x{2}, 0x{3}, 0x{4})", LogEnumName(texture), s.ToString("X8"), t.ToString("X8"), r.ToString("X8"), q.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormal3xOES.
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
			LogFunction("glNormal3xOES(0x{0}, 0x{1}, 0x{2})", nx.ToString("X8"), ny.ToString("X8"), nz.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glOrthoxOES.
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
			LogFunction("glOrthoxOES(0x{0}, 0x{1}, 0x{2}, 0x{3}, 0x{4}, 0x{5})", l.ToString("X8"), r.ToString("X8"), b.ToString("X8"), t.ToString("X8"), n.ToString("X8"), f.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointParameterxvOES.
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
					LogFunction("glPointParameterxvOES({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointSizexOES.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PointSizeOES(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizexOES != null, "pglPointSizexOES not implemented");
			Delegates.pglPointSizexOES(size);
			LogFunction("glPointSizexOES(0x{0})", size.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPolygonOffsetxOES.
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
			LogFunction("glPolygonOffsetxOES(0x{0}, 0x{1})", factor.ToString("X8"), units.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRotatexOES.
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
			LogFunction("glRotatexOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", angle.ToString("X8"), x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glScalexOES.
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
			LogFunction("glScalexOES(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexEnvxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexEnvOES(Int32 target, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvxOES != null, "pglTexEnvxOES not implemented");
			Delegates.pglTexEnvxOES(target, pname, param);
			LogFunction("glTexEnvxOES({0}, {1}, 0x{2})", LogEnumName(target), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexEnvxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexEnvOES(Int32 target, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxvOES != null, "pglTexEnvxvOES not implemented");
					Delegates.pglTexEnvxvOES(target, pname, p_params);
					LogFunction("glTexEnvxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexParameterxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexParameterOES(Int32 target, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterxOES != null, "pglTexParameterxOES not implemented");
			Delegates.pglTexParameterxOES(target, pname, param);
			LogFunction("glTexParameterxOES({0}, {1}, 0x{2})", LogEnumName(target), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexParameterxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexParameterOES(Int32 target, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxvOES != null, "pglTexParameterxvOES not implemented");
					Delegates.pglTexParameterxvOES(target, pname, p_params);
					LogFunction("glTexParameterxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTranslatexOES.
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
			LogFunction("glTranslatexOES(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLightxvOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetLightxvOES(Int32 light, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxvOES != null, "pglGetLightxvOES not implemented");
					Delegates.pglGetLightxvOES(light, pname, p_params);
					LogFunction("glGetLightxvOES({0}, {1}, {2})", LogEnumName(light), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMaterialxvOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetMaterialOES(Int32 face, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxvOES != null, "pglGetMaterialxvOES not implemented");
					Delegates.pglGetMaterialxvOES(face, pname, p_params);
					LogFunction("glGetMaterialxvOES({0}, {1}, {2})", LogEnumName(face), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointParameterxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PointParameterOES(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterxOES != null, "pglPointParameterxOES not implemented");
			Delegates.pglPointParameterxOES(pname, param);
			LogFunction("glPointParameterxOES({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSampleCoveragexOES.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="invert">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void SampleCoverageOES(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragexOES != null, "pglSampleCoveragexOES not implemented");
			Delegates.pglSampleCoveragexOES(value, invert);
			LogFunction("glSampleCoveragexOES({0}, {1})", value, invert);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glAccumxOES.
		/// </summary>
		/// <param name="op">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void AccumOES(Int32 op, IntPtr value)
		{
			Debug.Assert(Delegates.pglAccumxOES != null, "pglAccumxOES not implemented");
			Delegates.pglAccumxOES(op, value);
			LogFunction("glAccumxOES({0}, 0x{1})", LogEnumName(op), value.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBitmapxOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void BitmapOES(Int32 width, Int32 height, IntPtr xorig, IntPtr yorig, IntPtr xmove, IntPtr ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmapxOES != null, "pglBitmapxOES not implemented");
					Delegates.pglBitmapxOES(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					LogFunction("glBitmapxOES({0}, {1}, 0x{2}, 0x{3}, 0x{4}, 0x{5}, {6})", width, height, xorig.ToString("X8"), yorig.ToString("X8"), xmove.ToString("X8"), ymove.ToString("X8"), LogValue(bitmap));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glBlendColorxOES.
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
		public static void BlendColorOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglBlendColorxOES != null, "pglBlendColorxOES not implemented");
			Delegates.pglBlendColorxOES(red, green, blue, alpha);
			LogFunction("glBlendColorxOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearAccumxOES.
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
		public static void ClearAccumOES(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearAccumxOES != null, "pglClearAccumxOES not implemented");
			Delegates.pglClearAccumxOES(red, green, blue, alpha);
			LogFunction("glClearAccumxOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"), alpha.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColor3xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Color3OES(IntPtr red, IntPtr green, IntPtr blue)
		{
			Debug.Assert(Delegates.pglColor3xOES != null, "pglColor3xOES not implemented");
			Delegates.pglColor3xOES(red, green, blue);
			LogFunction("glColor3xOES(0x{0}, 0x{1}, 0x{2})", red.ToString("X8"), green.ToString("X8"), blue.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColor3xvOES.
		/// </summary>
		/// <param name="components">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Color3OES(IntPtr[] components)
		{
			unsafe {
				fixed (IntPtr* p_components = components)
				{
					Debug.Assert(Delegates.pglColor3xvOES != null, "pglColor3xvOES not implemented");
					Delegates.pglColor3xvOES(p_components);
					LogFunction("glColor3xvOES({0})", LogValue(components));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColor4xvOES.
		/// </summary>
		/// <param name="components">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Color4OES(IntPtr[] components)
		{
			unsafe {
				fixed (IntPtr* p_components = components)
				{
					Debug.Assert(Delegates.pglColor4xvOES != null, "pglColor4xvOES not implemented");
					Delegates.pglColor4xvOES(p_components);
					LogFunction("glColor4xvOES({0})", LogValue(components));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glConvolutionParameterxOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ConvolutionParameterOES(Int32 target, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglConvolutionParameterxOES != null, "pglConvolutionParameterxOES not implemented");
			Delegates.pglConvolutionParameterxOES(target, pname, param);
			LogFunction("glConvolutionParameterxOES({0}, {1}, 0x{2})", LogEnumName(target), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glConvolutionParameterxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void ConvolutionParameterOES(Int32 target, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglConvolutionParameterxvOES != null, "pglConvolutionParameterxvOES not implemented");
					Delegates.pglConvolutionParameterxvOES(target, pname, p_params);
					LogFunction("glConvolutionParameterxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvalCoord1xOES.
		/// </summary>
		/// <param name="u">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void EvalCoord1OES(IntPtr u)
		{
			Debug.Assert(Delegates.pglEvalCoord1xOES != null, "pglEvalCoord1xOES not implemented");
			Delegates.pglEvalCoord1xOES(u);
			LogFunction("glEvalCoord1xOES(0x{0})", u.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvalCoord1xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void EvalCoord1OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglEvalCoord1xvOES != null, "pglEvalCoord1xvOES not implemented");
					Delegates.pglEvalCoord1xvOES(p_coords);
					LogFunction("glEvalCoord1xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvalCoord2xOES.
		/// </summary>
		/// <param name="u">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void EvalCoord2OES(IntPtr u, IntPtr v)
		{
			Debug.Assert(Delegates.pglEvalCoord2xOES != null, "pglEvalCoord2xOES not implemented");
			Delegates.pglEvalCoord2xOES(u, v);
			LogFunction("glEvalCoord2xOES(0x{0}, 0x{1})", u.ToString("X8"), v.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvalCoord2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void EvalCoord2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglEvalCoord2xvOES != null, "pglEvalCoord2xvOES not implemented");
					Delegates.pglEvalCoord2xvOES(p_coords);
					LogFunction("glEvalCoord2xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFeedbackBufferxOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void FeedbackBufferOES(Int32 type, IntPtr[] buffer)
		{
			unsafe {
				fixed (IntPtr* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBufferxOES != null, "pglFeedbackBufferxOES not implemented");
					Delegates.pglFeedbackBufferxOES((Int32)buffer.Length, type, p_buffer);
					LogFunction("glFeedbackBufferxOES({0}, {1}, {2})", buffer.Length, LogEnumName(type), LogValue(buffer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetConvolutionParameterxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetConvolutionParameterOES(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetConvolutionParameterxvOES != null, "pglGetConvolutionParameterxvOES not implemented");
					Delegates.pglGetConvolutionParameterxvOES(target, pname, p_params);
					LogFunction("glGetConvolutionParameterxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetHistogramParameterxvOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetHistogramParameterOES(Int32 target, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetHistogramParameterxvOES != null, "pglGetHistogramParameterxvOES not implemented");
					Delegates.pglGetHistogramParameterxvOES(target, pname, p_params);
					LogFunction("glGetHistogramParameterxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetLightxOES.
		/// </summary>
		/// <param name="light">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetLightxOES(Int32 light, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxOES != null, "pglGetLightxOES not implemented");
					Delegates.pglGetLightxOES(light, pname, p_params);
					LogFunction("glGetLightxOES({0}, {1}, {2})", LogEnumName(light), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMapxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetMapOES(Int32 target, Int32 query, [Out] IntPtr[] v)
		{
			unsafe {
				fixed (IntPtr* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapxvOES != null, "pglGetMapxvOES not implemented");
					Delegates.pglGetMapxvOES(target, query, p_v);
					LogFunction("glGetMapxvOES({0}, {1}, {2})", LogEnumName(target), LogEnumName(query), LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetMaterialOES(Int32 face, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglGetMaterialxOES != null, "pglGetMaterialxOES not implemented");
			Delegates.pglGetMaterialxOES(face, pname, param);
			LogFunction("glGetMaterialxOES({0}, {1}, 0x{2})", LogEnumName(face), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetMaterialxOES.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetMaterialOES(Int32 face, Int32 pname, Object param)
		{
			GCHandle pin_param = GCHandle.Alloc(param, GCHandleType.Pinned);
			try {
				GetMaterialOES(face, pname, pin_param.AddrOfPinnedObject());
			} finally {
				pin_param.Free();
			}
		}

		/// <summary>
		/// Binding for glGetPixelMapxv.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetPixelMap(Int32 map, [Out] IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapxv != null, "pglGetPixelMapxv not implemented");
					Delegates.pglGetPixelMapxv(map, (Int32)values.Length, p_values);
					LogFunction("glGetPixelMapxv({0}, {1}, {2})", LogEnumName(map), values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexGenxvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(Int32 coord, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenxvOES != null, "pglGetTexGenxvOES not implemented");
					Delegates.pglGetTexGenxvOES(coord, pname, p_params);
					LogFunction("glGetTexGenxvOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexLevelParameterxvOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void GetTexLevelParameterOES(Int32 target, Int32 level, Int32 pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterxvOES != null, "pglGetTexLevelParameterxvOES not implemented");
					Delegates.pglGetTexLevelParameterxvOES(target, level, pname, p_params);
					LogFunction("glGetTexLevelParameterxvOES({0}, {1}, {2}, {3})", LogEnumName(target), level, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexxOES.
		/// </summary>
		/// <param name="component">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void IndexOES(IntPtr component)
		{
			Debug.Assert(Delegates.pglIndexxOES != null, "pglIndexxOES not implemented");
			Delegates.pglIndexxOES(component);
			LogFunction("glIndexxOES(0x{0})", component.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIndexxvOES.
		/// </summary>
		/// <param name="component">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void IndexOES(IntPtr[] component)
		{
			unsafe {
				fixed (IntPtr* p_component = component)
				{
					Debug.Assert(Delegates.pglIndexxvOES != null, "pglIndexxvOES not implemented");
					Delegates.pglIndexxvOES(p_component);
					LogFunction("glIndexxvOES({0})", LogValue(component));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadTransposeMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void LoadTransposeMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadTransposeMatrixxOES != null, "pglLoadTransposeMatrixxOES not implemented");
					Delegates.pglLoadTransposeMatrixxOES(p_m);
					LogFunction("glLoadTransposeMatrixxOES({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMap1xOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Map1OES(Int32 target, IntPtr u1, IntPtr u2, Int32 stride, Int32 order, IntPtr points)
		{
			Debug.Assert(Delegates.pglMap1xOES != null, "pglMap1xOES not implemented");
			Delegates.pglMap1xOES(target, u1, u2, stride, order, points);
			LogFunction("glMap1xOES({0}, 0x{1}, 0x{2}, {3}, {4}, 0x{5})", LogEnumName(target), u1.ToString("X8"), u2.ToString("X8"), stride, order, points.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMap2xOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Map2OES(Int32 target, IntPtr u1, IntPtr u2, Int32 ustride, Int32 uorder, IntPtr v1, IntPtr v2, Int32 vstride, Int32 vorder, IntPtr points)
		{
			Debug.Assert(Delegates.pglMap2xOES != null, "pglMap2xOES not implemented");
			Delegates.pglMap2xOES(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			LogFunction("glMap2xOES({0}, 0x{1}, 0x{2}, {3}, {4}, 0x{5}, 0x{6}, {7}, {8}, 0x{9})", LogEnumName(target), u1.ToString("X8"), u2.ToString("X8"), ustride, uorder, v1.ToString("X8"), v2.ToString("X8"), vstride, vorder, points.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapGrid1xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MapGrid1OES(Int32 n, IntPtr u1, IntPtr u2)
		{
			Debug.Assert(Delegates.pglMapGrid1xOES != null, "pglMapGrid1xOES not implemented");
			Delegates.pglMapGrid1xOES(n, u1, u2);
			LogFunction("glMapGrid1xOES({0}, 0x{1}, 0x{2})", n, u1.ToString("X8"), u2.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapGrid2xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MapGrid2OES(Int32 n, IntPtr u1, IntPtr u2, IntPtr v1, IntPtr v2)
		{
			Debug.Assert(Delegates.pglMapGrid2xOES != null, "pglMapGrid2xOES not implemented");
			Delegates.pglMapGrid2xOES(n, u1, u2, v1, v2);
			LogFunction("glMapGrid2xOES({0}, 0x{1}, 0x{2}, 0x{3}, 0x{4})", n, u1.ToString("X8"), u2.ToString("X8"), v1.ToString("X8"), v2.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultTransposeMatrixxOES.
		/// </summary>
		/// <param name="m">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultTransposeMatrixxOES(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultTransposeMatrixxOES != null, "pglMultTransposeMatrixxOES not implemented");
					Delegates.pglMultTransposeMatrixxOES(p_m);
					LogFunction("glMultTransposeMatrixxOES({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord1xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord1OES(Int32 texture, IntPtr s)
		{
			Debug.Assert(Delegates.pglMultiTexCoord1xOES != null, "pglMultiTexCoord1xOES not implemented");
			Delegates.pglMultiTexCoord1xOES(texture, s);
			LogFunction("glMultiTexCoord1xOES({0}, 0x{1})", LogEnumName(texture), s.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord1xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord1OES(Int32 texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord1xvOES != null, "pglMultiTexCoord1xvOES not implemented");
					Delegates.pglMultiTexCoord1xvOES(texture, p_coords);
					LogFunction("glMultiTexCoord1xvOES({0}, {1})", LogEnumName(texture), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord2xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord2OES(Int32 texture, IntPtr s, IntPtr t)
		{
			Debug.Assert(Delegates.pglMultiTexCoord2xOES != null, "pglMultiTexCoord2xOES not implemented");
			Delegates.pglMultiTexCoord2xOES(texture, s, t);
			LogFunction("glMultiTexCoord2xOES({0}, 0x{1}, 0x{2})", LogEnumName(texture), s.ToString("X8"), t.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord2xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord2OES(Int32 texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord2xvOES != null, "pglMultiTexCoord2xvOES not implemented");
					Delegates.pglMultiTexCoord2xvOES(texture, p_coords);
					LogFunction("glMultiTexCoord2xvOES({0}, {1})", LogEnumName(texture), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord3xOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord3OES(Int32 texture, IntPtr s, IntPtr t, IntPtr r)
		{
			Debug.Assert(Delegates.pglMultiTexCoord3xOES != null, "pglMultiTexCoord3xOES not implemented");
			Delegates.pglMultiTexCoord3xOES(texture, s, t, r);
			LogFunction("glMultiTexCoord3xOES({0}, 0x{1}, 0x{2}, 0x{3})", LogEnumName(texture), s.ToString("X8"), t.ToString("X8"), r.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord3xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord3OES(Int32 texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord3xvOES != null, "pglMultiTexCoord3xvOES not implemented");
					Delegates.pglMultiTexCoord3xvOES(texture, p_coords);
					LogFunction("glMultiTexCoord3xvOES({0}, {1})", LogEnumName(texture), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMultiTexCoord4xvOES.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void MultiTexCoord4OES(Int32 texture, IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglMultiTexCoord4xvOES != null, "pglMultiTexCoord4xvOES not implemented");
					Delegates.pglMultiTexCoord4xvOES(texture, p_coords);
					LogFunction("glMultiTexCoord4xvOES({0}, {1})", LogEnumName(texture), LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormal3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Normal3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglNormal3xvOES != null, "pglNormal3xvOES not implemented");
					Delegates.pglNormal3xvOES(p_coords);
					LogFunction("glNormal3xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPassThroughxOES.
		/// </summary>
		/// <param name="token">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PassThroughOES(IntPtr token)
		{
			Debug.Assert(Delegates.pglPassThroughxOES != null, "pglPassThroughxOES not implemented");
			Delegates.pglPassThroughxOES(token);
			LogFunction("glPassThroughxOES(0x{0})", token.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelMapx.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PixelMap(Int32 map, IntPtr[] values)
		{
			unsafe {
				fixed (IntPtr* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapx != null, "pglPixelMapx not implemented");
					Delegates.pglPixelMapx(map, (Int32)values.Length, p_values);
					LogFunction("glPixelMapx({0}, {1}, {2})", LogEnumName(map), values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelStorex.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PixelStore(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPixelStorex != null, "pglPixelStorex not implemented");
			Delegates.pglPixelStorex(pname, param);
			LogFunction("glPixelStorex({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelTransferxOES.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PixelTransferOES(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPixelTransferxOES != null, "pglPixelTransferxOES not implemented");
			Delegates.pglPixelTransferxOES(pname, param);
			LogFunction("glPixelTransferxOES({0}, 0x{1})", LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPixelZoomxOES.
		/// </summary>
		/// <param name="xfactor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="yfactor">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PixelZoomOES(IntPtr xfactor, IntPtr yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoomxOES != null, "pglPixelZoomxOES not implemented");
			Delegates.pglPixelZoomxOES(xfactor, yfactor);
			LogFunction("glPixelZoomxOES(0x{0}, 0x{1})", xfactor.ToString("X8"), yfactor.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPrioritizeTexturesxOES.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="priorities">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void PrioritizeTexturesOES(UInt32[] textures, IntPtr[] priorities)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (IntPtr* p_priorities = priorities)
				{
					Debug.Assert(Delegates.pglPrioritizeTexturesxOES != null, "pglPrioritizeTexturesxOES not implemented");
					Delegates.pglPrioritizeTexturesxOES((Int32)textures.Length, p_textures, p_priorities);
					LogFunction("glPrioritizeTexturesxOES({0}, {1}, {2})", textures.Length, LogValue(textures), LogValue(priorities));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos2xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RasterPos2OES(IntPtr x, IntPtr y)
		{
			Debug.Assert(Delegates.pglRasterPos2xOES != null, "pglRasterPos2xOES not implemented");
			Delegates.pglRasterPos2xOES(x, y);
			LogFunction("glRasterPos2xOES(0x{0}, 0x{1})", x.ToString("X8"), y.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RasterPos2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos2xvOES != null, "pglRasterPos2xvOES not implemented");
					Delegates.pglRasterPos2xvOES(p_coords);
					LogFunction("glRasterPos2xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos3xOES.
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
		public static void RasterPos3OES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRasterPos3xOES != null, "pglRasterPos3xOES not implemented");
			Delegates.pglRasterPos3xOES(x, y, z);
			LogFunction("glRasterPos3xOES(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RasterPos3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos3xvOES != null, "pglRasterPos3xvOES not implemented");
					Delegates.pglRasterPos3xvOES(p_coords);
					LogFunction("glRasterPos3xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos4xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RasterPos4OES(IntPtr x, IntPtr y, IntPtr z, IntPtr w)
		{
			Debug.Assert(Delegates.pglRasterPos4xOES != null, "pglRasterPos4xOES not implemented");
			Delegates.pglRasterPos4xOES(x, y, z, w);
			LogFunction("glRasterPos4xOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"), w.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRasterPos4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RasterPos4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglRasterPos4xvOES != null, "pglRasterPos4xvOES not implemented");
					Delegates.pglRasterPos4xvOES(p_coords);
					LogFunction("glRasterPos4xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRectxOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RectOES(IntPtr x1, IntPtr y1, IntPtr x2, IntPtr y2)
		{
			Debug.Assert(Delegates.pglRectxOES != null, "pglRectxOES not implemented");
			Delegates.pglRectxOES(x1, y1, x2, y2);
			LogFunction("glRectxOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", x1.ToString("X8"), y1.ToString("X8"), x2.ToString("X8"), y2.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glRectxvOES.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void RectOES(IntPtr[] v1, IntPtr[] v2)
		{
			unsafe {
				fixed (IntPtr* p_v1 = v1)
				fixed (IntPtr* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectxvOES != null, "pglRectxvOES not implemented");
					Delegates.pglRectxvOES(p_v1, p_v2);
					LogFunction("glRectxvOES({0}, {1})", LogValue(v1), LogValue(v2));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord1xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord1OES(IntPtr s)
		{
			Debug.Assert(Delegates.pglTexCoord1xOES != null, "pglTexCoord1xOES not implemented");
			Delegates.pglTexCoord1xOES(s);
			LogFunction("glTexCoord1xOES(0x{0})", s.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord1xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord1OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord1xvOES != null, "pglTexCoord1xvOES not implemented");
					Delegates.pglTexCoord1xvOES(p_coords);
					LogFunction("glTexCoord1xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord2xOES.
		/// </summary>
		/// <param name="s">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord2OES(IntPtr s, IntPtr t)
		{
			Debug.Assert(Delegates.pglTexCoord2xOES != null, "pglTexCoord2xOES not implemented");
			Delegates.pglTexCoord2xOES(s, t);
			LogFunction("glTexCoord2xOES(0x{0}, 0x{1})", s.ToString("X8"), t.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord2xvOES != null, "pglTexCoord2xvOES not implemented");
					Delegates.pglTexCoord2xvOES(p_coords);
					LogFunction("glTexCoord2xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord3xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord3OES(IntPtr s, IntPtr t, IntPtr r)
		{
			Debug.Assert(Delegates.pglTexCoord3xOES != null, "pglTexCoord3xOES not implemented");
			Delegates.pglTexCoord3xOES(s, t, r);
			LogFunction("glTexCoord3xOES(0x{0}, 0x{1}, 0x{2})", s.ToString("X8"), t.ToString("X8"), r.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord3xvOES != null, "pglTexCoord3xvOES not implemented");
					Delegates.pglTexCoord3xvOES(p_coords);
					LogFunction("glTexCoord3xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord4xOES.
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
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord4OES(IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglTexCoord4xOES != null, "pglTexCoord4xOES not implemented");
			Delegates.pglTexCoord4xOES(s, t, r, q);
			LogFunction("glTexCoord4xOES(0x{0}, 0x{1}, 0x{2}, 0x{3})", s.ToString("X8"), t.ToString("X8"), r.ToString("X8"), q.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoord4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void TexCoord4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglTexCoord4xvOES != null, "pglTexCoord4xvOES not implemented");
					Delegates.pglTexCoord4xvOES(p_coords);
					LogFunction("glTexCoord4xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexGenxOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexGenxOES != null, "pglTexGenxOES not implemented");
			Delegates.pglTexGenxOES(coord, pname, param);
			LogFunction("glTexGenxOES({0}, {1}, 0x{2})", LogEnumName(coord), LogEnumName(pname), param.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexGenxvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenxvOES != null, "pglTexGenxvOES not implemented");
					Delegates.pglTexGenxvOES(coord, pname, p_params);
					LogFunction("glTexGenxvOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex2xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Vertex2OES(IntPtr x)
		{
			Debug.Assert(Delegates.pglVertex2xOES != null, "pglVertex2xOES not implemented");
			Delegates.pglVertex2xOES(x);
			LogFunction("glVertex2xOES(0x{0})", x.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex2xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Vertex2OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex2xvOES != null, "pglVertex2xvOES not implemented");
					Delegates.pglVertex2xvOES(p_coords);
					LogFunction("glVertex2xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex3xOES.
		/// </summary>
		/// <param name="x">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Vertex3OES(IntPtr x, IntPtr y)
		{
			Debug.Assert(Delegates.pglVertex3xOES != null, "pglVertex3xOES not implemented");
			Delegates.pglVertex3xOES(x, y);
			LogFunction("glVertex3xOES(0x{0}, 0x{1})", x.ToString("X8"), y.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex3xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Vertex3OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex3xvOES != null, "pglVertex3xvOES not implemented");
					Delegates.pglVertex3xvOES(p_coords);
					LogFunction("glVertex3xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex4xOES.
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
		public static void Vertex4OES(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglVertex4xOES != null, "pglVertex4xOES not implemented");
			Delegates.pglVertex4xOES(x, y, z);
			LogFunction("glVertex4xOES(0x{0}, 0x{1}, 0x{2})", x.ToString("X8"), y.ToString("X8"), z.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertex4xvOES.
		/// </summary>
		/// <param name="coords">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public static void Vertex4OES(IntPtr[] coords)
		{
			unsafe {
				fixed (IntPtr* p_coords = coords)
				{
					Debug.Assert(Delegates.pglVertex4xvOES != null, "pglVertex4xvOES not implemented");
					Delegates.pglVertex4xvOES(p_coords);
					LogFunction("glVertex4xvOES({0})", LogValue(coords));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
