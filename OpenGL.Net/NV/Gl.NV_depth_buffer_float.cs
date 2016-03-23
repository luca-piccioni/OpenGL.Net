
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
		/// Value of GL_DEPTH_COMPONENT32F_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH_COMPONENT32F_NV = 0x8DAB;

		/// <summary>
		/// Value of GL_DEPTH32F_STENCIL8_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH32F_STENCIL8_NV = 0x8DAC;

		/// <summary>
		/// Value of GL_DEPTH_BUFFER_FLOAT_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public const int DEPTH_BUFFER_FLOAT_MODE_NV = 0x8DAF;

		/// <summary>
		/// Binding for glDepthRangedNV.
		/// </summary>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void DepthRangedNV(double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglDepthRangedNV != null, "pglDepthRangedNV not implemented");
			Delegates.pglDepthRangedNV(zNear, zFar);
			LogFunction("glDepthRangedNV({0}, {1})", zNear, zFar);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glClearDepthdNV.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void ClearDepthdNV(double depth)
		{
			Debug.Assert(Delegates.pglClearDepthdNV != null, "pglClearDepthdNV not implemented");
			Delegates.pglClearDepthdNV(depth);
			LogFunction("glClearDepthdNV({0})", depth);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glDepthBoundsdNV.
		/// </summary>
		/// <param name="zmin">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zmax">
		/// A <see cref="T:double"/>.
		/// </param>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		public static void DepthBoundsdNV(double zmin, double zmax)
		{
			Debug.Assert(Delegates.pglDepthBoundsdNV != null, "pglDepthBoundsdNV not implemented");
			Delegates.pglDepthBoundsdNV(zmin, zmax);
			LogFunction("glDepthBoundsdNV({0}, {1})", zmin, zmax);
			DebugCheckErrors(null);
		}

	}

}
