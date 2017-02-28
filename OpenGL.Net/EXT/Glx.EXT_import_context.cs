
// Copyright (C) 2015-2016 Luca Piccioni
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
		/// Value of GLX_SHARE_CONTEXT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_EXT_import_context")]
		public const int SHARE_CONTEXT_EXT = 0x800A;

		/// <summary>
		/// Binding for glXGetCurrentDisplayEXT.
		/// </summary>
		[RequiredByFeature("GLX_EXT_import_context")]
		public static IntPtr GetCurrentDisplayEXT()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentDisplayEXT != null, "pglXGetCurrentDisplayEXT not implemented");
			retValue = Delegates.pglXGetCurrentDisplayEXT();
			LogFunction("glXGetCurrentDisplayEXT() = {0}", retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// query context information
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// Specifies that a context parameter should be retrieved. Must be one of Glx.SHARED_CONTEXT_EXT, Glx.VISUAL_ID_EXT, or 
		/// Glx.SCREEN_EXT.
		/// </param>
		/// <param name="value">
		/// Contains the return value for <paramref name="attribute"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Glx.adContext is generated if <paramref name="ctx"/> does not refer to a valid context.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Glx.BAD_ATTRIBUTE is returned if <paramref name="attribute"/> is not a valid GLX context attribute.
		/// </exception>
		/// <exception cref="KhronosException">
		/// fred Glx.BAD_CONTEXT is returned if <paramref name="attribute"/> is not a valid context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		[RequiredByFeature("GLX_EXT_import_context")]
		public static int QueryContextInfoEXT(IntPtr dpy, IntPtr context, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXQueryContextInfoEXT != null, "pglXQueryContextInfoEXT not implemented");
					retValue = Delegates.pglXQueryContextInfoEXT(dpy, context, attribute, p_value);
					LogFunction("glXQueryContextInfoEXT(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), context.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// get the XID for a context.
		/// </summary>
		/// <param name="context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Glx.adContext is generated if <paramref name="ctx"/> does not refer to a valid context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		[RequiredByFeature("GLX_EXT_import_context")]
		public static IntPtr GetContextIDEXT(IntPtr context)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetContextIDEXT != null, "pglXGetContextIDEXT not implemented");
			retValue = Delegates.pglXGetContextIDEXT(context);
			LogFunction("glXGetContextIDEXT(0x{0}) = {1}", context.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// import another process's indirect rendering context.
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="contextID">
		/// Specifies a GLX rendering context.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Glx.adContext is generated if <paramref name="contextID"/> does not refer to a valid context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		/// <seealso cref="Glx.GetContextIDEXT"/>
		/// <seealso cref="Glx.FreeContextEXT"/>
		[RequiredByFeature("GLX_EXT_import_context")]
		public static IntPtr ImportContextEXT(IntPtr dpy, IntPtr contextID)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXImportContextEXT != null, "pglXImportContextEXT not implemented");
			retValue = Delegates.pglXImportContextEXT(dpy, contextID);
			LogFunction("glXImportContextEXT(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), contextID.ToString("X8"), retValue.ToString("X8"));
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// free client-side memory for imported context
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <remarks>
		/// </remarks>
		/// <exception cref="KhronosException">
		/// Glx.adContext is generated if <paramref name="ctx"/> does not refer to a valid context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.QueryVersion"/>
		/// <seealso cref="Glx.QueryExtensionsString"/>
		/// <seealso cref="Glx.ImportContextEXT"/>
		[RequiredByFeature("GLX_EXT_import_context")]
		public static void FreeContextEXT(IntPtr dpy, IntPtr context)
		{
			Debug.Assert(Delegates.pglXFreeContextEXT != null, "pglXFreeContextEXT not implemented");
			Delegates.pglXFreeContextEXT(dpy, context);
			LogFunction("glXFreeContextEXT(0x{0}, 0x{1})", dpy.ToString("X8"), context.ToString("X8"));
			DebugCheckErrors(null);
		}

		public unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetCurrentDisplayEXT", ExactSpelling = true)]
			internal extern static IntPtr glXGetCurrentDisplayEXT();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXQueryContextInfoEXT", ExactSpelling = true)]
			internal extern static unsafe int glXQueryContextInfoEXT(IntPtr dpy, IntPtr context, int attribute, int* value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXGetContextIDEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXGetContextIDEXT(IntPtr context);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXImportContextEXT", ExactSpelling = true)]
			internal extern static unsafe IntPtr glXImportContextEXT(IntPtr dpy, IntPtr contextID);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glXFreeContextEXT", ExactSpelling = true)]
			internal extern static unsafe void glXFreeContextEXT(IntPtr dpy, IntPtr context);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GLX_EXT_import_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glXGetCurrentDisplayEXT();

			internal static glXGetCurrentDisplayEXT pglXGetCurrentDisplayEXT;

			[RequiredByFeature("GLX_EXT_import_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate int glXQueryContextInfoEXT(IntPtr dpy, IntPtr context, int attribute, int* value);

			internal static glXQueryContextInfoEXT pglXQueryContextInfoEXT;

			[RequiredByFeature("GLX_EXT_import_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXGetContextIDEXT(IntPtr context);

			internal static glXGetContextIDEXT pglXGetContextIDEXT;

			[RequiredByFeature("GLX_EXT_import_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate IntPtr glXImportContextEXT(IntPtr dpy, IntPtr contextID);

			internal static glXImportContextEXT pglXImportContextEXT;

			[RequiredByFeature("GLX_EXT_import_context")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glXFreeContextEXT(IntPtr dpy, IntPtr context);

			internal static glXFreeContextEXT pglXFreeContextEXT;

		}
	}

}
