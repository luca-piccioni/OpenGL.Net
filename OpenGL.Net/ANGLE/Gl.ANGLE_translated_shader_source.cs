
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
		/// [GL] Value of GL_TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE symbol.
		/// </summary>
		[RequiredByFeature("GL_ANGLE_translated_shader_source", Api = "gles2")]
		public const int TRANSLATED_SHADER_SOURCE_LENGTH_ANGLE = 0x93A0;

		/// <summary>
		/// Binding for glGetTranslatedShaderSourceANGLE.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufsize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="source">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_ANGLE_translated_shader_source", Api = "gles2")]
		public static void GetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, out Int32 length, String source)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetTranslatedShaderSourceANGLE != null, "pglGetTranslatedShaderSourceANGLE not implemented");
					Delegates.pglGetTranslatedShaderSourceANGLE(shader, bufsize, p_length, source);
					LogCommand("glGetTranslatedShaderSourceANGLE", null, shader, bufsize, length, source					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTranslatedShaderSourceANGLE", ExactSpelling = true)]
			internal extern static unsafe void glGetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, Int32* length, String source);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ANGLE_translated_shader_source", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTranslatedShaderSourceANGLE(UInt32 shader, Int32 bufsize, Int32* length, String source);

			[ThreadStatic]
			internal static glGetTranslatedShaderSourceANGLE pglGetTranslatedShaderSourceANGLE;

		}
	}

}
