
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
		/// Value of GL_BUFFER_SERIALIZED_MODIFY_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public const int BUFFER_SERIALIZED_MODIFY_APPLE = 0x8A12;

		/// <summary>
		/// Value of GL_BUFFER_FLUSHING_UNMAP_APPLE symbol.
		/// </summary>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public const int BUFFER_FLUSHING_UNMAP_APPLE = 0x8A13;

		/// <summary>
		/// Binding for glBufferParameteriAPPLE.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_APPLE_flush_buffer_range")]
		public static void BufferParameterAPPLE(Int32 target, Int32 pname, Int32 param)
		{
			Debug.Assert(Delegates.pglBufferParameteriAPPLE != null, "pglBufferParameteriAPPLE not implemented");
			Delegates.pglBufferParameteriAPPLE(target, pname, param);
			LogFunction("glBufferParameteriAPPLE({0}, {1}, {2})", LogEnumName(target), LogEnumName(pname), param);
			DebugCheckErrors(null);
		}

	}

}
