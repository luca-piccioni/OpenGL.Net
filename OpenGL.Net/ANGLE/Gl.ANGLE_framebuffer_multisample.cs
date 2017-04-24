
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
		/// Binding for glRenderbufferStorageMultisampleANGLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		public static void RenderbufferStorageMultisampleANGLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleANGLE != null, "pglRenderbufferStorageMultisampleANGLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleANGLE(target, samples, internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleANGLE", null, target, samples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleANGLE", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleANGLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleANGLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleANGLE pglRenderbufferStorageMultisampleANGLE;

		}
	}

}
