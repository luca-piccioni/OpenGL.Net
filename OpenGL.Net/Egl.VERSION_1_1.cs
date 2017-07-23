
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
		/// [EGL] Value of EGL_BACK_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BACK_BUFFER = 0x3084;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by Egl.DONT_CARE, Egl.TRUE, or Egl.FALSE. If Egl.TRUE is specified, then only 
		/// frame buffer configurations that support binding of color buffers to an OpenGL ES RGB texture will be considered. 
		/// Currently only frame buffer configurations that support pbuffers allow this. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns Egl.TRUE if color buffers can be bound to an RGB texture, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGB = 0x3039;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by one of Egl.DONT_CARE, Egl.TRUE, or Egl.FALSE. If Egl.TRUE is specified, then 
		/// only frame buffer configurations that support binding of color buffers to an OpenGL ES RGBA texture will be considered. 
		/// Currently only frame buffer configurations that support pbuffers allow this. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns Egl.TRUE if color buffers can be bound to an RGBA texture, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGBA = 0x303A;

		/// <summary>
		/// [EGL] Egl.GetError: A power management event has occurred. The application must destroy all contexts and reinitialise 
		/// OpenGL ES state and objects to continue rendering.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int CONTEXT_LOST = 0x300E;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a integer that indicates the minimum value that can be passed to 
		/// eglSwapInterval. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns the minimum value that can be passed to eglSwapInterval.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIN_SWAP_INTERVAL = 0x303B;

		/// <summary>
		/// <para>
		/// [EGL] Egl.ChooseConfig: Must be followed by a integer that indicates the maximum value that can be passed to 
		/// Egl.SwapInterval. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// [EGL] Egl.GetConfigAttrib: Returns the maximum value that can be passed to eglSwapInterval.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MAX_SWAP_INTERVAL = 0x303C;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreatePbufferFromClientBuffer: Specifies whether storage for mipmaps should be allocated. Space for mipmaps 
		/// will be set aside if the attribute value is Egl.TRUE and Egl.TEXTURE_FORMAT is not Egl.NO_TEXTURE. The default value is 
		/// Egl.FALSE.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreatePbufferSurface: Specifies whether storage for mipmaps should be allocated. Space for mipmaps will be set 
		/// aside if the attribute value is Egl.TRUE and Egl.TEXTURE_FORMAT is not Egl.NO_TEXTURE. The default value is Egl.FALSE.
		/// </para>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns Egl.TRUE if texture has mipmaps, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIPMAP_TEXTURE = 0x3082;

		/// <summary>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns which level of the mipmap to render to, if texture has mipmaps.
		/// </para>
		/// <para>
		/// [EGL] Egl.SurfaceAttrib: For mipmap textures, the Egl.MIPMAP_LEVEL attribute indicates which level of the mipmap should 
		/// be rendered. If the value of this attribute is outside the range of supported mipmap levels, the closest valid mipmap 
		/// level is selected for rendering. The default value is Egl..
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIPMAP_LEVEL = 0x3083;

		/// <summary>
		/// [EGL] Value of EGL_NO_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int NO_TEXTURE = 0x305C;

		/// <summary>
		/// [EGL] Value of EGL_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_2D = 0x305F;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreatePbufferFromClientBuffer: Specifies the format of the texture that will be created when a pbuffer is 
		/// bound to a texture map. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and Egl.TEXTURE_RGBA. The default value is 
		/// Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreatePbufferSurface: Specifies the format of the texture that will be created when a pbuffer is bound to a 
		/// texture map. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and Egl.TEXTURE_RGBA. The default value is 
		/// Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns format of texture. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and 
		/// Egl.TEXTURE_RGBA.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_FORMAT = 0x3080;

		/// <summary>
		/// [EGL] Value of EGL_TEXTURE_RGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_RGB = 0x305D;

		/// <summary>
		/// [EGL] Value of EGL_TEXTURE_RGBA symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_RGBA = 0x305E;

		/// <summary>
		/// <para>
		/// [EGL] Egl.CreatePbufferFromClientBuffer: Specifies the target for the texture that will be created when the pbuffer is 
		/// created with a texture format of Egl.TEXTURE_RGB or Egl.TEXTURE_RGBA. Possible values are Egl.NO_TEXTURE, or 
		/// Egl.TEXTURE_2D. The default value is Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// [EGL] Egl.CreatePbufferSurface: Specifies the target for the texture that will be created when the pbuffer is created 
		/// with a texture format of Egl.TEXTURE_RGB or Egl.TEXTURE_RGBA. Possible values are Egl.NO_TEXTURE, or Egl.TEXTURE_2D. The 
		/// default value is Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// [EGL] Egl.QuerySurface: Returns type of texture. Possible values are Egl.NO_TEXTURE, or Egl.TEXTURE_2D.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_TARGET = 0x3081;

		/// <summary>
		/// [EGL] Defines a two-dimensional texture image
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface.
		/// </param>
		/// <param name="buffer">
		/// Specifies the texture image data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ACCESS is generated if <paramref name="buffer"/> is already bound to a texture.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the surface attribute Egl.TEXTURE_FORMAT is set to Egl.NO_TEXTURE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if <paramref name="buffer"/> is not a valid buffer (currently only Egl.BACK_BUFFER may be 
		/// specified).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_SURFACE is generated if <paramref name="surface"/> is not an EGL surface, or is not a pbuffer surface supporting 
		/// texture binding.
		/// </exception>
		/// <seealso cref="Egl.ReleaseTexImage"/>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool BindTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.peglBindTexImage != null, "peglBindTexImage not implemented");
			retValue = Delegates.peglBindTexImage(dpy, surface, buffer);
			LogCommand("eglBindTexImage", retValue, dpy, surface, buffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] Releases a color buffer that is being used as a texture
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface.
		/// </param>
		/// <param name="buffer">
		/// Specifies the texture image data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if the surface attribute Egl.TEXTURE_FORMAT is set to Egl.NO_TEXTURE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if <paramref name="buffer"/> is not a valid buffer (currently only Egl.BACK_BUFFER may be 
		/// specified).
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_SURFACE is generated if <paramref name="surface"/> is not an EGL surface, or is not a bound pbuffer surface.
		/// </exception>
		/// <seealso cref="Egl.BindTexImage"/>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool ReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.peglReleaseTexImage != null, "peglReleaseTexImage not implemented");
			retValue = Delegates.peglReleaseTexImage(dpy, surface, buffer);
			LogCommand("eglReleaseTexImage", retValue, dpy, surface, buffer			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] set an EGL surface attribute
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// Specifies the EGL surface.
		/// </param>
		/// <param name="attribute">
		/// Specifies the EGL surface attribute to set.
		/// </param>
		/// <param name="value">
		/// Specifies the attributes required value.
		/// </param>
		/// <exception cref="KhronosException">
		/// Egl.FALSE is returned on failure, Egl.TRUE otherwise.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_DISPLAY is generated if <paramref name="display"/> is not an EGL display connection.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if <paramref name="attribute"/> is Egl.MULTISAMPLE_RESOLVE, <paramref name="value"/> is 
		/// Egl.MULTISAMPLE_RESOLVE_BOX, and the Egl.SURFACE_TYPE attribute of the EGLConfig used to create <paramref 
		/// name="surface"/> does not contain Egl.MULTISAMPLE_RESOLVE_BOX_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_MATCH is generated if <paramref name="attribute"/> is Egl.SWAP_BEHAVIOR, <paramref name="value"/> is 
		/// Egl.BUFFER_PRESERVED, and the Egl.SURFACE_TYPE attribute of the EGLConfig used to create <paramref name="surface"/> does 
		/// not contain Egl.SWAP_BEHAVIOR_PRESERVED_BIT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.NOT_INITIALIZED is generated if <paramref name="display"/> has not been initialized.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_SURFACE is generated if <paramref name="surface"/> is not an EGL surface.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_ATTRIBUTE is generated if <paramref name="attribute"/> is not a valid surface attribute.
		/// </exception>
		/// <seealso cref="Egl.CreatePbufferSurface"/>
		/// <seealso cref="Egl.CreatePixmapSurface"/>
		/// <seealso cref="Egl.CreateWindowSurface"/>
		/// <seealso cref="Egl.QuerySurface"/>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool SurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSurfaceAttrib != null, "peglSurfaceAttrib not implemented");
			retValue = Delegates.peglSurfaceAttrib(dpy, surface, attribute, value);
			LogCommand("eglSurfaceAttrib", retValue, dpy, surface, attribute, value			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [EGL] specifies the minimum number of video frame periods per buffer swap for the window associated with the current 
		/// context.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="interval">
		/// Specifies the minimum number of video frames that are displayed before a buffer swap will occur.
		/// </param>
		/// <exception cref="KhronosException">
		/// Egl.FALSE is returned on failure, Egl.TRUE otherwise.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_CONTEXT is generated if there is no current context on the calling thread.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Egl.BAD_SURFACE is generated if there is no surface bound to the current context.
		/// </exception>
		/// <seealso cref="Egl.SwapBuffers"/>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool SwapInterval(IntPtr dpy, int interval)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSwapInterval != null, "peglSwapInterval not implemented");
			retValue = Delegates.peglSwapInterval(dpy, interval);
			LogCommand("eglSwapInterval", retValue, dpy, interval			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglBindTexImage", ExactSpelling = true)]
			internal extern static unsafe bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglReleaseTexImage", ExactSpelling = true)]
			internal extern static unsafe bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglSurfaceAttrib", ExactSpelling = true)]
			internal extern static unsafe bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "eglSwapInterval", ExactSpelling = true)]
			internal extern static unsafe bool eglSwapInterval(IntPtr dpy, int interval);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("EGL_VERSION_1_1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglBindTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[RequiredByFeature("EGL_VERSION_1_1")]
			internal static eglBindTexImage peglBindTexImage;

			[RequiredByFeature("EGL_VERSION_1_1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer);

			[RequiredByFeature("EGL_VERSION_1_1")]
			internal static eglReleaseTexImage peglReleaseTexImage;

			[RequiredByFeature("EGL_VERSION_1_1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value);

			[RequiredByFeature("EGL_VERSION_1_1")]
			internal static eglSurfaceAttrib peglSurfaceAttrib;

			[RequiredByFeature("EGL_VERSION_1_1")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate bool eglSwapInterval(IntPtr dpy, int interval);

			[RequiredByFeature("EGL_VERSION_1_1")]
			internal static eglSwapInterval peglSwapInterval;

		}
	}

}
