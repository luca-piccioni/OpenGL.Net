
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
		/// [GL] Value of GL_VERSION_ES_CL_1_0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CL_1_0 = 1;

		/// <summary>
		/// [GL] Value of GL_VERSION_ES_CM_1_1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CM_1_1 = 1;

		/// <summary>
		/// [GL] Value of GL_VERSION_ES_CL_1_1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int VERSION_ES_CL_1_1 = 1;

		/// <summary>
		/// [GLES1.1] specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		public static void ClipPlane(ClipPlaneName p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanef != null, "pglClipPlanef not implemented");
					Delegates.pglClipPlanef((Int32)p, p_eqn);
					LogCommand("glClipPlanef", null, p, eqn					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix by a perspective matrix
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="near"/> or <paramref name="far"/> is not positive, or if <paramref 
		/// name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = <paramref name="top"/>, or <paramref 
		/// name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		public static void Frustum(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumf != null, "pglFrustumf not implemented");
			Delegates.pglFrustumf(l, r, b, t, n, f);
			LogCommand("glFrustumf", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return the coefficients of the specified clipping plane
		/// </summary>
		/// <param name="plane">
		/// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping 
		/// planes are supported. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer between 0 and 
		/// Gl.MAX_CLIP_PLANES-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Returns four fixed-point or floating-point values that are the coefficients of the plane equation of <paramref 
		/// name="plane"/> in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.ClipPlane"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		public static void GetClipPlane(ClipPlaneName plane, [Out] float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanef != null, "pglGetClipPlanef not implemented");
					Delegates.pglGetClipPlanef((Int32)plane, p_equation);
					LogCommand("glGetClipPlanef", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix with an orthographic matrix
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = 
		/// <paramref name="top"/>, or <paramref name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
		public static void Ortho(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthof != null, "pglOrthof not implemented");
			Delegates.pglOrthof(l, r, b, t, n, f);
			LogCommand("glOrthof", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify the alpha test function
		/// </summary>
		/// <param name="func">
		/// Specifies the alpha comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER, 
		/// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range [0, 1], 
		/// where 0 represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void AlphaFunc(AlphaFunction func, IntPtr @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncx != null, "pglAlphaFuncx not implemented");
			Delegates.pglAlphaFuncx((Int32)func, @ref);
			LogCommand("glAlphaFuncx", null, func, @ref			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify clear values for the color buffer
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the color buffer is cleared. The initial values are all 0.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.ColorMask"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClearColor(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglClearColorx != null, "pglClearColorx not implemented");
			Delegates.pglClearColorx(red, green, blue, alpha);
			LogCommand("glClearColorx", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify the clear value for the depth buffer
		/// </summary>
		/// <param name="depth">
		/// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthMask"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClearDepth(IntPtr depth)
		{
			Debug.Assert(Delegates.pglClearDepthx != null, "pglClearDepthx not implemented");
			Delegates.pglClearDepthx(depth);
			LogCommand("glClearDepthx", null, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="plane">
		/// Specifies which clipping plane is being positioned. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer 
		/// between 0 and Gl.MAX_CLIP_PLANES-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Specifies the address of an array of four fixed-point or floating-point values. These are the coefficients of a plane 
		/// equation in object coordinates: p1, p2, p3, and p4, in that order.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void ClipPlane(ClipPlaneName plane, IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanex != null, "pglClipPlanex not implemented");
					Delegates.pglClipPlanex((Int32)plane, p_equation);
					LogCommand("glClipPlanex", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, blue, and alpha values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, blue, and alpha values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, blue, and alpha values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specify new red, green, blue, and alpha values for the current color.
		/// </param>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Color4(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha)
		{
			Debug.Assert(Delegates.pglColor4x != null, "pglColor4x not implemented");
			Delegates.pglColor4x(red, green, blue, alpha);
			LogCommand("glColor4x", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void DepthRange(IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglDepthRangex != null, "pglDepthRangex not implemented");
			Delegates.pglDepthRangex(n, f);
			LogCommand("glDepthRangex", null, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, and Gl.FOG_END are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY, and <paramref name="params"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Fog(FogPName pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglFogx != null, "pglFogx not implemented");
			Delegates.pglFogx((Int32)pname, param);
			LogCommand("glFogx", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, and Gl.FOG_END are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY, and <paramref name="params"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Fog(FogPName pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglFogxv != null, "pglFogxv not implemented");
					Delegates.pglFogxv((Int32)pname, p_param);
					LogCommand("glFogxv", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix by a perspective matrix
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="near"/> or <paramref name="far"/> is not positive, or if <paramref 
		/// name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = <paramref name="top"/>, or <paramref 
		/// name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Frustum(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglFrustumx != null, "pglFrustumx not implemented");
			Delegates.pglFrustumx(l, r, b, t, n, f);
			LogCommand("glFrustumx", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return the coefficients of the specified clipping plane
		/// </summary>
		/// <param name="plane">
		/// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping 
		/// planes are supported. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer between 0 and 
		/// Gl.MAX_CLIP_PLANES-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Returns four fixed-point or floating-point values that are the coefficients of the plane equation of <paramref 
		/// name="plane"/> in eye coordinates in the order p1, p2, p3, and p4. The initial value is (0, 0, 0, 0).
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.ClipPlane"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetClipPlane(ClipPlaneName plane, [Out] IntPtr[] equation)
		{
			unsafe {
				fixed (IntPtr* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanex != null, "pglGetClipPlanex not implemented");
					Delegates.pglGetClipPlanex((Int32)plane, p_equation);
					LogCommand("glGetClipPlanex", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned. The symbolic constants in the list below are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetString"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetFixed(GetPName pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFixedv != null, "pglGetFixedv not implemented");
					Delegates.pglGetFixedv((Int32)pname, p_params);
					LogCommand("glGetFixedv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form GL_LIGHTi where 0&lt;i&lt;GL_MAX_LIGHTS
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for light. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, 
		/// Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and 
		/// Gl.QUADRATIC_ATTENUATION.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetLightxv(LightName light, LightParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightxv != null, "pglGetLightxv not implemented");
					Delegates.pglGetLightxv((Int32)light, (Int32)pname, p_params);
					LogCommand("glGetLightxv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return material parameters values
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and back 
		/// materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, 
		/// Gl.EMISSION, and Gl.SHININESS.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialxv != null, "pglGetMaterialxv not implemented");
					Delegates.pglGetMaterialxv((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetMaterialxv", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV or Gl.POINT_SPRITE_OES.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_ENV_COLOR, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE_OES.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexEnv"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvxv != null, "pglGetTexEnvxv not implemented");
					Delegates.pglGetTexEnvxv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexEnvxv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be Gl.TEXTURE_2D.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Which can be one of the following: Gl.TEXTURE_MIN_FILTER, 
		/// Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// Returns texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterxv != null, "pglGetTexParameterxv not implemented");
					Delegates.pglGetTexParameterxv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexParameterxv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Must be Gl.LIGHT_MODEL_TWO_SIDE.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LightModel(LightModelParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightModelx != null, "pglLightModelx not implemented");
			Delegates.pglLightModelx((Int32)pname, param);
			LogCommand("glLightModelx", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Must be Gl.LIGHT_MODEL_TWO_SIDE.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LightModel(LightModelParameter pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglLightModelxv != null, "pglLightModelxv not implemented");
					Delegates.pglLightModelxv((Int32)pname, p_param);
					LogCommand("glLightModelxv", null, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi where 0&lt;=i&lt;GL_MAX_LIGHTS.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range [0, 128], or if spot cutoff is 
		/// specified outside the range [0, 90] (except for the special value 180), or if a negative attenuation factor is 
		/// specified.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Lightx(LightName light, LightParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglLightx != null, "pglLightx not implemented");
			Delegates.pglLightx((Int32)light, (Int32)pname, param);
			LogCommand("glLightx", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi where 0&lt;=i&lt;GL_MAX_LIGHTS.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range [0, 128], or if spot cutoff is 
		/// specified outside the range [0, 90] (except for the special value 180), or if a negative attenuation factor is 
		/// specified.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Lightxv(LightName light, LightParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightxv != null, "pglLightxv not implemented");
					Delegates.pglLightxv((Int32)light, (Int32)pname, p_params);
					LogCommand("glLightxv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify the width of rasterized lines
		/// </summary>
		/// <param name="width">
		/// Specifies the width of rasterized lines. The initial value is 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LineWidth(IntPtr width)
		{
			Debug.Assert(Delegates.pglLineWidthx != null, "pglLineWidthx not implemented");
			Delegates.pglLineWidthx(width);
			LogCommand("glLineWidthx", null, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4x4 column-major matrix.
		/// </param>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LoadMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixx != null, "pglLoadMatrixx not implemented");
					Delegates.pglLoadMatrixx(p_m);
					LogCommand("glLoadMatrixx", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range [0, 128] is specified.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Material(MaterialFace face, MaterialParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglMaterialx != null, "pglMaterialx not implemented");
			Delegates.pglMaterialx((Int32)face, (Int32)pname, param);
			LogCommand("glMaterialx", null, face, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range [0, 128] is specified.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Material(MaterialFace face, MaterialParameter pname, IntPtr[] param)
		{
			unsafe {
				fixed (IntPtr* p_param = param)
				{
					Debug.Assert(Delegates.pglMaterialxv != null, "pglMaterialxv not implemented");
					Delegates.pglMaterialxv((Int32)face, (Int32)pname, p_param);
					LogCommand("glMaterialxv", null, face, pname, param					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4x4 column-major matrix.
		/// </param>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void MultMatrixx(IntPtr[] m)
		{
			unsafe {
				fixed (IntPtr* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixx != null, "pglMultMatrixx not implemented");
					Delegates.pglMultMatrixx(p_m);
					LogCommand("glMultMatrixx", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the current texture coordinates
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:TextureUnit"/>.
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit.
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit.
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit.
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for <paramref name="target"/> texture unit.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void MultiTexCoord4(TextureUnit texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q)
		{
			Debug.Assert(Delegates.pglMultiTexCoord4x != null, "pglMultiTexCoord4x not implemented");
			Delegates.pglMultiTexCoord4x((Int32)texture, s, t, r, q);
			LogCommand("glMultiTexCoord4x", null, texture, s, t, r, q			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of the new current normal. 
		/// The initial value is (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of the new current normal. 
		/// The initial value is (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of the new current normal. 
		/// The initial value is (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Normal3(IntPtr nx, IntPtr ny, IntPtr nz)
		{
			Debug.Assert(Delegates.pglNormal3x != null, "pglNormal3x not implemented");
			Delegates.pglNormal3x(nx, ny, nz);
			LogCommand("glNormal3x", null, nx, ny, nz			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix with an orthographic matrix
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
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = 
		/// <paramref name="top"/>, or <paramref name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Orthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f)
		{
			Debug.Assert(Delegates.pglOrthox != null, "pglOrthox not implemented");
			Delegates.pglOrthox(l, r, b, t, n, f);
			LogCommand("glOrthox", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify parameters for point rasterization
		/// </summary>
		/// <param name="pname">
		/// Specifies the single-valued parameter to be updated. Can be either Gl.POINT_SIZE_MIN, Gl.POINT_SIZE_MAX, or 
		/// Gl.POINT_FADE_THRESHOLD_SIZE.
		/// </param>
		/// <param name="param">
		/// Specifies the value that the parameter will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if assigned values for Gl.POINT_SIZE_MIN, Gl.POINT_SIZE_MAX, or 
		/// Gl.POINT_FADE_THRESHOLD_SIZE are less then Gl.o.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointParameter(Int32 pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglPointParameterx != null, "pglPointParameterx not implemented");
			Delegates.pglPointParameterx(pname, param);
			LogCommand("glPointParameterx", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify parameters for point rasterization
		/// </summary>
		/// <param name="pname">
		/// Specifies the single-valued parameter to be updated. Can be either Gl.POINT_SIZE_MIN, Gl.POINT_SIZE_MAX, or 
		/// Gl.POINT_FADE_THRESHOLD_SIZE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if assigned values for Gl.POINT_SIZE_MIN, Gl.POINT_SIZE_MAX, or 
		/// Gl.POINT_FADE_THRESHOLD_SIZE are less then Gl.o.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointParameter(Int32 pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterxv != null, "pglPointParameterxv not implemented");
					Delegates.pglPointParameterxv(pname, p_params);
					LogCommand("glPointParameterxv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify the diameter of rasterized points
		/// </summary>
		/// <param name="size">
		/// Specifies the diameter of rasterized points. The initial value is 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointSize(IntPtr size)
		{
			Debug.Assert(Delegates.pglPointSizex != null, "pglPointSizex not implemented");
			Delegates.pglPointSizex(size);
			LogCommand("glPointSizex", null, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set the scale and units used to calculate depth values
		/// </summary>
		/// <param name="factor">
		/// Specifies a scale factor that is used to create a variable depth offset for each polygon. The initial value is 0.
		/// </param>
		/// <param name="units">
		/// Is multiplied by an implementation-specific value to create a constant depth offset. The initial value is 0.
		/// </param>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PolygonOffset(IntPtr factor, IntPtr units)
		{
			Debug.Assert(Delegates.pglPolygonOffsetx != null, "pglPolygonOffsetx not implemented");
			Delegates.pglPolygonOffsetx(factor, units);
			LogCommand("glPolygonOffsetx", null, factor, units			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees.
		/// </param>
		/// <param name="x">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a vector, respectively.
		/// </param>
		/// <param name="y">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a vector, respectively.
		/// </param>
		/// <param name="z">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a vector, respectively.
		/// </param>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Rotate(IntPtr angle, IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglRotatex != null, "pglRotatex not implemented");
			Delegates.pglRotatex(angle, x, y, z);
			LogCommand("glRotatex", null, angle, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] specify mask to modify multisampled pixel fragments
		/// </summary>
		/// <param name="value">
		/// Specifies the coverage of the modification mask. The value is clamped to the range [0, 1], where 0 represents no 
		/// coverage and 1 full coverage. The initial value is 1.
		/// </param>
		/// <param name="invert">
		/// Specifies whether the modification mask implied by <paramref name="value"/> is inverted or not. The initial value is 
		/// Gl.FALSE.
		/// </param>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void SampleCoverage(Int32 value, bool invert)
		{
			Debug.Assert(Delegates.pglSampleCoveragex != null, "pglSampleCoveragex not implemented");
			Delegates.pglSampleCoveragex(value, invert);
			LogCommand("glSampleCoveragex", null, value, invert			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix by a general scaling matrix
		/// </summary>
		/// <param name="x">
		/// Specify scale factors along the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> axes, respectively.
		/// </param>
		/// <param name="y">
		/// Specify scale factors along the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> axes, respectively.
		/// </param>
		/// <param name="z">
		/// Specify scale factors along the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> axes, respectively.
		/// </param>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Scale(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglScalex != null, "pglScalex not implemented");
			Delegates.pglScalex(x, y, z);
			LogCommand("glScalex", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV or Gl.POINT_SPRITE_OES.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, 
		/// Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, 
		/// Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE_OES.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.DOT3_RGB, Gl.DOT3_RGBA, Gl.INTERPOLATE, 
		/// Gl.MODULATE, Gl.DECAL, Gl.BLEND, Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, 
		/// Gl.PREVIOUS, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the 
		/// point sprite texture coordinate replacement, or 1.0, 2.0, or 4.0 when specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexEnvx != null, "pglTexEnvx not implemented");
			Delegates.pglTexEnvx((Int32)target, (Int32)pname, param);
			LogCommand("glTexEnvx", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV or Gl.POINT_SPRITE_OES.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, 
		/// Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, 
		/// Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE_OES.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvxv != null, "pglTexEnvxv not implemented");
					Delegates.pglTexEnvxv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexEnvxv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be Gl.TEXTURE_2D.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="param"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PixelStorei"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexParameter(TextureTarget target, GetTextureParameter pname, IntPtr param)
		{
			Debug.Assert(Delegates.pglTexParameterx != null, "pglTexParameterx not implemented");
			Delegates.pglTexParameterx((Int32)target, (Int32)pname, param);
			LogCommand("glTexParameterx", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be Gl.TEXTURE_2D.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. Which can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="param"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PixelStorei"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void TexParameter(TextureTarget target, GetTextureParameter pname, IntPtr[] @params)
		{
			unsafe {
				fixed (IntPtr* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterxv != null, "pglTexParameterxv not implemented");
					Delegates.pglTexParameterxv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexParameterxv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLES1.1] multiply the current matrix by a translation matrix
		/// </summary>
		/// <param name="x">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a translation vector.
		/// </param>
		/// <param name="y">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a translation vector.
		/// </param>
		/// <param name="z">
		/// Specify the <paramref name="x"/>, <paramref name="y"/>, and <paramref name="z"/> coordinates of a translation vector.
		/// </param>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void Translate(IntPtr x, IntPtr y, IntPtr z)
		{
			Debug.Assert(Delegates.pglTranslatex != null, "pglTranslatex not implemented");
			Delegates.pglTranslatex(x, y, z);
			LogCommand("glTranslatex", null, x, y, z			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanef(Int32 p, float* eqn);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustumf", ExactSpelling = true)]
			internal extern static void glFrustumf(float l, float r, float b, float t, float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlanef", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanef(Int32 plane, float* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrthof", ExactSpelling = true)]
			internal extern static void glOrthof(float l, float r, float b, float t, float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFuncx", ExactSpelling = true)]
			internal extern static unsafe void glAlphaFuncx(Int32 func, IntPtr @ref);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearColorx", ExactSpelling = true)]
			internal extern static unsafe void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepthx", ExactSpelling = true)]
			internal extern static unsafe void glClearDepthx(IntPtr depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanex(Int32 plane, IntPtr* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4x", ExactSpelling = true)]
			internal extern static unsafe void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRangex", ExactSpelling = true)]
			internal extern static unsafe void glDepthRangex(IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogx", ExactSpelling = true)]
			internal extern static unsafe void glFogx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogxv", ExactSpelling = true)]
			internal extern static unsafe void glFogxv(Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustumx", ExactSpelling = true)]
			internal extern static unsafe void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlanex", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFixedv", ExactSpelling = true)]
			internal extern static unsafe void glGetFixedv(Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightxv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelx", ExactSpelling = true)]
			internal extern static unsafe void glLightModelx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelxv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelxv(Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightx", ExactSpelling = true)]
			internal extern static unsafe void glLightx(Int32 light, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightxv", ExactSpelling = true)]
			internal extern static unsafe void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineWidthx", ExactSpelling = true)]
			internal extern static unsafe void glLineWidthx(IntPtr width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixx(IntPtr* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialx", ExactSpelling = true)]
			internal extern static unsafe void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialxv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixx", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixx(IntPtr* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiTexCoord4x", ExactSpelling = true)]
			internal extern static unsafe void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3x", ExactSpelling = true)]
			internal extern static unsafe void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrthox", ExactSpelling = true)]
			internal extern static unsafe void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterx", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterx(Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterxv(Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointSizex", ExactSpelling = true)]
			internal extern static unsafe void glPointSizex(IntPtr size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonOffsetx", ExactSpelling = true)]
			internal extern static unsafe void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotatex", ExactSpelling = true)]
			internal extern static unsafe void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSampleCoveragex", ExactSpelling = true)]
			internal extern static void glSampleCoveragex(Int32 value, bool invert);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScalex", ExactSpelling = true)]
			internal extern static unsafe void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvx", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvxv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterx", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterxv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslatex", ExactSpelling = true)]
			internal extern static unsafe void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanef(Int32 p, float* eqn);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[ThreadStatic]
			internal static glClipPlanef pglClipPlanef;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustumf(float l, float r, float b, float t, float n, float f);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[ThreadStatic]
			internal static glFrustumf pglFrustumf;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanef(Int32 plane, float* equation);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[ThreadStatic]
			internal static glGetClipPlanef pglGetClipPlanef;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrthof(float l, float r, float b, float t, float n, float f);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1", Profile = "common")]
			[ThreadStatic]
			internal static glOrthof pglOrthof;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glAlphaFuncx(Int32 func, IntPtr @ref);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glAlphaFuncx pglAlphaFuncx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearColorx(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glClearColorx pglClearColorx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClearDepthx(IntPtr depth);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glClearDepthx pglClearDepthx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanex(Int32 plane, IntPtr* equation);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glClipPlanex pglClipPlanex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4x(IntPtr red, IntPtr green, IntPtr blue, IntPtr alpha);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glColor4x pglColor4x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDepthRangex(IntPtr n, IntPtr f);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glDepthRangex pglDepthRangex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogx(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glFogx pglFogx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogxv(Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glFogxv pglFogxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFrustumx(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glFrustumx pglFrustumx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanex(Int32 plane, IntPtr* equation);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetClipPlanex pglGetClipPlanex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFixedv(Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetFixedv pglGetFixedv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetLightxv pglGetLightxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialxv(Int32 face, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetMaterialxv pglGetMaterialxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetTexEnvxv pglGetTexEnvxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glGetTexParameterxv pglGetTexParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelx(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLightModelx pglLightModelx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelxv(Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLightModelxv pglLightModelxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightx(Int32 light, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLightx pglLightx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightxv(Int32 light, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLightxv pglLightxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLineWidthx(IntPtr width);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLineWidthx pglLineWidthx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixx(IntPtr* m);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glLoadMatrixx pglLoadMatrixx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialx(Int32 face, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glMaterialx pglMaterialx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialxv(Int32 face, Int32 pname, IntPtr* param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glMaterialxv pglMaterialxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixx(IntPtr* m);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glMultMatrixx pglMultMatrixx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiTexCoord4x(Int32 texture, IntPtr s, IntPtr t, IntPtr r, IntPtr q);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glMultiTexCoord4x pglMultiTexCoord4x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3x(IntPtr nx, IntPtr ny, IntPtr nz);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glNormal3x pglNormal3x;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glOrthox(IntPtr l, IntPtr r, IntPtr b, IntPtr t, IntPtr n, IntPtr f);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glOrthox pglOrthox;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterx(Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glPointParameterx pglPointParameterx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterxv(Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glPointParameterxv pglPointParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointSizex(IntPtr size);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glPointSizex pglPointSizex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonOffsetx(IntPtr factor, IntPtr units);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glPolygonOffsetx pglPolygonOffsetx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRotatex(IntPtr angle, IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glRotatex pglRotatex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSampleCoveragex(Int32 value, bool invert);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glSampleCoveragex pglSampleCoveragex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glScalex(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glScalex pglScalex;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvx(Int32 target, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glTexEnvx pglTexEnvx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvxv(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glTexEnvxv pglTexEnvxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterx(Int32 target, Int32 pname, IntPtr param);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glTexParameterx pglTexParameterx;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterxv(Int32 target, Int32 pname, IntPtr* @params);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glTexParameterxv pglTexParameterxv;

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTranslatex(IntPtr x, IntPtr y, IntPtr z);

			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[ThreadStatic]
			internal static glTranslatex pglTranslatex;

		}
	}

}
