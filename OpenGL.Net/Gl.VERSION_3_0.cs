
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
		/// Value of GL_COMPARE_REF_TO_TEXTURE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to COMPARE_R_TO_TEXTURE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int COMPARE_REF_TO_TEXTURE = 0x884E;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE0 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE0.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE0 = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE1 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE1.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE1 = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE2 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE2.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE2 = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE3 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE3.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE3 = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE4 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE4.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE4 = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE5 symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to CLIP_PLANE5.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE5 = 0x3005;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE6 = 0x3006;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE7 = 0x3007;

		/// <summary>
		/// Value of GL_MAX_CLIP_DISTANCES symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to MAX_CLIP_PLANES.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_CLIP_DISTANCES = 0x0D32;

		/// <summary>
		/// Value of GL_MAJOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAJOR_VERSION = 0x821B;

		/// <summary>
		/// Value of GL_MINOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MINOR_VERSION = 0x821C;

		/// <summary>
		/// Value of GL_NUM_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int NUM_EXTENSIONS = 0x821D;

		/// <summary>
		/// Value of GL_CONTEXT_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CONTEXT_FLAGS = 0x821E;

		/// <summary>
		/// Value of GL_COMPRESSED_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RED = 0x8225;

		/// <summary>
		/// Value of GL_COMPRESSED_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RG = 0x8226;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_RGBA32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA32F = 0x8814;

		/// <summary>
		/// Value of GL_RGB32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		public const int RGB32F = 0x8815;

		/// <summary>
		/// Value of GL_RGBA16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA16F = 0x881A;

		/// <summary>
		/// Value of GL_RGB16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB16F = 0x881B;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

		/// <summary>
		/// Value of GL_MAX_ARRAY_TEXTURE_LAYERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXEL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MIN_PROGRAM_TEXEL_OFFSET = 0x8904;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXEL_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

		/// <summary>
		/// Value of GL_CLAMP_READ_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLAMP_READ_COLOR = 0x891C;

		/// <summary>
		/// Value of GL_FIXED_ONLY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int FIXED_ONLY = 0x891D;

		/// <summary>
		/// Value of GL_MAX_VARYING_COMPONENTS symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to MAX_VARYING_FLOATS.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_VARYING_COMPONENTS = 0x8B4B;

		/// <summary>
		/// Value of GL_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_1D_ARRAY = 0x8C18;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;

		/// <summary>
		/// Value of GL_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_2D_ARRAY = 0x8C1A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

		/// <summary>
		/// Value of GL_R11F_G11F_B10F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int R11F_G11F_B10F = 0x8C3A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10F_11F_11F_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_type_10f_11f_11f_rev")]
		public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

		/// <summary>
		/// Value of GL_RGB9_E5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB9_E5 = 0x8C3D;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_5_9_9_9_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

		/// <summary>
		/// Value of GL_TEXTURE_SHARED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_SHARED_SIZE = 0x8C3F;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_MODE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PRIMITIVES_GENERATED = 0x8C87;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

		/// <summary>
		/// Value of GL_RASTERIZER_DISCARD symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RASTERIZER_DISCARD = 0x8C89;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;

		/// <summary>
		/// Value of GL_INTERLEAVED_ATTRIBS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int INTERLEAVED_ATTRIBS = 0x8C8C;

		/// <summary>
		/// Value of GL_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SEPARATE_ATTRIBS = 0x8C8D;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_enhanced_layouts")]
		public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

		/// <summary>
		/// Value of GL_RGBA32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA32UI = 0x8D70;

		/// <summary>
		/// Value of GL_RGB32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		public const int RGB32UI = 0x8D71;

		/// <summary>
		/// Value of GL_RGBA16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA16UI = 0x8D76;

		/// <summary>
		/// Value of GL_RGB16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB16UI = 0x8D77;

		/// <summary>
		/// Value of GL_RGBA8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int RGBA8UI = 0x8D7C;

		/// <summary>
		/// Value of GL_RGB8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB8UI = 0x8D7D;

		/// <summary>
		/// Value of GL_RGBA32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA32I = 0x8D82;

		/// <summary>
		/// Value of GL_RGB32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int RGB32I = 0x8D83;

		/// <summary>
		/// Value of GL_RGBA16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA16I = 0x8D88;

		/// <summary>
		/// Value of GL_RGB16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB16I = 0x8D89;

		/// <summary>
		/// Value of GL_RGBA8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA8I = 0x8D8E;

		/// <summary>
		/// Value of GL_RGB8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB8I = 0x8D8F;

		/// <summary>
		/// Value of GL_RED_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RED_INTEGER = 0x8D94;

		/// <summary>
		/// Value of GL_GREEN_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int GREEN_INTEGER = 0x8D95;

		/// <summary>
		/// Value of GL_BLUE_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BLUE_INTEGER = 0x8D96;

		/// <summary>
		/// Value of GL_RGB_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGB_INTEGER = 0x8D98;

		/// <summary>
		/// Value of GL_RGBA_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int RGBA_INTEGER = 0x8D99;

		/// <summary>
		/// Value of GL_BGR_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BGR_INTEGER = 0x8D9A;

		/// <summary>
		/// Value of GL_BGRA_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BGRA_INTEGER = 0x8D9B;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_1D_ARRAY = 0x8DC0;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SAMPLER_2D_ARRAY = 0x8DC1;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int SAMPLER_CUBE_SHADOW = 0x8DC5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC2 = 0x8DC6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC3 = 0x8DC7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC4 = 0x8DC8;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_1D = 0x8DC9;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int INT_SAMPLER_2D = 0x8DCA;

		/// <summary>
		/// Value of GL_INT_SAMPLER_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int INT_SAMPLER_3D = 0x8DCB;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int INT_SAMPLER_CUBE = 0x8DCC;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_1D_ARRAY = 0x8DCE;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int INT_SAMPLER_2D_ARRAY = 0x8DCF;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_1D = 0x8DD1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_2D = 0x8DD2;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_3D symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_3D = 0x8DD3;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

		/// <summary>
		/// Value of GL_QUERY_WAIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_WAIT = 0x8E13;

		/// <summary>
		/// Value of GL_QUERY_NO_WAIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_NO_WAIT = 0x8E14;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_WAIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_BY_REGION_WAIT = 0x8E15;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_NO_WAIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_BY_REGION_NO_WAIT = 0x8E16;

		/// <summary>
		/// Value of GL_BUFFER_ACCESS_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int BUFFER_ACCESS_FLAGS = 0x911F;

		/// <summary>
		/// Value of GL_BUFFER_MAP_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int BUFFER_MAP_LENGTH = 0x9120;

		/// <summary>
		/// Value of GL_BUFFER_MAP_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		public const int BUFFER_MAP_OFFSET = 0x9121;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int DEPTH_COMPONENT32F = 0x8CAC;

		/// <summary>
		/// Value of GL_DEPTH32F_STENCIL8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int DEPTH32F_STENCIL8 = 0x8CAD;

		/// <summary>
		/// Value of GL_FLOAT_32_UNSIGNED_INT_24_8_REV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

		/// <summary>
		/// Value of GL_INVALID_FRAMEBUFFER_OPERATION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_DEFAULT = 0x8218;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNDEFINED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_UNDEFINED = 0x8219;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;

		/// <summary>
		/// Value of GL_MAX_RENDERBUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_RENDERBUFFER_SIZE = 0x84E8;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_STENCIL = 0x84F9;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_24_8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int UNSIGNED_INT_24_8 = 0x84FA;

		/// <summary>
		/// Value of GL_DEPTH24_STENCIL8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH24_STENCIL8 = 0x88F0;

		/// <summary>
		/// Value of GL_TEXTURE_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int TEXTURE_STENCIL_SIZE = 0x88F1;

		/// <summary>
		/// Value of GL_TEXTURE_RED_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_RED_TYPE = 0x8C10;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_GREEN_TYPE = 0x8C11;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_BLUE_TYPE = 0x8C12;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_ALPHA_TYPE = 0x8C13;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		public const int TEXTURE_DEPTH_TYPE = 0x8C16;

		/// <summary>
		/// Value of GL_UNSIGNED_NORMALIZED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int UNSIGNED_NORMALIZED = 0x8C17;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DRAW_FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_BINDING = 0x8CA7;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int READ_FRAMEBUFFER = 0x8CA8;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DRAW_FRAMEBUFFER = 0x8CA9;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int READ_FRAMEBUFFER_BINDING = 0x8CAA;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_SAMPLES = 0x8CAB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_COMPLETE = 0x8CD5;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNSUPPORTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

		/// <summary>
		/// Value of GL_MAX_COLOR_ATTACHMENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_COLOR_ATTACHMENTS = 0x8CDF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT0 = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT1 = 0x8CE1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT2 = 0x8CE2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT3 = 0x8CE3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT4 = 0x8CE4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT5 = 0x8CE5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT6 = 0x8CE6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT7 = 0x8CE7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT8 = 0x8CE8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT9 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT9 = 0x8CE9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT10 = 0x8CEA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT11 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT11 = 0x8CEB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT12 = 0x8CEC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT13 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT13 = 0x8CED;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT14 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT14 = 0x8CEE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT15 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT15 = 0x8CEF;

		/// <summary>
		/// Value of GL_DEPTH_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_ATTACHMENT = 0x8D00;

		/// <summary>
		/// Value of GL_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_ATTACHMENT = 0x8D20;

		/// <summary>
		/// Value of GL_FRAMEBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER = 0x8D40;

		/// <summary>
		/// Value of GL_RENDERBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_NV_internalformat_sample_query")]
		public const int RENDERBUFFER = 0x8D41;

		/// <summary>
		/// Value of GL_RENDERBUFFER_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_WIDTH = 0x8D42;

		/// <summary>
		/// Value of GL_RENDERBUFFER_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_HEIGHT = 0x8D43;

		/// <summary>
		/// Value of GL_RENDERBUFFER_INTERNAL_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;

		/// <summary>
		/// Value of GL_STENCIL_INDEX1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX1 = 0x8D46;

		/// <summary>
		/// Value of GL_STENCIL_INDEX4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX4 = 0x8D47;

		/// <summary>
		/// Value of GL_STENCIL_INDEX8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_texture_stencil8")]
		public const int STENCIL_INDEX8 = 0x8D48;

		/// <summary>
		/// Value of GL_STENCIL_INDEX16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX16 = 0x8D49;

		/// <summary>
		/// Value of GL_RENDERBUFFER_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_RED_SIZE = 0x8D50;

		/// <summary>
		/// Value of GL_RENDERBUFFER_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;

		/// <summary>
		/// Value of GL_RENDERBUFFER_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;

		/// <summary>
		/// Value of GL_RENDERBUFFER_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;

		/// <summary>
		/// Value of GL_RENDERBUFFER_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;

		/// <summary>
		/// Value of GL_MAX_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_SAMPLES = 0x8D57;

		/// <summary>
		/// Value of GL_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int INDEX = 0x8222;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_LUMINANCE_TYPE = 0x8C14;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_TYPE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_INTENSITY_TYPE = 0x8C15;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_SRGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_sRGB")]
		public const int FRAMEBUFFER_SRGB = 0x8DB9;

		/// <summary>
		/// Value of GL_HALF_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_half_float_vertex")]
		public const int HALF_FLOAT = 0x140B;

		/// <summary>
		/// Value of GL_MAP_READ_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_READ_BIT = 0x0001;

		/// <summary>
		/// Value of GL_MAP_WRITE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_WRITE_BIT = 0x0002;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_RANGE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_INVALIDATE_RANGE_BIT = 0x0004;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_BUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_INVALIDATE_BUFFER_BIT = 0x0008;

		/// <summary>
		/// Value of GL_MAP_FLUSH_EXPLICIT_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_FLUSH_EXPLICIT_BIT = 0x0010;

		/// <summary>
		/// Value of GL_MAP_UNSYNCHRONIZED_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_UNSYNCHRONIZED_BIT = 0x0020;

		/// <summary>
		/// Value of GL_COMPRESSED_RED_RGTC1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_RED_RGTC1 = 0x8DBB;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RED_RGTC1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;

		/// <summary>
		/// Value of GL_COMPRESSED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_RG_RGTC2 = 0x8DBD;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

		/// <summary>
		/// Value of GL_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG = 0x8227;

		/// <summary>
		/// Value of GL_RG_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG_INTEGER = 0x8228;

		/// <summary>
		/// Value of GL_R8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8 = 0x8229;

		/// <summary>
		/// Value of GL_R16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16 = 0x822A;

		/// <summary>
		/// Value of GL_RG8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8 = 0x822B;

		/// <summary>
		/// Value of GL_RG16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16 = 0x822C;

		/// <summary>
		/// Value of GL_R16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16F = 0x822D;

		/// <summary>
		/// Value of GL_R32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32F = 0x822E;

		/// <summary>
		/// Value of GL_RG16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16F = 0x822F;

		/// <summary>
		/// Value of GL_RG32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32F = 0x8230;

		/// <summary>
		/// Value of GL_R8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8I = 0x8231;

		/// <summary>
		/// Value of GL_R8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8UI = 0x8232;

		/// <summary>
		/// Value of GL_R16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16I = 0x8233;

		/// <summary>
		/// Value of GL_R16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16UI = 0x8234;

		/// <summary>
		/// Value of GL_R32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32I = 0x8235;

		/// <summary>
		/// Value of GL_R32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32UI = 0x8236;

		/// <summary>
		/// Value of GL_RG8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8I = 0x8237;

		/// <summary>
		/// Value of GL_RG8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8UI = 0x8238;

		/// <summary>
		/// Value of GL_RG16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16I = 0x8239;

		/// <summary>
		/// Value of GL_RG16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16UI = 0x823A;

		/// <summary>
		/// Value of GL_RG32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32I = 0x823B;

		/// <summary>
		/// Value of GL_RG32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32UI = 0x823C;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public const int VERTEX_ARRAY_BINDING = 0x85B5;

		/// <summary>
		/// Value of GL_CLAMP_VERTEX_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_VERTEX_COLOR = 0x891A;

		/// <summary>
		/// Value of GL_CLAMP_FRAGMENT_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_FRAGMENT_COLOR = 0x891B;

		/// <summary>
		/// Value of GL_ALPHA_INTEGER symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_INTEGER = 0x8D97;

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <remarks>
		/// glColorMask and glColorMaski specify whether the individual color components in the frame buffer can or cannot be 
		/// written.glColorMaski sets the mask for a specific draw buffer, whereas glColorMask sets the mask for all draw buffers. 
		/// Ifred is GL_FALSE, for example, no change is made to the red component of any pixel in any of the color buffers, 
		/// regardlessof the drawing operation attempted. 
		/// Changes to individual bits of components cannot be controlled. Rather, changes are either enabled or disabled for entire 
		/// colorcomponents. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_COLOR_WRITEMASK 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilMask"/>
		public static void ColorMask(UInt32 index, bool r, bool g, bool b, bool a)
		{
			if        (Delegates.pglColorMaski != null) {
				Delegates.pglColorMaski(index, r, g, b, a);
				CallLog("glColorMaski({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			} else if (Delegates.pglColorMaskIndexedEXT != null) {
				Delegates.pglColorMaskIndexedEXT(index, r, g, b, a);
				CallLog("glColorMaskIndexedEXT({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			} else if (Delegates.pglColorMaskiEXT != null) {
				Delegates.pglColorMaskiEXT(index, r, g, b, a);
				CallLog("glColorMaskiEXT({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			} else if (Delegates.pglColorMaskiOES != null) {
				Delegates.pglColorMaskiOES(index, r, g, b, a);
				CallLog("glColorMaskiOES({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			} else
				throw new NotImplementedException("glColorMaski (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
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
		public static void GetBoolean(int target, UInt32 index, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					if        (Delegates.pglGetBooleani_v != null) {
						Delegates.pglGetBooleani_v(target, index, p_data);
						CallLog("glGetBooleani_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetBooleanIndexedvEXT != null) {
						Delegates.pglGetBooleanIndexedvEXT(target, index, p_data);
						CallLog("glGetBooleanIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetBooleani_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried. 
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter. 
		/// </param>
		/// <remarks>
		/// These commands return values for simple state variables in GL. pname is a symbolic constant indicating the state 
		/// variableto be returned, and data is a pointer to an array of the indicated type in which to place the returned data. 
		/// Type conversion is performed if data has a different type than the state variable value being requested. If 
		/// glGetBooleanvis called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). 
		/// Otherwise,it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, 
		/// andmost floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are 
		/// returnedwith a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most 
		/// negativerepresentable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or 
		/// GL_FALSE,and integer values are converted to floating-point values. 
		/// The following symbolic constants are accepted by pname: 
		/// Many of the boolean parameters can also be queried more easily using glIsEnabled. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_VALUE is generated on any of glGetBooleani_v, glGetIntegeri_v, or glGetInteger64i_v if index is outside of 
		///   thevalid range for the indexed state target. 
		/// </para>
		/// </remarks>
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
		public static void GetIntegeri_v(int target, UInt32 index, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					if        (Delegates.pglGetIntegeri_v != null) {
						Delegates.pglGetIntegeri_v(target, index, p_data);
						CallLog("glGetIntegeri_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetIntegerIndexedvEXT != null) {
						Delegates.pglGetIntegerIndexedvEXT(target, index, p_data);
						CallLog("glGetIntegerIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetIntegeri_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnablei.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Enable(int target, UInt32 index)
		{
			if        (Delegates.pglEnablei != null) {
				Delegates.pglEnablei(target, index);
				CallLog("glEnablei({0}, {1})", target, index);
			} else if (Delegates.pglEnableIndexedEXT != null) {
				Delegates.pglEnableIndexedEXT(target, index);
				CallLog("glEnableIndexedEXT({0}, {1})", target, index);
			} else if (Delegates.pglEnableiEXT != null) {
				Delegates.pglEnableiEXT(target, index);
				CallLog("glEnableiEXT({0}, {1})", target, index);
			} else if (Delegates.pglEnableiNV != null) {
				Delegates.pglEnableiNV(target, index);
				CallLog("glEnableiNV({0}, {1})", target, index);
			} else if (Delegates.pglEnableiOES != null) {
				Delegates.pglEnableiOES(target, index);
				CallLog("glEnableiOES({0}, {1})", target, index);
			} else
				throw new NotImplementedException("glEnablei (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisablei.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		public static void Disable(int target, UInt32 index)
		{
			if        (Delegates.pglDisablei != null) {
				Delegates.pglDisablei(target, index);
				CallLog("glDisablei({0}, {1})", target, index);
			} else if (Delegates.pglDisableIndexedEXT != null) {
				Delegates.pglDisableIndexedEXT(target, index);
				CallLog("glDisableIndexedEXT({0}, {1})", target, index);
			} else if (Delegates.pglDisableiEXT != null) {
				Delegates.pglDisableiEXT(target, index);
				CallLog("glDisableiEXT({0}, {1})", target, index);
			} else if (Delegates.pglDisableiNV != null) {
				Delegates.pglDisableiNV(target, index);
				CallLog("glDisableiNV({0}, {1})", target, index);
			} else if (Delegates.pglDisableiOES != null) {
				Delegates.pglDisableiOES(target, index);
				CallLog("glDisableiOES({0}, {1})", target, index);
			} else
				throw new NotImplementedException("glDisablei (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the capability. 
		/// </param>
		/// <remarks>
		/// glIsEnabled returns GL_TRUE if cap is an enabled capability and returns GL_FALSE otherwise. Boolean states that are 
		/// indexedmay be tested with glIsEnabledi. For glIsEnabledi, index specifies the index of the capability to test. index 
		/// mustbe between zero and the count of indexed capabilities for cap. Initially all capabilities except GL_DITHER are 
		/// disabled;GL_DITHER is initially enabled. 
		/// The following capabilities are accepted for cap: 
		///  
		///  
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if cap is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glIsEnabledi if index is outside the valid range for the indexed state cap. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Disable"/>
		/// <seealso cref="Gl.Get"/>
		public static bool IsEnabledi(int target, UInt32 index)
		{
			bool retValue;

			if        (Delegates.pglIsEnabledi != null) {
				retValue = Delegates.pglIsEnabledi(target, index);
				CallLog("glIsEnabledi({0}, {1}) = {2}", target, index, retValue);
			} else if (Delegates.pglIsEnabledIndexedEXT != null) {
				retValue = Delegates.pglIsEnabledIndexedEXT(target, index);
				CallLog("glIsEnabledIndexedEXT({0}, {1}) = {2}", target, index, retValue);
			} else if (Delegates.pglIsEnablediEXT != null) {
				retValue = Delegates.pglIsEnablediEXT(target, index);
				CallLog("glIsEnablediEXT({0}, {1}) = {2}", target, index, retValue);
			} else if (Delegates.pglIsEnablediOES != null) {
				retValue = Delegates.pglIsEnablediOES(target, index);
				CallLog("glIsEnablediOES({0}, {1}) = {2}", target, index, retValue);
			} else if (Delegates.pglIsEnablediNV != null) {
				retValue = Delegates.pglIsEnablediNV(target, index);
				CallLog("glIsEnablediNV({0}, {1}) = {2}", target, index, retValue);
			} else
				throw new NotImplementedException("glIsEnabledi (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		/// <param name="primitiveMode">
		/// Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform 
		/// feedback.
		/// </param>
		/// <remarks>
		/// Transform feedback mode captures the values of varying variables written by the vertex shader (or, if active, the 
		/// geometryshader). Transform feedback is said to be active after a call to glBeginTransformFeedback until a subsequent 
		/// callto glEndTransformFeedback. Transform feedback commands must be paired. 
		/// If no geometry shader is present, while transform feedback is active the mode parameter to glDrawArrays must match those 
		/// specifiedin the following table: 
		/// If a geometry shader is present, the output primitive type from the geometry shader must match those provided in the 
		/// followingtable: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if glBeginTransformFeedback is executed while transform feedback is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback is executed while transform feedback is not active. 
		/// - GL_INVALID_OPERATION is generated by glDrawArrays if no geometry shader is present, transform feedback is active and 
		///   modeis not one of the allowed modes. 
		/// - GL_INVALID_OPERATION is generated by glDrawArrays if a geometry shader is present, transform feedback is active and the 
		///   outputprimitive type of the geometry shader does not match the transform feedback primitiveMode. 
		/// - GL_INVALID_OPERATION is generated by glEndTransformFeedback if any binding point used in transform feedback mode does 
		///   nothave a buffer object bound. 
		/// - GL_INVALID_OPERATION is generated by glEndTransformFeedback if no binding points would be used, either because no 
		///   programobject is active of because the active program object has specified no varying variables to record. 
		/// </para>
		/// </remarks>
		public static void BeginTransformFeedback(int primitiveMode)
		{
			if        (Delegates.pglBeginTransformFeedback != null) {
				Delegates.pglBeginTransformFeedback(primitiveMode);
				CallLog("glBeginTransformFeedback({0})", primitiveMode);
			} else if (Delegates.pglBeginTransformFeedbackEXT != null) {
				Delegates.pglBeginTransformFeedbackEXT(primitiveMode);
				CallLog("glBeginTransformFeedbackEXT({0})", primitiveMode);
			} else if (Delegates.pglBeginTransformFeedbackNV != null) {
				Delegates.pglBeginTransformFeedbackNV(primitiveMode);
				CallLog("glBeginTransformFeedbackNV({0})", primitiveMode);
			} else
				throw new NotImplementedException("glBeginTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		/// <remarks>
		/// Transform feedback mode captures the values of varying variables written by the vertex shader (or, if active, the 
		/// geometryshader). Transform feedback is said to be active after a call to glBeginTransformFeedback until a subsequent 
		/// callto glEndTransformFeedback. Transform feedback commands must be paired. 
		/// If no geometry shader is present, while transform feedback is active the mode parameter to glDrawArrays must match those 
		/// specifiedin the following table: 
		/// If a geometry shader is present, the output primitive type from the geometry shader must match those provided in the 
		/// followingtable: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if glBeginTransformFeedback is executed while transform feedback is active. 
		/// - GL_INVALID_OPERATION is generated if glEndTransformFeedback is executed while transform feedback is not active. 
		/// - GL_INVALID_OPERATION is generated by glDrawArrays if no geometry shader is present, transform feedback is active and 
		///   modeis not one of the allowed modes. 
		/// - GL_INVALID_OPERATION is generated by glDrawArrays if a geometry shader is present, transform feedback is active and the 
		///   outputprimitive type of the geometry shader does not match the transform feedback primitiveMode. 
		/// - GL_INVALID_OPERATION is generated by glEndTransformFeedback if any binding point used in transform feedback mode does 
		///   nothave a buffer object bound. 
		/// - GL_INVALID_OPERATION is generated by glEndTransformFeedback if no binding points would be used, either because no 
		///   programobject is active of because the active program object has specified no varying variables to record. 
		/// </para>
		/// </remarks>
		public static void EndTransformFeedback()
		{
			if        (Delegates.pglEndTransformFeedback != null) {
				Delegates.pglEndTransformFeedback();
				CallLog("glEndTransformFeedback()");
			} else if (Delegates.pglEndTransformFeedbackEXT != null) {
				Delegates.pglEndTransformFeedbackEXT();
				CallLog("glEndTransformFeedbackEXT()");
			} else if (Delegates.pglEndTransformFeedbackNV != null) {
				Delegates.pglEndTransformFeedbackNV();
				CallLog("glEndTransformFeedbackNV()");
			} else
				throw new NotImplementedException("glEndTransformFeedback (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a range within a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFER,or GL_SHADER_STORAGE_BUFFER. 
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by target. 
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point. 
		/// </param>
		/// <param name="offset">
		/// The starting offset in basic machine units into the buffer object buffer. 
		/// </param>
		/// <param name="size">
		/// The amount of data in machine units that can be read from the buffer object while used as an indexed target. 
		/// </param>
		/// <remarks>
		/// glBindBufferRange binds a range the buffer object buffer represented by offset and size to the binding point at index 
		/// indexof the array of targets specified by target. Each target represents an indexed array of buffer binding points, as 
		/// wellas a single general binding point that can be used by other buffer manipulation functions such as glBindBuffer or 
		/// glMapBuffer.In addition to binding a range of buffer to the indexed buffer binding target, glBindBufferRange also binds 
		/// therange to the generic buffer binding point specified by target. 
		/// offset specifies the offset in basic machine units into the buffer object buffer and size specifies the amount of data 
		/// thatcan be read from the buffer object while used as an indexed target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		///   GL_UNIFORM_BUFFERor GL_SHADER_STORAGE_BUFFER. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of target-specific indexed binding points. 
		/// - GL_INVALID_VALUE is generated if size is less than or equal to zero, or if offset + size is greater than the value of 
		///   GL_BUFFER_SIZE.
		/// - Additional errors may be generated if offset violates any target-specific alignmemt restrictions. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void BindBufferRange(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			if        (Delegates.pglBindBufferRange != null) {
				Delegates.pglBindBufferRange(target, index, buffer, offset, size);
				CallLog("glBindBufferRange({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			} else if (Delegates.pglBindBufferRangeEXT != null) {
				Delegates.pglBindBufferRangeEXT(target, index, buffer, offset, size);
				CallLog("glBindBufferRangeEXT({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			} else if (Delegates.pglBindBufferRangeNV != null) {
				Delegates.pglBindBufferRangeNV(target, index, buffer, offset, size);
				CallLog("glBindBufferRangeNV({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			} else
				throw new NotImplementedException("glBindBufferRange (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFERor GL_SHADER_STORAGE_BUFFER. 
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by target. 
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point. 
		/// </param>
		/// <remarks>
		/// glBindBufferBase binds the buffer object buffer to the binding point at index index of the array of targets specified by 
		/// target.Each target represents an indexed array of buffer binding points, as well as a single general binding point that 
		/// canbe used by other buffer manipulation functions such as glBindBuffer or glMapBuffer. In addition to binding buffer to 
		/// theindexed buffer binding target, glBindBufferBase also binds buffer to the generic buffer binding point specified by 
		/// target.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, GL_UNIFORM_BUFFER 
		///   orGL_SHADER_STORAGE_BUFFER. 
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to the number of target-specific indexed binding points. 
		/// - GL_INVALID_VALUE is generated if buffer does not have an associated data store, or if the size of that store is zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void BindBufferBase(int target, UInt32 index, UInt32 buffer)
		{
			if        (Delegates.pglBindBufferBase != null) {
				Delegates.pglBindBufferBase(target, index, buffer);
				CallLog("glBindBufferBase({0}, {1}, {2})", target, index, buffer);
			} else if (Delegates.pglBindBufferBaseEXT != null) {
				Delegates.pglBindBufferBaseEXT(target, index, buffer);
				CallLog("glBindBufferBaseEXT({0}, {1}, {2})", target, index, buffer);
			} else if (Delegates.pglBindBufferBaseNV != null) {
				Delegates.pglBindBufferBaseNV(target, index, buffer);
				CallLog("glBindBufferBaseNV({0}, {1}, {2})", target, index, buffer);
			} else
				throw new NotImplementedException("glBindBufferBase (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify values to record in transform feedback buffers
		/// </summary>
		/// <param name="program">
		/// The name of the target program object. 
		/// </param>
		/// <param name="count">
		/// The number of varying variables used for transform feedback. 
		/// </param>
		/// <param name="varyings">
		/// An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback. 
		/// </param>
		/// <param name="bufferMode">
		/// Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be 
		/// GL_INTERLEAVED_ATTRIBSor GL_SEPARATE_ATTRIBS. 
		/// </param>
		/// <remarks>
		/// The names of the vertex or geometry shader outputs to be recorded in transform feedback mode are specified using 
		/// glTransformFeedbackVaryings.When a geometry shader is active, transform feedback records the values of selected geometry 
		/// shaderoutput variables from the emitted vertices. Otherwise, the values of the selected vertex shader outputs are 
		/// recorded.
		/// The state set by glTranformFeedbackVaryings is stored and takes effect next time glLinkProgram is called on program. 
		/// WhenglLinkProgram is called, program is linked so that the values of the specified varying variables for the vertices of 
		/// eachprimitive generated by the GL are written to a single buffer object if bufferMode is GL_INTERLEAVED_ATTRIBS or 
		/// multiplebuffer objects if bufferMode is GL_SEPARATE_ATTRIBS. 
		/// In addition to the errors generated by glTransformFeedbackVaryings, the program program will fail to link if: The count 
		/// specifiedby glTransformFeedbackVaryings is non-zero, but the program object has no vertex or geometry shader. Any 
		/// variablename specified in the varyings array is not declared as an output in the vertex shader (or the geometry shader, 
		/// ifactive). Any two entries in the varyings array specify the same varying variable. The total number of components to 
		/// capturein any varying variable in varyings is greater than the constant GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS 
		/// andthe buffer mode is GL_SEPARATE_ATTRIBS. The total number of components to capture is greater than the constant 
		/// GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTSand the buffer mode is GL_INTERLEAVED_ATTRIBS. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of a program object. 
		/// - GL_INVALID_VALUE is generated if bufferMode is GL_SEPARATE_ATTRIBS and count is greater than the 
		///   implementation-dependentlimit GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTransformFeedbackVarying 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.GetTransformFeedbackVarying"/>
		public static void TransformFeedbackVarying(UInt32 program, Int32 count, String[] varyings, int bufferMode)
		{
			if        (Delegates.pglTransformFeedbackVaryings != null) {
				Delegates.pglTransformFeedbackVaryings(program, count, varyings, bufferMode);
				CallLog("glTransformFeedbackVaryings({0}, {1}, {2}, {3})", program, count, varyings, bufferMode);
			} else if (Delegates.pglTransformFeedbackVaryingsEXT != null) {
				Delegates.pglTransformFeedbackVaryingsEXT(program, count, varyings, bufferMode);
				CallLog("glTransformFeedbackVaryingsEXT({0}, {1}, {2}, {3})", program, count, varyings, bufferMode);
			} else
				throw new NotImplementedException("glTransformFeedbackVaryings (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about varying variables selected for transform feedback
		/// </summary>
		/// <param name="program">
		/// The name of the target program object. 
		/// </param>
		/// <param name="index">
		/// The index of the varying variable whose information to retrieve. 
		/// </param>
		/// <param name="bufSize">
		/// The maximum number of characters, including the null terminator, that may be written into name. 
		/// </param>
		/// <param name="length">
		/// The address of a variable which will receive the number of characters written into name, excluding the null-terminator. 
		/// Iflength is NULL no length is returned. 
		/// </param>
		/// <param name="size">
		/// The address of a variable that will receive the size of the varying. 
		/// </param>
		/// <param name="type">
		/// The address of a variable that will recieve the type of the varying. 
		/// </param>
		/// <param name="name">
		/// The address of a buffer into which will be written the name of the varying. 
		/// </param>
		/// <remarks>
		/// Information about the set of varying variables in a linked program that will be captured during transform feedback may 
		/// beretrieved by calling glGetTransformFeedbackVarying. glGetTransformFeedbackVarying provides information about the 
		/// varyingvariable selected by index. An index of 0 selects the first varying variable specified in the varyings array 
		/// passedto glTransformFeedbackVaryings, and an index of the value of GL_TRANSFORM_FEEDBACK_VARYINGS minus one selects the 
		/// lastsuch variable. 
		/// The name of the selected varying is returned as a null-terminated string in name. The actual number of characters 
		/// writteninto name, excluding the null terminator, is returned in length. If length is NULL, no length is returned. The 
		/// maximumnumber of characters that may be written into name, including the null terminator, is specified by bufSize. 
		/// The length of the longest varying name in program is given by GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, which can be 
		/// queriedwith glGetProgram. 
		/// For the selected varying variable, its type is returned into type. The size of the varying is returned into size. The 
		/// valuein size is in units of the type returned in type. The type returned can be any of the scalar, vector, or matrix 
		/// attributetypes returned by glGetActiveAttrib. If an error occurred, the return parameters length, size, type and name 
		/// willbe unmodified. This command will return as much information about the varying variables as possible. If no 
		/// informationis available, length will be set to zero and name will be an empty string. This situation could arise if 
		/// glGetTransformFeedbackVaryingis called after a failed link. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not the name of a program object. 
		/// - GL_INVALID_VALUE is generated if index is greater or equal to the value of GL_TRANSFORM_FEEDBACK_VARYINGS. 
		/// - GL_INVALID_OPERATION is generated program has not been linked. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetProgram with argument GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BeginTransformFeedback"/>
		/// <seealso cref="Gl.EndTransformFeedback"/>
		/// <seealso cref="Gl.TransformFeedbackVaryings"/>
		/// <seealso cref="Gl.GetProgram"/>
		public static void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					if        (Delegates.pglGetTransformFeedbackVarying != null) {
						Delegates.pglGetTransformFeedbackVarying(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetTransformFeedbackVarying({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else if (Delegates.pglGetTransformFeedbackVaryingEXT != null) {
						Delegates.pglGetTransformFeedbackVaryingEXT(program, index, bufSize, p_length, p_size, p_type, name);
						CallLog("glGetTransformFeedbackVaryingEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
					} else
						throw new NotImplementedException("glGetTransformFeedbackVarying (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify whether data read via glReadPixels should be clamped
		/// </summary>
		/// <param name="target">
		/// Target for color clamping. target must be GL_CLAMP_READ_COLOR. 
		/// </param>
		/// <param name="clamp">
		/// Specifies whether to apply color clamping. clamp must be GL_TRUE or GL_FALSE. 
		/// </param>
		/// <remarks>
		/// glClampColor controls color clamping that is performed during glReadPixels. target must be GL_CLAMP_READ_COLOR. If clamp 
		/// isGL_TRUE, read color clamping is enabled; if clamp is GL_FALSE, read color clamping is disabled. If clamp is 
		/// GL_FIXED_ONLY,read color clamping is enabled only if the selected read buffer has fixed point components and disabled 
		/// otherwise.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_CLAMP_READ_COLOR. 
		/// - GL_INVALID_ENUM is generated if clamp is not GL_TRUE or GL_FALSE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_CLAMP_READ_COLOR. 
		/// </para>
		/// </remarks>
		public static void ClampColor(int target, int clamp)
		{
			if        (Delegates.pglClampColor != null) {
				Delegates.pglClampColor(target, clamp);
				CallLog("glClampColor({0}, {1})", target, clamp);
			} else if (Delegates.pglClampColorARB != null) {
				Delegates.pglClampColorARB(target, clamp);
				CallLog("glClampColorARB({0}, {1})", target, clamp);
			} else
				throw new NotImplementedException("glClampColor (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		/// <param name="id">
		/// Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are 
		/// discarded.
		/// </param>
		/// <param name="mode">
		/// Specifies how glBeginConditionalRender interprets the results of the occlusion query. 
		/// </param>
		/// <remarks>
		/// Conditional rendering is started using glBeginConditionalRender and ended using glEndConditionalRender. During 
		/// conditionalrendering, all vertex array commands, as well as glClear and glClearBuffer have no effect if the 
		/// (GL_SAMPLES_PASSED)result of the query object id is zero, or if the (GL_ANY_SAMPLES_PASSED) result is GL_FALSE. The 
		/// resultsof commands setting the current vertex state, such as glVertexAttrib are undefined. If the (GL_SAMPLES_PASSED) 
		/// resultis non-zero or if the (GL_ANY_SAMPLES_PASSED) result is GL_TRUE, such commands are not discarded. The id parameter 
		/// toglBeginConditionalRender must be the name of a query object previously returned from a call to glGenQueries. mode 
		/// specifieshow the results of the query object are to be interpreted. If mode is GL_QUERY_WAIT, the GL waits for the 
		/// resultsof the query to be available and then uses the results to determine if subsequent rendering commands are 
		/// discarded.If mode is GL_QUERY_NO_WAIT, the GL may choose to unconditionally execute the subsequent rendering commands 
		/// withoutwaiting for the query to complete. 
		/// If mode is GL_QUERY_BY_REGION_WAIT, the GL will also wait for occlusion query results and discard rendering commands if 
		/// theresult of the occlusion query is zero. If the query result is non-zero, subsequent rendering commands are executed, 
		/// butthe GL may discard the results of the commands for any region of the framebuffer that did not contribute to the 
		/// samplecount in the specified occlusion query. Any such discarding is done in an implementation-dependent manner, but the 
		/// renderingcommand results may not be discarded for any samples that contributed to the occlusion query sample count. If 
		/// modeis GL_QUERY_BY_REGION_NO_WAIT, the GL operates as in GL_QUERY_BY_REGION_WAIT, but may choose to unconditionally 
		/// executethe subsequent rendering commands without waiting for the query to complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if id is not the name of an existing query object. 
		/// - GL_INVALID_ENUM is generated if mode is not one of the accepted tokens. 
		/// - GL_INVALID_OPERATION is generated if glBeginConditionalRender is called while conditional rendering is active, or if 
		///   glEndConditionalRenderis called while conditional rendering is inactive. 
		/// - GL_INVALID_OPERATION is generated if id is the name of a query object with a target other than GL_SAMPLES_PASSED or 
		///   GL_ANY_SAMPLES_PASSED.
		/// - GL_INVALID_OPERATION is generated if id is the name of a query currently in progress. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.BeginQuery"/>
		public static void BeginConditionalRender(UInt32 id, int mode)
		{
			if        (Delegates.pglBeginConditionalRender != null) {
				Delegates.pglBeginConditionalRender(id, mode);
				CallLog("glBeginConditionalRender({0}, {1})", id, mode);
			} else if (Delegates.pglBeginConditionalRenderNV != null) {
				Delegates.pglBeginConditionalRenderNV(id, mode);
				CallLog("glBeginConditionalRenderNV({0}, {1})", id, mode);
			} else
				throw new NotImplementedException("glBeginConditionalRender (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		/// <remarks>
		/// Conditional rendering is started using glBeginConditionalRender and ended using glEndConditionalRender. During 
		/// conditionalrendering, all vertex array commands, as well as glClear and glClearBuffer have no effect if the 
		/// (GL_SAMPLES_PASSED)result of the query object id is zero, or if the (GL_ANY_SAMPLES_PASSED) result is GL_FALSE. The 
		/// resultsof commands setting the current vertex state, such as glVertexAttrib are undefined. If the (GL_SAMPLES_PASSED) 
		/// resultis non-zero or if the (GL_ANY_SAMPLES_PASSED) result is GL_TRUE, such commands are not discarded. The id parameter 
		/// toglBeginConditionalRender must be the name of a query object previously returned from a call to glGenQueries. mode 
		/// specifieshow the results of the query object are to be interpreted. If mode is GL_QUERY_WAIT, the GL waits for the 
		/// resultsof the query to be available and then uses the results to determine if subsequent rendering commands are 
		/// discarded.If mode is GL_QUERY_NO_WAIT, the GL may choose to unconditionally execute the subsequent rendering commands 
		/// withoutwaiting for the query to complete. 
		/// If mode is GL_QUERY_BY_REGION_WAIT, the GL will also wait for occlusion query results and discard rendering commands if 
		/// theresult of the occlusion query is zero. If the query result is non-zero, subsequent rendering commands are executed, 
		/// butthe GL may discard the results of the commands for any region of the framebuffer that did not contribute to the 
		/// samplecount in the specified occlusion query. Any such discarding is done in an implementation-dependent manner, but the 
		/// renderingcommand results may not be discarded for any samples that contributed to the occlusion query sample count. If 
		/// modeis GL_QUERY_BY_REGION_NO_WAIT, the GL operates as in GL_QUERY_BY_REGION_WAIT, but may choose to unconditionally 
		/// executethe subsequent rendering commands without waiting for the query to complete. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if id is not the name of an existing query object. 
		/// - GL_INVALID_ENUM is generated if mode is not one of the accepted tokens. 
		/// - GL_INVALID_OPERATION is generated if glBeginConditionalRender is called while conditional rendering is active, or if 
		///   glEndConditionalRenderis called while conditional rendering is inactive. 
		/// - GL_INVALID_OPERATION is generated if id is the name of a query object with a target other than GL_SAMPLES_PASSED or 
		///   GL_ANY_SAMPLES_PASSED.
		/// - GL_INVALID_OPERATION is generated if id is the name of a query currently in progress. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenQueries"/>
		/// <seealso cref="Gl.DeleteQueries"/>
		/// <seealso cref="Gl.BeginQuery"/>
		public static void EndConditionalRender()
		{
			if        (Delegates.pglEndConditionalRender != null) {
				Delegates.pglEndConditionalRender();
				CallLog("glEndConditionalRender()");
			} else if (Delegates.pglEndConditionalRenderNV != null) {
				Delegates.pglEndConditionalRenderNV();
				CallLog("glEndConditionalRenderNV()");
			} else if (Delegates.pglEndConditionalRenderNVX != null) {
				Delegates.pglEndConditionalRenderNVX();
				CallLog("glEndConditionalRenderNVX()");
			} else
				throw new NotImplementedException("glEndConditionalRender (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRAis accepted by glVertexAttribPointer. The initial value is 4. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT,GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// AdditionallyGL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REVare accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointerand is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// areunderstood to be tightly packed in the array. The initial value is 0. 
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffercurrently bound to the GL_ARRAY_BUFFER target. The initial value is 0. 
		/// </param>
		/// <remarks>
		/// glVertexAttribPointer, glVertexAttribIPointer and glVertexAttribLPointer specify the location and data format of the 
		/// arrayof generic vertex attributes at index index to use when rendering. size specifies the number of components per 
		/// attributeand must be 1, 2, 3, 4, or GL_BGRA. type specifies the data type of each component, and stride specifies the 
		/// bytestride from one attribute to the next, allowing vertices and attributes to be packed into a single array or stored 
		/// inseparate arrays. 
		/// For glVertexAttribPointer, if normalized is set to GL_TRUE, it indicates that values stored in an integer format are to 
		/// bemapped to the range [-1,1] (for signed values) or [0,1] (for unsigned values) when they are accessed and converted to 
		/// floatingpoint. Otherwise, values will be converted to floats directly without normalization. 
		/// For glVertexAttribIPointer, only the integer types GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, 
		/// GL_UNSIGNED_INTare accepted. Values are always left as integer values. 
		/// glVertexAttribLPointer specifies state for a generic vertex attribute array associated with a shader attribute variable 
		/// declaredwith 64-bit double precision components. type must be GL_DOUBLE. index, size, and stride behave as described for 
		/// glVertexAttribPointerand glVertexAttribIPointer. 
		/// If pointer is not NULL, a non-zero named buffer object must be bound to the GL_ARRAY_BUFFER target (see glBindBuffer), 
		/// otherwisean error is generated. pointer is treated as a byte offset into the buffer object's data store. The buffer 
		/// objectbinding (GL_ARRAY_BUFFER_BINDING) is saved as generic vertex attribute array state 
		/// (GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING)for index index. 
		/// When a generic vertex attribute array is specified, size, type, normalized, stride, and pointer are saved as vertex 
		/// arraystate, in addition to the current vertex array buffer object binding. 
		/// To enable and disable a generic vertex attribute array, call glEnableVertexAttribArray and glDisableVertexAttribArray 
		/// withindex. If enabled, the generic vertex attribute array is used when glDrawArrays, glMultiDrawArrays, glDrawElements, 
		/// glMultiDrawElements,or glDrawRangeElements is called. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not 1, 2, 3, 4 or (for glVertexAttribPointer), GL_BGRA. 
		/// - GL_INVALID_ENUM is generated if type is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if stride is negative. 
		/// - GL_INVALID_OPERATION is generated if size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or 
		///   GL_UNSIGNED_INT_2_10_10_10_REV.
		/// - GL_INVALID_OPERATION is generated if type is GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV and size is not 4 
		///   orGL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if type is GL_UNSIGNED_INT_10F_11F_11F_REV and size is not 3. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribPointer if size is GL_BGRA and noramlized is GL_FALSE. 
		/// - GL_INVALID_OPERATION is generated if zero is bound to the GL_ARRAY_BUFFER buffer object binding point and the pointer 
		///   argumentis not NULL. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_SIZE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_TYPE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_NORMALIZED 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_STRIDE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING 
		/// - glGet with argument GL_ARRAY_BUFFER_BINDING 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		public static void VertexAttribIPointer(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglVertexAttribIPointer != null) {
				Delegates.pglVertexAttribIPointer(index, size, type, stride, pointer);
				CallLog("glVertexAttribIPointer({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			} else if (Delegates.pglVertexAttribIPointerEXT != null) {
				Delegates.pglVertexAttribIPointerEXT(index, size, type, stride, pointer);
				CallLog("glVertexAttribIPointerEXT({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			} else
				throw new NotImplementedException("glVertexAttribIPointer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRAis accepted by glVertexAttribPointer. The initial value is 4. 
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT,GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// AdditionallyGL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REVare accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointerand is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// areunderstood to be tightly packed in the array. The initial value is 0. 
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffercurrently bound to the GL_ARRAY_BUFFER target. The initial value is 0. 
		/// </param>
		/// <remarks>
		/// glVertexAttribPointer, glVertexAttribIPointer and glVertexAttribLPointer specify the location and data format of the 
		/// arrayof generic vertex attributes at index index to use when rendering. size specifies the number of components per 
		/// attributeand must be 1, 2, 3, 4, or GL_BGRA. type specifies the data type of each component, and stride specifies the 
		/// bytestride from one attribute to the next, allowing vertices and attributes to be packed into a single array or stored 
		/// inseparate arrays. 
		/// For glVertexAttribPointer, if normalized is set to GL_TRUE, it indicates that values stored in an integer format are to 
		/// bemapped to the range [-1,1] (for signed values) or [0,1] (for unsigned values) when they are accessed and converted to 
		/// floatingpoint. Otherwise, values will be converted to floats directly without normalization. 
		/// For glVertexAttribIPointer, only the integer types GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, GL_UNSIGNED_SHORT, GL_INT, 
		/// GL_UNSIGNED_INTare accepted. Values are always left as integer values. 
		/// glVertexAttribLPointer specifies state for a generic vertex attribute array associated with a shader attribute variable 
		/// declaredwith 64-bit double precision components. type must be GL_DOUBLE. index, size, and stride behave as described for 
		/// glVertexAttribPointerand glVertexAttribIPointer. 
		/// If pointer is not NULL, a non-zero named buffer object must be bound to the GL_ARRAY_BUFFER target (see glBindBuffer), 
		/// otherwisean error is generated. pointer is treated as a byte offset into the buffer object's data store. The buffer 
		/// objectbinding (GL_ARRAY_BUFFER_BINDING) is saved as generic vertex attribute array state 
		/// (GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING)for index index. 
		/// When a generic vertex attribute array is specified, size, type, normalized, stride, and pointer are saved as vertex 
		/// arraystate, in addition to the current vertex array buffer object binding. 
		/// To enable and disable a generic vertex attribute array, call glEnableVertexAttribArray and glDisableVertexAttribArray 
		/// withindex. If enabled, the generic vertex attribute array is used when glDrawArrays, glMultiDrawArrays, glDrawElements, 
		/// glMultiDrawElements,or glDrawRangeElements is called. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_VALUE is generated if size is not 1, 2, 3, 4 or (for glVertexAttribPointer), GL_BGRA. 
		/// - GL_INVALID_ENUM is generated if type is not an accepted value. 
		/// - GL_INVALID_VALUE is generated if stride is negative. 
		/// - GL_INVALID_OPERATION is generated if size is GL_BGRA and type is not GL_UNSIGNED_BYTE, GL_INT_2_10_10_10_REV or 
		///   GL_UNSIGNED_INT_2_10_10_10_REV.
		/// - GL_INVALID_OPERATION is generated if type is GL_INT_2_10_10_10_REV or GL_UNSIGNED_INT_2_10_10_10_REV and size is not 4 
		///   orGL_BGRA. 
		/// - GL_INVALID_OPERATION is generated if type is GL_UNSIGNED_INT_10F_11F_11F_REV and size is not 3. 
		/// - GL_INVALID_OPERATION is generated by glVertexAttribPointer if size is GL_BGRA and noramlized is GL_FALSE. 
		/// - GL_INVALID_OPERATION is generated if zero is bound to the GL_ARRAY_BUFFER buffer object binding point and the pointer 
		///   argumentis not NULL. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_ENABLED 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_SIZE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_TYPE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_NORMALIZED 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_STRIDE 
		/// - glGetVertexAttrib with arguments index and GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING 
		/// - glGet with argument GL_ARRAY_BUFFER_BINDING 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		public static void VertexAttribIPointer(UInt32 index, Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribIPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING,GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE,GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER,GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glGetVertexAttrib returns in params the value of a generic vertex attribute parameter. The generic vertex attribute to 
		/// bequeried is specified by index, and the parameter to be queried is specified by pname. 
		/// The accepted parameter names are as follows: 
		/// All of the parameters except GL_CURRENT_VERTEX_ATTRIB represent state stored in the currently bound vertex array object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if pname is not GL_CURRENT_VERTEX_ATTRIB and there is no currently bound vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if index is 0 and pname is GL_CURRENT_VERTEX_ATTRIB. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void GetVertexAttribI(UInt32 index, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					if        (Delegates.pglGetVertexAttribIiv != null) {
						Delegates.pglGetVertexAttribIiv(index, pname, p_params);
						CallLog("glGetVertexAttribIiv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribIivEXT != null) {
						Delegates.pglGetVertexAttribIivEXT(index, pname, p_params);
						CallLog("glGetVertexAttribIivEXT({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING,GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE,GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER,GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// glGetVertexAttrib returns in params the value of a generic vertex attribute parameter. The generic vertex attribute to 
		/// bequeried is specified by index, and the parameter to be queried is specified by pname. 
		/// The accepted parameter names are as follows: 
		/// All of the parameters except GL_CURRENT_VERTEX_ATTRIB represent state stored in the currently bound vertex array object. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if pname is not GL_CURRENT_VERTEX_ATTRIB and there is no currently bound vertex array 
		///   object.
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_OPERATION is generated if index is 0 and pname is GL_CURRENT_VERTEX_ATTRIB. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_ATTRIBS 
		/// - glGetVertexAttribPointerv with arguments index and GL_VERTEX_ATTRIB_ARRAY_POINTER 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void GetVertexAttribI(UInt32 index, int pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					if        (Delegates.pglGetVertexAttribIuiv != null) {
						Delegates.pglGetVertexAttribIuiv(index, pname, p_params);
						CallLog("glGetVertexAttribIuiv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribIuivEXT != null) {
						Delegates.pglGetVertexAttribIuivEXT(index, pname, p_params);
						CallLog("glGetVertexAttribIuivEXT({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI1(UInt32 index, Int32 x)
		{
			if        (Delegates.pglVertexAttribI1i != null) {
				Delegates.pglVertexAttribI1i(index, x);
				CallLog("glVertexAttribI1i({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttribI1iEXT != null) {
				Delegates.pglVertexAttribI1iEXT(index, x);
				CallLog("glVertexAttribI1iEXT({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttribI1i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI2(UInt32 index, Int32 x, Int32 y)
		{
			if        (Delegates.pglVertexAttribI2i != null) {
				Delegates.pglVertexAttribI2i(index, x, y);
				CallLog("glVertexAttribI2i({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttribI2iEXT != null) {
				Delegates.pglVertexAttribI2iEXT(index, x, y);
				CallLog("glVertexAttribI2iEXT({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttribI2i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI3(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			if        (Delegates.pglVertexAttribI3i != null) {
				Delegates.pglVertexAttribI3i(index, x, y, z);
				CallLog("glVertexAttribI3i({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttribI3iEXT != null) {
				Delegates.pglVertexAttribI3iEXT(index, x, y, z);
				CallLog("glVertexAttribI3iEXT({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttribI3i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			if        (Delegates.pglVertexAttribI4i != null) {
				Delegates.pglVertexAttribI4i(index, x, y, z, w);
				CallLog("glVertexAttribI4i({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttribI4iEXT != null) {
				Delegates.pglVertexAttribI4iEXT(index, x, y, z, w);
				CallLog("glVertexAttribI4iEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttribI4i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI1(UInt32 index, UInt32 x)
		{
			if        (Delegates.pglVertexAttribI1ui != null) {
				Delegates.pglVertexAttribI1ui(index, x);
				CallLog("glVertexAttribI1ui({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttribI1uiEXT != null) {
				Delegates.pglVertexAttribI1uiEXT(index, x);
				CallLog("glVertexAttribI1uiEXT({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttribI1ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI2(UInt32 index, UInt32 x, UInt32 y)
		{
			if        (Delegates.pglVertexAttribI2ui != null) {
				Delegates.pglVertexAttribI2ui(index, x, y);
				CallLog("glVertexAttribI2ui({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttribI2uiEXT != null) {
				Delegates.pglVertexAttribI2uiEXT(index, x, y);
				CallLog("glVertexAttribI2uiEXT({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttribI2ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI3(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			if        (Delegates.pglVertexAttribI3ui != null) {
				Delegates.pglVertexAttribI3ui(index, x, y, z);
				CallLog("glVertexAttribI3ui({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttribI3uiEXT != null) {
				Delegates.pglVertexAttribI3uiEXT(index, x, y, z);
				CallLog("glVertexAttribI3uiEXT({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttribI3ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			if        (Delegates.pglVertexAttribI4ui != null) {
				Delegates.pglVertexAttribI4ui(index, x, y, z, w);
				CallLog("glVertexAttribI4ui({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttribI4uiEXT != null) {
				Delegates.pglVertexAttribI4uiEXT(index, x, y, z, w);
				CallLog("glVertexAttribI4uiEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttribI4ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI1(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI1iv != null) {
						Delegates.pglVertexAttribI1iv(index, p_v);
						CallLog("glVertexAttribI1iv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI1ivEXT != null) {
						Delegates.pglVertexAttribI1ivEXT(index, p_v);
						CallLog("glVertexAttribI1ivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI1iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI2(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI2iv != null) {
						Delegates.pglVertexAttribI2iv(index, p_v);
						CallLog("glVertexAttribI2iv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI2ivEXT != null) {
						Delegates.pglVertexAttribI2ivEXT(index, p_v);
						CallLog("glVertexAttribI2ivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI2iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI3(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI3iv != null) {
						Delegates.pglVertexAttribI3iv(index, p_v);
						CallLog("glVertexAttribI3iv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI3ivEXT != null) {
						Delegates.pglVertexAttribI3ivEXT(index, p_v);
						CallLog("glVertexAttribI3ivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4iv != null) {
						Delegates.pglVertexAttribI4iv(index, p_v);
						CallLog("glVertexAttribI4iv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4ivEXT != null) {
						Delegates.pglVertexAttribI4ivEXT(index, p_v);
						CallLog("glVertexAttribI4ivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI1(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI1uiv != null) {
						Delegates.pglVertexAttribI1uiv(index, p_v);
						CallLog("glVertexAttribI1uiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI1uivEXT != null) {
						Delegates.pglVertexAttribI1uivEXT(index, p_v);
						CallLog("glVertexAttribI1uivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI1uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI2(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI2uiv != null) {
						Delegates.pglVertexAttribI2uiv(index, p_v);
						CallLog("glVertexAttribI2uiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI2uivEXT != null) {
						Delegates.pglVertexAttribI2uivEXT(index, p_v);
						CallLog("glVertexAttribI2uivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI2uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI3(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI3uiv != null) {
						Delegates.pglVertexAttribI3uiv(index, p_v);
						CallLog("glVertexAttribI3uiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI3uivEXT != null) {
						Delegates.pglVertexAttribI3uivEXT(index, p_v);
						CallLog("glVertexAttribI3uivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI3uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4uiv != null) {
						Delegates.pglVertexAttribI4uiv(index, p_v);
						CallLog("glVertexAttribI4uiv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4uivEXT != null) {
						Delegates.pglVertexAttribI4uivEXT(index, p_v);
						CallLog("glVertexAttribI4uivEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4bv != null) {
						Delegates.pglVertexAttribI4bv(index, p_v);
						CallLog("glVertexAttribI4bv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4bvEXT != null) {
						Delegates.pglVertexAttribI4bvEXT(index, p_v);
						CallLog("glVertexAttribI4bvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4bv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4sv != null) {
						Delegates.pglVertexAttribI4sv(index, p_v);
						CallLog("glVertexAttribI4sv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4svEXT != null) {
						Delegates.pglVertexAttribI4svEXT(index, p_v);
						CallLog("glVertexAttribI4svEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4ubv != null) {
						Delegates.pglVertexAttribI4ubv(index, p_v);
						CallLog("glVertexAttribI4ubv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4ubvEXT != null) {
						Delegates.pglVertexAttribI4ubvEXT(index, p_v);
						CallLog("glVertexAttribI4ubvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4ubv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified. 
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// The glVertexAttrib family of entry points allows an application to pass generic vertex attributes in numbered locations. 
		/// Generic attributes are defined as four-component values that are organized into an array. The first entry of this array 
		/// isnumbered 0, and the size of the array is specified by the implementation-dependent constant GL_MAX_VERTEX_ATTRIBS. 
		/// Individualelements of this array can be modified with a glVertexAttrib call that specifies the index of the element to 
		/// bemodified and a value for that element. 
		/// These commands can be used to specify one, two, three, or all four components of the generic vertex attribute specified 
		/// byindex. A 1 in the name of the command indicates that only one value is passed, and it will be used to modify the first 
		/// componentof the generic vertex attribute. The second and third components will be set to 0, and the fourth component 
		/// willbe set to 1. Similarly, a 2 in the name of the command indicates that values are provided for the first two 
		/// components,the third component will be set to 0, and the fourth component will be set to 1. A 3 in the name of the 
		/// commandindicates that values are provided for the first three components and the fourth component will be set to 1, 
		/// whereasa 4 in the name indicates that values are provided for all four components. 
		/// The letters s, f, i, d, ub, us, and ui indicate whether the arguments are of type short, float, int, double, unsigned 
		/// byte,unsigned short, or unsigned int. When v is appended to the name, the commands can take a pointer to an array of 
		/// suchvalues. 
		/// Additional capitalized letters can indicate further alterations to the default behavior of the glVertexAttrib function: 
		/// The commands containing N indicate that the arguments will be passed as fixed-point values that are scaled to a 
		/// normalizedrange according to the component conversion rules defined by the OpenGL specification. Signed values are 
		/// understoodto represent fixed-point values in the range [-1,1], and unsigned values are understood to represent 
		/// fixed-pointvalues in the range [0,1]. 
		/// The commands containing I indicate that the arguments are extended to full signed or unsigned integers. 
		/// The commands containing P indicate that the arguments are stored as packed components within a larger natural type. 
		/// The commands containing L indicate that the arguments are full 64-bit quantities and should be passed directly to shader 
		/// inputsdeclared as 64-bit double precision types. 
		/// OpenGL Shading Language attribute variables are allowed to be of type mat2, mat3, or mat4. Attributes of these types may 
		/// beloaded using the glVertexAttrib entry points. Matrices must be loaded into successive generic attribute slots in 
		/// columnmajor order, with one column of the matrix in each generic attribute slot. 
		/// A user-defined attribute variable declared in a vertex shader can be bound to a generic attribute index by calling 
		/// glBindAttribLocation.This allows an application to use more descriptive variable names in a vertex shader. A subsequent 
		/// changeto the specified generic vertex attribute will be immediately reflected as a change to the corresponding attribute 
		/// variablein the vertex shader. 
		/// The binding between a generic vertex attribute index and a user-defined attribute variable in a vertex shader is part of 
		/// thestate of a program object, but the current value of the generic vertex attribute is not. The value of each generic 
		/// vertexattribute is part of current state, just like standard vertex attributes, and it is maintained even if a different 
		/// programobject is used. 
		/// An application may freely modify generic vertex attributes that are not bound to a named vertex shader attribute 
		/// variable.These values are simply maintained as part of current state and will not be accessed by the vertex shader. If a 
		/// genericvertex attribute bound to an attribute variable in a vertex shader is not updated while the vertex shader is 
		/// executing,the vertex shader will repeatedly use the current value for the generic vertex attribute. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if index is greater than or equal to GL_MAX_VERTEX_ATTRIBS. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribP* is used with a type other than GL_INT_2_10_10_10_REV, 
		///   GL_UNSIGNED_INT_2_10_10_10_REV,or GL_UNSIGNED_INT_10F_11F_11F_REV. 
		/// - GL_INVALID_ENUM is generated if glVertexAttribL is used with a type other than GL_DOUBLE. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveAttrib with argument program and the index of an active attribute variable 
		/// - glGetAttribLocation with argument program and an attribute variable name 
		/// - glGetVertexAttrib with arguments GL_CURRENT_VERTEX_ATTRIB and index 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void VertexAttribI4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					if        (Delegates.pglVertexAttribI4usv != null) {
						Delegates.pglVertexAttribI4usv(index, p_v);
						CallLog("glVertexAttribI4usv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribI4usvEXT != null) {
						Delegates.pglVertexAttribI4usvEXT(index, p_v);
						CallLog("glVertexAttribI4usvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribI4usv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried. 
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetUniform and glGetnUniform return in params the value(s) of the specified uniform variable. The type of the uniform 
		/// variablespecified by location determines the number of values returned. If the uniform variable is defined in the shader 
		/// asa boolean, int, or float, a single value will be returned. If it is defined as a vec2, ivec2, or bvec2, two values 
		/// willbe returned. If it is defined as a vec3, ivec3, or bvec3, three values will be returned, and so on. To query values 
		/// storedin uniform variables declared as arrays, call glGetUniform for each element of the array. To query values stored 
		/// inuniform variables declared as structures, call glGetUniform for each field in the structure. The values for uniform 
		/// variablesdeclared as a matrix will be returned in column major order. 
		/// The locations assigned to uniform variables are not known until the program object is linked. After linking has 
		/// occurred,the command glGetUniformLocation can be used to obtain the location of a uniform variable. This location value 
		/// canthen be passed to glGetUniform or glGetnUniform in order to query the current value of the uniform variable. After a 
		/// programobject has been linked successfully, the index values for uniform variables remain fixed until the next link 
		/// commandoccurs. The uniform variable values can only be queried after a link if the link was successful. 
		/// The only difference between glGetUniform and glGetnUniform is that glGetnUniform will generate an error if size of the 
		/// paramsbuffer,as described by bufSize, is not large enough to hold the result data. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL. 
		/// - GL_INVALID_OPERATION is generated if program is not a program object. 
		/// - GL_INVALID_OPERATION is generated if program has not been successfully linked. 
		/// - GL_INVALID_OPERATION is generated if location does not correspond to a valid uniform variable location for the specified 
		///   programobject. 
		/// - GL_INVALID_OPERATION is generated by glGetnUniform if the buffer size required to store the requested data is greater 
		///   thanbufSize. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniform with arguments program and the index of an active uniform variable 
		/// - glGetProgram with arguments program and GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH 
		/// - glGetUniformLocation with arguments program and the name of a uniform variable 
		/// - glIsProgram 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		public static void GetUniform(UInt32 program, Int32 location, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetUniformuiv != null) {
						Delegates.pglGetUniformuiv(program, location, p_params);
						CallLog("glGetUniformuiv({0}, {1}, {2})", program, location, @params);
					} else if (Delegates.pglGetUniformuivEXT != null) {
						Delegates.pglGetUniformuivEXT(program, location, p_params);
						CallLog("glGetUniformuivEXT({0}, {1}, {2})", program, location, @params);
					} else
						throw new NotImplementedException("glGetUniformuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a user-defined varying out variable to a fragment shader color number
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to modify 
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to modify 
		/// </param>
		/// <remarks>
		/// glBindFragDataLocation explicitly specifies the binding of the user-defined varying out variable name to fragment shader 
		/// colornumber colorNumber for program program. If name was bound previously, its assigned binding is replaced with 
		/// colorNumber.name must be a null-terminated string. colorNumber must be less than GL_MAX_DRAW_BUFFERS. 
		/// The bindings specified by glBindFragDataLocation have no effect until program is next linked. Bindings may be specified 
		/// atany time after program has been created. Specifically, they may be specified before shader objects are attached to the 
		/// program.Therefore, any name may be specified in name, including a name that is never used as a varying out variable in 
		/// anyfragment shader object. Names beginning with gl_ are reserved by the GL. 
		/// In addition to the errors generated by glBindFragDataLocation, the program program will fail to link if: The number of 
		/// activeoutputs is greater than the value GL_MAX_DRAW_BUFFERS. More than one varying out variable is bound to the same 
		/// colornumber. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if colorNumber is greater than or equal to GL_MAX_DRAW_BUFFERS. 
		/// - GL_INVALID_OPERATION is generated if name starts with the reserved gl_ prefix. 
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetFragDataLocation with a valid program object and the the name of a user-defined varying out variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.GetFragDataLocation"/>
		public static void BindFragDataLocation(UInt32 program, UInt32 color, String name)
		{
			if        (Delegates.pglBindFragDataLocation != null) {
				Delegates.pglBindFragDataLocation(program, color, name);
				CallLog("glBindFragDataLocation({0}, {1}, {2})", program, color, name);
			} else if (Delegates.pglBindFragDataLocationEXT != null) {
				Delegates.pglBindFragDataLocationEXT(program, color, name);
				CallLog("glBindFragDataLocationEXT({0}, {1}, {2})", program, color, name);
			} else
				throw new NotImplementedException("glBindFragDataLocation (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// query the bindings of color numbers to user-defined varying out variables
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to query 
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to query 
		/// </param>
		/// <remarks>
		/// glGetFragDataLocation retrieves the assigned color number binding for the user-defined varying out variable name for 
		/// programprogram. program must have previously been linked. name must be a null-terminated string. If name is not the name 
		/// ofan active user-defined varying out fragment shader variable within program, -1 will be returned. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.BindFragDataLocation"/>
		public static Int32 GetFragDataLocation(UInt32 program, String name)
		{
			Int32 retValue;

			if        (Delegates.pglGetFragDataLocation != null) {
				retValue = Delegates.pglGetFragDataLocation(program, name);
				CallLog("glGetFragDataLocation({0}, {1}) = {2}", program, name, retValue);
			} else if (Delegates.pglGetFragDataLocationEXT != null) {
				retValue = Delegates.pglGetFragDataLocationEXT(program, name);
				CallLog("glGetFragDataLocationEXT({0}, {1}) = {2}", program, name, retValue);
			} else
				throw new NotImplementedException("glGetFragDataLocation (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform1(Int32 location, UInt32 v0)
		{
			if        (Delegates.pglUniform1ui != null) {
				Delegates.pglUniform1ui(location, v0);
				CallLog("glUniform1ui({0}, {1})", location, v0);
			} else if (Delegates.pglUniform1uiEXT != null) {
				Delegates.pglUniform1uiEXT(location, v0);
				CallLog("glUniform1uiEXT({0}, {1})", location, v0);
			} else
				throw new NotImplementedException("glUniform1ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform2(Int32 location, UInt32 v0, UInt32 v1)
		{
			if        (Delegates.pglUniform2ui != null) {
				Delegates.pglUniform2ui(location, v0, v1);
				CallLog("glUniform2ui({0}, {1}, {2})", location, v0, v1);
			} else if (Delegates.pglUniform2uiEXT != null) {
				Delegates.pglUniform2uiEXT(location, v0, v1);
				CallLog("glUniform2uiEXT({0}, {1}, {2})", location, v0, v1);
			} else
				throw new NotImplementedException("glUniform2ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform3(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			if        (Delegates.pglUniform3ui != null) {
				Delegates.pglUniform3ui(location, v0, v1, v2);
				CallLog("glUniform3ui({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else if (Delegates.pglUniform3uiEXT != null) {
				Delegates.pglUniform3uiEXT(location, v0, v1, v2);
				CallLog("glUniform3uiEXT({0}, {1}, {2}, {3})", location, v0, v1, v2);
			} else
				throw new NotImplementedException("glUniform3ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform4(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			if        (Delegates.pglUniform4ui != null) {
				Delegates.pglUniform4ui(location, v0, v1, v2, v3);
				CallLog("glUniform4ui({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else if (Delegates.pglUniform4uiEXT != null) {
				Delegates.pglUniform4uiEXT(location, v0, v1, v2, v3);
				CallLog("glUniform4uiEXT({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glUniform4ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeteduniform variable is not an array, and 1 or more if it is an array. 
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specifieduniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform1(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglUniform1uiv != null) {
						Delegates.pglUniform1uiv(location, count, p_value);
						CallLog("glUniform1uiv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform1uivEXT != null) {
						Delegates.pglUniform1uivEXT(location, count, p_value);
						CallLog("glUniform1uivEXT({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform1uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeteduniform variable is not an array, and 1 or more if it is an array. 
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specifieduniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform2(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglUniform2uiv != null) {
						Delegates.pglUniform2uiv(location, count, p_value);
						CallLog("glUniform2uiv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform2uivEXT != null) {
						Delegates.pglUniform2uivEXT(location, count, p_value);
						CallLog("glUniform2uivEXT({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform2uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeteduniform variable is not an array, and 1 or more if it is an array. 
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specifieduniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform3(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglUniform3uiv != null) {
						Delegates.pglUniform3uiv(location, count, p_value);
						CallLog("glUniform3uiv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform3uivEXT != null) {
						Delegates.pglUniform3uivEXT(location, count, p_value);
						CallLog("glUniform3uivEXT({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform3uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified. 
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeteduniform variable is not an array, and 1 or more if it is an array. 
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specifieduniform variable. 
		/// </param>
		/// <remarks>
		/// glUniform modifies the value of a uniform variable or a uniform variable array. The location of the uniform variable to 
		/// bemodified is specified by location, which should be a value returned by glGetUniformLocation. glUniform operates on the 
		/// programobject that was made part of current state by calling glUseProgram. 
		/// The commands glUniform{1|2|3|4}{f|i|ui} are used to change the value of the uniform variable specified by location using 
		/// thevalues passed as arguments. The number specified in the command should match the number of components in the data 
		/// typeof the specified uniform variable (e.g., 1 for float, int, unsigned int, bool; 2 for vec2, ivec2, uvec2, bvec2, 
		/// etc.).The suffix f indicates that floating-point values are being passed; the suffix i indicates that integer values are 
		/// beingpassed; the suffix ui indicates that unsigned integer values are being passed, and this type should also match the 
		/// datatype of the specified uniform variable. The i variants of this function should be used to provide values for uniform 
		/// variablesdefined as int, ivec2, ivec3, ivec4, or arrays of these. The ui variants of this function should be used to 
		/// providevalues for uniform variables defined as unsigned int, uvec2, uvec3, uvec4, or arrays of these. The f variants 
		/// shouldbe used to provide values for uniform variables of type float, vec2, vec3, vec4, or arrays of these. Either the i, 
		/// uior f variants may be used to provide values for uniform variables of type bool, bvec2, bvec3, bvec4, or arrays of 
		/// these.The uniform variable will be set to false if the input value is 0 or 0.0f, and it will be set to true otherwise. 
		/// All active uniform variables defined in a program object are initialized to 0 when the program object is linked 
		/// successfully.They retain the values assigned to them by a call to glUniform until the next successful link operation 
		/// occurson the program object, when they are once again initialized to 0. 
		/// The commands glUniform{1|2|3|4}{f|i|ui}v can be used to modify a single uniform variable or a uniform variable array. 
		/// Thesecommands pass a count and a pointer to the values to be loaded into a uniform variable or a uniform variable array. 
		/// Acount of 1 should be used if modifying the value of a single uniform variable, and a count of 1 or greater can be used 
		/// tomodify an entire array or part of an array. When loading n elements starting at an arbitrary position m in a uniform 
		/// variablearray, elements m + n - 1 in the array will be replaced with the new values. If m + n - 1 is larger than the 
		/// sizeof the uniform variable array, values for all array elements beyond the end of the array will be ignored. The number 
		/// specifiedin the name of the command indicates the number of components for each element in value, and it should match 
		/// thenumber of components in the data type of the specified uniform variable (e.g., 1 for float, int, bool; 2 for vec2, 
		/// ivec2,bvec2, etc.). The data type specified in the name of the command must match the data type for the specified 
		/// uniformvariable as described previously for glUniform{1|2|3|4}{f|i|ui}. 
		/// For uniform variable arrays, each element of the array is considered to be of the type indicated in the name of the 
		/// command(e.g., glUniform3f or glUniform3fv can be used to load a uniform variable array of type vec3). The number of 
		/// elementsof the uniform variable array to be modified is specified by count 
		/// The commands glUniformMatrix{2|3|4|2x3|3x2|2x4|4x2|3x4|4x3}fv are used to modify a matrix or an array of matrices. The 
		/// numbersin the command name are interpreted as the dimensionality of the matrix. The number 2 indicates a 2 × 2 matrix 
		/// (i.e.,4 values), the number 3 indicates a 3 × 3 matrix (i.e., 9 values), and the number 4 indicates a 4 × 4 matrix 
		/// (i.e.,16 values). Non-square matrix dimensionality is explicit, with the first number representing the number of columns 
		/// andthe second number representing the number of rows. For example, 2x4 indicates a 2 × 4 matrix with 2 columns and 4 
		/// rows(i.e., 8 values). If transpose is GL_FALSE, each matrix is assumed to be supplied in column major order. If 
		/// transposeis GL_TRUE, each matrix is assumed to be supplied in row major order. The count argument indicates the number 
		/// ofmatrices to be passed. A count of 1 should be used if modifying the value of a single matrix, and a count greater than 
		/// 1can be used to modify an array of matrices. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if there is no current program object. 
		/// - GL_INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		///   indicatedby the glUniform command. 
		/// - GL_INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		///   uniformvariable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		///   functionis used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		///   arrayof these. 
		/// - GL_INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		///   variableof type unsigned int, uvec2, uvec3, uvec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		///   variableof type int, ivec2, ivec3, ivec4, or an array of these. 
		/// - GL_INVALID_OPERATION is generated if location is an invalid uniform location for the current program object and location 
		///   isnot equal to -1. 
		/// - GL_INVALID_VALUE is generated if count is less than 0. 
		/// - GL_INVALID_OPERATION is generated if count is greater than 1 and the indicated uniform variable is not an array 
		///   variable.
		/// - GL_INVALID_OPERATION is generated if a sampler is loaded using a command other than glUniform1i and glUniform1iv. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with the argument GL_CURRENT_PROGRAM 
		/// - glGetActiveUniform with the handle of a program object and the index of an active uniform variable 
		/// - glGetUniform with the handle of a program object and the location of a uniform variable 
		/// - glGetUniformLocation with the handle of a program object and the name of a uniform variable 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void Uniform4(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglUniform4uiv != null) {
						Delegates.pglUniform4uiv(location, count, p_value);
						CallLog("glUniform4uiv({0}, {1}, {2})", location, count, value);
					} else if (Delegates.pglUniform4uivEXT != null) {
						Delegates.pglUniform4uivEXT(location, count, p_value);
						CallLog("glUniform4uivEXT({0}, {1}, {2})", location, count, value);
					} else
						throw new NotImplementedException("glUniform4uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TexParameterIiv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglTexParameterIiv != null) {
						Delegates.pglTexParameterIiv(target, pname, p_params);
						CallLog("glTexParameterIiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIivEXT != null) {
						Delegates.pglTexParameterIivEXT(target, pname, p_params);
						CallLog("glTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIivOES != null) {
						Delegates.pglTexParameterIivOES(target, pname, p_params);
						CallLog("glTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glTexParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglTexParameterIiv != null) {
						Delegates.pglTexParameterIiv((int)target, (int)pname, p_params);
						CallLog("glTexParameterIiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIivEXT != null) {
						Delegates.pglTexParameterIivEXT((int)target, (int)pname, p_params);
						CallLog("glTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIivOES != null) {
						Delegates.pglTexParameterIivOES((int)target, (int)pname, p_params);
						CallLog("glTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glTexParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void TexParameterIuiv(int target, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglTexParameterIuiv != null) {
						Delegates.pglTexParameterIuiv(target, pname, p_params);
						CallLog("glTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIuivEXT != null) {
						Delegates.pglTexParameterIuivEXT(target, pname, p_params);
						CallLog("glTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIuivOES != null) {
						Delegates.pglTexParameterIuivOES(target, pname, p_params);
						CallLog("glTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glTexParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglTexParameterIuiv != null) {
						Delegates.pglTexParameterIuiv((int)target, (int)pname, p_params);
						CallLog("glTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIuivEXT != null) {
						Delegates.pglTexParameterIuivEXT((int)target, (int)pname, p_params);
						CallLog("glTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglTexParameterIuivOES != null) {
						Delegates.pglTexParameterIuivOES((int)target, (int)pname, p_params);
						CallLog("glTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glTexParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameterIiv(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetTexParameterIiv != null) {
						Delegates.pglGetTexParameterIiv(target, pname, p_params);
						CallLog("glGetTexParameterIiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIivEXT != null) {
						Delegates.pglGetTexParameterIivEXT(target, pname, p_params);
						CallLog("glGetTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIivOES != null) {
						Delegates.pglGetTexParameterIivOES(target, pname, p_params);
						CallLog("glGetTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetTexParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetTexParameterIiv != null) {
						Delegates.pglGetTexParameterIiv((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIivEXT != null) {
						Delegates.pglGetTexParameterIivEXT((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIivOES != null) {
						Delegates.pglGetTexParameterIivOES((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetTexParameterIiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameterIuiv(int target, int pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetTexParameterIuiv != null) {
						Delegates.pglGetTexParameterIuiv(target, pname, p_params);
						CallLog("glGetTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIuivEXT != null) {
						Delegates.pglGetTexParameterIuivEXT(target, pname, p_params);
						CallLog("glGetTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIuivOES != null) {
						Delegates.pglGetTexParameterIuivOES(target, pname, p_params);
						CallLog("glGetTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetTexParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// andglGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE,GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, and 
		/// GL_TEXTURE_CUBE_MAP_ARRAYare accepted. 
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL,GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT,GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL,GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G,GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER,GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S,GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetTexParameter and glGetTextureParameter return in params the value or values of the texture parameter specified as 
		/// pname.target defines the target texture. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D_ARRAY,GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_2D_MULTISAMPLE, or 
		/// GL_TEXTURE_2D_MULTISAMPLE_ARRAYspecify one-, two-, or three-dimensional, one-dimensional array, two-dimensional array, 
		/// rectangle,cube-mapped or cube-mapped array, two-dimensional multisample, or two-dimensional multisample array texturing, 
		/// respectively.pname accepts the same symbols as glTexParameter, with the same interpretations: 
		/// In addition to the parameters that may be set with glTexParameter, glGetTexParameter and glGetTextureParameter accept 
		/// thefollowing read-only parameters: 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if pname is not an accepted value. 
		/// - GL_INVALID_ENUM error is generated by glGetTexParameter if the effective target is not one of the accepted texture 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetTextureParameter* if texture is not the name of an existing texture object. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TextureParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureStorage1D"/>
		/// <seealso cref="Gl.TextureStorage2D"/>
		/// <seealso cref="Gl.TextureStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					if        (Delegates.pglGetTexParameterIuiv != null) {
						Delegates.pglGetTexParameterIuiv((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIuivEXT != null) {
						Delegates.pglGetTexParameterIuivEXT((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetTexParameterIuivOES != null) {
						Delegates.pglGetTexParameterIuivOES((int)target, (int)pname, p_params);
						CallLog("glGetTexParameterIuivOES({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetTexParameterIuiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear. 
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear. 
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to. 
		/// </param>
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearBuffer(int buffer, Int32 drawbuffer, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferiv != null, "pglClearBufferiv not implemented");
					Delegates.pglClearBufferiv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferiv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear. 
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear. 
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to. 
		/// </param>
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearBuffer(int buffer, Int32 drawbuffer, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferuiv != null, "pglClearBufferuiv not implemented");
					Delegates.pglClearBufferuiv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferuiv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear. 
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear. 
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to. 
		/// </param>
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearBuffer(int buffer, Int32 drawbuffer, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferfv != null, "pglClearBufferfv not implemented");
					Delegates.pglClearBufferfv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferfv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear. 
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear. 
		/// </param>
		/// <param name="depth">
		/// The value to clear the depth buffer to. 
		/// </param>
		/// <param name="stencil">
		/// The value to clear the stencil buffer to. 
		/// </param>
		/// <remarks>
		/// These commands clear a specified buffer of a framebuffer to specified value(s). For glClearBuffer*, the framebuffer is 
		/// thecurrently bound draw framebuffer object. For glClearNamedFramebuffer*, framebuffer is zero, indicating the default 
		/// drawframebuffer, or the name of a framebuffer object. 
		/// buffer and drawbuffer identify the buffer to clear. 
		/// If buffer is GL_COLOR, a particular draw buffer GL_DRAW_BUFFERi is specified by passing i as drawbuffer, and value 
		/// pointsto a four-element vector specifying the R, G, B and A color to clear that draw buffer to. If the value of 
		/// GL_DRAW_BUFFERiis GL_NONE, the command has no effect. Otherwise, the value of GL_DRAW_BUFFERi identifies one or more 
		/// colorbuffers, each of which is cleared to the same value. Clamping and type conversion for fixed-point color buffers are 
		/// performedin the same fashion as for glClearColor. The *fv, *iv and *uiv forms of these commands should be used to clear 
		/// fixed-and floating-point, signed integer, and unsigned integer color buffers respectively. 
		/// If buffer is GL_DEPTH, drawbuffer must be zero, and value points to a single value to clear the depth buffer to. 
		/// Clampingand type conversion for fixed-point depth buffers are performed in the same fashion as for glClearDepth. Only 
		/// the*fv forms of these commands should be used to clear depth buffers; other forms do not accept a buffer of GL_DEPTH. 
		/// If buffer is GL_STENCIL, drawbuffer must be zero, and value points to a single value to clear the stencil buffer to. 
		/// Maskingis performed in the same fashion as for glClearStencil. Only the *iv forms of these commands should be used to 
		/// clearstencil buffers; be used to clear stencil buffers; other forms do not accept a buffer of GL_STENCIL. 
		/// glClearBufferfi and glClearNamedFramebufferfi are used to clear the depth and stencil buffers simultaneously. buffer 
		/// mustbe GL_DEPTH_STENCIL and drawbuffer must be zero. depth and stencil are the values to clear the depth and stencil 
		/// buffersto, respectively. Clamping and type conversion of depth for fixed-point depth buffers are performed in the same 
		/// fashionas for glClearDepth. Masking of stencil for stencil buffers is performed in the same fashion as for 
		/// glClearStencil.These commands are equivalent to clearing the depth and stencil buffers separately, but may be faster 
		/// whena buffer of internal format GL_DEPTH_STENCIL is being cleared. The same per-fragment and masking operations defined 
		/// forglClear are applied. 
		/// The result of these commands is undefined if no conversion between the type of the specified value and the type of the 
		/// bufferbeing cleared is defined (for example, if glClearBufferiv is called for a fixed- or floating-point buffer, or if 
		/// glClearBufferfvis called for a signed or unsigned integer buffer). This is not an error. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glClearNamedFramebuffer* if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated by glClearBufferiv and glClearNamedFramebufferivbuffer is not GL_COLOR or GL_STENCIL. 
		/// - GL_INVALID_ENUM is generated by glClearBufferuiv and glClearNamedFramebufferuivbuffer is not GL_COLOR. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfv and glClearNamedFramebufferfvbuffer is not GL_COLOR or GL_DEPTH. 
		/// - GL_INVALID_ENUM is generated by glClearBufferfi and glClearNamedFramebufferfibuffer is not GL_DEPTH_STENCIL. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_COLORdrawbuffer is negative, or greater than the value of 
		///   GL_MAX_DRAW_BUFFERSminus one. 
		/// - GL_INVALID_VALUE is generated if buffer is GL_DEPTH, GL_STENCIL or GL_DEPTH_STENCIL and drawbuffer is not zero. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ClearColor"/>
		/// <seealso cref="Gl.ClearDepth"/>
		/// <seealso cref="Gl.ClearStencil"/>
		/// <seealso cref="Gl.Clear"/>
		public static void ClearBuffer(int buffer, Int32 drawbuffer, float depth, Int32 stencil)
		{
			Debug.Assert(Delegates.pglClearBufferfi != null, "pglClearBufferfi not implemented");
			Delegates.pglClearBufferfi(buffer, drawbuffer, depth, stencil);
			CallLog("glClearBufferfi({0}, {1}, {2}, {3})", buffer, drawbuffer, depth, stencil);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringiaccepts the GL_EXTENSIONS token. 
		/// </param>
		/// <param name="index">
		/// For glGetStringi, specifies the index of the string to return. 
		/// </param>
		/// <remarks>
		/// glGetString returns a pointer to a static string describing some aspect of the current GL connection. name can be one of 
		/// thefollowing: 
		/// glGetStringi returns a pointer to a static string indexed by index. name can be one of the following: 
		/// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and 
		/// shouldbe used by platform-recognition algorithms. 
		/// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these 
		/// forms:
		/// major_number.minor_numbermajor_number.minor_number.release_number 
		/// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always 
		/// separatesthe version number and the vendor-specific information. 
		/// All strings are null-terminated. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if name is not an accepted value. 
		/// - GL_INVALID_VALUE is generated by glGetStringi if index is outside the valid range for indexed state name. 
		/// </para>
		/// </remarks>
		public static String GetString(int name, UInt32 index)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetStringi != null, "pglGetStringi not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetStringi(name, index));
			CallLog("glGetStringi({0}, {1}) = {2}", name, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// determine if a name corresponds to a renderbuffer object
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies a value that may be the name of a renderbuffer object. 
		/// </param>
		/// <remarks>
		/// glIsRenderbuffer returns GL_TRUE if renderbuffer is currently the name of a renderbuffer object. If renderbuffer is 
		/// zero,or if renderbuffer is not the name of a renderbuffer object, or if an error occurs, glIsRenderbuffer returns 
		/// GL_FALSE.If renderbuffer is a name returned by glGenRenderbuffers, by that has not yet been bound through a call to 
		/// glBindRenderbufferor glFramebufferRenderbuffer, then the name is not a renderbuffer object and glIsRenderbuffer returns 
		/// GL_FALSE.
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static bool IsRenderbuffer(UInt32 renderbuffer)
		{
			bool retValue;

			if        (Delegates.pglIsRenderbuffer != null) {
				retValue = Delegates.pglIsRenderbuffer(renderbuffer);
				CallLog("glIsRenderbuffer({0}) = {1}", renderbuffer, retValue);
			} else if (Delegates.pglIsRenderbufferEXT != null) {
				retValue = Delegates.pglIsRenderbufferEXT(renderbuffer);
				CallLog("glIsRenderbufferEXT({0}) = {1}", renderbuffer, retValue);
			} else
				throw new NotImplementedException("glIsRenderbuffer (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a renderbuffer to a renderbuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER. 
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object to bind. 
		/// </param>
		/// <remarks>
		/// glBindRenderbuffer binds the renderbuffer object with name renderbuffer to the renderbuffer target specified by target. 
		/// targetmust be GL_RENDERBUFFER. renderbuffer is the name of a renderbuffer object previously returned from a call to 
		/// glGenRenderbuffers,or zero to break the existing binding of a renderbuffer object to target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated if renderbuffer is not zero or the name of a renderbuffer previously returned from a 
		///   callto glGenRenderbuffers. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.IsRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		public static void BindRenderbuffer(int target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbuffer != null, "pglBindRenderbuffer not implemented");
			Delegates.pglBindRenderbuffer(target, renderbuffer);
			CallLog("glBindRenderbuffer({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete renderbuffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of renderbuffer objects to be deleted. 
		/// </param>
		/// <param name="renderbuffers">
		/// A pointer to an array containing n renderbuffer objects to be deleted. 
		/// </param>
		/// <remarks>
		/// glDeleteRenderbuffers deletes the n renderbuffer objects whose names are stored in the array addressed by renderbuffers. 
		/// Thename zero is reserved by the GL and is silently ignored, should it occur in renderbuffers, as are other unused names. 
		/// Oncea renderbuffer object is deleted, its name is again unused and it has no contents. If a renderbuffer that is 
		/// currentlybound to the target GL_RENDERBUFFER is deleted, it is as though glBindRenderbuffer had been executed with a 
		/// targetof GL_RENDERBUFFER and a name of zero. 
		/// If a renderbuffer object is attached to one or more attachment points in the currently bound framebuffer, then it as if 
		/// glFramebufferRenderbufferhad been called, with a renderbuffer of zero for each attachment point to which this image was 
		/// attachedin the currently bound framebuffer. In other words, this renderbuffer object is first detached from all 
		/// attachmentponits in the currently bound framebuffer. Note that the renderbuffer image is specifically not detached from 
		/// anynon-bound framebuffers. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		public static void DeleteRenderbuffer(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					if        (Delegates.pglDeleteRenderbuffers != null) {
						Delegates.pglDeleteRenderbuffers(n, p_renderbuffers);
						CallLog("glDeleteRenderbuffers({0}, {1})", n, renderbuffers);
					} else if (Delegates.pglDeleteRenderbuffersEXT != null) {
						Delegates.pglDeleteRenderbuffersEXT(n, p_renderbuffers);
						CallLog("glDeleteRenderbuffersEXT({0}, {1})", n, renderbuffers);
					} else
						throw new NotImplementedException("glDeleteRenderbuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate renderbuffer object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of renderbuffer object names to generate. 
		/// </param>
		/// <param name="renderbuffers">
		/// Specifies an array in which the generated renderbuffer object names are stored. 
		/// </param>
		/// <remarks>
		/// glGenRenderbuffers returns n renderbuffer object names in renderbuffers. There is no guarantee that the names form a 
		/// contiguousset of integers; however, it is guaranteed that none of the returned names was in use immediately before the 
		/// callto glGenRenderbuffers. 
		/// Renderbuffer object names returned by a call to glGenRenderbuffers are not returned by subsequent calls, unless they are 
		/// firstdeleted with glDeleteRenderbuffers. 
		/// The names returned in renderbuffers are marked as used, for the purposes of glGenRenderbuffers only, but they acquire 
		/// stateand type only when they are first bound. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void GenRenderbuffer(Int32 n, UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					if        (Delegates.pglGenRenderbuffers != null) {
						Delegates.pglGenRenderbuffers(n, p_renderbuffers);
						CallLog("glGenRenderbuffers({0}, {1})", n, renderbuffers);
					} else if (Delegates.pglGenRenderbuffersEXT != null) {
						Delegates.pglGenRenderbuffersEXT(n, p_renderbuffers);
						CallLog("glGenRenderbuffersEXT({0}, {1})", n, renderbuffers);
					} else
						throw new NotImplementedException("glGenRenderbuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// establish data storage, format and dimensions of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for glRenderbufferStorage function. Must be GL_RENDERBUFFER. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels. 
		/// </param>
		/// <remarks>
		/// glRenderbufferStorage is equivalent to calling glRenderbufferStorageMultisample with the samples set to zero, and 
		/// glNamedRenderbufferStorageis equivalent to calling glNamedRenderbufferStorageMultisample with the samples set to zero. 
		/// For glRenderbufferStorage, the target of the operation, specified by target must be GL_RENDERBUFFER. For 
		/// glNamedRenderbufferStorage,renderbuffer must be a name of an existing renderbuffer object. internalformat specifies the 
		/// internalformat to be used for the renderbuffer object's storage and must be a color-renderable, depth-renderable, or 
		/// stencil-renderableformat. width and height are the dimensions, in pixels, of the renderbuffer. Both width and height 
		/// mustbe less than or equal to the value of GL_MAX_RENDERBUFFER_SIZE. 
		/// Upon success, glRenderbufferStorage and glNamedRenderbufferStorage delete any existing data store for the renderbuffer 
		/// imageand the contents of the data store after calling glRenderbufferStorage are undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glRenderbufferStorage if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glNamedRenderbufferStorage if renderbuffer is not the name of an existing 
		///   renderbufferobject. 
		/// - GL_INVALID_VALUE is generated if either of width or height is negative, or greater than the value of 
		///   GL_MAX_RENDERBUFFER_SIZE.
		/// - GL_INVALID_ENUM is generated if internalformat is not a color-renderable, depth-renderable, or stencil-renderable 
		///   format.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void RenderbufferStorage(int target, int internalformat, Int32 width, Int32 height)
		{
			if        (Delegates.pglRenderbufferStorage != null) {
				Delegates.pglRenderbufferStorage(target, internalformat, width, height);
				CallLog("glRenderbufferStorage({0}, {1}, {2}, {3})", target, internalformat, width, height);
			} else if (Delegates.pglRenderbufferStorageEXT != null) {
				Delegates.pglRenderbufferStorageEXT(target, internalformat, width, height);
				CallLog("glRenderbufferStorageEXT({0}, {1}, {2}, {3})", target, internalformat, width, height);
			} else
				throw new NotImplementedException("glRenderbufferStorage (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// query a named parameter of a renderbuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the renderbuffer object is bound for glGetRenderbufferParameteriv. target must be 
		/// GL_RENDERBUFFER.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the renderbuffer object to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetRenderbufferParameteriv and glGetNamedRenderbufferParameteriv query parameters of a specified renderbuffer object. 
		/// For glGetRenderbufferParameteriv, the renderbuffer object is that bound to target, which must be GL_RENDERBUFFER. 
		/// For glGetNamedRenderbufferParameteriv, renderbuffer is the name of the renderbuffer object. 
		/// Upon successful return, param will contain the value of the renderbuffer parameter specified by pname, as described 
		/// below.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetRenderbufferParameteriv if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glGetRenderbufferParameteriv if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glGetNamedRenderbufferParameteriv if renderbuffer is not the name of an existing 
		///   renderbufferobject. 
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted parameter names described above. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorageMultisample"/>
		public static void GetRenderbufferParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetRenderbufferParameteriv != null) {
						Delegates.pglGetRenderbufferParameteriv(target, pname, p_params);
						CallLog("glGetRenderbufferParameteriv({0}, {1}, {2})", target, pname, @params);
					} else if (Delegates.pglGetRenderbufferParameterivEXT != null) {
						Delegates.pglGetRenderbufferParameterivEXT(target, pname, p_params);
						CallLog("glGetRenderbufferParameterivEXT({0}, {1}, {2})", target, pname, @params);
					} else
						throw new NotImplementedException("glGetRenderbufferParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies a value that may be the name of a framebuffer object. 
		/// </param>
		/// <remarks>
		/// glIsFramebuffer returns GL_TRUE if framebuffer is currently the name of a framebuffer object. If framebuffer is zero, or 
		/// ifframebuffer is not the name of a framebuffer object, or if an error occurs, glIsFramebuffer returns GL_FALSE. If 
		/// framebufferis a name returned by glGenFramebuffers, by that has not yet been bound through a call to glBindFramebuffer, 
		/// thenthe name is not a framebuffer object and glIsFramebuffer returns GL_FALSE. 
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		public static bool IsFramebuffer(UInt32 framebuffer)
		{
			bool retValue;

			if        (Delegates.pglIsFramebuffer != null) {
				retValue = Delegates.pglIsFramebuffer(framebuffer);
				CallLog("glIsFramebuffer({0}) = {1}", framebuffer, retValue);
			} else if (Delegates.pglIsFramebufferEXT != null) {
				retValue = Delegates.pglIsFramebufferEXT(framebuffer);
				CallLog("glIsFramebufferEXT({0}) = {1}", framebuffer, retValue);
			} else
				throw new NotImplementedException("glIsFramebuffer (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a framebuffer to a framebuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the framebuffer target of the binding operation. 
		/// </param>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object to bind. 
		/// </param>
		/// <remarks>
		/// glBindFramebuffer binds the framebuffer object with name framebuffer to the framebuffer target specified by target. 
		/// targetmust be either GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. If a framebuffer object is bound to 
		/// GL_DRAW_FRAMEBUFFERor GL_READ_FRAMEBUFFER, it becomes the target for rendering or readback operations, respectively, 
		/// untilit is deleted or another framebuffer is bound to the corresponding bind point. Calling glBindFramebuffer with 
		/// targetset to GL_FRAMEBUFFER binds framebuffer to both the read and draw framebuffer targets. framebuffer is the name of 
		/// aframebuffer object previously returned from a call to glGenFramebuffers, or zero to break the existing binding of a 
		/// framebufferobject to target. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. 
		/// - GL_INVALID_OPERATION is generated if framebuffer is not zero or the name of a framebuffer previously returned from a 
		///   callto glGenFramebuffers. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		/// <seealso cref="Gl.FramebufferTextureLayer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.IsFramebuffer"/>
		public static void BindFramebuffer(int target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebuffer != null, "pglBindFramebuffer not implemented");
			Delegates.pglBindFramebuffer(target, framebuffer);
			CallLog("glBindFramebuffer({0}, {1})", target, framebuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete framebuffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of framebuffer objects to be deleted. 
		/// </param>
		/// <param name="framebuffers">
		/// A pointer to an array containing n framebuffer objects to be deleted. 
		/// </param>
		/// <remarks>
		/// glDeleteFramebuffers deletes the n framebuffer objects whose names are stored in the array addressed by framebuffers. 
		/// Thename zero is reserved by the GL and is silently ignored, should it occur in framebuffers, as are other unused names. 
		/// Oncea framebuffer object is deleted, its name is again unused and it has no attachments. If a framebuffer that is 
		/// currentlybound to one or more of the targets GL_DRAW_FRAMEBUFFER or GL_READ_FRAMEBUFFER is deleted, it is as though 
		/// glBindFramebufferhad been executed with the corresponding target and framebuffer zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		public static void DeleteFramebuffers(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					if        (Delegates.pglDeleteFramebuffers != null) {
						Delegates.pglDeleteFramebuffers(n, p_framebuffers);
						CallLog("glDeleteFramebuffers({0}, {1})", n, framebuffers);
					} else if (Delegates.pglDeleteFramebuffersEXT != null) {
						Delegates.pglDeleteFramebuffersEXT(n, p_framebuffers);
						CallLog("glDeleteFramebuffersEXT({0}, {1})", n, framebuffers);
					} else
						throw new NotImplementedException("glDeleteFramebuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate framebuffer object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of framebuffer object names to generate. 
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <remarks>
		/// glGenFramebuffers returns n framebuffer object names in ids. There is no guarantee that the names form a contiguous set 
		/// ofintegers; however, it is guaranteed that none of the returned names was in use immediately before the call to 
		/// glGenFramebuffers.
		/// Framebuffer object names returned by a call to glGenFramebuffers are not returned by subsequent calls, unless they are 
		/// firstdeleted with glDeleteFramebuffers. 
		/// The names returned in ids are marked as used, for the purposes of glGenFramebuffers only, but they acquire state and 
		/// typeonly when they are first bound. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		public static void GenFramebuffers(Int32 n, UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					if        (Delegates.pglGenFramebuffers != null) {
						Delegates.pglGenFramebuffers(n, p_framebuffers);
						CallLog("glGenFramebuffers({0}, {1})", n, framebuffers);
					} else if (Delegates.pglGenFramebuffersEXT != null) {
						Delegates.pglGenFramebuffersEXT(n, p_framebuffers);
						CallLog("glGenFramebuffersEXT({0}, {1})", n, framebuffers);
					} else
						throw new NotImplementedException("glGenFramebuffers (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// check the completeness status of a framebuffer
		/// </summary>
		/// <param name="target">
		/// Specify the target to which the framebuffer is bound for glCheckFramebufferStatus, and the target against which 
		/// framebuffercompleteness of framebuffer is checked for glCheckNamedFramebufferStatus. 
		/// </param>
		/// <remarks>
		/// glCheckFramebufferStatus and glCheckNamedFramebufferStatus return the completeness status of a framebuffer object when 
		/// treatedas a read or draw framebuffer, depending on the value of target. 
		/// For glCheckFramebufferStatus, the framebuffer checked is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glCheckNamedFramebufferStatus, framebuffer is zero or the name of the framebuffer object to check. If framebuffer is 
		/// zero,then the status of the default read or draw framebuffer, as determined by target, is returned. 
		/// The return value is GL_FRAMEBUFFER_COMPLETE if the specified framebuffer is complete. Otherwise, the return value is 
		/// determinedas follows: GL_FRAMEBUFFER_UNDEFINED is returned if the specified framebuffer is the default read or draw 
		/// framebuffer,but the default framebuffer does not exist. GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT is returned if any of the 
		/// framebufferattachment points are framebuffer incomplete. GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT is returned if the 
		/// framebufferdoes not have at least one image attached to it. GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER is returned if the 
		/// valueof GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE for any color attachment point(s) named by GL_DRAW_BUFFERi. 
		/// GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFERis returned if GL_READ_BUFFER is not GL_NONE and the value of 
		/// GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPEis GL_NONE for the color attachment point named by GL_READ_BUFFER. 
		/// GL_FRAMEBUFFER_UNSUPPORTEDis returned if the combination of internal formats of the attached images violates an 
		/// implementation-dependentset of restrictions. GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE is returned if the value of 
		/// GL_RENDERBUFFER_SAMPLESis not the same for all attached renderbuffers; if the value of GL_TEXTURE_SAMPLES is the not 
		/// samefor all attached textures; or, if the attached images are a mix of renderbuffers and textures, the value of 
		/// GL_RENDERBUFFER_SAMPLESdoes not match the value of GL_TEXTURE_SAMPLES. GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE is also 
		/// returnedif the value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS is not the same for all attached textures; or, if the attached 
		/// imagesare a mix of renderbuffers and textures, the value of GL_TEXTURE_FIXED_SAMPLE_LOCATIONS is not GL_TRUE for all 
		/// attachedtextures. GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS is returned if any framebuffer attachment is layered, and any 
		/// populatedattachment is not layered, or if all populated color attachments are not from textures of the same target. 
		/// Additionally, if an error occurs, zero is returned. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if target is not GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glCheckNamedFramebufferStatus if framebuffer is not zero or the name of an existing 
		///   framebufferobject. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		public static int CheckFramebufferStatus(int target)
		{
			int retValue;

			if        (Delegates.pglCheckFramebufferStatus != null) {
				retValue = Delegates.pglCheckFramebufferStatus(target);
				CallLog("glCheckFramebufferStatus({0}) = {1}", target, retValue);
			} else if (Delegates.pglCheckFramebufferStatusEXT != null) {
				retValue = Delegates.pglCheckFramebufferStatusEXT(target);
				CallLog("glCheckFramebufferStatusEXT({0}) = {1}", target, retValue);
			} else
				throw new NotImplementedException("glCheckFramebufferStatus (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expectedin the texture parameter, or for cube map textures, which face is to be attached. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach. 
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach. 
		/// </param>
		/// <remarks>
		/// These commands attach a selected mipmap level or image of a texture object as one of the logical buffers of the 
		/// specifiedframebuffer object. Textures cannot be attached to the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For all commands exceptglNamedFramebufferTexture, the framebuffer object is that bound to target, which must be 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTexture, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, textarget specifies what type of texture 
		/// isnamed by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it 
		/// mustbe the name of an existing texture object with effective target textarget unless it is a cube map texture, in which 
		/// casetextarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_XGL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer 
		/// attachmentpoint named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, 
		/// texturemust be zero or the name of an existing texture with an effective target of textarget, or texture must be the 
		/// nameof an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be 
		/// zero.
		/// If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_3D_TEXTURE_SIZE. 
		/// If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be 
		/// greaterthan or equal to zero and less than or equal to $log_2$ of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. 
		/// For all other values of textarget, level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_TEXTURE_SIZE. 
		/// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture. 
		/// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if 
		/// textureis not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, 
		/// iftexture is not zero, then textarget must be GL_TEXTURE_3D. 
		/// For glFramebufferTexture and glNamedFramebufferTexture, if texture is the name of a three-dimensional, cube map array, 
		/// cubemap, one- or two-dimensional array, or two-dimensional multisample array texture, the specified texture level is an 
		/// arrayof images, and the framebuffer attachment is considered to be layered. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by all commands accepting a target parameter if it is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by all commands accepting a target parameter if zero is bound to that target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_VALUE is generated if texture is not zero or the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture. 
		/// - GL_INVALID_VALUE is generated by glFramebufferTexture3D if texture is not zero and layer is larger than the value of 
		///   GL_MAX_3D_TEXTURE_SIZEminus one. 
		/// - GL_INVALID_OPERATION is generated by all commands accepting a textarget parameter if texture is not zero, and textarget 
		///   andthe effective target of texture are not compatible. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void FramebufferTexture1D(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			if        (Delegates.pglFramebufferTexture1D != null) {
				Delegates.pglFramebufferTexture1D(target, attachment, textarget, texture, level);
				CallLog("glFramebufferTexture1D({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			} else if (Delegates.pglFramebufferTexture1DEXT != null) {
				Delegates.pglFramebufferTexture1DEXT(target, attachment, textarget, texture, level);
				CallLog("glFramebufferTexture1DEXT({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			} else
				throw new NotImplementedException("glFramebufferTexture1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expectedin the texture parameter, or for cube map textures, which face is to be attached. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach. 
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach. 
		/// </param>
		/// <remarks>
		/// These commands attach a selected mipmap level or image of a texture object as one of the logical buffers of the 
		/// specifiedframebuffer object. Textures cannot be attached to the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For all commands exceptglNamedFramebufferTexture, the framebuffer object is that bound to target, which must be 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTexture, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, textarget specifies what type of texture 
		/// isnamed by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it 
		/// mustbe the name of an existing texture object with effective target textarget unless it is a cube map texture, in which 
		/// casetextarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_XGL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer 
		/// attachmentpoint named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, 
		/// texturemust be zero or the name of an existing texture with an effective target of textarget, or texture must be the 
		/// nameof an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be 
		/// zero.
		/// If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_3D_TEXTURE_SIZE. 
		/// If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be 
		/// greaterthan or equal to zero and less than or equal to $log_2$ of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. 
		/// For all other values of textarget, level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_TEXTURE_SIZE. 
		/// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture. 
		/// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if 
		/// textureis not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, 
		/// iftexture is not zero, then textarget must be GL_TEXTURE_3D. 
		/// For glFramebufferTexture and glNamedFramebufferTexture, if texture is the name of a three-dimensional, cube map array, 
		/// cubemap, one- or two-dimensional array, or two-dimensional multisample array texture, the specified texture level is an 
		/// arrayof images, and the framebuffer attachment is considered to be layered. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by all commands accepting a target parameter if it is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by all commands accepting a target parameter if zero is bound to that target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_VALUE is generated if texture is not zero or the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture. 
		/// - GL_INVALID_VALUE is generated by glFramebufferTexture3D if texture is not zero and layer is larger than the value of 
		///   GL_MAX_3D_TEXTURE_SIZEminus one. 
		/// - GL_INVALID_OPERATION is generated by all commands accepting a textarget parameter if texture is not zero, and textarget 
		///   andthe effective target of texture are not compatible. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void FramebufferTexture2D(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			if        (Delegates.pglFramebufferTexture2D != null) {
				Delegates.pglFramebufferTexture2D(target, attachment, textarget, texture, level);
				CallLog("glFramebufferTexture2D({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			} else if (Delegates.pglFramebufferTexture2DEXT != null) {
				Delegates.pglFramebufferTexture2DEXT(target, attachment, textarget, texture, level);
				CallLog("glFramebufferTexture2DEXT({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			} else
				throw new NotImplementedException("glFramebufferTexture2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expectedin the texture parameter, or for cube map textures, which face is to be attached. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach. 
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach. 
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// These commands attach a selected mipmap level or image of a texture object as one of the logical buffers of the 
		/// specifiedframebuffer object. Textures cannot be attached to the default draw and read framebuffer, so they are not valid 
		/// targetsof these commands. 
		/// For all commands exceptglNamedFramebufferTexture, the framebuffer object is that bound to target, which must be 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTexture, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, textarget specifies what type of texture 
		/// isnamed by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it 
		/// mustbe the name of an existing texture object with effective target textarget unless it is a cube map texture, in which 
		/// casetextarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_XGL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer 
		/// attachmentpoint named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, 
		/// texturemust be zero or the name of an existing texture with an effective target of textarget, or texture must be the 
		/// nameof an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be 
		/// zero.
		/// If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_3D_TEXTURE_SIZE. 
		/// If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be 
		/// greaterthan or equal to zero and less than or equal to $log_2$ of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. 
		/// For all other values of textarget, level must be greater than or equal to zero and less than or equal to $log_2$ of the 
		/// valueof GL_MAX_TEXTURE_SIZE. 
		/// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture. 
		/// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if 
		/// textureis not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, 
		/// iftexture is not zero, then textarget must be GL_TEXTURE_3D. 
		/// For glFramebufferTexture and glNamedFramebufferTexture, if texture is the name of a three-dimensional, cube map array, 
		/// cubemap, one- or two-dimensional array, or two-dimensional multisample array texture, the specified texture level is an 
		/// arrayof images, and the framebuffer attachment is considered to be layered. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by all commands accepting a target parameter if it is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by all commands accepting a target parameter if zero is bound to that target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_VALUE is generated if texture is not zero or the name of an existing texture object. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture. 
		/// - GL_INVALID_VALUE is generated by glFramebufferTexture3D if texture is not zero and layer is larger than the value of 
		///   GL_MAX_3D_TEXTURE_SIZEminus one. 
		/// - GL_INVALID_OPERATION is generated by all commands accepting a textarget parameter if texture is not zero, and textarget 
		///   andthe effective target of texture are not compatible. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void FramebufferTexture3D(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			if        (Delegates.pglFramebufferTexture3D != null) {
				Delegates.pglFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
				CallLog("glFramebufferTexture3D({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			} else if (Delegates.pglFramebufferTexture3DEXT != null) {
				Delegates.pglFramebufferTexture3DEXT(target, attachment, textarget, texture, level, zoffset);
				CallLog("glFramebufferTexture3DEXT({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			} else if (Delegates.pglFramebufferTexture3DOES != null) {
				Delegates.pglFramebufferTexture3DOES(target, attachment, textarget, texture, level, zoffset);
				CallLog("glFramebufferTexture3DOES({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			} else
				throw new NotImplementedException("glFramebufferTexture3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for glFramebufferRenderbuffer. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="renderbuffertarget">
		/// Specifies the renderbuffer target. Must be GL_RENDERBUFFER. 
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach. 
		/// </param>
		/// <remarks>
		/// glFramebufferRenderbuffer and glNamedFramebufferRenderbuffer attaches a renderbuffer as one of the logical buffers of 
		/// thespecified framebuffer object. Renderbuffers cannot be attached to the default draw and read framebuffer, so they are 
		/// notvalid targets of these commands. 
		/// For glFramebufferRenderbuffer, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFERor GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferRenderbuffer, framebuffer is the name of the framebuffer object. 
		/// renderbuffertarget must be GL_RENDERBUFFER. 
		/// renderbuffer must be zero or the name of an existing renderbuffer object of type renderbuffertarget. If renderbuffer is 
		/// notzero, then the specified renderbuffer will be used as the logical buffer identified by attachment of the specified 
		/// framebufferobject. If renderbuffer is zero, then the value of renderbuffertarget is ignored. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS 
		/// minusone. Setting attachment to the value GL_DEPTH_STENCIL_ATTACHMENT is a special case causing both the depth and 
		/// stencilattachments of the specified framebuffer object to be set to renderbuffer, which should have the base internal 
		/// formatGL_DEPTH_STENCIL. 
		/// The value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE for the specified attachment point is set to GL_RENDERBUFFER and the 
		/// valueof GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME is set to renderbuffer. All other state values of specified attachment 
		/// pointare set to their default values. No change is made to the state of the renderbuuffer object and any previous 
		/// attachmentto the attachment logical buffer of the specified framebuffer object is broken. 
		/// If renderbuffer is zero, these commands will detach the image, if any, identified by the specified attachment point of 
		/// thespecified framebuffer object. All state values of the attachment point are set to their default values. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferRenderbuffer if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferRenderbuffer if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferRenderbuffer if framebuffer is not the name of an existing 
		///   framebufferobject. 
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_ENUM is generated if renderbuffertarget is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated if renderbuffertarget is not zero or the name of an existing renderbuffer object of 
		///   typeGL_RENDERBUFFER. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTexture1D"/>
		/// <seealso cref="Gl.FramebufferTexture2D"/>
		/// <seealso cref="Gl.FramebufferTexture3D"/>
		public static void FramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			if        (Delegates.pglFramebufferRenderbuffer != null) {
				Delegates.pglFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
				CallLog("glFramebufferRenderbuffer({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			} else if (Delegates.pglFramebufferRenderbufferEXT != null) {
				Delegates.pglFramebufferRenderbufferEXT(target, attachment, renderbuffertarget, renderbuffer);
				CallLog("glFramebufferRenderbufferEXT({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			} else
				throw new NotImplementedException("glFramebufferRenderbuffer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is bound for glGetFramebufferAttachmentParameteriv. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment of the framebuffer object to query. 
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of attachment to query. 
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetFramebufferAttachmentParameteriv and glGetNamedFramebufferAttachmentParameteriv return parameters of attachments of 
		/// aspecified framebuffer object. 
		/// For glGetFramebufferAttachmentParameteriv, the framebuffer object is that bound to target, which must be one of 
		/// GL_DRAW_FRAMEBUFFER,GL_READ_FRAMEBUFFER or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. Buffers 
		/// ofdefault framebuffers may also be queried if bound to target. 
		/// For glGetNamedFramebufferAttachmentParameteriv, framebuffer is the name of the framebuffer object. If framebuffer is 
		/// zero,the default draw framebuffer is queried. 
		/// If the specified framebuffer is a framebuffer object, attachment must be one of GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTGL_DEPTH_STENCIL_ATTACHMENT,or GL_COLOR_ATTACHMENTi, where i is between zero and the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. 
		/// If the specified framebuffer is a default framebuffer, target, attachment must be one of GL_FRONT_LEFT, GL_FRONT_RIGHT, 
		/// GL_BACK_LEFT,GL_BACK_RIGHT, GL_DEPTH or GL_STENCIL, identifying the corresponding buffer. 
		/// If attachment is GL_DEPTH_STENCIL_ATTACHMENT, the same object must be bound to both the depth and stencil attachment 
		/// pointsof the framebuffer object, and information about that object is returned. 
		/// Upon successful return, if pname is GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, then params will contain one of GL_NONE, 
		/// GL_FRAMEBUFFER_DEFAULT,GL_TEXTURE, or GL_RENDERBUFFER, identifying the type of object which contains the attached image. 
		/// Othervalues accepted for pname depend on the type of object, as described below. 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE, then either no framebuffer is bound to target; or a 
		/// defaultframebuffer is queried, attachment is GL_DEPTH or GL_STENCIL, and the number of depth or stencil bits, 
		/// respectively,is zero. In this case querying pnameGL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME will return zero, and all other 
		/// querieswill generate an error. 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is not GL_NONE, these queries apply to all other framebuffer 
		/// types:
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_RENDERBUFFER, then 
		/// If the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_TEXTURE, then 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGetFramebufferAttachmentParameteriv if target is not one of the accepted framebuffer 
		///   targets.
		/// - GL_INVALID_OPERATION is generated by glGetNamedFramebufferAttachmentParameteriv if framebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_ENUM is generated if pname is not valid for the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE, as described 
		///   above.
		/// - GL_INVALID_OPERATION is generated if attachment is not one of the accepted framebuffer attachment points, as described 
		///   above.
		/// - GL_INVALID_OPERATION is generated if the value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE is GL_NONE and pname is not 
		///   GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAMEor GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE. 
		/// - GL_INVALID_OPERATION is generated if attachment is GL_DEPTH_STENCIL_ATTACHMENT and different objects are bound to the 
		///   depthand stencil attachment points of target. 
		/// - GL_INVALID_OPERATION is generated if attachment is GL_DEPTH_STENCIL_ATTACHMENT and pname is 
		///   GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GetFramebufferParameter"/>
		public static void GetFramebufferAttachmentParameter(int target, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					if        (Delegates.pglGetFramebufferAttachmentParameteriv != null) {
						Delegates.pglGetFramebufferAttachmentParameteriv(target, attachment, pname, p_params);
						CallLog("glGetFramebufferAttachmentParameteriv({0}, {1}, {2}, {3})", target, attachment, pname, @params);
					} else if (Delegates.pglGetFramebufferAttachmentParameterivEXT != null) {
						Delegates.pglGetFramebufferAttachmentParameterivEXT(target, attachment, pname, p_params);
						CallLog("glGetFramebufferAttachmentParameterivEXT({0}, {1}, {2}, {3})", target, attachment, pname, @params);
					} else
						throw new NotImplementedException("glGetFramebufferAttachmentParameteriv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate mipmaps for a specified texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for glGenerateMipmap. Must be one of GL_TEXTURE_1D, 
		/// GL_TEXTURE_2D,GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, or 
		/// GL_TEXTURE_CUBE_MAP_ARRAY.
		/// </param>
		/// <remarks>
		/// glGenerateMipmap and glGenerateTextureMipmap generates mipmaps for the specified texture object. For glGenerateMipmap, 
		/// thetexture object is that bound to to target. For glGenerateTextureMipmap, texture is the name of the texture object. 
		/// For cube map and cube map array textures, the texture object must be cube complete or cube array complete respectively. 
		/// Mipmap generation replaces texel image levels $level_{base} + 1$ through $q$ with images derived from the $level_{base}$ 
		/// image,regardless of their previous contents. All other mimap images, including the $level_{base}+1$ image, are left 
		/// unchangedby this computation. 
		/// The internal formats of the derived mipmap images all match those of the $level_{base}$ image. The contents of the 
		/// derivedimages are computed by repeated, filtered reduction of the $level_{base} + 1$ image. For one- and two-dimensional 
		/// arrayand cube map array textures, each layer is filtered independently. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glGenerateMipmap if target is not one of the accepted texture targets. 
		/// - GL_INVALID_OPERATION is generated by glGenerateTextureMipmap if texture is not the name of an existing texture object. 
		/// - GL_INVALID_OPERATION is generated if target is GL_TEXTURE_CUBE_MAP or GL_TEXTURE_CUBE_MAP_ARRAY, and the specified 
		///   textureobject is not cube complete or cube array complete, respectively. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.GenTextures"/>
		public static void GenerateMipmap(int target)
		{
			if        (Delegates.pglGenerateMipmap != null) {
				Delegates.pglGenerateMipmap(target);
				CallLog("glGenerateMipmap({0})", target);
			} else if (Delegates.pglGenerateMipmapEXT != null) {
				Delegates.pglGenerateMipmapEXT(target);
				CallLog("glGenerateMipmapEXT({0})", target);
			} else
				throw new NotImplementedException("glGenerateMipmap (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="srcX0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcY0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcX1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcY1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="dstX0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstY0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstX1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstY1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="mask">
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BITand GL_STENCIL_BUFFER_BIT. 
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR. 
		/// </param>
		/// <remarks>
		/// glBlitFramebuffer and glBlitNamedFramebuffer transfer a rectangle of pixel values from one region of a read framebuffer 
		/// toanother region of a draw framebuffer. 
		/// For glBlitFramebuffer, the read and draw framebuffers are those bound to the GL_READ_FRAMEBUFFER and GL_DRAW_FRAMEBUFFER 
		/// targetsrespectively. 
		/// For glBlitNamedFramebuffer, readFramebuffer and drawFramebuffer are the names of the read read and draw framebuffer 
		/// objectsrespectively. If readFramebuffer or drawFramebuffer is zero, then the default read or draw framebuffer 
		/// respectivelyis used. 
		/// mask is the bitwise OR of a number of values indicating which buffers are to be copied. The values are 
		/// GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. The pixels corresponding to these buffers are copied 
		/// fromthe source rectangle bounded by the locations (srcX0, srcY0) and (srcX1, srcY1) to the destination rectangle bounded 
		/// bythe locations (dstX0, dstY0) and (dstX1, dstY1). The lower bounds of the rectangle are inclusive, while the upper 
		/// boundsare exclusive. 
		/// The actual region taken from the read framebuffer is limited to the intersection of the source buffers being 
		/// transferred,which may include the color buffer selected by the read buffer, the depth buffer, and/or the stencil buffer 
		/// dependingon mask. The actual region written to the draw framebuffer is limited to the intersection of the destination 
		/// buffersbeing written, which may include multiple draw buffers, the depth buffer, and/or the stencil buffer depending on 
		/// mask.Whether or not the source or destination regions are altered due to these limits, the scaling and offset applied to 
		/// pixelsbeing transferred is performed as though no such limits were present. 
		/// If the sizes of the source and destination rectangles are not equal, filter specifies the interpolation method that will 
		/// beapplied to resize the source image , and must be GL_NEAREST or GL_LINEAR. GL_LINEAR is only a valid interpolation 
		/// methodfor the color buffer. If filter is not GL_NEAREST and mask includes GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT, 
		/// nodata is transferred and a GL_INVALID_OPERATION error is generated. 
		/// If filter is GL_LINEAR and the source rectangle would require sampling outside the bounds of the source framebuffer, 
		/// valuesare read as if the GL_CLAMP_TO_EDGE texture wrapping mode were applied. 
		/// When the color buffer is transferred, values are taken from the read buffer of the specified read framebuffer and 
		/// writtento each of the draw buffers of the specified draw framebuffer. 
		/// If the source and destination rectangles overlap or are the same, and the read and draw buffers are the same, the result 
		/// ofthe operation is undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by BlitNamedFramebuffer if readFramebuffer or drawFramebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_OPERATION is generated if mask contains any of the GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and filter is 
		///   notGL_NEAREST. 
		/// - GL_INVALID_OPERATION is generated if mask contains GL_COLOR_BUFFER_BIT and any of the following conditions hold: The 
		///   readbuffer contains fixed-point or floating-point values and any draw buffer contains neither fixed-point nor 
		///   floating-pointvalues. The read buffer contains unsigned integer values and any draw buffer does not contain unsigned 
		///   integervalues. The read buffer contains signed integer values and any draw buffer does not contain signed integer 
		///   values.
		/// - GL_INVALID_OPERATION is generated if mask contains GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and the source and 
		///   destinationdepth and stencil formats do not match. 
		/// - GL_INVALID_OPERATION is generated if filter is GL_LINEAR and the read buffer contains integer data. 
		/// - GL_INVALID_OPERATION is generated if the effective value of GL_SAMPLES for the read and draw framebuffers is not 
		///   identical.
		/// - GL_INVALID_OPERATION is generated if the value of GL_SAMPLE_BUFFERS for both read and draw buffers is greater than zero 
		///   andthe dimensions of the source and destination rectangles is not identical. 
		/// - GL_INVALID_FRAMEBUFFER_OPERATION is generated if the specified read and draw framebuffers are not framebuffer complete. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		public static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			if        (Delegates.pglBlitFramebuffer != null) {
				Delegates.pglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
				CallLog("glBlitFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else if (Delegates.pglBlitFramebufferEXT != null) {
				Delegates.pglBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
				CallLog("glBlitFramebufferEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else if (Delegates.pglBlitFramebufferNV != null) {
				Delegates.pglBlitFramebufferNV(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
				CallLog("glBlitFramebufferNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else
				throw new NotImplementedException("glBlitFramebuffer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="srcX0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcY0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcX1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="srcY1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer. 
		/// </param>
		/// <param name="dstX0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstY0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstX1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="dstY1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer. 
		/// </param>
		/// <param name="mask">
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BITand GL_STENCIL_BUFFER_BIT. 
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR. 
		/// </param>
		/// <remarks>
		/// glBlitFramebuffer and glBlitNamedFramebuffer transfer a rectangle of pixel values from one region of a read framebuffer 
		/// toanother region of a draw framebuffer. 
		/// For glBlitFramebuffer, the read and draw framebuffers are those bound to the GL_READ_FRAMEBUFFER and GL_DRAW_FRAMEBUFFER 
		/// targetsrespectively. 
		/// For glBlitNamedFramebuffer, readFramebuffer and drawFramebuffer are the names of the read read and draw framebuffer 
		/// objectsrespectively. If readFramebuffer or drawFramebuffer is zero, then the default read or draw framebuffer 
		/// respectivelyis used. 
		/// mask is the bitwise OR of a number of values indicating which buffers are to be copied. The values are 
		/// GL_COLOR_BUFFER_BIT,GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT. The pixels corresponding to these buffers are copied 
		/// fromthe source rectangle bounded by the locations (srcX0, srcY0) and (srcX1, srcY1) to the destination rectangle bounded 
		/// bythe locations (dstX0, dstY0) and (dstX1, dstY1). The lower bounds of the rectangle are inclusive, while the upper 
		/// boundsare exclusive. 
		/// The actual region taken from the read framebuffer is limited to the intersection of the source buffers being 
		/// transferred,which may include the color buffer selected by the read buffer, the depth buffer, and/or the stencil buffer 
		/// dependingon mask. The actual region written to the draw framebuffer is limited to the intersection of the destination 
		/// buffersbeing written, which may include multiple draw buffers, the depth buffer, and/or the stencil buffer depending on 
		/// mask.Whether or not the source or destination regions are altered due to these limits, the scaling and offset applied to 
		/// pixelsbeing transferred is performed as though no such limits were present. 
		/// If the sizes of the source and destination rectangles are not equal, filter specifies the interpolation method that will 
		/// beapplied to resize the source image , and must be GL_NEAREST or GL_LINEAR. GL_LINEAR is only a valid interpolation 
		/// methodfor the color buffer. If filter is not GL_NEAREST and mask includes GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT, 
		/// nodata is transferred and a GL_INVALID_OPERATION error is generated. 
		/// If filter is GL_LINEAR and the source rectangle would require sampling outside the bounds of the source framebuffer, 
		/// valuesare read as if the GL_CLAMP_TO_EDGE texture wrapping mode were applied. 
		/// When the color buffer is transferred, values are taken from the read buffer of the specified read framebuffer and 
		/// writtento each of the draw buffers of the specified draw framebuffer. 
		/// If the source and destination rectangles overlap or are the same, and the read and draw buffers are the same, the result 
		/// ofthe operation is undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by BlitNamedFramebuffer if readFramebuffer or drawFramebuffer is not zero or the name 
		///   ofan existing framebuffer object. 
		/// - GL_INVALID_OPERATION is generated if mask contains any of the GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and filter is 
		///   notGL_NEAREST. 
		/// - GL_INVALID_OPERATION is generated if mask contains GL_COLOR_BUFFER_BIT and any of the following conditions hold: The 
		///   readbuffer contains fixed-point or floating-point values and any draw buffer contains neither fixed-point nor 
		///   floating-pointvalues. The read buffer contains unsigned integer values and any draw buffer does not contain unsigned 
		///   integervalues. The read buffer contains signed integer values and any draw buffer does not contain signed integer 
		///   values.
		/// - GL_INVALID_OPERATION is generated if mask contains GL_DEPTH_BUFFER_BIT or GL_STENCIL_BUFFER_BIT and the source and 
		///   destinationdepth and stencil formats do not match. 
		/// - GL_INVALID_OPERATION is generated if filter is GL_LINEAR and the read buffer contains integer data. 
		/// - GL_INVALID_OPERATION is generated if the effective value of GL_SAMPLES for the read and draw framebuffers is not 
		///   identical.
		/// - GL_INVALID_OPERATION is generated if the value of GL_SAMPLE_BUFFERS for both read and draw buffers is greater than zero 
		///   andthe dimensions of the source and destination rectangles is not identical. 
		/// - GL_INVALID_FRAMEBUFFER_OPERATION is generated if the specified read and draw framebuffers are not framebuffer complete. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.CheckFramebufferStatus"/>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.DeleteFramebuffers"/>
		public static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, int filter)
		{
			if        (Delegates.pglBlitFramebuffer != null) {
				Delegates.pglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
				CallLog("glBlitFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else if (Delegates.pglBlitFramebufferEXT != null) {
				Delegates.pglBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
				CallLog("glBlitFramebufferEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else if (Delegates.pglBlitFramebufferNV != null) {
				Delegates.pglBlitFramebufferNV(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
				CallLog("glBlitFramebufferNV({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			} else
				throw new NotImplementedException("glBlitFramebuffer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// establish data storage, format, dimensions and sample count of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for glRenderbufferStorageMultisample function. Must be GL_RENDERBUFFER. 
		/// </param>
		/// <param name="samples">
		/// Specifies the number of samples to be used for the renderbuffer object's storage. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels. 
		/// </param>
		/// <remarks>
		/// glRenderbufferStorageMultisample and glNamedRenderbufferStorageMultisample establish the data storage, format, 
		/// dimensionsand number of samples of a renderbuffer object's image. 
		/// For glRenderbufferStorageMultisample, the target of the operation, specified by target must be GL_RENDERBUFFER. For 
		/// glNamedRenderbufferStorageMultisample,renderbuffer must be an ID of an existing renderbuffer object. internalformat 
		/// specifiesthe internal format to be used for the renderbuffer object's storage and must be a color-renderable, 
		/// depth-renderable,or stencil-renderable format. width and height are the dimensions, in pixels, of the renderbuffer. Both 
		/// widthand height must be less than or equal to the value of GL_MAX_RENDERBUFFER_SIZE. samples specifies the number of 
		/// samplesto be used for the renderbuffer object's image, and must be less than or equal to the value of GL_MAX_SAMPLES. If 
		/// internalformatis a signed or unsigned integer format then samples must be less than or equal to the value of 
		/// GL_MAX_INTEGER_SAMPLES.
		/// Upon success, glRenderbufferStorageMultisample and glNamedRenderbufferStorageMultisample delete any existing data store 
		/// forthe renderbuffer image and the contents of the data store after calling either of the functions are undefined. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glRenderbufferStorageMultisample function if target is not GL_RENDERBUFFER. 
		/// - GL_INVALID_OPERATION is generated by glNamedRenderbufferStorageMultisample function if renderbuffer is not the name of 
		///   anexisting renderbuffer object. 
		/// - GL_INVALID_VALUE is generated if samples is greater than GL_MAX_SAMPLES. 
		/// - GL_INVALID_ENUM is generated if internalformat is not a color-renderable, depth-renderable, or stencil-renderable 
		///   format.
		/// - GL_INVALID_OPERATION is generated if internalformat is a signed or unsigned integer format and samples is greater than 
		///   thevalue of GL_MAX_INTEGER_SAMPLES 
		/// - GL_INVALID_VALUE is generated if either of width or height is negative, or greater than the value of 
		///   GL_MAX_RENDERBUFFER_SIZE.
		/// - GL_OUT_OF_MEMORY is generated if the GL is unable to create a data store of the requested size. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.BindRenderbuffer"/>
		/// <seealso cref="Gl.NamedRenderbufferStorage"/>
		/// <seealso cref="Gl.RenderbufferStorage"/>
		/// <seealso cref="Gl.FramebufferRenderbuffer"/>
		/// <seealso cref="Gl.DeleteRenderbuffers"/>
		public static void RenderbufferStorageMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			if        (Delegates.pglRenderbufferStorageMultisample != null) {
				Delegates.pglRenderbufferStorageMultisample(target, samples, internalformat, width, height);
				CallLog("glRenderbufferStorageMultisample({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			} else if (Delegates.pglRenderbufferStorageMultisampleEXT != null) {
				Delegates.pglRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
				CallLog("glRenderbufferStorageMultisampleEXT({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			} else if (Delegates.pglRenderbufferStorageMultisampleNV != null) {
				Delegates.pglRenderbufferStorageMultisampleNV(target, samples, internalformat, width, height);
				CallLog("glRenderbufferStorageMultisampleNV({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			} else
				throw new NotImplementedException("glRenderbufferStorageMultisample (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for glFramebufferTextureLayer. 
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer. 
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach. 
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach. 
		/// </param>
		/// <param name="layer">
		/// Specifies the layer of the texture object to attach. 
		/// </param>
		/// <remarks>
		/// glFramebufferTextureLayer and glNamedFramebufferTextureLayer attach a single layer of a three-dimensional or array 
		/// textureobject as one of the logical buffers of the specified framebuffer object. Textures cannot be attached to the 
		/// defaultdraw and read framebuffer, so they are not valid targets of these commands. 
		/// For glFramebufferTextureLayer, the framebuffer object is that bound to target, which must be GL_DRAW_FRAMEBUFFER, 
		/// GL_READ_FRAMEBUFFER,or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER. 
		/// For glNamedFramebufferTextureLayer, framebuffer is the name of the framebuffer object. 
		/// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, 
		/// GL_STENCIL_ATTACHMENTor GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of 
		/// GL_MAX_COLOR_ATTACHMENTSminus one. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to 
		/// attachingthat level to both the GL_DEPTH_ATTACHMENTand the GL_STENCIL_ATTACHMENT attachment points simultaneously. 
		/// If texture is not zero, it must be the name of a three-dimensional, two-dimensional multisample array, one- or 
		/// two-dimensionalarray, or cube map array texture. 
		/// If texture is a three-dimensional texture, then level must be greater than or equal to zero and less than or equal to 
		/// $log_2$of the value of GL_MAX_3D_TEXTURE_SIZE. 
		/// If texture is a two-dimensional array texture, then level must be greater than or equal to zero and less than or equal 
		/// to$log_2$ of the value of GL_MAX_TEXTURE_SIZE. 
		/// For cube map textures, layer is translated into a cube map face according to $$ face = k \bmod 6. $$ For cube map array 
		/// textures,layer is translated into an array layer and face according to $$ layer = \left\lfloor { layer \over 6 } 
		/// \right\rfloor$$and $$ face = k \bmod 6. $$ 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFramebufferTexture if target is not one of the accepted framebuffer targets. 
		/// - GL_INVALID_OPERATION is generated by glFramebufferTexture if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glNamedFramebufferTexture if framebuffer is not the name of an existing framebuffer 
		///   object.
		/// - GL_INVALID_ENUM is generated if attachment is not one of the accepted attachment points. 
		/// - GL_INVALID_OPERATION is generated if texture is not zero and is not the name of an existing three-dimensional, 
		///   two-dimensionalmultisample array, one- or two-dimensional array, cube map, or cube map array texture. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and level is not a supported texture level for texture, as 
		///   describedabove. 
		/// - GL_INVALID_VALUE is generated if texture is not zero and layer is larger than the value of GL_MAX_3D_TEXTURE_SIZE minus 
		///   one(for three-dimensional texture objects), or larger than the value of GL_MAX_ARRAY_TEXTURE_LAYERS minus one (for array 
		///   textureobjects). 
		/// - GL_INVALID_VALUE is generated if texture is not zero and layer is negative. 
		/// - GL_INVALID_OPERATION is generated by if texture is a buffer texture. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenFramebuffers"/>
		/// <seealso cref="Gl.BindFramebuffer"/>
		/// <seealso cref="Gl.GenRenderbuffers"/>
		/// <seealso cref="Gl.FramebufferTexture"/>
		/// <seealso cref="Gl.FramebufferTextureFace"/>
		public static void FramebufferTextureLayer(int target, int attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			if        (Delegates.pglFramebufferTextureLayer != null) {
				Delegates.pglFramebufferTextureLayer(target, attachment, texture, level, layer);
				CallLog("glFramebufferTextureLayer({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			} else if (Delegates.pglFramebufferTextureLayerARB != null) {
				Delegates.pglFramebufferTextureLayerARB(target, attachment, texture, level, layer);
				CallLog("glFramebufferTextureLayerARB({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			} else if (Delegates.pglFramebufferTextureLayerEXT != null) {
				Delegates.pglFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
				CallLog("glFramebufferTextureLayerEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			} else
				throw new NotImplementedException("glFramebufferTextureLayer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// map all or part of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding 
		/// targetsin the following table: 
		/// </param>
		/// <param name="offset">
		/// Specifies the starting offset within the buffer of the range to be mapped. 
		/// </param>
		/// <param name="length">
		/// Specifies the length of the range to be mapped. 
		/// </param>
		/// <param name="access">
		/// Specifies a combination of access flags indicating the desired access to the mapped range. 
		/// </param>
		/// <remarks>
		/// glMapBufferRange and glMapNamedBufferRange map all or part of the data store of a specified buffer object into the 
		/// client'saddress space. offset and length indicate the range of data in the buffer object that is to be mapped, in terms 
		/// ofbasic machine units. access is a bitfield containing flags which describe the requested mapping. These flags are 
		/// describedbelow. 
		/// A pointer to the beginning of the mapped range is returned once all pending operations on the buffer object have 
		/// completed,and may be used to modify and/or query the corresponding range of the data store according to the following 
		/// flagbits set in access: GL_MAP_READ_BIT indicates that the returned pointer may be used to read buffer object data. No 
		/// GLerror is generated if the pointer is used to query a mapping which excludes this flag, but the result is undefined and 
		/// systemerrors (possibly including program termination) may occur. GL_MAP_WRITE_BIT indicates that the returned pointer 
		/// maybe used to modify buffer object data. No GL error is generated if the pointer is used to modify a mapping which 
		/// excludesthis flag, but the result is undefined and system errors (possibly including program termination) may occur. 
		/// GL_MAP_PERSISTENT_BITindicates that the mapping is to be made in a persistent fassion and that the client intends to 
		/// holdand use the returned pointer during subsequent GL operation. It is not an error to call drawing commands (render) 
		/// whilebuffers are mapped using this flag. It is an error to specify this flag if the buffer's data store was not 
		/// allocatedthrough a call to the glBufferStorage command in which the GL_MAP_PERSISTENT_BIT was also set. 
		/// GL_MAP_COHERENT_BITindicates that a persistent mapping is also to be coherent. Coherent maps guarantee that the effect 
		/// ofwrites to a buffer's data store by either the client or server will eventually become visible to the other without 
		/// furtherintervention from the application. In the absence of this bit, persistent mappings are not coherent and modified 
		/// rangesof the buffer store must be explicitly communicated to the GL, either by unmapping the buffer, or through a call 
		/// toglFlushMappedBufferRange or glMemoryBarrier. 
		/// The following optional flag bits in access may be used to modify the mapping: GL_MAP_INVALIDATE_RANGE_BIT indicates that 
		/// theprevious contents of the specified range may be discarded. Data within this range are undefined with the exception of 
		/// subsequentlywritten data. No GL error is generated if subsequent GL operations access unwritten data, but the result is 
		/// undefinedand system errors (possibly including program termination) may occur. This flag may not be used in combination 
		/// withGL_MAP_READ_BIT. GL_MAP_INVALIDATE_BUFFER_BIT indicates that the previous contents of the entire buffer may be 
		/// discarded.Data within the entire buffer are undefined with the exception of subsequently written data. No GL error is 
		/// generatedif subsequent GL operations access unwritten data, but the result is undefined and system errors (possibly 
		/// includingprogram termination) may occur. This flag may not be used in combination with GL_MAP_READ_BIT. 
		/// GL_MAP_FLUSH_EXPLICIT_BITindicates that one or more discrete subranges of the mapping may be modified. When this flag is 
		/// set,modifications to each subrange must be explicitly flushed by calling glFlushMappedBufferRange. No GL error is set if 
		/// asubrange of the mapping is modified and not flushed, but data within the corresponding subrange of the buffer are 
		/// undefined.This flag may only be used in conjunction with GL_MAP_WRITE_BIT. When this option is selected, flushing is 
		/// strictlylimited to regions that are explicitly indicated with calls to glFlushMappedBufferRange prior to unmap; if this 
		/// optionis not selected glUnmapBuffer will automatically flush the entire mapped range when called. 
		/// GL_MAP_UNSYNCHRONIZED_BITindicates that the GL should not attempt to synchronize pending operations on the buffer prior 
		/// toreturning from glMapBufferRange or glMapNamedBufferRange. No GL error is generated if pending operations which source 
		/// ormodify the buffer overlap the mapped region, but the result of such previous and any subsequent operations is 
		/// undefined.
		/// If an error occurs, a NULL pointer is returned. 
		/// If no error occurs, the returned pointer will reflect an allocation aligned to the value of GL_MIN_MAP_BUFFER_ALIGNMENT 
		/// basicmachine units. Subtracting offset from this returned pointer will always produce a multiple of the value of 
		/// GL_MIN_MAP_BUFFER_ALIGNMENT.
		/// The returned pointer values may not be passed as parameter values to GL commands. For example, they may not be used to 
		/// specifyarray pointers, or to specify or query pixel or texture image data; such actions produce undefined results, 
		/// althoughimplementations may not check for such behavior for performance reasons. 
		/// Mappings to the data stores of buffer objects may have nonstandard performance characteristics. For example, such 
		/// mappingsmay be marked as uncacheable regions of memory, and in such cases reading from them may be very slow. To ensure 
		/// optimalperformance, the client should use the mapping in a fashion consistent with the values of GL_BUFFER_USAGE for the 
		/// bufferobject and of access. Using a mapping in a fashion inconsistent with these values is liable to be multiple orders 
		/// ofmagnitude slower than using normal memory. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glMapBufferRange if target is not one of the buffer binding targets listed above. 
		/// - GL_INVALID_OPERATION is generated by glMapBufferRange if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glMapNamedBufferRange if buffer is not the name of an existing buffer object. 
		/// - GL_INVALID_VALUE is generated if offset or length is negative, if $offset + length$ is greater than the value of 
		///   GL_BUFFER_SIZEfor the buffer object, or if access has any bits set other than those defined above. 
		/// - GL_INVALID_OPERATION is generated for any of the following conditions: length is zero. The buffer object is already in a 
		///   mappedstate. Neither GL_MAP_READ_BIT nor GL_MAP_WRITE_BIT is set. GL_MAP_READ_BIT is set and any of 
		///   GL_MAP_INVALIDATE_RANGE_BIT,GL_MAP_INVALIDATE_BUFFER_BIT or GL_MAP_UNSYNCHRONIZED_BIT is set. GL_MAP_FLUSH_EXPLICIT_BIT 
		///   isset and GL_MAP_WRITE_BIT is not set. Any of GL_MAP_READ_BIT, GL_MAP_WRITE_BIT, GL_MAP_PERSISTENT_BIT, or 
		///   GL_MAP_COHERENT_BITare set, but the same bit is not included in the buffer's storage flags. 
		/// - No error is generated if memory outside the mapped range is modified or queried, but the result is undefined and system 
		///   errors(possibly including program termination) may occur. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with pnameGL_MIN_MAP_BUFFER_ALIGNMENT. The value must be a power of two that is at least 64. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		/// <seealso cref="Gl.FlushMappedBufferRange"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferStorage"/>
		public static IntPtr MapBufferRange(int target, IntPtr offset, UInt32 length, uint access)
		{
			IntPtr retValue;

			if        (Delegates.pglMapBufferRange != null) {
				retValue = Delegates.pglMapBufferRange(target, offset, length, access);
				CallLog("glMapBufferRange({0}, {1}, {2}, {3}) = {4}", target, offset, length, access, retValue);
			} else if (Delegates.pglMapBufferRangeEXT != null) {
				retValue = Delegates.pglMapBufferRangeEXT(target, offset, length, access);
				CallLog("glMapBufferRangeEXT({0}, {1}, {2}, {3}) = {4}", target, offset, length, access, retValue);
			} else
				throw new NotImplementedException("glMapBufferRange (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// indicate modifications to a range of a mapped buffer
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer 
		/// bindingtargets in the following table: 
		/// </param>
		/// <param name="offset">
		/// Specifies the start of the buffer subrange, in basic machine units. 
		/// </param>
		/// <param name="length">
		/// Specifies the length of the buffer subrange, in basic machine units. 
		/// </param>
		/// <remarks>
		/// glFlushMappedBufferRange indicates that modifications have been made to a range of a mapped buffer object. The buffer 
		/// objectmust previously have been mapped with the GL_MAP_FLUSH_EXPLICIT_BIT flag. 
		/// offset and length indicate the modified subrange of the mapping, in basic machine units. The specified subrange to flush 
		/// isrelative to the start of the currently mapped range of the buffer. These commands may be called multiple times to 
		/// indicatedistinct subranges of the mapping which require flushing. 
		/// If a buffer range is mapped with both GL_MAP_PERSISTENT_BIT and GL_MAP_FLUSH_EXPLICIT_BIT set, then these commands may 
		/// becalled to ensure that data written by the client into the flushed region becomes visible to the server. Data written 
		/// toa coherent store will always become visible to the server after an unspecified period of time. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glFlushMappedBufferRange if target is not one of the buffer binding targets listed 
		///   above.
		/// - GL_INVALID_OPERATION is generated by glFlushMappedBufferRange if zero is bound to target. 
		/// - GL_INVALID_OPERATION is generated by glFlushMappedNamedBufferRange if buffer is not the name of an existing buffer 
		///   object.
		/// - GL_INVALID_VALUE is generated if offset or length is negative, or if offset + length exceeds the size of the mapping. 
		/// - GL_INVALID_OPERATION is generated if the buffer object is not mapped, or is mapped without the GL_MAP_FLUSH_EXPLICIT_BIT 
		///   flag.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.MapBufferRange"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.UnmapBuffer"/>
		public static void FlushMappedBufferRange(int target, IntPtr offset, UInt32 length)
		{
			if        (Delegates.pglFlushMappedBufferRange != null) {
				Delegates.pglFlushMappedBufferRange(target, offset, length);
				CallLog("glFlushMappedBufferRange({0}, {1}, {2})", target, offset, length);
			} else if (Delegates.pglFlushMappedBufferRangeAPPLE != null) {
				Delegates.pglFlushMappedBufferRangeAPPLE(target, offset, length);
				CallLog("glFlushMappedBufferRangeAPPLE({0}, {1}, {2})", target, offset, length);
			} else if (Delegates.pglFlushMappedBufferRangeEXT != null) {
				Delegates.pglFlushMappedBufferRangeEXT(target, offset, length);
				CallLog("glFlushMappedBufferRangeEXT({0}, {1}, {2})", target, offset, length);
			} else
				throw new NotImplementedException("glFlushMappedBufferRange (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies the name of the vertex array to bind. 
		/// </param>
		/// <remarks>
		/// glBindVertexArray binds the vertex array object with name array. array is the name of a vertex array object previously 
		/// returnedfrom a call to glGenVertexArrays, or zero to break the existing vertex array object binding. 
		/// If no vertex array object with name array exists, one is created when array is first bound. If the bind is successful no 
		/// changeis made to the state of the vertex array object, and any previous vertex array object binding is broken. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if array is not zero or the name of a vertex array object previously returned from a 
		///   callto glGenVertexArrays. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		public static void BindVertexArray(UInt32 array)
		{
			if        (Delegates.pglBindVertexArray != null) {
				Delegates.pglBindVertexArray(array);
				CallLog("glBindVertexArray({0})", array);
			} else if (Delegates.pglBindVertexArrayOES != null) {
				Delegates.pglBindVertexArrayOES(array);
				CallLog("glBindVertexArrayOES({0})", array);
			} else
				throw new NotImplementedException("glBindVertexArray (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// delete vertex array objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of vertex array objects to be deleted. 
		/// </param>
		/// <param name="arrays">
		/// Specifies the address of an array containing the n names of the objects to be deleted. 
		/// </param>
		/// <remarks>
		/// glDeleteVertexArrays deletes n vertex array objects whose names are stored in the array addressed by arrays. Once a 
		/// vertexarray object is deleted it has no contents and its name is again unused. If a vertex array object that is 
		/// currentlybound is deleted, the binding for that object reverts to zero and the default vertex array becomes current. 
		/// Unusednames in arrays are silently ignored, as is the value zero. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.IsVertexArray"/>
		/// <seealso cref="Gl.BindVertexArray"/>
		public static void DeleteVertexArrays(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					if        (Delegates.pglDeleteVertexArrays != null) {
						Delegates.pglDeleteVertexArrays(n, p_arrays);
						CallLog("glDeleteVertexArrays({0}, {1})", n, arrays);
					} else if (Delegates.pglDeleteVertexArraysAPPLE != null) {
						Delegates.pglDeleteVertexArraysAPPLE(n, p_arrays);
						CallLog("glDeleteVertexArraysAPPLE({0}, {1})", n, arrays);
					} else if (Delegates.pglDeleteVertexArraysOES != null) {
						Delegates.pglDeleteVertexArraysOES(n, p_arrays);
						CallLog("glDeleteVertexArraysOES({0}, {1})", n, arrays);
					} else
						throw new NotImplementedException("glDeleteVertexArrays (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate vertex array object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of vertex array object names to generate. 
		/// </param>
		/// <param name="arrays">
		/// Specifies an array in which the generated vertex array object names are stored. 
		/// </param>
		/// <remarks>
		/// glGenVertexArrays returns n vertex array object names in arrays. There is no guarantee that the names form a contiguous 
		/// setof integers; however, it is guaranteed that none of the returned names was in use immediately before the call to 
		/// glGenVertexArrays.
		/// Vertex array object names returned by a call to glGenVertexArrays are not returned by subsequent calls, unless they are 
		/// firstdeleted with glDeleteVertexArrays. 
		/// The names returned in arrays are marked as used, for the purposes of glGenVertexArrays only, but they acquire state and 
		/// typeonly when they are first bound. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if n is negative. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		public static void GenVertexArrays(Int32 n, UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					if        (Delegates.pglGenVertexArrays != null) {
						Delegates.pglGenVertexArrays(n, p_arrays);
						CallLog("glGenVertexArrays({0}, {1})", n, arrays);
					} else if (Delegates.pglGenVertexArraysAPPLE != null) {
						Delegates.pglGenVertexArraysAPPLE(n, p_arrays);
						CallLog("glGenVertexArraysAPPLE({0}, {1})", n, arrays);
					} else if (Delegates.pglGenVertexArraysOES != null) {
						Delegates.pglGenVertexArraysOES(n, p_arrays);
						CallLog("glGenVertexArraysOES({0}, {1})", n, arrays);
					} else
						throw new NotImplementedException("glGenVertexArrays (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies a value that may be the name of a vertex array object. 
		/// </param>
		/// <remarks>
		/// glIsVertexArray returns GL_TRUE if array is currently the name of a vertex array object. If array is zero, or if array 
		/// isnot the name of a vertex array object, or if an error occurs, glIsVertexArray returns GL_FALSE. If array is a name 
		/// returnedby glGenVertexArrays, by that has not yet been bound through a call to glBindVertexArray, then the name is not a 
		/// vertexarray object and glIsVertexArray returns GL_FALSE. 
		/// </remarks>
		/// <seealso cref="Gl.GenVertexArrays"/>
		/// <seealso cref="Gl.BindVertexArray"/>
		/// <seealso cref="Gl.DeleteVertexArrays"/>
		public static bool IsVertexArray(UInt32 array)
		{
			bool retValue;

			if        (Delegates.pglIsVertexArray != null) {
				retValue = Delegates.pglIsVertexArray(array);
				CallLog("glIsVertexArray({0}) = {1}", array, retValue);
			} else if (Delegates.pglIsVertexArrayAPPLE != null) {
				retValue = Delegates.pglIsVertexArrayAPPLE(array);
				CallLog("glIsVertexArrayAPPLE({0}) = {1}", array, retValue);
			} else if (Delegates.pglIsVertexArrayOES != null) {
				retValue = Delegates.pglIsVertexArrayOES(array);
				CallLog("glIsVertexArrayOES({0}) = {1}", array, retValue);
			} else
				throw new NotImplementedException("glIsVertexArray (and other aliases) are not implemented");
			DebugCheckErrors();

			return (retValue);
		}

	}

}
