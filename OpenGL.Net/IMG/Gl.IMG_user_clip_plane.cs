
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glClipPlanefIMG: Binding for glClipPlanefIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		public static void ClipPlaneIMG(ClipPlaneName p, float[] eqn)
		{
			Debug.Assert(eqn.Length >= 4);
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanefIMG != null, "pglClipPlanefIMG not implemented");
					Delegates.pglClipPlanefIMG((int)p, p_eqn);
					LogCommand("glClipPlanefIMG", null, p, eqn					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glClipPlanexIMG: Binding for glClipPlanexIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:ClipPlaneName"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		public static void ClipPlaneIMG(ClipPlaneName p, IntPtr[] eqn)
		{
			Debug.Assert(eqn.Length >= 4);
			unsafe {
				fixed (IntPtr* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanexIMG != null, "pglClipPlanexIMG not implemented");
					Delegates.pglClipPlanexIMG((int)p, p_eqn);
					LogCommand("glClipPlanexIMG", null, p, eqn					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glClipPlanefIMG(int p, float* eqn);

			[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
			[ThreadStatic]
			internal static glClipPlanefIMG pglClipPlanefIMG;

			[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glClipPlanexIMG(int p, IntPtr* eqn);

			[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
			[ThreadStatic]
			internal static glClipPlanexIMG pglClipPlanexIMG;

		}
	}

}
