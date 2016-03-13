
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

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions : ExtensionsCollection
		{
			/// <summary>
			/// Support for extension EGL_KHR_gl_renderbuffer_image.
			/// </summary>
			[Extension("EGL_KHR_gl_renderbuffer_image")]
			[ExtensionSupport("egl")]
			public bool GlRenderbufferImage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_wait_sync.
			/// </summary>
			[Extension("EGL_KHR_wait_sync")]
			[ExtensionSupport("egl")]
			public bool WaitSync_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_vg_parent_image.
			/// </summary>
			[Extension("EGL_KHR_vg_parent_image")]
			[ExtensionSupport("egl")]
			public bool VgParentImage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_swap_buffers_with_damage.
			/// </summary>
			[Extension("EGL_KHR_swap_buffers_with_damage")]
			[ExtensionSupport("egl")]
			public bool SwapBuffersWithDamage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_surfaceless_context.
			/// </summary>
			[Extension("EGL_KHR_surfaceless_context")]
			[ExtensionSupport("egl")]
			public bool SurfacelessContext_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream_producer_eglsurface.
			/// </summary>
			[Extension("EGL_KHR_stream_producer_eglsurface")]
			[ExtensionSupport("egl")]
			public bool StreamProducerEglsurface_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream_producer_aldatalocator.
			/// </summary>
			[Extension("EGL_KHR_stream_producer_aldatalocator")]
			[ExtensionSupport("egl")]
			public bool StreamProducerAldatalocator_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream_fifo.
			/// </summary>
			[Extension("EGL_KHR_stream_fifo")]
			[ExtensionSupport("egl")]
			public bool StreamFifo_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream_cross_process_fd.
			/// </summary>
			[Extension("EGL_KHR_stream_cross_process_fd")]
			[ExtensionSupport("egl")]
			public bool StreamCrossProcessFd_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream_consumer_gltexture.
			/// </summary>
			[Extension("EGL_KHR_stream_consumer_gltexture")]
			[ExtensionSupport("egl")]
			public bool StreamConsumerGltexture_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_stream.
			/// </summary>
			[Extension("EGL_KHR_stream")]
			[ExtensionSupport("egl")]
			public bool Stream_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_reusable_sync.
			/// </summary>
			[Extension("EGL_KHR_reusable_sync")]
			[ExtensionSupport("egl")]
			public bool ReusableSync_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_platform_x11.
			/// </summary>
			[Extension("EGL_KHR_platform_x11")]
			[ExtensionSupport("egl")]
			public bool PlatformX11_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_platform_wayland.
			/// </summary>
			[Extension("EGL_KHR_platform_wayland")]
			[ExtensionSupport("egl")]
			public bool PlatformWayland_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_platform_gbm.
			/// </summary>
			[Extension("EGL_KHR_platform_gbm")]
			[ExtensionSupport("egl")]
			public bool PlatformGbm_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_platform_android.
			/// </summary>
			[Extension("EGL_KHR_platform_android")]
			[ExtensionSupport("egl")]
			public bool PlatformAndroid_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_partial_update.
			/// </summary>
			[Extension("EGL_KHR_partial_update")]
			[ExtensionSupport("egl")]
			public bool PartialUpdate_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_lock_surface3.
			/// </summary>
			[Extension("EGL_KHR_lock_surface3")]
			[ExtensionSupport("egl")]
			public bool LockSurface3_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_lock_surface2.
			/// </summary>
			[Extension("EGL_KHR_lock_surface2")]
			[ExtensionSupport("egl")]
			public bool LockSurface2_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_lock_surface.
			/// </summary>
			[Extension("EGL_KHR_lock_surface")]
			[ExtensionSupport("egl")]
			public bool LockSurface_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_image_pixmap.
			/// </summary>
			[Extension("EGL_KHR_image_pixmap")]
			[ExtensionSupport("egl")]
			public bool ImagePixmap_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_image_base.
			/// </summary>
			[Extension("EGL_KHR_image_base")]
			[ExtensionSupport("egl")]
			public bool ImageBase_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_image.
			/// </summary>
			[Extension("EGL_KHR_image")]
			[ExtensionSupport("egl")]
			public bool Image_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_gl_texture_cubemap_image.
			/// </summary>
			[Extension("EGL_KHR_gl_texture_cubemap_image")]
			[ExtensionSupport("egl")]
			public bool GlTextureCubemapImage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_gl_texture_3D_image.
			/// </summary>
			[Extension("EGL_KHR_gl_texture_3D_image")]
			[ExtensionSupport("egl")]
			public bool GlTexture3DImage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_gl_texture_2D_image.
			/// </summary>
			[Extension("EGL_KHR_gl_texture_2D_image")]
			[ExtensionSupport("egl")]
			public bool GlTexture2DImage_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_gl_colorspace.
			/// </summary>
			[Extension("EGL_KHR_gl_colorspace")]
			[ExtensionSupport("egl")]
			public bool GlColorspace_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_get_all_proc_addresses.
			/// </summary>
			[Extension("EGL_KHR_get_all_proc_addresses")]
			[ExtensionSupport("egl")]
			public bool GetAllProcAddresses_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_fence_sync.
			/// </summary>
			[Extension("EGL_KHR_fence_sync")]
			[ExtensionSupport("egl")]
			public bool FenceSync_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_debug.
			/// </summary>
			[Extension("EGL_KHR_debug")]
			[ExtensionSupport("egl")]
			public bool Debug_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_create_context_no_error.
			/// </summary>
			[Extension("EGL_KHR_create_context_no_error")]
			[ExtensionSupport("egl")]
			public bool CreateContextNoError_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_create_context.
			/// </summary>
			[Extension("EGL_KHR_create_context")]
			[ExtensionSupport("egl")]
			public bool CreateContext_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_client_get_all_proc_addresses.
			/// </summary>
			[Extension("EGL_KHR_client_get_all_proc_addresses")]
			[ExtensionSupport("egl")]
			public bool ClientGetAllProcAddresses_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_config_attribs.
			/// </summary>
			[Extension("EGL_KHR_config_attribs")]
			[ExtensionSupport("egl")]
			public bool ConfigAttribs_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_cl_event2.
			/// </summary>
			[Extension("EGL_KHR_cl_event2")]
			[ExtensionSupport("egl")]
			public bool ClEvent2_KHR;

			/// <summary>
			/// Support for extension EGL_KHR_cl_event.
			/// </summary>
			[Extension("EGL_KHR_cl_event")]
			[ExtensionSupport("egl")]
			public bool ClEvent_KHR;

			/// <summary>
			/// Support for extension EGL_ANDROID_blob_cache.
			/// </summary>
			[Extension("EGL_ANDROID_blob_cache")]
			public bool BlobCache_ANDROID;

			/// <summary>
			/// Support for extension EGL_TIZEN_image_native_surface.
			/// </summary>
			[Extension("EGL_TIZEN_image_native_surface")]
			public bool ImageNativeSurface_TIZEN;

			/// <summary>
			/// Support for extension EGL_ANDROID_framebuffer_target.
			/// </summary>
			[Extension("EGL_ANDROID_framebuffer_target")]
			public bool FramebufferTarget_ANDROID;

			/// <summary>
			/// Support for extension EGL_TIZEN_image_native_buffer.
			/// </summary>
			[Extension("EGL_TIZEN_image_native_buffer")]
			public bool ImageNativeBuffer_TIZEN;

			/// <summary>
			/// Support for extension EGL_NV_system_time.
			/// </summary>
			[Extension("EGL_NV_system_time")]
			public bool SystemTime_NV;

			/// <summary>
			/// Support for extension EGL_NV_sync.
			/// </summary>
			[Extension("EGL_NV_sync")]
			public bool Sync_NV;

			/// <summary>
			/// Support for extension EGL_NV_stream_sync.
			/// </summary>
			[Extension("EGL_NV_stream_sync")]
			public bool StreamSync_NV;

			/// <summary>
			/// Support for extension EGL_NV_stream_metadata.
			/// </summary>
			[Extension("EGL_NV_stream_metadata")]
			public bool StreamMetadata_NV;

			/// <summary>
			/// Support for extension EGL_NV_stream_consumer_gltexture_yuv.
			/// </summary>
			[Extension("EGL_NV_stream_consumer_gltexture_yuv")]
			public bool StreamConsumerGltextureYuv_NV;

			/// <summary>
			/// Support for extension EGL_NV_post_sub_buffer.
			/// </summary>
			[Extension("EGL_NV_post_sub_buffer")]
			public bool PostSubBuffer_NV;

			/// <summary>
			/// Support for extension EGL_NV_post_convert_rounding.
			/// </summary>
			[Extension("EGL_NV_post_convert_rounding")]
			public bool PostConvertRounding_NV;

			/// <summary>
			/// Support for extension EGL_NV_native_query.
			/// </summary>
			[Extension("EGL_NV_native_query")]
			public bool NativeQuery_NV;

			/// <summary>
			/// Support for extension EGL_NV_device_cuda.
			/// </summary>
			[Extension("EGL_NV_device_cuda")]
			public bool DeviceCuda_NV;

			/// <summary>
			/// Support for extension EGL_NV_depth_nonlinear.
			/// </summary>
			[Extension("EGL_NV_depth_nonlinear")]
			public bool DepthNonlinear_NV;

			/// <summary>
			/// Support for extension EGL_NV_cuda_event.
			/// </summary>
			[Extension("EGL_NV_cuda_event")]
			public bool CudaEvent_NV;

			/// <summary>
			/// Support for extension EGL_NV_coverage_sample_resolve.
			/// </summary>
			[Extension("EGL_NV_coverage_sample_resolve")]
			public bool CoverageSampleResolve_NV;

			/// <summary>
			/// Support for extension EGL_NV_coverage_sample.
			/// </summary>
			[Extension("EGL_NV_coverage_sample")]
			public bool CoverageSample_NV;

			/// <summary>
			/// Support for extension EGL_NV_3dvision_surface.
			/// </summary>
			[Extension("EGL_NV_3dvision_surface")]
			public bool _3dvisionSurface_NV;

			/// <summary>
			/// Support for extension EGL_NOK_texture_from_pixmap.
			/// </summary>
			[Extension("EGL_NOK_texture_from_pixmap")]
			public bool TextureFromPixmap_NOK;

			/// <summary>
			/// Support for extension EGL_NOK_swap_region2.
			/// </summary>
			[Extension("EGL_NOK_swap_region2")]
			public bool SwapRegion2_NOK;

			/// <summary>
			/// Support for extension EGL_NOK_swap_region.
			/// </summary>
			[Extension("EGL_NOK_swap_region")]
			public bool SwapRegion_NOK;

			/// <summary>
			/// Support for extension EGL_MESA_platform_gbm.
			/// </summary>
			[Extension("EGL_MESA_platform_gbm")]
			public bool PlatformGbm_MESA;

			/// <summary>
			/// Support for extension EGL_MESA_image_dma_buf_export.
			/// </summary>
			[Extension("EGL_MESA_image_dma_buf_export")]
			public bool ImageDmaBufExport_MESA;

			/// <summary>
			/// Support for extension EGL_MESA_drm_image.
			/// </summary>
			[Extension("EGL_MESA_drm_image")]
			public bool DrmImage_MESA;

			/// <summary>
			/// Support for extension EGL_ANDROID_image_native_buffer.
			/// </summary>
			[Extension("EGL_ANDROID_image_native_buffer")]
			public bool ImageNativeBuffer_ANDROID;

			/// <summary>
			/// Support for extension EGL_IMG_image_plane_attribs.
			/// </summary>
			[Extension("EGL_IMG_image_plane_attribs")]
			public bool ImagePlaneAttribs_IMG;

			/// <summary>
			/// Support for extension EGL_IMG_context_priority.
			/// </summary>
			[Extension("EGL_IMG_context_priority")]
			public bool ContextPriority_IMG;

			/// <summary>
			/// Support for extension EGL_HI_colorformats.
			/// </summary>
			[Extension("EGL_HI_colorformats")]
			public bool Colorformats_HI;

			/// <summary>
			/// Support for extension EGL_HI_clientpixmap.
			/// </summary>
			[Extension("EGL_HI_clientpixmap")]
			public bool Clientpixmap_HI;

			/// <summary>
			/// Support for extension EGL_EXT_yuv_surface.
			/// </summary>
			[Extension("EGL_EXT_yuv_surface")]
			public bool YuvSurface_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_swap_buffers_with_damage.
			/// </summary>
			[Extension("EGL_EXT_swap_buffers_with_damage")]
			public bool SwapBuffersWithDamage_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_stream_consumer_egloutput.
			/// </summary>
			[Extension("EGL_EXT_stream_consumer_egloutput")]
			public bool StreamConsumerEgloutput_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_protected_surface.
			/// </summary>
			[Extension("EGL_EXT_protected_surface")]
			public bool ProtectedSurface_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_platform_x11.
			/// </summary>
			[Extension("EGL_EXT_platform_x11")]
			public bool PlatformX11_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_platform_wayland.
			/// </summary>
			[Extension("EGL_EXT_platform_wayland")]
			public bool PlatformWayland_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_platform_device.
			/// </summary>
			[Extension("EGL_EXT_platform_device")]
			public bool PlatformDevice_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_platform_base.
			/// </summary>
			[Extension("EGL_EXT_platform_base")]
			public bool PlatformBase_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_output_openwf.
			/// </summary>
			[Extension("EGL_EXT_output_openwf")]
			public bool OutputOpenwf_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_output_drm.
			/// </summary>
			[Extension("EGL_EXT_output_drm")]
			public bool OutputDrm_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_output_base.
			/// </summary>
			[Extension("EGL_EXT_output_base")]
			public bool OutputBase_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_multiview_window.
			/// </summary>
			[Extension("EGL_EXT_multiview_window")]
			public bool MultiviewWindow_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_image_dma_buf_import.
			/// </summary>
			[Extension("EGL_EXT_image_dma_buf_import")]
			public bool ImageDmaBufImport_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_device_query.
			/// </summary>
			[Extension("EGL_EXT_device_query")]
			public bool DeviceQuery_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_device_openwf.
			/// </summary>
			[Extension("EGL_EXT_device_openwf")]
			public bool DeviceOpenwf_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_device_enumeration.
			/// </summary>
			[Extension("EGL_EXT_device_enumeration")]
			public bool DeviceEnumeration_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_device_drm.
			/// </summary>
			[Extension("EGL_EXT_device_drm")]
			public bool DeviceDrm_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_device_base.
			/// </summary>
			[Extension("EGL_EXT_device_base")]
			public bool DeviceBase_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_create_context_robustness.
			/// </summary>
			[Extension("EGL_EXT_create_context_robustness")]
			public bool CreateContextRobustness_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_client_extensions.
			/// </summary>
			[Extension("EGL_EXT_client_extensions")]
			public bool ClientExtensions_EXT;

			/// <summary>
			/// Support for extension EGL_EXT_buffer_age.
			/// </summary>
			[Extension("EGL_EXT_buffer_age")]
			public bool BufferAge_EXT;

			/// <summary>
			/// Support for extension EGL_ARM_pixmap_multisample_discard.
			/// </summary>
			[Extension("EGL_ARM_pixmap_multisample_discard")]
			public bool PixmapMultisampleDiscard_ARM;

			/// <summary>
			/// Support for extension EGL_ANGLE_window_fixed_size.
			/// </summary>
			[Extension("EGL_ANGLE_window_fixed_size")]
			public bool WindowFixedSize_ANGLE;

			/// <summary>
			/// Support for extension EGL_ANGLE_surface_d3d_texture_2d_share_handle.
			/// </summary>
			[Extension("EGL_ANGLE_surface_d3d_texture_2d_share_handle")]
			public bool SurfaceD3dTexture2dShareHandle_ANGLE;

			/// <summary>
			/// Support for extension EGL_ANGLE_query_surface_pointer.
			/// </summary>
			[Extension("EGL_ANGLE_query_surface_pointer")]
			public bool QuerySurfacePointer_ANGLE;

			/// <summary>
			/// Support for extension EGL_ANGLE_device_d3d.
			/// </summary>
			[Extension("EGL_ANGLE_device_d3d")]
			public bool DeviceD3d_ANGLE;

			/// <summary>
			/// Support for extension EGL_ANGLE_d3d_share_handle_client_buffer.
			/// </summary>
			[Extension("EGL_ANGLE_d3d_share_handle_client_buffer")]
			public bool D3dShareHandleClientBuffer_ANGLE;

			/// <summary>
			/// Support for extension EGL_ANDROID_recordable.
			/// </summary>
			[Extension("EGL_ANDROID_recordable")]
			public bool Recordable_ANDROID;

			/// <summary>
			/// Support for extension EGL_ANDROID_native_fence_sync.
			/// </summary>
			[Extension("EGL_ANDROID_native_fence_sync")]
			public bool NativeFenceSync_ANDROID;

		}
}

}
