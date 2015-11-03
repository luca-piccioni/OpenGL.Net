
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXCreateGLXPixmapMESA.
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
			CallLog("glXCreateGLXPixmapMESA(0x{0}, {1}, 0x{2}, 0x{3}) = {4}", dpy.ToString("X8"), visual, pixmap.ToString("X8"), cmap.ToString("X8"), retValue.ToString("X8"));

			return (retValue);
		}

	}

}
