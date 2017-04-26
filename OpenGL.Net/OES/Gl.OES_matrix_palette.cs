
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
		/// Gl.Get: params returns one value, the matrix index array buffer binding. See Gl.MatrixIndexPointer.
		/// </summary>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public const int MATRIX_INDEX_ARRAY_BUFFER_BINDING_OES = 0x8B9E;

		/// <summary>
		/// defines which of the palette's matrices is affected by subsequent matrix operations
		/// </summary>
		/// <param name="matrixpaletteindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="index"/> is not between Gl. and Gl.MAX_PALETTE_MATRICES_OES - Gl..
		/// </exception>
		/// <seealso cref="Gl.LoadPaletteFromModelViewMatrix"/>
		/// <seealso cref="Gl.MatrixIndexPointer"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.WeightPointer"/>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void CurrentPaletteMatrixOES(UInt32 matrixpaletteindex)
		{
			Debug.Assert(Delegates.pglCurrentPaletteMatrixOES != null, "pglCurrentPaletteMatrixOES not implemented");
			Delegates.pglCurrentPaletteMatrixOES(matrixpaletteindex);
			LogCommand("glCurrentPaletteMatrixOES", null, matrixpaletteindex			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copies the current model view matrix to a matrix in the current matrix palette
		/// </summary>
		/// <seealso cref="Gl.CurrentPaletteMatrix"/>
		/// <seealso cref="Gl.MatrixIndexPointer"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.WeightPointer"/>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void LoadPaletteFromModelViewMatrixOES()
		{
			Debug.Assert(Delegates.pglLoadPaletteFromModelViewMatrixOES != null, "pglLoadPaletteFromModelViewMatrixOES not implemented");
			Delegates.pglLoadPaletteFromModelViewMatrixOES();
			LogCommand("glLoadPaletteFromModelViewMatrixOES", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of matrix indices
		/// </summary>
		/// <param name="size">
		/// Specifies the number of matrix indices per vertex. Must be is less than or equal to Gl.MAX_VERTEX_UNITS_OES. The initial 
		/// value is Gl..
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each matrix index in the array. Symbolic constant Gl.UNSIGNED_BYTE is accepted. The initial 
		/// value is Gl.UNSIGNED_BYTE.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive matrix indices. If <paramref name="stride"/> is 0, the matrix indices are 
		/// understood to be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is greater than Gl.MAX_VERTEX_UNITS_OES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.CurrentPaletteMatrix"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.LoadPaletteFromModelViewMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.WeightPointer"/>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void MatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglMatrixIndexPointerOES != null, "pglMatrixIndexPointerOES not implemented");
			Delegates.pglMatrixIndexPointerOES(size, type, stride, pointer);
			LogCommand("glMatrixIndexPointerOES", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of matrix indices
		/// </summary>
		/// <param name="size">
		/// Specifies the number of matrix indices per vertex. Must be is less than or equal to Gl.MAX_VERTEX_UNITS_OES. The initial 
		/// value is Gl..
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each matrix index in the array. Symbolic constant Gl.UNSIGNED_BYTE is accepted. The initial 
		/// value is Gl.UNSIGNED_BYTE.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive matrix indices. If <paramref name="stride"/> is 0, the matrix indices are 
		/// understood to be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first matrix index of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is greater than Gl.MAX_VERTEX_UNITS_OES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.CurrentPaletteMatrix"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.LoadPaletteFromModelViewMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.WeightPointer"/>
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
		/// define an array of weights
		/// </summary>
		/// <param name="size">
		/// Specifies the number of weights per vertex. Must be is less than or equal to Gl.MAX_VERTEX_UNITS_OES. The initial value 
		/// is Gl..
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each weight in the array. Symbolic constant Gl.FIXED is accepted. However, the common profile 
		/// also accepts the symbolic constant Gl.FLOAT as well. The initial value is Gl.FIXED for the common lite profile, or 
		/// Gl.FLOAT for the common profile.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive weights. If <paramref name="stride"/> is 0, the weights are understood to 
		/// be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first weight of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is greater than Gl.MAX_VERTEX_UNITS_OES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.CurrentPaletteMatrix"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.LoadPaletteFromModelViewMatrix"/>
		/// <seealso cref="Gl.MatrixIndexPointer"/>
		/// <seealso cref="Gl.MatrixMode"/>
		[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
		public static void WeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglWeightPointerOES != null, "pglWeightPointerOES not implemented");
			Delegates.pglWeightPointerOES(size, type, stride, pointer);
			LogCommand("glWeightPointerOES", null, size, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of weights
		/// </summary>
		/// <param name="size">
		/// Specifies the number of weights per vertex. Must be is less than or equal to Gl.MAX_VERTEX_UNITS_OES. The initial value 
		/// is Gl..
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each weight in the array. Symbolic constant Gl.FIXED is accepted. However, the common profile 
		/// also accepts the symbolic constant Gl.FLOAT as well. The initial value is Gl.FIXED for the common lite profile, or 
		/// Gl.FLOAT for the common profile.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive weights. If <paramref name="stride"/> is 0, the weights are understood to 
		/// be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the first weight of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is greater than Gl.MAX_VERTEX_UNITS_OES.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.CurrentPaletteMatrix"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.LoadPaletteFromModelViewMatrix"/>
		/// <seealso cref="Gl.MatrixIndexPointer"/>
		/// <seealso cref="Gl.MatrixMode"/>
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

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCurrentPaletteMatrixOES", ExactSpelling = true)]
			internal extern static void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadPaletteFromModelViewMatrixOES", ExactSpelling = true)]
			internal extern static void glLoadPaletteFromModelViewMatrixOES();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixIndexPointerOES", ExactSpelling = true)]
			internal extern static unsafe void glMatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glWeightPointerOES", ExactSpelling = true)]
			internal extern static unsafe void glWeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCurrentPaletteMatrixOES(UInt32 matrixpaletteindex);

			[ThreadStatic]
			internal static glCurrentPaletteMatrixOES pglCurrentPaletteMatrixOES;

			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadPaletteFromModelViewMatrixOES();

			[ThreadStatic]
			internal static glLoadPaletteFromModelViewMatrixOES pglLoadPaletteFromModelViewMatrixOES;

			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMatrixIndexPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glMatrixIndexPointerOES pglMatrixIndexPointerOES;

			[RequiredByFeature("GL_OES_matrix_palette", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glWeightPointerOES(Int32 size, Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glWeightPointerOES pglWeightPointerOES;

		}
	}

}
