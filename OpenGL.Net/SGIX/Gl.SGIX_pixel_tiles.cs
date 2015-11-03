
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_BEST_ALIGNMENT_SGIX = 0x813E;

		/// <summary>
		/// Value of GL_PIXEL_TILE_CACHE_INCREMENT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_CACHE_INCREMENT_SGIX = 0x813F;

		/// <summary>
		/// Value of GL_PIXEL_TILE_WIDTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_WIDTH_SGIX = 0x8140;

		/// <summary>
		/// Value of GL_PIXEL_TILE_HEIGHT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_HEIGHT_SGIX = 0x8141;

		/// <summary>
		/// Value of GL_PIXEL_TILE_GRID_WIDTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142;

		/// <summary>
		/// Value of GL_PIXEL_TILE_GRID_HEIGHT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143;

		/// <summary>
		/// Value of GL_PIXEL_TILE_GRID_DEPTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144;

		/// <summary>
		/// Value of GL_PIXEL_TILE_CACHE_SIZE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		public const int PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145;

	}

}
