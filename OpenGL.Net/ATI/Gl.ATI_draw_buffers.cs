
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
		/// Value of GL_MAX_DRAW_BUFFERS_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int MAX_DRAW_BUFFERS_ATI = 0x8824;

		/// <summary>
		/// Value of GL_DRAW_BUFFER0_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER0_ATI = 0x8825;

		/// <summary>
		/// Value of GL_DRAW_BUFFER1_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER1_ATI = 0x8826;

		/// <summary>
		/// Value of GL_DRAW_BUFFER2_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER2_ATI = 0x8827;

		/// <summary>
		/// Value of GL_DRAW_BUFFER3_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER3_ATI = 0x8828;

		/// <summary>
		/// Value of GL_DRAW_BUFFER4_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER4_ATI = 0x8829;

		/// <summary>
		/// Value of GL_DRAW_BUFFER5_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER5_ATI = 0x882A;

		/// <summary>
		/// Value of GL_DRAW_BUFFER6_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER6_ATI = 0x882B;

		/// <summary>
		/// Value of GL_DRAW_BUFFER7_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER7_ATI = 0x882C;

		/// <summary>
		/// Value of GL_DRAW_BUFFER8_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER8_ATI = 0x882D;

		/// <summary>
		/// Value of GL_DRAW_BUFFER9_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER9_ATI = 0x882E;

		/// <summary>
		/// Value of GL_DRAW_BUFFER10_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER10_ATI = 0x882F;

		/// <summary>
		/// Value of GL_DRAW_BUFFER11_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER11_ATI = 0x8830;

		/// <summary>
		/// Value of GL_DRAW_BUFFER12_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER12_ATI = 0x8831;

		/// <summary>
		/// Value of GL_DRAW_BUFFER13_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER13_ATI = 0x8832;

		/// <summary>
		/// Value of GL_DRAW_BUFFER14_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER14_ATI = 0x8833;

		/// <summary>
		/// Value of GL_DRAW_BUFFER15_ATI symbol.
		/// </summary>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public const int DRAW_BUFFER15_ATI = 0x8834;

		/// <summary>
		/// Binding for glDrawBuffersATI.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufs">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_draw_buffers")]
		public static void DrawBuffersATI(params int[] bufs)
		{
			unsafe {
				fixed (int* p_bufs = bufs)
				{
					Debug.Assert(Delegates.pglDrawBuffersATI != null, "pglDrawBuffersATI not implemented");
					Delegates.pglDrawBuffersATI((Int32)bufs.Length, p_bufs);
					CallLog("glDrawBuffersATI({0}, {1})", bufs.Length, bufs);
				}
			}
			DebugCheckErrors();
		}

	}

}
