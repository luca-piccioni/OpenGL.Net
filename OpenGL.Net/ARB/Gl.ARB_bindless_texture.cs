
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
		/// Value of GL_UNSIGNED_INT64_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_NV")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public const int UNSIGNED_INT64_ARB = 0x140F;

		/// <summary>
		/// Binding for glGetTextureHandleARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glGetTextureHandleIMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static UInt64 GetTextureHandleARB(UInt32 texture)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureHandleARB != null, "pglGetTextureHandleARB not implemented");
			retValue = Delegates.pglGetTextureHandleARB(texture);
			LogFunction("glGetTextureHandleARB({0}) = {1}", texture, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetTextureSamplerHandleARB.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sampler">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[AliasOf("glGetTextureSamplerHandleIMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static UInt64 GetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetTextureSamplerHandleARB != null, "pglGetTextureSamplerHandleARB not implemented");
			retValue = Delegates.pglGetTextureSamplerHandleARB(texture, sampler);
			LogFunction("glGetTextureSamplerHandleARB({0}, {1}) = {2}", texture, sampler, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void MakeTextureHandleResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleResidentARB != null, "pglMakeTextureHandleResidentARB not implemented");
			Delegates.pglMakeTextureHandleResidentARB(handle);
			LogFunction("glMakeTextureHandleResidentARB({0})", handle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeTextureHandleNonResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void MakeTextureHandleNonResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeTextureHandleNonResidentARB != null, "pglMakeTextureHandleNonResidentARB not implemented");
			Delegates.pglMakeTextureHandleNonResidentARB(handle);
			LogFunction("glMakeTextureHandleNonResidentARB({0})", handle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetImageHandleARB.
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
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static UInt64 GetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format)
		{
			UInt64 retValue;

			Debug.Assert(Delegates.pglGetImageHandleARB != null, "pglGetImageHandleARB not implemented");
			retValue = Delegates.pglGetImageHandleARB(texture, level, layered, layer, format);
			LogFunction("glGetImageHandleARB({0}, {1}, {2}, {3}, {4}) = {5}", texture, level, layered, layer, LogEnumName(format), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeImageHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void MakeImageHandleResidentARB(UInt64 handle, Int32 access)
		{
			Debug.Assert(Delegates.pglMakeImageHandleResidentARB != null, "pglMakeImageHandleResidentARB not implemented");
			Delegates.pglMakeImageHandleResidentARB(handle, access);
			LogFunction("glMakeImageHandleResidentARB({0}, {1})", handle, LogEnumName(access));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMakeImageHandleNonResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void MakeImageHandleNonResidentARB(UInt64 handle)
		{
			Debug.Assert(Delegates.pglMakeImageHandleNonResidentARB != null, "pglMakeImageHandleNonResidentARB not implemented");
			Delegates.pglMakeImageHandleNonResidentARB(handle);
			LogFunction("glMakeImageHandleNonResidentARB({0})", handle);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformHandleui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[AliasOf("glUniformHandleui64IMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static void UniformHandleARB(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformHandleui64ARB != null, "pglUniformHandleui64ARB not implemented");
			Delegates.pglUniformHandleui64ARB(location, value);
			LogFunction("glUniformHandleui64ARB({0}, {1})", location, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniformHandleui64vARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[AliasOf("glUniformHandleui64vIMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static void UniformHandleARB(Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformHandleui64vARB != null, "pglUniformHandleui64vARB not implemented");
					Delegates.pglUniformHandleui64vARB(location, (Int32)value.Length, p_value);
					LogFunction("glUniformHandleui64vARB({0}, {1}, {2})", location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64ARB.
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
		[AliasOf("glProgramUniformHandleui64IMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static void ProgramUniformHandleARB(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformHandleui64ARB != null, "pglProgramUniformHandleui64ARB not implemented");
			Delegates.pglProgramUniformHandleui64ARB(program, location, value);
			LogFunction("glProgramUniformHandleui64ARB({0}, {1}, {2})", program, location, value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniformHandleui64vARB.
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
		[AliasOf("glProgramUniformHandleui64vIMG")]
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
		public static void ProgramUniformHandleARB(UInt32 program, Int32 location, UInt64[] values)
		{
			unsafe {
				fixed (UInt64* p_values = values)
				{
					Debug.Assert(Delegates.pglProgramUniformHandleui64vARB != null, "pglProgramUniformHandleui64vARB not implemented");
					Delegates.pglProgramUniformHandleui64vARB(program, location, (Int32)values.Length, p_values);
					LogFunction("glProgramUniformHandleui64vARB({0}, {1}, {2}, {3})", program, location, values.Length, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsTextureHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static bool IsTextureHandleResidentARB(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsTextureHandleResidentARB != null, "pglIsTextureHandleResidentARB not implemented");
			retValue = Delegates.pglIsTextureHandleResidentARB(handle);
			LogFunction("glIsTextureHandleResidentARB({0}) = {1}", handle, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glIsImageHandleResidentARB.
		/// </summary>
		/// <param name="handle">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static bool IsImageHandleResidentARB(UInt64 handle)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsImageHandleResidentARB != null, "pglIsImageHandleResidentARB not implemented");
			retValue = Delegates.pglIsImageHandleResidentARB(handle);
			LogFunction("glIsImageHandleResidentARB({0}) = {1}", handle, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64ARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void VertexAttribL1ARB(UInt32 index, UInt64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1ui64ARB != null, "pglVertexAttribL1ui64ARB not implemented");
			Delegates.pglVertexAttribL1ui64ARB(index, x);
			LogFunction("glVertexAttribL1ui64ARB({0}, {1})", index, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexAttribL1ui64vARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void VertexAttribL1ARB(UInt32 index, UInt64[] v)
		{
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1ui64vARB != null, "pglVertexAttribL1ui64vARB not implemented");
					Delegates.pglVertexAttribL1ui64vARB(index, p_v);
					LogFunction("glVertexAttribL1ui64vARB({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetVertexAttribLui64vARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
		public static void GetVertexAttribLARB(UInt32 index, Int32 pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLui64vARB != null, "pglGetVertexAttribLui64vARB not implemented");
					Delegates.pglGetVertexAttribLui64vARB(index, pname, p_params);
					LogFunction("glGetVertexAttribLui64vARB({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureHandleARB(UInt32 texture);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTextureSamplerHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeTextureHandleResidentARB", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleResidentARB(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeTextureHandleNonResidentARB", ExactSpelling = true)]
			internal extern static void glMakeTextureHandleNonResidentARB(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetImageHandleARB", ExactSpelling = true)]
			internal extern static UInt64 glGetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeImageHandleResidentARB", ExactSpelling = true)]
			internal extern static void glMakeImageHandleResidentARB(UInt64 handle, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMakeImageHandleNonResidentARB", ExactSpelling = true)]
			internal extern static void glMakeImageHandleNonResidentARB(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformHandleui64ARB", ExactSpelling = true)]
			internal extern static void glUniformHandleui64ARB(Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformHandleui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glUniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64ARB", ExactSpelling = true)]
			internal extern static void glProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniformHandleui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsTextureHandleResidentARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsTextureHandleResidentARB(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsImageHandleResidentARB", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsImageHandleResidentARB(UInt64 handle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64ARB", ExactSpelling = true)]
			internal extern static void glVertexAttribL1ui64ARB(UInt32 index, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexAttribL1ui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glVertexAttribL1ui64vARB(UInt32 index, UInt64* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetVertexAttribLui64vARB", ExactSpelling = true)]
			internal extern static unsafe void glGetVertexAttribLui64vARB(UInt32 index, Int32 pname, UInt64* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureHandleARB(UInt32 texture);

			[AliasOf("glGetTextureHandleARB")]
			[AliasOf("glGetTextureHandleIMG")]
			[ThreadStatic]
			internal static glGetTextureHandleARB pglGetTextureHandleARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetTextureSamplerHandleARB(UInt32 texture, UInt32 sampler);

			[AliasOf("glGetTextureSamplerHandleARB")]
			[AliasOf("glGetTextureSamplerHandleIMG")]
			[ThreadStatic]
			internal static glGetTextureSamplerHandleARB pglGetTextureSamplerHandleARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleResidentARB pglMakeTextureHandleResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeTextureHandleNonResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeTextureHandleNonResidentARB pglMakeTextureHandleNonResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 glGetImageHandleARB(UInt32 texture, Int32 level, bool layered, Int32 layer, Int32 format);

			[ThreadStatic]
			internal static glGetImageHandleARB pglGetImageHandleARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleResidentARB(UInt64 handle, Int32 access);

			[ThreadStatic]
			internal static glMakeImageHandleResidentARB pglMakeImageHandleResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMakeImageHandleNonResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glMakeImageHandleNonResidentARB pglMakeImageHandleNonResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformHandleui64ARB(Int32 location, UInt64 value);

			[AliasOf("glUniformHandleui64ARB")]
			[AliasOf("glUniformHandleui64IMG")]
			[ThreadStatic]
			internal static glUniformHandleui64ARB pglUniformHandleui64ARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniformHandleui64vARB(Int32 location, Int32 count, UInt64* value);

			[AliasOf("glUniformHandleui64vARB")]
			[AliasOf("glUniformHandleui64vIMG")]
			[ThreadStatic]
			internal static glUniformHandleui64vARB pglUniformHandleui64vARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniformHandleui64ARB(UInt32 program, Int32 location, UInt64 value);

			[AliasOf("glProgramUniformHandleui64ARB")]
			[AliasOf("glProgramUniformHandleui64IMG")]
			[ThreadStatic]
			internal static glProgramUniformHandleui64ARB pglProgramUniformHandleui64ARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[RequiredByFeature("GL_IMG_bindless_texture", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniformHandleui64vARB(UInt32 program, Int32 location, Int32 count, UInt64* values);

			[AliasOf("glProgramUniformHandleui64vARB")]
			[AliasOf("glProgramUniformHandleui64vIMG")]
			[ThreadStatic]
			internal static glProgramUniformHandleui64vARB pglProgramUniformHandleui64vARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsTextureHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glIsTextureHandleResidentARB pglIsTextureHandleResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsImageHandleResidentARB(UInt64 handle);

			[ThreadStatic]
			internal static glIsImageHandleResidentARB pglIsImageHandleResidentARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64ARB(UInt32 index, UInt64 x);

			[ThreadStatic]
			internal static glVertexAttribL1ui64ARB pglVertexAttribL1ui64ARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vARB(UInt32 index, UInt64* v);

			[ThreadStatic]
			internal static glVertexAttribL1ui64vARB pglVertexAttribL1ui64vARB;

			[RequiredByFeature("GL_ARB_bindless_texture", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vARB(UInt32 index, Int32 pname, UInt64* @params);

			[ThreadStatic]
			internal static glGetVertexAttribLui64vARB pglGetVertexAttribLui64vARB;

		}
	}

}
