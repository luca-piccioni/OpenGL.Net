
// Copyright (C) 2012-2015 Luca Piccioni
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

// Support for WGL_ARB_multisample or WGL_EXT_multisample
#define SUPPORT_MULTISAMPLE
// Support for WGL_ARB_pbuffer
#define SUPPORT_PBUFFER
// Support WGL_ARB_framebuffer_sRGB or WGL_EXT_framebuffer_sRGB
#define SUPPORT_FRAMEBUFFER_SRGB
// Support WGL_ARB_pixel_format_float || WGL_ATI_pixel_format_float
#define SUPPORT_PIXEL_FORMAT_FLOAT
// Support WGL_EXT_pixel_format_packed_float
#define SUPPORT_PIXEL_FORMAT_PACKED_FLOAT

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Device context for MS Windows platform.
	/// </summary>
	public sealed class WindowsDeviceContext : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="WindowsDeviceContext"/> class.
		/// </summary>
		/// <param name='window'>
		/// Window.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public WindowsDeviceContext(Control window)
		{
			if (window == null)
				throw new ArgumentNullException("window");

			if (!window.IsHandleCreated && window.Handle != IntPtr.Zero)
				throw new InvalidOperationException("invalid handle");

			_WindowHandle = window.Handle;
			_DeviceContext = Wgl.GetDC(window.Handle);

			if (DeviceContext == IntPtr.Zero)
				throw new InvalidOperationException("unable to get any video device context");
		}

		#endregion

		#region Device Information

		/// <summary>
		/// The window handle.
		/// </summary>
		public IntPtr WindowHandle
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("WindowsDeviceContext");
				return (_WindowHandle);
			}
		}

		/// <summary>
		/// The device context of the control.
		/// </summary>
		public IntPtr DeviceContext
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("WindowsDeviceContext");
				return (_DeviceContext);
			}
		}

		/// <summary>
		/// The window handle.
		/// </summary>
		private readonly IntPtr _WindowHandle;

		/// <summary>
		/// The device context of the control.
		/// </summary>
		private readonly IntPtr _DeviceContext;

		#endregion

		#region DeviceContext Overrides

		/// <summary>
		/// Creates a context.
		/// </summary>
		/// <param name="sharedContext">
		/// A <see cref="IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case <paramref name="sharedContext"/> is different from IntPtr.Zero, and the objects
		/// cannot be shared with it.
		/// </exception>
		public override IntPtr CreateContext(IntPtr sharedContext)
		{
			IntPtr renderContext = IntPtr.Zero;

			try {
				renderContext = Wgl.CreateContext(DeviceContext);
				if ((renderContext != IntPtr.Zero) && (sharedContext != IntPtr.Zero)) {
					bool res = Wgl.ShareLists(renderContext, sharedContext);
					Debug.Assert(res);
				}

				return (renderContext);
			} catch {
				if (renderContext != IntPtr.Zero) {
					bool res = Wgl.DeleteContext(renderContext);
					Debug.Assert(res);
				}

				throw;
			}
		}

		/// <summary>
		/// Creates a context, specifying attributes.
		/// </summary>
		/// <param name="sharedContext">
		/// A <see cref="IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <param name="attribsList">
		/// A <see cref="T:Int32[]"/> that specifies the attributes list.
		/// </param>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <see cref="attribsList"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="attribsList"/> length is zero or if the last item of <paramref name="attribsList"/>
		/// is not zero.
		/// </exception>
		public override IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList)
		{
			if (attribsList == null)
				throw new ArgumentNullException("attribsList");
			if (attribsList.Length == 0)
				throw new ArgumentException("zero length array", "attribsList");
			if (attribsList[attribsList.Length - 1] != 0)
				throw new ArgumentException("not zero-terminated array", "attribsList");

			return (Wgl.CreateContextAttribsARB(DeviceContext, sharedContext, attribsList));
		}

		/// <summary>
		/// Makes the context current on the calling thread.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="IntPtr"/> that specify the context to be current on the calling thread, bound to
		/// thise device context. It can be IntPtr.Zero indicating that no context will be current.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public override bool MakeCurrent(IntPtr ctx)
		{
			return (Wgl.MakeCurrent(DeviceContext, ctx));
		}

		/// <summary>
		/// Deletes a context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="IntPtr"/> that specify the context to be deleted.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful. If it returns false,
		/// query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <remarks>
		/// <para>The context <paramref name="ctx"/> must not be current on any thread.</para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is IntPtr.Zero.
		/// </exception>
		public override bool DeleteContext(IntPtr ctx)
		{
			if (ctx == IntPtr.Zero)
				throw new ArgumentException("ctx");

			return (Wgl.DeleteContext(ctx));
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public override void SwapBuffers()
		{
			Wgl.UnsafeNativeMethods.GdiSwapBuffersFast(DeviceContext);
		}

		/// <summary>
		/// Control the the buffers swap of a device.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="System.Int32"/> that specifies the minimum number of video frames that are displayed
		/// before a buffer swap will occur.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful.
		/// </returns>
		public override bool SwapInterval(int interval)
		{
			return (Wgl.SwapIntervalEXT(interval));
		}

		/// <summary>
		/// Gets the platform exception relative to the last operation performed.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context on which an error occurred.
		/// </param>
		/// <returns>
		/// The platform exception relative to the last operation performed.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke")]
		public override Exception GetPlatformException()
		{
			Exception platformException = null;

			int win32Error = Marshal.GetLastWin32Error();
			if (win32Error != 0)
				platformException = new Win32Exception(win32Error);

			return (platformException);
		}

		/// <summary>
		/// Get the pixel formats supported by this device.
		/// </summary>
		public override DevicePixelFormatCollection PixelsFormats
		{
			get
			{
				// Use cached pixel formats
				if (_PixelFormatCache != null)
					return (_PixelFormatCache);

				// Query WGL extensions
				Wgl.Extensions wglExtensions = new Wgl.Extensions();

				wglExtensions.Query(this);

				// Get the number of pixel formats
				int[] countFormatAttribsCodes = new int[] { Wgl.NUMBER_PIXEL_FORMATS_ARB };
				int[] countFormatAttribsValues = new int[countFormatAttribsCodes.Length];

				Wgl.GetPixelFormatAttribARB(DeviceContext, 1, 0, (uint)countFormatAttribsCodes.Length, countFormatAttribsCodes, countFormatAttribsValues);

				// Request configurations
				List<int> pixelFormatAttribsCodes = new List<int>(12);

				// Minimum requirements
				pixelFormatAttribsCodes.Add(Wgl.SUPPORT_OPENGL_ARB);      // Required to be Gl.TRUE
				pixelFormatAttribsCodes.Add(Wgl.ACCELERATION_ARB);        // Required to be Wgl.FULL_ACCELERATION or Wgl.ACCELERATION_ARB
				pixelFormatAttribsCodes.Add(Wgl.PIXEL_TYPE_ARB);
				// Buffer destination
				pixelFormatAttribsCodes.Add(Wgl.DRAW_TO_WINDOW_ARB);
				pixelFormatAttribsCodes.Add(Wgl.DRAW_TO_BITMAP_ARB);
				// Multiple buffers
				pixelFormatAttribsCodes.Add(Wgl.DOUBLE_BUFFER_ARB);
				pixelFormatAttribsCodes.Add(Wgl.SWAP_METHOD_ARB);
				pixelFormatAttribsCodes.Add(Wgl.STEREO_ARB);
				// Pixel description
				pixelFormatAttribsCodes.Add(Wgl.COLOR_BITS_ARB);
				pixelFormatAttribsCodes.Add(Wgl.DEPTH_BITS_ARB);
				pixelFormatAttribsCodes.Add(Wgl.STENCIL_BITS_ARB);

#if SUPPORT_MULTISAMPLE
				// Multisample extension
				if (wglExtensions.Multisample_ARB || wglExtensions.Multisample_EXT) {
					pixelFormatAttribsCodes.Add(Wgl.SAMPLE_BUFFERS_ARB);
					pixelFormatAttribsCodes.Add(Wgl.SAMPLES_ARB);
				}
				int pixelFormatAttribMultisampleIndex = pixelFormatAttribsCodes.Count - 1;
#endif

#if SUPPORT_PBUFFER
				if (wglExtensions.Pbuffer_ARB || wglExtensions.Pbuffer_EXT) {
					pixelFormatAttribsCodes.Add(Wgl.DRAW_TO_PBUFFER_ARB);
				}
				int pixelFormatAttribPBufferIndex = pixelFormatAttribsCodes.Count - 1;
#endif

#if SUPPORT_FRAMEBUFFER_SRGB
				// Framebuffer sRGB extension
				if (wglExtensions.FramebufferSRGB_ARB || wglExtensions.FramebufferSRGB_EXT)
					pixelFormatAttribsCodes.Add(Wgl.FRAMEBUFFER_SRGB_CAPABLE_ARB);
				int pixelFormatAttribFramebufferSrgbIndex = pixelFormatAttribsCodes.Count - 1;
#endif

				// Create pixel format collection (cached)
				_PixelFormatCache = new DevicePixelFormatCollection();

				// Retrieve information about available pixel formats
				int[] pixelFormatAttribValues = new int[pixelFormatAttribsCodes.Count];

				for (int pixelFormatIndex = 1; pixelFormatIndex < countFormatAttribsValues[0]; pixelFormatIndex++) {
					DevicePixelFormat pixelFormat = new DevicePixelFormat();

					Wgl.GetPixelFormatAttribARB(DeviceContext, pixelFormatIndex, 0, (uint)pixelFormatAttribsCodes.Count, pixelFormatAttribsCodes.ToArray(), pixelFormatAttribValues);

					// Check minimum requirements
					if (pixelFormatAttribValues[0] != Gl.TRUE)
						continue;       // No OpenGL support
					if (pixelFormatAttribValues[1] != Wgl.FULL_ACCELERATION_ARB)
						continue;       // No hardware acceleration

					switch (pixelFormatAttribValues[2]) {
						case Wgl.TYPE_RGBA_ARB:
#if SUPPORT_PIXEL_FORMAT_FLOAT
						case Wgl.TYPE_RGBA_FLOAT_ARB:
#endif
#if SUPPORT_PIXEL_FORMAT_PACKED_FLOAT
						case Wgl.TYPE_RGBA_UNSIGNED_FLOAT_EXT:
#endif
							break;
						default:
							continue;       // Ignored pixel type
					}

					// Collect pixel format attributes
					pixelFormat.FormatIndex = pixelFormatIndex;

					switch (pixelFormatAttribValues[2]) {
						case Wgl.TYPE_RGBA_ARB:
							pixelFormat.RgbaUnsigned = true;
							break;
						case Wgl.TYPE_RGBA_FLOAT_ARB:
							pixelFormat.RgbaFloat = true;
							break;
						case Wgl.TYPE_RGBA_UNSIGNED_FLOAT_EXT:
							pixelFormat.RgbaFloat = pixelFormat.RgbaUnsigned = true;
							break;
					}

					pixelFormat.RenderWindow = pixelFormatAttribValues[3] == Gl.TRUE;
					pixelFormat.RenderBuffer = pixelFormatAttribValues[4] == Gl.TRUE;

					pixelFormat.DoubleBuffer = pixelFormatAttribValues[5] == Gl.TRUE;
					pixelFormat.SwapMethod = pixelFormatAttribValues[6];
					pixelFormat.StereoBuffer = pixelFormatAttribValues[7] == Gl.TRUE;

					pixelFormat.ColorBits = pixelFormatAttribValues[8];
					pixelFormat.DepthBits = pixelFormatAttribValues[9];
					pixelFormat.StencilBits = pixelFormatAttribValues[10];

#if SUPPORT_MULTISAMPLE
					if (wglExtensions.Multisample_ARB || wglExtensions.Multisample_EXT) {
						Debug.Assert(pixelFormatAttribMultisampleIndex >= 0);
						pixelFormat.MultisampleBits = pixelFormatAttribValues[pixelFormatAttribMultisampleIndex];
					}
#endif

#if SUPPORT_PBUFFER
					if (wglExtensions.Pbuffer_ARB || wglExtensions.Pbuffer_EXT) {
						Debug.Assert(pixelFormatAttribPBufferIndex >= 0);
						pixelFormat.RenderPBuffer = pixelFormatAttribValues[pixelFormatAttribPBufferIndex] == Gl.TRUE;
					}
#endif

#if SUPPORT_FRAMEBUFFER_SRGB
					if (wglExtensions.FramebufferSRGB_ARB || wglExtensions.FramebufferSRGB_EXT) {
						Debug.Assert(pixelFormatAttribFramebufferSrgbIndex >= 0);
						pixelFormat.SRGBCapable = pixelFormatAttribValues[pixelFormatAttribFramebufferSrgbIndex] != 0;
					}
#endif

					pixelFormat.XFbConfig = IntPtr.Zero;
					pixelFormat.XVisualInfo = new Glx.XVisualInfo();

					_PixelFormatCache.Add(pixelFormat);
				}

				return (_PixelFormatCache);
			}
		}

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="pixelFormat"/> is null.
		/// </exception>
		public override void SetPixelFormat(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException("pixelFormat");
			if (_PixelFormatSet == true)
				throw new InvalidOperationException("pixel format already set");

			Wgl.PIXELFORMATDESCRIPTOR pDescriptor = new Wgl.PIXELFORMATDESCRIPTOR();

			// Note (from MSDN): Setting the pixel format of a window more than once can lead to significant complications for the Window Manager
			// and for multithread applications, so it is not allowed. An application can only set the pixel format of a window one time. Once a
			// window's pixel format is set, it cannot be changed.

			// Set choosen pixel format
			if (Wgl.SetPixelFormat(DeviceContext, pixelFormat.FormatIndex, ref pDescriptor) == false)
				throw new InvalidOperationException("unable to select surface pixel format");
			_PixelFormatSet = true;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				bool res = Wgl.ReleaseDC(WindowHandle, DeviceContext);
				Debug.Assert(res);
			}
		}

		/// <summary>
		/// Pixel formats available on this DeviceContext (cache).
		/// </summary>
		private DevicePixelFormatCollection _PixelFormatCache;

		/// <summary>
		/// Flag for checking whether the pixel format is set only once.
		/// </summary>
		private bool _PixelFormatSet;

#endregion
	}
}