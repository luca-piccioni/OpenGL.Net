
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
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB")]
		[AliasOf("GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_EXT")]
		[RequiredByFeature("GL_AMD_sparse_texture")]
		[RequiredByFeature("GL_ARB_sparse_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		public const int MAX_SPARSE_ARRAY_TEXTURE_LAYERS = 0x919A;

		/// <summary>
		/// Value of GL_MIN_SPARSE_LEVEL_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_sparse_texture")]
		public const int MIN_SPARSE_LEVEL_AMD = 0x919B;

		/// <summary>
		/// Value of GL_MIN_LOD_WARNING_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_sparse_texture")]
		public const int MIN_LOD_WARNING_AMD = 0x919C;

		/// <summary>
		/// Value of GL_TEXTURE_STORAGE_SPARSE_BIT_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_sparse_texture")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_STORAGE_SPARSE_BIT_AMD = 0x00000001;

		/// <summary>
		/// Binding for glTexStorageSparseAMD.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
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
		/// <param name="layers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_sparse_texture")]
		public static void TexStorageAMD(Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags)
		{
			Debug.Assert(Delegates.pglTexStorageSparseAMD != null, "pglTexStorageSparseAMD not implemented");
			Delegates.pglTexStorageSparseAMD(target, internalFormat, width, height, depth, layers, flags);
			LogCommand("glTexStorageSparseAMD", null, target, internalFormat, width, height, depth, layers, flags			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureStorageSparseAMD.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalFormat">
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
		/// <param name="layers">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_sparse_texture")]
		public static void TextureStorageAMD(UInt32 texture, Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags)
		{
			Debug.Assert(Delegates.pglTextureStorageSparseAMD != null, "pglTextureStorageSparseAMD not implemented");
			Delegates.pglTextureStorageSparseAMD(texture, target, internalFormat, width, height, depth, layers, flags);
			LogCommand("glTextureStorageSparseAMD", null, texture, target, internalFormat, width, height, depth, layers, flags			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexStorageSparseAMD", ExactSpelling = true)]
			internal extern static void glTexStorageSparseAMD(Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureStorageSparseAMD", ExactSpelling = true)]
			internal extern static void glTextureStorageSparseAMD(UInt32 texture, Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_sparse_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexStorageSparseAMD(Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[ThreadStatic]
			internal static glTexStorageSparseAMD pglTexStorageSparseAMD;

			[RequiredByFeature("GL_AMD_sparse_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureStorageSparseAMD(UInt32 texture, Int32 target, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, Int32 layers, UInt32 flags);

			[ThreadStatic]
			internal static glTextureStorageSparseAMD pglTextureStorageSparseAMD;

		}
	}

}
