
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
			
			mWindowHandle = window.Handle;
			mDeviceContext = Wgl.UnsafeNativeMethods.GdiGetDC(window.Handle);

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
				return (mWindowHandle);
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
				return (mDeviceContext);
			}
		}

		/// <summary>
		/// The window handle.
		/// </summary>
		private readonly IntPtr mWindowHandle;

		/// <summary>
		/// The device context of the control.
		/// </summary>
		private readonly IntPtr mDeviceContext;
		
		#endregion

		#region DeviceContext Overrides
		
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