
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
		/// [GLX] Value of GLX_BUFFER_CLOBBER_MASK_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		[Log(BitmaskName = "GLXEventMask")]
		public const uint BUFFER_CLOBBER_MASK_SGIX = 0x08000000;

		/// <summary>
		/// [GLX] Value of GLX_SAMPLE_BUFFERS_BIT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		[Log(BitmaskName = "GLXPbufferClobberMask")]
		public const uint SAMPLE_BUFFERS_BIT_SGIX = 0x00000100;

		/// <summary>
		/// [GLX] Value of GLX_OPTIMAL_PBUFFER_WIDTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public const int OPTIMAL_PBUFFER_WIDTH_SGIX = 0x8019;

		/// <summary>
		/// [GLX] Value of GLX_OPTIMAL_PBUFFER_HEIGHT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public const int OPTIMAL_PBUFFER_HEIGHT_SGIX = 0x801A;

		/// <summary>
		/// [GLX] Binding for glXCreateGLXPbufferSGIX.
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
					LogCommand("glXCreateGLXPbufferSGIX", retValue, dpy, config, width, height, attrib_list					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXDestroyGLXPbufferSGIX.
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
			LogCommand("glXDestroyGLXPbufferSGIX", null, dpy, pbuf			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryGLXPbufferSGIX.
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
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_pbuffer")]
		public static int QueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, UInt32[] value)
		{
			int retValue;

			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglXQueryGLXPbufferSGIX != null, "pglXQueryGLXPbufferSGIX not implemented");
					retValue = Delegates.pglXQueryGLXPbufferSGIX(dpy, pbuf, attribute, p_value);
					LogCommand("glXQueryGLXPbufferSGIX", retValue, dpy, pbuf, attribute, value					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXSelectEventSGIX.
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
			LogCommand("glXSelectEventSGIX", null, dpy, drawable, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GLX] Binding for glXGetSelectedEventSGIX.
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
					LogCommand("glXGetSelectedEventSGIX", null, dpy, drawable, mask					);
				}
			}
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXCreateGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXDestroyGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXQueryGLXPbufferSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, UInt32* value);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXSelectEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);

			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			[DllImport(Library, EntryPoint = "glXGetSelectedEventSGIX", ExactSpelling = true)]
			internal extern static unsafe void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate IntPtr glXCreateGLXPbufferSGIX(IntPtr dpy, IntPtr config, UInt32 width, UInt32 height, int* attrib_list);

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			internal static glXCreateGLXPbufferSGIX pglXCreateGLXPbufferSGIX;

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXDestroyGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf);

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			internal static glXDestroyGLXPbufferSGIX pglXDestroyGLXPbufferSGIX;

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate int glXQueryGLXPbufferSGIX(IntPtr dpy, IntPtr pbuf, int attribute, UInt32* value);

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			internal static glXQueryGLXPbufferSGIX pglXQueryGLXPbufferSGIX;

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXSelectEventSGIX(IntPtr dpy, IntPtr drawable, UInt32 mask);

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			internal static glXSelectEventSGIX pglXSelectEventSGIX;

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			#if !NETCORE
			[SuppressUnmanagedCodeSecurity()]
			#endif
			internal unsafe delegate void glXGetSelectedEventSGIX(IntPtr dpy, IntPtr drawable, UInt32* mask);

			[RequiredByFeature("GLX_SGIX_pbuffer")]
			internal static glXGetSelectedEventSGIX pglXGetSelectedEventSGIX;

		}
	}

}
