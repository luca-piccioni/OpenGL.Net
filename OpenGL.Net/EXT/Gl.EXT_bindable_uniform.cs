
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
		/// Value of GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;

		/// <summary>
		/// Value of GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;

		/// <summary>
		/// Value of GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;

		/// <summary>
		/// Value of GL_MAX_BINDABLE_UNIFORM_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int UNIFORM_BUFFER_EXT = 0x8DEE;

		/// <summary>
		/// Value of GL_UNIFORM_BUFFER_BINDING_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int UNIFORM_BUFFER_BINDING_EXT = 0x8DEF;

		/// <summary>
		/// Binding for glUniformBufferEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public static void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglUniformBufferEXT != null, "pglUniformBufferEXT not implemented");
			Delegates.pglUniformBufferEXT(program, location, buffer);
			LogFunction("glUniformBufferEXT({0}, {1}, {2})", program, location, buffer);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetUniformBufferSizeEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public static Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetUniformBufferSizeEXT != null, "pglGetUniformBufferSizeEXT not implemented");
			retValue = Delegates.pglGetUniformBufferSizeEXT(program, location);
			LogFunction("glGetUniformBufferSizeEXT({0}, {1}) = {2}", program, location, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetUniformOffsetEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public static IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglGetUniformOffsetEXT != null, "pglGetUniformOffsetEXT not implemented");
			retValue = Delegates.pglGetUniformOffsetEXT(program, location);
			LogFunction("glGetUniformOffsetEXT({0}, {1}) = {2}", program, location, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
