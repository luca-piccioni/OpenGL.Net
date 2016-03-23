
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
		/// Value of GL_MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E;

		/// <summary>
		/// Binding for glCurrentPaletteMatrixOES.
		/// </summary>
		/// <param name="matrixpaletteindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixOES != null, "pglCurrentPaletteMatrixOES not implemented");
			Delegates.pglCurrentPaletteMatrixOES(matrixpaletteindex);
			LogFunction("glCurrentPaletteMatrixOES({0})", matrixpaletteindex);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glLoadPaletteFromModelViewMatrixOES.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void LoadPaletteFromModelViewMatrixOES()
		{
			Debug.Assert(Delegates.pglLoadPaletteFromModelViewMatrixOES != null, "pglLoadPaletteFromModelViewMatrixOES not implemented");
			Delegates.pglLoadPaletteFromModelViewMatrixOES();
			LogFunction("glLoadPaletteFromModelViewMatrixOES()");
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
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
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void MatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerOES != null, "pglMatrixIndexPointerOES not implemented");
			Delegates.pglMatrixIndexPointerOES(size, type, stride, pointer);
			LogFunction("glMatrixIndexPointerOES({0}, {1}, {2}, 0x{3})", size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glMatrixIndexPointerOES.
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
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void MatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				MatrixIndexPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
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
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void WeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerOES != null, "pglWeightPointerOES not implemented");
			Delegates.pglWeightPointerOES(size, type, stride, pointer);
			LogFunction("glWeightPointerOES({0}, {1}, {2}, 0x{3})", size, LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glWeightPointerOES.
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
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void WeightPointerOES(Int32 size, Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				WeightPointerOES(size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
