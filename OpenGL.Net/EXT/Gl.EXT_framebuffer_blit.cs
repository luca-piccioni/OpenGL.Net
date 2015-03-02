
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
		/// Value of GL_READ_FRAMEBUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		public const int READ_FRAMEBUFFER_EXT = 0x8CA8;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		public const int DRAW_FRAMEBUFFER_EXT = 0x8CA9;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		public const int DRAW_FRAMEBUFFER_BINDING_EXT = 0x8CA6;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		public const int READ_FRAMEBUFFER_BINDING_EXT = 0x8CAA;

		/// <summary>
		/// Binding for glBlitFramebufferEXT.
		/// </summary>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebufferEXT != null, "pglBlitFramebufferEXT not implemented");
			Delegates.pglBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			CallLog("glBlitFramebufferEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlitFramebufferEXT.
		/// </summary>
		/// <param name="srcX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="srcY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY0">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstX1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="dstY1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="filter">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebufferEXT != null, "pglBlitFramebufferEXT not implemented");
			Delegates.pglBlitFramebufferEXT(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
			CallLog("glBlitFramebufferEXT({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

	}

}
