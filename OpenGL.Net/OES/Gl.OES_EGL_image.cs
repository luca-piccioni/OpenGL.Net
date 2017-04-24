
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
		/// Binding for glEGLImageTargetTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetTexture2DOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetTexture2DOES != null, "pglEGLImageTargetTexture2DOES not implemented");
			Delegates.pglEGLImageTargetTexture2DOES(target, image);
			LogCommand("glEGLImageTargetTexture2DOES", null, target, image			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEGLImageTargetRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetRenderbufferStorageOES != null, "pglEGLImageTargetRenderbufferStorageOES not implemented");
			Delegates.pglEGLImageTargetRenderbufferStorageOES(target, image);
			LogCommand("glEGLImageTargetRenderbufferStorageOES", null, target, image			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEGLImageTargetTexture2DOES", ExactSpelling = true)]
			internal extern static unsafe void glEGLImageTargetTexture2DOES(Int32 target, IntPtr image);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEGLImageTargetRenderbufferStorageOES", ExactSpelling = true)]
			internal extern static unsafe void glEGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEGLImageTargetTexture2DOES(Int32 target, IntPtr image);

			[ThreadStatic]
			internal static glEGLImageTargetTexture2DOES pglEGLImageTargetTexture2DOES;

			[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image);

			[ThreadStatic]
			internal static glEGLImageTargetRenderbufferStorageOES pglEGLImageTargetRenderbufferStorageOES;

		}
	}

}
