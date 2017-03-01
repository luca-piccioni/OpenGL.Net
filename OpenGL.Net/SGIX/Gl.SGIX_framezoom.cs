
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_FRAMEZOOM_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		public const int FRAMEZOOM_SGIX = 0x818B;

		/// <summary>
		/// Value of GL_FRAMEZOOM_FACTOR_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		public const int FRAMEZOOM_FACTOR_SGIX = 0x818C;

		/// <summary>
		/// Value of GL_MAX_FRAMEZOOM_FACTOR_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		public const int MAX_FRAMEZOOM_FACTOR_SGIX = 0x818D;

		/// <summary>
		/// Binding for glFrameZoomSGIX.
		/// </summary>
		/// <param name="factor">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_framezoom")]
		public static void FrameZoomSGIX(Int32 factor)
		{
			Debug.Assert(Delegates.pglFrameZoomSGIX != null, "pglFrameZoomSGIX not implemented");
			Delegates.pglFrameZoomSGIX(factor);
			LogFunction("glFrameZoomSGIX({0})", factor);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrameZoomSGIX", ExactSpelling = true)]
			internal extern static void glFrameZoomSGIX(Int32 factor);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIX_framezoom")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrameZoomSGIX(Int32 factor);

			[ThreadStatic]
			internal static glFrameZoomSGIX pglFrameZoomSGIX;

		}
	}

}
