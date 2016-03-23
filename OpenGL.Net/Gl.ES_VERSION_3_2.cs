
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
		/// Value of GL_MULTISAMPLE_LINE_WIDTH_RANGE symbol.
		/// </summary>
		[AliasOf("GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_2_compatibility")]
		public const int MULTISAMPLE_LINE_WIDTH_RANGE = 0x9381;

		/// <summary>
		/// Value of GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY symbol.
		/// </summary>
		[AliasOf("GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_2_compatibility")]
		public const int MULTISAMPLE_LINE_WIDTH_GRANULARITY = 0x9382;

		/// <summary>
		/// Value of GL_MULTIPLY symbol.
		/// </summary>
		[AliasOf("GL_MULTIPLY_KHR")]
		[AliasOf("GL_MULTIPLY_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int MULTIPLY = 0x9294;

		/// <summary>
		/// Value of GL_SCREEN symbol.
		/// </summary>
		[AliasOf("GL_SCREEN_KHR")]
		[AliasOf("GL_SCREEN_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int SCREEN = 0x9295;

		/// <summary>
		/// Value of GL_OVERLAY symbol.
		/// </summary>
		[AliasOf("GL_OVERLAY_KHR")]
		[AliasOf("GL_OVERLAY_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int OVERLAY = 0x9296;

		/// <summary>
		/// Value of GL_DARKEN symbol.
		/// </summary>
		[AliasOf("GL_DARKEN_KHR")]
		[AliasOf("GL_DARKEN_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int DARKEN = 0x9297;

		/// <summary>
		/// Value of GL_LIGHTEN symbol.
		/// </summary>
		[AliasOf("GL_LIGHTEN_KHR")]
		[AliasOf("GL_LIGHTEN_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int LIGHTEN = 0x9298;

		/// <summary>
		/// Value of GL_COLORDODGE symbol.
		/// </summary>
		[AliasOf("GL_COLORDODGE_KHR")]
		[AliasOf("GL_COLORDODGE_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int COLORDODGE = 0x9299;

		/// <summary>
		/// Value of GL_COLORBURN symbol.
		/// </summary>
		[AliasOf("GL_COLORBURN_KHR")]
		[AliasOf("GL_COLORBURN_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int COLORBURN = 0x929A;

		/// <summary>
		/// Value of GL_HARDLIGHT symbol.
		/// </summary>
		[AliasOf("GL_HARDLIGHT_KHR")]
		[AliasOf("GL_HARDLIGHT_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int HARDLIGHT = 0x929B;

		/// <summary>
		/// Value of GL_SOFTLIGHT symbol.
		/// </summary>
		[AliasOf("GL_SOFTLIGHT_KHR")]
		[AliasOf("GL_SOFTLIGHT_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int SOFTLIGHT = 0x929C;

		/// <summary>
		/// Value of GL_DIFFERENCE symbol.
		/// </summary>
		[AliasOf("GL_DIFFERENCE_KHR")]
		[AliasOf("GL_DIFFERENCE_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int DIFFERENCE = 0x929E;

		/// <summary>
		/// Value of GL_EXCLUSION symbol.
		/// </summary>
		[AliasOf("GL_EXCLUSION_KHR")]
		[AliasOf("GL_EXCLUSION_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int EXCLUSION = 0x92A0;

		/// <summary>
		/// Value of GL_HSL_HUE symbol.
		/// </summary>
		[AliasOf("GL_HSL_HUE_KHR")]
		[AliasOf("GL_HSL_HUE_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int HSL_HUE = 0x92AD;

		/// <summary>
		/// Value of GL_HSL_SATURATION symbol.
		/// </summary>
		[AliasOf("GL_HSL_SATURATION_KHR")]
		[AliasOf("GL_HSL_SATURATION_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int HSL_SATURATION = 0x92AE;

		/// <summary>
		/// Value of GL_HSL_COLOR symbol.
		/// </summary>
		[AliasOf("GL_HSL_COLOR_KHR")]
		[AliasOf("GL_HSL_COLOR_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int HSL_COLOR = 0x92AF;

		/// <summary>
		/// Value of GL_HSL_LUMINOSITY symbol.
		/// </summary>
		[AliasOf("GL_HSL_LUMINOSITY_KHR")]
		[AliasOf("GL_HSL_LUMINOSITY_NV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public const int HSL_LUMINOSITY = 0x92B0;

		/// <summary>
		/// Value of GL_PRIMITIVE_BOUNDING_BOX symbol.
		/// </summary>
		[AliasOf("GL_PRIMITIVE_BOUNDING_BOX_ARB")]
		[AliasOf("GL_PRIMITIVE_BOUNDING_BOX_EXT")]
		[AliasOf("GL_PRIMITIVE_BOUNDING_BOX_OES")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_2_compatibility")]
		[RequiredByFeature("GL_EXT_primitive_bounding_box", Api = "gles2")]
		[RequiredByFeature("GL_OES_primitive_bounding_box", Api = "gles2")]
		public const int PRIMITIVE_BOUNDING_BOX = 0x92BE;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_4x4 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_4x4_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_4x4 = 0x93B0;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x4 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_5x4_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_5x4 = 0x93B1;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_5x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_5x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_5x5 = 0x93B2;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_6x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_6x5 = 0x93B3;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_6x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_6x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_6x6 = 0x93B4;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_8x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_8x5 = 0x93B5;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_8x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_8x6 = 0x93B6;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_8x8 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_8x8_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_8x8 = 0x93B7;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_10x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_10x5 = 0x93B8;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_10x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_10x6 = 0x93B9;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x8 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_10x8_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_10x8 = 0x93BA;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_10x10 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_10x10_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_10x10 = 0x93BB;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_12x10 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_12x10_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_12x10 = 0x93BC;

		/// <summary>
		/// Value of GL_COMPRESSED_RGBA_ASTC_12x12 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RGBA_ASTC_12x12_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_RGBA_ASTC_12x12 = 0x93BD;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_4x4 = 0x93D0;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x4 = 0x93D1;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_5x5 = 0x93D2;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x5 = 0x93D3;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_6x6 = 0x93D4;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x5 = 0x93D5;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x6 = 0x93D6;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_8x8 = 0x93D7;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x5 = 0x93D8;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x6 = 0x93D9;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x8 = 0x93DA;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_10x10 = 0x93DB;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x10 = 0x93DC;

		/// <summary>
		/// Value of GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_hdr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_texture_compression_astc_ldr", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_compression_astc", Api = "gles2")]
		public const int COMPRESSED_SRGB8_ALPHA8_ASTC_12x12 = 0x93DD;

		/// <summary>
		/// Binding for glBlendBarrier.
		/// </summary>
		[AliasOf("glBlendBarrierKHR")]
		[AliasOf("glBlendBarrierNV")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_blend_equation_advanced", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|gles2")]
		public static void BlendBarrier()
		{
			Debug.Assert(Delegates.pglBlendBarrier != null, "pglBlendBarrier not implemented");
			Delegates.pglBlendBarrier();
			LogFunction("glBlendBarrier()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPrimitiveBoundingBox.
		/// </summary>
		/// <param name="minX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="minW">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxZ">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="maxW">
		/// A <see cref="T:float"/>.
		/// </param>
		[AliasOf("glPrimitiveBoundingBoxARB")]
		[AliasOf("glPrimitiveBoundingBoxEXT")]
		[AliasOf("glPrimitiveBoundingBoxOES")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_2_compatibility")]
		[RequiredByFeature("GL_EXT_primitive_bounding_box", Api = "gles2")]
		[RequiredByFeature("GL_OES_primitive_bounding_box", Api = "gles2")]
		public static void Primitive(float minX, float minY, float minZ, float minW, float maxX, float maxY, float maxZ, float maxW)
		{
			Debug.Assert(Delegates.pglPrimitiveBoundingBox != null, "pglPrimitiveBoundingBox not implemented");
			Delegates.pglPrimitiveBoundingBox(minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			LogFunction("glPrimitiveBoundingBox({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", minX, minY, minZ, minW, maxX, maxY, maxZ, maxW);
			DebugCheckErrors(null);
		}

	}

}
