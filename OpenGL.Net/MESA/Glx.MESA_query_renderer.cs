
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
		/// Value of GLX_RENDERER_VENDOR_ID_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_VENDOR_ID_MESA = 0x8183;

		/// <summary>
		/// Value of GLX_RENDERER_DEVICE_ID_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_DEVICE_ID_MESA = 0x8184;

		/// <summary>
		/// Value of GLX_RENDERER_VERSION_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_VERSION_MESA = 0x8185;

		/// <summary>
		/// Value of GLX_RENDERER_ACCELERATED_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_ACCELERATED_MESA = 0x8186;

		/// <summary>
		/// Value of GLX_RENDERER_VIDEO_MEMORY_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_VIDEO_MEMORY_MESA = 0x8187;

		/// <summary>
		/// Value of GLX_RENDERER_UNIFIED_MEMORY_ARCHITECTURE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_UNIFIED_MEMORY_ARCHITECTURE_MESA = 0x8188;

		/// <summary>
		/// Value of GLX_RENDERER_PREFERRED_PROFILE_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_PREFERRED_PROFILE_MESA = 0x8189;

		/// <summary>
		/// Value of GLX_RENDERER_OPENGL_CORE_PROFILE_VERSION_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_OPENGL_CORE_PROFILE_VERSION_MESA = 0x818A;

		/// <summary>
		/// Value of GLX_RENDERER_OPENGL_COMPATIBILITY_PROFILE_VERSION_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_OPENGL_COMPATIBILITY_PROFILE_VERSION_MESA = 0x818B;

		/// <summary>
		/// Value of GLX_RENDERER_OPENGL_ES_PROFILE_VERSION_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_OPENGL_ES_PROFILE_VERSION_MESA = 0x818C;

		/// <summary>
		/// Value of GLX_RENDERER_OPENGL_ES2_PROFILE_VERSION_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_OPENGL_ES2_PROFILE_VERSION_MESA = 0x818D;

		/// <summary>
		/// Value of GLX_RENDERER_ID_MESA symbol.
		/// </summary>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public const int RENDERER_ID_MESA = 0x818E;

		/// <summary>
		/// Binding for glXQueryCurrentRendererIntegerMESA.
		/// </summary>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public static bool QueryCurrentRenderMESA(int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXQueryCurrentRendererIntegerMESA != null, "pglXQueryCurrentRendererIntegerMESA not implemented");
			retValue = Delegates.pglXQueryCurrentRendererIntegerMESA(attribute, value);
			CallLog("glXQueryCurrentRendererIntegerMESA({0}, {1}) = {2}", attribute, value, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryCurrentRendererStringMESA.
		/// </summary>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public static string QueryCurrentRendererStringMESA(int attribute)
		{
			string retValue;

			Debug.Assert(Delegates.pglXQueryCurrentRendererStringMESA != null, "pglXQueryCurrentRendererStringMESA not implemented");
			retValue = Delegates.pglXQueryCurrentRendererStringMESA(attribute);
			CallLog("glXQueryCurrentRendererStringMESA({0}) = {1}", attribute, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryRendererIntegerMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderer">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public static bool QueryRenderMESA(IntPtr dpy, int screen, int renderer, int attribute, IntPtr value)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXQueryRendererIntegerMESA != null, "pglXQueryRendererIntegerMESA not implemented");
			retValue = Delegates.pglXQueryRendererIntegerMESA(dpy, screen, renderer, attribute, value);
			CallLog("glXQueryRendererIntegerMESA({0}, {1}, {2}, {3}, {4}) = {5}", dpy, screen, renderer, attribute, value, retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXQueryRendererStringMESA.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="screen">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="renderer">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_MESA_query_renderer")]
		public static string QueryRendererStringMESA(IntPtr dpy, int screen, int renderer, int attribute)
		{
			string retValue;

			Debug.Assert(Delegates.pglXQueryRendererStringMESA != null, "pglXQueryRendererStringMESA not implemented");
			retValue = Delegates.pglXQueryRendererStringMESA(dpy, screen, renderer, attribute);
			CallLog("glXQueryRendererStringMESA({0}, {1}, {2}, {3}) = {4}", dpy, screen, renderer, attribute, retValue);

			return (retValue);
		}

	}

}
