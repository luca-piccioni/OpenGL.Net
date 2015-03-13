
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_X_VISUAL_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int X_VISUAL_TYPE_EXT = 0x22;

		/// <summary>
		/// Value of GLX_TRANSPARENT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_TYPE_EXT = 0x23;

		/// <summary>
		/// Value of GLX_TRANSPARENT_INDEX_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_INDEX_VALUE_EXT = 0x24;

		/// <summary>
		/// Value of GLX_TRANSPARENT_RED_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_RED_VALUE_EXT = 0x25;

		/// <summary>
		/// Value of GLX_TRANSPARENT_GREEN_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_GREEN_VALUE_EXT = 0x26;

		/// <summary>
		/// Value of GLX_TRANSPARENT_BLUE_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_BLUE_VALUE_EXT = 0x27;

		/// <summary>
		/// Value of GLX_TRANSPARENT_ALPHA_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_ALPHA_VALUE_EXT = 0x28;

		/// <summary>
		/// Value of GLX_NONE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		[RequiredByFeature("GLX_EXT_visual_rating")]
		public const int NONE_EXT = 0x8000;

		/// <summary>
		/// Value of GLX_TRUE_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRUE_COLOR_EXT = 0x8002;

		/// <summary>
		/// Value of GLX_DIRECT_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int DIRECT_COLOR_EXT = 0x8003;

		/// <summary>
		/// Value of GLX_PSEUDO_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int PSEUDO_COLOR_EXT = 0x8004;

		/// <summary>
		/// Value of GLX_STATIC_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int STATIC_COLOR_EXT = 0x8005;

		/// <summary>
		/// Value of GLX_GRAY_SCALE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int GRAY_SCALE_EXT = 0x8006;

		/// <summary>
		/// Value of GLX_STATIC_GRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int STATIC_GRAY_EXT = 0x8007;

		/// <summary>
		/// Value of GLX_TRANSPARENT_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_RGB_EXT = 0x8008;

		/// <summary>
		/// Value of GLX_TRANSPARENT_INDEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_visual_info")]
		public const int TRANSPARENT_INDEX_EXT = 0x8009;

	}

}
