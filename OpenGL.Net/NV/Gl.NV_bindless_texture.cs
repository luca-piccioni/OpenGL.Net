
// Copyright (C) 2015-2016 Luca Piccioni
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static UInt64 GetTextureHandleNV(UInt32 texture)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureHandleNV != null, "pglGetTextureHandleNV not implemented");
			retValue = Delegates.pglGetTextureHandleNV(texture);
			LogFunction("glGetTextureHandleNV({0}) = {1}", texture, retValue);
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static UInt64 GetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureSamplerHandleNV != null, "pglGetTextureSamplerHandleNV not implemented");
			retValue = Delegates.pglGetTextureSamplerHandleNV(texture, sampler);
			LogFunction("glGetTextureSamplerHandleNV({0}, {1}) = {2}", texture, sampler, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void MakeTextureHandleResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleResidentNV != null, "pglMakeTextureHandleResidentNV not implemented");
			Delegates.pglMakeTextureHandleResidentNV(handle);
			LogFunction("glMakeTextureHandleResidentNV({0})", handle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleNonResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void MakeTextureHandleNonResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleNonResidentNV != null, "pglMakeTextureHandleNonResidentNV not implemented");
			Delegates.pglMakeTextureHandleNonResidentNV(handle);
			LogFunction("glMakeTextureHandleNonResidentNV({0})", handle);
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
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static UInt64 GetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetImageHandleNV != null, "pglGetImageHandleNV not implemented");
			retValue = Delegates.pglGetImageHandleNV(texture, level, layered, layer, format);
			LogFunction("glGetImageHandleNV({0}, {1}, {2}, {3}, {4}) = {5}", texture, level, layered, layer, LogEnumName(format), retValue);
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void MakeImageHandleResidentNV(UInt64 handle, Int32 access)
		{
			Debug.Assert(Delegates.pglMakeImageHandleResidentNV != null, "pglMakeImageHandleResidentNV not implemented");
			Delegates.pglMakeImageHandleResidentNV(handle, access);
			LogFunction("glMakeImageHandleResidentNV({0}, {1})", handle, LogEnumName(access));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeImageHandleNonResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void MakeImageHandleNonResidentNV(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeImageHandleNonResidentNV != null, "pglMakeImageHandleNonResidentNV not implemented");
			Delegates.pglMakeImageHandleNonResidentNV(handle);
			LogFunction("glMakeImageHandleNonResidentNV({0})", handle);
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void UniformHandleNV(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformHandleui64NV != null, "pglUniformHandleui64NV not implemented");
			Delegates.pglUniformHandleui64NV(location, value);
			LogFunction("glUniformHandleui64NV({0}, {1})", location, value);
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void UniformHandleNV(Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformHandleui64vNV != null, "pglUniformHandleui64vNV not implemented");
					Delegates.pglUniformHandleui64vNV(location, (Int32)value.Length, p_value);
					LogFunction("glUniformHandleui64vNV({0}, {1}, {2})", location, value.Length, LogValue(value));
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void ProgramUniformHandleNV(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformHandleui64NV != null, "pglProgramUniformHandleui64NV not implemented");
			Delegates.pglProgramUniformHandleui64NV(program, location, value);
			LogFunction("glProgramUniformHandleui64NV({0}, {1}, {2})", program, location, value);
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static void ProgramUniformHandleNV(UInt32 program, Int32 location, UInt64[] values)
		{
			unsafe {
				fixed (UInt64* p_values = values)
				{
					Debug.Assert(Delegates.pglProgramUniformHandleui64vNV != null, "pglProgramUniformHandleui64vNV not implemented");
					Delegates.pglProgramUniformHandleui64vNV(program, location, (Int32)values.Length, p_values);
					LogFunction("glProgramUniformHandleui64vNV({0}, {1}, {2}, {3})", program, location, values.Length, LogValue(values));
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
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static bool IsTextureHandleResidentNV(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureHandleResidentNV != null, "pglIsTextureHandleResidentNV not implemented");
			retValue = Delegates.pglIsTextureHandleResidentNV(handle);
			LogFunction("glIsTextureHandleResidentNV({0}) = {1}", handle, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsImageHandleResidentNV.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_bindless_texture", Api = "gl|gles2")]
		public static bool IsImageHandleResidentNV(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsImageHandleResidentNV != null, "pglIsImageHandleResidentNV not implemented");
			retValue = Delegates.pglIsImageHandleResidentNV(handle);
			LogFunction("glIsImageHandleResidentNV({0}) = {1}", handle, retValue);
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
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureHandleNV(UInt32 texture);

			[ThreadStatic]
			internal static glGetTextureHandleNV pglGetTextureHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureSamplerHandleNV(UInt32 texture, UInt32 sampler);

			[ThreadStatic]
			internal static glGetTextureSamplerHandleNV pglGetTextureSamplerHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleResidentNV pglMakeTextureHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleNonResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentNV pglMakeTextureHandleNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetImageHandleNV(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[ThreadStatic]
			internal static glGetImageHandleNV pglGetImageHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleResidentNV(UInt64 handle, Int32 access);

			[ThreadStatic]
			internal static glMakeImageHandleResidentNV pglMakeImageHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleNonResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glMakeImageHandleNonResidentNV pglMakeImageHandleNonResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformHandleui64NV(Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glUniformHandleui64NV pglUniformHandleui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformHandleui64vNV(Int32 location, Int32 count, UInt64* value);

			[ThreadStatic]
			internal static glUniformHandleui64vNV pglUniformHandleui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformHandleui64NV(UInt32 program, Int32 location, UInt64 value);

			[ThreadStatic]
			internal static glProgramUniformHandleui64NV pglProgramUniformHandleui64NV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformHandleui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[ThreadStatic]
			internal static glProgramUniformHandleui64vNV pglProgramUniformHandleui64vNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glIsTextureHandleResidentNV pglIsTextureHandleResidentNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsImageHandleResidentNV(UInt64 handle);

			[ThreadStatic]
			internal static glIsImageHandleResidentNV pglIsImageHandleResidentNV;

		}
	}

}
