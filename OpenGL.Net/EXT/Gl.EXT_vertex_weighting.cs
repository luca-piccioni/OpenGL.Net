
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
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
			LogCommand("glVertexWeightfEXT", null, weight			);
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
					LogCommand("glVertexWeightfvEXT", null, weight					);
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
			LogCommand("glVertexWeightPointerEXT", null, size, type, stride, pointer			);
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

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexWeightfEXT", ExactSpelling = true)]
			internal extern static void glVertexWeightfEXT(float weight);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexWeightfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeightfvEXT(float* weight);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertexWeightPointerEXT", ExactSpelling = true)]
			internal extern static unsafe void glVertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexWeightfEXT(float weight);

			[ThreadStatic]
			internal static glVertexWeightfEXT pglVertexWeightfEXT;

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeightfvEXT(float* weight);

			[ThreadStatic]
			internal static glVertexWeightfvEXT pglVertexWeightfvEXT;

			[RequiredByFeature("GL_EXT_vertex_weighting")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexWeightPointerEXT(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glVertexWeightPointerEXT pglVertexWeightPointerEXT;

		}
	}

}
