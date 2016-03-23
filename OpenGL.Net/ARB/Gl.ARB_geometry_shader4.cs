
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
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public const int FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB = 0x8DA9;

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
		[AliasOf("GL_MAX_GEOMETRY_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_GEOMETRY_VARYING_COMPONENTS_ARB = 0x8DDD;

		/// <summary>
		/// Value of GL_MAX_VERTEX_VARYING_COMPONENTS_ARB symbol.
		/// </summary>
		[AliasOf("GL_MAX_VERTEX_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		public const int MAX_VERTEX_VARYING_COMPONENTS_ARB = 0x8DDE;

		/// <summary>
		/// Binding for glFramebufferTextureFaceARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="face">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		[AliasOf("glFramebufferTextureFaceEXT")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		public static void FramebufferTextureFaceARB(Int32 target, Int32 attachment, UInt32 texture, Int32 level, TextureTarget face)
		{
			Debug.Assert(Delegates.pglFramebufferTextureFaceARB != null, "pglFramebufferTextureFaceARB not implemented");
			Delegates.pglFramebufferTextureFaceARB(target, attachment, texture, level, (Int32)face);
			LogFunction("glFramebufferTextureFaceARB({0}, {1}, {2}, {3}, {4})", LogEnumName(target), LogEnumName(attachment), texture, level, face);
			DebugCheckErrors(null);
		}

	}

}
