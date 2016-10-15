
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Binding for glBlendFuncSeparateOES.
		/// </summary>
		/// <param name="srcRGB">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OES_blend_func_separate", Api = "gles1")]
		public static void BlendFuncSeparateOES(Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateOES != null, "pglBlendFuncSeparateOES not implemented");
			Delegates.pglBlendFuncSeparateOES(srcRGB, dstRGB, srcAlpha, dstAlpha);
			LogFunction("glBlendFuncSeparateOES({0}, {1}, {2}, {3})", LogEnumName(srcRGB), LogEnumName(dstRGB), LogEnumName(srcAlpha), LogEnumName(dstAlpha));
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendFuncSeparateOES", ExactSpelling = true)]
			internal extern static void glBlendFuncSeparateOES(Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFuncSeparateOES(Int32 srcRGB, Int32 dstRGB, Int32 srcAlpha, Int32 dstAlpha);

			[ThreadStatic]
			internal static glBlendFuncSeparateOES pglBlendFuncSeparateOES;

		}
	}

}
