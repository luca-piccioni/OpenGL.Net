
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK are accepted. The initial value is Gl.BACK.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.FrontFace"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void CullFace(CullFaceMode mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace((Int32)mode);
			LogFunction("glCullFace({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. Gl.CW and Gl.CCW are accepted. The initial value is Gl.CCW.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CullFace"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void FrontFace(FrontFaceDirection mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace((Int32)mode);
			LogFunction("glFrontFace({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. Gl.LINE_SMOOTH_HINT, Gl.POLYGON_SMOOTH_HINT, 
		/// Gl.TEXTURE_COMPRESSION_HINT, and Gl.FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. Gl.FASTEST, Gl.NICEST, and Gl.DONT_CARE are accepted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Hint(HintTarget target, HintMode mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint((Int32)target, (Int32)mode);
			LogFunction("glHint({0}, {1})", target, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the width of rasterized lines
		/// </summary>
		/// <param name="width">
		/// Specifies the width of rasterized lines. The initial value is 1.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void LineWidth(float width)
		{
			Debug.Assert(Delegates.pglLineWidth != null, "pglLineWidth not implemented");
			Delegates.pglLineWidth(width);
			LogFunction("glLineWidth({0})", width);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the diameter of rasterized points
		/// </summary>
		/// <param name="size">
		/// Specifies the diameter of rasterized points. The initial value is 1.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PointParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointSize(float size)
		{
			Debug.Assert(Delegates.pglPointSize != null, "pglPointSize not implemented");
			Delegates.pglPointSize(size);
			LogFunction("glPointSize({0})", size);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that <paramref name="mode"/> applies to. Must be Gl.FRONT_AND_BACK for front- and back-facing 
		/// polygons.
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are Gl.POINT, Gl.LINE, and Gl.FILL. The initial value is 
		/// Gl.FILL for both front- and back-facing polygons.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPolygonModeNV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode((Int32)face, (Int32)mode);
			LogFunction("glPolygonMode({0}, {1})", face, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the scissor box. Initially (0, 0).
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the scissor box. Initially (0, 0).
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, <paramref 
		/// name="width"/> and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, <paramref 
		/// name="width"/> and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissor != null, "pglScissor not implemented");
			Delegates.pglScissor(x, y, width, height);
			LogFunction("glScissor({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf((Int32)target, (Int32)pname, param);
			LogFunction("glTexParameterf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexParameterfv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri((Int32)target, (Int32)pname, param);
			LogFunction("glTexParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexParameteriv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX are accepted.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> cannot be 
		/// represented as 2n+2⁡border for some integer value of n.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage1D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D((Int32)target, level, internalformat, width, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6}, 0x{7})", target, level, internalformat, width, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX are accepted.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> cannot be 
		/// represented as 2n+2⁡border for some integer value of n.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage1D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage1D(target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// that are at least 64 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is one of the six cube map 2D image targets and the width and 
		/// height parameters are not equal.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> or 
		/// <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not Gl.TEXTURE_2D or Gl.PROXY_TEXTURE_2D and <paramref 
		/// name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage2D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D((Int32)target, level, internalformat, width, height, border, (Int32)format, (Int32)type, pixels);
			LogFunction("glTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, 0x{8})", target, level, internalformat, width, height, border, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// that are at least 64 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is one of the six cube map 2D image targets and the width and 
		/// height parameters are not equal.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> or 
		/// <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not Gl.TEXTURE_2D or Gl.PROXY_TEXTURE_2D and <paramref 
		/// name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage2D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage2D(target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants Gl.NONE, 
		/// Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, Gl.BACK, Gl.LEFT, Gl.RIGHT, and Gl.FRONT_AND_BACK 
		/// are accepted. The initial value is Gl.FRONT for single-buffered contexts, and Gl.BACK for double-buffered contexts. For 
		/// framebuffer objects, Gl.COLOR_ATTACHMENT$m$ and Gl.NONE enums are accepted, where Gl. is a value between 0 and 
		/// Gl.MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffer if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="buf"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by <paramref 
		/// name="buf"/> exists.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a framebuffer object is affected and <paramref name="buf"/> is not equal to Gl.NONE 
		/// or Gl.COLOR_ATTACHMENT$m$, where Gl. is a value between 0 and Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DrawBuffer(DrawBufferMode buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer((Int32)buf);
			LogFunction("glDrawBuffer({0})", buf);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are Gl.COLOR_BUFFER_BIT, 
		/// Gl.DEPTH_BUFFER_BIT, and Gl.STENCIL_BUFFER_BIT.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any bit other than the three defined bits is set in <paramref name="mask"/>.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Clear(ClearBufferMask mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear((UInt32)mask);
			LogFunction("glClear({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify clear values for the color buffers
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearColor != null, "pglClearColor not implemented");
			Delegates.pglClearColor(red, green, blue, alpha);
			LogFunction("glClearColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the stencil buffer
		/// </summary>
		/// <param name="s">
		/// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ClearStencil(Int32 s)
		{
			Debug.Assert(Delegates.pglClearStencil != null, "pglClearStencil not implemented");
			Delegates.pglClearStencil(s);
			LogFunction("glClearStencil({0})", s);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="depth">
		/// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ClearDepth(double depth)
		{
			Debug.Assert(Delegates.pglClearDepth != null, "pglClearDepth not implemented");
			Delegates.pglClearDepth(depth);
			LogFunction("glClearDepth({0})", depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the front and back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMask != null, "pglStencilMask not implemented");
			Delegates.pglStencilMask(mask);
			LogFunction("glStencilMask({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="red">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="green">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="blue">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="alpha">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglColorMask != null, "pglColorMask not implemented");
			Delegates.pglColorMask(red, green, blue, alpha);
			LogFunction("glColorMask({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable writing into the depth buffer
		/// </summary>
		/// <param name="flag">
		/// Specifies whether the depth buffer is enabled for writing. If <paramref name="flag"/> is Gl.FALSE, depth buffer writing 
		/// is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
		/// </param>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DepthMask(bool flag)
		{
			Debug.Assert(Delegates.pglDepthMask != null, "pglDepthMask not implemented");
			Delegates.pglDepthMask(flag);
			LogFunction("glDepthMask({0})", flag);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Enable or Gl\.Disable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ClipPlane"/>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Disable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable((Int32)cap);
			LogFunction("glDisable({0})", cap);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Enable or Gl\.Disable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ClipPlane"/>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Enable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable((Int32)cap);
			LogFunction("glEnable({0})", cap);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// block until all GL execution is complete
		/// </summary>
		/// <seealso cref="Gl.Flush"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Finish()
		{
			Debug.Assert(Delegates.pglFinish != null, "pglFinish not implemented");
			Delegates.pglFinish();
			LogFunction("glFinish()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// force execution of GL commands in finite time
		/// </summary>
		/// <seealso cref="Gl.Finish"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Flush()
		{
			Debug.Assert(Delegates.pglFlush != null, "pglFlush not implemented");
			Delegates.pglFlush();
			LogFunction("glFlush()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR, Gl.SRC_ALPHA, 
		/// Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA, Gl.CONSTANT_COLOR, Gl.ONE_MINUS_CONSTANT_COLOR, 
		/// Gl.CONSTANT_ALPHA, Gl.ONE_MINUS_CONSTANT_ALPHA, and Gl.SRC_ALPHA_SATURATE. The initial value is Gl.ONE.
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constants are accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR, 
		/// Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA. Gl.CONSTANT_COLOR, 
		/// Gl.ONE_MINUS_CONSTANT_COLOR, Gl.CONSTANT_ALPHA, and Gl.ONE_MINUS_CONSTANT_ALPHA. The initial value is Gl.ZERO.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="sfactor"/> or <paramref name="dfactor"/> is not an accepted 
		/// value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.BlendFunc is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc((Int32)sfactor, (Int32)dfactor);
			LogFunction("glBlendFunc({0}, {1})", sfactor, dfactor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: Gl.CLEAR, Gl.SET, 
		/// Gl.COPY, Gl.COPY_INVERTED, Gl.NOOP, Gl.INVERT, Gl.AND, Gl.NAND, Gl.OR, Gl.NOR, Gl.XOR, Gl.EQUIV, Gl.AND_REVERSE, 
		/// Gl.AND_INVERTED, Gl.OR_REVERSE, and Gl.OR_INVERTED. The initial value is Gl.COPY.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="opcode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilOp"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LogicOp(LogicOp opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp((Int32)opcode);
			LogFunction("glLogicOp({0})", opcode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL, 
		/// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value for the stencil test. <paramref name="ref"/> is clamped to the range 02n-1, where n is the 
		/// number of bitplanes in the stencil buffer. The initial value is 0.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not one of the eight accepted values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc((Int32)func, @ref, mask);
			LogFunction("glStencilFunc({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO, 
		/// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. <paramref name="dpfail"/> accepts 
		/// the same symbolic constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. <paramref name="dppass"/> accepts the same symbolic 
		/// constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="sfail"/>, <paramref name="dpfail"/>, or <paramref name="dppass"/> is any 
		/// value other than the defined constant values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilOp(StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp((Int32)sfail, (Int32)dpfail, (Int32)dppass);
			LogFunction("glStencilOp({0}, {1}, {2})", sfail, dpfail, dppass);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER, 
		/// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.LESS.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DepthFunc(DepthFunction func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc((Int32)func);
			LogFunction("glDepthFunc({0})", func);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: 
		/// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS, Gl.PACK_SKIP_ROWS, 
		/// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: 
		/// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS, 
		/// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a negative row length, pixel skip, or row skip value is specified, or if alignment is 
		/// specified as other than 1, 2, 4, or 8.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelStore is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(PixelStoreParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref((Int32)pname, param);
			LogFunction("glPixelStoref({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: 
		/// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS, Gl.PACK_SKIP_ROWS, 
		/// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: 
		/// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS, 
		/// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a negative row length, pixel skip, or row skip value is specified, or if alignment is 
		/// specified as other than 1, 2, 4, or 8.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelStore is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void PixelStore(PixelStoreParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei((Int32)pname, param);
			LogFunction("glPixelStorei({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="mode">
		/// Specifies a color buffer. Accepted values are Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, 
		/// Gl.BACK, Gl.LEFT, Gl.RIGHT, and the constants Gl.COLOR_ATTACHMENTi.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the twelve (or more) accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> specifies a buffer that does not exist.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferReadBuffer if <paramref name="framebuffer"/> is not zero or the 
		/// name of an existing framebuffer object.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ReadBuffer(ReadBufferMode mode)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer((Int32)mode);
			LogFunction("glReadBuffer({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// read a block of pixels from the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// corner of a rectangular block of pixels.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// corner of a rectangular block of pixels.
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// to a single pixel.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// to a single pixel.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.STENCIL_INDEX, 
		/// Gl.DEPTH_COMPONENT, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and 
		/// Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// Returns the pixel data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not Gl.COLOR_INDEX 
		/// or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.COLOR_INDEX and the color buffers store RGBA color 
		/// components.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and there is no depth buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// The formats Gl.BGR, and Gl.BGRA and types Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, 
		/// Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, 
		/// Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV are available only if the GL version is 1.2 or greater.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ReadPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, (Int32)format, (Int32)type, data);
			LogFunction("glReadPixels({0}, {1}, {2}, {3}, {4}, {5}, 0x{6})", x, y, width, height, format, type, data.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					LogFunction("glGetBooleanv({0}, {1})", LogEnumName(pname), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((Int32)pname, p_data);
					LogFunction("glGetBooleanv({0}, {1})", pname, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					LogFunction("glGetBooleanv({0}, {1})", LogEnumName(pname), data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((Int32)pname, p_data);
					LogFunction("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(Int32 pname, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					LogFunction("glGetDoublev({0}, {1})", LogEnumName(pname), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((Int32)pname, p_data);
					LogFunction("glGetDoublev({0}, {1})", pname, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(Int32 pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					LogFunction("glGetDoublev({0}, {1})", LogEnumName(pname), data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((Int32)pname, p_data);
					LogFunction("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return error information
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static ErrorCode GetError()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetError != null, "pglGetError not implemented");
			retValue = Delegates.pglGetError();
			LogFunction("glGetError() = {0}", (ErrorCode)retValue);

			return ((ErrorCode)retValue);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					LogFunction("glGetFloatv({0}, {1})", LogEnumName(pname), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((Int32)pname, p_data);
					LogFunction("glGetFloatv({0}, {1})", pname, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					LogFunction("glGetFloatv({0}, {1})", LogEnumName(pname), data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((Int32)pname, p_data);
					LogFunction("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					LogFunction("glGetIntegerv({0}, {1})", LogEnumName(pname), LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((Int32)pname, p_data);
					LogFunction("glGetIntegerv({0}, {1})", pname, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					LogFunction("glGetIntegerv({0}, {1})", LogEnumName(pname), data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((Int32)pname, p_data);
					LogFunction("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of Gl.VENDOR, Gl.RENDERER, Gl.VERSION, or Gl.SHADING_LANGUAGE_VERSION. Additionally, 
		/// Gl.GetStringi accepts the Gl.EXTENSIONS token.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="name"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.GetStringi if <paramref name="index"/> is outside the valid range for indexed state 
		/// <paramref name="name"/>.
		/// </exception>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static String GetString(StringName name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = Delegates.pglGetString((Int32)name);
			LogFunction("glGetString({0}) = {1}", name, Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref name="type"/> is not 
		/// an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV, and <paramref 
		/// name="format"/> is neither Gl.RGBA or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="img"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexImage is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage((Int32)target, level, (Int32)format, (Int32)type, pixels);
			LogFunction("glGetTexImage({0}, {1}, {2}, {3}, 0x{4})", target, level, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref name="type"/> is not 
		/// an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV, and <paramref 
		/// name="format"/> is neither Gl.RGBA or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="img"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexImage is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetTexImage(target, level, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexParameterfv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexParameteriv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv((Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetTexLevelParameterfv({0}, {1}, {2}, {3})", target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((Int32)target, level, (Int32)pname, p_params);
					LogFunction("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated by Gl.IsEnabledi if <paramref name="index"/> is outside the valid range for the indexed 
		/// state <paramref name="cap"/>.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Disable"/>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsEnabled(EnableCap cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled((Int32)cap);
			LogFunction("glIsEnabled({0}) = {1}", cap, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="nearVal">
		/// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
		/// </param>
		/// <param name="farVal">
		/// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
		/// </param>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthRange(double nearVal, double farVal)
		{
			Debug.Assert(Delegates.pglDepthRange != null, "pglDepthRange not implemented");
			Delegates.pglDepthRange(nearVal, farVal);
			LogFunction("glDepthRange({0}, {1})", nearVal, farVal);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the viewport
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Viewport is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
			Delegates.pglViewport(x, y, width, height);
			LogFunction("glViewport({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the display-list name.
		/// </param>
		/// <param name="mode">
		/// Specifies the compilation mode, which can be Gl.COMPILE or Gl.COMPILE_AND_EXECUTE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="list"/> is 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.EndList is called without a preceding Gl.NewList, or if Gl.NewList is called 
		/// while a display list is being defined.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.NewList or Gl\.EndList is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if there is insufficient memory to compile the display list. If the GL version is 1.1 or 
		/// greater, no change is made to the previous contents of the display list, if any, and no other change is made to the GL 
		/// state. (It is as if no attempt had been made to create the new display list.)
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NewList(UInt32 list, ListMode mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, (Int32)mode);
			LogFunction("glNewList({0}, {1})", list, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="list"/> is 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.EndList is called without a preceding Gl.NewList, or if Gl.NewList is called 
		/// while a display list is being defined.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.NewList or Gl\.EndList is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if there is insufficient memory to compile the display list. If the GL version is 1.1 or 
		/// greater, no change is made to the previous contents of the display list, if any, and no other change is made to the GL 
		/// state. (It is as if no attempt had been made to create the new display list.)
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EndList()
		{
			Debug.Assert(Delegates.pglEndList != null, "pglEndList not implemented");
			Delegates.pglEndList();
			LogFunction("glEndList()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// execute a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the integer name of the display list to be executed.
		/// </param>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallList(UInt32 list)
		{
			Debug.Assert(Delegates.pglCallList != null, "pglCallList not implemented");
			Delegates.pglCallList(list);
			LogFunction("glCallList({0})", list);
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, Gl.4_BYTES.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.ListBase"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, (Int32)type, lists);
			LogFunction("glCallLists({0}, {1}, 0x{2})", n, type, lists.ToString("X8"));
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, Gl.4_BYTES.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.ListBase"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, ListNameType type, Object lists)
		{
			GCHandle pin_lists = GCHandle.Alloc(lists, GCHandleType.Pinned);
			try {
				CallLists(n, type, pin_lists.AddrOfPinnedObject());
			} finally {
				pin_lists.Free();
			}
		}

		/// <summary>
		/// delete a contiguous group of display lists
		/// </summary>
		/// <param name="list">
		/// Specifies the integer name of the first display list to delete.
		/// </param>
		/// <param name="range">
		/// Specifies the number of display lists to delete.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="range"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DeleteLists is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.IsList"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DeleteLists(UInt32 list, Int32 range)
		{
			Debug.Assert(Delegates.pglDeleteLists != null, "pglDeleteLists not implemented");
			Delegates.pglDeleteLists(list, range);
			LogFunction("glDeleteLists({0}, {1})", list, range);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate a contiguous set of empty display lists
		/// </summary>
		/// <param name="range">
		/// Specifies the number of contiguous empty display lists to be generated.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="range"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GenLists is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static UInt32 GenLists(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenLists != null, "pglGenLists not implemented");
			retValue = Delegates.pglGenLists(range);
			LogFunction("glGenLists({0}) = {1}", range, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// set the display-list base for glCallLists
		/// </summary>
		/// <param name="base">
		/// Specifies an integer offset that will be added to Gl\.CallLists offsets to generate display-list names. The initial 
		/// value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ListBase is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ListBase(UInt32 @base)
		{
			Debug.Assert(Delegates.pglListBase != null, "pglListBase not implemented");
			Delegates.pglListBase(@base);
			LogFunction("glListBase({0})", @base);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between Gl.Begin and the subsequent 
		/// Gl\.End. Ten symbolic constants are accepted: Gl.POINTS, Gl.LINES, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.QUADS, Gl.QUAD_STRIP, and Gl.POLYGON.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is set to an unaccepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Begin is executed between a Gl.Begin and the corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.End is executed without being preceded by a Gl.Begin.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a command other than Gl\.Vertex, Gl\.Color, Gl\.SecondaryColor, Gl\.Index, 
		/// Gl\.Normal, Gl\.FogCoord, Gl\.TexCoord, Gl\.MultiTexCoord, Gl\.VertexAttrib, Gl\.EvalCoord, Gl\.EvalPoint, 
		/// Gl\.ArrayElement, Gl\.Material, Gl\.EdgeFlag, Gl\.CallList, or Gl\.CallLists is executed between the execution of 
		/// Gl.Begin and the corresponding execution Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Execution of Gl\.EnableClientState, Gl\.DisableClientState, Gl\.EdgeFlagPointer, Gl\.FogCoordPointer, 
		/// Gl\.TexCoordPointer, Gl\.ColorPointer, Gl\.SecondaryColorPointer, Gl\.IndexPointer, Gl\.NormalPointer, 
		/// Gl\.VertexPointer, Gl\.VertexAttribPointer, Gl\.InterleavedArrays, or Gl\.PixelStore is not allowed after a call to 
		/// Gl.Begin and before the corresponding call to Gl\.End, but an error may or may not be generated.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Begin(PrimitiveType mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin((Int32)mode);
			LogFunction("glBegin({0})", mode);
		}

		/// <summary>
		/// draw a bitmap
		/// </summary>
		/// <param name="width">
		/// Specify the pixel width and height of the bitmap image.
		/// </param>
		/// <param name="height">
		/// Specify the pixel width and height of the bitmap image.
		/// </param>
		/// <param name="xorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// with right and up being the positive axes.
		/// </param>
		/// <param name="yorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// with right and up being the positive axes.
		/// </param>
		/// <param name="xmove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
		/// </param>
		/// <param name="ymove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
		/// </param>
		/// <param name="bitmap">
		/// Specifies the address of the bitmap image.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Bitmap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Bitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
					Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					LogFunction("glBitmap({0}, {1}, {2}, {3}, {4}, {5}, {6})", width, height, xorig, yorig, xmove, ymove, LogValue(bitmap));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglColor3b != null, "pglColor3b not implemented");
			Delegates.pglColor3b(red, green, blue);
			LogFunction("glColor3b({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3bv != null, "pglColor3bv not implemented");
					Delegates.pglColor3bv(p_v);
					LogFunction("glColor3bv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglColor3d != null, "pglColor3d not implemented");
			Delegates.pglColor3d(red, green, blue);
			LogFunction("glColor3d({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3dv != null, "pglColor3dv not implemented");
					Delegates.pglColor3dv(p_v);
					LogFunction("glColor3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglColor3f != null, "pglColor3f not implemented");
			Delegates.pglColor3f(red, green, blue);
			LogFunction("glColor3f({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3fv != null, "pglColor3fv not implemented");
					Delegates.pglColor3fv(p_v);
					LogFunction("glColor3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglColor3i != null, "pglColor3i not implemented");
			Delegates.pglColor3i(red, green, blue);
			LogFunction("glColor3i({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3iv != null, "pglColor3iv not implemented");
					Delegates.pglColor3iv(p_v);
					LogFunction("glColor3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglColor3s != null, "pglColor3s not implemented");
			Delegates.pglColor3s(red, green, blue);
			LogFunction("glColor3s({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3sv != null, "pglColor3sv not implemented");
					Delegates.pglColor3sv(p_v);
					LogFunction("glColor3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglColor3ub != null, "pglColor3ub not implemented");
			Delegates.pglColor3ub(red, green, blue);
			LogFunction("glColor3ub({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3ubv != null, "pglColor3ubv not implemented");
					Delegates.pglColor3ubv(p_v);
					LogFunction("glColor3ubv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglColor3ui != null, "pglColor3ui not implemented");
			Delegates.pglColor3ui(red, green, blue);
			LogFunction("glColor3ui({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3uiv != null, "pglColor3uiv not implemented");
					Delegates.pglColor3uiv(p_v);
					LogFunction("glColor3uiv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglColor3us != null, "pglColor3us not implemented");
			Delegates.pglColor3us(red, green, blue);
			LogFunction("glColor3us({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3usv != null, "pglColor3usv not implemented");
					Delegates.pglColor3usv(p_v);
					LogFunction("glColor3usv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			Debug.Assert(Delegates.pglColor4b != null, "pglColor4b not implemented");
			Delegates.pglColor4b(red, green, blue, alpha);
			LogFunction("glColor4b({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4bv != null, "pglColor4bv not implemented");
					Delegates.pglColor4bv(p_v);
					LogFunction("glColor4bv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double red, double green, double blue, double alpha)
		{
			Debug.Assert(Delegates.pglColor4d != null, "pglColor4d not implemented");
			Delegates.pglColor4d(red, green, blue, alpha);
			LogFunction("glColor4d({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4dv != null, "pglColor4dv not implemented");
					Delegates.pglColor4dv(p_v);
					LogFunction("glColor4dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglColor4f != null, "pglColor4f not implemented");
			Delegates.pglColor4f(red, green, blue, alpha);
			LogFunction("glColor4f({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4fv != null, "pglColor4fv not implemented");
					Delegates.pglColor4fv(p_v);
					LogFunction("glColor4fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Debug.Assert(Delegates.pglColor4i != null, "pglColor4i not implemented");
			Delegates.pglColor4i(red, green, blue, alpha);
			LogFunction("glColor4i({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4iv != null, "pglColor4iv not implemented");
					Delegates.pglColor4iv(p_v);
					LogFunction("glColor4iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			Debug.Assert(Delegates.pglColor4s != null, "pglColor4s not implemented");
			Delegates.pglColor4s(red, green, blue, alpha);
			LogFunction("glColor4s({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4sv != null, "pglColor4sv not implemented");
					Delegates.pglColor4sv(p_v);
					LogFunction("glColor4sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte red, byte green, byte blue, byte alpha)
		{
			Debug.Assert(Delegates.pglColor4ub != null, "pglColor4ub not implemented");
			Delegates.pglColor4ub(red, green, blue, alpha);
			LogFunction("glColor4ub({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubv != null, "pglColor4ubv not implemented");
					Delegates.pglColor4ubv(p_v);
					LogFunction("glColor4ubv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			Debug.Assert(Delegates.pglColor4ui != null, "pglColor4ui not implemented");
			Delegates.pglColor4ui(red, green, blue, alpha);
			LogFunction("glColor4ui({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4uiv != null, "pglColor4uiv not implemented");
					Delegates.pglColor4uiv(p_v);
					LogFunction("glColor4uiv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			Debug.Assert(Delegates.pglColor4us != null, "pglColor4us not implemented");
			Delegates.pglColor4us(red, green, blue, alpha);
			LogFunction("glColor4us({0}, {1}, {2}, {3})", red, green, blue, alpha);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4usv != null, "pglColor4usv not implemented");
					Delegates.pglColor4usv(p_v);
					LogFunction("glColor4usv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.PolygonMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool flag)
		{
			Debug.Assert(Delegates.pglEdgeFlag != null, "pglEdgeFlag not implemented");
			Delegates.pglEdgeFlag(flag);
			LogFunction("glEdgeFlag({0})", flag);
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.PolygonMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool[] flag)
		{
			unsafe {
				fixed (bool* p_flag = flag)
				{
					Debug.Assert(Delegates.pglEdgeFlagv != null, "pglEdgeFlagv not implemented");
					Delegates.pglEdgeFlagv(p_flag);
					LogFunction("glEdgeFlagv({0})", LogValue(flag));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is set to an unaccepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Begin is executed between a Gl.Begin and the corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.End is executed without being preceded by a Gl.Begin.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a command other than Gl\.Vertex, Gl\.Color, Gl\.SecondaryColor, Gl\.Index, 
		/// Gl\.Normal, Gl\.FogCoord, Gl\.TexCoord, Gl\.MultiTexCoord, Gl\.VertexAttrib, Gl\.EvalCoord, Gl\.EvalPoint, 
		/// Gl\.ArrayElement, Gl\.Material, Gl\.EdgeFlag, Gl\.CallList, or Gl\.CallLists is executed between the execution of 
		/// Gl.Begin and the corresponding execution Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Execution of Gl\.EnableClientState, Gl\.DisableClientState, Gl\.EdgeFlagPointer, Gl\.FogCoordPointer, 
		/// Gl\.TexCoordPointer, Gl\.ColorPointer, Gl\.SecondaryColorPointer, Gl\.IndexPointer, Gl\.NormalPointer, 
		/// Gl\.VertexPointer, Gl\.VertexAttribPointer, Gl\.InterleavedArrays, or Gl\.PixelStore is not allowed after a call to 
		/// Gl.Begin and before the corresponding call to Gl\.End, but an error may or may not be generated.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void End()
		{
			Debug.Assert(Delegates.pglEnd != null, "pglEnd not implemented");
			Delegates.pglEnd();
			LogFunction("glEnd()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double c)
		{
			Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
			Delegates.pglIndexd(c);
			LogFunction("glIndexd({0})", c);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double[] c)
		{
			unsafe {
				fixed (double* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
					Delegates.pglIndexdv(p_c);
					LogFunction("glIndexdv({0})", LogValue(c));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float c)
		{
			Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
			Delegates.pglIndexf(c);
			LogFunction("glIndexf({0})", c);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float[] c)
		{
			unsafe {
				fixed (float* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
					Delegates.pglIndexfv(p_c);
					LogFunction("glIndexfv({0})", LogValue(c));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32 c)
		{
			Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
			Delegates.pglIndexi(c);
			LogFunction("glIndexi({0})", c);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32[] c)
		{
			unsafe {
				fixed (Int32* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
					Delegates.pglIndexiv(p_c);
					LogFunction("glIndexiv({0})", LogValue(c));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16 c)
		{
			Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
			Delegates.pglIndexs(c);
			LogFunction("glIndexs({0})", c);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16[] c)
		{
			unsafe {
				fixed (Int16* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
					Delegates.pglIndexsv(p_c);
					LogFunction("glIndexsv({0})", LogValue(c));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
		{
			Debug.Assert(Delegates.pglNormal3b != null, "pglNormal3b not implemented");
			Delegates.pglNormal3b(nx, ny, nz);
			LogFunction("glNormal3b({0}, {1}, {2})", nx, ny, nz);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3bv != null, "pglNormal3bv not implemented");
					Delegates.pglNormal3bv(p_v);
					LogFunction("glNormal3bv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double nx, double ny, double nz)
		{
			Debug.Assert(Delegates.pglNormal3d != null, "pglNormal3d not implemented");
			Delegates.pglNormal3d(nx, ny, nz);
			LogFunction("glNormal3d({0}, {1}, {2})", nx, ny, nz);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3dv != null, "pglNormal3dv not implemented");
					Delegates.pglNormal3dv(p_v);
					LogFunction("glNormal3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float nx, float ny, float nz)
		{
			Debug.Assert(Delegates.pglNormal3f != null, "pglNormal3f not implemented");
			Delegates.pglNormal3f(nx, ny, nz);
			LogFunction("glNormal3f({0}, {1}, {2})", nx, ny, nz);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3fv != null, "pglNormal3fv not implemented");
					Delegates.pglNormal3fv(p_v);
					LogFunction("glNormal3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32 nx, Int32 ny, Int32 nz)
		{
			Debug.Assert(Delegates.pglNormal3i != null, "pglNormal3i not implemented");
			Delegates.pglNormal3i(nx, ny, nz);
			LogFunction("glNormal3i({0}, {1}, {2})", nx, ny, nz);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3iv != null, "pglNormal3iv not implemented");
					Delegates.pglNormal3iv(p_v);
					LogFunction("glNormal3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16 nx, Int16 ny, Int16 nz)
		{
			Debug.Assert(Delegates.pglNormal3s != null, "pglNormal3s not implemented");
			Delegates.pglNormal3s(nx, ny, nz);
			LogFunction("glNormal3s({0}, {1}, {2})", nx, ny, nz);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3sv != null, "pglNormal3sv not implemented");
					Delegates.pglNormal3sv(p_v);
					LogFunction("glNormal3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglRasterPos2d != null, "pglRasterPos2d not implemented");
			Delegates.pglRasterPos2d(x, y);
			LogFunction("glRasterPos2d({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2dv != null, "pglRasterPos2dv not implemented");
					Delegates.pglRasterPos2dv(p_v);
					LogFunction("glRasterPos2dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglRasterPos2f != null, "pglRasterPos2f not implemented");
			Delegates.pglRasterPos2f(x, y);
			LogFunction("glRasterPos2f({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2fv != null, "pglRasterPos2fv not implemented");
					Delegates.pglRasterPos2fv(p_v);
					LogFunction("glRasterPos2fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglRasterPos2i != null, "pglRasterPos2i not implemented");
			Delegates.pglRasterPos2i(x, y);
			LogFunction("glRasterPos2i({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2iv != null, "pglRasterPos2iv not implemented");
					Delegates.pglRasterPos2iv(p_v);
					LogFunction("glRasterPos2iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglRasterPos2s != null, "pglRasterPos2s not implemented");
			Delegates.pglRasterPos2s(x, y);
			LogFunction("glRasterPos2s({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2sv != null, "pglRasterPos2sv not implemented");
					Delegates.pglRasterPos2sv(p_v);
					LogFunction("glRasterPos2sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRasterPos3d != null, "pglRasterPos3d not implemented");
			Delegates.pglRasterPos3d(x, y, z);
			LogFunction("glRasterPos3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3dv != null, "pglRasterPos3dv not implemented");
					Delegates.pglRasterPos3dv(p_v);
					LogFunction("glRasterPos3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRasterPos3f != null, "pglRasterPos3f not implemented");
			Delegates.pglRasterPos3f(x, y, z);
			LogFunction("glRasterPos3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3fv != null, "pglRasterPos3fv not implemented");
					Delegates.pglRasterPos3fv(p_v);
					LogFunction("glRasterPos3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglRasterPos3i != null, "pglRasterPos3i not implemented");
			Delegates.pglRasterPos3i(x, y, z);
			LogFunction("glRasterPos3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3iv != null, "pglRasterPos3iv not implemented");
					Delegates.pglRasterPos3iv(p_v);
					LogFunction("glRasterPos3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglRasterPos3s != null, "pglRasterPos3s not implemented");
			Delegates.pglRasterPos3s(x, y, z);
			LogFunction("glRasterPos3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3sv != null, "pglRasterPos3sv not implemented");
					Delegates.pglRasterPos3sv(p_v);
					LogFunction("glRasterPos3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglRasterPos4d != null, "pglRasterPos4d not implemented");
			Delegates.pglRasterPos4d(x, y, z, w);
			LogFunction("glRasterPos4d({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4dv != null, "pglRasterPos4dv not implemented");
					Delegates.pglRasterPos4dv(p_v);
					LogFunction("glRasterPos4dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglRasterPos4f != null, "pglRasterPos4f not implemented");
			Delegates.pglRasterPos4f(x, y, z, w);
			LogFunction("glRasterPos4f({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4fv != null, "pglRasterPos4fv not implemented");
					Delegates.pglRasterPos4fv(p_v);
					LogFunction("glRasterPos4fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglRasterPos4i != null, "pglRasterPos4i not implemented");
			Delegates.pglRasterPos4i(x, y, z, w);
			LogFunction("glRasterPos4i({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4iv != null, "pglRasterPos4iv not implemented");
					Delegates.pglRasterPos4iv(p_v);
					LogFunction("glRasterPos4iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglRasterPos4s != null, "pglRasterPos4s not implemented");
			Delegates.pglRasterPos4s(x, y, z, w);
			LogFunction("glRasterPos4s({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4sv != null, "pglRasterPos4sv not implemented");
					Delegates.pglRasterPos4sv(p_v);
					LogFunction("glRasterPos4sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(double x1, double y1, double x2, double y2)
		{
			Debug.Assert(Delegates.pglRectd != null, "pglRectd not implemented");
			Delegates.pglRectd(x1, y1, x2, y2);
			LogFunction("glRectd({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(double[] v1, double[] v2)
		{
			unsafe {
				fixed (double* p_v1 = v1)
				fixed (double* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectdv != null, "pglRectdv not implemented");
					Delegates.pglRectdv(p_v1, p_v2);
					LogFunction("glRectdv({0}, {1})", LogValue(v1), LogValue(v2));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(float x1, float y1, float x2, float y2)
		{
			Debug.Assert(Delegates.pglRectf != null, "pglRectf not implemented");
			Delegates.pglRectf(x1, y1, x2, y2);
			LogFunction("glRectf({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(float[] v1, float[] v2)
		{
			unsafe {
				fixed (float* p_v1 = v1)
				fixed (float* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectfv != null, "pglRectfv not implemented");
					Delegates.pglRectfv(p_v1, p_v2);
					LogFunction("glRectfv({0}, {1})", LogValue(v1), LogValue(v2));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			Debug.Assert(Delegates.pglRecti != null, "pglRecti not implemented");
			Delegates.pglRecti(x1, y1, x2, y2);
			LogFunction("glRecti({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int32[] v1, Int32[] v2)
		{
			unsafe {
				fixed (Int32* p_v1 = v1)
				fixed (Int32* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectiv != null, "pglRectiv not implemented");
					Delegates.pglRectiv(p_v1, p_v2);
					LogFunction("glRectiv({0}, {1})", LogValue(v1), LogValue(v2));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			Debug.Assert(Delegates.pglRects != null, "pglRects not implemented");
			Delegates.pglRects(x1, y1, x2, y2);
			LogFunction("glRects({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int16[] v1, Int16[] v2)
		{
			unsafe {
				fixed (Int16* p_v1 = v1)
				fixed (Int16* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectsv != null, "pglRectsv not implemented");
					Delegates.pglRectsv(p_v1, p_v2);
					LogFunction("glRectsv({0}, {1})", LogValue(v1), LogValue(v2));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double s)
		{
			Debug.Assert(Delegates.pglTexCoord1d != null, "pglTexCoord1d not implemented");
			Delegates.pglTexCoord1d(s);
			LogFunction("glTexCoord1d({0})", s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1dv != null, "pglTexCoord1dv not implemented");
					Delegates.pglTexCoord1dv(p_v);
					LogFunction("glTexCoord1dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float s)
		{
			Debug.Assert(Delegates.pglTexCoord1f != null, "pglTexCoord1f not implemented");
			Delegates.pglTexCoord1f(s);
			LogFunction("glTexCoord1f({0})", s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1fv != null, "pglTexCoord1fv not implemented");
					Delegates.pglTexCoord1fv(p_v);
					LogFunction("glTexCoord1fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32 s)
		{
			Debug.Assert(Delegates.pglTexCoord1i != null, "pglTexCoord1i not implemented");
			Delegates.pglTexCoord1i(s);
			LogFunction("glTexCoord1i({0})", s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1iv != null, "pglTexCoord1iv not implemented");
					Delegates.pglTexCoord1iv(p_v);
					LogFunction("glTexCoord1iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1s != null, "pglTexCoord1s not implemented");
			Delegates.pglTexCoord1s(s);
			LogFunction("glTexCoord1s({0})", s);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1sv != null, "pglTexCoord1sv not implemented");
					Delegates.pglTexCoord1sv(p_v);
					LogFunction("glTexCoord1sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double s, double t)
		{
			Debug.Assert(Delegates.pglTexCoord2d != null, "pglTexCoord2d not implemented");
			Delegates.pglTexCoord2d(s, t);
			LogFunction("glTexCoord2d({0}, {1})", s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2dv != null, "pglTexCoord2dv not implemented");
					Delegates.pglTexCoord2dv(p_v);
					LogFunction("glTexCoord2dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float s, float t)
		{
			Debug.Assert(Delegates.pglTexCoord2f != null, "pglTexCoord2f not implemented");
			Delegates.pglTexCoord2f(s, t);
			LogFunction("glTexCoord2f({0}, {1})", s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fv != null, "pglTexCoord2fv not implemented");
					Delegates.pglTexCoord2fv(p_v);
					LogFunction("glTexCoord2fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglTexCoord2i != null, "pglTexCoord2i not implemented");
			Delegates.pglTexCoord2i(s, t);
			LogFunction("glTexCoord2i({0}, {1})", s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2iv != null, "pglTexCoord2iv not implemented");
					Delegates.pglTexCoord2iv(p_v);
					LogFunction("glTexCoord2iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglTexCoord2s != null, "pglTexCoord2s not implemented");
			Delegates.pglTexCoord2s(s, t);
			LogFunction("glTexCoord2s({0}, {1})", s, t);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2sv != null, "pglTexCoord2sv not implemented");
					Delegates.pglTexCoord2sv(p_v);
					LogFunction("glTexCoord2sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double s, double t, double r)
		{
			Debug.Assert(Delegates.pglTexCoord3d != null, "pglTexCoord3d not implemented");
			Delegates.pglTexCoord3d(s, t, r);
			LogFunction("glTexCoord3d({0}, {1}, {2})", s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3dv != null, "pglTexCoord3dv not implemented");
					Delegates.pglTexCoord3dv(p_v);
					LogFunction("glTexCoord3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float s, float t, float r)
		{
			Debug.Assert(Delegates.pglTexCoord3f != null, "pglTexCoord3f not implemented");
			Delegates.pglTexCoord3f(s, t, r);
			LogFunction("glTexCoord3f({0}, {1}, {2})", s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3fv != null, "pglTexCoord3fv not implemented");
					Delegates.pglTexCoord3fv(p_v);
					LogFunction("glTexCoord3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglTexCoord3i != null, "pglTexCoord3i not implemented");
			Delegates.pglTexCoord3i(s, t, r);
			LogFunction("glTexCoord3i({0}, {1}, {2})", s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3iv != null, "pglTexCoord3iv not implemented");
					Delegates.pglTexCoord3iv(p_v);
					LogFunction("glTexCoord3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglTexCoord3s != null, "pglTexCoord3s not implemented");
			Delegates.pglTexCoord3s(s, t, r);
			LogFunction("glTexCoord3s({0}, {1}, {2})", s, t, r);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3sv != null, "pglTexCoord3sv not implemented");
					Delegates.pglTexCoord3sv(p_v);
					LogFunction("glTexCoord3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglTexCoord4d != null, "pglTexCoord4d not implemented");
			Delegates.pglTexCoord4d(s, t, r, q);
			LogFunction("glTexCoord4d({0}, {1}, {2}, {3})", s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4dv != null, "pglTexCoord4dv not implemented");
					Delegates.pglTexCoord4dv(p_v);
					LogFunction("glTexCoord4dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglTexCoord4f != null, "pglTexCoord4f not implemented");
			Delegates.pglTexCoord4f(s, t, r, q);
			LogFunction("glTexCoord4f({0}, {1}, {2}, {3})", s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fv != null, "pglTexCoord4fv not implemented");
					Delegates.pglTexCoord4fv(p_v);
					LogFunction("glTexCoord4fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglTexCoord4i != null, "pglTexCoord4i not implemented");
			Delegates.pglTexCoord4i(s, t, r, q);
			LogFunction("glTexCoord4i({0}, {1}, {2}, {3})", s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4iv != null, "pglTexCoord4iv not implemented");
					Delegates.pglTexCoord4iv(p_v);
					LogFunction("glTexCoord4iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglTexCoord4s != null, "pglTexCoord4s not implemented");
			Delegates.pglTexCoord4s(s, t, r, q);
			LogFunction("glTexCoord4s({0}, {1}, {2}, {3})", s, t, r, q);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4sv != null, "pglTexCoord4sv not implemented");
					Delegates.pglTexCoord4sv(p_v);
					LogFunction("glTexCoord4sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double x, double y)
		{
			Debug.Assert(Delegates.pglVertex2d != null, "pglVertex2d not implemented");
			Delegates.pglVertex2d(x, y);
			LogFunction("glVertex2d({0}, {1})", x, y);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2dv != null, "pglVertex2dv not implemented");
					Delegates.pglVertex2dv(p_v);
					LogFunction("glVertex2dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float x, float y)
		{
			Debug.Assert(Delegates.pglVertex2f != null, "pglVertex2f not implemented");
			Delegates.pglVertex2f(x, y);
			LogFunction("glVertex2f({0}, {1})", x, y);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2fv != null, "pglVertex2fv not implemented");
					Delegates.pglVertex2fv(p_v);
					LogFunction("glVertex2fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertex2i != null, "pglVertex2i not implemented");
			Delegates.pglVertex2i(x, y);
			LogFunction("glVertex2i({0}, {1})", x, y);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2iv != null, "pglVertex2iv not implemented");
					Delegates.pglVertex2iv(p_v);
					LogFunction("glVertex2iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertex2s != null, "pglVertex2s not implemented");
			Delegates.pglVertex2s(x, y);
			LogFunction("glVertex2s({0}, {1})", x, y);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2sv != null, "pglVertex2sv not implemented");
					Delegates.pglVertex2sv(p_v);
					LogFunction("glVertex2sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertex3d != null, "pglVertex3d not implemented");
			Delegates.pglVertex3d(x, y, z);
			LogFunction("glVertex3d({0}, {1}, {2})", x, y, z);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3dv != null, "pglVertex3dv not implemented");
					Delegates.pglVertex3dv(p_v);
					LogFunction("glVertex3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertex3f != null, "pglVertex3f not implemented");
			Delegates.pglVertex3f(x, y, z);
			LogFunction("glVertex3f({0}, {1}, {2})", x, y, z);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3fv != null, "pglVertex3fv not implemented");
					Delegates.pglVertex3fv(p_v);
					LogFunction("glVertex3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertex3i != null, "pglVertex3i not implemented");
			Delegates.pglVertex3i(x, y, z);
			LogFunction("glVertex3i({0}, {1}, {2})", x, y, z);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3iv != null, "pglVertex3iv not implemented");
					Delegates.pglVertex3iv(p_v);
					LogFunction("glVertex3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertex3s != null, "pglVertex3s not implemented");
			Delegates.pglVertex3s(x, y, z);
			LogFunction("glVertex3s({0}, {1}, {2})", x, y, z);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3sv != null, "pglVertex3sv not implemented");
					Delegates.pglVertex3sv(p_v);
					LogFunction("glVertex3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertex4d != null, "pglVertex4d not implemented");
			Delegates.pglVertex4d(x, y, z, w);
			LogFunction("glVertex4d({0}, {1}, {2}, {3})", x, y, z, w);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4dv != null, "pglVertex4dv not implemented");
					Delegates.pglVertex4dv(p_v);
					LogFunction("glVertex4dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertex4f != null, "pglVertex4f not implemented");
			Delegates.pglVertex4f(x, y, z, w);
			LogFunction("glVertex4f({0}, {1}, {2}, {3})", x, y, z, w);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4fv != null, "pglVertex4fv not implemented");
					Delegates.pglVertex4fv(p_v);
					LogFunction("glVertex4fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertex4i != null, "pglVertex4i not implemented");
			Delegates.pglVertex4i(x, y, z, w);
			LogFunction("glVertex4i({0}, {1}, {2}, {3})", x, y, z, w);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4iv != null, "pglVertex4iv not implemented");
					Delegates.pglVertex4iv(p_v);
					LogFunction("glVertex4iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertex4s != null, "pglVertex4s not implemented");
			Delegates.pglVertex4s(x, y, z, w);
			LogFunction("glVertex4s({0}, {1}, {2}, {3})", x, y, z, w);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4sv != null, "pglVertex4sv not implemented");
					Delegates.pglVertex4sv(p_v);
					LogFunction("glVertex4sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="plane">
		/// Specifies which clipping plane is being positioned. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer 
		/// between 0 and Gl.MAX_CLIP_PLANES-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a 
		/// plane equation.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClipPlane is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane((Int32)plane, p_equation);
					LogFunction("glClipPlane({0}, {1})", plane, LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// cause a material color to track the current color
		/// </summary>
		/// <param name="face">
		/// Specifies whether front, back, or both front and back material parameters should track the current color. Accepted 
		/// values are Gl.FRONT, Gl.BACK, and Gl.FRONT_AND_BACK. The initial value is Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="mode">
		/// Specifies which of several material parameters track the current color. Accepted values are Gl.EMISSION, Gl.AMBIENT, 
		/// Gl.DIFFUSE, Gl.SPECULAR, and Gl.AMBIENT_AND_DIFFUSE. The initial value is Gl.AMBIENT_AND_DIFFUSE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorMaterial is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial((Int32)face, (Int32)mode);
			LogFunction("glColorMaterial({0}, {1})", face, mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf((Int32)pname, param);
			LogFunction("glFogf({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv((Int32)pname, p_params);
					LogFunction("glFogfv({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi((Int32)pname, param);
			LogFunction("glFogi({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv((Int32)pname, p_params);
					LogFunction("glFogiv({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf((Int32)light, (Int32)pname, param);
			LogFunction("glLightf({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv((Int32)light, (Int32)pname, p_params);
					LogFunction("glLightfv({0}, {1}, {2})", light, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti((Int32)light, (Int32)pname, param);
			LogFunction("glLighti({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv((Int32)light, (Int32)pname, p_params);
					LogFunction("glLightiv({0}, {1}, {2})", light, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf((Int32)pname, param);
			LogFunction("glLightModelf({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv((Int32)pname, p_params);
					LogFunction("glLightModelfv({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli((Int32)pname, param);
			LogFunction("glLightModeli({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv((Int32)pname, p_params);
					LogFunction("glLightModeliv({0}, {1})", pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the line stipple pattern
		/// </summary>
		/// <param name="factor">
		/// Specifies a multiplier for each bit in the line stipple pattern. If <paramref name="factor"/> is 3, for example, each 
		/// bit in the pattern is used three times before the next bit in the pattern is used. <paramref name="factor"/> is clamped 
		/// to the range [1, 256] and defaults to 1.
		/// </param>
		/// <param name="pattern">
		/// Specifies a 16-bit integer whose bit pattern determines which fragments of a line will be drawn when the line is 
		/// rasterized. Bit zero is used first; the default pattern is all 1's.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LineStipple is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LineStipple(Int32 factor, UInt16 pattern)
		{
			Debug.Assert(Delegates.pglLineStipple != null, "pglLineStipple not implemented");
			Delegates.pglLineStipple(factor, pattern);
			LogFunction("glLineStipple({0}, {1})", factor, pattern);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf((Int32)face, (Int32)pname, param);
			LogFunction("glMaterialf({0}, {1}, {2})", face, pname, param);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv((Int32)face, (Int32)pname, p_params);
					LogFunction("glMaterialfv({0}, {1}, {2})", face, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali((Int32)face, (Int32)pname, param);
			LogFunction("glMateriali({0}, {1}, {2})", face, pname, param);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv((Int32)face, (Int32)pname, p_params);
					LogFunction("glMaterialiv({0}, {1}, {2})", face, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the polygon stippling pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PolygonStipple is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglPolygonStipple != null, "pglPolygonStipple not implemented");
					Delegates.pglPolygonStipple(p_mask);
					LogFunction("glPolygonStipple({0})", LogValue(mask));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are Gl.FLAT and Gl.SMOOTH. The initial 
		/// value is Gl.SMOOTH.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is any value other than Gl.FLAT or Gl.SMOOTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ShadeModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ShadeModel(ShadingModel mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel((Int32)mode);
			LogFunction("glShadeModel({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND, 
		/// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR, 
		/// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture 
		/// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when 
		/// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf((Int32)target, (Int32)pname, param);
			LogFunction("glTexEnvf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexEnvfv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND, 
		/// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR, 
		/// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture 
		/// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when 
		/// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi((Int32)target, (Int32)pname, param);
			LogFunction("glTexEnvi({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv((Int32)target, (Int32)pname, p_params);
					LogFunction("glTexEnviv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend((Int32)coord, (Int32)pname, param);
			LogFunction("glTexGend({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glTexGendv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf((Int32)coord, (Int32)pname, param);
			LogFunction("glTexGenf({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glTexGenfv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni((Int32)coord, (Int32)pname, param);
			LogFunction("glTexGeni({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glTexGeniv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="size">
		/// Specifies the maximum number of values that can be written into <paramref name="buffer"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D, 
		/// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl\.RenderMode is called with argument Gl.FEEDBACK before Gl.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(Int32 size, FeedbackType type, params float[] buffer)
		{
			Debug.Assert(buffer.Length >= size);
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, (Int32)type, p_buffer);
					LogFunction("glFeedbackBuffer({0}, {1}, {2})", size, type, LogValue(buffer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D, 
		/// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl\.RenderMode is called with argument Gl.FEEDBACK before Gl.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(FeedbackType type, params float[] buffer)
		{
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer((Int32)buffer.Length, (Int32)type, p_buffer);
					LogFunction("glFeedbackBuffer({0}, {1}, {2})", buffer.Length, type, LogValue(buffer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// establish a buffer for selection mode values
		/// </summary>
		/// <param name="buffer">
		/// Returns the selection data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SelectBuffer is called while the render mode is Gl.SELECT, or if Gl\.RenderMode 
		/// is called with argument Gl.SELECT before Gl.SelectBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SelectBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SelectBuffer(params UInt32[] buffer)
		{
			unsafe {
				fixed (UInt32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglSelectBuffer != null, "pglSelectBuffer not implemented");
					Delegates.pglSelectBuffer((Int32)buffer.Length, p_buffer);
					LogFunction("glSelectBuffer({0}, {1})", buffer.Length, LogValue(buffer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set rasterization mode
		/// </summary>
		/// <param name="mode">
		/// Specifies the rasterization mode. Three values are accepted: Gl.RENDER, Gl.SELECT, and Gl.FEEDBACK. The initial value is 
		/// Gl.RENDER.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the three accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.SelectBuffer is called while the render mode is Gl.SELECT, or if Gl.RenderMode 
		/// is called with argument Gl.SELECT before Gl\.SelectBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl.RenderMode is called with argument Gl.FEEDBACK before Gl\.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RenderMode is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static Int32 RenderMode(RenderingMode mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode((Int32)mode);
			LogFunction("glRenderMode({0}) = {1}", mode, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// initialize the name stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.InitNames is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InitName()
		{
			Debug.Assert(Delegates.pglInitNames != null, "pglInitNames not implemented");
			Delegates.pglInitNames();
			LogFunction("glInitNames()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load a name onto the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will replace the top value on the name stack.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadName is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadName(UInt32 name)
		{
			Debug.Assert(Delegates.pglLoadName != null, "pglLoadName not implemented");
			Delegates.pglLoadName(name);
			LogFunction("glLoadName({0})", name);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// place a marker in the feedback buffer
		/// </summary>
		/// <param name="token">
		/// Specifies a marker value to be placed in the feedback buffer following a Gl.PASS_THROUGH_TOKEN.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PassThrough is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.RenderMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PassThrough(float token)
		{
			Debug.Assert(Delegates.pglPassThrough != null, "pglPassThrough not implemented");
			Delegates.pglPassThrough(token);
			LogFunction("glPassThrough({0})", token);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushName is called while the name stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushName or Gl\.PopName is executed between a call to Gl\.Begin and the 
		/// corresponding call to Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopName()
		{
			Debug.Assert(Delegates.pglPopName != null, "pglPopName not implemented");
			Delegates.pglPopName();
			LogFunction("glPopName()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will be pushed onto the name stack.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushName is called while the name stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushName or Gl\.PopName is executed between a call to Gl\.Begin and the 
		/// corresponding call to Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushName(UInt32 name)
		{
			Debug.Assert(Delegates.pglPushName != null, "pglPushName not implemented");
			Delegates.pglPushName(name);
			LogFunction("glPushName({0})", name);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify clear values for the accumulation buffer
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClearAccum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Accum"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearAccum(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearAccum != null, "pglClearAccum not implemented");
			Delegates.pglClearAccum(red, green, blue, alpha);
			LogFunction("glClearAccum({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the color index buffers
		/// </summary>
		/// <param name="c">
		/// Specifies the index used when the color index buffers are cleared. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClearIndex is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearIndex(float c)
		{
			Debug.Assert(Delegates.pglClearIndex != null, "pglClearIndex not implemented");
			Delegates.pglClearIndex(c);
			LogFunction("glClearIndex({0})", c);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the writing of individual bits in the color index buffers
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable the writing of individual bits in the color index buffers. Initially, the 
		/// mask is all 1's.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.IndexMask is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglIndexMask != null, "pglIndexMask not implemented");
			Delegates.pglIndexMask(mask);
			LogFunction("glIndexMask({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// operate on the accumulation buffer
		/// </summary>
		/// <param name="op">
		/// Specifies the accumulation buffer operation. Symbolic constants Gl.ACCUM, Gl.LOAD, Gl.ADD, Gl.MULT, and Gl.RETURN are 
		/// accepted.
		/// </param>
		/// <param name="value">
		/// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op"/> determines how 
		/// <paramref name="value"/> is used.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="op"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no accumulation buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Accum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.ClearAccum"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilOp"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Accum(AccumOp op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum((Int32)op, value);
			LogFunction("glAccum({0}, {1})", op, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushAttrib or Gl\.PopAttrib is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetLight"/>
		/// <seealso cref="Gl.GetMap"/>
		/// <seealso cref="Gl.GetMaterial"/>
		/// <seealso cref="Gl.GetPixelMap"/>
		/// <seealso cref="Gl.GetPolygonStipple"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexEnv"/>
		/// <seealso cref="Gl.GetTexGen"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopAttrib()
		{
			Debug.Assert(Delegates.pglPopAttrib != null, "pglPopAttrib not implemented");
			Delegates.pglPopAttrib();
			LogFunction("glPopAttrib()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushAttrib or Gl\.PopAttrib is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetLight"/>
		/// <seealso cref="Gl.GetMap"/>
		/// <seealso cref="Gl.GetMaterial"/>
		/// <seealso cref="Gl.GetPixelMap"/>
		/// <seealso cref="Gl.GetPolygonStipple"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexEnv"/>
		/// <seealso cref="Gl.GetTexGen"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushAttrib(AttribMask mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib((UInt32)mask);
			LogFunction("glPushAttrib({0})", mask);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3, Gl.MAP1_VERTEX_4, 
		/// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, 
		/// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// in the data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is less than the number of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="order"/> is less than 1 or greater than the return value of 
		/// Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d((Int32)target, u1, u2, stride, order, p_points);
					LogFunction("glMap1d({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3, Gl.MAP1_VERTEX_4, 
		/// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, 
		/// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// in the data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is less than the number of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="order"/> is less than 1 or greater than the return value of 
		/// Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f((Int32)target, u1, u2, stride, order, p_points);
					LogFunction("glMap1f({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3, Gl.MAP2_VERTEX_4, 
		/// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="ustride"/> is 0.
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="vstride"/> is 0.
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref name="v1"/> is 
		/// equal to <paramref name="v2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less than the number 
		/// of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less than 1 or greater 
		/// than the return value of Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogFunction("glMap2d({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3, Gl.MAP2_VERTEX_4, 
		/// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="ustride"/> is 0.
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="vstride"/> is 0.
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref name="v1"/> is 
		/// equal to <paramref name="v2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less than the number 
		/// of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less than 1 or greater 
		/// than the return value of Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogFunction("glMap2f({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, LogValue(points));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, double u1, double u2)
		{
			Debug.Assert(Delegates.pglMapGrid1d != null, "pglMapGrid1d not implemented");
			Delegates.pglMapGrid1d(un, u1, u2);
			LogFunction("glMapGrid1d({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, float u1, float u2)
		{
			Debug.Assert(Delegates.pglMapGrid1f != null, "pglMapGrid1f not implemented");
			Delegates.pglMapGrid1f(un, u1, u2);
			LogFunction("glMapGrid1f({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] 
		/// (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, double u1, double u2, Int32 vn, double v1, double v2)
		{
			Debug.Assert(Delegates.pglMapGrid2d != null, "pglMapGrid2d not implemented");
			Delegates.pglMapGrid2d(un, u1, u2, vn, v1, v2);
			LogFunction("glMapGrid2d({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] 
		/// (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, float u1, float u2, Int32 vn, float v1, float v2)
		{
			Debug.Assert(Delegates.pglMapGrid2f != null, "pglMapGrid2f not implemented");
			Delegates.pglMapGrid2f(un, u1, u2, vn, v1, v2);
			LogFunction("glMapGrid2f({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double u)
		{
			Debug.Assert(Delegates.pglEvalCoord1d != null, "pglEvalCoord1d not implemented");
			Delegates.pglEvalCoord1d(u);
			LogFunction("glEvalCoord1d({0})", u);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1dv != null, "pglEvalCoord1dv not implemented");
					Delegates.pglEvalCoord1dv(p_u);
					LogFunction("glEvalCoord1dv({0})", LogValue(u));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float u)
		{
			Debug.Assert(Delegates.pglEvalCoord1f != null, "pglEvalCoord1f not implemented");
			Delegates.pglEvalCoord1f(u);
			LogFunction("glEvalCoord1f({0})", u);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1fv != null, "pglEvalCoord1fv not implemented");
					Delegates.pglEvalCoord1fv(p_u);
					LogFunction("glEvalCoord1fv({0})", LogValue(u));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argument is not present in a Gl.EvalCoord1 command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double u, double v)
		{
			Debug.Assert(Delegates.pglEvalCoord2d != null, "pglEvalCoord2d not implemented");
			Delegates.pglEvalCoord2d(u, v);
			LogFunction("glEvalCoord2d({0}, {1})", u, v);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2dv != null, "pglEvalCoord2dv not implemented");
					Delegates.pglEvalCoord2dv(p_u);
					LogFunction("glEvalCoord2dv({0})", LogValue(u));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argument is not present in a Gl.EvalCoord1 command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float u, float v)
		{
			Debug.Assert(Delegates.pglEvalCoord2f != null, "pglEvalCoord2f not implemented");
			Delegates.pglEvalCoord2f(u, v);
			LogFunction("glEvalCoord2f({0}, {1})", u, v);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2fv != null, "pglEvalCoord2fv not implemented");
					Delegates.pglEvalCoord2fv(p_u);
					LogFunction("glEvalCoord2fv({0})", LogValue(u));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT and 
		/// Gl.LINE are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EvalMesh is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1((Int32)mode, i1, i2);
			LogFunction("glEvalMesh1({0}, {1}, {2})", mode, i1, i2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint1(Int32 i)
		{
			Debug.Assert(Delegates.pglEvalPoint1 != null, "pglEvalPoint1 not implemented");
			Delegates.pglEvalPoint1(i);
			LogFunction("glEvalPoint1({0})", i);
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT and 
		/// Gl.LINE are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="j1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="j2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EvalMesh is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2((Int32)mode, i1, i2, j1, j2);
			LogFunction("glEvalMesh2({0}, {1}, {2}, {3}, {4})", mode, i1, i2, j1, j2);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		/// <param name="j">
		/// Specifies the integer value for grid domain variable j (Gl.EvalPoint2 only).
		/// </param>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint2(Int32 i, Int32 j)
		{
			Debug.Assert(Delegates.pglEvalPoint2 != null, "pglEvalPoint2 not implemented");
			Delegates.pglEvalPoint2(i, j);
			LogFunction("glEvalPoint2({0}, {1})", i, j);
		}

		/// <summary>
		/// specify the alpha test function
		/// </summary>
		/// <param name="func">
		/// Specifies the alpha comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER, 
		/// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range 01, where 0 
		/// represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.AlphaFunc is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void AlphaFunc(AlphaFunction func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc((Int32)func, @ref);
			LogFunction("glAlphaFunc({0}, {1})", func, @ref);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the pixel zoom factors
		/// </summary>
		/// <param name="xfactor">
		/// Specify the x and y zoom factors for pixel write operations.
		/// </param>
		/// <param name="yfactor">
		/// Specify the x and y zoom factors for pixel write operations.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelZoom is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelZoom(float xfactor, float yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoom != null, "pglPixelZoom not implemented");
			Delegates.pglPixelZoom(xfactor, yfactor);
			LogFunction("glPixelZoom({0}, {1})", xfactor, yfactor);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR, 
		/// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS, 
		/// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelTransfer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf((Int32)pname, param);
			LogFunction("glPixelTransferf({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR, 
		/// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS, 
		/// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelTransfer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi((Int32)pname, param);
			LogFunction("glPixelTransferi({0}, {1})", pname, param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, float[] values)
		{
			Debug.Assert(values.Length >= mapsize);
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((Int32)map, mapsize, p_values);
					LogFunction("glPixelMapfv({0}, {1}, {2})", map, mapsize, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((Int32)map, (Int32)values.Length, p_values);
					LogFunction("glPixelMapfv({0}, {1}, {2})", map, values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt32[] values)
		{
			Debug.Assert(values.Length >= mapsize);
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((Int32)map, mapsize, p_values);
					LogFunction("glPixelMapuiv({0}, {1}, {2})", map, mapsize, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((Int32)map, (Int32)values.Length, p_values);
					LogFunction("glPixelMapuiv({0}, {1}, {2})", map, values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt16[] values)
		{
			Debug.Assert(values.Length >= mapsize);
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((Int32)map, mapsize, p_values);
					LogFunction("glPixelMapusv({0}, {1}, {2})", map, mapsize, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((Int32)map, (Int32)values.Length, p_values);
					LogFunction("glPixelMapusv({0}, {1}, {2})", map, values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels in the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
		/// </param>
		/// <param name="type">
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants Gl.COLOR, Gl.DEPTH, 
		/// and Gl.STENCIL are accepted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.DEPTH and there is no depth buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.STENCIL and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, (Int32)type);
			LogFunction("glCopyPixels({0}, {1}, {2}, {3}, {4})", x, y, width, height, type);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not either 
		/// Gl.COLOR_INDEX or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.RGBA, 
		/// Gl.BGR, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA, and the GL is in color index mode.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DrawPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, (Int32)format, (Int32)type, pixels);
			LogFunction("glDrawPixels({0}, {1}, {2}, {3}, 0x{4})", width, height, format, type, pixels.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not either 
		/// Gl.COLOR_INDEX or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.RGBA, 
		/// Gl.BGR, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA, and the GL is in color index mode.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DrawPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				DrawPixels(width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return the coefficients of the specified clipping plane
		/// </summary>
		/// <param name="plane">
		/// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping 
		/// planes are supported. They are identified by symbolic names of the form Gl.CLIP_PLANEi where i ranges from 0 to the 
		/// value of Gl.MAX_CLIP_PLANES - 1.
		/// </param>
		/// <param name="equation">
		/// Returns four double-precision values that are the coefficients of the plane equation of <paramref name="plane"/> in eye 
		/// coordinates. The initial value is (0, 0, 0, 0).
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetClipPlane is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ClipPlane"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetClipPlane(ClipPlaneName plane, [Out] double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane((Int32)plane, p_equation);
					LogFunction("glGetClipPlane({0}, {1})", plane, LogValue(equation));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of 
		/// Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, 
		/// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION, 
		/// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetLight is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv((Int32)light, (Int32)pname, p_params);
					LogFunction("glGetLightfv({0}, {1}, {2})", light, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of 
		/// Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, 
		/// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION, 
		/// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetLight is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv((Int32)light, (Int32)pname, p_params);
					LogFunction("glGetLightiv({0}, {1}, {2})", light, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv((Int32)target, (Int32)query, p_v);
					LogFunction("glGetMapdv({0}, {1}, {2})", target, query, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv((Int32)target, (Int32)query, p_v);
					LogFunction("glGetMapfv({0}, {1}, {2})", target, query, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv((Int32)target, (Int32)query, p_v);
					LogFunction("glGetMapiv({0}, {1}, {2})", target, query, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and back 
		/// materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and 
		/// Gl.COLOR_INDEXES are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMaterial is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv((Int32)face, (Int32)pname, p_params);
					LogFunction("glGetMaterialfv({0}, {1}, {2})", face, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and back 
		/// materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and 
		/// Gl.COLOR_INDEXES are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMaterial is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv((Int32)face, (Int32)pname, p_params);
					LogFunction("glGetMaterialiv({0}, {1}, {2})", face, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv((Int32)map, p_values);
					LogFunction("glGetPixelMapfv({0}, {1})", map, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv((Int32)map, p_values);
					LogFunction("glGetPixelMapuiv({0}, {1})", map, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv((Int32)map, p_values);
					LogFunction("glGetPixelMapusv({0}, {1})", map, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the polygon stipple pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPolygonStipple is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPolygonStipple([Out] byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglGetPolygonStipple != null, "pglGetPolygonStipple not implemented");
					Delegates.pglGetPolygonStipple(p_mask);
					LogFunction("glGetPolygonStipple({0})", LogValue(mask));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, 
		/// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, 
		/// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexEnv"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexEnvfv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, 
		/// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, 
		/// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexEnv"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv((Int32)target, (Int32)pname, p_params);
					LogFunction("glGetTexEnviv({0}, {1}, {2})", target, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetTexGendv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetTexGenfv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv((Int32)coord, (Int32)pname, p_params);
					LogFunction("glGetTexGeniv({0}, {1}, {2})", coord, pname, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// determine if a name corresponds to a display list
		/// </summary>
		/// <param name="list">
		/// Specifies a potential display list name.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.IsList is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static bool IsList(UInt32 list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsList != null, "pglIsList not implemented");
			retValue = Delegates.pglIsList(list);
			LogFunction("glIsList({0}) = {1}", list, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// multiply the current matrix by a perspective matrix
		/// </summary>
		/// <param name="left">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="right">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="top">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="nearVal"/> or <paramref name="farVal"/> is not positive, or if 
		/// <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = <paramref name="top"/>, or <paramref 
		/// name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Frustum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglFrustum != null, "pglFrustum not implemented");
			Delegates.pglFrustum(left, right, bottom, top, zNear, zFar);
			LogFunction("glFrustum({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the identity matrix
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadIdentity is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadIdentity()
		{
			Debug.Assert(Delegates.pglLoadIdentity != null, "pglLoadIdentity not implemented");
			Delegates.pglLoadIdentity();
			LogFunction("glLoadIdentity()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
					Delegates.pglLoadMatrixf(p_m);
					LogFunction("glLoadMatrixf({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
					Delegates.pglLoadMatrixd(p_m);
					LogFunction("glLoadMatrixd({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify which matrix is the current matrix
		/// </summary>
		/// <param name="mode">
		/// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: Gl.MODELVIEW, 
		/// Gl.PROJECTION, and Gl.TEXTURE. The initial value is Gl.MODELVIEW. Additionally, if the ARB_imaging extension is 
		/// supported, Gl.COLOR is also accepted.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MatrixMode is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PopMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MatrixMode(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode((Int32)mode);
			LogFunction("glMatrixMode({0})", mode);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
					Delegates.pglMultMatrixf(p_m);
					LogFunction("glMultMatrixf({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
					Delegates.pglMultMatrixd(p_m);
					LogFunction("glMultMatrixd({0})", LogValue(m));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with an orthographic matrix
		/// </summary>
		/// <param name="left">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="right">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="top">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = 
		/// <paramref name="top"/>, or <paramref name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Ortho is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglOrtho != null, "pglOrtho not implemented");
			Delegates.pglOrtho(left, right, bottom, top, zNear, zFar);
			LogFunction("glOrtho({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushMatrix is called while the current matrix stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopMatrix is called while the current matrix stack contains only a single matrix.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushMatrix or Gl\.PopMatrix is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopMatrix()
		{
			Debug.Assert(Delegates.pglPopMatrix != null, "pglPopMatrix not implemented");
			Delegates.pglPopMatrix();
			LogFunction("glPopMatrix()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushMatrix is called while the current matrix stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopMatrix is called while the current matrix stack contains only a single matrix.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushMatrix or Gl\.PopMatrix is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushMatrix()
		{
			Debug.Assert(Delegates.pglPushMatrix != null, "pglPushMatrix not implemented");
			Delegates.pglPushMatrix();
			LogFunction("glPushMatrix()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees.
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rotate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(double angle, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRotated != null, "pglRotated not implemented");
			Delegates.pglRotated(angle, x, y, z);
			LogFunction("glRotated({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees.
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rotate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(float angle, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRotatef != null, "pglRotatef not implemented");
			Delegates.pglRotatef(angle, x, y, z);
			LogFunction("glRotatef({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a general scaling matrix
		/// </summary>
		/// <param name="x">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="y">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="z">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Scale is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglScaled != null, "pglScaled not implemented");
			Delegates.pglScaled(x, y, z);
			LogFunction("glScaled({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a general scaling matrix
		/// </summary>
		/// <param name="x">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="y">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="z">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Scale is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglScalef != null, "pglScalef not implemented");
			Delegates.pglScalef(x, y, z);
			LogFunction("glScalef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a translation matrix
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Translate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglTranslated != null, "pglTranslated not implemented");
			Delegates.pglTranslated(x, y, z);
			LogFunction("glTranslated({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a translation matrix
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Translate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTranslatef != null, "pglTranslatef not implemented");
			Delegates.pglTranslatef(x, y, z);
			LogFunction("glTranslatef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
			internal extern static void glCullFace(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
			internal extern static void glFrontFace(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
			internal extern static void glHint(Int32 target, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
			internal extern static void glLineWidth(float width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
			internal extern static void glPointSize(float size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
			internal extern static void glPolygonMode(Int32 face, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
			internal extern static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
			internal extern static void glTexParameterf(Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
			internal extern static void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
			internal extern static void glDrawBuffer(Int32 buf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
			internal extern static void glClear(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
			internal extern static void glClearColor(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
			internal extern static void glClearStencil(Int32 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
			internal extern static void glClearDepth(double depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
			internal extern static void glStencilMask(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
			internal extern static void glColorMask(bool red, bool green, bool blue, bool alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
			internal extern static void glDepthMask(bool flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
			internal extern static void glDisable(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
			internal extern static void glEnable(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
			internal extern static void glFinish();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
			internal extern static void glFlush();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
			internal extern static void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
			internal extern static void glLogicOp(Int32 opcode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
			internal extern static void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
			internal extern static void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
			internal extern static void glDepthFunc(Int32 func);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
			internal extern static void glPixelStoref(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
			internal extern static void glPixelStorei(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
			internal extern static void glReadBuffer(Int32 src);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
			internal extern static unsafe void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
			internal extern static unsafe void glGetBooleanv(Int32 pname, bool* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublev(Int32 pname, double* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
			internal extern static Int32 glGetError();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
			internal extern static unsafe void glGetFloatv(Int32 pname, float* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerv(Int32 pname, Int32* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
			internal extern static IntPtr glGetString(Int32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnabled(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
			internal extern static void glDepthRange(double near, double far);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
			internal extern static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNewList", ExactSpelling = true)]
			internal extern static void glNewList(UInt32 list, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEndList", ExactSpelling = true)]
			internal extern static void glEndList();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCallList", ExactSpelling = true)]
			internal extern static void glCallList(UInt32 list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCallLists", ExactSpelling = true)]
			internal extern static unsafe void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
			internal extern static void glDeleteLists(UInt32 list, Int32 range);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenLists", ExactSpelling = true)]
			internal extern static UInt32 glGenLists(Int32 range);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListBase", ExactSpelling = true)]
			internal extern static void glListBase(UInt32 @base);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBegin", ExactSpelling = true)]
			internal extern static void glBegin(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBitmap", ExactSpelling = true)]
			internal extern static unsafe void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3b", ExactSpelling = true)]
			internal extern static void glColor3b(sbyte red, sbyte green, sbyte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
			internal extern static unsafe void glColor3bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3d", ExactSpelling = true)]
			internal extern static void glColor3d(double red, double green, double blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
			internal extern static unsafe void glColor3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3f", ExactSpelling = true)]
			internal extern static void glColor3f(float red, float green, float blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
			internal extern static unsafe void glColor3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3i", ExactSpelling = true)]
			internal extern static void glColor3i(Int32 red, Int32 green, Int32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
			internal extern static unsafe void glColor3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3s", ExactSpelling = true)]
			internal extern static void glColor3s(Int16 red, Int16 green, Int16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
			internal extern static unsafe void glColor3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
			internal extern static void glColor3ub(byte red, byte green, byte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor3ubv(byte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
			internal extern static void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor3uiv(UInt32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3us", ExactSpelling = true)]
			internal extern static void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
			internal extern static unsafe void glColor3usv(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4b", ExactSpelling = true)]
			internal extern static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
			internal extern static unsafe void glColor4bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4d", ExactSpelling = true)]
			internal extern static void glColor4d(double red, double green, double blue, double alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
			internal extern static unsafe void glColor4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4f", ExactSpelling = true)]
			internal extern static void glColor4f(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
			internal extern static unsafe void glColor4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4i", ExactSpelling = true)]
			internal extern static void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
			internal extern static unsafe void glColor4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4s", ExactSpelling = true)]
			internal extern static void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
			internal extern static unsafe void glColor4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
			internal extern static void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubv(byte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
			internal extern static void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor4uiv(UInt32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4us", ExactSpelling = true)]
			internal extern static void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
			internal extern static unsafe void glColor4usv(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
			internal extern static void glEdgeFlag(bool flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagv(bool* flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnd", ExactSpelling = true)]
			internal extern static void glEnd();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexd", ExactSpelling = true)]
			internal extern static void glIndexd(double c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
			internal extern static unsafe void glIndexdv(double* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexf", ExactSpelling = true)]
			internal extern static void glIndexf(float c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
			internal extern static unsafe void glIndexfv(float* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexi", ExactSpelling = true)]
			internal extern static void glIndexi(Int32 c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
			internal extern static unsafe void glIndexiv(Int32* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexs", ExactSpelling = true)]
			internal extern static void glIndexs(Int16 c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
			internal extern static unsafe void glIndexsv(Int16* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
			internal extern static void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
			internal extern static void glNormal3d(double nx, double ny, double nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
			internal extern static void glNormal3f(float nx, float ny, float nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
			internal extern static void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
			internal extern static void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
			internal extern static void glRasterPos2d(double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
			internal extern static void glRasterPos2f(float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
			internal extern static void glRasterPos2i(Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
			internal extern static void glRasterPos2s(Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
			internal extern static void glRasterPos3d(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
			internal extern static void glRasterPos3f(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
			internal extern static void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
			internal extern static void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
			internal extern static void glRasterPos4d(double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
			internal extern static void glRasterPos4f(float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
			internal extern static void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
			internal extern static void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectd", ExactSpelling = true)]
			internal extern static void glRectd(double x1, double y1, double x2, double y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectdv", ExactSpelling = true)]
			internal extern static unsafe void glRectdv(double* v1, double* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectf", ExactSpelling = true)]
			internal extern static void glRectf(float x1, float y1, float x2, float y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectfv", ExactSpelling = true)]
			internal extern static unsafe void glRectfv(float* v1, float* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRecti", ExactSpelling = true)]
			internal extern static void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectiv", ExactSpelling = true)]
			internal extern static unsafe void glRectiv(Int32* v1, Int32* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRects", ExactSpelling = true)]
			internal extern static void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectsv", ExactSpelling = true)]
			internal extern static unsafe void glRectsv(Int16* v1, Int16* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
			internal extern static void glTexCoord1d(double s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
			internal extern static void glTexCoord1f(float s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
			internal extern static void glTexCoord1i(Int32 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
			internal extern static void glTexCoord1s(Int16 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
			internal extern static void glTexCoord2d(double s, double t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
			internal extern static void glTexCoord2f(float s, float t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
			internal extern static void glTexCoord2i(Int32 s, Int32 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
			internal extern static void glTexCoord2s(Int16 s, Int16 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
			internal extern static void glTexCoord3d(double s, double t, double r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
			internal extern static void glTexCoord3f(float s, float t, float r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
			internal extern static void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
			internal extern static void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
			internal extern static void glTexCoord4d(double s, double t, double r, double q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
			internal extern static void glTexCoord4f(float s, float t, float r, float q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
			internal extern static void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
			internal extern static void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
			internal extern static void glVertex2d(double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
			internal extern static void glVertex2f(float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
			internal extern static void glVertex2i(Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
			internal extern static void glVertex2s(Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
			internal extern static void glVertex3d(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
			internal extern static void glVertex3f(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
			internal extern static void glVertex3i(Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
			internal extern static void glVertex3s(Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
			internal extern static void glVertex4d(double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
			internal extern static void glVertex4f(float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
			internal extern static void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
			internal extern static void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glClipPlane(Int32 plane, double* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
			internal extern static void glColorMaterial(Int32 face, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogf", ExactSpelling = true)]
			internal extern static void glFogf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogfv", ExactSpelling = true)]
			internal extern static unsafe void glFogfv(Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogi", ExactSpelling = true)]
			internal extern static void glFogi(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogiv", ExactSpelling = true)]
			internal extern static unsafe void glFogiv(Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightf", ExactSpelling = true)]
			internal extern static void glLightf(Int32 light, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightfv", ExactSpelling = true)]
			internal extern static unsafe void glLightfv(Int32 light, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLighti", ExactSpelling = true)]
			internal extern static void glLighti(Int32 light, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightiv", ExactSpelling = true)]
			internal extern static unsafe void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
			internal extern static void glLightModelf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelfv(Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
			internal extern static void glLightModeli(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
			internal extern static unsafe void glLightModeliv(Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
			internal extern static void glLineStipple(Int32 factor, UInt16 pattern);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
			internal extern static void glMaterialf(Int32 face, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMateriali", ExactSpelling = true)]
			internal extern static void glMateriali(Int32 face, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glPolygonStipple(byte* mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
			internal extern static void glShadeModel(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
			internal extern static void glTexEnvf(Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
			internal extern static void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGend", ExactSpelling = true)]
			internal extern static void glTexGend(Int32 coord, Int32 pname, double param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
			internal extern static void glTexGenf(Int32 coord, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
			internal extern static void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
			internal extern static unsafe void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
			internal extern static unsafe void glSelectBuffer(Int32 size, UInt32* buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
			internal extern static Int32 glRenderMode(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInitNames", ExactSpelling = true)]
			internal extern static void glInitNames();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadName", ExactSpelling = true)]
			internal extern static void glLoadName(UInt32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
			internal extern static void glPassThrough(float token);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopName", ExactSpelling = true)]
			internal extern static void glPopName();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushName", ExactSpelling = true)]
			internal extern static void glPushName(UInt32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
			internal extern static void glClearAccum(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
			internal extern static void glClearIndex(float c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
			internal extern static void glIndexMask(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAccum", ExactSpelling = true)]
			internal extern static void glAccum(Int32 op, float value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
			internal extern static void glPopAttrib();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
			internal extern static void glPushAttrib(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap1d", ExactSpelling = true)]
			internal extern static unsafe void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap1f", ExactSpelling = true)]
			internal extern static unsafe void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap2d", ExactSpelling = true)]
			internal extern static unsafe void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap2f", ExactSpelling = true)]
			internal extern static unsafe void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
			internal extern static void glMapGrid1d(Int32 un, double u1, double u2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
			internal extern static void glMapGrid1f(Int32 un, float u1, float u2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
			internal extern static void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
			internal extern static void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
			internal extern static void glEvalCoord1d(double u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1dv(double* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
			internal extern static void glEvalCoord1f(float u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1fv(float* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
			internal extern static void glEvalCoord2d(double u, double v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2dv(double* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
			internal extern static void glEvalCoord2f(float u, float v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2fv(float* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
			internal extern static void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
			internal extern static void glEvalPoint1(Int32 i);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
			internal extern static void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
			internal extern static void glEvalPoint2(Int32 i, Int32 j);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
			internal extern static void glAlphaFunc(Int32 func, float @ref);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
			internal extern static void glPixelZoom(float xfactor, float yfactor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
			internal extern static void glPixelTransferf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
			internal extern static void glPixelTransferi(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
			internal extern static void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
			internal extern static unsafe void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlane(Int32 plane, double* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapdv(Int32 target, Int32 query, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapfv(Int32 target, Int32 query, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapfv(Int32 map, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapuiv(Int32 map, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapusv(Int32 map, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glGetPolygonStipple(byte* mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsList", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsList(UInt32 list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustum", ExactSpelling = true)]
			internal extern static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
			internal extern static void glLoadIdentity();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixf(float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixd(double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
			internal extern static void glMatrixMode(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixf(float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixd(double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrtho", ExactSpelling = true)]
			internal extern static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
			internal extern static void glPopMatrix();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
			internal extern static void glPushMatrix();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotated", ExactSpelling = true)]
			internal extern static void glRotated(double angle, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotatef", ExactSpelling = true)]
			internal extern static void glRotatef(float angle, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScaled", ExactSpelling = true)]
			internal extern static void glScaled(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScalef", ExactSpelling = true)]
			internal extern static void glScalef(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslated", ExactSpelling = true)]
			internal extern static void glTranslated(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
			internal extern static void glTranslatef(float x, float y, float z);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCullFace(Int32 mode);

			[ThreadStatic]
			internal static glCullFace pglCullFace;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrontFace(Int32 mode);

			[ThreadStatic]
			internal static glFrontFace pglFrontFace;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHint(Int32 target, Int32 mode);

			[ThreadStatic]
			internal static glHint pglHint;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineWidth(float width);

			[ThreadStatic]
			internal static glLineWidth pglLineWidth;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointSize(float size);

			[ThreadStatic]
			internal static glPointSize pglPointSize;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonMode(Int32 face, Int32 mode);

			[AliasOf("glPolygonMode")]
			[AliasOf("glPolygonModeNV")]
			[ThreadStatic]
			internal static glPolygonMode pglPolygonMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glScissor pglScissor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameterf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexParameterf pglTexParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexParameterfv pglTexParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexParameteri pglTexParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexParameteriv pglTexParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage1D pglTexImage1D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage2D pglTexImage2D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawBuffer(Int32 buf);

			[ThreadStatic]
			internal static glDrawBuffer pglDrawBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClear(UInt32 mask);

			[ThreadStatic]
			internal static glClear pglClear;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearColor(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearColor pglClearColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearStencil(Int32 s);

			[ThreadStatic]
			internal static glClearStencil pglClearStencil;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepth(double depth);

			[ThreadStatic]
			internal static glClearDepth pglClearDepth;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilMask(UInt32 mask);

			[ThreadStatic]
			internal static glStencilMask pglStencilMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			[ThreadStatic]
			internal static glColorMask pglColorMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthMask(bool flag);

			[ThreadStatic]
			internal static glDepthMask pglDepthMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisable(Int32 cap);

			[ThreadStatic]
			internal static glDisable pglDisable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnable(Int32 cap);

			[ThreadStatic]
			internal static glEnable pglEnable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinish();

			[ThreadStatic]
			internal static glFinish pglFinish;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlush();

			[ThreadStatic]
			internal static glFlush pglFlush;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[ThreadStatic]
			internal static glBlendFunc pglBlendFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLogicOp(Int32 opcode);

			[ThreadStatic]
			internal static glLogicOp pglLogicOp;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFunc pglStencilFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[ThreadStatic]
			internal static glStencilOp pglStencilOp;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthFunc(Int32 func);

			[ThreadStatic]
			internal static glDepthFunc pglDepthFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStoref(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelStoref pglPixelStoref;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStorei(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelStorei pglPixelStorei;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadBuffer(Int32 src);

			[ThreadStatic]
			internal static glReadBuffer pglReadBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glReadPixels pglReadPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBooleanv(Int32 pname, bool* data);

			[ThreadStatic]
			internal static glGetBooleanv pglGetBooleanv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublev(Int32 pname, double* data);

			[ThreadStatic]
			internal static glGetDoublev pglGetDoublev;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetError();

			[ThreadStatic]
			internal static glGetError pglGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloatv(Int32 pname, float* data);

			[ThreadStatic]
			internal static glGetFloatv pglGetFloatv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerv(Int32 pname, Int32* data);

			[ThreadStatic]
			internal static glGetIntegerv pglGetIntegerv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetString(Int32 name);

			[ThreadStatic]
			internal static glGetString pglGetString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTexImage pglGetTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexParameterfv pglGetTexParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexParameteriv pglGetTexParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameterfv pglGetTexLevelParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameteriv pglGetTexLevelParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsEnabled(Int32 cap);

			[ThreadStatic]
			internal static glIsEnabled pglIsEnabled;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRange(double near, double far);

			[ThreadStatic]
			internal static glDepthRange pglDepthRange;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glViewport pglViewport;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNewList(UInt32 list, Int32 mode);

			[ThreadStatic]
			internal static glNewList pglNewList;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndList();

			[ThreadStatic]
			internal static glEndList pglEndList;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCallList(UInt32 list);

			[ThreadStatic]
			internal static glCallList pglCallList;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[ThreadStatic]
			internal static glCallLists pglCallLists;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteLists(UInt32 list, Int32 range);

			[ThreadStatic]
			internal static glDeleteLists pglDeleteLists;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenLists(Int32 range);

			[ThreadStatic]
			internal static glGenLists pglGenLists;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListBase(UInt32 @base);

			[ThreadStatic]
			internal static glListBase pglListBase;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBegin(Int32 mode);

			[ThreadStatic]
			internal static glBegin pglBegin;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[ThreadStatic]
			internal static glBitmap pglBitmap;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3b(sbyte red, sbyte green, sbyte blue);

			[ThreadStatic]
			internal static glColor3b pglColor3b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3bv(sbyte* v);

			[ThreadStatic]
			internal static glColor3bv pglColor3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3d(double red, double green, double blue);

			[ThreadStatic]
			internal static glColor3d pglColor3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3dv(double* v);

			[ThreadStatic]
			internal static glColor3dv pglColor3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3f(float red, float green, float blue);

			[ThreadStatic]
			internal static glColor3f pglColor3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3fv(float* v);

			[ThreadStatic]
			internal static glColor3fv pglColor3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3i(Int32 red, Int32 green, Int32 blue);

			[ThreadStatic]
			internal static glColor3i pglColor3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3iv(Int32* v);

			[ThreadStatic]
			internal static glColor3iv pglColor3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3s(Int16 red, Int16 green, Int16 blue);

			[ThreadStatic]
			internal static glColor3s pglColor3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3sv(Int16* v);

			[ThreadStatic]
			internal static glColor3sv pglColor3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ub(byte red, byte green, byte blue);

			[ThreadStatic]
			internal static glColor3ub pglColor3ub;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3ubv(byte* v);

			[ThreadStatic]
			internal static glColor3ubv pglColor3ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[ThreadStatic]
			internal static glColor3ui pglColor3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor3uiv pglColor3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[ThreadStatic]
			internal static glColor3us pglColor3us;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3usv(UInt16* v);

			[ThreadStatic]
			internal static glColor3usv pglColor3usv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[ThreadStatic]
			internal static glColor4b pglColor4b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4bv(sbyte* v);

			[ThreadStatic]
			internal static glColor4bv pglColor4bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4d(double red, double green, double blue, double alpha);

			[ThreadStatic]
			internal static glColor4d pglColor4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4dv(double* v);

			[ThreadStatic]
			internal static glColor4dv pglColor4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4f(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glColor4f pglColor4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4fv(float* v);

			[ThreadStatic]
			internal static glColor4fv pglColor4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[ThreadStatic]
			internal static glColor4i pglColor4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4iv(Int32* v);

			[ThreadStatic]
			internal static glColor4iv pglColor4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[ThreadStatic]
			internal static glColor4s pglColor4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4sv(Int16* v);

			[ThreadStatic]
			internal static glColor4sv pglColor4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[ThreadStatic]
			internal static glColor4ub pglColor4ub;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubv(byte* v);

			[ThreadStatic]
			internal static glColor4ubv pglColor4ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[ThreadStatic]
			internal static glColor4ui pglColor4ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor4uiv pglColor4uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[ThreadStatic]
			internal static glColor4us pglColor4us;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4usv(UInt16* v);

			[ThreadStatic]
			internal static glColor4usv pglColor4usv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlag(bool flag);

			[ThreadStatic]
			internal static glEdgeFlag pglEdgeFlag;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagv(bool* flag);

			[ThreadStatic]
			internal static glEdgeFlagv pglEdgeFlagv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnd();

			[ThreadStatic]
			internal static glEnd pglEnd;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexd(double c);

			[ThreadStatic]
			internal static glIndexd pglIndexd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexdv(double* c);

			[ThreadStatic]
			internal static glIndexdv pglIndexdv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexf(float c);

			[ThreadStatic]
			internal static glIndexf pglIndexf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexfv(float* c);

			[ThreadStatic]
			internal static glIndexfv pglIndexfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexi(Int32 c);

			[ThreadStatic]
			internal static glIndexi pglIndexi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexiv(Int32* c);

			[ThreadStatic]
			internal static glIndexiv pglIndexiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexs(Int16 c);

			[ThreadStatic]
			internal static glIndexs pglIndexs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexsv(Int16* c);

			[ThreadStatic]
			internal static glIndexsv pglIndexsv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[ThreadStatic]
			internal static glNormal3b pglNormal3b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3bv(sbyte* v);

			[ThreadStatic]
			internal static glNormal3bv pglNormal3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3d(double nx, double ny, double nz);

			[ThreadStatic]
			internal static glNormal3d pglNormal3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3dv(double* v);

			[ThreadStatic]
			internal static glNormal3dv pglNormal3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3f(float nx, float ny, float nz);

			[ThreadStatic]
			internal static glNormal3f pglNormal3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3fv(float* v);

			[ThreadStatic]
			internal static glNormal3fv pglNormal3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[ThreadStatic]
			internal static glNormal3i pglNormal3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3iv(Int32* v);

			[ThreadStatic]
			internal static glNormal3iv pglNormal3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[ThreadStatic]
			internal static glNormal3s pglNormal3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3sv(Int16* v);

			[ThreadStatic]
			internal static glNormal3sv pglNormal3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2d(double x, double y);

			[ThreadStatic]
			internal static glRasterPos2d pglRasterPos2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2dv(double* v);

			[ThreadStatic]
			internal static glRasterPos2dv pglRasterPos2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2f(float x, float y);

			[ThreadStatic]
			internal static glRasterPos2f pglRasterPos2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2fv(float* v);

			[ThreadStatic]
			internal static glRasterPos2fv pglRasterPos2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glRasterPos2i pglRasterPos2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos2iv pglRasterPos2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glRasterPos2s pglRasterPos2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos2sv pglRasterPos2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3d(double x, double y, double z);

			[ThreadStatic]
			internal static glRasterPos3d pglRasterPos3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3dv(double* v);

			[ThreadStatic]
			internal static glRasterPos3dv pglRasterPos3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3f(float x, float y, float z);

			[ThreadStatic]
			internal static glRasterPos3f pglRasterPos3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3fv(float* v);

			[ThreadStatic]
			internal static glRasterPos3fv pglRasterPos3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glRasterPos3i pglRasterPos3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos3iv pglRasterPos3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glRasterPos3s pglRasterPos3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos3sv pglRasterPos3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glRasterPos4d pglRasterPos4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4dv(double* v);

			[ThreadStatic]
			internal static glRasterPos4dv pglRasterPos4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glRasterPos4f pglRasterPos4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4fv(float* v);

			[ThreadStatic]
			internal static glRasterPos4fv pglRasterPos4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glRasterPos4i pglRasterPos4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos4iv pglRasterPos4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glRasterPos4s pglRasterPos4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos4sv pglRasterPos4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectd(double x1, double y1, double x2, double y2);

			[ThreadStatic]
			internal static glRectd pglRectd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectdv(double* v1, double* v2);

			[ThreadStatic]
			internal static glRectdv pglRectdv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectf(float x1, float y1, float x2, float y2);

			[ThreadStatic]
			internal static glRectf pglRectf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectfv(float* v1, float* v2);

			[ThreadStatic]
			internal static glRectfv pglRectfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[ThreadStatic]
			internal static glRecti pglRecti;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectiv(Int32* v1, Int32* v2);

			[ThreadStatic]
			internal static glRectiv pglRectiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[ThreadStatic]
			internal static glRects pglRects;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectsv(Int16* v1, Int16* v2);

			[ThreadStatic]
			internal static glRectsv pglRectsv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1d(double s);

			[ThreadStatic]
			internal static glTexCoord1d pglTexCoord1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1dv(double* v);

			[ThreadStatic]
			internal static glTexCoord1dv pglTexCoord1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1f(float s);

			[ThreadStatic]
			internal static glTexCoord1f pglTexCoord1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1fv(float* v);

			[ThreadStatic]
			internal static glTexCoord1fv pglTexCoord1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1i(Int32 s);

			[ThreadStatic]
			internal static glTexCoord1i pglTexCoord1i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord1iv pglTexCoord1iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1s(Int16 s);

			[ThreadStatic]
			internal static glTexCoord1s pglTexCoord1s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord1sv pglTexCoord1sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2d(double s, double t);

			[ThreadStatic]
			internal static glTexCoord2d pglTexCoord2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2dv(double* v);

			[ThreadStatic]
			internal static glTexCoord2dv pglTexCoord2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2f(float s, float t);

			[ThreadStatic]
			internal static glTexCoord2f pglTexCoord2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fv(float* v);

			[ThreadStatic]
			internal static glTexCoord2fv pglTexCoord2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2i(Int32 s, Int32 t);

			[ThreadStatic]
			internal static glTexCoord2i pglTexCoord2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord2iv pglTexCoord2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2s(Int16 s, Int16 t);

			[ThreadStatic]
			internal static glTexCoord2s pglTexCoord2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord2sv pglTexCoord2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3d(double s, double t, double r);

			[ThreadStatic]
			internal static glTexCoord3d pglTexCoord3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3dv(double* v);

			[ThreadStatic]
			internal static glTexCoord3dv pglTexCoord3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3f(float s, float t, float r);

			[ThreadStatic]
			internal static glTexCoord3f pglTexCoord3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3fv(float* v);

			[ThreadStatic]
			internal static glTexCoord3fv pglTexCoord3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[ThreadStatic]
			internal static glTexCoord3i pglTexCoord3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord3iv pglTexCoord3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[ThreadStatic]
			internal static glTexCoord3s pglTexCoord3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord3sv pglTexCoord3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4d(double s, double t, double r, double q);

			[ThreadStatic]
			internal static glTexCoord4d pglTexCoord4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4dv(double* v);

			[ThreadStatic]
			internal static glTexCoord4dv pglTexCoord4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4f(float s, float t, float r, float q);

			[ThreadStatic]
			internal static glTexCoord4f pglTexCoord4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fv(float* v);

			[ThreadStatic]
			internal static glTexCoord4fv pglTexCoord4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[ThreadStatic]
			internal static glTexCoord4i pglTexCoord4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord4iv pglTexCoord4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[ThreadStatic]
			internal static glTexCoord4s pglTexCoord4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord4sv pglTexCoord4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2d(double x, double y);

			[ThreadStatic]
			internal static glVertex2d pglVertex2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2dv(double* v);

			[ThreadStatic]
			internal static glVertex2dv pglVertex2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2f(float x, float y);

			[ThreadStatic]
			internal static glVertex2f pglVertex2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2fv(float* v);

			[ThreadStatic]
			internal static glVertex2fv pglVertex2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glVertex2i pglVertex2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2iv(Int32* v);

			[ThreadStatic]
			internal static glVertex2iv pglVertex2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glVertex2s pglVertex2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2sv(Int16* v);

			[ThreadStatic]
			internal static glVertex2sv pglVertex2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3d(double x, double y, double z);

			[ThreadStatic]
			internal static glVertex3d pglVertex3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3dv(double* v);

			[ThreadStatic]
			internal static glVertex3dv pglVertex3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3f(float x, float y, float z);

			[ThreadStatic]
			internal static glVertex3f pglVertex3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3fv(float* v);

			[ThreadStatic]
			internal static glVertex3fv pglVertex3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glVertex3i pglVertex3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3iv(Int32* v);

			[ThreadStatic]
			internal static glVertex3iv pglVertex3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glVertex3s pglVertex3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3sv(Int16* v);

			[ThreadStatic]
			internal static glVertex3sv pglVertex3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glVertex4d pglVertex4d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4dv(double* v);

			[ThreadStatic]
			internal static glVertex4dv pglVertex4dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glVertex4f pglVertex4f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4fv(float* v);

			[ThreadStatic]
			internal static glVertex4fv pglVertex4fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glVertex4i pglVertex4i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4iv(Int32* v);

			[ThreadStatic]
			internal static glVertex4iv pglVertex4iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glVertex4s pglVertex4s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4sv(Int16* v);

			[ThreadStatic]
			internal static glVertex4sv pglVertex4sv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glClipPlane pglClipPlane;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMaterial(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glColorMaterial pglColorMaterial;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogf(Int32 pname, float param);

			[ThreadStatic]
			internal static glFogf pglFogf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFogfv pglFogfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFogi pglFogi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogiv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFogiv pglFogiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightf(Int32 light, Int32 pname, float param);

			[ThreadStatic]
			internal static glLightf pglLightf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightfv pglLightfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLighti(Int32 light, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLighti pglLighti;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightiv pglLightiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModelf(Int32 pname, float param);

			[ThreadStatic]
			internal static glLightModelf pglLightModelf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightModelfv pglLightModelfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModeli(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLightModeli pglLightModeli;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModeliv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightModeliv pglLightModeliv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineStipple(Int32 factor, UInt16 pattern);

			[ThreadStatic]
			internal static glLineStipple pglLineStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMaterialf(Int32 face, Int32 pname, float param);

			[ThreadStatic]
			internal static glMaterialf pglMaterialf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMaterialfv pglMaterialfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMateriali(Int32 face, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMateriali pglMateriali;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMaterialiv pglMaterialiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glPolygonStipple pglPolygonStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShadeModel(Int32 mode);

			[ThreadStatic]
			internal static glShadeModel pglShadeModel;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexEnvf pglTexEnvf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexEnvfv pglTexEnvfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexEnvi pglTexEnvi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexEnviv pglTexEnviv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGend(Int32 coord, Int32 pname, double param);

			[ThreadStatic]
			internal static glTexGend pglTexGend;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glTexGendv pglTexGendv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGenf(Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexGenf pglTexGenf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexGenfv pglTexGenfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexGeni pglTexGeni;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexGeniv pglTexGeniv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[ThreadStatic]
			internal static glFeedbackBuffer pglFeedbackBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSelectBuffer(Int32 size, UInt32* buffer);

			[ThreadStatic]
			internal static glSelectBuffer pglSelectBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glRenderMode(Int32 mode);

			[ThreadStatic]
			internal static glRenderMode pglRenderMode;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInitNames();

			[ThreadStatic]
			internal static glInitNames pglInitNames;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadName(UInt32 name);

			[ThreadStatic]
			internal static glLoadName pglLoadName;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPassThrough(float token);

			[ThreadStatic]
			internal static glPassThrough pglPassThrough;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopName();

			[ThreadStatic]
			internal static glPopName pglPopName;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushName(UInt32 name);

			[ThreadStatic]
			internal static glPushName pglPushName;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearAccum(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearAccum pglClearAccum;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearIndex(float c);

			[ThreadStatic]
			internal static glClearIndex pglClearIndex;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexMask(UInt32 mask);

			[ThreadStatic]
			internal static glIndexMask pglIndexMask;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAccum(Int32 op, float value);

			[ThreadStatic]
			internal static glAccum pglAccum;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopAttrib();

			[ThreadStatic]
			internal static glPopAttrib pglPopAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushAttrib(UInt32 mask);

			[ThreadStatic]
			internal static glPushAttrib pglPushAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[ThreadStatic]
			internal static glMap1d pglMap1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[ThreadStatic]
			internal static glMap1f pglMap1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[ThreadStatic]
			internal static glMap2d pglMap2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[ThreadStatic]
			internal static glMap2f pglMap2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1d(Int32 un, double u1, double u2);

			[ThreadStatic]
			internal static glMapGrid1d pglMapGrid1d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1f(Int32 un, float u1, float u2);

			[ThreadStatic]
			internal static glMapGrid1f pglMapGrid1f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[ThreadStatic]
			internal static glMapGrid2d pglMapGrid2d;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[ThreadStatic]
			internal static glMapGrid2f pglMapGrid2f;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1d(double u);

			[ThreadStatic]
			internal static glEvalCoord1d pglEvalCoord1d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord1dv pglEvalCoord1dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1f(float u);

			[ThreadStatic]
			internal static glEvalCoord1f pglEvalCoord1f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord1fv pglEvalCoord1fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2d(double u, double v);

			[ThreadStatic]
			internal static glEvalCoord2d pglEvalCoord2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord2dv pglEvalCoord2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2f(float u, float v);

			[ThreadStatic]
			internal static glEvalCoord2f pglEvalCoord2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord2fv pglEvalCoord2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[ThreadStatic]
			internal static glEvalMesh1 pglEvalMesh1;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint1(Int32 i);

			[ThreadStatic]
			internal static glEvalPoint1 pglEvalPoint1;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[ThreadStatic]
			internal static glEvalMesh2 pglEvalMesh2;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint2(Int32 i, Int32 j);

			[ThreadStatic]
			internal static glEvalPoint2 pglEvalPoint2;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFunc(Int32 func, float @ref);

			[ThreadStatic]
			internal static glAlphaFunc pglAlphaFunc;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelZoom(float xfactor, float yfactor);

			[ThreadStatic]
			internal static glPixelZoom pglPixelZoom;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferf(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTransferf pglPixelTransferf;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTransferi pglPixelTransferi;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[ThreadStatic]
			internal static glPixelMapfv pglPixelMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[ThreadStatic]
			internal static glPixelMapuiv pglPixelMapuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[ThreadStatic]
			internal static glPixelMapusv pglPixelMapusv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[ThreadStatic]
			internal static glCopyPixels pglCopyPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glDrawPixels pglDrawPixels;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glGetClipPlane pglGetClipPlane;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetLightfv pglGetLightfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetLightiv pglGetLightiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapdv(Int32 target, Int32 query, double* v);

			[ThreadStatic]
			internal static glGetMapdv pglGetMapdv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapfv(Int32 target, Int32 query, float* v);

			[ThreadStatic]
			internal static glGetMapfv pglGetMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[ThreadStatic]
			internal static glGetMapiv pglGetMapiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMaterialfv pglGetMaterialfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMaterialiv pglGetMaterialiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapfv(Int32 map, float* values);

			[ThreadStatic]
			internal static glGetPixelMapfv pglGetPixelMapfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapuiv(Int32 map, UInt32* values);

			[ThreadStatic]
			internal static glGetPixelMapuiv pglGetPixelMapuiv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapusv(Int32 map, UInt16* values);

			[ThreadStatic]
			internal static glGetPixelMapusv pglGetPixelMapusv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glGetPolygonStipple pglGetPolygonStipple;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexEnvfv pglGetTexEnvfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexEnviv pglGetTexEnviv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetTexGendv pglGetTexGendv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexGenfv pglGetTexGenfv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexGeniv pglGetTexGeniv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsList(UInt32 list);

			[ThreadStatic]
			internal static glIsList pglIsList;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glFrustum pglFrustum;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadIdentity();

			[ThreadStatic]
			internal static glLoadIdentity pglLoadIdentity;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixf(float* m);

			[ThreadStatic]
			internal static glLoadMatrixf pglLoadMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixd(double* m);

			[ThreadStatic]
			internal static glLoadMatrixd pglLoadMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixMode(Int32 mode);

			[ThreadStatic]
			internal static glMatrixMode pglMatrixMode;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixf(float* m);

			[ThreadStatic]
			internal static glMultMatrixf pglMultMatrixf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixd(double* m);

			[ThreadStatic]
			internal static glMultMatrixd pglMultMatrixd;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glOrtho pglOrtho;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopMatrix();

			[ThreadStatic]
			internal static glPopMatrix pglPopMatrix;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushMatrix();

			[ThreadStatic]
			internal static glPushMatrix pglPushMatrix;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotated(double angle, double x, double y, double z);

			[ThreadStatic]
			internal static glRotated pglRotated;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotatef(float angle, float x, float y, float z);

			[ThreadStatic]
			internal static glRotatef pglRotatef;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScaled(double x, double y, double z);

			[ThreadStatic]
			internal static glScaled pglScaled;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScalef(float x, float y, float z);

			[ThreadStatic]
			internal static glScalef pglScalef;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslated(double x, double y, double z);

			[ThreadStatic]
			internal static glTranslated pglTranslated;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslatef(float x, float y, float z);

			[ThreadStatic]
			internal static glTranslatef pglTranslatef;

		}
	}

}
