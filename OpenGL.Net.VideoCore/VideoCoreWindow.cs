
// Copyright (C) 2016-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Window based on VideoCore IV API on RaspberryPi.
	/// </summary>
	public class VideoCoreWindow : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static VideoCoreWindow()
		{
			// Support for RPi
			KhronosApi.EglInitializing += KhronosApi_PlatformInit_Rpi;
		}

		/// <summary>
		/// Initialize RPi Broadcom VideoCore IV API.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private static void KhronosApi_PlatformInit_Rpi(object sender, EglEventArgs e)
		{
			if (Bcm.IsAvailable)
				Bcm.bcm_host_init();
		}

		/// <summary>
		/// Construct a fullscreen window.
		/// </summary>
		public VideoCoreWindow()
		{
			try {
				int width, height;

				KhronosApi.LogComment("Creating VideoCore IV native window");

				if (Bcm.graphics_get_display_size(0 /* LCD */, out width, out height) < 0)
					throw new InvalidOperationException("unable to get BCM display size");

				Bcm.VC_RECT_T dstRect = new Bcm.VC_RECT_T(0, 0, width, height);
				Bcm.VC_RECT_T srcRect = new Bcm.VC_RECT_T(0, 0, width << 16, height << 16);

				if ((_DispManxDisplay = Bcm.vc_dispmanx_display_open(0 /* LCD */)) == 0)
					throw new InvalidOperationException("unable to open DispManX display");

				// Update - Add element
				uint updateHandle = Bcm.vc_dispmanx_update_start(0);
				_ElementHandle = Bcm.vc_dispmanx_element_add(updateHandle, _DispManxDisplay, 0, dstRect, 0, srcRect, 0, IntPtr.Zero, IntPtr.Zero, Bcm.DISPMANX_TRANSFORM_T.DISPMANX_NO_ROTATE);
				Bcm.vc_dispmanx_update_submit_sync(updateHandle);

				// Native window
				_NativeWindow = new EGL_DISPMANX_WINDOW_T();
				_NativeWindow.element = _ElementHandle;
				_NativeWindow.width = width;
				_NativeWindow.height = height;

				// Keep native window pinned
				_NativeWindowLock = new MemoryLock(_NativeWindow);

				KhronosApi.LogComment($"VideoCore IV Native Window is 0x{_NativeWindowLock.Address.ToString("X")}");
			} catch {
				Dispose();
				throw;
			}
		}

		#endregion

		#region VideoCore Handles

		/// <summary>
		/// Get the display handle associated this instance.
		/// </summary>
		public IntPtr Display { get { return (IntPtr.Zero); } }
		
		/// <summary>
		/// Get the native window handle.
		/// </summary>
		public IntPtr Handle { get { return (_NativeWindowLock.Address); } }

		/// <summary>
		/// The structure expected by eglCreateWindowSurface function.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		private struct EGL_DISPMANX_WINDOW_T
		{
			public UInt32 element;
			public int width;
			public int height;
		}

		/// <summary>
		/// The DispManX display.
		/// </summary>
		private uint _DispManxDisplay;

		/// <summary>
		/// The element used for presenting a fullscreen window.
		/// </summary>
		private uint _ElementHandle;

		/// <summary>
		/// The native window.
		/// </summary>
		private EGL_DISPMANX_WINDOW_T _NativeWindow;

		/// <summary>
		/// The native window, pinned.
		/// </summary>
		private MemoryLock _NativeWindowLock;

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Releases all resources used by the <see cref="VideoCoreWindow"/> object.
		/// </summary>
		/// <param name="disposing">
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				
				if (_ElementHandle != 0) {
					uint updateHandle = Bcm.vc_dispmanx_update_start(0);
					Bcm.vc_dispmanx_element_remove(updateHandle, _ElementHandle);
					Bcm.vc_dispmanx_update_submit_sync(updateHandle);
					
					_ElementHandle = 0;
				}

				if (_DispManxDisplay != 0) {
					Bcm.vc_dispmanx_display_close(_DispManxDisplay);
					_DispManxDisplay = 0;
				}

				if (_NativeWindowLock != null) {
					_NativeWindowLock.Dispose();
					_NativeWindowLock = null;
				}
			}
		}

		// <summary>
		/// Releases all resources used by the <see cref="VideoCoreWindow"/> object.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
		}

		#endregion
	}
}
