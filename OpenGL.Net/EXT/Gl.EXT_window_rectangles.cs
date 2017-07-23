
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
		/// [GL] Value of GL_INCLUSIVE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int INCLUSIVE_EXT = 0x8F10;

		/// <summary>
		/// [GL] Value of GL_EXCLUSIVE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int EXCLUSIVE_EXT = 0x8F11;

		/// <summary>
		/// [GL] Value of GL_WINDOW_RECTANGLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int WINDOW_RECTANGLE_EXT = 0x8F12;

		/// <summary>
		/// [GL] Value of GL_WINDOW_RECTANGLE_MODE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int WINDOW_RECTANGLE_MODE_EXT = 0x8F13;

		/// <summary>
		/// [GL] Value of GL_MAX_WINDOW_RECTANGLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int MAX_WINDOW_RECTANGLES_EXT = 0x8F14;

		/// <summary>
		/// [GL] Value of GL_NUM_WINDOW_RECTANGLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public const int NUM_WINDOW_RECTANGLES_EXT = 0x8F15;

		/// <summary>
		/// [GL] Binding for glWindowRectanglesEXT.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="box">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
		public static void WindowRectanglesEXT(Int32 mode, Int32 count, Int32[] box)
		{
			unsafe {
				fixed (Int32* p_box = box)
				{
					Debug.Assert(Delegates.pglWindowRectanglesEXT != null, "pglWindowRectanglesEXT not implemented");
					Delegates.pglWindowRectanglesEXT(mode, count, p_box);
					LogCommand("glWindowRectanglesEXT", null, mode, count, box					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glWindowRectanglesEXT", ExactSpelling = true)]
			internal extern static unsafe void glWindowRectanglesEXT(Int32 mode, Int32 count, Int32* box);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glWindowRectanglesEXT(Int32 mode, Int32 count, Int32* box);

			[RequiredByFeature("GL_EXT_window_rectangles", Api = "gl|glcore|gles2")]
			[ThreadStatic]
			internal static glWindowRectanglesEXT pglWindowRectanglesEXT;

		}
	}

}
