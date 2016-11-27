
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
using System.Diagnostics;

namespace OpenGL
{
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
		internal static INativeWindow CreateWindow()
		{
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (new DeviceContextWGL.NativeWindow());
					case Platform.Id.Linux:
						return (new DeviceContextGLX.NativeWindow());
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return (new DeviceContextGLX.NativeWindow());
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
				}
			} else
				return (new DeviceContextEGL.NativePBuffer(new DevicePixelFormat(24), 1, 1));
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
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (new DeviceContextWGL.NativePBuffer(pixelFormat, width, height));
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
				}
			} else
				return (new DeviceContextEGL.NativePBuffer(pixelFormat, width, height));
		}

		/// <summary>
		/// Create a device context without a specific window.
		/// </summary>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static DeviceContext Create()
		{
			Debug.Assert(Gl._NativeWindow != null);

			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (new DeviceContextWGL());
					case Platform.Id.Linux:
						return (new DeviceContextGLX());
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return (new DeviceContextGLX());
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
				}
			} else
				return (new DeviceContextEGL(Gl._NativeWindow as INativePBuffer));
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
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (new DeviceContextWGL(windowHandle));
					case Platform.Id.Linux:
						return (new DeviceContextGLX(display, windowHandle));
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return (new DeviceContextGLX(display, windowHandle));
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Environment.OSVersion));
				}
			} else
				return (new DeviceContextEGL(windowHandle));
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
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (new DeviceContextWGL(nativeBuffer));
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Environment.OSVersion));
				}
			} else
				return (new DeviceContextEGL(nativeBuffer));
		}

		#endregion

		#region Referenceable Instance

		/// <summary>
		/// Number of shared instances of this IRenderResource.
		/// </summary>
		/// <remarks>
		/// The reference count shall be initially 0 on new instances.
		/// </remarks>
		public uint RefCount { get { return (_RefCount); } }

		/// <summary>
		/// Increment the shared IRenderResource reference count.
		/// </summary>
		/// <remarks>
		/// Incrementing the reference count for this resource prevents the system to dispose this instance.
		/// </remarks>
		public void IncRef()
		{
			_RefCount++;
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
			if (_RefCount > 0)
				_RefCount--;

			// Automatically dispose when no references are available
			if (_RefCount == 0)
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
		protected void ResetRefCount() { _RefCount = 0; }

		/// <summary>
		/// The count of references for this RenderResource.
		/// </summary>
		private uint _RefCount;

		#endregion

		#region Platform Methods

		/// <summary>
		/// Create a simple context.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		internal abstract IntPtr CreateSimpleContext();

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
		/// </exception>>
		public abstract IntPtr CreateContext(IntPtr sharedContext);

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
		public abstract IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList);

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
			if ((ctx != IntPtr.Zero) && (current == true))
				Gl.BindAPI();

			return (current);
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
		/// A <see cref="System.Int32"/> that specifies the minimum number of video frames that are displayed
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

		#endregion

		#region Context Version

		/// <summary>
		/// Get the OpenGL context current on the calling thread.
		/// </summary>
		/// <returns>
		/// It returns the handle of the OpenGL context current on the calling thread. It may return <see cref="IntPtr.Zero"/>
		/// indicating that no OpenGL context is current.
		/// </returns>
		public static IntPtr GetCurrentContext()
		{
			if (Egl.IsRequired == false) {
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.WindowsNT:
						return (Wgl.GetCurrentContext());
					case Platform.Id.Linux:
						return (Glx.GetCurrentContext());
					case Platform.Id.MacOS:
						if (Glx.IsRequired)
							return (Glx.GetCurrentContext());
						else
							throw new NotSupportedException("platform MacOS not supported without Glx.IsRequired=true");
					default:
						throw new NotSupportedException(String.Format("platform {0} not supported", Platform.CurrentPlatformId));
				}
			} else
				return (Egl.GetCurrentContext());
		}

		/// <summary>
		/// Query the version of the current OpenGL context.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="KhronosVersion"/> specifying teh actual version of <paramref name="ctx"/>.
		/// </returns>
		internal static KhronosVersion QueryContextVersion()
		{
			IntPtr ctx = GetCurrentContext();
			if (ctx == null)
				throw new InvalidOperationException("no current context");

			// Load minimal Gl functions for querying information
			IGetProcAddress getProcAddress = GetProcAddress.GetProcAddressGL;

			if (Egl.IsRequired == false) {
				Gl.BindAPIFunction(Gl.Version_100, "glGetError", getProcAddress);
				Gl.BindAPIFunction(Gl.Version_100, "glGetString", getProcAddress);
			} else {
				Gl.BindAPIFunction(Gl.Version_320_ES, "glGetError", getProcAddress);
				Gl.BindAPIFunction(Gl.Version_320_ES, "glGetString", getProcAddress);
			}

			// Parse version string (effective for detecting Desktop and ES contextes)
			KhronosVersion glversion = KhronosVersion.Parse(Gl.GetString(StringName.Version));

			// ATM do not support fancy context creation flags

			return (glversion);
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
		public bool IsDisposed { get { return (_Disposed); } }

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
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
		/// Flag indicating that this instance has been disposed.
		/// </summary>
		private bool _Disposed;

		#endregion
	}
}

