
// Copyright (C) 2015-2016 Luca Piccioni
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
	public partial class Glx
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions : ExtensionsCollection
		{
			/// <summary>
			/// Support for extension GLX_ARB_get_proc_address.
			/// </summary>
			[Extension("GLX_ARB_get_proc_address")]
			[ExtensionSupport("glx")]
			public bool GetProcAddress_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_multisample.
			/// </summary>
			[Extension("GLX_ARB_multisample")]
			[ExtensionSupport("glx")]
			public bool Multisample_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_vertex_buffer_object.
			/// </summary>
			[Extension("GLX_ARB_vertex_buffer_object")]
			[ExtensionSupport("glx")]
			public bool VertexBufferObject_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_fbconfig_float.
			/// </summary>
			[Extension("GLX_ARB_fbconfig_float")]
			[ExtensionSupport("glx")]
			public bool FbconfigFloat_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_framebuffer_sRGB.
			/// </summary>
			[Extension("GLX_ARB_framebuffer_sRGB")]
			[ExtensionSupport("glx")]
			public bool FramebufferSRGB_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_create_context.
			/// </summary>
			[Extension("GLX_ARB_create_context")]
			[ExtensionSupport("glx")]
			public bool CreateContext_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_create_context_profile.
			/// </summary>
			[Extension("GLX_ARB_create_context_profile")]
			[ExtensionSupport("glx")]
			public bool CreateContextProfile_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_create_context_robustness.
			/// </summary>
			[Extension("GLX_ARB_create_context_robustness")]
			[ExtensionSupport("glx")]
			public bool CreateContextRobustness_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_robustness_application_isolation.
			/// </summary>
			[Extension("GLX_ARB_robustness_application_isolation")]
			[Extension("GLX_ARB_robustness_share_group_isolation")]
			[ExtensionSupport("glx")]
			public bool RobustnessApplicationIsolation_ARB;

			/// <summary>
			/// Support for extension GLX_ARB_context_flush_control.
			/// </summary>
			[Extension("GLX_ARB_context_flush_control")]
			[ExtensionSupport("glx")]
			public bool ContextFlushControl_ARB;

			/// <summary>
			/// Support for extension GLX_SGIS_multisample.
			/// </summary>
			[Extension("GLX_SGIS_multisample")]
			public bool Multisample_SGIS;

			/// <summary>
			/// Support for extension GLX_EXT_visual_info.
			/// </summary>
			[Extension("GLX_EXT_visual_info")]
			public bool VisualInfo_EXT;

			/// <summary>
			/// Support for extension GLX_SGI_swap_control.
			/// </summary>
			[Extension("GLX_SGI_swap_control")]
			public bool SwapControl_SGI;

			/// <summary>
			/// Support for extension GLX_SGI_video_sync.
			/// </summary>
			[Extension("GLX_SGI_video_sync")]
			public bool VideoSync_SGI;

			/// <summary>
			/// Support for extension GLX_SGI_make_current_read.
			/// </summary>
			[Extension("GLX_SGI_make_current_read")]
			public bool MakeCurrentRead_SGI;

			/// <summary>
			/// Support for extension GLX_SGIX_video_source.
			/// </summary>
			[Extension("GLX_SGIX_video_source")]
			public bool VideoSource_SGIX;

			/// <summary>
			/// Support for extension GLX_EXT_visual_rating.
			/// </summary>
			[Extension("GLX_EXT_visual_rating")]
			public bool VisualRating_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_import_context.
			/// </summary>
			[Extension("GLX_EXT_import_context")]
			public bool ImportContext_EXT;

			/// <summary>
			/// Support for extension GLX_SGIX_fbconfig.
			/// </summary>
			[Extension("GLX_SGIX_fbconfig")]
			public bool Fbconfig_SGIX;

			/// <summary>
			/// Support for extension GLX_SGIX_pbuffer.
			/// </summary>
			[Extension("GLX_SGIX_pbuffer")]
			public bool Pbuffer_SGIX;

			/// <summary>
			/// Support for extension GLX_SGI_cushion.
			/// </summary>
			[Extension("GLX_SGI_cushion")]
			public bool Cushion_SGI;

			/// <summary>
			/// Support for extension GLX_SGIX_video_resize.
			/// </summary>
			[Extension("GLX_SGIX_video_resize")]
			public bool VideoResize_SGIX;

			/// <summary>
			/// Support for extension GLX_SGIX_swap_group.
			/// </summary>
			[Extension("GLX_SGIX_swap_group")]
			public bool SwapGroup_SGIX;

			/// <summary>
			/// Support for extension GLX_SGIX_swap_barrier.
			/// </summary>
			[Extension("GLX_SGIX_swap_barrier")]
			public bool SwapBarrier_SGIX;

			/// <summary>
			/// Support for extension GLX_SGIS_blended_overlay.
			/// </summary>
			[Extension("GLX_SGIS_blended_overlay")]
			public bool BlendedOverlay_SGIS;

			/// <summary>
			/// Support for extension GLX_SUN_get_transparent_index.
			/// </summary>
			[Extension("GLX_SUN_get_transparent_index")]
			public bool GetTransparentIndex_SUN;

			/// <summary>
			/// Support for extension GLX_MESA_copy_sub_buffer.
			/// </summary>
			[Extension("GLX_MESA_copy_sub_buffer")]
			public bool CopySubBuffer_MESA;

			/// <summary>
			/// Support for extension GLX_MESA_pixmap_colormap.
			/// </summary>
			[Extension("GLX_MESA_pixmap_colormap")]
			public bool PixmapColormap_MESA;

			/// <summary>
			/// Support for extension GLX_MESA_release_buffers.
			/// </summary>
			[Extension("GLX_MESA_release_buffers")]
			public bool ReleaseBuffers_MESA;

			/// <summary>
			/// Support for extension GLX_MESA_set_3dfx_mode.
			/// </summary>
			[Extension("GLX_MESA_set_3dfx_mode")]
			public bool Set3dfxMode_MESA;

			/// <summary>
			/// Support for extension GLX_SGIX_visual_select_group.
			/// </summary>
			[Extension("GLX_SGIX_visual_select_group")]
			public bool VisualSelectGroup_SGIX;

			/// <summary>
			/// Support for extension GLX_OML_swap_method.
			/// </summary>
			[Extension("GLX_OML_swap_method")]
			public bool SwapMethod_OML;

			/// <summary>
			/// Support for extension GLX_OML_sync_control.
			/// </summary>
			[Extension("GLX_OML_sync_control")]
			public bool SyncControl_OML;

			/// <summary>
			/// Support for extension GLX_SGIX_hyperpipe.
			/// </summary>
			[Extension("GLX_SGIX_hyperpipe")]
			public bool Hyperpipe_SGIX;

			/// <summary>
			/// Support for extension GLX_MESA_agp_offset.
			/// </summary>
			[Extension("GLX_MESA_agp_offset")]
			public bool AgpOffset_MESA;

			/// <summary>
			/// Support for extension GLX_EXT_fbconfig_packed_float.
			/// </summary>
			[Extension("GLX_EXT_fbconfig_packed_float")]
			public bool FbconfigPackedFloat_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_framebuffer_sRGB.
			/// </summary>
			[Extension("GLX_EXT_framebuffer_sRGB")]
			public bool FramebufferSRGB_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_texture_from_pixmap.
			/// </summary>
			[Extension("GLX_EXT_texture_from_pixmap")]
			public bool TextureFromPixmap_EXT;

			/// <summary>
			/// Support for extension GLX_NV_present_video.
			/// </summary>
			[Extension("GLX_NV_present_video")]
			public bool PresentVideo_NV;

			/// <summary>
			/// Support for extension GLX_NV_video_out.
			/// </summary>
			[Extension("GLX_NV_video_out")]
			public bool VideoOut_NV;

			/// <summary>
			/// Support for extension GLX_NV_swap_group.
			/// </summary>
			[Extension("GLX_NV_swap_group")]
			public bool SwapGroup_NV;

			/// <summary>
			/// Support for extension GLX_NV_video_capture.
			/// </summary>
			[Extension("GLX_NV_video_capture")]
			public bool VideoCapture_NV;

			/// <summary>
			/// Support for extension GLX_NV_copy_image.
			/// </summary>
			[Extension("GLX_NV_copy_image")]
			public bool CopyImage_NV;

			/// <summary>
			/// Support for extension GLX_INTEL_swap_event.
			/// </summary>
			[Extension("GLX_INTEL_swap_event")]
			public bool SwapEvent_INTEL;

			/// <summary>
			/// Support for extension GLX_AMD_gpu_association.
			/// </summary>
			[Extension("GLX_AMD_gpu_association")]
			public bool GpuAssociation_AMD;

			/// <summary>
			/// Support for extension GLX_EXT_create_context_es_profile.
			/// </summary>
			[Extension("GLX_EXT_create_context_es_profile")]
			[Extension("GLX_EXT_create_context_es2_profile")]
			public bool CreateContextEsProfile_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_swap_control_tear.
			/// </summary>
			[Extension("GLX_EXT_swap_control_tear")]
			public bool SwapControlTear_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_buffer_age.
			/// </summary>
			[Extension("GLX_EXT_buffer_age")]
			public bool BufferAge_EXT;

			/// <summary>
			/// Support for extension GLX_NV_delay_before_swap.
			/// </summary>
			[Extension("GLX_NV_delay_before_swap")]
			public bool DelayBeforeSwap_NV;

			/// <summary>
			/// Support for extension GLX_MESA_query_renderer.
			/// </summary>
			[Extension("GLX_MESA_query_renderer")]
			public bool QueryRenderer_MESA;

			/// <summary>
			/// Support for extension GLX_NV_copy_buffer.
			/// </summary>
			[Extension("GLX_NV_copy_buffer")]
			public bool CopyBuffer_NV;

			/// <summary>
			/// Support for extension GLX_3DFX_multisample.
			/// </summary>
			[Extension("GLX_3DFX_multisample")]
			public bool Multisample_3DFX;

			/// <summary>
			/// Support for extension GLX_EXT_stereo_tree.
			/// </summary>
			[Extension("GLX_EXT_stereo_tree")]
			public bool StereoTree_EXT;

			/// <summary>
			/// Support for extension GLX_EXT_swap_control.
			/// </summary>
			[Extension("GLX_EXT_swap_control")]
			public bool SwapControl_EXT;

			/// <summary>
			/// Support for extension GLX_NV_float_buffer.
			/// </summary>
			[Extension("GLX_NV_float_buffer")]
			public bool FloatBuffer_NV;

			/// <summary>
			/// Support for extension GLX_NV_multisample_coverage.
			/// </summary>
			[Extension("GLX_NV_multisample_coverage")]
			public bool MultisampleCoverage_NV;

			/// <summary>
			/// Support for extension GLX_SGIS_shared_multisample.
			/// </summary>
			[Extension("GLX_SGIS_shared_multisample")]
			public bool SharedMultisample_SGIS;

			/// <summary>
			/// Support for extension GLX_SGIX_dmbuffer.
			/// </summary>
			[Extension("GLX_SGIX_dmbuffer")]
			public bool Dmbuffer_SGIX;

		}
}

}
