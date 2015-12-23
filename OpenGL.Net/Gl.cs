
// Copyright (C) 2015 Luca Piccioni
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

#define OPENGL_NET_SUPPORT_WGL
#define OPENGL_NET_SUPPORT_GLX

#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings.
	/// </summary>
	public partial class Gl : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Gl()
		{
			LinkOpenGLProcImports(typeof(Gl), out sImportMap, out sDelegates);
		}

		#endregion

		#region Imports/Delegates Management

		/// <summary>
		/// Synchronize OpenGL delegates.
		/// </summary>
		public static void SyncDelegates()
		{
			SynchDelegates(sImportMap, sDelegates);
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "opengl32.dll";

		/// <summary>
		/// Imported functions delegates.
		/// </summary>
		private static List<FieldInfo> sDelegates;

		/// <summary>
		/// Build a string->MethodInfo map to speed up extension loading.
		/// </summary>
		internal static SortedList<string, MethodInfo> sImportMap = null;

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			ErrorCode error = GetError();

			if (error != ErrorCode.NoError)
				throw new InvalidOperationException(error.ToString());
		}

		#endregion

		#region Call Log

		/// <summary>
		/// Get or set the enable flag for the OpenGL call log.
		/// </summary>
		public static bool CallLogEnabled = true;

		/// <summary>
		/// OpenGL logging utility.
		/// </summary>
		/// <param name="format">
		/// A <see cref="String"/> that speficies the format string.
		/// </param>
		/// <param name="args">
		/// A variable arrays of objects used for rendering the <paramref name="format"/>.
		/// </param>
		[Conditional("OPENGL_NET_CALL_LOG_ENABLED")]
		private static void CallLog(string format, params object[] args)
		{
			if (CallLogEnabled == false)
				return;

			Trace.TraceInformation(format, args);
		}

		#endregion

		#region WGL/GLX Platform Abstractions

		/// <summary>
		/// Creates a context.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context on which the context has to be created.
		/// </param>
		/// <returns>
		/// A <see cref="System.IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero; if this is the case, query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static IntPtr CreateContext(IDeviceContext deviceContext)
		{
			return (CreateContext(deviceContext, IntPtr.Zero));
		}

		/// <summary>
		/// Creates a context.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context on which the context has to be created.
		/// </param>
		/// <param name="sharedContext">
		/// A <see cref="System.IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <returns>
		/// A <see cref="System.IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero; if this is the case, query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown in the case <paramref name="sharedContext"/> is different from IntPtr.Zero, and the objects
		/// cannot be shared with it.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static IntPtr CreateContext(IDeviceContext deviceContext, IntPtr sharedContext)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");

			IntPtr renderContext = IntPtr.Zero;

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT:
					try {
						WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)deviceContext;

						renderContext = Wgl.CreateContext(winDeviceContext.DeviceContext);
						if ((renderContext != IntPtr.Zero) && (sharedContext != IntPtr.Zero)) {
							if (Wgl.ShareLists(renderContext, sharedContext) == false)
								throw new InvalidOperationException("failed to share object name space");
						}

						return (renderContext);
					} catch {
						if (renderContext != IntPtr.Zero)
							Wgl.DeleteContext(renderContext);
						throw;
					}
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						if (x11DeviceContext.XVisualInfo == null)
							throw new InvalidOperationException("no visual information");

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							return (Glx.CreateContext(x11DeviceContext.Display, x11DeviceContext.XVisualInfo, sharedContext, true));
						}
					}
#endif
				default:
					throw new NotSupportedException(String.Format("platform {0} is not supported", Environment.OSVersion.Platform));
			}
		}

		/// <summary>
		/// Creates a context, specifying attributes.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context on which the context has to be created.
		/// </param>
		/// <param name="sharedContext">
		/// A <see cref="System.IntPtr"/> that specify a context that will share objects with the returned one. If
		/// it is IntPtr.Zero, no sharing is performed.
		/// </param>
		/// <param name="attribsList">
		/// A <see cref="T:Int32[]"/> that specifies the attributes list.
		/// </param>
		/// <returns>
		/// A <see cref="System.IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero; if this is the case, query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> or <see cref="attribsList"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="attribsList"/> length is zero or if the last item of <paramref name="attribsList"/>
		/// is not zero.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static IntPtr CreateContextAttrib(IDeviceContext deviceContext, IntPtr sharedContext, int[] attribsList)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (attribsList == null)
				throw new ArgumentNullException("attribsList");
			if (attribsList.Length == 0)
				throw new ArgumentException("zero length array", "attribsList");
			if (attribsList[attribsList.Length - 1] != 0)
				throw new ArgumentException("not zero-terminated array", "attribsList");

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT: {
						WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)deviceContext;
						return (Wgl.CreateContextAttribsARB(winDeviceContext.DeviceContext, sharedContext, attribsList));
					}
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							return (Glx.CreateContextAttribsARB(x11DeviceContext.Display, x11DeviceContext.FBConfig, sharedContext, true, attribsList));
						}
					}
#endif
				default:
					throw new NotSupportedException(String.Format("platform {0} is not supported", Environment.OSVersion.Platform));
			}
		}

		/// <summary>
		/// Makes the context current on the calling thread.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context on which the context has to be current.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="ctx"/> that specify the context to be current on the calling thread, bound to
		/// <paramref name="deviceContext"/>. It can be IntPtr.Zero indicating that no context will be current.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful. If it returns false,
		/// query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static bool MakeContextCurrent(IDeviceContext deviceContext, IntPtr ctx)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT: {
						WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)deviceContext;

						return (Wgl.MakeCurrent(winDeviceContext.DeviceContext, ctx));
					}
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							return (Glx.MakeCurrent(x11DeviceContext.Display, ctx != IntPtr.Zero ? x11DeviceContext.WindowHandle : IntPtr.Zero, ctx));
						}
					}
#endif
				default:
					throw new NotSupportedException(String.Format("platform {0} is not supported", Environment.OSVersion.Platform));
			}
		}

		/// <summary>
		/// Deletes a context.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context used for creating the context <paramref name="ctx"/>.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="ctx"/> that specify the context to be deleted.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful. If it returns false,
		/// query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <remarks>
		/// <para>The context <paramref name="ctx"/> must not be current on any thread.</para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is IntPtr.Zero.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static bool DeleteContext(IDeviceContext deviceContext, IntPtr ctx)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (ctx == IntPtr.Zero)
				throw new ArgumentException("ctx");

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT:
					return (Wgl.DeleteContext(ctx));
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							Glx.DestroyContext(x11DeviceContext.Display, ctx);
						}
						return (true);
					}
#endif
				default:
					throw new NotSupportedException(String.Format("platform {0} is not supported", Environment.OSVersion.Platform));
			}
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specify the device context which buffers will be swapped.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful. If it returns false,
		/// query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static void SwapBuffers(IDeviceContext deviceContext)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT: {
						WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)deviceContext;

						Wgl.UnsafeNativeMethods.GdiSwapBuffersFast(winDeviceContext.DeviceContext);
					}
					break;
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							Glx.SwapBuffers(x11DeviceContext.Display, x11DeviceContext.WindowHandle);
						}
					}
					break;
#endif
				default:
					throw new NotSupportedException(String.Format("platform {0} is not supported", Environment.OSVersion.Platform));
			}
		}

		/// <summary>
		/// Control the the buffers swap of a device.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context which buffers will be swapped.
		/// </param>
		/// <param name="interval">
		/// A <see cref="System.Int32"/> that specifies the minimum number of video frames that are displayed
		/// before a buffer swap will occur.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether the operation was successful. If it returns false,
		/// query the exception by calling <see cref="GetPlatformException"/>.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="deviceContext"/> is null.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static bool SwapInterval(IDeviceContext deviceContext, int interval)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT:
					return (Wgl.SwapIntervalEXT(interval));
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						// Keep into account the SwapIntervalEXT and SwapIntervalSGI entry points, relative to
						// two equivalent GLX extensions

						using (Glx.XLock displayLock = new Glx.XLock(x11DeviceContext.Display)) {
							if (Glx.Delegates.pglXSwapIntervalEXT != null) {
								Glx.SwapIntervalEXT(x11DeviceContext.Display, x11DeviceContext.WindowHandle, interval);
								return (true);
							} else if (Glx.Delegates.pglXSwapIntervalSGI != null)
								return (Glx.SwapIntervalSGI(interval) == 0);
							else
								throw new InvalidOperationException("binding point SwapInterval{EXT|SGI} cannot be found");
						}
					}
#endif
				default:
					throw new NotSupportedException();
			}
		}

		/// <summary>
		/// Gets the platform exception relative to the last operation performed.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context on which an error occurred.
		/// </param>
		/// <returns>
		/// The platform exception relative to the last operation performed.
		/// </returns>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke")]
		public static Exception GetPlatformException(IDeviceContext deviceContext)
		{
			Exception platformException = null;

			switch (Environment.OSVersion.Platform) {
#if OPENGL_NET_SUPPORT_WGL
				case PlatformID.Win32Windows:
				case PlatformID.Win32NT: {
						int win32Error = Marshal.GetLastWin32Error();
						if (win32Error != 0)
							platformException = new System.ComponentModel.Win32Exception(win32Error);
					}
					break;
#endif

#if OPENGL_NET_SUPPORT_GLX
				case PlatformID.Unix: {
						XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;

						lock (mDisplayErrorsLock) {
							platformException = mDisplayErrors[x11DeviceContext.Display];
							mDisplayErrors[x11DeviceContext.Display] = null;
						}
					}
					break;
#endif
				default:
					throw new NotSupportedException(String.Format("{0} not supported", Environment.OSVersion.Platform));
			}

			return (platformException);
		}

#if OPENGL_NET_SUPPORT_GLX

		/// <summary>
		/// The XServer error handler, invoked each time a X/GLX routine raise an error.
		/// </summary>
		/// <param name="DisplayHandle">
		/// A <see cref="IntPtr"/> that specifies the handle of the display on which the error occurred.
		/// </param>
		/// <param name="error_event">
		/// A <see cref="Glx.XErrorEvent"/> that describe the error.
		/// </param>
		/// <returns>
		/// It returns always 0.
		/// </returns>
		internal static int XServerErrorHandler(IntPtr DisplayHandle, ref Glx.XErrorEvent error_event)
		{
			lock (mDisplayErrorsLock) {
				StringBuilder sb = new StringBuilder(1024);
				Glx.UnsafeNativeMethods.XGetErrorText(DisplayHandle, error_event.error_code, sb, 1024);

				string eventName = Enum.GetName(typeof(Glx.XEventName), error_event.type);
				string requestName = Enum.GetName(typeof(Glx.XRequest), error_event.request_code);

				if (String.IsNullOrEmpty(eventName))
					eventName = "Unknown";
				if (String.IsNullOrEmpty(requestName))
					requestName = "Unknown";

				// Additional details
				sb.AppendLine("\nX error details:");
				sb.AppendFormat("	X event name: '{0}' ({1})\n", eventName, error_event.type);
				sb.AppendFormat("	Display: 0x{0}\n", error_event.display.ToInt64().ToString("x"));
				sb.AppendFormat("	Resource ID: {0}\n", error_event.resourceid.ToInt64().ToString("x"));
				sb.AppendFormat("	Error code: {0}\n", error_event.error_code);
				sb.AppendFormat("	Major code: '{0}' ({1})\n", requestName, error_event.request_code);
				sb.AppendFormat("	Minor code: {0}", error_event.minor_code);

				mDisplayErrors[DisplayHandle] = new System.ComponentModel.Win32Exception(error_event.error_code, sb.ToString());
			}

			return (0);
		}

		/// <summary>
		/// The display errors list lock.
		/// </summary>
		private static readonly object mDisplayErrorsLock = new object();

		/// <summary>
		/// The display errors.
		/// </summary>
		private static readonly Dictionary<IntPtr, Exception> mDisplayErrors = new Dictionary<IntPtr, Exception>();

#endif

		#endregion
	}
}
