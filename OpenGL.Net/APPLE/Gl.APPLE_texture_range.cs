
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
		/// Value of GL_TEXTURE_RANGE_LENGTH_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_LENGTH_APPLE = 0x85B7;

		/// <summary>
		/// Value of GL_TEXTURE_RANGE_POINTER_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_RANGE_POINTER_APPLE = 0x85B8;

		/// <summary>
		/// Value of GL_TEXTURE_STORAGE_HINT_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int TEXTURE_STORAGE_HINT_APPLE = 0x85BC;

		/// <summary>
		/// Value of GL_STORAGE_PRIVATE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		public const int STORAGE_PRIVATE_APPLE = 0x85BD;

		/// <summary>
		/// Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TextureRangeAPPLE(int target, Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglTextureRangeAPPLE != null, "pglTextureRangeAPPLE not implemented");
			Delegates.pglTextureRangeAPPLE(target, length, pointer);
			CallLog("glTextureRangeAPPLE({0}, {1}, {2})", target, length, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTextureRangeAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void TextureRangeAPPLE(int target, Int32 length, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				TextureRangeAPPLE(target, length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glGetTexParameterPointervAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		public static void GetTexParameterPointerAPPLE(int target, int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglGetTexParameterPointervAPPLE != null, "pglGetTexParameterPointervAPPLE not implemented");
			Delegates.pglGetTexParameterPointervAPPLE(target, pname, @params);
			CallLog("glGetTexParameterPointervAPPLE({0}, {1}, {2})", target, pname, @params);
			DebugCheckErrors();
		}

	}

}
