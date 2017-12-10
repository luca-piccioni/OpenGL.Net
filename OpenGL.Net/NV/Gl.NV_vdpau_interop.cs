
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_SURFACE_STATE_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public const int SURFACE_STATE_NV = 0x86EB;

		/// <summary>
		/// [GL] Value of GL_SURFACE_REGISTERED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public const int SURFACE_REGISTERED_NV = 0x86FD;

		/// <summary>
		/// [GL] Value of GL_SURFACE_MAPPED_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public const int SURFACE_MAPPED_NV = 0x8700;

		/// <summary>
		/// [GL] Value of GL_WRITE_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public const int WRITE_DISCARD_NV = 0x88BE;

		/// <summary>
		/// [GL] glVDPAUInitNV: Binding for glVDPAUInitNV.
		/// </summary>
		/// <param name="vdpDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="getProcAddress">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress)
		{
			Debug.Assert(Delegates.pglVDPAUInitNV != null, "pglVDPAUInitNV not implemented");
			Delegates.pglVDPAUInitNV(vdpDevice, getProcAddress);
			LogCommand("glVDPAUInitNV", null, vdpDevice, getProcAddress			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAUInitNV: Binding for glVDPAUInitNV.
		/// </summary>
		/// <param name="vdpDevice">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="getProcAddress">
		/// A <see cref="T:object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUInitNV(object vdpDevice, object getProcAddress)
		{
			GCHandle pin_vdpDevice = GCHandle.Alloc(vdpDevice, GCHandleType.Pinned);
			GCHandle pin_getProcAddress = GCHandle.Alloc(getProcAddress, GCHandleType.Pinned);
			try {
				VDPAUInitNV(pin_vdpDevice.AddrOfPinnedObject(), pin_getProcAddress.AddrOfPinnedObject());
			} finally {
				pin_vdpDevice.Free();
				pin_getProcAddress.Free();
			}
		}

		/// <summary>
		/// [GL] glVDPAUFiniNV: Binding for glVDPAUFiniNV.
		/// </summary>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUNV()
		{
			Debug.Assert(Delegates.pglVDPAUFiniNV != null, "pglVDPAUFiniNV not implemented");
			Delegates.pglVDPAUFiniNV();
			LogCommand("glVDPAUFiniNV", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAURegisterVideoSurfaceNV: Binding for glVDPAURegisterVideoSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numTextureNames">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterVideoSurfaceNV(object vdpSurface, int target, int numTextureNames, uint[] textureNames)
		{
			GCHandle pin_vdpSurface = GCHandle.Alloc(vdpSurface, GCHandleType.Pinned);
			try {
				return (VDPAURegisterVideoSurfaceNV(pin_vdpSurface.AddrOfPinnedObject(), target, numTextureNames, textureNames));
			} finally {
				pin_vdpSurface.Free();
			}
		}

		/// <summary>
		/// [GL] glVDPAURegisterVideoSurfaceNV: Binding for glVDPAURegisterVideoSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, int target, uint[] textureNames)
		{
			IntPtr retValue;

			unsafe {
				fixed (uint* p_textureNames = textureNames)
				{
					Debug.Assert(Delegates.pglVDPAURegisterVideoSurfaceNV != null, "pglVDPAURegisterVideoSurfaceNV not implemented");
					retValue = Delegates.pglVDPAURegisterVideoSurfaceNV(vdpSurface, target, textureNames.Length, p_textureNames);
					LogCommand("glVDPAURegisterVideoSurfaceNV", retValue, vdpSurface, target, textureNames.Length, textureNames					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glVDPAURegisterOutputSurfaceNV: Binding for glVDPAURegisterOutputSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:object"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="numTextureNames">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterOutputSurfaceNV(object vdpSurface, int target, int numTextureNames, uint[] textureNames)
		{
			GCHandle pin_vdpSurface = GCHandle.Alloc(vdpSurface, GCHandleType.Pinned);
			try {
				return (VDPAURegisterOutputSurfaceNV(pin_vdpSurface.AddrOfPinnedObject(), target, numTextureNames, textureNames));
			} finally {
				pin_vdpSurface.Free();
			}
		}

		/// <summary>
		/// [GL] glVDPAURegisterOutputSurfaceNV: Binding for glVDPAURegisterOutputSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, int target, uint[] textureNames)
		{
			IntPtr retValue;

			unsafe {
				fixed (uint* p_textureNames = textureNames)
				{
					Debug.Assert(Delegates.pglVDPAURegisterOutputSurfaceNV != null, "pglVDPAURegisterOutputSurfaceNV not implemented");
					retValue = Delegates.pglVDPAURegisterOutputSurfaceNV(vdpSurface, target, textureNames.Length, p_textureNames);
					LogCommand("glVDPAURegisterOutputSurfaceNV", retValue, vdpSurface, target, textureNames.Length, textureNames					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glVDPAUIsSurfaceNV: Binding for glVDPAUIsSurfaceNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static bool VDPAUIsSurfaceNV(IntPtr surface)
		{
			bool retValue;

			Debug.Assert(Delegates.pglVDPAUIsSurfaceNV != null, "pglVDPAUIsSurfaceNV not implemented");
			retValue = Delegates.pglVDPAUIsSurfaceNV(surface);
			LogCommand("glVDPAUIsSurfaceNV", retValue, surface			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glVDPAUUnregisterSurfaceNV: Binding for glVDPAUUnregisterSurfaceNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUUnregisterSurfaceNV(IntPtr surface)
		{
			Debug.Assert(Delegates.pglVDPAUUnregisterSurfaceNV != null, "pglVDPAUUnregisterSurfaceNV not implemented");
			Delegates.pglVDPAUUnregisterSurfaceNV(surface);
			LogCommand("glVDPAUUnregisterSurfaceNV", null, surface			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAUGetSurfaceivNV: Binding for glVDPAUGetSurfaceivNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUGetSurfaceNV(IntPtr surface, int pname, int[] length, int[] values)
		{
			unsafe {
				fixed (int* p_length = length)
				fixed (int* p_values = values)
				{
					Debug.Assert(Delegates.pglVDPAUGetSurfaceivNV != null, "pglVDPAUGetSurfaceivNV not implemented");
					Delegates.pglVDPAUGetSurfaceivNV(surface, pname, values.Length, p_length, p_values);
					LogCommand("glVDPAUGetSurfaceivNV", null, surface, pname, values.Length, length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAUSurfaceAccessNV: Binding for glVDPAUSurfaceAccessNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUSurfaceNV(IntPtr surface, int access)
		{
			Debug.Assert(Delegates.pglVDPAUSurfaceAccessNV != null, "pglVDPAUSurfaceAccessNV not implemented");
			Delegates.pglVDPAUSurfaceAccessNV(surface, access);
			LogCommand("glVDPAUSurfaceAccessNV", null, surface, access			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAUMapSurfacesNV: Binding for glVDPAUMapSurfacesNV.
		/// </summary>
		/// <param name="surfaces">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUMapSurfaceNV(IntPtr[] surfaces)
		{
			unsafe {
				fixed (IntPtr* p_surfaces = surfaces)
				{
					Debug.Assert(Delegates.pglVDPAUMapSurfacesNV != null, "pglVDPAUMapSurfacesNV not implemented");
					Delegates.pglVDPAUMapSurfacesNV(surfaces.Length, p_surfaces);
					LogCommand("glVDPAUMapSurfacesNV", null, surfaces.Length, surfaces					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVDPAUUnmapSurfacesNV: Binding for glVDPAUUnmapSurfacesNV.
		/// </summary>
		/// <param name="surfaces">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUUnmapSurfaceNV(IntPtr[] surfaces)
		{
			unsafe {
				fixed (IntPtr* p_surfaces = surfaces)
				{
					Debug.Assert(Delegates.pglVDPAUUnmapSurfacesNV != null, "pglVDPAUUnmapSurfacesNV not implemented");
					Delegates.pglVDPAUUnmapSurfacesNV(surfaces.Length, p_surfaces);
					LogCommand("glVDPAUUnmapSurfacesNV", null, surfaces.Length, surfaces					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUInitNV pglVDPAUInitNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUFiniNV();

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUFiniNV pglVDPAUFiniNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, int target, int numTextureNames, uint* textureNames);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAURegisterVideoSurfaceNV pglVDPAURegisterVideoSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, int target, int numTextureNames, uint* textureNames);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAURegisterOutputSurfaceNV pglVDPAURegisterOutputSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glVDPAUIsSurfaceNV(IntPtr surface);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUIsSurfaceNV pglVDPAUIsSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUUnregisterSurfaceNV(IntPtr surface);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUUnregisterSurfaceNV pglVDPAUUnregisterSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUGetSurfaceivNV(IntPtr surface, int pname, int bufSize, int* length, int* values);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUGetSurfaceivNV pglVDPAUGetSurfaceivNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUSurfaceAccessNV(IntPtr surface, int access);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUSurfaceAccessNV pglVDPAUSurfaceAccessNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUMapSurfacesNV(int numSurfaces, IntPtr* surfaces);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUMapSurfacesNV pglVDPAUMapSurfacesNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glVDPAUUnmapSurfacesNV(int numSurface, IntPtr* surfaces);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUUnmapSurfacesNV pglVDPAUUnmapSurfacesNV;

		}
	}

}
