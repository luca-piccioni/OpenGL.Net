
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
		/// Value of GL_INT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT8_NV = 0x8FE0;

		/// <summary>
		/// Value of GL_INT8_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT8_VEC2_NV = 0x8FE1;

		/// <summary>
		/// Value of GL_INT8_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT8_VEC3_NV = 0x8FE2;

		/// <summary>
		/// Value of GL_INT8_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT8_VEC4_NV = 0x8FE3;

		/// <summary>
		/// Value of GL_INT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT16_NV = 0x8FE4;

		/// <summary>
		/// Value of GL_INT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT16_VEC2_NV = 0x8FE5;

		/// <summary>
		/// Value of GL_INT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT16_VEC3_NV = 0x8FE6;

		/// <summary>
		/// Value of GL_INT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT16_VEC4_NV = 0x8FE7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT8_NV = 0x8FEC;

		/// <summary>
		/// Value of GL_UNSIGNED_INT8_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT8_VEC2_NV = 0x8FED;

		/// <summary>
		/// Value of GL_UNSIGNED_INT8_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT8_VEC3_NV = 0x8FEE;

		/// <summary>
		/// Value of GL_UNSIGNED_INT8_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT8_VEC4_NV = 0x8FEF;

		/// <summary>
		/// Value of GL_UNSIGNED_INT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT16_NV = 0x8FF0;

		/// <summary>
		/// Value of GL_UNSIGNED_INT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT16_VEC2_NV = 0x8FF1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT16_VEC3_NV = 0x8FF2;

		/// <summary>
		/// Value of GL_UNSIGNED_INT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT16_VEC4_NV = 0x8FF3;

		/// <summary>
		/// Value of GL_FLOAT16_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int FLOAT16_NV = 0x8FF8;

		/// <summary>
		/// Value of GL_FLOAT16_VEC2_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int FLOAT16_VEC2_NV = 0x8FF9;

		/// <summary>
		/// Value of GL_FLOAT16_VEC3_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int FLOAT16_VEC3_NV = 0x8FFA;

		/// <summary>
		/// Value of GL_FLOAT16_VEC4_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int FLOAT16_VEC4_NV = 0x8FFB;

		/// <summary>
		/// Binding for glUniform1i64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform1NV(Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglUniform1i64NV != null, "pglUniform1i64NV not implemented");
			Delegates.pglUniform1i64NV(location, x);
			LogFunction("glUniform1i64NV({0}, {1})", location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform2NV(Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglUniform2i64NV != null, "pglUniform2i64NV not implemented");
			Delegates.pglUniform2i64NV(location, x, y);
			LogFunction("glUniform2i64NV({0}, {1}, {2})", location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform3NV(Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglUniform3i64NV != null, "pglUniform3i64NV not implemented");
			Delegates.pglUniform3i64NV(location, x, y, z);
			LogFunction("glUniform3i64NV({0}, {1}, {2}, {3})", location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform4NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglUniform4i64NV != null, "pglUniform4i64NV not implemented");
			Delegates.pglUniform4i64NV(location, x, y, z, w);
			LogFunction("glUniform4i64NV({0}, {1}, {2}, {3}, {4})", location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform1NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1i64vNV != null, "pglUniform1i64vNV not implemented");
					Delegates.pglUniform1i64vNV(location, count, p_value);
					LogFunction("glUniform1i64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform2NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2i64vNV != null, "pglUniform2i64vNV not implemented");
					Delegates.pglUniform2i64vNV(location, count, p_value);
					LogFunction("glUniform2i64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform3NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3i64vNV != null, "pglUniform3i64vNV not implemented");
					Delegates.pglUniform3i64vNV(location, count, p_value);
					LogFunction("glUniform3i64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform4NV(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4i64vNV != null, "pglUniform4i64vNV not implemented");
					Delegates.pglUniform4i64vNV(location, count, p_value);
					LogFunction("glUniform4i64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1ui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform1NV(Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglUniform1ui64NV != null, "pglUniform1ui64NV not implemented");
			Delegates.pglUniform1ui64NV(location, x);
			LogFunction("glUniform1ui64NV({0}, {1})", location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform2NV(Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglUniform2ui64NV != null, "pglUniform2ui64NV not implemented");
			Delegates.pglUniform2ui64NV(location, x, y);
			LogFunction("glUniform2ui64NV({0}, {1}, {2})", location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform3NV(Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglUniform3ui64NV != null, "pglUniform3ui64NV not implemented");
			Delegates.pglUniform3ui64NV(location, x, y, z);
			LogFunction("glUniform3ui64NV({0}, {1}, {2}, {3})", location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform4NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglUniform4ui64NV != null, "pglUniform4ui64NV not implemented");
			Delegates.pglUniform4ui64NV(location, x, y, z, w);
			LogFunction("glUniform4ui64NV({0}, {1}, {2}, {3}, {4})", location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform1NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1ui64vNV != null, "pglUniform1ui64vNV not implemented");
					Delegates.pglUniform1ui64vNV(location, count, p_value);
					LogFunction("glUniform1ui64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform2NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2ui64vNV != null, "pglUniform2ui64vNV not implemented");
					Delegates.pglUniform2ui64vNV(location, count, p_value);
					LogFunction("glUniform2ui64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform3NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3ui64vNV != null, "pglUniform3ui64vNV not implemented");
					Delegates.pglUniform3ui64vNV(location, count, p_value);
					LogFunction("glUniform3ui64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void Uniform4NV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4ui64vNV != null, "pglUniform4ui64vNV not implemented");
					Delegates.pglUniform4ui64vNV(location, count, p_value);
					LogFunction("glUniform4ui64vNV({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetUniformi64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void GetUniformNV(UInt32 program, Int32 location, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformi64vNV != null, "pglGetUniformi64vNV not implemented");
					Delegates.pglGetUniformi64vNV(program, location, p_params);
					LogFunction("glGetUniformi64vNV({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1i64NV != null, "pglProgramUniform1i64NV not implemented");
			Delegates.pglProgramUniform1i64NV(program, location, x);
			LogFunction("glProgramUniform1i64NV({0}, {1}, {2})", program, location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2i64NV != null, "pglProgramUniform2i64NV not implemented");
			Delegates.pglProgramUniform2i64NV(program, location, x, y);
			LogFunction("glProgramUniform2i64NV({0}, {1}, {2}, {3})", program, location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3i64NV != null, "pglProgramUniform3i64NV not implemented");
			Delegates.pglProgramUniform3i64NV(program, location, x, y, z);
			LogFunction("glProgramUniform3i64NV({0}, {1}, {2}, {3}, {4})", program, location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4i64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4i64NV != null, "pglProgramUniform4i64NV not implemented");
			Delegates.pglProgramUniform4i64NV(program, location, x, y, z, w);
			LogFunction("glProgramUniform4i64NV({0}, {1}, {2}, {3}, {4}, {5})", program, location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1i64vNV != null, "pglProgramUniform1i64vNV not implemented");
					Delegates.pglProgramUniform1i64vNV(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniform1i64vNV({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2i64vNV != null, "pglProgramUniform2i64vNV not implemented");
					Delegates.pglProgramUniform2i64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform2i64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3i64vNV != null, "pglProgramUniform3i64vNV not implemented");
					Delegates.pglProgramUniform3i64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform3i64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4i64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4i64vNV != null, "pglProgramUniform4i64vNV not implemented");
					Delegates.pglProgramUniform4i64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform4i64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui64NV != null, "pglProgramUniform1ui64NV not implemented");
			Delegates.pglProgramUniform1ui64NV(program, location, x);
			LogFunction("glProgramUniform1ui64NV({0}, {1}, {2})", program, location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui64NV != null, "pglProgramUniform2ui64NV not implemented");
			Delegates.pglProgramUniform2ui64NV(program, location, x, y);
			LogFunction("glProgramUniform2ui64NV({0}, {1}, {2}, {3})", program, location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui64NV != null, "pglProgramUniform3ui64NV not implemented");
			Delegates.pglProgramUniform3ui64NV(program, location, x, y, z);
			LogFunction("glProgramUniform3ui64NV({0}, {1}, {2}, {3}, {4})", program, location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4ui64NV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui64NV != null, "pglProgramUniform4ui64NV not implemented");
			Delegates.pglProgramUniform4ui64NV(program, location, x, y, z, w);
			LogFunction("glProgramUniform4ui64NV({0}, {1}, {2}, {3}, {4}, {5})", program, location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform1NV(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1ui64vNV != null, "pglProgramUniform1ui64vNV not implemented");
					Delegates.pglProgramUniform1ui64vNV(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniform1ui64vNV({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform2NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2ui64vNV != null, "pglProgramUniform2ui64vNV not implemented");
					Delegates.pglProgramUniform2ui64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform2ui64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform3NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3ui64vNV != null, "pglProgramUniform3ui64vNV not implemented");
					Delegates.pglProgramUniform3ui64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform3ui64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4ui64vNV.
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
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public static void ProgramUniform4NV(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4ui64vNV != null, "pglProgramUniform4ui64vNV not implemented");
					Delegates.pglProgramUniform4ui64vNV(program, location, count, p_value);
					LogFunction("glProgramUniform4ui64vNV({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
