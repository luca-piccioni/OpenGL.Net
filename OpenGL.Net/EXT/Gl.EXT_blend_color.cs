
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
		/// Value of GL_CONSTANT_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int CONSTANT_COLOR_EXT = 0x8001;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int ONE_MINUS_CONSTANT_COLOR_EXT = 0x8002;

		/// <summary>
		/// Value of GL_CONSTANT_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int CONSTANT_ALPHA_EXT = 0x8003;

		/// <summary>
		/// Value of GL_ONE_MINUS_CONSTANT_ALPHA_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int ONE_MINUS_CONSTANT_ALPHA_EXT = 0x8004;

		/// <summary>
		/// Value of GL_BLEND_COLOR_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_blend_color")]
		public const int BLEND_COLOR_EXT = 0x8005;

		/// <summary>
		/// Binding for glBlendColorEXT.
		/// </summary>
		/// <param name="red">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="green">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="blue">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="alpha">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_blend_color")]
		public static void BlendColorEXT(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglBlendColorEXT != null, "pglBlendColorEXT not implemented");
			Delegates.pglBlendColorEXT(red, green, blue, alpha);
			CallLog("glBlendColorEXT({0}, {1}, {2}, {3})", red, green, blue, alpha);
			DebugCheckErrors();
		}

	}

}
