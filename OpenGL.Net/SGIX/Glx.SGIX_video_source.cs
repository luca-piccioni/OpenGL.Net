
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
		/// Binding for glXCreateGLXVideoSourceSGIX.
		/// </summary>
		/// <param name="display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="server">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="path">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="nodeClass">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="drainNode">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_source")]
		public static IntPtr CreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXVideoSourceSGIX != null, "pglXCreateGLXVideoSourceSGIX not implemented");
			retValue = Delegates.pglXCreateGLXVideoSourceSGIX(display, screen, server, path, nodeClass, drainNode);
			CallLog("glXCreateGLXVideoSourceSGIX(0x{0}, {1}, 0x{2}, 0x{3}, {4}, 0x{5}) = {6}", display.ToString("X8"), screen, server.ToString("X8"), path.ToString("X8"), nodeClass, drainNode.ToString("X8"), retValue.ToString("X8"));

			return (retValue);
		}

		/// <summary>
		/// Binding for glXDestroyGLXVideoSourceSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="glxvideosource">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_video_source")]
		public static void DestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource)
		{
			Debug.Assert(Delegates.pglXDestroyGLXVideoSourceSGIX != null, "pglXDestroyGLXVideoSourceSGIX not implemented");
			Delegates.pglXDestroyGLXVideoSourceSGIX(dpy, glxvideosource);
			CallLog("glXDestroyGLXVideoSourceSGIX(0x{0}, 0x{1})", dpy.ToString("X8"), glxvideosource.ToString("X8"));
		}

	}

}
