
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
		/// Value of GL_LINES_ADJACENCY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int LINES_ADJACENCY_ARB = 0x000A;

		/// <summary>
		/// Value of GL_LINE_STRIP_ADJACENCY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int LINE_STRIP_ADJACENCY_ARB = 0x000B;

		/// <summary>
		/// Value of GL_TRIANGLES_ADJACENCY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int TRIANGLES_ADJACENCY_ARB = 0x000C;

		/// <summary>
		/// Value of GL_TRIANGLE_STRIP_ADJACENCY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D;

		/// <summary>
		/// Value of GL_PROGRAM_POINT_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int PROGRAM_POINT_SIZE_ARB = 0x8642;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB = 0x8C29;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int FRAMEBUFFER_ATTACHMENT_LAYERED_ARB = 0x8DA7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB = 0x8DA8;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;

		/// <summary>
		/// Value of GL_GEOMETRY_SHADER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int GEOMETRY_SHADER_ARB = 0x8DD9;

		/// <summary>
		/// Value of GL_GEOMETRY_VERTICES_OUT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int GEOMETRY_VERTICES_OUT_ARB = 0x8DDA;

		/// <summary>
		/// Value of GL_GEOMETRY_INPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int GEOMETRY_INPUT_TYPE_ARB = 0x8DDB;

		/// <summary>
		/// Value of GL_GEOMETRY_OUTPUT_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int GEOMETRY_OUTPUT_TYPE_ARB = 0x8DDC;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;

		/// <summary>
		/// Value of GL_MAX_VERTEX_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB = 0x8DDF;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_GEOMETRY_OUTPUT_VERTICES_ARB = 0x8DE0;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB = 0x8DE1;

		/// <summary>
		/// Binding for glProgramParameteriARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:Int32"/>.
		/// </param>
		public static void ProgramParameterARB(UInt32 program, int pname, Int32 value)
		{
			Debug.Assert(Delegates.pglProgramParameteriARB != null, "pglProgramParameteriARB not implemented");
			Delegates.pglProgramParameteriARB(program, pname, value);
			CallLog("glProgramParameteriARB({0}, {1}, {2})", program, pname, value);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureARB.
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
		public static void FramebufferTextureARB(int target, int attachment, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTextureARB != null, "pglFramebufferTextureARB not implemented");
			Delegates.pglFramebufferTextureARB(target, attachment, texture, level);
			CallLog("glFramebufferTextureARB({0}, {1}, {2}, {3})", target, attachment, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureLayerARB.
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
		public static void FramebufferTextureLayerARB(int target, int attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglFramebufferTextureLayerARB != null, "pglFramebufferTextureLayerARB not implemented");
			Delegates.pglFramebufferTextureLayerARB(target, attachment, texture, level, layer);
			CallLog("glFramebufferTextureLayerARB({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureFaceARB.
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
		public static void FramebufferTextureFaceARB(int target, int attachment, UInt32 texture, Int32 level, int face)
		{
			if        (Delegates.pglFramebufferTextureFaceARB != null) {
				Delegates.pglFramebufferTextureFaceARB(target, attachment, texture, level, face);
				CallLog("glFramebufferTextureFaceARB({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			} else if (Delegates.pglFramebufferTextureFaceEXT != null) {
				Delegates.pglFramebufferTextureFaceEXT(target, attachment, texture, level, face);
				CallLog("glFramebufferTextureFaceEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			} else
				throw new NotImplementedException("glFramebufferTextureFaceARB (and other aliases) are not implemented");
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glFramebufferTextureFaceARB.
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
		public static void FramebufferTextureFaceARB(int target, int attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			if        (Delegates.pglFramebufferTextureFaceARB != null) {
				Delegates.pglFramebufferTextureFaceARB(target, attachment, texture, level, (int)face);
				CallLog("glFramebufferTextureFaceARB({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			} else if (Delegates.pglFramebufferTextureFaceEXT != null) {
				Delegates.pglFramebufferTextureFaceEXT(target, attachment, texture, level, (int)face);
				CallLog("glFramebufferTextureFaceEXT({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, face);
			} else
				throw new NotImplementedException("glFramebufferTextureFaceARB (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
