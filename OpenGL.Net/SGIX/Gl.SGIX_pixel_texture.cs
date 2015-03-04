
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
		/// Value of GL_PIXEL_TEX_GEN_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		public const int PIXEL_TEX_GEN_SGIX = 0x8139;

		/// <summary>
		/// Value of GL_PIXEL_TEX_GEN_MODE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		public const int PIXEL_TEX_GEN_MODE_SGIX = 0x832B;

		/// <summary>
		/// Binding for glPixelTexGenSGIX.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		public static void PixelTexGenSGIX(int mode)
		{
			Debug.Assert(Delegates.pglPixelTexGenSGIX != null, "pglPixelTexGenSGIX not implemented");
			Delegates.pglPixelTexGenSGIX(mode);
			CallLog("glPixelTexGenSGIX({0})", mode);
			DebugCheckErrors();
		}

	}

}
