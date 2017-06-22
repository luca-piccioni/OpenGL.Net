
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
	public partial class Glx
	{
		/// <summary>
		/// [GLX] Binding for glXCreateGLXPixmapMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="cmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_pixmap_colormap")]
		public static IntPtr CreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXPixmapMESA != null, "pglXCreateGLXPixmapMESA not implemented");
			retValue = Delegates.pglXCreateGLXPixmapMESA(dpy, visual, pixmap, cmap);
			LogCommand("glXCreateGLXPixmapMESA", retValue, dpy, visual, pixmap, cmap			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapMESA", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_MESA_pixmap_colormap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);

			[RequiredByFeature("GLX_MESA_pixmap_colormap")]
			internal static glXCreateGLXPixmapMESA pglXCreateGLXPixmapMESA;

		}
	}

}
