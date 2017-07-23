
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
		/// [GLES1.1] return the values of the current matrix
		/// </summary>
		/// <param name="mantissa">
		/// Returns the mantissa values of the current matrix.
		/// </param>
		/// <param name="exponent">
		/// Returns the exponents of the current matrix.
		/// </param>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.MatrixMode"/>
		[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
		public static UInt32 QueryMatrixxOES(IntPtr[] mantissa, Int32[] exponent)
		{
			UInt32 retValue;

			unsafe {
				fixed (IntPtr* p_mantissa = mantissa)
				fixed (Int32* p_exponent = exponent)
				{
					Debug.Assert(Delegates.pglQueryMatrixxOES != null, "pglQueryMatrixxOES not implemented");
					retValue = Delegates.pglQueryMatrixxOES(p_mantissa, p_exponent);
					LogCommand("glQueryMatrixxOES", retValue, mantissa, exponent					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glQueryMatrixxOES", ExactSpelling = true)]
			internal extern static unsafe UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate UInt32 glQueryMatrixxOES(IntPtr* mantissa, Int32* exponent);

			[RequiredByFeature("GL_OES_query_matrix", Api = "gl|gles1")]
			[ThreadStatic]
			internal static glQueryMatrixxOES pglQueryMatrixxOES;

		}
	}

}
