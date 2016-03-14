
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
	/// Native Platform Interface (EGL) device context.
	/// </summary>
	public sealed class NativeDeviceContext : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="NativeDeviceContext"/> class.
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
		public NativeDeviceContext(Control window)
		{
			if (window == null)
				throw new ArgumentNullException("window");

			// "Force" handle creation
			if (!window.IsHandleCreated && window.Handle != IntPtr.Zero)
				throw new InvalidOperationException("invalid handle");

			if ((_Display = Egl.GetDisplay(new IntPtr(Egl.DEFAULT_DISPLAY))) == IntPtr.Zero)
				throw new InvalidOperationException("unable to get display handle");

			int[] major = new int[1], minor = new int[1];

			if (Egl.Initialize(_Display, major, minor) == false)
				throw new InvalidOperationException("unable to initialize the display");

			_NativeWindow = window.Handle;
			_Version = new KhronosVersion(major[0], minor[0]);
		}

		#endregion

		#region Device Information

		/// <summary>
		/// The opened display.
		/// </summary>
		public IntPtr Display
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_Display);
			}
		}

		/// <summary>
		/// The frame buffer configuration index.
		/// </summary>
		public IntPtr Config
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				return (_Config);
			}
			set
			{
				if (IsDisposed)
					throw new ObjectDisposedException("XServerDeviceContext");
				_Config = value;
			}
		}

		/// <summary>
		/// Native window handle.
		/// </summary>
		private IntPtr _NativeWindow;

		/// <summary>
		/// The opened display.
		/// </summary>
		private IntPtr _Display;

		/// <summary>
		/// The frame buffer configuration.
		/// </summary>
		private IntPtr _Config;

		/// <summary>
		/// The EGL surface.
		/// </summary>
		private IntPtr _EglSurface;

		/// <summary>
		/// EGL version implemented.
		/// </summary>
		private readonly KhronosVersion _Version;

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
			return (Egl.CreateContext(_Display, _Config, sharedContext, null));
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

			return (Egl.CreateContext(_Display, _Config, sharedContext, attribsList));
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
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public override bool MakeCurrent(IntPtr ctx)
		{
			return (Egl.MakeCurrent(_Display, IntPtr.Zero, IntPtr.Zero, ctx));
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

			Egl.DestroyContext(_Display, ctx);

			return (true);
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public override void SwapBuffers()
		{
			Egl.SwapBuffers(_Display, IntPtr.Zero);
		}

		/// <summary>
		/// Control the the buffers swap of a device.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="Int32"/> that specifies the minimum number of video frames that are displayed
		/// before a buffer swap will occur.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful.
		/// </returns>
		public override bool SwapInterval(int interval)
		{
			return (Egl.SwapInterval(_Display, interval));
		}

		/// <summary>
		/// Gets the platform exception relative to the last operation performed.
		/// </summary>
		/// <returns>
		/// The platform exception relative to the last operation performed.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public override Exception GetPlatformException()
		{
			return (null);
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

				_PixelFormatCache = new DevicePixelFormatCollection();

				// Get the number of pixel formats
				int configCount;
				if (Egl.GetConfigs(_Display, null, 0, out configCount) == false)
					throw new InvalidOperationException("unable to get configurations count");

				IntPtr[] configs = new IntPtr[configCount];
				if (Egl.GetConfigs(_Display, configs, configs.Length, out configCount) == false)
					throw new InvalidOperationException("unable to get configurations");
				
				foreach (IntPtr config in configs) {
					DevicePixelFormat pixelFormat = new DevicePixelFormat();
					int[] param = new int[1];

					// Defaults to RGBA
					pixelFormat.RgbaUnsigned = true;
					pixelFormat.RenderWindow = true;
					pixelFormat.RenderBuffer = false;

					// Double buffer and swap method can be determined only later, once the pixel format is set
					pixelFormat.DoubleBuffer = false;
					pixelFormat.SwapMethod = 0;

					if (Egl.GetConfigAttrib(_Display, config, Egl.BUFFER_SIZE, param) == false)
						throw new InvalidOperationException("unable to get configuration parameter BUFFER_SIZE");
					pixelFormat.ColorBits = param[0];

					if (Egl.GetConfigAttrib(_Display, config, Egl.DEPTH_SIZE, param) == false)
						throw new InvalidOperationException("unable to get configuration parameter DEPTH_SIZE");
					pixelFormat.DepthBits = param[0];

					if (Egl.GetConfigAttrib(_Display, config, Egl.STENCIL_SIZE, param) == false)
						throw new InvalidOperationException("unable to get configuration parameter STENCIL_SIZE");
					pixelFormat.StencilBits = param[0];

					if (Egl.GetConfigAttrib(_Display, config, Egl.SAMPLES, param) == false)
						throw new InvalidOperationException("unable to get configuration parameter SAMPLES");
					pixelFormat.MultisampleBits = param[0];

					pixelFormat.EglConfig = config;

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

			_EglSurface = Egl.CreatePlatformWindowSurface(_Display, pixelFormat.EglConfig, _NativeWindow, null);
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
				if (_Display != IntPtr.Zero) {
					Egl.Terminate(_Display);
					_Display = IntPtr.Zero;
				}
			}
		}

		/// <summary>
		/// Pixel formats available on this DeviceContext (cache).
		/// </summary>
		private DevicePixelFormatCollection _PixelFormatCache;

		#endregion
	}
}
