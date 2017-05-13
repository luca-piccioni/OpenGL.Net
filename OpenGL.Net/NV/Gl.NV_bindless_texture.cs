
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
		/// Binding for glGetTextureHandleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static UInt64 GetTextureHandleNV(UInt32 texture)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureHandleNV != null, "pglGetTextureHandleNV not implemented");
			retValue = Delegates.pglGetTextureHandleNV(texture);
			LogCommand("glGetTextureHandleNV", retValue, texture			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetTextureSamplerHandleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static UInt64 GetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureSamplerHandleNV != null, "pglGetTextureSamplerHandleNV not implemented");
			retValue = Delegates.pglGetTextureSamplerHandleNV(texture, sampler);
			LogCommand("glGetTextureSamplerHandleNV", retValue, texture, sampler			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void MakeTextureHandleResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleResidentNV != null, "pglMakeTextureHandleResidentNV not implemented");
			Delegates.pglMakeTextureHandleResidentNV(handle);
			LogCommand("glMakeTextureHandleResidentNV", null, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleNonResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void MakeTextureHandleNonResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleNonResidentNV != null, "pglMakeTextureHandleNonResidentNV not implemented");
			Delegates.pglMakeTextureHandleNonResidentNV(handle);
			LogCommand("glMakeTextureHandleNonResidentNV", null, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetImageHandleNV.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layered">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:PixelFormat"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static UInt64 GetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, PixelFormat format)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetImageHandleNV != null, "pglGetImageHandleNV not implemented");
			retValue = Delegates.pglGetImageHandleNV(texture, level, layered, layer, (Int32)format);
			LogCommand("glGetImageHandleNV", retValue, texture, level, layered, layer, format			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeImageHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void MakeImageHandleResidentNV(UInt64 handle, Int32 access)
		{
			Debug.Assert(Delegates.pglMakeImageHandleResidentNV != null, "pglMakeImageHandleResidentNV not implemented");
			Delegates.pglMakeImageHandleResidentNV(handle, access);
			LogCommand("glMakeImageHandleResidentNV", null, handle, access			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeImageHandleNonResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void MakeImageHandleNonResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeImageHandleNonResidentNV != null, "pglMakeImageHandleNonResidentNV not implemented");
			Delegates.pglMakeImageHandleNonResidentNV(handle);
			LogCommand("glMakeImageHandleNonResidentNV", null, handle			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformHandleui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void UniformHandleNV(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformHandleui64NV != null, "pglUniformHandleui64NV not implemented");
			Delegates.pglUniformHandleui64NV(location, value);
			LogCommand("glUniformHandleui64NV", null, location, value			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformHandleui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void UniformHandleNV(Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformHandleui64vNV != null, "pglUniformHandleui64vNV not implemented");
					Delegates.pglUniformHandleui64vNV(location, (Int32)value.Length, p_value);
					LogCommand("glUniformHandleui64vNV", null, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void ProgramUniformHandleNV(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformHandleui64NV != null, "pglProgramUniformHandleui64NV not implemented");
			Delegates.pglProgramUniformHandleui64NV(program, location, value);
			LogCommand("glProgramUniformHandleui64NV", null, program, location, value			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static void ProgramUniformHandleNV(UInt32 program, Int32 location, UInt64[] values)
		{
			unsafe {
				fixed (UInt64* p_values = values)
				{
					Debug.Assert(Delegates.pglProgramUniformHandleui64vNV != null, "pglProgramUniformHandleui64vNV not implemented");
					Delegates.pglProgramUniformHandleui64vNV(program, location, (Int32)values.Length, p_values);
					LogCommand("glProgramUniformHandleui64vNV", null, program, location, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsTextureHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static bool IsTextureHandleResidentNV(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureHandleResidentNV != null, "pglIsTextureHandleResidentNV not implemented");
			retValue = Delegates.pglIsTextureHandleResidentNV(handle);
			LogCommand("glIsTextureHandleResidentNV", retValue, handle			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsImageHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
		public static bool IsImageHandleResidentNV(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsImageHandleResidentNV != null, "pglIsImageHandleResidentNV not implemented");
			retValue = Delegates.pglIsImageHandleResidentNV(handle);
			LogCommand("glIsImageHandleResidentNV", retValue, handle			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureHandleNV(UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureSamplerHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeTextureHandleResidentNV", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleResidentNV(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeTextureHandleNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleNonResidentNV(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetImageHandleNV", ExactSpelling = true)]
			internal extern static UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeImageHandleResidentNV", ExactSpelling = true)]
			internal extern static void glMakeImageHandleResidentNV(UInt64 handle, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeImageHandleNonResidentNV", ExactSpelling = true)]
			internal extern static void glMakeImageHandleNonResidentNV(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformHandleui64NV", ExactSpelling = true)]
			internal extern static void glUniformHandleui64NV(Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformHandleui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsTextureHandleResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTextureHandleResidentNV(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsImageHandleResidentNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsImageHandleResidentNV(UInt64 handle);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureHandleNV(UInt32 texture);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetTextureHandleNV pglGetTextureHandleNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetTextureSamplerHandleNV pglGetTextureSamplerHandleNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleResidentNV(UInt64 handle);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glMakeTextureHandleResidentNV pglMakeTextureHandleResidentNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleNonResidentNV(UInt64 handle);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentNV pglMakeTextureHandleNonResidentNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetImageHandleNV pglGetImageHandleNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleResidentNV(UInt64 handle, Int32 access);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glMakeImageHandleResidentNV pglMakeImageHandleResidentNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleNonResidentNV(UInt64 handle);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glMakeImageHandleNonResidentNV pglMakeImageHandleNonResidentNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformHandleui64NV(Int32 location, UInt64 value);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniformHandleui64NV pglUniformHandleui64NV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniformHandleui64vNV pglUniformHandleui64vNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniformHandleui64NV pglProgramUniformHandleui64NV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniformHandleui64vNV pglProgramUniformHandleui64vNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureHandleResidentNV(UInt64 handle);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glIsTextureHandleResidentNV pglIsTextureHandleResidentNV;

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsImageHandleResidentNV(UInt64 handle);

			[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glIsImageHandleResidentNV pglIsImageHandleResidentNV;

		}
	}

}
