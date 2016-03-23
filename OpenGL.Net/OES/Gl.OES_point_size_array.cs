
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
		/// Value of GL_POINT_SIZE_ARRAY_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_OES = 0x8B9C;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_TYPE_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_TYPE_OES = 0x898A;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_STRIDE_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_POINTER_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_POINTER_OES = 0x898C;

		/// <summary>
		/// Value of GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;

		/// <summary>
		/// Binding for glPointSizePointerOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public static void PointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPointSizePointerOES != null, "pglPointSizePointerOES not implemented");
			Delegates.pglPointSizePointerOES(type, stride, pointer);
			LogFunction("glPointSizePointerOES({0}, {1}, 0x{2})", LogEnumName(type), stride, pointer.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPointSizePointerOES.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public static void PointSizePointerOES(Int32 type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				PointSizePointerOES(type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
