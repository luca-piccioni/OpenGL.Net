
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
		/// Value of GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;

		/// <summary>
		/// Value of GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;

		/// <summary>
		/// Value of GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;

		/// <summary>
		/// Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;

		/// <summary>
		/// Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
		[RequiredByFeature("GL_ARB_sample_locations")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public const int FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;

		/// <summary>
		/// Binding for glFramebufferSampleLocationsfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
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
		[RequiredByFeature("GL_ARB_sample_locations")]
		public static void FramebufferSampleLocationARB(Int32 target, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvARB != null, "pglFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglFramebufferSampleLocationsfvARB(target, start, count, p_v);
					LogFunction("glFramebufferSampleLocationsfvARB({0}, {1}, {2}, {3})", LogEnumName(target), start, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferSampleLocationsfvARB.
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
		[RequiredByFeature("GL_ARB_sample_locations")]
		public static void NamedFramebufferSampleLocationARB(UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvARB != null, "pglNamedFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, p_v);
					LogFunction("glNamedFramebufferSampleLocationsfvARB({0}, {1}, {2}, {3})", framebuffer, start, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvaluateDepthValuesARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations")]
		public static void EvaluateDepthValuesARB()
		{
			Debug.Assert(Delegates.pglEvaluateDepthValuesARB != null, "pglEvaluateDepthValuesARB not implemented");
			Delegates.pglEvaluateDepthValuesARB();
			LogFunction("glEvaluateDepthValuesARB()");
			DebugCheckErrors(null);
		}

	}

}
