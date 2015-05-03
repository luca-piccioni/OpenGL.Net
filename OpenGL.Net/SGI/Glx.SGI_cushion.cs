
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
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXCushionSGI.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="cushion">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GLX_SGI_cushion")]
		public static void CushionSGI(IntPtr dpy, IntPtr window, float cushion)
		{
			Debug.Assert(Delegates.pglXCushionSGI != null, "pglXCushionSGI not implemented");
			Delegates.pglXCushionSGI(dpy, window, cushion);
			CallLog("glXCushionSGI(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), window.ToString("X8"), cushion);
		}

	}

}
