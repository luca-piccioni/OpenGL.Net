
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
		/// Gl.Get: data returns one value, the symbolic constant identifying the RGB destination blend function. The initial value 
		/// is Gl.ZERO. See Gl.BlendFunc and Gl.BlendFuncSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_DST_RGB_EXT")]
		[AliasOf("GL_BLEND_DST_RGB_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		[RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
		public const int BLEND_DST_RGB = 0x80C8;

		/// <summary>
		/// Gl.Get: data returns one value, the symbolic constant identifying the RGB source blend function. The initial value is 
		/// Gl.ONE. See Gl.BlendFunc and Gl.BlendFuncSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_SRC_RGB_EXT")]
		[AliasOf("GL_BLEND_SRC_RGB_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		[RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
		public const int BLEND_SRC_RGB = 0x80C9;

		/// <summary>
		/// Gl.Get: data returns one value, the symbolic constant identifying the alpha destination blend function. The initial 
		/// value is Gl.ZERO. See Gl.BlendFunc and Gl.BlendFuncSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_DST_ALPHA_EXT")]
		[AliasOf("GL_BLEND_DST_ALPHA_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		[RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
		public const int BLEND_DST_ALPHA = 0x80CA;

		/// <summary>
		/// Gl.Get: data returns one value, the symbolic constant identifying the alpha source blend function. The initial value is 
		/// Gl.ONE. See Gl.BlendFunc and Gl.BlendFuncSeparate.
		/// </summary>
		[AliasOf("GL_BLEND_SRC_ALPHA_EXT")]
		[AliasOf("GL_BLEND_SRC_ALPHA_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		[RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
		public const int BLEND_SRC_ALPHA = 0x80CB;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, the point size threshold for determining the point size. See Gl.PointParameter.
		/// </para>
		/// <para>
		/// Gl.PointParameter: params is a single floating-point value that specifies the threshold value to which point sizes are 
		/// clamped if they exceed the specified value. The default value is 1.0.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_EXT")]
		[AliasOf("GL_POINT_FADE_THRESHOLD_SIZE_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		public const int POINT_FADE_THRESHOLD_SIZE = 0x8128;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT16 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT16_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT16_OES")]
		[AliasOf("GL_DEPTH_COMPONENT16_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		public const int DEPTH_COMPONENT16 = 0x81A5;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT24 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT24_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT24_OES")]
		[AliasOf("GL_DEPTH_COMPONENT24_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_OES_depth24", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		public const int DEPTH_COMPONENT24 = 0x81A6;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_COMPONENT32_ARB")]
		[AliasOf("GL_DEPTH_COMPONENT32_OES")]
		[AliasOf("GL_DEPTH_COMPONENT32_SGIX")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth32", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		public const int DEPTH_COMPONENT32 = 0x81A7;

		/// <summary>
		/// Value of GL_MIRRORED_REPEAT symbol.
		/// </summary>
		[AliasOf("GL_MIRRORED_REPEAT_ARB")]
		[AliasOf("GL_MIRRORED_REPEAT_IBM")]
		[AliasOf("GL_MIRRORED_REPEAT_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_mirrored_repeat")]
		[RequiredByFeature("GL_IBM_texture_mirrored_repeat")]
		[RequiredByFeature("GL_OES_texture_mirrored_repeat", Api = "gles1")]
		public const int MIRRORED_REPEAT = 0x8370;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum, absolute value of the texture level-of-detail bias. The value must be at 
		/// least 2.0.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_LOD_BIAS_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
		public const int MAX_TEXTURE_LOD_BIAS = 0x84FD;

		/// <summary>
		/// Gl.GetTexEnv: params returns a single floating-point value that is the texture level-of-detail bias. The initial value 
		/// is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_LOD_BIAS_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
		public const int TEXTURE_LOD_BIAS = 0x8501;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: increments the current stencil buffer value. Wraps stencil buffer value to zero when incrementing the 
		/// maximum representable unsigned value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: increments the current stencil buffer value. Wraps stencil buffer value to zero when incrementing 
		/// the maximum representable unsigned value.
		/// </para>
		/// </summary>
		[AliasOf("GL_INCR_WRAP_EXT")]
		[AliasOf("GL_INCR_WRAP_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_stencil_wrap")]
		[RequiredByFeature("GL_OES_stencil_wrap", Api = "gles1")]
		public const int INCR_WRAP = 0x8507;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: decrements the current stencil buffer value. Wraps stencil buffer value to the maximum representable 
		/// unsigned value when decrementing a stencil buffer value of zero.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: decrements the current stencil buffer value. Wraps stencil buffer value to the maximum 
		/// representable unsigned value when decrementing a stencil buffer value of zero.
		/// </para>
		/// </summary>
		[AliasOf("GL_DECR_WRAP_EXT")]
		[AliasOf("GL_DECR_WRAP_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_stencil_wrap")]
		[RequiredByFeature("GL_OES_stencil_wrap", Api = "gles1")]
		public const int DECR_WRAP = 0x8508;

		/// <summary>
		/// Gl.GetTexLevelParameter: the internal storage resolution of an individual component. The resolution chosen by the GL 
		/// will be a close match for the resolution requested by the user with the component argument of Gl.TexImage1D, 
		/// Gl.TexImage2D, Gl.TexImage3D, Gl.CopyTexImage1D, and Gl.CopyTexImage2D. The initial value is 0.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_SIZE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		public const int TEXTURE_DEPTH_SIZE = 0x884A;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns a single-valued texture comparison mode, a symbolic constant. The initial value is 
		/// Gl.NONE. See Gl.SamplerParameter.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns a single-valued texture comparison mode, a symbolic constant. The initial value is Gl.NONE. 
		/// See Gl.TexParameter.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPARE_MODE_ARB")]
		[AliasOf("GL_TEXTURE_COMPARE_MODE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		public const int TEXTURE_COMPARE_MODE = 0x884C;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: returns a single-valued texture comparison function, a symbolic constant. The initial value is 
		/// Gl.LEQUAL. See Gl.SamplerParameter.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: returns a single-valued texture comparison function, a symbolic constant. The initial value is 
		/// Gl.LEQUAL. See Gl.TexParameter.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_COMPARE_FUNC_ARB")]
		[AliasOf("GL_TEXTURE_COMPARE_FUNC_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		public const int TEXTURE_COMPARE_FUNC = 0x884D;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, the lower bound for the attenuated point sizes. The initial value is 1.0. See 
		/// Gl.PointParameter.
		/// </para>
		/// <para>
		/// Gl.PointParameter: params is a single floating-point value that specifies the minimum point size. The default value is 
		/// 0.0.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_SIZE_MIN_ARB")]
		[AliasOf("GL_POINT_SIZE_MIN_EXT")]
		[AliasOf("GL_POINT_SIZE_MIN_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MIN = 0x8126;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, the upper bound for the attenuated point sizes. The initial value is 0.0. See 
		/// Gl.PointParameter.
		/// </para>
		/// <para>
		/// Gl.PointParameter: params is a single floating-point value that specifies the maximum point size. The default value is 
		/// 1.0.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_SIZE_MAX_ARB")]
		[AliasOf("GL_POINT_SIZE_MAX_EXT")]
		[AliasOf("GL_POINT_SIZE_MAX_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_SIZE_MAX = 0x8127;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns three values, the coefficients for computing the attenuation value for points. See 
		/// Gl.PointParameter.
		/// </para>
		/// <para>
		/// Gl.PointParameter: params is an array of three floating-point values that specify the coefficients used for scaling the 
		/// computed point size. The default values are 100.
		/// </para>
		/// </summary>
		[AliasOf("GL_POINT_DISTANCE_ATTENUATION_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int POINT_DISTANCE_ATTENUATION = 0x8129;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns a single boolean value indicating if automatic mipmap level updates are enabled. See 
		/// Gl.TexParameter.
		/// </para>
		/// <para>
		/// Gl.TexParameter: specifies a boolean value that indicates if all levels of a mipmap array should be automatically 
		/// updated when any modification to the base level mipmap is done. The initial value is Gl.FALSE.
		/// </para>
		/// </summary>
		[AliasOf("GL_GENERATE_MIPMAP_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP = 0x8191;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the mipmap generation filtering hint. The 
		/// initial value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: indicates the quality of filtering when generating mipmap images.
		/// </para>
		/// </summary>
		[AliasOf("GL_GENERATE_MIPMAP_HINT_SGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int GENERATE_MIPMAP_HINT = 0x8192;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_SOURCE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_SOURCE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_SOURCE = 0x8450;

		/// <summary>
		/// Value of GL_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE = 0x8451;

		/// <summary>
		/// Value of GL_FRAGMENT_DEPTH symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FRAGMENT_DEPTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RequiredByFeature("GL_EXT_light_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FRAGMENT_DEPTH = 0x8452;

		/// <summary>
		/// Value of GL_CURRENT_FOG_COORDINATE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CURRENT_FOG_COORDINATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_FOG_COORDINATE = 0x8453;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_TYPE = 0x8454;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_STRIDE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_STRIDE = 0x8455;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY_POINTER = 0x8456;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_FOG_COORDINATE_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int FOG_COORDINATE_ARRAY = 0x8457;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether primary and secondary color sum is enabled. See 
		/// Gl.SecondaryColor.
		/// </para>
		/// <para>
		/// Gl.Enable: if enabled and no fragment shader is active, add the secondary color value to the computed fragment color. 
		/// See Gl.SecondaryColor.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_SUM_ARB")]
		[AliasOf("GL_COLOR_SUM_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COLOR_SUM = 0x8458;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha values of the current secondary color. Integer 
		/// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most 
		/// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value 
		/// is (0, 0, 0, 0). See Gl.SecondaryColor.
		/// </summary>
		[AliasOf("GL_CURRENT_SECONDARY_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CURRENT_SECONDARY_COLOR = 0x8459;

		/// <summary>
		/// Gl.Get: params returns one value, the number of components per color in the secondary color array. The initial value is 
		/// 3. See Gl.SecondaryColorPointer.
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_SIZE = 0x845A;

		/// <summary>
		/// Gl.Get: params returns one value, the data type of each component in the secondary color array. The initial value is 
		/// Gl.FLOAT. See Gl.SecondaryColorPointer.
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_TYPE = 0x845B;

		/// <summary>
		/// Gl.Get: params returns one value, the byte offset between consecutive colors in the secondary color array. The initial 
		/// value is 0. See Gl.SecondaryColorPointer.
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_STRIDE = 0x845C;

		/// <summary>
		/// Value of GL_SECONDARY_COLOR_ARRAY_POINTER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_POINTER_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY_POINTER = 0x845D;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether the secondary color array is enabled. The initial value 
		/// is Gl.FALSE. See Gl.SecondaryColorPointer.
		/// </para>
		/// <para>
		/// Gl.EnableClientState: if enabled, the secondary color array is enabled for writing and used during rendering when 
		/// Gl.ArrayElement, Gl.DrawArrays, Gl.DrawElements, Gl.DrawRangeElementsGl.MultiDrawArrays, or Gl.MultiDrawElements is 
		/// called. See Gl.ColorPointer.
		/// </para>
		/// </summary>
		[AliasOf("GL_SECONDARY_COLOR_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SECONDARY_COLOR_ARRAY = 0x845E;

		/// <summary>
		/// Value of GL_TEXTURE_FILTER_CONTROL symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_FILTER_CONTROL_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_FILTER_CONTROL = 0x8500;

		/// <summary>
		/// <para>
		/// Gl.GetTexParameter: returns a single-valued texture format indicating how the depth values should be converted into 
		/// color components. The initial value is Gl.LUMINANCE. See Gl.TexParameter.
		/// </para>
		/// <para>
		/// Gl.TexParameter: specifies a single symbolic constant indicating how depth values should be treated during filtering and 
		/// texture application. Accepted values are Gl.LUMINANCE, Gl.INTENSITY, and Gl.ALPHA. The initial value is Gl.LUMINANCE.
		/// </para>
		/// </summary>
		[AliasOf("GL_DEPTH_TEXTURE_MODE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DEPTH_TEXTURE_MODE = 0x884B;

		/// <summary>
		/// Value of GL_COMPARE_R_TO_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_COMPARE_R_TO_TEXTURE_ARB")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPARE_R_TO_TEXTURE = 0x884E;

		/// <summary>
		/// Value of GL_FUNC_ADD symbol.
		/// </summary>
		[AliasOf("GL_FUNC_ADD_EXT")]
		[AliasOf("GL_FUNC_ADD_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		public const int FUNC_ADD = 0x8006;

		/// <summary>
		/// Value of GL_FUNC_SUBTRACT symbol.
		/// </summary>
		[AliasOf("GL_FUNC_SUBTRACT_EXT")]
		[AliasOf("GL_FUNC_SUBTRACT_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_subtract")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		public const int FUNC_SUBTRACT = 0x800A;

		/// <summary>
		/// Value of GL_FUNC_REVERSE_SUBTRACT symbol.
		/// </summary>
		[AliasOf("GL_FUNC_REVERSE_SUBTRACT_EXT")]
		[AliasOf("GL_FUNC_REVERSE_SUBTRACT_OES")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_subtract")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		public const int FUNC_REVERSE_SUBTRACT = 0x800B;

		/// <summary>
		/// Value of GL_MIN symbol.
		/// </summary>
		[AliasOf("GL_MIN_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		public const int MIN = 0x8007;

		/// <summary>
		/// Value of GL_MAX symbol.
		/// </summary>
		[AliasOf("GL_MAX_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		public const int MAX = 0x8008;

		/// <summary>
		/// Value of GL_CONSTANT_COLOR symbol.
		/// </summary>
		[AliasOf("GL_CONSTANT_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int CONSTANT_COLOR = 0x8001;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_COLOR symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_CONSTANT_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int ONE_MINUS_CONSTANT_COLOR = 0x8002;

		/// <summary>
		/// Value of GL_CONSTANT_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_CONSTANT_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int CONSTANT_ALPHA = 0x8003;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_ALPHA symbol.
		/// </summary>
		[AliasOf("GL_ONE_MINUS_CONSTANT_ALPHA_EXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int ONE_MINUS_CONSTANT_ALPHA = 0x8004;

		/// <summary>
		/// specify pixel arithmetic for RGB and alpha components separately
		/// </summary>
		/// <param name="sfactorRGB">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dfactorRGB">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sfactorAlpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dfactorAlpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="srcRGB"/> or <paramref name="dstRGB"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.BlendFuncSeparate is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[AliasOf("glBlendFuncSeparateEXT")]
		[AliasOf("glBlendFuncSeparateINGR")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		[RequiredByFeature("GL_INGR_blend_func_separate")]
		public static void BlendFuncSeparate(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparate != null, "pglBlendFuncSeparate not implemented");
			Delegates.pglBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			LogFunction("glBlendFuncSeparate({0}, {1}, {2}, {3})", LogEnumName(sfactorRGB), LogEnumName(dfactorRGB), LogEnumName(sfactorAlpha), LogEnumName(dfactorAlpha));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple sets of primitives from array data
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Points to an array of starting indices in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Points to an array of the number of indices to be rendered.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the first and count
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[AliasOf("glMultiDrawArraysEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
		public static void MultiDrawArrays(PrimitiveType mode, Int32[] first, Int32[] count, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_first = first)
				fixed (Int32* p_count = count)
				{
					Debug.Assert(Delegates.pglMultiDrawArrays != null, "pglMultiDrawArrays not implemented");
					Delegates.pglMultiDrawArrays((Int32)mode, p_first, p_count, drawcount);
					LogFunction("glMultiDrawArrays({0}, {1}, {2}, {3})", mode, LogValue(first), LogValue(count), drawcount);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// render multiple sets of primitives by specifying indices of array data elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Points to an array of the elements counts.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="drawcount">
		/// Specifies the size of the <paramref name="count"/> and <paramref name="indices"/> arrays.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="drawcount"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array or the element array and 
		/// the buffer object's data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		[AliasOf("glMultiDrawElementsEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_multi_draw_arrays", Api = "gl|gles1|gles2")]
		public static void MultiDrawElements(PrimitiveType mode, Int32[] count, DrawElementsType type, IntPtr[] indices, Int32 drawcount)
		{
			unsafe {
				fixed (Int32* p_count = count)
				fixed (IntPtr* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMultiDrawElements != null, "pglMultiDrawElements not implemented");
					Delegates.pglMultiDrawElements((Int32)mode, p_count, (Int32)type, p_indices, drawcount);
					LogFunction("glMultiDrawElements({0}, {1}, {2}, {3}, {4})", mode, LogValue(count), type, LogValue(indices), drawcount);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For Gl.PointParameterf and Gl.PointParameteri, specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the value specified for Gl.POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated If the value specified for Gl.POINT_SPRITE_COORD_ORIGIN is not Gl.LOWER_LEFT or 
		/// Gl.UPPER_LEFT.
		/// </exception>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPointParameterfARB")]
		[AliasOf("glPointParameterfEXT")]
		[AliasOf("glPointParameterfSGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		public static void PointParameter(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglPointParameterf != null, "pglPointParameterf not implemented");
			Delegates.pglPointParameterf(pname, param);
			LogFunction("glPointParameterf({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// For Gl.PointParameterfv and Gl.PointParameteriv, specifies a pointer to an array where the value or values to be 
		/// assigned to <paramref name="pname"/> are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the value specified for Gl.POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated If the value specified for Gl.POINT_SPRITE_COORD_ORIGIN is not Gl.LOWER_LEFT or 
		/// Gl.UPPER_LEFT.
		/// </exception>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPointParameterfvARB")]
		[AliasOf("glPointParameterfvEXT")]
		[AliasOf("glPointParameterfvSGIS")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		public static void PointParameter(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterfv != null, "pglPointParameterfv not implemented");
					Delegates.pglPointParameterfv(pname, p_params);
					LogFunction("glPointParameterfv({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="param">
		/// For Gl.PointParameterf and Gl.PointParameteri, specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the value specified for Gl.POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated If the value specified for Gl.POINT_SPRITE_COORD_ORIGIN is not Gl.LOWER_LEFT or 
		/// Gl.UPPER_LEFT.
		/// </exception>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPointParameteriNV")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_NV_point_sprite")]
		public static void PointParameter(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPointParameteri != null, "pglPointParameteri not implemented");
			Delegates.pglPointParameteri(pname, param);
			LogFunction("glPointParameteri({0}, {1})", LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify point parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued point parameter. Gl.POINT_FADE_THRESHOLD_SIZE, and Gl.POINT_SPRITE_COORD_ORIGIN are accepted.
		/// </param>
		/// <param name="params">
		/// For Gl.PointParameterfv and Gl.PointParameteriv, specifies a pointer to an array where the value or values to be 
		/// assigned to <paramref name="pname"/> are stored.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the value specified for Gl.POINT_FADE_THRESHOLD_SIZE is less than zero.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated If the value specified for Gl.POINT_SPRITE_COORD_ORIGIN is not Gl.LOWER_LEFT or 
		/// Gl.UPPER_LEFT.
		/// </exception>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPointParameterivNV")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_NV_point_sprite")]
		public static void PointParameter(Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameteriv != null, "pglPointParameteriv not implemented");
					Delegates.pglPointParameteriv(pname, p_params);
					LogFunction("glPointParameteriv({0}, {1})", LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glFogCoordfEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float coord)
		{
			Debug.Assert(Delegates.pglFogCoordf != null, "pglFogCoordf not implemented");
			Delegates.pglFogCoordf(coord);
			LogFunction("glFogCoordf({0})", coord);
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glFogCoordfvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(float[] coord)
		{
			unsafe {
				fixed (float* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoordfv != null, "pglFogCoordfv not implemented");
					Delegates.pglFogCoordfv(p_coord);
					LogFunction("glFogCoordfv({0})", LogValue(coord));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glFogCoorddEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double coord)
		{
			Debug.Assert(Delegates.pglFogCoordd != null, "pglFogCoordd not implemented");
			Delegates.pglFogCoordd(coord);
			LogFunction("glFogCoordd({0})", coord);
		}

		/// <summary>
		/// set the current fog coordinates
		/// </summary>
		/// <param name="coord">
		/// Specify the fog distance.
		/// </param>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glFogCoorddvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoord(double[] coord)
		{
			unsafe {
				fixed (double* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoorddv != null, "pglFogCoorddv not implemented");
					Delegates.pglFogCoorddv(p_coord);
					LogFunction("glFogCoorddv({0})", LogValue(coord));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants Gl.FLOAT, or Gl.DOUBLE are accepted. The initial 
		/// value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not either Gl.FLOAT or Gl.DOUBLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[AliasOf("glFogCoordPointerEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFogCoordPointer != null, "pglFogCoordPointer not implemented");
			Delegates.pglFogCoordPointer((Int32)type, stride, pointer);
			LogFunction("glFogCoordPointer({0}, {1}, 0x{2})", type, stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of fog coordinates
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each fog coordinate. Symbolic constants Gl.FLOAT, or Gl.DOUBLE are accepted. The initial 
		/// value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive fog coordinates. If <paramref name="stride"/> is 0, the array elements are 
		/// understood to be tightly packed. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first coordinate of the first fog coordinate in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not either Gl.FLOAT or Gl.DOUBLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColorPointer"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[AliasOf("glFogCoordPointerEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FogCoordPointer(FogPointerTypeEXT type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointer(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3bEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3b != null, "pglSecondaryColor3b not implemented");
			Delegates.pglSecondaryColor3b(red, green, blue);
			LogFunction("glSecondaryColor3b({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3bvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3bv != null, "pglSecondaryColor3bv not implemented");
					Delegates.pglSecondaryColor3bv(p_v);
					LogFunction("glSecondaryColor3bv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3dEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3d != null, "pglSecondaryColor3d not implemented");
			Delegates.pglSecondaryColor3d(red, green, blue);
			LogFunction("glSecondaryColor3d({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3dvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3dv != null, "pglSecondaryColor3dv not implemented");
					Delegates.pglSecondaryColor3dv(p_v);
					LogFunction("glSecondaryColor3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3fEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3f != null, "pglSecondaryColor3f not implemented");
			Delegates.pglSecondaryColor3f(red, green, blue);
			LogFunction("glSecondaryColor3f({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3fvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3fv != null, "pglSecondaryColor3fv not implemented");
					Delegates.pglSecondaryColor3fv(p_v);
					LogFunction("glSecondaryColor3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3iEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3i != null, "pglSecondaryColor3i not implemented");
			Delegates.pglSecondaryColor3i(red, green, blue);
			LogFunction("glSecondaryColor3i({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3ivEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3iv != null, "pglSecondaryColor3iv not implemented");
					Delegates.pglSecondaryColor3iv(p_v);
					LogFunction("glSecondaryColor3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3sEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3s != null, "pglSecondaryColor3s not implemented");
			Delegates.pglSecondaryColor3s(red, green, blue);
			LogFunction("glSecondaryColor3s({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3svEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3sv != null, "pglSecondaryColor3sv not implemented");
					Delegates.pglSecondaryColor3sv(p_v);
					LogFunction("glSecondaryColor3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3ubEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3ub != null, "pglSecondaryColor3ub not implemented");
			Delegates.pglSecondaryColor3ub(red, green, blue);
			LogFunction("glSecondaryColor3ub({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3ubvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3ubv != null, "pglSecondaryColor3ubv not implemented");
					Delegates.pglSecondaryColor3ubv(p_v);
					LogFunction("glSecondaryColor3ubv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3uiEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3ui != null, "pglSecondaryColor3ui not implemented");
			Delegates.pglSecondaryColor3ui(red, green, blue);
			LogFunction("glSecondaryColor3ui({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3uivEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3uiv != null, "pglSecondaryColor3uiv not implemented");
					Delegates.pglSecondaryColor3uiv(p_v);
					LogFunction("glSecondaryColor3uiv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current secondary color.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3usEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglSecondaryColor3us != null, "pglSecondaryColor3us not implemented");
			Delegates.pglSecondaryColor3us(red, green, blue);
			LogFunction("glSecondaryColor3us({0}, {1}, {2})", red, green, blue);
		}

		/// <summary>
		/// set the current secondary color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.LightModel"/>
		[AliasOf("glSecondaryColor3usvEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColor3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglSecondaryColor3usv != null, "pglSecondaryColor3usv not implemented");
					Delegates.pglSecondaryColor3usv(p_v);
					LogFunction("glSecondaryColor3usv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, or Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[AliasOf("glSecondaryColorPointerEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglSecondaryColorPointer != null, "pglSecondaryColorPointer not implemented");
			Delegates.pglSecondaryColorPointer(size, (Int32)type, stride, pointer);
			LogFunction("glSecondaryColorPointer({0}, {1}, {2}, 0x{3})", size, type, stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of secondary colors
		/// </summary>
		/// <param name="size">
		/// Specifies the number of components per color. Must be 3.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each color component in the array. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, or Gl.DOUBLE are accepted. The initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive colors. If <paramref name="stride"/> is 0, the colors are understood to be 
		/// tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 3.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EdgeFlagPointer"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.FogCoordPointer"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.InterleavedArrays"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PopClientAttrib"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[AliasOf("glSecondaryColorPointerEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_secondary_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SecondaryColorPointer(Int32 size, ColorPointerType type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				SecondaryColorPointer(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2dARB")]
		[AliasOf("glWindowPos2dMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglWindowPos2d != null, "pglWindowPos2d not implemented");
			Delegates.pglWindowPos2d(x, y);
			LogFunction("glWindowPos2d({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2dvARB")]
		[AliasOf("glWindowPos2dvMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2dv != null, "pglWindowPos2dv not implemented");
					Delegates.pglWindowPos2dv(p_v);
					LogFunction("glWindowPos2dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2fARB")]
		[AliasOf("glWindowPos2fMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglWindowPos2f != null, "pglWindowPos2f not implemented");
			Delegates.pglWindowPos2f(x, y);
			LogFunction("glWindowPos2f({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2fvARB")]
		[AliasOf("glWindowPos2fvMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2fv != null, "pglWindowPos2fv not implemented");
					Delegates.pglWindowPos2fv(p_v);
					LogFunction("glWindowPos2fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2iARB")]
		[AliasOf("glWindowPos2iMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglWindowPos2i != null, "pglWindowPos2i not implemented");
			Delegates.pglWindowPos2i(x, y);
			LogFunction("glWindowPos2i({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2ivARB")]
		[AliasOf("glWindowPos2ivMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2iv != null, "pglWindowPos2iv not implemented");
					Delegates.pglWindowPos2iv(p_v);
					LogFunction("glWindowPos2iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2sARB")]
		[AliasOf("glWindowPos2sMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglWindowPos2s != null, "pglWindowPos2s not implemented");
			Delegates.pglWindowPos2s(x, y);
			LogFunction("glWindowPos2s({0}, {1})", x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos2svARB")]
		[AliasOf("glWindowPos2svMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos2sv != null, "pglWindowPos2sv not implemented");
					Delegates.pglWindowPos2sv(p_v);
					LogFunction("glWindowPos2sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3dARB")]
		[AliasOf("glWindowPos3dMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglWindowPos3d != null, "pglWindowPos3d not implemented");
			Delegates.pglWindowPos3d(x, y, z);
			LogFunction("glWindowPos3d({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3dvARB")]
		[AliasOf("glWindowPos3dvMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3dv != null, "pglWindowPos3dv not implemented");
					Delegates.pglWindowPos3dv(p_v);
					LogFunction("glWindowPos3dv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3fARB")]
		[AliasOf("glWindowPos3fMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglWindowPos3f != null, "pglWindowPos3f not implemented");
			Delegates.pglWindowPos3f(x, y, z);
			LogFunction("glWindowPos3f({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3fvARB")]
		[AliasOf("glWindowPos3fvMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3fv != null, "pglWindowPos3fv not implemented");
					Delegates.pglWindowPos3fv(p_v);
					LogFunction("glWindowPos3fv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3iARB")]
		[AliasOf("glWindowPos3iMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglWindowPos3i != null, "pglWindowPos3i not implemented");
			Delegates.pglWindowPos3i(x, y, z);
			LogFunction("glWindowPos3i({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3ivARB")]
		[AliasOf("glWindowPos3ivMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3iv != null, "pglWindowPos3iv not implemented");
					Delegates.pglWindowPos3iv(p_v);
					LogFunction("glWindowPos3iv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z coordinates for the raster position.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3sARB")]
		[AliasOf("glWindowPos3sMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglWindowPos3s != null, "pglWindowPos3s not implemented");
			Delegates.pglWindowPos3s(x, y, z);
			LogFunction("glWindowPos3s({0}, {1}, {2})", x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position in window coordinates for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.WindowPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		[AliasOf("glWindowPos3svARB")]
		[AliasOf("glWindowPos3svMESA")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_window_pos")]
		[RequiredByFeature("GL_MESA_window_pos")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void WindowPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglWindowPos3sv != null, "pglWindowPos3sv not implemented");
					Delegates.pglWindowPos3sv(p_v);
					LogFunction("glWindowPos3sv({0})", LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the blend color
		/// </summary>
		/// <param name="red">
		/// specify the components of Gl.BLEND_COLOR
		/// </param>
		/// <param name="green">
		/// specify the components of Gl.BLEND_COLOR
		/// </param>
		/// <param name="blue">
		/// specify the components of Gl.BLEND_COLOR
		/// </param>
		/// <param name="alpha">
		/// specify the components of Gl.BLEND_COLOR
		/// </param>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glBlendColorEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_color")]
		public static void BlendColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglBlendColor != null, "pglBlendColor not implemented");
			Delegates.pglBlendColor(red, green, blue, alpha);
			LogFunction("glBlendColor({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the equation used for both the RGB blend equation and the Alpha blend equation
		/// </summary>
		/// <param name="mode">
		/// specifies how source and destination colors are combined. It must be Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, 
		/// Gl.FUNC_REVERSE_SUBTRACT, Gl.MIN, Gl.MAX.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.FUNC_ADD, Gl.FUNC_SUBTRACT, 
		/// Gl.FUNC_REVERSE_SUBTRACT, Gl.MAX, or Gl.MIN.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.BlendEquation is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		[AliasOf("glBlendEquationEXT")]
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		public static void BlendEquation(Int32 mode)
		{
			Debug.Assert(Delegates.pglBlendEquation != null, "pglBlendEquation not implemented");
			Delegates.pglBlendEquation(mode);
			LogFunction("glBlendEquation({0})", LogEnumName(mode));
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparate(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawArrays(Int32 mode, Int32* first, Int32* count, Int32 drawcount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
			internal extern static unsafe void glMultiDrawElements(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
			internal extern static void glPointParameterf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameterfv(Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
			internal extern static void glPointParameteri(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glPointParameteriv(Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
			internal extern static void glFogCoordf(float coord);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordfv(float* coord);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
			internal extern static void glFogCoordd(double coord);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
			internal extern static unsafe void glFogCoorddv(double* coord);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
			internal extern static unsafe void glFogCoordPointer(Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
			internal extern static void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
			internal extern static void glSecondaryColor3d(double red, double green, double blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
			internal extern static void glSecondaryColor3f(float red, float green, float blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
			internal extern static void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
			internal extern static void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
			internal extern static void glSecondaryColor3ub(byte red, byte green, byte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3ubv(byte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
			internal extern static void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3uiv(UInt32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
			internal extern static void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColor3usv(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
			internal extern static unsafe void glSecondaryColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
			internal extern static void glWindowPos2d(double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
			internal extern static void glWindowPos2f(float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
			internal extern static void glWindowPos2i(Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
			internal extern static void glWindowPos2s(Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
			internal extern static void glWindowPos3d(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
			internal extern static void glWindowPos3f(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
			internal extern static void glWindowPos3i(Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
			internal extern static void glWindowPos3s(Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
			internal extern static unsafe void glWindowPos3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
			internal extern static void glBlendColor(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
			internal extern static void glBlendEquation(Int32 mode);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparate(Int32 sfactorRGB, Int32 dfactorRGB, Int32 sfactorAlpha, Int32 dfactorAlpha);

			[AliasOf("glBlendFuncSeparate")]
			[AliasOf("glBlendFuncSeparateEXT")]
			[AliasOf("glBlendFuncSeparateINGR")]
			[ThreadStatic]
			internal static glBlendFuncSeparate pglBlendFuncSeparate;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawArrays(Int32 mode, Int32* first, Int32* count, Int32 drawcount);

			[AliasOf("glMultiDrawArrays")]
			[AliasOf("glMultiDrawArraysEXT")]
			[ThreadStatic]
			internal static glMultiDrawArrays pglMultiDrawArrays;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultiDrawElements(Int32 mode, Int32* count, Int32 type, IntPtr* indices, Int32 drawcount);

			[AliasOf("glMultiDrawElements")]
			[AliasOf("glMultiDrawElementsEXT")]
			[ThreadStatic]
			internal static glMultiDrawElements pglMultiDrawElements;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameterf(Int32 pname, float param);

			[AliasOf("glPointParameterf")]
			[AliasOf("glPointParameterfARB")]
			[AliasOf("glPointParameterfEXT")]
			[AliasOf("glPointParameterfSGIS")]
			[ThreadStatic]
			internal static glPointParameterf pglPointParameterf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameterfv(Int32 pname, float* @params);

			[AliasOf("glPointParameterfv")]
			[AliasOf("glPointParameterfvARB")]
			[AliasOf("glPointParameterfvEXT")]
			[AliasOf("glPointParameterfvSGIS")]
			[ThreadStatic]
			internal static glPointParameterfv pglPointParameterfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointParameteri(Int32 pname, Int32 param);

			[AliasOf("glPointParameteri")]
			[AliasOf("glPointParameteriNV")]
			[ThreadStatic]
			internal static glPointParameteri pglPointParameteri;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointParameteriv(Int32 pname, Int32* @params);

			[AliasOf("glPointParameteriv")]
			[AliasOf("glPointParameterivNV")]
			[ThreadStatic]
			internal static glPointParameteriv pglPointParameteriv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordf(float coord);

			[AliasOf("glFogCoordf")]
			[AliasOf("glFogCoordfEXT")]
			[ThreadStatic]
			internal static glFogCoordf pglFogCoordf;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordfv(float* coord);

			[AliasOf("glFogCoordfv")]
			[AliasOf("glFogCoordfvEXT")]
			[ThreadStatic]
			internal static glFogCoordfv pglFogCoordfv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogCoordd(double coord);

			[AliasOf("glFogCoordd")]
			[AliasOf("glFogCoorddEXT")]
			[ThreadStatic]
			internal static glFogCoordd pglFogCoordd;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoorddv(double* coord);

			[AliasOf("glFogCoorddv")]
			[AliasOf("glFogCoorddvEXT")]
			[ThreadStatic]
			internal static glFogCoorddv pglFogCoorddv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogCoordPointer(Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glFogCoordPointer")]
			[AliasOf("glFogCoordPointerEXT")]
			[ThreadStatic]
			internal static glFogCoordPointer pglFogCoordPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3b(sbyte red, sbyte green, sbyte blue);

			[AliasOf("glSecondaryColor3b")]
			[AliasOf("glSecondaryColor3bEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3b pglSecondaryColor3b;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3bv(sbyte* v);

			[AliasOf("glSecondaryColor3bv")]
			[AliasOf("glSecondaryColor3bvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3bv pglSecondaryColor3bv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3d(double red, double green, double blue);

			[AliasOf("glSecondaryColor3d")]
			[AliasOf("glSecondaryColor3dEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3d pglSecondaryColor3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3dv(double* v);

			[AliasOf("glSecondaryColor3dv")]
			[AliasOf("glSecondaryColor3dvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3dv pglSecondaryColor3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3f(float red, float green, float blue);

			[AliasOf("glSecondaryColor3f")]
			[AliasOf("glSecondaryColor3fEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3f pglSecondaryColor3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3fv(float* v);

			[AliasOf("glSecondaryColor3fv")]
			[AliasOf("glSecondaryColor3fvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3fv pglSecondaryColor3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3i(Int32 red, Int32 green, Int32 blue);

			[AliasOf("glSecondaryColor3i")]
			[AliasOf("glSecondaryColor3iEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3i pglSecondaryColor3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3iv(Int32* v);

			[AliasOf("glSecondaryColor3iv")]
			[AliasOf("glSecondaryColor3ivEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3iv pglSecondaryColor3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3s(Int16 red, Int16 green, Int16 blue);

			[AliasOf("glSecondaryColor3s")]
			[AliasOf("glSecondaryColor3sEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3s pglSecondaryColor3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3sv(Int16* v);

			[AliasOf("glSecondaryColor3sv")]
			[AliasOf("glSecondaryColor3svEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3sv pglSecondaryColor3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3ub(byte red, byte green, byte blue);

			[AliasOf("glSecondaryColor3ub")]
			[AliasOf("glSecondaryColor3ubEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ub pglSecondaryColor3ub;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3ubv(byte* v);

			[AliasOf("glSecondaryColor3ubv")]
			[AliasOf("glSecondaryColor3ubvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ubv pglSecondaryColor3ubv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[AliasOf("glSecondaryColor3ui")]
			[AliasOf("glSecondaryColor3uiEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3ui pglSecondaryColor3ui;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3uiv(UInt32* v);

			[AliasOf("glSecondaryColor3uiv")]
			[AliasOf("glSecondaryColor3uivEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3uiv pglSecondaryColor3uiv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[AliasOf("glSecondaryColor3us")]
			[AliasOf("glSecondaryColor3usEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3us pglSecondaryColor3us;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColor3usv(UInt16* v);

			[AliasOf("glSecondaryColor3usv")]
			[AliasOf("glSecondaryColor3usvEXT")]
			[ThreadStatic]
			internal static glSecondaryColor3usv pglSecondaryColor3usv;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSecondaryColorPointer(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[AliasOf("glSecondaryColorPointer")]
			[AliasOf("glSecondaryColorPointerEXT")]
			[ThreadStatic]
			internal static glSecondaryColorPointer pglSecondaryColorPointer;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2d(double x, double y);

			[AliasOf("glWindowPos2d")]
			[AliasOf("glWindowPos2dARB")]
			[AliasOf("glWindowPos2dMESA")]
			[ThreadStatic]
			internal static glWindowPos2d pglWindowPos2d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2dv(double* v);

			[AliasOf("glWindowPos2dv")]
			[AliasOf("glWindowPos2dvARB")]
			[AliasOf("glWindowPos2dvMESA")]
			[ThreadStatic]
			internal static glWindowPos2dv pglWindowPos2dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2f(float x, float y);

			[AliasOf("glWindowPos2f")]
			[AliasOf("glWindowPos2fARB")]
			[AliasOf("glWindowPos2fMESA")]
			[ThreadStatic]
			internal static glWindowPos2f pglWindowPos2f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2fv(float* v);

			[AliasOf("glWindowPos2fv")]
			[AliasOf("glWindowPos2fvARB")]
			[AliasOf("glWindowPos2fvMESA")]
			[ThreadStatic]
			internal static glWindowPos2fv pglWindowPos2fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2i(Int32 x, Int32 y);

			[AliasOf("glWindowPos2i")]
			[AliasOf("glWindowPos2iARB")]
			[AliasOf("glWindowPos2iMESA")]
			[ThreadStatic]
			internal static glWindowPos2i pglWindowPos2i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2iv(Int32* v);

			[AliasOf("glWindowPos2iv")]
			[AliasOf("glWindowPos2ivARB")]
			[AliasOf("glWindowPos2ivMESA")]
			[ThreadStatic]
			internal static glWindowPos2iv pglWindowPos2iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos2s(Int16 x, Int16 y);

			[AliasOf("glWindowPos2s")]
			[AliasOf("glWindowPos2sARB")]
			[AliasOf("glWindowPos2sMESA")]
			[ThreadStatic]
			internal static glWindowPos2s pglWindowPos2s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos2sv(Int16* v);

			[AliasOf("glWindowPos2sv")]
			[AliasOf("glWindowPos2svARB")]
			[AliasOf("glWindowPos2svMESA")]
			[ThreadStatic]
			internal static glWindowPos2sv pglWindowPos2sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3d(double x, double y, double z);

			[AliasOf("glWindowPos3d")]
			[AliasOf("glWindowPos3dARB")]
			[AliasOf("glWindowPos3dMESA")]
			[ThreadStatic]
			internal static glWindowPos3d pglWindowPos3d;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3dv(double* v);

			[AliasOf("glWindowPos3dv")]
			[AliasOf("glWindowPos3dvARB")]
			[AliasOf("glWindowPos3dvMESA")]
			[ThreadStatic]
			internal static glWindowPos3dv pglWindowPos3dv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3f(float x, float y, float z);

			[AliasOf("glWindowPos3f")]
			[AliasOf("glWindowPos3fARB")]
			[AliasOf("glWindowPos3fMESA")]
			[ThreadStatic]
			internal static glWindowPos3f pglWindowPos3f;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3fv(float* v);

			[AliasOf("glWindowPos3fv")]
			[AliasOf("glWindowPos3fvARB")]
			[AliasOf("glWindowPos3fvMESA")]
			[ThreadStatic]
			internal static glWindowPos3fv pglWindowPos3fv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3i(Int32 x, Int32 y, Int32 z);

			[AliasOf("glWindowPos3i")]
			[AliasOf("glWindowPos3iARB")]
			[AliasOf("glWindowPos3iMESA")]
			[ThreadStatic]
			internal static glWindowPos3i pglWindowPos3i;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3iv(Int32* v);

			[AliasOf("glWindowPos3iv")]
			[AliasOf("glWindowPos3ivARB")]
			[AliasOf("glWindowPos3ivMESA")]
			[ThreadStatic]
			internal static glWindowPos3iv pglWindowPos3iv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glWindowPos3s(Int16 x, Int16 y, Int16 z);

			[AliasOf("glWindowPos3s")]
			[AliasOf("glWindowPos3sARB")]
			[AliasOf("glWindowPos3sMESA")]
			[ThreadStatic]
			internal static glWindowPos3s pglWindowPos3s;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWindowPos3sv(Int16* v);

			[AliasOf("glWindowPos3sv")]
			[AliasOf("glWindowPos3svARB")]
			[AliasOf("glWindowPos3svMESA")]
			[ThreadStatic]
			internal static glWindowPos3sv pglWindowPos3sv;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendColor(float red, float green, float blue, float alpha);

			[AliasOf("glBlendColor")]
			[AliasOf("glBlendColorEXT")]
			[ThreadStatic]
			internal static glBlendColor pglBlendColor;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquation(Int32 mode);

			[AliasOf("glBlendEquation")]
			[AliasOf("glBlendEquationEXT")]
			[ThreadStatic]
			internal static glBlendEquation pglBlendEquation;

		}
	}

}
