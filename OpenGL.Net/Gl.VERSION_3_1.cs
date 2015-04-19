
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
		/// Value of GL_SAMPLER_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_RECT_ARB")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_RECT = 0x8B63;

		/// <summary>
		/// Value of GL_SAMPLER_2D_RECT_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_RECT_SHADOW_ARB")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		public const int SAMPLER_2D_RECT_SHADOW = 0x8B64;

		/// <summary>
		/// Value of GL_SAMPLER_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int SAMPLER_BUFFER = 0x8DC2;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_2D_RECT = 0x8DCD;

		/// <summary>
		/// Value of GL_INT_SAMPLER_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int INT_SAMPLER_BUFFER = 0x8DD0;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_RECT symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_RECT_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		public const int UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_ARB")]
		[AliasOf("GL_TEXTURE_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object")]
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BUFFER = 0x8C2A;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives the maximum number of texels allowed in the texel array of a texture 
		/// buffer object. Value must be at least 65536.
		/// </summary>
		[AliasOf("GL_MAX_TEXTURE_BUFFER_SIZE_ARB")]
		[AliasOf("GL_MAX_TEXTURE_BUFFER_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_buffer_object")]
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_BUFFER. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </para>
		/// <para>
		/// Gl.Get: data returns a single value, the name of the buffer object currently bound to the Gl.TEXTURE_BUFFER buffer 
		/// binding point. The initial value is 0. See Gl.BindBuffer.
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_BUFFER_ARB")]
		[AliasOf("GL_TEXTURE_BINDING_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_buffer_object")]
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BINDING_BUFFER = 0x8C2C;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_DATA_STORE_BINDING symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB")]
		[AliasOf("GL_TEXTURE_BUFFER_DATA_STORE_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_buffer_object")]
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		public const int TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;

		/// <summary>
		/// Value of GL_TEXTURE_RECTANGLE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_RECTANGLE_ARB")]
		[AliasOf("GL_TEXTURE_RECTANGLE_NV")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int TEXTURE_RECTANGLE = 0x84F5;

		/// <summary>
		/// Gl.Get: data returns a single value, the name of the texture currently bound to the target Gl.TEXTURE_RECTANGLE. The 
		/// initial value is 0. See Gl.BindTexture.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_RECTANGLE_ARB")]
		[AliasOf("GL_TEXTURE_BINDING_RECTANGLE_NV")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int TEXTURE_BINDING_RECTANGLE = 0x84F6;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_RECTANGLE symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_RECTANGLE_ARB")]
		[AliasOf("GL_PROXY_TEXTURE_RECTANGLE_NV")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int PROXY_TEXTURE_RECTANGLE = 0x84F7;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives a rough estimate of the largest rectangular texture that the GL can 
		/// handle. The value must be at least 1024. Use Gl.PROXY_TEXTURE_RECTANGLE to determine if a texture is too large. See 
		/// Gl.TexImage2D.
		/// </summary>
		[AliasOf("GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB")]
		[AliasOf("GL_MAX_RECTANGLE_TEXTURE_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		public const int MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;

		/// <summary>
		/// Value of GL_R8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int R8_SNORM = 0x8F94;

		/// <summary>
		/// Value of GL_RG8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RG8_SNORM = 0x8F95;

		/// <summary>
		/// Value of GL_RGB8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGB8_SNORM = 0x8F96;

		/// <summary>
		/// Value of GL_RGBA8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGBA8_SNORM = 0x8F97;

		/// <summary>
		/// Value of GL_R16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int R16_SNORM = 0x8F98;

		/// <summary>
		/// Value of GL_RG16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RG16_SNORM = 0x8F99;

		/// <summary>
		/// Value of GL_RGB16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGB16_SNORM = 0x8F9A;

		/// <summary>
		/// Value of GL_RGBA16_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGBA16_SNORM = 0x8F9B;

		/// <summary>
		/// Value of GL_SIGNED_NORMALIZED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int SIGNED_NORMALIZED = 0x8F9C;

		/// <summary>
		/// Gl.Enable: enables primitive restarting. If enabled, any one of the draw commands which transfers a set of generic 
		/// attribute array elements to the GL will restart the primitive when the index of the vertex is equal to the primitive 
		/// restart index. See Gl.PrimitiveRestartIndex.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int PRIMITIVE_RESTART = 0x8F9D;

		/// <summary>
		/// Gl.Get: data returns one value, the current primitive restart index. The initial value is 0. See 
		/// Gl.PrimitiveRestartIndex.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int PRIMITIVE_RESTART_INDEX = 0x8F9E;

		/// <summary>
		/// Value of GL_COPY_READ_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
		public const int COPY_READ_BUFFER = 0x8F36;

		/// <summary>
		/// Value of GL_COPY_WRITE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
		public const int COPY_WRITE_BUFFER = 0x8F37;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER = 0x8A11;

		/// <summary>
		/// Gl.Get: when used with non-indexed variants of glGet (such as glGetIntegerv), data returns a single value, the name of 
		/// the buffer object currently bound to the target Gl.UNIFORM_BUFFER. If no buffer object is bound to this target, 0 is 
		/// returned. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns a single value, the name of 
		/// the buffer object bound to the indexed uniform buffer binding point. The initial value is 0 for all targets. See 
		/// Gl.BindBuffer, Gl.BindBufferBase, and Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_BINDING = 0x8A28;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the start 
		/// offset of the binding range for each indexed uniform buffer binding. The initial value is 0 for all bindings. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_START = 0x8A29;

		/// <summary>
		/// Gl.Get: when used with indexed variants of glGet (such as glGetInteger64i_v), data returns a single value, the size of 
		/// the binding range for each indexed uniform buffer binding. The initial value is 0 for all bindings. See 
		/// Gl.BindBufferRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_SIZE = 0x8A2A;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform blocks per vertex shader. The value must be at least 12. 
		/// See Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform blocks per geometry shader. The value must be at least 12. 
		/// See Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform blocks per fragment shader. The value must be at least 12. 
		/// See Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform blocks per program. The value must be at least 70. See 
		/// Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum number of uniform buffer binding points on the context, which must be at 
		/// least 36.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;

		/// <summary>
		/// Gl.Get: data returns one value, the maximum size in basic machine units of a uniform block, which must be at least 
		/// 16384.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BLOCK_SIZE = 0x8A30;

		/// <summary>
		/// Gl.Get: data returns one value, the number of words for vertex shader uniform variables in all uniform blocks (including 
		/// default). The value must be at least 1. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;

		/// <summary>
		/// Gl.Get: data returns one value, the number of words for geometry shader uniform variables in all uniform blocks 
		/// (including default). The value must be at least 1. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;

		/// <summary>
		/// Gl.Get: data returns one value, the number of words for fragment shader uniform variables in all uniform blocks 
		/// (including default). The value must be at least 1. See Gl.Uniform.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;

		/// <summary>
		/// Gl.Get: data returns a single value, the minimum required alignment for uniform buffer sizes and offset. The initial 
		/// value is 1. See Gl.UniformBlockBinding.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int ACTIVE_UNIFORM_BLOCKS = 0x8A36;

		/// <summary>
		/// Value of GL_UNIFORM_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_TYPE = 0x8A37;

		/// <summary>
		/// Value of GL_UNIFORM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_SIZE = 0x8A38;

		/// <summary>
		/// Value of GL_UNIFORM_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_NAME_LENGTH = 0x8A39;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_INDEX = 0x8A3A;

		/// <summary>
		/// Value of GL_UNIFORM_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_OFFSET = 0x8A3B;

		/// <summary>
		/// Value of GL_UNIFORM_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_ARRAY_STRIDE = 0x8A3C;

		/// <summary>
		/// Value of GL_UNIFORM_MATRIX_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_MATRIX_STRIDE = 0x8A3D;

		/// <summary>
		/// Value of GL_UNIFORM_IS_ROW_MAJOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_IS_ROW_MAJOR = 0x8A3E;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_BINDING = 0x8A3F;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_DATA_SIZE = 0x8A40;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER = 0x8A44;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER = 0x8A45;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;

		/// <summary>
		/// Value of GL_INVALID_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const uint INVALID_INDEX = 0xFFFFFFFF;

		/// <summary>
		/// draw multiple instances of a range of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLESGl.LINES_ADJACENCY, Gl.LINE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="first">
		/// Specifies the starting index in the enabled arrays.
		/// </param>
		/// <param name="count">
		/// Specifies the number of indices to be rendered.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void DrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawArraysInstanced != null, "pglDrawArraysInstanced not implemented");
			Delegates.pglDrawArraysInstanced((Int32)mode, first, count, instancecount);
			CallLog("glDrawArraysInstanced({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a set of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, or Gl.TRIANGLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void DrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount)
		{
			Debug.Assert(Delegates.pglDrawElementsInstanced != null, "pglDrawElementsInstanced not implemented");
			Delegates.pglDrawElementsInstanced((Int32)mode, count, (Int32)type, indices, instancecount);
			CallLog("glDrawElementsInstanced({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a set of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.LINE_STRIP_ADJACENCY, Gl.LINES_ADJACENCY, Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP_ADJACENCY, Gl.TRIANGLES_ADJACENCY and Gl.PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in <paramref name="indices"/>. Must be one of Gl.UNSIGNED_BYTE, Gl.UNSIGNED_SHORT, or 
		/// Gl.UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of Gl.POINTS, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.LINES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, or Gl.TRIANGLES.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="count"/> or <paramref name="primcount"/> are negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a geometry shader is active and <paramref name="mode"/> is incompatible with the 
		/// input primitive type of the geometry shader in the currently installed program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		/// data store is currently mapped.
		/// </exception>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void DrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, Object indices, Int32 instancecount)
		{
			GCHandle pin_indices = GCHandle.Alloc(indices, GCHandleType.Pinned);
			try {
				DrawElementsInstanced(mode, count, type, pin_indices.AddrOfPinnedObject(), instancecount);
			} finally {
				pin_indices.Free();
			}
		}

		/// <summary>
		/// attach a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.TexBuffer. Must be Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TexBuffer if <paramref name="target"/> is not Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.TextureBuffer if <paramref name="texture"/> is not the name of an existing 
		/// texture object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.TextureBuffer if the effective target of <paramref name="texture"/> is not 
		/// Gl.TEXTURE_BUFFER.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="internalformat"/> is not one of the sized internal formats described 
		/// above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="buffer"/> is not zero and is not the name of an existing buffer 
		/// object.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void TexBuffer(TextureTarget target, Int32 internalformat, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglTexBuffer != null, "pglTexBuffer not implemented");
			Delegates.pglTexBuffer((Int32)target, internalformat, buffer);
			CallLog("glTexBuffer({0}, {1}, {2})", target, internalformat, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the primitive restart index
		/// </summary>
		/// <param name="index">
		/// Specifies the value to be interpreted as the primitive restart index.
		/// </param>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void PrimitiveRestartIndex(UInt32 index)
		{
			Debug.Assert(Delegates.pglPrimitiveRestartIndex != null, "pglPrimitiveRestartIndex not implemented");
			Delegates.pglPrimitiveRestartIndex(index);
			CallLog("glPrimitiveRestartIndex({0})", index);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy all or part of the data store of a buffer object to the data store of another buffer object
		/// </summary>
		/// <param name="readTarget">
		/// Specifies the target to which the source buffer object is bound for Gl.CopyBufferSubData
		/// </param>
		/// <param name="writeTarget">
		/// Specifies the target to which the destination buffer object is bound for Gl.CopyBufferSubData.
		/// </param>
		/// <param name="readOffset">
		/// Specifies the offset, in basic machine units, within the data store of the source buffer object at which data will be 
		/// read.
		/// </param>
		/// <param name="writeOffset">
		/// Specifies the offset, in basic machine units, within the data store of the destination buffer object at which data will 
		/// be written.
		/// </param>
		/// <param name="size">
		/// Specifies the size, in basic machine units, of the data to be copied from the source buffer object to the destination 
		/// buffer object.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated by Gl.CopyBufferSubData if <paramref name="readTarget"/> or <paramref name="writeTarget"/> 
		/// is not one of the buffer binding targets listed above.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyBufferSubData if zero is bound to <paramref name="readTarget"/> or <paramref 
		/// name="writeTarget"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated by Gl.CopyNamedBufferSubData if <paramref name="readBuffer"/> or <paramref 
		/// name="writeBuffer"/> is not the name of an existing buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if any of <paramref name="readOffset"/>, <paramref name="writeOffset"/> or <paramref 
		/// name="size"/> is negative, if $readOffset + size$ is greater than the size of the source buffer object (its value of 
		/// Gl.BUFFER_SIZE), or if $writeOffset + size$ is greater than the size of the destination buffer object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if the source and destination are the same buffer object, and the ranges 
		/// $[readOffset,readOffset+size)$ and $[writeOffset,writeOffset+size)$ overlap.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if either the source or destination buffer object is mapped with glMapBufferRange or 
		/// glMapBuffer, unless they were mapped with the Gl.MAP_PERSISTENT bit set in the Gl.MapBufferRange<paramref 
		/// name="access"/> flags.
		/// </exception>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
		public static void CopyBufferSubData(Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			Debug.Assert(Delegates.pglCopyBufferSubData != null, "pglCopyBufferSubData not implemented");
			Delegates.pglCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
			CallLog("glCopyBufferSubData({0}, {1}, {2}, {3}, {4})", readTarget, writeTarget, readOffset, writeOffset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the index of a named uniform block
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program containing uniforms whose indices to query.
		/// </param>
		/// <param name="uniformCount">
		/// Specifies the number of uniforms whose indices to query.
		/// </param>
		/// <param name="uniformNames">
		/// Specifies the address of an array of pointers to buffers containing the names of the queried uniforms.
		/// </param>
		/// <param name="uniformIndices">
		/// Specifies the address of an array that will receive the indices of the uniforms.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object for which 
		/// glLinkProgram has been called in the past.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetActiveUniformName"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [Out] UInt32[] uniformIndices)
		{
			unsafe {
				fixed (UInt32* p_uniformIndices = uniformIndices)
				{
					Debug.Assert(Delegates.pglGetUniformIndices != null, "pglGetUniformIndices not implemented");
					Delegates.pglGetUniformIndices(program, uniformCount, uniformNames, p_uniformIndices);
					CallLog("glGetUniformIndices({0}, {1}, {2}, {3})", program, uniformCount, uniformNames, uniformIndices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns information about several active uniform variables for the specified program object
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="uniformCount">
		/// Specifies both the number of elements in the array of indices <paramref name="uniformIndices"/> and the number of 
		/// parameters written to <paramref name="params"/> upon successful return.
		/// </param>
		/// <param name="uniformIndices">
		/// Specifies the address of an array of <paramref name="uniformCount"/> integers containing the indices of uniforms within 
		/// <paramref name="program"/> whose parameter <paramref name="pname"/> should be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the property of each uniform in <paramref name="uniformIndices"/> that should be written into the 
		/// corresponding element of <paramref name="params"/>.
		/// </param>
		/// <param name="params">
		/// Specifies the address of an array of <paramref name="uniformCount"/> integers which are to receive the value of 
		/// <paramref name="pname"/> for each uniform in <paramref name="uniformIndices"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not a value generated by OpenGL.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not a program object.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformCount"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_UNIFORMS for <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted token.
		/// </exception>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetActiveUniforms(UInt32 program, UInt32[] uniformIndices, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (UInt32* p_uniformIndices = uniformIndices)
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveUniformsiv != null, "pglGetActiveUniformsiv not implemented");
					Delegates.pglGetActiveUniformsiv(program, (Int32)uniformIndices.Length, p_uniformIndices, pname, p_params);
					CallLog("glGetActiveUniformsiv({0}, {1}, {2}, {3}, {4})", program, uniformIndices.Length, uniformIndices, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the name of an active uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the program containing the active uniform index <paramref name="uniformIndex"/>.
		/// </param>
		/// <param name="uniformIndex">
		/// Specifies the index of the active uniform whose name to query.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer, in units of GLchar, of the buffer whose address is specified in <paramref 
		/// name="uniformName"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable that will receive the number of characters that were or would have been written to 
		/// the buffer addressed by <paramref name="uniformName"/>.
		/// </param>
		/// <param name="uniformName">
		/// Specifies the address of a buffer into which the GL will place the name of the active uniform at <paramref 
		/// name="uniformIndex"/> within <paramref name="program"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformIndex"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_UNIFORMS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="bufSize"/> is negative.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object for which glLinkProgram 
		/// has been issued.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetUniformIndices"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, out Int32 length, [Out] StringBuilder uniformName)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveUniformName != null, "pglGetActiveUniformName not implemented");
					Delegates.pglGetActiveUniformName(program, uniformIndex, bufSize, p_length, uniformName);
					CallLog("glGetActiveUniformName({0}, {1}, {2}, {3}, {4})", program, uniformIndex, bufSize, length, uniformName);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the index of a named uniform block
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program containing the uniform block.
		/// </param>
		/// <param name="uniformBlockName">
		/// Specifies the address an array of characters to containing the name of the uniform block whose index to retrieve.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object for which 
		/// glLinkProgram has been called in the past.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniformBlockName"/>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGetUniformBlockIndex != null, "pglGetUniformBlockIndex not implemented");
			retValue = Delegates.pglGetUniformBlockIndex(program, uniformBlockName);
			CallLog("glGetUniformBlockIndex({0}, {1}) = {2}", program, uniformBlockName, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// query information about an active uniform block
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program containing the uniform block.
		/// </param>
		/// <param name="uniformBlockIndex">
		/// Specifies the index of the uniform block within <paramref name="program"/>.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to query.
		/// </param>
		/// <param name="params">
		/// Specifies the address of a variable to receive the result of the query.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformBlockIndex"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_UNIFORM_BLOCKS or is not the index of an active uniform block in <paramref name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not one of the accepted tokens.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object for which 
		/// glLinkProgram has been called in the past.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniformBlockName"/>
		/// <seealso cref="Gl.GetUniformBlockIndex"/>
		/// <seealso cref="Gl.LinkProgram"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetActiveUniformBlock(UInt32 program, UInt32 uniformBlockIndex, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveUniformBlockiv != null, "pglGetActiveUniformBlockiv not implemented");
					Delegates.pglGetActiveUniformBlockiv(program, uniformBlockIndex, pname, p_params);
					CallLog("glGetActiveUniformBlockiv({0}, {1}, {2}, {3})", program, uniformBlockIndex, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve the name of an active uniform block
		/// </summary>
		/// <param name="program">
		/// Specifies the name of a program containing the uniform block.
		/// </param>
		/// <param name="uniformBlockIndex">
		/// Specifies the index of the uniform block within <paramref name="program"/>.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer addressed by <paramref name="uniformBlockName"/>.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of characters that were written to <paramref 
		/// name="uniformBlockName"/>.
		/// </param>
		/// <param name="uniformBlockName">
		/// Specifies the address an array of characters to receive the name of the uniform block at <paramref 
		/// name="uniformBlockIndex"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="program"/> is not the name of a program object for which 
		/// glLinkProgram has been called in the past.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformBlockIndex"/> is greater than or equal to the value of 
		/// Gl.ACTIVE_UNIFORM_BLOCKS or is not the index of an active uniform block in <paramref name="program"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		/// <seealso cref="Gl.GetUniformBlockIndex"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, out Int32 length, [Out] StringBuilder uniformBlockName)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetActiveUniformBlockName != null, "pglGetActiveUniformBlockName not implemented");
					Delegates.pglGetActiveUniformBlockName(program, uniformBlockIndex, bufSize, p_length, uniformBlockName);
					CallLog("glGetActiveUniformBlockName({0}, {1}, {2}, {3}, {4})", program, uniformBlockIndex, bufSize, length, uniformBlockName);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// assign a binding point to an active uniform block
		/// </summary>
		/// <param name="program">
		/// The name of a program object containing the active uniform block whose binding to assign.
		/// </param>
		/// <param name="uniformBlockIndex">
		/// The index of the active uniform block within <paramref name="program"/> whose binding to assign.
		/// </param>
		/// <param name="uniformBlockBinding">
		/// Specifies the binding point to which to bind the uniform block with index <paramref name="uniformBlockIndex"/> within 
		/// <paramref name="program"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformBlockIndex"/> is not an active uniform block index of <paramref 
		/// name="program"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="uniformBlockBinding"/> is greater than or equal to the value of 
		/// Gl.MAX_UNIFORM_BUFFER_BINDINGS.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Gl.INVALID_VALUE is generated if <paramref name="program"/> is not the name of a program object generated by the GL.
		/// </exception>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
		{
			Debug.Assert(Delegates.pglUniformBlockBinding != null, "pglUniformBlockBinding not implemented");
			Delegates.pglUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
			CallLog("glUniformBlockBinding({0}, {1}, {2})", program, uniformBlockIndex, uniformBlockBinding);
			DebugCheckErrors();
		}

	}

}
