
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

#pragma warning disable 1734

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
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired size of the alpha component of 
		/// the color buffer, in bits. If this value is zero, color buffers with the smallest alpha component size are preferred. 
		/// Otherwise, color buffers with the largest alpha component of at least the specified size are preferred. The default 
		/// value is zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits of alpha stored in the color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int ALPHA_SIZE = 0x3021;

		/// <summary>
		/// Egl.GetError: eGL cannot access a requested resource (for example a context is bound in another thread).
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ACCESS = 0x3002;

		/// <summary>
		/// Egl.GetError: eGL failed to allocate resources for the requested operation.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ALLOC = 0x3003;

		/// <summary>
		/// Egl.GetError: an unrecognized attribute or attribute value was passed in the attribute list.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ATTRIBUTE = 0x3004;

		/// <summary>
		/// Egl.GetError: an EGLConfig argument does not name a valid EGL frame buffer configuration.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CONFIG = 0x3005;

		/// <summary>
		/// Egl.GetError: an EGLContext argument does not name a valid EGL rendering context.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CONTEXT = 0x3006;

		/// <summary>
		/// Egl.GetError: the current surface of the calling thread is a window, pixel buffer or pixmap that is no longer valid.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CURRENT_SURFACE = 0x3007;

		/// <summary>
		/// Egl.GetError: an EGLDisplay argument does not name a valid EGL display connection.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_DISPLAY = 0x3008;

		/// <summary>
		/// Egl.GetError: arguments are inconsistent (for example, a valid context requires buffers not supplied by a valid 
		/// surface).
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_MATCH = 0x3009;

		/// <summary>
		/// Egl.GetError: a NativePixmapType argument does not refer to a valid native pixmap.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_NATIVE_PIXMAP = 0x300A;

		/// <summary>
		/// Egl.GetError: a NativeWindowType argument does not refer to a valid native window.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_NATIVE_WINDOW = 0x300B;

		/// <summary>
		/// Egl.GetError: one or more argument values are invalid.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_PARAMETER = 0x300C;

		/// <summary>
		/// Egl.GetError: an EGLSurface argument does not name a valid surface (window, pixel buffer or pixmap) configured for GL 
		/// rendering.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_SURFACE = 0x300D;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired size of the blue component of the 
		/// color buffer, in bits. If this value is zero, color buffers with the smallest blue component size are preferred. 
		/// Otherwise, color buffers with the largest blue component of at least the specified size are preferred. The default value 
		/// is zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits of blue stored in the color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BLUE_SIZE = 0x3022;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired color buffer size, in bits. The 
		/// smallest color buffers of at least the specified size are preferred. The default value is zero. The color buffer size is 
		/// the sum of Egl.RED_SIZE, Egl.GREEN_SIZE, Egl.BLUE_SIZE, and Egl.ALPHA_SIZE, and does not include any padding bits which 
		/// may be present in the pixel format. It is usually preferable to specify desired sizes for these color components 
		/// individually.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the depth of the color buffer. It is the sum of Egl.RED_SIZE, Egl.GREEN_SIZE, 
		/// Egl.BLUE_SIZE, and Egl.ALPHA_SIZE.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BUFFER_SIZE = 0x3020;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by Egl.DONT_CARE, Egl.NONE, Egl.SLOW_CONFIG, or Egl.NON_CONFORMANT_CONFIG. If 
		/// Egl.DONT_CARE is specified, then configs are not matched for this attribute. The default value is Egl.DONT_CARE. If 
		/// Egl.NONE is specified, then configs are matched for this attribute, but only configs with no caveats (neither 
		/// Egl.SLOW_CONFIG or Egl.NON_CONFORMANT_CONFIG) will be considered. If Egl.SLOW_CONFIG is specified, then only slow 
		/// configs configurations will be considered. The meaning of``slow'' is implementation-dependent, but typically indicates a 
		/// non-hardware-accelerated (software) implementation. If Egl.NON_CONFORMANT_CONFIG is specified, then only configs 
		/// supporting non-conformant OpenGL ES contexts will be considered. If the EGL version is 1.3 or later, caveat 
		/// Egl.NON_CONFORMANT_CONFIG is obsolete, since the same information can be specified via the Egl.CONFORMANT attribute on a 
		/// per-client-API basis, not just for OpenGL ES.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the caveats for the frame buffer configuration. Possible caveat values are Egl.NONE, 
		/// Egl.SLOW_CONFIG, and Egl.NON_CONFORMANT.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CONFIG_CAVEAT = 0x3027;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a valid integer ID that indicates the desired EGL frame buffer configuration. When 
		/// a Egl.CONFIG_ID is specified, all other attributes are ignored. The default value is Egl.DONT_CARE. The meaning of 
		/// config IDs is implementation-dependent. They are used only to uniquely identify different frame buffer configurations.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the ID of the frame buffer configuration.
		/// </para>
		/// <para>
		/// Egl.QueryContext: returns the ID of the EGL frame buffer configuration with respect to which the context was created.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns the ID of the EGL frame buffer configuration with respect to which the surface was created.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CONFIG_ID = 0x3028;

		/// <summary>
		/// Value of EGL_CORE_NATIVE_ENGINE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CORE_NATIVE_ENGINE = 0x305B;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired depth buffer size, in bits. The 
		/// smallest depth buffers of at least the specified size is preferred. If the desired size is zero, frame buffer 
		/// configurations with no depth buffer are preferred. The default value is zero. The depth buffer is used only by OpenGL 
		/// and OpenGL ES client APIs.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits in the depth buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DEPTH_SIZE = 0x3025;

		/// <summary>
		/// Value of EGL_DONT_CARE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DONT_CARE = -1;

		/// <summary>
		/// Value of EGL_DRAW symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DRAW = 0x3059;

		/// <summary>
		/// Egl.QueryString: returns a space separated list of supported extensions to EGL.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int EXTENSIONS = 0x3055;

		/// <summary>
		/// Value of EGL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int FALSE = 0;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired size of the green component of 
		/// the color buffer, in bits. If this value is zero, color buffers with the smallest green component size are preferred. 
		/// Otherwise, color buffers with the largest green component of at least the specified size are preferred. The default 
		/// value is zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits of green stored in the color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int GREEN_SIZE = 0x3023;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferSurface: specifies the required height of the pixel buffer surface. The default value is Egl..
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns the height of the surface in pixels.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int HEIGHT = 0x3056;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferSurface: requests the largest available pixel buffer surface when the allocation would otherwise fail. 
		/// Use Egl.QuerySurface to retrieve the dimensions of the allocated pixel buffer. The default value is Egl.FALSE.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns the same attribute value specified when the surface was created with Egl.CreatePbufferSurface. 
		/// For a window or pixmap surface, value is not modified.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int LARGEST_PBUFFER = 0x3058;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by an integer buffer level specification. This specification is honored exactly. 
		/// Buffer level zero corresponds to the default frame buffer of the display. Buffer level one is the first overlay frame 
		/// buffer, level two the second overlay frame buffer, and so on. Negative buffer levels correspond to underlay frame 
		/// buffers. The default value is zero. Most imlementations do not support overlay or underlay planes (buffer levels other 
		/// than zero).
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the frame buffer level. Level zero is the default frame buffer. Positive levels correspond 
		/// to frame buffers that overlay the default buffer and negative levels correspond to frame buffers that underlay the 
		/// default buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int LEVEL = 0x3029;

		/// <summary>
		/// Egl.GetConfigAttrib: returns the maximum height of a pixel buffer surface in pixels.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_HEIGHT = 0x302A;

		/// <summary>
		/// Egl.GetConfigAttrib: returns the maximum size of a pixel buffer surface in pixels.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_PIXELS = 0x302B;

		/// <summary>
		/// Egl.GetConfigAttrib: returns the maximum width of a pixel buffer surface in pixels.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_WIDTH = 0x302C;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by Egl.DONT_CARE, Egl.TRUE, or Egl.FALSE. If Egl.TRUE is specified, then only frame 
		/// buffer configurations that allow native rendering into the surface will be considered. The default value is 
		/// Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns Egl.TRUE if native rendering APIs can render into the surface, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_RENDERABLE = 0x302D;

		/// <summary>
		/// Egl.GetConfigAttrib: returns the ID of the associated native visual.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_VISUAL_ID = 0x302E;

		/// <summary>
		/// Egl.GetConfigAttrib: returns the type of the associated native visual.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_VISUAL_TYPE = 0x302F;

		/// <summary>
		/// Value of EGL_NONE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NONE = 0x3038;

		/// <summary>
		/// Value of EGL_NON_CONFORMANT_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NON_CONFORMANT_CONFIG = 0x3051;

		/// <summary>
		/// Egl.GetError: eGL is not initialized, or could not be initialized, for the specified EGL display connection.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NOT_INITIALIZED = 0x3001;

		/// <summary>
		/// Value of EGL_NO_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_CONTEXT = 0;

		/// <summary>
		/// Value of EGL_NO_DISPLAY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_DISPLAY = 0;

		/// <summary>
		/// Value of EGL_NO_SURFACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_SURFACE = 0;

		/// <summary>
		/// Value of EGL_PBUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int PBUFFER_BIT = 0x0001;

		/// <summary>
		/// Value of EGL_PIXMAP_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int PIXMAP_BIT = 0x0002;

		/// <summary>
		/// Value of EGL_READ symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int READ = 0x305A;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired size of the red component of the 
		/// color buffer, in bits. If this value is zero, color buffers with the smallest red component size are preferred. 
		/// Otherwise, color buffers with the largest red component of at least the specified size are preferred. The default value 
		/// is zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits of red stored in the color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int RED_SIZE = 0x3024;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by the minimum number of samples required in multisample buffers. Configurations with 
		/// the smallest number of samples that meet or exceed the specified minimum number are preferred. Note that it is possible 
		/// for color samples in the multisample buffer to have fewer bits than colors in the main color buffers. However, 
		/// multisampled colors maintain at least as much color resolution in aggregate as the main color buffers.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of samples per pixel.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SAMPLES = 0x3031;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by the minimum acceptable number of multisample buffers. Configurations with the 
		/// smallest number of multisample buffers that meet or exceed this minimum number are preferred. Currently operation with 
		/// more than one multisample buffer is undefined, so only values of zero or one will produce a match. The default value is 
		/// zero.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of multisample buffers.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SAMPLE_BUFFERS = 0x3032;

		/// <summary>
		/// Value of EGL_SLOW_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SLOW_CONFIG = 0x3050;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a nonnegative integer that indicates the desired stencil buffer size, in bits. The 
		/// smallest stencil buffers of at least the specified size are preferred. If the desired size is zero, frame buffer 
		/// configurations with no stencil buffer are preferred. The default value is zero. The stencil buffer is used only by 
		/// OpenGL and OpenGL ES client APIs.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the number of bits in the stencil buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int STENCIL_SIZE = 0x3026;

		/// <summary>
		/// Egl.GetError: the last function succeeded without error.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SUCCESS = 0x3000;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a bitmask indicating which EGL surface types and capabilities the frame buffer 
		/// configuration must support. Mask bits include: Egl.MULTISAMPLE_RESOLVE_BOX_BIT Config allows specifying box filtered 
		/// multisample resolve behavior with Egl.SurfaceAttrib. Egl.PBUFFER_BIT Config supports creating pixel buffer surfaces. 
		/// Egl.PIXMAP_BIT Config supports creating pixmap surfaces. Egl.SWAP_BEHAVIOR_PRESERVED_BIT Config allows setting swap 
		/// behavior for color buffers with Egl.SurfaceAttrib. Egl.VG_ALPHA_FORMAT_PRE_BIT Config allows specifying OpenVG rendering 
		/// with premultiplied alpha values at surface creation time (see Egl.CreatePbufferSurface, Egl.CreatePixmapSurface, and 
		/// Egl.CreateWindowSurface). Egl.VG_COLORSPACE_LINEAR_BIT Config allows specifying OpenVG rendering in a linear colorspace 
		/// at surface creation time (see Egl.CreatePbufferSurface, Egl.CreatePixmapSurface, and Egl.CreateWindowSurface). 
		/// Egl.WINDOW_BIT Config supports creating window surfaces. For example, if the bitmask is set to Egl.WINDOW_BIT | 
		/// Egl.PIXMAP_BIT, only frame buffer configurations that support both windows and pixmaps will be considered. The default 
		/// value is Egl.WINDOW_BIT.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns a bitmask indicating the types of supported EGL surfaces.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SURFACE_TYPE = 0x3033;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by an integer value indicating the transparent blue value. The value must be between 
		/// zero and the maximum color buffer value for blue. Only frame buffer configurations that use the specified transparent 
		/// blue value will be considered. The default value is Egl.DONT_CARE. This attribute is ignored unless Egl.TRANSPARENT_TYPE 
		/// is included in attrib_list and specified as Egl.TRANSPARENT_RGB.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the transparent blue value.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_BLUE_VALUE = 0x3035;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by an integer value indicating the transparent green value. The value must be between 
		/// zero and the maximum color buffer value for green. Only frame buffer configurations that use the specified transparent 
		/// green value will be considered. The default value is Egl.DONT_CARE. This attribute is ignored unless 
		/// Egl.TRANSPARENT_TYPE is included in attrib_list and specified as Egl.TRANSPARENT_RGB.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the transparent green value.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_GREEN_VALUE = 0x3036;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by an integer value indicating the transparent red value. The value must be between 
		/// zero and the maximum color buffer value for red. Only frame buffer configurations that use the specified transparent red 
		/// value will be considered. The default value is Egl.DONT_CARE. This attribute is ignored unless Egl.TRANSPARENT_TYPE is 
		/// included in attrib_list and specified as Egl.TRANSPARENT_RGB.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the transparent red value.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_RED_VALUE = 0x3037;

		/// <summary>
		/// Value of EGL_TRANSPARENT_RGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_RGB = 0x3052;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by one of Egl.NONE or Egl.TRANSPARENT_RGB. If Egl.NONE is specified, then only opaque 
		/// frame buffer configurations will be considered. If Egl.TRANSPARENT_RGB is specified, then only transparent frame buffer 
		/// configurations will be considered. The default value is Egl.NONE. Most implementations support only opaque frame buffer 
		/// configurations.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the type of supported transparency. Possible transparency values are: Egl.NONE, and 
		/// Egl.TRANSPARENT_RGB.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_TYPE = 0x3034;

		/// <summary>
		/// Value of EGL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRUE = 1;

		/// <summary>
		/// Egl.QueryString: returns the company responsible for this EGL implementation. This name does not change from release to 
		/// release.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int VENDOR = 0x3053;

		/// <summary>
		/// Egl.QueryString: returns a version or release number. The Egl.VERSION string is laid out as 
		/// follows:major_version.minor_version space vendor_specific_info
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int VERSION = 0x3054;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferSurface: specifies the required width of the pixel buffer surface. The default value is Egl..
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns the width of the surface in pixels.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int WIDTH = 0x3057;

		/// <summary>
		/// Value of EGL_WINDOW_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		[Log(BitmaskName = "EGLSurfaceTypeMask")]
		public const int WINDOW_BIT = 0x0004;

		/// <summary>
		/// return a list of EGL frame buffer configurations that match specified attributes
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies attributes required to match by configs.
		/// </param>
		/// <param name="configs">
		/// Returns an array of frame buffer configurations.
		/// </param>
		/// <param name="config_size">
		/// Specifies the size of the array of frame buffer configurations.
		/// </param>
		/// <param name="num_config">
		/// Returns the number of frame buffer configurations returned.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool ChooseConfig(IntPtr dpy, int[] attrib_list, IntPtr[] configs, int config_size, int[] num_config)
		{
			bool retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				fixed (IntPtr* p_configs = configs)
				fixed (int* p_num_config = num_config)
				{
					Debug.Assert(Delegates.peglChooseConfig != null, "peglChooseConfig not implemented");
					retValue = Delegates.peglChooseConfig(dpy, p_attrib_list, p_configs, config_size, p_num_config);
					LogFunction("eglChooseConfig(0x{0}, {1}, {2}, {3}, {4}) = {5}", dpy.ToString("X8"), LogValue(attrib_list), LogValue(configs), config_size, LogValue(num_config), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// copy EGL surface color buffer to a native pixmap
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface whose color buffer is to be copied.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool CopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target)
		{
			bool retValue;

			Debug.Assert(Delegates.peglCopyBuffers != null, "peglCopyBuffers not implemented");
			retValue = Delegates.peglCopyBuffers(dpy, surface, target);
			LogFunction("eglCopyBuffers(0x{0}, 0x{1}, 0x{2}) = {3}", dpy.ToString("X8"), surface.ToString("X8"), target.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a new EGL rendering context
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the rendering context.
		/// </param>
		/// <param name="share_context">
		/// Specifies another EGL rendering context with which to share data, as defined by the client API corresponding to the 
		/// contexts. Data is also shared with all other contexts with which <paramref name="share_context"/> shares data. 
		/// Egl.NO_CONTEXT indicates that no sharing is to take place.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies attributes and attribute values for the context being created. Only the attribute Egl.CONTEXT_CLIENT_VERSION 
		/// may be specified.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateContext != null, "peglCreateContext not implemented");
					retValue = Delegates.peglCreateContext(dpy, config, share_context, p_attrib_list);
					LogFunction("eglCreateContext(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), share_context.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a new EGL pixel buffer surface
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the surface.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies pixel buffer surface attributes. May be Egl. or empty (first attribute is Egl.NONE).
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreatePbufferSurface(IntPtr dpy, IntPtr config, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePbufferSurface != null, "peglCreatePbufferSurface not implemented");
					retValue = Delegates.peglCreatePbufferSurface(dpy, config, p_attrib_list);
					LogFunction("eglCreatePbufferSurface(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), config.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a new EGL pixmap surface
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the surface.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies pixmap surface attributes. May be Egl. or empty (first attribute is Egl.NONE).
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePixmapSurface != null, "peglCreatePixmapSurface not implemented");
					retValue = Delegates.peglCreatePixmapSurface(dpy, config, pixmap, p_attrib_list);
					LogFunction("eglCreatePixmapSurface(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), pixmap.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// create a new EGL window surface
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration that defines the frame buffer resource available to the surface.
		/// </param>
		/// <param name="win">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies window surface attributes. May be Egl. or empty (first attribute is Egl.NONE).
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateWindowSurface != null, "peglCreateWindowSurface not implemented");
					retValue = Delegates.peglCreateWindowSurface(dpy, config, win, p_attrib_list);
					LogFunction("eglCreateWindowSurface(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), win.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// destroy an EGL rendering context
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool DestroyContext(IntPtr dpy, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroyContext != null, "peglDestroyContext not implemented");
			retValue = Delegates.peglDestroyContext(dpy, ctx);
			LogFunction("eglDestroyContext(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), ctx.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// destroy an EGL surface
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface to be destroyed.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool DestroySurface(IntPtr dpy, IntPtr surface)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroySurface != null, "peglDestroySurface not implemented");
			retValue = Delegates.peglDestroySurface(dpy, surface);
			LogFunction("eglDestroySurface(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), surface.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return information about an EGL frame buffer configuration
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// Specifies the EGL frame buffer configuration to be queried.
		/// </param>
		/// <param name="attribute">
		/// Specifies the EGL rendering context attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool GetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, [Out] int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetConfigAttrib != null, "peglGetConfigAttrib not implemented");
					retValue = Delegates.peglGetConfigAttrib(dpy, config, attribute, p_value);
					LogFunction("eglGetConfigAttrib(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return a list of all EGL frame buffer configurations for a display
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="configs">
		/// Returns a list of configs.
		/// </param>
		/// <param name="config_size">
		/// Specifies the size of the list of configs.
		/// </param>
		/// <param name="num_config">
		/// Returns the number of configs returned.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool GetConfigs(IntPtr dpy, [Out] IntPtr[] configs, int config_size, [Out] int[] num_config)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_configs = configs)
				fixed (int* p_num_config = num_config)
				{
					Debug.Assert(Delegates.peglGetConfigs != null, "peglGetConfigs not implemented");
					retValue = Delegates.peglGetConfigs(dpy, p_configs, config_size, p_num_config);
					LogFunction("eglGetConfigs(0x{0}, {1}, {2}, {3}) = {4}", dpy.ToString("X8"), LogValue(configs), config_size, LogValue(num_config), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return the display for the current EGL rendering context
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetCurrentDisplay()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentDisplay != null, "peglGetCurrentDisplay not implemented");
			retValue = Delegates.peglGetCurrentDisplay();
			LogFunction("eglGetCurrentDisplay() = {0}", retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return the read or draw surface for the current EGL rendering context
		/// </summary>
		/// <param name="readdraw">
		/// Specifies whether the EGL read or draw surface is to be returned.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetCurrentSurface(int readdraw)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentSurface != null, "peglGetCurrentSurface not implemented");
			retValue = Delegates.peglGetCurrentSurface(readdraw);
			LogFunction("eglGetCurrentSurface({0}) = {1}", readdraw, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return an EGL display connection
		/// </summary>
		/// <param name="display_id">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetDisplay(IntPtr display_id)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetDisplay != null, "peglGetDisplay not implemented");
			retValue = Delegates.peglGetDisplay(display_id);
			LogFunction("eglGetDisplay(0x{0}) = {1}", display_id.ToString("X8"), retValue.ToString("X8"));

			return (retValue);
		}

		/// <summary>
		/// return error information
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static int GetError()
		{
			int retValue;

			Debug.Assert(Delegates.peglGetError != null, "peglGetError not implemented");
			retValue = Delegates.peglGetError();
			LogFunction("eglGetError() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// return a GL or an EGL extension function
		/// </summary>
		/// <param name="procname">
		/// Specifies the name of the function to return.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetProcAddress(string procname)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetProcAddress != null, "peglGetProcAddress not implemented");
			retValue = Delegates.peglGetProcAddress(procname);
			LogFunction("eglGetProcAddress({0}) = {1}", procname, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// initialize an EGL display connection
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="major">
		/// Returns the major version number of the EGL implementation. May be Egl..
		/// </param>
		/// <param name="minor">
		/// Returns the minor version number of the EGL implementation. May be Egl..
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool Initialize(IntPtr dpy, int[] major, int[] minor)
		{
			bool retValue;

			unsafe {
				fixed (int* p_major = major)
				fixed (int* p_minor = minor)
				{
					Debug.Assert(Delegates.peglInitialize != null, "peglInitialize not implemented");
					retValue = Delegates.peglInitialize(dpy, p_major, p_minor);
					LogFunction("eglInitialize(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), LogValue(major), LogValue(minor), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// attach an EGL rendering context to EGL surfaces
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="draw">
		/// Specifies the EGL draw surface.
		/// </param>
		/// <param name="read">
		/// Specifies the EGL read surface.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool MakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.peglMakeCurrent != null, "peglMakeCurrent not implemented");
			retValue = Delegates.peglMakeCurrent(dpy, draw, read, ctx);
			LogFunction("eglMakeCurrent(0x{0}, 0x{1}, 0x{2}, 0x{3}) = {4}", dpy.ToString("X8"), draw.ToString("X8"), read.ToString("X8"), ctx.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return EGL rendering context information
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// Specifies the EGL rendering context attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool QueryContext(IntPtr dpy, IntPtr ctx, int attribute, int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryContext != null, "peglQueryContext not implemented");
					retValue = Delegates.peglQueryContext(dpy, ctx, attribute, p_value);
					LogFunction("eglQueryContext(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), ctx.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// return a string describing an EGL display connection
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// Specifies a symbolic constant, one of Egl.CLIENT_APIS, Egl.VENDOR, Egl.VERSION, or Egl.EXTENSIONS.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static string QueryString(IntPtr dpy, int name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglQueryString != null, "peglQueryString not implemented");
			retValue = Delegates.peglQueryString(dpy, name);
			LogFunction("eglQueryString(0x{0}, {1}) = {2}", dpy.ToString("X8"), name, Marshal.PtrToStringAnsi(retValue));
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// return EGL surface information
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface to query.
		/// </param>
		/// <param name="attribute">
		/// Specifies the EGL surface attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool QuerySurface(IntPtr dpy, IntPtr surface, int attribute, int[] value)
		{
			bool retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQuerySurface != null, "peglQuerySurface not implemented");
					retValue = Delegates.peglQuerySurface(dpy, surface, attribute, p_value);
					LogFunction("eglQuerySurface(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), surface.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// post EGL surface color buffer to a native window
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL drawing surface whose buffers are to be swapped.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool SwapBuffers(IntPtr dpy, IntPtr surface)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSwapBuffers != null, "peglSwapBuffers not implemented");
			retValue = Delegates.peglSwapBuffers(dpy, surface);
			LogFunction("eglSwapBuffers(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), surface.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// terminate an EGL display connection
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool Terminate(IntPtr dpy)
		{
			bool retValue;

			Debug.Assert(Delegates.peglTerminate != null, "peglTerminate not implemented");
			retValue = Delegates.peglTerminate(dpy);
			LogFunction("eglTerminate(0x{0}) = {1}", dpy.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Complete GL execution prior to subsequent native rendering calls
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool WaitGL()
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitGL != null, "peglWaitGL not implemented");
			retValue = Delegates.peglWaitGL();
			LogFunction("eglWaitGL() = {0}", retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// complete native execution prior to subsequent GL rendering calls
		/// </summary>
		/// <param name="engine">
		/// Specifies a particular marking engine to be waited on. Must be Egl.CORE_NATIVE_ENGINE.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static bool WaitNative(int engine)
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitNative != null, "peglWaitNative not implemented");
			retValue = Delegates.peglWaitNative(engine);
			LogFunction("eglWaitNative({0}) = {1}", engine, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
