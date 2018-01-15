
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

using Khronos;

// ReSharper disable RedundantIfElseBlock
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <inheritdoc />
	/// <summary>
	/// Abstract device context.
	/// </summary>
	public abstract class DeviceContext : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static DeviceContext()
		{
			// The default API is GLES2 in the case Egl.IsRequired is initialized to true
			if (Egl.IsRequired)
				_DefaultAPI = KhronosVersion.ApiGles2;

			// Required for correct static initialization sequences
			Gl.Initialize();
		}

		#endregion

		#region Factory

		/// <summary>
		/// Create a native window.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="INativeWindow"/> that implements a native window on the underlying platform.
		/// </returns>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		internal static INativeWindow CreateHiddenWindow()
		{
#if !MONODROID
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return new DeviceContextWGL.NativeWindow();
					case Platform.Id.Linux:
						return new DeviceContextGLX.NativeWindow();
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return new DeviceContextGLX.NativeWindow();
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else {
				Debug.Assert(DeviceContextEGL.IsPBufferSupported);
				return new DeviceContextEGL.NativePBuffer(new DevicePixelFormat(24), 1, 1);
			}
#else
			Debug.Assert(DeviceContextEGL.IsPBufferSupported);
			return new DeviceContextEGL.NativePBuffer(new DevicePixelFormat(24), 1, 1);
#endif
		}

		/// <summary>
		/// Determine whether the hosting platform is able to create a P-Buffer.
		/// </summary>
		public static bool IsPBufferSupported
		{
			get
			{
#if !MONODROID
				if (Egl.IsRequired == false) {
					switch (Platform.CurrentPlatformId) {
						case Platform.Id.WindowsNT:
							return DeviceContextWGL.IsPBufferSupported;
						default:
							return false;
					}
				} else
#endif
					return DeviceContextEGL.IsPBufferSupported;
			}
		}

		/// <summary>
		/// Create an off-screen buffer.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="INativePBuffer"/> that implements a native P-Buffer on the underlying platform.
		/// </returns>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static INativePBuffer CreatePBuffer(DevicePixelFormat pixelFormat, uint width, uint height)
		{
#if !MONODROID
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return new DeviceContextWGL.NativePBuffer(pixelFormat, width, height);
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else
#endif
				return new DeviceContextEGL.NativePBuffer(pixelFormat, width, height);
		}

		/// <summary>
		/// Create a device context without a specific window.
		/// </summary>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static DeviceContext Create()
		{
#if !MONODROID
			if (IsEglRequired == false) {
				// OPENGL_NET_INIT environment set to NO?
				if (Gl.NativeWindow == null)
					throw new InvalidOperationException("OpenGL.Net not initialized", Gl.InitializationException);

				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return new DeviceContextWGL();
					case Platform.Id.Linux:
						return new DeviceContextGLX();
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return new DeviceContextGLX();
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else {
#endif
				// Create a surfaceless context
				if (Egl.CurrentExtensions == null || Egl.CurrentExtensions.SurfacelessContext_KHR == false) {
					// OPENGL_NET_INIT environment set to NO?
					if (Gl.NativeWindow == null)
						throw new InvalidOperationException("OpenGL.Net not initialized", Gl.InitializationException);

					INativePBuffer nativeBuffer = Gl.NativeWindow as INativePBuffer;
					if (nativeBuffer != null)
						return new DeviceContextEGL(nativeBuffer);

					INativeWindow nativeWindow = Gl.NativeWindow;
					if (nativeWindow != null)
						return new DeviceContextEGL(nativeWindow.Handle);

					throw new NotSupportedException("EGL surface not supported");
				} else
					return new DeviceContextEGL(IntPtr.Zero);
#if !MONODROID
			}
#endif
		}

		/// <summary>
		/// Create a device context on the specified window.
		/// </summary>
		/// <param name="display">
		/// A <see cref="IntPtr"/> that specifies the display handle associated to <paramref name="windowHandle"/>. Some platforms
		/// ignore this parameter (i.e. Windows or EGL implementation).
		/// </param>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context.
		/// </param>
		/// <exception cref='ArgumentException'>
		/// Is thrown when <paramref name="windowHandle"/> is <see cref="IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static DeviceContext Create(IntPtr display, IntPtr windowHandle)
		{
#if !MONODROID
			if (IsEglRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return new DeviceContextWGL(windowHandle);
					case Platform.Id.Linux:
						return new DeviceContextGLX(display, windowHandle);
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return new DeviceContextGLX(display, windowHandle);
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else
#endif
				return new DeviceContextEGL(display, windowHandle);
		}

		/// <summary>
		/// Create a device context on the specified P-Buffer.
		/// </summary>
		/// <param name="nativeBuffer">
		/// A <see cref="INativePBuffer"/> created with <see cref="CreatePBuffer(DevicePixelFormat, uint, uint)"/> which
		/// the created context shall be able to render on.
		/// </param>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static DeviceContext Create(INativePBuffer nativeBuffer)
		{
#if !MONODROID
			if (IsEglRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return new DeviceContextWGL(nativeBuffer);
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else
#endif
				return new DeviceContextEGL(nativeBuffer);
		}

		/// <summary>
		/// Get whether EGL device context is is required for implementing <see cref="DefaultAPI"/>.
		/// </summary>
		private static bool IsEglRequired
		{
			get
			{
#if !MONODROID
				// Default API management
				// - Select eglRequired if EGL is the only device API available
				// - Select eglRequired if desktop device does not support ES context creation
				// - Select eglRequired if VG context creation
				bool eglRequired = Egl.IsRequired;

				if (eglRequired)
					return true;

				switch (_DefaultAPI) {
					case KhronosVersion.ApiGl:
						// Leave EGL requirement to the system (i.e. ANDROID or Broadcom)
						break;
					case KhronosVersion.ApiGles1:
					case KhronosVersion.ApiGles2:
						string[] desktopAvailableApi;

						switch (Platform.CurrentPlatformId) {
							case Platform.Id.WindowsNT:
								desktopAvailableApi = DeviceContextWGL.GetAvailableApis();
								break;
							case Platform.Id.Linux:
								desktopAvailableApi = DeviceContextGLX.GetAvailableApis();
								break;
							case Platform.Id.MacOS:
								if (Glx.IsRequired)
									desktopAvailableApi = DeviceContextGLX.GetAvailableApis();
								else
									throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
								break;
							default:
								throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
						}
						Debug.Assert(desktopAvailableApi != null);

						if (Array.FindIndex(desktopAvailableApi, item => item == _DefaultAPI) < 0)
							eglRequired = true;
						break;
					case KhronosVersion.ApiVg:
						// EGL is the only way to access to VG
						eglRequired = true;
						break;
				}

				return eglRequired;
#else
				return true;
#endif
			}
		}

		#endregion

		#region Referenceable Instance

		/// <summary>
		/// Number of shared instances of this IRenderResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get; private set; }

		/// <summary>
		/// Increment the shared IRenderResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			RefCount++;
		}

		/// <summary>
		/// Decrement the shared IResource reference count.
		/// </summary>
		/// <remarks>
		/// Decrementing the reference count for this resource could cause this instance disposition. In the case
		/// the reference count equals 0 (with or without decrementing it), this instance will be disposed.
		/// </remarks>
		public void DecRef()
		{
			// Instance could be never referenced with IncRef
			if (RefCount > 0)
				RefCount--;

			// Automatically dispose when no references are available
			if (RefCount == 0)
				Dispose();
		}

		/// <summary>
		/// Reset the reference count of this instance.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This should be used in normal code.
		/// </para>
		/// <para>
		/// This routine could be useful in the case the deep-copoy implementation uses <see cref="Object.MemberwiseClone"/>,
		/// indeed copying the reference count.
		/// </para>
		/// </remarks>
		protected void ResetRefCount() { RefCount = 0; }

		#endregion

		#region Default API

		/// <summary>
		/// Get or set the default API, driving device context creation using <see cref="Create"/>,
		/// <see cref="Create(IntPtr, IntPtr)"/> or <see cref="Create(INativePBuffer)"/>.
		/// </summary>
		public static string DefaultAPI
		{
			get { return _DefaultAPI; }
			set
			{
				switch (value) {
					case KhronosVersion.ApiGl:
					case KhronosVersion.ApiGles1:
					case KhronosVersion.ApiGles2:
					case KhronosVersion.ApiGlsc2:
					case KhronosVersion.ApiVg:
						// Allowed values
						break;
					default:
						throw new InvalidOperationException("unsupported API");
				}
				_DefaultAPI = value;
			}
		}

		/// <summary>
		/// The default API driving device context creation.
		/// </summary>
		private static string _DefaultAPI = KhronosVersion.ApiGl;

		/// <summary>
		/// Get or set the current API driving device context creation.
		/// </summary>
		public string CurrentAPI { get; protected set; } = _DefaultAPI;

		#endregion

		#region Platform Methods

		/// <summary>
		/// Get this DeviceContext API version.
		/// </summary>
		public abstract KhronosVersion Version { get; }

		/// <summary>
		/// Create a simple context.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		internal abstract IntPtr CreateSimpleContext();

		/// <summary>
		///  Get the APIs available on this host.
		/// </summary>
		/// <returns>
		/// It returns the list of the APIs available on the current host.
		/// </returns>
		public static IEnumerable<string> GetAvailableAPIs()
		{
			List<string> availableAPIs = new List<string>();

			// Uses the default device
			using (DeviceContext deviceContext = Create()) {
				availableAPIs.AddRange(deviceContext.AvailableAPIs);
			}
#if INTEGRATES_EGL
			// Consider EGL availability
			if (!Egl.IsRequired && Egl.IsAvailable) {
				// Integrates EGL device context APIss

				Egl.IsRequired = true;
				try {
					if (Egl.IsRequired == true) {
						using (DeviceContext deviceContext = DeviceContext.Create()) {
							foreach (string availableAPI in deviceContext.AvailableAPIs)
								if (!availableAPIs.Contains(availableAPI))
									availableAPIs.Add(availableAPI);
						}
					}
				} finally {
					Egl.IsRequired = false;
				}
			} else {

			}
#endif

			return availableAPIs;
		}

		/// <summary>
		/// Get the APIs available on this device context. The API tokens are space separated, and they can be
		/// found in <see cref="KhronosVersion"/> definition. The returned value can be null; in this case only
		/// the explicit API is implemented.
		/// </summary>
		public virtual IEnumerable<string> AvailableAPIs
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Creates a compatible context.
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
		/// </exception>>
		public abstract IntPtr CreateContext(IntPtr sharedContext);

		/// <summary>
		/// Creates a context, specifying attributes, using the default API (see <see cref="DefaultAPI"/>).
		/// </summary>
		/// <param name="sharedContext">
		/// A <see cref="IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <param name="attribsList">
		/// A <see cref="T:Int32[]"/> that specifies the attributes list. The attribute list is dependent on the actual
		/// platform and the GL version and extension support.
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
		public abstract IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList);

		/// <summary>
		/// Creates a context, specifying attributes.
		/// </summary>
		/// <param name="sharedContext">
		/// A <see cref="IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <param name="attribsList">
		/// A <see cref="T:Int32[]"/> that specifies the attributes list. The attribute list is dependent on the actual
		/// platform and the GL version and extension support.
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
		/// Exception thrown if <see cref="attribsList"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="attribsList"/> length is zero or if the last item of <paramref name="attribsList"/>
		/// is not zero.
		/// </exception>
		public abstract IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList, KhronosVersion api);

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
		public virtual bool MakeCurrent(IntPtr ctx)
		{
			// Basic implementation
			bool current = MakeCurrentCore(ctx);

			// Link OpenGL procedures on Gl
			if (ctx == IntPtr.Zero || current != true)
				return current;

			switch (DefaultAPI) {
				case KhronosVersion.ApiGlsc2:
					// Special OpenGL SC2 management: loads only SC2 requirements
					// Note: in order to work, DefaultAPI should stay set to SC2! Otherwise user shall call BindAPI manually
					Gl.BindAPI(Gl.Version_200_SC, null);
					break;
				default:
					Gl.BindAPI();
					break;
			}

			return true;
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
		protected abstract bool MakeCurrentCore(IntPtr ctx);

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
		public abstract bool DeleteContext(IntPtr ctx);

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public abstract void SwapBuffers();

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
		public abstract bool SwapInterval(int interval);

		/// <summary>
		/// Query platform extensions available.
		/// </summary>
		internal abstract void QueryPlatformExtensions();

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
		public abstract Exception GetPlatformException();
		
		/// <summary>
		/// Get the pixel formats supported by this device.
		/// </summary>
		public abstract DevicePixelFormatCollection PixelsFormats { get; }

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		public abstract void ChoosePixelFormat(DevicePixelFormat pixelFormat);

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		public abstract void SetPixelFormat(DevicePixelFormat pixelFormat);

		/// <summary>
		/// Get the flag indicating whether this DeviceContext has a pixel format defined.
		/// </summary>
		public bool IsPixelFormatSet { get; protected set; }

		#endregion

		#region Get Current Context

		/// <summary>
		/// Get the OpenGL context current on the calling thread.
		/// </summary>
		/// <returns>
		/// It returns the handle of the OpenGL context current on the calling thread. It may return <see cref="IntPtr.Zero"/>
		/// indicating that no OpenGL context is current.
		/// </returns>
		public static IntPtr GetCurrentContext()
		{
#if !MONODROID
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return Wgl.GetCurrentContext();
					case Platform.Id.Linux:
						return Glx.GetCurrentContext();
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return Glx.GetCurrentContext();
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException($"platform {Platform.CurrentPlatformId} not supported");
				}
			} else
#endif
				return Egl.GetCurrentContext();
		}

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~DeviceContext()
		{
			Dispose(false);
		}

		/// <summary>
		/// Get whether this instance has been disposed.
		/// </summary>
		public bool IsDisposed { get; private set; }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected virtual void Dispose(bool disposing)
		{
			if (!disposing)
				return;
			// Mark as disposed
			IsDisposed = true;
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion
	}
}

