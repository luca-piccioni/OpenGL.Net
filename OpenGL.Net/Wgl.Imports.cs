
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
using System.Security;
using System.Runtime.InteropServices;

namespace OpenGL
{
	public unsafe partial class Wgl
	{
		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglAllocateMemoryNV", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglAllocateMemoryNV(Int32 size, float readfreq, float writefreq, float priority);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglAssociateImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBeginFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglBeginFrameTrackingI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindDisplayColorTableEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool wglBindDisplayColorTableEXT(UInt16 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindSwapBarrierNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglBindSwapBarrierNV(UInt32 group, UInt32 barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindVideoCaptureDeviceNV(UInt32 uVideoSlot, IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindVideoDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindVideoDeviceNV(IntPtr hDC, UInt32 uVideoSlot, IntPtr hVideoDevice, int* piAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBindVideoImageNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglBlitContextFramebufferAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglChoosePixelFormatARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglChoosePixelFormatEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCopyContext", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCopyImageSubDataNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglCopyImageSubDataNV(IntPtr hSrcRC, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr hDstRC, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAffinityDCNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateAffinityDCNV(IntPtr* phGpuList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglCreateAssociatedContextAMD(UInt32 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateAssociatedContextAttribsAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr hShareContext, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateContext(IntPtr hDc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateContextAttribsARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateDisplayColorTableEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool wglCreateDisplayColorTableEXT(UInt16 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreateLayerContext", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreateLayerContext(IntPtr hDc, int level);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreatePbufferARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglCreatePbufferEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDelayBeforeSwapNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDelayBeforeSwapNV(IntPtr hDC, float seconds);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteAssociatedContextAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglDeleteBufferRegionARB(IntPtr hRegion);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteContext(IntPtr oldContext);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDeleteDCNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDeleteDCNV(IntPtr hdc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDescribeLayerPlane", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, IntPtr* plpd);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyDisplayColorTableEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static void wglDestroyDisplayColorTableEXT(UInt16 id);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyImageBufferI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyPbufferARB(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDestroyPbufferEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDestroyPbufferEXT(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDisableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglDisableFrameLockI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDisableGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDisableGenlockI3D(IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXCloseDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXCloseDeviceNV(IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXLockObjectsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXLockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXObjectAccessNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXObjectAccessNV(IntPtr hObject, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXOpenDeviceNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglDXOpenDeviceNV(IntPtr dxDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXRegisterObjectNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglDXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, Int32 type, Int32 access);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXSetResourceShareHandleNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXUnlockObjectsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglDXUnregisterObjectNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnableFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglEnableFrameLockI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnableGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnableGenlockI3D(IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEndFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglEndFrameTrackingI3D();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumerateVideoCaptureDevicesNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglEnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumerateVideoDevicesNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglEnumerateVideoDevicesNV(IntPtr hDC, IntPtr* phDeviceList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpuDevicesNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpuDevicesNV(IntPtr hGpu, UInt32 iDeviceIndex, IntPtr lpGpuDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpusFromAffinityDCNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpusFromAffinityDCNV(IntPtr hAffinityDC, UInt32 iGpuIndex, IntPtr* hGpu);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglEnumGpusNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglEnumGpusNV(UInt32 iGpuIndex, IntPtr* phGpu);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglFreeMemoryNV", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe void wglFreeMemoryNV(IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSampleRateI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceEdgeI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGenlockSourceI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGenlockSourceI3D(IntPtr hDC, UInt32 uSource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetContextGPUIDAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglGetContextGPUIDAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentAssociatedContextAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentAssociatedContextAMD();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentContext();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentDC();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentReadDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentReadDCARB();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetCurrentReadDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetCurrentReadDCEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetDigitalVideoParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetExtensionsStringARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe string wglGetExtensionsStringARB(IntPtr hdc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetExtensionsStringEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static string wglGetExtensionsStringEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetFrameUsageI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetFrameUsageI3D(float * pUsage);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGammaTableI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGammaTableParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSampleRateI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSampleRateI3D(IntPtr hDC, UInt32* uRate);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceDelayI3D(IntPtr hDC, UInt32* uDelay);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceEdgeI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, UInt32* uEdge);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGenlockSourceI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetGenlockSourceI3D(IntPtr hDC, UInt32* uSource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGPUIDsAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe UInt32 wglGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetGPUInfoAMD", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int32 wglGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetMscRateOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetMscRateOML(IntPtr hdc, Int32* numerator, Int32* denominator);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPbufferDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe IntPtr wglGetPbufferDCEXT(IntPtr hPbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribfvARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribfvEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribivARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetPixelFormatAttribivEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
			internal extern static IntPtr wglGetProcAddress(String lpszProc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetSwapIntervalEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static int wglGetSwapIntervalEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetSyncValuesOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetSyncValuesOML(IntPtr hdc, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetVideoDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglGetVideoInfoNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglGetVideoInfoNV(IntPtr hpVideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglIsEnabledFrameLockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglIsEnabledFrameLockI3D(bool* pFlag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglIsEnabledGenlockI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglJoinSwapGroupNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglJoinSwapGroupNV(IntPtr hDC, UInt32 group);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglLoadDisplayColorTableEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static unsafe bool wglLoadDisplayColorTableEXT(UInt16* table, UInt32 length);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglLockVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglLockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeAssociatedContextCurrentAMD", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeAssociatedContextCurrentAMD(IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeContextCurrentARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeContextCurrentEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglMakeCurrent(IntPtr hDc, IntPtr newContext);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryCurrentContextNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryCurrentContextNV(int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryFrameCountNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameCountNV(IntPtr hDC, UInt32* count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryFrameLockMasterI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameLockMasterI3D(bool* pFlag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryFrameTrackingI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryFrameTrackingI3D(Int32* pFrameCount, Int32* pMissedFrames, float * pLastMissedUsage);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, UInt32* uMaxLineDelay, UInt32* uMaxPixelDelay);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryMaxSwapGroupsNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryMaxSwapGroupsNV(IntPtr hDC, UInt32* maxGroups, UInt32* maxBarriers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryPbufferARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryPbufferEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQuerySwapGroupNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQuerySwapGroupNV(IntPtr hDC, UInt32* group, UInt32* barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglQueryVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglQueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglRealizeLayerPalette", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseImageBufferEventsI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleasePbufferDCARB", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleasePbufferDCEXT", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseTexImageARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoCaptureDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoDeviceNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoDeviceNV(IntPtr hVideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglReleaseVideoImageNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglResetFrameCountNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglResetFrameCountNV(IntPtr hDC);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglRestoreBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSaveBufferRegionARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSendPbufferToVideoNV", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetDigitalVideoParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetGammaTableI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetGammaTableParametersI3D", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetLayerPaletteEntries", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetPbufferAttribARB", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSetStereoEmitterState3DL", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSetStereoEmitterState3DL(IntPtr hDC, UInt32 uState);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapBuffersMscOML", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int64 wglSwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapLayerBuffers", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglSwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapIntervalEXT", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static bool wglSwapIntervalEXT(int interval);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglSwapLayerBuffersMscOML", ExactSpelling = true, SetLastError = true)]
			internal extern static unsafe Int64 wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontBitmaps", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmaps(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontBitmapsA", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontBitmapsW", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontOutlines", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlines(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontOutlinesA", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglUseFontOutlinesW", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglUseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglWaitForMscOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglWaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "wglWaitForSbcOML", ExactSpelling = true, SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			internal extern static unsafe bool wglWaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

		}
	}

}
