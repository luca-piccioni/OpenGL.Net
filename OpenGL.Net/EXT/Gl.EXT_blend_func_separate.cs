
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
		/// Value of GL_BLEND_DST_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		public const int BLEND_DST_RGB_EXT = 0x80C8;

		/// <summary>
		/// Value of GL_BLEND_SRC_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		public const int BLEND_SRC_RGB_EXT = 0x80C9;

		/// <summary>
		/// Value of GL_BLEND_DST_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		public const int BLEND_DST_ALPHA_EXT = 0x80CA;

		/// <summary>
		/// Value of GL_BLEND_SRC_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_func_separate")]
		public const int BLEND_SRC_ALPHA_EXT = 0x80CB;

		/// <summary>
		/// Binding for glBlendFuncSeparateEXT.
		/// </summary>
		/// <param name="sfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorRGB">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="sfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="dfactorAlpha">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void BlendFuncSeparateEXT(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha)
		{
			Debug.Assert(Delegates.pglBlendFuncSeparateEXT != null, "pglBlendFuncSeparateEXT not implemented");
			Delegates.pglBlendFuncSeparateEXT(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			CallLog("glBlendFuncSeparateEXT({0}, {1}, {2}, {3})", sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			DebugCheckErrors();
		}

	}

}
