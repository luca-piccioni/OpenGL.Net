
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
		/// Value of GL_TEXTURE0 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE0 = 0x84C0;

		/// <summary>
		/// Value of GL_TEXTURE1 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE1 = 0x84C1;

		/// <summary>
		/// Value of GL_TEXTURE2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE2 = 0x84C2;

		/// <summary>
		/// Value of GL_TEXTURE3 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE3 = 0x84C3;

		/// <summary>
		/// Value of GL_TEXTURE4 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE4 = 0x84C4;

		/// <summary>
		/// Value of GL_TEXTURE5 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE5 = 0x84C5;

		/// <summary>
		/// Value of GL_TEXTURE6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE6 = 0x84C6;

		/// <summary>
		/// Value of GL_TEXTURE7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE7 = 0x84C7;

		/// <summary>
		/// Value of GL_TEXTURE8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE8 = 0x84C8;

		/// <summary>
		/// Value of GL_TEXTURE9 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE9 = 0x84C9;

		/// <summary>
		/// Value of GL_TEXTURE10 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE10 = 0x84CA;

		/// <summary>
		/// Value of GL_TEXTURE11 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE11 = 0x84CB;

		/// <summary>
		/// Value of GL_TEXTURE12 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE12 = 0x84CC;

		/// <summary>
		/// Value of GL_TEXTURE13 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE13 = 0x84CD;

		/// <summary>
		/// Value of GL_TEXTURE14 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE14 = 0x84CE;

		/// <summary>
		/// Value of GL_TEXTURE15 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE15 = 0x84CF;

		/// <summary>
		/// Value of GL_TEXTURE16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE16 = 0x84D0;

		/// <summary>
		/// Value of GL_TEXTURE17 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE17 = 0x84D1;

		/// <summary>
		/// Value of GL_TEXTURE18 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE18 = 0x84D2;

		/// <summary>
		/// Value of GL_TEXTURE19 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE19 = 0x84D3;

		/// <summary>
		/// Value of GL_TEXTURE20 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE20 = 0x84D4;

		/// <summary>
		/// Value of GL_TEXTURE21 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE21 = 0x84D5;

		/// <summary>
		/// Value of GL_TEXTURE22 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE22 = 0x84D6;

		/// <summary>
		/// Value of GL_TEXTURE23 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE23 = 0x84D7;

		/// <summary>
		/// Value of GL_TEXTURE24 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE24 = 0x84D8;

		/// <summary>
		/// Value of GL_TEXTURE25 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE25 = 0x84D9;

		/// <summary>
		/// Value of GL_TEXTURE26 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE26 = 0x84DA;

		/// <summary>
		/// Value of GL_TEXTURE27 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE27 = 0x84DB;

		/// <summary>
		/// Value of GL_TEXTURE28 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE28 = 0x84DC;

		/// <summary>
		/// Value of GL_TEXTURE29 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE29 = 0x84DD;

		/// <summary>
		/// Value of GL_TEXTURE30 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE30 = 0x84DE;

		/// <summary>
		/// Value of GL_TEXTURE31 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE31 = 0x84DF;

		/// <summary>
		/// Value of GL_ACTIVE_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int ACTIVE_TEXTURE = 0x84E0;

		/// <summary>
		/// Value of GL_MULTISAMPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int MULTISAMPLE = 0x809D;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_COVERAGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

		/// <summary>
		/// Value of GL_SAMPLE_ALPHA_TO_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		public const int SAMPLE_ALPHA_TO_ONE = 0x809F;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLE_COVERAGE = 0x80A0;

		/// <summary>
		/// Value of GL_SAMPLE_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLE_BUFFERS = 0x80A8;

		/// <summary>
		/// Value of GL_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int SAMPLES = 0x80A9;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLE_COVERAGE_VALUE = 0x80AA;

		/// <summary>
		/// Value of GL_SAMPLE_COVERAGE_INVERT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int SAMPLE_COVERAGE_INVERT = 0x80AB;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_CUBE_MAP = 0x8513;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_CUBE_MAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_CUBE_MAP = 0x8514;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

		/// <summary>
		/// Value of GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_CUBE_MAP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int PROXY_TEXTURE_CUBE_MAP = 0x851B;

		/// <summary>
		/// Value of GL_MAX_CUBE_MAP_TEXTURE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

		/// <summary>
		/// Value of GL_COMPRESSED_RGB symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int COMPRESSED_RGB = 0x84ED;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int COMPRESSED_RGBA = 0x84EE;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSION_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_COMPRESSION_HINT = 0x84EF;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED_IMAGE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

		/// <summary>
		/// Value of GL_TEXTURE_COMPRESSED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_COMPRESSED = 0x86A1;

		/// <summary>
		/// Value of GL_NUM_COMPRESSED_TEXTURE_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

		/// <summary>
		/// Value of GL_COMPRESSED_TEXTURE_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0")]
		public const int COMPRESSED_TEXTURE_FORMATS = 0x86A3;

		/// <summary>
		/// Value of GL_CLAMP_TO_BORDER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		public const int CLAMP_TO_BORDER = 0x812D;

		/// <summary>
		/// Value of GL_CLIENT_ACTIVE_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLIENT_ACTIVE_TEXTURE = 0x84E1;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_UNITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int MAX_TEXTURE_UNITS = 0x84E2;

		/// <summary>
		/// Value of GL_TRANSPOSE_MODELVIEW_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;

		/// <summary>
		/// Value of GL_TRANSPOSE_PROJECTION_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_PROJECTION_MATRIX = 0x84E4;

		/// <summary>
		/// Value of GL_TRANSPOSE_TEXTURE_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_TEXTURE_MATRIX = 0x84E5;

		/// <summary>
		/// Value of GL_TRANSPOSE_COLOR_MATRIX symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TRANSPOSE_COLOR_MATRIX = 0x84E6;

		/// <summary>
		/// Value of GL_MULTISAMPLE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const uint MULTISAMPLE_BIT = 0x20000000;

		/// <summary>
		/// Value of GL_NORMAL_MAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int NORMAL_MAP = 0x8511;

		/// <summary>
		/// Value of GL_REFLECTION_MAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int REFLECTION_MAP = 0x8512;

		/// <summary>
		/// Value of GL_COMPRESSED_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_ALPHA = 0x84E9;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_LUMINANCE = 0x84EA;

		/// <summary>
		/// Value of GL_COMPRESSED_LUMINANCE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_LUMINANCE_ALPHA = 0x84EB;

		/// <summary>
		/// Value of GL_COMPRESSED_INTENSITY symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMPRESSED_INTENSITY = 0x84EC;

		/// <summary>
		/// Value of GL_COMBINE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE = 0x8570;

		/// <summary>
		/// Value of GL_COMBINE_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE_RGB = 0x8571;

		/// <summary>
		/// Value of GL_COMBINE_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int COMBINE_ALPHA = 0x8572;

		/// <summary>
		/// Value of GL_SOURCE0_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE0_RGB = 0x8580;

		/// <summary>
		/// Value of GL_SOURCE1_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE1_RGB = 0x8581;

		/// <summary>
		/// Value of GL_SOURCE2_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE2_RGB = 0x8582;

		/// <summary>
		/// Value of GL_SOURCE0_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE0_ALPHA = 0x8588;

		/// <summary>
		/// Value of GL_SOURCE1_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE1_ALPHA = 0x8589;

		/// <summary>
		/// Value of GL_SOURCE2_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SOURCE2_ALPHA = 0x858A;

		/// <summary>
		/// Value of GL_OPERAND0_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND0_RGB = 0x8590;

		/// <summary>
		/// Value of GL_OPERAND1_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND1_RGB = 0x8591;

		/// <summary>
		/// Value of GL_OPERAND2_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND2_RGB = 0x8592;

		/// <summary>
		/// Value of GL_OPERAND0_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND0_ALPHA = 0x8598;

		/// <summary>
		/// Value of GL_OPERAND1_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND1_ALPHA = 0x8599;

		/// <summary>
		/// Value of GL_OPERAND2_ALPHA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int OPERAND2_ALPHA = 0x859A;

		/// <summary>
		/// Value of GL_RGB_SCALE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int RGB_SCALE = 0x8573;

		/// <summary>
		/// Value of GL_ADD_SIGNED symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ADD_SIGNED = 0x8574;

		/// <summary>
		/// Value of GL_INTERPOLATE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int INTERPOLATE = 0x8575;

		/// <summary>
		/// Value of GL_SUBTRACT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int SUBTRACT = 0x84E7;

		/// <summary>
		/// Value of GL_CONSTANT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CONSTANT = 0x8576;

		/// <summary>
		/// Value of GL_PRIMARY_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RequiredByFeature("GL_NV_path_rendering")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PRIMARY_COLOR = 0x8577;

		/// <summary>
		/// Value of GL_PREVIOUS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int PREVIOUS = 0x8578;

		/// <summary>
		/// Value of GL_DOT3_RGB symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOT3_RGB = 0x86AE;

		/// <summary>
		/// Value of GL_DOT3_RGBA symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int DOT3_RGBA = 0x86AF;

		/// <summary>
		/// select active texture unit
		/// </summary>
		/// <param name="texture">
		/// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at 
		/// least80. texture must be one of GL_TEXTUREi, where i ranges from zero to the value of 
		/// GL_MAX_COMBINED_TEXTURE_IMAGE_UNITSminus one. The initial value is GL_TEXTURE0. 
		/// </param>
		/// <remarks>
		/// glActiveTexture selects which texture unit subsequent texture state calls will affect. The number of texture units an 
		/// implementationsupports is implementation dependent, but must be at least 80. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if texture is not one of GL_TEXTUREi, where i ranges from zero to the value of 
		///   GL_MAX_COMBINED_TEXTURE_IMAGE_UNITSminus one. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_ACTIVE_TEXTURE, or GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS. 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		/// <seealso cref="Gl.IsTexture"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2DMultisample"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexImage3DMultisample"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void ActiveTexture(int texture)
		{
			if        (Delegates.pglActiveTexture != null) {
				Delegates.pglActiveTexture(texture);
				CallLog("glActiveTexture({0})", texture);
			} else if (Delegates.pglActiveTextureARB != null) {
				Delegates.pglActiveTextureARB(texture);
				CallLog("glActiveTextureARB({0})", texture);
			} else
				throw new NotImplementedException("glActiveTexture (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify multisample coverage parameters
		/// </summary>
		/// <param name="value">
		/// Specify a single floating-point sample coverage value. The value is clamped to the range 01. The initial value is 1.0. 
		/// </param>
		/// <param name="invert">
		/// Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. 
		/// Theinitial value is GL_FALSE. 
		/// </param>
		/// <remarks>
		/// Multisampling samples a pixel multiple times at various implementation-dependent subpixel locations to generate 
		/// antialiasingeffects. Multisampling transparently antialiases points, lines, polygons, and images if it is enabled. 
		/// value is used in constructing a temporary mask used in determining which samples will be used in resolving the final 
		/// fragmentcolor. This mask is bitwise-anded with the coverage mask generated from the multisampling computation. If the 
		/// invertflag is set, the temporary mask is inverted (all bits flipped) and then the bitwise-and is computed. 
		/// If an implementation does not have any multisample buffers available, or multisampling is disabled, rasterization occurs 
		/// withonly a single sample computing a pixel's final RGB color. 
		/// Provided an implementation supports multisample buffers, and multisampling is enabled, then a pixel's final color is 
		/// generatedby combining several samples per pixel. Each sample contains color, depth, and stencil information, allowing 
		/// thoseoperations to be performed on each sample. 
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_SAMPLE_COVERAGE_VALUE 
		/// - glGet with argument GL_SAMPLE_COVERAGE_INVERT 
		/// - glIsEnabled with argument GL_MULTISAMPLE 
		/// - glIsEnabled with argument GL_SAMPLE_ALPHA_TO_COVERAGE 
		/// - glIsEnabled with argument GL_SAMPLE_ALPHA_TO_ONE 
		/// - glIsEnabled with argument GL_SAMPLE_COVERAGE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.removedTypes"/>
		public static void SampleCoverage(float value, bool invert)
		{
			if        (Delegates.pglSampleCoverage != null) {
				Delegates.pglSampleCoverage(value, invert);
				CallLog("glSampleCoverage({0}, {1})", value, invert);
			} else if (Delegates.pglSampleCoverageARB != null) {
				Delegates.pglSampleCoverageARB(value, invert);
				CallLog("glSampleCoverageARB({0}, {1})", value, invert);
			} else
				throw new NotImplementedException("glSampleCoverage (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels high. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels deep. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>. 
		/// <see cref="Gl.CompressedTexImage3D"/> loads a previously defined, and retrieved, compressed three-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/> (see Gl.TexImage3D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage3D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage3D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage3D != null) {
				Delegates.pglCompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage3DARB != null) {
				Delegates.pglCompressedTexImage3DARB(target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage3DOES != null) {
				Delegates.pglCompressedTexImage3DOES(target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels high. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels deep. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>. 
		/// <see cref="Gl.CompressedTexImage3D"/> loads a previously defined, and retrieved, compressed three-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/> (see Gl.TexImage3D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage3D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage3D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage3D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage3D != null) {
				Delegates.pglCompressedTexImage3D((int)target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage3DARB != null) {
				Delegates.pglCompressedTexImage3DARB((int)target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage3DOES != null) {
				Delegates.pglCompressedTexImage3DOES((int)target, level, internalformat, width, height, depth, border, imageSize, data);
				CallLog("glCompressedTexImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, internalformat, width, height, depth, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_3D"/> or <see cref="Gl.PROXY_TEXTURE_3D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels high. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 3D texture images 
		/// thatare at least 16 texels deep. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable three-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_3D"/>. 
		/// <see cref="Gl.CompressedTexImage3D"/> loads a previously defined, and retrieved, compressed three-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_3D"/> (see Gl.TexImage3D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_3D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage3D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage3D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_3D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture images 
		/// thatare at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D texture 
		/// imagesthat are at least 64 texels high and cube-mapped texture images that are at least 16 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped textures, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// <see cref="Gl.CompressedTexImage2D"/> loads a previously defined, and retrieved, compressed two-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/> (see Gl.TexImage2D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage2D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage2D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
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
		public static void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage2D != null) {
				Delegates.pglCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
				CallLog("glCompressedTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage2DARB != null) {
				Delegates.pglCompressedTexImage2DARB(target, level, internalformat, width, height, border, imageSize, data);
				CallLog("glCompressedTexImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture images 
		/// thatare at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D texture 
		/// imagesthat are at least 64 texels high and cube-mapped texture images that are at least 16 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped textures, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// <see cref="Gl.CompressedTexImage2D"/> loads a previously defined, and retrieved, compressed two-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/> (see Gl.TexImage2D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage2D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage2D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
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
		public static void CompressedTexImage2D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage2D != null) {
				Delegates.pglCompressedTexImage2D((int)target, level, internalformat, width, height, border, imageSize, data);
				CallLog("glCompressedTexImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage2DARB != null) {
				Delegates.pglCompressedTexImage2DARB((int)target, level, internalformat, width, height, border, imageSize, data);
				CallLog("glCompressedTexImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, level, internalformat, width, height, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_2D"/>, <see cref="Gl.PROXY_TEXTURE_2D"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_X"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_X"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Y"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y"/>, <see 
		/// cref="Gl.TEXTURE_CUBE_MAP_POSITIVE_Z"/>,<see cref="Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z"/>, or <see 
		/// cref="Gl.PROXY_TEXTURE_CUBE_MAP"/>.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support 2D texture images 
		/// thatare at least 64 texels wide and cube-mapped texture images that are at least 16 texels wide. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be Must be 2n+2⁡border for some integer n. All implementations support 2D texture 
		/// imagesthat are at least 64 texels high and cube-mapped texture images that are at least 16 texels high. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable two-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_2D"/>. To 
		/// enableand disable texturing using cube-mapped textures, call Gl.Enable and Gl.Disable with argument <see 
		/// cref="Gl.TEXTURE_CUBE_MAP"/>.
		/// <see cref="Gl.CompressedTexImage2D"/> loads a previously defined, and retrieved, compressed two-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_2D"/> (see Gl.TexImage2D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_2D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be an extension-specified compressed-texture format. When a texture is loaded 
		/// withGl.TexImage2D using a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>), the GL selects from 
		/// oneof its extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage2D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage2D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_2D"/> or <see cref="Gl.TEXTURE_CUBE_MAP"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
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
		public static void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// <see cref="Gl.CompressedTexImage1D"/> loads a previously defined, and retrieved, compressed one-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/> (see Gl.TexImage1D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be extension-specified compressed-texture format. When a texture is loaded with 
		/// Gl.TexImage1Dusing a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>) the GL selects from one 
		/// ofits extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage1D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage1D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
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
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage1D != null) {
				Delegates.pglCompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
				CallLog("glCompressedTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage1DARB != null) {
				Delegates.pglCompressedTexImage1DARB(target, level, internalformat, width, border, imageSize, data);
				CallLog("glCompressedTexImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// <see cref="Gl.CompressedTexImage1D"/> loads a previously defined, and retrieved, compressed one-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/> (see Gl.TexImage1D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be extension-specified compressed-texture format. When a texture is loaded with 
		/// Gl.TexImage1Dusing a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>) the GL selects from one 
		/// ofits extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage1D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage1D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
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
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage1D(TextureTarget target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexImage1D != null) {
				Delegates.pglCompressedTexImage1D((int)target, level, internalformat, width, border, imageSize, data);
				CallLog("glCompressedTexImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			} else if (Delegates.pglCompressedTexImage1DARB != null) {
				Delegates.pglCompressedTexImage1DARB((int)target, level, internalformat, width, border, imageSize, data);
				CallLog("glCompressedTexImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, internalformat, width, border, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture image in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be <see cref="Gl.TEXTURE_1D"/> or <see cref="Gl.PROXY_TEXTURE_1D"/>. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="internalformat">
		/// Specifies the format of the compressed image data stored at address <paramref name="data"/>. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-twosizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// thatare at least 64 texels wide. The height of the 1D texture image is 1. 
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by <paramref name="data"/>. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To 
		/// enableand disable one-dimensional texturing, call Gl.Enable and Gl.Disable with argument <see cref="Gl.TEXTURE_1D"/>. 
		/// <see cref="Gl.CompressedTexImage1D"/> loads a previously defined, and retrieved, compressed one-dimensional texture 
		/// imageif <paramref name="target"/> is <see cref="Gl.TEXTURE_1D"/> (see Gl.TexImage1D). 
		/// If <paramref name="target"/> is <see cref="Gl.PROXY_TEXTURE_1D"/>, no data is read from <paramref name="data"/>, but all 
		/// ofthe texture image state is recalculated, checked for consistency, and checked against the implementation's 
		/// capabilities.If the implementation cannot handle a texture of the requested texture size, it sets all of the image state 
		/// to0, but does not generate an error (see Gl.GetError). To query for an entire mipmap array, use an image array level 
		/// greaterthan or equal to 1. 
		/// <paramref name="internalformat"/> must be extension-specified compressed-texture format. When a texture is loaded with 
		/// Gl.TexImage1Dusing a generic compressed texture format (e.g., <see cref="Gl.COMPRESSED_RGB"/>) the GL selects from one 
		/// ofits extensions supporting compressed textures. In order to load the compressed texture image using <see 
		/// cref="Gl.CompressedTexImage1D"/>,query the compressed texture image's size and format using Gl.GetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the <see cref="Gl.PIXEL_UNPACK_BUFFER"/> target (see Gl.BindBuffer) while 
		/// atexture image is specified, <paramref name="data"/> is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="internalformat"/> is one of the generic compressed 
		///   internalformats: <see cref="Gl.COMPRESSED_ALPHA"/>, <see cref="Gl.COMPRESSED_LUMINANCE"/>, <see 
		///   cref="Gl.COMPRESSED_LUMINANCE_ALPHA"/>,<see cref="Gl.COMPRESSED_INTENSITY"/>, <see cref="Gl.COMPRESSED_RGB"/>, or <see 
		///   cref="Gl.COMPRESSED_RGBA"/>.
		/// - <see cref="Gl.INVALID_VALUE"/> is generated if <paramref name="imageSize"/> is not consistent with the format, 
		///   dimensions,and contents of the specified compressed image data. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if parameter combinations are not supported by the specific compressed 
		///   internalformat as specified in the specific texture compression extension. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the buffer object's data store is currently mapped. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if a non-zero buffer object name is bound to the <see 
		///   cref="Gl.PIXEL_UNPACK_BUFFER"/>target and the data would be unpacked from the buffer object such that the memory reads 
		///   requiredwould exceed the data store size. 
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.CompressedTexImage1D"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// - Undefined results, including abnormal program termination, are generated if <paramref name="data"/> is not encoded in a 
		///   mannerconsistent with the extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.GetCompressedTexImage 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_COMPRESSED"/> 
		/// - Gl.Get with argument <see cref="Gl.PIXEL_UNPACK_BUFFER_BINDING"/> 
		/// - Gl.GetTexLevelParameter with arguments <see cref="Gl.TEXTURE_INTERNAL_FORMAT"/> and <see 
		///   cref="Gl.TEXTURE_COMPRESSED_IMAGE_SIZE"/>
		/// - Gl.IsEnabled with argument <see cref="Gl.TEXTURE_1D"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
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
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexImage1D(target, level, internalformat, width, border, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage3D function. Must be GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_3D,or GL_TEXTURE_CUBE_MAP_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage3D and glCompressedTextureSubImage3D redefine a contiguous subregion of an existing 
		/// three-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, and the z indices zoffset and 
		/// zoffset+depth-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage3D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage3D if target is not GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or 
		///   GL_TEXTURE_CUBE_MAP_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage3D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage3D != null) {
				Delegates.pglCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
				CallLog("glCompressedTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage3DARB != null) {
				Delegates.pglCompressedTexSubImage3DARB(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
				CallLog("glCompressedTexSubImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage3DOES != null) {
				Delegates.pglCompressedTexSubImage3DOES(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
				CallLog("glCompressedTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage3D function. Must be GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_3D,or GL_TEXTURE_CUBE_MAP_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage3D and glCompressedTextureSubImage3D redefine a contiguous subregion of an existing 
		/// three-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, and the z indices zoffset and 
		/// zoffset+depth-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage3D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage3D if target is not GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or 
		///   GL_TEXTURE_CUBE_MAP_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage3D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage3D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage3D != null) {
				Delegates.pglCompressedTexSubImage3D((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage3D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage3DARB != null) {
				Delegates.pglCompressedTexSubImage3DARB((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage3DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage3DOES != null) {
				Delegates.pglCompressedTexSubImage3DOES((int)target, level, xoffset, yoffset, zoffset, width, height, depth, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage3DOES({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10})", target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage3D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a three-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage3D function. Must be GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_3D,or GL_TEXTURE_CUBE_MAP_ARRAY. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="depth">
		/// Specifies the depth of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage3D and glCompressedTextureSubImage3D redefine a contiguous subregion of an existing 
		/// three-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, and the z indices zoffset and 
		/// zoffset+depth-1,inclusive. This region may not include any texels outside the range of the texture array as it was 
		/// originallyspecified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage3D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage3D if target is not GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, or 
		///   GL_TEXTURE_CUBE_MAP_ARRAY.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage3D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage2D function. Must be GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D,GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage2D and glCompressedTextureSubImage2D redefine a contiguous subregion of an existing 
		/// two-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, inclusive. This region may not 
		/// includeany texels outside the range of the texture array as it was originally specified. It is not an error to specify a 
		/// subtexturewith width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage2D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage2D if target is GL_TEXTURE_RECTANGLE or 
		///   GL_PROXY_TEXTURE_RECTANGLE.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if the effective target is GL_TEXTURE_RECTANGLE. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage2D != null) {
				Delegates.pglCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
				CallLog("glCompressedTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage2DARB != null) {
				Delegates.pglCompressedTexSubImage2DARB(target, level, xoffset, yoffset, width, height, format, imageSize, data);
				CallLog("glCompressedTexSubImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage2D function. Must be GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D,GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage2D and glCompressedTextureSubImage2D redefine a contiguous subregion of an existing 
		/// two-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, inclusive. This region may not 
		/// includeany texels outside the range of the texture array as it was originally specified. It is not an error to specify a 
		/// subtexturewith width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage2D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage2D if target is GL_TEXTURE_RECTANGLE or 
		///   GL_PROXY_TEXTURE_RECTANGLE.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if the effective target is GL_TEXTURE_RECTANGLE. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage2D != null) {
				Delegates.pglCompressedTexSubImage2D((int)target, level, xoffset, yoffset, width, height, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage2D({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage2DARB != null) {
				Delegates.pglCompressedTexSubImage2DARB((int)target, level, xoffset, yoffset, width, height, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage2DARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, width, height, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage2D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a two-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glCompressedTexSubImage2D function. Must be GL_TEXTURE_1D_ARRAY, 
		/// GL_TEXTURE_2D,GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="yoffset">
		/// Specifies a texel offset in the y direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage2D and glCompressedTextureSubImage2D redefine a contiguous subregion of an existing 
		/// two-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, and the y indices yoffset and yoffset+height-1, inclusive. This region may not 
		/// includeany texels outside the range of the texture array as it was originally specified. It is not an error to specify a 
		/// subtexturewith width of 0, but such a specification has no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage2D)and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_ENUM is generated by glCompressedTexSubImage2D if target is GL_TEXTURE_RECTANGLE or 
		///   GL_PROXY_TEXTURE_RECTANGLE.
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage2D if the effective target is GL_TEXTURE_RECTANGLE. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for glCompressedTexSubImage1D function. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage1D and glCompressedTextureSubImage1D redefine a contiguous subregion of an existing 
		/// one-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, inclusive. This region may not include any texels outside the range of the texture 
		/// arrayas it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specificationhas no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage1D),and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage1D function if texture is not the name of an existing 
		///   textureobject. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage1D != null) {
				Delegates.pglCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
				CallLog("glCompressedTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage1DARB != null) {
				Delegates.pglCompressedTexSubImage1DARB(target, level, xoffset, width, format, imageSize, data);
				CallLog("glCompressedTexSubImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for glCompressedTexSubImage1D function. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage1D and glCompressedTextureSubImage1D redefine a contiguous subregion of an existing 
		/// one-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, inclusive. This region may not include any texels outside the range of the texture 
		/// arrayas it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specificationhas no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage1D),and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage1D function if texture is not the name of an existing 
		///   textureobject. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage1D(TextureTarget target, Int32 level, Int32 xoffset, Int32 width, PixelFormat format, Int32 imageSize, IntPtr data)
		{
			if        (Delegates.pglCompressedTexSubImage1D != null) {
				Delegates.pglCompressedTexSubImage1D((int)target, level, xoffset, width, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage1D({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			} else if (Delegates.pglCompressedTexSubImage1DARB != null) {
				Delegates.pglCompressedTexSubImage1DARB((int)target, level, xoffset, width, (int)format, imageSize, data);
				CallLog("glCompressedTexSubImage1DARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", target, level, xoffset, width, format, imageSize, data);
			} else
				throw new NotImplementedException("glCompressedTexSubImage1D (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify a one-dimensional texture subimage in a compressed format
		/// </summary>
		/// <param name="target">
		/// Specifies the target, to which the texture is bound, for glCompressedTexSubImage1D function. Must be GL_TEXTURE_1D. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. 
		/// </param>
		/// <param name="xoffset">
		/// Specifies a texel offset in the x direction within the texture array. 
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture subimage. 
		/// </param>
		/// <param name="format">
		/// Specifies the format of the compressed image data stored at address data. 
		/// </param>
		/// <param name="imageSize">
		/// Specifies the number of unsigned bytes of image data starting at the address specified by data. 
		/// </param>
		/// <param name="data">
		/// Specifies a pointer to the compressed image data in memory. 
		/// </param>
		/// <remarks>
		/// Texturing allows elements of an image array to be read by shaders. 
		/// glCompressedTexSubImage1D and glCompressedTextureSubImage1D redefine a contiguous subregion of an existing 
		/// one-dimensionaltexture image. The texels referenced by data replace the portion of the existing texture array with x 
		/// indicesxoffset and xoffset+width-1, inclusive. This region may not include any texels outside the range of the texture 
		/// arrayas it was originally specified. It is not an error to specify a subtexture with width of 0, but such a 
		/// specificationhas no effect. 
		/// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture 
		/// format.The format of the compressed texture image is selected by the GL implementation that compressed it (see 
		/// glTexImage1D),and should be queried at the time the texture was compressed with glGetTexLevelParameter. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isspecified, data is treated as a byte offset into the buffer object's data store. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the generic compressed internal formats: GL_COMPRESSED_RED, 
		///   GL_COMPRESSED_RG,GL_COMPRESSED_RGB, GL_COMPRESSED_RGBA. GL_COMPRESSED_SRGB, or GL_COMPRESSED_SRGB_ALPHA. 
		/// - GL_INVALID_VALUE is generated if imageSize is not consistent with the format, dimensions, and contents of the specified 
		///   compressedimage data. 
		/// - GL_INVALID_OPERATION is generated if parameter combinations are not supported by the specific compressed internal format 
		///   asspecified in the specific texture compression extension. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   bufferobject's data store is currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_UNPACK_BUFFER target and the 
		///   datawould be unpacked from the buffer object such that the memory reads required would exceed the data store size. 
		/// - GL_INVALID_OPERATION is generated by glCompressedTextureSubImage1D function if texture is not the name of an existing 
		///   textureobject. 
		/// - Undefined results, including abnormal program termination, are generated if data is not encoded in a manner consistent 
		///   withthe extension specification defining the internal compression format. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetCompressedTexImage 
		/// - glGet with argument GL_TEXTURE_COMPRESSED 
		/// - glGet with argument GL_PIXEL_UNPACK_BUFFER_BINDING 
		/// - glGetTexLevelParameter with arguments GL_TEXTURE_INTERNAL_FORMAT and GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		public static void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D,GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// areaccepted. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmapreduction image. 
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetCompressedTexImage and glGetnCompressedTexImage return the compressed texture image associated with target and lod 
		/// intopixels. glGetCompressedTextureImage serves the same purpose, but instead of taking a texture target, it takes the ID 
		/// ofthe texture object. pixels should be an array of bufSize bytes for glGetnCompresedTexImage and 
		/// glGetCompressedTextureImagefunctions, and of GL_TEXTURE_COMPRESSED_IMAGE_SIZE bytes in case of glGetCompressedTexImage. 
		/// Ifthe actual data takes less space than bufSize, the remaining bytes will not be touched. target specifies the texture 
		/// target,to which the texture the data the function should extract the data from is bound to. lod specifies the 
		/// level-of-detailnumber of the desired image. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isrequested, pixels is treated as a byte offset into the buffer object's data store. 
		/// To minimize errors, first verify that the texture is compressed by calling glGetTexLevelParameter with argument 
		/// GL_TEXTURE_COMPRESSED.If the texture is compressed, you can determine the amount of memory required to store the 
		/// compressedtexture by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE. Finally, retrieve 
		/// theinternal format of the texture by calling glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT. To store 
		/// thetexture for later use, associate the internal format and size with the retrieved texture image. These data can be 
		/// usedby the respective texture or subtexture loading routine used for loading target textures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetCompressedTextureImage if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if level is less than zero or greater than the maximum number of LODs permitted by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if glGetCompressedTexImage, glGetnCompressedTexImage, and glGetCompressedTextureImage 
		///   isused to retrieve a texture that is in an uncompressed internal format. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target, the 
		///   bufferstorage was not initialized with glBufferStorage using GL_MAP_PERSISTENT_BIT flag, and the buffer object's data 
		///   storeis currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target and the 
		///   datawould be packed to the buffer object such that the memory writes required would exceed the data store size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT 
		/// - glGet with argument GL_PIXEL_PACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void GetCompressedTexImage(int target, Int32 level, IntPtr img)
		{
			if        (Delegates.pglGetCompressedTexImage != null) {
				Delegates.pglGetCompressedTexImage(target, level, img);
				CallLog("glGetCompressedTexImage({0}, {1}, {2})", target, level, img);
			} else if (Delegates.pglGetCompressedTexImageARB != null) {
				Delegates.pglGetCompressedTexImageARB(target, level, img);
				CallLog("glGetCompressedTexImageARB({0}, {1}, {2})", target, level, img);
			} else
				throw new NotImplementedException("glGetCompressedTexImage (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return a compressed texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetCompressedTexImage and glGetnCompressedTexImage functions. 
		/// GL_TEXTURE_1D,GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_ARRAY, 
		/// GL_TEXTURE_CUBE_MAP_POSITIVE_X,GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// GL_TEXTURE_CUBE_MAP_NEGATIVE_Y,GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, GL_TEXTURE_RECTANGLE 
		/// areaccepted. 
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level $n$ is the $n$-th 
		/// mipmapreduction image. 
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// glGetCompressedTexImage and glGetnCompressedTexImage return the compressed texture image associated with target and lod 
		/// intopixels. glGetCompressedTextureImage serves the same purpose, but instead of taking a texture target, it takes the ID 
		/// ofthe texture object. pixels should be an array of bufSize bytes for glGetnCompresedTexImage and 
		/// glGetCompressedTextureImagefunctions, and of GL_TEXTURE_COMPRESSED_IMAGE_SIZE bytes in case of glGetCompressedTexImage. 
		/// Ifthe actual data takes less space than bufSize, the remaining bytes will not be touched. target specifies the texture 
		/// target,to which the texture the data the function should extract the data from is bound to. lod specifies the 
		/// level-of-detailnumber of the desired image. 
		/// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image 
		/// isrequested, pixels is treated as a byte offset into the buffer object's data store. 
		/// To minimize errors, first verify that the texture is compressed by calling glGetTexLevelParameter with argument 
		/// GL_TEXTURE_COMPRESSED.If the texture is compressed, you can determine the amount of memory required to store the 
		/// compressedtexture by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE. Finally, retrieve 
		/// theinternal format of the texture by calling glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT. To store 
		/// thetexture for later use, associate the internal format and size with the retrieved texture image. These data can be 
		/// usedby the respective texture or subtexture loading routine used for loading target textures. 
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated by glGetCompressedTextureImage if texture is not the name of an existing texture 
		///   object.
		/// - GL_INVALID_VALUE is generated if level is less than zero or greater than the maximum number of LODs permitted by the 
		///   implementation.
		/// - GL_INVALID_OPERATION is generated if glGetCompressedTexImage, glGetnCompressedTexImage, and glGetCompressedTextureImage 
		///   isused to retrieve a texture that is in an uncompressed internal format. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target, the 
		///   bufferstorage was not initialized with glBufferStorage using GL_MAP_PERSISTENT_BIT flag, and the buffer object's data 
		///   storeis currently mapped. 
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to the GL_PIXEL_PACK_BUFFER target and the 
		///   datawould be packed to the buffer object such that the memory writes required would exceed the data store size. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE 
		/// - glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT 
		/// - glGet with argument GL_PIXEL_PACK_BUFFER_BINDING 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexImage2D"/>
		/// <seealso cref="Gl.CompressedTexImage3D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage2D"/>
		/// <seealso cref="Gl.CompressedTexSubImage3D"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		public static void GetCompressedTexImage(TextureTarget target, Int32 level, IntPtr img)
		{
			if        (Delegates.pglGetCompressedTexImage != null) {
				Delegates.pglGetCompressedTexImage((int)target, level, img);
				CallLog("glGetCompressedTexImage({0}, {1}, {2})", target, level, img);
			} else if (Delegates.pglGetCompressedTexImageARB != null) {
				Delegates.pglGetCompressedTexImageARB((int)target, level, img);
				CallLog("glGetCompressedTexImageARB({0}, {1}, {2})", target, level, img);
			} else
				throw new NotImplementedException("glGetCompressedTexImage (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// select active texture unit
		/// </summary>
		/// <param name="texture">
		/// Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at 
		/// leasttwo. <paramref name="texture"/> must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to the value of 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. The initial value is <see 
		/// cref="Gl.TEXTURE0"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.ClientActiveTexture"/> selects the vertex array client state parameters to be modified by 
		/// Gl.TexCoordPointer,and enabled or disabled with Gl.EnableClientState or Gl.DisableClientState, respectively, when called 
		/// witha parameter of <see cref="Gl.TEXTURE_COORD_ARRAY"/>. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_ENUM"/> is generated if <paramref name="texture"/> is not one of <see cref="Gl.TEXTURE"/>i, where 
		///   iranges from 0 to the value of <see cref="Gl.MAX_TEXTURE_COORDS"/> - 1. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CLIENT_ACTIVE_TEXTURE"/> or <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DisableClientState"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		public static void ClientActiveTexture(int texture)
		{
			if        (Delegates.pglClientActiveTexture != null) {
				Delegates.pglClientActiveTexture(texture);
				CallLog("glClientActiveTexture({0})", texture);
			} else if (Delegates.pglClientActiveTextureARB != null) {
				Delegates.pglClientActiveTextureARB(texture);
				CallLog("glClientActiveTextureARB({0})", texture);
			} else
				throw new NotImplementedException("glClientActiveTexture (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, double s)
		{
			if        (Delegates.pglMultiTexCoord1d != null) {
				Delegates.pglMultiTexCoord1d(target, s);
				CallLog("glMultiTexCoord1d({0}, {1})", target, s);
			} else if (Delegates.pglMultiTexCoord1dARB != null) {
				Delegates.pglMultiTexCoord1dARB(target, s);
				CallLog("glMultiTexCoord1dARB({0}, {1})", target, s);
			} else
				throw new NotImplementedException("glMultiTexCoord1d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord1dv != null) {
						Delegates.pglMultiTexCoord1dv(target, p_v);
						CallLog("glMultiTexCoord1dv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord1dvARB != null) {
						Delegates.pglMultiTexCoord1dvARB(target, p_v);
						CallLog("glMultiTexCoord1dvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord1dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, float s)
		{
			if        (Delegates.pglMultiTexCoord1f != null) {
				Delegates.pglMultiTexCoord1f(target, s);
				CallLog("glMultiTexCoord1f({0}, {1})", target, s);
			} else if (Delegates.pglMultiTexCoord1fARB != null) {
				Delegates.pglMultiTexCoord1fARB(target, s);
				CallLog("glMultiTexCoord1fARB({0}, {1})", target, s);
			} else
				throw new NotImplementedException("glMultiTexCoord1f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord1fv != null) {
						Delegates.pglMultiTexCoord1fv(target, p_v);
						CallLog("glMultiTexCoord1fv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord1fvARB != null) {
						Delegates.pglMultiTexCoord1fvARB(target, p_v);
						CallLog("glMultiTexCoord1fvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord1fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, Int32 s)
		{
			if        (Delegates.pglMultiTexCoord1i != null) {
				Delegates.pglMultiTexCoord1i(target, s);
				CallLog("glMultiTexCoord1i({0}, {1})", target, s);
			} else if (Delegates.pglMultiTexCoord1iARB != null) {
				Delegates.pglMultiTexCoord1iARB(target, s);
				CallLog("glMultiTexCoord1iARB({0}, {1})", target, s);
			} else
				throw new NotImplementedException("glMultiTexCoord1i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord1iv != null) {
						Delegates.pglMultiTexCoord1iv(target, p_v);
						CallLog("glMultiTexCoord1iv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord1ivARB != null) {
						Delegates.pglMultiTexCoord1ivARB(target, p_v);
						CallLog("glMultiTexCoord1ivARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord1iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, Int16 s)
		{
			if        (Delegates.pglMultiTexCoord1s != null) {
				Delegates.pglMultiTexCoord1s(target, s);
				CallLog("glMultiTexCoord1s({0}, {1})", target, s);
			} else if (Delegates.pglMultiTexCoord1sARB != null) {
				Delegates.pglMultiTexCoord1sARB(target, s);
				CallLog("glMultiTexCoord1sARB({0}, {1})", target, s);
			} else
				throw new NotImplementedException("glMultiTexCoord1s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord1(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord1sv != null) {
						Delegates.pglMultiTexCoord1sv(target, p_v);
						CallLog("glMultiTexCoord1sv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord1svARB != null) {
						Delegates.pglMultiTexCoord1svARB(target, p_v);
						CallLog("glMultiTexCoord1svARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord1sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, double s, double t)
		{
			if        (Delegates.pglMultiTexCoord2d != null) {
				Delegates.pglMultiTexCoord2d(target, s, t);
				CallLog("glMultiTexCoord2d({0}, {1}, {2})", target, s, t);
			} else if (Delegates.pglMultiTexCoord2dARB != null) {
				Delegates.pglMultiTexCoord2dARB(target, s, t);
				CallLog("glMultiTexCoord2dARB({0}, {1}, {2})", target, s, t);
			} else
				throw new NotImplementedException("glMultiTexCoord2d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord2dv != null) {
						Delegates.pglMultiTexCoord2dv(target, p_v);
						CallLog("glMultiTexCoord2dv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord2dvARB != null) {
						Delegates.pglMultiTexCoord2dvARB(target, p_v);
						CallLog("glMultiTexCoord2dvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord2dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, float s, float t)
		{
			if        (Delegates.pglMultiTexCoord2f != null) {
				Delegates.pglMultiTexCoord2f(target, s, t);
				CallLog("glMultiTexCoord2f({0}, {1}, {2})", target, s, t);
			} else if (Delegates.pglMultiTexCoord2fARB != null) {
				Delegates.pglMultiTexCoord2fARB(target, s, t);
				CallLog("glMultiTexCoord2fARB({0}, {1}, {2})", target, s, t);
			} else
				throw new NotImplementedException("glMultiTexCoord2f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord2fv != null) {
						Delegates.pglMultiTexCoord2fv(target, p_v);
						CallLog("glMultiTexCoord2fv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord2fvARB != null) {
						Delegates.pglMultiTexCoord2fvARB(target, p_v);
						CallLog("glMultiTexCoord2fvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, Int32 s, Int32 t)
		{
			if        (Delegates.pglMultiTexCoord2i != null) {
				Delegates.pglMultiTexCoord2i(target, s, t);
				CallLog("glMultiTexCoord2i({0}, {1}, {2})", target, s, t);
			} else if (Delegates.pglMultiTexCoord2iARB != null) {
				Delegates.pglMultiTexCoord2iARB(target, s, t);
				CallLog("glMultiTexCoord2iARB({0}, {1}, {2})", target, s, t);
			} else
				throw new NotImplementedException("glMultiTexCoord2i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord2iv != null) {
						Delegates.pglMultiTexCoord2iv(target, p_v);
						CallLog("glMultiTexCoord2iv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord2ivARB != null) {
						Delegates.pglMultiTexCoord2ivARB(target, p_v);
						CallLog("glMultiTexCoord2ivARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord2iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, Int16 s, Int16 t)
		{
			if        (Delegates.pglMultiTexCoord2s != null) {
				Delegates.pglMultiTexCoord2s(target, s, t);
				CallLog("glMultiTexCoord2s({0}, {1}, {2})", target, s, t);
			} else if (Delegates.pglMultiTexCoord2sARB != null) {
				Delegates.pglMultiTexCoord2sARB(target, s, t);
				CallLog("glMultiTexCoord2sARB({0}, {1}, {2})", target, s, t);
			} else
				throw new NotImplementedException("glMultiTexCoord2s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord2(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord2sv != null) {
						Delegates.pglMultiTexCoord2sv(target, p_v);
						CallLog("glMultiTexCoord2sv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord2svARB != null) {
						Delegates.pglMultiTexCoord2svARB(target, p_v);
						CallLog("glMultiTexCoord2svARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord2sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, double s, double t, double r)
		{
			if        (Delegates.pglMultiTexCoord3d != null) {
				Delegates.pglMultiTexCoord3d(target, s, t, r);
				CallLog("glMultiTexCoord3d({0}, {1}, {2}, {3})", target, s, t, r);
			} else if (Delegates.pglMultiTexCoord3dARB != null) {
				Delegates.pglMultiTexCoord3dARB(target, s, t, r);
				CallLog("glMultiTexCoord3dARB({0}, {1}, {2}, {3})", target, s, t, r);
			} else
				throw new NotImplementedException("glMultiTexCoord3d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord3dv != null) {
						Delegates.pglMultiTexCoord3dv(target, p_v);
						CallLog("glMultiTexCoord3dv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord3dvARB != null) {
						Delegates.pglMultiTexCoord3dvARB(target, p_v);
						CallLog("glMultiTexCoord3dvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord3dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, float s, float t, float r)
		{
			if        (Delegates.pglMultiTexCoord3f != null) {
				Delegates.pglMultiTexCoord3f(target, s, t, r);
				CallLog("glMultiTexCoord3f({0}, {1}, {2}, {3})", target, s, t, r);
			} else if (Delegates.pglMultiTexCoord3fARB != null) {
				Delegates.pglMultiTexCoord3fARB(target, s, t, r);
				CallLog("glMultiTexCoord3fARB({0}, {1}, {2}, {3})", target, s, t, r);
			} else
				throw new NotImplementedException("glMultiTexCoord3f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord3fv != null) {
						Delegates.pglMultiTexCoord3fv(target, p_v);
						CallLog("glMultiTexCoord3fv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord3fvARB != null) {
						Delegates.pglMultiTexCoord3fvARB(target, p_v);
						CallLog("glMultiTexCoord3fvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, Int32 s, Int32 t, Int32 r)
		{
			if        (Delegates.pglMultiTexCoord3i != null) {
				Delegates.pglMultiTexCoord3i(target, s, t, r);
				CallLog("glMultiTexCoord3i({0}, {1}, {2}, {3})", target, s, t, r);
			} else if (Delegates.pglMultiTexCoord3iARB != null) {
				Delegates.pglMultiTexCoord3iARB(target, s, t, r);
				CallLog("glMultiTexCoord3iARB({0}, {1}, {2}, {3})", target, s, t, r);
			} else
				throw new NotImplementedException("glMultiTexCoord3i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord3iv != null) {
						Delegates.pglMultiTexCoord3iv(target, p_v);
						CallLog("glMultiTexCoord3iv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord3ivARB != null) {
						Delegates.pglMultiTexCoord3ivARB(target, p_v);
						CallLog("glMultiTexCoord3ivARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, Int16 s, Int16 t, Int16 r)
		{
			if        (Delegates.pglMultiTexCoord3s != null) {
				Delegates.pglMultiTexCoord3s(target, s, t, r);
				CallLog("glMultiTexCoord3s({0}, {1}, {2}, {3})", target, s, t, r);
			} else if (Delegates.pglMultiTexCoord3sARB != null) {
				Delegates.pglMultiTexCoord3sARB(target, s, t, r);
				CallLog("glMultiTexCoord3sARB({0}, {1}, {2}, {3})", target, s, t, r);
			} else
				throw new NotImplementedException("glMultiTexCoord3s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord3(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord3sv != null) {
						Delegates.pglMultiTexCoord3sv(target, p_v);
						CallLog("glMultiTexCoord3sv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord3svARB != null) {
						Delegates.pglMultiTexCoord3svARB(target, p_v);
						CallLog("glMultiTexCoord3svARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord3sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, double s, double t, double r, double q)
		{
			if        (Delegates.pglMultiTexCoord4d != null) {
				Delegates.pglMultiTexCoord4d(target, s, t, r, q);
				CallLog("glMultiTexCoord4d({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else if (Delegates.pglMultiTexCoord4dARB != null) {
				Delegates.pglMultiTexCoord4dARB(target, s, t, r, q);
				CallLog("glMultiTexCoord4dARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else
				throw new NotImplementedException("glMultiTexCoord4d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord4dv != null) {
						Delegates.pglMultiTexCoord4dv(target, p_v);
						CallLog("glMultiTexCoord4dv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord4dvARB != null) {
						Delegates.pglMultiTexCoord4dvARB(target, p_v);
						CallLog("glMultiTexCoord4dvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord4dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, float s, float t, float r, float q)
		{
			if        (Delegates.pglMultiTexCoord4f != null) {
				Delegates.pglMultiTexCoord4f(target, s, t, r, q);
				CallLog("glMultiTexCoord4f({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else if (Delegates.pglMultiTexCoord4fARB != null) {
				Delegates.pglMultiTexCoord4fARB(target, s, t, r, q);
				CallLog("glMultiTexCoord4fARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else
				throw new NotImplementedException("glMultiTexCoord4f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord4fv != null) {
						Delegates.pglMultiTexCoord4fv(target, p_v);
						CallLog("glMultiTexCoord4fv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord4fvARB != null) {
						Delegates.pglMultiTexCoord4fvARB(target, p_v);
						CallLog("glMultiTexCoord4fvARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, Int32 s, Int32 t, Int32 r, Int32 q)
		{
			if        (Delegates.pglMultiTexCoord4i != null) {
				Delegates.pglMultiTexCoord4i(target, s, t, r, q);
				CallLog("glMultiTexCoord4i({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else if (Delegates.pglMultiTexCoord4iARB != null) {
				Delegates.pglMultiTexCoord4iARB(target, s, t, r, q);
				CallLog("glMultiTexCoord4iARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else
				throw new NotImplementedException("glMultiTexCoord4i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord4iv != null) {
						Delegates.pglMultiTexCoord4iv(target, p_v);
						CallLog("glMultiTexCoord4iv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord4ivARB != null) {
						Delegates.pglMultiTexCoord4ivARB(target, p_v);
						CallLog("glMultiTexCoord4ivARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord4iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="s">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="t">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="r">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <param name="q">
		/// Specify <paramref name="s"/>, <paramref name="t"/>, <paramref name="r"/>, and <paramref name="q"/> texture coordinates 
		/// for<paramref name="target"/> texture unit. Not all parameters are present in all forms of the command. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, Int16 s, Int16 t, Int16 r, Int16 q)
		{
			if        (Delegates.pglMultiTexCoord4s != null) {
				Delegates.pglMultiTexCoord4s(target, s, t, r, q);
				CallLog("glMultiTexCoord4s({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else if (Delegates.pglMultiTexCoord4sARB != null) {
				Delegates.pglMultiTexCoord4sARB(target, s, t, r, q);
				CallLog("glMultiTexCoord4sARB({0}, {1}, {2}, {3}, {4})", target, s, t, r, q);
			} else
				throw new NotImplementedException("glMultiTexCoord4s (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="target">
		/// Specifies the texture unit whose coordinates should be modified. The number of texture units is implementation 
		/// dependent,but must be at least two. Symbolic constant must be one of <see cref="Gl.TEXTURE"/>i, where i ranges from 0 to 
		/// <seecref="Gl.MAX_TEXTURE_COORDS"/> - 1, which is an implementation-dependent value. 
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultiTexCoord"/> specifies texture coordinates in one, two, three, or four dimensions. <see 
		/// cref="Gl.MultiTexCoord1"/>sets the current texture coordinates to s001; a call to <see cref="Gl.MultiTexCoord2"/> sets 
		/// themto st01. Similarly, <see cref="Gl.MultiTexCoord3"/> specifies the texture coordinates as str1, and <see 
		/// cref="Gl.MultiTexCoord4"/>defines all four components explicitly as strq. 
		/// The current texture coordinates are part of the data that is associated with each vertex and with the current raster 
		/// position.Initially, the values for strq are 0001. 
		///  
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.CURRENT_TEXTURE_COORDS"/> with appropriate texture unit selected. 
		/// - Gl.Get with argument <see cref="Gl.MAX_TEXTURE_COORDS"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ClientActiveTexture"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexCoordPointer"/>
		/// <seealso cref="Gl.Vertex"/>
		public static void MultiTexCoord4(int target, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					if        (Delegates.pglMultiTexCoord4sv != null) {
						Delegates.pglMultiTexCoord4sv(target, p_v);
						CallLog("glMultiTexCoord4sv({0}, {1})", target, v);
					} else if (Delegates.pglMultiTexCoord4svARB != null) {
						Delegates.pglMultiTexCoord4svARB(target, p_v);
						CallLog("glMultiTexCoord4svARB({0}, {1})", target, v);
					} else
						throw new NotImplementedException("glMultiTexCoord4sv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.LoadTransposeMatrix"/> replaces the current matrix with the one whose elements are specified by <paramref 
		/// name="m"/>.The current matrix is the projection matrix, modelview matrix, or texture matrix, depending on the current 
		/// matrixmode (see Gl.MatrixMode). 
		/// The current matrix, M, defines a transformation of coordinates. For instance, assume M refers to the modelview matrix. 
		/// Ifv=v⁡0v⁡1v⁡2v⁡3 is the set of object coordinates of a vertex, and <paramref name="m"/> points to an array of 16 single- 
		/// ordouble-precision floating-point values m=m⁡0m⁡1...m⁡15, then the modelview transformation M⁡v does the following: 
		/// M⁡v=m⁡0m⁡1m⁡2m⁡3m⁡4m⁡5m⁡6m⁡7m⁡8m⁡9m⁡10m⁡11m⁡12m⁡13m⁡14m⁡15×v⁡0v⁡1v⁡2v⁡3 
		///  
		/// Projection and texture transformations are similarly defined. 
		/// Calling <see cref="Gl.LoadTransposeMatrix"/> with matrix M is identical in operation to Gl.LoadMatrix with MT, where T 
		/// representsthe transpose. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.LoadTransposeMatrix"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void LoadTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					if        (Delegates.pglLoadTransposeMatrixf != null) {
						Delegates.pglLoadTransposeMatrixf(p_m);
						CallLog("glLoadTransposeMatrixf({0})", m);
					} else if (Delegates.pglLoadTransposeMatrixfARB != null) {
						Delegates.pglLoadTransposeMatrixfARB(p_m);
						CallLog("glLoadTransposeMatrixfARB({0})", m);
					} else
						throw new NotImplementedException("glLoadTransposeMatrixf (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// replace the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 row-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.LoadTransposeMatrix"/> replaces the current matrix with the one whose elements are specified by <paramref 
		/// name="m"/>.The current matrix is the projection matrix, modelview matrix, or texture matrix, depending on the current 
		/// matrixmode (see Gl.MatrixMode). 
		/// The current matrix, M, defines a transformation of coordinates. For instance, assume M refers to the modelview matrix. 
		/// Ifv=v⁡0v⁡1v⁡2v⁡3 is the set of object coordinates of a vertex, and <paramref name="m"/> points to an array of 16 single- 
		/// ordouble-precision floating-point values m=m⁡0m⁡1...m⁡15, then the modelview transformation M⁡v does the following: 
		/// M⁡v=m⁡0m⁡1m⁡2m⁡3m⁡4m⁡5m⁡6m⁡7m⁡8m⁡9m⁡10m⁡11m⁡12m⁡13m⁡14m⁡15×v⁡0v⁡1v⁡2v⁡3 
		///  
		/// Projection and texture transformations are similarly defined. 
		/// Calling <see cref="Gl.LoadTransposeMatrix"/> with matrix M is identical in operation to Gl.LoadMatrix with MT, where T 
		/// representsthe transpose. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.LoadTransposeMatrix"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void LoadTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					if        (Delegates.pglLoadTransposeMatrixd != null) {
						Delegates.pglLoadTransposeMatrixd(p_m);
						CallLog("glLoadTransposeMatrixd({0})", m);
					} else if (Delegates.pglLoadTransposeMatrixdARB != null) {
						Delegates.pglLoadTransposeMatrixdARB(p_m);
						CallLog("glLoadTransposeMatrixdARB({0})", m);
					} else
						throw new NotImplementedException("glLoadTransposeMatrixd (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultTransposeMatrix"/> multiplies the current matrix with the one specified using <paramref name="m"/>, 
		/// andreplaces the current matrix with the product. 
		/// The current matrix is determined by the current matrix mode (see Gl.MatrixMode). It is either the projection matrix, 
		/// modelviewmatrix, or the texture matrix. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MultTransposeMatrix"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void MultTransposeMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					if        (Delegates.pglMultTransposeMatrixf != null) {
						Delegates.pglMultTransposeMatrixf(p_m);
						CallLog("glMultTransposeMatrixf({0})", m);
					} else if (Delegates.pglMultTransposeMatrixfARB != null) {
						Delegates.pglMultTransposeMatrixfARB(p_m);
						CallLog("glMultTransposeMatrixfARB({0})", m);
					} else
						throw new NotImplementedException("glMultTransposeMatrixf (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// multiply the current matrix with the specified row-major ordered matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 row-major matrix. 
		/// </param>
		/// <remarks>
		/// <see cref="Gl.MultTransposeMatrix"/> multiplies the current matrix with the one specified using <paramref name="m"/>, 
		/// andreplaces the current matrix with the product. 
		/// The current matrix is determined by the current matrix mode (see Gl.MatrixMode). It is either the projection matrix, 
		/// modelviewmatrix, or the texture matrix. 
		/// <para>
		/// The following errors can be generated:
		/// - <see cref="Gl.INVALID_OPERATION"/> is generated if <see cref="Gl.MultTransposeMatrix"/> is executed between the 
		///   executionof Gl.Begin and the corresponding execution of Gl.End. 
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - Gl.Get with argument <see cref="Gl.MATRIX_MODE"/> 
		/// - Gl.Get with argument <see cref="Gl.COLOR_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.MODELVIEW_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.PROJECTION_MATRIX"/> 
		/// - Gl.Get with argument <see cref="Gl.TEXTURE_MATRIX"/> 
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PushMatrix"/>
		public static void MultTransposeMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					if        (Delegates.pglMultTransposeMatrixd != null) {
						Delegates.pglMultTransposeMatrixd(p_m);
						CallLog("glMultTransposeMatrixd({0})", m);
					} else if (Delegates.pglMultTransposeMatrixdARB != null) {
						Delegates.pglMultTransposeMatrixdARB(p_m);
						CallLog("glMultTransposeMatrixdARB({0})", m);
					} else
						throw new NotImplementedException("glMultTransposeMatrixd (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

	}

}
