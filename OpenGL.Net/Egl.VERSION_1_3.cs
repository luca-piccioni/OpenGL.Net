
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a bitmask indicating which types of client API contexts created with respect 
		/// to the frame buffer configuration config must pass the required conformance tests for that API. Mask bits include: 
		/// Egl.OPENGL_BIT Config supports creating OpenGL contexts. Egl.OPENGL_ES_BIT Config supports creating OpenGL ES 1.0 and/or 
		/// 1.1 contexts. Egl.OPENGL_ES2_BIT Config supports creating OpenGL ES 2.0 contexts. Egl.OPENVG_BIT Config supports 
		/// creating OpenVG contexts. For example, if the bitmask is set to Egl.OPENGL_ES_BIT, only frame buffer configurations that 
		/// support creating conformant OpenGL ES contexts will match. The default value is zero. Most EGLConfigs should be 
		/// conformant for all supported client APIs, and it is rarely desirable to select a nonconformant config. Conformance 
		/// requirements limit the number of non-conformant configs that an implementation can define.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns a bitmask indicating which client API contexts created with respect to this config 
		/// are conformant.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		[RequiredByFeature("EGL_KHR_config_attribs")]
		public const int CONFORMANT = 0x3042;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreateContext: Must be followed by an integer that determines which version of an OpenGL ES context to create. 
		/// A value of 1 specifies creation of an OpenGL ES 1.x context. An attribute value of 2 specifies creation of an OpenGL ES 
		/// 2.x context. The default value is 1. This attribute can only be specified when creating a OpenGL ES context (e.g. when 
		/// the current rendering API is Egl.OPENGL_ES_API).
		/// </para>
		/// <para>
		/// [EGL] Egl.QueryContext: Returns the version of the client API which the context supports, as specified at context 
		/// creation time. The resulting value is only meaningful for an OpenGL ES context.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int CONTEXT_CLIENT_VERSION = 0x3098;

		/// <summary>
		/// [EGL] Egl.ChooseConfig: Must be followed by the handle of a valid native pixmap, cast to EGLint, or Egl.NONE. If the 
		/// value is not Egl.NONE, only configs which support creating pixmap surfaces with this pixmap using 
		/// Egl.CreatePixmapSurface will match this attribute. If the value is Egl.NONE, then configs are not matched for this 
		/// attribute. The default value is Egl.NONE. Egl.MATCH_NATIVE_PIXMAP was introduced due to the difficulty of determining an 
		/// EGLConfig compatibile with a native pixmap using only color component sizes.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int MATCH_NATIVE_PIXMAP = 0x3041;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_ES2_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const int OPENGL_ES2_BIT = 0x0004;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreatePbufferSurface: Specifies how alpha values are interpreted by OpenVG when rendering to the surface. If 
		/// its value is Egl.VG_ALPHA_FORMAT_NONPRE, then alpha values are not premultipled. If its value is 
		/// Egl.VG_ALPHA_FORMAT_PRE, then alpha values are premultiplied. The default value of Egl.VG_ALPHA_FORMAT is 
		/// Egl.VG_ALPHA_FORMAT_NONPRE.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreatePixmapSurface: Specifies how alpha values are interpreted by OpenVG when rendering to the surface. If 
		/// its value is Egl.VG_ALPHA_FORMAT_NONPRE, then alpha values are not premultipled. If its value is 
		/// Egl.VG_ALPHA_FORMAT_PRE, then alpha values are premultiplied. The default value of Egl.VG_ALPHA_FORMAT is 
		/// Egl.VG_ALPHA_FORMAT_NONPRE.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreateWindowSurface: Specifies how alpha values are interpreted by OpenVG when rendering to the surface. If 
		/// its value is Egl.VG_ALPHA_FORMAT_NONPRE, then alpha values are not premultipled. If its value is 
		/// Egl.VG_ALPHA_FORMAT_PRE, then alpha values are premultiplied. The default value of Egl.VG_ALPHA_FORMAT is 
		/// Egl.VG_ALPHA_FORMAT_NONPRE.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT = 0x3088;

		/// <summary>
		/// [EGL] Value of EGL_VG_ALPHA_FORMAT_NONPRE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT_NONPRE = 0x308B;

		/// <summary>
		/// [EGL] Value of EGL_VG_ALPHA_FORMAT_PRE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT_PRE = 0x308C;

		/// <summary>
		/// [EGL] Value of EGL_VG_ALPHA_FORMAT_PRE_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		[RequiredByFeature("EGL_KHR_config_attribs")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int VG_ALPHA_FORMAT_PRE_BIT = 0x0040;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreatePbufferSurface: Specifies the color space used by OpenVG when rendering to the surface. If its value is 
		/// Egl.VG_COLORSPACE_sRGB, then a non-linear, perceptually uniform color space is assumed, with a corresponding 
		/// VGImageFormat of form Egl.*. If its value is Egl.VG_COLORSPACE_LINEAR, then a linear color space is assumed, with a 
		/// corresponding VGImageFormat of form Egl.*. The default value of Egl.VG_COLORSPACE is Egl.VG_COLORSPACE_sRGB.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreatePixmapSurface: Specifies the color space used by OpenVG when rendering to the surface. If its value is 
		/// Egl.VG_COLORSPACE_sRGB, then a non-linear, perceptually uniform color space is assumed, with a corresponding 
		/// VGImageFormat of form Egl.*. If its value is Egl.VG_COLORSPACE_LINEAR, then a linear color space is assumed, with a 
		/// corresponding VGImageFormat of form Egl.*. The default value of Egl.VG_COLORSPACE is Egl.VG_COLORSPACE_sRGB.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreateWindowSurface: Specifies the color space used by OpenVG when rendering to the surface. If its value is 
		/// Egl.VG_COLORSPACE_sRGB, then a non-linear, perceptually uniform color space is assumed, with a corresponding 
		/// VGImageFormat of form Egl.*. If its value is Egl.VG_COLORSPACE_LINEAR, then a linear color space is assumed, with a 
		/// corresponding VGImageFormat of form Egl.*. The default value of Egl.VG_COLORSPACE is Egl.VG_COLORSPACE_sRGB.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_COLORSPACE = 0x3087;

		/// <summary>
		/// [EGL] Value of EGL_VG_COLORSPACE_LINEAR_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		[RequiredByFeature("EGL_KHR_config_attribs")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int VG_COLORSPACE_LINEAR_BIT = 0x0020;

	}

}
