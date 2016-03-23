
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
		/// Value of GL_ALPHA32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA32UI_EXT = 0x8D72;

		/// <summary>
		/// Value of GL_INTENSITY32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY32UI_EXT = 0x8D73;

		/// <summary>
		/// Value of GL_LUMINANCE32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE32UI_EXT = 0x8D74;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA32UI_EXT = 0x8D75;

		/// <summary>
		/// Value of GL_ALPHA16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA16UI_EXT = 0x8D78;

		/// <summary>
		/// Value of GL_INTENSITY16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY16UI_EXT = 0x8D79;

		/// <summary>
		/// Value of GL_LUMINANCE16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE16UI_EXT = 0x8D7A;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA16UI_EXT = 0x8D7B;

		/// <summary>
		/// Value of GL_ALPHA8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA8UI_EXT = 0x8D7E;

		/// <summary>
		/// Value of GL_INTENSITY8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY8UI_EXT = 0x8D7F;

		/// <summary>
		/// Value of GL_LUMINANCE8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE8UI_EXT = 0x8D80;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA8UI_EXT = 0x8D81;

		/// <summary>
		/// Value of GL_ALPHA32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA32I_EXT = 0x8D84;

		/// <summary>
		/// Value of GL_INTENSITY32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY32I_EXT = 0x8D85;

		/// <summary>
		/// Value of GL_LUMINANCE32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE32I_EXT = 0x8D86;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA32I_EXT = 0x8D87;

		/// <summary>
		/// Value of GL_ALPHA16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA16I_EXT = 0x8D8A;

		/// <summary>
		/// Value of GL_INTENSITY16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY16I_EXT = 0x8D8B;

		/// <summary>
		/// Value of GL_LUMINANCE16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE16I_EXT = 0x8D8C;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA16I_EXT = 0x8D8D;

		/// <summary>
		/// Value of GL_ALPHA8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA8I_EXT = 0x8D90;

		/// <summary>
		/// Value of GL_INTENSITY8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int INTENSITY8I_EXT = 0x8D91;

		/// <summary>
		/// Value of GL_LUMINANCE8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE8I_EXT = 0x8D92;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA8I_EXT = 0x8D93;

		/// <summary>
		/// Value of GL_LUMINANCE_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_INTEGER_EXT = 0x8D9C;

		/// <summary>
		/// Value of GL_LUMINANCE_ALPHA_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int LUMINANCE_ALPHA_INTEGER_EXT = 0x8D9D;

		/// <summary>
		/// Value of GL_RGBA_INTEGER_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA_INTEGER_MODE_EXT = 0x8D9E;

		/// <summary>
		/// Binding for glClearColorIiEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void ClearColorIEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Debug.Assert(Delegates.pglClearColorIiEXT != null, "pglClearColorIiEXT not implemented");
			Delegates.pglClearColorIiEXT(red, green, blue, alpha);
			LogFunction("glClearColorIiEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearColorIuiEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void ClearColorIEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			Debug.Assert(Delegates.pglClearColorIuiEXT != null, "pglClearColorIuiEXT not implemented");
			Delegates.pglClearColorIuiEXT(red, green, blue, alpha);
			LogFunction("glClearColorIuiEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors(null);
		}

	}

}
