
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
	public unsafe partial class Glx
	{
		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXAssociateDMPbufferSGIX(IntPtr dpy, IntPtr pbuffer, IntPtr* @params, IntPtr dmbuffer);
			[ThreadStatic]
			internal static glXAssociateDMPbufferSGIX pglXAssociateDMPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindChannelToWindowSGIX(IntPtr display, int screen, int channel, IntPtr window);
			[ThreadStatic]
			internal static glXBindChannelToWindowSGIX pglXBindChannelToWindowSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindHyperpipeSGIX(IntPtr dpy, int hpId);
			[ThreadStatic]
			internal static glXBindHyperpipeSGIX pglXBindHyperpipeSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXBindSwapBarrierNV(IntPtr dpy, UInt32 group, UInt32 barrier);
			[ThreadStatic]
			internal static glXBindSwapBarrierNV pglXBindSwapBarrierNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXBindSwapBarrierSGIX(IntPtr dpy, IntPtr drawable, int barrier);
			[ThreadStatic]
			internal static glXBindSwapBarrierSGIX pglXBindSwapBarrierSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXBindTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer, int* attrib_list);
			[ThreadStatic]
			internal static glXBindTexImageEXT pglXBindTexImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindVideoCaptureDeviceNV(IntPtr dpy, UInt32 video_capture_slot, IntPtr device);
			[ThreadStatic]
			internal static glXBindVideoCaptureDeviceNV pglXBindVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindVideoDeviceNV(IntPtr dpy, UInt32 video_slot, UInt32 video_device, int* attrib_list);
			[ThreadStatic]
			internal static glXBindVideoDeviceNV pglXBindVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindVideoImageNV(IntPtr dpy, IntPtr VideoDevice, IntPtr pbuf, int iVideoBuffer);
			[ThreadStatic]
			internal static glXBindVideoImageNV pglXBindVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXBlitContextFramebufferAMD(IntPtr dstCtx, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, UInt32 mask, Int32 filter);
			[ThreadStatic]
			internal static glXBlitContextFramebufferAMD pglXBlitContextFramebufferAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXChannelRectSGIX(IntPtr display, int screen, int channel, int x, int y, int w, int h);
			[ThreadStatic]
			internal static glXChannelRectSGIX pglXChannelRectSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXChannelRectSyncSGIX(IntPtr display, int screen, int channel, Int32 synctype);
			[ThreadStatic]
			internal static glXChannelRectSyncSGIX pglXChannelRectSyncSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXChooseFBConfig(IntPtr dpy, int screen, int* attrib_list, int* nelements);
			[ThreadStatic]
			internal static glXChooseFBConfig pglXChooseFBConfig;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);
			[ThreadStatic]
			internal static glXChooseFBConfigSGIX pglXChooseFBConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXChooseVisual(IntPtr dpy, int screen, int* attribList);
			[ThreadStatic]
			internal static glXChooseVisual pglXChooseVisual;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, Int32 readTarget, Int32 writeTarget, IntPtr readOffset, IntPtr writeOffset, UInt32 size);
			[ThreadStatic]
			internal static glXCopyBufferSubDataNV pglXCopyBufferSubDataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXNamedCopyBufferSubDataNV(IntPtr dpy, IntPtr readCtx, IntPtr writeCtx, UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, UInt32 size);
			[ThreadStatic]
			internal static glXNamedCopyBufferSubDataNV pglXNamedCopyBufferSubDataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopyContext(IntPtr dpy, IntPtr src, IntPtr dst, UInt32 mask);
			[ThreadStatic]
			internal static glXCopyContext pglXCopyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopyImageSubDataNV(IntPtr dpy, IntPtr srcCtx, UInt32 srcName, Int32 srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, IntPtr dstCtx, UInt32 dstName, Int32 dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);
			[ThreadStatic]
			internal static glXCopyImageSubDataNV pglXCopyImageSubDataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCopySubBufferMESA(IntPtr dpy, IntPtr drawable, int x, int y, int width, int height);
			[ThreadStatic]
			internal static glXCopySubBufferMESA pglXCopySubBufferMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateAssociatedContextAMD(UInt32 id, IntPtr share_list);
			[ThreadStatic]
			internal static glXCreateAssociatedContextAMD pglXCreateAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateAssociatedContextAttribsAMD(UInt32 id, IntPtr share_context, int* attribList);
			[ThreadStatic]
			internal static glXCreateAssociatedContextAttribsAMD pglXCreateAssociatedContextAttribsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateContextAttribsARB(IntPtr dpy, IntPtr config, IntPtr share_context, bool direct, int* attrib_list);
			[ThreadStatic]
			internal static glXCreateContextAttribsARB pglXCreateContextAttribsARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateContext(IntPtr dpy, Glx.XVisualInfo vis, IntPtr shareList, bool direct);
			[ThreadStatic]
			internal static glXCreateContext pglXCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);
			[ThreadStatic]
			internal static glXCreateContextWithConfigSGIX pglXCreateContextWithConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);
			[ThreadStatic]
			internal static glXCreateGLXPbufferSGIX pglXCreateGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPixmap(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap);
			[ThreadStatic]
			internal static glXCreateGLXPixmap pglXCreateGLXPixmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPixmapMESA(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap, IntPtr cmap);
			[ThreadStatic]
			internal static glXCreateGLXPixmapMESA pglXCreateGLXPixmapMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);
			[ThreadStatic]
			internal static glXCreateGLXPixmapWithConfigSGIX pglXCreateGLXPixmapWithConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXVideoSourceSGIX(IntPtr display, int screen, IntPtr server, IntPtr path, int nodeClass, IntPtr drainNode);
			[ThreadStatic]
			internal static glXCreateGLXVideoSourceSGIX pglXCreateGLXVideoSourceSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateNewContext(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);
			[ThreadStatic]
			internal static glXCreateNewContext pglXCreateNewContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreatePbuffer(IntPtr dpy, IntPtr config, int* attrib_list);
			[ThreadStatic]
			internal static glXCreatePbuffer pglXCreatePbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreatePixmap(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);
			[ThreadStatic]
			internal static glXCreatePixmap pglXCreatePixmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateWindow(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);
			[ThreadStatic]
			internal static glXCreateWindow pglXCreateWindow;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXCushionSGI(IntPtr dpy, IntPtr window, float cushion);
			[ThreadStatic]
			internal static glXCushionSGI pglXCushionSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXDelayBeforeSwapNV(IntPtr dpy, IntPtr drawable, float seconds);
			[ThreadStatic]
			internal static glXDelayBeforeSwapNV pglXDelayBeforeSwapNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXDeleteAssociatedContextAMD(IntPtr ctx);
			[ThreadStatic]
			internal static glXDeleteAssociatedContextAMD pglXDeleteAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyContext(IntPtr dpy, IntPtr ctx);
			[ThreadStatic]
			internal static glXDestroyContext pglXDestroyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);
			[ThreadStatic]
			internal static glXDestroyGLXPbufferSGIX pglXDestroyGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyGLXPixmap(IntPtr dpy, IntPtr pixmap);
			[ThreadStatic]
			internal static glXDestroyGLXPixmap pglXDestroyGLXPixmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyGLXVideoSourceSGIX(IntPtr dpy, IntPtr glxvideosource);
			[ThreadStatic]
			internal static glXDestroyGLXVideoSourceSGIX pglXDestroyGLXVideoSourceSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXDestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId);
			[ThreadStatic]
			internal static glXDestroyHyperpipeConfigSGIX pglXDestroyHyperpipeConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyPbuffer(IntPtr dpy, IntPtr pbuf);
			[ThreadStatic]
			internal static glXDestroyPbuffer pglXDestroyPbuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyPixmap(IntPtr dpy, IntPtr pixmap);
			[ThreadStatic]
			internal static glXDestroyPixmap pglXDestroyPixmap;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyWindow(IntPtr dpy, IntPtr win);
			[ThreadStatic]
			internal static glXDestroyWindow pglXDestroyWindow;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXEnumerateVideoCaptureDevicesNV(IntPtr dpy, int screen, int* nelements);
			[ThreadStatic]
			internal static glXEnumerateVideoCaptureDevicesNV pglXEnumerateVideoCaptureDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXEnumerateVideoDevicesNV(IntPtr dpy, int screen, int* nelements);
			[ThreadStatic]
			internal static glXEnumerateVideoDevicesNV pglXEnumerateVideoDevicesNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXFreeContextEXT(IntPtr dpy, IntPtr context);
			[ThreadStatic]
			internal static glXFreeContextEXT pglXFreeContextEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glXGetAGPOffsetMESA(IntPtr pointer);
			[ThreadStatic]
			internal static glXGetAGPOffsetMESA pglXGetAGPOffsetMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetClientString(IntPtr dpy, int name);
			[ThreadStatic]
			internal static glXGetClientString pglXGetClientString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetConfig(IntPtr dpy, Glx.XVisualInfo visual, int attrib, int* value);
			[ThreadStatic]
			internal static glXGetConfig pglXGetConfig;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glXGetContextGPUIDAMD(IntPtr ctx);
			[ThreadStatic]
			internal static glXGetContextGPUIDAMD pglXGetContextGPUIDAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetContextIDEXT(IntPtr context);
			[ThreadStatic]
			internal static glXGetContextIDEXT pglXGetContextIDEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentAssociatedContextAMD();
			[ThreadStatic]
			internal static glXGetCurrentAssociatedContextAMD pglXGetCurrentAssociatedContextAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentContext();
			[ThreadStatic]
			internal static glXGetCurrentContext pglXGetCurrentContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentDisplayEXT();
			[ThreadStatic]
			internal static glXGetCurrentDisplayEXT pglXGetCurrentDisplayEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentDisplay();
			[ThreadStatic]
			internal static glXGetCurrentDisplay pglXGetCurrentDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentDrawable();
			[ThreadStatic]
			internal static glXGetCurrentDrawable pglXGetCurrentDrawable;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentReadDrawableSGI();
			[ThreadStatic]
			internal static glXGetCurrentReadDrawableSGI pglXGetCurrentReadDrawableSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentReadDrawable();
			[ThreadStatic]
			internal static glXGetCurrentReadDrawable pglXGetCurrentReadDrawable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetFBConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);
			[ThreadStatic]
			internal static glXGetFBConfigAttrib pglXGetFBConfigAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);
			[ThreadStatic]
			internal static glXGetFBConfigAttribSGIX pglXGetFBConfigAttribSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);
			[ThreadStatic]
			internal static glXGetFBConfigFromVisualSGIX pglXGetFBConfigFromVisualSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXGetFBConfigs(IntPtr dpy, int screen, int* nelements);
			[ThreadStatic]
			internal static glXGetFBConfigs pglXGetFBConfigs;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate UInt32 glXGetGPUIDsAMD(UInt32 maxCount, IntPtr ids);
			[ThreadStatic]
			internal static glXGetGPUIDsAMD pglXGetGPUIDsAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetGPUInfoAMD(UInt32 id, int property, Int32 dataType, UInt32 size, IntPtr data);
			[ThreadStatic]
			internal static glXGetGPUInfoAMD pglXGetGPUInfoAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXGetMscRateOML(IntPtr dpy, IntPtr drawable, Int32* numerator, Int32* denominator);
			[ThreadStatic]
			internal static glXGetMscRateOML pglXGetMscRateOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetProcAddressARB(byte* procName);
			[ThreadStatic]
			internal static glXGetProcAddressARB pglXGetProcAddressARB;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetProcAddress(byte* procName);
			[ThreadStatic]
			internal static glXGetProcAddress pglXGetProcAddress;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXGetSelectedEvent(IntPtr dpy, IntPtr draw, UInt32* event_mask);
			[ThreadStatic]
			internal static glXGetSelectedEvent pglXGetSelectedEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);
			[ThreadStatic]
			internal static glXGetSelectedEventSGIX pglXGetSelectedEventSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXGetSyncValuesOML(IntPtr dpy, IntPtr drawable, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static glXGetSyncValuesOML pglXGetSyncValuesOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int32 glXGetTransparentIndexSUN(IntPtr dpy, IntPtr overlay, IntPtr underlay, long * pTransparentIndex);
			[ThreadStatic]
			internal static glXGetTransparentIndexSUN pglXGetTransparentIndexSUN;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetVideoDeviceNV(IntPtr dpy, int screen, int numVideoDevices, IntPtr pVideoDevice);
			[ThreadStatic]
			internal static glXGetVideoDeviceNV pglXGetVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetVideoInfoNV(IntPtr dpy, int screen, IntPtr VideoDevice, UInt32* pulCounterOutputPbuffer, UInt32* pulCounterOutputVideo);
			[ThreadStatic]
			internal static glXGetVideoInfoNV pglXGetVideoInfoNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetVideoSyncSGI(IntPtr count);
			[ThreadStatic]
			internal static glXGetVideoSyncSGI pglXGetVideoSyncSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetVisualFromFBConfig(IntPtr dpy, IntPtr config);
			[ThreadStatic]
			internal static glXGetVisualFromFBConfig pglXGetVisualFromFBConfig;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);
			[ThreadStatic]
			internal static glXGetVisualFromFBConfigSGIX pglXGetVisualFromFBConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList);
			[ThreadStatic]
			internal static glXHyperpipeAttribSGIX pglXHyperpipeAttribSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXHyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, int* hpId);
			[ThreadStatic]
			internal static glXHyperpipeConfigSGIX pglXHyperpipeConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXImportContextEXT(IntPtr dpy, IntPtr contextID);
			[ThreadStatic]
			internal static glXImportContextEXT pglXImportContextEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXIsDirect(IntPtr dpy, IntPtr ctx);
			[ThreadStatic]
			internal static glXIsDirect pglXIsDirect;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXJoinSwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32 group);
			[ThreadStatic]
			internal static glXJoinSwapGroupNV pglXJoinSwapGroupNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXJoinSwapGroupSGIX(IntPtr dpy, IntPtr drawable, IntPtr member);
			[ThreadStatic]
			internal static glXJoinSwapGroupSGIX pglXJoinSwapGroupSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXLockVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);
			[ThreadStatic]
			internal static glXLockVideoCaptureDeviceNV pglXLockVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeAssociatedContextCurrentAMD(IntPtr ctx);
			[ThreadStatic]
			internal static glXMakeAssociatedContextCurrentAMD pglXMakeAssociatedContextCurrentAMD;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeContextCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);
			[ThreadStatic]
			internal static glXMakeContextCurrent pglXMakeContextCurrent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeCurrent(IntPtr dpy, IntPtr drawable, IntPtr ctx);
			[ThreadStatic]
			internal static glXMakeCurrent pglXMakeCurrent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXMakeCurrentReadSGI(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);
			[ThreadStatic]
			internal static glXMakeCurrentReadSGI pglXMakeCurrentReadSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryChannelDeltasSGIX(IntPtr display, int screen, int channel, int* x, int* y, int* w, int* h);
			[ThreadStatic]
			internal static glXQueryChannelDeltasSGIX pglXQueryChannelDeltasSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryChannelRectSGIX(IntPtr display, int screen, int channel, int* dx, int* dy, int* dw, int* dh);
			[ThreadStatic]
			internal static glXQueryChannelRectSGIX pglXQueryChannelRectSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);
			[ThreadStatic]
			internal static glXQueryContext pglXQueryContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryContextInfoEXT(IntPtr dpy, IntPtr context, int attribute, int* value);
			[ThreadStatic]
			internal static glXQueryContextInfoEXT pglXQueryContextInfoEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryCurrentRendererIntegerMESA(int attribute, IntPtr value);
			[ThreadStatic]
			internal static glXQueryCurrentRendererIntegerMESA pglXQueryCurrentRendererIntegerMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXQueryCurrentRendererStringMESA(int attribute);
			[ThreadStatic]
			internal static glXQueryCurrentRendererStringMESA pglXQueryCurrentRendererStringMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXQueryDrawable(IntPtr dpy, IntPtr draw, int attribute, IntPtr value);
			[ThreadStatic]
			internal static glXQueryDrawable pglXQueryDrawable;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryExtension(IntPtr dpy, int* errorb, int* @event);
			[ThreadStatic]
			internal static glXQueryExtension pglXQueryExtension;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXQueryExtensionsString(IntPtr dpy, int screen);
			[ThreadStatic]
			internal static glXQueryExtensionsString pglXQueryExtensionsString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryFrameCountNV(IntPtr dpy, int screen, UInt32* count);
			[ThreadStatic]
			internal static glXQueryFrameCountNV pglXQueryFrameCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, IntPtr value);
			[ThreadStatic]
			internal static glXQueryGLXPbufferSGIX pglXQueryGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList);
			[ThreadStatic]
			internal static glXQueryHyperpipeAttribSGIX pglXQueryHyperpipeAttribSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList);
			[ThreadStatic]
			internal static glXQueryHyperpipeBestAttribSGIX pglXQueryHyperpipeBestAttribSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXQueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, int* npipes);
			[ThreadStatic]
			internal static glXQueryHyperpipeConfigSGIX pglXQueryHyperpipeConfigSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXQueryHyperpipeNetworkSGIX(IntPtr dpy, int* npipes);
			[ThreadStatic]
			internal static glXQueryHyperpipeNetworkSGIX pglXQueryHyperpipeNetworkSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryMaxSwapBarriersSGIX(IntPtr dpy, int screen, int* max);
			[ThreadStatic]
			internal static glXQueryMaxSwapBarriersSGIX pglXQueryMaxSwapBarriersSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryMaxSwapGroupsNV(IntPtr dpy, int screen, UInt32* maxGroups, UInt32* maxBarriers);
			[ThreadStatic]
			internal static glXQueryMaxSwapGroupsNV pglXQueryMaxSwapGroupsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryRendererIntegerMESA(IntPtr dpy, int screen, int renderer, int attribute, IntPtr value);
			[ThreadStatic]
			internal static glXQueryRendererIntegerMESA pglXQueryRendererIntegerMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXQueryRendererStringMESA(IntPtr dpy, int screen, int renderer, int attribute);
			[ThreadStatic]
			internal static glXQueryRendererStringMESA pglXQueryRendererStringMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXQueryServerString(IntPtr dpy, int screen, int name);
			[ThreadStatic]
			internal static glXQueryServerString pglXQueryServerString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQuerySwapGroupNV(IntPtr dpy, IntPtr drawable, UInt32* group, UInt32* barrier);
			[ThreadStatic]
			internal static glXQuerySwapGroupNV pglXQuerySwapGroupNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXQueryVersion(IntPtr dpy, int* maj, int* min);
			[ThreadStatic]
			internal static glXQueryVersion pglXQueryVersion;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryVideoCaptureDeviceNV(IntPtr dpy, IntPtr device, int attribute, int* value);
			[ThreadStatic]
			internal static glXQueryVideoCaptureDeviceNV pglXQueryVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXReleaseBuffersMESA(IntPtr dpy, IntPtr drawable);
			[ThreadStatic]
			internal static glXReleaseBuffersMESA pglXReleaseBuffersMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXReleaseTexImageEXT(IntPtr dpy, IntPtr drawable, int buffer);
			[ThreadStatic]
			internal static glXReleaseTexImageEXT pglXReleaseTexImageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXReleaseVideoCaptureDeviceNV(IntPtr dpy, IntPtr device);
			[ThreadStatic]
			internal static glXReleaseVideoCaptureDeviceNV pglXReleaseVideoCaptureDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXReleaseVideoDeviceNV(IntPtr dpy, int screen, IntPtr VideoDevice);
			[ThreadStatic]
			internal static glXReleaseVideoDeviceNV pglXReleaseVideoDeviceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXReleaseVideoImageNV(IntPtr dpy, IntPtr pbuf);
			[ThreadStatic]
			internal static glXReleaseVideoImageNV pglXReleaseVideoImageNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXResetFrameCountNV(IntPtr dpy, int screen);
			[ThreadStatic]
			internal static glXResetFrameCountNV pglXResetFrameCountNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSelectEvent(IntPtr dpy, IntPtr draw, UInt32 event_mask);
			[ThreadStatic]
			internal static glXSelectEvent pglXSelectEvent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);
			[ThreadStatic]
			internal static glXSelectEventSGIX pglXSelectEventSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXSendPbufferToVideoNV(IntPtr dpy, IntPtr pbuf, int iBufferType, UInt32* pulCounterPbuffer, bool bBlock);
			[ThreadStatic]
			internal static glXSendPbufferToVideoNV pglXSendPbufferToVideoNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glXSet3DfxModeMESA(int mode);
			[ThreadStatic]
			internal static glXSet3DfxModeMESA pglXSet3DfxModeMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSwapBuffers(IntPtr dpy, IntPtr drawable);
			[ThreadStatic]
			internal static glXSwapBuffers pglXSwapBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate Int64 glXSwapBuffersMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder);
			[ThreadStatic]
			internal static glXSwapBuffersMscOML pglXSwapBuffersMscOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSwapIntervalEXT(IntPtr dpy, IntPtr drawable, int interval);
			[ThreadStatic]
			internal static glXSwapIntervalEXT pglXSwapIntervalEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int glXSwapIntervalSGI(int interval);
			[ThreadStatic]
			internal static glXSwapIntervalSGI pglXSwapIntervalSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glXUseXFont(Int32 font, int first, int count, int list);
			[ThreadStatic]
			internal static glXUseXFont pglXUseXFont;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXWaitForMscOML(IntPtr dpy, IntPtr drawable, Int64 target_msc, Int64 divisor, Int64 remainder, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static glXWaitForMscOML pglXWaitForMscOML;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool glXWaitForSbcOML(IntPtr dpy, IntPtr drawable, Int64 target_sbc, Int64* ust, Int64* msc, Int64* sbc);
			[ThreadStatic]
			internal static glXWaitForSbcOML pglXWaitForSbcOML;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glXWaitGL();
			[ThreadStatic]
			internal static glXWaitGL pglXWaitGL;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXWaitVideoSyncSGI(int divisor, int remainder, IntPtr count);
			[ThreadStatic]
			internal static glXWaitVideoSyncSGI pglXWaitVideoSyncSGI;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glXWaitX();
			[ThreadStatic]
			internal static glXWaitX pglXWaitX;

		}
	}

}
