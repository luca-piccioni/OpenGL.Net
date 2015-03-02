
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
		/// Value of GL_VERTEX_SHADER_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int VERTEX_SHADER_ARB = 0x8B31;

		/// <summary>
		/// Value of GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VERTEX_UNIFORM_COMPONENTS_ARB = 0x8B4A;

		/// <summary>
		/// Value of GL_MAX_VARYING_FLOATS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_VARYING_FLOATS_ARB = 0x8B4B;

		/// <summary>
		/// Value of GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_NV_vertex_program3")]
		public const int MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB = 0x8B4C;

		/// <summary>
		/// Value of GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB = 0x8B4D;

		/// <summary>
		/// Value of GL_OBJECT_ACTIVE_ATTRIBUTES_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int OBJECT_ACTIVE_ATTRIBUTES_ARB = 0x8B89;

		/// <summary>
		/// Value of GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_vertex_shader")]
		public const int OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB = 0x8B8A;

		/// <summary>
		/// Binding for glBindAttribLocationARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		public static void BindAttribLocationARB(UInt32 programObj, UInt32 index, String name)
		{
			Debug.Assert(Delegates.pglBindAttribLocationARB != null, "pglBindAttribLocationARB not implemented");
			Delegates.pglBindAttribLocationARB(programObj, index, name);
			CallLog("glBindAttribLocationARB({0}, {1}, {2})", programObj, index, name);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetActiveAttribARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="maxLength">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:StringBuilder"/>.
		/// </param>
		public static void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetActiveAttribARB != null, "pglGetActiveAttribARB not implemented");
					Delegates.pglGetActiveAttribARB(programObj, index, maxLength, p_length, p_size, p_type, name);
					CallLog("glGetActiveAttribARB({0}, {1}, {2}, {3}, {4}, {5}, {6})", programObj, index, maxLength, length, size, type, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetAttribLocationARB.
		/// </summary>
		/// <param name="programObj">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:String"/>.
		/// </param>
		public static Int32 GetAttribLocationARB(UInt32 programObj, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetAttribLocationARB != null, "pglGetAttribLocationARB not implemented");
			retValue = Delegates.pglGetAttribLocationARB(programObj, name);
			CallLog("glGetAttribLocationARB({0}, {1}) = {2}", programObj, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
