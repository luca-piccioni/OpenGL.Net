
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
		/// Value of GL_POINT_SIZE_MIN_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_point_parameters")]
		public const int POINT_SIZE_MIN_ARB = 0x8126;

		/// <summary>
		/// Value of GL_POINT_SIZE_MAX_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_point_parameters")]
		public const int POINT_SIZE_MAX_ARB = 0x8127;

		/// <summary>
		/// Value of GL_POINT_FADE_THRESHOLD_SIZE_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_point_parameters")]
		public const int POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;

		/// <summary>
		/// Value of GL_POINT_DISTANCE_ATTENUATION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GL_ARB_point_parameters")]
		public const int POINT_DISTANCE_ATTENUATION_ARB = 0x8129;

		/// <summary>
		/// Binding for glPointParameterfARB.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="param">
		/// A <see cref="T:float"/>.
		/// </param>
		public static void PointParameterARB(int pname, float param)
		{
			Debug.Assert(Delegates.pglPointParameterfARB != null, "pglPointParameterfARB not implemented");
			Delegates.pglPointParameterfARB(pname, param);
			CallLog("glPointParameterfARB({0}, {1})", pname, param);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glPointParameterfvARB.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void PointParameterARB(int pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglPointParameterfvARB != null, "pglPointParameterfvARB not implemented");
					Delegates.pglPointParameterfvARB(pname, p_params);
					CallLog("glPointParameterfvARB({0}, {1})", pname, @params);
				}
			}
			DebugCheckErrors();
		}

	}

}
