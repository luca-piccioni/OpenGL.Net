
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
		/// Value of GL_STENCIL_TAG_BITS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_clear_tag")]
		public const int STENCIL_TAG_BITS_EXT = 0x88F2;

		/// <summary>
		/// Value of GL_STENCIL_CLEAR_TAG_VALUE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_stencil_clear_tag")]
		public const int STENCIL_CLEAR_TAG_VALUE_EXT = 0x88F3;

		/// <summary>
		/// Binding for glStencilClearTagEXT.
		/// </summary>
		/// <param name="stencilTagBits">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="stencilClearTag">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_stencil_clear_tag")]
		public static void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag)
		{
			Debug.Assert(Delegates.pglStencilClearTagEXT != null, "pglStencilClearTagEXT not implemented");
			Delegates.pglStencilClearTagEXT(stencilTagBits, stencilClearTag);
			LogFunction("glStencilClearTagEXT({0}, {1})", stencilTagBits, stencilClearTag);
			DebugCheckErrors(null);
		}

	}

}
