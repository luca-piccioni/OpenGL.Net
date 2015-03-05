
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
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void CullFace(int mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace(mode);
			CallLog("glCullFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and 
		/// GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void CullFace(CullFaceMode mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace((int)mode);
			CallLog("glCullFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void FrontFace(int mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace(mode);
			CallLog("glFrontFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void FrontFace(FrontFaceDirection mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace((int)mode);
			CallLog("glFrontFace({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, 
		/// GL_TEXTURE_COMPRESSION_HINT, and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Hint(int target, int mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint(target, mode);
			CallLog("glHint({0}, {1})", target, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. GL_LINE_SMOOTH_HINT, GL_POLYGON_SMOOTH_HINT, 
		/// GL_TEXTURE_COMPRESSION_HINT, and GL_FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. GL_FASTEST, GL_NICEST, and GL_DONT_CARE are accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Hint(HintTarget target, HintMode mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint((int)target, (int)mode);
			CallLog("glHint({0}, {1})", target, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the width of rasterized lines
		/// </summary>
		/// <param name="width">
		/// Specifies the width of rasterized lines. The initial value is 1.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void LineWidth(float width)
		{
			Debug.Assert(Delegates.pglLineWidth != null, "pglLineWidth not implemented");
			Delegates.pglLineWidth(width);
			CallLog("glLineWidth({0})", width);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the diameter of rasterized points
		/// </summary>
		/// <param name="size">
		/// Specifies the diameter of rasterized points. The initial value is 1.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PointSize(float size)
		{
			Debug.Assert(Delegates.pglPointSize != null, "pglPointSize not implemented");
			Delegates.pglPointSize(size);
			CallLog("glPointSize({0})", size);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that mode applies to. Must be GL_FRONT_AND_BACK for front- and back-facing polygons.
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are GL_POINT, GL_LINE, and GL_FILL. The initial value is 
		/// GL_FILL for both front- and back-facing polygons.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PolygonMode(int face, int mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode(face, mode);
			CallLog("glPolygonMode({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that mode applies to. Must be GL_FRONT_AND_BACK for front- and back-facing polygons.
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are GL_POINT, GL_LINE, and GL_FILL. The initial value is 
		/// GL_FILL for both front- and back-facing polygons.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode((int)face, (int)mode);
			CallLog("glPolygonMode({0}, {1})", face, mode);
			DebugCheckErrors();
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
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are 
		/// set to the dimensions of that window.
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, width and height are 
		/// set to the dimensions of that window.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissor != null, "pglScissor not implemented");
			Delegates.pglScissor(x, y, width, height);
			CallLog("glScissor({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(int target, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf(target, pname, param);
			CallLog("glTexParameterf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf((int)target, (int)pname, param);
			CallLog("glTexParameterf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv(target, pname, p_params);
					CallLog("glTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv((int)target, (int)pname, p_params);
					CallLog("glTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri(target, pname, param);
			CallLog("glTexParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri((int)target, (int)pname, param);
			CallLog("glTexParameteri({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv(target, pname, p_params);
					CallLog("glTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, or <see cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// <see cref="Gl.TEXTURE_MIN_FILTER"/>, <see cref="Gl.TEXTURE_MAG_FILTER"/>, <see cref="Gl.TEXTURE_MIN_LOD"/>, <see 
		/// cref="Gl.TEXTURE_MAX_LOD"/>, <see cref="Gl.TEXTURE_BASE_LEVEL"/>, <see cref="Gl.TEXTURE_MAX_LEVEL"/>, <see 
		/// cref="Gl.TEXTURE_WRAP_S"/>, <see cref="Gl.TEXTURE_WRAP_T"/>, <see cref="Gl.TEXTURE_WRAP_R"/>, <see 
		/// cref="Gl.TEXTURE_PRIORITY"/>, <see cref="Gl.TEXTURE_COMPARE_MODE"/>, <see cref="Gl.TEXTURE_COMPARE_FUNC"/>, <see 
		/// cref="Gl.DEPTH_TEXTURE_MODE"/>, or <see cref="Gl.GENERATE_MIPMAP"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv((int)target, (int)pname, p_params);
					CallLog("glTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D(target, level, internalformat, width, border, format, type, pixels);
			CallLog("glTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D((int)target, level, internalformat, width, border, (int)format, (int)type, pixels);
			CallLog("glTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage1D(target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
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
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			CallLog("glTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D((int)target, level, internalformat, width, height, border, (int)format, (int)type, pixels);
			CallLog("glTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, border, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage2D(int target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage2D(target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see 
		/// cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see 
		/// cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: <see cref="Gl.UNSIGNED_BYTE"/>, 
		/// <see cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
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
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT, GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// are accepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DrawBuffer(int buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer(buf);
			CallLog("glDrawBuffer({0})", buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, 
		/// GL_FRONT_LEFT, GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK 
		/// are accepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts. For 
		/// framebuffer objects, GL_COLOR_ATTACHMENT$m$ and GL_NONE enums are accepted, where $m$ is a value between 0 and 
		/// GL_MAX_COLOR_ATTACHMENTS.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DrawBuffer(DrawBufferMode buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer((int)buf);
			CallLog("glDrawBuffer({0})", buf);
			DebugCheckErrors();
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Clear(uint mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear(mask);
			CallLog("glClear({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Clear(ClearBufferMask mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear((uint)mask);
			CallLog("glClear({0})", mask);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearColor != null, "pglClearColor not implemented");
			Delegates.pglClearColor(red, green, blue, alpha);
			CallLog("glClearColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the stencil buffer
		/// </summary>
		/// <param name="s">
		/// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ClearStencil(Int32 s)
		{
			Debug.Assert(Delegates.pglClearStencil != null, "pglClearStencil not implemented");
			Delegates.pglClearStencil(s);
			CallLog("glClearStencil({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="depth">
		/// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ClearDepth(double depth)
		{
			Debug.Assert(Delegates.pglClearDepth != null, "pglClearDepth not implemented");
			Delegates.pglClearDepth(depth);
			CallLog("glClearDepth({0})", depth);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the front and back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void StencilMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMask != null, "pglStencilMask not implemented");
			Delegates.pglStencilMask(mask);
			CallLog("glStencilMask({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="red">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="green">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="blue">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="alpha">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, 
		/// indicating that the color components are written.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglColorMask != null, "pglColorMask not implemented");
			Delegates.pglColorMask(red, green, blue, alpha);
			CallLog("glColorMask({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable writing into the depth buffer
		/// </summary>
		/// <param name="flag">
		/// Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. 
		/// Otherwise, it is enabled. Initially, depth buffer writing is enabled.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthMask(bool flag)
		{
			Debug.Assert(Delegates.pglDepthMask != null, "pglDepthMask not implemented");
			Delegates.pglDepthMask(flag);
			CallLog("glDepthMask({0})", flag);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Disable(int cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable(cap);
			CallLog("glDisable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Disable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable((int)cap);
			CallLog("glDisable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Enable(int cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable(cap);
			CallLog("glEnable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Enable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable((int)cap);
			CallLog("glEnable({0})", cap);
			DebugCheckErrors();
		}

		/// <summary>
		/// block until all GL execution is complete
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Finish()
		{
			Debug.Assert(Delegates.pglFinish != null, "pglFinish not implemented");
			Delegates.pglFinish();
			CallLog("glFinish()");
			DebugCheckErrors();
		}

		/// <summary>
		/// force execution of GL commands in finite time
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Flush()
		{
			Debug.Assert(Delegates.pglFlush != null, "pglFlush not implemented");
			Delegates.pglFlush();
			CallLog("glFlush()");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see cref="Gl.ONE_MINUS_SRC_COLOR"/>, 
		/// <see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see cref="Gl.ONE_MINUS_DST_ALPHA"/>, <see 
		/// cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see cref="Gl.CONSTANT_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>, and <see cref="Gl.SRC_ALPHA_SATURATE"/>. The initial value is <see 
		/// cref="Gl.ONE"/>.
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constants are accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see 
		/// cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_DST_ALPHA"/>. <see cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see 
		/// cref="Gl.CONSTANT_ALPHA"/>, and <see cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>. The initial value is <see cref="Gl.ZERO"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void BlendFunc(int sfactor, int dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc(sfactor, dfactor);
			CallLog("glBlendFunc({0}, {1})", sfactor, dfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see cref="Gl.ONE_MINUS_SRC_COLOR"/>, 
		/// <see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see cref="Gl.ONE_MINUS_DST_ALPHA"/>, <see 
		/// cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see cref="Gl.CONSTANT_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>, and <see cref="Gl.SRC_ALPHA_SATURATE"/>. The initial value is <see 
		/// cref="Gl.ONE"/>.
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constants are accepted: <see cref="Gl.ZERO"/>, <see cref="Gl.ONE"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.DST_COLOR"/>, <see cref="Gl.ONE_MINUS_DST_COLOR"/>, <see 
		/// cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, <see cref="Gl.DST_ALPHA"/>, <see 
		/// cref="Gl.ONE_MINUS_DST_ALPHA"/>. <see cref="Gl.CONSTANT_COLOR"/>, <see cref="Gl.ONE_MINUS_CONSTANT_COLOR"/>, <see 
		/// cref="Gl.CONSTANT_ALPHA"/>, and <see cref="Gl.ONE_MINUS_CONSTANT_ALPHA"/>. The initial value is <see cref="Gl.ZERO"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc((int)sfactor, (int)dfactor);
			CallLog("glBlendFunc({0}, {1})", sfactor, dfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, 
		/// GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, 
		/// GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void LogicOp(int opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp(opcode);
			CallLog("glLogicOp({0})", opcode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: GL_CLEAR, GL_SET, 
		/// GL_COPY, GL_COPY_INVERTED, GL_NOOP, GL_INVERT, GL_AND, GL_NAND, GL_OR, GL_NOR, GL_XOR, GL_EQUIV, GL_AND_REVERSE, 
		/// GL_AND_INVERTED, GL_OR_REVERSE, and GL_OR_INVERTED. The initial value is GL_COPY.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void LogicOp(LogicOp opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp((int)opcode);
			CallLog("glLogicOp({0})", opcode);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void StencilFunc(int func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc(func, @ref, mask);
			CallLog("glStencilFunc({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: GL_NEVER, GL_LESS, GL_LEQUAL, GL_GREATER, GL_GEQUAL, 
		/// GL_EQUAL, GL_NOTEQUAL, and GL_ALWAYS. The initial value is GL_ALWAYS.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc((int)func, @ref, mask);
			CallLog("glStencilFunc({0}, {1}, {2})", func, @ref, mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="fail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zpass">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void StencilOp(int fail, int zfail, int zpass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp(fail, zfail, zpass);
			CallLog("glStencilOp({0}, {1}, {2})", fail, zfail, zpass);
			DebugCheckErrors();
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="fail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zfail">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="zpass">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp((int)fail, (int)zfail, (int)zpass);
			CallLog("glStencilOp({0}, {1}, {2})", fail, zfail, zpass);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, 
		/// GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthFunc(int func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc(func);
			CallLog("glDepthFunc({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, 
		/// GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthFunc(DepthFunction func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc((int)func);
			CallLog("glDepthFunc({0})", func);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>, <see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>, <see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>, and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory: <see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>, <see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>, and <see cref="Gl.UNPACK_ALIGNMENT"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(int pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref(pname, param);
			CallLog("glPixelStoref({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>, <see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>, <see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>, and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory: <see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>, <see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>, and <see cref="Gl.UNPACK_ALIGNMENT"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(PixelStoreParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref((int)pname, param);
			CallLog("glPixelStoref({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>, <see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>, <see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>, and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory: <see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>, <see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>, and <see cref="Gl.UNPACK_ALIGNMENT"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei(pname, param);
			CallLog("glPixelStorei({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: <see 
		/// cref="Gl.PACK_SWAP_BYTES"/>, <see cref="Gl.PACK_LSB_FIRST"/>, <see cref="Gl.PACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.PACK_IMAGE_HEIGHT"/>, <see cref="Gl.PACK_SKIP_PIXELS"/>, <see cref="Gl.PACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.PACK_SKIP_IMAGES"/>, and <see cref="Gl.PACK_ALIGNMENT"/>. Six more affect the unpacking of pixel data from 
		/// memory: <see cref="Gl.UNPACK_SWAP_BYTES"/>, <see cref="Gl.UNPACK_LSB_FIRST"/>, <see cref="Gl.UNPACK_ROW_LENGTH"/>, <see 
		/// cref="Gl.UNPACK_IMAGE_HEIGHT"/>, <see cref="Gl.UNPACK_SKIP_PIXELS"/>, <see cref="Gl.UNPACK_SKIP_ROWS"/>, <see 
		/// cref="Gl.UNPACK_SKIP_IMAGES"/>, and <see cref="Gl.UNPACK_ALIGNMENT"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(PixelStoreParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei((int)pname, param);
			CallLog("glPixelStorei({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ReadBuffer(int src)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer(src);
			CallLog("glReadBuffer({0})", src);
			DebugCheckErrors();
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ReadBuffer(ReadBufferMode src)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer((int)src);
			CallLog("glReadBuffer({0})", src);
			DebugCheckErrors();
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>, <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, format, type, pixels);
			CallLog("glReadPixels({0}, {1}, {2}, {3}, {4}, {5}, {6})", x, y, width, height, format, type, pixels);
			DebugCheckErrors();
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
		/// Specifies the format of the pixel data. The following symbolic values are accepted: <see cref="Gl.COLOR_INDEX"/>, <see 
		/// cref="Gl.STENCIL_INDEX"/>, <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see 
		/// cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of <see cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, or <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, (int)format, (int)type, pixels);
			CallLog("glReadPixels({0}, {1}, {2}, {3}, {4}, {5}, {6})", x, y, width, height, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((int)pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((int)pname, p_data);
					CallLog("glGetBooleanv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((int)pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((int)pname, p_data);
					CallLog("glGetDoublev({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return error information
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static ErrorCode GetError()
		{
			ErrorCode retValue;

			Debug.Assert(Delegates.pglGetError != null, "pglGetError not implemented");
			retValue = (ErrorCode)Delegates.pglGetError();
			CallLog("glGetError() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((int)pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((int)pname, p_data);
					CallLog("glGetFloatv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((int)pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(int pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of glGet. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((int)pname, p_data);
					CallLog("glGetIntegerv({0}, {1})", pname, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringi accepts the GL_EXTENSIONS token.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static String GetString(int name)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetString(name));
			CallLog("glGetString({0}) = {1}", name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringi accepts the GL_EXTENSIONS token.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static String GetString(StringName name)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetString((int)name));
			CallLog("glGetString({0}) = {1}", name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, and <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/> are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, 
		/// <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(int target, Int32 level, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage(target, level, format, type, pixels);
			CallLog("glGetTexImage({0}, {1}, {2}, {3}, {4})", target, level, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. <see cref="Gl.TEXTURE_1D"/>, <see cref="Gl.TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_3D"/>, <see cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>, <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>, and <see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/> are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, 
		/// <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_INT"/>, <see 
		/// cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/>.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage((int)target, level, (int)format, (int)type, pixels);
			CallLog("glGetTexImage({0}, {1}, {2}, {3}, {4})", target, level, format, type, pixels);
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexParameter(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv(target, pname, p_params);
					CallLog("glGetTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv(target, pname, p_params);
					CallLog("glGetTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Must be one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP, or GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexLevelParameter(int target, Int32 level, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv(target, level, pname, p_params);
					CallLog("glGetTexLevelParameterfv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Must be one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP, or GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv((int)target, level, (int)pname, p_params);
					CallLog("glGetTexLevelParameterfv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Must be one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP, or GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexLevelParameter(int target, Int32 level, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv(target, level, pname, p_params);
					CallLog("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexLevelParameterfv and glGetTexLevelParameteriv functions. 
		/// Must be one of the following values: GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_PROXY_TEXTURE_1D, 
		/// GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY, 
		/// GL_PROXY_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE, GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// GL_PROXY_TEXTURE_CUBE_MAP, or GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_TEXTURE_WIDTH, GL_TEXTURE_HEIGHT, GL_TEXTURE_DEPTH, 
		/// GL_TEXTURE_INTERNAL_FORMAT, GL_TEXTURE_RED_SIZE, GL_TEXTURE_GREEN_SIZE, GL_TEXTURE_BLUE_SIZE, GL_TEXTURE_ALPHA_SIZE, 
		/// GL_TEXTURE_DEPTH_SIZE, GL_TEXTURE_COMPRESSED, GL_TEXTURE_COMPRESSED_IMAGE_SIZE, and GL_TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((int)target, level, (int)pname, p_params);
					CallLog("glGetTexLevelParameteriv({0}, {1}, {2}, {3})", target, level, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static bool IsEnabled(int cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled(cap);
			CallLog("glIsEnabled({0}) = {1}", cap, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static bool IsEnabled(EnableCap cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled((int)cap);
			CallLog("glIsEnabled({0}) = {1}", cap, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="near">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="far">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthRange(double near, double far)
		{
			Debug.Assert(Delegates.pglDepthRange != null, "pglDepthRange not implemented");
			Delegates.pglDepthRange(near, far);
			CallLog("glDepthRange({0}, {1})", near, far);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
			Delegates.pglViewport(x, y, width, height);
			CallLog("glViewport({0}, {1}, {2}, {3})", x, y, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the display-list name.
		/// </param>
		/// <param name="mode">
		/// Specifies the compilation mode, which can be <see cref="Gl.COMPILE"/> or <see cref="Gl.COMPILE_AND_EXECUTE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NewList(UInt32 list, int mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, mode);
			CallLog("glNewList({0}, {1})", list, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the display-list name.
		/// </param>
		/// <param name="mode">
		/// Specifies the compilation mode, which can be <see cref="Gl.COMPILE"/> or <see cref="Gl.COMPILE_AND_EXECUTE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NewList(UInt32 list, ListMode mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, (int)mode);
			CallLog("glNewList({0}, {1})", list, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EndList()
		{
			Debug.Assert(Delegates.pglEndList != null, "pglEndList not implemented");
			Delegates.pglEndList();
			CallLog("glEndList()");
			DebugCheckErrors();
		}

		/// <summary>
		/// execute a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the integer name of the display list to be executed.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallList(UInt32 list)
		{
			Debug.Assert(Delegates.pglCallList != null, "pglCallList not implemented");
			Delegates.pglCallList(list);
			CallLog("glCallList({0})", list);
			DebugCheckErrors();
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.2_BYTES"/>, <see cref="Gl.3_BYTES"/>, and <see 
		/// cref="Gl.4_BYTES"/> are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, int type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, type, lists);
			CallLog("glCallLists({0}, {1}, {2})", n, type, lists);
			DebugCheckErrors();
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.2_BYTES"/>, <see cref="Gl.3_BYTES"/>, and <see 
		/// cref="Gl.4_BYTES"/> are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, (int)type, lists);
			CallLog("glCallLists({0}, {1}, {2})", n, type, lists);
			DebugCheckErrors();
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.2_BYTES"/>, <see cref="Gl.3_BYTES"/>, and <see 
		/// cref="Gl.4_BYTES"/> are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, int type, Object lists)
		{
			GCHandle pin_lists = GCHandle.Alloc(lists, GCHandleType.Pinned);
			try {
				CallLists(n, type, pin_lists.AddrOfPinnedObject());
			} finally {
				pin_lists.Free();
			}
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants <see cref="Gl.BYTE"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE"/>, <see cref="Gl.SHORT"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.INT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.2_BYTES"/>, <see cref="Gl.3_BYTES"/>, and <see 
		/// cref="Gl.4_BYTES"/> are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DeleteLists(UInt32 list, Int32 range)
		{
			Debug.Assert(Delegates.pglDeleteLists != null, "pglDeleteLists not implemented");
			Delegates.pglDeleteLists(list, range);
			CallLog("glDeleteLists({0}, {1})", list, range);
			DebugCheckErrors();
		}

		/// <summary>
		/// generate a contiguous set of empty display lists
		/// </summary>
		/// <param name="range">
		/// Specifies the number of contiguous empty display lists to be generated.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static UInt32 GenLists(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenLists != null, "pglGenLists not implemented");
			retValue = Delegates.pglGenLists(range);
			CallLog("glGenLists({0}) = {1}", range, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// set the display-list base for glCallLists
		/// </summary>
		/// <param name="base">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ListBase(UInt32 @base)
		{
			Debug.Assert(Delegates.pglListBase != null, "pglListBase not implemented");
			Delegates.pglListBase(@base);
			CallLog("glListBase({0})", @base);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between <see cref="Gl.Begin"/> and 
		/// the subsequent Gl\.End. Ten symbolic constants are accepted: <see cref="Gl.POINTS"/>, <see cref="Gl.LINES"/>, <see 
		/// cref="Gl.LINE_STRIP"/>, <see cref="Gl.LINE_LOOP"/>, <see cref="Gl.TRIANGLES"/>, <see cref="Gl.TRIANGLE_STRIP"/>, <see 
		/// cref="Gl.TRIANGLE_FAN"/>, <see cref="Gl.QUADS"/>, <see cref="Gl.QUAD_STRIP"/>, and <see cref="Gl.POLYGON"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Begin(int mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin(mode);
			CallLog("glBegin({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between <see cref="Gl.Begin"/> and 
		/// the subsequent Gl\.End. Ten symbolic constants are accepted: <see cref="Gl.POINTS"/>, <see cref="Gl.LINES"/>, <see 
		/// cref="Gl.LINE_STRIP"/>, <see cref="Gl.LINE_LOOP"/>, <see cref="Gl.TRIANGLES"/>, <see cref="Gl.TRIANGLE_STRIP"/>, <see 
		/// cref="Gl.TRIANGLE_FAN"/>, <see cref="Gl.QUADS"/>, <see cref="Gl.QUAD_STRIP"/>, and <see cref="Gl.POLYGON"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Begin(PrimitiveType mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin((int)mode);
			CallLog("glBegin({0})", mode);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Bitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
					Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					CallLog("glBitmap({0}, {1}, {2}, {3}, {4}, {5}, {6})", width, height, xorig, yorig, xmove, ymove, bitmap);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglColor3b != null, "pglColor3b not implemented");
			Delegates.pglColor3b(red, green, blue);
			CallLog("glColor3b({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3bv != null, "pglColor3bv not implemented");
					Delegates.pglColor3bv(p_v);
					CallLog("glColor3bv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglColor3d != null, "pglColor3d not implemented");
			Delegates.pglColor3d(red, green, blue);
			CallLog("glColor3d({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3dv != null, "pglColor3dv not implemented");
					Delegates.pglColor3dv(p_v);
					CallLog("glColor3dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglColor3f != null, "pglColor3f not implemented");
			Delegates.pglColor3f(red, green, blue);
			CallLog("glColor3f({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3fv != null, "pglColor3fv not implemented");
					Delegates.pglColor3fv(p_v);
					CallLog("glColor3fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglColor3i != null, "pglColor3i not implemented");
			Delegates.pglColor3i(red, green, blue);
			CallLog("glColor3i({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3iv != null, "pglColor3iv not implemented");
					Delegates.pglColor3iv(p_v);
					CallLog("glColor3iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglColor3s != null, "pglColor3s not implemented");
			Delegates.pglColor3s(red, green, blue);
			CallLog("glColor3s({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3sv != null, "pglColor3sv not implemented");
					Delegates.pglColor3sv(p_v);
					CallLog("glColor3sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglColor3ub != null, "pglColor3ub not implemented");
			Delegates.pglColor3ub(red, green, blue);
			CallLog("glColor3ub({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3ubv != null, "pglColor3ubv not implemented");
					Delegates.pglColor3ubv(p_v);
					CallLog("glColor3ubv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglColor3ui != null, "pglColor3ui not implemented");
			Delegates.pglColor3ui(red, green, blue);
			CallLog("glColor3ui({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3uiv != null, "pglColor3uiv not implemented");
					Delegates.pglColor3uiv(p_v);
					CallLog("glColor3uiv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglColor3us != null, "pglColor3us not implemented");
			Delegates.pglColor3us(red, green, blue);
			CallLog("glColor3us({0}, {1}, {2})", red, green, blue);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3usv != null, "pglColor3usv not implemented");
					Delegates.pglColor3usv(p_v);
					CallLog("glColor3usv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			Debug.Assert(Delegates.pglColor4b != null, "pglColor4b not implemented");
			Delegates.pglColor4b(red, green, blue, alpha);
			CallLog("glColor4b({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4bv != null, "pglColor4bv not implemented");
					Delegates.pglColor4bv(p_v);
					CallLog("glColor4bv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double red, double green, double blue, double alpha)
		{
			Debug.Assert(Delegates.pglColor4d != null, "pglColor4d not implemented");
			Delegates.pglColor4d(red, green, blue, alpha);
			CallLog("glColor4d({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4dv != null, "pglColor4dv not implemented");
					Delegates.pglColor4dv(p_v);
					CallLog("glColor4dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglColor4f != null, "pglColor4f not implemented");
			Delegates.pglColor4f(red, green, blue, alpha);
			CallLog("glColor4f({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4fv != null, "pglColor4fv not implemented");
					Delegates.pglColor4fv(p_v);
					CallLog("glColor4fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Debug.Assert(Delegates.pglColor4i != null, "pglColor4i not implemented");
			Delegates.pglColor4i(red, green, blue, alpha);
			CallLog("glColor4i({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4iv != null, "pglColor4iv not implemented");
					Delegates.pglColor4iv(p_v);
					CallLog("glColor4iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			Debug.Assert(Delegates.pglColor4s != null, "pglColor4s not implemented");
			Delegates.pglColor4s(red, green, blue, alpha);
			CallLog("glColor4s({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4sv != null, "pglColor4sv not implemented");
					Delegates.pglColor4sv(p_v);
					CallLog("glColor4sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte red, byte green, byte blue, byte alpha)
		{
			Debug.Assert(Delegates.pglColor4ub != null, "pglColor4ub not implemented");
			Delegates.pglColor4ub(red, green, blue, alpha);
			CallLog("glColor4ub({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubv != null, "pglColor4ubv not implemented");
					Delegates.pglColor4ubv(p_v);
					CallLog("glColor4ubv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			Debug.Assert(Delegates.pglColor4ui != null, "pglColor4ui not implemented");
			Delegates.pglColor4ui(red, green, blue, alpha);
			CallLog("glColor4ui({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4uiv != null, "pglColor4uiv not implemented");
					Delegates.pglColor4uiv(p_v);
					CallLog("glColor4uiv({0})", v);
				}
			}
			DebugCheckErrors();
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
		/// Specifies a new alpha value for the current color. Included only in the four-argument <see cref="Gl.Color4"/> commands.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			Debug.Assert(Delegates.pglColor4us != null, "pglColor4us not implemented");
			Delegates.pglColor4us(red, green, blue, alpha);
			CallLog("glColor4us({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4usv != null, "pglColor4usv not implemented");
					Delegates.pglColor4usv(p_v);
					CallLog("glColor4usv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either <see cref="Gl.TRUE"/> or <see cref="Gl.FALSE"/>. The initial value is <see 
		/// cref="Gl.TRUE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool flag)
		{
			Debug.Assert(Delegates.pglEdgeFlag != null, "pglEdgeFlag not implemented");
			Delegates.pglEdgeFlag(flag);
			CallLog("glEdgeFlag({0})", flag);
			DebugCheckErrors();
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either <see cref="Gl.TRUE"/> or <see cref="Gl.FALSE"/>. The initial value is <see 
		/// cref="Gl.TRUE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool[] flag)
		{
			unsafe {
				fixed (bool* p_flag = flag)
				{
					Debug.Assert(Delegates.pglEdgeFlagv != null, "pglEdgeFlagv not implemented");
					Delegates.pglEdgeFlagv(p_flag);
					CallLog("glEdgeFlagv({0})", flag);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void End()
		{
			Debug.Assert(Delegates.pglEnd != null, "pglEnd not implemented");
			Delegates.pglEnd();
			CallLog("glEnd()");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double c)
		{
			Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
			Delegates.pglIndexd(c);
			CallLog("glIndexd({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double[] c)
		{
			unsafe {
				fixed (double* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
					Delegates.pglIndexdv(p_c);
					CallLog("glIndexdv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float c)
		{
			Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
			Delegates.pglIndexf(c);
			CallLog("glIndexf({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float[] c)
		{
			unsafe {
				fixed (float* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
					Delegates.pglIndexfv(p_c);
					CallLog("glIndexfv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32 c)
		{
			Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
			Delegates.pglIndexi(c);
			CallLog("glIndexi({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32[] c)
		{
			unsafe {
				fixed (Int32* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
					Delegates.pglIndexiv(p_c);
					CallLog("glIndexiv({0})", c);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16 c)
		{
			Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
			Delegates.pglIndexs(c);
			CallLog("glIndexs({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16[] c)
		{
			unsafe {
				fixed (Int16* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
					Delegates.pglIndexsv(p_c);
					CallLog("glIndexsv({0})", c);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
		{
			Debug.Assert(Delegates.pglNormal3b != null, "pglNormal3b not implemented");
			Delegates.pglNormal3b(nx, ny, nz);
			CallLog("glNormal3b({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3bv != null, "pglNormal3bv not implemented");
					Delegates.pglNormal3bv(p_v);
					CallLog("glNormal3bv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double nx, double ny, double nz)
		{
			Debug.Assert(Delegates.pglNormal3d != null, "pglNormal3d not implemented");
			Delegates.pglNormal3d(nx, ny, nz);
			CallLog("glNormal3d({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3dv != null, "pglNormal3dv not implemented");
					Delegates.pglNormal3dv(p_v);
					CallLog("glNormal3dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float nx, float ny, float nz)
		{
			Debug.Assert(Delegates.pglNormal3f != null, "pglNormal3f not implemented");
			Delegates.pglNormal3f(nx, ny, nz);
			CallLog("glNormal3f({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3fv != null, "pglNormal3fv not implemented");
					Delegates.pglNormal3fv(p_v);
					CallLog("glNormal3fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32 nx, Int32 ny, Int32 nz)
		{
			Debug.Assert(Delegates.pglNormal3i != null, "pglNormal3i not implemented");
			Delegates.pglNormal3i(nx, ny, nz);
			CallLog("glNormal3i({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3iv != null, "pglNormal3iv not implemented");
					Delegates.pglNormal3iv(p_v);
					CallLog("glNormal3iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16 nx, Int16 ny, Int16 nz)
		{
			Debug.Assert(Delegates.pglNormal3s != null, "pglNormal3s not implemented");
			Delegates.pglNormal3s(nx, ny, nz);
			CallLog("glNormal3s({0}, {1}, {2})", nx, ny, nz);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3sv != null, "pglNormal3sv not implemented");
					Delegates.pglNormal3sv(p_v);
					CallLog("glNormal3sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglRasterPos2d != null, "pglRasterPos2d not implemented");
			Delegates.pglRasterPos2d(x, y);
			CallLog("glRasterPos2d({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2dv != null, "pglRasterPos2dv not implemented");
					Delegates.pglRasterPos2dv(p_v);
					CallLog("glRasterPos2dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglRasterPos2f != null, "pglRasterPos2f not implemented");
			Delegates.pglRasterPos2f(x, y);
			CallLog("glRasterPos2f({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2fv != null, "pglRasterPos2fv not implemented");
					Delegates.pglRasterPos2fv(p_v);
					CallLog("glRasterPos2fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglRasterPos2i != null, "pglRasterPos2i not implemented");
			Delegates.pglRasterPos2i(x, y);
			CallLog("glRasterPos2i({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2iv != null, "pglRasterPos2iv not implemented");
					Delegates.pglRasterPos2iv(p_v);
					CallLog("glRasterPos2iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglRasterPos2s != null, "pglRasterPos2s not implemented");
			Delegates.pglRasterPos2s(x, y);
			CallLog("glRasterPos2s({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2sv != null, "pglRasterPos2sv not implemented");
					Delegates.pglRasterPos2sv(p_v);
					CallLog("glRasterPos2sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRasterPos3d != null, "pglRasterPos3d not implemented");
			Delegates.pglRasterPos3d(x, y, z);
			CallLog("glRasterPos3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3dv != null, "pglRasterPos3dv not implemented");
					Delegates.pglRasterPos3dv(p_v);
					CallLog("glRasterPos3dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRasterPos3f != null, "pglRasterPos3f not implemented");
			Delegates.pglRasterPos3f(x, y, z);
			CallLog("glRasterPos3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3fv != null, "pglRasterPos3fv not implemented");
					Delegates.pglRasterPos3fv(p_v);
					CallLog("glRasterPos3fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglRasterPos3i != null, "pglRasterPos3i not implemented");
			Delegates.pglRasterPos3i(x, y, z);
			CallLog("glRasterPos3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3iv != null, "pglRasterPos3iv not implemented");
					Delegates.pglRasterPos3iv(p_v);
					CallLog("glRasterPos3iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglRasterPos3s != null, "pglRasterPos3s not implemented");
			Delegates.pglRasterPos3s(x, y, z);
			CallLog("glRasterPos3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3sv != null, "pglRasterPos3sv not implemented");
					Delegates.pglRasterPos3sv(p_v);
					CallLog("glRasterPos3sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglRasterPos4d != null, "pglRasterPos4d not implemented");
			Delegates.pglRasterPos4d(x, y, z, w);
			CallLog("glRasterPos4d({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4dv != null, "pglRasterPos4dv not implemented");
					Delegates.pglRasterPos4dv(p_v);
					CallLog("glRasterPos4dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglRasterPos4f != null, "pglRasterPos4f not implemented");
			Delegates.pglRasterPos4f(x, y, z, w);
			CallLog("glRasterPos4f({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4fv != null, "pglRasterPos4fv not implemented");
					Delegates.pglRasterPos4fv(p_v);
					CallLog("glRasterPos4fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglRasterPos4i != null, "pglRasterPos4i not implemented");
			Delegates.pglRasterPos4i(x, y, z, w);
			CallLog("glRasterPos4i({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4iv != null, "pglRasterPos4iv not implemented");
					Delegates.pglRasterPos4iv(p_v);
					CallLog("glRasterPos4iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglRasterPos4s != null, "pglRasterPos4s not implemented");
			Delegates.pglRasterPos4s(x, y, z, w);
			CallLog("glRasterPos4s({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4sv != null, "pglRasterPos4sv not implemented");
					Delegates.pglRasterPos4sv(p_v);
					CallLog("glRasterPos4sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(double x1, double y1, double x2, double y2)
		{
			Debug.Assert(Delegates.pglRectd != null, "pglRectd not implemented");
			Delegates.pglRectd(x1, y1, x2, y2);
			CallLog("glRectd({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
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
					CallLog("glRectdv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(float x1, float y1, float x2, float y2)
		{
			Debug.Assert(Delegates.pglRectf != null, "pglRectf not implemented");
			Delegates.pglRectf(x1, y1, x2, y2);
			CallLog("glRectf({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
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
					CallLog("glRectfv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			Debug.Assert(Delegates.pglRecti != null, "pglRecti not implemented");
			Delegates.pglRecti(x1, y1, x2, y2);
			CallLog("glRecti({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
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
					CallLog("glRectiv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			Debug.Assert(Delegates.pglRects != null, "pglRects not implemented");
			Delegates.pglRects(x1, y1, x2, y2);
			CallLog("glRects({0}, {1}, {2}, {3})", x1, y1, x2, y2);
			DebugCheckErrors();
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
					CallLog("glRectsv({0}, {1})", v1, v2);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double s)
		{
			Debug.Assert(Delegates.pglTexCoord1d != null, "pglTexCoord1d not implemented");
			Delegates.pglTexCoord1d(s);
			CallLog("glTexCoord1d({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1dv != null, "pglTexCoord1dv not implemented");
					Delegates.pglTexCoord1dv(p_v);
					CallLog("glTexCoord1dv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float s)
		{
			Debug.Assert(Delegates.pglTexCoord1f != null, "pglTexCoord1f not implemented");
			Delegates.pglTexCoord1f(s);
			CallLog("glTexCoord1f({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1fv != null, "pglTexCoord1fv not implemented");
					Delegates.pglTexCoord1fv(p_v);
					CallLog("glTexCoord1fv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32 s)
		{
			Debug.Assert(Delegates.pglTexCoord1i != null, "pglTexCoord1i not implemented");
			Delegates.pglTexCoord1i(s);
			CallLog("glTexCoord1i({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1iv != null, "pglTexCoord1iv not implemented");
					Delegates.pglTexCoord1iv(p_v);
					CallLog("glTexCoord1iv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1s != null, "pglTexCoord1s not implemented");
			Delegates.pglTexCoord1s(s);
			CallLog("glTexCoord1s({0})", s);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1sv != null, "pglTexCoord1sv not implemented");
					Delegates.pglTexCoord1sv(p_v);
					CallLog("glTexCoord1sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double s, double t)
		{
			Debug.Assert(Delegates.pglTexCoord2d != null, "pglTexCoord2d not implemented");
			Delegates.pglTexCoord2d(s, t);
			CallLog("glTexCoord2d({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2dv != null, "pglTexCoord2dv not implemented");
					Delegates.pglTexCoord2dv(p_v);
					CallLog("glTexCoord2dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float s, float t)
		{
			Debug.Assert(Delegates.pglTexCoord2f != null, "pglTexCoord2f not implemented");
			Delegates.pglTexCoord2f(s, t);
			CallLog("glTexCoord2f({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fv != null, "pglTexCoord2fv not implemented");
					Delegates.pglTexCoord2fv(p_v);
					CallLog("glTexCoord2fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglTexCoord2i != null, "pglTexCoord2i not implemented");
			Delegates.pglTexCoord2i(s, t);
			CallLog("glTexCoord2i({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2iv != null, "pglTexCoord2iv not implemented");
					Delegates.pglTexCoord2iv(p_v);
					CallLog("glTexCoord2iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglTexCoord2s != null, "pglTexCoord2s not implemented");
			Delegates.pglTexCoord2s(s, t);
			CallLog("glTexCoord2s({0}, {1})", s, t);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2sv != null, "pglTexCoord2sv not implemented");
					Delegates.pglTexCoord2sv(p_v);
					CallLog("glTexCoord2sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double s, double t, double r)
		{
			Debug.Assert(Delegates.pglTexCoord3d != null, "pglTexCoord3d not implemented");
			Delegates.pglTexCoord3d(s, t, r);
			CallLog("glTexCoord3d({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3dv != null, "pglTexCoord3dv not implemented");
					Delegates.pglTexCoord3dv(p_v);
					CallLog("glTexCoord3dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float s, float t, float r)
		{
			Debug.Assert(Delegates.pglTexCoord3f != null, "pglTexCoord3f not implemented");
			Delegates.pglTexCoord3f(s, t, r);
			CallLog("glTexCoord3f({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3fv != null, "pglTexCoord3fv not implemented");
					Delegates.pglTexCoord3fv(p_v);
					CallLog("glTexCoord3fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglTexCoord3i != null, "pglTexCoord3i not implemented");
			Delegates.pglTexCoord3i(s, t, r);
			CallLog("glTexCoord3i({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3iv != null, "pglTexCoord3iv not implemented");
					Delegates.pglTexCoord3iv(p_v);
					CallLog("glTexCoord3iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglTexCoord3s != null, "pglTexCoord3s not implemented");
			Delegates.pglTexCoord3s(s, t, r);
			CallLog("glTexCoord3s({0}, {1}, {2})", s, t, r);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3sv != null, "pglTexCoord3sv not implemented");
					Delegates.pglTexCoord3sv(p_v);
					CallLog("glTexCoord3sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglTexCoord4d != null, "pglTexCoord4d not implemented");
			Delegates.pglTexCoord4d(s, t, r, q);
			CallLog("glTexCoord4d({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4dv != null, "pglTexCoord4dv not implemented");
					Delegates.pglTexCoord4dv(p_v);
					CallLog("glTexCoord4dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglTexCoord4f != null, "pglTexCoord4f not implemented");
			Delegates.pglTexCoord4f(s, t, r, q);
			CallLog("glTexCoord4f({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fv != null, "pglTexCoord4fv not implemented");
					Delegates.pglTexCoord4fv(p_v);
					CallLog("glTexCoord4fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglTexCoord4i != null, "pglTexCoord4i not implemented");
			Delegates.pglTexCoord4i(s, t, r, q);
			CallLog("glTexCoord4i({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4iv != null, "pglTexCoord4iv not implemented");
					Delegates.pglTexCoord4iv(p_v);
					CallLog("glTexCoord4iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglTexCoord4s != null, "pglTexCoord4s not implemented");
			Delegates.pglTexCoord4s(s, t, r, q);
			CallLog("glTexCoord4s({0}, {1}, {2}, {3})", s, t, r, q);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4sv != null, "pglTexCoord4sv not implemented");
					Delegates.pglTexCoord4sv(p_v);
					CallLog("glTexCoord4sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double x, double y)
		{
			Debug.Assert(Delegates.pglVertex2d != null, "pglVertex2d not implemented");
			Delegates.pglVertex2d(x, y);
			CallLog("glVertex2d({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2dv != null, "pglVertex2dv not implemented");
					Delegates.pglVertex2dv(p_v);
					CallLog("glVertex2dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float x, float y)
		{
			Debug.Assert(Delegates.pglVertex2f != null, "pglVertex2f not implemented");
			Delegates.pglVertex2f(x, y);
			CallLog("glVertex2f({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2fv != null, "pglVertex2fv not implemented");
					Delegates.pglVertex2fv(p_v);
					CallLog("glVertex2fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertex2i != null, "pglVertex2i not implemented");
			Delegates.pglVertex2i(x, y);
			CallLog("glVertex2i({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2iv != null, "pglVertex2iv not implemented");
					Delegates.pglVertex2iv(p_v);
					CallLog("glVertex2iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertex2s != null, "pglVertex2s not implemented");
			Delegates.pglVertex2s(x, y);
			CallLog("glVertex2s({0}, {1})", x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2sv != null, "pglVertex2sv not implemented");
					Delegates.pglVertex2sv(p_v);
					CallLog("glVertex2sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertex3d != null, "pglVertex3d not implemented");
			Delegates.pglVertex3d(x, y, z);
			CallLog("glVertex3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3dv != null, "pglVertex3dv not implemented");
					Delegates.pglVertex3dv(p_v);
					CallLog("glVertex3dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertex3f != null, "pglVertex3f not implemented");
			Delegates.pglVertex3f(x, y, z);
			CallLog("glVertex3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3fv != null, "pglVertex3fv not implemented");
					Delegates.pglVertex3fv(p_v);
					CallLog("glVertex3fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertex3i != null, "pglVertex3i not implemented");
			Delegates.pglVertex3i(x, y, z);
			CallLog("glVertex3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3iv != null, "pglVertex3iv not implemented");
					Delegates.pglVertex3iv(p_v);
					CallLog("glVertex3iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertex3s != null, "pglVertex3s not implemented");
			Delegates.pglVertex3s(x, y, z);
			CallLog("glVertex3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3sv != null, "pglVertex3sv not implemented");
					Delegates.pglVertex3sv(p_v);
					CallLog("glVertex3sv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertex4d != null, "pglVertex4d not implemented");
			Delegates.pglVertex4d(x, y, z, w);
			CallLog("glVertex4d({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4dv != null, "pglVertex4dv not implemented");
					Delegates.pglVertex4dv(p_v);
					CallLog("glVertex4dv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertex4f != null, "pglVertex4f not implemented");
			Delegates.pglVertex4f(x, y, z, w);
			CallLog("glVertex4f({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4fv != null, "pglVertex4fv not implemented");
					Delegates.pglVertex4fv(p_v);
					CallLog("glVertex4fv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertex4i != null, "pglVertex4i not implemented");
			Delegates.pglVertex4i(x, y, z, w);
			CallLog("glVertex4i({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4iv != null, "pglVertex4iv not implemented");
					Delegates.pglVertex4iv(p_v);
					CallLog("glVertex4iv({0})", v);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertex4s != null, "pglVertex4s not implemented");
			Delegates.pglVertex4s(x, y, z, w);
			CallLog("glVertex4s({0}, {1}, {2}, {3})", x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4sv != null, "pglVertex4sv not implemented");
					Delegates.pglVertex4sv(p_v);
					CallLog("glVertex4sv({0})", v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="plane">
		/// Specifies which clipping plane is being positioned. Symbolic names of the form <see cref="Gl.CLIP_PLANE"/>i, where i is 
		/// an integer between 0 and <see cref="Gl.MAX_CLIP_PLANES"/>-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a 
		/// plane equation.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClipPlane(int plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane(plane, p_equation);
					CallLog("glClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="plane">
		/// Specifies which clipping plane is being positioned. Symbolic names of the form <see cref="Gl.CLIP_PLANE"/>i, where i is 
		/// an integer between 0 and <see cref="Gl.MAX_CLIP_PLANES"/>-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a 
		/// plane equation.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane((int)plane, p_equation);
					CallLog("glClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// cause a material color to track the current color
		/// </summary>
		/// <param name="face">
		/// Specifies whether front, back, or both front and back material parameters should track the current color. Accepted 
		/// values are <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, and <see cref="Gl.FRONT_AND_BACK"/>. The initial value is <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="mode">
		/// Specifies which of several material parameters track the current color. Accepted values are <see cref="Gl.EMISSION"/>, 
		/// <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, and <see cref="Gl.AMBIENT_AND_DIFFUSE"/>. 
		/// The initial value is <see cref="Gl.AMBIENT_AND_DIFFUSE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorMaterial(int face, int mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial(face, mode);
			CallLog("glColorMaterial({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// cause a material color to track the current color
		/// </summary>
		/// <param name="face">
		/// Specifies whether front, back, or both front and back material parameters should track the current color. Accepted 
		/// values are <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, and <see cref="Gl.FRONT_AND_BACK"/>. The initial value is <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="mode">
		/// Specifies which of several material parameters track the current color. Accepted values are <see cref="Gl.EMISSION"/>, 
		/// <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, and <see cref="Gl.AMBIENT_AND_DIFFUSE"/>. 
		/// The initial value is <see cref="Gl.AMBIENT_AND_DIFFUSE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial((int)face, (int)mode);
			CallLog("glColorMaterial({0}, {1})", face, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(int pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf(pname, param);
			CallLog("glFogf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf((int)pname, param);
			CallLog("glFogf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv(pname, p_params);
					CallLog("glFogfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv((int)pname, p_params);
					CallLog("glFogfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi(pname, param);
			CallLog("glFogi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi((int)pname, param);
			CallLog("glFogi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv(pname, p_params);
					CallLog("glFogiv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. <see cref="Gl.FOG_MODE"/>, <see cref="Gl.FOG_DENSITY"/>, <see 
		/// cref="Gl.FOG_START"/>, <see cref="Gl.FOG_END"/>, <see cref="Gl.FOG_INDEX"/>, and <see cref="Gl.FOG_COORD_SRC"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv((int)pname, p_params);
					CallLog("glFogiv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(int light, int pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf(light, pname, param);
			CallLog("glLightf({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf((int)light, (int)pname, param);
			CallLog("glLightf({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(int light, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv(light, pname, p_params);
					CallLog("glLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv((int)light, (int)pname, p_params);
					CallLog("glLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(int light, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti(light, pname, param);
			CallLog("glLighti({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti((int)light, (int)pname, param);
			CallLog("glLighti({0}, {1}, {2})", light, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(int light, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv(light, pname, p_params);
					CallLog("glLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form <see cref="Gl.LIGHT"/>i, where i ranges from 0 to the value of <see 
		/// cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. <see cref="Gl.SPOT_EXPONENT"/>, <see 
		/// cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see cref="Gl.LINEAR_ATTENUATION"/>, and <see 
		/// cref="Gl.QUADRATIC_ATTENUATION"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv((int)light, (int)pname, p_params);
					CallLog("glLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(int pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf(pname, param);
			CallLog("glLightModelf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf((int)pname, param);
			CallLog("glLightModelf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv(pname, p_params);
					CallLog("glLightModelfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv((int)pname, p_params);
					CallLog("glLightModelfv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli(pname, param);
			CallLog("glLightModeli({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli((int)pname, param);
			CallLog("glLightModeli({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv(pname, p_params);
					CallLog("glLightModeliv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. <see cref="Gl.LIGHT_MODEL_LOCAL_VIEWER"/>, <see 
		/// cref="Gl.LIGHT_MODEL_COLOR_CONTROL"/>, and <see cref="Gl.LIGHT_MODEL_TWO_SIDE"/> are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv((int)pname, p_params);
					CallLog("glLightModeliv({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LineStipple(Int32 factor, UInt16 pattern)
		{
			Debug.Assert(Delegates.pglLineStipple != null, "pglLineStipple not implemented");
			Delegates.pglLineStipple(factor, pattern);
			CallLog("glLineStipple({0}, {1})", factor, pattern);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <see cref="Gl.SHININESS"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(int face, int pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf(face, pname, param);
			CallLog("glMaterialf({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <see cref="Gl.SHININESS"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf((int)face, (int)pname, param);
			CallLog("glMaterialf({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(int face, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv(face, pname, p_params);
					CallLog("glMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv((int)face, (int)pname, p_params);
					CallLog("glMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <see cref="Gl.SHININESS"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(int face, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali(face, pname, param);
			CallLog("glMateriali({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <see cref="Gl.SHININESS"/> will be set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali((int)face, (int)pname, param);
			CallLog("glMateriali({0}, {1}, {2})", face, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(int face, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv(face, pname, p_params);
					CallLog("glMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of <see cref="Gl.FRONT"/>, <see cref="Gl.BACK"/>, or <see 
		/// cref="Gl.FRONT_AND_BACK"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be <see 
		/// cref="Gl.SHININESS"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv((int)face, (int)pname, p_params);
					CallLog("glMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the polygon stippling pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglPolygonStipple != null, "pglPolygonStipple not implemented");
					Delegates.pglPolygonStipple(p_mask);
					CallLog("glPolygonStipple({0})", mask);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are <see cref="Gl.FLAT"/> and <see 
		/// cref="Gl.SMOOTH"/>. The initial value is <see cref="Gl.SMOOTH"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ShadeModel(int mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel(mode);
			CallLog("glShadeModel({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are <see cref="Gl.FLAT"/> and <see 
		/// cref="Gl.SMOOTH"/>. The initial value is <see cref="Gl.SMOOTH"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ShadeModel(ShadingModel mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel((int)mode);
			CallLog("glShadeModel({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>, <see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean 
		/// value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail 
		/// bias, or 1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(int target, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf(target, pname, param);
			CallLog("glTexEnvf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>, <see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean 
		/// value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail 
		/// bias, or 1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf((int)target, (int)pname, param);
			CallLog("glTexEnvf({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv(target, pname, p_params);
					CallLog("glTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv((int)target, (int)pname, p_params);
					CallLog("glTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>, <see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean 
		/// value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail 
		/// bias, or 1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(int target, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi(target, pname, param);
			CallLog("glTexEnvi({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of <see cref="Gl.ADD"/>, <see cref="Gl.ADD_SIGNED"/>, <see 
		/// cref="Gl.INTERPOLATE"/>, <see cref="Gl.MODULATE"/>, <see cref="Gl.DECAL"/>, <see cref="Gl.BLEND"/>, <see 
		/// cref="Gl.REPLACE"/>, <see cref="Gl.SUBTRACT"/>, <see cref="Gl.COMBINE"/>, <see cref="Gl.TEXTURE"/>, <see 
		/// cref="Gl.CONSTANT"/>, <see cref="Gl.PRIMARY_COLOR"/>, <see cref="Gl.PREVIOUS"/>, <see cref="Gl.SRC_COLOR"/>, <see 
		/// cref="Gl.ONE_MINUS_SRC_COLOR"/>, <see cref="Gl.SRC_ALPHA"/>, <see cref="Gl.ONE_MINUS_SRC_ALPHA"/>, a single boolean 
		/// value for the point sprite texture coordinate replacement, a single floating-point value for the texture level-of-detail 
		/// bias, or 1.0, 2.0, or 4.0 when specifying the <see cref="Gl.RGB_SCALE"/> or <see cref="Gl.ALPHA_SCALE"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi((int)target, (int)pname, param);
			CallLog("glTexEnvi({0}, {1}, {2})", target, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv(target, pname, p_params);
					CallLog("glTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/> or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either <see 
		/// cref="Gl.TEXTURE_ENV_MODE"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv((int)target, (int)pname, p_params);
					CallLog("glTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend(coord, pname, param);
			CallLog("glTexGend({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend((int)coord, (int)pname, param);
			CallLog("glTexGend({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv(coord, pname, p_params);
					CallLog("glTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv((int)coord, (int)pname, p_params);
					CallLog("glTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf(coord, pname, param);
			CallLog("glTexGenf({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf((int)coord, (int)pname, param);
			CallLog("glTexGenf({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv(coord, pname, p_params);
					CallLog("glTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv((int)coord, (int)pname, p_params);
					CallLog("glTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni(coord, pname, param);
			CallLog("glTexGeni({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of <see cref="Gl.OBJECT_LINEAR"/>, <see 
		/// cref="Gl.EYE_LINEAR"/>, <see cref="Gl.SPHERE_MAP"/>, <see cref="Gl.NORMAL_MAP"/>, or <see cref="Gl.REFLECTION_MAP"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni((int)coord, (int)pname, param);
			CallLog("glTexGeni({0}, {1}, {2})", coord, pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv(coord, pname, p_params);
					CallLog("glTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be <see cref="Gl.TEXTURE_GEN_MODE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv((int)coord, (int)pname, p_params);
					CallLog("glTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="size">
		/// Specifies the maximum number of values that can be written into <paramref name="buffer"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. <see cref="Gl.2D"/>, 
		/// <see cref="Gl.3D"/>, <see cref="Gl.3D_COLOR"/>, <see cref="Gl.3D_COLOR_TEXTURE"/>, and <see cref="Gl.4D_COLOR_TEXTURE"/> 
		/// are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(Int32 size, int type, float[] buffer)
		{
			Debug.Assert(buffer.Length >= size);

			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, type, p_buffer);
					CallLog("glFeedbackBuffer({0}, {1}, {2})", size, type, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="size">
		/// Specifies the maximum number of values that can be written into <paramref name="buffer"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. <see cref="Gl.2D"/>, 
		/// <see cref="Gl.3D"/>, <see cref="Gl.3D_COLOR"/>, <see cref="Gl.3D_COLOR_TEXTURE"/>, and <see cref="Gl.4D_COLOR_TEXTURE"/> 
		/// are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(Int32 size, FeedbackType type, float[] buffer)
		{
			Debug.Assert(buffer.Length >= size);

			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, (int)type, p_buffer);
					CallLog("glFeedbackBuffer({0}, {1}, {2})", size, type, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// establish a buffer for selection mode values
		/// </summary>
		/// <param name="size">
		/// Specifies the size of <paramref name="buffer"/>.
		/// </param>
		/// <param name="buffer">
		/// Returns the selection data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SelectBuffer(Int32 size, UInt32[] buffer)
		{
			Debug.Assert(buffer.Length >= size);

			unsafe {
				fixed (UInt32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglSelectBuffer != null, "pglSelectBuffer not implemented");
					Delegates.pglSelectBuffer(size, p_buffer);
					CallLog("glSelectBuffer({0}, {1})", size, buffer);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set rasterization mode
		/// </summary>
		/// <param name="mode">
		/// Specifies the rasterization mode. Three values are accepted: <see cref="Gl.RENDER"/>, <see cref="Gl.SELECT"/>, and <see 
		/// cref="Gl.FEEDBACK"/>. The initial value is <see cref="Gl.RENDER"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static Int32 RenderMode(int mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode(mode);
			CallLog("glRenderMode({0}) = {1}", mode, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// set rasterization mode
		/// </summary>
		/// <param name="mode">
		/// Specifies the rasterization mode. Three values are accepted: <see cref="Gl.RENDER"/>, <see cref="Gl.SELECT"/>, and <see 
		/// cref="Gl.FEEDBACK"/>. The initial value is <see cref="Gl.RENDER"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static Int32 RenderMode(RenderingMode mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode((int)mode);
			CallLog("glRenderMode({0}) = {1}", mode, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// initialize the name stack
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InitName()
		{
			Debug.Assert(Delegates.pglInitNames != null, "pglInitNames not implemented");
			Delegates.pglInitNames();
			CallLog("glInitNames()");
			DebugCheckErrors();
		}

		/// <summary>
		/// load a name onto the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will replace the top value on the name stack.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadName(UInt32 name)
		{
			Debug.Assert(Delegates.pglLoadName != null, "pglLoadName not implemented");
			Delegates.pglLoadName(name);
			CallLog("glLoadName({0})", name);
			DebugCheckErrors();
		}

		/// <summary>
		/// place a marker in the feedback buffer
		/// </summary>
		/// <param name="token">
		/// Specifies a marker value to be placed in the feedback buffer following a <see cref="Gl.PASS_THROUGH_TOKEN"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PassThrough(float token)
		{
			Debug.Assert(Delegates.pglPassThrough != null, "pglPassThrough not implemented");
			Delegates.pglPassThrough(token);
			CallLog("glPassThrough({0})", token);
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopName()
		{
			Debug.Assert(Delegates.pglPopName != null, "pglPopName not implemented");
			Delegates.pglPopName();
			CallLog("glPopName()");
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will be pushed onto the name stack.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushName(UInt32 name)
		{
			Debug.Assert(Delegates.pglPushName != null, "pglPushName not implemented");
			Delegates.pglPushName(name);
			CallLog("glPushName({0})", name);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearAccum(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearAccum != null, "pglClearAccum not implemented");
			Delegates.pglClearAccum(red, green, blue, alpha);
			CallLog("glClearAccum({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the color index buffers
		/// </summary>
		/// <param name="c">
		/// Specifies the index used when the color index buffers are cleared. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearIndex(float c)
		{
			Debug.Assert(Delegates.pglClearIndex != null, "pglClearIndex not implemented");
			Delegates.pglClearIndex(c);
			CallLog("glClearIndex({0})", c);
			DebugCheckErrors();
		}

		/// <summary>
		/// control the writing of individual bits in the color index buffers
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable the writing of individual bits in the color index buffers. Initially, the 
		/// mask is all 1's.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglIndexMask != null, "pglIndexMask not implemented");
			Delegates.pglIndexMask(mask);
			CallLog("glIndexMask({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// operate on the accumulation buffer
		/// </summary>
		/// <param name="op">
		/// Specifies the accumulation buffer operation. Symbolic constants <see cref="Gl.ACCUM"/>, <see cref="Gl.LOAD"/>, <see 
		/// cref="Gl.ADD"/>, <see cref="Gl.MULT"/>, and <see cref="Gl.RETURN"/> are accepted.
		/// </param>
		/// <param name="value">
		/// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op"/> determines how 
		/// <paramref name="value"/> is used.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Accum(int op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum(op, value);
			CallLog("glAccum({0}, {1})", op, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// operate on the accumulation buffer
		/// </summary>
		/// <param name="op">
		/// Specifies the accumulation buffer operation. Symbolic constants <see cref="Gl.ACCUM"/>, <see cref="Gl.LOAD"/>, <see 
		/// cref="Gl.ADD"/>, <see cref="Gl.MULT"/>, and <see cref="Gl.RETURN"/> are accepted.
		/// </param>
		/// <param name="value">
		/// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op"/> determines how 
		/// <paramref name="value"/> is used.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Accum(AccumOp op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum((int)op, value);
			CallLog("glAccum({0}, {1})", op, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopAttrib()
		{
			Debug.Assert(Delegates.pglPopAttrib != null, "pglPopAttrib not implemented");
			Delegates.pglPopAttrib();
			CallLog("glPopAttrib()");
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushAttrib(uint mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib(mask);
			CallLog("glPushAttrib({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushAttrib(AttribMask mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib((uint)mask);
			CallLog("glPushAttrib({0})", mask);
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <see cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see 
		/// cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(int target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d(target, u1, u2, stride, order, p_points);
					CallLog("glMap1d({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <see cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see 
		/// cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d((int)target, u1, u2, stride, order, p_points);
					CallLog("glMap1d({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <see cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see 
		/// cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(int target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f(target, u1, u2, stride, order, p_points);
					CallLog("glMap1f({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP1_VERTEX_3"/>, 
		/// <see cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP1_INDEX"/>, <see cref="Gl.MAP1_COLOR_4"/>, <see 
		/// cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP1_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f((int)target, u1, u2, stride, order, p_points);
					CallLog("glMap1f({0}, {1}, {2}, {3}, {4}, {5})", target, u1, u2, stride, order, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <see cref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see 
		/// cref="Gl.MAP2_NORMAL"/>, <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(int target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2d({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <see cref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see 
		/// cref="Gl.MAP2_NORMAL"/>, <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2d({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <see cref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see 
		/// cref="Gl.MAP2_NORMAL"/>, <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(int target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2f({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants <see cref="Gl.MAP2_VERTEX_3"/>, 
		/// <see cref="Gl.MAP2_VERTEX_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see 
		/// cref="Gl.MAP2_NORMAL"/>, <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP2_TEXTURE_COORD_3"/>, and <see cref="Gl.MAP2_TEXTURE_COORD_4"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f((int)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					CallLog("glMap2f({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, double u1, double u2)
		{
			Debug.Assert(Delegates.pglMapGrid1d != null, "pglMapGrid1d not implemented");
			Delegates.pglMapGrid1d(un, u1, u2);
			CallLog("glMapGrid1d({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, float u1, float u2)
		{
			Debug.Assert(Delegates.pglMapGrid1f != null, "pglMapGrid1f not implemented");
			Delegates.pglMapGrid1f(un, u1, u2);
			CallLog("glMapGrid1f({0}, {1}, {2})", un, u1, u2);
			DebugCheckErrors();
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
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] (<see 
		/// cref="Gl.MapGrid2"/> only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only).
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, double u1, double u2, Int32 vn, double v1, double v2)
		{
			Debug.Assert(Delegates.pglMapGrid2d != null, "pglMapGrid2d not implemented");
			Delegates.pglMapGrid2d(un, u1, u2, vn, v1, v2);
			CallLog("glMapGrid2d({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors();
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
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] (<see 
		/// cref="Gl.MapGrid2"/> only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (<see cref="Gl.MapGrid2"/> only).
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, float u1, float u2, Int32 vn, float v1, float v2)
		{
			Debug.Assert(Delegates.pglMapGrid2f != null, "pglMapGrid2f not implemented");
			Delegates.pglMapGrid2f(un, u1, u2, vn, v1, v2);
			CallLog("glMapGrid2f({0}, {1}, {2}, {3}, {4}, {5})", un, u1, u2, vn, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double u)
		{
			Debug.Assert(Delegates.pglEvalCoord1d != null, "pglEvalCoord1d not implemented");
			Delegates.pglEvalCoord1d(u);
			CallLog("glEvalCoord1d({0})", u);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1dv != null, "pglEvalCoord1dv not implemented");
					Delegates.pglEvalCoord1dv(p_u);
					CallLog("glEvalCoord1dv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float u)
		{
			Debug.Assert(Delegates.pglEvalCoord1f != null, "pglEvalCoord1f not implemented");
			Delegates.pglEvalCoord1f(u);
			CallLog("glEvalCoord1f({0})", u);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1fv != null, "pglEvalCoord1fv not implemented");
					Delegates.pglEvalCoord1fv(p_u);
					CallLog("glEvalCoord1fv({0})", u);
				}
			}
			DebugCheckErrors();
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
		/// argument is not present in a <see cref="Gl.EvalCoord1"/> command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double u, double v)
		{
			Debug.Assert(Delegates.pglEvalCoord2d != null, "pglEvalCoord2d not implemented");
			Delegates.pglEvalCoord2d(u, v);
			CallLog("glEvalCoord2d({0}, {1})", u, v);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2dv != null, "pglEvalCoord2dv not implemented");
					Delegates.pglEvalCoord2dv(p_u);
					CallLog("glEvalCoord2dv({0})", u);
				}
			}
			DebugCheckErrors();
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
		/// argument is not present in a <see cref="Gl.EvalCoord1"/> command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float u, float v)
		{
			Debug.Assert(Delegates.pglEvalCoord2f != null, "pglEvalCoord2f not implemented");
			Delegates.pglEvalCoord2f(u, v);
			CallLog("glEvalCoord2f({0}, {1})", u, v);
			DebugCheckErrors();
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2fv != null, "pglEvalCoord2fv not implemented");
					Delegates.pglEvalCoord2fv(p_u);
					CallLog("glEvalCoord2fv({0})", u);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants <see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh1(int mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1(mode, i1, i2);
			CallLog("glEvalMesh1({0}, {1}, {2})", mode, i1, i2);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants <see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1((int)mode, i1, i2);
			CallLog("glEvalMesh1({0}, {1}, {2})", mode, i1, i2);
			DebugCheckErrors();
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint1(Int32 i)
		{
			Debug.Assert(Delegates.pglEvalPoint1 != null, "pglEvalPoint1 not implemented");
			Delegates.pglEvalPoint1(i);
			CallLog("glEvalPoint1({0})", i);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants <see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2(mode, i1, i2, j1, j2);
			CallLog("glEvalMesh2({0}, {1}, {2}, {3}, {4})", mode, i1, i2, j1, j2);
			DebugCheckErrors();
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In <see cref="Gl.EvalMesh1"/>, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic 
		/// constants <see cref="Gl.POINT"/> and <see cref="Gl.LINE"/> are accepted.
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2((int)mode, i1, i2, j1, j2);
			CallLog("glEvalMesh2({0}, {1}, {2}, {3}, {4})", mode, i1, i2, j1, j2);
			DebugCheckErrors();
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		/// <param name="j">
		/// Specifies the integer value for grid domain variable j (<see cref="Gl.EvalPoint2"/> only).
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint2(Int32 i, Int32 j)
		{
			Debug.Assert(Delegates.pglEvalPoint2 != null, "pglEvalPoint2 not implemented");
			Delegates.pglEvalPoint2(i, j);
			CallLog("glEvalPoint2({0}, {1})", i, j);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the alpha test function
		/// </summary>
		/// <param name="func">
		/// Specifies the alpha comparison function. Symbolic constants <see cref="Gl.NEVER"/>, <see cref="Gl.LESS"/>, <see 
		/// cref="Gl.EQUAL"/>, <see cref="Gl.LEQUAL"/>, <see cref="Gl.GREATER"/>, <see cref="Gl.NOTEQUAL"/>, <see 
		/// cref="Gl.GEQUAL"/>, and <see cref="Gl.ALWAYS"/> are accepted. The initial value is <see cref="Gl.ALWAYS"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void AlphaFunc(int func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc(func, @ref);
			CallLog("glAlphaFunc({0}, {1})", func, @ref);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the alpha test function
		/// </summary>
		/// <param name="func">
		/// Specifies the alpha comparison function. Symbolic constants <see cref="Gl.NEVER"/>, <see cref="Gl.LESS"/>, <see 
		/// cref="Gl.EQUAL"/>, <see cref="Gl.LEQUAL"/>, <see cref="Gl.GREATER"/>, <see cref="Gl.NOTEQUAL"/>, <see 
		/// cref="Gl.GEQUAL"/>, and <see cref="Gl.ALWAYS"/> are accepted. The initial value is <see cref="Gl.ALWAYS"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void AlphaFunc(AlphaFunction func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc((int)func, @ref);
			CallLog("glAlphaFunc({0}, {1})", func, @ref);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelZoom(float xfactor, float yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoom != null, "pglPixelZoom not implemented");
			Delegates.pglPixelZoom(xfactor, yfactor);
			CallLog("glPixelZoom({0}, {1})", xfactor, yfactor);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: <see 
		/// cref="Gl.MAP_COLOR"/>, <see cref="Gl.MAP_STENCIL"/>, <see cref="Gl.INDEX_SHIFT"/>, <see cref="Gl.INDEX_OFFSET"/>, <see 
		/// cref="Gl.RED_SCALE"/>, <see cref="Gl.RED_BIAS"/>, <see cref="Gl.GREEN_SCALE"/>, <see cref="Gl.GREEN_BIAS"/>, <see 
		/// cref="Gl.BLUE_SCALE"/>, <see cref="Gl.BLUE_BIAS"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.ALPHA_BIAS"/>, <see 
		/// cref="Gl.DEPTH_SCALE"/>, or <see cref="Gl.DEPTH_BIAS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(int pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf(pname, param);
			CallLog("glPixelTransferf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: <see 
		/// cref="Gl.MAP_COLOR"/>, <see cref="Gl.MAP_STENCIL"/>, <see cref="Gl.INDEX_SHIFT"/>, <see cref="Gl.INDEX_OFFSET"/>, <see 
		/// cref="Gl.RED_SCALE"/>, <see cref="Gl.RED_BIAS"/>, <see cref="Gl.GREEN_SCALE"/>, <see cref="Gl.GREEN_BIAS"/>, <see 
		/// cref="Gl.BLUE_SCALE"/>, <see cref="Gl.BLUE_BIAS"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.ALPHA_BIAS"/>, <see 
		/// cref="Gl.DEPTH_SCALE"/>, or <see cref="Gl.DEPTH_BIAS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf((int)pname, param);
			CallLog("glPixelTransferf({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: <see 
		/// cref="Gl.MAP_COLOR"/>, <see cref="Gl.MAP_STENCIL"/>, <see cref="Gl.INDEX_SHIFT"/>, <see cref="Gl.INDEX_OFFSET"/>, <see 
		/// cref="Gl.RED_SCALE"/>, <see cref="Gl.RED_BIAS"/>, <see cref="Gl.GREEN_SCALE"/>, <see cref="Gl.GREEN_BIAS"/>, <see 
		/// cref="Gl.BLUE_SCALE"/>, <see cref="Gl.BLUE_BIAS"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.ALPHA_BIAS"/>, <see 
		/// cref="Gl.DEPTH_SCALE"/>, or <see cref="Gl.DEPTH_BIAS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi(pname, param);
			CallLog("glPixelTransferi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: <see 
		/// cref="Gl.MAP_COLOR"/>, <see cref="Gl.MAP_STENCIL"/>, <see cref="Gl.INDEX_SHIFT"/>, <see cref="Gl.INDEX_OFFSET"/>, <see 
		/// cref="Gl.RED_SCALE"/>, <see cref="Gl.RED_BIAS"/>, <see cref="Gl.GREEN_SCALE"/>, <see cref="Gl.GREEN_BIAS"/>, <see 
		/// cref="Gl.BLUE_SCALE"/>, <see cref="Gl.BLUE_BIAS"/>, <see cref="Gl.ALPHA_SCALE"/>, <see cref="Gl.ALPHA_BIAS"/>, <see 
		/// cref="Gl.DEPTH_SCALE"/>, or <see cref="Gl.DEPTH_BIAS"/>.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi((int)pname, param);
			CallLog("glPixelTransferi({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(int map, Int32 mapsize, float[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv(map, mapsize, p_values);
					CallLog("glPixelMapfv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, float[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((int)map, mapsize, p_values);
					CallLog("glPixelMapfv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(int map, Int32 mapsize, UInt32[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv(map, mapsize, p_values);
					CallLog("glPixelMapuiv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt32[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((int)map, mapsize, p_values);
					CallLog("glPixelMapuiv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(int map, Int32 mapsize, UInt16[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv(map, mapsize, p_values);
					CallLog("glPixelMapusv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, or <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt16[] values)
		{
			Debug.Assert(values.Length >= mapsize);

			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((int)map, mapsize, p_values);
					CallLog("glPixelMapusv({0}, {1}, {2})", map, mapsize, values);
				}
			}
			DebugCheckErrors();
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
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants <see 
		/// cref="Gl.COLOR"/>, <see cref="Gl.DEPTH"/>, and <see cref="Gl.STENCIL"/> are accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, type);
			CallLog("glCopyPixels({0}, {1}, {2}, {3}, {4})", x, y, width, height, type);
			DebugCheckErrors();
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
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants <see 
		/// cref="Gl.COLOR"/>, <see cref="Gl.DEPTH"/>, and <see cref="Gl.STENCIL"/> are accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, (int)type);
			CallLog("glCopyPixels({0}, {1}, {2}, {3}, {4})", x, y, width, height, type);
			DebugCheckErrors();
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
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, format, type, pixels);
			CallLog("glDrawPixels({0}, {1}, {2}, {3}, {4})", width, height, format, type, pixels);
			DebugCheckErrors();
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
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, (int)format, (int)type, pixels);
			CallLog("glDrawPixels({0}, {1}, {2}, {3}, {4})", width, height, format, type, pixels);
			DebugCheckErrors();
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
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, int format, int type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				DrawPixels(width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
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
		/// Specifies the format of the pixel data. Symbolic constants <see cref="Gl.COLOR_INDEX"/>, <see cref="Gl.STENCIL_INDEX"/>, 
		/// <see cref="Gl.DEPTH_COMPONENT"/>, <see cref="Gl.RGB"/>, <see cref="Gl.BGR"/>, <see cref="Gl.RGBA"/>, <see 
		/// cref="Gl.BGRA"/>, <see cref="Gl.RED"/>, <see cref="Gl.GREEN"/>, <see cref="Gl.BLUE"/>, <see cref="Gl.ALPHA"/>, <see 
		/// cref="Gl.LUMINANCE"/>, and <see cref="Gl.LUMINANCE_ALPHA"/> are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants <see cref="Gl.UNSIGNED_BYTE"/>, <see 
		/// cref="Gl.BYTE"/>, <see cref="Gl.BITMAP"/>, <see cref="Gl.UNSIGNED_SHORT"/>, <see cref="Gl.SHORT"/>, <see 
		/// cref="Gl.UNSIGNED_INT"/>, <see cref="Gl.INT"/>, <see cref="Gl.FLOAT"/>, <see cref="Gl.UNSIGNED_BYTE_3_3_2"/>, <see 
		/// cref="Gl.UNSIGNED_BYTE_2_3_3_REV"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5"/>, <see cref="Gl.UNSIGNED_SHORT_5_6_5_REV"/>, 
		/// <see cref="Gl.UNSIGNED_SHORT_4_4_4_4"/>, <see cref="Gl.UNSIGNED_SHORT_4_4_4_4_REV"/>, <see 
		/// cref="Gl.UNSIGNED_SHORT_5_5_5_1"/>, <see cref="Gl.UNSIGNED_SHORT_1_5_5_5_REV"/>, <see cref="Gl.UNSIGNED_INT_8_8_8_8"/>, 
		/// <see cref="Gl.UNSIGNED_INT_8_8_8_8_REV"/>, <see cref="Gl.UNSIGNED_INT_10_10_10_2"/>, and <see 
		/// cref="Gl.UNSIGNED_INT_2_10_10_10_REV"/> are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
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
		/// planes are supported. They are identified by symbolic names of the form <see cref="Gl.CLIP_PLANE"/>i where i ranges from 
		/// 0 to the value of <see cref="Gl.MAX_CLIP_PLANES"/> - 1.
		/// </param>
		/// <param name="equation">
		/// Returns four double-precision values that are the coefficients of the plane equation of <paramref name="plane"/> in eye 
		/// coordinates. The initial value is (0, 0, 0, 0).
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetClipPlane(int plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane(plane, p_equation);
					CallLog("glGetClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the coefficients of the specified clipping plane
		/// </summary>
		/// <param name="plane">
		/// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping 
		/// planes are supported. They are identified by symbolic names of the form <see cref="Gl.CLIP_PLANE"/>i where i ranges from 
		/// 0 to the value of <see cref="Gl.MAX_CLIP_PLANES"/> - 1.
		/// </param>
		/// <param name="equation">
		/// Returns four double-precision values that are the coefficients of the plane equation of <paramref name="plane"/> in eye 
		/// coordinates. The initial value is (0, 0, 0, 0).
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane((int)plane, p_equation);
					CallLog("glGetClipPlane({0}, {1})", plane, equation);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form <see cref="Gl.LIGHT"/>i where i ranges from 0 to the value 
		/// of <see cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are <see cref="Gl.AMBIENT"/>, 
		/// <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, <see cref="Gl.POSITION"/>, <see cref="Gl.SPOT_DIRECTION"/>, <see 
		/// cref="Gl.SPOT_EXPONENT"/>, <see cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see 
		/// cref="Gl.LINEAR_ATTENUATION"/>, and <see cref="Gl.QUADRATIC_ATTENUATION"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(int light, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv(light, pname, p_params);
					CallLog("glGetLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form <see cref="Gl.LIGHT"/>i where i ranges from 0 to the value 
		/// of <see cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are <see cref="Gl.AMBIENT"/>, 
		/// <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, <see cref="Gl.POSITION"/>, <see cref="Gl.SPOT_DIRECTION"/>, <see 
		/// cref="Gl.SPOT_EXPONENT"/>, <see cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see 
		/// cref="Gl.LINEAR_ATTENUATION"/>, and <see cref="Gl.QUADRATIC_ATTENUATION"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv((int)light, (int)pname, p_params);
					CallLog("glGetLightfv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form <see cref="Gl.LIGHT"/>i where i ranges from 0 to the value 
		/// of <see cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are <see cref="Gl.AMBIENT"/>, 
		/// <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, <see cref="Gl.POSITION"/>, <see cref="Gl.SPOT_DIRECTION"/>, <see 
		/// cref="Gl.SPOT_EXPONENT"/>, <see cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see 
		/// cref="Gl.LINEAR_ATTENUATION"/>, and <see cref="Gl.QUADRATIC_ATTENUATION"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(int light, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv(light, pname, p_params);
					CallLog("glGetLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form <see cref="Gl.LIGHT"/>i where i ranges from 0 to the value 
		/// of <see cref="Gl.MAX_LIGHTS"/> - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are <see cref="Gl.AMBIENT"/>, 
		/// <see cref="Gl.DIFFUSE"/>, <see cref="Gl.SPECULAR"/>, <see cref="Gl.POSITION"/>, <see cref="Gl.SPOT_DIRECTION"/>, <see 
		/// cref="Gl.SPOT_EXPONENT"/>, <see cref="Gl.SPOT_CUTOFF"/>, <see cref="Gl.CONSTANT_ATTENUATION"/>, <see 
		/// cref="Gl.LINEAR_ATTENUATION"/>, and <see cref="Gl.QUADRATIC_ATTENUATION"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv((int)light, (int)pname, p_params);
					CallLog("glGetLightiv({0}, {1}, {2})", light, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(int target, int query, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv(target, query, p_v);
					CallLog("glGetMapdv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv((int)target, (int)query, p_v);
					CallLog("glGetMapdv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(int target, int query, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv(target, query, p_v);
					CallLog("glGetMapfv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv((int)target, (int)query, p_v);
					CallLog("glGetMapfv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(int target, int query, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv(target, query, p_v);
					CallLog("glGetMapiv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are <see cref="Gl.MAP1_COLOR_4"/>, <see cref="Gl.MAP1_INDEX"/>, 
		/// <see cref="Gl.MAP1_NORMAL"/>, <see cref="Gl.MAP1_TEXTURE_COORD_1"/>, <see cref="Gl.MAP1_TEXTURE_COORD_2"/>, <see 
		/// cref="Gl.MAP1_TEXTURE_COORD_3"/>, <see cref="Gl.MAP1_TEXTURE_COORD_4"/>, <see cref="Gl.MAP1_VERTEX_3"/>, <see 
		/// cref="Gl.MAP1_VERTEX_4"/>, <see cref="Gl.MAP2_COLOR_4"/>, <see cref="Gl.MAP2_INDEX"/>, <see cref="Gl.MAP2_NORMAL"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_1"/>, <see cref="Gl.MAP2_TEXTURE_COORD_2"/>, <see cref="Gl.MAP2_TEXTURE_COORD_3"/>, 
		/// <see cref="Gl.MAP2_TEXTURE_COORD_4"/>, <see cref="Gl.MAP2_VERTEX_3"/>, and <see cref="Gl.MAP2_VERTEX_4"/>.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names <see cref="Gl.COEFF"/>, <see cref="Gl.ORDER"/>, and <see 
		/// cref="Gl.DOMAIN"/> are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv((int)target, (int)query, p_v);
					CallLog("glGetMapiv({0}, {1}, {2})", target, query, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. <see cref="Gl.FRONT"/> or <see cref="Gl.BACK"/> are accepted, 
		/// representing the front and back materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see 
		/// cref="Gl.SPECULAR"/>, <see cref="Gl.EMISSION"/>, <see cref="Gl.SHININESS"/>, and <see cref="Gl.COLOR_INDEXES"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(int face, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv(face, pname, p_params);
					CallLog("glGetMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. <see cref="Gl.FRONT"/> or <see cref="Gl.BACK"/> are accepted, 
		/// representing the front and back materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see 
		/// cref="Gl.SPECULAR"/>, <see cref="Gl.EMISSION"/>, <see cref="Gl.SHININESS"/>, and <see cref="Gl.COLOR_INDEXES"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv((int)face, (int)pname, p_params);
					CallLog("glGetMaterialfv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. <see cref="Gl.FRONT"/> or <see cref="Gl.BACK"/> are accepted, 
		/// representing the front and back materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see 
		/// cref="Gl.SPECULAR"/>, <see cref="Gl.EMISSION"/>, <see cref="Gl.SHININESS"/>, and <see cref="Gl.COLOR_INDEXES"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(int face, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv(face, pname, p_params);
					CallLog("glGetMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. <see cref="Gl.FRONT"/> or <see cref="Gl.BACK"/> are accepted, 
		/// representing the front and back materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. <see cref="Gl.AMBIENT"/>, <see cref="Gl.DIFFUSE"/>, <see 
		/// cref="Gl.SPECULAR"/>, <see cref="Gl.EMISSION"/>, <see cref="Gl.SHININESS"/>, and <see cref="Gl.COLOR_INDEXES"/> are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv((int)face, (int)pname, p_params);
					CallLog("glGetMaterialiv({0}, {1}, {2})", face, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(int map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv(map, p_values);
					CallLog("glGetPixelMapfv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv((int)map, p_values);
					CallLog("glGetPixelMapfv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(int map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv(map, p_values);
					CallLog("glGetPixelMapuiv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv((int)map, p_values);
					CallLog("glGetPixelMapuiv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(int map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv(map, p_values);
					CallLog("glGetPixelMapusv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are <see cref="Gl.PIXEL_MAP_I_TO_I"/>, <see 
		/// cref="Gl.PIXEL_MAP_S_TO_S"/>, <see cref="Gl.PIXEL_MAP_I_TO_R"/>, <see cref="Gl.PIXEL_MAP_I_TO_G"/>, <see 
		/// cref="Gl.PIXEL_MAP_I_TO_B"/>, <see cref="Gl.PIXEL_MAP_I_TO_A"/>, <see cref="Gl.PIXEL_MAP_R_TO_R"/>, <see 
		/// cref="Gl.PIXEL_MAP_G_TO_G"/>, <see cref="Gl.PIXEL_MAP_B_TO_B"/>, and <see cref="Gl.PIXEL_MAP_A_TO_A"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv((int)map, p_values);
					CallLog("glGetPixelMapusv({0}, {1})", map, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the polygon stipple pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglGetPolygonStipple != null, "pglGetPolygonStipple not implemented");
					Delegates.pglGetPolygonStipple(p_mask);
					CallLog("glGetPolygonStipple({0})", mask);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are <see cref="Gl.TEXTURE_ENV_MODE"/>, 
		/// <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv(target, pname, p_params);
					CallLog("glGetTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are <see cref="Gl.TEXTURE_ENV_MODE"/>, 
		/// <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv((int)target, (int)pname, p_params);
					CallLog("glGetTexEnvfv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are <see cref="Gl.TEXTURE_ENV_MODE"/>, 
		/// <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv(target, pname, p_params);
					CallLog("glGetTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be <see cref="Gl.TEXTURE_ENV"/>, <see cref="Gl.TEXTURE_FILTER_CONTROL"/>, or <see 
		/// cref="Gl.POINT_SPRITE"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are <see cref="Gl.TEXTURE_ENV_MODE"/>, 
		/// <see cref="Gl.TEXTURE_ENV_COLOR"/>, <see cref="Gl.TEXTURE_LOD_BIAS"/>, <see cref="Gl.COMBINE_RGB"/>, <see 
		/// cref="Gl.COMBINE_ALPHA"/>, <see cref="Gl.SRC0_RGB"/>, <see cref="Gl.SRC1_RGB"/>, <see cref="Gl.SRC2_RGB"/>, <see 
		/// cref="Gl.SRC0_ALPHA"/>, <see cref="Gl.SRC1_ALPHA"/>, <see cref="Gl.SRC2_ALPHA"/>, <see cref="Gl.OPERAND0_RGB"/>, <see 
		/// cref="Gl.OPERAND1_RGB"/>, <see cref="Gl.OPERAND2_RGB"/>, <see cref="Gl.OPERAND0_ALPHA"/>, <see 
		/// cref="Gl.OPERAND1_ALPHA"/>, <see cref="Gl.OPERAND2_ALPHA"/>, <see cref="Gl.RGB_SCALE"/>, <see cref="Gl.ALPHA_SCALE"/>, 
		/// or <see cref="Gl.COORD_REPLACE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv((int)target, (int)pname, p_params);
					CallLog("glGetTexEnviv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(int coord, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv(coord, pname, p_params);
					CallLog("glGetTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGendv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(int coord, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv(coord, pname, p_params);
					CallLog("glGetTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGenfv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(int coord, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv(coord, pname, p_params);
					CallLog("glGetTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be <see cref="Gl.S"/>, <see cref="Gl.T"/>, <see cref="Gl.R"/>, or <see 
		/// cref="Gl.Q"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either <see cref="Gl.TEXTURE_GEN_MODE"/> or the name 
		/// of one of the texture generation plane equations: <see cref="Gl.OBJECT_PLANE"/> or <see cref="Gl.EYE_PLANE"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv((int)coord, (int)pname, p_params);
					CallLog("glGetTexGeniv({0}, {1}, {2})", coord, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a display list
		/// </summary>
		/// <param name="list">
		/// Specifies a potential display list name.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static bool IsList(UInt32 list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsList != null, "pglIsList not implemented");
			retValue = Delegates.pglIsList(list);
			CallLog("glIsList({0}) = {1}", list, retValue);
			DebugCheckErrors();

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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglFrustum != null, "pglFrustum not implemented");
			Delegates.pglFrustum(left, right, bottom, top, zNear, zFar);
			CallLog("glFrustum({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the identity matrix
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadIdentity()
		{
			Debug.Assert(Delegates.pglLoadIdentity != null, "pglLoadIdentity not implemented");
			Delegates.pglLoadIdentity();
			CallLog("glLoadIdentity()");
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
					Delegates.pglLoadMatrixf(p_m);
					CallLog("glLoadMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
					Delegates.pglLoadMatrixd(p_m);
					CallLog("glLoadMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify which matrix is the current matrix
		/// </summary>
		/// <param name="mode">
		/// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: <see 
		/// cref="Gl.MODELVIEW"/>, <see cref="Gl.PROJECTION"/>, and <see cref="Gl.TEXTURE"/>. The initial value is <see 
		/// cref="Gl.MODELVIEW"/>. Additionally, if the ARB_imaging extension is supported, <see cref="Gl.COLOR"/> is also accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MatrixMode(int mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode(mode);
			CallLog("glMatrixMode({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify which matrix is the current matrix
		/// </summary>
		/// <param name="mode">
		/// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: <see 
		/// cref="Gl.MODELVIEW"/>, <see cref="Gl.PROJECTION"/>, and <see cref="Gl.TEXTURE"/>. The initial value is <see 
		/// cref="Gl.MODELVIEW"/>. Additionally, if the ARB_imaging extension is supported, <see cref="Gl.COLOR"/> is also accepted.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MatrixMode(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode((int)mode);
			CallLog("glMatrixMode({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
					Delegates.pglMultMatrixf(p_m);
					CallLog("glMultMatrixf({0})", m);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
					Delegates.pglMultMatrixd(p_m);
					CallLog("glMultMatrixd({0})", m);
				}
			}
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglOrtho != null, "pglOrtho not implemented");
			Delegates.pglOrtho(left, right, bottom, top, zNear, zFar);
			CallLog("glOrtho({0}, {1}, {2}, {3}, {4}, {5})", left, right, bottom, top, zNear, zFar);
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopMatrix()
		{
			Debug.Assert(Delegates.pglPopMatrix != null, "pglPopMatrix not implemented");
			Delegates.pglPopMatrix();
			CallLog("glPopMatrix()");
			DebugCheckErrors();
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushMatrix()
		{
			Debug.Assert(Delegates.pglPushMatrix != null, "pglPushMatrix not implemented");
			Delegates.pglPushMatrix();
			CallLog("glPushMatrix()");
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(double angle, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRotated != null, "pglRotated not implemented");
			Delegates.pglRotated(angle, x, y, z);
			CallLog("glRotated({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(float angle, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRotatef != null, "pglRotatef not implemented");
			Delegates.pglRotatef(angle, x, y, z);
			CallLog("glRotatef({0}, {1}, {2}, {3})", angle, x, y, z);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglScaled != null, "pglScaled not implemented");
			Delegates.pglScaled(x, y, z);
			CallLog("glScaled({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglScalef != null, "pglScalef not implemented");
			Delegates.pglScalef(x, y, z);
			CallLog("glScalef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglTranslated != null, "pglTranslated not implemented");
			Delegates.pglTranslated(x, y, z);
			CallLog("glTranslated({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
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
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTranslatef != null, "pglTranslatef not implemented");
			Delegates.pglTranslatef(x, y, z);
			CallLog("glTranslatef({0}, {1}, {2})", x, y, z);
			DebugCheckErrors();
		}

	}

}
