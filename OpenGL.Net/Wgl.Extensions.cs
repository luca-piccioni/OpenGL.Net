
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
	public partial class Wgl
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions : ExtensionsCollection
		{
			/// <summary>
			/// Support for extension WGL_ARB_buffer_region.
			/// </summary>
			[Extension("WGL_ARB_buffer_region")]
			[ExtensionSupport("wgl")]
			public bool BufferRegion_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_multisample.
			/// </summary>
			[Extension("WGL_ARB_multisample")]
			[ExtensionSupport("wgl")]
			public bool Multisample_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_extensions_string.
			/// </summary>
			[Extension("WGL_ARB_extensions_string")]
			[ExtensionSupport("wgl")]
			public bool ExtensionsString_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_pixel_format.
			/// </summary>
			[Extension("WGL_ARB_pixel_format")]
			[ExtensionSupport("wgl")]
			public bool PixelFormat_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_make_current_read.
			/// </summary>
			[Extension("WGL_ARB_make_current_read")]
			[ExtensionSupport("wgl")]
			public bool MakeCurrentRead_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_pbuffer.
			/// </summary>
			[Extension("WGL_ARB_pbuffer")]
			[ExtensionSupport("wgl")]
			public bool Pbuffer_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_render_texture.
			/// </summary>
			[Extension("WGL_ARB_render_texture")]
			[ExtensionSupport("wgl")]
			public bool RenderTexture_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_pixel_format_float.
			/// </summary>
			[Extension("WGL_ARB_pixel_format_float")]
			[ExtensionSupport("wgl")]
			public bool PixelFormatFloat_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_framebuffer_sRGB.
			/// </summary>
			[Extension("WGL_ARB_framebuffer_sRGB")]
			[ExtensionSupport("wgl")]
			public bool FramebufferSRGB_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_create_context.
			/// </summary>
			[Extension("WGL_ARB_create_context")]
			[ExtensionSupport("wgl")]
			public bool CreateContext_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_create_context_profile.
			/// </summary>
			[Extension("WGL_ARB_create_context_profile")]
			[ExtensionSupport("wgl")]
			public bool CreateContextProfile_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_create_context_robustness.
			/// </summary>
			[Extension("WGL_ARB_create_context_robustness")]
			[ExtensionSupport("wgl")]
			public bool CreateContextRobustness_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_robustness_application_isolation.
			/// </summary>
			[Extension("WGL_ARB_robustness_application_isolation")]
			[Extension("WGL_ARB_robustness_share_group_isolation")]
			[ExtensionSupport("wgl")]
			public bool RobustnessApplicationIsolation_ARB;

			/// <summary>
			/// Support for extension WGL_ARB_context_flush_control.
			/// </summary>
			[Extension("WGL_ARB_context_flush_control")]
			[ExtensionSupport("wgl")]
			public bool ContextFlushControl_ARB;

			/// <summary>
			/// Support for extension WGL_EXT_display_color_table.
			/// </summary>
			[Extension("WGL_EXT_display_color_table")]
			public bool DisplayColorTable_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_extensions_string.
			/// </summary>
			[Extension("WGL_EXT_extensions_string")]
			public bool ExtensionsString_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_make_current_read.
			/// </summary>
			[Extension("WGL_EXT_make_current_read")]
			public bool MakeCurrentRead_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_pixel_format.
			/// </summary>
			[Extension("WGL_EXT_pixel_format")]
			public bool PixelFormat_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_pbuffer.
			/// </summary>
			[Extension("WGL_EXT_pbuffer")]
			public bool Pbuffer_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_swap_control.
			/// </summary>
			[Extension("WGL_EXT_swap_control")]
			public bool SwapControl_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_depth_float.
			/// </summary>
			[Extension("WGL_EXT_depth_float")]
			public bool DepthFloat_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_multisample.
			/// </summary>
			[Extension("WGL_EXT_multisample")]
			public bool Multisample_EXT;

			/// <summary>
			/// Support for extension WGL_OML_sync_control.
			/// </summary>
			[Extension("WGL_OML_sync_control")]
			public bool SyncControl_OML;

			/// <summary>
			/// Support for extension WGL_I3D_digital_video_control.
			/// </summary>
			[Extension("WGL_I3D_digital_video_control")]
			public bool DigitalVideoControl_I3D;

			/// <summary>
			/// Support for extension WGL_I3D_gamma.
			/// </summary>
			[Extension("WGL_I3D_gamma")]
			public bool Gamma_I3D;

			/// <summary>
			/// Support for extension WGL_I3D_genlock.
			/// </summary>
			[Extension("WGL_I3D_genlock")]
			public bool Genlock_I3D;

			/// <summary>
			/// Support for extension WGL_I3D_image_buffer.
			/// </summary>
			[Extension("WGL_I3D_image_buffer")]
			public bool ImageBuffer_I3D;

			/// <summary>
			/// Support for extension WGL_I3D_swap_frame_lock.
			/// </summary>
			[Extension("WGL_I3D_swap_frame_lock")]
			public bool SwapFrameLock_I3D;

			/// <summary>
			/// Support for extension WGL_I3D_swap_frame_usage.
			/// </summary>
			[Extension("WGL_I3D_swap_frame_usage")]
			public bool SwapFrameUsage_I3D;

			/// <summary>
			/// Support for extension WGL_NV_render_depth_texture.
			/// </summary>
			[Extension("WGL_NV_render_depth_texture")]
			public bool RenderDepthTexture_NV;

			/// <summary>
			/// Support for extension WGL_NV_render_texture_rectangle.
			/// </summary>
			[Extension("WGL_NV_render_texture_rectangle")]
			public bool RenderTextureRectangle_NV;

			/// <summary>
			/// Support for extension WGL_ATI_pixel_format_float.
			/// </summary>
			[Extension("WGL_ATI_pixel_format_float")]
			public bool PixelFormatFloat_ATI;

			/// <summary>
			/// Support for extension WGL_NV_float_buffer.
			/// </summary>
			[Extension("WGL_NV_float_buffer")]
			public bool FloatBuffer_NV;

			/// <summary>
			/// Support for extension WGL_3DL_stereo_control.
			/// </summary>
			[Extension("WGL_3DL_stereo_control")]
			public bool StereoControl_3DL;

			/// <summary>
			/// Support for extension WGL_EXT_pixel_format_packed_float.
			/// </summary>
			[Extension("WGL_EXT_pixel_format_packed_float")]
			public bool PixelFormatPackedFloat_EXT;

			/// <summary>
			/// Support for extension WGL_EXT_framebuffer_sRGB.
			/// </summary>
			[Extension("WGL_EXT_framebuffer_sRGB")]
			public bool FramebufferSRGB_EXT;

			/// <summary>
			/// Support for extension WGL_NV_present_video.
			/// </summary>
			[Extension("WGL_NV_present_video")]
			public bool PresentVideo_NV;

			/// <summary>
			/// Support for extension WGL_NV_video_output.
			/// </summary>
			[Extension("WGL_NV_video_output")]
			public bool VideoOutput_NV;

			/// <summary>
			/// Support for extension WGL_NV_swap_group.
			/// </summary>
			[Extension("WGL_NV_swap_group")]
			public bool SwapGroup_NV;

			/// <summary>
			/// Support for extension WGL_NV_gpu_affinity.
			/// </summary>
			[Extension("WGL_NV_gpu_affinity")]
			public bool GpuAffinity_NV;

			/// <summary>
			/// Support for extension WGL_AMD_gpu_association.
			/// </summary>
			[Extension("WGL_AMD_gpu_association")]
			public bool GpuAssociation_AMD;

			/// <summary>
			/// Support for extension WGL_NV_video_capture.
			/// </summary>
			[Extension("WGL_NV_video_capture")]
			public bool VideoCapture_NV;

			/// <summary>
			/// Support for extension WGL_NV_copy_image.
			/// </summary>
			[Extension("WGL_NV_copy_image")]
			public bool CopyImage_NV;

			/// <summary>
			/// Support for extension WGL_EXT_create_context_es_profile.
			/// </summary>
			[Extension("WGL_EXT_create_context_es_profile")]
			[Extension("WGL_EXT_create_context_es2_profile")]
			public bool CreateContextEsProfile_EXT;

			/// <summary>
			/// Support for extension WGL_NV_DX_interop.
			/// </summary>
			[Extension("WGL_NV_DX_interop")]
			public bool DXInterop_NV;

			/// <summary>
			/// Support for extension WGL_NV_DX_interop2.
			/// </summary>
			[Extension("WGL_NV_DX_interop2")]
			public bool DXInterop2_NV;

			/// <summary>
			/// Support for extension WGL_EXT_swap_control_tear.
			/// </summary>
			[Extension("WGL_EXT_swap_control_tear")]
			public bool SwapControlTear_EXT;

			/// <summary>
			/// Support for extension WGL_NV_delay_before_swap.
			/// </summary>
			[Extension("WGL_NV_delay_before_swap")]
			public bool DelayBeforeSwap_NV;

			/// <summary>
			/// Support for extension WGL_3DFX_multisample.
			/// </summary>
			[Extension("WGL_3DFX_multisample")]
			public bool Multisample_3DFX;

			/// <summary>
			/// Support for extension WGL_NV_multisample_coverage.
			/// </summary>
			[Extension("WGL_NV_multisample_coverage")]
			public bool MultisampleCoverage_NV;

			/// <summary>
			/// Support for extension WGL_EXT_colorspace.
			/// </summary>
			[Extension("WGL_EXT_colorspace")]
			public bool Colorspace_EXT;

			/// <summary>
			/// Support for extension WGL_NV_vertex_array_range.
			/// </summary>
			[Extension("WGL_NV_vertex_array_range")]
			public bool VertexArrayRange_NV;

		}
}

}
