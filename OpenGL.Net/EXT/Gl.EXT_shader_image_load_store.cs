
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
		/// Value of GL_MAX_IMAGE_UNITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_UNITS_EXT = 0x8F38;

		/// <summary>
		/// Value of GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS_EXT = 0x8F39;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_NAME_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_NAME_EXT = 0x8F3A;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LEVEL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LEVEL_EXT = 0x8F3B;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYERED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYERED_EXT = 0x8F3C;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_LAYER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_LAYER_EXT = 0x8F3D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_ACCESS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_ACCESS_EXT = 0x8F3E;

		/// <summary>
		/// Value of GL_IMAGE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D_EXT = 0x904C;

		/// <summary>
		/// Value of GL_IMAGE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_EXT = 0x904D;

		/// <summary>
		/// Value of GL_IMAGE_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_3D_EXT = 0x904E;

		/// <summary>
		/// Value of GL_IMAGE_2D_RECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_RECT_EXT = 0x904F;

		/// <summary>
		/// Value of GL_IMAGE_CUBE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_CUBE_EXT = 0x9050;

		/// <summary>
		/// Value of GL_IMAGE_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BUFFER_EXT = 0x9051;

		/// <summary>
		/// Value of GL_IMAGE_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_1D_ARRAY_EXT = 0x9052;

		/// <summary>
		/// Value of GL_IMAGE_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_ARRAY_EXT = 0x9053;

		/// <summary>
		/// Value of GL_IMAGE_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_CUBE_MAP_ARRAY_EXT = 0x9054;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE_EXT = 0x9055;

		/// <summary>
		/// Value of GL_IMAGE_2D_MULTISAMPLE_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9056;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D_EXT = 0x9057;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_EXT = 0x9058;

		/// <summary>
		/// Value of GL_INT_IMAGE_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_3D_EXT = 0x9059;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_RECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_RECT_EXT = 0x905A;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_CUBE_EXT = 0x905B;

		/// <summary>
		/// Value of GL_INT_IMAGE_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_BUFFER_EXT = 0x905C;

		/// <summary>
		/// Value of GL_INT_IMAGE_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_1D_ARRAY_EXT = 0x905D;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_ARRAY_EXT = 0x905E;

		/// <summary>
		/// Value of GL_INT_IMAGE_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x905F;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE_EXT = 0x9060;

		/// <summary>
		/// Value of GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x9061;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D_EXT = 0x9062;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_EXT = 0x9063;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_3D_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_3D_EXT = 0x9064;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_RECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_RECT_EXT = 0x9065;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE_EXT = 0x9066;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_BUFFER_EXT = 0x9067;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_1D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_1D_ARRAY_EXT = 0x9068;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_ARRAY_EXT = 0x9069;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY_EXT = 0x906A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_EXT = 0x906B;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY_EXT = 0x906C;

		/// <summary>
		/// Value of GL_MAX_IMAGE_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int MAX_IMAGE_SAMPLES_EXT = 0x906D;

		/// <summary>
		/// Value of GL_IMAGE_BINDING_FORMAT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const int IMAGE_BINDING_FORMAT_EXT = 0x906E;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT = 0x00000001;

		/// <summary>
		/// Value of GL_ELEMENT_ARRAY_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint ELEMENT_ARRAY_BARRIER_BIT_EXT = 0x00000002;

		/// <summary>
		/// Value of GL_UNIFORM_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint UNIFORM_BARRIER_BIT_EXT = 0x00000004;

		/// <summary>
		/// Value of GL_TEXTURE_FETCH_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint TEXTURE_FETCH_BARRIER_BIT_EXT = 0x00000008;

		/// <summary>
		/// Value of GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT = 0x00000020;

		/// <summary>
		/// Value of GL_COMMAND_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint COMMAND_BARRIER_BIT_EXT = 0x00000040;

		/// <summary>
		/// Value of GL_PIXEL_BUFFER_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint PIXEL_BUFFER_BARRIER_BIT_EXT = 0x00000080;

		/// <summary>
		/// Value of GL_TEXTURE_UPDATE_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint TEXTURE_UPDATE_BARRIER_BIT_EXT = 0x00000100;

		/// <summary>
		/// Value of GL_BUFFER_UPDATE_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint BUFFER_UPDATE_BARRIER_BIT_EXT = 0x00000200;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint FRAMEBUFFER_BARRIER_BIT_EXT = 0x00000400;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint TRANSFORM_FEEDBACK_BARRIER_BIT_EXT = 0x00000800;

		/// <summary>
		/// Value of GL_ATOMIC_COUNTER_BARRIER_BIT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint ATOMIC_COUNTER_BARRIER_BIT_EXT = 0x00001000;

		/// <summary>
		/// Value of GL_ALL_BARRIER_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public const uint ALL_BARRIER_BITS_EXT = 0xFFFFFFFF;

		/// <summary>
		/// Binding for glBindImageTextureEXT.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="layered">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public static void BindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, int access, Int32 format)
		{
			Debug.Assert(Delegates.pglBindImageTextureEXT != null, "pglBindImageTextureEXT not implemented");
			Delegates.pglBindImageTextureEXT(index, texture, level, layered, layer, access, format);
			CallLog("glBindImageTextureEXT({0}, {1}, {2}, {3}, {4}, {5}, {6})", index, texture, level, layered, layer, access, format);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMemoryBarrierEXT.
		/// </summary>
		/// <param name="barriers">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		public static void MemoryBarrierEXT(uint barriers)
		{
			Debug.Assert(Delegates.pglMemoryBarrierEXT != null, "pglMemoryBarrierEXT not implemented");
			Delegates.pglMemoryBarrierEXT(barriers);
			CallLog("glMemoryBarrierEXT({0})", barriers);
			DebugCheckErrors();
		}

	}

}
