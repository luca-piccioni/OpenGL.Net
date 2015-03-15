
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
		/// Value of GLX_WINDOW_BIT symbol.
		/// </summary>
		[AliasOf("GLX_WINDOW_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint WINDOW_BIT = 0x00000001;

		/// <summary>
		/// Value of GLX_PIXMAP_BIT symbol.
		/// </summary>
		[AliasOf("GLX_PIXMAP_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint PIXMAP_BIT = 0x00000002;

		/// <summary>
		/// Value of GLX_PBUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_PBUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint PBUFFER_BIT = 0x00000004;

		/// <summary>
		/// Value of GLX_RGBA_BIT symbol.
		/// </summary>
		[AliasOf("GLX_RGBA_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint RGBA_BIT = 0x00000001;

		/// <summary>
		/// Value of GLX_COLOR_INDEX_BIT symbol.
		/// </summary>
		[AliasOf("GLX_COLOR_INDEX_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint COLOR_INDEX_BIT = 0x00000002;

		/// <summary>
		/// Value of GLX_PBUFFER_CLOBBER_MASK symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint PBUFFER_CLOBBER_MASK = 0x08000000;

		/// <summary>
		/// Value of GLX_FRONT_LEFT_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_FRONT_LEFT_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint FRONT_LEFT_BUFFER_BIT = 0x00000001;

		/// <summary>
		/// Value of GLX_FRONT_RIGHT_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_FRONT_RIGHT_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint FRONT_RIGHT_BUFFER_BIT = 0x00000002;

		/// <summary>
		/// Value of GLX_BACK_LEFT_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_BACK_LEFT_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint BACK_LEFT_BUFFER_BIT = 0x00000004;

		/// <summary>
		/// Value of GLX_BACK_RIGHT_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_BACK_RIGHT_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint BACK_RIGHT_BUFFER_BIT = 0x00000008;

		/// <summary>
		/// Value of GLX_AUX_BUFFERS_BIT symbol.
		/// </summary>
		[AliasOf("GLX_AUX_BUFFERS_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint AUX_BUFFERS_BIT = 0x00000010;

		/// <summary>
		/// Value of GLX_DEPTH_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_DEPTH_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint DEPTH_BUFFER_BIT = 0x00000020;

		/// <summary>
		/// Value of GLX_STENCIL_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_STENCIL_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint STENCIL_BUFFER_BIT = 0x00000040;

		/// <summary>
		/// Value of GLX_ACCUM_BUFFER_BIT symbol.
		/// </summary>
		[AliasOf("GLX_ACCUM_BUFFER_BIT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint ACCUM_BUFFER_BIT = 0x00000080;

		/// <summary>
		/// Value of GLX_CONFIG_CAVEAT symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int CONFIG_CAVEAT = 0x20;

		/// <summary>
		/// Value of GLX_X_VISUAL_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_X_VISUAL_TYPE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int X_VISUAL_TYPE = 0x22;

		/// <summary>
		/// Value of GLX_TRANSPARENT_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_TYPE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_TYPE = 0x23;

		/// <summary>
		/// Value of GLX_TRANSPARENT_INDEX_VALUE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_INDEX_VALUE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_INDEX_VALUE = 0x24;

		/// <summary>
		/// Value of GLX_TRANSPARENT_RED_VALUE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_RED_VALUE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_RED_VALUE = 0x25;

		/// <summary>
		/// Value of GLX_TRANSPARENT_GREEN_VALUE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_GREEN_VALUE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_GREEN_VALUE = 0x26;

		/// <summary>
		/// Value of GLX_TRANSPARENT_BLUE_VALUE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_BLUE_VALUE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_BLUE_VALUE = 0x27;

		/// <summary>
		/// Value of GLX_TRANSPARENT_ALPHA_VALUE symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_ALPHA_VALUE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_ALPHA_VALUE = 0x28;

		/// <summary>
		/// Value of GLX_DONT_CARE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const uint DONT_CARE = 0xFFFFFFFF;

		/// <summary>
		/// Value of GLX_NONE symbol.
		/// </summary>
		[AliasOf("GLX_NONE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int NONE = 0x8000;

		/// <summary>
		/// Value of GLX_SLOW_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int SLOW_CONFIG = 0x8001;

		/// <summary>
		/// Value of GLX_TRUE_COLOR symbol.
		/// </summary>
		[AliasOf("GLX_TRUE_COLOR_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRUE_COLOR = 0x8002;

		/// <summary>
		/// Value of GLX_DIRECT_COLOR symbol.
		/// </summary>
		[AliasOf("GLX_DIRECT_COLOR_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int DIRECT_COLOR = 0x8003;

		/// <summary>
		/// Value of GLX_PSEUDO_COLOR symbol.
		/// </summary>
		[AliasOf("GLX_PSEUDO_COLOR_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int PSEUDO_COLOR = 0x8004;

		/// <summary>
		/// Value of GLX_STATIC_COLOR symbol.
		/// </summary>
		[AliasOf("GLX_STATIC_COLOR_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int STATIC_COLOR = 0x8005;

		/// <summary>
		/// Value of GLX_GRAY_SCALE symbol.
		/// </summary>
		[AliasOf("GLX_GRAY_SCALE_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int GRAY_SCALE = 0x8006;

		/// <summary>
		/// Value of GLX_STATIC_GRAY symbol.
		/// </summary>
		[AliasOf("GLX_STATIC_GRAY_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int STATIC_GRAY = 0x8007;

		/// <summary>
		/// Value of GLX_TRANSPARENT_RGB symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_RGB_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_RGB = 0x8008;

		/// <summary>
		/// Value of GLX_TRANSPARENT_INDEX symbol.
		/// </summary>
		[AliasOf("GLX_TRANSPARENT_INDEX_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int TRANSPARENT_INDEX = 0x8009;

		/// <summary>
		/// Value of GLX_VISUAL_ID symbol.
		/// </summary>
		[AliasOf("GLX_VISUAL_ID_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int VISUAL_ID = 0x800B;

		/// <summary>
		/// Value of GLX_SCREEN symbol.
		/// </summary>
		[AliasOf("GLX_SCREEN_EXT")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int SCREEN = 0x800C;

		/// <summary>
		/// Value of GLX_NON_CONFORMANT_CONFIG symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int NON_CONFORMANT_CONFIG = 0x800D;

		/// <summary>
		/// Value of GLX_DRAWABLE_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_DRAWABLE_TYPE_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int DRAWABLE_TYPE = 0x8010;

		/// <summary>
		/// Value of GLX_RENDER_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_RENDER_TYPE_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int RENDER_TYPE = 0x8011;

		/// <summary>
		/// Value of GLX_X_RENDERABLE symbol.
		/// </summary>
		[AliasOf("GLX_X_RENDERABLE_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int X_RENDERABLE = 0x8012;

		/// <summary>
		/// Value of GLX_FBCONFIG_ID symbol.
		/// </summary>
		[AliasOf("GLX_FBCONFIG_ID_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int FBCONFIG_ID = 0x8013;

		/// <summary>
		/// Value of GLX_RGBA_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_RGBA_TYPE_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int RGBA_TYPE = 0x8014;

		/// <summary>
		/// Value of GLX_COLOR_INDEX_TYPE symbol.
		/// </summary>
		[AliasOf("GLX_COLOR_INDEX_TYPE_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int COLOR_INDEX_TYPE = 0x8015;

		/// <summary>
		/// Value of GLX_MAX_PBUFFER_WIDTH symbol.
		/// </summary>
		[AliasOf("GLX_MAX_PBUFFER_WIDTH_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int MAX_PBUFFER_WIDTH = 0x8016;

		/// <summary>
		/// Value of GLX_MAX_PBUFFER_HEIGHT symbol.
		/// </summary>
		[AliasOf("GLX_MAX_PBUFFER_HEIGHT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int MAX_PBUFFER_HEIGHT = 0x8017;

		/// <summary>
		/// Value of GLX_MAX_PBUFFER_PIXELS symbol.
		/// </summary>
		[AliasOf("GLX_MAX_PBUFFER_PIXELS_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int MAX_PBUFFER_PIXELS = 0x8018;

		/// <summary>
		/// Value of GLX_PRESERVED_CONTENTS symbol.
		/// </summary>
		[AliasOf("GLX_PRESERVED_CONTENTS_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int PRESERVED_CONTENTS = 0x801B;

		/// <summary>
		/// Value of GLX_LARGEST_PBUFFER symbol.
		/// </summary>
		[AliasOf("GLX_LARGEST_PBUFFER_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int LARGEST_PBUFFER = 0x801C;

		/// <summary>
		/// Value of GLX_WIDTH symbol.
		/// </summary>
		[AliasOf("GLX_WIDTH_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int WIDTH = 0x801D;

		/// <summary>
		/// Value of GLX_HEIGHT symbol.
		/// </summary>
		[AliasOf("GLX_HEIGHT_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int HEIGHT = 0x801E;

		/// <summary>
		/// Value of GLX_EVENT_MASK symbol.
		/// </summary>
		[AliasOf("GLX_EVENT_MASK_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int EVENT_MASK = 0x801F;

		/// <summary>
		/// Value of GLX_DAMAGED symbol.
		/// </summary>
		[AliasOf("GLX_DAMAGED_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int DAMAGED = 0x8020;

		/// <summary>
		/// Value of GLX_SAVED symbol.
		/// </summary>
		[AliasOf("GLX_SAVED_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int SAVED = 0x8021;

		/// <summary>
		/// Value of GLX_WINDOW symbol.
		/// </summary>
		[AliasOf("GLX_WINDOW_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int WINDOW = 0x8022;

		/// <summary>
		/// Value of GLX_PBUFFER symbol.
		/// </summary>
		[AliasOf("GLX_PBUFFER_SGIX")]
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int PBUFFER = 0x8023;

		/// <summary>
		/// Value of GLX_PBUFFER_HEIGHT symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int PBUFFER_HEIGHT = 0x8040;

		/// <summary>
		/// Value of GLX_PBUFFER_WIDTH symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public const int PBUFFER_WIDTH = 0x8041;

		/// <summary>
		/// list all GLX frame buffer configurations for a given screen
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <param name="nelements">
		/// Returns the number of GLXFBConfigs returned.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr GetFBConfigs(IntPtr dpy, int screen, int[] nelements)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXGetFBConfigs != null, "pglXGetFBConfigs not implemented");
					retValue = Delegates.pglXGetFBConfigs(dpy, screen, p_nelements);
					CallLog("glXGetFBConfigs({0}, {1}, {2}) = {3}", dpy, screen, nelements, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// return a list of GLX frame buffer configurations that match the specified attributes
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies a list of attribute/value pairs. The last attribute must be <see cref="Gl.e"/>.
		/// </param>
		/// <param name="nelements">
		/// Returns the number of elements in the list returned by <see cref="Gl.XChooseFBConfig"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr ChooseFBConfig(IntPtr dpy, int screen, int[] attrib_list, int[] nelements)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				fixed (int* p_nelements = nelements)
				{
					Debug.Assert(Delegates.pglXChooseFBConfig != null, "pglXChooseFBConfig not implemented");
					retValue = Delegates.pglXChooseFBConfig(dpy, screen, p_attrib_list, p_nelements);
					CallLog("glXChooseFBConfig({0}, {1}, {2}, {3}) = {4}", dpy, screen, attrib_list, nelements, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// return information about a GLX frame buffer configuration
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies the GLX frame buffer configuration to be queried.
		/// </param>
		/// <param name="attribute">
		/// Specifies the attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static int GetFBConfigAttrib(IntPtr dpy, IntPtr config, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXGetFBConfigAttrib != null, "pglXGetFBConfigAttrib not implemented");
					retValue = Delegates.pglXGetFBConfigAttrib(dpy, config, attribute, p_value);
					CallLog("glXGetFBConfigAttrib({0}, {1}, {2}, {3}) = {4}", dpy, config, attribute, value, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// return visual that is associated with the frame buffer configuration
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies the GLX frame buffer configuration.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static Glx.XVisualInfo GetVisualFromFBConfig(IntPtr dpy, IntPtr config)
		{
			Glx.XVisualInfo retValue;

			Debug.Assert(Delegates.pglXGetVisualFromFBConfig != null, "pglXGetVisualFromFBConfig not implemented");
			retValue = Delegates.pglXGetVisualFromFBConfig(dpy, config);
			CallLog("glXGetVisualFromFBConfig({0}, {1}) = {2}", dpy, config, retValue);

			return (retValue);
		}

		/// <summary>
		/// create an on-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies a GLXFBConfig structure with the desired attributes for the window.
		/// </param>
		/// <param name="win">
		/// Specifies the X window to be used as the rendering area.
		/// </param>
		/// <param name="attrib_list">
		/// Currently unused. This must be set to <see cref="Gl.L"/> or be an empty list (i.e., one in which the first element is 
		/// <see cref="Gl.e"/>).
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr CreateWindow(IntPtr dpy, IntPtr config, IntPtr win, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXCreateWindow != null, "pglXCreateWindow not implemented");
					retValue = Delegates.pglXCreateWindow(dpy, config, win, p_attrib_list);
					CallLog("glXCreateWindow({0}, {1}, {2}, {3}) = {4}", dpy, config, win, attrib_list, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// destroy an on-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="win">
		/// Specifies the GLXWindow to be destroyed.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void DestroyWindow(IntPtr dpy, IntPtr win)
		{
			Debug.Assert(Delegates.pglXDestroyWindow != null, "pglXDestroyWindow not implemented");
			Delegates.pglXDestroyWindow(dpy, win);
			CallLog("glXDestroyWindow({0}, {1})", dpy, win);
		}

		/// <summary>
		/// create an off-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies a GLXFBConfig structure with the desired attributes for the window.
		/// </param>
		/// <param name="pixmap">
		/// Specifies the X pixmap to be used as the rendering area.
		/// </param>
		/// <param name="attrib_list">
		/// Currently unused. This must be set to <see cref="Gl.L"/> or be an empty list (i.e., one in which the first element is 
		/// <see cref="Gl.e"/>).
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr CreatePixmap(IntPtr dpy, IntPtr config, IntPtr pixmap, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXCreatePixmap != null, "pglXCreatePixmap not implemented");
					retValue = Delegates.pglXCreatePixmap(dpy, config, pixmap, p_attrib_list);
					CallLog("glXCreatePixmap({0}, {1}, {2}, {3}) = {4}", dpy, config, pixmap, attrib_list, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// destroy an off-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="pixmap">
		/// Specifies the GLXPixmap to be destroyed.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void DestroyPixmap(IntPtr dpy, IntPtr pixmap)
		{
			Debug.Assert(Delegates.pglXDestroyPixmap != null, "pglXDestroyPixmap not implemented");
			Delegates.pglXDestroyPixmap(dpy, pixmap);
			CallLog("glXDestroyPixmap({0}, {1})", dpy, pixmap);
		}

		/// <summary>
		/// create an off-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies a GLXFBConfig structure with the desired attributes for the window.
		/// </param>
		/// <param name="attrib_list">
		/// Specifies a list of attribute value pairs, which must be terminated with <see cref="Gl.e"/> or <see cref="Gl.L"/>. 
		/// Accepted attributes are <see cref="Gl._PBUFFER_WIDTH"/>, <see cref="Gl._PBUFFER_HEIGHT"/>, <see 
		/// cref="Gl._PRESERVED_CONTENTS"/>, and <see cref="Gl._LARGEST_PBUFFER"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr CreatePbuffer(IntPtr dpy, IntPtr config, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXCreatePbuffer != null, "pglXCreatePbuffer not implemented");
					retValue = Delegates.pglXCreatePbuffer(dpy, config, p_attrib_list);
					CallLog("glXCreatePbuffer({0}, {1}, {2}) = {3}", dpy, config, attrib_list, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// destroy an off-screen rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="pbuf">
		/// Specifies the GLXPbuffer to be destroyed.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void DestroyPbuffer(IntPtr dpy, IntPtr pbuf)
		{
			Debug.Assert(Delegates.pglXDestroyPbuffer != null, "pglXDestroyPbuffer not implemented");
			Delegates.pglXDestroyPbuffer(dpy, pbuf);
			CallLog("glXDestroyPbuffer({0}, {1})", dpy, pbuf);
		}

		/// <summary>
		/// returns an attribute assoicated with a GLX drawable
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="draw">
		/// Specifies the GLX drawable to be queried.
		/// </param>
		/// <param name="attribute">
		/// Specifies the attribute to be returned. Must be one of <see cref="Gl._WIDTH"/>, <see cref="Gl._HEIGHT"/>, <see 
		/// cref="Gl._PRESERVED_CONTENTS"/>, <see cref="Gl._LARGEST_PBUFFER"/>, or <see cref="Gl._FBCONFIG_ID"/>.
		/// </param>
		/// <param name="value">
		/// Contains the return value for <paramref name="attribute"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void QueryDrawable(IntPtr dpy, IntPtr draw, int attribute, IntPtr value)
		{
			Debug.Assert(Delegates.pglXQueryDrawable != null, "pglXQueryDrawable not implemented");
			Delegates.pglXQueryDrawable(dpy, draw, attribute, value);
			CallLog("glXQueryDrawable({0}, {1}, {2}, {3})", dpy, draw, attribute, value);
		}

		/// <summary>
		/// create a new GLX rendering context
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="config">
		/// Specifies the GLXFBConfig structure with the desired attributes for the context.
		/// </param>
		/// <param name="render_type">
		/// Specifies the type of the context to be created. Must be one of <see cref="Gl._RGBA_TYPE"/> or <see 
		/// cref="Gl._COLOR_INDEX_TYPE"/>.
		/// </param>
		/// <param name="share_list">
		/// Specifies the context with which to share display lists. <see cref="Gl.L"/> indicates that no sharing is to take place.
		/// </param>
		/// <param name="direct">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr CreateNewContext(IntPtr dpy, IntPtr config, int render_type, IntPtr share_list, bool direct)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateNewContext != null, "pglXCreateNewContext not implemented");
			retValue = Delegates.pglXCreateNewContext(dpy, config, render_type, share_list, direct);
			CallLog("glXCreateNewContext({0}, {1}, {2}, {3}, {4}) = {5}", dpy, config, render_type, share_list, direct, retValue);

			return (retValue);
		}

		/// <summary>
		/// attach a GLX context to a GLX drawable
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="draw">
		/// Specifies a GLX drawable to render into. Must be an XID representing a GLXWindow, GLXPixmap, or GLXPbuffer.
		/// </param>
		/// <param name="read">
		/// Specifies a GLX drawable to read from. Must be an XID representing a GLXWindow, GLXPixmap, or GLXPbuffer.
		/// </param>
		/// <param name="ctx">
		/// Specifies the GLX context to be bound to <paramref name="read"/> and <paramref name="ctx"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static bool MakeContextCurrent(IntPtr dpy, IntPtr draw, IntPtr read, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXMakeContextCurrent != null, "pglXMakeContextCurrent not implemented");
			retValue = Delegates.pglXMakeContextCurrent(dpy, draw, read, ctx);
			CallLog("glXMakeContextCurrent({0}, {1}, {2}, {3}) = {4}", dpy, draw, read, ctx, retValue);

			return (retValue);
		}

		/// <summary>
		/// return the current drawable
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static IntPtr GetCurrentReadDrawable()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentReadDrawable != null, "pglXGetCurrentReadDrawable not implemented");
			retValue = Delegates.pglXGetCurrentReadDrawable();
			CallLog("glXGetCurrentReadDrawable() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// query context information
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="ctx">
		/// Specifies a GLX rendering context.
		/// </param>
		/// <param name="attribute">
		/// Specifies that a context parameter should be retrieved. Must be one of <see cref="Gl._FBCONFIG_ID"/>, <see 
		/// cref="Gl._RENDER_TYPE"/>, or <see cref="Gl._SCREEN"/>.
		/// </param>
		/// <param name="value">
		/// Contains the return value for <paramref name="attribute"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static int QueryContext(IntPtr dpy, IntPtr ctx, int attribute, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXQueryContext != null, "pglXQueryContext not implemented");
					retValue = Delegates.pglXQueryContext(dpy, ctx, attribute, p_value);
					CallLog("glXQueryContext({0}, {1}, {2}, {3}) = {4}", dpy, ctx, attribute, value, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// select GLX events for a window or a GLX pixel buffer
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="draw">
		/// Specifies a GLX drawable. Must be a GLX pixel buffer or a window.
		/// </param>
		/// <param name="event_mask">
		/// Specifies the events to be returned for <paramref name="draw"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void SelectEvent(IntPtr dpy, IntPtr draw, UInt32 event_mask)
		{
			Debug.Assert(Delegates.pglXSelectEvent != null, "pglXSelectEvent not implemented");
			Delegates.pglXSelectEvent(dpy, draw, event_mask);
			CallLog("glXSelectEvent({0}, {1}, {2})", dpy, draw, event_mask);
		}

		/// <summary>
		/// returns GLX events that are selected for a window or a GLX pixel buffer
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="draw">
		/// Specifies a GLX drawable. Must be a GLX pixel buffer or a window.
		/// </param>
		/// <param name="event_mask">
		/// Returns the events that are selected for <paramref name="draw"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_3")]
		public static void GetSelectedEvent(IntPtr dpy, IntPtr draw, UInt32[] event_mask)
		{
			unsafe {
				fixed (UInt32* p_event_mask = event_mask)
				{
					Debug.Assert(Delegates.pglXGetSelectedEvent != null, "pglXGetSelectedEvent not implemented");
					Delegates.pglXGetSelectedEvent(dpy, draw, p_event_mask);
					CallLog("glXGetSelectedEvent({0}, {1}, {2})", dpy, draw, event_mask);
				}
			}
		}

	}

}
