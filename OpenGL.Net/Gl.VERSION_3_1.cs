
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
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int SAMPLER_2D_RECT = 0x8B63;

		/// <summary>
		/// Value of GL_SAMPLER_2D_RECT_SHADOW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int SAMPLER_2D_RECT_SHADOW = 0x8B64;

		/// <summary>
		/// Value of GL_SAMPLER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int SAMPLER_BUFFER = 0x8DC2;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_RECT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int INT_SAMPLER_2D_RECT = 0x8DCD;

		/// <summary>
		/// Value of GL_INT_SAMPLER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int INT_SAMPLER_BUFFER = 0x8DD0;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_RECT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_BUFFER = 0x8C2A;

		/// <summary>
		/// Value of GL_MAX_TEXTURE_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int MAX_TEXTURE_BUFFER_SIZE = 0x8C2B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_BUFFER = 0x8C2C;

		/// <summary>
		/// Value of GL_TEXTURE_BUFFER_DATA_STORE_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int TEXTURE_BUFFER_DATA_STORE_BINDING = 0x8C2D;

		/// <summary>
		/// Value of GL_TEXTURE_RECTANGLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_RECTANGLE = 0x84F5;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_RECTANGLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_RECTANGLE = 0x84F6;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_RECTANGLE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int PROXY_TEXTURE_RECTANGLE = 0x84F7;

		/// <summary>
		/// Value of GL_MAX_RECTANGLE_TEXTURE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8;

		/// <summary>
		/// Value of GL_R8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_render_snorm")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int R8_SNORM = 0x8F94;

		/// <summary>
		/// Value of GL_RG8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_render_snorm")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RG8_SNORM = 0x8F95;

		/// <summary>
		/// Value of GL_RGB8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int RGB8_SNORM = 0x8F96;

		/// <summary>
		/// Value of GL_RGBA8_SNORM symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_render_snorm")]
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		public const int SIGNED_NORMALIZED = 0x8F9C;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int PRIMITIVE_RESTART = 0x8F9D;

		/// <summary>
		/// Value of GL_PRIMITIVE_RESTART_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		public const int PRIMITIVE_RESTART_INDEX = 0x8F9E;

		/// <summary>
		/// Value of GL_COPY_READ_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
		public const int COPY_READ_BUFFER = 0x8F36;

		/// <summary>
		/// Value of GL_COPY_WRITE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
		public const int COPY_WRITE_BUFFER = 0x8F37;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER = 0x8A11;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_BINDING = 0x8A28;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_START = 0x8A29;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_SIZE = 0x8A2A;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;

		/// <summary>
		/// Value of GL_MAX_COMBINED_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;

		/// <summary>
		/// Value of GL_MAX_UNIFORM_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;

		/// <summary>
		/// Value of GL_MAX_UNIFORM_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BLOCK_SIZE = 0x8A30;

		/// <summary>
		/// Value of GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31;

		/// <summary>
		/// Value of GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32;

		/// <summary>
		/// Value of GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35;

		/// <summary>
		/// Value of GL_ACTIVE_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int ACTIVE_UNIFORM_BLOCKS = 0x8A36;

		/// <summary>
		/// Value of GL_UNIFORM_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_TYPE = 0x8A37;

		/// <summary>
		/// Value of GL_UNIFORM_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_SIZE = 0x8A38;

		/// <summary>
		/// Value of GL_UNIFORM_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_NAME_LENGTH = 0x8A39;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_INDEX = 0x8A3A;

		/// <summary>
		/// Value of GL_UNIFORM_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_OFFSET = 0x8A3B;

		/// <summary>
		/// Value of GL_UNIFORM_ARRAY_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_ARRAY_STRIDE = 0x8A3C;

		/// <summary>
		/// Value of GL_UNIFORM_MATRIX_STRIDE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_MATRIX_STRIDE = 0x8A3D;

		/// <summary>
		/// Value of GL_UNIFORM_IS_ROW_MAJOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_IS_ROW_MAJOR = 0x8A3E;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_BINDING = 0x8A3F;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_DATA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_DATA_SIZE = 0x8A40;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_NAME_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_NAME_LENGTH = 0x8A41;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_ACTIVE_UNIFORMS = 0x8A42;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES = 0x8A43;

		/// <summary>
		/// Value of GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
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
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER = 0x8A46;

		/// <summary>
		/// Value of GL_INVALID_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const uint INVALID_INDEX = 0xFFFFFFFF;

		/// <summary>
		/// draw multiple instances of a range of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLESGL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// glDrawArraysInstanced behaves identically to glDrawArrays except that primcount instances of the range of elements are 
		/// executed and the value of the internal counter instanceID advances for each iteration. instanceID is an internal 32-bit 
		/// integer counter that may be read by a vertex shader as gl_InstanceID.
		/// glDrawArraysInstanced has the same effect as: if ( mode or count is invalid ) generate appropriate error else { for (int 
		/// i = 0; i &lt; primcount ; i++) { instanceID = i; glDrawArrays(mode, first, count); } instanceID = 0; }
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of the accepted values.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_VALUE is generated if count or primcount are negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		public static void DrawArraysInstanced(int mode, Int32 first, Int32 count, Int32 instancecount)
		{
			if        (Delegates.pglDrawArraysInstanced != null) {
				Delegates.pglDrawArraysInstanced(mode, first, count, instancecount);
				CallLog("glDrawArraysInstanced({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedANGLE != null) {
				Delegates.pglDrawArraysInstancedANGLE(mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedANGLE({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedARB != null) {
				Delegates.pglDrawArraysInstancedARB(mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedARB({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedEXT != null) {
				Delegates.pglDrawArraysInstancedEXT(mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedEXT({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedNV != null) {
				Delegates.pglDrawArraysInstancedNV(mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedNV({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else
				throw new NotImplementedException("glDrawArraysInstanced (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a range of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLESGL_LINES_ADJACENCY, GL_LINE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, 
		/// GL_TRIANGLE_STRIP_ADJACENCY and GL_PATCHES are accepted.
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
		/// glDrawArraysInstanced behaves identically to glDrawArrays except that primcount instances of the range of elements are 
		/// executed and the value of the internal counter instanceID advances for each iteration. instanceID is an internal 32-bit 
		/// integer counter that may be read by a vertex shader as gl_InstanceID.
		/// glDrawArraysInstanced has the same effect as: if ( mode or count is invalid ) generate appropriate error else { for (int 
		/// i = 0; i &lt; primcount ; i++) { instanceID = i; glDrawArrays(mode, first, count); } instanceID = 0; }
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of the accepted values.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_VALUE is generated if count or primcount are negative.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElementsInstanced"/>
		public static void DrawArraysInstanced(PrimitiveType mode, Int32 first, Int32 count, Int32 instancecount)
		{
			if        (Delegates.pglDrawArraysInstanced != null) {
				Delegates.pglDrawArraysInstanced((int)mode, first, count, instancecount);
				CallLog("glDrawArraysInstanced({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedANGLE != null) {
				Delegates.pglDrawArraysInstancedANGLE((int)mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedANGLE({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedARB != null) {
				Delegates.pglDrawArraysInstancedARB((int)mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedARB({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedEXT != null) {
				Delegates.pglDrawArraysInstancedEXT((int)mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedEXT({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else if (Delegates.pglDrawArraysInstancedNV != null) {
				Delegates.pglDrawArraysInstancedNV((int)mode, first, count, instancecount);
				CallLog("glDrawArraysInstancedNV({0}, {1}, {2}, {3})", mode, first, count, instancecount);
			} else
				throw new NotImplementedException("glDrawArraysInstanced (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a set of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawElementsInstanced behaves identically to glDrawElements except that primcount instances of the set of elements are 
		/// executed and the value of the internal counter instanceID advances for each iteration. instanceID is an internal 32-bit 
		/// integer counter that may be read by a vertex shader as gl_InstanceID.
		/// glDrawElementsInstanced has the same effect as: if (mode, count, or type is invalid ) generate appropriate error else { 
		/// for (int i = 0; i &lt; primcount ; i++) { instanceID = i; glDrawElements(mode, count, type, indices); } instanceID = 0; 
		/// }
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, 
		///   GL_TRIANGLE_FAN, or GL_TRIANGLES.
		/// - GL_INVALID_VALUE is generated if count or primcount are negative.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		public static void DrawElementsInstanced(int mode, Int32 count, int type, IntPtr indices, Int32 instancecount)
		{
			if        (Delegates.pglDrawElementsInstanced != null) {
				Delegates.pglDrawElementsInstanced(mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstanced({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedANGLE != null) {
				Delegates.pglDrawElementsInstancedANGLE(mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedANGLE({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedARB != null) {
				Delegates.pglDrawElementsInstancedARB(mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedARB({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedEXT != null) {
				Delegates.pglDrawElementsInstancedEXT(mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedNV != null) {
				Delegates.pglDrawElementsInstancedNV(mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedNV({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else
				throw new NotImplementedException("glDrawElementsInstanced (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a set of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawElementsInstanced behaves identically to glDrawElements except that primcount instances of the set of elements are 
		/// executed and the value of the internal counter instanceID advances for each iteration. instanceID is an internal 32-bit 
		/// integer counter that may be read by a vertex shader as gl_InstanceID.
		/// glDrawElementsInstanced has the same effect as: if (mode, count, or type is invalid ) generate appropriate error else { 
		/// for (int i = 0; i &lt; primcount ; i++) { instanceID = i; glDrawElements(mode, count, type, indices); } instanceID = 0; 
		/// }
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, 
		///   GL_TRIANGLE_FAN, or GL_TRIANGLES.
		/// - GL_INVALID_VALUE is generated if count or primcount are negative.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		public static void DrawElementsInstanced(PrimitiveType mode, Int32 count, int type, IntPtr indices, Int32 instancecount)
		{
			if        (Delegates.pglDrawElementsInstanced != null) {
				Delegates.pglDrawElementsInstanced((int)mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstanced({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedANGLE != null) {
				Delegates.pglDrawElementsInstancedANGLE((int)mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedANGLE({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedARB != null) {
				Delegates.pglDrawElementsInstancedARB((int)mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedARB({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedEXT != null) {
				Delegates.pglDrawElementsInstancedEXT((int)mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedNV != null) {
				Delegates.pglDrawElementsInstancedNV((int)mode, count, type, indices, instancecount);
				CallLog("glDrawElementsInstancedNV({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else
				throw new NotImplementedException("glDrawElementsInstanced (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// draw multiple instances of a set of elements
		/// </summary>
		/// <param name="mode">
		/// Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, 
		/// GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, 
		/// GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.
		/// </param>
		/// <param name="count">
		/// Specifies the number of elements to be rendered.
		/// </param>
		/// <param name="type">
		/// Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.
		/// </param>
		/// <param name="indices">
		/// Specifies a pointer to the location where the indices are stored.
		/// </param>
		/// <param name="instancecount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <remarks>
		/// glDrawElementsInstanced behaves identically to glDrawElements except that primcount instances of the set of elements are 
		/// executed and the value of the internal counter instanceID advances for each iteration. instanceID is an internal 32-bit 
		/// integer counter that may be read by a vertex shader as gl_InstanceID.
		/// glDrawElementsInstanced has the same effect as: if (mode, count, or type is invalid ) generate appropriate error else { 
		/// for (int i = 0; i &lt; primcount ; i++) { instanceID = i; glDrawElements(mode, count, type, indices); } instanceID = 0; 
		/// }
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated if mode is not one of GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_TRIANGLE_STRIP, 
		///   GL_TRIANGLE_FAN, or GL_TRIANGLES.
		/// - GL_INVALID_VALUE is generated if count or primcount are negative.
		/// - GL_INVALID_OPERATION is generated if a geometry shader is active and mode is incompatible with the input primitive type 
		///   of the geometry shader in the currently installed program object.
		/// - GL_INVALID_OPERATION is generated if a non-zero buffer object name is bound to an enabled array and the buffer object's 
		///   data store is currently mapped.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawArraysInstanced"/>
		public static void DrawElementsInstanced(int mode, Int32 count, int type, Object indices, Int32 instancecount)
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
		/// Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <remarks>
		/// glTexBuffer and glTextureBuffer attaches the data store of a specified buffer object to a specified texture object, and 
		/// specify the storage format for the texture image found found in the buffer object. The texture object must be a buffer 
		/// texture.
		/// If buffer is zero, any buffer object attached to the buffer texture is detached and no new buffer object is attached. If 
		/// buffer is non-zero, it must be the name of an existing buffer object.
		/// internalformat specifies the storage format, and must be one of the following sized internal formats:
		/// internalformat specifies the storage format, and must be one of the following sized internal formats:
		/// When a buffer object is attached to a buffer texture, the buffer object's data store is taken as the texture's texel 
		/// array. The number of texels in the buffer texture's texel array is given by $$ \left\lfloor { size \over { components 
		/// \times sizeof(base\_type) } } \right\rfloor $$ where $size$ is the size of the buffer object in basic machine units (the 
		/// value of GL_BUFFER_SIZE for buffer), and $components$ and $base\_type$ are the element count and base data type for 
		/// elements, as specified in the table above. The number of texels in the texel array is then clamped to the value of the 
		/// implementation-dependent limit GL_MAX_TEXTURE_BUFFER_SIZE. When a buffer texture is accessed in a shader, the results of 
		/// a texel fetch are undefined if the specified texel coordinate is negative, or greater than or equal to the clamped 
		/// number of texels in the texel array.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glTexBuffer if target is not GL_TEXTURE_BUFFER.
		/// - GL_INVALID_OPERATION is generated by glTextureBuffer if texture is not the name of an existing texture object.
		/// - GL_INVALID_ENUM is generated by glTextureBuffer if the effective target of texture is not GL_TEXTURE_BUFFER.
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the sized internal formats described above.
		/// - GL_INVALID_OPERATION is generated if buffer is not zero and is not the name of an existing buffer object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_TEXTURE_BUFFER_SIZE
		/// - glGet with argument GL_TEXTURE_BINDING_BUFFER
		/// - glGetTexLevelParameter with argument GL_TEXTURE_BUFFER_DATA_STORE_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		public static void TexBuffer(int target, int internalformat, UInt32 buffer)
		{
			if        (Delegates.pglTexBuffer != null) {
				Delegates.pglTexBuffer(target, internalformat, buffer);
				CallLog("glTexBuffer({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferARB != null) {
				Delegates.pglTexBufferARB(target, internalformat, buffer);
				CallLog("glTexBufferARB({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferEXT != null) {
				Delegates.pglTexBufferEXT(target, internalformat, buffer);
				CallLog("glTexBufferEXT({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferOES != null) {
				Delegates.pglTexBufferOES(target, internalformat, buffer);
				CallLog("glTexBufferOES({0}, {1}, {2})", target, internalformat, buffer);
			} else
				throw new NotImplementedException("glTexBuffer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a buffer object's data store to a buffer texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		/// <remarks>
		/// glTexBuffer and glTextureBuffer attaches the data store of a specified buffer object to a specified texture object, and 
		/// specify the storage format for the texture image found found in the buffer object. The texture object must be a buffer 
		/// texture.
		/// If buffer is zero, any buffer object attached to the buffer texture is detached and no new buffer object is attached. If 
		/// buffer is non-zero, it must be the name of an existing buffer object.
		/// internalformat specifies the storage format, and must be one of the following sized internal formats:
		/// internalformat specifies the storage format, and must be one of the following sized internal formats:
		/// When a buffer object is attached to a buffer texture, the buffer object's data store is taken as the texture's texel 
		/// array. The number of texels in the buffer texture's texel array is given by $$ \left\lfloor { size \over { components 
		/// \times sizeof(base\_type) } } \right\rfloor $$ where $size$ is the size of the buffer object in basic machine units (the 
		/// value of GL_BUFFER_SIZE for buffer), and $components$ and $base\_type$ are the element count and base data type for 
		/// elements, as specified in the table above. The number of texels in the texel array is then clamped to the value of the 
		/// implementation-dependent limit GL_MAX_TEXTURE_BUFFER_SIZE. When a buffer texture is accessed in a shader, the results of 
		/// a texel fetch are undefined if the specified texel coordinate is negative, or greater than or equal to the clamped 
		/// number of texels in the texel array.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glTexBuffer if target is not GL_TEXTURE_BUFFER.
		/// - GL_INVALID_OPERATION is generated by glTextureBuffer if texture is not the name of an existing texture object.
		/// - GL_INVALID_ENUM is generated by glTextureBuffer if the effective target of texture is not GL_TEXTURE_BUFFER.
		/// - GL_INVALID_ENUM is generated if internalformat is not one of the sized internal formats described above.
		/// - GL_INVALID_OPERATION is generated if buffer is not zero and is not the name of an existing buffer object.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_TEXTURE_BUFFER_SIZE
		/// - glGet with argument GL_TEXTURE_BINDING_BUFFER
		/// - glGetTexLevelParameter with argument GL_TEXTURE_BUFFER_DATA_STORE_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.DeleteBuffers"/>
		/// <seealso cref="Gl.GenTextures"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.DeleteTextures"/>
		public static void TexBuffer(TextureTarget target, int internalformat, UInt32 buffer)
		{
			if        (Delegates.pglTexBuffer != null) {
				Delegates.pglTexBuffer((int)target, internalformat, buffer);
				CallLog("glTexBuffer({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferARB != null) {
				Delegates.pglTexBufferARB((int)target, internalformat, buffer);
				CallLog("glTexBufferARB({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferEXT != null) {
				Delegates.pglTexBufferEXT((int)target, internalformat, buffer);
				CallLog("glTexBufferEXT({0}, {1}, {2})", target, internalformat, buffer);
			} else if (Delegates.pglTexBufferOES != null) {
				Delegates.pglTexBufferOES((int)target, internalformat, buffer);
				CallLog("glTexBufferOES({0}, {1}, {2})", target, internalformat, buffer);
			} else
				throw new NotImplementedException("glTexBuffer (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// specify the primitive restart index
		/// </summary>
		/// <param name="index">
		/// Specifies the value to be interpreted as the primitive restart index.
		/// </param>
		/// <remarks>
		/// glPrimitiveRestartIndex specifies a vertex array element that is treated specially when primitive restarting is enabled. 
		/// This is known as the primitive restart index.
		/// When one of the Draw* commands transfers a set of generic attribute array elements to the GL, if the index within the 
		/// vertex arrays corresponding to that set is equal to the primitive restart index, then the GL does not process those 
		/// elements as a vertex. Instead, it is as if the drawing command ended with the immediately preceding transfer, and 
		/// another drawing command is immediately started with the same parameters, but only transferring the immediately following 
		/// element through the end of the originally specified elements.
		/// When either glDrawElementsBaseVertex, glDrawElementsInstancedBaseVertex or glMultiDrawElementsBaseVertex is used, the 
		/// primitive restart comparison occurs before the basevertex offset is added to the array index.
		/// </remarks>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawElementsBaseVertex"/>
		/// <seealso cref="Gl.DrawElementsInstancedBaseVertex"/>
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
		/// Specifies the target to which the source buffer object is bound for glCopyBufferSubData
		/// </param>
		/// <param name="writeTarget">
		/// Specifies the target to which the destination buffer object is bound for glCopyBufferSubData.
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
		/// glCopyBufferSubData and glCopyNamedBufferSubData copy part of the data store attached to a source buffer object to the 
		/// data store attached to a destination buffer object. The number of basic machine units indicated by size is copied from 
		/// the source at offset readOffset to the destination at writeOffset. readOffset, writeOffset and size are in terms of 
		/// basic machine units.
		/// For glCopyBufferSubData, readTarget and writeTarget specify the targets to which the source and destination buffer 
		/// objects are bound, and must each be one of the buffer binding targets in the following table:
		/// Any of these targets may be used, but the targets GL_COPY_READ_BUFFER and GL_COPY_WRITE_BUFFER are provided specifically 
		/// to allow copies between buffers without disturbing other GL state.
		/// readOffset, writeOffset and size must all be greater than or equal to zero. Furthermore, $readOffset+size$ must not 
		/// exceeed the size of the source buffer object, and $writeOffset+size$ must not exceeed the size of the buffer bound to 
		/// writeTarget. If the source and destination are the same buffer object, then the source and destination ranges must not 
		/// overlap.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_ENUM is generated by glCopyBufferSubData if readTarget or writeTarget is not one of the buffer binding 
		///   targets listed above.
		/// - GL_INVALID_OPERATION is generated by glCopyBufferSubData if zero is bound to readTarget or writeTarget.
		/// - GL_INVALID_OPERATION is generated by glCopyNamedBufferSubData if readBuffer or writeBuffer is not the name of an 
		///   existing buffer object.
		/// - GL_INVALID_VALUE is generated if any of readOffset, writeOffset or size is negative, if $readOffset + size$ is greater 
		///   than the size of the source buffer object (its value of GL_BUFFER_SIZE), or if $writeOffset + size$ is greater than the 
		///   size of the destination buffer object.
		/// - GL_INVALID_VALUE is generated if the source and destination are the same buffer object, and the ranges 
		///   $[readOffset,readOffset+size)$ and $[writeOffset,writeOffset+size)$ overlap.
		/// - GL_INVALID_OPERATION is generated if either the source or destination buffer object is mapped with glMapBufferRange or 
		///   glMapBuffer, unless they were mapped with the GL_MAP_PERSISTENT bit set in the glMapBufferRangeaccess flags.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GenBuffers"/>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.BufferData"/>
		/// <seealso cref="Gl.BufferSubData"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.MapBuffer"/>
		/// <seealso cref="Gl.MapBufferRange"/>
		public static void CopyBufferSubData(int readTarget, int writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size)
		{
			if        (Delegates.pglCopyBufferSubData != null) {
				Delegates.pglCopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
				CallLog("glCopyBufferSubData({0}, {1}, {2}, {3}, {4})", readTarget, writeTarget, readOffset, writeOffset, size);
			} else if (Delegates.pglCopyBufferSubDataNV != null) {
				Delegates.pglCopyBufferSubDataNV(readTarget, writeTarget, readOffset, writeOffset, size);
				CallLog("glCopyBufferSubDataNV({0}, {1}, {2}, {3}, {4})", readTarget, writeTarget, readOffset, writeOffset, size);
			} else
				throw new NotImplementedException("glCopyBufferSubData (and other aliases) are not implemented");
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
		/// glGetUniformIndices retrieves the indices of a number of uniforms within program.
		/// program must be the name of a program object for which the command glLinkProgram must have been called in the past, 
		/// although it is not required that glLinkProgram must have succeeded. The link could have failed because the number of 
		/// active uniforms exceeded the limit.
		/// uniformCount indicates both the number of elements in the array of names uniformNames and the number of indices that may 
		/// be written to uniformIndices.
		/// uniformNames contains a list of uniformCount name strings identifying the uniform names to be queried for indices. For 
		/// each name string in uniformNames, the index assigned to the active uniform of that name will be written to the 
		/// corresponding element of uniformIndices. If a string in uniformNames is not the name of an active uniform, the special 
		/// value GL_INVALID_INDEX will be written to the corresponding element of uniformIndices.
		/// If an error occurs, nothing is written to uniformIndices.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object for which glLinkProgram has been called 
		///   in the past.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetActiveUniformName"/>
		/// <seealso cref="Gl.LinkProgram"/>
		public static void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, UInt32[] uniformIndices)
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
		/// Specifies both the number of elements in the array of indices uniformIndices and the number of parameters written to 
		/// params upon successful return.
		/// </param>
		/// <param name="uniformIndices">
		/// Specifies the address of an array of uniformCount integers containing the indices of uniforms within program whose 
		/// parameter pname should be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the property of each uniform in uniformIndices that should be written into the corresponding element of 
		/// params.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetActiveUniformsiv queries the value of the parameter named pname for each of the uniforms within program whose 
		/// indices are specified in the array of uniformCount unsigned integers uniformIndices. Upon success, the value of the 
		/// parameter for each uniform is written into the corresponding entry in the array whose address is given in params. If an 
		/// error is generated, nothing is written into params.
		/// If pname is GL_UNIFORM_TYPE, then an array identifying the types of uniforms specified by the corresponding array of 
		/// uniformIndices is returned. The returned types can be any of the values from the following table: Returned Symbolic 
		/// Contant Shader Uniform Type 
		/// GL_FLOATfloatGL_FLOAT_VEC2vec2GL_FLOAT_VEC3vec3GL_FLOAT_VEC4vec4GL_DOUBLEdoubleGL_DOUBLE_VEC2dvec2GL_DOUBLE_VEC3dvec3GL_DOUBLE_VEC4dvec4GL_INTintGL_INT_VEC2ivec2GL_INT_VEC3ivec3GL_INT_VEC4ivec4GL_UNSIGNED_INTunsigned 
		/// intGL_UNSIGNED_INT_VEC2uvec2GL_UNSIGNED_INT_VEC3uvec3GL_UNSIGNED_INT_VEC4uvec4GL_BOOLboolGL_BOOL_VEC2bvec2GL_BOOL_VEC3bvec3GL_BOOL_VEC4bvec4GL_FLOAT_MAT2mat2GL_FLOAT_MAT3mat3GL_FLOAT_MAT4mat4GL_FLOAT_MAT2x3mat2x3GL_FLOAT_MAT2x4mat2x4GL_FLOAT_MAT3x2mat3x2GL_FLOAT_MAT3x4mat3x4GL_FLOAT_MAT4x2mat4x2GL_FLOAT_MAT4x3mat4x3GL_DOUBLE_MAT2dmat2GL_DOUBLE_MAT3dmat3GL_DOUBLE_MAT4dmat4GL_DOUBLE_MAT2x3dmat2x3GL_DOUBLE_MAT2x4dmat2x4GL_DOUBLE_MAT3x2dmat3x2GL_DOUBLE_MAT3x4dmat3x4GL_DOUBLE_MAT4x2dmat4x2GL_DOUBLE_MAT4x3dmat4x3GL_SAMPLER_1Dsampler1DGL_SAMPLER_2Dsampler2DGL_SAMPLER_3Dsampler3DGL_SAMPLER_CUBEsamplerCubeGL_SAMPLER_1D_SHADOWsampler1DShadowGL_SAMPLER_2D_SHADOWsampler2DShadowGL_SAMPLER_1D_ARRAYsampler1DArrayGL_SAMPLER_2D_ARRAYsampler2DArrayGL_SAMPLER_1D_ARRAY_SHADOWsampler1DArrayShadowGL_SAMPLER_2D_ARRAY_SHADOWsampler2DArrayShadowGL_SAMPLER_2D_MULTISAMPLEsampler2DMSGL_SAMPLER_2D_MULTISAMPLE_ARRAYsampler2DMSArrayGL_SAMPLER_CUBE_SHADOWsamplerCubeShadowGL_SAMPLER_BUFFERsamplerBufferGL_SAMPLER_2D_RECTsampler2DRectGL_SAMPLER_2D_RECT_SHADOWsampler2DRectShadowGL_INT_SAMPLER_1Disampler1DGL_INT_SAMPLER_2Disampler2DGL_INT_SAMPLER_3Disampler3DGL_INT_SAMPLER_CUBEisamplerCubeGL_INT_SAMPLER_1D_ARRAYisampler1DArrayGL_INT_SAMPLER_2D_ARRAYisampler2DArrayGL_INT_SAMPLER_2D_MULTISAMPLEisampler2DMSGL_INT_SAMPLER_2D_MULTISAMPLE_ARRAYisampler2DMSArrayGL_INT_SAMPLER_BUFFERisamplerBufferGL_INT_SAMPLER_2D_RECTisampler2DRectGL_UNSIGNED_INT_SAMPLER_1Dusampler1DGL_UNSIGNED_INT_SAMPLER_2Dusampler2DGL_UNSIGNED_INT_SAMPLER_3Dusampler3DGL_UNSIGNED_INT_SAMPLER_CUBEusamplerCubeGL_UNSIGNED_INT_SAMPLER_1D_ARRAYusampler2DArrayGL_UNSIGNED_INT_SAMPLER_2D_ARRAYusampler2DArrayGL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLEusampler2DMSGL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAYusampler2DMSArrayGL_UNSIGNED_INT_SAMPLER_BUFFERusamplerBufferGL_UNSIGNED_INT_SAMPLER_2D_RECTusampler2DRect
		/// If pname is GL_UNIFORM_SIZE, then an array identifying the size of the uniforms specified by the corresponding array of 
		/// uniformIndices is returned. The sizes returned are in units of the type returned by a query of GL_UNIFORM_TYPE. For 
		/// active uniforms that are arrays, the size is the number of active elements in the array; for all other uniforms, the 
		/// size is one.
		/// If pname is GL_UNIFORM_NAME_LENGTH, then an array identifying the length, including the terminating null character, of 
		/// the uniform name strings specified by the corresponding array of uniformIndices is returned.
		/// If pname is GL_UNIFORM_BLOCK_INDEX, then an array identifying the the uniform block index of each of the uniforms 
		/// specified by the corresponding array of uniformIndices is returned. The uniform block index of a uniform associated with 
		/// the default uniform block is -1.
		/// If pname is GL_UNIFORM_OFFSET, then an array of uniform buffer offsets is returned. For uniforms in a named uniform 
		/// block, the returned value will be its offset, in basic machine units, relative to the beginning of the uniform block in 
		/// the buffer object data store. For atomic counter uniforms, the returned value will be its offset relative to the 
		/// beginning of its active atomic counter buffer. For all other uniforms, -1 will be returned.
		/// If pname is GL_UNIFORM_ARRAY_STRIDE, then an array identifying the stride between elements of each of the uniforms 
		/// specified by the corresponding array of uniformIndices is returned. For uniforms in named uniform blocks and for 
		/// uniforms declared as atomic counters, the stride is the difference, in basic machine units, of consecutive elements in 
		/// an array, or zero for uniforms not declared as an array. For all other uniforms, a stride of -1 will be returned.
		/// If pname is GL_UNIFORM_MATRIX_STRIDE, then an array identifying the stride between columns of a column-major matrix or 
		/// rows of a row-major matrix, in basic machine units, of each of the uniforms specified by the corresponding array of 
		/// uniformIndices is returned. The matrix stride of a uniform associated with the default uniform block is -1. Note that 
		/// this information only makes sense for uniforms that are matrices. For uniforms that are not matrices, but are declared 
		/// in a named uniform block, a matrix stride of zero is returned.
		/// If pname is GL_UNIFORM_IS_ROW_MAJOR, then an array identifying whether each of the uniforms specified by the 
		/// corresponding array of uniformIndices is a row-major matrix or not is returned. A value of one indicates a row-major 
		/// matrix, and a value of zero indicates a column-major matrix, a matrix in the default uniform block, or a non-matrix.
		/// If pname is GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX, then an array identifying the active atomic counter buffer index of 
		/// each of the uniforms specified by the corresponding array of uniformIndices is returned. For uniforms other than atomic 
		/// counters, the returned buffer index is -1. The returned indices may be passed to glGetActiveAtomicCounterBufferiv to 
		/// query the properties of the associated buffer, and not necessarily the binding point specified in the uniform 
		/// declaration.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if program is not a value generated by OpenGL.
		/// - GL_INVALID_OPERATION is generated if program is not a program object.
		/// - GL_INVALID_VALUE is generated if uniformCount is greater than or equal to the value of GL_ACTIVE_UNIFORMS for program.
		/// - GL_INVALID_ENUM is generated if pname is not an accepted token.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGet with argument GL_MAX_VERTEX_UNIFORM_COMPONENTS, GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS, 
		///   GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS, GL_MAX_GEOMETRY_UNIFORM_COMPONENTS, GL_MAX_FRAGMENT_UNIFORM_COMPONENTS, or 
		///   GL_MAX_COMBINED_UNIFORM_COMPONENTS.
		/// - glGetProgram with argument GL_ACTIVE_UNIFORMS or GL_ACTIVE_UNIFORM_MAX_LENGTH.
		/// - glIsProgram
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.Uniform"/>
		/// <seealso cref="Gl.UseProgram"/>
		public static void GetActiveUniforms(UInt32 program, Int32 uniformCount, UInt32[] uniformIndices, int pname, Int32[] @params)
		{
			unsafe {
				fixed (UInt32* p_uniformIndices = uniformIndices)
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetActiveUniformsiv != null, "pglGetActiveUniformsiv not implemented");
					Delegates.pglGetActiveUniformsiv(program, uniformCount, p_uniformIndices, pname, p_params);
					CallLog("glGetActiveUniformsiv({0}, {1}, {2}, {3}, {4})", program, uniformCount, uniformIndices, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// query the name of an active uniform
		/// </summary>
		/// <param name="program">
		/// Specifies the program containing the active uniform index uniformIndex.
		/// </param>
		/// <param name="uniformIndex">
		/// Specifies the index of the active uniform whose name to query.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer, in units of GLchar, of the buffer whose address is specified in uniformName.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable that will receive the number of characters that were or would have been written to 
		/// the buffer addressed by uniformName.
		/// </param>
		/// <param name="uniformName">
		/// Specifies the address of a buffer into which the GL will place the name of the active uniform at uniformIndex within 
		/// program.
		/// </param>
		/// <remarks>
		/// glGetActiveUniformName returns the name of the active uniform at uniformIndex within program. If uniformName is not 
		/// NULL, up to bufSize characters (including a nul-terminator) will be written into the array whose address is specified by 
		/// uniformName. If length is not NULL, the number of characters that were (or would have been) written into uniformName 
		/// (not including the nul-terminator) will be placed in the variable whose address is specified in length. If length is 
		/// NULL, no length is returned. The length of the longest uniform name in program is given by the value of 
		/// GL_ACTIVE_UNIFORM_MAX_LENGTH, which can be queried with glGetProgram.
		/// If glGetActiveUniformName is not successful, nothing is written to length or uniformName.
		/// program must be the name of a program for which the command glLinkProgram has been issued in the past. It is not 
		/// necessary for program to have been linked successfully. The link could have failed because the number of active uniforms 
		/// exceeded the limit.
		/// uniformIndex must be an active uniform index of the program program, in the range zero to the value of 
		/// GL_ACTIVE_UNIFORMS minus one. The value of GL_ACTIVE_UNIFORMS can be queried with glGetProgram.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if uniformIndex is greater than or equal to the value of GL_ACTIVE_UNIFORMS.
		/// - GL_INVALID_VALUE is generated if bufSize is negative.
		/// - GL_INVALID_VALUE is generated if program is not the name of a program object for which glLinkProgram has been issued.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetUniformIndices"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.LinkProgram"/>
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
		/// glGetUniformBlockIndex retrieves the index of a uniform block within program.
		/// program must be the name of a program object for which the command glLinkProgram must have been called in the past, 
		/// although it is not required that glLinkProgram must have succeeded. The link could have failed because the number of 
		/// active uniforms exceeded the limit.
		/// uniformBlockName must contain a nul-terminated string specifying the name of the uniform block.
		/// glGetUniformBlockIndex returns the uniform block index for the uniform block named uniformBlockName of program. If 
		/// uniformBlockName does not identify an active uniform block of program, glGetUniformBlockIndex returns the special 
		/// identifier, GL_INVALID_INDEX. Indices of the active uniform blocks of a program are assigned in consecutive order, 
		/// beginning with zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object for which glLinkProgram has been called 
		///   in the past.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniformBlockName"/>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		/// <seealso cref="Gl.LinkProgram"/>
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
		/// Specifies the index of the uniform block within program.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to query.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <remarks>
		/// glGetActiveUniformBlockiv retrieves information about an active uniform block within program.
		/// program must be the name of a program object for which the command glLinkProgram must have been called in the past, 
		/// although it is not required that glLinkProgram must have succeeded. The link could have failed because the number of 
		/// active uniforms exceeded the limit.
		/// uniformBlockIndex is an active uniform block index of program, and must be less than the value of 
		/// GL_ACTIVE_UNIFORM_BLOCKS.
		/// Upon success, the uniform block parameter(s) specified by pname are returned in params. If an error occurs, nothing will 
		/// be written to params.
		/// If pname is GL_UNIFORM_BLOCK_BINDING, then the index of the uniform buffer binding point last selected by the uniform 
		/// block specified by uniformBlockIndex for program is returned. If no uniform block has been previously specified, zero is 
		/// returned.
		/// If pname is GL_UNIFORM_BLOCK_DATA_SIZE, then the implementation-dependent minimum total buffer object size, in basic 
		/// machine units, required to hold all active uniforms in the uniform block identified by uniformBlockIndex is returned. It 
		/// is neither guaranteed nor expected that a given implementation will arrange uniform values as tightly packed in a buffer 
		/// object. The exception to this is the std140 uniform block layout, which guarantees specific packing behavior and does 
		/// not require the application to query for offsets and strides. In this case the minimum size may still be queried, even 
		/// though it is determined in advance based only on the uniform block declaration.
		/// If pname is GL_UNIFORM_BLOCK_NAME_LENGTH, then the total length (including the nul terminator) of the name of the 
		/// uniform block identified by uniformBlockIndex is returned.
		/// If pname is GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS, then the number of active uniforms in the uniform block identified by 
		/// uniformBlockIndex is returned.
		/// If pname is GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES, then a list of the active uniform indices for the uniform block 
		/// identified by uniformBlockIndex is returned. The number of elements that will be written to params is the value of 
		/// GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS for uniformBlockIndex.
		/// If pname is GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER, GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER, 
		/// GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER, GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER, 
		/// GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER, or GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER then a boolean value 
		/// indicating whether the uniform block identified by uniformBlockIndex is referenced by the vertex, tessellation control, 
		/// tessellation evaluation, geometry, fragment or compute programming stages of program, respectively, is returned.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if uniformBlockIndex is greater than or equal to the value of GL_ACTIVE_UNIFORM_BLOCKS or 
		///   is not the index of an active uniform block in program.
		/// - GL_INVALID_ENUM is generated if pname is not one of the accepted tokens.
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object for which glLinkProgram has been called 
		///   in the past.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniformBlockName"/>
		/// <seealso cref="Gl.GetUniformBlockIndex"/>
		/// <seealso cref="Gl.LinkProgram"/>
		public static void GetActiveUniformBlock(UInt32 program, UInt32 uniformBlockIndex, int pname, Int32[] @params)
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
		/// Specifies the index of the uniform block within program.
		/// </param>
		/// <param name="bufSize">
		/// Specifies the size of the buffer addressed by uniformBlockName.
		/// </param>
		/// <param name="length">
		/// Specifies the address of a variable to receive the number of characters that were written to uniformBlockName.
		/// </param>
		/// <param name="uniformBlockName">
		/// Specifies the address an array of characters to receive the name of the uniform block at uniformBlockIndex.
		/// </param>
		/// <remarks>
		/// glGetActiveUniformBlockName retrieves the name of the active uniform block at uniformBlockIndex within program.
		/// program must be the name of a program object for which the command glLinkProgram must have been called in the past, 
		/// although it is not required that glLinkProgram must have succeeded. The link could have failed because the number of 
		/// active uniforms exceeded the limit.
		/// uniformBlockIndex is an active uniform block index of program, and must be less than the value of 
		/// GL_ACTIVE_UNIFORM_BLOCKS.
		/// Upon success, the name of the uniform block identified by unifomBlockIndex is returned into uniformBlockName. The name 
		/// is nul-terminated. The actual number of characters written into uniformBlockName, excluding the nul terminator, is 
		/// returned in length. If length is NULL, no length is returned.
		/// bufSize contains the maximum number of characters (including the nul terminator) that will be written into 
		/// uniformBlockName.
		/// If an error occurs, nothing will be written to uniformBlockName or length.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_OPERATION is generated if program is not the name of a program object for which glLinkProgram has been called 
		///   in the past.
		/// - GL_INVALID_VALUE is generated if uniformBlockIndex is greater than or equal to the value of GL_ACTIVE_UNIFORM_BLOCKS or 
		///   is not the index of an active uniform block in program.
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		/// <seealso cref="Gl.GetUniformBlockIndex"/>
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
		/// The index of the active uniform block within program whose binding to assign.
		/// </param>
		/// <param name="uniformBlockBinding">
		/// Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program.
		/// </param>
		/// <remarks>
		/// Binding points for active uniform blocks are assigned using glUniformBlockBinding. Each of a program's active uniform 
		/// blocks has a corresponding uniform buffer binding point. program is the name of a program object for which the command 
		/// glLinkProgram has been issued in the past.
		/// If successful, glUniformBlockBinding specifies that program will use the data store of the buffer object bound to the 
		/// binding point uniformBlockBinding to extract the values of the uniforms in the uniform block identified by 
		/// uniformBlockIndex.
		/// When a program object is linked or re-linked, the uniform buffer object binding point assigned to each of its active 
		/// uniform blocks is reset to zero.
		/// <para>
		/// The following errors can be generated:
		/// - GL_INVALID_VALUE is generated if uniformBlockIndex is not an active uniform block index of program.
		/// - GL_INVALID_VALUE is generated if uniformBlockBinding is greater than or equal to the value of 
		///   GL_MAX_UNIFORM_BUFFER_BINDINGS.
		/// - GL_INVALID_VALUE is generated if program is not the name of a program object generated by the GL.
		/// </para>
		/// <para>
		/// The associated information is got with the following commands:
		/// - glGetActiveUniformBlock with argument GL_UNIFORM_BLOCK_BINDING
		/// </para>
		/// </remarks>
		/// <seealso cref="Gl.LinkProgram"/>
		/// <seealso cref="Gl.BindBufferBase"/>
		/// <seealso cref="Gl.BindBufferRange"/>
		/// <seealso cref="Gl.GetActiveUniformBlock"/>
		public static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding)
		{
			Debug.Assert(Delegates.pglUniformBlockBinding != null, "pglUniformBlockBinding not implemented");
			Delegates.pglUniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
			CallLog("glUniformBlockBinding({0}, {1}, {2})", program, uniformBlockIndex, uniformBlockBinding);
			DebugCheckErrors();
		}

	}

}
