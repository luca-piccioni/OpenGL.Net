
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
	public partial class Gl
	{
		/// <summary>
		/// Binding for glDrawBuffersNV.
		/// </summary>
		/// <param name="bufs">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		public static void DrawBuffersNV(Int32[] bufs)
		{
			unsafe {
				fixed (Int32* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersNV != null, "pglDrawBuffersNV not implemented");
					Delegates.pglDrawBuffersNV((Int32)bufs.Length, p_bufs);
					LogFunction("glDrawBuffersNV({0}, {1})", bufs.Length, LogEnumName(bufs));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
