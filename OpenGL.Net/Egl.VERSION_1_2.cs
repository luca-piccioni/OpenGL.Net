
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_ALPHA_FORMAT symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to VG_ALPHA_FORMAT.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int ALPHA_FORMAT = 0x3088;

		/// <summary>
		/// Value of EGL_ALPHA_FORMAT_NONPRE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to VG_ALPHA_FORMAT_NONPRE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int ALPHA_FORMAT_NONPRE = 0x308B;

		/// <summary>
		/// Value of EGL_ALPHA_FORMAT_PRE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to VG_ALPHA_FORMAT_PRE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int ALPHA_FORMAT_PRE = 0x308C;

		/// <summary>
		/// Value of EGL_ALPHA_MASK_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int ALPHA_MASK_SIZE = 0x303E;

		/// <summary>
		/// Value of EGL_BUFFER_PRESERVED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int BUFFER_PRESERVED = 0x3094;

		/// <summary>
		/// Value of EGL_BUFFER_DESTROYED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int BUFFER_DESTROYED = 0x3095;

		/// <summary>
		/// Value of EGL_CLIENT_APIS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CLIENT_APIS = 0x308D;

		/// <summary>
		/// Value of EGL_COLORSPACE symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to VG_COLORSPACE.
		/// </para>
		/// </remarks>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLORSPACE = 0x3087;

		/// <summary>
		/// Value of EGL_COLORSPACE_sRGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLORSPACE_sRGB = 0x3089;

		/// <summary>
		/// Value of EGL_COLORSPACE_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLORSPACE_LINEAR = 0x308A;

		/// <summary>
		/// Value of EGL_COLOR_BUFFER_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLOR_BUFFER_TYPE = 0x303F;

		/// <summary>
		/// Value of EGL_CONTEXT_CLIENT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CONTEXT_CLIENT_TYPE = 0x3097;

		/// <summary>
		/// Value of EGL_DISPLAY_SCALING symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int DISPLAY_SCALING = 10000;

		/// <summary>
		/// Value of EGL_HORIZONTAL_RESOLUTION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int HORIZONTAL_RESOLUTION = 0x3090;

		/// <summary>
		/// Value of EGL_LUMINANCE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_BUFFER = 0x308F;

		/// <summary>
		/// Value of EGL_LUMINANCE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_SIZE = 0x303D;

		/// <summary>
		/// Value of EGL_OPENGL_ES_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENGL_ES_BIT = 0x0001;

		/// <summary>
		/// Value of EGL_OPENVG_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENVG_BIT = 0x0002;

		/// <summary>
		/// Value of EGL_OPENGL_ES_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENGL_ES_API = 0x30A0;

		/// <summary>
		/// Value of EGL_OPENVG_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENVG_API = 0x30A1;

		/// <summary>
		/// Value of EGL_OPENVG_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENVG_IMAGE = 0x3096;

		/// <summary>
		/// Value of EGL_PIXEL_ASPECT_RATIO symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int PIXEL_ASPECT_RATIO = 0x3092;

		/// <summary>
		/// Value of EGL_RENDERABLE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RENDERABLE_TYPE = 0x3040;

		/// <summary>
		/// Value of EGL_RENDER_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RENDER_BUFFER = 0x3086;

		/// <summary>
		/// Value of EGL_RGB_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RGB_BUFFER = 0x308E;

		/// <summary>
		/// Value of EGL_SINGLE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int SINGLE_BUFFER = 0x3085;

		/// <summary>
		/// Value of EGL_SWAP_BEHAVIOR symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int SWAP_BEHAVIOR = 0x3093;

		/// <summary>
		/// Value of EGL_UNKNOWN symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int UNKNOWN = -1;

		/// <summary>
		/// Value of EGL_VERTICAL_RESOLUTION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int VERTICAL_RESOLUTION = 0x3091;

		/// <summary>
		/// Set the current rendering API
		/// </summary>
		/// <param name="api">
		/// Specifies the client API to bind, one of EGL_OPENGL_API, EGL_OPENGL_ES_API, or EGL_OPENVG_API.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static IntPtr BindAPI(uint api)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglBindAPI != null, "peglBindAPI not implemented");
			retValue = Delegates.peglBindAPI(api);
			CallLog("eglBindAPI({0}) = {1}", api, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Query the current rendering API
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static uint QueryAPI()
		{
			uint retValue;

			Debug.Assert(Delegates.peglQueryAPI != null, "peglQueryAPI not implemented");
			retValue = Delegates.peglQueryAPI();
			CallLog("eglQueryAPI() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// create a new EGL pixel buffer surface bound to an OpenVG image
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buftype">
		/// Specifies the type of client API buffer to be bound. Must be EGL_OPENVG_IMAGE, corresponding to an OpenVG VGImage 
		/// buffer.
		/// </param>
		/// <param name="buffer">
		/// Specifies the OpenVG VGImage handle of the buffer to be bound.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the surface.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies pixel buffer surface attributes. May be NULL or empty (first attribute is EGL_NONE).
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static IntPtr CreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePbufferFromClientBuffer != null, "peglCreatePbufferFromClientBuffer not implemented");
					retValue = Delegates.peglCreatePbufferFromClientBuffer(dpy, buftype, buffer, config, p_attrib_list);
					CallLog("eglCreatePbufferFromClientBuffer({0}, {1}, {2}, {3}, {4}) = {5}", dpy, buftype, buffer, config, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Release EGL per-thread state
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static IntPtr ReleaseThread()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglReleaseThread != null, "peglReleaseThread not implemented");
			retValue = Delegates.peglReleaseThread();
			CallLog("eglReleaseThread() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Complete client API execution prior to subsequent native rendering calls
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static IntPtr WaitClient()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglWaitClient != null, "peglWaitClient not implemented");
			retValue = Delegates.peglWaitClient();
			CallLog("eglWaitClient() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
