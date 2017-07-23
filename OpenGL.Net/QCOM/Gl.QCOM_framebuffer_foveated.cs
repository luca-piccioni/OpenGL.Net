
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
		/// [GL] Value of GL_FOVEATION_ENABLE_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_ENABLE_BIT_QCOM = 0x00000001;

		/// <summary>
		/// [GL] Value of GL_FOVEATION_SCALED_BIN_METHOD_BIT_QCOM symbol.
		/// </summary>
		[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint FOVEATION_SCALED_BIN_METHOD_BIT_QCOM = 0x00000002;

		/// <summary>
		/// [GL] Binding for glFramebufferFoveationConfigQCOM.
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
					LogCommand("glFramebufferFoveationConfigQCOM", null, framebuffer, numLayers, focalPointsPerLayer, requestedFeatures, providedFeatures					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glFramebufferFoveationParametersQCOM.
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
			LogCommand("glFramebufferFoveationParametersQCOM", null, framebuffer, layer, focalPoint, focalX, focalY, gainX, gainY, foveaArea			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFramebufferFoveationConfigQCOM", ExactSpelling = true)]
			internal extern static unsafe void glFramebufferFoveationConfigQCOM(UInt32 framebuffer, UInt32 numLayers, UInt32 focalPointsPerLayer, UInt32 requestedFeatures, UInt32* providedFeatures);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glFramebufferFoveationParametersQCOM", ExactSpelling = true)]
			internal extern static void glFramebufferFoveationParametersQCOM(UInt32 framebuffer, UInt32 layer, UInt32 focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glFramebufferFoveationConfigQCOM(UInt32 framebuffer, UInt32 numLayers, UInt32 focalPointsPerLayer, UInt32 requestedFeatures, UInt32* providedFeatures);

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferFoveationConfigQCOM pglFramebufferFoveationConfigQCOM;

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal delegate void glFramebufferFoveationParametersQCOM(UInt32 framebuffer, UInt32 layer, UInt32 focalPoint, float focalX, float focalY, float gainX, float gainY, float foveaArea);

			[RequiredByFeature("GL_QCOM_framebuffer_foveated", Api = "gles2")]
			[ThreadStatic]
			internal static glFramebufferFoveationParametersQCOM pglFramebufferFoveationParametersQCOM;

		}
	}

}
