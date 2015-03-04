
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
		/// Value of GL_WRITE_PIXEL_DATA_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_NV = 0x8878;

		/// <summary>
		/// Value of GL_READ_PIXEL_DATA_RANGE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_NV = 0x8879;

		/// <summary>
		/// Value of GL_WRITE_PIXEL_DATA_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_LENGTH_NV = 0x887A;

		/// <summary>
		/// Value of GL_READ_PIXEL_DATA_RANGE_LENGTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_LENGTH_NV = 0x887B;

		/// <summary>
		/// Value of GL_WRITE_PIXEL_DATA_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int WRITE_PIXEL_DATA_RANGE_POINTER_NV = 0x887C;

		/// <summary>
		/// Value of GL_READ_PIXEL_DATA_RANGE_POINTER_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public const int READ_PIXEL_DATA_RANGE_POINTER_NV = 0x887D;

		/// <summary>
		/// Binding for glPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void PixelDataRangeNV(int target, Int32 length, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPixelDataRangeNV != null, "pglPixelDataRangeNV not implemented");
			Delegates.pglPixelDataRangeNV(target, length, pointer);
			CallLog("glPixelDataRangeNV({0}, {1}, {2})", target, length, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void PixelDataRangeNV(int target, Int32 length, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				PixelDataRangeNV(target, length, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Binding for glFlushPixelDataRangeNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_pixel_data_range")]
		public static void FlushPixelDataRangeNV(int target)
		{
			Debug.Assert(Delegates.pglFlushPixelDataRangeNV != null, "pglFlushPixelDataRangeNV not implemented");
			Delegates.pglFlushPixelDataRangeNV(target);
			CallLog("glFlushPixelDataRangeNV({0})", target);
			DebugCheckErrors();
		}

	}

}
