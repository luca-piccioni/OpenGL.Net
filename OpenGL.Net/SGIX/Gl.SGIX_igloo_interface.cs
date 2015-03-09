
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
		/// Binding for glIglooInterfaceSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_igloo_interface")]
		public static void IglooInterfaceSGIX(int pname, IntPtr @params)
		{
			Debug.Assert(Delegates.pglIglooInterfaceSGIX != null, "pglIglooInterfaceSGIX not implemented");
			Delegates.pglIglooInterfaceSGIX(pname, @params);
			CallLog("glIglooInterfaceSGIX({0}, {1})", pname, @params);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glIglooInterfaceSGIX.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_SGIX_igloo_interface")]
		public static void IglooInterfaceSGIX(int pname, Object @params)
		{
			GCHandle pin_params = GCHandle.Alloc(@params, GCHandleType.Pinned);
			try {
				IglooInterfaceSGIX(pname, pin_params.AddrOfPinnedObject());
			} finally {
				pin_params.Free();
			}
		}

	}

}
