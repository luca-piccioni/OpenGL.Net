
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
		/// Value of GL_MAX_DRAW_BUFFERS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int MAX_DRAW_BUFFERS_ARB = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER0_ARB = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER1_ARB = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER2_ARB = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER3_ARB = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER4_ARB = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER5_ARB = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER6_ARB = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER7_ARB = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER8_ARB = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER9_ARB = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER10_ARB = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER11_ARB = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER12_ARB = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER13_ARB = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER14_ARB = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public const int DRAW_BUFFER15_ARB = 0x8834;

		/// <summary>
		/// Binding for glDrawBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public static void DrawBuffersARB(Int32 n, int[] bufs)
		{
			Debug.Assert(bufs.Length >= n);
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersARB != null, "pglDrawBuffersARB not implemented");
					Delegates.pglDrawBuffersARB(n, p_bufs);
					CallLog("glDrawBuffersARB({0}, {1})", n, bufs);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDrawBuffersARB.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_draw_buffers")]
		public static void DrawBuffersARB(int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersARB != null, "pglDrawBuffersARB not implemented");
					Delegates.pglDrawBuffersARB((Int32)bufs.Length, p_bufs);
					CallLog("glDrawBuffersARB({0}, {1})", bufs.Length, bufs);
				}
			}
			DebugCheckErrors();
		}

	}

}
