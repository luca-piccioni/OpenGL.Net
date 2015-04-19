
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
		/// Value of GL_BUFFER_GPU_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int BUFFER_GPU_ADDRESS_NV = 0x8F1D;

		/// <summary>
		/// Value of GL_GPU_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int GPU_ADDRESS_NV = 0x8F34;

		/// <summary>
		/// Value of GL_MAX_SHADER_BUFFER_ADDRESS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public const int MAX_SHADER_BUFFER_ADDRESS_NV = 0x8F35;

		/// <summary>
		/// Binding for glMakeBufferResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeBufferResidentNV(int target, int access)
		{
			Debug.Assert(Delegates.pglMakeBufferResidentNV != null, "pglMakeBufferResidentNV not implemented");
			Delegates.pglMakeBufferResidentNV(target, access);
			CallLog("glMakeBufferResidentNV({0}, {1})", target, access);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMakeBufferNonResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeBufferNonResidentNV(int target)
		{
			Debug.Assert(Delegates.pglMakeBufferNonResidentNV != null, "pglMakeBufferNonResidentNV not implemented");
			Delegates.pglMakeBufferNonResidentNV(target);
			CallLog("glMakeBufferNonResidentNV({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsBufferResidentNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static bool IsBufferResidentNV(int target)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsBufferResidentNV != null, "pglIsBufferResidentNV not implemented");
			retValue = Delegates.pglIsBufferResidentNV(target);
			CallLog("glIsBufferResidentNV({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glMakeNamedBufferResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeNamedBufferResidentNV(UInt32 buffer, int access)
		{
			Debug.Assert(Delegates.pglMakeNamedBufferResidentNV != null, "pglMakeNamedBufferResidentNV not implemented");
			Delegates.pglMakeNamedBufferResidentNV(buffer, access);
			CallLog("glMakeNamedBufferResidentNV({0}, {1})", buffer, access);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMakeNamedBufferNonResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void MakeNamedBufferNonResidentNV(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglMakeNamedBufferNonResidentNV != null, "pglMakeNamedBufferNonResidentNV not implemented");
			Delegates.pglMakeNamedBufferNonResidentNV(buffer);
			CallLog("glMakeNamedBufferNonResidentNV({0})", buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIsNamedBufferResidentNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static bool IsNamedBufferResidentNV(UInt32 buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsNamedBufferResidentNV != null, "pglIsNamedBufferResidentNV not implemented");
			retValue = Delegates.pglIsNamedBufferResidentNV(buffer);
			CallLog("glIsNamedBufferResidentNV({0}) = {1}", buffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetBufferParameterui64vNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetBufferParameterNV(int target, int pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetBufferParameterui64vNV != null, "pglGetBufferParameterui64vNV not implemented");
					Delegates.pglGetBufferParameterui64vNV(target, pname, p_params);
					CallLog("glGetBufferParameterui64vNV({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetNamedBufferParameterui64vNV.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetNamedBufferParameterNV(UInt32 buffer, int pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetNamedBufferParameterui64vNV != null, "pglGetNamedBufferParameterui64vNV not implemented");
					Delegates.pglGetNamedBufferParameterui64vNV(buffer, pname, p_params);
					CallLog("glGetNamedBufferParameterui64vNV({0}, {1}, {2})", buffer, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetIntegerui64vNV.
		/// </summary>
		/// <param name="value">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="result">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetIntegerNV(int value, [Out] UInt64[] result)
		{
			unsafe {
				fixed (UInt64* p_result = result)
				{
					Debug.Assert(Delegates.pglGetIntegerui64vNV != null, "pglGetIntegerui64vNV not implemented");
					Delegates.pglGetIntegerui64vNV(value, p_result);
					CallLog("glGetIntegerui64vNV({0}, {1})", value, result);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformui64NV.
		/// </summary>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void UniformNV(Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglUniformui64NV != null, "pglUniformui64NV not implemented");
			Delegates.pglUniformui64NV(location, value);
			CallLog("glUniformui64NV({0}, {1})", location, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glUniformui64vNV.
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
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void UniformNV(Int32 location, Int32 count, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglUniformui64vNV != null, "pglUniformui64vNV not implemented");
					Delegates.pglUniformui64vNV(location, count, p_value);
					CallLog("glUniformui64vNV({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetUniformui64vNV.
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
		[RequiredByFeature("GL_AMD_gpu_shader_int64")]
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void GetUniformNV(UInt32 program, Int32 location, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformui64vNV != null, "pglGetUniformui64vNV not implemented");
					Delegates.pglGetUniformui64vNV(program, location, p_params);
					CallLog("glGetUniformui64vNV({0}, {1}, {2})", program, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformui64NV.
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
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void ProgramUniformNV(UInt32 program, Int32 location, UInt64 value)
		{
			Debug.Assert(Delegates.pglProgramUniformui64NV != null, "pglProgramUniformui64NV not implemented");
			Delegates.pglProgramUniformui64NV(program, location, value);
			CallLog("glProgramUniformui64NV({0}, {1}, {2})", program, location, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformui64vNV.
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
		[RequiredByFeature("GL_NV_shader_buffer_load")]
		public static void ProgramUniformNV(UInt32 program, Int32 location, UInt64[] value)
		{
			unsafe {
				fixed (UInt64* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformui64vNV != null, "pglProgramUniformui64vNV not implemented");
					Delegates.pglProgramUniformui64vNV(program, location, (Int32)value.Length, p_value);
					CallLog("glProgramUniformui64vNV({0}, {1}, {2}, {3})", program, location, value.Length, value);
				}
			}
			DebugCheckErrors();
		}

	}

}
