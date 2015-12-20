
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
			
			_WindowHandle = window.Handle;
			_DeviceContext = Wgl.UnsafeNativeMethods.GdiGetDC(window.Handle);

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
		/// Get the pixel formats supported by this device.
		/// </summary>
		public override DevicePixelFormatCollection PixelsFormats
		{
			get
			{
				// Query WGL extensions
				Wgl.Extensions wglExtensions = new Wgl.Extensions();

				wglExtensions.Query(this);

				// Request configurations
				DevicePixelFormatCollection pFormats = new DevicePixelFormatCollection();
				List<int> pfAttributesCodes = new List<int>(12);
				int[] pfAttributesValue;

				// Minimum requirements
				pfAttributesCodes.Add(Wgl.SUPPORT_OPENGL_ARB);      // Required to be Gl.TRUE
				pfAttributesCodes.Add(Wgl.ACCELERATION_ARB);        // Required to be Wgl.FULL_ACCELERATION or Wgl.ACCELERATION_ARB
				pfAttributesCodes.Add(Wgl.PIXEL_TYPE_ARB);
				// Buffer destination
				pfAttributesCodes.Add(Wgl.DRAW_TO_WINDOW_ARB);
				pfAttributesCodes.Add(Wgl.DRAW_TO_BITMAP_ARB);
				pfAttributesCodes.Add(Wgl.DRAW_TO_PBUFFER_ARB);
				// Multiple buffers
				pfAttributesCodes.Add(Wgl.DOUBLE_BUFFER_ARB);
				pfAttributesCodes.Add(Wgl.SWAP_METHOD_ARB);
				pfAttributesCodes.Add(Wgl.STEREO_ARB);
				// Pixel description
				pfAttributesCodes.Add(Wgl.COLOR_BITS_ARB);
				pfAttributesCodes.Add(Wgl.DEPTH_BITS_ARB);
				pfAttributesCodes.Add(Wgl.STENCIL_BITS_ARB);
				// Multisample extension
				if (wglExtensions.Multisample_ARB) {
					pfAttributesCodes.Add(Wgl.SAMPLE_BUFFERS_ARB);
					pfAttributesCodes.Add(Wgl.SAMPLES_ARB);
				}
#if false
				// Framebuffer sRGB extension
				if ((caps.FramebufferSRGB == true) || (caps.FramebufferSRGB_EXT == true)) {
					pfAttributesCodes.Add(Wgl.FRAMEBUFFER_SRGB_CAPABLE_ARB);
				}
#endif

				pfAttributesValue = new int[pfAttributesCodes.Count];
				for (int pFormatIndex = 1; ; pFormatIndex++) {
					DevicePixelFormat pFormat = new DevicePixelFormat();

					if (Wgl.GetPixelFormatAttribARB(DeviceContext, pFormatIndex, 0, (uint)pfAttributesCodes.Count, pfAttributesCodes.ToArray(), pfAttributesValue) == false) {
						Debug.Assert(pFormats.Count > 0, "wrong pixel format attribute list");
						break;  // All pixel format are queried
					}

					// Check minimum requirements
					if (pfAttributesValue[0] != Gl.TRUE)
						continue;       // No OpenGL support
					if (pfAttributesValue[1] != Wgl.FULL_ACCELERATION_ARB)
						continue;       // No hardware acceleration
					if (pfAttributesValue[2] != Wgl.TYPE_RGBA_ARB)
						continue;       // Ignored pixel type

					// Collect pixel format attributes
					pFormat.FormatIndex = pFormatIndex;

					pFormat.RgbaUnsigned = pfAttributesValue[2] == Wgl.TYPE_RGBA_ARB;
					pFormat.RgbaFloat = pfAttributesValue[2] == Wgl.TYPE_RGBA_FLOAT_ARB;

					pFormat.RenderWindow = pfAttributesValue[3] == Gl.TRUE;
					pFormat.RenderBuffer = pfAttributesValue[4] == Gl.TRUE;
					pFormat.RenderPBuffer = pfAttributesValue[5] == Gl.TRUE;

					pFormat.DoubleBuffer = pfAttributesValue[6] == Gl.TRUE;
					pFormat.SwapMethod = pfAttributesValue[7];
					pFormat.StereoBuffer = pfAttributesValue[8] == Gl.TRUE;

					pFormat.ColorBits = pfAttributesValue[9];
					pFormat.DepthBits = pfAttributesValue[10];
					pFormat.StencilBits = pfAttributesValue[11];

					if (wglExtensions.Multisample_ARB) {
						// pfAttributesValue[12] ? What about multiple sample buffers?
						pFormat.MultisampleBits = pfAttributesValue[13];
					} else
						pFormat.MultisampleBits = 0;

#if false
					XXX Problems with 2.1 contextes
					if ((caps.FramebufferSRGB == true) || (caps.FramebufferSRGB_EXT == true)) {
						pFormat.SRGBCapable = pfAttributesValue[13] != 0;
					} else
#endif
					pFormat.SRGBCapable = false;
					pFormat.XFbConfig = IntPtr.Zero;
					pFormat.XVisualInfo = new Glx.XVisualInfo();

					pFormats.Add(pFormat);
				}

				return (pFormats);
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

			Wgl.PIXELFORMATDESCRIPTOR pDescriptor = new Wgl.PIXELFORMATDESCRIPTOR();

			// Set choosen pixel format
			if (Wgl.UnsafeNativeMethods.GdiSetPixelFormat(DeviceContext, pixelFormat.FormatIndex, ref pDescriptor) == false)
				throw new InvalidOperationException("unable to select surface pixel format");
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
				Wgl.UnsafeNativeMethods.GdiReleaseDC(WindowHandle, DeviceContext);
			}
		}

		#endregion
	}
}