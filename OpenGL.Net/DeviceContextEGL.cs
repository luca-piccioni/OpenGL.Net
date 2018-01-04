
// Copyright (C) 2012-2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

using Khronos;

// ReSharper disable RedundantAssignment
// ReSharper disable InvertIf
// ReSharper disable RedundantIfElseBlock
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <summary>
	/// Native Platform Interface (EGL) device context.
	/// </summary>
	sealed class DeviceContextEGL : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Default constructor.
		/// </summary>
		private DeviceContextEGL()
		{
			string[] availApis = Egl.AvailableApis;

			if (availApis.Length == 0)
				throw new InvalidOperationException("no API available");

			if (Array.Exists(availApis, api => api == DefaultAPI) == false)
				CurrentAPI = availApis[0];
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextEGL"/> class.
		/// </summary>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context.  If it is <see cref="IntPtr.Zero"/>
		/// the surface referenced by this NativeDeviceContext is a minimal PBuffer, or no surface at all in case EGL_KHR_surfaceless_context
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public DeviceContextEGL(IntPtr windowHandle)
			: this(NativeSurface.DefaultDisplay, windowHandle)
		{

		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextEGL"/> class.
		/// </summary>
		/// <param name="display">
		/// A <see cref="IntPtr"/> that specifies the display handle used to create <paramref name="windowHandle"/>.
		/// </param>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context. If it is <see cref="IntPtr.Zero"/>
		/// the surface referenced by this NativeDeviceContext is a minimal PBuffer, or no surface at all in case EGL_KHR_surfaceless_context
		/// is supported.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public DeviceContextEGL(IntPtr display, IntPtr windowHandle)
			: this()
		{
			_NativeSurface = new NativeWindow(display, windowHandle);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextEGL"/> class.
		/// </summary>
		/// <param name='nativeBuffer'>
		/// A <see cref="INativePBuffer"/> that specifies the P-Buffer used to create the device context.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="nativeBuffer"/> is null.
		/// </exception>
		public DeviceContextEGL(INativePBuffer nativeBuffer)
			: this()
		{
			if (nativeBuffer == null)
				throw new ArgumentNullException(nameof(nativeBuffer));

			NativePBuffer nativePBuffer = nativeBuffer as NativePBuffer;
			if (nativePBuffer == null)
				throw new ArgumentException("INativePBuffer not created with DeviceContext.CreatePBuffer");

			_NativeSurface = nativePBuffer;

			IsPixelFormatSet = true;
		}

		#endregion

		#region Device Information

		/// <summary>
		/// The native surface used by this device context.
		/// </summary>
		private NativeSurface _NativeSurface;

		/// <summary>
		/// Get the display connection.
		/// </summary>
		internal IntPtr Display => _NativeSurface?._Display ?? IntPtr.Zero;

		/// <summary>
		/// Get the EGL surface handle.
		/// </summary>
		private IntPtr EglSurface => _NativeSurface?.Handle ?? new IntPtr(Egl.NO_DISPLAY);

		/// <summary>
		/// The frame buffer configuration.
		/// </summary>
		private IntPtr _Config;

		private int[] DefaultConfigAttribs
		{
			get
			{
				List<int> configAttribs = new List<int>();

				if (Version >= Egl.Version_120)
					configAttribs.AddRange(new[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });
				configAttribs.AddRange(new[] { Egl.SURFACE_TYPE, Egl.PBUFFER_BIT | Egl.WINDOW_BIT });
				configAttribs.AddRange(new[] {
					Egl.RED_SIZE, 8,
					Egl.GREEN_SIZE, 8,
					Egl.BLUE_SIZE, 8
				});
				configAttribs.Add(Egl.NONE);

				return configAttribs.ToArray();
			}
		}

		private int[] DefaultContextAttribs
		{
			get
			{
				List<int> contextAttribs = new List<int>();

				if (Version >= Egl.Version_130)
					contextAttribs.AddRange(new[] { Egl.CONTEXT_CLIENT_VERSION, 2 });
				contextAttribs.Add(Egl.NONE);

				return contextAttribs.ToArray();
			}
		}

		#endregion

		#region Window Factory

		/// <summary>
		/// Determine whether the hosting platform is able to create a P-Buffer.
		/// </summary>
		public new static bool IsPBufferSupported => true;

		/// <summary>
		/// Basic native EGL surface.
		/// </summary>
		/// <remarks>
		/// Holds EGL display and version.
		/// </remarks>
		internal abstract class NativeSurface : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Default constructor.
			/// </summary>
			/// <param name="display">
			/// A <see cref="IntPtr"/> that specifies the display handle to be passed to <see cref="Egl.GetDisplay(IntPtr)"/>.
			/// </param>
			protected NativeSurface(IntPtr display)
			{
				if ((_Display = Egl.GetDisplay(display)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to get display handle");

				int[] major = new int[1], minor = new int[1];

				if (Egl.Initialize(_Display, major, minor) == false)
					throw new InvalidOperationException("unable to initialize the display");

				_EglVersion = new KhronosVersion(major[0], minor[0], KhronosVersion.ApiEgl);
			}

			#endregion

			#region Handles

			/// <summary>
			/// The default display handle.
			/// </summary>
			public static readonly IntPtr DefaultDisplay = new IntPtr(Egl.DEFAULT_DISPLAY);

			/// <summary>
			/// Get the native surface handle.
			/// </summary>
			public abstract IntPtr Handle { get; }

			/// <summary>
			/// Create the native surface handle.
			/// </summary>
			/// <param name="configId">
			/// A <see cref="IntPtr"/> that specifies the configuration ID.
			/// </param>
			/// <param name="attribs">
			/// A <see cref="T:int[]"/> that lists the handle attributes.
			/// </param>
			/// <exception cref="InvalidOperationException">
			/// Exception thrown if the handle is already created.
			/// </exception>
			public abstract void CreateHandle(IntPtr configId, int[] attribs);

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			protected internal IntPtr _Display;

			/// <summary>
			/// EGL version.
			/// </summary>
			protected internal KhronosVersion _EglVersion;

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public virtual void Dispose()
			{
				if (_Display != IntPtr.Zero) {
					Egl.Terminate(_Display);
					_Display = IntPtr.Zero;
				}
			}

			#endregion
		}

		/// <summary>
		/// Native window implementation for Windows.
		/// </summary>
		internal sealed class NativeWindow : NativeSurface, INativeWindow
		{
			#region Constructors

			/// <summary>
			/// Construct a NativeWindow.
			/// </summary>
			/// <param name="display">
			/// A <see cref="IntPtr"/> that specifies the display handle to be passed to <see cref="Egl.GetDisplay(IntPtr)"/>.
			/// </param>
			public NativeWindow(IntPtr display)
				: this(display, Gl.NativeWindow.Handle)
			{

			}

			/// <summary>
			/// Construct a NativeWindow on an OS window
			/// </summary>
			/// <param name="display">
			/// A <see cref="IntPtr"/> that specifies the display handle to be passed to <see cref="Egl.GetDisplay(IntPtr)"/>.
			/// </param>
			/// <param name="windowHandle">
			/// A <see cref="IntPtr"/> that specifies the handle of the OS window.
			/// </param>
			public NativeWindow(IntPtr display, IntPtr windowHandle)
				: this(display, windowHandle, null)
			{

			}

			/// <summary>
			/// Construct a NativeWindow on an OS window.
			/// </summary>
			/// <param name="display">
			/// A <see cref="IntPtr"/> that specifies the display handle to be passed to <see cref="Egl.GetDisplay(IntPtr)"/>.
			/// </param>
			/// <param name="windowHandle">
			/// A <see cref="IntPtr"/> that specifies the handle of the OS window.
			/// </param>
			/// <param name="pixelFormat">
			/// A <see cref="DevicePixelFormat"/> used for choosing the NativeWindow pixel format configuration. It can
			/// be null; in this case the pixel format will be set elsewhere.
			/// </param>
			public NativeWindow(IntPtr display, IntPtr windowHandle, DevicePixelFormat pixelFormat)
				: base(display)
			{
				try {
					// Hold the window handle in case pixel format will be set later
					_WindowHandle = windowHandle;

					// Choose appropriate pixel format
					if (pixelFormat != null) {
						pixelFormat.RenderWindow = true;

						IntPtr configId = ChoosePixelFormat(_Display, _EglVersion, pixelFormat);
						List<int> attribs = new List<int>();

						if (pixelFormat.DoubleBuffer)
							attribs.AddRange(new[] { Egl.RENDER_BUFFER, Egl.BACK_BUFFER });
						attribs.Add(Egl.NONE);

						CreateHandle(configId, attribs.ToArray());
					}
				} catch {
					Dispose();
					throw;
				}
			}

			#endregion

			#region Handles

			/// <summary>
			/// The EGL window handle.
			/// </summary>
			private IntPtr _Handle;

			/// <summary>
			/// The OS window handle.
			/// </summary>
			private readonly IntPtr _WindowHandle;

			#endregion

			#region NativeSurface Overrides

			/// <summary>
			/// Get the EGL window handle.
			/// </summary>
			public override IntPtr Handle => _Handle;

			/// <summary>
			/// Create the native surface handle.
			/// </summary>
			/// <param name="configId">
			/// A <see cref="IntPtr"/> that specifies the configuration ID.
			/// </param>
			/// <param name="attribs">
			/// A <see cref="T:int[]"/> that lists the handle attributes.
			/// </param>
			/// <exception cref="InvalidOperationException">
			/// Exception thrown if the handle is already created.
			/// </exception>
			public override void CreateHandle(IntPtr configId, int[] attribs)
			{
				if (_Handle != IntPtr.Zero)
					throw new InvalidOperationException("handle already created");
				if (_WindowHandle == IntPtr.Zero && Egl.CurrentExtensions.SurfacelessContext_KHR == false)
					throw new InvalidOperationException("null window handle");

				if (_WindowHandle != IntPtr.Zero) {
					if ((_Handle = Egl.CreateWindowSurface(_Display, configId, _WindowHandle, attribs)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to create window surface");
				}
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Handle != IntPtr.Zero) {
					bool res = Egl.DestroySurface(_Display, _Handle);
					Debug.Assert(res);
					_Handle = IntPtr.Zero;
				}

				// Base implementation
				base.Dispose();
			}

			#endregion

			#region INativeWindow Implementation

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			IntPtr INativeWindow.Display => _Display;

			/// <summary>
			/// Get the native window handle.
			/// </summary>
			IntPtr INativeWindow.Handle => _Handle;

			#endregion
		}

		/// <summary>
		/// P-Buffer implementation for EGL.
		/// </summary>
		internal sealed class NativePBuffer : NativeSurface, INativePBuffer, INativeWindow
		{
			#region Constructors

			/// <summary>
			/// Construct a NativePBuffer with a specific pixel format and size.
			/// </summary>
			/// <param name="pixelFormat">
			/// A <see cref="DevicePixelFormat"/> that specifies the pixel format and the ancillary buffers required.
			/// </param>
			/// <param name="width">
			/// A <see cref="UInt32"/> that specifies the width of the P-Buffer, in pixels.
			/// </param>
			/// <param name="height">
			/// A <see cref="UInt32"/> that specifies the height of the P-Buffer, in pixels.
			/// </param>
			public NativePBuffer(DevicePixelFormat pixelFormat, uint width, uint height)
				: this(DefaultDisplay, pixelFormat, width, height)
			{

			}

			/// <summary>
			/// Construct a NativePBuffer with a specific pixel format and size.
			/// </summary>
			/// <param name="display">
			/// 
			/// </param>
			/// <param name="pixelFormat">
			/// A <see cref="DevicePixelFormat"/> that specifies the pixel format and the ancillary buffers required.
			/// </param>
			/// <param name="width">
			/// A <see cref="UInt32"/> that specifies the width of the P-Buffer, in pixels.
			/// </param>
			/// <param name="height">
			/// A <see cref="UInt32"/> that specifies the height of the P-Buffer, in pixels.
			/// </param>
			public NativePBuffer(IntPtr display, DevicePixelFormat pixelFormat, uint width, uint height)
				: base(display)
			{
				if (pixelFormat == null)
					throw new ArgumentNullException(nameof(pixelFormat));

				try {
					// Choose appropriate pixel format
					pixelFormat.RenderWindow = false;	// XXX
					pixelFormat.RenderPBuffer = true;

					IntPtr configId = ChoosePixelFormat(_Display, _EglVersion, pixelFormat);
					List<int> attribs = new List<int>();

					attribs.AddRange(new[] { Egl.WIDTH, (int)width });
					attribs.AddRange(new[] { Egl.HEIGHT, (int)height });
					attribs.Add(Egl.NONE);

					CreateHandle(configId, attribs.ToArray());
				} catch {
					Dispose();
					throw;
				}
			}

			#endregion

			#region Handles

			/// <summary>
			/// The P-Buffer handle.
			/// </summary>
			private IntPtr _Handle;

			#endregion

			#region NativeSurface Overrides

			/// <summary>
			/// Get the EGL window handle.
			/// </summary>
			public override IntPtr Handle => _Handle;

			/// <summary>
			/// Create the native surface handle.
			/// </summary>
			/// <param name="configId">
			/// A <see cref="IntPtr"/> that specifies the configuration ID.
			/// </param>
			/// <param name="attribs">
			/// A <see cref="T:int[]"/> that lists the handle attributes.
			/// </param>
			/// <exception cref="InvalidOperationException">
			/// Exception thrown if the handle is already created.
			/// </exception>
			public override void CreateHandle(IntPtr configId, int[] attribs)
			{
				if (_Handle != IntPtr.Zero)
					throw new InvalidOperationException("handle already created");

				if ((_Handle = Egl.CreatePbufferSurface(_Display, configId, attribs)) == IntPtr.Zero)
					throw new InvalidOperationException("unable to create window surface");
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Handle != IntPtr.Zero) {
					bool res = Egl.DestroySurface(_Display, _Handle);
					_Handle = IntPtr.Zero;
				}

				// Base implementation
				base.Dispose();
			}

			#endregion

			#region INativeWindow Implementation

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			IntPtr INativeWindow.Display => _Display;

			/// <summary>
			/// Get the native window handle.
			/// </summary>
			IntPtr INativeWindow.Handle => _Handle;

			#endregion
		}

		#endregion

		#region DeviceContext Overrides

		/// <summary>
		/// Get this DeviceContext API version.
		/// </summary>
		public override KhronosVersion Version => new KhronosVersion(_NativeSurface._EglVersion);

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

			if (Egl.ChooseConfig(Display, configAttribs, configs, configs.Length, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			int[] contextAttribs = DefaultContextAttribs;
			int[] surfaceAttribs = { Egl.NONE };

			if (Version >= Egl.Version_120) {
				if (Egl.BindAPI(Egl.OPENGL_ES_API) == false)
					throw new InvalidOperationException("no ES API");
			}

			if ((ctx = Egl.CreateContext(Display, configs[0], IntPtr.Zero, contextAttribs)) == IntPtr.Zero)
				throw new InvalidOperationException("unable to create context");

			if (_NativeSurface.Handle == IntPtr.Zero) {
				List<int> pbufferAttribs = new List<int>(surfaceAttribs);

				pbufferAttribs.RemoveAt(pbufferAttribs.Count - 1);
				pbufferAttribs.AddRange(new[] { Egl.WIDTH, 1, Egl.HEIGHT, 1 });
				pbufferAttribs.Add(Egl.NONE);

				_NativeSurface.CreateHandle(configs[0], pbufferAttribs.ToArray());
			}

			return ctx;
		}

		/// <summary>
		/// Get the APIs available on this device context. The API tokens are space separated, and they can be
		/// found in <see cref="KhronosVersion"/> definition.
		/// </summary>
		public override IEnumerable<string> AvailableAPIs
		{
			get { return Egl.AvailableApis; }
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
			return CreateContextAttrib(sharedContext, DefaultContextAttribs);
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
			return CreateContextAttrib(sharedContext, attribsList, new KhronosVersion(1, 0, CurrentAPI));
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
		/// <param name="api">
		/// A <see cref="KhronosVersion"/> that specifies the API to be implemented by the returned context. It can be null indicating the
		/// default API for this DeviceContext implementation. If it is possible, try to determine the API version also.
		/// </param>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="attribsList"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="attribsList"/> length is zero or if the last item of <paramref name="attribsList"/>
		/// is not zero.
		/// </exception>
		public override IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList, KhronosVersion api)
		{
			if (attribsList == null)
				throw new ArgumentNullException(nameof(attribsList));
			if (attribsList.Length == 0)
				throw new ArgumentException("zero length array", nameof(attribsList));
			if (attribsList[attribsList.Length - 1] != Egl.NONE)
				throw new ArgumentException("not EGL_NONE-terminated array", nameof(attribsList));

			IntPtr context;

			// Select surface pixel format automatically
			if (_NativeSurface != null && _NativeSurface.Handle != IntPtr.Zero) {
				int[] configId = new int[1];

				if (Egl.QuerySurface(Display, EglSurface, Egl.CONFIG_ID, configId) == false)
					throw new InvalidOperationException("unable to query EGL surface config ID");

				_Config = ChoosePixelFormat(Display, configId[0]);
			}

			// Bind API
			if (Version >= Egl.Version_120) {
				uint apiEnum;

				switch (api.Api) {
					case KhronosVersion.ApiGles2:
					case KhronosVersion.ApiGles1:
					case null:
						// Default
						apiEnum = Egl.OPENGL_ES_API;
						break;
					case KhronosVersion.ApiGl:
						apiEnum = Egl.OPENGL_API;
						break;
					case KhronosVersion.ApiVg:
						apiEnum = Egl.OPENVG_API;
						break;
					default:
						throw new InvalidOperationException($"'{api}' API not available");
				}
				if (Egl.BindAPI(apiEnum) == false)
					throw new InvalidOperationException("no ES API");
			} else if (api != null && api.Api != KhronosVersion.ApiGles2 && api.Api != KhronosVersion.ApiGles1)
				throw new InvalidOperationException($"'{api}' API not available");

			// Create context
			if ((context = Egl.CreateContext(Display, _Config, sharedContext, attribsList)) == IntPtr.Zero)
				throw new EglException(Egl.GetError());

			// Create native surface (pixel format pending)
			// @todo Back-buffer?
			if (_NativeSurface != null && _NativeSurface.Handle == IntPtr.Zero)
				_NativeSurface.CreateHandle(_Config, new[] { Egl.NONE });

			return context;
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
		protected override bool MakeCurrentCore(IntPtr ctx)
		{
			if (ctx != IntPtr.Zero) {
				// Ensure correct API bound
				if (Version >= Egl.Version_120) {
					int[] contextClientType = new int[1];

					if (Egl.QueryContext(Display, ctx, Egl.CONTEXT_CLIENT_TYPE, contextClientType)) {
						if (Egl.BindAPI((uint)contextClientType[0]) == false)
							throw new InvalidOperationException("no ES API");
					}
				}

				return Egl.MakeCurrent(Display, EglSurface, EglSurface, ctx);
			} else
				return Egl.MakeCurrent(Display, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
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

			return Egl.DestroyContext(Display, ctx);
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public override void SwapBuffers()
		{
			Egl.SwapBuffers(Display, EglSurface);
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
			return Egl.SwapInterval(Display, interval);
		}

		/// <summary>
		/// Query platform extensions available.
		/// </summary>
		internal override void QueryPlatformExtensions()
		{
			Egl.CurrentExtensions = new Egl.Extensions();
			Egl.CurrentExtensions.Query(Display, Version);
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
			return null;
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
					return _PixelFormatCache;

				_PixelFormatCache = new DevicePixelFormatCollection();

				// Get the number of pixel formats
				int configCount;
				if (Egl.GetConfigs(Display, null, 0, out configCount) == false)
					throw new InvalidOperationException("unable to get configurations count");

				IntPtr[] configs = new IntPtr[configCount];
				if (Egl.GetConfigs(Display, configs, configs.Length, out configCount) == false)
					throw new InvalidOperationException("unable to get configurations");
				
				foreach (IntPtr config in configs) {
					DevicePixelFormat pixelFormat = new DevicePixelFormat();
					int param;
					bool version12 = Version >= Egl.Version_120;
					bool version13 = Version >= Egl.Version_130;
					bool version14 = Version >= Egl.Version_140;

					if (Egl.GetConfigAttrib(Display, config, Egl.CONFIG_ID, out pixelFormat.FormatIndex) == false)
						throw new InvalidOperationException("unable to get configuration parameter CONFIG_ID");

					// Defaults to RGBA
					pixelFormat.RgbaUnsigned = true;
					pixelFormat.RenderWindow = true;
					pixelFormat.RenderBuffer = false;

					if (Egl.GetConfigAttrib(Display, config, Egl.BUFFER_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter BUFFER_SIZE");
					pixelFormat.ColorBits = param;

					if (Egl.GetConfigAttrib(Display, config, Egl.RED_SIZE, out pixelFormat.RedBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter RED_SIZE");
					if (Egl.GetConfigAttrib(Display, config, Egl.GREEN_SIZE, out pixelFormat.GreenBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter GREEN_SIZE");
					if (Egl.GetConfigAttrib(Display, config, Egl.BLUE_SIZE, out pixelFormat.BlueBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter BLUE_SIZE");
					if (Egl.GetConfigAttrib(Display, config, Egl.ALPHA_SIZE, out pixelFormat.AlphaBits) == false)
						throw new InvalidOperationException("unable to get configuration parameter ALPHA_SIZE");
					if (Egl.GetConfigAttrib(Display, config, Egl.ALPHA_MASK_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter ALPHA_MASK_SIZE");

					if (Egl.GetConfigAttrib(Display, config, Egl.DEPTH_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter DEPTH_SIZE");
					pixelFormat.DepthBits = param;

					if (Egl.GetConfigAttrib(Display, config, Egl.STENCIL_SIZE, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter STENCIL_SIZE");
					pixelFormat.StencilBits = param;

					if (Egl.GetConfigAttrib(Display, config, Egl.SAMPLES, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter SAMPLES");
					pixelFormat.MultisampleBits = param;

					if (Egl.GetConfigAttrib(Display, config, Egl.CONFIG_CAVEAT, out param) == false)
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
						if (Egl.GetConfigAttrib(Display, config, Egl.COLOR_BUFFER_TYPE, out param) == false)
							throw new InvalidOperationException("unable to get configuration parameter COLOR_BUFFER_TYPE");
						switch (param) {
							case Egl.RGB_BUFFER:
									break;
							case Egl.LUMINANCE_BUFFER:
								if (Egl.GetConfigAttrib(Display, config, Egl.LUMINANCE_SIZE, out param) == false)
									throw new InvalidOperationException("unable to get configuration parameter LUMINANCE_SIZE");
								// Overrides color bits
								pixelFormat.ColorBits = param;

								// ATM do not support luminance buffers
								continue;
						}
					}

					if (Egl.GetConfigAttrib(Display, config, Egl.MAX_SWAP_INTERVAL, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter MAX_SWAP_INTERVAL");
					if (Egl.GetConfigAttrib(Display, config, Egl.MIN_SWAP_INTERVAL, out param) == false)
						throw new InvalidOperationException("unable to get configuration parameter MIN_SWAP_INTERVAL");

					// EGL 1.3 attributes
					if (version13) {
						if (Egl.GetConfigAttrib(Display, config, Egl.CONFORMANT, out param) == false)
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
						if (Egl.GetConfigAttrib(Display, config, Egl.SURFACE_TYPE, out param) == false)
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

					// Double buffer and swap method can be determined only later, once the pixel format is set
					pixelFormat.DoubleBuffer = true;
					pixelFormat.SwapMethod = 0;

					// 
					_PixelFormatCache.Add(pixelFormat);
				}

				return _PixelFormatCache;
			}
		}

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		public override void ChoosePixelFormat(DevicePixelFormat pixelFormat)
		{
			if (_NativeSurface == null)
				return; // Support EGL_KHR_surfaceless_context

			if (_NativeSurface.Handle != IntPtr.Zero)
				throw new InvalidOperationException("pixel format already set");
			_Config = ChoosePixelFormat(Display, Version, pixelFormat);

			IsPixelFormatSet = true;
		}

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		private static IntPtr ChoosePixelFormat(IntPtr display, KhronosVersion version, DevicePixelFormat pixelFormat)
		{
			if (version == null)
				throw new ArgumentNullException(nameof(version));
			if (pixelFormat == null)
				throw new ArgumentNullException(nameof(pixelFormat));

			List<int> configAttribs = new List<int>();
			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[8];
			int surfaceType = 0;

			if (version >= Egl.Version_120)
				configAttribs.AddRange(new[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });

			if (pixelFormat.RenderWindow)
				surfaceType |= Egl.WINDOW_BIT;
			if (pixelFormat.RenderPBuffer)
				surfaceType |= Egl.PBUFFER_BIT;
			if (surfaceType != 0)
				configAttribs.AddRange(new[] { Egl.SURFACE_TYPE, surfaceType });

			switch (pixelFormat.ColorBits) {
				case 24:
					configAttribs.AddRange(new[] { Egl.RED_SIZE, 8, Egl.GREEN_SIZE, 8, Egl.BLUE_SIZE, 8 });
					break;
				case 32:
					configAttribs.AddRange(new[] { Egl.RED_SIZE, 8, Egl.GREEN_SIZE, 8, Egl.BLUE_SIZE, 8, Egl.ALPHA_SIZE, 8 });
					break;
				default:
					configAttribs.AddRange(new[] { Egl.BUFFER_SIZE, pixelFormat.ColorBits });
					break;
			}
			if (pixelFormat.DepthBits > 0)
				configAttribs.AddRange(new[] { Egl.DEPTH_SIZE, pixelFormat.DepthBits });
			if (pixelFormat.StencilBits > 0)
				configAttribs.AddRange(new[] { Egl.STENCIL_SIZE, pixelFormat.StencilBits });

			configAttribs.Add(Egl.NONE);

			if (Egl.ChooseConfig(display, configAttribs.ToArray(), configs, configs.Length, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			return configs[0];
		}

		private static IntPtr ChoosePixelFormat(IntPtr display, int configId)
		{
			List<int> configAttribs = new List<int>();
			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[8];

			configAttribs.AddRange(new[] { Egl.CONFIG_ID, configId });
			configAttribs.Add(Egl.NONE);

			if (Egl.ChooseConfig(display, configAttribs.ToArray(), configs, configs.Length, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			return configs[0];
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
				throw new ArgumentNullException(nameof(pixelFormat));
			if (_NativeSurface == null)
				return; // Support EGL_KHR_surfaceless_context
			if (_NativeSurface.Handle != IntPtr.Zero)
				throw new InvalidOperationException("pixel format already set");

			List<int> configAttribs = new List<int>();

			if (Version >= Egl.Version_120)
				configAttribs.AddRange(new[] { Egl.RENDERABLE_TYPE, Egl.OPENGL_ES2_BIT });
			configAttribs.AddRange(new[] {
				Egl.CONFIG_ID, pixelFormat.FormatIndex
			});
			configAttribs.Add(Egl.NONE);

			int[] configCount = new int[1];
			IntPtr[] configs = new IntPtr[1];

			if (Egl.ChooseConfig(Display, configAttribs.ToArray(), configs, 1, configCount) == false)
				throw new InvalidOperationException("unable to choose configuration");
			if (configCount[0] == 0)
				throw new InvalidOperationException("no available configuration");

			_Config = configs[0];

			IsPixelFormatSet = true;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			// Note: display must be disposed after device context disposition
			if (disposing) {
				if (_NativeSurface != null) {
					_NativeSurface.Dispose();
					_NativeSurface = null;
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
