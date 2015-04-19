
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
		/// <para>
		/// Glx.ChooseVisual: ignored. Only visuals that can be rendered with GLX are considered.
		/// </para>
		/// <para>
		/// Glx.GetConfig: glx. if OpenGL rendering is supported by this visual, Glx.e otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int USE_GL = 1;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative integer that indicates the desired color index buffer size. The 
		/// smallest index buffer of at least the specified size is preferred. This attribute is ignored if Glx.COLOR_INDEX_BIT is 
		/// not set in Glx.RENDER_TYPE. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative integer that indicates the desired color index buffer size. The 
		/// smallest index buffer of at least the specified size is preferred. Ignored if Glx.RGBA is asserted.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits per color buffer. For RGBA visuals, Glx.BUFFER_SIZE is the sum of Glx.RED_SIZE, 
		/// Glx.GREEN_SIZE, Glx.BLUE_SIZE, and Glx.ALPHA_SIZE. For color index visuals, Glx.BUFFER_SIZE is the size of the color 
		/// indexes.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits per color buffer. If the frame buffer configuration supports RGBA contexts, then 
		/// Glx.BUFFER_SIZE is the sum of Glx.RED_SIZE, Glx.GREEN_SIZE, Glx.BLUE_SIZE, and Glx.ALPHA_SIZE. If the frame buffer 
		/// configuration supports only color index contexts, Glx.BUFFER_SIZE is the size of the color indexes.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BUFFER_SIZE = 2;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by an integer buffer-level specification. This specification is honored exactly. 
		/// Buffer level 0 corresponds to the default frame buffer of the display. Buffer level 1 is the first overlay frame buffer, 
		/// level two the second overlay frame buffer, and so on. Negative buffer levels correspond to underlay frame buffers. The 
		/// default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by an integer buffer-level specification. This specification is honored exactly. 
		/// Buffer level zero corresponds to the main frame buffer of the display. Buffer level one is the first overlay frame 
		/// buffer, level two the second overlay frame buffer, and so on. Negative buffer levels correspond to underlay frame 
		/// buffers.
		/// </para>
		/// <para>
		/// Glx.GetConfig: frame buffer level of the visual. Level zero is the default frame buffer. Positive levels correspond to 
		/// frame buffers that overlay the default buffer, and negative levels correspond to frame buffers that underlay the default 
		/// buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: frame buffer level of the configuration. Level zero is the default frame buffer. Positive levels 
		/// correspond to frame buffers that overlay the default buffer, and negative levels correspond to frame buffers that 
		/// underlie the default buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int LEVEL = 3;

		/// <summary>
		/// <para>
		/// Glx.ChooseVisual: if present, only TrueColor and DirectColor visuals are considered. Otherwise, only PseudoColor and 
		/// StaticColor visuals are considered.
		/// </para>
		/// <para>
		/// Glx.GetConfig: glx. if color buffers store red, green, blue, and alpha values. Glx.e if they store color indexes.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int RGBA = 4;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by Glx. or Glx.e. If Glx. is specified, then only double-buffered frame buffer 
		/// configurations are considered; if Glx.e is specified, then only single-buffered frame buffer configurations are 
		/// considered. The default value is Glx.DONT_CARE.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: if present, only double-buffered visuals are considered. Otherwise, only single-buffered visuals are 
		/// considered.
		/// </para>
		/// <para>
		/// Glx.GetConfig: glx. if color buffers exist in front/back pairs that can be swapped, Glx.e otherwise.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: glx. if color buffers exist in front/back pairs that can be swapped, Glx.e otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int DOUBLEBUFFER = 5;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by Glx. or Glx.e. If Glx. is specified, then only stereo frame buffer 
		/// configurations are considered; if Glx.e is specified, then only monoscopic frame buffer configurations are considered. 
		/// The default value is Glx.e.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: if present, only stereo visuals are considered. Otherwise, only monoscopic visuals are considered.
		/// </para>
		/// <para>
		/// Glx.GetConfig: glx. if color buffers exist in left/right pairs, Glx.e otherwise.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: glx. if color buffers exist in left/right pairs, Glx.e otherwise.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int STEREO = 6;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative integer that indicates the desired number of auxiliary buffers. 
		/// Configurations with the smallest number of auxiliary buffers that meet or exceed the specified number are preferred. The 
		/// default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative integer that indicates the desired number of auxiliary buffers. 
		/// Visuals with the smallest number of auxiliary buffers that meets or exceeds the specified number are preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of auxiliary color buffers that are available. Zero indicates that no auxiliary color buffers 
		/// exist.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of auxiliary color buffers that are available. Zero indicates that no auxiliary color 
		/// buffers exist.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int AUX_BUFFERS = 7;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: each attribute, if present, must be followed by a nonnegative minimum size specification or 
		/// Glx.DONT_CARE. The largest available total RGBA color buffer size (sum of Glx.RED_SIZE, Glx.GREEN_SIZE, Glx.BLUE_SIZE, 
		/// and Glx.ALPHA_SIZE) of at least the minimum size specified for each color component is preferred. If the requested 
		/// number of bits for a color component is 0 or Glx.DONT_CARE, it is not considered. The default value for each color 
		/// component is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, the smallest 
		/// available red buffer is preferred. Otherwise, the largest available red buffer of at least the minimum size is 
		/// preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of red stored in each color buffer. Undefined if Glx.RGBA is Glx.e.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of red stored in each color buffer. Undefined if RGBA contexts are not supported 
		/// by the frame buffer configuration.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int RED_SIZE = 8;

		/// <summary>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, the smallest 
		/// available green buffer is preferred. Otherwise, the largest available green buffer of at least the minimum size is 
		/// preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of green stored in each color buffer. Undefined if Glx.RGBA is Glx.e.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of green stored in each color buffer. Undefined if RGBA contexts are not supported 
		/// by the frame buffer configuration.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int GREEN_SIZE = 9;

		/// <summary>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, the smallest 
		/// available blue buffer is preferred. Otherwise, the largest available blue buffer of at least the minimum size is 
		/// preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of blue stored in each color buffer. Undefined if Glx.RGBA is Glx.e.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of blue stored in each color buffer. Undefined if RGBA contexts are not supported 
		/// by the frame buffer configuration.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int BLUE_SIZE = 10;

		/// <summary>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, the smallest 
		/// available alpha buffer is preferred. Otherwise, the largest available alpha buffer of at least the minimum size is 
		/// preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of alpha stored in each color buffer. Undefined if Glx.RGBA is Glx.e.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of alpha stored in each color buffer. Undefined if RGBA contexts are not supported 
		/// by the frame buffer configuration.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ALPHA_SIZE = 11;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative minimum size specification. If this value is zero, frame buffer 
		/// configurations with no depth buffer are preferred. Otherwise, the largest available depth buffer of at least the minimum 
		/// size is preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, visuals with no 
		/// depth buffer are preferred. Otherwise, the largest available depth buffer of at least the minimum size is preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits in the depth buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits in the depth buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int DEPTH_SIZE = 12;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative integer that indicates the desired number of stencil bitplanes. 
		/// The smallest stencil buffer of at least the specified size is preferred. If the desired value is zero, frame buffer 
		/// configurations with no stencil buffer are preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative integer that indicates the desired number of stencil bitplanes. The 
		/// smallest stencil buffer of at least the specified size is preferred. If the desired value is zero, visuals with no 
		/// stencil buffer are preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits in the stencil buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits in the stencil buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int STENCIL_SIZE = 13;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative minimum size specification. If this value is zero, frame buffer 
		/// configurations with no red accumulation buffer are preferred. Otherwise, the largest possible red accumulation buffer of 
		/// at least the minimum size is preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, visuals with no 
		/// red accumulation buffer are preferred. Otherwise, the largest possible red accumulation buffer of at least the minimum 
		/// size is preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of red stored in the accumulation buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of red stored in the accumulation buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_RED_SIZE = 14;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative minimum size specification. If this value is zero, frame buffer 
		/// configurations with no green accumulation buffer are preferred. Otherwise, the largest possible green accumulation 
		/// buffer of at least the minimum size is preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, visuals with no 
		/// green accumulation buffer are preferred. Otherwise, the largest possible green accumulation buffer of at least the 
		/// minimum size is preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of green stored in the accumulation buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of green stored in the accumulation buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_GREEN_SIZE = 15;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative minimum size specification. If this value is zero, frame buffer 
		/// configurations with no blue accumulation buffer are preferred. Otherwise, the largest possible blue accumulation buffer 
		/// of at least the minimum size is preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, visuals with no 
		/// blue accumulation buffer are preferred. Otherwise, the largest possible blue accumulation buffer of at least the minimum 
		/// size is preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of blue stored in the accumulation buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of blue stored in the accumulation buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public const int ACCUM_BLUE_SIZE = 16;

		/// <summary>
		/// <para>
		/// Glx.ChooseFBConfig: must be followed by a nonnegative minimum size specification. If this value is zero, frame buffer 
		/// configurations with no alpha accumulation buffer are preferred. Otherwise, the largest possible alpha accumulation 
		/// buffer of at least the minimum size is preferred. The default value is 0.
		/// </para>
		/// <para>
		/// Glx.ChooseVisual: must be followed by a nonnegative minimum size specification. If this value is zero, visuals with no 
		/// alpha accumulation buffer are preferred. Otherwise, the largest possible alpha accumulation buffer of at least the 
		/// minimum size is preferred.
		/// </para>
		/// <para>
		/// Glx.GetConfig: number of bits of alpha stored in the accumulation buffer.
		/// </para>
		/// <para>
		/// Glx.GetFBConfigAttrib: number of bits of alpha stored in the accumulation buffer.
		/// </para>
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
		/// Specifies a list of boolean attributes and integer attribute/value pairs. The last attribute must be Glx..
		/// </param>
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx. is returned if an undefined GLX attribute is encountered in <paramref name="attribList"/>.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.GetConfig"/>
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
		/// Glx.ualInfo structure, not a visual ID or a pointer to a Glx.al.
		/// </param>
		/// <param name="shareList">
		/// Specifies the context with which to share display lists. Glx. indicates that no sharing is to take place.
		/// </param>
		/// <param name="direct">
		/// Specifies whether rendering is to be done with a direct connection to the graphics system if possible (Glx.) or through 
		/// the X server (Glx.e).
		/// </param>
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx. is returned if execution fails on the client side.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.atch is generated if the context to be created would not share the address space or the screen of the context 
		/// specified by <paramref name="shareList"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.alue is generated if <paramref name="vis"/> is not a valid visual (for example, if a particular GLX implementation 
		/// does not support it).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContext is generated if <paramref name="shareList"/> is not a GLX context and is not Glx..
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.lloc is generated if the server does not have enough resources to allocate the new context.
		/// </exception>
		/// <seealso cref="Glx.DestroyContext"/>
		/// <seealso cref="Glx.GetConfig"/>
		/// <seealso cref="Glx.IsDirect"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContext is generated if <paramref name="ctx"/> is not a valid GLX context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.CreateNewContext"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.atch is generated if <paramref name="drawable"/> was not created with the same X screen and visual as <paramref 
		/// name="ctx"/>. It is also generated if <paramref name="drawable"/> is Glx. and <paramref name="ctx"/> is not Glx..
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.ccess is generated if <paramref name="ctx"/> was current to another thread at the time Glx.MakeCurrent was called.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adDrawable is generated if <paramref name="drawable"/> is not a valid GLX drawable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContext is generated if <paramref name="ctx"/> is not a valid GLX context.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContextState is generated if Glx.MakeCurrent is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContextState is also generated if the rendering context current to the calling thread has GL renderer state 
		/// Glx.FEEDBACK or Glx.SELECT.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if there are pending GL commands for the previous context and the current drawable is a 
		/// window that is no longer valid.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.lloc may be generated if the server has delayed allocation of ancillary buffers until Glx.MakeCurrent is called, 
		/// only to find that it has insufficient resources to complete the allocation.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.CreateGLXPixmap"/>
		/// <seealso cref="Glx.GetCurrentContext"/>
		/// <seealso cref="Glx.GetCurrentDisplay"/>
		/// <seealso cref="Glx.GetCurrentDrawable"/>
		/// <seealso cref="Glx.GetCurrentReadDrawable"/>
		/// <seealso cref="Glx.MakeContextCurrent"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.atch is generated if rendering contexts <paramref name="src"/> and <paramref name="dst"/> do not share an address 
		/// space or were not created with respect to the same screen.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.ccess is generated if <paramref name="dst"/> is current to any thread (including the calling thread) at the time 
		/// Glx.CopyContext is called.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if <paramref name="src"/> is the current context and the current drawable is a window 
		/// that is no longer valid.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContext is generated if either <paramref name="src"/> or <paramref name="dst"/> is not a valid GLX context.
		/// </exception>
		/// <seealso cref="Glx.ushAttrib"/>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.IsDirect"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adDrawable is generated if <paramref name="drawable"/> is not a valid GLX drawable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if <paramref name="dpy"/> and <paramref name="drawable"/> are respectively the display 
		/// and drawable associated with the current context of the calling thread, and <paramref name="drawable"/> identifies a 
		/// window that is no longer valid.
		/// </exception>
		/// <seealso cref="Glx.glFlush"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.atch is generated if the depth of <paramref name="pixmap"/> does not match the depth value reported by core X11 for 
		/// <paramref name="vis"/>, or if <paramref name="pixmap"/> was not created with respect to the same screen as <paramref 
		/// name="vis"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.alue is generated if <paramref name="vis"/> is not a valid XVisualInfo pointer (for example, if a particular GLX 
		/// implementation does not support this visual).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.ixmap is generated if <paramref name="pixmap"/> is not a valid pixmap.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.lloc is generated if the server cannot allocate the GLX pixmap.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.CreatePixmap"/>
		/// <seealso cref="Glx.DestroyGLXPixmap"/>
		/// <seealso cref="Glx.IsDirect"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adPixmap is generated if <paramref name="pix"/> is not a valid GLX pixmap.
		/// </exception>
		/// <seealso cref="Glx.CreateGLXPixmap"/>
		/// <seealso cref="Glx.DestroyPixmap"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <seealso cref="Glx.QueryVersion"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.QueryVersion returns Glx.e if it fails, Glx. otherwise.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// <paramref name="major"/> and <paramref name="minor"/> are not updated when Glx.e is returned.
		/// </exception>
		/// <seealso cref="Glx.QueryExtension"/>
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
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContext is generated if <paramref name="ctx"/> is not a valid GLX context.
		/// </exception>
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.CreateNewContext"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.NO_EXTENSION is returned if <paramref name="dpy"/> does not support the GLX extension.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.BAD_SCREEN is returned if the screen of <paramref name="vis"/> does not correspond to a screen.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.BAD_ATTRIBUTE is returned if <paramref name="attrib"/> is not a valid GLX attribute.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.BAD_VISUAL is returned if <paramref name="vis"/> doesn't support GLX and an attribute other than Glx.USE_GL is 
		/// requested.
		/// </exception>
		/// <seealso cref="Glx.ChooseVisual"/>
		/// <seealso cref="Glx.CreateContext"/>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static int GetConfig(IntPtr dpy, Glx.XVisualInfo visual, int attrib, [Out] int[] value)
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
		/// <seealso cref="Glx.CreateContext"/>
		/// <seealso cref="Glx.GetCurrentDisplay"/>
		/// <seealso cref="Glx.GetCurrentDrawable"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <seealso cref="Glx.CreateGLXPixmap"/>
		/// <seealso cref="Glx.GetCurrentContext"/>
		/// <seealso cref="Glx.GetCurrentDisplay"/>
		/// <seealso cref="Glx.GetCurrentReadDrawable"/>
		/// <seealso cref="Glx.MakeCurrent"/>
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
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if the drawable associated with the current context of the calling thread is a window, 
		/// and that window is no longer valid.
		/// </exception>
		/// <seealso cref="Glx.glFinish"/>
		/// <seealso cref="Glx.glFlush"/>
		/// <seealso cref="Glx.WaitX"/>
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
		/// <remarks>
		/// <para>The exception below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if the drawable associated with the current context of the calling thread is a window, 
		/// and that window is no longer valid.
		/// </exception>
		/// <seealso cref="Glx.glFinish"/>
		/// <seealso cref="Glx.glFlush"/>
		/// <seealso cref="Glx.WaitGL"/>
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
		/// <remarks>
		/// <para>The exceptions below won't be thrown; caller must check result manually.</para>
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Glx.ont is generated if <paramref name="font"/> is not a valid font.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adContextState is generated if the current GLX context is in display-list construction mode.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Glx.adCurrentWindow is generated if the drawable associated with the current context of the calling thread is a window, 
		/// and that window is no longer valid.
		/// </exception>
		/// <seealso cref="Glx.glBitmap"/>
		/// <seealso cref="Glx.MakeCurrent"/>
		[RequiredByFeature("GLX_VERSION_1_0")]
		public static void UseXFont(Int32 font, int first, int count, int list)
		{
			Debug.Assert(Delegates.pglXUseXFont != null, "pglXUseXFont not implemented");
			Delegates.pglXUseXFont(font, first, count, list);
			CallLog("glXUseXFont({0}, {1}, {2}, {3})", font, first, count, list);
		}

	}

}
