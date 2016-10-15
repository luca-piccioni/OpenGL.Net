
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
		/// Binding for glRenderbufferStorageMultisampleAPPLE.
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
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		public static void RenderbufferStorageMultisampleAPPLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleAPPLE != null, "pglRenderbufferStorageMultisampleAPPLE not implemented");
			Delegates.pglRenderbufferStorageMultisampleAPPLE(target, samples, internalformat, width, height);
			LogFunction("glRenderbufferStorageMultisampleAPPLE({0}, {1}, {2}, {3}, {4})", LogEnumName(target), samples, LogEnumName(internalformat), width, height);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glResolveMultisampleFramebufferAPPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		public static void ResolveMultisampleFramebufferAPPLE()
		{
			Debug.Assert(Delegates.pglResolveMultisampleFramebufferAPPLE != null, "pglResolveMultisampleFramebufferAPPLE not implemented");
			Delegates.pglResolveMultisampleFramebufferAPPLE();
			LogFunction("glResolveMultisampleFramebufferAPPLE()");
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleAPPLE", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleAPPLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glResolveMultisampleFramebufferAPPLE", ExactSpelling = true)]
			internal extern static void glResolveMultisampleFramebufferAPPLE();

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleAPPLE(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleAPPLE pglRenderbufferStorageMultisampleAPPLE;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResolveMultisampleFramebufferAPPLE();

			[ThreadStatic]
			internal static glResolveMultisampleFramebufferAPPLE pglResolveMultisampleFramebufferAPPLE;

		}
	}

}
