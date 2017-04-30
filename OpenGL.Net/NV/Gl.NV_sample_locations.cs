
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
		/// Binding for glFramebufferSampleLocationsfvNV.
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void FramebufferSampleLocationNV(FramebufferTarget target, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvNV != null, "pglFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglFramebufferSampleLocationsfvNV((Int32)target, start, count, p_v);
					LogCommand("glFramebufferSampleLocationsfvNV", null, target, start, count, v					);
				}
			}
			DebugCheckErrors(null);
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void NamedFramebufferSampleLocationNV(UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvNV != null, "pglNamedFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvNV(framebuffer, start, count, p_v);
					LogCommand("glNamedFramebufferSampleLocationsfvNV", null, framebuffer, start, count, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glResolveDepthValuesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
		public static void ResolveDepthValuesNV()
		{
			Debug.Assert(Delegates.pglResolveDepthValuesNV != null, "pglResolveDepthValuesNV not implemented");
			Delegates.pglResolveDepthValuesNV();
			LogCommand("glResolveDepthValuesNV", null			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferSampleLocationsfvNV", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferSampleLocationsfvNV(Int32 target, UInt32 start, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNamedFramebufferSampleLocationsfvNV", ExactSpelling = true)]
			internal extern static unsafe void glNamedFramebufferSampleLocationsfvNV(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glResolveDepthValuesNV", ExactSpelling = true)]
			internal extern static void glResolveDepthValuesNV();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferSampleLocationsfvNV(Int32 target, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glFramebufferSampleLocationsfvNV pglFramebufferSampleLocationsfvNV;

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNamedFramebufferSampleLocationsfvNV(UInt32 framebuffer, UInt32 start, Int32 count, float* v);

			[ThreadStatic]
			internal static glNamedFramebufferSampleLocationsfvNV pglNamedFramebufferSampleLocationsfvNV;

			[RequiredByFeature("GL_NV_sample_locations", Api = "gl|glcore|gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glResolveDepthValuesNV();

			[ThreadStatic]
			internal static glResolveDepthValuesNV pglResolveDepthValuesNV;

		}
	}

}
