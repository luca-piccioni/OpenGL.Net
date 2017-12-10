
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// [GLX] glXGetFBConfigAttribSGIX: Binding for glXGetFBConfigAttribSGIX.
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
		/// [GLX] glXChooseFBConfigSGIX: Binding for glXChooseFBConfigSGIX.
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
		/// [GLX] glXCreateGLXPixmapWithConfigSGIX: Binding for glXCreateGLXPixmapWithConfigSGIX.
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
		/// [GLX] glXCreateContextWithConfigSGIX: Binding for glXCreateContextWithConfigSGIX.
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
		/// [GLX] glXGetVisualFromFBConfigSGIX: Binding for glXGetVisualFromFBConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		private static IntPtr GetVisualFromFBConfigSGIXCore(IntPtr dpy, IntPtr config)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetVisualFromFBConfigSGIX != null, "pglXGetVisualFromFBConfigSGIX not implemented");
			retValue = Delegates.pglXGetVisualFromFBConfigSGIX(dpy, config);
			LogCommand("glXGetVisualFromFBConfigSGIX", retValue, dpy, config			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] glXGetFBConfigFromVisualSGIX: Binding for glXGetFBConfigFromVisualSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="vis">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_fbconfig")]
		private static IntPtr GetFBConfigFromVisualSGIXCore(IntPtr dpy, IntPtr vis)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetFBConfigFromVisualSGIX != null, "pglXGetFBConfigFromVisualSGIX not implemented");
			retValue = Delegates.pglXGetFBConfigFromVisualSGIX(dpy, vis);
			LogCommand("glXGetFBConfigFromVisualSGIX", retValue, dpy, vis			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate int glXGetFBConfigAttribSGIX(IntPtr dpy, IntPtr config, int attribute, int* value);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetFBConfigAttribSGIX pglXGetFBConfigAttribSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr* glXChooseFBConfigSGIX(IntPtr dpy, int screen, int* attrib_list, int* nelements);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXChooseFBConfigSGIX pglXChooseFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glXCreateGLXPixmapWithConfigSGIX(IntPtr dpy, IntPtr config, IntPtr pixmap);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXCreateGLXPixmapWithConfigSGIX pglXCreateGLXPixmapWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glXCreateContextWithConfigSGIX(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXCreateContextWithConfigSGIX pglXCreateContextWithConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glXGetVisualFromFBConfigSGIX(IntPtr dpy, IntPtr config);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetVisualFromFBConfigSGIX pglXGetVisualFromFBConfigSGIX;

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate IntPtr glXGetFBConfigFromVisualSGIX(IntPtr dpy, IntPtr vis);

			[RequiredByFeature("GLX_SGIX_fbconfig")]
			internal static glXGetFBConfigFromVisualSGIX pglXGetFBConfigFromVisualSGIX;

		}
	}

}
