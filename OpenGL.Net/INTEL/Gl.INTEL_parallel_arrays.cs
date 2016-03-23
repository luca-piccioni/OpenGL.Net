
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
		/// Value of GL_PARALLEL_ARRAYS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public const int PARALLEL_ARRAYS_INTEL = 0x83F4;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_PARALLEL_POINTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public const int VERTEX_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F5;

		/// <summary>
		/// Value of GL_NORMAL_ARRAY_PARALLEL_POINTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public const int NORMAL_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F6;

		/// <summary>
		/// Value of GL_COLOR_ARRAY_PARALLEL_POINTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public const int COLOR_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F7;

		/// <summary>
		/// Value of GL_TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL symbol.
		/// </summary>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public const int TEXTURE_COORD_ARRAY_PARALLEL_POINTERS_INTEL = 0x83F8;

		/// <summary>
		/// Binding for glVertexPointervINTEL.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public static void VertexPointerINTEL(Int32 size, VertexPointerType type, IntPtr[] pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglVertexPointervINTEL != null, "pglVertexPointervINTEL not implemented");
					Delegates.pglVertexPointervINTEL(size, (Int32)type, p_pointer);
					LogFunction("glVertexPointervINTEL({0}, {1}, {2})", size, type, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNormalPointervINTEL.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:NormalPointerType"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public static void NormalPointerINTEL(NormalPointerType type, IntPtr[] pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglNormalPointervINTEL != null, "pglNormalPointervINTEL not implemented");
					Delegates.pglNormalPointervINTEL((Int32)type, p_pointer);
					LogFunction("glNormalPointervINTEL({0}, {1})", type, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glColorPointervINTEL.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public static void ColorPointerINTEL(Int32 size, VertexPointerType type, IntPtr[] pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglColorPointervINTEL != null, "pglColorPointervINTEL not implemented");
					Delegates.pglColorPointervINTEL(size, (Int32)type, p_pointer);
					LogFunction("glColorPointervINTEL({0}, {1}, {2})", size, type, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTexCoordPointervINTEL.
		/// </summary>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexPointerType"/>.
		/// </param>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_INTEL_parallel_arrays")]
		public static void TexCoordPointerINTEL(Int32 size, VertexPointerType type, IntPtr[] pointer)
		{
			unsafe {
				fixed (IntPtr* p_pointer = pointer)
				{
					Debug.Assert(Delegates.pglTexCoordPointervINTEL != null, "pglTexCoordPointervINTEL not implemented");
					Delegates.pglTexCoordPointervINTEL(size, (Int32)type, p_pointer);
					LogFunction("glTexCoordPointervINTEL({0}, {1}, {2})", size, type, LogValue(pointer));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
