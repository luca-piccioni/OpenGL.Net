
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
		/// Binding for glAlphaFuncQCOM.
		/// </summary>
		/// <param name="func">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="ref">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		public static void AlphaFuncQCOM(Int32 func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFuncQCOM != null, "pglAlphaFuncQCOM not implemented");
			Delegates.pglAlphaFuncQCOM(func, @ref);
			LogFunction("glAlphaFuncQCOM({0}, {1})", LogEnumName(func), @ref);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFuncQCOM", ExactSpelling = true)]
			internal extern static void glAlphaFuncQCOM(Int32 func, float @ref);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFuncQCOM(Int32 func, float @ref);

			[ThreadStatic]
			internal static glAlphaFuncQCOM pglAlphaFuncQCOM;

		}
	}

}
