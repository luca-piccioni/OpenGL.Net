
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
		/// Binding for glClipPlanefOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void ClipPlaneOES(ClipPlaneName plane, float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlanefOES != null, "pglClipPlanefOES not implemented");
					Delegates.pglClipPlanefOES((Int32)plane, p_equation);
					LogCommand("glClipPlanefOES", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFrustumfOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void FrustumOES(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglFrustumfOES != null, "pglFrustumfOES not implemented");
			Delegates.pglFrustumfOES(l, r, b, t, n, f);
			LogCommand("glFrustumfOES", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetClipPlanefOES.
		/// </summary>
		/// <param name="plane">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="equation">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void GetClipPlaneOES(ClipPlaneName plane, [Out] float[] equation)
		{
			unsafe {
				fixed (float* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlanefOES != null, "pglGetClipPlanefOES not implemented");
					Delegates.pglGetClipPlanefOES((Int32)plane, p_equation);
					LogCommand("glGetClipPlanefOES", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glOrthofOES.
		/// </summary>
		/// <param name="l">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="t">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="n">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="f">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
		public static void OrthoOES(float l, float r, float b, float t, float n, float f)
		{
			Debug.Assert(Delegates.pglOrthofOES != null, "pglOrthofOES not implemented");
			Delegates.pglOrthofOES(l, r, b, t, n, f);
			LogCommand("glOrthofOES", null, l, r, b, t, n, f			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlanefOES", ExactSpelling = true)]
			internal extern static unsafe void glClipPlanefOES(Int32 plane, float* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustumfOES", ExactSpelling = true)]
			internal extern static void glFrustumfOES(float l, float r, float b, float t, float n, float f);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlanefOES", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlanefOES(Int32 plane, float* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrthofOES", ExactSpelling = true)]
			internal extern static void glOrthofOES(float l, float r, float b, float t, float n, float f);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlanefOES(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glClipPlanefOES pglClipPlanefOES;

			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustumfOES(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glFrustumfOES pglFrustumfOES;

			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlanefOES(Int32 plane, float* equation);

			[ThreadStatic]
			internal static glGetClipPlanefOES pglGetClipPlanefOES;

			[RequiredByFeature("GL_OES_single_precision", Api = "gl|gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrthofOES(float l, float r, float b, float t, float n, float f);

			[ThreadStatic]
			internal static glOrthofOES pglOrthofOES;

		}
	}

}
