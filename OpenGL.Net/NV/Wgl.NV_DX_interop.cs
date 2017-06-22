
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
	public partial class Wgl
	{
		/// <summary>
		/// [WGL] Value of WGL_ACCESS_READ_ONLY_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_READ_ONLY_NV = 0x00000000;

		/// <summary>
		/// [WGL] Value of WGL_ACCESS_READ_WRITE_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_READ_WRITE_NV = 0x00000001;

		/// <summary>
		/// [WGL] Value of WGL_ACCESS_WRITE_DISCARD_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_DX_interop")]
		[Log(BitmaskName = "WGLDXInteropMaskNV")]
		public const int ACCESS_WRITE_DISCARD_NV = 0x00000002;

		/// <summary>
		/// [WGL] Binding for wglDXSetResourceShareHandleNV.
		/// </summary>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="shareHandle">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXSetResourceShareHandleNV != null, "pwglDXSetResourceShareHandleNV not implemented");
			retValue = Delegates.pwglDXSetResourceShareHandleNV(dxObject, shareHandle);
			LogCommand("wglDXSetResourceShareHandleNV", retValue, dxObject, shareHandle			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXOpenDeviceNV.
		/// </summary>
		/// <param name="dxDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXOpenDeviceNV(IntPtr dxDevice)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXOpenDeviceNV != null, "pwglDXOpenDeviceNV not implemented");
			retValue = Delegates.pwglDXOpenDeviceNV(dxDevice);
			LogCommand("wglDXOpenDeviceNV", retValue, dxDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXCloseDeviceNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXCloseDeviceNV(IntPtr hDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXCloseDeviceNV != null, "pwglDXCloseDeviceNV not implemented");
			retValue = Delegates.pwglDXCloseDeviceNV(hDevice);
			LogCommand("wglDXCloseDeviceNV", retValue, hDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXRegisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="dxObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static IntPtr DXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pwglDXRegisterObjectNV != null, "pwglDXRegisterObjectNV not implemented");
			retValue = Delegates.pwglDXRegisterObjectNV(hDevice, dxObject, name, type, access);
			LogCommand("wglDXRegisterObjectNV", retValue, hDevice, dxObject, name, type, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXUnregisterObjectNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXUnregisterObjectNV != null, "pwglDXUnregisterObjectNV not implemented");
			retValue = Delegates.pwglDXUnregisterObjectNV(hDevice, hObject);
			LogCommand("wglDXUnregisterObjectNV", retValue, hDevice, hObject			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXObjectAccessNV.
		/// </summary>
		/// <param name="hObject">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="access">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXObjectNV(IntPtr hObject, Int32 access)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDXObjectAccessNV != null, "pwglDXObjectAccessNV not implemented");
			retValue = Delegates.pwglDXObjectAccessNV(hObject, access);
			LogCommand("wglDXObjectAccessNV", retValue, hObject, access			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXLockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXLockObjectNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXLockObjectsNV != null, "pwglDXLockObjectsNV not implemented");
					retValue = Delegates.pwglDXLockObjectsNV(hDevice, count, p_hObjects);
					LogCommand("wglDXLockObjectsNV", retValue, hDevice, count, hObjects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDXUnlockObjectsNV.
		/// </summary>
		/// <param name="hDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="hObjects">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_DX_interop")]
		public static bool DXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr[] hObjects)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hObjects = hObjects)
				{
					Debug.Assert(Delegates.pwglDXUnlockObjectsNV != null, "pwglDXUnlockObjectsNV not implemented");
					retValue = Delegates.pwglDXUnlockObjectsNV(hDevice, count, p_hObjects);
					LogCommand("wglDXUnlockObjectsNV", retValue, hDevice, count, hObjects					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXSetResourceShareHandleNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXOpenDeviceNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglDXOpenDeviceNV(IntPtr dxDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXCloseDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXCloseDeviceNV(IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXRegisterObjectNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglDXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXUnregisterObjectNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXObjectAccessNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXObjectAccessNV(IntPtr hObject, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXLockObjectsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXLockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXUnlockObjectsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXSetResourceShareHandleNV pwglDXSetResourceShareHandleNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglDXOpenDeviceNV(IntPtr dxDevice);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXOpenDeviceNV pwglDXOpenDeviceNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXCloseDeviceNV(IntPtr hDevice);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXCloseDeviceNV pwglDXCloseDeviceNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglDXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXRegisterObjectNV pwglDXRegisterObjectNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXUnregisterObjectNV pwglDXUnregisterObjectNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXObjectAccessNV(IntPtr hObject, Int32 access);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXObjectAccessNV pwglDXObjectAccessNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXLockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXLockObjectsNV pwglDXLockObjectsNV;

			[RequiredByFeature("WGL_NV_DX_interop")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[RequiredByFeature("WGL_NV_DX_interop")]
			[ThreadStatic]
			internal static wglDXUnlockObjectsNV pwglDXUnlockObjectsNV;

		}
	}

}
