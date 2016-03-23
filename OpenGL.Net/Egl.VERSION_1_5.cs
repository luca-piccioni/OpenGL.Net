
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
	public partial class Egl
	{
		/// <summary>
		/// Value of EGL_CONTEXT_MINOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_MINOR_VERSION = 0x30FB;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_PROFILE_MASK symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_PROFILE_MASK = 0x30FD;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_RESET_NOTIFICATION_STRATEGY = 0x31BD;

		/// <summary>
		/// Value of EGL_NO_RESET_NOTIFICATION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_RESET_NOTIFICATION = 0x31BE;

		/// <summary>
		/// Value of EGL_LOSE_CONTEXT_ON_RESET symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int LOSE_CONTEXT_ON_RESET = 0x31BF;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_CORE_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLContextProfileMask")]
		public const uint CONTEXT_OPENGL_CORE_PROFILE_BIT = 0x00000001;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLContextProfileMask")]
		public const uint CONTEXT_OPENGL_COMPATIBILITY_PROFILE_BIT = 0x00000002;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_DEBUG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_DEBUG = 0x31B0;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_FORWARD_COMPATIBLE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_FORWARD_COMPATIBLE = 0x31B1;

		/// <summary>
		/// Value of EGL_CONTEXT_OPENGL_ROBUST_ACCESS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONTEXT_OPENGL_ROBUST_ACCESS = 0x31B2;

		/// <summary>
		/// Value of EGL_OPENGL_ES3_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_create_context")]
		[Log(BitmaskName = "EGLRenderableTypeMask")]
		public const uint OPENGL_ES3_BIT = 0x00000040;

		/// <summary>
		/// Value of EGL_CL_EVENT_HANDLE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CL_EVENT_HANDLE = 0x309C;

		/// <summary>
		/// Value of EGL_SYNC_CL_EVENT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CL_EVENT = 0x30FE;

		/// <summary>
		/// Value of EGL_SYNC_CL_EVENT_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CL_EVENT_COMPLETE = 0x30FF;

		/// <summary>
		/// Value of EGL_SYNC_PRIOR_COMMANDS_COMPLETE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_PRIOR_COMMANDS_COMPLETE = 0x30F0;

		/// <summary>
		/// Value of EGL_SYNC_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_TYPE = 0x30F7;

		/// <summary>
		/// Value of EGL_SYNC_STATUS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_STATUS = 0x30F1;

		/// <summary>
		/// Value of EGL_SYNC_CONDITION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_CONDITION = 0x30F8;

		/// <summary>
		/// Value of EGL_SIGNALED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SIGNALED = 0x30F2;

		/// <summary>
		/// Value of EGL_UNSIGNALED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int UNSIGNALED = 0x30F3;

		/// <summary>
		/// Value of EGL_SYNC_FLUSH_COMMANDS_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		[Log(BitmaskName = "EGLSyncFlagsKHR")]
		public const int SYNC_FLUSH_COMMANDS_BIT = 0x0001;

		/// <summary>
		/// Value of EGL_FOREVER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const ulong FOREVER = 0xFFFFFFFFFFFFF;

		/// <summary>
		/// Value of EGL_TIMEOUT_EXPIRED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int TIMEOUT_EXPIRED = 0x30F5;

		/// <summary>
		/// Value of EGL_CONDITION_SATISFIED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int CONDITION_SATISFIED = 0x30F6;

		/// <summary>
		/// Value of EGL_NO_SYNC symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_SYNC = 0;

		/// <summary>
		/// Value of EGL_SYNC_FENCE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int SYNC_FENCE = 0x30F9;

		/// <summary>
		/// Value of EGL_GL_COLORSPACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_COLORSPACE = 0x309D;

		/// <summary>
		/// Value of EGL_GL_RENDERBUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_RENDERBUFFER = 0x30B9;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_2D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_2D = 0x30B1;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_LEVEL = 0x30BC;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_3D symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_3D = 0x30B2;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_ZOFFSET symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_ZOFFSET = 0x30BD;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_X symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x30B3;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_X symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x30B4;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x30B5;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Y symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x30B6;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_POSITIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x30B7;

		/// <summary>
		/// Value of EGL_GL_TEXTURE_CUBE_MAP_NEGATIVE_Z symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x30B8;

		/// <summary>
		/// Value of EGL_IMAGE_PRESERVED symbol.
		/// </summary>
		[AliasOf("EGL_IMAGE_PRESERVED_KHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public const int IMAGE_PRESERVED = 0x30D2;

		/// <summary>
		/// Value of EGL_NO_IMAGE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public const int NO_IMAGE = 0;

		/// <summary>
		/// Binding for eglCreateSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[AliasOf("eglCreateSync64KHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_cl_event2")]
		public static IntPtr CreateSync(IntPtr dpy, uint type, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateSync != null, "peglCreateSync not implemented");
					retValue = Delegates.peglCreateSync(dpy, type, p_attrib_list);
					LogFunction("eglCreateSync(0x{0}, {1}, {2}) = {3}", dpy.ToString("X8"), type, LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroySync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("eglDestroySyncKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static bool DestroySync(IntPtr dpy, IntPtr sync)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroySync != null, "peglDestroySync not implemented");
			retValue = Delegates.peglDestroySync(dpy, sync);
			LogFunction("eglDestroySync(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), sync.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglClientWaitSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="timeout">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[AliasOf("eglClientWaitSyncKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_fence_sync")]
		[RequiredByFeature("EGL_KHR_reusable_sync")]
		public static int ClientWaitSync(IntPtr dpy, IntPtr sync, int flags, UInt64 timeout)
		{
			int retValue;

			Debug.Assert(Delegates.peglClientWaitSync != null, "peglClientWaitSync not implemented");
			retValue = Delegates.peglClientWaitSync(dpy, sync, flags, timeout);
			LogFunction("eglClientWaitSync(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), sync.ToString("X8"), flags, timeout, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetSyncAttrib.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static bool GetSyncAttrib(IntPtr dpy, IntPtr sync, int attribute, [Out] IntPtr[] value)
		{
			bool retValue;

			unsafe {
				fixed (IntPtr* p_value = value)
				{
					Debug.Assert(Delegates.peglGetSyncAttrib != null, "peglGetSyncAttrib not implemented");
					retValue = Delegates.peglGetSyncAttrib(dpy, sync, attribute, p_value);
					LogFunction("eglGetSyncAttrib(0x{0}, 0x{1}, {2}, {3}) = {4}", dpy.ToString("X8"), sync.ToString("X8"), attribute, LogValue(value), retValue);
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreateImage.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreateImage(IntPtr dpy, IntPtr ctx, uint target, IntPtr buffer, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateImage != null, "peglCreateImage not implemented");
					retValue = Delegates.peglCreateImage(dpy, ctx, target, buffer, p_attrib_list);
					LogFunction("eglCreateImage(0x{0}, 0x{1}, {2}, 0x{3}, {4}) = {5}", dpy.ToString("X8"), ctx.ToString("X8"), target, buffer.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroyImage.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[AliasOf("eglDestroyImageKHR")]
		[RequiredByFeature("EGL_VERSION_1_5")]
		[RequiredByFeature("EGL_KHR_image")]
		[RequiredByFeature("EGL_KHR_image_base")]
		public static bool DestroyImage(IntPtr dpy, IntPtr image)
		{
			bool retValue;

			Debug.Assert(Delegates.peglDestroyImage != null, "peglDestroyImage not implemented");
			retValue = Delegates.peglDestroyImage(dpy, image);
			LogFunction("eglDestroyImage(0x{0}, 0x{1}) = {2}", dpy.ToString("X8"), image.ToString("X8"), retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetPlatformDisplay.
		/// </summary>
		/// <param name="platform">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="native_display">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr GetPlatformDisplay(uint platform, IntPtr native_display, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglGetPlatformDisplay != null, "peglGetPlatformDisplay not implemented");
					retValue = Delegates.peglGetPlatformDisplay(platform, native_display, p_attrib_list);
					LogFunction("eglGetPlatformDisplay({0}, 0x{1}, {2}) = {3}", platform, native_display.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePlatformWindowSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_window">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreatePlatformWindowSurface(IntPtr dpy, IntPtr config, IntPtr native_window, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformWindowSurface != null, "peglCreatePlatformWindowSurface not implemented");
					retValue = Delegates.peglCreatePlatformWindowSurface(dpy, config, native_window, p_attrib_list);
					LogFunction("eglCreatePlatformWindowSurface(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), native_window.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePlatformPixmapSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="native_pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static IntPtr CreatePlatformPixmapSurface(IntPtr dpy, IntPtr config, IntPtr native_pixmap, IntPtr[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePlatformPixmapSurface != null, "peglCreatePlatformPixmapSurface not implemented");
					retValue = Delegates.peglCreatePlatformPixmapSurface(dpy, config, native_pixmap, p_attrib_list);
					LogFunction("eglCreatePlatformPixmapSurface(0x{0}, 0x{1}, 0x{2}, {3}) = {4}", dpy.ToString("X8"), config.ToString("X8"), native_pixmap.ToString("X8"), LogValue(attrib_list), retValue.ToString("X8"));
				}
			}
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglWaitSync.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="sync">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="flags">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_5")]
		public static bool WaitSync(IntPtr dpy, IntPtr sync, int flags)
		{
			bool retValue;

			Debug.Assert(Delegates.peglWaitSync != null, "peglWaitSync not implemented");
			retValue = Delegates.peglWaitSync(dpy, sync, flags);
			LogFunction("eglWaitSync(0x{0}, 0x{1}, {2}) = {3}", dpy.ToString("X8"), sync.ToString("X8"), flags, retValue);
			DebugCheckErrors(retValue);

			return (retValue);
		}

	}

}
