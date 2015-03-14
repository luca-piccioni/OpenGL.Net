
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
		/// Value of GL_FOG_COORDINATE_SOURCE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_SOURCE_EXT = 0x8450;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_EXT = 0x8451;

		/// <summary>
		/// Value of GL_CURRENT_FOG_COORDINATE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int CURRENT_FOG_COORDINATE_EXT = 0x8453;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;

		/// <summary>
		/// Value of GL_FOG_COORDINATE_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public const int FOG_COORDINATE_ARRAY_EXT = 0x8457;

		/// <summary>
		/// Binding for glFogCoordfEXT.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordEXT(float coord)
		{
			Debug.Assert(Delegates.pglFogCoordfEXT != null, "pglFogCoordfEXT not implemented");
			Delegates.pglFogCoordfEXT(coord);
			CallLog("glFogCoordfEXT({0})", coord);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoordfvEXT.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordEXT(float[] coord)
		{
			unsafe {
				fixed (float* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoordfvEXT != null, "pglFogCoordfvEXT not implemented");
					Delegates.pglFogCoordfvEXT(p_coord);
					CallLog("glFogCoordfvEXT({0})", coord);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoorddEXT.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordEXT(double coord)
		{
			Debug.Assert(Delegates.pglFogCoorddEXT != null, "pglFogCoorddEXT not implemented");
			Delegates.pglFogCoorddEXT(coord);
			CallLog("glFogCoorddEXT({0})", coord);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoorddvEXT.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordEXT(double[] coord)
		{
			unsafe {
				fixed (double* p_coord = coord)
				{
					Debug.Assert(Delegates.pglFogCoorddvEXT != null, "pglFogCoorddvEXT not implemented");
					Delegates.pglFogCoorddvEXT(p_coord);
					CallLog("glFogCoorddvEXT({0})", coord);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoordPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:FogPointerTypeEXT"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordPointerEXT(FogPointerTypeEXT type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglFogCoordPointerEXT != null, "pglFogCoordPointerEXT not implemented");
			Delegates.pglFogCoordPointerEXT((int)type, stride, pointer);
			CallLog("glFogCoordPointerEXT({0}, {1}, {2})", type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFogCoordPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordPointerEXT(int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointerEXT(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glFogCoordPointerEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:FogPointerTypeEXT"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_fog_coord")]
		public static void FogCoordPointerEXT(FogPointerTypeEXT type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				FogCoordPointerEXT(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
