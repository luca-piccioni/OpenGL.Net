
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
		/// Value of GL_INT64_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit")]
		public const int INT64_ARB = 0x140E;

		/// <summary>
		/// Value of GL_INT64_VEC2_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC2_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT64_VEC2_ARB = 0x8FE9;

		/// <summary>
		/// Value of GL_INT64_VEC3_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC3_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT64_VEC3_ARB = 0x8FEA;

		/// <summary>
		/// Value of GL_INT64_VEC4_ARB symbol.
		/// </summary>
		[AliasOf("GL_INT64_VEC4_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int INT64_VEC4_ARB = 0x8FEB;

		/// <summary>
		/// Value of GL_UNSIGNED_INT64_VEC2_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC2_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT64_VEC2_ARB = 0x8FF5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT64_VEC3_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC3_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT64_VEC3_ARB = 0x8FF6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT64_VEC4_ARB symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT64_VEC4_NV")]
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_gpu_shader5")]
		public const int UNSIGNED_INT64_VEC4_ARB = 0x8FF7;

		/// <summary>
		/// Binding for glUniform1i64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform1ARB(Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglUniform1i64ARB != null, "pglUniform1i64ARB not implemented");
			Delegates.pglUniform1i64ARB(location, x);
			LogFunction("glUniform1i64ARB({0}, {1})", location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform2ARB(Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglUniform2i64ARB != null, "pglUniform2i64ARB not implemented");
			Delegates.pglUniform2i64ARB(location, x, y);
			LogFunction("glUniform2i64ARB({0}, {1}, {2})", location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform3ARB(Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglUniform3i64ARB != null, "pglUniform3i64ARB not implemented");
			Delegates.pglUniform3i64ARB(location, x, y, z);
			LogFunction("glUniform3i64ARB({0}, {1}, {2}, {3})", location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform4ARB(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglUniform4i64ARB != null, "pglUniform4i64ARB not implemented");
			Delegates.pglUniform4i64ARB(location, x, y, z, w);
			LogFunction("glUniform4i64ARB({0}, {1}, {2}, {3}, {4})", location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform1ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1i64vARB != null, "pglUniform1i64vARB not implemented");
					Delegates.pglUniform1i64vARB(location, count, p_value);
					LogFunction("glUniform1i64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform2ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2i64vARB != null, "pglUniform2i64vARB not implemented");
					Delegates.pglUniform2i64vARB(location, count, p_value);
					LogFunction("glUniform2i64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform3ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3i64vARB != null, "pglUniform3i64vARB not implemented");
					Delegates.pglUniform3i64vARB(location, count, p_value);
					LogFunction("glUniform3i64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform4ARB(Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4i64vARB != null, "pglUniform4i64vARB not implemented");
					Delegates.pglUniform4i64vARB(location, count, p_value);
					LogFunction("glUniform4i64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1ui64ARB.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform1ARB(Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglUniform1ui64ARB != null, "pglUniform1ui64ARB not implemented");
			Delegates.pglUniform1ui64ARB(location, x);
			LogFunction("glUniform1ui64ARB({0}, {1})", location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform2ARB(Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglUniform2ui64ARB != null, "pglUniform2ui64ARB not implemented");
			Delegates.pglUniform2ui64ARB(location, x, y);
			LogFunction("glUniform2ui64ARB({0}, {1}, {2})", location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform3ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglUniform3ui64ARB != null, "pglUniform3ui64ARB not implemented");
			Delegates.pglUniform3ui64ARB(location, x, y, z);
			LogFunction("glUniform3ui64ARB({0}, {1}, {2}, {3})", location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform4ARB(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglUniform4ui64ARB != null, "pglUniform4ui64ARB not implemented");
			Delegates.pglUniform4ui64ARB(location, x, y, z, w);
			LogFunction("glUniform4ui64ARB({0}, {1}, {2}, {3}, {4})", location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform1ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform1ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1ui64vARB != null, "pglUniform1ui64vARB not implemented");
					Delegates.pglUniform1ui64vARB(location, count, p_value);
					LogFunction("glUniform1ui64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform2ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform2ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2ui64vARB != null, "pglUniform2ui64vARB not implemented");
					Delegates.pglUniform2ui64vARB(location, count, p_value);
					LogFunction("glUniform2ui64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform3ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform3ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3ui64vARB != null, "pglUniform3ui64vARB not implemented");
					Delegates.pglUniform3ui64vARB(location, count, p_value);
					LogFunction("glUniform3ui64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glUniform4ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void Uniform4ARB(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4ui64vARB != null, "pglUniform4ui64vARB not implemented");
					Delegates.pglUniform4ui64vARB(location, count, p_value);
					LogFunction("glUniform4ui64vARB({0}, {1}, {2})", location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetUniformi64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void GetUniformARB(UInt32 program, Int32 location, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformi64vARB != null, "pglGetUniformi64vARB not implemented");
					Delegates.pglGetUniformi64vARB(program, location, p_params);
					LogFunction("glGetUniformi64vARB({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetUniformui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void GetUniformARB(UInt32 program, Int32 location, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformui64vARB != null, "pglGetUniformui64vARB not implemented");
					Delegates.pglGetUniformui64vARB(program, location, p_params);
					LogFunction("glGetUniformui64vARB({0}, {1}, {2})", program, location, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformi64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformi64vARB != null, "pglGetnUniformi64vARB not implemented");
					Delegates.pglGetnUniformi64vARB(program, location, bufSize, p_params);
					LogFunction("glGetnUniformi64vARB({0}, {1}, {2}, {3})", program, location, bufSize, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformui64vARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void GetnUniformARB(UInt32 program, Int32 location, Int32 bufSize, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformui64vARB != null, "pglGetnUniformui64vARB not implemented");
					Delegates.pglGetnUniformui64vARB(program, location, bufSize, p_params);
					LogFunction("glGetnUniformui64vARB({0}, {1}, {2}, {3})", program, location, bufSize, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, Int64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1i64ARB != null, "pglProgramUniform1i64ARB not implemented");
			Delegates.pglProgramUniform1i64ARB(program, location, x);
			LogFunction("glProgramUniform1i64ARB({0}, {1}, {2})", program, location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2i64ARB != null, "pglProgramUniform2i64ARB not implemented");
			Delegates.pglProgramUniform2i64ARB(program, location, x, y);
			LogFunction("glProgramUniform2i64ARB({0}, {1}, {2}, {3})", program, location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3i64ARB != null, "pglProgramUniform3i64ARB not implemented");
			Delegates.pglProgramUniform3i64ARB(program, location, x, y, z);
			LogFunction("glProgramUniform3i64ARB({0}, {1}, {2}, {3}, {4})", program, location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4i64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4i64ARB != null, "pglProgramUniform4i64ARB not implemented");
			Delegates.pglProgramUniform4i64ARB(program, location, x, y, z, w);
			LogFunction("glProgramUniform4i64ARB({0}, {1}, {2}, {3}, {4}, {5})", program, location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1i64vARB != null, "pglProgramUniform1i64vARB not implemented");
					Delegates.pglProgramUniform1i64vARB(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniform1i64vARB({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2i64vARB != null, "pglProgramUniform2i64vARB not implemented");
					Delegates.pglProgramUniform2i64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform2i64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3i64vARB != null, "pglProgramUniform3i64vARB not implemented");
					Delegates.pglProgramUniform3i64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform3i64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4i64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int32 count, Int64[] value)
		{
			unsafe {
				fixed (Int64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4i64vARB != null, "pglProgramUniform4i64vARB not implemented");
					Delegates.pglProgramUniform4i64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform4i64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, UInt64 x)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui64ARB != null, "pglProgramUniform1ui64ARB not implemented");
			Delegates.pglProgramUniform1ui64ARB(program, location, x);
			LogFunction("glProgramUniform1ui64ARB({0}, {1}, {2})", program, location, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui64ARB != null, "pglProgramUniform2ui64ARB not implemented");
			Delegates.pglProgramUniform2ui64ARB(program, location, x, y);
			LogFunction("glProgramUniform2ui64ARB({0}, {1}, {2}, {3})", program, location, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui64ARB != null, "pglProgramUniform3ui64ARB not implemented");
			Delegates.pglProgramUniform3ui64ARB(program, location, x, y, z);
			LogFunction("glProgramUniform3ui64ARB({0}, {1}, {2}, {3}, {4})", program, location, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4ui64ARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui64ARB != null, "pglProgramUniform4ui64ARB not implemented");
			Delegates.pglProgramUniform4ui64ARB(program, location, x, y, z, w);
			LogFunction("glProgramUniform4ui64ARB({0}, {1}, {2}, {3}, {4}, {5})", program, location, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform1ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform1ARB(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1ui64vARB != null, "pglProgramUniform1ui64vARB not implemented");
					Delegates.pglProgramUniform1ui64vARB(program, location, (Int32)value.Length, p_value);
					LogFunction("glProgramUniform1ui64vARB({0}, {1}, {2}, {3})", program, location, value.Length, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform2ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform2ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2ui64vARB != null, "pglProgramUniform2ui64vARB not implemented");
					Delegates.pglProgramUniform2ui64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform2ui64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform3ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform3ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3ui64vARB != null, "pglProgramUniform3ui64vARB not implemented");
					Delegates.pglProgramUniform3ui64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform3ui64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramUniform4ui64vARB.
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
		[RequiredByFeature("GL_ARB_gpu_shader_int64")]
		public static void ProgramUniform4ARB(UInt32 program, Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4ui64vARB != null, "pglProgramUniform4ui64vARB not implemented");
					Delegates.pglProgramUniform4ui64vARB(program, location, count, p_value);
					LogFunction("glProgramUniform4ui64vARB({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
