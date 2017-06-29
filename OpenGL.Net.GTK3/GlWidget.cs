
// Copyright (C) 2017 Luca Piccioni
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

// warning CS0612: GlWidget.DoubleBuffered could be obsolete, but it is required
#pragma warning disable 612

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;

using Cairo;
using Gtk;

namespace OpenGL.GTK3
{
	/// <summary>
	/// GTK3 widget for rendering using OpenGL.Net.
	/// </summary>
	[ToolboxItem(true)]
	public class GlWidget : DrawingArea
	{
		#region Constructors

		/// <summary>
		/// Construct a GlWidget.
		/// </summary>
		public GlWidget()
		{
			DoubleBuffered = false;
		}

		#endregion

		#region Designer Properties

		/// <summary>
		/// The <see cref="DevicePixelFormat"/> describing the minimum pixel format required by this control.
		/// </summary>
		private DevicePixelFormat ControlPixelFormat
		{
			get
			{
				DevicePixelFormat controlReqFormat = new DevicePixelFormat();

				controlReqFormat.RgbaUnsigned = true;
				controlReqFormat.RenderWindow = true;

				controlReqFormat.ColorBits = (int)24;
				controlReqFormat.DepthBits = (int)0;
				controlReqFormat.StencilBits = (int)0;
				controlReqFormat.MultisampleBits = (int)0;
				controlReqFormat.DoubleBuffer = true;

				return (controlReqFormat);
			}
		}

		#endregion

		#region DrawingArea Overrides

		protected override void OnRealized()
		{
			// Base implementation
			base.OnRealized();

			// Create Device and GL context
			IntPtr winHandle = GetWindowHandle();

			if (winHandle != IntPtr.Zero) {
				_DeviceContext = DeviceContext.Create(IntPtr.Zero, GetWindowHandle());

				DevicePixelFormat[] pixelFormats = _DeviceContext.PixelsFormats.Choose(ControlPixelFormat).ToArray();

				_DeviceContext.SetPixelFormat(pixelFormats[0]);

				_GraphicsContext = _DeviceContext.CreateContext(IntPtr.Zero);
			}
		}

		protected override bool OnDrawn(Context cr)
		{
			// Base implementation
			//bool ret = base.OnDrawn(cr);

			_DeviceContext.MakeCurrent(_GraphicsContext);

			Gl.ClearColor(1.0f, 0.0f, 0.0f, 0.0f);

			Gl.Viewport(0, 0, 100, 100);
			Gl.Clear(ClearBufferMask.ColorBufferBit);

			_DeviceContext.SwapBuffers();

			return (true);
		}

		/// <summary>
		/// Get platform independent GTL widget handle.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="IntPtr"/> that is the handle of this GlWidget.
		/// </returns>
		private IntPtr GetWindowHandle()
		{
			return (gdk_win32_window_get_handle(Window.Handle));
		}

		/// <summary>
		/// GDK method for getting the GTK widget handle on Windows platform.
		/// </summary>
		/// <param name="d"></param>
		/// <returns></returns>
		[SuppressUnmanagedCodeSecurity, DllImport("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr gdk_win32_window_get_handle(IntPtr d);

		/// <summary>
		/// Device context created on the GTK widget handle.
		/// </summary>
		private DeviceContext _DeviceContext;

		/// <summary>
		/// OpenGL context created on <see cref="_DeviceContext"/>.
		/// </summary>
		private IntPtr _GraphicsContext;

		#endregion
	}
}
