
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
		/// [GL] Binding for glBlendEquationSeparateOES.
		/// </summary>
		/// <param name="modeRGB">
		/// A <see cref="T:BlendEquationMode"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:BlendEquationMode"/>.
		/// </param>
		[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
		public static void BlendEquationSeparateOES(BlendEquationMode modeRGB, BlendEquationMode modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateOES != null, "pglBlendEquationSeparateOES not implemented");
			Delegates.pglBlendEquationSeparateOES((Int32)modeRGB, (Int32)modeAlpha);
			LogCommand("glBlendEquationSeparateOES", null, modeRGB, modeAlpha			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendEquationSeparateOES", ExactSpelling = true)]
			internal extern static void glBlendEquationSeparateOES(Int32 modeRGB, Int32 modeAlpha);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendEquationSeparateOES(Int32 modeRGB, Int32 modeAlpha);

			[RequiredByFeature("GL_OES_blend_equation_separate", Api = "gles1")]
			[ThreadStatic]
			internal static glBlendEquationSeparateOES pglBlendEquationSeparateOES;

		}
	}

}
