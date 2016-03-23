
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
		/// Binding for glClipPlanefIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		public static void ClipPlaneIMG(Int32 p, float[] eqn)
		{
			unsafe {
				fixed (float* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanefIMG != null, "pglClipPlanefIMG not implemented");
					Delegates.pglClipPlanefIMG(p, p_eqn);
					LogFunction("glClipPlanefIMG({0}, {1})", LogEnumName(p), LogValue(eqn));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClipPlanexIMG.
		/// </summary>
		/// <param name="p">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="eqn">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		public static void ClipPlaneIMG(Int32 p, IntPtr[] eqn)
		{
			unsafe {
				fixed (IntPtr* p_eqn = eqn)
				{
					Debug.Assert(Delegates.pglClipPlanexIMG != null, "pglClipPlanexIMG not implemented");
					Delegates.pglClipPlanexIMG(p, p_eqn);
					LogFunction("glClipPlanexIMG({0}, {1})", LogEnumName(p), LogValue(eqn));
				}
			}
			DebugCheckErrors(null);
		}

	}

}
