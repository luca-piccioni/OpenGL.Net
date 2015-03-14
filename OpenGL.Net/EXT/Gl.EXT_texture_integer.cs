
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
		/// Value of GL_RGBA32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA32UI_EXT = 0x8D70;

		/// <summary>
		/// Value of GL_RGB32UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB32UI_EXT = 0x8D71;

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
		/// Value of GL_RGBA16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA16UI_EXT = 0x8D76;

		/// <summary>
		/// Value of GL_RGB16UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB16UI_EXT = 0x8D77;

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
		/// Value of GL_RGBA8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA8UI_EXT = 0x8D7C;

		/// <summary>
		/// Value of GL_RGB8UI_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB8UI_EXT = 0x8D7D;

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
		/// Value of GL_RGBA32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA32I_EXT = 0x8D82;

		/// <summary>
		/// Value of GL_RGB32I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB32I_EXT = 0x8D83;

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
		/// Value of GL_RGBA16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA16I_EXT = 0x8D88;

		/// <summary>
		/// Value of GL_RGB16I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB16I_EXT = 0x8D89;

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
		/// Value of GL_RGBA8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA8I_EXT = 0x8D8E;

		/// <summary>
		/// Value of GL_RGB8I_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB8I_EXT = 0x8D8F;

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
		/// Value of GL_RED_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RED_INTEGER_EXT = 0x8D94;

		/// <summary>
		/// Value of GL_GREEN_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int GREEN_INTEGER_EXT = 0x8D95;

		/// <summary>
		/// Value of GL_BLUE_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BLUE_INTEGER_EXT = 0x8D96;

		/// <summary>
		/// Value of GL_ALPHA_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int ALPHA_INTEGER_EXT = 0x8D97;

		/// <summary>
		/// Value of GL_RGB_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGB_INTEGER_EXT = 0x8D98;

		/// <summary>
		/// Value of GL_RGBA_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int RGBA_INTEGER_EXT = 0x8D99;

		/// <summary>
		/// Value of GL_BGR_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BGR_INTEGER_EXT = 0x8D9A;

		/// <summary>
		/// Value of GL_BGRA_INTEGER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public const int BGRA_INTEGER_EXT = 0x8D9B;

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
		/// Binding for glTexParameterIivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void TexParameterIivEXT(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIivEXT != null, "pglTexParameterIivEXT not implemented");
					Delegates.pglTexParameterIivEXT((int)target, (int)pname, p_params);
					CallLog("glTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void TexParameterIuivEXT(TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIuivEXT != null, "pglTexParameterIuivEXT not implemented");
					Delegates.pglTexParameterIuivEXT((int)target, (int)pname, p_params);
					CallLog("glTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void GetTexParameterIivEXT(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIivEXT != null, "pglGetTexParameterIivEXT not implemented");
					Delegates.pglGetTexParameterIivEXT((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetTexParameterIuivEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:GetTextureParameter"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_integer")]
		public static void GetTexParameterIuivEXT(TextureTarget target, GetTextureParameter pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIuivEXT != null, "pglGetTexParameterIuivEXT not implemented");
					Delegates.pglGetTexParameterIuivEXT((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIuivEXT({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

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
			CallLog("glClearColorIiEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
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
			CallLog("glClearColorIuiEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

	}

}
