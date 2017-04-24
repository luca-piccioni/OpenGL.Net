
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
		/// Binding for glTextureBarrierNV.
		/// </summary>
		[RequiredByFeature("GL_NV_texture_barrier", Api = "gl|glcore")]
		public static void TextureBarrierNV()
		{
			Debug.Assert(Delegates.pglTextureBarrierNV != null, "pglTextureBarrierNV not implemented");
			Delegates.pglTextureBarrierNV();
			LogCommand("glTextureBarrierNV", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTextureBarrierNV", ExactSpelling = true)]
			internal extern static void glTextureBarrierNV();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_texture_barrier", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTextureBarrierNV();

			[ThreadStatic]
			internal static glTextureBarrierNV pglTextureBarrierNV;

		}
	}

}
