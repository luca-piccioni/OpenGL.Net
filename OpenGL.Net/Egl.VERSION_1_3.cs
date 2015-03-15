
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_CONFORMANT symbol.
		/// </summary>
		[AliasOf("EGL_CONFORMANT_KHR"]
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int CONFORMANT = 0x3042;

		/// <summary>
		/// Value of EGL_CONTEXT_CLIENT_VERSION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int CONTEXT_CLIENT_VERSION = 0x3098;

		/// <summary>
		/// Value of EGL_MATCH_NATIVE_PIXMAP symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int MATCH_NATIVE_PIXMAP = 0x3041;

		/// <summary>
		/// Value of EGL_OPENGL_ES2_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int OPENGL_ES2_BIT = 0x0004;

		/// <summary>
		/// Value of EGL_VG_ALPHA_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT = 0x3088;

		/// <summary>
		/// Value of EGL_VG_ALPHA_FORMAT_NONPRE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT_NONPRE = 0x308B;

		/// <summary>
		/// Value of EGL_VG_ALPHA_FORMAT_PRE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT_PRE = 0x308C;

		/// <summary>
		/// Value of EGL_VG_ALPHA_FORMAT_PRE_BIT symbol.
		/// </summary>
		[AliasOf("EGL_VG_ALPHA_FORMAT_PRE_BIT_KHR"]
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_ALPHA_FORMAT_PRE_BIT = 0x0040;

		/// <summary>
		/// Value of EGL_VG_COLORSPACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_COLORSPACE = 0x3087;

		/// <summary>
		/// Value of EGL_VG_COLORSPACE_LINEAR_BIT symbol.
		/// </summary>
		[AliasOf("EGL_VG_COLORSPACE_LINEAR_BIT_KHR"]
		[RequiredByFeature("EGL_VERSION_1_3")]
		public const int VG_COLORSPACE_LINEAR_BIT = 0x0020;

	}

}
