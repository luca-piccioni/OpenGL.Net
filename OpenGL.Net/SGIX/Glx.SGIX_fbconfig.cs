
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
					LogFunction("glXGetFBConfigAttribSGIX(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

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
					LogFunction("glXChooseFBConfigSGIX(0x{0}, {1}, {2}, {3}) = {4}", dpy.ToString("X8"), screen, LogValue(attrib_list), LogValue(nelements), retValue != null ? retValue->ToString() : "(null)");
				}
			}
			DebugCheckErrors(null);

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
			LogFunction("glXCreateGLXPixmapWithConfigSGIX(0x{0}, 0x{1}, 0x{2}) = {3}", dpy.ToString("X8"), config.ToString("X8"), pixmap.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

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
			LogFunction("glXCreateContextWithConfigSGIX(0x{0}, 0x{1}, {2}, 0x{3}, {4}) = {5}", dpy.ToString("X8"), config.ToString("X8"), render_type, share_list.ToString("X8"), direct, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

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
			LogFunction("glXGetVisualFromFBConfigSGIX(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), config.ToString("X8"), (Glx.XVisualInfo)Marshal.PtrToStructure(retValue, typeof(Glx.XVisualInfo)));
			DebugCheckErrors(retValue);

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
			LogFunction("glXGetFBConfigFromVisualSGIX(0x{0}, {1}) = {2}", dpy.ToString("X8"), vis, retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXChooseFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateContextWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetVisualFromFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetFBConfigFromVisualSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			internal static glXGetFBConfigAttribSGIX pglXGetFBConfigAttribSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			internal static glXChooseFBConfigSGIX pglXChooseFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			internal static glXCreateGLXPixmapWithConfigSGIX pglXCreateGLXPixmapWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			internal static glXCreateContextWithConfigSGIX pglXCreateContextWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			internal static glXGetVisualFromFBConfigSGIX pglXGetVisualFromFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);

			internal static glXGetFBConfigFromVisualSGIX pglXGetFBConfigFromVisualSGIX;

		}
	}

}
