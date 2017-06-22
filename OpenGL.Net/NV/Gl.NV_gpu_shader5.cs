
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
		/// [GL] Value of GL_INT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT8_NV = 0x8FE0;

		/// <summary>
		/// [GL] Value of GL_INT8_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT8_VEC2_NV = 0x8FE1;

		/// <summary>
		/// [GL] Value of GL_INT8_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT8_VEC3_NV = 0x8FE2;

		/// <summary>
		/// [GL] Value of GL_INT8_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT8_VEC4_NV = 0x8FE3;

		/// <summary>
		/// [GL] Value of GL_INT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT16_NV = 0x8FE4;

		/// <summary>
		/// [GL] Value of GL_INT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT16_VEC2_NV = 0x8FE5;

		/// <summary>
		/// [GL] Value of GL_INT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT16_VEC3_NV = 0x8FE6;

		/// <summary>
		/// [GL] Value of GL_INT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int INT16_VEC4_NV = 0x8FE7;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT8_NV = 0x8FEC;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT8_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT8_VEC2_NV = 0x8FED;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT8_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT8_VEC3_NV = 0x8FEE;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT8_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT8_VEC4_NV = 0x8FEF;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT16_NV = 0x8FF0;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT16_VEC2_NV = 0x8FF1;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT16_VEC3_NV = 0x8FF2;

		/// <summary>
		/// [GL] Value of GL_UNSIGNED_INT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int UNSIGNED_INT16_VEC4_NV = 0x8FF3;

		/// <summary>
		/// [GL] Value of GL_FLOAT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int FLOAT16_NV = 0x8FF8;

		/// <summary>
		/// [GL] Value of GL_FLOAT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int FLOAT16_VEC2_NV = 0x8FF9;

		/// <summary>
		/// [GL] Value of GL_FLOAT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int FLOAT16_VEC3_NV = 0x8FFA;

		/// <summary>
		/// [GL] Value of GL_FLOAT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_half_float")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public const int FLOAT16_VEC4_NV = 0x8FFB;

		/// <summary>
		/// [GL] Binding for glUniform1i64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform1NV(Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglUniform1i64NV != null, "pglUniform1i64NV not implemented");
			Delegates.pglUniform1i64NV(location, x);
			LogCommand("glUniform1i64NV", null, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2i64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform2NV(Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglUniform2i64NV != null, "pglUniform2i64NV not implemented");
			Delegates.pglUniform2i64NV(location, x, y);
			LogCommand("glUniform2i64NV", null, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3i64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform3NV(Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglUniform3i64NV != null, "pglUniform3i64NV not implemented");
			Delegates.pglUniform3i64NV(location, x, y, z);
			LogCommand("glUniform3i64NV", null, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4i64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform4NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglUniform4i64NV != null, "pglUniform4i64NV not implemented");
			Delegates.pglUniform4i64NV(location, x, y, z, w);
			LogCommand("glUniform4i64NV", null, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1i64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform1NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1i64vNV != null, "pglUniform1i64vNV not implemented");
					Delegates.pglUniform1i64vNV(location, count, p_value);
					LogCommand("glUniform1i64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2i64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform2NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2i64vNV != null, "pglUniform2i64vNV not implemented");
					Delegates.pglUniform2i64vNV(location, count, p_value);
					LogCommand("glUniform2i64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3i64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform3NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3i64vNV != null, "pglUniform3i64vNV not implemented");
					Delegates.pglUniform3i64vNV(location, count, p_value);
					LogCommand("glUniform3i64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4i64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform4NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4i64vNV != null, "pglUniform4i64vNV not implemented");
					Delegates.pglUniform4i64vNV(location, count, p_value);
					LogCommand("glUniform4i64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1ui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform1NV(Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglUniform1ui64NV != null, "pglUniform1ui64NV not implemented");
			Delegates.pglUniform1ui64NV(location, x);
			LogCommand("glUniform1ui64NV", null, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2ui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform2NV(Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglUniform2ui64NV != null, "pglUniform2ui64NV not implemented");
			Delegates.pglUniform2ui64NV(location, x, y);
			LogCommand("glUniform2ui64NV", null, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3ui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform3NV(Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglUniform3ui64NV != null, "pglUniform3ui64NV not implemented");
			Delegates.pglUniform3ui64NV(location, x, y, z);
			LogCommand("glUniform3ui64NV", null, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4ui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform4NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglUniform4ui64NV != null, "pglUniform4ui64NV not implemented");
			Delegates.pglUniform4ui64NV(location, x, y, z, w);
			LogCommand("glUniform4ui64NV", null, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform1ui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform1NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1ui64vNV != null, "pglUniform1ui64vNV not implemented");
					Delegates.pglUniform1ui64vNV(location, count, p_value);
					LogCommand("glUniform1ui64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform2ui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform2NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2ui64vNV != null, "pglUniform2ui64vNV not implemented");
					Delegates.pglUniform2ui64vNV(location, count, p_value);
					LogCommand("glUniform2ui64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform3ui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform3NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3ui64vNV != null, "pglUniform3ui64vNV not implemented");
					Delegates.pglUniform3ui64vNV(location, count, p_value);
					LogCommand("glUniform3ui64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glUniform4ui64vNV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void Uniform4NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4ui64vNV != null, "pglUniform4ui64vNV not implemented");
					Delegates.pglUniform4ui64vNV(location, count, p_value);
					LogCommand("glUniform4ui64vNV", null, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetUniformi64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void GetUniformNV(UInt32 program, Int32 location, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformi64vNV != null, "pglGetUniformi64vNV not implemented");
					Delegates.pglGetUniformi64vNV(program, location, p_params);
					LogCommand("glGetUniformi64vNV", null, program, location, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1i64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1i64NV != null, "pglProgramUniform1i64NV not implemented");
			Delegates.pglProgramUniform1i64NV(program, location, x);
			LogCommand("glProgramUniform1i64NV", null, program, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2i64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2i64NV != null, "pglProgramUniform2i64NV not implemented");
			Delegates.pglProgramUniform2i64NV(program, location, x, y);
			LogCommand("glProgramUniform2i64NV", null, program, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3i64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3i64NV != null, "pglProgramUniform3i64NV not implemented");
			Delegates.pglProgramUniform3i64NV(program, location, x, y, z);
			LogCommand("glProgramUniform3i64NV", null, program, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4i64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4i64NV != null, "pglProgramUniform4i64NV not implemented");
			Delegates.pglProgramUniform4i64NV(program, location, x, y, z, w);
			LogCommand("glProgramUniform4i64NV", null, program, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1i64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1i64vNV != null, "pglProgramUniform1i64vNV not implemented");
					Delegates.pglProgramUniform1i64vNV(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1i64vNV", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2i64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2i64vNV != null, "pglProgramUniform2i64vNV not implemented");
					Delegates.pglProgramUniform2i64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform2i64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3i64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3i64vNV != null, "pglProgramUniform3i64vNV not implemented");
					Delegates.pglProgramUniform3i64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform3i64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4i64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4i64vNV != null, "pglProgramUniform4i64vNV not implemented");
					Delegates.pglProgramUniform4i64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform4i64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1ui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui64NV != null, "pglProgramUniform1ui64NV not implemented");
			Delegates.pglProgramUniform1ui64NV(program, location, x);
			LogCommand("glProgramUniform1ui64NV", null, program, location, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2ui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui64NV != null, "pglProgramUniform2ui64NV not implemented");
			Delegates.pglProgramUniform2ui64NV(program, location, x, y);
			LogCommand("glProgramUniform2ui64NV", null, program, location, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3ui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui64NV != null, "pglProgramUniform3ui64NV not implemented");
			Delegates.pglProgramUniform3ui64NV(program, location, x, y, z);
			LogCommand("glProgramUniform3ui64NV", null, program, location, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4ui64NV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui64NV != null, "pglProgramUniform4ui64NV not implemented");
			Delegates.pglProgramUniform4ui64NV(program, location, x, y, z, w);
			LogCommand("glProgramUniform4ui64NV", null, program, location, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform1ui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1ui64vNV != null, "pglProgramUniform1ui64vNV not implemented");
					Delegates.pglProgramUniform1ui64vNV(program, location, (Int32)value.Length, p_value);
					LogCommand("glProgramUniform1ui64vNV", null, program, location, value.Length, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform2ui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2ui64vNV != null, "pglProgramUniform2ui64vNV not implemented");
					Delegates.pglProgramUniform2ui64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform2ui64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform3ui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3ui64vNV != null, "pglProgramUniform3ui64vNV not implemented");
					Delegates.pglProgramUniform3ui64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform3ui64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glProgramUniform4ui64vNV.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4ui64vNV != null, "pglProgramUniform4ui64vNV not implemented");
					Delegates.pglProgramUniform4ui64vNV(program, location, count, p_value);
					LogCommand("glProgramUniform4ui64vNV", null, program, location, count, value					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1i64NV", ExactSpelling = true)]
			internal extern static void glUniform1i64NV(Int32 location, Int64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2i64NV", ExactSpelling = true)]
			internal extern static void glUniform2i64NV(Int32 location, Int64 x, Int64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3i64NV", ExactSpelling = true)]
			internal extern static void glUniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4i64NV", ExactSpelling = true)]
			internal extern static void glUniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform1i64vNV(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform2i64vNV(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform3i64vNV(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform4i64vNV(Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1ui64NV", ExactSpelling = true)]
			internal extern static void glUniform1ui64NV(Int32 location, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2ui64NV", ExactSpelling = true)]
			internal extern static void glUniform2ui64NV(Int32 location, UInt64 x, UInt64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3ui64NV", ExactSpelling = true)]
			internal extern static void glUniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4ui64NV", ExactSpelling = true)]
			internal extern static void glUniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform1ui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform2ui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform3ui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniform4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glUniform4ui64vNV(Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformi64vNV", ExactSpelling = true)]
			internal extern static unsafe void glGetUniformi64vNV(UInt32 program, Int32 location, Int64* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4i64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4i64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4ui64NV", ExactSpelling = true)]
			internal extern static void glProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform1ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform2ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform3ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glProgramUniform4ui64vNV", ExactSpelling = true)]
			internal extern static unsafe void glProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1i64NV(Int32 location, Int64 x);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform1i64NV pglUniform1i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2i64NV(Int32 location, Int64 x, Int64 y);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform2i64NV pglUniform2i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform3i64NV pglUniform3i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform4i64NV pglUniform4i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1i64vNV(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform1i64vNV pglUniform1i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2i64vNV(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform2i64vNV pglUniform2i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3i64vNV(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform3i64vNV pglUniform3i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4i64vNV(Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform4i64vNV pglUniform4i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform1ui64NV(Int32 location, UInt64 x);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform1ui64NV pglUniform1ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform2ui64NV(Int32 location, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform2ui64NV pglUniform2ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform3ui64NV pglUniform3ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform4ui64NV pglUniform4ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform1ui64vNV(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform1ui64vNV pglUniform1ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform2ui64vNV(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform2ui64vNV pglUniform2ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform3ui64vNV(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform3ui64vNV pglUniform3ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glUniform4ui64vNV(Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glUniform4ui64vNV pglUniform4ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetUniformi64vNV(UInt32 program, Int32 location, Int64* @params);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glGetUniformi64vNV pglGetUniformi64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform1i64NV pglProgramUniform1i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform2i64NV pglProgramUniform2i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform3i64NV pglProgramUniform3i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform4i64NV pglProgramUniform4i64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform1i64vNV pglProgramUniform1i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform2i64vNV pglProgramUniform2i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform3i64vNV pglProgramUniform3i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform4i64vNV pglProgramUniform4i64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform1ui64NV pglProgramUniform1ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform2ui64NV pglProgramUniform2ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform3ui64NV pglProgramUniform3ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform4ui64NV pglProgramUniform4ui64NV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform1ui64vNV pglProgramUniform1ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform2ui64vNV pglProgramUniform2ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform3ui64vNV pglProgramUniform3ui64vNV;

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);

			[RequiredByFeature("GL_AMD_gpu_shader_int64")]
			[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glProgramUniform4ui64vNV pglProgramUniform4ui64vNV;

		}
	}

}
