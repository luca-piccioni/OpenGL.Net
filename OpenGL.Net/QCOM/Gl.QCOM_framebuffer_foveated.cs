
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
		/// Value of GL_FOVEATION_ENABLE_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_ENABLE_BIT_QCOM = 0x00000001;

		/// <summary>
		/// Value of GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;

		/// <summary>
		/// Binding for glFramebufferFoveationConfigQCOM.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="numLayers">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="focalPointsPerLayer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="requestedFeatures">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="providedFeatures">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		public static void FramebufferQCOM(UInt32 framebuffer, UInt32 numLayers, UInt32 focalPointsPerLayer, UInt32 requestedFeatures, UInt32[] providedFeatures)
		{
			unsafe {
				fixed (UInt32* p_providedFeatures = providedFeatures)
				{
					Debug.Assert(Delegates.pglFramebufferFoveationConfigQCOM != null, "pglFramebufferFoveationConfigQCOM not implemented");
					Delegates.pglFramebufferFoveationConfigQCOM(framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, p_providedFeatures);
					LogFunction("glFramebufferFoveationConfigQCOM({0}, {1}, {2}, {3}, {4})", framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, LogValue(providedFeatures));
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glFramebufferFoveationParametersQCOM.
		/// </summary>
		/// <param name="framebuffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="layer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="focalPoint">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="focalX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="focalY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="gainX">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="gainY">
		/// A <see cref="T:float"/>.
		/// </param>
		/// <param name="foveaArea">
		/// A <see cref="T:float"/>.
		/// </param>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		public static void FramebufferFoveationParametersQCOM(UInt32 framebuffer, UInt32 layer, UInt32 focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea)
		{
			Debug.Assert(Delegates.pglFramebufferFoveationParametersQCOM != null, "pglFramebufferFoveationParametersQCOM not implemented");
			Delegates.pglFramebufferFoveationParametersQCOM(framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
			LogFunction("glFramebufferFoveationParametersQCOM({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferFoveationConfigQCOM", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferFoveationConfigQCOM(UInt32 framebuffer, UInt32 numLayers, UInt32 focalPointsPerLayer, UInt32 requestedFeatures, UInt32* providedFeatures);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFramebufferFoveationParametersQCOM", ExactSpelling = true)]
			internal extern static void glFramebufferFoveationParametersQCOM(UInt32 framebuffer, UInt32 layer, UInt32 focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFramebufferFoveationConfigQCOM(UInt32 framebuffer, UInt32 numLayers, UInt32 focalPointsPerLayer, UInt32 requestedFeatures, UInt32* providedFeatures);

			[ThreadStatic]
			internal static glFramebufferFoveationConfigQCOM pglFramebufferFoveationConfigQCOM;

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFramebufferFoveationParametersQCOM(UInt32 framebuffer, UInt32 layer, UInt32 focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);

			[ThreadStatic]
			internal static glFramebufferFoveationParametersQCOM pglFramebufferFoveationParametersQCOM;

		}
	}

}
