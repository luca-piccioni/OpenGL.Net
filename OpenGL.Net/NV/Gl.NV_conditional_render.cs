
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
		/// Value of GL_QUERY_WAIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conditional_render")]
		public const int QUERY_WAIT_NV = 0x8E13;

		/// <summary>
		/// Value of GL_QUERY_NO_WAIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conditional_render")]
		public const int QUERY_NO_WAIT_NV = 0x8E14;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_WAIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conditional_render")]
		public const int QUERY_BY_REGION_WAIT_NV = 0x8E15;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_NO_WAIT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_conditional_render")]
		public const int QUERY_BY_REGION_NO_WAIT_NV = 0x8E16;

		/// <summary>
		/// Binding for glBeginConditionalRenderNV.
		/// </summary>
		/// <param name="id">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="mode">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_conditional_render")]
		public static void BeginConditionalRenderNV(UInt32 id, int mode)
		{
			Debug.Assert(Delegates.pglBeginConditionalRenderNV != null, "pglBeginConditionalRenderNV not implemented");
			Delegates.pglBeginConditionalRenderNV(id, mode);
			CallLog("glBeginConditionalRenderNV({0}, {1})", id, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEndConditionalRenderNV.
		/// </summary>
		[RequiredByFeature("GL_NV_conditional_render")]
		public static void EndConditionalRenderNV()
		{
			Debug.Assert(Delegates.pglEndConditionalRenderNV != null, "pglEndConditionalRenderNV not implemented");
			Delegates.pglEndConditionalRenderNV();
			CallLog("glEndConditionalRenderNV()");
			DebugCheckErrors();
		}

	}

}
