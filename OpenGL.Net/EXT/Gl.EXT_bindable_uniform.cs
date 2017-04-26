
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
		/// [GL] Value of GL_MAX_VERTEX_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_VERTEX_BINDABLE_UNIFORMS_EXT = 0x8DE2;

		/// <summary>
		/// [GL] Value of GL_MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_FRAGMENT_BINDABLE_UNIFORMS_EXT = 0x8DE3;

		/// <summary>
		/// [GL] Value of GL_MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_GEOMETRY_BINDABLE_UNIFORMS_EXT = 0x8DE4;

		/// <summary>
		/// [GL] Value of GL_MAX_BINDABLE_UNIFORM_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int MAX_BINDABLE_UNIFORM_SIZE_EXT = 0x8DED;

		/// <summary>
		/// [GL] Value of GL_UNIFORM_BUFFER_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_bindable_uniform")]
		public const int UNIFORM_BUFFER_EXT = 0x8DEE;

		/// <summary>
		/// [GL] Value of GL_UNIFORM_BUFFER_BINDING_EXT symbol.
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
			LogCommand("glUniformBufferEXT", null, program, location, buffer			);
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
			LogCommand("glGetUniformBufferSizeEXT", retValue, program, location			);
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
			LogCommand("glGetUniformOffsetEXT", retValue, program, location			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glUniformBufferEXT", ExactSpelling = true)]
			internal extern static void glUniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformBufferSizeEXT", ExactSpelling = true)]
			internal extern static Int32 glGetUniformBufferSizeEXT(UInt32 program, Int32 location);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetUniformOffsetEXT", ExactSpelling = true)]
			internal extern static IntPtr glGetUniformOffsetEXT(UInt32 program, Int32 location);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_bindable_uniform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glUniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);

			[ThreadStatic]
			internal static glUniformBufferEXT pglUniformBufferEXT;

			[RequiredByFeature("GL_EXT_bindable_uniform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetUniformBufferSizeEXT(UInt32 program, Int32 location);

			[ThreadStatic]
			internal static glGetUniformBufferSizeEXT pglGetUniformBufferSizeEXT;

			[RequiredByFeature("GL_EXT_bindable_uniform")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetUniformOffsetEXT(UInt32 program, Int32 location);

			[ThreadStatic]
			internal static glGetUniformOffsetEXT pglGetUniformOffsetEXT;

		}
	}

}
