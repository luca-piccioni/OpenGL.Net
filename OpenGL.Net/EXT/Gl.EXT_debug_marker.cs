
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

	}

}
