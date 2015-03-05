
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
		/// Value of GL_TEXTURE_PRIORITY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_PRIORITY_EXT = 0x8066;

		/// <summary>
		/// Value of GL_TEXTURE_RESIDENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture_object")]
		public const int TEXTURE_RESIDENT_EXT = 0x8067;

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
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="residences">
		/// A <see cref="T:bool[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static bool AreTexturesResidentEXT(Int32 n, UInt32[] textures, bool[] residences)
		{
			Debug.Assert(textures.Length >= n);
			Debug.Assert(residences.Length >= n);

			bool retValue;

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (bool* p_residences = residences)
				{
					Debug.Assert(Delegates.pglAreTexturesResidentEXT != null, "pglAreTexturesResidentEXT not implemented");
					retValue = Delegates.pglAreTexturesResidentEXT(n, p_textures, p_residences);
					CallLog("glAreTexturesResidentEXT({0}, {1}, {2}) = {3}", n, textures, residences, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glBindTextureEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void BindTextureEXT(int target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTextureEXT != null, "pglBindTextureEXT not implemented");
			Delegates.pglBindTextureEXT(target, texture);
			CallLog("glBindTextureEXT({0}, {1})", target, texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBindTextureEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void BindTextureEXT(TextureTarget target, UInt32 texture)
		{
			Debug.Assert(Delegates.pglBindTextureEXT != null, "pglBindTextureEXT not implemented");
			Delegates.pglBindTextureEXT((int)target, texture);
			CallLog("glBindTextureEXT({0}, {1})", target, texture);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDeleteTexturesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void DeleteTexturesEXT(Int32 n, UInt32[] textures)
		{
			Debug.Assert(textures.Length >= n);

			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglDeleteTexturesEXT != null, "pglDeleteTexturesEXT not implemented");
					Delegates.pglDeleteTexturesEXT(n, p_textures);
					CallLog("glDeleteTexturesEXT({0}, {1})", n, textures);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGenTexturesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void GenTexturesEXT(Int32 n, UInt32[] textures)
		{
			Debug.Assert(textures.Length >= n);

			unsafe {
				fixed (UInt32* p_textures = textures)
				{
					Debug.Assert(Delegates.pglGenTexturesEXT != null, "pglGenTexturesEXT not implemented");
					Delegates.pglGenTexturesEXT(n, p_textures);
					CallLog("glGenTexturesEXT({0}, {1})", n, textures);
				}
			}
			DebugCheckErrors();
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
			CallLog("glIsTextureEXT({0}) = {1}", texture, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glPrioritizeTexturesEXT.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="priorities">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_object")]
		public static void PrioritizeTexturesEXT(Int32 n, UInt32[] textures, float[] priorities)
		{
			Debug.Assert(textures.Length >= n);
			Debug.Assert(priorities.Length >= n);

			unsafe {
				fixed (UInt32* p_textures = textures)
				fixed (float* p_priorities = priorities)
				{
					Debug.Assert(Delegates.pglPrioritizeTexturesEXT != null, "pglPrioritizeTexturesEXT not implemented");
					Delegates.pglPrioritizeTexturesEXT(n, p_textures, p_priorities);
					CallLog("glPrioritizeTexturesEXT({0}, {1}, {2})", n, textures, priorities);
				}
			}
			DebugCheckErrors();
		}

	}

}
