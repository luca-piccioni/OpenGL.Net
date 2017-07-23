
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
		/// [GL] Binding for glCopyTextureLevelsAPPLE.
		/// </summary>
		/// <param name="destinationTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceTexture">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="sourceBaseLevel">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="sourceLevelCount">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
		public static void CopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount)
		{
			Debug.Assert(Delegates.pglCopyTextureLevelsAPPLE != null, "pglCopyTextureLevelsAPPLE not implemented");
			Delegates.pglCopyTextureLevelsAPPLE(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);
			LogCommand("glCopyTextureLevelsAPPLE", null, destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glCopyTextureLevelsAPPLE", ExactSpelling = true)]
			internal extern static void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glCopyTextureLevelsAPPLE(UInt32 destinationTexture, UInt32 sourceTexture, Int32 sourceBaseLevel, Int32 sourceLevelCount);

			[RequiredByFeature("GL_APPLE_copy_texture_levels", Api = "gles1|gles2")]
			[ThreadStatic]
			internal static glCopyTextureLevelsAPPLE pglCopyTextureLevelsAPPLE;

		}
	}

}
