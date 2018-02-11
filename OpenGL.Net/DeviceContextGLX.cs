
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
using System.Diagnostics;
using System.Collections.Generic;

using Khronos;

namespace OpenGL
{
	/// <summary>
	///Device context for Unix-based platforms.
	/// </summary>
	sealed class DeviceContextGLX : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes the <see cref="DeviceContextGLX"/> class.
		/// </summary>
		static DeviceContextGLX()
		{
			// Be notified about XServer errors
			Glx.UnsafeNativeMethods.XSetErrorHandler(XServerErrorHandler);
		}

		/// <summary>
		/// Construct a <see cref="DeviceContextGLX"/> class.
		/// </summary>
		public DeviceContextGLX()
		{
			if (Gl.NativeWindow == null)
				throw new InvalidOperationException("no underlying native window", Gl.InitializationException);

			_Display = Gl.NativeWindow.Display;
			_WindowHandle = Gl.NativeWindow.Handle;

			// Query GLX extensions
			QueryVersion();

			if (Version < Glx.Version_130)
				throw new NotSupportedException("missing GLX 1.3 or greater");
		}

		/// <summary>
		/// Construct a <see cref="DeviceContextGLX"/> class, initialized with the display of a control.
		/// </summary>
		/// <param name="display">
		/// A <see cref="IntPtr"/> that specifies the display handle used to create <paramref name="windowHandle"/>.
		/// Specifies the connection to the X server.
		/// </param>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context.
		/// </param>
		/// <exception cref='ArgumentException'>
		/// Is thrown when <paramref name="windowHandle"/> is <see cref="IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="PlatformNotSupportedException">
		/// Exception thrown if the current assembly is not executed by a (supported) Mono runtime.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the current Mono runtime has not yet opened a display connection.
		/// </exception>
		public DeviceContextGLX(IntPtr display, IntPtr windowHandle)
		{
			if (display == IntPtr.Zero)
				throw new ArgumentException("invalid X display", "display");
			if (windowHandle == IntPtr.Zero)
				throw new ArgumentException("invalid X window", "windowHandle");

			_Display = display;
			_WindowHandle = windowHandle;

			// Query GLX extensions
			QueryVersion();

			if (Version < Glx.Version_130)
				throw new NotSupportedException("missing GLX 1.3 or greater");
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
		/// The opened display.
		/// </summary>
		private readonly IntPtr _Display;

		/// <summary>
		/// The window handle.
		/// </summary>
		private readonly IntPtr _WindowHandle;

		/// <summary>
		/// The framebuffer configuration (<see cref="SetPixelFormat"/>).
		/// </summary>
		private IntPtr _FBConfig;

		/// <summary>
		/// The <see cref="Glx.XVisualInfo"/> corresponding to <see cref="_FBConfig"/>
		/// </summary>
		private Glx.XVisualInfo _XVisualInfo;
		
		#endregion

		#region Window Factory

		/// <summary>
		/// Native window implementation for Windows.
		/// </summary>
		internal class NativeWindow : INativeWindow
		{
			#region Constructors

			/// <summary>
			/// Default constructor.
			/// </summary>
			public NativeWindow()
				: this(0, 0, 16, 16)
			{

			}

			/// <summary>
			/// Default constructor.
			/// </summary>
			public NativeWindow(int x, int y, uint width, uint height)
			{
				try {
					// Open display
					if ((_Display = Glx.XOpenDisplay(IntPtr.Zero)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to connect to X server");

					Glx.XVisualInfo visual;
					IntPtr config;

					int[] attributes = new int[] {
						Glx.DRAWABLE_TYPE, (int)Glx.WINDOW_BIT,
						Glx.RENDER_TYPE, (int)Glx.RGBA_BIT,
						Glx.DOUBLEBUFFER,  unchecked((int)Glx.DONT_CARE),
						Glx.RED_SIZE, 1,
						Glx.GREEN_SIZE, 1,
						Glx.BLUE_SIZE, 1,
						0
					};

					int screen = Glx.XDefaultScreen(_Display);

					// Get basic visual
					unsafe {
						int[] choosenConfigCount = new int[1];

						IntPtr* choosenConfigs = Glx.ChooseFBConfig(_Display, screen, attributes, choosenConfigCount);
						if (choosenConfigCount[0] == 0)
							throw new InvalidOperationException("unable to find basic visual");
						config = *choosenConfigs;
						visual = Glx.GetVisualFromFBConfig(_Display, config);

						Glx.XFree((IntPtr)choosenConfigs);

						// KhronosApi.LogComment("Choosen config is 0x{0}", config.ToString("X8"));
						// KhronosApi.LogComment("Choosen visual is {0}", visual);

						_InternalConfig = config;
						_InternalVisual = visual;
					}

					Glx.XSetWindowAttributes setWindowAttrs = new Glx.XSetWindowAttributes();
					IntPtr rootWindow = Glx.XRootWindow(_Display, screen);
					ulong setWindowAttrFlags = /* CWBorderPixel | CWColormap | CWEventMask*/ (1L<<3) | (1L<<13) | (1L<<11);

					setWindowAttrs.border_pixel = IntPtr.Zero;
					setWindowAttrs.event_mask = /* StructureNotifyMask	*/ new IntPtr(1L << 17);
					setWindowAttrs.colormap = Glx.XCreateColormap(_Display, rootWindow, visual.visual, /* AllocNone */ 0);

					if ((_Handle = Glx.XCreateWindow(_Display, rootWindow, x, y, (int)width, (int)height, 0, visual.depth, /* InputOutput */ 0, visual.visual, new UIntPtr(setWindowAttrFlags), ref setWindowAttrs)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to create window");

					// Assign FB configuration to window: essential to make CreateContext(IntPtr) working
					_GlxHandle = Glx.CreateWindow(_Display, config, _Handle, null);
				
				} catch {
					Dispose();
					throw;
				}
			}

			internal static IntPtr _InternalConfig;

			internal static Glx.XVisualInfo _InternalVisual;

			#endregion

			#region INativeWindow Implementation

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			IntPtr INativeWindow.Display { get { return (_Display); } }

			/// <summary>
			/// The native window handle.
			/// </summary>
			private IntPtr _Display;

			/// <summary>
			/// Get the native window handle.
			/// </summary>
			IntPtr INativeWindow.Handle { get { return (_GlxHandle); } }

			/// <summary>
			/// The native window handle.
			/// </summary>
			private IntPtr _Handle;

			/// <summary>
			/// The GLX window handle.
			/// </summary>
			private IntPtr _GlxHandle;

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public void Dispose()
			{
				if (_Handle != IntPtr.Zero) {
					Glx.UnsafeNativeMethods.XDestroyWindow(_Display, _Handle);
					_Handle = IntPtr.Zero;
				}

				if (_Display != IntPtr.Zero) {
					Glx.UnsafeNativeMethods.XCloseDisplay(_Display);
					_Display = IntPtr.Zero;
				}
			}

			#endregion
		}

		#endregion
		
		#region Multithreading Support
		
		/// <summary>
		/// Initializes the X11 multithreading.
		/// </summary>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public static void InitializeMultithreading()
		{
			// Ensure to have X11 thread system initialized
			int initialized = Glx.UnsafeNativeMethods.XInitThreads();
			KhronosApi.LogCommand("XInitThreads", initialized);
			
			if (initialized == 0)
				throw new InvalidOperationException("platform does not support multithreading");
			
			_MultithreadingInitialized = true;
		}
		
		/// <summary>
		/// Gets a value indicating whether if X11 multithreading is initialized.
		/// </summary>
		/// <value>
		/// It returns <c>true</c> if this instance is X11 multithreading is initialized; otherwise, <c>false</c>.
		/// </value>
		internal static bool IsMultithreadingInitialized { get { return (_MultithreadingInitialized); } }
		
		/// <summary>
		/// Flag indicating whether X11 multithreading is initialized.
		/// </summary>
		private static bool _MultithreadingInitialized;
		
		#endregion

		#region DeviceContext Overrides

		/// <summary>
		/// Get this DeviceContext API version.
		/// </summary>
		public override KhronosVersion Version { get { return (new KhronosVersion(_GlxVersion)); } }

		/// <summary>
		/// Query the GLX version supported by current implementation.
		/// </summary>
		private void QueryVersion()
		{
			using (Glx.XLock xLock = new Glx.XLock(Display)) {
				int[] majorArg = new int[1], minorArg = new int[1];
	
				Glx.QueryVersion(Display, majorArg, minorArg);

				_GlxVersion = new KhronosVersion(majorArg[0], minorArg[0], KhronosVersion.ApiGlx);
			}
		}
		
		/// <summary>
		/// The GLX major version.
		/// </summary>
		private KhronosVersion _GlxVersion;

		/// <summary>
		/// Create a simple context.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		internal override IntPtr CreateSimpleContext()
		{
			using (Glx.XLock xLock = new Glx.XLock(Display)) {
				// Create direct context
				IntPtr rContext = CreateContext(IntPtr.Zero);

				if (rContext == IntPtr.Zero)
					throw new InvalidOperationException("unable to create context");

				return (rContext);
			}
		}

		/// <summary>
		/// Get the APIs available on this device context. The API tokens are space separated, and they can be
		/// found in <see cref="KhronosVersion"/> definition.
		/// </summary>
		public override IEnumerable<string> AvailableAPIs
		{
			get { return (GetAvailableApis()); }
		}

		/// <summary>
		/// Get the APIs available on the WGL device context.
		/// </summary>
		/// <returns></returns>
		internal static string[] GetAvailableApis()
		{
			List<string> deviceApi = new List<string> { KhronosVersion.ApiGl };

			// Default
			// OpenGL ES via GLX_EXT_create_context_es(2)?_profile
			if (Glx.CurrentExtensions != null && Glx.CurrentExtensions.CreateContextEsProfile_EXT) {
				deviceApi.Add(KhronosVersion.ApiGles1);
				deviceApi.Add(KhronosVersion.ApiGles2);
			}

			return (deviceApi.ToArray());
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
			if (Glx.CurrentExtensions == null || Glx.CurrentExtensions.CreateContext_ARB == false) {
				using (Glx.XLock displayLock = new Glx.XLock(Display)) {
					// Get the corresponding X visual info
					Glx.XVisualInfo xVisualInfo = _XVisualInfo != null ? _XVisualInfo : GetVisualInfoFromXWindow(_WindowHandle);

					Debug.Assert(xVisualInfo != null, "SetPixelFormat not executed or undetected XVisualInfo");
					return (Glx.CreateContext(Display, xVisualInfo, sharedContext, true));
				}
			} else
				return (CreateContextAttrib(sharedContext, new int[] { Gl.NONE }));
		}

		/// <summary>
		/// Get the <see cref="Glx.XVisualInfo"/> set on the specified X window.
		/// </summary>
		/// <param name="xWindow">
		/// The <see cref="IntPtr"/> that specifies the handle of the X window.
		/// </param>
		/// <returns>
		/// It returns the <see cref="Glx.XVisualInfo"/> set on <paramref name="xWindow"/>.
		/// </returns>
		private Glx.XVisualInfo GetVisualInfoFromXWindow(IntPtr xWindow)
		{
			Glx.XVisualInfo xVisualInfo;
			uint[] windowFBConfigId = new uint[1];
			int screen = Glx.XDefaultScreen(_Display);

			// Get the FB configuration associated to the native window
			Glx.QueryDrawable(_Display, _WindowHandle, Glx.FBCONFIG_ID, windowFBConfigId);

			if (windowFBConfigId[0] == 0) {
				KhronosApi.LogComment("Glx.QueryDrawable cannot query Glx.FBCONFIG_ID. Query manually.");

				return (NativeWindow._InternalVisual);
			}

			unsafe {
				int[] attributes = new int[] {
					Glx.FBCONFIG_ID, (int)windowFBConfigId[0],
					0,
				};

				int[] choosenConfigCount = new int[1];

				IntPtr* choosenConfigs = Glx.ChooseFBConfig(_Display, screen, attributes, choosenConfigCount);
				if (choosenConfigCount[0] == 0)
					throw new InvalidOperationException("unable to find X Window visual configuration");
				IntPtr configId = *choosenConfigs;

				xVisualInfo = Glx.GetVisualFromFBConfig(_Display, configId);

				Glx.XFree((IntPtr)choosenConfigs);
			}

			return (xVisualInfo);
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
		/// Exception thrown if <paramref name="attribsList"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="attribsList"/> length is zero or if the last item of <paramref name="attribsList"/>
		/// is not zero.
		/// </exception>
		public override IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList)
		{
			return (CreateContextAttrib(sharedContext, attribsList, new KhronosVersion(1, 0, CurrentAPI)));
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
			if (api != null && api.Api != KhronosVersion.ApiGl) {
				List<int> adulteredAttribs = new List<int>(attribsList);

				// Support check
				switch (api.Api) {
					case KhronosVersion.ApiGles1:
					case KhronosVersion.ApiGles2:
						if (Glx.CurrentExtensions.CreateContextEsProfile_EXT == false)
							throw new NotSupportedException("OpenGL ES API not supported");
						break;
					default:
						throw new NotSupportedException(String.Format("'{0}' API not supported", api.Api));
				}

				// Remove trailing 0
				if (adulteredAttribs.Count > 0 && adulteredAttribs[adulteredAttribs.Count - 1] == Gl.NONE)
					adulteredAttribs.RemoveAt(adulteredAttribs.Count - 1);

				// Add required attributes
				int majorVersionIndex = adulteredAttribs.FindIndex(delegate(int item) { return (item == Gl.MAJOR_VERSION); });
				int minorVersionIndex = adulteredAttribs.FindIndex(delegate(int item) { return (item == Gl.MINOR_VERSION); });
				int profileMaskIndex = adulteredAttribs.FindIndex(delegate(int item) { return (item == Gl.CONTEXT_PROFILE_MASK); });

				if (majorVersionIndex < 0) {
					adulteredAttribs.AddRange(new int[] { Gl.MAJOR_VERSION, api.Major });
					majorVersionIndex = adulteredAttribs.Count - 2;
				}
						
				if (minorVersionIndex < 0) {
					adulteredAttribs.AddRange(new int[] { Gl.MINOR_VERSION, api.Minor });
					minorVersionIndex = adulteredAttribs.Count - 2;
				}
					
				if (profileMaskIndex < 0) {
					adulteredAttribs.AddRange(new int[] { Gl.CONTEXT_PROFILE_MASK, 0 });
					profileMaskIndex = adulteredAttribs.Count - 2;
				}

				switch (api.Api) {
					case KhronosVersion.ApiGles1:
						// Ignore API version: force always to 1.0
						adulteredAttribs[majorVersionIndex + 1] = 1;
						adulteredAttribs[minorVersionIndex + 1] = 1;
						adulteredAttribs[profileMaskIndex + 1] |= (int)Glx.CONTEXT_ES_PROFILE_BIT_EXT;
						break;
					case KhronosVersion.ApiGles2:
						// Uses API version: it may be greater than 2.0(?)
						adulteredAttribs[majorVersionIndex + 1] = api.Major;
						adulteredAttribs[minorVersionIndex + 1] = api.Minor;
						adulteredAttribs[profileMaskIndex + 1] |= (int)Glx.CONTEXT_ES_PROFILE_BIT_EXT;
						break;
					default:
						throw new NotSupportedException(String.Format("'{0}' API not supported", api.Api));
				}

				// Restore trailing 0
				adulteredAttribs.Add(Gl.NONE);

				using (Glx.XLock displayLock = new Glx.XLock(Display)) {
					Debug.Assert(_FBConfig != IntPtr.Zero, "SetPixelFormat not executed");
					return (Glx.CreateContextAttribsARB(Display, _FBConfig, sharedContext, true, adulteredAttribs.ToArray()));
				}
			} else {
				using (Glx.XLock displayLock = new Glx.XLock(Display)) {
					Debug.Assert(_FBConfig != IntPtr.Zero, "SetPixelFormat not executed");
					return (Glx.CreateContextAttribsARB(Display, _FBConfig, sharedContext, true, attribsList));
				}
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
		protected override bool MakeCurrentCore(IntPtr ctx)
		{
			using (Glx.XLock displayLock = new Glx.XLock(Display)) {
				return (Glx.MakeCurrent(Display, ctx != IntPtr.Zero ? _WindowHandle : IntPtr.Zero, ctx));
			}
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

			using (Glx.XLock displayLock = new Glx.XLock(Display)) {
				Glx.DestroyContext(Display, ctx);
			}

			return (true);
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public override void SwapBuffers()
		{
			using (Glx.XLock displayLock = new Glx.XLock(Display)) {
				Glx.SwapBuffers(Display, _WindowHandle);
			}
		}

		/// <summary>
		/// Control the the buffers swap of a device.
		/// </summary>
		/// <param name="interval">
		/// A <see cref="System.Int32"/> that specifies the minimum number of video frames that are displayed
		/// before a buffer swap will occur.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful.
		/// </returns>
		public override bool SwapInterval(int interval)
		{
			// Keep into account the SwapIntervalEXT and SwapIntervalSGI entry points, relative to
			// two equivalent GLX extensions

#if false
			using (Glx.XLock displayLock = new Glx.XLock(Display)) {
				if (Glx.Delegates.pglXSwapIntervalEXT != null) {
					Glx.SwapIntervalEXT(Display, _WindowHandle, interval);
					return (true);
				} else if (Glx.Delegates.pglXSwapIntervalSGI != null)
					return (Glx.SwapIntervalSGI(interval) == 0);
				else
					throw new InvalidOperationException("binding point SwapInterval{EXT|SGI} cannot be found");
			}
#else
			return (false);
#endif
		}

		/// <summary>
		/// Query platform extensions available.
		/// </summary>
		internal override void QueryPlatformExtensions()
		{
			Glx._CurrentExtensions = new Glx.Extensions();
			Glx._CurrentExtensions.Query(this);
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
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke")]
		public override Exception GetPlatformException()
		{
			Exception platformException = null;

			lock (_DisplayErrorsLock) {
				if ((platformException = _DisplayErrors[Display]) != null)
					_DisplayErrors[Display] = null;
			}

			return (platformException);
		}

		/// <summary>
		/// The XServer error handler, invoked each time a X/GLX routine raise an error.
		/// </summary>
		/// <param name="displayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <returns>
		/// It returns always 0.
		/// </returns>
		private static int XServerErrorHandler(IntPtr displayHandle, ref Glx.XErrorEvent error_event)
		{
			lock (_DisplayErrorsLock) {
				_DisplayErrors[displayHandle] = new GlxException(displayHandle, ref error_event);
			}

			return (0);
		}

		/// <summary>
		/// The display errors list lock.
		/// </summary>
		internal static readonly object _DisplayErrorsLock = new object();

		/// <summary>
		/// The display errors.
		/// </summary>
		internal static readonly Dictionary<IntPtr, Exception> _DisplayErrors = new Dictionary<IntPtr, Exception>();

		/// <summary>
		/// Get the pixel formats supported by this device.
		/// </summary>
		public override DevicePixelFormatCollection PixelsFormats
		{
			get
			{
				// Query GLX extensions
				Glx.Extensions glxExtensions = new Glx.Extensions();

				glxExtensions.Query(this);

				// Request configurations
				DevicePixelFormatCollection pFormats = new DevicePixelFormatCollection();

				using (Glx.XLock xLock = new Glx.XLock(Display)) {
					int configsCount = 0;

					unsafe
					{
						int screen = Glx.UnsafeNativeMethods.XDefaultScreen(_Display);
						IntPtr* configs = Glx.GetFBConfigs(Display, screen, out configsCount);

						for (int i = 0; i < configsCount; i++) {
							IntPtr configId = configs[i];
							int err, renderType, attribValue;

							#region Satisfy minimum requirements

							// Requires RGBA configuration
							err = Glx.GetFBConfigAttrib(Display, configId, Glx.RENDER_TYPE, out renderType);
							if (err != 0)
								throw new InvalidOperationException();
							if ((renderType & Glx.RGBA_BIT) == 0)
								continue;       // Ignore indexed visuals

							// Do not choose configurations with some caveat
							err = Glx.GetFBConfigAttrib(Display, configId, Glx.CONFIG_CAVEAT, out attribValue);
							if (attribValue == Glx.SLOW_CONFIG)
								continue;

							#endregion

							DevicePixelFormat pixelFormat = new DevicePixelFormat();

							pixelFormat.XFbConfig = configId;

							pixelFormat.XVisualInfo = Glx.GetVisualFromFBConfig(Display, configId);
							pixelFormat.RgbaUnsigned = (renderType & Glx.RGBA_FLOAT_BIT_ARB) == 0; ;
							pixelFormat.RgbaFloat = (renderType & Glx.RGBA_FLOAT_BIT_ARB) != 0;

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.DRAWABLE_TYPE, out attribValue);
							if (err != 0)
								throw new InvalidOperationException("unable to get DRAWABLE_TYPE from framebuffer configuration");

							pixelFormat.RenderWindow = (attribValue & Glx.WINDOW_BIT) != 0;
							pixelFormat.RenderBuffer = false;
							pixelFormat.RenderPBuffer = (attribValue & Glx.PBUFFER_BIT) != 0;

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.FBCONFIG_ID, out pixelFormat.FormatIndex);
							if (err != 0)
								throw new InvalidOperationException("unable to get FBCONFIG_ID from framebuffer configuration");

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.BUFFER_SIZE, out pixelFormat.ColorBits);
							if (err != 0)
								throw new InvalidOperationException("unable to get BUFFER_SIZE from framebuffer configuration");

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.DEPTH_SIZE, out pixelFormat.DepthBits);
							if (err != 0)
								throw new InvalidOperationException("unable to get DEPTH_SIZE from framebuffer configuration");

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.STENCIL_SIZE, out pixelFormat.StencilBits);
							if (err != 0)
								throw new InvalidOperationException("unable to get STENCIL_SIZE from framebuffer configuration");

							if (glxExtensions.Multisample_ARB) {
								int hasMultisample = 0;

								err = Glx.GetFBConfigAttrib(Display, configId, Glx.SAMPLE_BUFFERS, out hasMultisample);
								if (err != 0)
									throw new InvalidOperationException("unable to get SAMPLE_BUFFERS from framebuffer configuration");

								if (hasMultisample != 0) {
									pixelFormat.MultisampleBits = 0;
									err = Glx.GetFBConfigAttrib(Display, configId, Glx.SAMPLES, out pixelFormat.MultisampleBits);
									if (err != 0)
										throw new InvalidOperationException("unable to get SAMPLES from framebuffer configuration");
								} else
									pixelFormat.MultisampleBits = 0;
							}

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.DOUBLEBUFFER, out attribValue);
							if (err != 0)
								throw new InvalidOperationException("unable to get DOUBLEBUFFER from framebuffer configuration");
							pixelFormat.DoubleBuffer = attribValue != 0;

							err = Glx.GetFBConfigAttrib(Display, configId, Glx.STEREO, out attribValue);
							if (err != 0)
								throw new InvalidOperationException("unable to get STEREO from framebuffer configuration");
							pixelFormat.StereoBuffer = attribValue != 0;

							if (glxExtensions.FramebufferSRGB_ARB) {
								err = Glx.GetFBConfigAttrib(Display, configId, Glx.FRAMEBUFFER_SRGB_CAPABLE_ARB, out attribValue);
								if (err != 0)
									throw new InvalidOperationException("unable to get FRAMEBUFFER_SRGB_CAPABLE_ARB from framebuffer configuration");
								pixelFormat.SRGBCapable = attribValue != 0;
							} else
								pixelFormat.SRGBCapable = false;

							pFormats.Add(pixelFormat);
						}
					}
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
		public override void ChoosePixelFormat(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException("pixelFormat");

			int screen = Glx.XDefaultScreen(_Display);

			// Get basic visual
			Glx.XVisualInfo visual;
			IntPtr config;

			List<int> attributes = new List<int>();

			if (pixelFormat.RenderWindow)
				attributes.AddRange(new int[] { Glx.DRAWABLE_TYPE, (int)Glx.WINDOW_BIT });
			if (pixelFormat.RgbaUnsigned)
				attributes.AddRange(new int[] { Glx.RENDER_TYPE, (int)Glx.RGBA_BIT });
			if (pixelFormat.RgbaFloat)
				attributes.AddRange(new int[] { Glx.RENDER_TYPE, (int)Glx.RGBA_FLOAT_BIT_ARB });
			if (pixelFormat.DoubleBuffer)
			attributes.AddRange(new int[] { Glx.DOUBLEBUFFER,  Gl.TRUE });

			if (pixelFormat.ColorBits > 0) {
				switch (pixelFormat.ColorBits) {
					case 16:
						attributes.AddRange(new int[] { Glx.RED_SIZE, 5, Glx.GREEN_SIZE, 6, Glx.BLUE_SIZE, 8, Glx.ALPHA_SIZE, 5 });
						break;
					case 24:
						attributes.AddRange(new int[] { Glx.RED_SIZE, 8, Glx.GREEN_SIZE, 8, Glx.BLUE_SIZE, 8 });
						break;
					case 32:
						attributes.AddRange(new int[] { Glx.RED_SIZE, 8, Glx.GREEN_SIZE, 8, Glx.BLUE_SIZE, 8, Glx.ALPHA_SIZE, 8 });
						break;
					default:
						if (pixelFormat.ColorBits < 16)
							attributes.AddRange(new int[] { Glx.RED_SIZE, 1, Glx.GREEN_SIZE, 1, Glx.BLUE_SIZE, 1 });
						else {
							int bits = pixelFormat.ColorBits / 4;
							attributes.AddRange(new int[] { Glx.RED_SIZE, bits, Glx.GREEN_SIZE, bits, Glx.BLUE_SIZE, bits });
						}
						break;
				}
				
			}
			
			if (pixelFormat.DepthBits > 0)
				attributes.AddRange(new int[] { Glx.DEPTH_SIZE, pixelFormat.DepthBits });
			if (pixelFormat.StencilBits > 0)
				attributes.AddRange(new int[] { Glx.STENCIL_SIZE, pixelFormat.StencilBits });

			attributes.Add(0);

			unsafe {
				int[] choosenConfigCount = new int[1];

				IntPtr* choosenConfigs = Glx.ChooseFBConfig(_Display, screen, attributes.ToArray(), choosenConfigCount);
				if (choosenConfigCount[0] == 0)
					throw new InvalidOperationException("unable to choose visual");
				config = *choosenConfigs;
				// KhronosApi.LogComment("Choosen config is 0x{0}", config.ToString("X8"));

				visual = Glx.GetVisualFromFBConfig(_Display, config);
				// KhronosApi.LogComment("Choosen visual is {0}", visual);

				Glx.XFree((IntPtr)choosenConfigs);
			}

			_FBConfig = config;
			_XVisualInfo = visual;

			IsPixelFormatSet = true;
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

			_FBConfig = pixelFormat.XFbConfig;
			_XVisualInfo = pixelFormat.XVisualInfo;

			IsPixelFormatSet = true;
		}

		#endregion
	}
}