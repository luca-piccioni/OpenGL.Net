
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
		/// Binding for glQueryMatrixxOES.
		/// </summary>
		/// <param name="mantissa">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="exponent">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
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
					LogFunction("glQueryMatrixxOES({0}, {1}) = {2}", LogValue(mantissa), LogValue(exponent), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
