
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
		[AliasOf("GL_FIXED_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		public const int FIXED = 0x140C;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data type. See Gl.ReadPixels.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a GLenum value indicating the implementation's preferred pixel data type for 
		/// the framebuffer object. See Gl.ReadPixels.
		/// </para>
		/// </summary>
		[AliasOf("GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		public const int IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single GLenum value indicating the implementation's preferred pixel data format. See 
		/// Gl.ReadPixels.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a GLenum value indicating the preferred pixel data format for the framebuffer 
		/// object. See Gl.ReadPixels.
		/// </para>
		/// </summary>
		[AliasOf("GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		public const int IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B;

		/// <summary>
		/// Value of GL_LOW_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int LOW_FLOAT = 0x8DF0;

		/// <summary>
		/// Value of GL_MEDIUM_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MEDIUM_FLOAT = 0x8DF1;

		/// <summary>
		/// Value of GL_HIGH_FLOAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int HIGH_FLOAT = 0x8DF2;

		/// <summary>
		/// Value of GL_LOW_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int LOW_INT = 0x8DF3;

		/// <summary>
		/// Value of GL_MEDIUM_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MEDIUM_INT = 0x8DF4;

		/// <summary>
		/// Value of GL_HIGH_INT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int HIGH_INT = 0x8DF5;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether an online shader compiler is present in the 
		/// implementation. All desktop OpenGL implementations must support online shader compilations, and therefore the value of 
		/// Gl.SHADER_COMPILER will always be Gl.TRUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int SHADER_COMPILER = 0x8DFA;

		/// <summary>
		/// Value of GL_SHADER_BINARY_FORMATS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int SHADER_BINARY_FORMATS = 0x8DF8;

		/// <summary>
		/// Gl.Get: data returns one value, the number of binary shader formats supported by the implementation. If this value is 
		/// greater than zero, then the implementation supports loading binary shaders. If it is zero, then the loading of binary 
		/// shaders by the implementation is not supported.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int NUM_SHADER_BINARY_FORMATS = 0x8DF9;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of 4-vectors that may be held in uniform variable storage for the 
		/// vertex shader. The value of Gl.MAX_VERTEX_UNIFORM_VECTORS is equal to the value of Gl.MAX_VERTEX_UNIFORM_COMPONENTS and 
		/// must be at least 256.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB;

		/// <summary>
		/// Gl.Get: data returns one value, the number 4-vectors for varying variables, which is equal to the value of 
		/// Gl.MAX_VARYING_COMPONENTS and must be at least 15.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_VARYING_VECTORS = 0x8DFC;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of individual 4-vectors of floating-point, integer, or boolean values 
		/// that can be held in uniform variable storage for a fragment shader. The value is equal to the value of 
		/// Gl.MAX_FRAGMENT_UNIFORM_COMPONENTS divided by 4 and must be at least 256. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public const int MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD;

		/// <summary>
		/// Value of GL_RGB565 symbol.
		/// </summary>
		[AliasOf("GL_RGB565_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		public const int RGB565 = 0x8D62;

		/// <summary>
		/// Value of GL_PROGRAM_BINARY_RETRIEVABLE_HINT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		public const int PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257;

		/// <summary>
		/// Gl.GetProgram: params returns the length of the program binary, in bytes that will be returned by a call to 
		/// Gl.GetProgramBinary. When a progam's Gl.LINK_STATUS is Gl.FALSE, its program binary length is zero.
		/// </summary>
		[AliasOf("GL_PROGRAM_BINARY_LENGTH_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int PROGRAM_BINARY_LENGTH = 0x8741;

		/// <summary>
		/// Gl.Get: data returns one value, the number of program binary formats supported by the implementation.
		/// </summary>
		[AliasOf("GL_NUM_PROGRAM_BINARY_FORMATS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int NUM_PROGRAM_BINARY_FORMATS = 0x87FE;

		/// <summary>
		/// Gl.Get: data an array of Gl.NUM_PROGRAM_BINARY_FORMATS values, indicating the proram binary formats supported by the 
		/// implementation.
		/// </summary>
		[AliasOf("GL_PROGRAM_BINARY_FORMATS_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public const int PROGRAM_BINARY_FORMATS = 0x87FF;

		/// <summary>
		/// Value of GL_VERTEX_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_SHADER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint VERTEX_SHADER_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_FRAGMENT_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_FRAGMENT_SHADER_BIT_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FRAGMENT_SHADER_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_GEOMETRY_SHADER_BIT_EXT")]
		[AliasOf("GL_GEOMETRY_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint GEOMETRY_SHADER_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_TESS_CONTROL_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TESS_CONTROL_SHADER_BIT_EXT")]
		[AliasOf("GL_TESS_CONTROL_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint TESS_CONTROL_SHADER_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_TESS_EVALUATION_SHADER_BIT symbol.
		/// </summary>
		[AliasOf("GL_TESS_EVALUATION_SHADER_BIT_EXT")]
		[AliasOf("GL_TESS_EVALUATION_SHADER_BIT_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint TESS_EVALUATION_SHADER_BIT = 0x00000010;

		/// <summary>
		/// Value of GL_ALL_SHADER_BITS symbol.
		/// </summary>
		[AliasOf("GL_ALL_SHADER_BITS_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		[Log(BitmaskName = "GL")]
		public const uint ALL_SHADER_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Value of GL_PROGRAM_SEPARABLE symbol.
		/// </summary>
		[AliasOf("GL_PROGRAM_SEPARABLE_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public const int PROGRAM_SEPARABLE = 0x8258;

		/// <summary>
		/// Value of GL_ACTIVE_PROGRAM symbol.
		/// </summary>
		[AliasOf("GL_ACTIVE_PROGRAM_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public const int ACTIVE_PROGRAM = 0x8259;

		/// <summary>
		/// Gl.Get: data a single value, the name of the currently bound program pipeline object, or zero if no program pipeline 
		/// object is bound. See Gl.BindProgramPipeline.
		/// </summary>
		[AliasOf("GL_PROGRAM_PIPELINE_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public const int PROGRAM_PIPELINE_BINDING = 0x825A;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of simultaneous viewports that are supported. The value must be at 
		/// least 16. See Gl.ViewportIndexed.
		/// </summary>
		[AliasOf("GL_MAX_VIEWPORTS_NV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public const int MAX_VIEWPORTS = 0x825B;

		/// <summary>
		/// Gl.Get: data returns a single value, the number of bits of sub-pixel precision which the GL uses to interpret the 
		/// floating point viewport bounds. The minimum value is 0.
		/// </summary>
		[AliasOf("GL_VIEWPORT_SUBPIXEL_BITS_NV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public const int VIEWPORT_SUBPIXEL_BITS = 0x825C;

		/// <summary>
		/// Gl.Get: data returns two values, the minimum and maximum viewport bounds range. The minimum range should be at least 
		/// [-32768, 32767].
		/// </summary>
		[AliasOf("GL_VIEWPORT_BOUNDS_RANGE_NV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public const int VIEWPORT_BOUNDS_RANGE = 0x825D;

		/// <summary>
		/// Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to select the 
		/// rendering layer. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows the 
		/// convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then the 
		/// selection is always taken from the first vertex in the primitive. If the value returned is equivalent to 
		/// Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value 
		/// returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex 
		/// in the primitive.
		/// </summary>
		[AliasOf("GL_LAYER_PROVOKING_VERTEX_EXT")]
		[AliasOf("GL_LAYER_PROVOKING_VERTEX_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int LAYER_PROVOKING_VERTEX = 0x825E;

		/// <summary>
		/// Gl.Get: data returns one value, the implementation dependent specifc vertex of a primitive that is used to select the 
		/// viewport index. If the value returned is equivalent to Gl.PROVOKING_VERTEX, then the vertex selection follows the 
		/// convention specified by Gl.ProvokingVertex. If the value returned is equivalent to Gl.FIRST_VERTEX_CONVENTION, then the 
		/// selection is always taken from the first vertex in the primitive. If the value returned is equivalent to 
		/// Gl.LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value 
		/// returned is equivalent to Gl.UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex 
		/// in the primitive.
		/// </summary>
		[AliasOf("GL_VIEWPORT_INDEX_PROVOKING_VERTEX_NV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public const int VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F;

		/// <summary>
		/// Value of GL_UNDEFINED_VERTEX symbol.
		/// </summary>
		[AliasOf("GL_UNDEFINED_VERTEX_EXT")]
		[AliasOf("GL_UNDEFINED_VERTEX_OES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		public const int UNDEFINED_VERTEX = 0x8260;

		/// <summary>
		/// release resources consumed by the implementation's shader compiler
		/// </summary>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ReleaseShaderCompiler()
		{
			Debug.Assert(Delegates.pglReleaseShaderCompiler != null, "pglReleaseShaderCompiler not implemented");
			Delegates.pglReleaseShaderCompiler();
			LogFunction("glReleaseShaderCompiler()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load pre-compiled shader binaries
		/// </summary>
		/// <param name="count">
		/// Specifies the number of shader object handles contained in <paramref name="shaders"/>.
		/// </param>
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// Specifies the format of the shader binaries contained in <paramref name="binary"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in <paramref name="binary"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if more than one of the handles in <paramref name="shaders"/> refers to the same 
		/// shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the data pointed to by <paramref name="binary"/> does not match the format specified by 
		/// <paramref name="binaryFormat"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryformat, Object binary, Int32 length)
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
		/// <param name="shaders">
		/// Specifies the address of an array of shader handles into which to load pre-compiled shader binaries.
		/// </param>
		/// <param name="binaryformat">
		/// Specifies the format of the shader binaries contained in <paramref name="binary"/>.
		/// </param>
		/// <param name="binary">
		/// Specifies the address of an array of bytes containing pre-compiled binary shader code.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the array whose address is given in <paramref name="binary"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if more than one of the handles in <paramref name="shaders"/> refers to the same 
		/// shader object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the data pointed to by <paramref name="binary"/> does not match the format specified by 
		/// <paramref name="binaryFormat"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void ShaderBinary(UInt32[] shaders, Int32 binaryformat, IntPtr binary, Int32 length)
		{
			unsafe {
				fixed (UInt32* p_shaders = shaders)
				{
					Debug.Assert(Delegates.pglShaderBinary != null, "pglShaderBinary not implemented");
					Delegates.pglShaderBinary((Int32)shaders.Length, p_shaders, binaryformat, binary, length);
					LogFunction("glShaderBinary({0}, {1}, {2}, 0x{3}, {4})", shaders.Length, LogValue(shaders), LogEnumName(binaryformat), binary.ToString("X8"), length);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the range and precision for numeric formats supported by the shader compiler
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the type of shader whose precision to query. <paramref name="shaderType"/> must be Gl.VERTEX_SHADER or 
		/// Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="precisiontype">
		/// Specifies the numeric format whose precision and range to query.
		/// </param>
		/// <param name="range">
		/// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
		/// </param>
		/// <param name="precision">
		/// Specifies the address of an integer into which the numeric precision of the implementation is written.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> or <paramref name="precisionType"/> is not an accepted 
		/// value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void GetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, [Out] Int32[] range, [Out] Int32[] precision)
		{
			unsafe {
				fixed (Int32* p_range = range)
				fixed (Int32* p_precision = precision)
				{
					Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
					Delegates.pglGetShaderPrecisionFormat(shadertype, precisiontype, p_range, p_precision);
					LogFunction("glGetShaderPrecisionFormat({0}, {1}, {2}, {3})", LogEnumName(shadertype), LogEnumName(precisiontype), LogValue(range), LogValue(precision));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the range and precision for numeric formats supported by the shader compiler
		/// </summary>
		/// <param name="shadertype">
		/// Specifies the type of shader whose precision to query. <paramref name="shaderType"/> must be Gl.VERTEX_SHADER or 
		/// Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="precisiontype">
		/// Specifies the numeric format whose precision and range to query.
		/// </param>
		/// <param name="range">
		/// Specifies the address of array of two integers into which encodings of the implementation's numeric range are returned.
		/// </param>
		/// <param name="precision">
		/// Specifies the address of an integer into which the numeric precision of the implementation is written.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="shaderType"/> or <paramref name="precisionType"/> is not an accepted 
		/// value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		public static void GetShaderPrecisionFormat(Int32 shadertype, Int32 precisiontype, out Int32 range, out Int32 precision)
		{
			unsafe {
				fixed (Int32* p_range = &range)
				fixed (Int32* p_precision = &precision)
				{
					Debug.Assert(Delegates.pglGetShaderPrecisionFormat != null, "pglGetShaderPrecisionFormat not implemented");
					Delegates.pglGetShaderPrecisionFormat(shadertype, precisiontype, p_range, p_precision);
					LogFunction("glGetShaderPrecisionFormat({0}, {1}, {2}, {3})", LogEnumName(shadertype), LogEnumName(precisiontype), range, precision);
				}
			}
			DebugCheckErrors(null);
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
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glDepthRangefOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void DepthRange(float n, float f)
		{
			Debug.Assert(Delegates.pglDepthRangef != null, "pglDepthRangef not implemented");
			Delegates.pglDepthRangef(n, f);
			LogFunction("glDepthRangef({0}, {1})", n, f);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="d">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[AliasOf("glClearDepthfOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void ClearDepth(float d)
		{
			Debug.Assert(Delegates.pglClearDepthf != null, "pglClearDepthf not implemented");
			Delegates.pglClearDepthf(d);
			LogFunction("glClearDepthf({0})", d);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by <paramref name="binary"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return <paramref name="program"/>'s binary representation.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="bufSize"/> is less than the size of Gl.PROGRAM_BINARY_LENGTH for 
		/// <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.LINK_STATUS for the program object is false.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glGetProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out Int32 binaryFormat, IntPtr binary)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_binaryFormat = &binaryFormat)
				{
					Debug.Assert(Delegates.pglGetProgramBinary != null, "pglGetProgramBinary not implemented");
					Delegates.pglGetProgramBinary(program, bufSize, p_length, p_binaryFormat, binary);
					LogFunction("glGetProgramBinary({0}, {1}, {2}, {3}, 0x{4})", program, bufSize, length, LogEnumName(binaryFormat), binary.ToString("X8"));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a binary representation of a program object's compiled and linked executable source
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program object whose binary representation to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer whose address is given by <paramref name="binary"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of bytes written into <paramref name="binary"/>.
		/// </param>
		/// <param name="binaryFormat">
		/// Specifies the address of a variable to receive a token indicating the format of the binary data returned by the GL.
		/// </param>
		/// <param name="binary">
		/// Specifies the address an array into which the GL will return <paramref name="program"/>'s binary representation.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="bufSize"/> is less than the size of Gl.PROGRAM_BINARY_LENGTH for 
		/// <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if Gl.LINK_STATUS for the program object is false.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glGetProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void GetProgramBinary(UInt32 program, Int32 bufSize, out Int32 length, out Int32 binaryFormat, Object binary)
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
		/// Specifies the address an array containing the binary to be loaded into <paramref name="program"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in <paramref name="binary"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not a value recognized by the implementation.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		[AliasOf("glProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length)
		{
			Debug.Assert(Delegates.pglProgramBinary != null, "pglProgramBinary not implemented");
			Delegates.pglProgramBinary(program, binaryFormat, binary, length);
			LogFunction("glProgramBinary({0}, {1}, 0x{2}, {3})", program, LogEnumName(binaryFormat), binary.ToString("X8"), length);
			DebugCheckErrors(null);
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
		/// Specifies the address an array containing the binary to be loaded into <paramref name="program"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the number of bytes contained in <paramref name="binary"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="binaryFormat"/> is not a value recognized by the implementation.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		[AliasOf("glProgramBinaryOES")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_get_program_binary", Api = "gles2")]
		public static void ProgramBinary(UInt32 program, Int32 binaryFormat, Object binary, Int32 length)
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
		/// Specifies the new value of the parameter specified by <paramref name="pname"/> for <paramref name="program"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of an existing program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="value"/> is not a valid value for the parameter named by <paramref 
		/// name="pname"/>.
		/// </exception>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramBinary"/>
		/// <seealso cref="Gl.ProgramBinary"/>
		[AliasOf("glProgramParameteriARB")]
		[AliasOf("glProgramParameteriEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramParameter(UInt32 program, Int32 pname, Int32 value)
		{
			Debug.Assert(Delegates.pglProgramParameteri != null, "pglProgramParameteri not implemented");
			Delegates.pglProgramParameteri(program, pname, value);
			LogFunction("glProgramParameteri({0}, {1}, {2})", program, LogEnumName(pname), value);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// bind stages of a program object to a program pipeline
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to which to bind stages from <paramref name="program"/>.
		/// </param>
		/// <param name="stages">
		/// Specifies a set of program stages to bind to the program pipeline object.
		/// </param>
		/// <param name="program">
		/// Specifies the program object containing the shader executables to use in <paramref name="pipeline"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="shaders"/> contains set bits that are not recognized, and is not the 
		/// reserved value Gl.ALL_SHADER_BITS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that was not linked with its 
		/// Gl.PROGRAM_SEPARABLE status set.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that has not been 
		/// successfully linked.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void UseProgramStage(UInt32 pipeline, UInt32 stages, UInt32 program)
		{
			Debug.Assert(Delegates.pglUseProgramStages != null, "pglUseProgramStages not implemented");
			Delegates.pglUseProgramStages(pipeline, stages, program);
			LogFunction("glUseProgramStages({0}, {1}, {2})", pipeline, stages, program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the active program object for a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the program pipeline object to set the active program object for.
		/// </param>
		/// <param name="program">
		/// Specifies the program object to set as the active program pipeline object <paramref name="pipeline"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> refers to a program object that has not been 
		/// successfully linked.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ActiveShaderProgram(UInt32 pipeline, UInt32 program)
		{
			Debug.Assert(Delegates.pglActiveShaderProgram != null, "pglActiveShaderProgram not implemented");
			Delegates.pglActiveShaderProgram(pipeline, program);
			LogFunction("glActiveShaderProgram({0}, {1})", pipeline, program);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create a stand-alone program from an array of null-terminated source code strings
		/// </summary>
		/// <param name="type">
		/// Specifies the type of shader to create.
		/// </param>
		/// <param name="strings">
		/// Specifies the address of an array of pointers to source code strings from which to create the program object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if if <paramref name="type"/> is not an accepted shader type.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Other errors are generated if the supplied shader code fails to compile and link, as described for the commands in the 
		/// pseudocode sequence above, but all such errors are generated without any side effects of executing those commands.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static UInt32 CreateShaderProgram(Int32 type, params String[] strings)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglCreateShaderProgramv != null, "pglCreateShaderProgramv not implemented");
			retValue = Delegates.pglCreateShaderProgramv(type, (Int32)strings.Length, strings);
			LogFunction("glCreateShaderProgramv({0}, {1}, {2}) = {3}", LogEnumName(type), strings.Length, LogValue(strings), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// bind a program pipeline to the current context
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of the pipeline object to bind to the context.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not zero or a name previously returned from a call 
		/// to glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.CreateShader"/>
		/// <seealso cref="Gl.CreateProgram"/>
		/// <seealso cref="Gl.CompileShader"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void BindProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglBindProgramPipeline != null, "pglBindProgramPipeline not implemented");
			Delegates.pglBindProgramPipeline(pipeline);
			LogFunction("glBindProgramPipeline({0})", pipeline);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delete program pipeline objects
		/// </summary>
		/// <param name="pipelines">
		/// Specifies an array of names of program pipeline objects to delete.
		/// </param>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseShaderPrograms"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void DeleteProgramPipelines(params UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglDeleteProgramPipelines != null, "pglDeleteProgramPipelines not implemented");
					Delegates.pglDeleteProgramPipelines((Int32)pipelines.Length, p_pipelines);
					LogFunction("glDeleteProgramPipelines({0}, {1})", pipelines.Length, LogValue(pipelines));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		/// <param name="pipelines">
		/// Specifies an array of into which the reserved names will be written.
		/// </param>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseShaderPrograms"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GenProgramPipelines(UInt32[] pipelines)
		{
			unsafe {
				fixed (UInt32* p_pipelines = pipelines)
				{
					Debug.Assert(Delegates.pglGenProgramPipelines != null, "pglGenProgramPipelines not implemented");
					Delegates.pglGenProgramPipelines((Int32)pipelines.Length, p_pipelines);
					LogFunction("glGenProgramPipelines({0}, {1})", pipelines.Length, LogValue(pipelines));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// reserve program pipeline object names
		/// </summary>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.IsProgramPipeline"/>
		/// <seealso cref="Gl.UseShaderPrograms"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
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
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static bool IsProgramPipeline(UInt32 pipeline)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsProgramPipeline != null, "pglIsProgramPipeline not implemented");
			retValue = Delegates.pglIsProgramPipeline(pipeline);
			LogFunction("glIsProgramPipeline({0}) = {1}", pipeline, retValue);
			DebugCheckErrors(retValue);

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
		/// Specifies the address of a variable into which will be written the value or values of <paramref name="pname"/> for 
		/// <paramref name="pipeline"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not zero or a name previously returned from a call 
		/// to glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted values.
		/// </exception>
		/// <seealso cref="Gl.GetProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GetProgramPipeline(UInt32 pipeline, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineiv != null, "pglGetProgramPipelineiv not implemented");
					Delegates.pglGetProgramPipelineiv(pipeline, pname, p_params);
					LogFunction("glGetProgramPipelineiv({0}, {1}, {2})", pipeline, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1i != null, "pglProgramUniform1i not implemented");
			Delegates.pglProgramUniform1i(program, location, v0);
			LogFunction("glProgramUniform1i({0}, {1}, {2})", program, location, v0);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1iv != null, "pglProgramUniform1iv not implemented");
					Delegates.pglProgramUniform1iv(program, location, count, p_value);
					LogFunction("glProgramUniform1iv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, float v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1f != null, "pglProgramUniform1f not implemented");
			Delegates.pglProgramUniform1f(program, location, v0);
			LogFunction("glProgramUniform1f({0}, {1}, {2})", program, location, v0);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1fv != null, "pglProgramUniform1fv not implemented");
					Delegates.pglProgramUniform1fv(program, location, count, p_value);
					LogFunction("glProgramUniform1fv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform1(UInt32 program, Int32 location, double v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1d != null, "pglProgramUniform1d not implemented");
			Delegates.pglProgramUniform1d(program, location, v0);
			LogFunction("glProgramUniform1d({0}, {1}, {2})", program, location, v0);
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1dv != null, "pglProgramUniform1dv not implemented");
					Delegates.pglProgramUniform1dv(program, location, count, p_value);
					LogFunction("glProgramUniform1dv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, UInt32 v0)
		{
			Debug.Assert(Delegates.pglProgramUniform1ui != null, "pglProgramUniform1ui not implemented");
			Delegates.pglProgramUniform1ui(program, location, v0);
			LogFunction("glProgramUniform1ui({0}, {1}, {2})", program, location, v0);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform1uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform1(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform1uiv != null, "pglProgramUniform1uiv not implemented");
					Delegates.pglProgramUniform1uiv(program, location, count, p_value);
					LogFunction("glProgramUniform1uiv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 v0, Int32 v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2i != null, "pglProgramUniform2i not implemented");
			Delegates.pglProgramUniform2i(program, location, v0, v1);
			LogFunction("glProgramUniform2i({0}, {1}, {2}, {3})", program, location, v0, v1);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2iv != null, "pglProgramUniform2iv not implemented");
					Delegates.pglProgramUniform2iv(program, location, count, p_value);
					LogFunction("glProgramUniform2iv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, float v0, float v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2f != null, "pglProgramUniform2f not implemented");
			Delegates.pglProgramUniform2f(program, location, v0, v1);
			LogFunction("glProgramUniform2f({0}, {1}, {2}, {3})", program, location, v0, v1);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2fv != null, "pglProgramUniform2fv not implemented");
					Delegates.pglProgramUniform2fv(program, location, count, p_value);
					LogFunction("glProgramUniform2fv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform2(UInt32 program, Int32 location, double v0, double v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2d != null, "pglProgramUniform2d not implemented");
			Delegates.pglProgramUniform2d(program, location, v0, v1);
			LogFunction("glProgramUniform2d({0}, {1}, {2}, {3})", program, location, v0, v1);
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2dv != null, "pglProgramUniform2dv not implemented");
					Delegates.pglProgramUniform2dv(program, location, count, p_value);
					LogFunction("glProgramUniform2dv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, UInt32 v0, UInt32 v1)
		{
			Debug.Assert(Delegates.pglProgramUniform2ui != null, "pglProgramUniform2ui not implemented");
			Delegates.pglProgramUniform2ui(program, location, v0, v1);
			LogFunction("glProgramUniform2ui({0}, {1}, {2}, {3})", program, location, v0, v1);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform2uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform2(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform2uiv != null, "pglProgramUniform2uiv not implemented");
					Delegates.pglProgramUniform2uiv(program, location, count, p_value);
					LogFunction("glProgramUniform2uiv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3i != null, "pglProgramUniform3i not implemented");
			Delegates.pglProgramUniform3i(program, location, v0, v1, v2);
			LogFunction("glProgramUniform3i({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3iv != null, "pglProgramUniform3iv not implemented");
					Delegates.pglProgramUniform3iv(program, location, count, p_value);
					LogFunction("glProgramUniform3iv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, float v0, float v1, float v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3f != null, "pglProgramUniform3f not implemented");
			Delegates.pglProgramUniform3f(program, location, v0, v1, v2);
			LogFunction("glProgramUniform3f({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3fv != null, "pglProgramUniform3fv not implemented");
					Delegates.pglProgramUniform3fv(program, location, count, p_value);
					LogFunction("glProgramUniform3fv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform3(UInt32 program, Int32 location, double v0, double v1, double v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3d != null, "pglProgramUniform3d not implemented");
			Delegates.pglProgramUniform3d(program, location, v0, v1, v2);
			LogFunction("glProgramUniform3d({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3dv != null, "pglProgramUniform3dv not implemented");
					Delegates.pglProgramUniform3dv(program, location, count, p_value);
					LogFunction("glProgramUniform3dv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			Debug.Assert(Delegates.pglProgramUniform3ui != null, "pglProgramUniform3ui not implemented");
			Delegates.pglProgramUniform3ui(program, location, v0, v1, v2);
			LogFunction("glProgramUniform3ui({0}, {1}, {2}, {3}, {4})", program, location, v0, v1, v2);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform3uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform3(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform3uiv != null, "pglProgramUniform3uiv not implemented");
					Delegates.pglProgramUniform3uiv(program, location, count, p_value);
					LogFunction("glProgramUniform3uiv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4iEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4i != null, "pglProgramUniform4i not implemented");
			Delegates.pglProgramUniform4i(program, location, v0, v1, v2, v3);
			LogFunction("glProgramUniform4i({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4ivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4iv != null, "pglProgramUniform4iv not implemented");
					Delegates.pglProgramUniform4iv(program, location, count, p_value);
					LogFunction("glProgramUniform4iv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4fEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, float v0, float v1, float v2, float v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4f != null, "pglProgramUniform4f not implemented");
			Delegates.pglProgramUniform4f(program, location, v0, v1, v2, v3);
			LogFunction("glProgramUniform4f({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4fv != null, "pglProgramUniform4fv not implemented");
					Delegates.pglProgramUniform4fv(program, location, count, p_value);
					LogFunction("glProgramUniform4fv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform4(UInt32 program, Int32 location, double v0, double v1, double v2, double v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4d != null, "pglProgramUniform4d not implemented");
			Delegates.pglProgramUniform4d(program, location, v0, v1, v2, v3);
			LogFunction("glProgramUniform4d({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4dv != null, "pglProgramUniform4dv not implemented");
					Delegates.pglProgramUniform4dv(program, location, count, p_value);
					LogFunction("glProgramUniform4dv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4uiEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			Debug.Assert(Delegates.pglProgramUniform4ui != null, "pglProgramUniform4ui not implemented");
			Delegates.pglProgramUniform4ui(program, location, v0, v1, v2, v3);
			LogFunction("glProgramUniform4ui({0}, {1}, {2}, {3}, {4}, {5})", program, location, v0, v1, v2, v3);
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniform4uivEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniform4(UInt32 program, Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniform4uiv != null, "pglProgramUniform4uiv not implemented");
					Delegates.pglProgramUniform4uiv(program, location, count, p_value);
					LogFunction("glProgramUniform4uiv({0}, {1}, {2}, {3})", program, location, count, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2fv != null, "pglProgramUniformMatrix2fv not implemented");
					Delegates.pglProgramUniformMatrix2fv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix2fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3fv != null, "pglProgramUniformMatrix3fv not implemented");
					Delegates.pglProgramUniformMatrix3fv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix3fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// For the vector commands (Gl.ProgramUniform*v), specifies the number of elements that are to be modified. This should be 
		/// 1 if the targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4fv != null, "pglProgramUniformMatrix4fv not implemented");
					Delegates.pglProgramUniformMatrix4fv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix4fv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2dv != null, "pglProgramUniformMatrix2dv not implemented");
					Delegates.pglProgramUniformMatrix2dv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix2dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3dv != null, "pglProgramUniformMatrix3dv not implemented");
					Delegates.pglProgramUniformMatrix3dv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix3dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4(UInt32 program, Int32 location, Int32 count, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4dv != null, "pglProgramUniformMatrix4dv not implemented");
					Delegates.pglProgramUniformMatrix4dv(program, location, count, transpose, p_value);
					LogFunction("glProgramUniformMatrix4dv({0}, {1}, {2}, {3}, {4})", program, location, count, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3fv != null, "pglProgramUniformMatrix2x3fv not implemented");
					Delegates.pglProgramUniformMatrix2x3fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x3fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2fv != null, "pglProgramUniformMatrix3x2fv not implemented");
					Delegates.pglProgramUniformMatrix3x2fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x2fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix2x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4fv != null, "pglProgramUniformMatrix2x4fv not implemented");
					Delegates.pglProgramUniformMatrix2x4fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x4fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x2fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2fv != null, "pglProgramUniformMatrix4x2fv not implemented");
					Delegates.pglProgramUniformMatrix4x2fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x2fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix3x4fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4fv != null, "pglProgramUniformMatrix3x4fv not implemented");
					Delegates.pglProgramUniformMatrix3x4fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x4fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// For the matrix commands, specifies whether to transpose the matrix as the values are loaded into the uniform variable.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of <paramref name="count"/> values that will be used 
		/// to update the specified uniform variable.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> does not refer to a program object owned by the GL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if the size of the uniform variable declared in the shader does not match the size 
		/// indicated by the Gl.ProgramUniform command.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed or unsigned integer variants of this function is used to load a 
		/// uniform variable of type float, vec2, vec3, vec4, or an array of these, or if one of the floating-point variants of this 
		/// function is used to load a uniform variable of type int, ivec2, ivec3, ivec4, unsigned int, uvec2, uvec3, uvec4, or an 
		/// array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the signed integer variants of this function is used to load a uniform 
		/// variable of type unsigned int, uvec2, uvec3, uvec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if one of the unsigned integer variants of this function is used to load a uniform 
		/// variable of type int, ivec2, ivec3, ivec4, or an array of these.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="location"/> is an invalid uniform location for <paramref 
		/// name="program"/> and <paramref name="location"/> is not equal to -1.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> is less than 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="count"/> is greater than 1 and the indicated uniform variable is 
		/// not an array variable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a sampler is loaded using a command other than Gl.ProgramUniform1i and 
		/// Gl.ProgramUniform1iv.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.UseProgram"/>
		[AliasOf("glProgramUniformMatrix4x3fvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|gles2")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, bool transpose, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3fv != null, "pglProgramUniformMatrix4x3fv not implemented");
					Delegates.pglProgramUniformMatrix4x3fv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x3fv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x3(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x3dv != null, "pglProgramUniformMatrix2x3dv not implemented");
					Delegates.pglProgramUniformMatrix2x3dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x3dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x2(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x2dv != null, "pglProgramUniformMatrix3x2dv not implemented");
					Delegates.pglProgramUniformMatrix3x2dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x2dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix2x4(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix2x4dv != null, "pglProgramUniformMatrix2x4dv not implemented");
					Delegates.pglProgramUniformMatrix2x4dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix2x4dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x2(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x2dv != null, "pglProgramUniformMatrix4x2dv not implemented");
					Delegates.pglProgramUniformMatrix4x2dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x2dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix3x4(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix3x4dv != null, "pglProgramUniformMatrix3x4dv not implemented");
					Delegates.pglProgramUniformMatrix3x4dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix3x4dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
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
		/// <param name="transpose">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ProgramUniformMatrix4x3(UInt32 program, Int32 location, bool transpose, double[] value)
		{
			unsafe {
				fixed (double* p_value = value)
				{
					Debug.Assert(Delegates.pglProgramUniformMatrix4x3dv != null, "pglProgramUniformMatrix4x3dv not implemented");
					Delegates.pglProgramUniformMatrix4x3dv(program, location, (Int32)value.Length, transpose, p_value);
					LogFunction("glProgramUniformMatrix4x3dv({0}, {1}, {2}, {3}, {4})", program, location, value.Length, transpose, LogValue(value));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// validate a program pipeline object against current GL state
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object to validate.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void ValidateProgramPipeline(UInt32 pipeline)
		{
			Debug.Assert(Delegates.pglValidateProgramPipeline != null, "pglValidateProgramPipeline not implemented");
			Delegates.pglValidateProgramPipeline(pipeline);
			LogFunction("glValidateProgramPipeline({0})", pipeline);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// retrieve the info log string from a program pipeline object
		/// </summary>
		/// <param name="pipeline">
		/// Specifies the name of a program pipeline object from which to retrieve the info log.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the maximum number of characters, including the null terminator, that may be written into <paramref 
		/// name="infoLog"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable into which will be written the number of characters written into <paramref 
		/// name="infoLog"/>.
		/// </param>
		/// <param name="infoLog">
		/// Specifies the address of an array of characters into which will be written the info log for <paramref name="pipeline"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pipeline"/> is not a name previously returned from a call to 
		/// glGenProgramPipelines or if such a name has been deleted by a call to glDeleteProgramPipelines.
		/// </exception>
		/// <seealso cref="Gl.GenProgramPipelines"/>
		/// <seealso cref="Gl.BindProgramPipeline"/>
		/// <seealso cref="Gl.DeleteProgramPipelines"/>
		/// <seealso cref="Gl.GetProgramPipeline"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		public static void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, out Int32 length, [Out] StringBuilder infoLog)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetProgramPipelineInfoLog != null, "pglGetProgramPipelineInfoLog not implemented");
					Delegates.pglGetProgramPipelineInfoLog(pipeline, bufSize, p_length, infoLog);
					LogFunction("glGetProgramPipelineInfoLog({0}, {1}, {2}, {3})", pipeline, bufSize, length, infoLog);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL1dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1d != null, "pglVertexAttribL1d not implemented");
			Delegates.pglVertexAttribL1d(index, x);
			LogFunction("glVertexAttribL1d({0}, {1})", index, x);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL2dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double x, double y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2d != null, "pglVertexAttribL2d not implemented");
			Delegates.pglVertexAttribL2d(index, x, y);
			LogFunction("glVertexAttribL2d({0}, {1}, {2})", index, x, y);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL3dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3d != null, "pglVertexAttribL3d not implemented");
			Delegates.pglVertexAttribL3d(index, x, y, z);
			LogFunction("glVertexAttribL3d({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="y">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="z">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <param name="w">
		/// For the scalar commands, specifies the new values to be used for the specified vertex attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL4dEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4d != null, "pglVertexAttribL4d not implemented");
			Delegates.pglVertexAttribL4d(index, x, y, z, w);
			LogFunction("glVertexAttribL4d({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL1dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL1(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1dv != null, "pglVertexAttribL1dv not implemented");
					Delegates.pglVertexAttribL1dv(index, p_v);
					LogFunction("glVertexAttribL1dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL2dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL2(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2dv != null, "pglVertexAttribL2dv not implemented");
					Delegates.pglVertexAttribL2dv(index, p_v);
					LogFunction("glVertexAttribL2dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL3dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL3(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3dv != null, "pglVertexAttribL3dv not implemented");
					Delegates.pglVertexAttribL3dv(index, p_v);
					LogFunction("glVertexAttribL3dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (Gl.VertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribP* is used with a <paramref name="type"/> other than 
		/// Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV, or Gl.UNSIGNED_INT_10F_11F_11F_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if Gl.VertexAttribL is used with a <paramref name="type"/> other than Gl.DOUBLE.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glVertexAttribL4dvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribL4(UInt32 index, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4dv != null, "pglVertexAttribL4dv not implemented");
					Delegates.pglVertexAttribL4dv(index, p_v);
					LogFunction("glVertexAttribL4dv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribLPointerEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribLPointer != null, "pglVertexAttribLPointer not implemented");
			Delegates.pglVertexAttribLPointer(index, size, type, stride, pointer);
			LogFunction("glVertexAttribLPointer({0}, {1}, {2}, {3}, 0x{4})", index, size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// Gl.BGRA is accepted by Gl.VertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, and Gl.UNSIGNED_INT are accepted by Gl.VertexAttribPointer and Gl.VertexAttribIPointer. 
		/// Additionally Gl.HALF_FLOAT, Gl.FLOAT, Gl.DOUBLE, Gl.FIXED, Gl.INT_2_10_10_10_REV, Gl.UNSIGNED_INT_2_10_10_10_REV and 
		/// Gl.UNSIGNED_INT_10F_11F_11F_REV are accepted by Gl.VertexAttribPointer. Gl.DOUBLE is also accepted by 
		/// Gl.VertexAttribLPointer and is the only token accepted by the <paramref name="type"/> parameter for that function. The 
		/// initial value is Gl.FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If <paramref name="stride"/> is 0, the generic 
		/// vertex attributes are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the Gl.ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is not 1, 2, 3, 4 or (for Gl.VertexAttribPointer), Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="size"/> is Gl.BGRA and <paramref name="type"/> is not 
		/// Gl.UNSIGNED_BYTE, Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.INT_2_10_10_10_REV or Gl.UNSIGNED_INT_2_10_10_10_REV 
		/// and <paramref name="size"/> is not 4 or Gl.BGRA.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.UNSIGNED_INT_10F_11F_11F_REV and <paramref 
		/// name="size"/> is not 3.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.VertexAttribPointer if <paramref name="size"/> is Gl.BGRA and <paramref 
		/// name="noramlized"/> is Gl.FALSE.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if zero is bound to the Gl.ARRAY_BUFFER buffer object binding point and the <paramref 
		/// name="pointer"/> argument is not Gl.L.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.MultiDrawArrays"/>
		/// <seealso cref="Gl.MultiDrawElements"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[AliasOf("glVertexAttribLPointerEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void VertexAttribLPointer(UInt32 index, Int32 size, Int32 type, Int32 stride, Object pointer)
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
		/// Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, Gl.VERTEX_ATTRIB_ARRAY_SIZE, 
		/// Gl.VERTEX_ATTRIB_ARRAY_STRIDE, Gl.VERTEX_ATTRIB_ARRAY_TYPE, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// Gl.VERTEX_ATTRIB_ARRAY_INTEGER, Gl.VERTEX_ATTRIB_ARRAY_DIVISOR, or Gl.CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="pname"/> is not Gl.CURRENT_VERTEX_ATTRIB and there is no currently 
		/// bound vertex array object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to Gl.MAX_VERTEX_ATTRIBS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="index"/> is 0 and <paramref name="pname"/> is 
		/// Gl.CURRENT_VERTEX_ATTRIB.
		/// </exception>
		/// <seealso cref="Gl.BindAttribLocation"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DisableVertexAttribArray"/>
		/// <seealso cref="Gl.EnableVertexAttribArray"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		/// <seealso cref="Gl.VertexAttribDivisor"/>
		/// <seealso cref="Gl.VertexAttribPointer"/>
		[AliasOf("glGetVertexAttribLdvEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		public static void GetVertexAttribL(UInt32 index, Int32 pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLdv != null, "pglGetVertexAttribLdv not implemented");
					Delegates.pglGetVertexAttribLdv(index, pname, p_params);
					LogFunction("glGetVertexAttribLdv({0}, {1}, {2})", index, LogEnumName(pname), LogValue(@params));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set multiple viewports
		/// </summary>
		/// <param name="first">
		/// Specify the first viewport to set.
		/// </param>
		/// <param name="count">
		/// Specify the number of viewports to set.
		/// </param>
		/// <param name="v">
		/// Specify the address of an array containing the viewport parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> + <paramref name="count"/> is greater than or equal to the 
		/// value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.ViewportIndexed"/>
		[AliasOf("glViewportArrayvNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ViewportArray(UInt32 first, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportArrayv != null, "pglViewportArrayv not implemented");
					Delegates.pglViewportArrayv(first, count, p_v);
					LogFunction("glViewportArrayv({0}, {1}, {2})", first, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set a specified viewport
		/// </summary>
		/// <param name="index">
		/// Specify the first viewport to set.
		/// </param>
		/// <param name="x">
		/// For Gl.ViewportIndexedf, specifies the lower left corner of the viewport rectangle, in pixels. The initial value is 
		/// (0,0).
		/// </param>
		/// <param name="y">
		/// For Gl.ViewportIndexedf, specifies the lower left corner of the viewport rectangle, in pixels. The initial value is 
		/// (0,0).
		/// </param>
		/// <param name="w">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="h">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.ViewportArray"/>
		[AliasOf("glViewportIndexedfNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ViewportIndexed(UInt32 index, float x, float y, float w, float h)
		{
			Debug.Assert(Delegates.pglViewportIndexedf != null, "pglViewportIndexedf not implemented");
			Delegates.pglViewportIndexedf(index, x, y, w, h);
			LogFunction("glViewportIndexedf({0}, {1}, {2}, {3}, {4})", index, x, y, w, h);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set a specified viewport
		/// </summary>
		/// <param name="index">
		/// Specify the first viewport to set.
		/// </param>
		/// <param name="v">
		/// For Gl.ViewportIndexedfv, specifies the address of an array containing the viewport parameters.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.ViewportArray"/>
		[AliasOf("glViewportIndexedfvNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ViewportIndexed(UInt32 index, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglViewportIndexedfv != null, "pglViewportIndexedfv not implemented");
					Delegates.pglViewportIndexedfv(index, p_v);
					LogFunction("glViewportIndexedfv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> + <paramref name="count"/> is greater than or equal to the 
		/// value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.ViewportIndexed"/>
		/// <seealso cref="Gl.ViewportArray"/>
		[AliasOf("glScissorArrayvNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ScissorArray(UInt32 first, Int32 count, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorArrayv != null, "pglScissorArrayv not implemented");
					Delegates.pglScissorArrayv(first, count, p_v);
					LogFunction("glScissorArrayv({0}, {1}, {2})", first, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.ScissorArray"/>
		[AliasOf("glScissorIndexedNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissorIndexed != null, "pglScissorIndexed not implemented");
			Delegates.pglScissorIndexed(index, left, bottom, width, height);
			LogFunction("glScissorIndexed({0}, {1}, {2}, {3}, {4})", index, left, bottom, width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box for a specific viewport
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the viewport whose scissor box to modify.
		/// </param>
		/// <param name="v">
		/// For Gl.ScissorIndexedv, specifies the address of an array containing the left, bottom, width and height of each scissor 
		/// box, in that order.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any width or height specified in the array <paramref name="v"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.ScissorArray"/>
		[AliasOf("glScissorIndexedvNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void ScissorIndexed(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglScissorIndexedv != null, "pglScissorIndexedv not implemented");
					Delegates.pglScissorIndexedv(index, p_v);
					LogFunction("glScissorIndexedv({0}, {1})", index, LogValue(v));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="first"/> + <paramref name="count"/> is greater than or equal to the 
		/// value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.DepthRangeIndexed"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.ViewportArray"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeArray(UInt32 first, Int32 count, double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglDepthRangeArrayv != null, "pglDepthRangeArrayv not implemented");
					Delegates.pglDepthRangeArrayv(first, count, p_v);
					LogFunction("glDepthRangeArrayv({0}, {1}, {2})", first, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
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
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is greater than or equal to the value of Gl.MAX_VIEWPORTS.
		/// </exception>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.DepthRangeArray"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.ViewportArray"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		public static void DepthRangeIndexed(UInt32 index, double n, double f)
		{
			Debug.Assert(Delegates.pglDepthRangeIndexed != null, "pglDepthRangeIndexed not implemented");
			Delegates.pglDepthRangeIndexed(index, n, f);
			LogFunction("glDepthRangeIndexed({0}, {1}, {2})", index, n, f);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetFloatIndexedvEXT")]
		[AliasOf("glGetFloati_vEXT")]
		[AliasOf("glGetFloati_vNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
					Delegates.pglGetFloati_v(target, index, p_data);
					LogFunction("glGetFloati_v({0}, {1}, {2})", LogEnumName(target), index, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetFloatIndexedvEXT")]
		[AliasOf("glGetFloati_vEXT")]
		[AliasOf("glGetFloati_vNV")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		public static void Get(Int32 target, UInt32 index, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloati_v != null, "pglGetFloati_v not implemented");
					Delegates.pglGetFloati_v(target, index, p_data);
					LogFunction("glGetFloati_v({0}, {1}, {2})", LogEnumName(target), index, data);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetDoubleIndexedvEXT")]
		[AliasOf("glGetDoublei_vEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		public static void Get(Int32 target, UInt32 index, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
					Delegates.pglGetDoublei_v(target, index, p_data);
					LogFunction("glGetDoublei_v({0}, {1}, {2})", LogEnumName(target), index, LogValue(data));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of Gl.Get. The symbolic constants in the list below 
		/// are accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[AliasOf("glGetDoubleIndexedvEXT")]
		[AliasOf("glGetDoublei_vEXT")]
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_direct_state_access")]
		public static void Get(Int32 target, UInt32 index, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublei_v != null, "pglGetDoublei_v not implemented");
					Delegates.pglGetDoublei_v(target, index, p_data);
					LogFunction("glGetDoublei_v({0}, {1}, {2})", LogEnumName(target), index, data);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
