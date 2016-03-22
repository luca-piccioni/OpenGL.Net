
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
			internal delegate bool eglBindAPI(uint api);

			internal static eglBindAPI peglBindAPI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			internal static eglBindTexImage peglBindTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglChooseConfig(IntPtr dpy, int* attrib_list, IntPtr* configs, int config_size, int* num_config);

			internal static eglChooseConfig peglChooseConfig;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout);

			[AliasOf("eglClientWaitSync")]
			[AliasOf("eglClientWaitSyncKHR")]
			internal static eglClientWaitSync peglClientWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglClientWaitSyncNV(IntPtr sync, int flags, UInt64 timeout);

			internal static eglClientWaitSyncNV peglClientWaitSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglCopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target);

			internal static eglCopyBuffers peglCopyBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int* attrib_list);

			internal static eglCreateContext peglCreateContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateDRMImageMESA(IntPtr dpy, int* attrib_list);

			internal static eglCreateDRMImageMESA peglCreateDRMImageMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateFenceSyncNV(IntPtr dpy, uint condition, int* attrib_list);

			internal static eglCreateFenceSyncNV peglCreateFenceSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr* attrib_list);

			internal static eglCreateImage peglCreateImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateImageKHR(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, int* attrib_list);

			internal static eglCreateImageKHR peglCreateImageKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			internal static eglCreatePbufferFromClientBuffer peglCreatePbufferFromClientBuffer;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePbufferSurface(IntPtr dpy, IntPtr config, int* attrib_list);

			internal static eglCreatePbufferSurface peglCreatePbufferSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int* attrib_list);

			internal static eglCreatePixmapSurface peglCreatePixmapSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePixmapSurfaceHI(IntPtr dpy, IntPtr config, ClientPixmap* pixmap);

			internal static eglCreatePixmapSurfaceHI peglCreatePixmapSurfaceHI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr* attrib_list);

			internal static eglCreatePlatformPixmapSurface peglCreatePlatformPixmapSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformPixmapSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_pixmap, int* attrib_list);

			internal static eglCreatePlatformPixmapSurfaceEXT peglCreatePlatformPixmapSurfaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr* attrib_list);

			internal static eglCreatePlatformWindowSurface peglCreatePlatformWindowSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePlatformWindowSurfaceEXT(IntPtr dpy, IntPtr config, IntPtr native_window, int* attrib_list);

			internal static eglCreatePlatformWindowSurfaceEXT peglCreatePlatformWindowSurfaceEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamFromFileDescriptorKHR(IntPtr dpy, int file_descriptor);

			internal static eglCreateStreamFromFileDescriptorKHR peglCreateStreamFromFileDescriptorKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamKHR(IntPtr dpy, int* attrib_list);

			internal static eglCreateStreamKHR peglCreateStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamProducerSurfaceKHR(IntPtr dpy, IntPtr config, IntPtr stream, int* attrib_list);

			internal static eglCreateStreamProducerSurfaceKHR peglCreateStreamProducerSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateStreamSyncNV(IntPtr dpy, IntPtr stream, uint type, int* attrib_list);

			internal static eglCreateStreamSyncNV peglCreateStreamSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateSync(IntPtr dpy, uint type, IntPtr* attrib_list);

			[AliasOf("eglCreateSync")]
			[AliasOf("eglCreateSync64KHR")]
			internal static eglCreateSync peglCreateSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateSyncKHR(IntPtr dpy, uint type, int* attrib_list);

			internal static eglCreateSyncKHR peglCreateSyncKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int* attrib_list);

			internal static eglCreateWindowSurface peglCreateWindowSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglDebugMessageControlKHR(DebugProcKHR callback, IntPtr* attrib_list);

			internal static eglDebugMessageControlKHR peglDebugMessageControlKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroyContext(IntPtr dpy, IntPtr ctx);

			internal static eglDestroyContext peglDestroyContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroyImage(IntPtr dpy, IntPtr image);

			[AliasOf("eglDestroyImage")]
			[AliasOf("eglDestroyImageKHR")]
			internal static eglDestroyImage peglDestroyImage;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroyStreamKHR(IntPtr dpy, IntPtr stream);

			internal static eglDestroyStreamKHR peglDestroyStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroySurface(IntPtr dpy, IntPtr surface);

			internal static eglDestroySurface peglDestroySurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroySync(IntPtr dpy, IntPtr sync);

			[AliasOf("eglDestroySync")]
			[AliasOf("eglDestroySyncKHR")]
			internal static eglDestroySync peglDestroySync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglDestroySyncNV(IntPtr sync);

			internal static eglDestroySyncNV peglDestroySyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglDupNativeFenceFDANDROID(IntPtr dpy, IntPtr sync);

			internal static eglDupNativeFenceFDANDROID peglDupNativeFenceFDANDROID;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglExportDMABUFImageMESA(IntPtr dpy, IntPtr image, int* fds, int* strides, int* offsets);

			internal static eglExportDMABUFImageMESA peglExportDMABUFImageMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglExportDMABUFImageQueryMESA(IntPtr dpy, IntPtr image, int* fourcc, int* num_planes, UInt64* modifiers);

			internal static eglExportDMABUFImageQueryMESA peglExportDMABUFImageQueryMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglExportDRMImageMESA(IntPtr dpy, IntPtr image, int* name, int* handle, int* stride);

			internal static eglExportDRMImageMESA peglExportDRMImageMESA;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglFenceNV(IntPtr sync);

			internal static eglFenceNV peglFenceNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int* value);

			internal static eglGetConfigAttrib peglGetConfigAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetConfigs(IntPtr dpy, IntPtr* configs, int config_size, int* num_config);

			internal static eglGetConfigs peglGetConfigs;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentContext();

			internal static eglGetCurrentContext peglGetCurrentContext;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentDisplay();

			internal static eglGetCurrentDisplay peglGetCurrentDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetCurrentSurface(int readdraw);

			internal static eglGetCurrentSurface peglGetCurrentSurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetDisplay(IntPtr display_id);

			internal static eglGetDisplay peglGetDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate int eglGetError();

			internal static eglGetError peglGetError;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetOutputLayersEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* layers, int max_layers, int* num_layers);

			internal static eglGetOutputLayersEXT peglGetOutputLayersEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetOutputPortsEXT(IntPtr dpy, IntPtr* attrib_list, IntPtr* ports, int max_ports, int* num_ports);

			internal static eglGetOutputPortsEXT peglGetOutputPortsEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetPlatformDisplay(uint platform, IntPtr native_display, IntPtr* attrib_list);

			internal static eglGetPlatformDisplay peglGetPlatformDisplay;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglGetPlatformDisplayEXT(uint platform, IntPtr native_display, int* attrib_list);

			internal static eglGetPlatformDisplayEXT peglGetPlatformDisplayEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr eglGetProcAddress(string procname);

			internal static eglGetProcAddress peglGetProcAddress;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglGetStreamFileDescriptorKHR(IntPtr dpy, IntPtr stream);

			internal static eglGetStreamFileDescriptorKHR peglGetStreamFileDescriptorKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, IntPtr* value);

			internal static eglGetSyncAttrib peglGetSyncAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetSyncAttribKHR(IntPtr dpy, IntPtr sync, int attribute, int* value);

			internal static eglGetSyncAttribKHR peglGetSyncAttribKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglGetSyncAttribNV(IntPtr sync, int attribute, int* value);

			internal static eglGetSyncAttribNV peglGetSyncAttribNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeFrequencyNV();

			internal static eglGetSystemTimeFrequencyNV peglGetSystemTimeFrequencyNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt64 eglGetSystemTimeNV();

			internal static eglGetSystemTimeNV peglGetSystemTimeNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglInitialize(IntPtr dpy, int* major, int* minor);

			internal static eglInitialize peglInitialize;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglLabelObjectKHR(IntPtr display, uint objectType, IntPtr @object, IntPtr label);

			internal static eglLabelObjectKHR peglLabelObjectKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglLockSurfaceKHR(IntPtr dpy, IntPtr surface, int* attrib_list);

			internal static eglLockSurfaceKHR peglLockSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglMakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx);

			internal static eglMakeCurrent peglMakeCurrent;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr value);

			internal static eglOutputLayerAttribEXT peglOutputLayerAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr value);

			internal static eglOutputPortAttribEXT peglOutputPortAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglPostSubBufferNV(IntPtr dpy, IntPtr surface, int x, int y, int width, int height);

			internal static eglPostSubBufferNV peglPostSubBufferNV;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate uint eglQueryAPI();

			internal static eglQueryAPI peglQueryAPI;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryContext(IntPtr dpy, IntPtr ctx, int attribute, int* value);

			internal static eglQueryContext peglQueryContext;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDebugKHR(int attribute, IntPtr* value);

			internal static eglQueryDebugKHR peglQueryDebugKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDeviceAttribEXT(IntPtr device, int attribute, IntPtr* value);

			internal static eglQueryDeviceAttribEXT peglQueryDeviceAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryDeviceStringEXT(IntPtr device, int name);

			internal static eglQueryDeviceStringEXT peglQueryDeviceStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDevicesEXT(int max_devices, IntPtr* devices, int* num_devices);

			internal static eglQueryDevicesEXT peglQueryDevicesEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryDisplayAttribEXT(IntPtr dpy, int attribute, IntPtr* value);

			[AliasOf("eglQueryDisplayAttribEXT")]
			[AliasOf("eglQueryDisplayAttribNV")]
			internal static eglQueryDisplayAttribEXT peglQueryDisplayAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryNativeDisplayNV(IntPtr dpy, IntPtr* display_id);

			internal static eglQueryNativeDisplayNV peglQueryNativeDisplayNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryNativePixmapNV(IntPtr dpy, IntPtr surf, IntPtr* pixmap);

			internal static eglQueryNativePixmapNV peglQueryNativePixmapNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryNativeWindowNV(IntPtr dpy, IntPtr surf, IntPtr* window);

			internal static eglQueryNativeWindowNV peglQueryNativeWindowNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryOutputLayerAttribEXT(IntPtr dpy, IntPtr layer, int attribute, IntPtr* value);

			internal static eglQueryOutputLayerAttribEXT peglQueryOutputLayerAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputLayerStringEXT(IntPtr dpy, IntPtr layer, int name);

			internal static eglQueryOutputLayerStringEXT peglQueryOutputLayerStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryOutputPortAttribEXT(IntPtr dpy, IntPtr port, int attribute, IntPtr* value);

			internal static eglQueryOutputPortAttribEXT peglQueryOutputPortAttribEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryOutputPortStringEXT(IntPtr dpy, IntPtr port, int name);

			internal static eglQueryOutputPortStringEXT peglQueryOutputPortStringEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamKHR(IntPtr dpy, IntPtr stream, uint attribute, int* value);

			internal static eglQueryStreamKHR peglQueryStreamKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamMetadataNV(IntPtr dpy, IntPtr stream, uint name, int n, int offset, int size, IntPtr data);

			internal static eglQueryStreamMetadataNV peglQueryStreamMetadataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamTimeKHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			internal static eglQueryStreamTimeKHR peglQueryStreamTimeKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQueryStreamu64KHR(IntPtr dpy, IntPtr stream, uint attribute, UInt64* value);

			internal static eglQueryStreamu64KHR peglQueryStreamu64KHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglQueryString(IntPtr dpy, int name);

			internal static eglQueryString peglQueryString;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQuerySurface(IntPtr dpy, IntPtr surface, int attribute, int* value);

			internal static eglQuerySurface peglQuerySurface;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQuerySurface64KHR(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			internal static eglQuerySurface64KHR peglQuerySurface64KHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglQuerySurfacePointerANGLE(IntPtr dpy, IntPtr surface, int attribute, IntPtr* value);

			internal static eglQuerySurfacePointerANGLE peglQuerySurfacePointerANGLE;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			internal static eglReleaseTexImage peglReleaseTexImage;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglReleaseThread();

			internal static eglReleaseThread peglReleaseThread;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void eglSetBlobCacheFuncsANDROID(IntPtr dpy, SetBlobFuncDelegate set, GetBlobFuncDelegate get);

			internal static eglSetBlobCacheFuncsANDROID peglSetBlobCacheFuncsANDROID;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSetDamageRegionKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSetDamageRegionKHR peglSetDamageRegionKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSetStreamMetadataNV(IntPtr dpy, IntPtr stream, int n, int offset, int size, IntPtr data);

			internal static eglSetStreamMetadataNV peglSetStreamMetadataNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSignalSyncKHR(IntPtr dpy, IntPtr sync, uint mode);

			internal static eglSignalSyncKHR peglSignalSyncKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSignalSyncNV(IntPtr sync, uint mode);

			internal static eglSignalSyncNV peglSignalSyncNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamAttribKHR(IntPtr dpy, IntPtr stream, uint attribute, int value);

			internal static eglStreamAttribKHR peglStreamAttribKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerAcquireKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerAcquireKHR peglStreamConsumerAcquireKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerGLTextureExternalKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerGLTextureExternalKHR peglStreamConsumerGLTextureExternalKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerGLTextureExternalAttribsNV(IntPtr dpy, IntPtr stream, IntPtr* attrib_list);

			internal static eglStreamConsumerGLTextureExternalAttribsNV peglStreamConsumerGLTextureExternalAttribsNV;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerOutputEXT(IntPtr dpy, IntPtr stream, IntPtr layer);

			internal static eglStreamConsumerOutputEXT peglStreamConsumerOutputEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglStreamConsumerReleaseKHR(IntPtr dpy, IntPtr stream);

			internal static eglStreamConsumerReleaseKHR peglStreamConsumerReleaseKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			internal static eglSurfaceAttrib peglSurfaceAttrib;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffers(IntPtr dpy, IntPtr surface);

			internal static eglSwapBuffers peglSwapBuffers;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffersWithDamageEXT(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSwapBuffersWithDamageEXT peglSwapBuffersWithDamageEXT;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffersWithDamageKHR(IntPtr dpy, IntPtr surface, int* rects, int n_rects);

			internal static eglSwapBuffersWithDamageKHR peglSwapBuffersWithDamageKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffersRegionNOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			internal static eglSwapBuffersRegionNOK peglSwapBuffersRegionNOK;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapBuffersRegion2NOK(IntPtr dpy, IntPtr surface, int numRects, int* rects);

			internal static eglSwapBuffersRegion2NOK peglSwapBuffersRegion2NOK;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglSwapInterval(IntPtr dpy, int interval);

			internal static eglSwapInterval peglSwapInterval;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglTerminate(IntPtr dpy);

			internal static eglTerminate peglTerminate;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglUnlockSurfaceKHR(IntPtr dpy, IntPtr surface);

			internal static eglUnlockSurfaceKHR peglUnlockSurfaceKHR;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglWaitClient();

			internal static eglWaitClient peglWaitClient;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglWaitGL();

			internal static eglWaitGL peglWaitGL;

			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglWaitNative(int engine);

			internal static eglWaitNative peglWaitNative;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate bool eglWaitSync(IntPtr dpy, IntPtr sync, int flags);

			internal static eglWaitSync peglWaitSync;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int eglWaitSyncKHR(IntPtr dpy, IntPtr sync, int flags);

			internal static eglWaitSyncKHR peglWaitSyncKHR;

		}
	}

}
