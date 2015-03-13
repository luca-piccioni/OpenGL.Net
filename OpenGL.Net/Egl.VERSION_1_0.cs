
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
		/// Value of EGL_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int ALPHA_SIZE = 0x3021;

		/// <summary>
		/// Value of EGL_BAD_ACCESS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ACCESS = 0x3002;

		/// <summary>
		/// Value of EGL_BAD_ALLOC symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ALLOC = 0x3003;

		/// <summary>
		/// Value of EGL_BAD_ATTRIBUTE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_ATTRIBUTE = 0x3004;

		/// <summary>
		/// Value of EGL_BAD_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CONFIG = 0x3005;

		/// <summary>
		/// Value of EGL_BAD_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CONTEXT = 0x3006;

		/// <summary>
		/// Value of EGL_BAD_CURRENT_SURFACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_CURRENT_SURFACE = 0x3007;

		/// <summary>
		/// Value of EGL_BAD_DISPLAY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_DISPLAY = 0x3008;

		/// <summary>
		/// Value of EGL_BAD_MATCH symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_MATCH = 0x3009;

		/// <summary>
		/// Value of EGL_BAD_NATIVE_PIXMAP symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_NATIVE_PIXMAP = 0x300A;

		/// <summary>
		/// Value of EGL_BAD_NATIVE_WINDOW symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_NATIVE_WINDOW = 0x300B;

		/// <summary>
		/// Value of EGL_BAD_PARAMETER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_PARAMETER = 0x300C;

		/// <summary>
		/// Value of EGL_BAD_SURFACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BAD_SURFACE = 0x300D;

		/// <summary>
		/// Value of EGL_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BLUE_SIZE = 0x3022;

		/// <summary>
		/// Value of EGL_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int BUFFER_SIZE = 0x3020;

		/// <summary>
		/// Value of EGL_CONFIG_CAVEAT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CONFIG_CAVEAT = 0x3027;

		/// <summary>
		/// Value of EGL_CONFIG_ID symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CONFIG_ID = 0x3028;

		/// <summary>
		/// Value of EGL_CORE_NATIVE_ENGINE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int CORE_NATIVE_ENGINE = 0x305B;

		/// <summary>
		/// Value of EGL_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DEPTH_SIZE = 0x3025;

		/// <summary>
		/// Value of EGL_DONT_CARE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DONT_CARE = -1;

		/// <summary>
		/// Value of EGL_DRAW symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int DRAW = 0x3059;

		/// <summary>
		/// Value of EGL_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int EXTENSIONS = 0x3055;

		/// <summary>
		/// Value of EGL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int FALSE = 0;

		/// <summary>
		/// Value of EGL_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int GREEN_SIZE = 0x3023;

		/// <summary>
		/// Value of EGL_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int HEIGHT = 0x3056;

		/// <summary>
		/// Value of EGL_LARGEST_PBUFFER symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int LARGEST_PBUFFER = 0x3058;

		/// <summary>
		/// Value of EGL_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int LEVEL = 0x3029;

		/// <summary>
		/// Value of EGL_MAX_PBUFFER_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_HEIGHT = 0x302A;

		/// <summary>
		/// Value of EGL_MAX_PBUFFER_PIXELS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_PIXELS = 0x302B;

		/// <summary>
		/// Value of EGL_MAX_PBUFFER_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int MAX_PBUFFER_WIDTH = 0x302C;

		/// <summary>
		/// Value of EGL_NATIVE_RENDERABLE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_RENDERABLE = 0x302D;

		/// <summary>
		/// Value of EGL_NATIVE_VISUAL_ID symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_VISUAL_ID = 0x302E;

		/// <summary>
		/// Value of EGL_NATIVE_VISUAL_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NATIVE_VISUAL_TYPE = 0x302F;

		/// <summary>
		/// Value of EGL_NONE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NONE = 0x3038;

		/// <summary>
		/// Value of EGL_NON_CONFORMANT_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NON_CONFORMANT_CONFIG = 0x3051;

		/// <summary>
		/// Value of EGL_NOT_INITIALIZED symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NOT_INITIALIZED = 0x3001;

		/// <summary>
		/// Value of EGL_NO_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_CONTEXT = 0;

		/// <summary>
		/// Value of EGL_NO_DISPLAY symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_DISPLAY = 0;

		/// <summary>
		/// Value of EGL_NO_SURFACE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int NO_SURFACE = 0;

		/// <summary>
		/// Value of EGL_PBUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int PBUFFER_BIT = 0x0001;

		/// <summary>
		/// Value of EGL_PIXMAP_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int PIXMAP_BIT = 0x0002;

		/// <summary>
		/// Value of EGL_READ symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int READ = 0x305A;

		/// <summary>
		/// Value of EGL_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int RED_SIZE = 0x3024;

		/// <summary>
		/// Value of EGL_SAMPLES symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SAMPLES = 0x3031;

		/// <summary>
		/// Value of EGL_SAMPLE_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SAMPLE_BUFFERS = 0x3032;

		/// <summary>
		/// Value of EGL_SLOW_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SLOW_CONFIG = 0x3050;

		/// <summary>
		/// Value of EGL_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int STENCIL_SIZE = 0x3026;

		/// <summary>
		/// Value of EGL_SUCCESS symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SUCCESS = 0x3000;

		/// <summary>
		/// Value of EGL_SURFACE_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int SURFACE_TYPE = 0x3033;

		/// <summary>
		/// Value of EGL_TRANSPARENT_BLUE_VALUE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_BLUE_VALUE = 0x3035;

		/// <summary>
		/// Value of EGL_TRANSPARENT_GREEN_VALUE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_GREEN_VALUE = 0x3036;

		/// <summary>
		/// Value of EGL_TRANSPARENT_RED_VALUE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_RED_VALUE = 0x3037;

		/// <summary>
		/// Value of EGL_TRANSPARENT_RGB symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_RGB = 0x3052;

		/// <summary>
		/// Value of EGL_TRANSPARENT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRANSPARENT_TYPE = 0x3034;

		/// <summary>
		/// Value of EGL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int TRUE = 1;

		/// <summary>
		/// Value of EGL_VENDOR symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int VENDOR = 0x3053;

		/// <summary>
		/// Value of EGL_VERSION symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int VERSION = 0x3054;

		/// <summary>
		/// Value of EGL_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int WIDTH = 0x3057;

		/// <summary>
		/// Value of EGL_WINDOW_BIT symbol.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public const int WINDOW_BIT = 0x0004;

		/// <summary>
		/// Binding for eglChooseConfig.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="configs">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="config_size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_config">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr ChooseConfig(IntPtr dpy, int[] attrib_list, IntPtr[] configs, int config_size, int[] num_config)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				fixed (IntPtr* p_configs = configs)
				fixed (int* p_num_config = num_config)
				{
					Debug.Assert(Delegates.peglChooseConfig != null, "peglChooseConfig not implemented");
					retValue = Delegates.peglChooseConfig(dpy, p_attrib_list, p_configs, config_size, p_num_config);
					CallLog("eglChooseConfig({0}, {1}, {2}, {3}, {4}) = {5}", dpy, attrib_list, configs, config_size, num_config, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCopyBuffers.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="target">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CopyBuffers(IntPtr dpy, IntPtr surface, IntPtr target)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglCopyBuffers != null, "peglCopyBuffers not implemented");
			retValue = Delegates.peglCopyBuffers(dpy, surface, target);
			CallLog("eglCopyBuffers({0}, {1}, {2}) = {3}", dpy, surface, target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreateContext.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="share_context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreateContext(IntPtr dpy, IntPtr config, IntPtr share_context, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateContext != null, "peglCreateContext not implemented");
					retValue = Delegates.peglCreateContext(dpy, config, share_context, p_attrib_list);
					CallLog("eglCreateContext({0}, {1}, {2}, {3}) = {4}", dpy, config, share_context, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePbufferSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreatePbufferSurface(IntPtr dpy, IntPtr config, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePbufferSurface != null, "peglCreatePbufferSurface not implemented");
					retValue = Delegates.peglCreatePbufferSurface(dpy, config, p_attrib_list);
					CallLog("eglCreatePbufferSurface({0}, {1}, {2}) = {3}", dpy, config, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreatePixmapSurface.
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
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreatePixmapSurface(IntPtr dpy, IntPtr config, IntPtr pixmap, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreatePixmapSurface != null, "peglCreatePixmapSurface not implemented");
					retValue = Delegates.peglCreatePixmapSurface(dpy, config, pixmap, p_attrib_list);
					CallLog("eglCreatePixmapSurface({0}, {1}, {2}, {3}) = {4}", dpy, config, pixmap, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglCreateWindowSurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="win">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr CreateWindowSurface(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.peglCreateWindowSurface != null, "peglCreateWindowSurface not implemented");
					retValue = Delegates.peglCreateWindowSurface(dpy, config, win, p_attrib_list);
					CallLog("eglCreateWindowSurface({0}, {1}, {2}, {3}) = {4}", dpy, config, win, attrib_list, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroyContext.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr DestroyContext(IntPtr dpy, IntPtr ctx)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglDestroyContext != null, "peglDestroyContext not implemented");
			retValue = Delegates.peglDestroyContext(dpy, ctx);
			CallLog("eglDestroyContext({0}, {1}) = {2}", dpy, ctx, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglDestroySurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr DestroySurface(IntPtr dpy, IntPtr surface)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglDestroySurface != null, "peglDestroySurface not implemented");
			retValue = Delegates.peglDestroySurface(dpy, surface);
			CallLog("eglDestroySurface({0}, {1}) = {2}", dpy, surface, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetConfigAttrib.
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
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglGetConfigAttrib != null, "peglGetConfigAttrib not implemented");
					retValue = Delegates.peglGetConfigAttrib(dpy, config, attribute, p_value);
					CallLog("eglGetConfigAttrib({0}, {1}, {2}, {3}) = {4}", dpy, config, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetConfigs.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="configs">
		/// A <see cref="T:IntPtr[]"/>.
		/// </param>
		/// <param name="config_size">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="num_config">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetConfigs(IntPtr dpy, IntPtr[] configs, int config_size, int[] num_config)
		{
			IntPtr retValue;

			unsafe {
				fixed (IntPtr* p_configs = configs)
				fixed (int* p_num_config = num_config)
				{
					Debug.Assert(Delegates.peglGetConfigs != null, "peglGetConfigs not implemented");
					retValue = Delegates.peglGetConfigs(dpy, p_configs, config_size, p_num_config);
					CallLog("eglGetConfigs({0}, {1}, {2}, {3}) = {4}", dpy, configs, config_size, num_config, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetCurrentDisplay.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetCurrentDisplay()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentDisplay != null, "peglGetCurrentDisplay not implemented");
			retValue = Delegates.peglGetCurrentDisplay();
			CallLog("eglGetCurrentDisplay() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetCurrentSurface.
		/// </summary>
		/// <param name="readdraw">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetCurrentSurface(int readdraw)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetCurrentSurface != null, "peglGetCurrentSurface not implemented");
			retValue = Delegates.peglGetCurrentSurface(readdraw);
			CallLog("eglGetCurrentSurface({0}) = {1}", readdraw, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetDisplay.
		/// </summary>
		/// <param name="display_id">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetDisplay(IntPtr display_id)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetDisplay != null, "peglGetDisplay not implemented");
			retValue = Delegates.peglGetDisplay(display_id);
			CallLog("eglGetDisplay({0}) = {1}", display_id, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetError.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static int GetError()
		{
			int retValue;

			Debug.Assert(Delegates.peglGetError != null, "peglGetError not implemented");
			retValue = Delegates.peglGetError();
			CallLog("eglGetError() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for eglGetProcAddress.
		/// </summary>
		/// <param name="procname">
		/// A <see cref="T:string"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr GetProcAddress(string procname)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglGetProcAddress != null, "peglGetProcAddress not implemented");
			retValue = Delegates.peglGetProcAddress(procname);
			CallLog("eglGetProcAddress({0}) = {1}", procname, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglInitialize.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="major">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="minor">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr Initialize(IntPtr dpy, int[] major, int[] minor)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_major = major)
				fixed (int* p_minor = minor)
				{
					Debug.Assert(Delegates.peglInitialize != null, "peglInitialize not implemented");
					retValue = Delegates.peglInitialize(dpy, p_major, p_minor);
					CallLog("eglInitialize({0}, {1}, {2}) = {3}", dpy, major, minor, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglMakeCurrent.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="draw">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="read">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr MakeCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglMakeCurrent != null, "peglMakeCurrent not implemented");
			retValue = Delegates.peglMakeCurrent(dpy, draw, read, ctx);
			CallLog("eglMakeCurrent({0}, {1}, {2}, {3}) = {4}", dpy, draw, read, ctx, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryContext.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr QueryContext(IntPtr dpy, IntPtr ctx, int attribute, int[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQueryContext != null, "peglQueryContext not implemented");
					retValue = Delegates.peglQueryContext(dpy, ctx, attribute, p_value);
					CallLog("eglQueryContext({0}, {1}, {2}, {3}) = {4}", dpy, ctx, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQueryString.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="name">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static string QueryString(IntPtr dpy, int name)
		{
			string retValue;

			Debug.Assert(Delegates.peglQueryString != null, "peglQueryString not implemented");
			retValue = Delegates.peglQueryString(dpy, name);
			CallLog("eglQueryString({0}, {1}) = {2}", dpy, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglQuerySurface.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="surface">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="attribute">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="value">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr QuerySurface(IntPtr dpy, IntPtr surface, int attribute, int[] value)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.peglQuerySurface != null, "peglQuerySurface not implemented");
					retValue = Delegates.peglQuerySurface(dpy, surface, attribute, p_value);
					CallLog("eglQuerySurface({0}, {1}, {2}, {3}) = {4}", dpy, surface, attribute, value, retValue);
				}
			}
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglTerminate.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr Terminate(IntPtr dpy)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglTerminate != null, "peglTerminate not implemented");
			retValue = Delegates.peglTerminate(dpy);
			CallLog("eglTerminate({0}) = {1}", dpy, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglWaitGL.
		/// </summary>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr WaitGL()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglWaitGL != null, "peglWaitGL not implemented");
			retValue = Delegates.peglWaitGL();
			CallLog("eglWaitGL() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for eglWaitNative.
		/// </summary>
		/// <param name="engine">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("EGL_VERSION_1_0")]
		public static IntPtr WaitNative(int engine)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.peglWaitNative != null, "peglWaitNative not implemented");
			retValue = Delegates.peglWaitNative(engine);
			CallLog("eglWaitNative({0}) = {1}", engine, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}
