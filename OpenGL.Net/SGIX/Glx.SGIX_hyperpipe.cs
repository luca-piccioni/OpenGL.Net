
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
		/// [GLX] Value of GLX_HYPERPIPE_PIPE_NAME_LENGTH_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public const int HYPERPIPE_PIPE_NAME_LENGTH_SGIX = 80;

		/// <summary>
		/// [GLX] Value of GLX_BAD_HYPERPIPE_CONFIG_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public const int BAD_HYPERPIPE_CONFIG_SGIX = 91;

		/// <summary>
		/// [GLX] Value of GLX_BAD_HYPERPIPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public const int BAD_HYPERPIPE_SGIX = 92;

		/// <summary>
		/// [GLX] Value of GLX_HYPERPIPE_DISPLAY_PIPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeTypeMask")]
		public const int HYPERPIPE_DISPLAY_PIPE_SGIX = 0x00000001;

		/// <summary>
		/// [GLX] Value of GLX_HYPERPIPE_RENDER_PIPE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeTypeMask")]
		public const int HYPERPIPE_RENDER_PIPE_SGIX = 0x00000002;

		/// <summary>
		/// [GLX] Value of GLX_PIPE_RECT_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeAttribSGIX")]
		public const int PIPE_RECT_SGIX = 0x00000001;

		/// <summary>
		/// [GLX] Value of GLX_PIPE_RECT_LIMITS_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeAttribSGIX")]
		public const int PIPE_RECT_LIMITS_SGIX = 0x00000002;

		/// <summary>
		/// [GLX] Value of GLX_HYPERPIPE_STEREO_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeAttribSGIX")]
		public const int HYPERPIPE_STEREO_SGIX = 0x00000003;

		/// <summary>
		/// [GLX] Value of GLX_HYPERPIPE_PIXEL_AVERAGE_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		[Log(BitmaskName = "GLXHyperpipeAttribSGIX")]
		public const int HYPERPIPE_PIXEL_AVERAGE_SGIX = 0x00000004;

		/// <summary>
		/// [GLX] Value of GLX_HYPERPIPE_ID_SGIX symbol.
		/// </summary>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public const int HYPERPIPE_ID_SGIX = 0x8030;

		/// <summary>
		/// [GLX] Binding for glXQueryHyperpipeNetworkSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="npipes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static unsafe IntPtr* QueryHyperpipeNetworkSGIX(IntPtr dpy, int[] npipes)
		{
			IntPtr* retValue;

			unsafe {
				fixed (int* p_npipes = npipes)
				{
					Debug.Assert(Delegates.pglXQueryHyperpipeNetworkSGIX != null, "pglXQueryHyperpipeNetworkSGIX not implemented");
					retValue = Delegates.pglXQueryHyperpipeNetworkSGIX(dpy, p_npipes);
					LogCommand("glXQueryHyperpipeNetworkSGIX", new IntPtr(retValue), dpy, npipes					);
				}
			}
			DebugCheckErrors(null);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXHyperpipeConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="networkId">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="npipes">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="cfg">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hpId">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int HyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, int[] hpId)
		{
			int retValue;

			unsafe {
				fixed (int* p_hpId = hpId)
				{
					Debug.Assert(Delegates.pglXHyperpipeConfigSGIX != null, "pglXHyperpipeConfigSGIX not implemented");
					retValue = Delegates.pglXHyperpipeConfigSGIX(dpy, networkId, npipes, cfg, p_hpId);
					LogCommand("glXHyperpipeConfigSGIX", retValue, dpy, networkId, npipes, cfg, hpId					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryHyperpipeConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hpId">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="npipes">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static IntPtr QueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, int[] npipes)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_npipes = npipes)
				{
					Debug.Assert(Delegates.pglXQueryHyperpipeConfigSGIX != null, "pglXQueryHyperpipeConfigSGIX not implemented");
					retValue = Delegates.pglXQueryHyperpipeConfigSGIX(dpy, hpId, p_npipes);
					LogCommand("glXQueryHyperpipeConfigSGIX", retValue, dpy, hpId, npipes					);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXDestroyHyperpipeConfigSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hpId">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int DestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId)
		{
			int retValue;

			Debug.Assert(Delegates.pglXDestroyHyperpipeConfigSGIX != null, "pglXDestroyHyperpipeConfigSGIX not implemented");
			retValue = Delegates.pglXDestroyHyperpipeConfigSGIX(dpy, hpId);
			LogCommand("glXDestroyHyperpipeConfigSGIX", retValue, dpy, hpId			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXBindHyperpipeSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="hpId">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int BindHyperpipeSGIX(IntPtr dpy, int hpId)
		{
			int retValue;

			Debug.Assert(Delegates.pglXBindHyperpipeSGIX != null, "pglXBindHyperpipeSGIX not implemented");
			retValue = Delegates.pglXBindHyperpipeSGIX(dpy, hpId);
			LogCommand("glXBindHyperpipeSGIX", retValue, dpy, hpId			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryHyperpipeBestAttribSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="timeSlice">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="returnAttribList">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int QueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList)
		{
			int retValue;

			Debug.Assert(Delegates.pglXQueryHyperpipeBestAttribSGIX != null, "pglXQueryHyperpipeBestAttribSGIX not implemented");
			retValue = Delegates.pglXQueryHyperpipeBestAttribSGIX(dpy, timeSlice, attrib, size, attribList, returnAttribList);
			LogCommand("glXQueryHyperpipeBestAttribSGIX", retValue, dpy, timeSlice, attrib, size, attribList, returnAttribList			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXHyperpipeAttribSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="timeSlice">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attribList">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int HyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList)
		{
			int retValue;

			Debug.Assert(Delegates.pglXHyperpipeAttribSGIX != null, "pglXHyperpipeAttribSGIX not implemented");
			retValue = Delegates.pglXHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, attribList);
			LogCommand("glXHyperpipeAttribSGIX", retValue, dpy, timeSlice, attrib, size, attribList			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GLX] Binding for glXQueryHyperpipeAttribSGIX.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="timeSlice">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attrib">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="returnAttribList">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGIX_hyperpipe")]
		public static int QueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList)
		{
			int retValue;

			Debug.Assert(Delegates.pglXQueryHyperpipeAttribSGIX != null, "pglXQueryHyperpipeAttribSGIX not implemented");
			retValue = Delegates.pglXQueryHyperpipeAttribSGIX(dpy, timeSlice, attrib, size, returnAttribList);
			LogCommand("glXQueryHyperpipeAttribSGIX", retValue, dpy, timeSlice, attrib, size, returnAttribList			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeNetworkSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr* glXQueryHyperpipeNetworkSGIX(IntPtr dpy, int* npipes);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXHyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, int* hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXQueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, int* npipes);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXDestroyHyperpipeConfigSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXDestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXBindHyperpipeSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXBindHyperpipeSGIX(IntPtr dpy, int hpId);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeBestAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXHyperpipeAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryHyperpipeAttribSGIX", ExactSpelling = true)]
			internal extern static unsafe int glXQueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr* glXQueryHyperpipeNetworkSGIX(IntPtr dpy, int* npipes);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXQueryHyperpipeNetworkSGIX pglXQueryHyperpipeNetworkSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXHyperpipeConfigSGIX(IntPtr dpy, int networkId, int npipes, IntPtr cfg, int* hpId);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXHyperpipeConfigSGIX pglXHyperpipeConfigSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXQueryHyperpipeConfigSGIX(IntPtr dpy, int hpId, int* npipes);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXQueryHyperpipeConfigSGIX pglXQueryHyperpipeConfigSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXDestroyHyperpipeConfigSGIX(IntPtr dpy, int hpId);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXDestroyHyperpipeConfigSGIX pglXDestroyHyperpipeConfigSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXBindHyperpipeSGIX(IntPtr dpy, int hpId);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXBindHyperpipeSGIX pglXBindHyperpipeSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryHyperpipeBestAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList, IntPtr returnAttribList);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXQueryHyperpipeBestAttribSGIX pglXQueryHyperpipeBestAttribSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr attribList);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXHyperpipeAttribSGIX pglXHyperpipeAttribSGIX;

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryHyperpipeAttribSGIX(IntPtr dpy, int timeSlice, int attrib, int size, IntPtr returnAttribList);

			[RequiredByFeature("GLX_SGIX_hyperpipe")]
			internal static glXQueryHyperpipeAttribSGIX pglXQueryHyperpipeAttribSGIX;

		}
	}

}
