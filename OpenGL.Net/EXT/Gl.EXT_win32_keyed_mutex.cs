
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
		/// Binding for glAcquireKeyedMutexWin32EXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
		public static bool AcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout)
		{
			bool retValue;

			Debug.Assert(Delegates.pglAcquireKeyedMutexWin32EXT != null, "pglAcquireKeyedMutexWin32EXT not implemented");
			retValue = Delegates.pglAcquireKeyedMutexWin32EXT(memory, key, timeout);
			LogCommand("glAcquireKeyedMutexWin32EXT", retValue, memory, key, timeout			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glReleaseKeyedMutexWin32EXT.
		/// </summary>
		/// <param name="memory">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="key">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
		public static bool ReleaseKeyedEXT(UInt32 memory, UInt64 key)
		{
			bool retValue;

			Debug.Assert(Delegates.pglReleaseKeyedMutexWin32EXT != null, "pglReleaseKeyedMutexWin32EXT not implemented");
			retValue = Delegates.pglReleaseKeyedMutexWin32EXT(memory, key);
			LogCommand("glReleaseKeyedMutexWin32EXT", retValue, memory, key			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAcquireKeyedMutexWin32EXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glAcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReleaseKeyedMutexWin32EXT", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.U1)]
			internal extern static bool glReleaseKeyedMutexWin32EXT(UInt32 memory, UInt64 key);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glAcquireKeyedMutexWin32EXT(UInt32 memory, UInt64 key, UInt32 timeout);

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glAcquireKeyedMutexWin32EXT pglAcquireKeyedMutexWin32EXT;

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glReleaseKeyedMutexWin32EXT(UInt32 memory, UInt64 key);

			[RequiredByFeature("GL_EXT_win32_keyed_mutex", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glReleaseKeyedMutexWin32EXT pglReleaseKeyedMutexWin32EXT;

		}
	}

}
