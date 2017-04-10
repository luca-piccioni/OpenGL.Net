
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_VIEWPORT_POSITION_W_SCALE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_clip_space_w_scaling", Api = "gl|glcore")]
		public const int VIEWPORT_POSITION_W_SCALE_NV = 0x937C;

		/// <summary>
		/// Value of GL_VIEWPORT_POSITION_W_SCALE_X_COEFF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_clip_space_w_scaling", Api = "gl|glcore")]
		public const int VIEWPORT_POSITION_W_SCALE_X_COEFF_NV = 0x937D;

		/// <summary>
		/// Value of GL_VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_clip_space_w_scaling", Api = "gl|glcore")]
		public const int VIEWPORT_POSITION_W_SCALE_Y_COEFF_NV = 0x937E;

		/// <summary>
		/// Binding for glViewportPositionWScaleNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="xcoeff">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="ycoeff">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_NV_clip_space_w_scaling", Api = "gl|glcore")]
		public static void ViewportPositionWScaleNV(UInt32 index, float xcoeff, float ycoeff)
		{
			Debug.Assert(Delegates.pglViewportPositionWScaleNV != null, "pglViewportPositionWScaleNV not implemented");
			Delegates.pglViewportPositionWScaleNV(index, xcoeff, ycoeff);
			LogFunction("glViewportPositionWScaleNV({0}, {1}, {2})", index, xcoeff, ycoeff);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewportPositionWScaleNV", ExactSpelling = true)]
			internal extern static void glViewportPositionWScaleNV(UInt32 index, float xcoeff, float ycoeff);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_clip_space_w_scaling", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewportPositionWScaleNV(UInt32 index, float xcoeff, float ycoeff);

			[ThreadStatic]
			internal static glViewportPositionWScaleNV pglViewportPositionWScaleNV;

		}
	}

}
