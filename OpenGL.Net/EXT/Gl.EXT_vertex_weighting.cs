
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
		/// Value of GL_MODELVIEW0_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;

		/// <summary>
		/// Value of GL_MODELVIEW1_STACK_DEPTH_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_STACK_DEPTH_EXT = 0x8502;

		/// <summary>
		/// Value of GL_MODELVIEW0_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW0_MATRIX_EXT = 0x0BA6;

		/// <summary>
		/// Value of GL_MODELVIEW1_MATRIX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int MODELVIEW1_MATRIX_EXT = 0x8506;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHTING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHTING_EXT = 0x8509;

		/// <summary>
		/// Value of GL_CURRENT_VERTEX_WEIGHT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int CURRENT_VERTEX_WEIGHT_EXT = 0x850B;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHT_ARRAY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_EXT = 0x850C;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;

		/// <summary>
		/// Value of GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public const int VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;

		/// <summary>
		/// Binding for glVertexWeightfEXT.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightEXT(float weight)
		{
			Debug.Assert(Delegates.pglVertexWeightfEXT != null, "pglVertexWeightfEXT not implemented");
			Delegates.pglVertexWeightfEXT(weight);
			LogFunction("glVertexWeightfEXT({0})", weight);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexWeightfvEXT.
		/// </summary>
		/// <param name="weight">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightEXT(float[] weight)
		{
			unsafe {
				fixed (float* p_weight = weight)
				{
					Debug.Assert(Delegates.pglVertexWeightfvEXT != null, "pglVertexWeightfvEXT not implemented");
					Delegates.pglVertexWeightfvEXT(p_weight);
					LogFunction("glVertexWeightfvEXT({0})", LogValue(weight));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexWeightPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexWeightPointerEXT != null, "pglVertexWeightPointerEXT not implemented");
			Delegates.pglVertexWeightPointerEXT(size, type, stride, pointer);
			LogFunction("glVertexWeightPointerEXT({0}, {1}, {2}, 0x{3})", size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVertexWeightPointerEXT.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_vertex_weighting")]
		public static void VertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexWeightPointerEXT(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
