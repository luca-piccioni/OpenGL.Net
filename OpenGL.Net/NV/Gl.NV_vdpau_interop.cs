
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
		/// Binding for glVDPAUInitNV.
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
		/// Binding for glVDPAUInitNV.
		/// </summary>
		/// <param name="vdpDevice">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="getProcAddress">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUInitNV(Object vdpDevice, Object getProcAddress)
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
		/// Binding for glVDPAUFiniNV.
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
		/// Binding for glVDPAURegisterVideoSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numTextureNames">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterVideoSurfaceNV(Object vdpSurface, Int32 target, Int32 numTextureNames, UInt32[] textureNames)
		{
			GCHandle pin_vdpSurface = GCHandle.Alloc(vdpSurface, GCHandleType.Pinned);
			try {
				return (VDPAURegisterVideoSurfaceNV(pin_vdpSurface.AddrOfPinnedObject(), target, numTextureNames, textureNames));
			} finally {
				pin_vdpSurface.Free();
			}
		}

		/// <summary>
		/// Binding for glVDPAURegisterVideoSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, Int32 target, UInt32[] textureNames)
		{
			IntPtr retValue;

			unsafe {
				fixed (UInt32* p_textureNames = textureNames)
				{
					Debug.Assert(Delegates.pglVDPAURegisterVideoSurfaceNV != null, "pglVDPAURegisterVideoSurfaceNV not implemented");
					retValue = Delegates.pglVDPAURegisterVideoSurfaceNV(vdpSurface, target, (Int32)textureNames.Length, p_textureNames);
					LogCommand("glVDPAURegisterVideoSurfaceNV", retValue, vdpSurface, target, textureNames.Length, textureNames					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glVDPAURegisterOutputSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="numTextureNames">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterOutputSurfaceNV(Object vdpSurface, Int32 target, Int32 numTextureNames, UInt32[] textureNames)
		{
			GCHandle pin_vdpSurface = GCHandle.Alloc(vdpSurface, GCHandleType.Pinned);
			try {
				return (VDPAURegisterOutputSurfaceNV(pin_vdpSurface.AddrOfPinnedObject(), target, numTextureNames, textureNames));
			} finally {
				pin_vdpSurface.Free();
			}
		}

		/// <summary>
		/// Binding for glVDPAURegisterOutputSurfaceNV.
		/// </summary>
		/// <param name="vdpSurface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="textureNames">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static IntPtr VDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, Int32 target, UInt32[] textureNames)
		{
			IntPtr retValue;

			unsafe {
				fixed (UInt32* p_textureNames = textureNames)
				{
					Debug.Assert(Delegates.pglVDPAURegisterOutputSurfaceNV != null, "pglVDPAURegisterOutputSurfaceNV not implemented");
					retValue = Delegates.pglVDPAURegisterOutputSurfaceNV(vdpSurface, target, (Int32)textureNames.Length, p_textureNames);
					LogCommand("glVDPAURegisterOutputSurfaceNV", retValue, vdpSurface, target, textureNames.Length, textureNames					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glVDPAUIsSurfaceNV.
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
		/// Binding for glVDPAUUnregisterSurfaceNV.
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
		/// Binding for glVDPAUGetSurfaceivNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="length">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUGetSurfaceNV(IntPtr surface, Int32 pname, Int32[] length, Int32[] values)
		{
			unsafe {
				fixed (Int32* p_length = length)
				fixed (Int32* p_values = values)
				{
					Debug.Assert(Delegates.pglVDPAUGetSurfaceivNV != null, "pglVDPAUGetSurfaceivNV not implemented");
					Delegates.pglVDPAUGetSurfaceivNV(surface, pname, (Int32)values.Length, p_length, p_values);
					LogCommand("glVDPAUGetSurfaceivNV", null, surface, pname, values.Length, length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVDPAUSurfaceAccessNV.
		/// </summary>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vdpau_interop")]
		public static void VDPAUSurfaceNV(IntPtr surface, Int32 access)
		{
			Debug.Assert(Delegates.pglVDPAUSurfaceAccessNV != null, "pglVDPAUSurfaceAccessNV not implemented");
			Delegates.pglVDPAUSurfaceAccessNV(surface, access);
			LogCommand("glVDPAUSurfaceAccessNV", null, surface, access			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVDPAUMapSurfacesNV.
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
					Delegates.pglVDPAUMapSurfacesNV((Int32)surfaces.Length, p_surfaces);
					LogCommand("glVDPAUMapSurfacesNV", null, surfaces.Length, surfaces					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// Binding for glVDPAUUnmapSurfacesNV.
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
					Delegates.pglVDPAUUnmapSurfacesNV((Int32)surfaces.Length, p_surfaces);
					LogCommand("glVDPAUUnmapSurfacesNV", null, surfaces.Length, surfaces					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUInitNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUFiniNV", ExactSpelling = true)]
			internal extern static void glVDPAUFiniNV();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAURegisterVideoSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAURegisterOutputSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUIsSurfaceNV", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool glVDPAUIsSurfaceNV(IntPtr surface);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUUnregisterSurfaceNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUUnregisterSurfaceNV(IntPtr surface);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUGetSurfaceivNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUGetSurfaceivNV(IntPtr surface, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUSurfaceAccessNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUSurfaceAccessNV(IntPtr surface, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUMapSurfacesNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVDPAUUnmapSurfacesNV", ExactSpelling = true)]
			internal extern static unsafe void glVDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUInitNV pglVDPAUInitNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVDPAUFiniNV();

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUFiniNV pglVDPAUFiniNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glVDPAURegisterVideoSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAURegisterVideoSurfaceNV pglVDPAURegisterVideoSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glVDPAURegisterOutputSurfaceNV(IntPtr vdpSurface, Int32 target, Int32 numTextureNames, UInt32* textureNames);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAURegisterOutputSurfaceNV pglVDPAURegisterOutputSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glVDPAUIsSurfaceNV(IntPtr surface);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUIsSurfaceNV pglVDPAUIsSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUUnregisterSurfaceNV(IntPtr surface);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUUnregisterSurfaceNV pglVDPAUUnregisterSurfaceNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUGetSurfaceivNV(IntPtr surface, Int32 pname, Int32 bufSize, Int32* length, Int32* values);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUGetSurfaceivNV pglVDPAUGetSurfaceivNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUSurfaceAccessNV(IntPtr surface, Int32 access);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUSurfaceAccessNV pglVDPAUSurfaceAccessNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUMapSurfacesNV pglVDPAUMapSurfacesNV;

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);

			[RequiredByFeature("GL_NV_vdpau_interop")]
			[ThreadStatic]
			internal static glVDPAUUnmapSurfacesNV pglVDPAUUnmapSurfacesNV;

		}
	}

}
