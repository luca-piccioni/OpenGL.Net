
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
		/// Value of GL_FIXED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int FIXED = 0x140C;

		/// <summary>
		/// Value of GL_IMPLEMENTATION_COLOR_READ_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;

		/// <summary>
		/// Value of GL_IMPLEMENTATION_COLOR_READ_FORMAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

		/// <summary>
		/// Value of GL_LOW_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int LOW_FLOAT = 0x8DF0;

		/// <summary>
		/// Value of GL_MEDIUM_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int MEDIUM_FLOAT = 0x8DF1;

		/// <summary>
		/// Value of GL_HIGH_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int HIGH_FLOAT = 0x8DF2;

		/// <summary>
		/// Value of GL_LOW_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int LOW_INT = 0x8DF3;

		/// <summary>
		/// Value of GL_MEDIUM_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int MEDIUM_INT = 0x8DF4;

		/// <summary>
		/// Value of GL_HIGH_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int HIGH_INT = 0x8DF5;

		/// <summary>
		/// Value of GL_SHADER_COMPILER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int SHADER_COMPILER = 0x8DFA;

		/// <summary>
		/// Value of GL_SHADER_BINARY_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int SHADER_BINARY_FORMATS = 0x8DF8;

		/// <summary>
		/// Value of GL_NUM_SHADER_BINARY_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int NUM_SHADER_BINARY_FORMATS = 0x8DF9;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_VECTORS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;

		/// <summary>
		/// Value of GL_MAX_VARYING_VECTORS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int MAX_VARYING_VECTORS = 0x8DFC;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_UNIFORM_VECTORS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

		/// <summary>
		/// Value of GL_RGB565 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public const int RGB565 = 0x8D62;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_RETRIEVABLE_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public const int PROGRAM_BINARY_LENGTH = 0x8741;

		/// <summary>
		/// Value of GL_NUM_PROGRAM_BINARY_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public const int NUM_PROGRAM_BINARY_FORMATS = 0x87FE;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public const int PROGRAM_BINARY_FORMATS = 0x87FF;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint VERTEX_SHADER_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint FRAGMENT_SHADER_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint GEOMETRY_SHADER_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;

		/// <summary>
		/// Value of GL_ALL_SHADER_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const uint ALL_SHADER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_PROGRAM_SEPARABLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const int PROGRAM_SEPARABLE = 0x8258;

		/// <summary>
		/// Value of GL_ACTIVE_PROGRAM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const int ACTIVE_PROGRAM = 0x8259;

		/// <summary>
		/// Value of GL_PROGRAM_PIPELINE_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public const int PROGRAM_PIPELINE_BINDING = 0x825A;

		/// <summary>
		/// Value of GL_MAX_VIEWPORTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int MAX_VIEWPORTS = 0x825B;

		/// <summary>
		/// Value of GL_VIEWPORT_SUBPIXEL_BITS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int VIEWPORT_SUBPIXEL_BITS = 0x825C;

		/// <summary>
		/// Value of GL_VIEWPORT_BOUNDS_RANGE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int VIEWPORT_BOUNDS_RANGE = 0x825D;

		/// <summary>
		/// Value of GL_LAYER_PROVOKING_VERTEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int LAYER_PROVOKING_VERTEX = 0x825E;

		/// <summary>
		/// Value of GL_VIEWPORT_INDEX_PROVOKING_VERTEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

		/// <summary>
		/// Value of GL_UNDEFINED_VERTEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public const int UNDEFINED_VERTEX = 0x8260;

		/// <summary>
		/// release resources consumed by the implementation's shader compiler
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void ReleaseShaderCompiler()
		{
			Debug.Assert(Delegates.pglReleaseShaderCompiler != null, "pglReleaseShaderCompiler not implemented");
			Delegates.pglReleaseShaderCompiler();
			CallLog("glReleaseShaderCompiler()");
			DebugCheckErrors();
		}

		/// <summary>
		/// load pre-compiled shader binaries
		/// </summary>
		/// <param name="count">
		/// Specifies the number of shader object handles contained in shaders.
		/// </param>
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in binary.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void ShaderBinary(Int32 count, UInt32[] shaders, int binaryformat, Object binary, Int32 length)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				ShaderBinary(count, shaders, binaryformat, pin_binary.AddrOfPinnedObject(), length);
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// load pre-compiled shader binaries
		/// </summary>
		/// <param name="count">
		/// Specifies the number of shader object handles contained in shaders.
		/// </param>
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in binary.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void ShaderBinary(UInt32[] shaders, int binaryformat, IntPtr binary, Int32 length)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglShaderBinary != null, "pglShaderBinary not implemented");
					Delegates.pglShaderBinary((Int32)shaders.Length, p_shaders, binaryformat, binary, length);
					CallLog("glShaderBinary({0}, {1}, {2}, {3}, {4})", shaders.Length, shaders, binaryformat, binary, length);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the range and precision for numeric formats supported by the shader compiler
		/// </summary>
		/// <param name="shadertype">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="precisiontype">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="range">
		/// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
		/// </param>
		/// <param name="precision">
		/// Specifies the address of an integer into which the numeric precision of the implementation is written.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void GetShaderPrecisionFormat(int shadertype, int precisiontype, Int32[] range, Int32[] precision)
		{
			unsafe {
				fixed (Int32* p_range = range)
				fixed (Int32* p_precision = precision)
				{
					Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
					Delegates.pglGetShaderPrecisionFormat(shadertype, precisiontype, p_range, p_precision);
					CallLog("glGetShaderPrecisionFormat({0}, {1}, {2}, {3})", shadertype, precisiontype, range, precision);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void DepthRange(float n, float f)
		{
			if        (Delegates.pglDepthRangef != null) {
				Delegates.pglDepthRangef(n, f);
				CallLog("glDepthRangef({0}, {1})", n, f);
			} else if (Delegates.pglDepthRangefOES != null) {
				Delegates.pglDepthRangefOES(n, f);
				CallLog("glDepthRangefOES({0}, {1})", n, f);
			} else
				throw new NotImplementedException("glDepthRangef (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="d">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_ES2_compatibility")]
		public static void ClearDepth(float d)
		{
			if        (Delegates.pglClearDepthf != null) {
				Delegates.pglClearDepthf(d);
				CallLog("glClearDepthf({0})", d);
			} else if (Delegates.pglClearDepthfOES != null) {
				Delegates.pglClearDepthfOES(d);
				CallLog("glClearDepthfOES({0})", d);
			} else
				throw new NotImplementedException("glClearDepthf (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by binary.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return program's binary representation.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out int binaryFormat, IntPtr binary)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (int* p_binaryFormat = &binaryFormat)
				{
					Debug.Assert(Delegates.pglGetProgramBinary != null, "pglGetProgramBinary not implemented");
					Delegates.pglGetProgramBinary(program, bufSize, p_length, p_binaryFormat, binary);
					CallLog("glGetProgramBinary({0}, {1}, {2}, {3}, {4})", program, bufSize, length, binaryFormat, binary);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by binary.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return program's binary representation.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out int binaryFormat, Object binary)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				GetProgramBinary(program, bufSize, out length, out binaryFormat, pin_binary.AddrOfPinnedObject());
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// load a program object with a program binary
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object into which to load a program binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the format of the binary data in binary.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array containing the binary to be loaded into program.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in binary.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public static void ProgramBinary(UInt32 program, int binaryFormat, IntPtr binary, Int32 length)
		{
			Debug.Assert(Delegates.pglProgramBinary != null, "pglProgramBinary not implemented");
			Delegates.pglProgramBinary(program, binaryFormat, binary, length);
			CallLog("glProgramBinary({0}, {1}, {2}, {3})", program, binaryFormat, binary, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// load a program object with a program binary
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object into which to load a program binary.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the format of the binary data in binary.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array containing the binary to be loaded into program.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in binary.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public static void ProgramBinary(UInt32 program, int binaryFormat, Object binary, Int32 length)
		{
			GCHandle pin_binary = GCHandle.Alloc(binary, GCHandleType.Pinned);
			try {
				ProgramBinary(program, binaryFormat, pin_binary.AddrOfPinnedObject(), length);
			} finally {
				pin_binary.Free();
			}
		}

		/// <summary>
		/// specify a parameter for a program object
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose parameter to modify.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to modify.
		/// </param>
		/// <param name="value">
		/// Specifies the new value of the parameter specified by pname for program.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_get_program_binary")]
		public static void ProgramParameter(UInt32 program, int pname, Int32 value)
		{
			if        (Delegates.pglProgramParameteri != null) {
				Delegates.pglProgramParameteri(program, pname, value);
				CallLog("glProgramParameteri({0}, {1}, {2})", program, pname, value);
			} else if (Delegates.pglProgramParameteriARB != null) {
				Delegates.pglProgramParameteriARB(program, pname, value);
				CallLog("glProgramParameteriARB({0}, {1}, {2})", program, pname, value);
			} else if (Delegates.pglProgramParameteriEXT != null) {
				Delegates.pglProgramParameteriEXT(program, pname, value);
				CallLog("glProgramParameteriEXT({0}, {1}, {2})", program, pname, value);
			} else
				throw new NotImplementedException("glProgramParameteri (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind stages of a program object to a program pipeline
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to which to bind stages from program.
		/// </param>
		/// <param name="stages">
		/// Specifies a set of program stages to bind to the program pipeline object.
		/// </param>
		/// <param name="program">
		/// Specifies the program object containing the shader executables to use in pipeline.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void UseProgramStage(UInt32 pipeline, uint stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStages != null, "pglUseProgramStages not implemented");
			Delegates.pglUseProgramStages(pipeline, stages, program);
			CallLog("glUseProgramStages({0}, {1}, {2})", pipeline, stages, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// set the active program object for a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to set the active program object for.
		/// </param>
		/// <param name="program">
		/// Specifies the program object to set as the active program pipeline object pipeline.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ActiveShaderProgram(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgram != null, "pglActiveShaderProgram not implemented");
			Delegates.pglActiveShaderProgram(pipeline, program);
			CallLog("glActiveShaderProgram({0}, {1})", pipeline, program);
			DebugCheckErrors();
		}

		/// <summary>
		/// create a stand-alone program from an array of null-terminated source code strings
		/// </summary>
		/// <param name="type">
		/// Specifies the type of shader to create.
		/// </param>
		/// <param name="count">
		/// Specifies the number of source code strings in the array strings.
		/// </param>
		/// <param name="strings">
		/// Specifies the address of an array of pointers to source code strings from which to create the program object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static UInt32 CreateShaderProgram(int type, params String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
			retValue = Delegates.pglCreateShaderProgramv(type, (Int32)strings.Length, strings);
			CallLog("glCreateShaderProgramv({0}, {1}, {2}) = {3}", type, strings.Length, strings, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a program pipeline to the current context
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of the pipeline object to bind to the context.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void BindProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipeline != null, "pglBindProgramPipeline not implemented");
			Delegates.pglBindProgramPipeline(pipeline);
			CallLog("glBindProgramPipeline({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete program pipeline objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of program pipeline objects to delete.
		/// </param>
		/// <param name="pipelines">
		/// Specifies an array of names of program pipeline objects to delete.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void DeleteProgramPipelines(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelines != null, "pglDeleteProgramPipelines not implemented");
					Delegates.pglDeleteProgramPipelines((Int32)pipelines.Length, p_pipelines);
					CallLog("glDeleteProgramPipelines({0}, {1})", pipelines.Length, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of program pipeline object names to reserve.
		/// </param>
		/// <param name="pipelines">
		/// Specifies an array of into which the reserved names will be written.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void GenProgramPipelines(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelines != null, "pglGenProgramPipelines not implemented");
					Delegates.pglGenProgramPipelines((Int32)pipelines.Length, p_pipelines);
					CallLog("glGenProgramPipelines({0}, {1})", pipelines.Length, pipelines);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static UInt32 GenProgramPipeline()
		{
			UInt32[] retValue = new UInt32[1];
			GenProgramPipelines(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies a value that may be the name of a program pipeline object.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static bool IsProgramPipeline(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipeline != null, "pglIsProgramPipeline not implemented");
			retValue = Delegates.pglIsProgramPipeline(pipeline);
			CallLog("glIsProgramPipeline({0}) = {1}", pipeline, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// retrieve properties of a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object whose parameter retrieve.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to retrieve.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void GetProgramPipeline(UInt32 pipeline, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineiv != null, "pglGetProgramPipelineiv not implemented");
					Delegates.pglGetProgramPipelineiv(pipeline, pname, p_params);
					CallLog("glGetProgramPipelineiv({0}, {1}, {2})", pipeline, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 v0)
		{
			if        (Delegates.pglProgramUniform1i != null) {
				Delegates.pglProgramUniform1i(program, location, v0);
				CallLog("glProgramUniform1i({0}, {1}, {2})", program, location, v0);
			} else if (Delegates.pglProgramUniform1iEXT != null) {
				Delegates.pglProgramUniform1iEXT(program, location, v0);
				CallLog("glProgramUniform1iEXT({0}, {1}, {2})", program, location, v0);
			} else
				throw new NotImplementedException("glProgramUniform1i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglProgramUniform1iv != null) {
						Delegates.pglProgramUniform1iv(program, location, count, p_value);
						CallLog("glProgramUniform1iv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform1ivEXT != null) {
						Delegates.pglProgramUniform1ivEXT(program, location, count, p_value);
						CallLog("glProgramUniform1ivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform1iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, float v0)
		{
			if        (Delegates.pglProgramUniform1f != null) {
				Delegates.pglProgramUniform1f(program, location, v0);
				CallLog("glProgramUniform1f({0}, {1}, {2})", program, location, v0);
			} else if (Delegates.pglProgramUniform1fEXT != null) {
				Delegates.pglProgramUniform1fEXT(program, location, v0);
				CallLog("glProgramUniform1fEXT({0}, {1}, {2})", program, location, v0);
			} else
				throw new NotImplementedException("glProgramUniform1f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniform1fv != null) {
						Delegates.pglProgramUniform1fv(program, location, count, p_value);
						CallLog("glProgramUniform1fv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform1fvEXT != null) {
						Delegates.pglProgramUniform1fvEXT(program, location, count, p_value);
						CallLog("glProgramUniform1fvEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform1fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform1d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, double v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1d != null, "pglProgramUniform1d not implemented");
			Delegates.pglProgramUniform1d(program, location, v0);
			CallLog("glProgramUniform1d({0}, {1}, {2})", program, location, v0);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform1dv.
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
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
					Delegates.pglProgramUniform1dv(program, location, count, p_value);
					CallLog("glProgramUniform1dv({0}, {1}, {2}, {3})", program, location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, UInt32 v0)
		{
			if        (Delegates.pglProgramUniform1ui != null) {
				Delegates.pglProgramUniform1ui(program, location, v0);
				CallLog("glProgramUniform1ui({0}, {1}, {2})", program, location, v0);
			} else if (Delegates.pglProgramUniform1uiEXT != null) {
				Delegates.pglProgramUniform1uiEXT(program, location, v0);
				CallLog("glProgramUniform1uiEXT({0}, {1}, {2})", program, location, v0);
			} else
				throw new NotImplementedException("glProgramUniform1ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglProgramUniform1uiv != null) {
						Delegates.pglProgramUniform1uiv(program, location, count, p_value);
						CallLog("glProgramUniform1uiv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform1uivEXT != null) {
						Delegates.pglProgramUniform1uivEXT(program, location, count, p_value);
						CallLog("glProgramUniform1uivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform1uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 v0, Int32 v1)
		{
			if        (Delegates.pglProgramUniform2i != null) {
				Delegates.pglProgramUniform2i(program, location, v0, v1);
				CallLog("glProgramUniform2i({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else if (Delegates.pglProgramUniform2iEXT != null) {
				Delegates.pglProgramUniform2iEXT(program, location, v0, v1);
				CallLog("glProgramUniform2iEXT({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else
				throw new NotImplementedException("glProgramUniform2i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglProgramUniform2iv != null) {
						Delegates.pglProgramUniform2iv(program, location, count, p_value);
						CallLog("glProgramUniform2iv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform2ivEXT != null) {
						Delegates.pglProgramUniform2ivEXT(program, location, count, p_value);
						CallLog("glProgramUniform2ivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform2iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, float v0, float v1)
		{
			if        (Delegates.pglProgramUniform2f != null) {
				Delegates.pglProgramUniform2f(program, location, v0, v1);
				CallLog("glProgramUniform2f({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else if (Delegates.pglProgramUniform2fEXT != null) {
				Delegates.pglProgramUniform2fEXT(program, location, v0, v1);
				CallLog("glProgramUniform2fEXT({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else
				throw new NotImplementedException("glProgramUniform2f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniform2fv != null) {
						Delegates.pglProgramUniform2fv(program, location, count, p_value);
						CallLog("glProgramUniform2fv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform2fvEXT != null) {
						Delegates.pglProgramUniform2fvEXT(program, location, count, p_value);
						CallLog("glProgramUniform2fvEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform2d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, double v0, double v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2d != null, "pglProgramUniform2d not implemented");
			Delegates.pglProgramUniform2d(program, location, v0, v1);
			CallLog("glProgramUniform2d({0}, {1}, {2}, {3})", program, location, v0, v1);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform2dv.
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
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
					Delegates.pglProgramUniform2dv(program, location, count, p_value);
					CallLog("glProgramUniform2dv({0}, {1}, {2}, {3})", program, location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
		{
			if        (Delegates.pglProgramUniform2ui != null) {
				Delegates.pglProgramUniform2ui(program, location, v0, v1);
				CallLog("glProgramUniform2ui({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else if (Delegates.pglProgramUniform2uiEXT != null) {
				Delegates.pglProgramUniform2uiEXT(program, location, v0, v1);
				CallLog("glProgramUniform2uiEXT({0}, {1}, {2}, {3})", program, location, v0, v1);
			} else
				throw new NotImplementedException("glProgramUniform2ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglProgramUniform2uiv != null) {
						Delegates.pglProgramUniform2uiv(program, location, count, p_value);
						CallLog("glProgramUniform2uiv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform2uivEXT != null) {
						Delegates.pglProgramUniform2uivEXT(program, location, count, p_value);
						CallLog("glProgramUniform2uivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform2uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			if        (Delegates.pglProgramUniform3i != null) {
				Delegates.pglProgramUniform3i(program, location, v0, v1, v2);
				CallLog("glProgramUniform3i({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else if (Delegates.pglProgramUniform3iEXT != null) {
				Delegates.pglProgramUniform3iEXT(program, location, v0, v1, v2);
				CallLog("glProgramUniform3iEXT({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else
				throw new NotImplementedException("glProgramUniform3i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglProgramUniform3iv != null) {
						Delegates.pglProgramUniform3iv(program, location, count, p_value);
						CallLog("glProgramUniform3iv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform3ivEXT != null) {
						Delegates.pglProgramUniform3ivEXT(program, location, count, p_value);
						CallLog("glProgramUniform3ivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform3iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, float v0, float v1, float v2)
		{
			if        (Delegates.pglProgramUniform3f != null) {
				Delegates.pglProgramUniform3f(program, location, v0, v1, v2);
				CallLog("glProgramUniform3f({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else if (Delegates.pglProgramUniform3fEXT != null) {
				Delegates.pglProgramUniform3fEXT(program, location, v0, v1, v2);
				CallLog("glProgramUniform3fEXT({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else
				throw new NotImplementedException("glProgramUniform3f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniform3fv != null) {
						Delegates.pglProgramUniform3fv(program, location, count, p_value);
						CallLog("glProgramUniform3fv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform3fvEXT != null) {
						Delegates.pglProgramUniform3fvEXT(program, location, count, p_value);
						CallLog("glProgramUniform3fvEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform3d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, double v0, double v1, double v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3d != null, "pglProgramUniform3d not implemented");
			Delegates.pglProgramUniform3d(program, location, v0, v1, v2);
			CallLog("glProgramUniform3d({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform3dv.
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
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
					Delegates.pglProgramUniform3dv(program, location, count, p_value);
					CallLog("glProgramUniform3dv({0}, {1}, {2}, {3})", program, location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			if        (Delegates.pglProgramUniform3ui != null) {
				Delegates.pglProgramUniform3ui(program, location, v0, v1, v2);
				CallLog("glProgramUniform3ui({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else if (Delegates.pglProgramUniform3uiEXT != null) {
				Delegates.pglProgramUniform3uiEXT(program, location, v0, v1, v2);
				CallLog("glProgramUniform3uiEXT({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			} else
				throw new NotImplementedException("glProgramUniform3ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglProgramUniform3uiv != null) {
						Delegates.pglProgramUniform3uiv(program, location, count, p_value);
						CallLog("glProgramUniform3uiv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform3uivEXT != null) {
						Delegates.pglProgramUniform3uivEXT(program, location, count, p_value);
						CallLog("glProgramUniform3uivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform3uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			if        (Delegates.pglProgramUniform4i != null) {
				Delegates.pglProgramUniform4i(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4i({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else if (Delegates.pglProgramUniform4iEXT != null) {
				Delegates.pglProgramUniform4iEXT(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4iEXT({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glProgramUniform4i (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					if        (Delegates.pglProgramUniform4iv != null) {
						Delegates.pglProgramUniform4iv(program, location, count, p_value);
						CallLog("glProgramUniform4iv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform4ivEXT != null) {
						Delegates.pglProgramUniform4ivEXT(program, location, count, p_value);
						CallLog("glProgramUniform4ivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform4iv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, float v0, float v1, float v2, float v3)
		{
			if        (Delegates.pglProgramUniform4f != null) {
				Delegates.pglProgramUniform4f(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4f({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else if (Delegates.pglProgramUniform4fEXT != null) {
				Delegates.pglProgramUniform4fEXT(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4fEXT({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glProgramUniform4f (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniform4fv != null) {
						Delegates.pglProgramUniform4fv(program, location, count, p_value);
						CallLog("glProgramUniform4fv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform4fvEXT != null) {
						Delegates.pglProgramUniform4fvEXT(program, location, count, p_value);
						CallLog("glProgramUniform4fvEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform4d.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v0">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v1">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="v3">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, double v0, double v1, double v2, double v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4d != null, "pglProgramUniform4d not implemented");
			Delegates.pglProgramUniform4d(program, location, v0, v1, v2, v3);
			CallLog("glProgramUniform4d({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniform4dv.
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
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
					Delegates.pglProgramUniform4dv(program, location, count, p_value);
					CallLog("glProgramUniform4dv({0}, {1}, {2}, {3})", program, location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			if        (Delegates.pglProgramUniform4ui != null) {
				Delegates.pglProgramUniform4ui(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4ui({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else if (Delegates.pglProgramUniform4uiEXT != null) {
				Delegates.pglProgramUniform4uiEXT(program, location, v0, v1, v2, v3);
				CallLog("glProgramUniform4uiEXT({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			} else
				throw new NotImplementedException("glProgramUniform4ui (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					if        (Delegates.pglProgramUniform4uiv != null) {
						Delegates.pglProgramUniform4uiv(program, location, count, p_value);
						CallLog("glProgramUniform4uiv({0}, {1}, {2}, {3})", program, location, count, value);
					} else if (Delegates.pglProgramUniform4uivEXT != null) {
						Delegates.pglProgramUniform4uivEXT(program, location, count, p_value);
						CallLog("glProgramUniform4uivEXT({0}, {1}, {2}, {3})", program, location, count, value);
					} else
						throw new NotImplementedException("glProgramUniform4uiv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix2fv != null) {
						Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix2fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix2fvEXT != null) {
						Delegates.pglProgramUniformMatrix2fvEXT(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix2fvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix3fv != null) {
						Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix3fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix3fvEXT != null) {
						Delegates.pglProgramUniformMatrix3fvEXT(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix3fvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix4fv != null) {
						Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix4fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix4fvEXT != null) {
						Delegates.pglProgramUniformMatrix4fvEXT(program, location, count, transpose, p_value);
						CallLog("glProgramUniformMatrix4fvEXT({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
					Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, p_value);
					CallLog("glProgramUniformMatrix2dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
					Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, p_value);
					CallLog("glProgramUniformMatrix3dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
					Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, p_value);
					CallLog("glProgramUniformMatrix4dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix2x3fv != null) {
						Delegates.pglProgramUniformMatrix2x3fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix2x3fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix2x3fvEXT != null) {
						Delegates.pglProgramUniformMatrix2x3fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix2x3fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix2x3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix3x2fv != null) {
						Delegates.pglProgramUniformMatrix3x2fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix3x2fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix3x2fvEXT != null) {
						Delegates.pglProgramUniformMatrix3x2fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix3x2fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix3x2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix2x4fv != null) {
						Delegates.pglProgramUniformMatrix2x4fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix2x4fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix2x4fvEXT != null) {
						Delegates.pglProgramUniformMatrix2x4fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix2x4fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix2x4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix4x2fv != null) {
						Delegates.pglProgramUniformMatrix4x2fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix4x2fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix4x2fvEXT != null) {
						Delegates.pglProgramUniformMatrix4x2fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix4x2fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix4x2fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix3x4fv != null) {
						Delegates.pglProgramUniformMatrix3x4fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix3x4fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix3x4fvEXT != null) {
						Delegates.pglProgramUniformMatrix3x4fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix3x4fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix3x4fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for a specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the handle of the program containing the uniform variable to be modified.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector commands (glProgramUniform*v), specifies the number of elements that are to be modified. This should be 1 
		/// if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, bool transpose, params float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					if        (Delegates.pglProgramUniformMatrix4x3fv != null) {
						Delegates.pglProgramUniformMatrix4x3fv(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix4x3fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else if (Delegates.pglProgramUniformMatrix4x3fvEXT != null) {
						Delegates.pglProgramUniformMatrix4x3fvEXT(program, location, (Int32)value.Length, transpose, p_value);
						CallLog("glProgramUniformMatrix4x3fvEXT({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
					} else
						throw new NotImplementedException("glProgramUniformMatrix4x3fv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x3dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
					Delegates.pglProgramUniformMatrix2x3dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix2x3dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x2dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
					Delegates.pglProgramUniformMatrix3x2dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix3x2dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix2x4dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
					Delegates.pglProgramUniformMatrix2x4dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix2x4dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x2dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
					Delegates.pglProgramUniformMatrix4x2dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix4x2dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix3x4dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
					Delegates.pglProgramUniformMatrix3x4dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix3x4dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glProgramUniformMatrix4x3dv.
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, bool transpose, params double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
					Delegates.pglProgramUniformMatrix4x3dv(program, location, (Int32)value.Length, transpose, p_value);
					CallLog("glProgramUniformMatrix4x3dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// validate a program pipeline object against current GL state
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object to validate.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void ValidateProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipeline != null, "pglValidateProgramPipeline not implemented");
			Delegates.pglValidateProgramPipeline(pipeline);
			CallLog("glValidateProgramPipeline({0})", pipeline);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the info log string from a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object from which to retrieve the info log.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters, including the null terminator, that may be written into infoLog.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable into which will be written the number of characters written into infoLog.
		/// </param>
		/// <param name="infoLog">
		/// Specifies the address of an array of characters into which will be written the info log for pipeline.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects")]
		public static void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLog != null, "pglGetProgramPipelineInfoLog not implemented");
					Delegates.pglGetProgramPipelineInfoLog(pipeline, bufSize, p_length, infoLog);
					CallLog("glGetProgramPipelineInfoLog({0}, {1}, {2}, {3})", pipeline, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double x)
		{
			if        (Delegates.pglVertexAttribL1d != null) {
				Delegates.pglVertexAttribL1d(index, x);
				CallLog("glVertexAttribL1d({0}, {1})", index, x);
			} else if (Delegates.pglVertexAttribL1dEXT != null) {
				Delegates.pglVertexAttribL1dEXT(index, x);
				CallLog("glVertexAttribL1dEXT({0}, {1})", index, x);
			} else
				throw new NotImplementedException("glVertexAttribL1d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double x, double y)
		{
			if        (Delegates.pglVertexAttribL2d != null) {
				Delegates.pglVertexAttribL2d(index, x, y);
				CallLog("glVertexAttribL2d({0}, {1}, {2})", index, x, y);
			} else if (Delegates.pglVertexAttribL2dEXT != null) {
				Delegates.pglVertexAttribL2dEXT(index, x, y);
				CallLog("glVertexAttribL2dEXT({0}, {1}, {2})", index, x, y);
			} else
				throw new NotImplementedException("glVertexAttribL2d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double x, double y, double z)
		{
			if        (Delegates.pglVertexAttribL3d != null) {
				Delegates.pglVertexAttribL3d(index, x, y, z);
				CallLog("glVertexAttribL3d({0}, {1}, {2}, {3})", index, x, y, z);
			} else if (Delegates.pglVertexAttribL3dEXT != null) {
				Delegates.pglVertexAttribL3dEXT(index, x, y, z);
				CallLog("glVertexAttribL3dEXT({0}, {1}, {2}, {3})", index, x, y, z);
			} else
				throw new NotImplementedException("glVertexAttribL3d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double x, double y, double z, double w)
		{
			if        (Delegates.pglVertexAttribL4d != null) {
				Delegates.pglVertexAttribL4d(index, x, y, z, w);
				CallLog("glVertexAttribL4d({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else if (Delegates.pglVertexAttribL4dEXT != null) {
				Delegates.pglVertexAttribL4dEXT(index, x, y, z, w);
				CallLog("glVertexAttribL4dEXT({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			} else
				throw new NotImplementedException("glVertexAttribL4d (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttribL1dv != null) {
						Delegates.pglVertexAttribL1dv(index, p_v);
						CallLog("glVertexAttribL1dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribL1dvEXT != null) {
						Delegates.pglVertexAttribL1dvEXT(index, p_v);
						CallLog("glVertexAttribL1dvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribL1dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttribL2dv != null) {
						Delegates.pglVertexAttribL2dv(index, p_v);
						CallLog("glVertexAttribL2dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribL2dvEXT != null) {
						Delegates.pglVertexAttribL2dvEXT(index, p_v);
						CallLog("glVertexAttribL2dvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribL2dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttribL3dv != null) {
						Delegates.pglVertexAttribL3dv(index, p_v);
						CallLog("glVertexAttribL3dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribL3dvEXT != null) {
						Delegates.pglVertexAttribL3dvEXT(index, p_v);
						CallLog("glVertexAttribL3dvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribL3dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					if        (Delegates.pglVertexAttribL4dv != null) {
						Delegates.pglVertexAttribL4dv(index, p_v);
						CallLog("glVertexAttribL4dv({0}, {1})", index, v);
					} else if (Delegates.pglVertexAttribL4dvEXT != null) {
						Delegates.pglVertexAttribL4dvEXT(index, p_v);
						CallLog("glVertexAttribL4dvEXT({0}, {1})", index, v);
					} else
						throw new NotImplementedException("glVertexAttribL4dv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			if        (Delegates.pglVertexAttribLPointer != null) {
				Delegates.pglVertexAttribLPointer(index, size, type, stride, pointer);
				CallLog("glVertexAttribLPointer({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			} else if (Delegates.pglVertexAttribLPointerEXT != null) {
				Delegates.pglVertexAttribLPointerEXT(index, size, type, stride, pointer);
				CallLog("glVertexAttribLPointerEXT({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			} else
				throw new NotImplementedException("glVertexAttribLPointer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribLPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public static void GetVertexAttribL(UInt32 index, int pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					if        (Delegates.pglGetVertexAttribLdv != null) {
						Delegates.pglGetVertexAttribLdv(index, pname, p_params);
						CallLog("glGetVertexAttribLdv({0}, {1}, {2})", index, pname, @params);
					} else if (Delegates.pglGetVertexAttribLdvEXT != null) {
						Delegates.pglGetVertexAttribLdvEXT(index, pname, p_params);
						CallLog("glGetVertexAttribLdvEXT({0}, {1}, {2})", index, pname, @params);
					} else
						throw new NotImplementedException("glGetVertexAttribLdv (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportArrayv.
		/// </summary>
		/// <param name="first">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ViewportArray(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportArrayv != null, "pglViewportArrayv not implemented");
					Delegates.pglViewportArrayv(first, count, p_v);
					CallLog("glViewportArrayv({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportIndexedf.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ViewportIndexed(UInt32 index, float x, float y, float w, float h)
		{
			Debug.Assert(Delegates.pglViewportIndexedf != null, "pglViewportIndexedf not implemented");
			Delegates.pglViewportIndexedf(index, x, y, w, h);
			CallLog("glViewportIndexedf({0}, {1}, {2}, {3}, {4})", index, x, y, w, h);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glViewportIndexedfv.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ViewportIndexed(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportIndexedfv != null, "pglViewportIndexedfv not implemented");
					Delegates.pglViewportIndexedfv(index, p_v);
					CallLog("glViewportIndexedfv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define the scissor box for multiple viewports
		/// </summary>
		/// <param name="first">
		/// Specifies the index of the first viewport whose scissor box to modify.
		/// </param>
		/// <param name="count">
		/// Specifies the number of scissor boxes to modify.
		/// </param>
		/// <param name="v">
		/// Specifies the address of an array containing the left, bottom, width and height of each scissor box, in that order.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ScissorArray(UInt32 first, Int32 count, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorArrayv != null, "pglScissorArrayv not implemented");
					Delegates.pglScissorArrayv(first, count, p_v);
					CallLog("glScissorArrayv({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// define the scissor box for a specific viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose scissor box to modify.
		/// </param>
		/// <param name="left">
		/// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinate of the bottom left corner of the scissor box, in pixels.
		/// </param>
		/// <param name="width">
		/// Specify ths dimensions of the scissor box, in pixels.
		/// </param>
		/// <param name="height">
		/// Specify ths dimensions of the scissor box, in pixels.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissorIndexed != null, "pglScissorIndexed not implemented");
			Delegates.pglScissorIndexed(index, left, bottom, width, height);
			CallLog("glScissorIndexed({0}, {1}, {2}, {3}, {4})", index, left, bottom, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// define the scissor box for a specific viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose scissor box to modify.
		/// </param>
		/// <param name="v">
		/// For glScissorIndexedv, specifies the address of an array containing the left, bottom, width and height of each scissor 
		/// box, in that order.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void ScissorIndexed(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorIndexedv != null, "pglScissorIndexedv not implemented");
					Delegates.pglScissorIndexedv(index, p_v);
					CallLog("glScissorIndexedv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates for a specified set of viewports
		/// </summary>
		/// <param name="first">
		/// Specifies the index of the first viewport whose depth range to update.
		/// </param>
		/// <param name="count">
		/// Specifies the number of viewports whose depth range to update.
		/// </param>
		/// <param name="v">
		/// Specifies the address of an array containing the near and far values for the depth range of each modified viewport.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void DepthRangeArray(UInt32 first, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayv != null, "pglDepthRangeArrayv not implemented");
					Delegates.pglDepthRangeArrayv(first, count, p_v);
					CallLog("glDepthRangeArrayv({0}, {1}, {2})", first, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates for a specified viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose depth range to update.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void DepthRangeIndexed(UInt32 index, double n, double f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexed != null, "pglDepthRangeIndexed not implemented");
			Delegates.pglDepthRangeIndexed(index, n, f);
			CallLog("glDepthRangeIndexed({0}, {1}, {2})", index, n, f);
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void Get(int target, UInt32 index, float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					if        (Delegates.pglGetFloati_v != null) {
						Delegates.pglGetFloati_v(target, index, p_data);
						CallLog("glGetFloati_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetFloatIndexedvEXT != null) {
						Delegates.pglGetFloatIndexedvEXT(target, index, p_data);
						CallLog("glGetFloatIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetFloati_vEXT != null) {
						Delegates.pglGetFloati_vEXT(target, index, p_data);
						CallLog("glGetFloati_vEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetFloati_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void Get(int target, UInt32 index, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					if        (Delegates.pglGetFloati_v != null) {
						Delegates.pglGetFloati_v(target, index, p_data);
						CallLog("glGetFloati_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetFloatIndexedvEXT != null) {
						Delegates.pglGetFloatIndexedvEXT(target, index, p_data);
						CallLog("glGetFloatIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetFloati_vEXT != null) {
						Delegates.pglGetFloati_vEXT(target, index, p_data);
						CallLog("glGetFloati_vEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetFloati_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void Get(int target, UInt32 index, double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					if        (Delegates.pglGetDoublei_v != null) {
						Delegates.pglGetDoublei_v(target, index, p_data);
						CallLog("glGetDoublei_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetDoubleIndexedvEXT != null) {
						Delegates.pglGetDoubleIndexedvEXT(target, index, p_data);
						CallLog("glGetDoubleIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetDoublei_vEXT != null) {
						Delegates.pglGetDoublei_vEXT(target, index, p_data);
						CallLog("glGetDoublei_vEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetDoublei_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array")]
		public static void Get(int target, UInt32 index, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					if        (Delegates.pglGetDoublei_v != null) {
						Delegates.pglGetDoublei_v(target, index, p_data);
						CallLog("glGetDoublei_v({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetDoubleIndexedvEXT != null) {
						Delegates.pglGetDoubleIndexedvEXT(target, index, p_data);
						CallLog("glGetDoubleIndexedvEXT({0}, {1}, {2})", target, index, data);
					} else if (Delegates.pglGetDoublei_vEXT != null) {
						Delegates.pglGetDoublei_vEXT(target, index, p_data);
						CallLog("glGetDoublei_vEXT({0}, {1}, {2})", target, index, data);
					} else
						throw new NotImplementedException("glGetDoublei_v (and other aliases) are not implemented");
				}
			}
			DebugCheckErrors();
		}

	}

}
