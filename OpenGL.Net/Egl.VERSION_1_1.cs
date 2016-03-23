
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
		/// Value of EGL_BACK_BUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BACK_BUFFER = 0x3084;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by Egl.DONT_CARE, Egl.TRUE, or Egl.FALSE. If Egl.TRUE is specified, then only frame 
		/// buffer configurations that support binding of color buffers to an OpenGL ES RGB texture will be considered. Currently 
		/// only frame buffer configurations that support pbuffers allow this. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns Egl.TRUE if color buffers can be bound to an RGB texture, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGB = 0x3039;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by one of Egl.DONT_CARE, Egl.TRUE, or Egl.FALSE. If Egl.TRUE is specified, then only 
		/// frame buffer configurations that support binding of color buffers to an OpenGL ES RGBA texture will be considered. 
		/// Currently only frame buffer configurations that support pbuffers allow this. The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns Egl.TRUE if color buffers can be bound to an RGBA texture, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGBA = 0x303A;

		/// <summary>
		/// Egl.GetError: a power management event has occurred. The application must destroy all contexts and reinitialise OpenGL 
		/// ES state and objects to continue rendering.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int CONTEXT_LOST = 0x300E;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a integer that indicates the minimum value that can be passed to eglSwapInterval. 
		/// The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the minimum value that can be passed to eglSwapInterval.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIN_SWAP_INTERVAL = 0x303B;

		/// <summary>
		/// <para>
		/// Egl.ChooseConfig: must be followed by a integer that indicates the maximum value that can be passed to Egl.SwapInterval. 
		/// The default value is Egl.DONT_CARE.
		/// </para>
		/// <para>
		/// Egl.GetConfigAttrib: returns the maximum value that can be passed to eglSwapInterval.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MAX_SWAP_INTERVAL = 0x303C;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferFromClientBuffer: specifies whether storage for mipmaps should be allocated. Space for mipmaps will be 
		/// set aside if the attribute value is Egl.TRUE and Egl.TEXTURE_FORMAT is not Egl.NO_TEXTURE. The default value is 
		/// Egl.FALSE.
		/// </para>
		/// <para>
		/// Egl.CreatePbufferSurface: specifies whether storage for mipmaps should be allocated. Space for mipmaps will be set aside 
		/// if the attribute value is Egl.TRUE and Egl.TEXTURE_FORMAT is not Egl.NO_TEXTURE. The default value is Egl.FALSE.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns Egl.TRUE if texture has mipmaps, Egl.FALSE otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIPMAP_TEXTURE = 0x3082;

		/// <summary>
		/// <para>
		/// Egl.QuerySurface: returns which level of the mipmap to render to, if texture has mipmaps.
		/// </para>
		/// <para>
		/// Egl.SurfaceAttrib: for mipmap textures, the Egl.MIPMAP_LEVEL attribute indicates which level of the mipmap should be 
		/// rendered. If the value of this attribute is outside the range of supported mipmap levels, the closest valid mipmap level 
		/// is selected for rendering. The default value is Egl..
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIPMAP_LEVEL = 0x3083;

		/// <summary>
		/// Value of EGL_NO_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int NO_TEXTURE = 0x305C;

		/// <summary>
		/// Value of EGL_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_2D = 0x305F;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferFromClientBuffer: specifies the format of the texture that will be created when a pbuffer is bound to a 
		/// texture map. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and Egl.TEXTURE_RGBA. The default value is 
		/// Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// Egl.CreatePbufferSurface: specifies the format of the texture that will be created when a pbuffer is bound to a texture 
		/// map. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and Egl.TEXTURE_RGBA. The default value is Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns format of texture. Possible values are Egl.NO_TEXTURE, Egl.TEXTURE_RGB, and Egl.TEXTURE_RGBA.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_FORMAT = 0x3080;

		/// <summary>
		/// Value of EGL_TEXTURE_RGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_RGB = 0x305D;

		/// <summary>
		/// Value of EGL_TEXTURE_RGBA symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_RGBA = 0x305E;

		/// <summary>
		/// <para>
		/// Egl.CreatePbufferFromClientBuffer: specifies the target for the texture that will be created when the pbuffer is created 
		/// with a texture format of Egl.TEXTURE_RGB or Egl.TEXTURE_RGBA. Possible values are Egl.NO_TEXTURE, or Egl.TEXTURE_2D. The 
		/// default value is Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// Egl.CreatePbufferSurface: specifies the target for the texture that will be created when the pbuffer is created with a 
		/// texture format of Egl.TEXTURE_RGB or Egl.TEXTURE_RGBA. Possible values are Egl.NO_TEXTURE, or Egl.TEXTURE_2D. The 
		/// default value is Egl.NO_TEXTURE.
		/// </para>
		/// <para>
		/// Egl.QuerySurface: returns type of texture. Possible values are Egl.NO_TEXTURE, or Egl.TEXTURE_2D.
		/// </para>
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int TEXTURE_TARGET = 0x3081;

		/// <summary>
		/// Defines a two-dimensional texture image
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
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool BindTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.peglBindTexImage != null, "peglBindTexImage not implemented");
			retValue = Delegates.peglBindTexImage(dpy, surface, buffer);
			LogFunction("eglBindTexImage(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), surface.ToString("X8"), buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Releases a color buffer that is being used as a texture
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
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool ReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			bool retValue;

			Debug.Assert(Delegates.peglReleaseTexImage != null, "peglReleaseTexImage not implemented");
			retValue = Delegates.peglReleaseTexImage(dpy, surface, buffer);
			LogFunction("eglReleaseTexImage(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), surface.ToString("X8"), buffer, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// set an EGL surface attribute
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
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool SurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSurfaceAttrib != null, "peglSurfaceAttrib not implemented");
			retValue = Delegates.peglSurfaceAttrib(dpy, surface, attribute, value);
			LogFunction("eglSurfaceAttrib(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), surface.ToString("X8"), attribute, value, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// specifies the minimum number of video frame periods per buffer swap for the window associated with the current context.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="interval">
		/// Specifies the minimum number of video frames that are displayed before a buffer swap will occur.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public static bool SwapInterval(IntPtr dpy, int interval)
		{
			bool retValue;

			Debug.Assert(Delegates.peglSwapInterval != null, "peglSwapInterval not implemented");
			retValue = Delegates.peglSwapInterval(dpy, interval);
			LogFunction("eglSwapInterval(0x{0}, {1}) = {2}", dpy.ToString("X8"), interval, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
