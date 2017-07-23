
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
		/// [GL] Value of GL_PREFER_DOUBLEBUFFER_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8;

		/// <summary>
		/// [GL] Value of GL_CONSERVE_MEMORY_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int CONSERVE_MEMORY_HINT_PGI = 0x1A1FD;

		/// <summary>
		/// [GL] Value of GL_RECLAIM_MEMORY_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int RECLAIM_MEMORY_HINT_PGI = 0x1A1FE;

		/// <summary>
		/// [GL] Value of GL_NATIVE_GRAPHICS_HANDLE_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int NATIVE_GRAPHICS_HANDLE_PGI = 0x1A202;

		/// <summary>
		/// [GL] Value of GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203;

		/// <summary>
		/// [GL] Value of GL_NATIVE_GRAPHICS_END_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204;

		/// <summary>
		/// [GL] Value of GL_ALWAYS_FAST_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALWAYS_FAST_HINT_PGI = 0x1A20C;

		/// <summary>
		/// [GL] Value of GL_ALWAYS_SOFT_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALWAYS_SOFT_HINT_PGI = 0x1A20D;

		/// <summary>
		/// [GL] Value of GL_ALLOW_DRAW_OBJ_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E;

		/// <summary>
		/// [GL] Value of GL_ALLOW_DRAW_WIN_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F;

		/// <summary>
		/// [GL] Value of GL_ALLOW_DRAW_FRG_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALLOW_DRAW_FRG_HINT_PGI = 0x1A210;

		/// <summary>
		/// [GL] Value of GL_ALLOW_DRAW_MEM_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int ALLOW_DRAW_MEM_HINT_PGI = 0x1A211;

		/// <summary>
		/// [GL] Value of GL_STRICT_DEPTHFUNC_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int STRICT_DEPTHFUNC_HINT_PGI = 0x1A216;

		/// <summary>
		/// [GL] Value of GL_STRICT_LIGHTING_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int STRICT_LIGHTING_HINT_PGI = 0x1A217;

		/// <summary>
		/// [GL] Value of GL_STRICT_SCISSOR_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int STRICT_SCISSOR_HINT_PGI = 0x1A218;

		/// <summary>
		/// [GL] Value of GL_FULL_STIPPLE_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int FULL_STIPPLE_HINT_PGI = 0x1A219;

		/// <summary>
		/// [GL] Value of GL_CLIP_NEAR_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int CLIP_NEAR_HINT_PGI = 0x1A220;

		/// <summary>
		/// [GL] Value of GL_CLIP_FAR_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int CLIP_FAR_HINT_PGI = 0x1A221;

		/// <summary>
		/// [GL] Value of GL_WIDE_LINE_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int WIDE_LINE_HINT_PGI = 0x1A222;

		/// <summary>
		/// [GL] Value of GL_BACK_NORMALS_HINT_PGI symbol.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public const int BACK_NORMALS_HINT_PGI = 0x1A223;

		/// <summary>
		/// [GL] Binding for glHintPGI.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_PGI_misc_hints")]
		public static void HintPGI(Int32 target, Int32 mode)
		{
			Debug.Assert(Delegates.pglHintPGI != null, "pglHintPGI not implemented");
			Delegates.pglHintPGI(target, mode);
			LogCommand("glHintPGI", null, target, mode			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glHintPGI", ExactSpelling = true)]
			internal extern static void glHintPGI(Int32 target, Int32 mode);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_PGI_misc_hints")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glHintPGI(Int32 target, Int32 mode);

			[RequiredByFeature("GL_PGI_misc_hints")]
			[ThreadStatic]
			internal static glHintPGI pglHintPGI;

		}
	}

}
