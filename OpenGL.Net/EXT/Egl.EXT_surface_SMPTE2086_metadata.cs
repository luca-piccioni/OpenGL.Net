
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_RX_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_RX_EXT = 0x3341;

		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_RY_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_RY_EXT = 0x3342;

		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_GX_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_GX_EXT = 0x3343;

		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_GY_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_GY_EXT = 0x3344;

		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_BX_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_BX_EXT = 0x3345;

		/// <summary>
		/// Value of EGL_SMPTE2086_DISPLAY_PRIMARY_BY_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_DISPLAY_PRIMARY_BY_EXT = 0x3346;

		/// <summary>
		/// Value of EGL_SMPTE2086_WHITE_POINT_X_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_WHITE_POINT_X_EXT = 0x3347;

		/// <summary>
		/// Value of EGL_SMPTE2086_WHITE_POINT_Y_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_WHITE_POINT_Y_EXT = 0x3348;

		/// <summary>
		/// Value of EGL_SMPTE2086_MAX_LUMINANCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_MAX_LUMINANCE_EXT = 0x3349;

		/// <summary>
		/// Value of EGL_SMPTE2086_MIN_LUMINANCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_EXT_surface_SMPTE2086_metadata")]
		public const int SMPTE2086_MIN_LUMINANCE_EXT = 0x334A;

	}

}
