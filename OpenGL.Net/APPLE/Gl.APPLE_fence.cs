
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
		/// Value of GL_DRAW_PIXELS_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int DRAW_PIXELS_APPLE = 0x8A0A;

		/// <summary>
		/// Value of GL_FENCE_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public const int FENCE_APPLE = 0x8A0B;

		/// <summary>
		/// Binding for glGenFencesAPPLE.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void GenFencesAPPLE(UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesAPPLE != null, "pglGenFencesAPPLE not implemented");
					Delegates.pglGenFencesAPPLE((Int32)fences.Length, p_fences);
					LogCommand("glGenFencesAPPLE", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesAPPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_fence")]
		public static UInt32 GenFencesAPPLE()
		{
			UInt32[] retValue = new UInt32[1];
			GenFencesAPPLE(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glDeleteFencesAPPLE.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void DeleteFencesAPPLE(params UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesAPPLE != null, "pglDeleteFencesAPPLE not implemented");
					Delegates.pglDeleteFencesAPPLE((Int32)fences.Length, p_fences);
					LogCommand("glDeleteFencesAPPLE", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void SetFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglSetFenceAPPLE != null, "pglSetFenceAPPLE not implemented");
			Delegates.pglSetFenceAPPLE(fence);
			LogCommand("glSetFenceAPPLE", null, fence			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glIsFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool IsFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceAPPLE != null, "pglIsFenceAPPLE not implemented");
			retValue = Delegates.pglIsFenceAPPLE(fence);
			LogCommand("glIsFenceAPPLE", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glTestFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestFenceAPPLE(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceAPPLE != null, "pglTestFenceAPPLE not implemented");
			retValue = Delegates.pglTestFenceAPPLE(fence);
			LogCommand("glTestFenceAPPLE", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishFenceAPPLE.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishFenceAPPLE(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceAPPLE != null, "pglFinishFenceAPPLE not implemented");
			Delegates.pglFinishFenceAPPLE(fence);
			LogCommand("glFinishFenceAPPLE", null, fence			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glTestObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static bool TestObjectAPPLE(Int32 @object, UInt32 name)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestObjectAPPLE != null, "pglTestObjectAPPLE not implemented");
			retValue = Delegates.pglTestObjectAPPLE(@object, name);
			LogCommand("glTestObjectAPPLE", retValue, @object, name			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glFinishObjectAPPLE.
		/// </summary>
		/// <param name="object">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_fence")]
		public static void FinishObjectAPPLE(Int32 @object, Int32 name)
		{
			Debug.Assert(Delegates.pglFinishObjectAPPLE != null, "pglFinishObjectAPPLE not implemented");
			Delegates.pglFinishObjectAPPLE(@object, name);
			LogCommand("glFinishObjectAPPLE", null, @object, name			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenFencesAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glGenFencesAPPLE(Int32 n, UInt32* fences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteFencesAPPLE", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFencesAPPLE(Int32 n, UInt32* fences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSetFenceAPPLE", ExactSpelling = true)]
			internal extern static void glSetFenceAPPLE(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsFenceAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFenceAPPLE(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTestFenceAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestFenceAPPLE(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFinishFenceAPPLE", ExactSpelling = true)]
			internal extern static void glFinishFenceAPPLE(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTestObjectAPPLE", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestObjectAPPLE(Int32 @object, UInt32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFinishObjectAPPLE", ExactSpelling = true)]
			internal extern static void glFinishObjectAPPLE(Int32 @object, Int32 name);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFencesAPPLE(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glGenFencesAPPLE pglGenFencesAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFencesAPPLE(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glDeleteFencesAPPLE pglDeleteFencesAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSetFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glSetFenceAPPLE pglSetFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glIsFenceAPPLE pglIsFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glTestFenceAPPLE pglTestFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishFenceAPPLE(UInt32 fence);

			[ThreadStatic]
			internal static glFinishFenceAPPLE pglFinishFenceAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestObjectAPPLE(Int32 @object, UInt32 name);

			[ThreadStatic]
			internal static glTestObjectAPPLE pglTestObjectAPPLE;

			[RequiredByFeature("GL_APPLE_fence")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishObjectAPPLE(Int32 @object, Int32 name);

			[ThreadStatic]
			internal static glFinishObjectAPPLE pglFinishObjectAPPLE;

		}
	}

}
