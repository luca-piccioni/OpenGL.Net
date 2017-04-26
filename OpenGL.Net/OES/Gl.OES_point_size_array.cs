
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
		/// <para>
		/// [GLES1.1] Gl.EnableClientState: If enabled, the point size array controls the sizes used to render points and point 
		/// sprites. In this case the point size defined by Gl.PointSize is ignored. The point sizes supplied in the point size 
		/// arrays will be the sizes used to render both points and point sprites. See Gl.PointSize
		/// </para>
		/// <para>
		/// [GLES1.1] Gl.Get: params returns a single boolean value indicating whether the point size array is enabled. The initial 
		/// value is Gl.FALSE. See Gl.PointSizePointerOES.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_OES = 0x8B9C;

		/// <summary>
		/// [GLES1.1] Gl.Get: params returns one value, the data type of each point size in the point array. See 
		/// Gl.PointSizePointerOES.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_TYPE_OES = 0x898A;

		/// <summary>
		/// [GLES1.1] Gl.Get: params returns one value, the byte offset between consecutive point sizes in the point size array. See 
		/// Gl.PointSizePointerOES.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_STRIDE_OES = 0x898B;

		/// <summary>
		/// [GL] Value of GL_POINT_SIZE_ARRAY_POINTER_OES symbol.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_POINTER_OES = 0x898C;

		/// <summary>
		/// [GLES1.1] Gl.Get: params returns one value, the point size array buffer binding. See Gl.PointSizePointerOES.
		/// </summary>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public const int POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 0x8B9F;

		/// <summary>
		/// define an array of point sizes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each point size in the array. Symbolic constant Gl.FIXED is accepted. However, the common 
		/// profile also accepts the symbolic constant Gl.FLOAT. The initial value is Gl.FIXED for the common lite profile, or 
		/// Gl.FLOAT for the common profile.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive point sizes. If <paramref name="stride"/> is 0, the point sizes are 
		/// understood to be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the point size of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.PointParameter"/>
		/// <seealso cref="Gl.PointSize"/>
		[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
		public static void PointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglPointSizePointerOES != null, "pglPointSizePointerOES not implemented");
			Delegates.pglPointSizePointerOES(type, stride, pointer);
			LogCommand("glPointSizePointerOES", null, type, stride, pointer			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define an array of point sizes
		/// </summary>
		/// <param name="type">
		/// Specifies the data type of each point size in the array. Symbolic constant Gl.FIXED is accepted. However, the common 
		/// profile also accepts the symbolic constant Gl.FLOAT. The initial value is Gl.FIXED for the common lite profile, or 
		/// Gl.FLOAT for the common profile.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive point sizes. If <paramref name="stride"/> is 0, the point sizes are 
		/// understood to be tightly packed in the array. The initial value is Gl..
		/// </param>
		/// <param name="pointer">
		/// Specifies a pointer to the point size of the first vertex in the array. The initial value is Gl..
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.PointParameter"/>
		/// <seealso cref="Gl.PointSize"/>
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

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointSizePointerOES", ExactSpelling = true)]
			internal extern static unsafe void glPointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_point_size_array", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPointSizePointerOES(Int32 type, Int32 stride, IntPtr pointer);

			[ThreadStatic]
			internal static glPointSizePointerOES pglPointSizePointerOES;

		}
	}

}
