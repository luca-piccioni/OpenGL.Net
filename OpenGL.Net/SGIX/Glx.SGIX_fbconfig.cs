
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
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_WINDOW_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const uint WINDOW_BIT_SGIX = 0x00000001;

		/// <summary>
		/// Value of GLX_PIXMAP_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const uint PIXMAP_BIT_SGIX = 0x00000002;

		/// <summary>
		/// Value of GLX_RGBA_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const uint RGBA_BIT_SGIX = 0x00000001;

		/// <summary>
		/// Value of GLX_COLOR_INDEX_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const uint COLOR_INDEX_BIT_SGIX = 0x00000002;

		/// <summary>
		/// Value of GLX_DRAWABLE_TYPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int DRAWABLE_TYPE_SGIX = 0x8010;

		/// <summary>
		/// Value of GLX_RENDER_TYPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int RENDER_TYPE_SGIX = 0x8011;

		/// <summary>
		/// Value of GLX_X_RENDERABLE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int X_RENDERABLE_SGIX = 0x8012;

		/// <summary>
		/// Value of GLX_FBCONFIG_ID_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int FBCONFIG_ID_SGIX = 0x8013;

		/// <summary>
		/// Value of GLX_RGBA_TYPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int RGBA_TYPE_SGIX = 0x8014;

		/// <summary>
		/// Value of GLX_COLOR_INDEX_TYPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public const int COLOR_INDEX_TYPE_SGIX = 0x8015;

		/// <summary>
		/// Binding for glXGetFBConfigAttribSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static int GetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXGetFBConfigAttribSGIX != null, "pglXGetFBConfigAttribSGIX not implemented");
					retValue = Delegates.pglXGetFBConfigAttribSGIX(dpy, config, attribute, p_value);
					CallLog("glXGetFBConfigAttribSGIX({0}, {1}, {2}, {3}) = {4}", dpy, config, attribute, value, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXChooseFBConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="nelements">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static IntPtr ChooseFBConfigSGIX(IntPtr dpy, int screen, int[] attrib_list, int[] nelements)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXChooseFBConfigSGIX != null, "pglXChooseFBConfigSGIX not implemented");
					retValue = Delegates.pglXChooseFBConfigSGIX(dpy, screen, p_attrib_list, p_nelements);
					CallLog("glXChooseFBConfigSGIX({0}, {1}, {2}, {3}) = {4}", dpy, screen, attrib_list, nelements, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXCreateGLXPixmapWithConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static IntPtr CreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXPixmapWithConfigSGIX != null, "pglXCreateGLXPixmapWithConfigSGIX not implemented");
			retValue = Delegates.pglXCreateGLXPixmapWithConfigSGIX(dpy, config, pixmap);
			CallLog("glXCreateGLXPixmapWithConfigSGIX({0}, {1}, {2}) = {3}", dpy, config, pixmap, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXCreateContextWithConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="render_type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="share_list">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="direct">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static IntPtr CreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateContextWithConfigSGIX != null, "pglXCreateContextWithConfigSGIX not implemented");
			retValue = Delegates.pglXCreateContextWithConfigSGIX(dpy, config, render_type, share_list, direct);
			CallLog("glXCreateContextWithConfigSGIX({0}, {1}, {2}, {3}, {4}) = {5}", dpy, config, render_type, share_list, direct, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetVisualFromFBConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static Glx.XVisualInfo GetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config)
		{
			Glx.XVisualInfo retValue;

			Debug.Assert(Delegates.pglXGetVisualFromFBConfigSGIX != null, "pglXGetVisualFromFBConfigSGIX not implemented");
			retValue = Delegates.pglXGetVisualFromFBConfigSGIX(dpy, config);
			CallLog("glXGetVisualFromFBConfigSGIX({0}, {1}) = {2}", dpy, config, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXGetFBConfigFromVisualSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="vis">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		public static IntPtr GetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetFBConfigFromVisualSGIX != null, "pglXGetFBConfigFromVisualSGIX not implemented");
			retValue = Delegates.pglXGetFBConfigFromVisualSGIX(dpy, vis);
			CallLog("glXGetFBConfigFromVisualSGIX({0}, {1}) = {2}", dpy, vis, retValue);

			return (retValue);
		}

	}

}
