
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
		/// [GL] Value of GL_MAX_SHADER_COMPILER_THREADS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public const int MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;

		/// <summary>
		/// [GL] Value of GL_COMPLETION_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public const int COMPLETION_STATUS_ARB = 0x91B1;

		/// <summary>
		/// [GL] Binding for glMaxShaderCompilerThreadsARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
		public static void MaxShaderCompilerThreadsARB(UInt32 count)
		{
			Debug.Assert(Delegates.pglMaxShaderCompilerThreadsARB != null, "pglMaxShaderCompilerThreadsARB not implemented");
			Delegates.pglMaxShaderCompilerThreadsARB(count);
			LogCommand("glMaxShaderCompilerThreadsARB", null, count			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaxShaderCompilerThreadsARB", ExactSpelling = true)]
			internal extern static void glMaxShaderCompilerThreadsARB(UInt32 count);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMaxShaderCompilerThreadsARB(UInt32 count);

			[RequiredByFeature("GL_ARB_parallel_shader_compile", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glMaxShaderCompilerThreadsARB pglMaxShaderCompilerThreadsARB;

		}
	}

}
