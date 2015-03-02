
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
		/// Value of GL_RGBA_FLOAT_MODE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int RGBA_FLOAT_MODE_ARB = 0x8820;

		/// <summary>
		/// Value of GL_CLAMP_VERTEX_COLOR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int CLAMP_VERTEX_COLOR_ARB = 0x891A;

		/// <summary>
		/// Value of GL_CLAMP_FRAGMENT_COLOR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int CLAMP_FRAGMENT_COLOR_ARB = 0x891B;

		/// <summary>
		/// Value of GL_CLAMP_READ_COLOR_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int CLAMP_READ_COLOR_ARB = 0x891C;

		/// <summary>
		/// Value of GL_FIXED_ONLY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_color_buffer_float")]
		public const int FIXED_ONLY_ARB = 0x891D;

		/// <summary>
		/// Binding for glClampColorARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="clamp">
		/// A <see cref="T:int"/>.
		/// </param>
		public static void ClampColorARB(int target, int clamp)
		{
			Debug.Assert(Delegates.pglClampColorARB != null, "pglClampColorARB not implemented");
			Delegates.pglClampColorARB(target, clamp);
			CallLog("glClampColorARB({0}, {1})", target, clamp);
			DebugCheckErrors();
		}

	}

}
