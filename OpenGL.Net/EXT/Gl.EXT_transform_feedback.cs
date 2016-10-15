
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Binding for glBindBufferOffsetEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("glBindBufferOffsetNV")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		public static void BindBufferOffsetEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset)
		{
			Debug.Assert(Delegates.pglBindBufferOffsetEXT != null, "pglBindBufferOffsetEXT not implemented");
			Delegates.pglBindBufferOffsetEXT(target, index, buffer, offset);
			LogFunction("glBindBufferOffsetEXT({0}, {1}, {2}, 0x{3})", LogEnumName(target), index, buffer, offset.ToString("X8"));
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBindBufferOffsetEXT", ExactSpelling = true)]
			internal extern static unsafe void glBindBufferOffsetEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBindBufferOffsetEXT(Int32 target, UInt32 index, UInt32 buffer, IntPtr offset);

			[AliasOf("glBindBufferOffsetEXT")]
			[AliasOf("glBindBufferOffsetNV")]
			[ThreadStatic]
			internal static glBindBufferOffsetEXT pglBindBufferOffsetEXT;

		}
	}

}
