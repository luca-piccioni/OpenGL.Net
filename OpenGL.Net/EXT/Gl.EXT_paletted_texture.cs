
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
		/// Value of GL_COLOR_INDEX1_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX1_EXT = 0x80E2;

		/// <summary>
		/// Value of GL_COLOR_INDEX2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX2_EXT = 0x80E3;

		/// <summary>
		/// Value of GL_COLOR_INDEX4_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX4_EXT = 0x80E4;

		/// <summary>
		/// Value of GL_COLOR_INDEX8_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX8_EXT = 0x80E5;

		/// <summary>
		/// Value of GL_COLOR_INDEX12_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX12_EXT = 0x80E6;

		/// <summary>
		/// Value of GL_COLOR_INDEX16_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int COLOR_INDEX16_EXT = 0x80E7;

		/// <summary>
		/// Value of GL_TEXTURE_INDEX_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public const int TEXTURE_INDEX_SIZE_EXT = 0x80ED;

		/// <summary>
		/// Binding for glColorTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void ColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, IntPtr table)
		{
			Debug.Assert(Delegates.pglColorTableEXT != null, "pglColorTableEXT not implemented");
			Delegates.pglColorTableEXT(target, internalFormat, width, format, type, table);
			CallLog("glColorTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalFormat, width, format, type, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void ColorTableEXT(int target, int internalFormat, Int32 width, PixelFormat format, PixelType type, IntPtr table)
		{
			Debug.Assert(Delegates.pglColorTableEXT != null, "pglColorTableEXT not implemented");
			Delegates.pglColorTableEXT(target, internalFormat, width, (int)format, (int)type, table);
			CallLog("glColorTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, internalFormat, width, format, type, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void ColorTableEXT(int target, int internalFormat, Int32 width, int format, int type, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				ColorTableEXT(target, internalFormat, width, format, type, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetColorTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableEXT(int target, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetColorTableEXT != null, "pglGetColorTableEXT not implemented");
			Delegates.pglGetColorTableEXT(target, format, type, data);
			CallLog("glGetColorTableEXT({0}, {1}, {2}, {3})", target, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableEXT(int target, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglGetColorTableEXT != null, "pglGetColorTableEXT not implemented");
			Delegates.pglGetColorTableEXT(target, (int)format, (int)type, data);
			CallLog("glGetColorTableEXT({0}, {1}, {2}, {3})", target, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableParameterivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableParameterEXT(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterivEXT != null, "pglGetColorTableParameterivEXT not implemented");
					Delegates.pglGetColorTableParameterivEXT(target, pname, p_params);
					CallLog("glGetColorTableParameterivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetColorTableParameterfvEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_paletted_texture")]
		public static void GetColorTableParameterEXT(int target, int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetColorTableParameterfvEXT != null, "pglGetColorTableParameterfvEXT not implemented");
					Delegates.pglGetColorTableParameterfvEXT(target, pname, p_params);
					CallLog("glGetColorTableParameterfvEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
