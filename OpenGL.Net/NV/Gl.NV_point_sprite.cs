
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
		/// Value of GL_POINT_SPRITE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_point_sprite")]
		public const int POINT_SPRITE_NV = 0x8861;

		/// <summary>
		/// Value of GL_COORD_REPLACE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_point_sprite")]
		public const int COORD_REPLACE_NV = 0x8862;

		/// <summary>
		/// Value of GL_POINT_SPRITE_R_MODE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_point_sprite")]
		public const int POINT_SPRITE_R_MODE_NV = 0x8863;

		/// <summary>
		/// Binding for glPointParameteriNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_point_sprite")]
		public static void PointParameterNV(int pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPointParameteriNV != null, "pglPointParameteriNV not implemented");
			Delegates.pglPointParameteriNV(pname, param);
			CallLog("glPointParameteriNV({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterivNV.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_point_sprite")]
		public static void PointParameterNV(int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterivNV != null, "pglPointParameterivNV not implemented");
					Delegates.pglPointParameterivNV(pname, p_params);
					CallLog("glPointParameterivNV({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
