
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
	public partial class Glx
	{
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
		public static int GetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, [Out] int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXGetFBConfigAttribSGIX != null, "pglXGetFBConfigAttribSGIX not implemented");
					retValue = Delegates.pglXGetFBConfigAttribSGIX(dpy, config, attribute, p_value);
					CallLog("glXGetFBConfigAttribSGIX(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), attribute, value, retValue);
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
		public static unsafe IntPtr* ChooseFBConfigSGIX(IntPtr dpy, int screen, int[] attrib_list, int[] nelements)
		{
			IntPtr* retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXChooseFBConfigSGIX != null, "pglXChooseFBConfigSGIX not implemented");
					retValue = Delegates.pglXChooseFBConfigSGIX(dpy, screen, p_attrib_list, p_nelements);
					CallLog("glXChooseFBConfigSGIX(0x{0}, {1}, {2}, {3}) = {4}", dpy.ToString("X8"), screen, attrib_list, nelements, retValue != null ? retValue->ToString() : "(null)");
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
			CallLog("glXCreateGLXPixmapWithConfigSGIX(0x{0}, 0x{1}, 0x{2}) = {3}", dpy.ToString("X8"), config.ToString("X8"), pixmap.ToString("X8"), retValue.ToString("X8"));

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
			CallLog("glXCreateContextWithConfigSGIX(0x{0}, 0x{1}, {2}, 0x{3}, {4}) = {5}", dpy.ToString("X8"), config.ToString("X8"), render_type, share_list.ToString("X8"), direct, retValue.ToString("X8"));

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
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetVisualFromFBConfigSGIX != null, "pglXGetVisualFromFBConfigSGIX not implemented");
			retValue = Delegates.pglXGetVisualFromFBConfigSGIX(dpy, config);
			CallLog("glXGetVisualFromFBConfigSGIX(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), config.ToString("X8"), (Glx.XVisualInfo)Marshal.PtrToStructure(retValue, typeof(Glx.XVisualInfo)));

			return ((Glx.XVisualInfo)Marshal.PtrToStructure(retValue, typeof(Glx.XVisualInfo)));
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
			CallLog("glXGetFBConfigFromVisualSGIX(0x{0}, {1}) = {2}", dpy.ToString("X8"), vis, retValue.ToString("X8"));

			return (retValue);
		}

	}

}
