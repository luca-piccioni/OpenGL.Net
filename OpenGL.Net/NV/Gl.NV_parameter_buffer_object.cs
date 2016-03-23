
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
		/// Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int MAX_PROGRAM_PARAMETER_BUFFER_BINDINGS_NV = 0x8DA0;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int MAX_PROGRAM_PARAMETER_BUFFER_SIZE_NV = 0x8DA1;

		/// <summary>
		/// Value of GL_VERTEX_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int VERTEX_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA2;

		/// <summary>
		/// Value of GL_GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int GEOMETRY_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA3;

		/// <summary>
		/// Value of GL_FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public const int FRAGMENT_PROGRAM_PARAMETER_BUFFER_NV = 0x8DA4;

		/// <summary>
		/// Binding for glProgramBufferParametersfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersNV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersfvNV != null, "pglProgramBufferParametersfvNV not implemented");
					Delegates.pglProgramBufferParametersfvNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogFunction("glProgramBufferParametersfvNV({0}, {1}, {2}, {3}, {4})", LogEnumName(target), bindingIndex, wordIndex, @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramBufferParametersIivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersINV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersIivNV != null, "pglProgramBufferParametersIivNV not implemented");
					Delegates.pglProgramBufferParametersIivNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogFunction("glProgramBufferParametersIivNV({0}, {1}, {2}, {3}, {4})", LogEnumName(target), bindingIndex, wordIndex, @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glProgramBufferParametersIuivNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bindingIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="wordIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_parameter_buffer_object")]
		public static void ProgramBufferParametersINV(Int32 target, UInt32 bindingIndex, UInt32 wordIndex, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglProgramBufferParametersIuivNV != null, "pglProgramBufferParametersIuivNV not implemented");
					Delegates.pglProgramBufferParametersIuivNV(target, bindingIndex, wordIndex, (Int32)@params.Length, p_params);
					LogFunction("glProgramBufferParametersIuivNV({0}, {1}, {2}, {3}, {4})", LogEnumName(target), bindingIndex, wordIndex, @params.Length, LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
