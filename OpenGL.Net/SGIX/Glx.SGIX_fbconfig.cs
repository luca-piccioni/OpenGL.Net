
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
		/// [GLX] Binding for glXGetFBConfigAttribSGIX.
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
					LogCommand("glXGetFBConfigAttribSGIX", retValue, dpy, config, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXChooseFBConfigSGIX.
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
					LogCommand("glXChooseFBConfigSGIX", new IntPtr(retValue), dpy, screen, attrib_list, nelements					);
				}
			}
			DebugCheckErrors(null);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXCreateGLXPixmapWithConfigSGIX.
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
			LogCommand("glXCreateGLXPixmapWithConfigSGIX", retValue, dpy, config, pixmap			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXCreateContextWithConfigSGIX.
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
			LogCommand("glXCreateContextWithConfigSGIX", retValue, dpy, config, render_type, share_list, direct			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXGetVisualFromFBConfigSGIX.
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
			LogCommand("glXGetVisualFromFBConfigSGIX", (Glx.XVisualInfo)Marshal.PtrToStructure(retValue, typeof(Glx.XVisualInfo)), dpy, config			);
			DebugCheckErrors(retValue);

			return ((Glx.XVisualInfo)Marshal.PtrToStructure(retValue, typeof(Glx.XVisualInfo)));
		}

		/// <summary>
		/// [GLX] Binding for glXGetFBConfigFromVisualSGIX.
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
			LogCommand("glXGetFBConfigFromVisualSGIX", retValue, dpy, vis			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetFBConfigAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXChooseFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateGLXPixmapWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateContextWithConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetVisualFromFBConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetFBConfigFromVisualSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetFBConfigAttribSGIX pglXGetFBConfigAttribSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXChooseFBConfigSGIX pglXChooseFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXCreateGLXPixmapWithConfigSGIX pglXCreateGLXPixmapWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXCreateContextWithConfigSGIX pglXCreateContextWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetVisualFromFBConfigSGIX pglXGetVisualFromFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, Glx.XVisualInfo vis);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetFBConfigFromVisualSGIX pglXGetFBConfigFromVisualSGIX;

		}
	}

}
