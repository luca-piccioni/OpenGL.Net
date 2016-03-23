
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
		/// Binding for glFramebufferSampleLocationsfvNV.
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public static void FramebufferSampleLocationNV(Int32 target, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglFramebufferSampleLocationsfvNV != null, "pglFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglFramebufferSampleLocationsfvNV(target, start, count, p_v);
					LogFunction("glFramebufferSampleLocationsfvNV({0}, {1}, {2}, {3})", LogEnumName(target), start, count, LogValue(v));
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
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public static void NamedFramebufferSampleLocationNV(UInt32 framebuffer, UInt32 start, Int32 count, float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNamedFramebufferSampleLocationsfvNV != null, "pglNamedFramebufferSampleLocationsfvNV not implemented");
					Delegates.pglNamedFramebufferSampleLocationsfvNV(framebuffer, start, count, p_v);
					LogFunction("glNamedFramebufferSampleLocationsfvNV({0}, {1}, {2}, {3})", framebuffer, start, count, LogValue(v));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glResolveDepthValuesNV.
		/// </summary>
		[RequiredByFeature("GL_NV_sample_locations", Api = "gl|gles2")]
		public static void ResolveDepthValuesNV()
		{
			Debug.Assert(Delegates.pglResolveDepthValuesNV != null, "pglResolveDepthValuesNV not implemented");
			Delegates.pglResolveDepthValuesNV();
			LogFunction("glResolveDepthValuesNV()");
			DebugCheckErrors(null);
		}

	}

}
