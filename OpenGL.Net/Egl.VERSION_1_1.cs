
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
		/// Value of EGL_BIND_TO_TEXTURE_RGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGB = 0x3039;

		/// <summary>
		/// Value of EGL_BIND_TO_TEXTURE_RGBA symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int BIND_TO_TEXTURE_RGBA = 0x303A;

		/// <summary>
		/// Value of EGL_CONTEXT_LOST symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int CONTEXT_LOST = 0x300E;

		/// <summary>
		/// Value of EGL_MIN_SWAP_INTERVAL symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIN_SWAP_INTERVAL = 0x303B;

		/// <summary>
		/// Value of EGL_MAX_SWAP_INTERVAL symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MAX_SWAP_INTERVAL = 0x303C;

		/// <summary>
		/// Value of EGL_MIPMAP_TEXTURE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_1")]
		public const int MIPMAP_TEXTURE = 0x3082;

		/// <summary>
		/// Value of EGL_MIPMAP_LEVEL symbol.
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
		/// Value of EGL_TEXTURE_FORMAT symbol.
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
		/// Value of EGL_TEXTURE_TARGET symbol.
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
		public static IntPtr BindTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglBindTexImage != null, "peglBindTexImage not implemented");
			retValue = Delegates.peglBindTexImage(dpy, surface, buffer);
			CallLog("eglBindTexImage({0}, {1}, {2}) = {3}", dpy, surface, buffer, retValue);
			DebugCheckErrors();

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
		public static IntPtr ReleaseTexImage(IntPtr dpy, IntPtr surface, int buffer)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglReleaseTexImage != null, "peglReleaseTexImage not implemented");
			retValue = Delegates.peglReleaseTexImage(dpy, surface, buffer);
			CallLog("eglReleaseTexImage({0}, {1}, {2}) = {3}", dpy, surface, buffer, retValue);
			DebugCheckErrors();

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
		public static IntPtr SurfaceAttrib(IntPtr dpy, IntPtr surface, int attribute, int value)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglSurfaceAttrib != null, "peglSurfaceAttrib not implemented");
			retValue = Delegates.peglSurfaceAttrib(dpy, surface, attribute, value);
			CallLog("eglSurfaceAttrib({0}, {1}, {2}, {3}) = {4}", dpy, surface, attribute, value, retValue);
			DebugCheckErrors();

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
		public static IntPtr SwapInterval(IntPtr dpy, int interval)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglSwapInterval != null, "peglSwapInterval not implemented");
			retValue = Delegates.peglSwapInterval(dpy, interval);
			CallLog("eglSwapInterval({0}, {1}) = {2}", dpy, interval, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
