
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
		/// Value of GL_TEXTURE_GEN_STR_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public const int TEXTURE_GEN_STR_OES = 0x8D60;

		/// <summary>
		/// Binding for glTexGenfOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenfOES != null, "pglTexGenfOES not implemented");
			Delegates.pglTexGenfOES(coord, pname, param);
			LogFunction("glTexGenfOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfvOES != null, "pglTexGenfvOES not implemented");
					Delegates.pglTexGenfvOES(coord, pname, p_params);
					LogFunction("glTexGenfvOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexGeniOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeniOES != null, "pglTexGeniOES not implemented");
			Delegates.pglTexGeniOES(coord, pname, param);
			LogFunction("glTexGeniOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void TexGenOES(Int32 coord, Int32 pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenivOES != null, "pglTexGenivOES not implemented");
					Delegates.pglTexGenivOES(coord, pname, p_params);
					LogFunction("glTexGenivOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexGenfvOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(Int32 coord, Int32 pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfvOES != null, "pglGetTexGenfvOES not implemented");
					Delegates.pglGetTexGenfvOES(coord, pname, p_params);
					LogFunction("glGetTexGenfvOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetTexGenivOES.
		/// </summary>
		/// <param name="coord">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		public static void GetTexGenOES(Int32 coord, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenivOES != null, "pglGetTexGenivOES not implemented");
					Delegates.pglGetTexGenivOES(coord, pname, p_params);
					LogFunction("glGetTexGenivOES({0}, {1}, {2})", LogEnumName(coord), LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
