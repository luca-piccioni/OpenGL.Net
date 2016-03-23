
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

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_CLIENT_PIXMAP_POINTER_HI symbol.
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
					LogFunction("eglCreatePixmapSurfaceHI(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), config.ToString("X8"), LogValue(pixmap), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
