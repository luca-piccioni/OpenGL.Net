
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
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_NUM_VIEWS_OVR = 0x9630;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|gles2")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_BASE_VIEW_INDEX_OVR = 0x9632;

		/// <summary>
		/// Value of GL_MAX_VIEWS_OVR symbol.
		/// </summary>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|gles2")]
		public const int MAX_VIEWS_OVR = 0x9631;

		/// <summary>
		/// Binding for glFramebufferTextureMultiviewOVR.
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
		/// <param name="baseViewIndex">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numViews">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_OVR_multiview", Api = "gl|gles2")]
		public static void FramebufferTextureMultiOVR(Int32 target, Int32 attachment, UInt32 texture, Int32 level, Int32 baseViewIndex, Int32 numViews)
		{
			Debug.Assert(Delegates.pglFramebufferTextureMultiviewOVR != null, "pglFramebufferTextureMultiviewOVR not implemented");
			Delegates.pglFramebufferTextureMultiviewOVR(target, attachment, texture, level, baseViewIndex, numViews);
			LogFunction("glFramebufferTextureMultiviewOVR({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(attachment), texture, level, baseViewIndex, numViews);
			DebugCheckErrors(null);
		}

	}

}
