
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_RASTER_MULTISAMPLE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int RASTER_MULTISAMPLE_EXT = 0x9327;

		/// <summary>
		/// Value of GL_RASTER_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int RASTER_SAMPLES_EXT = 0x9328;

		/// <summary>
		/// Value of GL_MAX_RASTER_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int MAX_RASTER_SAMPLES_EXT = 0x9329;

		/// <summary>
		/// Value of GL_RASTER_FIXED_SAMPLE_LOCATIONS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int RASTER_FIXED_SAMPLE_LOCATIONS_EXT = 0x932A;

		/// <summary>
		/// Value of GL_MULTISAMPLE_RASTERIZATION_ALLOWED_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int MULTISAMPLE_RASTERIZATION_ALLOWED_EXT = 0x932B;

		/// <summary>
		/// Value of GL_EFFECTIVE_RASTER_SAMPLES_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public const int EFFECTIVE_RASTER_SAMPLES_EXT = 0x932C;

		/// <summary>
		/// Binding for glRasterSamplesEXT.
		/// </summary>
		/// <param name="samples">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="fixedsamplelocations">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_raster_multisample", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_texture_filter_minmax", Api = "gl|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_mixed_samples", Api = "gl|gles2")]
		public static void RasterSampleEXT(UInt32 samples, bool fixedsamplelocations)
		{
			Debug.Assert(Delegates.pglRasterSamplesEXT != null, "pglRasterSamplesEXT not implemented");
			Delegates.pglRasterSamplesEXT(samples, fixedsamplelocations);
			LogFunction("glRasterSamplesEXT({0}, {1})", samples, fixedsamplelocations);
			DebugCheckErrors(null);
		}

	}

}
