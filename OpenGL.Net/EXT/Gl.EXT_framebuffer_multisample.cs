
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
		/// Value of GL_RENDERBUFFER_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		public const int RENDERBUFFER_SAMPLES_EXT = 0x8CAB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT = 0x8D56;

		/// <summary>
		/// Value of GL_MAX_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		public const int MAX_SAMPLES_EXT = 0x8D57;

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		public static void RenderbufferStorageMultisampleEXT(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleEXT != null, "pglRenderbufferStorageMultisampleEXT not implemented");
			Delegates.pglRenderbufferStorageMultisampleEXT(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisampleEXT({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

	}

}
