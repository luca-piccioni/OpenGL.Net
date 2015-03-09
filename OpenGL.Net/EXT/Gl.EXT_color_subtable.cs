
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
		/// Binding for glColorSubTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
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
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, IntPtr data)
		{
			Debug.Assert(Delegates.pglColorSubTableEXT != null, "pglColorSubTableEXT not implemented");
			Delegates.pglColorSubTableEXT(target, start, count, format, type, data);
			CallLog("glColorSubTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorSubTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTableEXT(int target, Int32 start, Int32 count, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglColorSubTableEXT != null, "pglColorSubTableEXT not implemented");
			Delegates.pglColorSubTableEXT(target, start, count, (int)format, (int)type, data);
			CallLog("glColorSubTableEXT({0}, {1}, {2}, {3}, {4}, {5})", target, start, count, format, type, data);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glColorSubTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTableEXT(int target, Int32 start, Int32 count, int format, int type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ColorSubTableEXT(target, start, count, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glColorSubTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:PixelType"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void ColorSubTableEXT(int target, Int32 start, Int32 count, PixelFormat format, PixelType type, Object data)
		{
			GCHandle pin_data = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				ColorSubTableEXT(target, start, count, format, type, pin_data.AddrOfPinnedObject());
			} finally {
				pin_data.Free();
			}
		}

		/// <summary>
		/// Binding for glCopyColorSubTableEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_color_subtable")]
		public static void CopyColorSubTableEXT(int target, Int32 start, Int32 x, Int32 y, Int32 width)
		{
			Debug.Assert(Delegates.pglCopyColorSubTableEXT != null, "pglCopyColorSubTableEXT not implemented");
			Delegates.pglCopyColorSubTableEXT(target, start, x, y, width);
			CallLog("glCopyColorSubTableEXT({0}, {1}, {2}, {3}, {4})", target, start, x, y, width);
			DebugCheckErrors();
		}

	}

}
