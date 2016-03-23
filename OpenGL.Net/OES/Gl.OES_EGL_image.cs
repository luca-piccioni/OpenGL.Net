
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
		/// Binding for glEGLImageTargetTexture2DOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetTexture2DOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetTexture2DOES != null, "pglEGLImageTargetTexture2DOES not implemented");
			Delegates.pglEGLImageTargetTexture2DOES(target, image);
			LogFunction("glEGLImageTargetTexture2DOES({0}, 0x{1})", LogEnumName(target), image.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEGLImageTargetRenderbufferStorageOES.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_OES_EGL_image", Api = "gles1|gles2")]
		public static void EGLImageTargetRenderbufferStorageOES(Int32 target, IntPtr image)
		{
			Debug.Assert(Delegates.pglEGLImageTargetRenderbufferStorageOES != null, "pglEGLImageTargetRenderbufferStorageOES not implemented");
			Delegates.pglEGLImageTargetRenderbufferStorageOES(target, image);
			LogFunction("glEGLImageTargetRenderbufferStorageOES({0}, 0x{1})", LogEnumName(target), image.ToString("X8"));
			DebugCheckErrors(null);
		}

	}

}
