
// Copyright (c) 2017 Luca Piccioni
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

namespace OpenGL.CoreUI
{
	/// <summary>
	/// Native window abstract implementation.
	/// </summary>
	public abstract class NativeWindow : IDisposable
	{
		#region Platform Handles

		/// <summary>
		/// Get the display handle associated this instance.
		/// </summary>
		public abstract IntPtr Display { get; }

		/// <summary>
		/// Get the native window handle.
		/// </summary>
		public abstract IntPtr Handle { get; }

		/// <summary>
		/// Run the event loop for this NativeWindow.
		/// </summary>
		public abstract void Run();

		#endregion

		#region Abstract Interface

		/// <summary>
		/// Create the NativeWindow.
		/// </summary>
		/// <param name="x">
		/// A <see cref="Int32"/> that specifies the X coordinate of the window, in pixels.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specifies the Y coordinate of the window, in pixels.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the window width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the window height, in pixels.
		/// </param>
		public abstract void Create(int x, int y, uint width, uint height);

		/// <summary>
		/// Show the native window.
		/// </summary>
		public abstract void Show();

		/// <summary>
		/// Hide the native window.
		/// </summary>
		public abstract void Hide();

		#endregion

		#region Factory

		/// <summary>
		/// Create a <see cref="NativeWindow"/> for the current platform.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="NativeWindow"/> implementation for the current platform.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported (no native window backend implemented).
		/// </exception>
		public static NativeWindow Create()
		{
			switch (OpenGL.Platform.CurrentPlatformId) {
				case OpenGL.Platform.Id.WindowsNT:
					return (new NativeWindowWinNT());
				default:
					throw new NotSupportedException();
			}
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~NativeWindow()
		{
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get { return (_Disposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing) {
				// Mark as disposed
				_Disposed = true;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		
		/// <summary>
		/// Disposed state.
		/// </summary>
		private bool _Disposed;

		#endregion
	}
}
