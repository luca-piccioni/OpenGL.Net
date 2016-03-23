
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
		/// Value of GL_FRAGMENT_MATERIAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int FRAGMENT_MATERIAL_EXT = 0x8349;

		/// <summary>
		/// Value of GL_FRAGMENT_NORMAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int FRAGMENT_NORMAL_EXT = 0x834A;

		/// <summary>
		/// Value of GL_FRAGMENT_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int FRAGMENT_COLOR_EXT = 0x834C;

		/// <summary>
		/// Value of GL_ATTENUATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int ATTENUATION_EXT = 0x834D;

		/// <summary>
		/// Value of GL_SHADOW_ATTENUATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int SHADOW_ATTENUATION_EXT = 0x834E;

		/// <summary>
		/// Value of GL_TEXTURE_APPLICATION_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int TEXTURE_APPLICATION_MODE_EXT = 0x834F;

		/// <summary>
		/// Value of GL_TEXTURE_LIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int TEXTURE_LIGHT_EXT = 0x8350;

		/// <summary>
		/// Value of GL_TEXTURE_MATERIAL_FACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int TEXTURE_MATERIAL_FACE_EXT = 0x8351;

		/// <summary>
		/// Value of GL_TEXTURE_MATERIAL_PARAMETER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_light_texture")]
		public const int TEXTURE_MATERIAL_PARAMETER_EXT = 0x8352;

		/// <summary>
		/// Binding for glApplyTextureEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_light_texture")]
		public static void ApplyTextureEXT(Int32 mode)
		{
			Debug.Assert(Delegates.pglApplyTextureEXT != null, "pglApplyTextureEXT not implemented");
			Delegates.pglApplyTextureEXT(mode);
			LogFunction("glApplyTextureEXT({0})", LogEnumName(mode));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureLightEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_light_texture")]
		public static void TextureLightEXT(Int32 pname)
		{
			Debug.Assert(Delegates.pglTextureLightEXT != null, "pglTextureLightEXT not implemented");
			Delegates.pglTextureLightEXT(pname);
			LogFunction("glTextureLightEXT({0})", LogEnumName(pname));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTextureMaterialEXT.
		/// </summary>
		/// <param name="face">
		/// A <see cref="T:MaterialFace"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:MaterialParameter"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_light_texture")]
		public static void TextureMaterialEXT(MaterialFace face, MaterialParameter mode)
		{
			Debug.Assert(Delegates.pglTextureMaterialEXT != null, "pglTextureMaterialEXT not implemented");
			Delegates.pglTextureMaterialEXT((Int32)face, (Int32)mode);
			LogFunction("glTextureMaterialEXT({0}, {1})", face, mode);
			DebugCheckErrors(null);
		}

	}

}
