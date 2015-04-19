
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
	public unsafe partial class Glx
	{
		internal unsafe static partial class Imports
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXAssociateDMPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe bool glXAssociateDMPbufferSGIX(IntPtr dpy, IntPtr pbuffer, IntPtr @params, IntPtr dmbuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindChannelToWindowSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXBindChannelToWindowSGIX(IntPtr display, int screen, int channel, IntPtr window);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindHyperpipeSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXBindHyperpipeSGIX(IntPtr dpy, int hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindSwapBarrierNV", ExactSpelling = true)]
			internal extern static unsafe bool glXBindSwapBarrierNV(IntPtr dpy, UInt32 group, UInt32 barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindSwapBarrierSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXBindSwapBarrierSGIX(IntPtr dpy, IntPtr drawable, int barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glXBindTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoDeviceNV(IntPtr dpy, UInt32 video_slot, UInt32 video_device, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindVideoImageNV", ExactSpelling = true)]
			internal extern static unsafe int glXBindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBlitContextFramebufferAMD", ExactSpelling = true)]
			internal extern static unsafe void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChannelRectSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXChannelRectSGIX(IntPtr display, int screen, int channel, int x, int y, int w, int h);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChannelRectSyncSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXChannelRectSyncSGIX(IntPtr display, int screen, int channel, Int32 synctype);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChooseFBConfig", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXChooseFBConfig(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChooseFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChooseVisual", ExactSpelling = true)]
			internal extern static unsafe Glx.XVisualInfo glXChooseVisual(IntPtr dpy, int screen, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXNamedCopyBufferSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXNamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopyContext", ExactSpelling = true)]
			internal extern static unsafe void glXCopyContext(IntPtr dpy, IntPtr src, IntPtr dst, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopyImageSubDataNV", ExactSpelling = true)]
			internal extern static unsafe void glXCopyImageSubDataNV(IntPtr dpy, IntPtr srcCtx, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr dstCtx, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCopySubBufferMESA", ExactSpelling = true)]
			internal extern static unsafe void glXCopySubBufferMESA(IntPtr dpy, IntPtr drawable, int x, int y, int width, int height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateAssociatedContextAttribsAMD", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateContextAttribsARB", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateContextAttribsARB(IntPtr dpy, IntPtr config, IntPtr share_context, bool direct, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateContext", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateContext(IntPtr dpy, Glx.XVisualInfo vis, IntPtr shareList, bool direct);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateContextWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmap", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmap(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapMESA", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXVideoSourceSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateNewContext", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateNewContext(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreatePbuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreatePbuffer(IntPtr dpy, IntPtr config, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreatePixmap", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreatePixmap(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateWindow", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateWindow(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCushionSGI", ExactSpelling = true)]
			internal extern static unsafe void glXCushionSGI(IntPtr dpy, IntPtr window, float cushion);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDelayBeforeSwapNV", ExactSpelling = true)]
			internal extern static unsafe bool glXDelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDeleteAssociatedContextAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXDeleteAssociatedContextAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyContext", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyContext(IntPtr dpy, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyGLXPixmap", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXPixmap(IntPtr dpy, IntPtr pixmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyGLXVideoSourceSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXDestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyPbuffer", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyPbuffer(IntPtr dpy, IntPtr pbuf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyPixmap", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyPixmap(IntPtr dpy, IntPtr pixmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyWindow", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyWindow(IntPtr dpy, IntPtr win);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXEnumerateVideoCaptureDevicesNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXEnumerateVideoDevicesNV", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXEnumerateVideoDevicesNV(IntPtr dpy, int screen, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXFreeContextEXT", ExactSpelling = true)]
			internal extern static unsafe void glXFreeContextEXT(IntPtr dpy, IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetAGPOffsetMESA", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetAGPOffsetMESA(IntPtr pointer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetClientString", ExactSpelling = true)]
			internal extern static unsafe string glXGetClientString(IntPtr dpy, int name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetConfig", ExactSpelling = true)]
			internal extern static unsafe int glXGetConfig(IntPtr dpy, Glx.XVisualInfo visual, int attrib, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetContextGPUIDAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetContextGPUIDAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetContextIDEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetContextIDEXT(IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentAssociatedContextAMD", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentAssociatedContextAMD();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentContext", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentContext();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentDisplayEXT", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentDisplayEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentDisplay", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentDisplay();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentDrawable", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentDrawable();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentReadDrawableSGI", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentReadDrawableSGI();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentReadDrawable", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentReadDrawable();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigAttrib", ExactSpelling = true)]
			internal extern static unsafe int glXGetFBConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigFromVisualSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigs", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetFBConfigs(IntPtr dpy, int screen, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetGPUIDsAMD", ExactSpelling = true)]
			internal extern static unsafe UInt32 glXGetGPUIDsAMD(UInt32 maxCount, IntPtr ids);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetGPUInfoAMD", ExactSpelling = true)]
			internal extern static unsafe int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetMscRateOML", ExactSpelling = true)]
			internal extern static unsafe bool glXGetMscRateOML(IntPtr dpy, IntPtr drawable, Int32* numerator, Int32* denominator);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetProcAddressARB", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetProcAddressARB(byte* procName);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetProcAddress", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetProcAddress(byte* procName);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetSelectedEvent", ExactSpelling = true)]
			internal extern static unsafe void glXGetSelectedEvent(IntPtr dpy, IntPtr draw, UInt32* event_mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetSelectedEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetSyncValuesOML", ExactSpelling = true)]
			internal extern static unsafe bool glXGetSyncValuesOML(IntPtr dpy, IntPtr drawable, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetTransparentIndexSUN", ExactSpelling = true)]
			internal extern static unsafe Int32 glXGetTransparentIndexSUN(IntPtr dpy, IntPtr overlay, IntPtr underlay, long * pTransparentIndex);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXGetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVideoInfoNV", ExactSpelling = true)]
			internal extern static unsafe int glXGetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVideoSyncSGI", ExactSpelling = true)]
			internal extern static unsafe int glXGetVideoSyncSGI(IntPtr count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVisualFromFBConfig", ExactSpelling = true)]
			internal extern static unsafe Glx.XVisualInfo glXGetVisualFromFBConfig(IntPtr dpy, IntPtr config);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVisualFromFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe Glx.XVisualInfo glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXHyperpipeAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXHyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, int* hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXImportContextEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXImportContextEXT(IntPtr dpy, IntPtr contextID);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXIsDirect", ExactSpelling = true)]
			internal extern static unsafe bool glXIsDirect(IntPtr dpy, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXJoinSwapGroupNV", ExactSpelling = true)]
			internal extern static unsafe bool glXJoinSwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32 group);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXJoinSwapGroupSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXJoinSwapGroupSGIX(IntPtr dpy, IntPtr drawable, IntPtr member);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXLockVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeAssociatedContextCurrentAMD", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeContextCurrent", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeContextCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeCurrent", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeCurrent(IntPtr dpy, IntPtr drawable, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXMakeCurrentReadSGI", ExactSpelling = true)]
			internal extern static unsafe bool glXMakeCurrentReadSGI(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryChannelDeltasSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryChannelDeltasSGIX(IntPtr display, int screen, int channel, int* x, int* y, int* w, int* h);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryChannelRectSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryChannelRectSGIX(IntPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryContext", ExactSpelling = true)]
			internal extern static unsafe int glXQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryContextInfoEXT", ExactSpelling = true)]
			internal extern static unsafe int glXQueryContextInfoEXT(IntPtr dpy, IntPtr context, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryCurrentRendererIntegerMESA", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryCurrentRendererIntegerMESA(int attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryCurrentRendererStringMESA", ExactSpelling = true)]
			internal extern static string glXQueryCurrentRendererStringMESA(int attribute);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryDrawable", ExactSpelling = true)]
			internal extern static unsafe void glXQueryDrawable(IntPtr dpy, IntPtr draw, int attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryExtension", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryExtension(IntPtr dpy, int* errorb, int* @event);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryExtensionsString", ExactSpelling = true)]
			internal extern static unsafe string glXQueryExtensionsString(IntPtr dpy, int screen);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryFrameCountNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryFrameCountNV(IntPtr dpy, int screen, UInt32* count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeBestAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXQueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, int* npipes);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeNetworkSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXQueryHyperpipeNetworkSGIX(IntPtr dpy, int* npipes);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryMaxSwapBarriersSGIX", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, int* max);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryMaxSwapGroupsNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryMaxSwapGroupsNV(IntPtr dpy, int screen, UInt32* maxGroups, UInt32* maxBarriers);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryRendererIntegerMESA", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryRendererIntegerMESA(IntPtr dpy, int screen, int renderer, int attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryRendererStringMESA", ExactSpelling = true)]
			internal extern static unsafe string glXQueryRendererStringMESA(IntPtr dpy, int screen, int renderer, int attribute);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryServerString", ExactSpelling = true)]
			internal extern static unsafe string glXQueryServerString(IntPtr dpy, int screen, int name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQuerySwapGroupNV", ExactSpelling = true)]
			internal extern static unsafe bool glXQuerySwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32* group, UInt32* barrier);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryVersion", ExactSpelling = true)]
			internal extern static unsafe bool glXQueryVersion(IntPtr dpy, int* maj, int* min);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseBuffersMESA", ExactSpelling = true)]
			internal extern static unsafe bool glXReleaseBuffersMESA(IntPtr dpy, IntPtr drawable);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseTexImageEXT", ExactSpelling = true)]
			internal extern static unsafe void glXReleaseTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseVideoCaptureDeviceNV", ExactSpelling = true)]
			internal extern static unsafe void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseVideoDeviceNV", ExactSpelling = true)]
			internal extern static unsafe int glXReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXReleaseVideoImageNV", ExactSpelling = true)]
			internal extern static unsafe int glXReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXResetFrameCountNV", ExactSpelling = true)]
			internal extern static unsafe bool glXResetFrameCountNV(IntPtr dpy, int screen);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSelectEvent", ExactSpelling = true)]
			internal extern static unsafe void glXSelectEvent(IntPtr dpy, IntPtr draw, UInt32 event_mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSelectEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSendPbufferToVideoNV", ExactSpelling = true)]
			internal extern static unsafe int glXSendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSet3DfxModeMESA", ExactSpelling = true)]
			internal extern static bool glXSet3DfxModeMESA(int mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapBuffers", ExactSpelling = true)]
			internal extern static unsafe void glXSwapBuffers(IntPtr dpy, IntPtr drawable);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapBuffersMscOML", ExactSpelling = true)]
			internal extern static unsafe Int64 glXSwapBuffersMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapIntervalEXT", ExactSpelling = true)]
			internal extern static unsafe void glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSwapIntervalSGI", ExactSpelling = true)]
			internal extern static int glXSwapIntervalSGI(int interval);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXUseXFont", ExactSpelling = true)]
			internal extern static void glXUseXFont(Int32 font, int first, int count, int list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXWaitForMscOML", ExactSpelling = true)]
			internal extern static unsafe bool glXWaitForMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXWaitForSbcOML", ExactSpelling = true)]
			internal extern static unsafe bool glXWaitForSbcOML(IntPtr dpy, IntPtr drawable, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXWaitGL", ExactSpelling = true)]
			internal extern static void glXWaitGL();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXWaitVideoSyncSGI", ExactSpelling = true)]
			internal extern static unsafe int glXWaitVideoSyncSGI(int divisor, int remainder, IntPtr count);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXWaitX", ExactSpelling = true)]
			internal extern static void glXWaitX();

		}
	}

}
