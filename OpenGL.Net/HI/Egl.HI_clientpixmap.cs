
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
	public partial class Egl
	{
		/// <summary>
		/// [EGL] Value of EGL_CLIENT_PIXMAP_POINTER_HI symbol.
		/// </summary>
		[RequiredByFeature("EGL_HI_clientpixmap")]
		public const int CLIENT_PIXMAP_POINTER_HI = 0x8F74;

		/// <summary>
		/// Binding for eglCreatePixmapSurfaceHI.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:ClientPixmap[]"/>.
		/// </param>
		[RequiredByFeature("EGL_HI_clientpixmap")]
		public static IntPtr CreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap[] pixmap)
		{
			IntPtr retValue;

			unsafe {
				fixed (ClientPixmap* p_pixmap = pixmap)
				{
					Debug.Assert(Delegates.peglCreatePixmapSurfaceHI != null, "peglCreatePixmapSurfaceHI not implemented");
					retValue = Delegates.peglCreatePixmapSurfaceHI(dpy, config, p_pixmap);
					LogCommand("eglCreatePixmapSurfaceHI", retValue, dpy, config, pixmap					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglCreatePixmapSurfaceHI", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_HI_clientpixmap")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

			internal static eglCreatePixmapSurfaceHI peglCreatePixmapSurfaceHI;

		}
	}

}
