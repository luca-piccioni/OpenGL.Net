
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
			LogFunction("glSyncTextureINTEL({0})", texture);
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
			LogFunction("glUnmapTexture2DINTEL({0}, {1})", texture, level);
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
					LogFunction("glMapTexture2DINTEL({0}, {1}, {2}, {3}, {4}) = {5}", texture, level, access, LogValue(stride), LogEnumName(layout), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
