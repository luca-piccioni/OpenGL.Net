
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
		/// Binding for eglStreamConsumerOutputEXT.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="stream">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_EXT_stream_consumer_egloutput")]
		public static bool StreamConsumerOutputEXT(IntPtr dpy, IntPtr stream, IntPtr layer)
		{
			bool retValue;

			Debug.Assert(Delegates.peglStreamConsumerOutputEXT != null, "peglStreamConsumerOutputEXT not implemented");
			retValue = Delegates.peglStreamConsumerOutputEXT(dpy, stream, layer);
			LogFunction("eglStreamConsumerOutputEXT(0x{0}, 0x{1}, 0x{2}) = {3}", dpy.ToString("X8"), stream.ToString("X8"), layer.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
