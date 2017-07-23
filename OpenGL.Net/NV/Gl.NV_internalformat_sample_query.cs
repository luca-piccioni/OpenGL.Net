
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
		/// [GL] Value of GL_MULTISAMPLES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int MULTISAMPLES_NV = 0x9371;

		/// <summary>
		/// [GL] Value of GL_SUPERSAMPLE_SCALE_X_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int SUPERSAMPLE_SCALE_X_NV = 0x9372;

		/// <summary>
		/// [GL] Value of GL_SUPERSAMPLE_SCALE_Y_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int SUPERSAMPLE_SCALE_Y_NV = 0x9373;

		/// <summary>
		/// [GL] Value of GL_CONFORMANT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public const int CONFORMANT_NV = 0x9374;

		/// <summary>
		/// [GL] Binding for glGetInternalformatSampleivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:InternalFormatPName"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public static void GetInternalformatSampleNV(TextureTarget target, InternalFormat internalformat, Int32 samples, InternalFormatPName pname, Int32 bufSize, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformatSampleivNV != null, "pglGetInternalformatSampleivNV not implemented");
					Delegates.pglGetInternalformatSampleivNV((Int32)target, (Int32)internalformat, samples, (Int32)pname, bufSize, p_params);
					LogCommand("glGetInternalformatSampleivNV", null, target, internalformat, samples, pname, bufSize, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetInternalformatSampleivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:InternalFormatPName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		public static void GetInternalformatSampleNV(TextureTarget target, InternalFormat internalformat, Int32 samples, InternalFormatPName pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetInternalformatSampleivNV != null, "pglGetInternalformatSampleivNV not implemented");
					Delegates.pglGetInternalformatSampleivNV((Int32)target, (Int32)internalformat, samples, (Int32)pname, (Int32)@params.Length, p_params);
					LogCommand("glGetInternalformatSampleivNV", null, target, internalformat, samples, pname, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glGetInternalformatSampleivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetInternalformatSampleivNV(Int32 target, Int32 internalformat, Int32 samples, Int32 pname, Int32 bufSize, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glGetInternalformatSampleivNV(Int32 target, Int32 internalformat, Int32 samples, Int32 pname, Int32 bufSize, Int32* @params);

			[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetInternalformatSampleivNV pglGetInternalformatSampleivNV;

		}
	}

}
