
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
	public partial class Glx
	{
		/// <summary>
		/// Binding for glXGetAGPOffsetMESA.
		/// </summary>
		/// <param name="pointer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_agp_offset")]
		public static UInt32 GetAGPOffsetMESA(IntPtr pointer)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglXGetAGPOffsetMESA != null, "pglXGetAGPOffsetMESA not implemented");
			retValue = Delegates.pglXGetAGPOffsetMESA(pointer);
			CallLog("glXGetAGPOffsetMESA({0}) = {1}", pointer, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetAGPOffsetMESA.
		/// </summary>
		/// <param name="pointer">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_agp_offset")]
		public static UInt32 GetAGPOffsetMESA(Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				return (GetAGPOffsetMESA(pin_pointer.AddrOfPinnedObject()));
			} finally {
				pin_pointer.Free();
			}
		}

	}

}
