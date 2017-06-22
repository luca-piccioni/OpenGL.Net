
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
		/// [WGL] Value of ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public const int ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV = 0x20D0;

		/// <summary>
		/// [WGL] Value of ERROR_MISSING_AFFINITY_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public const int ERROR_MISSING_AFFINITY_MASK_NV = 0x20D1;

		/// <summary>
		/// [WGL] Binding for wglEnumGpusNV.
		/// </summary>
		/// <param name="iGpuIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="phGpu">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public static bool EnumGpusNV(UInt32 iGpuIndex, IntPtr[] phGpu)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_phGpu = phGpu)
				{
					Debug.Assert(Delegates.pwglEnumGpusNV != null, "pwglEnumGpusNV not implemented");
					retValue = Delegates.pwglEnumGpusNV(iGpuIndex, p_phGpu);
					LogCommand("wglEnumGpusNV", retValue, iGpuIndex, phGpu					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglEnumGpuDevicesNV.
		/// </summary>
		/// <param name="hGpu">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iDeviceIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="lpGpuDevice">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public static bool EnumGpuDevicesNV(IntPtr hGpu, UInt32 iDeviceIndex, IntPtr lpGpuDevice)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglEnumGpuDevicesNV != null, "pwglEnumGpuDevicesNV not implemented");
			retValue = Delegates.pwglEnumGpuDevicesNV(hGpu, iDeviceIndex, lpGpuDevice);
			LogCommand("wglEnumGpuDevicesNV", retValue, hGpu, iDeviceIndex, lpGpuDevice			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglCreateAffinityDCNV.
		/// </summary>
		/// <param name="phGpuList">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public static IntPtr CreateAffinityDCNV(IntPtr[] phGpuList)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_phGpuList = phGpuList)
				{
					Debug.Assert(Delegates.pwglCreateAffinityDCNV != null, "pwglCreateAffinityDCNV not implemented");
					retValue = Delegates.pwglCreateAffinityDCNV(p_phGpuList);
					LogCommand("wglCreateAffinityDCNV", retValue, phGpuList					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglEnumGpusFromAffinityDCNV.
		/// </summary>
		/// <param name="hAffinityDC">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="iGpuIndex">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="hGpu">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public static bool EnumGpusFromAffinityDCNV(IntPtr hAffinityDC, UInt32 iGpuIndex, IntPtr[] hGpu)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_hGpu = hGpu)
				{
					Debug.Assert(Delegates.pwglEnumGpusFromAffinityDCNV != null, "pwglEnumGpusFromAffinityDCNV not implemented");
					retValue = Delegates.pwglEnumGpusFromAffinityDCNV(hAffinityDC, iGpuIndex, p_hGpu);
					LogCommand("wglEnumGpusFromAffinityDCNV", retValue, hAffinityDC, iGpuIndex, hGpu					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [WGL] Binding for wglDeleteDCNV.
		/// </summary>
		/// <param name="hdc">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public static bool DeleteDCNV(IntPtr hdc)
		{
			bool retValue;

			Debug.Assert(Delegates.pwglDeleteDCNV != null, "pwglDeleteDCNV not implemented");
			retValue = Delegates.pwglDeleteDCNV(hdc);
			LogCommand("wglDeleteDCNV", retValue, hdc			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpusNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpusNV(UInt32 iGpuIndex, IntPtr* phGpu);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpuDevicesNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpuDevicesNV(IntPtr hGpu, UInt32 iDeviceIndex, IntPtr lpGpuDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAffinityDCNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateAffinityDCNV(IntPtr* phGpuList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpusFromAffinityDCNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpusFromAffinityDCNV(IntPtr hAffinityDC, UInt32 iGpuIndex, IntPtr* hGpu);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteDCNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteDCNV(IntPtr hdc);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpusNV(UInt32 iGpuIndex, IntPtr* phGpu);

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[ThreadStatic]
			internal static wglEnumGpusNV pwglEnumGpusNV;

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpuDevicesNV(IntPtr hGpu, UInt32 iDeviceIndex, IntPtr lpGpuDevice);

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[ThreadStatic]
			internal static wglEnumGpuDevicesNV pwglEnumGpuDevicesNV;

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateAffinityDCNV(IntPtr* phGpuList);

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[ThreadStatic]
			internal static wglCreateAffinityDCNV pwglCreateAffinityDCNV;

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpusFromAffinityDCNV(IntPtr hAffinityDC, UInt32 iGpuIndex, IntPtr* hGpu);

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[ThreadStatic]
			internal static wglEnumGpusFromAffinityDCNV pwglEnumGpusFromAffinityDCNV;

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDeleteDCNV(IntPtr hdc);

			[RequiredByFeature("WGL_NV_gpu_affinity")]
			[ThreadStatic]
			internal static wglDeleteDCNV pwglDeleteDCNV;

		}
	}

}
