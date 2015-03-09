
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
		/// Value of GL_MATRIX_PALETTE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_PALETTE_ARB = 0x8840;

		/// <summary>
		/// Value of GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;

		/// <summary>
		/// Value of GL_MAX_PALETTE_MATRICES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MAX_PALETTE_MATRICES_ARB = 0x8842;

		/// <summary>
		/// Value of GL_CURRENT_PALETTE_MATRIX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int CURRENT_PALETTE_MATRIX_ARB = 0x8843;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_INDEX_ARRAY_ARB = 0x8844;

		/// <summary>
		/// Value of GL_CURRENT_MATRIX_INDEX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int CURRENT_MATRIX_INDEX_ARB = 0x8845;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_TYPE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_STRIDE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;

		/// <summary>
		/// Value of GL_MATRIX_INDEX_ARRAY_POINTER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public const int MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;

		/// <summary>
		/// Binding for glCurrentPaletteMatrixARB.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void CurrentPaletteMatrixARB(Int32 index)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixARB != null, "pglCurrentPaletteMatrixARB not implemented");
			Delegates.pglCurrentPaletteMatrixARB(index);
			CallLog("glCurrentPaletteMatrixARB({0})", index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexubvARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(Int32 size, byte[] indices)
		{
			Debug.Assert(indices.Length >= size);
			unsafe {
				fixed (byte* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexubvARB != null, "pglMatrixIndexubvARB not implemented");
					Delegates.pglMatrixIndexubvARB(size, p_indices);
					CallLog("glMatrixIndexubvARB({0}, {1})", size, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexubvARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(byte[] indices)
		{
			unsafe {
				fixed (byte* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexubvARB != null, "pglMatrixIndexubvARB not implemented");
					Delegates.pglMatrixIndexubvARB((Int32)indices.Length, p_indices);
					CallLog("glMatrixIndexubvARB({0}, {1})", indices.Length, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexusvARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(Int32 size, UInt16[] indices)
		{
			Debug.Assert(indices.Length >= size);
			unsafe {
				fixed (UInt16* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexusvARB != null, "pglMatrixIndexusvARB not implemented");
					Delegates.pglMatrixIndexusvARB(size, p_indices);
					CallLog("glMatrixIndexusvARB({0}, {1})", size, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexusvARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(UInt16[] indices)
		{
			unsafe {
				fixed (UInt16* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexusvARB != null, "pglMatrixIndexusvARB not implemented");
					Delegates.pglMatrixIndexusvARB((Int32)indices.Length, p_indices);
					CallLog("glMatrixIndexusvARB({0}, {1})", indices.Length, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexuivARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(Int32 size, UInt32[] indices)
		{
			Debug.Assert(indices.Length >= size);
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexuivARB != null, "pglMatrixIndexuivARB not implemented");
					Delegates.pglMatrixIndexuivARB(size, p_indices);
					CallLog("glMatrixIndexuivARB({0}, {1})", size, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexuivARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="indices">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexARB(UInt32[] indices)
		{
			unsafe {
				fixed (UInt32* p_indices = indices)
				{
					Debug.Assert(Delegates.pglMatrixIndexuivARB != null, "pglMatrixIndexuivARB not implemented");
					Delegates.pglMatrixIndexuivARB((Int32)indices.Length, p_indices);
					CallLog("glMatrixIndexuivARB({0}, {1})", indices.Length, indices);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerARB != null, "pglMatrixIndexPointerARB not implemented");
			Delegates.pglMatrixIndexPointerARB(size, type, stride, pointer);
			CallLog("glMatrixIndexPointerARB({0}, {1}, {2}, {3})", size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerARB.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_matrix_palette")]
		public static void MatrixIndexPointerARB(Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerARB(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
