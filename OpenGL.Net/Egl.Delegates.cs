
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
	public unsafe partial class Egl
	{
		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglBindAPI(uint api);

			[ThreadStatic]
			internal static eglBindAPI peglBindAPI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[ThreadStatic]
			internal static eglBindTexImage peglBindTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

			[ThreadStatic]
			internal static eglChooseConfig peglChooseConfig;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[AliasOf("eglClientWaitSync")]
			[AliasOf("eglClientWaitSyncKHR")]
			[ThreadStatic]
			internal static eglClientWaitSync peglClientWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			[ThreadStatic]
			internal static eglClientWaitSyncNV peglClientWaitSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

			[ThreadStatic]
			internal static eglCopyBuffers peglCopyBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateContext peglCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateDRMImageMESA peglCreateDRMImageMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateFenceSyncNV peglCreateFenceSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			[ThreadStatic]
			internal static eglCreateImage peglCreateImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateImageKHR(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateImageKHR peglCreateImageKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			[ThreadStatic]
			internal static eglCreatePbufferFromClientBuffer peglCreatePbufferFromClientBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

			[ThreadStatic]
			internal static eglCreatePbufferSurface peglCreatePbufferSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			[ThreadStatic]
			internal static eglCreatePixmapSurface peglCreatePixmapSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

			[ThreadStatic]
			internal static eglCreatePixmapSurfaceHI peglCreatePixmapSurfaceHI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			[ThreadStatic]
			internal static eglCreatePlatformPixmapSurface peglCreatePlatformPixmapSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			[ThreadStatic]
			internal static eglCreatePlatformPixmapSurfaceEXT peglCreatePlatformPixmapSurfaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			[ThreadStatic]
			internal static eglCreatePlatformWindowSurface peglCreatePlatformWindowSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			[ThreadStatic]
			internal static eglCreatePlatformWindowSurfaceEXT peglCreatePlatformWindowSurfaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamFromFileDescriptorKHR(IntPtr dpy, int file_descriptor);

			[ThreadStatic]
			internal static eglCreateStreamFromFileDescriptorKHR peglCreateStreamFromFileDescriptorKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamKHR(IntPtr dpy, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateStreamKHR peglCreateStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateStreamProducerSurfaceKHR peglCreateStreamProducerSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateStreamSyncNV peglCreateStreamSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			[AliasOf("eglCreateSync")]
			[AliasOf("eglCreateSync64KHR")]
			[ThreadStatic]
			internal static eglCreateSync peglCreateSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateSyncKHR peglCreateSyncKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			[ThreadStatic]
			internal static eglCreateWindowSurface peglCreateWindowSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroyContext(IntPtr dpy, IntPtr ctx);

			[ThreadStatic]
			internal static eglDestroyContext peglDestroyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroyImage(IntPtr dpy, IntPtr image);

			[AliasOf("eglDestroyImage")]
			[AliasOf("eglDestroyImageKHR")]
			[ThreadStatic]
			internal static eglDestroyImage peglDestroyImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroyStreamKHR(IntPtr dpy, IntPtr stream);

			[ThreadStatic]
			internal static eglDestroyStreamKHR peglDestroyStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroySurface(IntPtr dpy, IntPtr surface);

			[ThreadStatic]
			internal static eglDestroySurface peglDestroySurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroySync(IntPtr dpy, IntPtr sync);

			[AliasOf("eglDestroySync")]
			[AliasOf("eglDestroySyncKHR")]
			[ThreadStatic]
			internal static eglDestroySync peglDestroySync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglDestroySyncNV(IntPtr sync);

			[ThreadStatic]
			internal static eglDestroySyncNV peglDestroySyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			[ThreadStatic]
			internal static eglDupNativeFenceFDANDROID peglDupNativeFenceFDANDROID;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

			[ThreadStatic]
			internal static eglExportDRMImageMESA peglExportDRMImageMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglFenceNV(IntPtr sync);

			[ThreadStatic]
			internal static eglFenceNV peglFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			[ThreadStatic]
			internal static eglGetConfigAttrib peglGetConfigAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

			[ThreadStatic]
			internal static eglGetConfigs peglGetConfigs;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentContext();

			[ThreadStatic]
			internal static eglGetCurrentContext peglGetCurrentContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentDisplay();

			[ThreadStatic]
			internal static eglGetCurrentDisplay peglGetCurrentDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentSurface(int readdraw);

			[ThreadStatic]
			internal static eglGetCurrentSurface peglGetCurrentSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetDisplay(IntPtr display_id);

			[ThreadStatic]
			internal static eglGetDisplay peglGetDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int eglGetError();

			[ThreadStatic]
			internal static eglGetError peglGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			[ThreadStatic]
			internal static eglGetOutputLayersEXT peglGetOutputLayersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			[ThreadStatic]
			internal static eglGetOutputPortsEXT peglGetOutputPortsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			[ThreadStatic]
			internal static eglGetPlatformDisplay peglGetPlatformDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			[ThreadStatic]
			internal static eglGetPlatformDisplayEXT peglGetPlatformDisplayEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetProcAddress(string procname);

			[ThreadStatic]
			internal static eglGetProcAddress peglGetProcAddress;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglGetStreamFileDescriptorKHR(IntPtr dpy, IntPtr stream);

			[ThreadStatic]
			internal static eglGetStreamFileDescriptorKHR peglGetStreamFileDescriptorKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglGetSyncAttrib peglGetSyncAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

			[ThreadStatic]
			internal static eglGetSyncAttribKHR peglGetSyncAttribKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

			[ThreadStatic]
			internal static eglGetSyncAttribNV peglGetSyncAttribNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeFrequencyNV();

			[ThreadStatic]
			internal static eglGetSystemTimeFrequencyNV peglGetSystemTimeFrequencyNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeNV();

			[ThreadStatic]
			internal static eglGetSystemTimeNV peglGetSystemTimeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglInitialize(IntPtr dpy, int* major, int* minor);

			[ThreadStatic]
			internal static eglInitialize peglInitialize;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglLockSurfaceKHR(IntPtr dpy, IntPtr surface, int* attrib_list);

			[ThreadStatic]
			internal static eglLockSurfaceKHR peglLockSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			[ThreadStatic]
			internal static eglMakeCurrent peglMakeCurrent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			[ThreadStatic]
			internal static eglOutputLayerAttribEXT peglOutputLayerAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			[ThreadStatic]
			internal static eglOutputPortAttribEXT peglOutputPortAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

			[ThreadStatic]
			internal static eglPostSubBufferNV peglPostSubBufferNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate uint eglQueryAPI();

			[ThreadStatic]
			internal static eglQueryAPI peglQueryAPI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			[ThreadStatic]
			internal static eglQueryContext peglQueryContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQueryDeviceAttribEXT peglQueryDeviceAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			[ThreadStatic]
			internal static eglQueryDeviceStringEXT peglQueryDeviceStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			[ThreadStatic]
			internal static eglQueryDevicesEXT peglQueryDevicesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQueryDisplayAttribEXT peglQueryDisplayAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryNativeDisplayNV(IntPtr dpy, IntPtr* display_id);

			[ThreadStatic]
			internal static eglQueryNativeDisplayNV peglQueryNativeDisplayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr* pixmap);

			[ThreadStatic]
			internal static eglQueryNativePixmapNV peglQueryNativePixmapNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr* window);

			[ThreadStatic]
			internal static eglQueryNativeWindowNV peglQueryNativeWindowNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQueryOutputLayerAttribEXT peglQueryOutputLayerAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			[ThreadStatic]
			internal static eglQueryOutputLayerStringEXT peglQueryOutputLayerStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQueryOutputPortAttribEXT peglQueryOutputPortAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

			[ThreadStatic]
			internal static eglQueryOutputPortStringEXT peglQueryOutputPortStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int* value);

			[ThreadStatic]
			internal static eglQueryStreamKHR peglQueryStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			[ThreadStatic]
			internal static eglQueryStreamTimeKHR peglQueryStreamTimeKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryStreamu64KHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			[ThreadStatic]
			internal static eglQueryStreamu64KHR peglQueryStreamu64KHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryString(IntPtr dpy, int name);

			[ThreadStatic]
			internal static eglQueryString peglQueryString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

			[ThreadStatic]
			internal static eglQuerySurface peglQuerySurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQuerySurface64KHR(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQuerySurface64KHR peglQuerySurface64KHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			[ThreadStatic]
			internal static eglQuerySurfacePointerANGLE peglQuerySurfacePointerANGLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[ThreadStatic]
			internal static eglReleaseTexImage peglReleaseTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglReleaseThread();

			[ThreadStatic]
			internal static eglReleaseThread peglReleaseThread;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void eglSetBlobCacheFuncsANDROID(IntPtr dpy, SetBlobFuncDelegate set, GetBlobFuncDelegate get);

			[ThreadStatic]
			internal static eglSetBlobCacheFuncsANDROID peglSetBlobCacheFuncsANDROID;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSetDamageRegionKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[ThreadStatic]
			internal static eglSetDamageRegionKHR peglSetDamageRegionKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			[ThreadStatic]
			internal static eglSignalSyncKHR peglSignalSyncKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSignalSyncNV(IntPtr sync, uint mode);

			[ThreadStatic]
			internal static eglSignalSyncNV peglSignalSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value);

			[ThreadStatic]
			internal static eglStreamAttribKHR peglStreamAttribKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			[ThreadStatic]
			internal static eglStreamConsumerAcquireKHR peglStreamConsumerAcquireKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			[ThreadStatic]
			internal static eglStreamConsumerGLTextureExternalKHR peglStreamConsumerGLTextureExternalKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglStreamConsumerOutputEXT(IntPtr dpy, IntPtr stream, IntPtr layer);

			[ThreadStatic]
			internal static eglStreamConsumerOutputEXT peglStreamConsumerOutputEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			[ThreadStatic]
			internal static eglStreamConsumerReleaseKHR peglStreamConsumerReleaseKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			[ThreadStatic]
			internal static eglSurfaceAttrib peglSurfaceAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapBuffers(IntPtr dpy, IntPtr surface);

			[ThreadStatic]
			internal static eglSwapBuffers peglSwapBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[ThreadStatic]
			internal static eglSwapBuffersWithDamageEXT peglSwapBuffersWithDamageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapBuffersWithDamageKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			[ThreadStatic]
			internal static eglSwapBuffersWithDamageKHR peglSwapBuffersWithDamageKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[ThreadStatic]
			internal static eglSwapBuffersRegionNOK peglSwapBuffersRegionNOK;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			[ThreadStatic]
			internal static eglSwapBuffersRegion2NOK peglSwapBuffersRegion2NOK;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglSwapInterval(IntPtr dpy, int interval);

			[ThreadStatic]
			internal static eglSwapInterval peglSwapInterval;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglTerminate(IntPtr dpy);

			[ThreadStatic]
			internal static eglTerminate peglTerminate;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglUnlockSurfaceKHR(IntPtr dpy, IntPtr surface);

			[ThreadStatic]
			internal static eglUnlockSurfaceKHR peglUnlockSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglWaitClient();

			[ThreadStatic]
			internal static eglWaitClient peglWaitClient;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglWaitGL();

			[ThreadStatic]
			internal static eglWaitGL peglWaitGL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglWaitNative(int engine);

			[ThreadStatic]
			internal static eglWaitNative peglWaitNative;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

			[ThreadStatic]
			internal static eglWaitSync peglWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

			[ThreadStatic]
			internal static eglWaitSyncKHR peglWaitSyncKHR;

		}
	}

}
