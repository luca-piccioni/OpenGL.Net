
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_TEXTURE_GEN_STR_OES symbol.
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
			LogCommand("glTexGenfOES", null, coord, pname, param			);
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
					LogCommand("glTexGenfvOES", null, coord, pname, @params					);
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
			LogCommand("glTexGeniOES", null, coord, pname, param			);
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
					LogCommand("glTexGenivOES", null, coord, pname, @params					);
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
					LogCommand("glGetTexGenfvOES", null, coord, pname, @params					);
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
					LogCommand("glGetTexGenivOES", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenfOES", ExactSpelling = true)]
			internal extern static void glTexGenfOES(Int32 coord, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGeniOES", ExactSpelling = true)]
			internal extern static void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGenfvOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGenivOES", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGenfOES(Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexGenfOES pglTexGenfOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexGenfvOES pglTexGenfvOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGeniOES(Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexGeniOES pglTexGeniOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexGenivOES pglTexGenivOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenfvOES(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexGenfvOES pglGetTexGenfvOES;

			[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenivOES(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexGenivOES pglGetTexGenivOES;

		}
	}

}
