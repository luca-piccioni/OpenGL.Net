
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
		/// Binding for glFramebufferTextureMultisampleMultiviewOVR.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseViewIndex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numViews">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OVR_multiview_multisampled_render_to_texture", Api = "gles2")]
		public static void FramebufferTextureMultisampleMultiOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 samples, Int32 baseViewIndex, Int32 numViews)
		{
			Debug.Assert(Delegates.pglFramebufferTextureMultisampleMultiviewOVR != null, "pglFramebufferTextureMultisampleMultiviewOVR not implemented");
			Delegates.pglFramebufferTextureMultisampleMultiviewOVR(target, attachment, texture, level, samples, baseViewIndex, numViews);
			LogFunction("glFramebufferTextureMultisampleMultiviewOVR({0}, {1}, {2}, {3}, {4}, {5}, {6})", LogEnumName(target), LogEnumName(attachment), texture, level, samples, baseViewIndex, numViews);
			DebugCheckErrors(null);
		}

	}

}
