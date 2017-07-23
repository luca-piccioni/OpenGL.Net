
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
		/// [GL] Binding for glBlendEquationOES.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:BlendEquationMode"/>.
		/// </param>
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		public static void BlendEquationOES(BlendEquationMode mode)
		{
			Debug.Assert(Delegates.pglBlendEquationOES != null, "pglBlendEquationOES not implemented");
			Delegates.pglBlendEquationOES((Int32)mode);
			LogCommand("glBlendEquationOES", null, mode			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glBlendEquationOES", ExactSpelling = true)]
			internal extern static void glBlendEquationOES(Int32 mode);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glBlendEquationOES(Int32 mode);

			[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
			[ThreadStatic]
			internal static glBlendEquationOES pglBlendEquationOES;

		}
	}

}
