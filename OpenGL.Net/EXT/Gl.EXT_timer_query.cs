
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
		/// Value of GL_TIME_ELAPSED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_timer_query")]
		public const int TIME_ELAPSED_EXT = 0x88BF;

		/// <summary>
		/// Binding for glGetQueryObjecti64vEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObjecti64vEXT(UInt32 id, int pname, Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjecti64vEXT != null, "pglGetQueryObjecti64vEXT not implemented");
					Delegates.pglGetQueryObjecti64vEXT(id, pname, p_params);
					CallLog("glGetQueryObjecti64vEXT({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetQueryObjectui64vEXT.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_timer_query")]
		public static void GetQueryObjectui64vEXT(UInt32 id, int pname, UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetQueryObjectui64vEXT != null, "pglGetQueryObjectui64vEXT not implemented");
					Delegates.pglGetQueryObjectui64vEXT(id, pname, p_params);
					CallLog("glGetQueryObjectui64vEXT({0}, {1}, {2})", id, pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
