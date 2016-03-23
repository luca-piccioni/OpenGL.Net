
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
		/// Value of GL_MAX_SHADER_COMPILER_THREADS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile")]
		public const int MAX_SHADER_COMPILER_THREADS_ARB = 0x91B0;

		/// <summary>
		/// Value of GL_COMPLETION_STATUS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_parallel_shader_compile")]
		public const int COMPLETION_STATUS_ARB = 0x91B1;

		/// <summary>
		/// Binding for glMaxShaderCompilerThreadsARB.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_parallel_shader_compile")]
		public static void MaxShaderCompilerThreadsARB(UInt32 count)
		{
			Debug.Assert(Delegates.pglMaxShaderCompilerThreadsARB != null, "pglMaxShaderCompilerThreadsARB not implemented");
			Delegates.pglMaxShaderCompilerThreadsARB(count);
			LogFunction("glMaxShaderCompilerThreadsARB({0})", count);
			DebugCheckErrors(null);
		}

	}

}
