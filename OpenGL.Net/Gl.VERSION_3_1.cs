
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
		/// Value of GL_UNIFORM_BUFFER_BINDING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_BINDING = 0x8A28;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_START symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_START = 0x8A29;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int UNIFORM_BUFFER_SIZE = 0x8A2A;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
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
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D;

		/// <summary>
		/// Value of GL_MAX_COMBINED_UNIFORM_BLOCKS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E;

		/// <summary>
		/// Value of GL_MAX_UNIFORM_BUFFER_BINDINGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F;

		/// <summary>
		/// Value of GL_MAX_UNIFORM_BLOCK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_UNIFORM_BLOCK_SIZE = 0x8A30;

		/// <summary>
		/// Value of GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
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
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public const int MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT symbol.
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
		[RequiredByFeature("GL_VERSION_3_1")]
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
		[RequiredByFeature("GL_VERSION_3_1")]
		public static void DrawElementsInstanced(PrimitiveType mode, Int32 count, DrawElementsType type, IntPtr indices, Int32 instancecount)
		{
			if        (Delegates.pglDrawElementsInstanced != null) {
				Delegates.pglDrawElementsInstanced((int)mode, count, (int)type, indices, instancecount);
				CallLog("glDrawElementsInstanced({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedANGLE != null) {
				Delegates.pglDrawElementsInstancedANGLE((int)mode, count, (int)type, indices, instancecount);
				CallLog("glDrawElementsInstancedANGLE({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedARB != null) {
				Delegates.pglDrawElementsInstancedARB((int)mode, count, (int)type, indices, instancecount);
				CallLog("glDrawElementsInstancedARB({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedEXT != null) {
				Delegates.pglDrawElementsInstancedEXT((int)mode, count, (int)type, indices, instancecount);
				CallLog("glDrawElementsInstancedEXT({0}, {1}, {2}, {3}, {4})", mode, count, type, indices, instancecount);
			} else if (Delegates.pglDrawElementsInstancedNV != null) {
				Delegates.pglDrawElementsInstancedNV((int)mode, count, (int)type, indices, instancecount);
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
		/// Specifies the target to which the texture is bound for glTexBuffer. Must be GL_TEXTURE_BUFFER.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="buffer">
		/// Specifies the name of the buffer object whose storage to attach to the active buffer texture.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_1")]
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
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_copy_buffer")]
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
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
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
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
		public static void GetActiveUniforms(UInt32 program, UInt32[] uniformIndices, int pname, Int32[] @params)
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
		/// Specifies the index of the uniform block within program.
		/// </param>
		/// <param name="pname">
		/// Specifies the name of the parameter to query.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object")]
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
		/// The index of the active uniform block within program whose binding to assign.
		/// </param>
		/// <param name="uniformBlockBinding">
		/// Specifies the binding point to which to bind the uniform block with index uniformBlockIndex within program.
		/// </param>
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
