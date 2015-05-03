
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
		/// Binding for glXJoinSwapGroupSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="member">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_swap_group")]
		public static void JoinSwapGroupSGIX(IntPtr dpy, IntPtr drawable, IntPtr member)
		{
			Debug.Assert(Delegates.pglXJoinSwapGroupSGIX != null, "pglXJoinSwapGroupSGIX not implemented");
			Delegates.pglXJoinSwapGroupSGIX(dpy, drawable, member);
			CallLog("glXJoinSwapGroupSGIX(0x{0}, 0x{1}, 0x{2})", dpy.ToString("X8"), drawable.ToString("X8"), member.ToString("X8"));
		}

	}

}
