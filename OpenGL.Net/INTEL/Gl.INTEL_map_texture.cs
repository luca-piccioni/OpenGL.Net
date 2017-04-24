
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
		/// Value of GL_TEXTURE_MEMORY_LAYOUT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int TEXTURE_MEMORY_LAYOUT_INTEL = 0x83FF;

		/// <summary>
		/// Value of GL_LAYOUT_DEFAULT_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_DEFAULT_INTEL = 0;

		/// <summary>
		/// Value of GL_LAYOUT_LINEAR_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_LINEAR_INTEL = 1;

		/// <summary>
		/// Value of GL_LAYOUT_LINEAR_CPU_CACHED_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public const int LAYOUT_LINEAR_CPU_CACHED_INTEL = 2;

		/// <summary>
		/// Binding for glSyncTextureINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static void SyncTextureINTEL(UInt32 texture)
		{
			Debug.Assert(Delegates.pglSyncTextureINTEL != null, "pglSyncTextureINTEL not implemented");
			Delegates.pglSyncTextureINTEL(texture);
			LogCommand("glSyncTextureINTEL", null, texture			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUnmapTexture2DINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static void UnmapTexture2DINTEL(UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglUnmapTexture2DINTEL != null, "pglUnmapTexture2DINTEL not implemented");
			Delegates.pglUnmapTexture2DINTEL(texture, level);
			LogCommand("glUnmapTexture2DINTEL", null, texture, level			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMapTexture2DINTEL.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="layout">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_map_texture")]
		public static IntPtr MapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32[] stride, Int32[] layout)
		{
			IntPtr retValue;

			unsafe {
				fixed (Int32* p_stride = stride)
				fixed (Int32* p_layout = layout)
				{
					Debug.Assert(Delegates.pglMapTexture2DINTEL != null, "pglMapTexture2DINTEL not implemented");
					retValue = Delegates.pglMapTexture2DINTEL(texture, level, access, p_stride, p_layout);
					LogCommand("glMapTexture2DINTEL", retValue, texture, level, access, stride, layout					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSyncTextureINTEL", ExactSpelling = true)]
			internal extern static void glSyncTextureINTEL(UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUnmapTexture2DINTEL", ExactSpelling = true)]
			internal extern static void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapTexture2DINTEL", ExactSpelling = true)]
			internal extern static unsafe IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32* stride, Int32* layout);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_INTEL_map_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSyncTextureINTEL(UInt32 texture);

			[ThreadStatic]
			internal static glSyncTextureINTEL pglSyncTextureINTEL;

			[RequiredByFeature("GL_INTEL_map_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUnmapTexture2DINTEL(UInt32 texture, Int32 level);

			[ThreadStatic]
			internal static glUnmapTexture2DINTEL pglUnmapTexture2DINTEL;

			[RequiredByFeature("GL_INTEL_map_texture")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glMapTexture2DINTEL(UInt32 texture, Int32 level, UInt32 access, Int32* stride, Int32* layout);

			[ThreadStatic]
			internal static glMapTexture2DINTEL pglMapTexture2DINTEL;

		}
	}

}
