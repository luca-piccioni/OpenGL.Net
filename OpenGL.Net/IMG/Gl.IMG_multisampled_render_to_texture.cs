
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_RENDERBUFFER_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int RENDERBUFFER_SAMPLES_IMG = 0x9133;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134;

		/// <summary>
		/// [GL] Value of GL_MAX_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int MAX_SAMPLES_IMG = 0x9135;

		/// <summary>
		/// [GL] Value of GL_TEXTURE_SAMPLES_IMG symbol.
		/// </summary>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public const int TEXTURE_SAMPLES_IMG = 0x9136;

		/// <summary>
		/// Binding for glRenderbufferStorageMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:RenderbufferTarget"/>.
		/// </param>
		/// <param name="samples">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:InternalFormat"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void RenderbufferStorageMultisampleIMG(RenderbufferTarget target, Int32 samples, InternalFormat internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisampleIMG != null, "pglRenderbufferStorageMultisampleIMG not implemented");
			Delegates.pglRenderbufferStorageMultisampleIMG((Int32)target, samples, (Int32)internalformat, width, height);
			LogCommand("glRenderbufferStorageMultisampleIMG", null, target, samples, internalformat, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferTexture2DMultisampleIMG.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="textarget">
		/// A <see cref="T:TextureTarget"/>.
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
		[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
		public static void FramebufferTexture2DMultisampleIMG(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, UInt32 texture, Int32 level, Int32 samples)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2DMultisampleIMG != null, "pglFramebufferTexture2DMultisampleIMG not implemented");
			Delegates.pglFramebufferTexture2DMultisampleIMG((Int32)target, (Int32)attachment, (Int32)textarget, texture, level, samples);
			LogCommand("glFramebufferTexture2DMultisampleIMG", null, target, attachment, textarget, texture, level, samples			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderbufferStorageMultisampleIMG", ExactSpelling = true)]
			internal extern static void glRenderbufferStorageMultisampleIMG(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTexture2DMultisampleIMG", ExactSpelling = true)]
			internal extern static void glFramebufferTexture2DMultisampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRenderbufferStorageMultisampleIMG(Int32 target, Int32 samples, Int32 internalformat, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glRenderbufferStorageMultisampleIMG pglRenderbufferStorageMultisampleIMG;

			[RequiredByFeature("GL_IMG_multisampled_render_to_texture", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTexture2DMultisampleIMG(Int32 target, Int32 attachment, Int32 textarget, UInt32 texture, Int32 level, Int32 samples);

			[ThreadStatic]
			internal static glFramebufferTexture2DMultisampleIMG pglFramebufferTexture2DMultisampleIMG;

		}
	}

}
