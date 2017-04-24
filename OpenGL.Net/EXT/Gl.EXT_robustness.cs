
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
		/// Binding for glGetGraphicsResetStatusEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static Int32 GetGraphicsResetStatusEXT()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusEXT != null, "pglGetGraphicsResetStatusEXT not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusEXT();
			LogCommand("glGetGraphicsResetStatusEXT", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetnUniformfvEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static void GetnUniformEXT(UInt32 program, Int32 location, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvEXT != null, "pglGetnUniformfvEXT not implemented");
					Delegates.pglGetnUniformfvEXT(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformfvEXT", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetnUniformivEXT.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		public static void GetnUniformEXT(UInt32 program, Int32 location, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivEXT != null, "pglGetnUniformivEXT not implemented");
					Delegates.pglGetnUniformivEXT(program, location, (Int32)@params.Length, p_params);
					LogCommand("glGetnUniformivEXT", null, program, location, @params.Length, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetGraphicsResetStatusEXT", ExactSpelling = true)]
			internal extern static Int32 glGetGraphicsResetStatusEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetnUniformivEXT", ExactSpelling = true)]
			internal extern static unsafe void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetGraphicsResetStatusEXT();

			[ThreadStatic]
			internal static glGetGraphicsResetStatusEXT pglGetGraphicsResetStatusEXT;

			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformfvEXT(UInt32 program, Int32 location, Int32 bufSize, float* @params);

			[ThreadStatic]
			internal static glGetnUniformfvEXT pglGetnUniformfvEXT;

			[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetnUniformivEXT(UInt32 program, Int32 location, Int32 bufSize, Int32* @params);

			[ThreadStatic]
			internal static glGetnUniformivEXT pglGetnUniformivEXT;

		}
	}

}
