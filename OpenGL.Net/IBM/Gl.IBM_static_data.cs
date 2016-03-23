
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
		/// Value of GL_ALL_STATIC_DATA_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_static_data")]
		public const int ALL_STATIC_DATA_IBM = 103060;

		/// <summary>
		/// Value of GL_STATIC_VERTEX_ARRAY_IBM symbol.
		/// </summary>
		[RequiredByFeature("GL_IBM_static_data")]
		public const int STATIC_VERTEX_ARRAY_IBM = 103061;

		/// <summary>
		/// Binding for glFlushStaticDataIBM.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_IBM_static_data")]
		public static void FlushStaticDataIBM(Int32 target)
		{
			Debug.Assert(Delegates.pglFlushStaticDataIBM != null, "pglFlushStaticDataIBM not implemented");
			Delegates.pglFlushStaticDataIBM(target);
			LogFunction("glFlushStaticDataIBM({0})", LogEnumName(target));
			DebugCheckErrors(null);
		}

	}

}
