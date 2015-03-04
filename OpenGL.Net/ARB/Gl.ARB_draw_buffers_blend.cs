
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
		/// Binding for glBlendEquationiARB.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers_blend")]
		public static void BlendEquationARB(UInt32 buf, int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationiARB != null, "pglBlendEquationiARB not implemented");
			Delegates.pglBlendEquationiARB(buf, mode);
			CallLog("glBlendEquationiARB({0}, {1})", buf, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationSeparateiARB.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="modeRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers_blend")]
		public static void BlendEquationSeparateiARB(UInt32 buf, int modeRGB, int modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateiARB != null, "pglBlendEquationSeparateiARB not implemented");
			Delegates.pglBlendEquationSeparateiARB(buf, modeRGB, modeAlpha);
			CallLog("glBlendEquationSeparateiARB({0}, {1}, {2})", buf, modeRGB, modeAlpha);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFunciARB.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="src">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dst">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers_blend")]
		public static void BlendFunciARB(UInt32 buf, int src, int dst)
		{
			Debug.Assert(Delegates.pglBlendFunciARB != null, "pglBlendFunciARB not implemented");
			Delegates.pglBlendFunciARB(buf, src, dst);
			CallLog("glBlendFunciARB({0}, {1}, {2})", buf, src, dst);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendFuncSeparateiARB.
		/// </summary>
		/// <param name="buf">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="srcRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="srcAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dstAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers_blend")]
		public static void BlendFuncSeparateiARB(UInt32 buf, int srcRGB, int dstRGB, int srcAlpha, int dstAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateiARB != null, "pglBlendFuncSeparateiARB not implemented");
			Delegates.pglBlendFuncSeparateiARB(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			CallLog("glBlendFuncSeparateiARB({0}, {1}, {2}, {3}, {4})", buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			DebugCheckErrors();
		}

	}

}
