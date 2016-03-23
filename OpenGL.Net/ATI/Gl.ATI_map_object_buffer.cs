
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
		/// Binding for glMapObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_map_object_buffer")]
		public static IntPtr MapObjectBufferATI(UInt32 buffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapObjectBufferATI != null, "pglMapObjectBufferATI not implemented");
			retValue = Delegates.pglMapObjectBufferATI(buffer);
			LogFunction("glMapObjectBufferATI({0}) = {1}", buffer, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glUnmapObjectBufferATI.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_ATI_map_object_buffer")]
		public static void UnmapObjectBufferATI(UInt32 buffer)
		{
			Debug.Assert(Delegates.pglUnmapObjectBufferATI != null, "pglUnmapObjectBufferATI not implemented");
			Delegates.pglUnmapObjectBufferATI(buffer);
			LogFunction("glUnmapObjectBufferATI({0})", buffer);
			DebugCheckErrors(null);
		}

	}

}
