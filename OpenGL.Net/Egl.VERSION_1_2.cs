
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
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired alpha mask buffer size, in bits. 
		/// The smallest alpha mask buffers of at least the specified size are preferred. The default value is zero. The alpha mask 
		/// buffer is used only by OpenGL and OpenGL ES client APIs.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits in the alpha mask buffer.
		/// </para>
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
		/// Egl.QueryString: returns a string describing which client rendering APIs are supported. The string contains a 
		/// space-separate list of API names. The list must include at least one of OpenGL, OpenGL_ES, or OpenVG. These strings 
		/// correspond respectively to values Egl.OPENGL_API, Egl.OPENGL_ES_API, and Egl.OPENVG_API of the Egl.BindAPI, api 
		/// argument.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CLIENT_APIS = 0x308D;

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
		/// <para>
		/// Egl.ChooseConfig: must be followed by one of Egl.RGB_BUFFER or Egl.LUMINANCE_BUFFER. Egl.RGB_BUFFER indicates an RGB 
		/// color buffer; in this case, attributes Egl.RED_SIZE, Egl.GREEN_SIZE and Egl.BLUE_SIZE must be non-zero, and 
		/// Egl.LUMINANCE_SIZE must be zero. Egl.LUMINANCE_BUFFER indicates a luminance color buffer. In this case Egl.RED_SIZE, 
		/// Egl.GREEN_SIZE, Egl.BLUE_SIZE must be zero, and Egl.LUMINANCE_SIZE must be non-zero. For both RGB and luminance color 
		/// buffers, Egl.ALPHA_SIZE may be zero or non-zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the color buffer type. Possible types are Egl.RGB_BUFFER and Egl.LUMINANCE_BUFFER.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLOR_BUFFER_TYPE = 0x303F;

		/// <summary>
		/// Egl.QueryContext: returns the type of client API which the context supports (one of Egl.OPENGL_API, Egl.OPENGL_ES_API, 
		/// or Egl.OPENVG_API).
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CONTEXT_CLIENT_TYPE = 0x3097;

		/// <summary>
		/// Value of EGL_DISPLAY_SCALING symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int DISPLAY_SCALING = 10000;

		/// <summary>
		/// Egl.QuerySurface: returns the horizontal dot pitch of the display on which a window surface is visible. The value 
		/// returned is equal to the actual dot pitch, in pixels/meter, multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int HORIZONTAL_RESOLUTION = 0x3090;

		/// <summary>
		/// Value of EGL_LUMINANCE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_BUFFER = 0x308F;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired size of the luminance component 
		/// of the color buffer, in bits. If this value is zero, color buffers with the smallest luminance component size are 
		/// preferred. Otherwise, color buffers with the largest luminance component of at least the specified size are preferred. 
		/// The default value is zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits of luminance stored in the luminance buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_SIZE = 0x303D;

		/// <summary>
		/// Value of EGL_OPENGL_ES_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const int OPENGL_ES_BIT = 0x0001;

		/// <summary>
		/// Value of EGL_OPENVG_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
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
		/// Egl.QuerySurface: returns the aspect ratio of an individual pixel (the ratio of a pixel's width to its height). The 
		/// value returned is equal to the actual aspect ratio multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int PIXEL_ASPECT_RATIO = 0x3092;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a bitmask indicating which types of client API contexts the frame buffer 
		/// configuration must support creating with Egl.CreateContext). Mask bits are the same as for attribute Egl.CONFORMANT. The 
		/// default value is Egl.OPENGL_ES_BIT.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns a bitmask indicating the types of supported client API contexts.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RENDERABLE_TYPE = 0x3040;

		/// <summary>
		/// <para>
		/// Egl.CreateWindowSurface: specifies which buffer should be used for client API rendering to the window. If its value is 
		/// Egl.SINGLE_BUFFER, then client APIs should render directly into the visible window. If its value is Egl.BACK_BUFFER, 
		/// then client APIs should render into the back buffer. The default value of Egl.RENDER_BUFFER is Egl.BACK_BUFFER. Client 
		/// APIs may not be able to respect the requested rendering buffer. To determine the actual buffer being rendered to by a 
		/// context, call Egl.QueryContext.
		/// </para>
		/// <para>
		/// Egl.QueryContext: returns the buffer which client API rendering via the context will use. The value returned depends on 
		/// properties of both the context, and the surface to which the context is bound: If the context is bound to a pixmap 
		/// surface, then Egl.SINGLE_BUFFER will be returned. If the context is bound to a pbuffer surface, then Egl.BACK_BUFFER 
		/// will be returned. If the context is bound to a window surface, then either Egl.BACK_BUFFER or Egl.SINGLE_BUFFER may be 
		/// returned. The value returned depends on both the buffer requested by the setting of the Egl.RENDER_BUFFER property of 
		/// the surface (which may be queried by calling eglQuerySurface), and on the client API (not all client APIs support 
		/// single-buffer rendering to window surfaces). If the context is not bound to a surface, such as an OpenGL ES context 
		/// bound to a framebuffer object, then Egl.NONE will be returned.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns the buffer which client API rendering is requested to use. For a window surface, this is the 
		/// same attribute value specified when the surface was created. For a pbuffer surface, it is always Egl.BACK_BUFFER. For a 
		/// pixmap surface, it is always Egl.SINGLE_BUFFER. To determine the actual buffer being rendered to by a context, call 
		/// Egl.QueryContext.
		/// </para>
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
		/// <para>
		/// Egl.QuerySurface: returns the effect on the color buffer when posting a surface with Egl.SwapBuffers. Swap behavior may 
		/// be either Egl.BUFFER_PRESERVED or Egl.BUFFER_DESTROYED, as described for Egl.SurfaceAttrib.
		/// </para>
		/// <para>
		/// Egl.SurfaceAttrib: specifies the effect on the color buffer of posting a surface with Egl.SwapBuffers. A value of 
		/// Egl.BUFFER_PRESERVED indicates that color buffer contents are unaffected, while Egl.BUFFER_DESTROYED indicates that 
		/// color buffer contents may be destroyed or changed by the operation. The initial value of Egl.SWAP_BEHAVIOR is chosen by 
		/// the implementation.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int SWAP_BEHAVIOR = 0x3093;

		/// <summary>
		/// Value of EGL_UNKNOWN symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int UNKNOWN = -1;

		/// <summary>
		/// Egl.QuerySurface: returns the vertical dot pitch of the display on which a window surface is visible. The value returned 
		/// is equal to the actual dot pitch, in pixels/meter, multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int VERTICAL_RESOLUTION = 0x3091;

		/// <summary>
		/// Set the current rendering API
		/// </summary>
		/// <param name="api">
		/// Specifies the client API to bind, one of Egl.OPENGL_API, Egl.OPENGL_ES_API, or Egl.OPENVG_API.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool BindAPI(uint api)
		{
			bool retValue;

			Debug.Assert(Delegates.peglBindAPI != null, "peglBindAPI not implemented");
			retValue = Delegates.peglBindAPI(api);
			LogFunction("eglBindAPI({0}) = {1}", api, retValue);
			DebugCheckErrors(retValue);

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
			LogFunction("eglQueryAPI() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a new EGL pixel buffer surface bound to an OpenVG image
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="buftype">
		/// Specifies the type of client API buffer to be bound. Must be Egl.OPENVG_IMAGE, corresponding to an OpenVG VGImage 
		/// buffer.
		/// </param>
		/// <param name="buffer">
		/// Specifies the OpenVG VGImage handle of the buffer to be bound.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the surface.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies pixel buffer surface attributes. May be Egl. or empty (first attribute is Egl.NONE).
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
					LogFunction("eglCreatePbufferFromClientBuffer(0x{0}, {1}, 0x{2}, 0x{3}, {4}) = {5}", dpy.ToString("X8"), buftype, buffer.ToString("X8"), config.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Release EGL per-thread state
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool ReleaseThread()
		{
			bool retValue;

			Debug.Assert(Delegates.peglReleaseThread != null, "peglReleaseThread not implemented");
			retValue = Delegates.peglReleaseThread();
			LogFunction("eglReleaseThread() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Complete client API execution prior to subsequent native rendering calls
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool WaitClient()
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitClient != null, "peglWaitClient not implemented");
			retValue = Delegates.peglWaitClient();
			LogFunction("eglWaitClient() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
