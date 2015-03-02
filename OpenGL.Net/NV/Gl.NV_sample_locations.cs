
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
		/// Value of GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int SAMPLE_LOCATION_SUBPIXEL_BITS_NV = 0x933D;

		/// <summary>
		/// Value of GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV = 0x933E;

		/// <summary>
		/// Value of GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV = 0x933F;

		/// <summary>
		/// Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV = 0x9340;

		/// <summary>
		/// Value of GL_SAMPLE_LOCATION_NV symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to SAMPLE_POSITION_NV.
		/// </para>
		/// </remarks>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int SAMPLE_LOCATION_NV = 0x8E50;

		/// <summary>
		/// Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_NV = 0x9341;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV = 0x9342;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations")]
		public const int FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV = 0x9343;

		/// <summary>
		/// Binding for glFramebufferSampleLocationsfvNV.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void FramebufferSampleLocationNV(int target, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvNV != null, "pglFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglFramebufferSampleLocationsfvNV(target, start, count, p_v);
					CallLog("glFramebufferSampleLocationsfvNV({0}, {1}, {2}, {3})", target, start, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glNamedFramebufferSampleLocationsfvNV.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="start">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		public static void NamedFramebufferSampleLocationNV(UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvNV != null, "pglNamedFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvNV(framebuffer, start, count, p_v);
					CallLog("glNamedFramebufferSampleLocationsfvNV({0}, {1}, {2}, {3})", framebuffer, start, count, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glResolveDepthValuesNV.
		/// </summary>
		public static void ResolveDepthValuesNV()
		{
			Debug.Assert(Delegates.pglResolveDepthValuesNV != null, "pglResolveDepthValuesNV not implemented");
			Delegates.pglResolveDepthValuesNV();
			CallLog("glResolveDepthValuesNV()");
			DebugCheckErrors();
		}

	}

}
