
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
		/// Binding for glInsertEventMarkerEXT.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="marker">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_marker", Api = "gl|gles2")]
		public static void InsertEventMarkerEXT(Int32 length, String marker)
		{
			Debug.Assert(Delegates.pglInsertEventMarkerEXT != null, "pglInsertEventMarkerEXT not implemented");
			Delegates.pglInsertEventMarkerEXT(length, marker);
			LogFunction("glInsertEventMarkerEXT({0}, {1})", length, marker);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPushGroupMarkerEXT.
		/// </summary>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="marker">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_marker", Api = "gl|gles2")]
		public static void PushGroupMarkerEXT(Int32 length, String marker)
		{
			Debug.Assert(Delegates.pglPushGroupMarkerEXT != null, "pglPushGroupMarkerEXT not implemented");
			Delegates.pglPushGroupMarkerEXT(length, marker);
			LogFunction("glPushGroupMarkerEXT({0}, {1})", length, marker);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glPopGroupMarkerEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_marker", Api = "gl|gles2")]
		public static void PopGroupMarkerEXT()
		{
			Debug.Assert(Delegates.pglPopGroupMarkerEXT != null, "pglPopGroupMarkerEXT not implemented");
			Delegates.pglPopGroupMarkerEXT();
			LogFunction("glPopGroupMarkerEXT()");
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInsertEventMarkerEXT", ExactSpelling = true)]
			internal extern static void glInsertEventMarkerEXT(Int32 length, String marker);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushGroupMarkerEXT", ExactSpelling = true)]
			internal extern static void glPushGroupMarkerEXT(Int32 length, String marker);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopGroupMarkerEXT", ExactSpelling = true)]
			internal extern static void glPopGroupMarkerEXT();

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInsertEventMarkerEXT(Int32 length, String marker);

			[ThreadStatic]
			internal static glInsertEventMarkerEXT pglInsertEventMarkerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushGroupMarkerEXT(Int32 length, String marker);

			[ThreadStatic]
			internal static glPushGroupMarkerEXT pglPushGroupMarkerEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopGroupMarkerEXT();

			[ThreadStatic]
			internal static glPopGroupMarkerEXT pglPopGroupMarkerEXT;

		}
	}

}
