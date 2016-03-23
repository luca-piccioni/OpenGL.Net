
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
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_SAMPLES_EXT = 0x8D6C;

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textarget">
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
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void FramebufferTexture2DMultisampleEXT(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleEXT != null, "pglFramebufferTexture2DMultisampleEXT not implemented");
			Delegates.pglFramebufferTexture2DMultisampleEXT(target, attachment, textarget, texture, level, samples);
			LogFunction("glFramebufferTexture2DMultisampleEXT({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(attachment), LogEnumName(textarget), texture, level, samples);
			DebugCheckErrors(null);
		}

	}

}
