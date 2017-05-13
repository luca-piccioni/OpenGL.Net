
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Egl
	{
		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a nonnegative integer that indicates the desired alpha mask buffer size, in 
		/// bits. The smallest alpha mask buffers of at least the specified size are preferred. The default value is zero. The alpha 
		/// mask buffer is used only by OpenGL and OpenGL ES client APIs.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns the number of bits in the alpha mask buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int ALPHA_MASK_SIZE = 0x303E;

		/// <summary>
		/// [EGL] Value of EGL_BUFFER_PRESERVED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int BUFFER_PRESERVED = 0x3094;

		/// <summary>
		/// [EGL] Value of EGL_BUFFER_DESTROYED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int BUFFER_DESTROYED = 0x3095;

		/// <summary>
		/// [EGL] Egl.QueryString: Returns a string describing which client rendering APIs are supported. The string contains a 
		/// space-separate list of API names. The list must include at least one of OpenGL, OpenGL_ES, or OpenVG. These strings 
		/// correspond respectively to values Egl.OPENGL_API, Egl.OPENGL_ES_API, and Egl.OPENVG_API of the Egl.BindAPI, api 
		/// argument.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CLIENT_APIS = 0x308D;

		/// <summary>
		/// [EGL] Value of EGL_COLORSPACE_sRGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLORSPACE_sRGB = 0x3089;

		/// <summary>
		/// [EGL] Value of EGL_COLORSPACE_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLORSPACE_LINEAR = 0x308A;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by one of Egl.RGB_BUFFER or Egl.LUMINANCE_BUFFER. Egl.RGB_BUFFER indicates an 
		/// RGB color buffer; in this case, attributes Egl.RED_SIZE, Egl.GREEN_SIZE and Egl.BLUE_SIZE must be non-zero, and 
		/// Egl.LUMINANCE_SIZE must be zero. Egl.LUMINANCE_BUFFER indicates a luminance color buffer. In this case Egl.RED_SIZE, 
		/// Egl.GREEN_SIZE, Egl.BLUE_SIZE must be zero, and Egl.LUMINANCE_SIZE must be non-zero. For both RGB and luminance color 
		/// buffers, Egl.ALPHA_SIZE may be zero or non-zero.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns the color buffer type. Possible types are Egl.RGB_BUFFER and Egl.LUMINANCE_BUFFER.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int COLOR_BUFFER_TYPE = 0x303F;

		/// <summary>
		/// [EGL] Egl.QueryContext: Returns the type of client API which the context supports (one of Egl.OPENGL_API, 
		/// Egl.OPENGL_ES_API, or Egl.OPENVG_API).
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int CONTEXT_CLIENT_TYPE = 0x3097;

		/// <summary>
		/// [EGL] Value of EGL_DISPLAY_SCALING symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int DISPLAY_SCALING = 10000;

		/// <summary>
		/// [EGL] Egl.QuerySurface: Returns the horizontal dot pitch of the display on which a window surface is visible. The value 
		/// returned is equal to the actual dot pitch, in pixels/meter, multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int HORIZONTAL_RESOLUTION = 0x3090;

		/// <summary>
		/// [EGL] Value of EGL_LUMINANCE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_BUFFER = 0x308F;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a nonnegative integer that indicates the desired size of the luminance 
		/// component of the color buffer, in bits. If this value is zero, color buffers with the smallest luminance component size 
		/// are preferred. Otherwise, color buffers with the largest luminance component of at least the specified size are 
		/// preferred. The default value is zero.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns the number of bits of luminance stored in the luminance buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int LUMINANCE_SIZE = 0x303D;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_ES_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const int OPENGL_ES_BIT = 0x0001;

		/// <summary>
		/// [EGL] Value of EGL_OPENVG_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const int OPENVG_BIT = 0x0002;

		/// <summary>
		/// [EGL] Value of EGL_OPENGL_ES_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENGL_ES_API = 0x30A0;

		/// <summary>
		/// [EGL] Value of EGL_OPENVG_API symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENVG_API = 0x30A1;

		/// <summary>
		/// [EGL] Value of EGL_OPENVG_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int OPENVG_IMAGE = 0x3096;

		/// <summary>
		/// [EGL] Egl.QuerySurface: Returns the aspect ratio of an individual pixel (the ratio of a pixel's width to its height). 
		/// The value returned is equal to the actual aspect ratio multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int PIXEL_ASPECT_RATIO = 0x3092;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a bitmask indicating which types of client API contexts the frame buffer 
		/// configuration must support creating with Egl.CreateContext). Mask bits are the same as for attribute Egl.CONFORMANT. The 
		/// default value is Egl.OPENGL_ES_BIT.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns a bitmask indicating the types of supported client API contexts.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RENDERABLE_TYPE = 0x3040;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreateWindowSurface: Specifies which buffer should be used for client API rendering to the window. If its 
		/// value is Egl.SINGLE_BUFFER, then client APIs should render directly into the visible window. If its value is 
		/// Egl.BACK_BUFFER, then client APIs should render into the back buffer. The default value of Egl.RENDER_BUFFER is 
		/// Egl.BACK_BUFFER. Client APIs may not be able to respect the requested rendering buffer. To determine the actual buffer 
		/// being rendered to by a context, call Egl.QueryContext.
		/// </para>
		/// <para>
		/// [EGL] Egl.QueryContext: Returns the buffer which client API rendering via the context will use. The value returned 
		/// depends on properties of both the context, and the surface to which the context is bound: If the context is bound to a 
		/// pixmap surface, then Egl.SINGLE_BUFFER will be returned. If the context is bound to a pbuffer surface, then 
		/// Egl.BACK_BUFFER will be returned. If the context is bound to a window surface, then either Egl.BACK_BUFFER or 
		/// Egl.SINGLE_BUFFER may be returned. The value returned depends on both the buffer requested by the setting of the 
		/// Egl.RENDER_BUFFER property of the surface (which may be queried by calling eglQuerySurface), and on the client API (not 
		/// all client APIs support single-buffer rendering to window surfaces). If the context is not bound to a surface, such as 
		/// an OpenGL ES context bound to a framebuffer object, then Egl.NONE will be returned.
		/// </para>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns the buffer which client API rendering is requested to use. For a window surface, this is 
		/// the same attribute value specified when the surface was created. For a pbuffer surface, it is always Egl.BACK_BUFFER. 
		/// For a pixmap surface, it is always Egl.SINGLE_BUFFER. To determine the actual buffer being rendered to by a context, 
		/// call Egl.QueryContext.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RENDER_BUFFER = 0x3086;

		/// <summary>
		/// [EGL] Value of EGL_RGB_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int RGB_BUFFER = 0x308E;

		/// <summary>
		/// [EGL] Value of EGL_SINGLE_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int SINGLE_BUFFER = 0x3085;

		/// <summary>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns the effect on the color buffer when posting a surface with Egl.SwapBuffers. Swap 
		/// behavior may be either Egl.BUFFER_PRESERVED or Egl.BUFFER_DESTROYED, as described for Egl.SurfaceAttrib.
		/// </para>
		/// <para>
		/// [EGL] Egl.SurfaceAttrib: Specifies the effect on the color buffer of posting a surface with Egl.SwapBuffers. A value of 
		/// Egl.BUFFER_PRESERVED indicates that color buffer contents are unaffected, while Egl.BUFFER_DESTROYED indicates that 
		/// color buffer contents may be destroyed or changed by the operation. The initial value of Egl.SWAP_BEHAVIOR is chosen by 
		/// the implementation.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int SWAP_BEHAVIOR = 0x3093;

		/// <summary>
		/// [EGL] Value of EGL_UNKNOWN symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int UNKNOWN = -1;

		/// <summary>
		/// [EGL] Egl.QuerySurface: Returns the vertical dot pitch of the display on which a window surface is visible. The value 
		/// returned is equal to the actual dot pitch, in pixels/meter, multiplied by the constant value Egl.DISPLAY_SCALING.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public const int VERTICAL_RESOLUTION = 0x3091;

		/// <summary>
		/// Set the current rendering API
		/// </summary>
		/// <param name="api">
		/// Specifies the client API to bind, one of Egl.OPENGL_API, Egl.OPENGL_ES_API, or Egl.OPENVG_API.
		/// </param>
		/// <exception cref="KhronosException">
		/// Egl.FALSE is returned on failure.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_PARAMETER is generated if <paramref name="api"/> is not one of the accepted tokens, or if the specified client 
		/// API is not supported by the EGL implementation.
		/// </exception>
		/// <seealso cref="Egl.CreateContext"/>
		/// <seealso cref="Egl.GetCurrentContext"/>
		/// <seealso cref="Egl.GetCurrentDisplay"/>
		/// <seealso cref="Egl.GetCurrentSurface"/>
		/// <seealso cref="Egl.MakeCurrent"/>
		/// <seealso cref="Egl.QueryAPI"/>
		/// <seealso cref="Egl.WaitClient"/>
		/// <seealso cref="Egl.WaitNative"/>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool BindAPI(uint api)
		{
			bool retValue;

			Debug.Assert(Delegates.peglBindAPI != null, "peglBindAPI not implemented");
			retValue = Delegates.peglBindAPI(api);
			LogCommand("eglBindAPI", retValue, api			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Query the current rendering API
		/// </summary>
		/// <exception cref="KhronosException">
		/// None.
		/// </exception>
		/// <seealso cref="Egl.BindAPI"/>
		/// <seealso cref="Egl.CreateContext"/>
		/// <seealso cref="Egl.GetCurrentContext"/>
		/// <seealso cref="Egl.GetCurrentDisplay"/>
		/// <seealso cref="Egl.GetCurrentSurface"/>
		/// <seealso cref="Egl.MakeCurrent"/>
		/// <seealso cref="Egl.WaitClient"/>
		/// <seealso cref="Egl.WaitNative"/>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static uint QueryAPI()
		{
			uint retValue;

			Debug.Assert(Delegates.peglQueryAPI != null, "peglQueryAPI not implemented");
			retValue = Delegates.peglQueryAPI();
			LogCommand("eglQueryAPI", retValue			);
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
		/// <exception cref="KhronosException">
		/// Egl.NO_SURFACE is returned if creation of the context fails.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_DISPLAY is generated if <paramref name="display"/> is not an EGL display connection.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.NOT_INITIALIZED is generated if <paramref name="display"/> has not been initialized.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_CONFIG is generated if <paramref name="config"/> is not an EGL frame buffer configuration.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_PARAMETER is generated if <paramref name="buftype"/> is not Egl.OPENVG_IMAGE, or if <paramref name="buffer"/> is 
		/// not a valid handle to a VGImage object in the currently bound OpenVG context.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ACCESS is generated if there is no current OpenVG context, or if <paramref name="buffer"/> is already bound to 
		/// another pixel buffer or in use by OpenVG as discussed in the Notes section above.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ALLOC is generated if there are not enough resources to allocate the new surface.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ATTRIBUTE is generated if <paramref name="attrib_list"/> contains an invalid pixel buffer attribute or if an 
		/// attribute value is not recognized or out of range.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ATTRIBUTE is generated if <paramref name="attrib_list"/> contains any of the attributes Egl.MIPMAP_TEXTURE, 
		/// Egl.TEXTURE_FORMAT, or Egl.TEXTURE_TARGET, and <paramref name="config"/> does not support OpenGL ES rendering (e.g. the 
		/// EGL version is 1.2 or later, and the Egl.RENDERABLE_TYPE attribute of <paramref name="config"/> does not include at 
		/// least one of Egl.OPENGL_ES_BIT or Egl.OPENGL_ES2_BIT).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if <paramref name="config"/> does not support rendering to pixel buffers (the 
		/// Egl.SURFACE_TYPE attribute does not contain Egl.PBUFFER_BIT).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the buffers contained in <paramref name="buffer"/> do not match the bit depths for those 
		/// buffers specified by <paramref name="config"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the Egl.TEXTURE_FORMAT attribute is not Egl.NO_TEXTURE, and Egl.WIDTH and/or Egl.HEIGHT 
		/// specify an invalid size (e.g., the texture size is not a power of 2, and the underlying OpenGL ES implementation does 
		/// not support non-power-of-two textures).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the Egl.TEXTURE_FORMAT attribute is Egl.NO_TEXTURE, and Egl.TEXTURE_TARGET is something 
		/// other than Egl.NO_TEXTURE; or, Egl.TEXTURE_FORMAT is something other than Egl.NO_TEXTURE, and Egl.TEXTURE_TARGET is 
		/// Egl.NO_TEXTURE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the implementation has additional constraints on which types of client API buffers may be 
		/// bound to pixel buffer surfaces. For example, it is possible that the OpenVG implementation might not support a VGImage 
		/// being bound to a pixel buffer which will be used as a mipmapped OpenGL ES texture (e.g. whose Egl.MIPMAP_TEXTURE 
		/// attribute is Egl.). Any such constraints should be documented by the implementation release notes.
		/// </exception>
		/// <seealso cref="Egl.DestroySurface"/>
		/// <seealso cref="Egl.ChooseConfig"/>
		/// <seealso cref="Egl.CreatePbufferSurface"/>
		/// <seealso cref="Egl.GetConfigs"/>
		/// <seealso cref="Egl.MakeCurrent"/>
		/// <seealso cref="Egl.QuerySurface"/>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static IntPtr CreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePbufferFromClientBuffer != null, "peglCreatePbufferFromClientBuffer not implemented");
					retValue = Delegates.peglCreatePbufferFromClientBuffer(dpy, buftype, buffer, config, p_attrib_list);
					LogCommand("eglCreatePbufferFromClientBuffer", retValue, dpy, buftype, buffer, config, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Release EGL per-thread state
		/// </summary>
		/// <exception cref="KhronosException">
		/// Egl.FALSE is returned on failure, Egl.TRUE otherwise. There are no defined conditions under which failure will occur. 
		/// Even if EGL is not initialized on any EGLDisplay, Egl.ReleaseThread should succeed.
		/// </exception>
		/// <exception cref="KhronosException">
		/// However, platform-dependent failures may be signaled through the value returned from Egl.GetError. Unless the 
		/// platform-dependent behavior is known, a failed call to Egl.ReleaseThread should be assumed to leave the current 
		/// rendering API, and the currently bound contexts for each supported client API, in an unknown state.
		/// </exception>
		/// <seealso cref="Egl.BindAPI"/>
		/// <seealso cref="Egl.GetError"/>
		/// <seealso cref="Egl.MakeCurrent"/>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool ReleaseThread()
		{
			bool retValue;

			Debug.Assert(Delegates.peglReleaseThread != null, "peglReleaseThread not implemented");
			retValue = Delegates.peglReleaseThread();
			LogCommand("eglReleaseThread", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Complete client API execution prior to subsequent native rendering calls
		/// </summary>
		/// <exception cref="KhronosException">
		/// Egl.FALSE is returned if Egl.WaitClient fails, Egl.TRUE otherwise.
		/// </exception>
		/// <exception cref="KhronosException">
		/// If there is no current context for the current rendering API, the function has no effect but still returns Egl.TRUE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_CURRENT_SURFACE is generated if the surface associated with the current context has a native window or pixmap, 
		/// and that window or pixmap is no longer valid.
		/// </exception>
		/// <seealso cref="Egl.glFinish"/>
		/// <seealso cref="Egl.glFlush"/>
		/// <seealso cref="Egl.WaitGL"/>
		/// <seealso cref="Egl.WaitNative"/>
		/// <seealso cref="Egl.vgFinish"/>
		[RequiredByFeature("EGL_VERSION_1_2")]
		public static bool WaitClient()
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitClient != null, "peglWaitClient not implemented");
			retValue = Delegates.peglWaitClient();
			LogCommand("eglWaitClient", retValue			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglBindAPI", ExactSpelling = true)]
			internal extern static bool eglBindAPI(uint api);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglQueryAPI", ExactSpelling = true)]
			internal extern static uint eglQueryAPI();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglCreatePbufferFromClientBuffer", ExactSpelling = true)]
			internal extern static unsafe IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglReleaseThread", ExactSpelling = true)]
			internal extern static bool eglReleaseThread();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "eglWaitClient", ExactSpelling = true)]
			internal extern static bool eglWaitClient();

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_VERSION_1_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglBindAPI(uint api);

			[RequiredByFeature("EGL_VERSION_1_2")]
			internal static eglBindAPI peglBindAPI;

			[RequiredByFeature("EGL_VERSION_1_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate uint eglQueryAPI();

			[RequiredByFeature("EGL_VERSION_1_2")]
			internal static eglQueryAPI peglQueryAPI;

			[RequiredByFeature("EGL_VERSION_1_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr eglCreatePbufferFromClientBuffer(IntPtr dpy, uint buftype, IntPtr buffer, IntPtr config, int* attrib_list);

			[RequiredByFeature("EGL_VERSION_1_2")]
			internal static eglCreatePbufferFromClientBuffer peglCreatePbufferFromClientBuffer;

			[RequiredByFeature("EGL_VERSION_1_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglReleaseThread();

			[RequiredByFeature("EGL_VERSION_1_2")]
			internal static eglReleaseThread peglReleaseThread;

			[RequiredByFeature("EGL_VERSION_1_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool eglWaitClient();

			[RequiredByFeature("EGL_VERSION_1_2")]
			internal static eglWaitClient peglWaitClient;

		}
	}

}
