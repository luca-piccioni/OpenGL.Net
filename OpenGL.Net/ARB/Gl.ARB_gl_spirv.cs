
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
		/// [GL] Value of GL_SHADER_BINARY_FORMAT_SPIR_V_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
		public const int SHADER_BINARY_FORMAT_SPIR_V_ARB = 0x9551;

		/// <summary>
		/// [GL] Value of GL_SPIR_V_BINARY_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
		public const int SPIR_V_BINARY_ARB = 0x9552;

		/// <summary>
		/// [GL] Binding for glSpecializeShaderARB.
		/// </summary>
		/// <param name="shader">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pEntryPoint">
		/// A <see cref="T:String"/>.
		/// </param>
		/// <param name="numSpecializationConstants">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pConstantIndex">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <param name="pConstantValue">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
		public static void SpecializeShaderARB(UInt32 shader, String pEntryPoint, UInt32 numSpecializationConstants, UInt32[] pConstantIndex, UInt32[] pConstantValue)
		{
			unsafe {
				fixed (UInt32* p_pConstantIndex = pConstantIndex)
				fixed (UInt32* p_pConstantValue = pConstantValue)
				{
					Debug.Assert(Delegates.pglSpecializeShaderARB != null, "pglSpecializeShaderARB not implemented");
					Delegates.pglSpecializeShaderARB(shader, pEntryPoint, numSpecializationConstants, p_pConstantIndex, p_pConstantValue);
					LogCommand("glSpecializeShaderARB", null, shader, pEntryPoint, numSpecializationConstants, pConstantIndex, pConstantValue					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSpecializeShaderARB", ExactSpelling = true)]
			internal extern static unsafe void glSpecializeShaderARB(UInt32 shader, String pEntryPoint, UInt32 numSpecializationConstants, UInt32* pConstantIndex, UInt32* pConstantValue);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSpecializeShaderARB(UInt32 shader, String pEntryPoint, UInt32 numSpecializationConstants, UInt32* pConstantIndex, UInt32* pConstantValue);

			[RequiredByFeature("GL_ARB_gl_spirv", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glSpecializeShaderARB pglSpecializeShaderARB;

		}
	}

}
