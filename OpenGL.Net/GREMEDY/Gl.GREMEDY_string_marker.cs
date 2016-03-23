
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
		/// Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, IntPtr @string)
		{
			Debug.Assert(Delegates.pglStringMarkerGREMEDY != null, "pglStringMarkerGREMEDY not implemented");
			Delegates.pglStringMarkerGREMEDY(len, @string);
			LogFunction("glStringMarkerGREMEDY({0}, 0x{1})", len, @string.ToString("X8"));
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glStringMarkerGREMEDY.
		/// </summary>
		/// <param name="len">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="string">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_GREMEDY_string_marker")]
		public static void StringMarkerGREMEDY(Int32 len, Object @string)
		{
			GCHandle pin_string = GCHandle.Alloc(@string, GCHandleType.Pinned);
			try {
				StringMarkerGREMEDY(len, pin_string.AddrOfPinnedObject());
			} finally {
				pin_string.Free();
			}
		}

	}

}
