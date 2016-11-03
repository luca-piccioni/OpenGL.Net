
// Copyright (C) 2012-2016 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Native Platform Interface (EGL) device context.
	/// </summary>
	sealed class NativeDeviceContext : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="NativeDeviceContext"/> class.
		/// </summary>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context. If it is <see cref="IntPtr.Zero"/>
		/// the surface referenced by this NativeDeviceContext is a minimal PBuffer.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public NativeDeviceContext(IntPtr windowHandle)
		{
			if ((_Display = Egl.GetDisplay(new IntPtr(Egl.DEFAULT_DISPLAY))) == IntPtr.Zero)
				throw new InvalidOperationException("unable to get display handle");

			int[] major = new int[1], minor = new int[1];

			if (Egl.Initialize(_Display, major, minor) == false)
				throw new InvalidOperationException("unable to initialize the display");

			_WindowHandle = windowHandle;
			_Version = new KhronosVersion(major[0], minor[0], KhronosVersion.ApiEgl);
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
			internal set
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
		/// Get the native window handle.
		/// </summary>
		internal IntPtr WindowHandle
		{
			get { return (_WindowHandle); }
		}

		/// <summary>
		/// Native window handle.
		/// </summary>
		private IntPtr _WindowHandle;

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

		private int[] DefaultConfigAttribs
		{
			get
			{
				List<int> configAttribs = new List<int>();

				if (Version >= Egl.Version_120)
					configAttribs.AddRange(new int[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });
				configAttribs.AddRange(new int[] { Egl.SURFACE_TYPE, Egl.PBUFFER_BIT | Egl.WINDOW_BIT });
				configAttribs.AddRange(new int[] {
					Egl.RED_SIZE, 8,
					Egl.GREEN_SIZE, 8,
					Egl.BLUE_SIZE, 8,
				});
				configAttribs.Add(Egl.NONE);

				return (configAttribs.ToArray());
			}
		}

		private int[] DefaultContextAttribs
		{
			get
			{
				List<int> contextAttribs = new List<int>();

				if (Version >= Egl.Version_130)
					contextAttribs.AddRange(new int[] { Egl.CONTEXT_CLIENT_VERSION, 2 });
				contextAttribs.Add(Egl.NONE);

				return (contextAttribs.ToArray());
			}
		}

		private int[] DefaultSurfaceAttribs
		{
			get
			{
				List<int> surfaceAttribs = new List<int>();

				surfaceAttribs.Add(Egl.NONE);
				// Egl.RENDER_BUFFER, Egl.BACK_BUFFER,

				return (surfaceAttribs.ToArray());
			}
		}

		#endregion

		#region Window Factory

		/// <summary>
		/// Native window implementation for Windows.
		/// </summary>
		internal class NativeWindow : INativeWindow
		{
			#region INativeWindow Implementation

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			IntPtr INativeWindow.Display { get { return (IntPtr.Zero); } }

			/// <summary>
			/// Get the native window handle.
			/// </summary>
			IntPtr INativeWindow.Handle { get { return (IntPtr.Zero); } }

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public void Dispose()
			{
				
			}

			#endregion
		}

		#endregion

		#region DeviceContext Overrides

		/// <summary>
		/// Create a simple context.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		internal override IntPtr CreateSimpleContext()
		{
			IntPtr ctx;

			int[] configAttribs = DefaultConfigAttribs;
			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[8];

			if (Egl.BindAPI(Egl.OPENGL_ES_API) == false)
				throw new InvalidOperationException("no ES API");

			if (Egl.ChooseConfig(Display, configAttribs, configs, configs.Length, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			int[] contextAttribs = DefaultContextAttribs;
			int[] surfaceAttribs = DefaultSurfaceAttribs;

			if ((ctx = Egl.CreateContext(Display, configs[0], IntPtr.Zero, contextAttribs)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create context");

			List<int> pbufferAttribs = new List<int>(surfaceAttribs);

			pbufferAttribs.RemoveAt(pbufferAttribs.Count - 1);
			pbufferAttribs.AddRange(new int[] { Egl.WIDTH, 1, Egl.HEIGHT, 2 });
			pbufferAttribs.Add(Egl.NONE);

			Surface = Egl.CreatePbufferSurface(Display, configs[0], pbufferAttribs.ToArray());

			return (ctx);
		}

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
			return (CreateContextAttrib(sharedContext, DefaultContextAttribs));
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
			if (attribsList[attribsList.Length - 1] != Egl.NONE)
				throw new ArgumentException("not EGL_NONE-terminated array", "attribsList");

			IntPtr context;

			if ((context = Egl.CreateContext(_Display, _Config, sharedContext, attribsList)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create context");

			CreateWindowSurface();

			return (context);
		}

		private void CreateWindowSurface()
		{
			int[] surfaceAttribs = DefaultSurfaceAttribs;

			if (_WindowHandle != IntPtr.Zero) {
				if ((_EglSurface = Egl.CreateWindowSurface(_Display, _Config, _WindowHandle, surfaceAttribs)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create window surface");
			} else {
				if ((_EglSurface = Egl.CreatePbufferSurface(_Display, _Config, surfaceAttribs)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create PBuffer surface");
			}
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
			Egl.SwapBuffers(_Display, _EglSurface);
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
		/// Query platform extensions available.
		/// </summary>
		internal override void QueryPlatformExtensions()
		{
			Egl._CurrentExtensions = new Egl.Extensions();
			Egl._CurrentExtensions.Query(this);
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
					int param;
					bool version12 = _Version >= Egl.Version_120;
					bool version13 = _Version >= Egl.Version_130;
					bool version14 = _Version >= Egl.Version_140;

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
					switch (param) {
						case Egl.NONE:
							break;
						case Egl.SLOW_CONFIG:
							continue;			// Skip software implementations?
						case Egl.NON_CONFORMANT_CONFIG:
							break;
					}

					if (version12) {
						if (Egl.GetConfigAttrib(_Display, config, Egl.COLOR_BUFFER_TYPE, out param) == false)
							throw new InvalidOperationException("unable to get configuration parameter COLOR_BUFFER_TYPE");
						switch (param) {
							case Egl.RGB_BUFFER:
									break;
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

						if ((param & Egl.WINDOW_BIT) == 0)
							pixelFormat.RenderWindow = false;
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
			if (pixelFormat == null)
				throw new ArgumentNullException("pixelFormat");

			List<int> configAttribs = new List<int>();

			if (Version >= Egl.Version_120)
				configAttribs.AddRange(new int[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });
			configAttribs.AddRange(new int[] {
				Egl.CONFIG_ID, pixelFormat.FormatIndex,
			});
			configAttribs.Add(Egl.NONE);

			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[1];

			if (Egl.BindAPI(Egl.OPENGL_ES_API) == false)
				throw new InvalidOperationException("no ES API");

			if (Egl.ChooseConfig(_Display, configAttribs.ToArray(), configs, 1, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			IntPtr config = configs[0];

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
				//if (_EglSurface != IntPtr.Zero) {
				//	Egl.DestroySurface(_Display, _EglSurface);
				//	_EglSurface = IntPtr.Zero;
				//}
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
