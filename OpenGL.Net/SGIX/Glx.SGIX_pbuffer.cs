
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
		/// Value of GLX_BUFFER_CLOBBER_MASK_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		[Log(BitmaskName = "GLXEventMask")]
		public const uint BUFFER_CLOBBER_MASK_SGIX = 0x08000000;

		/// <summary>
		/// Value of GLX_SAMPLE_BUFFERS_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		[Log(BitmaskName = "GLXPbufferClobberMask")]
		public const uint SAMPLE_BUFFERS_BIT_SGIX = 0x00000100;

		/// <summary>
		/// Value of GLX_OPTIMAL_PBUFFER_WIDTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public const int OPTIMAL_PBUFFER_WIDTH_SGIX = 0x8019;

		/// <summary>
		/// Value of GLX_OPTIMAL_PBUFFER_HEIGHT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public const int OPTIMAL_PBUFFER_HEIGHT_SGIX = 0x801A;

		/// <summary>
		/// Binding for glXCreateGLXPbufferSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="width">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="height">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static IntPtr CreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXCreateGLXPbufferSGIX != null, "pglXCreateGLXPbufferSGIX not implemented");
					retValue = Delegates.pglXCreateGLXPbufferSGIX(dpy, config, width, height, p_attrib_list);
					LogFunction("glXCreateGLXPbufferSGIX(0x{0}, 0x{1}, {2}, {3}, {4}) = {5}", dpy.ToString("X8"), config.ToString("X8"), width, height, LogValue(attrib_list), retValue.ToString("X8"));
				}
			}

			return (retValue);
		}

		/// <summary>
		/// Binding for glXDestroyGLXPbufferSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static void DestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf)
		{
			Debug.Assert(Delegates.pglXDestroyGLXPbufferSGIX != null, "pglXDestroyGLXPbufferSGIX not implemented");
			Delegates.pglXDestroyGLXPbufferSGIX(dpy, pbuf);
			LogFunction("glXDestroyGLXPbufferSGIX(0x{0}, 0x{1})", dpy.ToString("X8"), pbuf.ToString("X8"));
		}

		/// <summary>
		/// Binding for glXQueryGLXPbufferSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="pbuf">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static int QueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, IntPtr value)
		{
			int retValue;

			Debug.Assert(Delegates.pglXQueryGLXPbufferSGIX != null, "pglXQueryGLXPbufferSGIX not implemented");
			retValue = Delegates.pglXQueryGLXPbufferSGIX(dpy, pbuf, attribute, value);
			LogFunction("glXQueryGLXPbufferSGIX(0x{0}, 0x{1}, {2}, 0x{3}) = {4}", dpy.ToString("X8"), pbuf.ToString("X8"), attribute, value.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXSelectEventSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static void SelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask)
		{
			Debug.Assert(Delegates.pglXSelectEventSGIX != null, "pglXSelectEventSGIX not implemented");
			Delegates.pglXSelectEventSGIX(dpy, drawable, mask);
			LogFunction("glXSelectEventSGIX(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), drawable.ToString("X8"), mask);
		}

		/// <summary>
		/// Binding for glXGetSelectedEventSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="drawable">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="mask">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static void GetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, [Out] UInt32[] mask)
		{
			unsafe {
				fixed (UInt32* p_mask = mask)
				{
					Debug.Assert(Delegates.pglXGetSelectedEventSGIX != null, "pglXGetSelectedEventSGIX not implemented");
					Delegates.pglXGetSelectedEventSGIX(dpy, drawable, p_mask);
					LogFunction("glXGetSelectedEventSGIX(0x{0}, 0x{1}, {2})", dpy.ToString("X8"), drawable.ToString("X8"), LogValue(mask));
				}
			}
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXCreateGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, IntPtr value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXSelectEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetSelectedEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);

		}

		internal unsafe static partial class Delegates
		{
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);

			internal static glXCreateGLXPbufferSGIX pglXCreateGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);

			internal static glXDestroyGLXPbufferSGIX pglXDestroyGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, IntPtr value);

			internal static glXQueryGLXPbufferSGIX pglXQueryGLXPbufferSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);

			internal static glXSelectEventSGIX pglXSelectEventSGIX;

			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);

			internal static glXGetSelectedEventSGIX pglXGetSelectedEventSGIX;

		}
	}

}
