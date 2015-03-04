
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
		/// Value of GL_LINES_ADJACENCY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int LINES_ADJACENCY_EXT = 0x000A;

		/// <summary>
		/// Value of GL_LINE_STRIP_ADJACENCY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int LINE_STRIP_ADJACENCY_EXT = 0x000B;

		/// <summary>
		/// Value of GL_TRIANGLES_ADJACENCY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int TRIANGLES_ADJACENCY_EXT = 0x000C;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP_ADJACENCY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D;

		/// <summary>
		/// Value of GL_GEOMETRY_PROGRAM_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_PROGRAM_NV = 0x8C26;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_OUTPUT_VERTICES_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_OUTPUT_VERTICES_NV = 0x8C27;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_PROGRAM_TOTAL_OUTPUT_COMPONENTS_NV = 0x8C28;

		/// <summary>
		/// Value of GL_GEOMETRY_VERTICES_OUT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_VERTICES_OUT_EXT = 0x8DDA;

		/// <summary>
		/// Value of GL_GEOMETRY_INPUT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_INPUT_TYPE_EXT = 0x8DDB;

		/// <summary>
		/// Value of GL_GEOMETRY_OUTPUT_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int GEOMETRY_OUTPUT_TYPE_EXT = 0x8DDC;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_EXT = 0x8C29;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED_EXT = 0x8DA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_EXT = 0x8DA8;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT = 0x8DA9;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_texture_array")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT = 0x8CD4;

		/// <summary>
		/// Value of GL_PROGRAM_POINT_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int PROGRAM_POINT_SIZE_EXT = 0x8642;

		/// <summary>
		/// Binding for glProgramVertexLimitNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="limit">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void ProgramVertexLimitNV(int target, Int32 limit)
		{
			Debug.Assert(Delegates.pglProgramVertexLimitNV != null, "pglProgramVertexLimitNV not implemented");
			Delegates.pglProgramVertexLimitNV(target, limit);
			CallLog("glProgramVertexLimitNV({0}, {1})", target, limit);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureEXT(int target, int attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTextureEXT != null, "pglFramebufferTextureEXT not implemented");
			Delegates.pglFramebufferTextureEXT(target, attachment, texture, level);
			CallLog("glFramebufferTextureEXT({0}, {1}, {2}, {3})", target, attachment, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureLayerEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_texture_array")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureLayerEXT(int target, int attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglFramebufferTextureLayerEXT != null, "pglFramebufferTextureLayerEXT not implemented");
			Delegates.pglFramebufferTextureLayerEXT(target, attachment, texture, level, layer);
			CallLog("glFramebufferTextureLayerEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureFaceEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, int face)
		{
			Debug.Assert(Delegates.pglFramebufferTextureFaceEXT != null, "pglFramebufferTextureFaceEXT not implemented");
			Delegates.pglFramebufferTextureFaceEXT(target, attachment, texture, level, face);
			CallLog("glFramebufferTextureFaceEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureFaceEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureFaceEXT(int target, int attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			Debug.Assert(Delegates.pglFramebufferTextureFaceEXT != null, "pglFramebufferTextureFaceEXT not implemented");
			Delegates.pglFramebufferTextureFaceEXT(target, attachment, texture, level, (int)face);
			CallLog("glFramebufferTextureFaceEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			DebugCheckErrors();
		}

	}

}
