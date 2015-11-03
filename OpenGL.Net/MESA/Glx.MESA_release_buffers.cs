
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
		/// Binding for glXReleaseBuffersMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_release_buffers")]
		public static bool ReleaseBuffersMESA(IntPtr dpy, IntPtr drawable)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXReleaseBuffersMESA != null, "pglXReleaseBuffersMESA not implemented");
			retValue = Delegates.pglXReleaseBuffersMESA(dpy, drawable);
			CallLog("glXReleaseBuffersMESA(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), drawable.ToString("X8"), retValue);

			return (retValue);
		}

	}

}
