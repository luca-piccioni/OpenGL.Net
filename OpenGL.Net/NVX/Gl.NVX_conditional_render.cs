
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
		/// Binding for glBeginConditionalRenderNVX.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_NVX_conditional_render")]
		public static void BeginConditionalRenderNVX(UInt32 id)
		{
			Debug.Assert(Delegates.pglBeginConditionalRenderNVX != null, "pglBeginConditionalRenderNVX not implemented");
			Delegates.pglBeginConditionalRenderNVX(id);
			LogFunction("glBeginConditionalRenderNVX({0})", id);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBeginConditionalRenderNVX", ExactSpelling = true)]
			internal extern static void glBeginConditionalRenderNVX(UInt32 id);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBeginConditionalRenderNVX(UInt32 id);

			[ThreadStatic]
			internal static glBeginConditionalRenderNVX pglBeginConditionalRenderNVX;

		}
	}

}
