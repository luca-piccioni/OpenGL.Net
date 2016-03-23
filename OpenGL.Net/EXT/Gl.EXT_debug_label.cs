
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
		/// Value of GL_PROGRAM_PIPELINE_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		public const int PROGRAM_PIPELINE_OBJECT_EXT = 0x8A4F;

		/// <summary>
		/// Value of GL_BUFFER_OBJECT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		public const int BUFFER_OBJECT_EXT = 0x9151;

		/// <summary>
		/// Value of GL_QUERY_OBJECT_EXT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_OBJECT_AMD")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int QUERY_OBJECT_EXT = 0x9153;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_OBJECT_EXT symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_OBJECT_AMD")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		[RequiredByFeature("GL_AMD_name_gen_delete")]
		public const int VERTEX_ARRAY_OBJECT_EXT = 0x9154;

		/// <summary>
		/// Binding for glLabelObjectEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="object">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:String"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		public static void LabelObjectEXT(Int32 type, UInt32 @object, Int32 length, String label)
		{
			Debug.Assert(Delegates.pglLabelObjectEXT != null, "pglLabelObjectEXT not implemented");
			Delegates.pglLabelObjectEXT(type, @object, length, label);
			LogFunction("glLabelObjectEXT({0}, {1}, {2}, {3})", LogEnumName(type), @object, length, label);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetObjectLabelEXT.
		/// </summary>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="object">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="label">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|gles2")]
		public static void GetObjectEXT(Int32 type, UInt32 @object, Int32 bufSize, out Int32 length, [Out] StringBuilder label)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				{
					Debug.Assert(Delegates.pglGetObjectLabelEXT != null, "pglGetObjectLabelEXT not implemented");
					Delegates.pglGetObjectLabelEXT(type, @object, bufSize, p_length, label);
					LogFunction("glGetObjectLabelEXT({0}, {1}, {2}, {3}, {4})", LogEnumName(type), @object, bufSize, length, label);
				}
			}
			DebugCheckErrors(null);
		}

	}

}
