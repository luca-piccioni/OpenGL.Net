
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
			_Version = new KhronosVersion(major[0], minor[0], KhronosVersion.ApiEgl);
		}

		#endregion

		#region Device Information

		/// <summary>
		/// Native window handle.
		/// </summary>
		public IntPtr NativeWindow
		{
			get { return (_NativeWindow); }
		}

		/// <summary>
		/// The opened display.
		/// </summary>
		public IntPtr Display
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("NativeDeviceContext");
				return (_Display);
			}
		}

		/// <summary>
		/// The EGL surface.
		/// </summary>
		public IntPtr Surface
		{
			get { return (_EglSurface); }
			set
			{
				if (value == IntPtr.Zero)
					throw new InvalidOperationException("invalid value");
				if (_EglSurface != IntPtr.Zero)
					throw new InvalidOperationException("already allocated");
				_EglSurface = value;
			}
		}

		/// <summary>
		/// The context version.
		/// </summary>
		public KhronosVersion Version
		{
			get
			{
				if (IsDisposed)
					throw new ObjectDisposedException("NativeDeviceContext");
				return (_Version);
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
		/// The graphics context.
		/// </summary>
		private IntPtr _Context;

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
			if (ctx != IntPtr.Zero) {
				bool current = Egl.MakeCurrent(_Display, _EglSurface, _EglSurface, ctx);

				// Link OpenGL ES procedures on Gl
				if (ctx != IntPtr.Zero && current == true)
					Gl.SyncEsDelegates();

				return (current);
			} else
				return (Egl.MakeCurrent(_Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero));
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
				return (_PixelFormatCache);

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
					int param;
					bool version12 = _Version >= new KhronosVersion(1, 2, KhronosVersion.ApiEgl);
					bool version13 = _Version >= new KhronosVersion(1, 3, KhronosVersion.ApiEgl);
					bool version14 = _Version >= new KhronosVersion(1, 4, KhronosVersion.ApiEgl);

					if (Egl.GetConfigAttrib(_Display, config, Egl.CONFIG_ID, out pixelFormat.FormatIndex) == false)
						throw new InvalidOperationException("unable to get configuration parameter CONFIG_ID");

					// Defaults to RGBA
					pixelFormat.RgbaUnsigned = true;
					pixelFormat.RenderWindow = true;
					pixelFormat.RenderBuffer = false;

					// Double buffer and swap method can be determined only later, once the pixel format is set
					pixelFormat.DoubleBuffer = false;
					pixelFormat.SwapMethod = 0;

					if (Egl.GetConfigAttrib(_Display, config, Egl.BUFFER_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter BUFFER_SIZE");
					pixelFormat.ColorBits = param;

					if (Egl.GetConfigAttrib(_Display, config, Egl.RED_SIZE, out pixelFormat.RedBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter RED_SIZE");
					if (Egl.GetConfigAttrib(_Display, config, Egl.GREEN_SIZE, out pixelFormat.GreenBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter GREEN_SIZE");
					if (Egl.GetConfigAttrib(_Display, config, Egl.BLUE_SIZE, out pixelFormat.BlueBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter BLUE_SIZE");
					if (Egl.GetConfigAttrib(_Display, config, Egl.ALPHA_SIZE, out pixelFormat.AlphaBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter ALPHA_SIZE");
					if (Egl.GetConfigAttrib(_Display, config, Egl.ALPHA_MASK_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter ALPHA_MASK_SIZE");

					if (Egl.GetConfigAttrib(_Display, config, Egl.DEPTH_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter DEPTH_SIZE");
					pixelFormat.DepthBits = param;

					if (Egl.GetConfigAttrib(_Display, config, Egl.STENCIL_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter STENCIL_SIZE");
					pixelFormat.StencilBits = param;

					if (Egl.GetConfigAttrib(_Display, config, Egl.SAMPLES, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter SAMPLES");
					pixelFormat.MultisampleBits = param;

					if (Egl.GetConfigAttrib(_Display, config, Egl.CONFIG_CAVEAT, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter CONFIG_CAVEAT");
					if (param == Egl.SLOW_CONFIG)		// Skip software implementations?
						continue;

					if (Egl.GetConfigAttrib(_Display, config, Egl.NATIVE_RENDERABLE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter NATIVE_RENDERABLE");
					if (param == Egl.TRUE)
						continue;

					if (version12) {
						if (Egl.GetConfigAttrib(_Display, config, Egl.COLOR_BUFFER_TYPE, out param) == false)
							throw new InvalidOperationException("unable to get configuration parameter COLOR_BUFFER_TYPE");
						switch (param) {
							case Egl.LUMINANCE_BUFFER:
								if (Egl.GetConfigAttrib(_Display, config, Egl.LUMINANCE_SIZE, out param) == false)
									throw new InvalidOperationException("unable to get configuration parameter LUMINANCE_SIZE");
								// Overrides color bits
								pixelFormat.ColorBits = param;

								// ATM do not support luminance buffers
								continue;
						}
					}

					if (Egl.GetConfigAttrib(_Display, config, Egl.MAX_SWAP_INTERVAL, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter MAX_SWAP_INTERVAL");
					if (Egl.GetConfigAttrib(_Display, config, Egl.MIN_SWAP_INTERVAL, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter MIN_SWAP_INTERVAL");

					// EGL 1.3 attributes
					if (version13) {
						if (Egl.GetConfigAttrib(_Display, config, Egl.CONFORMANT, out param) == false)
							throw new InvalidOperationException("unable to get configuration parameter CONFORMANT");

						if ((param & Egl.OPENGL_ES2_BIT) != 0) {

						} else
							continue;

						if ((param & Egl.OPENGL_ES_BIT) != 0) {

						}

						if ((param & Egl.OPENVG_BIT) != 0) {

						}

						if (version14 && (param & Egl.OPENGL_BIT) != 0) {

						}

						// Not implemented by ANGLE
						//if (Egl.GetConfigAttrib(_Display, config, Egl.MATCH_NATIVE_PIXMAP, param) == false)
						//	throw new InvalidOperationException("unable to get configuration parameter MATCH_NATIVE_PIXMAP");
					}

					if (version14) {
						if (Egl.GetConfigAttrib(_Display, config, Egl.SURFACE_TYPE, out param) == false)
							throw new InvalidOperationException("unable to get configuration parameter SURFACE_TYPE");

						if ((param & Egl.MULTISAMPLE_RESOLVE_BOX_BIT) != 0) { }
						if ((param & Egl.PBUFFER_BIT) != 0) { }
						if ((param & Egl.PIXMAP_BIT) != 0) { }
						if ((param & Egl.SWAP_BEHAVIOR_PRESERVED_BIT) != 0) { }
						if ((param & Egl.VG_ALPHA_FORMAT_PRE_BIT) != 0) { }
						if ((param & Egl.VG_COLORSPACE_LINEAR_BIT) != 0) { }
						if ((param & Egl.WINDOW_BIT) != 0) { }
					}

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
			//if (pixelFormat == null)
			//	throw new ArgumentNullException("pixelFormat");

			int[] configAttribs = new int[3] {
				Egl.CONFIG_ID, 10,
				Egl.NONE
			};
			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[1024];

			if (Egl.ChooseConfig(_Display, configAttribs, configs, 1, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");

			IntPtr config = configs[0];
			int[] contextAttribs = new int[1] {
				// Egl.RENDER_BUFFER, Egl.BACK_BUFFER,
				Gl.NONE
			};

			if ((_Context = Egl.CreateContext(_Display, config, IntPtr.Zero, contextAttribs)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create context");

			int[] surfaceAttribs = new int[1] {
				// Egl.RENDER_BUFFER, Egl.BACK_BUFFER,
				Gl.NONE
			};

			if ((_EglSurface = Egl.CreateWindowSurface(_Display, config, _NativeWindow, surfaceAttribs)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create window surface");

			_Config = config;
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
