
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
		/// Value of GL_PIXELS_PER_SAMPLE_PATTERN_X_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public const int PIXELS_PER_SAMPLE_PATTERN_X_AMD = 0x91AE;

		/// <summary>
		/// Value of GL_PIXELS_PER_SAMPLE_PATTERN_Y_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public const int PIXELS_PER_SAMPLE_PATTERN_Y_AMD = 0x91AF;

		/// <summary>
		/// Value of GL_ALL_PIXELS_AMD symbol.
		/// </summary>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public const uint ALL_PIXELS_AMD = 0xFFFFFFFF;

		/// <summary>
		/// Binding for glFramebufferSamplePositionsfvAMD.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numsamples">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pixelindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public static void FramebufferSampleAMD(Int32 target, UInt32 numsamples, UInt32 pixelindex, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglFramebufferSamplePositionsfvAMD != null, "pglFramebufferSamplePositionsfvAMD not implemented");
					Delegates.pglFramebufferSamplePositionsfvAMD(target, numsamples, pixelindex, p_values);
					LogFunction("glFramebufferSamplePositionsfvAMD({0}, {1}, {2}, {3})", LogEnumName(target), numsamples, pixelindex, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glNamedFramebufferSamplePositionsfvAMD.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numsamples">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pixelindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public static void NamedFramebufferSampleAMD(UInt32 framebuffer, UInt32 numsamples, UInt32 pixelindex, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSamplePositionsfvAMD != null, "pglNamedFramebufferSamplePositionsfvAMD not implemented");
					Delegates.pglNamedFramebufferSamplePositionsfvAMD(framebuffer, numsamples, pixelindex, p_values);
					LogFunction("glNamedFramebufferSamplePositionsfvAMD({0}, {1}, {2}, {3})", framebuffer, numsamples, pixelindex, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetFramebufferParameterfvAMD.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numsamples">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pixelindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public static void GetFramebufferParameterAMD(Int32 target, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetFramebufferParameterfvAMD != null, "pglGetFramebufferParameterfvAMD not implemented");
					Delegates.pglGetFramebufferParameterfvAMD(target, pname, numsamples, pixelindex, size, p_values);
					LogFunction("glGetFramebufferParameterfvAMD({0}, {1}, {2}, {3}, {4}, {5})", LogEnumName(target), LogEnumName(pname), numsamples, pixelindex, size, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glGetNamedFramebufferParameterfvAMD.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numsamples">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pixelindex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
		public static void GetNamedFramebufferParameterAMD(UInt32 framebuffer, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetNamedFramebufferParameterfvAMD != null, "pglGetNamedFramebufferParameterfvAMD not implemented");
					Delegates.pglGetNamedFramebufferParameterfvAMD(framebuffer, pname, numsamples, pixelindex, size, p_values);
					LogFunction("glGetNamedFramebufferParameterfvAMD({0}, {1}, {2}, {3}, {4}, {5})", framebuffer, LogEnumName(pname), numsamples, pixelindex, size, LogValue(values));
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferSamplePositionsfvAMD", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferSamplePositionsfvAMD(Int32 target, UInt32 numsamples, UInt32 pixelindex, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferSamplePositionsfvAMD", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferSamplePositionsfvAMD(UInt32 framebuffer, UInt32 numsamples, UInt32 pixelindex, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFramebufferParameterfvAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetFramebufferParameterfvAMD(Int32 target, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetNamedFramebufferParameterfvAMD", ExactSpelling = true)]
			internal extern static unsafe void glGetNamedFramebufferParameterfvAMD(UInt32 framebuffer, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, float* values);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferSamplePositionsfvAMD(Int32 target, UInt32 numsamples, UInt32 pixelindex, float* values);

			[ThreadStatic]
			internal static glFramebufferSamplePositionsfvAMD pglFramebufferSamplePositionsfvAMD;

			[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferSamplePositionsfvAMD(UInt32 framebuffer, UInt32 numsamples, UInt32 pixelindex, float* values);

			[ThreadStatic]
			internal static glNamedFramebufferSamplePositionsfvAMD pglNamedFramebufferSamplePositionsfvAMD;

			[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFramebufferParameterfvAMD(Int32 target, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, float* values);

			[ThreadStatic]
			internal static glGetFramebufferParameterfvAMD pglGetFramebufferParameterfvAMD;

			[RequiredByFeature("GL_AMD_framebuffer_sample_positions")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetNamedFramebufferParameterfvAMD(UInt32 framebuffer, Int32 pname, UInt32 numsamples, UInt32 pixelindex, Int32 size, float* values);

			[ThreadStatic]
			internal static glGetNamedFramebufferParameterfvAMD pglGetNamedFramebufferParameterfvAMD;

		}
	}

}
