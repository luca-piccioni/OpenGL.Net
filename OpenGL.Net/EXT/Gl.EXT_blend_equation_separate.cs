
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
		/// Value of GL_BLEND_EQUATION_RGB_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		public const int BLEND_EQUATION_RGB_EXT = 0x8009;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		public const int BLEND_EQUATION_ALPHA_EXT = 0x883D;

		/// <summary>
		/// Binding for glBlendEquationSeparateEXT.
		/// </summary>
		/// <param name="modeRGB">
		/// A <see cref="T:BlendEquationModeEXT"/>.
		/// </param>
		/// <param name="modeAlpha">
		/// A <see cref="T:BlendEquationModeEXT"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_equation_separate")]
		public static void BlendEquationSeparateEXT(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
		{
			Debug.Assert(Delegates.pglBlendEquationSeparateEXT != null, "pglBlendEquationSeparateEXT not implemented");
			Delegates.pglBlendEquationSeparateEXT((int)modeRGB, (int)modeAlpha);
			CallLog("glBlendEquationSeparateEXT({0}, {1})", modeRGB, modeAlpha);
			DebugCheckErrors();
		}

	}

}
