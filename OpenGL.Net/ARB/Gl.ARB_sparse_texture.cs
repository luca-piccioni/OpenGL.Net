
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
		/// Value of GL_TEXTURE_SPARSE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int TEXTURE_SPARSE_ARB = 0x91A6;

		/// <summary>
		/// Value of GL_VIRTUAL_PAGE_SIZE_INDEX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int VIRTUAL_PAGE_SIZE_INDEX_ARB = 0x91A7;

		/// <summary>
		/// Value of GL_NUM_SPARSE_LEVELS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int NUM_SPARSE_LEVELS_ARB = 0x91AA;

		/// <summary>
		/// Value of GL_NUM_VIRTUAL_PAGE_SIZES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int NUM_VIRTUAL_PAGE_SIZES_ARB = 0x91A8;

		/// <summary>
		/// Value of GL_VIRTUAL_PAGE_SIZE_X_ARB symbol.
		/// </summary>
		[AliasOf("GL_VIRTUAL_PAGE_SIZE_X_AMD"]
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int VIRTUAL_PAGE_SIZE_X_ARB = 0x9195;

		/// <summary>
		/// Value of GL_VIRTUAL_PAGE_SIZE_Y_ARB symbol.
		/// </summary>
		[AliasOf("GL_VIRTUAL_PAGE_SIZE_Y_AMD"]
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int VIRTUAL_PAGE_SIZE_Y_ARB = 0x9196;

		/// <summary>
		/// Value of GL_VIRTUAL_PAGE_SIZE_Z_ARB symbol.
		/// </summary>
		[AliasOf("GL_VIRTUAL_PAGE_SIZE_Z_AMD"]
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int VIRTUAL_PAGE_SIZE_Z_ARB = 0x9197;

		/// <summary>
		/// Value of GL_MAX_SPARSE_TEXTURE_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_SPARSE_TEXTURE_SIZE_AMD"]
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int MAX_SPARSE_TEXTURE_SIZE_ARB = 0x9198;

		/// <summary>
		/// Value of GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_SPARSE_3D_TEXTURE_SIZE_AMD"]
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int MAX_SPARSE_3D_TEXTURE_SIZE_ARB = 0x9199;

		/// <summary>
		/// Value of GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public const int SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB = 0x91A9;

		/// <summary>
		/// Binding for glTexPageCommitmentARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="xoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="yoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="depth">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="resident">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_sparse_texture")]
		public static void TexPageCommitmentARB(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, bool resident)
		{
			Debug.Assert(Delegates.pglTexPageCommitmentARB != null, "pglTexPageCommitmentARB not implemented");
			Delegates.pglTexPageCommitmentARB(target, level, xoffset, yoffset, zoffset, width, height, depth, resident);
			CallLog("glTexPageCommitmentARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", target, level, xoffset, yoffset, zoffset, width, height, depth, resident);
			DebugCheckErrors();
		}

	}

}
