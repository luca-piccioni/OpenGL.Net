
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Security;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public unsafe partial class Wgl
	{
		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglAllocateMemoryNV(Int32 size, float readfreq, float writefreq, float priority);
			[ThreadStatic]
			internal static wglAllocateMemoryNV pwglAllocateMemoryNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr* pAddress, Int32* pSize, UInt32 count);
			[ThreadStatic]
			internal static wglAssociateImageBufferEventsI3D pwglAssociateImageBufferEventsI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglBeginFrameTrackingI3D();
			[ThreadStatic]
			internal static wglBeginFrameTrackingI3D pwglBeginFrameTrackingI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglBindDisplayColorTableEXT(UInt16 id);
			[ThreadStatic]
			internal static wglBindDisplayColorTableEXT pwglBindDisplayColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglBindSwapBarrierNV(UInt32 group, UInt32 barrier);
			[ThreadStatic]
			internal static wglBindSwapBarrierNV pwglBindSwapBarrierNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer);
			[ThreadStatic]
			internal static wglBindTexImageARB pwglBindTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindVideoCaptureDeviceNV(UInt32 uVideoSlot, IntPtr hDevice);
			[ThreadStatic]
			internal static wglBindVideoCaptureDeviceNV pwglBindVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindVideoDeviceNV(IntPtr hDC, UInt32 uVideoSlot, IntPtr hVideoDevice, int* piAttribList);
			[ThreadStatic]
			internal static wglBindVideoDeviceNV pwglBindVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglBindVideoImageNV(IntPtr hVideoDevice, IntPtr hPbuffer, int iVideoBuffer);
			[ThreadStatic]
			internal static wglBindVideoImageNV pwglBindVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wglBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, uint mask, int filter);
			[ThreadStatic]
			internal static wglBlitContextFramebufferAMD pwglBlitContextFramebufferAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);
			[ThreadStatic]
			internal static wglChoosePixelFormatARB pwglChoosePixelFormatARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, float* pfAttribFList, UInt32 nMaxFormats, int* piFormats, UInt32* nNumFormats);
			[ThreadStatic]
			internal static wglChoosePixelFormatEXT pwglChoosePixelFormatEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
			[ThreadStatic]
			internal static wglCopyContext pwglCopyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglCopyImageSubDataNV(IntPtr hSrcRC, UInt32 srcName, int srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr hDstRC, UInt32 dstName, int dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static wglCopyImageSubDataNV pwglCopyImageSubDataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateAffinityDCNV(IntPtr* phGpuList);
			[ThreadStatic]
			internal static wglCreateAffinityDCNV pwglCreateAffinityDCNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglCreateAssociatedContextAMD(UInt32 id);
			[ThreadStatic]
			internal static wglCreateAssociatedContextAMD pwglCreateAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr hShareContext, int* attribList);
			[ThreadStatic]
			internal static wglCreateAssociatedContextAttribsAMD pwglCreateAssociatedContextAttribsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
			[ThreadStatic]
			internal static wglCreateBufferRegionARB pwglCreateBufferRegionARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateContext(IntPtr hDc);
			[ThreadStatic]
			internal static wglCreateContext pwglCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateContextAttribsARB(IntPtr hDC, IntPtr hShareContext, int* attribList);
			[ThreadStatic]
			internal static wglCreateContextAttribsARB pwglCreateContextAttribsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglCreateDisplayColorTableEXT(UInt16 id);
			[ThreadStatic]
			internal static wglCreateDisplayColorTableEXT pwglCreateDisplayColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
			[ThreadStatic]
			internal static wglCreateImageBufferI3D pwglCreateImageBufferI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreateLayerContext(IntPtr hDc, int level);
			[ThreadStatic]
			internal static wglCreateLayerContext pwglCreateLayerContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
			[ThreadStatic]
			internal static wglCreatePbufferARB pwglCreatePbufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
			[ThreadStatic]
			internal static wglCreatePbufferEXT pwglCreatePbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDelayBeforeSwapNV(IntPtr hDC, float seconds);
			[ThreadStatic]
			internal static wglDelayBeforeSwapNV pwglDelayBeforeSwapNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDeleteAssociatedContextAMD(IntPtr hglrc);
			[ThreadStatic]
			internal static wglDeleteAssociatedContextAMD pwglDeleteAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wglDeleteBufferRegionARB(IntPtr hRegion);
			[ThreadStatic]
			internal static wglDeleteBufferRegionARB pwglDeleteBufferRegionARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDeleteContext(IntPtr oldContext);
			[ThreadStatic]
			internal static wglDeleteContext pwglDeleteContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDeleteDCNV(IntPtr hdc);
			[ThreadStatic]
			internal static wglDeleteDCNV pwglDeleteDCNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, IntPtr* plpd);
			[ThreadStatic]
			internal static wglDescribeLayerPlane pwglDescribeLayerPlane;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void wglDestroyDisplayColorTableEXT(UInt16 id);
			[ThreadStatic]
			internal static wglDestroyDisplayColorTableEXT pwglDestroyDisplayColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);
			[ThreadStatic]
			internal static wglDestroyImageBufferI3D pwglDestroyImageBufferI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDestroyPbufferARB(IntPtr hPbuffer);
			[ThreadStatic]
			internal static wglDestroyPbufferARB pwglDestroyPbufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDestroyPbufferEXT(IntPtr hPbuffer);
			[ThreadStatic]
			internal static wglDestroyPbufferEXT pwglDestroyPbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglDisableFrameLockI3D();
			[ThreadStatic]
			internal static wglDisableFrameLockI3D pwglDisableFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDisableGenlockI3D(IntPtr hDC);
			[ThreadStatic]
			internal static wglDisableGenlockI3D pwglDisableGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXCloseDeviceNV(IntPtr hDevice);
			[ThreadStatic]
			internal static wglDXCloseDeviceNV pwglDXCloseDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXLockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);
			[ThreadStatic]
			internal static wglDXLockObjectsNV pwglDXLockObjectsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXObjectAccessNV(IntPtr hObject, int access);
			[ThreadStatic]
			internal static wglDXObjectAccessNV pwglDXObjectAccessNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglDXOpenDeviceNV(IntPtr dxDevice);
			[ThreadStatic]
			internal static wglDXOpenDeviceNV pwglDXOpenDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglDXRegisterObjectNV(IntPtr hDevice, IntPtr dxObject, UInt32 name, int type, int access);
			[ThreadStatic]
			internal static wglDXRegisterObjectNV pwglDXRegisterObjectNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXSetResourceShareHandleNV(IntPtr dxObject, IntPtr shareHandle);
			[ThreadStatic]
			internal static wglDXSetResourceShareHandleNV pwglDXSetResourceShareHandleNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXUnlockObjectsNV(IntPtr hDevice, Int32 count, IntPtr* hObjects);
			[ThreadStatic]
			internal static wglDXUnlockObjectsNV pwglDXUnlockObjectsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglDXUnregisterObjectNV(IntPtr hDevice, IntPtr hObject);
			[ThreadStatic]
			internal static wglDXUnregisterObjectNV pwglDXUnregisterObjectNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglEnableFrameLockI3D();
			[ThreadStatic]
			internal static wglEnableFrameLockI3D pwglEnableFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnableGenlockI3D(IntPtr hDC);
			[ThreadStatic]
			internal static wglEnableGenlockI3D pwglEnableGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglEndFrameTrackingI3D();
			[ThreadStatic]
			internal static wglEndFrameTrackingI3D pwglEndFrameTrackingI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglEnumerateVideoCaptureDevicesNV(IntPtr hDc, IntPtr* phDeviceList);
			[ThreadStatic]
			internal static wglEnumerateVideoCaptureDevicesNV pwglEnumerateVideoCaptureDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglEnumerateVideoDevicesNV(IntPtr hDC, IntPtr* phDeviceList);
			[ThreadStatic]
			internal static wglEnumerateVideoDevicesNV pwglEnumerateVideoDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpuDevicesNV(IntPtr hGpu, UInt32 iDeviceIndex, IntPtr lpGpuDevice);
			[ThreadStatic]
			internal static wglEnumGpuDevicesNV pwglEnumGpuDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpusFromAffinityDCNV(IntPtr hAffinityDC, UInt32 iGpuIndex, IntPtr* hGpu);
			[ThreadStatic]
			internal static wglEnumGpusFromAffinityDCNV pwglEnumGpusFromAffinityDCNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglEnumGpusNV(UInt32 iGpuIndex, IntPtr* phGpu);
			[ThreadStatic]
			internal static wglEnumGpusNV pwglEnumGpusNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void wglFreeMemoryNV(IntPtr pointer);
			[ThreadStatic]
			internal static wglFreeMemoryNV pwglFreeMemoryNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
			[ThreadStatic]
			internal static wglGenlockSampleRateI3D pwglGenlockSampleRateI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
			[ThreadStatic]
			internal static wglGenlockSourceDelayI3D pwglGenlockSourceDelayI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
			[ThreadStatic]
			internal static wglGenlockSourceEdgeI3D pwglGenlockSourceEdgeI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGenlockSourceI3D(IntPtr hDC, UInt32 uSource);
			[ThreadStatic]
			internal static wglGenlockSourceI3D pwglGenlockSourceI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglGetContextGPUIDAMD(IntPtr hglrc);
			[ThreadStatic]
			internal static wglGetContextGPUIDAMD pwglGetContextGPUIDAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentAssociatedContextAMD();
			[ThreadStatic]
			internal static wglGetCurrentAssociatedContextAMD pwglGetCurrentAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentContext();
			[ThreadStatic]
			internal static wglGetCurrentContext pwglGetCurrentContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentDC();
			[ThreadStatic]
			internal static wglGetCurrentDC pwglGetCurrentDC;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentReadDCARB();
			[ThreadStatic]
			internal static wglGetCurrentReadDCARB pwglGetCurrentReadDCARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetCurrentReadDCEXT();
			[ThreadStatic]
			internal static wglGetCurrentReadDCEXT pwglGetCurrentReadDCEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglGetDigitalVideoParametersI3D pwglGetDigitalVideoParametersI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate string wglGetExtensionsStringARB(IntPtr hdc);
			[ThreadStatic]
			internal static wglGetExtensionsStringARB pwglGetExtensionsStringARB;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate string wglGetExtensionsStringEXT();
			[ThreadStatic]
			internal static wglGetExtensionsStringEXT pwglGetExtensionsStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetFrameUsageI3D(float * pUsage);
			[ThreadStatic]
			internal static wglGetFrameUsageI3D pwglGetFrameUsageI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
			[ThreadStatic]
			internal static wglGetGammaTableI3D pwglGetGammaTableI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglGetGammaTableParametersI3D pwglGetGammaTableParametersI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSampleRateI3D(IntPtr hDC, UInt32* uRate);
			[ThreadStatic]
			internal static wglGetGenlockSampleRateI3D pwglGetGenlockSampleRateI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceDelayI3D(IntPtr hDC, UInt32* uDelay);
			[ThreadStatic]
			internal static wglGetGenlockSourceDelayI3D pwglGetGenlockSourceDelayI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, UInt32* uEdge);
			[ThreadStatic]
			internal static wglGetGenlockSourceEdgeI3D pwglGetGenlockSourceEdgeI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetGenlockSourceI3D(IntPtr hDC, UInt32* uSource);
			[ThreadStatic]
			internal static wglGetGenlockSourceI3D pwglGetGenlockSourceI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 wglGetGPUIDsAMD(UInt32 maxCount, UInt32* ids);
			[ThreadStatic]
			internal static wglGetGPUIDsAMD pwglGetGPUIDsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 wglGetGPUInfoAMD(UInt32 id, int property, int dataType, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static wglGetGPUInfoAMD pwglGetGPUInfoAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);
			[ThreadStatic]
			internal static wglGetLayerPaletteEntries pwglGetLayerPaletteEntries;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetMscRateOML(IntPtr hdc, Int32* numerator, Int32* denominator);
			[ThreadStatic]
			internal static wglGetMscRateOML pwglGetMscRateOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglGetPbufferDCARB(IntPtr hPbuffer);
			[ThreadStatic]
			internal static wglGetPbufferDCARB pwglGetPbufferDCARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr wglGetPbufferDCEXT(IntPtr hPbuffer);
			[ThreadStatic]
			internal static wglGetPbufferDCEXT pwglGetPbufferDCEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);
			[ThreadStatic]
			internal static wglGetPixelFormatAttribfvARB pwglGetPixelFormatAttribfvARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, float* pfValues);
			[ThreadStatic]
			internal static wglGetPixelFormatAttribfvEXT pwglGetPixelFormatAttribfvEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);
			[ThreadStatic]
			internal static wglGetPixelFormatAttribivARB pwglGetPixelFormatAttribivARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, int* piValues);
			[ThreadStatic]
			internal static wglGetPixelFormatAttribivEXT pwglGetPixelFormatAttribivEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr wglGetProcAddress(String lpszProc);
			[ThreadStatic]
			internal static wglGetProcAddress pwglGetProcAddress;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int wglGetSwapIntervalEXT();
			[ThreadStatic]
			internal static wglGetSwapIntervalEXT pwglGetSwapIntervalEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetSyncValuesOML(IntPtr hdc, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static wglGetSyncValuesOML pwglGetSyncValuesOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetVideoDeviceNV(IntPtr hDC, int numDevices, IntPtr* hVideoDevice);
			[ThreadStatic]
			internal static wglGetVideoDeviceNV pwglGetVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglGetVideoInfoNV(IntPtr hpVideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);
			[ThreadStatic]
			internal static wglGetVideoInfoNV pwglGetVideoInfoNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledFrameLockI3D(bool* pFlag);
			[ThreadStatic]
			internal static wglIsEnabledFrameLockI3D pwglIsEnabledFrameLockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglIsEnabledGenlockI3D(IntPtr hDC, bool* pFlag);
			[ThreadStatic]
			internal static wglIsEnabledGenlockI3D pwglIsEnabledGenlockI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglJoinSwapGroupNV(IntPtr hDC, UInt32 group);
			[ThreadStatic]
			internal static wglJoinSwapGroupNV pwglJoinSwapGroupNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglLoadDisplayColorTableEXT(UInt16* table, UInt32 length);
			[ThreadStatic]
			internal static wglLoadDisplayColorTableEXT pwglLoadDisplayColorTableEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglLockVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);
			[ThreadStatic]
			internal static wglLockVideoCaptureDeviceNV pwglLockVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeAssociatedContextCurrentAMD(IntPtr hglrc);
			[ThreadStatic]
			internal static wglMakeAssociatedContextCurrentAMD pwglMakeAssociatedContextCurrentAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
			[ThreadStatic]
			internal static wglMakeContextCurrentARB pwglMakeContextCurrentARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
			[ThreadStatic]
			internal static wglMakeContextCurrentEXT pwglMakeContextCurrentEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglMakeCurrent(IntPtr hDc, IntPtr newContext);
			[ThreadStatic]
			internal static wglMakeCurrent pwglMakeCurrent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryCurrentContextNV(int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglQueryCurrentContextNV pwglQueryCurrentContextNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryFrameCountNV(IntPtr hDC, UInt32* count);
			[ThreadStatic]
			internal static wglQueryFrameCountNV pwglQueryFrameCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryFrameLockMasterI3D(bool* pFlag);
			[ThreadStatic]
			internal static wglQueryFrameLockMasterI3D pwglQueryFrameLockMasterI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryFrameTrackingI3D(Int32* pFrameCount, Int32* pMissedFrames, float * pLastMissedUsage);
			[ThreadStatic]
			internal static wglQueryFrameTrackingI3D pwglQueryFrameTrackingI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, UInt32* uMaxLineDelay, UInt32* uMaxPixelDelay);
			[ThreadStatic]
			internal static wglQueryGenlockMaxSourceDelayI3D pwglQueryGenlockMaxSourceDelayI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryMaxSwapGroupsNV(IntPtr hDC, UInt32* maxGroups, UInt32* maxBarriers);
			[ThreadStatic]
			internal static wglQueryMaxSwapGroupsNV pwglQueryMaxSwapGroupsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglQueryPbufferARB pwglQueryPbufferARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglQueryPbufferEXT pwglQueryPbufferEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQuerySwapGroupNV(IntPtr hDC, UInt32* group, UInt32* barrier);
			[ThreadStatic]
			internal static wglQuerySwapGroupNV pwglQuerySwapGroupNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglQueryVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglQueryVideoCaptureDeviceNV pwglQueryVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);
			[ThreadStatic]
			internal static wglRealizeLayerPalette pwglRealizeLayerPalette;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr* pAddress, UInt32 count);
			[ThreadStatic]
			internal static wglReleaseImageBufferEventsI3D pwglReleaseImageBufferEventsI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
			[ThreadStatic]
			internal static wglReleasePbufferDCARB pwglReleasePbufferDCARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
			[ThreadStatic]
			internal static wglReleasePbufferDCEXT pwglReleasePbufferDCEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
			[ThreadStatic]
			internal static wglReleaseTexImageARB pwglReleaseTexImageARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoCaptureDeviceNV(IntPtr hDc, IntPtr hDevice);
			[ThreadStatic]
			internal static wglReleaseVideoCaptureDeviceNV pwglReleaseVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoDeviceNV(IntPtr hVideoDevice);
			[ThreadStatic]
			internal static wglReleaseVideoDeviceNV pwglReleaseVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglReleaseVideoImageNV(IntPtr hPbuffer, int iVideoBuffer);
			[ThreadStatic]
			internal static wglReleaseVideoImageNV pwglReleaseVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglResetFrameCountNV(IntPtr hDC);
			[ThreadStatic]
			internal static wglResetFrameCountNV pwglResetFrameCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
			[ThreadStatic]
			internal static wglRestoreBufferRegionARB pwglRestoreBufferRegionARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
			[ThreadStatic]
			internal static wglSaveBufferRegionARB pwglSaveBufferRegionARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSendPbufferToVideoNV(IntPtr hPbuffer, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);
			[ThreadStatic]
			internal static wglSendPbufferToVideoNV pwglSendPbufferToVideoNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglSetDigitalVideoParametersI3D pwglSetDigitalVideoParametersI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
			[ThreadStatic]
			internal static wglSetGammaTableI3D pwglSetGammaTableI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
			[ThreadStatic]
			internal static wglSetGammaTableParametersI3D pwglSetGammaTableParametersI3D;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr);
			[ThreadStatic]
			internal static wglSetLayerPaletteEntries pwglSetLayerPaletteEntries;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
			[ThreadStatic]
			internal static wglSetPbufferAttribARB pwglSetPbufferAttribARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSetStereoEmitterState3DL(IntPtr hDC, UInt32 uState);
			[ThreadStatic]
			internal static wglSetStereoEmitterState3DL pwglSetStereoEmitterState3DL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
			[ThreadStatic]
			internal static wglShareLists pwglShareLists;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int64 wglSwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
			[ThreadStatic]
			internal static wglSwapBuffersMscOML pwglSwapBuffersMscOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglSwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
			[ThreadStatic]
			internal static wglSwapLayerBuffers pwglSwapLayerBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool wglSwapIntervalEXT(int interval);
			[ThreadStatic]
			internal static wglSwapIntervalEXT pwglSwapIntervalEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int64 wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
			[ThreadStatic]
			internal static wglSwapLayerBuffersMscOML pwglSwapLayerBuffersMscOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontBitmaps(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
			[ThreadStatic]
			internal static wglUseFontBitmaps pwglUseFontBitmaps;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
			[ThreadStatic]
			internal static wglUseFontBitmapsA pwglUseFontBitmapsA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
			[ThreadStatic]
			internal static wglUseFontBitmapsW pwglUseFontBitmapsW;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontOutlines(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);
			[ThreadStatic]
			internal static wglUseFontOutlines pwglUseFontOutlines;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);
			[ThreadStatic]
			internal static wglUseFontOutlinesA pwglUseFontOutlinesA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglUseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float deviation, float extrusion, int format, IntPtr lpgmf);
			[ThreadStatic]
			internal static wglUseFontOutlinesW pwglUseFontOutlinesW;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static wglWaitForMscOML pwglWaitForMscOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool wglWaitForSbcOML(IntPtr hdc, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static wglWaitForSbcOML pwglWaitForSbcOML;

		}
	}

}
