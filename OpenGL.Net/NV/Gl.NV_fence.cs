
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
		/// [GL] Value of GL_ALL_COMPLETED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int ALL_COMPLETED_NV = 0x84F2;

		/// <summary>
		/// [GL] Value of GL_FENCE_STATUS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int FENCE_STATUS_NV = 0x84F3;

		/// <summary>
		/// [GL] Value of GL_FENCE_CONDITION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public const int FENCE_CONDITION_NV = 0x84F4;

		/// <summary>
		/// Binding for glDeleteFencesNV.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void DeleteFencesNV(params UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglDeleteFencesNV != null, "pglDeleteFencesNV not implemented");
					Delegates.pglDeleteFencesNV((Int32)fences.Length, p_fences);
					LogCommand("glDeleteFencesNV", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesNV.
		/// </summary>
		/// <param name="fences">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void GenFencesNV(UInt32[] fences)
		{
			unsafe {
				fixed (UInt32* p_fences = fences)
				{
					Debug.Assert(Delegates.pglGenFencesNV != null, "pglGenFencesNV not implemented");
					Delegates.pglGenFencesNV((Int32)fences.Length, p_fences);
					LogCommand("glGenFencesNV", null, fences.Length, fences					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGenFencesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static UInt32 GenFencesNV()
		{
			UInt32[] retValue = new UInt32[1];
			GenFencesNV(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// Binding for glIsFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static bool IsFenceNV(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFenceNV != null, "pglIsFenceNV not implemented");
			retValue = Delegates.pglIsFenceNV(fence);
			LogCommand("glIsFenceNV", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glTestFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static bool TestFenceNV(UInt32 fence)
		{
			bool retValue;

			Debug.Assert(Delegates.pglTestFenceNV != null, "pglTestFenceNV not implemented");
			retValue = Delegates.pglTestFenceNV(fence);
			LogCommand("glTestFenceNV", retValue, fence			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetFenceivNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void GetFenceNV(UInt32 fence, Int32 pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFenceivNV != null, "pglGetFenceivNV not implemented");
					Delegates.pglGetFenceivNV(fence, pname, p_params);
					LogCommand("glGetFenceivNV", null, fence, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFinishFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void FinishFenceNV(UInt32 fence)
		{
			Debug.Assert(Delegates.pglFinishFenceNV != null, "pglFinishFenceNV not implemented");
			Delegates.pglFinishFenceNV(fence);
			LogCommand("glFinishFenceNV", null, fence			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glSetFenceNV.
		/// </summary>
		/// <param name="fence">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="condition">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
		public static void SetFenceNV(UInt32 fence, Int32 condition)
		{
			Debug.Assert(Delegates.pglSetFenceNV != null, "pglSetFenceNV not implemented");
			Delegates.pglSetFenceNV(fence, condition);
			LogCommand("glSetFenceNV", null, fence, condition			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
			internal extern static unsafe void glDeleteFencesNV(Int32 n, UInt32* fences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
			internal extern static unsafe void glGenFencesNV(Int32 n, UInt32* fences);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsFenceNV(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glTestFenceNV(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
			internal extern static unsafe void glGetFenceivNV(UInt32 fence, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
			internal extern static void glFinishFenceNV(UInt32 fence);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
			internal extern static void glSetFenceNV(UInt32 fence, Int32 condition);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDeleteFencesNV(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glDeleteFencesNV pglDeleteFencesNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGenFencesNV(Int32 n, UInt32* fences);

			[ThreadStatic]
			internal static glGenFencesNV pglGenFencesNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glIsFenceNV pglIsFenceNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glTestFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glTestFenceNV pglTestFenceNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFenceivNV(UInt32 fence, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetFenceivNV pglGetFenceivNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinishFenceNV(UInt32 fence);

			[ThreadStatic]
			internal static glFinishFenceNV pglFinishFenceNV;

			[RequiredByFeature("GL_NV_fence", Api = "gl|gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glSetFenceNV(UInt32 fence, Int32 condition);

			[ThreadStatic]
			internal static glSetFenceNV pglSetFenceNV;

		}
	}

}
