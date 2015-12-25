
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

#pragma warning disable 1734

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Value of ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public const int ERROR_INCOMPATIBLE_AFFINITY_MASKS_NV = 0x20D0;

		/// <summary>
		/// Value of ERROR_MISSING_AFFINITY_MASK_NV symbol.
		/// </summary>
		[RequiredByFeature("WGL_NV_gpu_affinity")]
		public const int ERROR_MISSING_AFFINITY_MASK_NV = 0x20D1;

		/// <summary>
		/// Binding for wglEnumGpusNV.
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
					LogFunction("wglEnumGpusNV({0}, {1}) = {2}", iGpuIndex, phGpu, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglEnumGpuDevicesNV.
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
			LogFunction("wglEnumGpuDevicesNV(0x{0}, {1}, 0x{2}) = {3}", hGpu.ToString("X8"), iDeviceIndex, lpGpuDevice.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglCreateAffinityDCNV.
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
					LogFunction("wglCreateAffinityDCNV({0}) = {1}", phGpuList, retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglEnumGpusFromAffinityDCNV.
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
					LogFunction("wglEnumGpusFromAffinityDCNV(0x{0}, {1}, {2}) = {3}", hAffinityDC.ToString("X8"), iGpuIndex, hGpu, retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for wglDeleteDCNV.
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
			LogFunction("wglDeleteDCNV(0x{0}) = {1}", hdc.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
