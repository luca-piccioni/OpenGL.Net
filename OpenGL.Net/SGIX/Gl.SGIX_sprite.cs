
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
		/// Value of GL_SPRITE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_SGIX = 0x8148;

		/// <summary>
		/// Value of GL_SPRITE_MODE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_MODE_SGIX = 0x8149;

		/// <summary>
		/// Value of GL_SPRITE_AXIS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_AXIS_SGIX = 0x814A;

		/// <summary>
		/// Value of GL_SPRITE_TRANSLATION_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_TRANSLATION_SGIX = 0x814B;

		/// <summary>
		/// Value of GL_SPRITE_AXIAL_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_AXIAL_SGIX = 0x814C;

		/// <summary>
		/// Value of GL_SPRITE_OBJECT_ALIGNED_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_OBJECT_ALIGNED_SGIX = 0x814D;

		/// <summary>
		/// Value of GL_SPRITE_EYE_ALIGNED_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		public const int SPRITE_EYE_ALIGNED_SGIX = 0x814E;

		/// <summary>
		/// Binding for glSpriteParameterfSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglSpriteParameterfSGIX != null, "pglSpriteParameterfSGIX not implemented");
			Delegates.pglSpriteParameterfSGIX(pname, param);
			CallLog("glSpriteParameterfSGIX({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSpriteParameterfvSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglSpriteParameterfvSGIX != null, "pglSpriteParameterfvSGIX not implemented");
					Delegates.pglSpriteParameterfvSGIX(pname, p_params);
					CallLog("glSpriteParameterfvSGIX({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSpriteParameteriSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglSpriteParameteriSGIX != null, "pglSpriteParameteriSGIX not implemented");
			Delegates.pglSpriteParameteriSGIX(pname, param);
			CallLog("glSpriteParameteriSGIX({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glSpriteParameterivSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_sprite")]
		public static void SpriteParameterSGIX(Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglSpriteParameterivSGIX != null, "pglSpriteParameterivSGIX not implemented");
					Delegates.pglSpriteParameterivSGIX(pname, p_params);
					CallLog("glSpriteParameterivSGIX({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
