
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
		/// Value of GL_MIN_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public const int MIN_EXT = 0x8007;

		/// <summary>
		/// Value of GL_MAX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public const int MAX_EXT = 0x8008;

		/// <summary>
		/// Value of GL_FUNC_ADD_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public const int FUNC_ADD_EXT = 0x8006;

		/// <summary>
		/// Value of GL_BLEND_EQUATION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public const int BLEND_EQUATION_EXT = 0x8009;

		/// <summary>
		/// Binding for glBlendEquationEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public static void BlendEquationEXT(int mode)
		{
			Debug.Assert(Delegates.pglBlendEquationEXT != null, "pglBlendEquationEXT not implemented");
			Delegates.pglBlendEquationEXT(mode);
			CallLog("glBlendEquationEXT({0})", mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glBlendEquationEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:BlendEquationModeEXT"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_minmax")]
		public static void BlendEquationEXT(BlendEquationModeEXT mode)
		{
			Debug.Assert(Delegates.pglBlendEquationEXT != null, "pglBlendEquationEXT not implemented");
			Delegates.pglBlendEquationEXT((int)mode);
			CallLog("glBlendEquationEXT({0})", mode);
			DebugCheckErrors();
		}

	}

}
