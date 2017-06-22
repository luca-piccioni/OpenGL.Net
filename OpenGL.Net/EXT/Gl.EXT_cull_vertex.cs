
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
		/// [GL] Value of GL_CULL_VERTEX_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_EXT = 0x81AA;

		/// <summary>
		/// [GL] Value of GL_CULL_VERTEX_EYE_POSITION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_EYE_POSITION_EXT = 0x81AB;

		/// <summary>
		/// [GL] Value of GL_CULL_VERTEX_OBJECT_POSITION_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public const int CULL_VERTEX_OBJECT_POSITION_EXT = 0x81AC;

		/// <summary>
		/// [GL] Binding for glCullParameterdvEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public static void CullParameterEXT(Int32 pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglCullParameterdvEXT != null, "pglCullParameterdvEXT not implemented");
					Delegates.pglCullParameterdvEXT(pname, p_params);
					LogCommand("glCullParameterdvEXT", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glCullParameterfvEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_cull_vertex")]
		public static void CullParameterEXT(Int32 pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglCullParameterfvEXT != null, "pglCullParameterfvEXT not implemented");
					Delegates.pglCullParameterfvEXT(pname, p_params);
					LogCommand("glCullParameterfvEXT", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterdvEXT(Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
			internal extern static unsafe void glCullParameterfvEXT(Int32 pname, float* @params);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_EXT_cull_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCullParameterdvEXT(Int32 pname, double* @params);

			[RequiredByFeature("GL_EXT_cull_vertex")]
			[ThreadStatic]
			internal static glCullParameterdvEXT pglCullParameterdvEXT;

			[RequiredByFeature("GL_EXT_cull_vertex")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCullParameterfvEXT(Int32 pname, float* @params);

			[RequiredByFeature("GL_EXT_cull_vertex")]
			[ThreadStatic]
			internal static glCullParameterfvEXT pglCullParameterfvEXT;

		}
	}

}
