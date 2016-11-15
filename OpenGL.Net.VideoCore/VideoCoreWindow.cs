
// Copyright (C) 2016 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Window based on VideoCore IV API on RaspberryPi.
	/// </summary>
	public class VideoCoreWindow : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Construct a fullscreen window.
		/// </summary>
		public VideoCoreWindow()
		{
			try {
				int width, height;

				KhronosApi.LogComment("Creating VideoCore native window");

				if (Bcm.graphics_get_display_size(0 /* LCD */, out width, out height) < 0)
					throw new InvalidOperationException("unable to get BCM display size");

				Bcm.VC_RECT_T dstRect = new Bcm.VC_RECT_T(0, 0, width, height);
				Bcm.VC_RECT_T srcRect = new Bcm.VC_RECT_T(0, 0, width << 16, height << 16);

				if ((_DispManxDisplay = Bcm.vc_dispmanx_display_open(0 /* LCD */)) == 0)
					throw new InvalidOperationException("unable to open DispManX display");
				_Update = Bcm.vc_dispmanx_update_start(0);
				_ElementHandle = Bcm.vc_dispmanx_element_add(_Update, _DispManxDisplay, 0, ref dstRect, 0, ref srcRect, 0, IntPtr.Zero, IntPtr.Zero, Bcm.DISPMANX_TRANSFORM_T.DISPMANX_NO_ROTATE);
				Bcm.vc_dispmanx_update_submit_sync(_Update);

				// Native window
				_NativeWindow = new EGL_DISPMANX_WINDOW_T();
				_NativeWindow.element = _ElementHandle;
				_NativeWindow.width = width;
				_NativeWindow.height = height;

				// Keep native window pinned
				_NativeWindowLock = new MemoryLock(_NativeWindow);
			} catch {
				Dispose();
				throw;
			}
		}

		#endregion

		#region VideoCore Handles

		public IntPtr Display { get { return (IntPtr.Zero); } }
		
		public IntPtr Handle { get { return (IntPtr.Zero); } }

		private struct EGL_DISPMANX_WINDOW_T
		{
			public UInt32 element;
			public int width;
			public int height;
		}

		private uint _DispManxDisplay;

		private uint _Update;

		private uint _ElementHandle;

		private EGL_DISPMANX_WINDOW_T _NativeWindow;

		private MemoryLock _NativeWindowLock;

		#endregion

		#region IDisposable Implementation

		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				if (_NativeWindowLock != null) {
					_NativeWindowLock.Dispose();
					_NativeWindowLock = null;
				}
				if (_DispManxDisplay != 0) {
					Bcm.vc_dispmanx_display_close(_DispManxDisplay);
					_DispManxDisplay = 0;
				}
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			Dispose(true);
		}

		#endregion
	}
}
