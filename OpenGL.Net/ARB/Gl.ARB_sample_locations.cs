
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
		/// [GL] Value of GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_SUBPIXEL_BITS_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_SUBPIXEL_BITS_ARB = 0x933D;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB = 0x933E;

		/// <summary>
		/// [GL] Value of GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB symbol.
		/// </summary>
		[AliasOf("GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB = 0x933F;

		/// <summary>
		/// [GL] Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB = 0x9340;

		/// <summary>
		/// [GL] Value of GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB symbol.
		/// </summary>
		[AliasOf("GL_PROGRAMMABLE_SAMPLE_LOCATION_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int PROGRAMMABLE_SAMPLE_LOCATION_ARB = 0x9341;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB = 0x9342;

		/// <summary>
		/// [GL] Value of GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_NV")]
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public const int FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB = 0x9343;

		/// <summary>
		/// Binding for glFramebufferSampleLocationsfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:FramebufferTarget"/>.
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
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void FramebufferSampleLocationARB(FramebufferTarget target, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvARB != null, "pglFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglFramebufferSampleLocationsfvARB((Int32)target, start, count, p_v);
					LogCommand("glFramebufferSampleLocationsfvARB", null, target, start, count, v					);
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
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void NamedFramebufferSampleLocationARB(UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvARB != null, "pglNamedFramebufferSampleLocationsfvARB not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvARB(framebuffer, start, count, p_v);
					LogCommand("glNamedFramebufferSampleLocationsfvARB", null, framebuffer, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glEvaluateDepthValuesARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
		public static void EvaluateDepthValuesARB()
		{
			Debug.Assert(Delegates.pglEvaluateDepthValuesARB != null, "pglEvaluateDepthValuesARB not implemented");
			Delegates.pglEvaluateDepthValuesARB();
			LogCommand("glEvaluateDepthValuesARB", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferSampleLocationsfvARB", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferSampleLocationsfvARB(Int32 target, UInt32 start, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferSampleLocationsfvARB", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferSampleLocationsfvARB(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvaluateDepthValuesARB", ExactSpelling = true)]
			internal extern static void glEvaluateDepthValuesARB();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferSampleLocationsfvARB(Int32 target, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvARB pglFramebufferSampleLocationsfvARB;

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferSampleLocationsfvARB(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvARB pglNamedFramebufferSampleLocationsfvARB;

			[RequiredByFeature("GL_ARB_sample_locations", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvaluateDepthValuesARB();

			[ThreadStatic]
			internal static glEvaluateDepthValuesARB pglEvaluateDepthValuesARB;

		}
	}

}
