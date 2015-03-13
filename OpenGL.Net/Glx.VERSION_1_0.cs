
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
		/// Value of GLX_EXTENSION_NAME symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const string EXTENSION_NAME = "GLX";

		/// <summary>
		/// Value of GLX_PbufferClobber symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int PbufferClobber = 0;

		/// <summary>
		/// Value of GLX_BufferSwapComplete symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BufferSwapComplete = 1;

		/// <summary>
		/// Value of __GLX_NUMBER_EVENTS symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int __GLX_NUMBER_EVENTS = 17;

		/// <summary>
		/// Value of GLX_BAD_SCREEN symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_SCREEN = 1;

		/// <summary>
		/// Value of GLX_BAD_ATTRIBUTE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_ATTRIBUTE = 2;

		/// <summary>
		/// Value of GLX_NO_EXTENSION symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int NO_EXTENSION = 3;

		/// <summary>
		/// Value of GLX_BAD_VISUAL symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_VISUAL = 4;

		/// <summary>
		/// Value of GLX_BAD_CONTEXT symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_CONTEXT = 5;

		/// <summary>
		/// Value of GLX_BAD_VALUE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_VALUE = 6;

		/// <summary>
		/// Value of GLX_BAD_ENUM symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BAD_ENUM = 7;

		/// <summary>
		/// Value of GLX_USE_GL symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int USE_GL = 1;

		/// <summary>
		/// Value of GLX_BUFFER_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BUFFER_SIZE = 2;

		/// <summary>
		/// Value of GLX_LEVEL symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int LEVEL = 3;

		/// <summary>
		/// Value of GLX_RGBA symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int RGBA = 4;

		/// <summary>
		/// Value of GLX_DOUBLEBUFFER symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int DOUBLEBUFFER = 5;

		/// <summary>
		/// Value of GLX_STEREO symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int STEREO = 6;

		/// <summary>
		/// Value of GLX_AUX_BUFFERS symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int AUX_BUFFERS = 7;

		/// <summary>
		/// Value of GLX_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int RED_SIZE = 8;

		/// <summary>
		/// Value of GLX_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int GREEN_SIZE = 9;

		/// <summary>
		/// Value of GLX_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BLUE_SIZE = 10;

		/// <summary>
		/// Value of GLX_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ALPHA_SIZE = 11;

		/// <summary>
		/// Value of GLX_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int DEPTH_SIZE = 12;

		/// <summary>
		/// Value of GLX_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int STENCIL_SIZE = 13;

		/// <summary>
		/// Value of GLX_ACCUM_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_RED_SIZE = 14;

		/// <summary>
		/// Value of GLX_ACCUM_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_GREEN_SIZE = 15;

		/// <summary>
		/// Value of GLX_ACCUM_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_BLUE_SIZE = 16;

		/// <summary>
		/// Value of GLX_ACCUM_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_ALPHA_SIZE = 17;

		/// <summary>
		/// return a visual that matches specified attributes
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="screen">
		/// Specifies the screen number.
		/// </param>
		/// <param name="attribList">
		/// Specifies a list of boolean attributes and integer attribute/value pairs. The last attribute must be <see cref="Gl.e"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static Glx.XVisualInfo ChooseVisual(IntPtr dpy, int screen, int[] attribList)
		{
			Glx.XVisualInfo retValue;

			unsafe {
				fixed (int* p_attribList = attribList)
				{
					Debug.Assert(Delegates.pglXChooseVisual != null, "pglXChooseVisual not implemented");
					retValue = Delegates.pglXChooseVisual(dpy, screen, p_attribList);
					CallLog("glXChooseVisual({0}, {1}, {2}) = {3}", dpy, screen, attribList, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// create a new GLX rendering context
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="vis">
		/// Specifies the visual that defines the frame buffer resources available to the rendering context. It is a pointer to an 
		/// <see cref="Gl.sualInfo"/> structure, not a visual ID or a pointer to a <see cref="Gl.ual"/>.
		/// </param>
		/// <param name="shareList">
		/// Specifies the context with which to share display lists. <see cref="Gl.L"/> indicates that no sharing is to take place.
		/// </param>
		/// <param name="direct">
		/// Specifies whether rendering is to be done with a direct connection to the graphics system if possible (<see 
		/// cref="Gl.e"/>) or through the X server (<see cref="Gl.se"/>).
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr CreateContext(IntPtr dpy, Glx.XVisualInfo vis, IntPtr shareList, bool direct)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateContext != null, "pglXCreateContext not implemented");
			retValue = Delegates.pglXCreateContext(dpy, vis, shareList, direct);
			CallLog("glXCreateContext({0}, {1}, {2}, {3}) = {4}", dpy, vis, shareList, direct, retValue);

			return (retValue);
		}

		/// <summary>
		/// destroy a GLX context
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="ctx">
		/// Specifies the GLX context to be destroyed.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void DestroyContext(IntPtr dpy, IntPtr ctx)
		{
			Debug.Assert(Delegates.pglXDestroyContext != null, "pglXDestroyContext not implemented");
			Delegates.pglXDestroyContext(dpy, ctx);
			CallLog("glXDestroyContext({0}, {1})", dpy, ctx);
		}

		/// <summary>
		/// attach a GLX context to a window or a GLX pixmap
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="drawable">
		/// Specifies a GLX drawable. Must be either an X window ID or a GLX pixmap ID.
		/// </param>
		/// <param name="ctx">
		/// Specifies a GLX rendering context that is to be attached to <paramref name="drawable"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static bool MakeCurrent(IntPtr dpy, IntPtr drawable, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXMakeCurrent != null, "pglXMakeCurrent not implemented");
			retValue = Delegates.pglXMakeCurrent(dpy, drawable, ctx);
			CallLog("glXMakeCurrent({0}, {1}, {2}) = {3}", dpy, drawable, ctx, retValue);

			return (retValue);
		}

		/// <summary>
		/// copy state from one rendering context to another
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="src">
		/// Specifies the source context.
		/// </param>
		/// <param name="dst">
		/// Specifies the destination context.
		/// </param>
		/// <param name="mask">
		/// Specifies which portions of <paramref name="src"/> state are to be copied to <paramref name="dst"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void CopyContext(IntPtr dpy, IntPtr src, IntPtr dst, UInt32 mask)
		{
			Debug.Assert(Delegates.pglXCopyContext != null, "pglXCopyContext not implemented");
			Delegates.pglXCopyContext(dpy, src, dst, mask);
			CallLog("glXCopyContext({0}, {1}, {2}, {3})", dpy, src, dst, mask);
		}

		/// <summary>
		/// exchange front and back buffers
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="drawable">
		/// Specifies the drawable whose buffers are to be swapped.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void SwapBuffers(IntPtr dpy, IntPtr drawable)
		{
			Debug.Assert(Delegates.pglXSwapBuffers != null, "pglXSwapBuffers not implemented");
			Delegates.pglXSwapBuffers(dpy, drawable);
			CallLog("glXSwapBuffers({0}, {1})", dpy, drawable);
		}

		/// <summary>
		/// create an off-screen GLX rendering area
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="pixmap">
		/// Specifies the X pixmap that will be used as the front left color buffer of the off-screen rendering area.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr CreateGLXPixmap(IntPtr dpy, Glx.XVisualInfo visual, IntPtr pixmap)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXCreateGLXPixmap != null, "pglXCreateGLXPixmap not implemented");
			retValue = Delegates.pglXCreateGLXPixmap(dpy, visual, pixmap);
			CallLog("glXCreateGLXPixmap({0}, {1}, {2}) = {3}", dpy, visual, pixmap, retValue);

			return (retValue);
		}

		/// <summary>
		/// destroy a GLX pixmap
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="pixmap">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void DestroyGLXPixmap(IntPtr dpy, IntPtr pixmap)
		{
			Debug.Assert(Delegates.pglXDestroyGLXPixmap != null, "pglXDestroyGLXPixmap not implemented");
			Delegates.pglXDestroyGLXPixmap(dpy, pixmap);
			CallLog("glXDestroyGLXPixmap({0}, {1})", dpy, pixmap);
		}

		/// <summary>
		/// indicate whether the GLX extension is supported
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="errorb">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="event">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static bool Query(IntPtr dpy, int[] errorb, int[] @event)
		{
			bool retValue;

			unsafe {
				fixed (int* p_errorb = errorb)
				fixed (int* p_event = @event)
				{
					Debug.Assert(Delegates.pglXQueryExtension != null, "pglXQueryExtension not implemented");
					retValue = Delegates.pglXQueryExtension(dpy, p_errorb, p_event);
					CallLog("glXQueryExtension({0}, {1}, {2}) = {3}", dpy, errorb, @event, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// return the version numbers of the GLX extension
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="maj">
		/// A <see cref="T:int[]"/>.
		/// </param>
		/// <param name="min">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static bool QueryVersion(IntPtr dpy, int[] maj, int[] min)
		{
			bool retValue;

			unsafe {
				fixed (int* p_maj = maj)
				fixed (int* p_min = min)
				{
					Debug.Assert(Delegates.pglXQueryVersion != null, "pglXQueryVersion not implemented");
					retValue = Delegates.pglXQueryVersion(dpy, p_maj, p_min);
					CallLog("glXQueryVersion({0}, {1}, {2}) = {3}", dpy, maj, min, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// indicate whether direct rendering is enabled
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="ctx">
		/// Specifies the GLX context that is being queried.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static bool IsDirect(IntPtr dpy, IntPtr ctx)
		{
			bool retValue;

			Debug.Assert(Delegates.pglXIsDirect != null, "pglXIsDirect not implemented");
			retValue = Delegates.pglXIsDirect(dpy, ctx);
			CallLog("glXIsDirect({0}, {1}) = {2}", dpy, ctx, retValue);

			return (retValue);
		}

		/// <summary>
		/// return information about GLX visuals
		/// </summary>
		/// <param name="dpy">
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name="visual">
		/// A <see cref="T:Glx.XVisualInfo"/>.
		/// </param>
		/// <param name="attrib">
		/// Specifies the visual attribute to be returned.
		/// </param>
		/// <param name="value">
		/// Returns the requested value.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static int GetConfig(IntPtr dpy, Glx.XVisualInfo visual, int attrib, int[] value)
		{
			int retValue;

			unsafe {
				fixed (int* p_value = value)
				{
					Debug.Assert(Delegates.pglXGetConfig != null, "pglXGetConfig not implemented");
					retValue = Delegates.pglXGetConfig(dpy, visual, attrib, p_value);
					CallLog("glXGetConfig({0}, {1}, {2}, {3}) = {4}", dpy, visual, attrib, value, retValue);
				}
			}

			return (retValue);
		}

		/// <summary>
		/// return the current context
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr GetCurrentContext()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentContext != null, "pglXGetCurrentContext not implemented");
			retValue = Delegates.pglXGetCurrentContext();
			CallLog("glXGetCurrentContext() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// return the current drawable
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static IntPtr GetCurrentDrawable()
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglXGetCurrentDrawable != null, "pglXGetCurrentDrawable not implemented");
			retValue = Delegates.pglXGetCurrentDrawable();
			CallLog("glXGetCurrentDrawable() = {0}", retValue);

			return (retValue);
		}

		/// <summary>
		/// complete GL execution prior to subsequent X calls
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void WaitGL()
		{
			Debug.Assert(Delegates.pglXWaitGL != null, "pglXWaitGL not implemented");
			Delegates.pglXWaitGL();
			CallLog("glXWaitGL()");
		}

		/// <summary>
		/// complete X execution prior to subsequent GL calls
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void WaitX()
		{
			Debug.Assert(Delegates.pglXWaitX != null, "pglXWaitX not implemented");
			Delegates.pglXWaitX();
			CallLog("glXWaitX()");
		}

		/// <summary>
		/// create bitmap display lists from an X font
		/// </summary>
		/// <param name="font">
		/// Specifies the font from which character glyphs are to be taken.
		/// </param>
		/// <param name="first">
		/// Specifies the index of the first glyph to be taken.
		/// </param>
		/// <param name="count">
		/// Specifies the number of glyphs to be taken.
		/// </param>
		/// <param name="list">
		/// A <see cref="T:int"/>.
		/// </param>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void UseXFont(Int32 font, int first, int count, int list)
		{
			Debug.Assert(Delegates.pglXUseXFont != null, "pglXUseXFont not implemented");
			Delegates.pglXUseXFont(font, first, count, list);
			CallLog("glXUseXFont({0}, {1}, {2}, {3})", font, first, count, list);
		}

	}

}
