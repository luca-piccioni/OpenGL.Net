
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
		/// Value of GL_TEXTURE_1D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_1D_BINDING_EXT = 0x8068;

		/// <summary>
		/// Value of GL_TEXTURE_2D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_2D_BINDING_EXT = 0x8069;

		/// <summary>
		/// Value of GL_TEXTURE_3D_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_3D_BINDING_EXT = 0x806A;

		/// <summary>
		/// Binding for glAreTexturesResidentEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static bool AreTexturesResidentEXT(UInt32[] textures, [Out] bool[] residences)
		{
			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResidentEXT != null, "pglAreTexturesResidentEXT not implemented");
					retValue = Delegates.pglAreTexturesResidentEXT((Int32)textures.Length, p_textures, p_residences);
					LogFunction("glAreTexturesResidentEXT({0}, {1}, {2}) = {3}", textures.Length, LogValue(textures), LogValue(residences), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glDeleteTexturesEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void DeleteTexturesEXT(params UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTexturesEXT != null, "pglDeleteTexturesEXT not implemented");
					Delegates.pglDeleteTexturesEXT((Int32)textures.Length, p_textures);
					LogFunction("glDeleteTexturesEXT({0}, {1})", textures.Length, LogValue(textures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenTexturesEXT.
		/// </summary>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void GenTexturesEXT(UInt32[] textures)
		{
			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTexturesEXT != null, "pglGenTexturesEXT not implemented");
					Delegates.pglGenTexturesEXT((Int32)textures.Length, p_textures);
					LogFunction("glGenTexturesEXT({0}, {1})", textures.Length, LogValue(textures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenTexturesEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static UInt32 GenTexturesEXT()
		{
			UInt32[] retValue = new UInt32[1];
			GenTexturesEXT(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glIsTextureEXT.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static bool IsTextureEXT(UInt32 texture)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureEXT != null, "pglIsTextureEXT not implemented");
			retValue = Delegates.pglIsTextureEXT(texture);
			LogFunction("glIsTextureEXT({0}) = {1}", texture, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
