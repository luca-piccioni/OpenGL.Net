
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
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;

		/// <summary>
		/// [GL] Value of GL_MAX_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int MAX_VIEWS_OVR = 0x9631;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_INCOMPLETE_VIEW_TARGETS_OVR = 0x9633;

		/// <summary>
		/// Binding for glFramebufferTextureMultiviewOVR.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="T:FramebufferAttachment"/>.
		/// </param>
		/// <param name="texture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="baseViewIndex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numViews">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
		public static void FramebufferTextureMultiOVR(FramebufferTarget target, FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews)
		{
			Debug.Assert(Delegates.pglFramebufferTextureMultiviewOVR != null, "pglFramebufferTextureMultiviewOVR not implemented");
			Delegates.pglFramebufferTextureMultiviewOVR((Int32)target, (Int32)attachment, texture, level, baseViewIndex, numViews);
			LogCommand("glFramebufferTextureMultiviewOVR", null, target, attachment, texture, level, baseViewIndex, numViews			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferTextureMultiviewOVR", ExactSpelling = true)]
			internal extern static void glFramebufferTextureMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OVR_multiview", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferTextureMultiviewOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews);

			[ThreadStatic]
			internal static glFramebufferTextureMultiviewOVR pglFramebufferTextureMultiviewOVR;

		}
	}

}
