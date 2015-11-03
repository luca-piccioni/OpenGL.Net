
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Graphics context.
	/// </summary>
	/// <remarks>
	/// <para>
	/// A GraphicsContext represents an attachment to the graphic operations. It actually store the graphic state, which determines the
	/// graphical pipeline results.
	/// </para>
	/// <para>
	/// To construct a GraphicsContext instance, it is necessary a device context. The device context is a OS handle which represents a
	/// specific graphical device. You can note that there are constructors which does not require a device context parameter: in this cases
	/// a common device context is used implicitly.
	/// </para>
	/// <para>
	/// If it available, it is possible to request a particoular OpenGL implementation. To check availability, <see cref="GraphicsContext.Capabilities.CreateContext"/>
	/// or <see cref="GraphicsContext.Capabilities.CreateContextProfile"/> indicates whether it is possible to select a particoular OpenGL implementation
	/// only for a GraphicsContext instance.
	/// 
	/// Respect a particoular version requested, it is possible that the current OpenGL implementation returns a context that doesn't have the exact
	/// OpenGL version requested. In this cases it is assured that the OpenGL version requested it is implemented (i.e. actual OpenGL version is a
	/// superset of the requested one).
	/// 
	/// Without those OpenGL extensions, it won't be possible to request a different OpenGL implementation from the current one, which is queriable
	/// by accessing to <see cref="GraphicsContext.CurrentCaps"/>.
	/// </para>
	/// <para>
	/// It is possible to share resources with other GraphicsContext instances by specifying a GraphicsContext parameter at construction time. The
	/// resources could be shared are listed in <see cref="IRenderResource"/>. There can be sharing compatibility issues by sharing resources
	/// having different OpenGL implementations.
	/// 
	/// As generale rule, when an OpenGL version introduce a new object space class not implemented by another version, those two OpenGL version
	/// cannot share object spaces.
	/// </para>
	/// <para>
	/// GraphicsContext define OpenGL implementation capabilities with the type <see cref="GraphicsContext.Capabilities"/>. This type collection
	/// useful information about a specific OpenGL implementation. It defines general information, implementation limits and extension support.
	/// 
	/// GraphicsContext exposes the current implementation capabilities by the static property <see cref="GraphicsContext.CurrentCaps"/>. This information
	/// is static, and it represent the most extended implementation currently available. Normally this property is not used for testing OpenGL support
	/// and limits, since this information is dependent on the current context, which could not be a GraphicsContext with the current OpenGL version (because
	/// it is possible to request a specific OpenGL implementation version).
	/// 
	/// Since each OpenGL implementation version can support any OpenGL extension combination, each GraphicsContext has its own OpenGL support, which could
	/// differ from the current OpenGL support.
	/// 
	/// Because this, all methods which depends on OpenGL support take a parameter of type GraphicsContext: that parameter is used to test effective support
	/// and limits for the specific OpenGL context. Testing OpenGL context capabilities by means of <see cref="GraphicsContext.CurrentCaps"/> could lead to
	/// invalid operations since those capabilities are not referred to the currently bound context.
	/// </para>
	/// <para>
	/// Since the device context is constructed by specifying a device context, it is able to detect ... remove public interface!
	/// </para>
	/// <para>
	/// Before any operation, the GraphicsContext has to be current. Only one current context per thread is allowed, but multiple context can made current on
	/// a thread one at time. Once a GraphicsContext is current on a thread, it is possible to issue rendering commands, and the rendering commands result is
	/// dependent on the current GraphicsContext.
	/// 
	/// Issuing rendering commands without having a current context on the thread will lead to exceptions.
	/// 
	/// A GraphicsContext is made current by calling <see cref="MakeCurrent(System.Boolean)"/> or <see cref="MakeCurrent(System.IntPtr,System.Boolean)"/>. It is
	/// possible to check the GraphicsContext currency by calling <see cref="IsCurrent()"/>, or getting the current GraphicsContext for the thread
	/// by calling <see cref="GetCurrentContext"/>.
	/// </para>
	/// </remarks>
	public sealed class GraphicsContext : IDisposable
	{
		#region Constructors

		/// <summary>
		/// Static GraphicsContext constructor.
		/// </summary>
		/// <remarks>
		/// This method shall create an initial OpenGL context for querying extensions; then shall destroy it keeping track of extensions. Future GraphicsContext can
		/// use the inspected extensions to provide every acceleration as possible.
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception throw in the case the <see cref="System.Windows.Forms.Form"/> created cannot be used for getting a valid device context.
		/// </exception>
		static GraphicsContext()
		{
			// Create common hidden window/device
			_HiddenWindow = new System.Windows.Forms.Form();
			_HiddenWindowDevice = DeviceContextFactory.Create(_HiddenWindow);
			_HiddenWindowDevice.IncRef();

			// Create basic context
			IntPtr rContext;

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32S:
				case PlatformID.Win32Windows:
				case PlatformID.WinCE:
					rContext = CreateWinSimpleContext(_HiddenWindowDevice);
					break;
				case PlatformID.Unix:
					rContext = CreateX11SimpleContext(_HiddenWindowDevice);
					break;
				default:
					throw new NotSupportedException("unable to create OpenGL context on platform " + Environment.OSVersion.ToString());
			}

			// Query OpenGL informations
			bool current = Gl.MakeContextCurrent(_HiddenWindowDevice, rContext);
			if (current == false)
				throw new Exception("unable to make current");

			// Initialize OpenGL implementations descriptions
			RegisterSupportedOpenGLVersions();

			// Obtain current OpenGL implementation
			string glVersion = Gl.GetString(StringName.Vendor);
			sCurrentGLVersion = ParseGLVersion(glVersion);

			// Obtain current OpenGL Shading Language version
			string glslVersion = Gl.GetString(StringName.ShadingLanguageVersion);
			sCurrentShadingGLVersion = ParseGLSLVersion(glslVersion);

			// Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
			// sRenderCaps = GraphicsCapabilities.Query(this, _HiddenWindowDevice);
			// Cache current OpenGL capabilities
			_RenderCapsDb[sCurrentGLVersion] = _RenderCaps;

			// Detroy context
			if (Gl.DeleteContext(_HiddenWindowDevice, rContext) == false)
				throw new InvalidOperationException("unable to delete OpenGL context");
		}

		/// <summary>
		/// Creates an OpenGL context from a Windows platform.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/>
		/// </returns>
		private static IntPtr CreateWinSimpleContext(IDeviceContext rDevice)
		{
			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)rDevice;
			IntPtr rContext;

			// Define most compatible pixel format
			Wgl.PIXELFORMATDESCRIPTOR pfd;
			int pFormat;

			// Describe the pixel format fundamentals
			pfd.nVersion = 1; pfd.nSize = (short)Marshal.SizeOf(typeof(Wgl.PIXELFORMATDESCRIPTOR));
			pfd.iLayerType = Wgl.PFD_MAIN_PLANE;
			pfd.dwFlags = (Wgl.PFD_SUPPORT_OPENGL | Wgl.PFD_DOUBLEBUFFER | Wgl.PFD_DRAW_TO_WINDOW);
			pfd.iPixelType = Wgl.PFD_TYPE_RGBA;
			pfd.dwLayerMask = 0; pfd.dwVisibleMask = 0; pfd.dwDamageMask = 0;
			pfd.cAuxBuffers = 0;
			pfd.bReserved = 0;
			pfd.cColorBits = 32;
			pfd.cRedBits = 0; pfd.cRedShift = 0;
			pfd.cGreenBits = 0; pfd.cGreenShift = 0;
			pfd.cBlueBits = 0; pfd.cBlueShift = 0;
			pfd.cAlphaBits = 0; pfd.cAlphaShift = 0;
			pfd.cDepthBits = 0;
			pfd.cStencilBits = 0;
			pfd.cAccumBits = 0;
			pfd.cAccumRedBits = 0; pfd.cAccumGreenBits = 0; pfd.cAccumBlueBits = 0; pfd.cAccumAlphaBits = 0;

			// Find pixel format match
			if ((pFormat = Wgl.UnsafeNativeMethods.GdiChoosePixelFormat(winDeviceContext.DeviceContext, out pfd)) == 0)
				throw new NotSupportedException("unable to choose basic pixel format, error code " + Marshal.GetLastWin32Error());

			if (pfd.cColorBits == 0)
				throw new Exception("unable to select valid pixel format");
			// Set pixel format before creating OpenGL context
			if (Wgl.UnsafeNativeMethods.GdiSetPixelFormat(winDeviceContext.DeviceContext, pFormat, out pfd) == false)
				throw new Exception("unable to set valid pixel format");

			// Create a dummy OpenGL context to retrieve initial informations.
			if ((rContext = Wgl.CreateContext(winDeviceContext.DeviceContext)) == IntPtr.Zero)
				throw new Exception("unable to create OpenGL context");

			return (rContext);
		}

		/// <summary>
		/// Creates an OpenGL context from a Windows platform.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/>
		/// </returns>
		private static IntPtr CreateX11SimpleContext(IDeviceContext rDevice)
		{
			XServerDeviceContext x11DeviceCtx = (XServerDeviceContext)rDevice;
			IntPtr rContext;

			using (Glx.XLock xLock = new Glx.XLock(x11DeviceCtx.Display)) {
				int[] attributes = new int[] {
					Glx.RENDER_TYPE, (int)Glx.RGBA_BIT,
					0
				};

				// Get basic visual
				unsafe {
					int[] choosenConfigCount = new int[1];
					IntPtr* choosenConfigs = Glx.ChooseFBConfig(x11DeviceCtx.Display, x11DeviceCtx.Screen, attributes, choosenConfigCount);

					if (choosenConfigCount[0] == 0)
						throw new InvalidOperationException("unable to find basic visual");

					IntPtr choosenConfig = *choosenConfigs;

					x11DeviceCtx.XVisualInfo = Glx.GetVisualFromFBConfig(x11DeviceCtx.Display, choosenConfig);
					x11DeviceCtx.FBConfig = choosenConfig;

					Glx.UnsafeNativeMethods.XFree((IntPtr)choosenConfigs);
				}

				// Create direct context
				rContext = Glx.CreateContext(x11DeviceCtx.Display, x11DeviceCtx.XVisualInfo, IntPtr.Zero, true);
				if (rContext == IntPtr.Zero) {
					// Fallback to not direct context
					rContext = Glx.CreateContext(x11DeviceCtx.Display, x11DeviceCtx.XVisualInfo, IntPtr.Zero, false);
				}

				if (rContext == IntPtr.Zero)
					throw new InvalidOperationException("unable to create context");

				return (rContext);
			}
		}

		/// <summary>
		/// Force execution of static constructor.
		/// </summary>
		internal static void Touch() { _RenderCaps.GetHashCode(); }

		/// <summary>
		/// GraphicsContext constructor.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// This exception is throw in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		public GraphicsContext()
		{
			// Release device context on dispose
			_CommonDeviceContext = true;
			// Create render context
			CreateRenderContext(_HiddenWindowDevice, null, GLVersion.Current);
		}

		/// <summary>
		/// GraphicsContext constructor.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context which has to be linked this
		/// this Render context.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// This exception is throw in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		public GraphicsContext(IDeviceContext deviceContext)
		{
			// Create render context
			CreateRenderContext(deviceContext, null, GLVersion.Current);
		}

		/// <summary>
		/// Construct a GraphicsContext implementing the current OpenGL version.
		/// </summary>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this this Render context (to share resource with it).
		/// In the case this parameter is null, this is equivalent to <see cref="Derm.Render.GraphicsContext.ctor"/>
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// This exception is throw in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it was created by a thread different from the calling one.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it is disposed.
		/// </exception>
		public GraphicsContext(GraphicsContext hSharedContext)
		{
			// Release device context on dispose
			_CommonDeviceContext = true;
			// Create render context
			CreateRenderContext(_HiddenWindowDevice, hSharedContext, GLVersion.Current);
		}

		/// <summary>
		/// Construct a GraphicsContext implementing the current OpenGL version.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context which has to be linked this
		/// this Render context.
		/// </param>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this
		/// this Render context (to share resource with it).
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it was created by a thread different from the calling one.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it is disposed.
		/// </exception>
		public GraphicsContext(IDeviceContext deviceContext, GraphicsContext hSharedContext)
		{
			// Create render context
			CreateRenderContext(deviceContext, hSharedContext, GLVersion.Current);
		}

		/// <summary>
		/// Construct a GraphicsContext specifying the implemented OpenGL version.
		/// </summary>
		/// <param name="version">
		/// A <see cref="GLVersion"/> that specifies the minimum OpenGL version required to implement.
		/// </param>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this
		/// this Render context (to share resource with it).
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown in the case <paramref name="version"/> is different from the currently implemented by the derive,
		/// and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context are not implemented.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="version"/> specifies a forward compatible version (greater than or equal to
		/// <see cref="GLVersion.Version_3_2"/>), and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context
		/// are not implemented.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="devctx"/> is <see cref="System.IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// This exception is throw in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it was created by a thread different from the calling one.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it is disposed.
		/// </exception>
		public GraphicsContext(GLVersion version, GraphicsContext hSharedContext)
		{
			// Release device context on dispose
			_CommonDeviceContext = true;
			// Create render context
			CreateRenderContext(_HiddenWindowDevice, hSharedContext, version);
		}

		/// <summary>
		/// Construct a GraphicsContext specifying the implemented OpenGL version.
		/// </summary>
		/// <param name="version">
		/// A <see cref="GLVersion"/> that specifies the minimum OpenGL version required to implement.
		/// </param>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context which has to be linked this
		/// this Render context.
		/// </param>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this
		/// this Render context (to share resource with it).
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown in the case <paramref name="version"/> is different from the currently implemented by the derive,
		/// and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context are not implemented.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="version"/> specifies a forward compatible version (greater than or equal to
		/// <see cref="GLVersion.Version_3_2"/>), and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context
		/// are not implemented.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="devctx"/> is <see cref="System.IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// This exception is thrown in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it was created by a thread different from the calling one.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it is disposed.
		/// </exception>
		public GraphicsContext(GLVersion version, IDeviceContext deviceContext, GraphicsContext hSharedContext)
		{
			// Create render context
			CreateRenderContext(deviceContext, hSharedContext, version);
		}

		/// <summary>
		/// Create a GraphicsContext specifying the implemented OpenGL version and a shared object space.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context which has to be linked this this Render context.
		/// </param>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this
		/// this Render context (to share resource with it).
		/// </param>
		/// <param name="version">
		/// A <see cref="GLVersion"/> that specifies the minimum OpenGL version required to implement.
		/// </param>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="devctx"/> is <see cref="System.IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it is disposed.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown if <paramref name="hSharedContext"/> is not null and it was created by a thread different from the calling one.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// This exception is thrown in the case <paramref name="version"/> specifies a forward compatible version (greater than or equal to
		/// <see cref="GLVersion.Version_3_2"/>), and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context
		/// are not implemented.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown in the case <paramref name="version"/> is different from the currently implemented by the driver,
		/// and the OpenGL extension WGL_ARB_create_context_profile or WGL_ARB_create_context are not implemented.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// This exception is thrown in the case it's not possible to create a valid OpenGL context.
		/// </exception>
		private void CreateRenderContext(IDeviceContext deviceContext, GraphicsContext hSharedContext, GLVersion version)
		{
			try {
				IntPtr pSharedContext = (hSharedContext != null) ? hSharedContext._RenderContext : IntPtr.Zero;

#if DEBUG
				mConstructorStackTrace = Environment.StackTrace;
#endif

				// Defaulting OpenGL version
				if (version == GLVersion.Current)
					version = sCurrentGLVersion;

				// Store thread ID of the render context
				_RenderContextThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
				// Store thread ID of the device context
				_DeviceContextThreadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

				if (deviceContext == null)
					throw new ArgumentNullException("devctx");
				if ((hSharedContext != null) && (hSharedContext._DeviceContext == null))
					throw new ArgumentException("shared context disposed", "hSharedContext");
				if ((hSharedContext != null) && (hSharedContext._RenderContextThreadId != _RenderContextThreadId))
					throw new ArgumentException("shared context created from another thread", "hSharedContext");
				if ((version != sCurrentGLVersion) && ((CurrentCaps.CreateContext == false) && (CurrentCaps.CreateContextProfile == false)))
					throw new ArgumentException("unable to specify OpenGL version when GL_ARB_create_context[_profile] is not supported");
				if ((sVersionDb[version].ForwardCompatible == true) && ((CurrentCaps.CreateContext == false) && (CurrentCaps.CreateContextProfile == false)))
					throw new ArgumentException("unable to specify forward-compatible OpenGL version when GL_ARB_create_context[_profile] is not supported");

				// Store device context handle
				_DeviceContext = deviceContext;
                _DeviceContext.IncRef();

				if ((CurrentCaps.CreateContext || CurrentCaps.CreateContextProfile) && (version >= GLVersion.Version_3_0)) {
					List<int> cAttributes = new List<int>();
					int rContextFlags = 0;

					// Requires a specific version
					Debug.Assert(Wgl.CONTEXT_MAJOR_VERSION_ARB == Glx.CONTEXT_MAJOR_VERSION_ARB);
					Debug.Assert(Wgl.CONTEXT_MINOR_VERSION_ARB == Glx.CONTEXT_MINOR_VERSION_ARB);
					cAttributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, sVersionDb[version].GLMajor,
						Wgl.CONTEXT_MINOR_VERSION_ARB, sVersionDb[version].GLMinor
					});

					// Context flags
					Debug.Assert(Wgl.CONTEXT_FLAGS_ARB == Glx.CONTEXT_FLAGS_ARB);
					Debug.Assert(Wgl.CONTEXT_DEBUG_BIT_ARB == Glx.CONTEXT_DEBUG_BIT_ARB);
					Debug.Assert(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB == Glx.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
					// Context flags: forward compatible context
					if (sVersionDb[version].ForwardCompatible == true)
						rContextFlags |= (int)(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
					// Context flags: debug context
					rContextFlags |= (int)(Wgl.CONTEXT_DEBUG_BIT_ARB);
					cAttributes.AddRange(new int[] {
						Wgl.CONTEXT_FLAGS_ARB, rContextFlags
					});

                    // End of attributes
                    cAttributes.Add(0);

					// Create rendering context
					int[] contextAttributes = cAttributes.ToArray();

					if ((_RenderContext = Gl.CreateContextAttrib(_DeviceContext, pSharedContext, contextAttributes)) == IntPtr.Zero) {
						Exception platformException = GraphicsException.CheckPlatformErrors(_DeviceContext, false);

						throw new InvalidOperationException("unable to create context " + sVersionDb[version].GLMajor + "." + sVersionDb[version].GLMinor, platformException);
					}
				} else {
					// Create rendering context
					if ((_RenderContext = Gl.CreateContext(_DeviceContext, pSharedContext)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to create context " + sVersionDb[version].GLMajor + "." + sVersionDb[version].GLMinor);
				}

				GraphicsContext rContextCurrent = GetCurrentContext();		// Back current context, if any
				IDeviceContext rContextCurrentDevice = (rContextCurrent != null) ? rContextCurrent.mCurrentDeviceContext : null;

				// This will cause OpenGL operation flushed... not too bad
				MakeCurrent(deviceContext, true);

				// Get the current OpenGL implementation supported by this GraphicsContext
				mVersion = ParseGLVersion(Gl.GetString(StringName.Version));
				// Get the current OpenGL Shading Language implementation supported by this GraphicsContext
				mShadingVersion = ParseGLSLVersion(Gl.GetString(StringName.ShadingLanguageVersion));
				// Determine the compatibility profile
				mCompatibilityProfile = (version < GLVersion.Version_3_1) && (mVersion >= GLVersion.Version_3_1);

				// Cache context capabilities for this version
				if (_RenderCapsDb.ContainsKey(mVersion) == false)
					_RenderCapsDb[mVersion] = GraphicsCapabilities.Query(this, deviceContext);

				// Determine this GraphicsContext object name space and garbage service
				if (hSharedContext != null) {
					// Sharing same object name space
					mObjectNameSpace = hSharedContext.mObjectNameSpace;

					// Test for effective sharing
					TestSharingObjects(hSharedContext);
				} else {
					// Reserved object name space
					mObjectNameSpace = Guid.NewGuid();

					// Effective sharing false by default
				}

				// Restore previous current context, if any
				if (rContextCurrent != null)
					rContextCurrent.MakeCurrent(rContextCurrentDevice, true);
				else
					MakeCurrent(deviceContext, false);
			} catch {
				// Rethrow the exception
				throw;
			}
		}

#if DEBUG
		/// <summary>
		/// Stack trace when constructor were called.
		/// </summary>
		private string mConstructorStackTrace = String.Empty;
#endif

		#endregion

		#region OpenGL Versioning

		/// <summary>
		/// Supported OpenGL implementations.
		/// </summary>
		public enum GLVersion
		{
			/// <summary>
			/// OpenGL 1.0.
			/// </summary>
			Version_1_0 = 0,
			/// <summary>
			/// OpenGL 1.1.
			/// </summary>
			Version_1_1,
			/// <summary>
			/// OpenGL 1.2.
			/// </summary>
			Version_1_2,
			/// <summary>
			/// OpenGL 1.2.1.
			/// </summary>
			Version_1_2_1,
			/// <summary>
			/// OpenGL 1.3.
			/// </summary>
			Version_1_3,
			/// <summary>
			/// OpenGL 1.1.
			/// </summary>
			Version_1_4,
			/// <summary>
			/// OpenGL 1.5.
			/// </summary>
			Version_1_5,

			/// <summary>
			/// OpenGL 2.0.
			/// </summary>
			Version_2_0,
			/// <summary>
			/// OpenGL 2.1.
			/// </summary>
			Version_2_1,

			/// <summary>
			/// OpenGL 3.0.
			/// </summary>
			Version_3_0,
			/// <summary>
			/// OpenGL 3.1.
			/// </summary>
			Version_3_1,
			/// <summary>
			/// OpenGL 3.2.
			/// </summary>
			Version_3_2,
			/// <summary>
			/// OpenGL 3.3.
			/// </summary>
			Version_3_3,

			/// <summary>
			/// OpenGL 4.0.
			/// </summary>
			Version_4_0,
			/// <summary>
			/// OpenGL 4.1.
			/// </summary>
			Version_4_1,
			/// <summary>
			/// OpenGL 4.2.
			/// </summary>
			Version_4_2,
			/// <summary>
			/// OpenGL 4.3.
			/// </summary>
			Version_4_3,
			/// <summary>
			/// OpenGL 4.4.
			/// </summary>
			Version_4_4,
			/// <summary>
			/// OpenGL 4.5.
			/// </summary>
			Version_4_5,

			/// <summary>
			/// Current OpenGL implementation.
			/// </summary>
			Current
		}

		/// <summary>
		/// Supported OpenGL Shading Language implementations.
		/// </summary>
		public enum GLSLVersion
		{
			/// <summary>
			/// No OpenGL Shading Language implementation
			/// </summary>
			None = 0,
			/// <summary>
			/// OpenGL Shading Language 1.1.0.
			/// </summary>
			Version_1_1 = 110,
			/// <summary>
			/// OpenGL Shading Language 1.2.0.
			/// </summary>
			Version_1_2 = 120,
			/// <summary>
			/// OpenGL Shading Language 1.3.0.
			/// </summary>
			Version_1_3 = 130,
			/// <summary>
			/// OpenGL Shading Language 1.4.0.
			/// </summary>
			Version_1_4 = 140,
			/// <summary>
			/// OpenGL Shading Language 1.5.0.
			/// </summary>
			Version_1_5 = 150,
			/// <summary>
			/// Current OpenGL Shading Language implementation.
			/// </summary>
			Current = 65536,
		}

		/// <summary>
		/// The OpenGL version implemented by this GraphicsContext.
		/// </summary>
		public GLVersion Version { get { return (mVersion); } }

		/// <summary>
		/// The OpenGL Shading Language version implemented by this GraphicsContext.
		/// </summary>
		public GLSLVersion ShadingVersion { get { return (mShadingVersion); } }

		/// <summary>
		/// The compatibility profile presence implemented by this GraphicsContext.
		/// </summary>
		public bool CompatibilityProfile { get { return (mCompatibilityProfile); } }

		/// <summary>
		/// The OpenGL version implemented by this GraphicsContext.
		/// </summary>
		private GLVersion mVersion = GLVersion.Current;

		/// <summary>
		/// The OpenGL Shading Language version implemented by this GraphicsContext.
		/// </summary>
		private GLSLVersion mShadingVersion = GLSLVersion.Current;

		/// <summary>
		/// Compatibility profile enabled (only for versions greater than OpenGL 3.0).
		/// </summary>
		private bool mCompatibilityProfile = false;

		#region Version Database & Utilities

		/// <summary>
		/// Get the number representation of a <see cref="GLVersion"/>.
		/// </summary>
		/// <param name="version">
		/// A <see cref="GLVersion"/> which has to be represented by an integer.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> representing <paramref name="version"/>.
		/// </returns>
		internal static int GetGLVersionId(GLVersion version)
		{
			return (sVersionDb[version].GLVersionID);
		}

		/// <summary>
		/// Get the number representation of a <see cref="GLSLVersion"/>.
		/// </summary>
		/// <param name="version">
		/// A <see cref="GLSLVersion"/> which has to be represented by an integer.
		/// </param>
		/// <returns>
		/// It returns a <see cref="System.Int32"/> representing <paramref name="version"/>.
		/// </returns>
		internal static int GetGLSLVersionId(GLSLVersion version)
		{
			return (sShadingVersionDb[version].GLSLVersionID);
		}

		/// <summary>
		/// OpenGL standard implementation.
		/// </summary>
		internal struct GLVersionDescr
		{
			/// <summary>
			/// Major version for this OpenGL version.
			/// </summary>
			public int GLMajor { get { return (GLVersionID / 100); } }

			/// <summary>
			/// Minor version for this OpenGL version.
			/// </summary>
			public int GLMinor { get { return ((GLVersionID % 100) / 10); } }

			/// <summary>
			/// OpenGL version.
			/// </summary>
			public GLVersion GLVersion;
			/// <summary>
			/// OpenGL version identifier.
			/// </summary>
			public int GLVersionID;
			/// <summary>
			/// OpenGL Shading Language version.
			/// </summary>
			public GLSLVersion GLSLVersion;
			/// <summary>
			/// OpenGL Shading Language version identifier.
			/// </summary>
			public int GLSLVersionID;
			/// <summary>
			/// Implementation forward compatibility flag.
			/// </summary>
			public bool ForwardCompatible { get { return (GLVersion >= GraphicsContext.GLVersion.Version_3_0); } }
		}

		/// <summary>
		/// OpenGL version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL versions versions cannot be requested to be implemented.
		/// </remarks>
		internal static GLVersion sCurrentGLVersion;

		/// <summary>
		/// OpenGL Shading Language version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL Shading Language versions cannot be requested to be implemented.
		/// </remarks>
		internal static GLSLVersion sCurrentShadingGLVersion;

		/// <summary>
		/// Register supported OpenGL versions.
		/// </summary>
		private static void RegisterSupportedOpenGLVersions()
		{
			GLVersionDescr glVersionItem;

			// OpenGL 1.0
			glVersionItem.GLVersion = GLVersion.Version_1_0;
			glVersionItem.GLVersionID = 100;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_0] = glVersionItem;
			// OpenGL 1.1
			glVersionItem.GLVersion = GLVersion.Version_1_1;
			glVersionItem.GLVersionID = 110;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_1] = glVersionItem;
			// OpenGL 1.2
			glVersionItem.GLVersion = GLVersion.Version_1_2;
			glVersionItem.GLVersionID = 120;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_2] = glVersionItem;
			// OpenGL 1.2.1
			glVersionItem.GLVersion = GLVersion.Version_1_2_1;
			glVersionItem.GLVersionID = 121;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_2_1] = glVersionItem;
			// OpenGL 1.3
			glVersionItem.GLVersion = GLVersion.Version_1_3;
			glVersionItem.GLVersionID = 130;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_3] = glVersionItem;
			// OpenGL 1.4
			glVersionItem.GLVersion = GLVersion.Version_1_4;
			glVersionItem.GLVersionID = 140;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_4] = glVersionItem;
			// OpenGL 1.5
			glVersionItem.GLVersion = GLVersion.Version_1_5;
			glVersionItem.GLVersionID = 150;
			glVersionItem.GLSLVersion = GLSLVersion.None;
			glVersionItem.GLSLVersionID = 0;
			sVersionDb[GLVersion.Version_1_5] = glVersionItem;

			// OpenGL 2.0
			glVersionItem.GLVersion = GLVersion.Version_2_0;
			glVersionItem.GLVersionID = 200;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_2;
			glVersionItem.GLSLVersionID = 120;
			sVersionDb[GLVersion.Version_2_0] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_2] = glVersionItem;
			// OpenGL 2.1
			glVersionItem.GLVersion = GLVersion.Version_2_1;
			glVersionItem.GLVersionID = 210;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_2;
			glVersionItem.GLSLVersionID = 120;
			sVersionDb[GLVersion.Version_2_1] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_2] = glVersionItem;

			// OpenGL 3.0
			glVersionItem.GLVersion = GLVersion.Version_3_0;
			glVersionItem.GLVersionID = 300;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_3;
			glVersionItem.GLSLVersionID = 130;
			sVersionDb[GLVersion.Version_3_0] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_3] = glVersionItem;
			// OpenGL 3.1
			glVersionItem.GLVersion = GLVersion.Version_3_1;
			glVersionItem.GLVersionID = 310;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_4;
			glVersionItem.GLSLVersionID = 140;
			sVersionDb[GLVersion.Version_3_1] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_4] = glVersionItem;
			// OpenGL 3.2
			glVersionItem.GLVersion = GLVersion.Version_3_2;
			glVersionItem.GLVersionID = 320;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_5;
			glVersionItem.GLSLVersionID = 150;
			sVersionDb[GLVersion.Version_3_2] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_5] = glVersionItem;
			// OpenGL 3.3
			glVersionItem.GLVersion = GLVersion.Version_3_3;
			glVersionItem.GLVersionID = 330;
			glVersionItem.GLSLVersion = GLSLVersion.Version_1_5;
			glVersionItem.GLSLVersionID = 150;
			sVersionDb[GLVersion.Version_3_3] = glVersionItem;
			sShadingVersionDb[GLSLVersion.Version_1_5] = glVersionItem;
		}

		/// <summary>
		/// Parse OpenGL version string.
		/// </summary>
		private static GLVersion ParseGLVersion(string glVersionString)
		{
			if (glVersionString == null)
				throw new ArgumentNullException("glVersionString");

			Regex glVersionRegex = new Regex(@"(?<Major>\d)\.(?<Minor>\d)(\.(?<Revision>\d) *.*)?");
			Match glVersionMatch = glVersionRegex.Match(glVersionString);

			if (glVersionMatch.Success == false)
				throw new ArithmeticException(String.Format("{0} is not a valid OpenGL version string", glVersionString));

			GLVersion version = GLVersion.Version_1_0;
			int major, minor, rev = 0, glVersion;

			major = Int32.Parse(glVersionMatch.Groups["Major"].Value);
			minor = Int32.Parse(glVersionMatch.Groups["Minor"].Value);
			if (glVersionMatch.Groups["Revision"].Length > 0)
				rev = Int32.Parse(glVersionMatch.Groups["Revision"].Value);

			// Compose ID corresponding to this version
			glVersion = major * 100 + minor * 10 + rev;

			// Get the highest OpenGL version desciption
			foreach (GLVersionDescr vDescr in sVersionDb.Values) {
				if (vDescr.GLVersionID <= glVersion)
					version = vDescr.GLVersion;
			}

			return (version);
		}

		/// <summary>
		/// Parse OpenGL version string.
		/// </summary>
		private static GLSLVersion ParseGLSLVersion(string glslVersionString)
		{
			GLSLVersion version = GLSLVersion.None;
			Match versionMatch;
			int major, minor, glslVersion;

			if (glslVersionString == null)
				throw new ArgumentNullException("glVersionString");

			versionMatch = sGlslVersionRegex.Match(glslVersionString);

			if (versionMatch.Success == false)
				throw new ArgumentException(String.Format("version '{0}' not recognized", glslVersionString), "glslVersionString");

			// Parse OpenGL Shading Language version string
			major = Int32.Parse(versionMatch.Groups["Major"].Value, NumberFormatInfo.InvariantInfo);
			minor = Int32.Parse(versionMatch.Groups["Minor"].Value, NumberFormatInfo.InvariantInfo);

			// Cover version paterns like 1.20
			if (minor >= 10) minor /= 10;

			// Compose ID corresponding to this version
			glslVersion = major * 100 + minor * 10;

			// Get the highest OpenGL SL version desciption
			foreach (GLVersionDescr vDescr in sVersionDb.Values) {
				if ((int)vDescr.GLSLVersionID <= glslVersion) {
					version = vDescr.GLSLVersion;
				}
			}

			return (version);
		}

		/// <summary>
		/// Supported OpenGL implementations (indexed by OpenGL version).
		/// </summary>
		private static readonly Dictionary<GLVersion, GLVersionDescr> sVersionDb = new Dictionary<GLVersion, GLVersionDescr>();

		/// <summary>
		/// Supported OpenGL implementations (indexed by OpenGL Shading Language version, the default one).
		/// </summary>
		/// <remarks>
		/// Other implementation could implement lower OpenGL Shading Language version respect the default supported by
		/// the current OpenGL version.
		/// </remarks>
		private static readonly Dictionary<GLSLVersion, GLVersionDescr> sShadingVersionDb = new Dictionary<GLSLVersion, GLVersionDescr>();

		/// <summary>
		/// Regular expression for parsing OpenGL version string.
		/// </summary>
		private static Regex sGlVersionRegex = new Regex(@"^(?<Major>\d)\.(?<Minor>\d)(\.(?<Rev>\d))?");

		/// <summary>
		/// Regular expression for parsing OpenGL Shading Language version string.
		/// </summary>/
		private static Regex sGlslVersionRegex = new Regex(@"^(?<Major>\d)\.(?<Minor>\d{1,}).*");

		#endregion

		#endregion

		#region OpenGL Extension Support

		/// <summary>
		/// Get rendering context capabilities of this GraphicsContext.
		/// </summary>
		/// <returns>
		/// A <see cref="Capabilities"/> which specify all available OpenGL implementation features and limits.
		/// </returns>
		/// <remarks>
		/// 
		/// </remarks>
		public GraphicsCapabilities Caps
		{
			get
			{
				return (_RenderCapsDb[Version]);
			}
		}

		/// <summary>
		/// Get rendering context capabilities of the current OpenGL implementation.
		/// </summary>
		/// <returns>
		/// A <see cref="Capabilities"/> which specify all available OpenGL implementation features and limits.
		/// </returns>
		/// <remarks>
		/// 
		/// </remarks>
		public static GraphicsCapabilities CurrentCaps
		{
			get
			{
				return (_RenderCaps);
			}
		}

		/// <summary>
		/// Rendering context capabilities.
		/// </summary>
		/// <remarks>
		/// The <see cref="Capabilities"/> class is meant to represent a set of extensions and limits for a particoular OpenGL implementation. This
		/// means also that the render capabilities are dependent on the current context on the executing thread.
		/// </remarks>
		private static readonly GraphicsCapabilities _RenderCaps = new GraphicsCapabilities();

		/// <summary>
		/// Map OpenGL capabilities to a specific OpenGL version.
		/// </summary>
		/// <remarks>
		/// The use of this map suppose that the capabilities doesn't change between context having the same OpenGL version. At this
		/// moment is not clear if it really is.
		/// </remarks>
		private static readonly Dictionary<GLVersion, GraphicsCapabilities> _RenderCapsDb = new Dictionary<GLVersion, GraphicsCapabilities>();

		#endregion

		#region Device Pixel Formats

		/// <summary>
		/// Pixel format description.
		/// </summary>
		[DebuggerDisplay("Window: {RenderWindow}, Buffer: {RenderBuffer}, Color: {ColorBits}, Depth: {DepthBits}, Stencil: {StencilBits}, Multisample: {MultisampleBits}, DoubleBuffer: {DoubleBuffer}")]
		public struct PixelLayout
		{
			/// <summary>
			/// Pixel format index.
			/// </summary>
			public int FormatIndex;

			/// <summary>
			/// Flag indicating whether this pixel format provide canonical (normalized) unsigned integer RGBA color.
			/// </summary>
			public bool RgbaUnsigned;
			/// <summary>
			/// Flag indicating whether this pixel format provide RGBA color composed by single-precision floating-point.
			/// </summary>
			public bool RgbaFloat;

			/// <summary>
			/// Pixel format can be used for rendering on windows.
			/// </summary>
			public bool RenderWindow;
			/// <summary>
			/// Pixel format can be used for rendering on memory buffers.
			/// </summary>
			public bool RenderBuffer;
			/// <summary>
			/// Pixel format can be used for rendering on pixel buffer objects.
			/// </summary>
			public bool RenderPBuffer;

			/// <summary>
			/// Pixel format support double buffering.
			/// </summary>
			public bool DoubleBuffer;
			/// <summary>
			/// Method used for swapping back buffers.
			/// </summary>
			/// <remarks>
			/// It can assume the values Wgl.SWAP_EXCHANGE, SWAP_COPY, or 
			/// SWAP_UNDEFINED in the case DoubleBuffer is false.
			/// </remarks>
			public int SwapMethod;
			/// <summary>
			/// Pixel format support stereo buffering.
			/// </summary>
			public bool StereoBuffer;

			/// <summary>
			/// Color bits (without alpha).
			/// </summary>
			public int ColorBits;
			/// <summary>
			/// Depth buffer bits.
			/// </summary>
			public int DepthBits;
			/// <summary>
			/// Stencil buffer bits.
			/// </summary>
			public int StencilBits;
			/// <summary>
			/// Multisample bits.
			/// </summary>
			public int MultisampleBits;

			/// <summary>
			/// sRGB conversion capability.
			/// </summary>
			public bool SRGBCapable;

			/// <summary>
			/// GLX framebuffer configuration (valid only for X11).
			/// </summary>
			public IntPtr XFbConfig;

			/// <summary>
			/// GLX visual information (valid only for X11).
			/// </summary>
			public Glx.XVisualInfo XVisualInfo;
		}

		/// <summary>
		/// List of pixel format descriptions.
		/// </summary>
		[DebuggerDisplay("PixelFormatCollection({Count} Pixel Formats)")]
		public class PixelFormatCollection : List<PixelLayout>
		{
			#region Render Window Format Filtering

			#region Window Color Bits

			/// <summary>
			/// Get all possible color bit values for rendering on visibile windows.
			/// </summary>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowColorBits()
			{
				return (GetWindowColorBits(-1, -1, -1));
			}

			/// <summary>
			/// Get all possible color bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowColorBits(int bitsMultisample)
			{
				return (GetWindowColorBits(-1, -1, bitsMultisample));
			}

			/// <summary>
			/// Get all possible color bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowColorBits(int bitsDepth, int bitsMultisample)
			{
				return (GetWindowColorBits(bitsDepth, -1, bitsMultisample));
			}

			/// <summary>
			/// Get all possible color bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowColorBits(int bitsDepth, int bitsStencil, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;

				// Filter for window rendering type
				windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
				// Filter for buffer bits
				return (GetFormatColorBits(windowPixelFormats, bitsDepth, bitsStencil, bitsMultisample));
			}

			#endregion

			#region Window Depth Bits

			/// <summary>
			/// Get all possible depth bit values for rendering on visibile windows.
			/// </summary>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowDepthBits()
			{
				return (GetWindowDepthBits(-1, -1, -1));
			}

			/// <summary>
			/// Get all possible depth bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowDepthBits(int bitsColor)
			{
				return (GetWindowDepthBits(bitsColor, -1, -1));
			}

			/// <summary>
			/// Get all possible depth bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowDepthBits(int bitsColor, int bitsMultisample)
			{
				return (GetWindowDepthBits(bitsColor, -1, bitsMultisample));
			}

			/// <summary>
			/// Get all possible depth bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="colorBits">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowDepthBits(int colorBits, int bitsStencil, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;

				// Filter for window rendering type
				windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
				// Filter for buffer bits
				return (GetFormatDepthBits(windowPixelFormats, colorBits, bitsStencil, bitsMultisample));
			}

			#endregion

			#region Window Stencil Bits

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowStencilBits()
			{
				return (GetWindowStencilBits(-1, -1, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowStencilBits(int bitsColor)
			{
				return (GetWindowStencilBits(bitsColor, -1, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowStencilBits(int bitsColor, int bitsDepth)
			{
				return (GetWindowStencilBits(bitsColor, bitsDepth, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowStencilBits(int bitsColor, int bitsDepth, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;

				// Filter for window rendering type
				windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
				// Filter for buffer bits
				return (GetFormatStencilBits(windowPixelFormats, bitsColor, bitsDepth, bitsMultisample));
			}

			#endregion

			#region Window Multisample Bits

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowMultisampleBits()
			{
				return (GetWindowMultisampleBits(-1, -1, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowMultisampleBits(int bitsColor)
			{
				return (GetWindowMultisampleBits(bitsColor, -1, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowMultisampleBits(int bitsColor, int bitsDepth)
			{
				return (GetWindowMultisampleBits(bitsColor, bitsDepth, -1));
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on visibile windows.
			/// </summary>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetWindowMultisampleBits(int bitsColor, int bitsDepth, int bitsStencil)
			{
				List<PixelLayout> windowPixelFormats = this;

				// Filter for window rendering type
				windowPixelFormats = FilterPixelFormatByWindow(windowPixelFormats);
				// Filter for buffer bits
				return (GetFormatMultisampleBits(windowPixelFormats, bitsColor, bitsStencil, bitsStencil));
			}

			#endregion

			#endregion

			#region Render Buffer Format Filtering



			#endregion

			#region Render PBuffer Format Filtering



			#endregion

			#region Pixel Format Filtering

			#region Combined Bits Filter

			/// <summary>
			/// Get all possible color bit values for rendering on a certain pixel format list.
			/// </summary>
			/// <param name="pFormats">
			/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetFormatColorBits(List<PixelLayout> pFormats, int bitsDepth, int bitsStencil, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;
				SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

				// Filter for buffer bits
				if (bitsDepth > 0)
					pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
				if (bitsStencil > 0)
					pFormats = FilterPixelFormatByDepthBits(pFormats, bitsStencil);
				if (bitsMultisample > 0)
					pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
				// Find all unique color bits combinations
				foreach (PixelLayout pFormat in windowPixelFormats)
					if (windowColorBits.ContainsKey(pFormat.ColorBits) == false)
						windowColorBits.Add(pFormat.ColorBits, pFormat.ColorBits);

				return (windowColorBits.Keys);
			}

			/// <summary>
			/// Get all possible depth bit values for rendering on a certain pixel format list.
			/// </summary>
			/// <param name="pFormats">
			/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
			/// </param>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting color buffer bits.
			/// </returns>
			public IEnumerable<int> GetFormatDepthBits(List<PixelLayout> pFormats, int bitsColor, int bitsStencil, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;
				SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

				// Filter for buffer bits
				if (bitsColor > 0)
					pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
				if (bitsStencil > 0)
					pFormats = FilterPixelFormatByStencilBits(pFormats, bitsStencil);
				if (bitsMultisample > 0)
					pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
				// Find all unique color bits combinations
				foreach (PixelLayout pFormat in windowPixelFormats)
					if (windowColorBits.ContainsKey(pFormat.DepthBits) == false)
						windowColorBits.Add(pFormat.DepthBits, pFormat.ColorBits);

				return (windowColorBits.Keys);
			}

			/// <summary>
			/// Get all possible stencil bit values for rendering on a certain pixel format list.
			/// </summary>
			/// <param name="pFormats">
			/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
			/// </param>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsMultisample">
			/// A <see cref="System.Int32"/> that specifies the required multisample buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting depth buffer bits.
			/// </returns>
			public IEnumerable<int> GetFormatStencilBits(List<PixelLayout> pFormats, int bitsColor, int bitsDepth, int bitsMultisample)
			{
				List<PixelLayout> windowPixelFormats = this;
				SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

				// Filter for buffer bits
				if (bitsColor > 0)
					pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
				if (bitsDepth > 0)
					pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
				if (bitsMultisample > 0)
					pFormats = FilterPixelFormatByMultisampleBits(pFormats, bitsMultisample);
				// Find all unique color bits combinations
				foreach (PixelLayout pFormat in windowPixelFormats)
					if (windowColorBits.ContainsKey(pFormat.StencilBits) == false)
						windowColorBits.Add(pFormat.StencilBits, pFormat.ColorBits);

				return (windowColorBits.Keys);
			}

			/// <summary>
			/// Get all possible multisample bit values for rendering on a certain pixel format list.
			/// </summary>
			/// <param name="pFormats">
			/// A <see cref="System.Int32"/> that specifies the initially available pixel formats.
			/// </param>
			/// <param name="bitsColor">
			/// A <see cref="System.Int32"/> that specifies the required color buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsDepth">
			/// A <see cref="System.Int32"/> that specifies the required depth buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <param name="bitsStencil">
			/// A <see cref="System.Int32"/> that specifies the required stencil buffer bits. This parameter is ignored in the case is
			/// less or equals to 0.
			/// </param>
			/// <returns>
			/// It returns a list of integer values suitable for requesting multisample buffer bits.
			/// </returns>
			public IEnumerable<int> GetFormatMultisampleBits(List<PixelLayout> pFormats, int bitsColor, int bitsDepth, int bitsStencil)
			{
				List<PixelLayout> windowPixelFormats = this;
				SortedDictionary<int, int> windowColorBits = new SortedDictionary<int, int>();

				// Filter for buffer bits
				if (bitsColor > 0)
					pFormats = FilterPixelFormatByColorBits(pFormats, bitsColor);
				if (bitsDepth > 0)
					pFormats = FilterPixelFormatByDepthBits(pFormats, bitsDepth);
				if (bitsStencil > 0)
					pFormats = FilterPixelFormatByStencilBits(pFormats, bitsStencil);
				// Find all unique color bits combinations
				foreach (PixelLayout pFormat in windowPixelFormats)
					if (windowColorBits.ContainsKey(pFormat.MultisampleBits) == false)
						windowColorBits.Add(pFormat.MultisampleBits, pFormat.ColorBits);

				return (windowColorBits.Keys);
			}

			#endregion

			#region Render Mode Filter

			private List<PixelLayout> FilterPixelFormatByWindow(List<PixelLayout> formats)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.RenderWindow == true); }));
			}

			private List<PixelLayout> FilterPixelFormatByBuffer(List<PixelLayout> formats)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.RenderBuffer == true); }));
			}

			private List<PixelLayout> FilterPixelFormatByPBuffer(List<PixelLayout> formats)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.RenderPBuffer == true); }));
			}

			#endregion

			#region Color/Depth/Stencil/Multisample Bits Filter

			private List<PixelLayout> FilterPixelFormatByColorBits(List<PixelLayout> formats, int bits)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.ColorBits == bits); }));
			}

			private List<PixelLayout> FilterPixelFormatByDepthBits(List<PixelLayout> formats, int bits)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.DepthBits == bits); }));
			}

			private List<PixelLayout> FilterPixelFormatByStencilBits(List<PixelLayout> formats, int bits)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.StencilBits == bits); }));
			}

			private List<PixelLayout> FilterPixelFormatByMultisampleBits(List<PixelLayout> formats, int bits)
			{
				if (formats == null)
					throw new ArgumentNullException("formats");

				return (formats.FindAll(delegate(PixelLayout pFormat) { return (pFormat.MultisampleBits == bits); }));
			}

			#endregion

			#endregion
		}

		/// <summary>
		/// Query available pixel format of a device.
		/// </summary>
		/// <param name="rDevice">
		/// A <see cref="IntPtr"/> representing the device context which defined
		/// the available pixel formats.
		/// </param>
		/// <returns>
		/// </returns>
		public static PixelFormatCollection QueryPixelFormats(IDeviceContext deviceContext)
		{
			return (QueryPixelFormats(deviceContext, CurrentCaps));
		}

		/// <summary>
		/// Query available pixel format of a device.
		/// </summary>
		/// <param name="rDevice">
		/// A <see cref="IntPtr"/> representing the device context which defined
		/// the available pixel formats.
		/// </param>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for querying available pixel formats.
		/// </param>
		/// <returns>
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="ctx"/> is null.
		/// </exception>
		public static PixelFormatCollection QueryPixelFormats(IDeviceContext deviceContext, GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (QueryPixelFormats(deviceContext, ctx.Caps));
		}

		/// <summary>
		/// Query available pixel format of a device.
		/// </summary>
		/// <param name="rDevice">
		/// A <see cref="IntPtr"/> representing the device context which defined
		/// the available pixel formats.
		/// </param>
		/// <param name="caps">
		/// A <see cref="GraphicsContext.Capabilities"/> that declares which extension are supported by a particoular OpenGL version.
		/// </param>
		/// <returns>
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="rDevice"/> is <see cref="System.IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="caps"/> is null.
		/// </exception>
		public static PixelFormatCollection QueryPixelFormats(IDeviceContext deviceContext, GraphicsCapabilities caps)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (caps == null)
				throw new ArgumentNullException("caps");

			sLog.Debug("Query available device pixel formats:");

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32Windows:
				case PlatformID.Win32S:
				case PlatformID.WinCE:
					return (QueryPixelFormatsWgl(deviceContext, caps));
				case PlatformID.Unix:
					return (QueryPixelFormatsGlx(deviceContext, caps));
				default:
					throw new NotSupportedException();
			}
		}

		private static PixelFormatCollection QueryPixelFormatsWgl(IDeviceContext deviceContext, GraphicsCapabilities caps)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (caps == null)
				throw new ArgumentNullException("caps");

			WindowsDeviceContext winDeviceContext = (WindowsDeviceContext)deviceContext;
			PixelFormatCollection pFormats = new PixelFormatCollection();
			List<int> pfAttributesCodes = new List<int>(12);
			int[] pfAttributesValue;

			// Minimum requirements
			pfAttributesCodes.Add(Wgl.SUPPORT_OPENGL_ARB);		// Required to be Gl.TRUE
			pfAttributesCodes.Add(Wgl.ACCELERATION_ARB);		// Required to be Wgl.FULL_ACCELERATION or Wgl.ACCELERATION_ARB
			pfAttributesCodes.Add(Wgl.PIXEL_TYPE_ARB);
			// Buffer destination
			pfAttributesCodes.Add(Wgl.DRAW_TO_WINDOW_ARB);
			pfAttributesCodes.Add(Wgl.DRAW_TO_BITMAP_ARB);
			pfAttributesCodes.Add(Wgl.DRAW_TO_PBUFFER_ARB);
			// Multiple buffers
			pfAttributesCodes.Add(Wgl.DOUBLE_BUFFER_ARB);
			pfAttributesCodes.Add(Wgl.SWAP_METHOD_ARB);
			pfAttributesCodes.Add(Wgl.STEREO_ARB);
			// Pixel description
			pfAttributesCodes.Add(Wgl.COLOR_BITS_ARB);
			pfAttributesCodes.Add(Wgl.DEPTH_BITS_ARB);
			pfAttributesCodes.Add(Wgl.STENCIL_BITS_ARB);
			// Multisample extension
			if (caps.Multisample == true) {
				pfAttributesCodes.Add(Wgl.SAMPLE_BUFFERS_ARB);
				pfAttributesCodes.Add(Wgl.SAMPLES_ARB);
			}
#if false
			// Framebuffer sRGB extension
			if ((caps.FramebufferSRGB == true) || (caps.FramebufferSRGB_EXT == true)) {
				pfAttributesCodes.Add(Wgl.FRAMEBUFFER_SRGB_CAPABLE_ARB);
			}
#endif

			sLog.Debug("ID |Unsigned|Float|Window|Buffer|PBuffer| C | D | S |MS| DB  | SWP        | ST  ");
			sLog.Debug("--------------------------------------------------------------------------------");

			pfAttributesValue = new int[pfAttributesCodes.Count];
			for (int pFormatIndex = 1; ; pFormatIndex++) {
				PixelLayout pFormat;

				if (Wgl.GetPixelFormatAttribARB(winDeviceContext.DeviceContext, pFormatIndex, 0, (uint)pfAttributesCodes.Count, pfAttributesCodes.ToArray(), pfAttributesValue) == false) {
					Debug.Assert(pFormats.Count > 0, "wrong pixel format attribute list");
					break;	// All pixel format are queried
				}

				// Check minimum requirements
				if (pfAttributesValue[0] != Gl.TRUE)
					continue;		// No OpenGL support
				if (pfAttributesValue[1] != Wgl.FULL_ACCELERATION_ARB)
					continue;		// No hardware acceleration
				if (pfAttributesValue[2] != Wgl.TYPE_RGBA_ARB)
					continue;		// Ignored pixel type

				// Collect pixel format attributes
				pFormat.FormatIndex = pFormatIndex;

				pFormat.RgbaUnsigned = pfAttributesValue[2] == Wgl.TYPE_RGBA_ARB;
				pFormat.RgbaFloat = pfAttributesValue[2] == Wgl.TYPE_RGBA_FLOAT_ARB;

				pFormat.RenderWindow = pfAttributesValue[3] == Gl.TRUE;
				pFormat.RenderBuffer = pfAttributesValue[4] == Gl.TRUE;
				pFormat.RenderPBuffer = pfAttributesValue[5] == Gl.TRUE;

				pFormat.DoubleBuffer = pfAttributesValue[6] == Gl.TRUE;
				pFormat.SwapMethod = pfAttributesValue[7];
				pFormat.StereoBuffer = pfAttributesValue[8] == Gl.TRUE;

				pFormat.ColorBits = pfAttributesValue[9];
				pFormat.DepthBits = pfAttributesValue[10];
				pFormat.StencilBits = pfAttributesValue[11];

				if (caps.Multisample == true) {
					// pfAttributesValue[12] ? What about multiple sample buffers?
					pFormat.MultisampleBits = pfAttributesValue[13];
				} else
					pFormat.MultisampleBits = 0;

#if false
                XXX Problems with 2.1 contextes
				if ((caps.FramebufferSRGB == true) || (caps.FramebufferSRGB_EXT == true)) {
					pFormat.SRGBCapable = pfAttributesValue[13] != 0;
				} else
#endif
				pFormat.SRGBCapable = false;
				pFormat.XFbConfig = IntPtr.Zero;
				pFormat.XVisualInfo = new Glx.XVisualInfo();

				pFormats.Add(pFormat);

				string swapMethodString = "Undefined";

				if (pFormat.SwapMethod == Wgl.SWAP_EXCHANGE_ARB)
					swapMethodString = "Swap ";
				if (pFormat.SwapMethod == Wgl.SWAP_COPY_ARB)
					swapMethodString = "Copy ";

				sLog.Debug("{0,3}|{1,8}|{2,5}|{3,6}|{4,6}|{5,7}|{6,3}|{7,3}|{8,3}|{9,2}|{10,5}|{11,9}|{12,5}",
					pFormatIndex,
					pFormat.RgbaUnsigned,
					pFormat.RgbaFloat,
					pFormat.RenderWindow,
					pFormat.RenderBuffer,
					pFormat.RenderPBuffer,
					pFormat.ColorBits,
					pFormat.DepthBits,
					pFormat.StencilBits,
					pFormat.MultisampleBits,
					pFormat.DoubleBuffer,
					swapMethodString,
					pFormat.StereoBuffer
				);
			}

			sLog.Debug("--------------------------------------------------------------------------------");

			return (pFormats);
		}

		private static PixelFormatCollection QueryPixelFormatsGlx(IDeviceContext deviceContext, GraphicsCapabilities caps)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (caps == null)
				throw new ArgumentNullException("caps");

			XServerDeviceContext x11DeviceContext = (XServerDeviceContext)deviceContext;
			PixelFormatCollection pFormats = new PixelFormatCollection();

			using (Glx.XLock xLock = new Glx.XLock(x11DeviceContext.Display)) {
				int configsCount = 0;

				unsafe {
					IntPtr* configs = Glx.GetFBConfigs(x11DeviceContext.Display, x11DeviceContext.Screen, out configsCount);

					for (int i = 0; i < configsCount; i++) {
						IntPtr configId = configs[i];
						int err, renderType, attribValue;

						#region Satisfy minimum requirements

						// Requires RGBA configuration
						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.RENDER_TYPE, out renderType);
						if (err != 0)
							throw new InvalidOperationException();
						if ((renderType & Glx.RGBA_BIT) == 0)
							continue;		// Ignore indexed visuals

						// Do not choose configurations with some caveat
						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.CONFIG_CAVEAT, out attribValue);
						if (attribValue == Glx.SLOW_CONFIG)
							continue;

						#endregion

						PixelLayout pixelFormat = new PixelLayout();

						pixelFormat.XFbConfig = configId;

                        pixelFormat.XVisualInfo = Glx.GetVisualFromFBConfig(x11DeviceContext.Display, configId);
						pixelFormat.RgbaUnsigned = (renderType & Glx.RGBA_FLOAT_BIT_ARB) == 0; ;
						pixelFormat.RgbaFloat = (renderType & Glx.RGBA_FLOAT_BIT_ARB) != 0;

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.DRAWABLE_TYPE, out attribValue);
						if (err != 0)
							throw new InvalidOperationException("unable to get DRAWABLE_TYPE from framebuffer configuration");

						pixelFormat.RenderWindow = (attribValue & Glx.WINDOW_BIT) != 0;
						pixelFormat.RenderBuffer = false;
						pixelFormat.RenderPBuffer = (attribValue & Glx.PBUFFER_BIT) != 0;

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.FBCONFIG_ID, out pixelFormat.FormatIndex);
						if (err != 0)
							throw new InvalidOperationException("unable to get FBCONFIG_ID from framebuffer configuration");

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.BUFFER_SIZE, out pixelFormat.ColorBits);
						if (err != 0)
							throw new InvalidOperationException("unable to get BUFFER_SIZE from framebuffer configuration");

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.DEPTH_SIZE, out pixelFormat.DepthBits);
						if (err != 0)
							throw new InvalidOperationException("unable to get DEPTH_SIZE from framebuffer configuration");

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.STENCIL_SIZE, out pixelFormat.StencilBits);
						if (err != 0)
							throw new InvalidOperationException("unable to get STENCIL_SIZE from framebuffer configuration");

						if (caps.Multisample) {
							int hasMultisample = 0;

							err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.SAMPLE_BUFFERS, out hasMultisample);
							if (err != 0)
								throw new InvalidOperationException("unable to get SAMPLE_BUFFERS from framebuffer configuration");

							if (hasMultisample != 0) {
								pixelFormat.MultisampleBits = 0;
								err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.SAMPLES, out pixelFormat.MultisampleBits);
								if (err != 0)
									throw new InvalidOperationException("unable to get SAMPLES from framebuffer configuration");
							} else
								pixelFormat.MultisampleBits = 0;
						}

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.DOUBLEBUFFER, out attribValue);
						if (err != 0)
							throw new InvalidOperationException("unable to get DOUBLEBUFFER from framebuffer configuration");
						pixelFormat.DoubleBuffer = attribValue != 0;

						err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.STEREO, out attribValue);
						if (err != 0)
							throw new InvalidOperationException("unable to get STEREO from framebuffer configuration");
						pixelFormat.StereoBuffer = attribValue != 0;

						if (caps.FramebufferSRGB) {
							err = Glx.GetFBConfigAttrib(x11DeviceContext.Display, configId, Glx.FRAMEBUFFER_SRGB_CAPABLE_ARB, out attribValue);
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

		#endregion

		#region Object Name Space Sharing

		#region Object Class Sharing

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing texture objects.
		/// </summary>
		public bool ShareTextureObjects { get { return (IsSharedObjectClass(Texture.TextureObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing shader objects.
		/// </summary>
		public bool ShareShaderObjects { get { return (IsSharedObjectClass(ShaderObject.ShaderObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing shader program objects.
		/// </summary>
		public bool ShareShaderProgramObjects { get { return (IsSharedObjectClass(ShaderProgram.ShaderProgramObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing render buffer objects.
		/// </summary>
		public bool ShareRenderBufferObjects { get { return (IsSharedObjectClass(RenderBuffer.RenderBufferObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing render buffer objects.
		/// </summary>
		public bool ShareFramebufferObjects { get { return (IsSharedObjectClass(RenderBuffer.RenderBufferObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing vertex buffer objects.
		/// </summary>
		public bool ShareVertexBufferObjects { get { return (IsSharedObjectClass(BufferObject.BufferObjectClass)); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing vertex array objects.
		/// </summary>
		public bool ShareVertexArrayObjects { get { return (IsSharedObjectClass(VertexArrayObject.VertexArrayObjectClass)); } }

		#endregion

		/// <summary>
		/// GraphicsContext object name space.
		/// </summary>
		internal Guid ObjectNameSpace { get { return (mObjectNameSpace); } }

		/// <summary>
		/// Property that specify whether this GraphicsContext is sharing a specific object class.
		/// </summary>
		/// <param name="class"></param>
		/// <returns></returns>
		internal bool IsSharedObjectClass(Guid @class)
		{
			return ((mSharedObjectClasses != null) && (mSharedObjectClasses.Contains(@class)));
		}

		/// <summary>
		/// Execute a benchmark to determine whether this GraphicsContext can share various object.
		/// </summary>
		/// <param name="rContextShare">
		/// A <see cref="GraphicsContext"/> sharing with this GraphicsContext.
		/// </param>
		private void TestSharingObjects(GraphicsContext rContextShare)
		{
			if (rContextShare == null)
				throw new ArgumentNullException("rContextShare");
			if (IsCurrent == false)
				throw new InvalidOperationException("not current");

			#region Create Objects

			// Create objects on this GraphicsContext
			uint texture = 0;
			uint shader = 0;
			uint shaderProgram = 0;
			uint renderBuffer = 0;
			uint framebuffer = 0;
			uint vertexBuffer = 0;
			uint vertexArray = 0;

			#region Textures

			if (Caps.TextureObject == true) {
                // Generate texture name
                texture = Gl.GenTexture();
				// Ensure existing texture object
				Gl.BindTexture(TextureTarget.Texture2d, texture);
				Gl.BindTexture(TextureTarget.Texture2d, 0);
				// Self test
				if (Gl.IsTexture(texture) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Shader

			if (Caps.ShaderObjects == true) {
				// Generate shader object name
				shader = Gl.CreateShader(Gl.VERTEX_SHADER);
				// Self test
				if (Gl.IsShader(shader) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Shader Program

			if (Caps.VertexShader == true) {
				// Generate shader program object name
				shaderProgram = Gl.CreateProgram();
				// Self test
				if (Gl.IsProgram(shaderProgram) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Render Buffer

			if (Caps.FrambufferObject == true) {
                // Generate shader program object name
                renderBuffer = Gl.GenRenderbuffer();
				// Ensure existing render buffer
				Gl.BindRenderbuffer(Gl.RENDERBUFFER, renderBuffer);
				Gl.BindRenderbuffer(Gl.RENDERBUFFER, 0);
				// Self test
				if (Gl.IsRenderbuffer(renderBuffer) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Framebuffer

			if (Caps.FrambufferObject == true) {
                // Generate framebuffer name
                framebuffer = Gl.GenFramebuffer();
				// Ensure existing object
				Gl.BindFramebuffer(Gl.FRAMEBUFFER, framebuffer);
				Gl.BindFramebuffer(Gl.FRAMEBUFFER, 0);
				// Self test
				if (Gl.IsFramebuffer(framebuffer) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Vertex Buffer

			if (Caps.VertexBufferObject == true) {
                // Generate buffer name
                vertexBuffer = Gl.GenBuffer();
				// Ensure existing object
				Gl.BindBuffer(BufferTargetARB.ArrayBuffer, vertexBuffer);
				Gl.BindBuffer(BufferTargetARB.ArrayBuffer, 0);
				// Self test
				if (Gl.IsBuffer(vertexBuffer) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Vertex Array

			if (Caps.VertexArrayObject == true) {
                // Generate buffer name
                vertexArray = Gl.GenVertexArray();
				// Ensure existing object
				Gl.BindVertexArray(vertexArray);
				Gl.BindVertexArray(0);
				// Self test
				if (Gl.IsVertexArray(vertexArray) == false)
					throw new NotSupportedException();
			}

			#endregion

			#endregion

			// Make current sharing context
			rContextShare.MakeCurrent(true);

			#region Test Object Sharing

			// Create dictionary
			mSharedObjectClasses = new ListDictionary();

			if ((texture != 0) && (Gl.IsTexture(texture) == true)) {
				mSharedObjectClasses.Add(Texture.TextureObjectClass, Texture.TextureObjectClass);
				sLog.Debug("- Texture objects are shared.");
			}

			if ((shader != 0) && (Gl.IsShader(shader) == true)) {
				mSharedObjectClasses.Add(ShaderObject.ShaderObjectClass, ShaderObject.ShaderObjectClass);
				sLog.Debug("- Shader objects are shared.");
			}

			if ((shaderProgram != 0) && (Gl.IsProgram(shaderProgram) == true)) {
				mSharedObjectClasses.Add(ShaderProgram.ShaderProgramObjectClass, ShaderProgram.ShaderProgramObjectClass);
				sLog.Debug("- Shader programs are shared.");
			}

			if ((renderBuffer != 0) && (Gl.IsRenderbuffer(renderBuffer) == true)) {
				mSharedObjectClasses.Add(RenderBuffer.RenderBufferObjectClass, RenderBuffer.RenderBufferObjectClass);
				sLog.Debug("- Render buffer objects are shared.");
			}

			if ((vertexBuffer != 0) && (Gl.IsBuffer(vertexBuffer) == true)) {
				mSharedObjectClasses.Add(BufferObject.BufferObjectClass, BufferObject.BufferObjectClass);
				sLog.Debug("- Vertex buffer objects are shared.");
			}

			if ((vertexArray != 0) && (Gl.IsVertexArray(vertexArray) == true)) {
				mSharedObjectClasses.Add(VertexArrayObject.VertexArrayObjectClass, VertexArrayObject.VertexArrayObjectClass);
				sLog.Debug("- Vertex array objects are shared.");
			}

			#endregion

			#region Delete Objects

			// Texture
			if (texture != 0)
				Gl.DeleteTextures(texture);
			// Shader
			if (shader != 0)
				Gl.DeleteShader(shader);
			// Shader program
			if (shaderProgram != 0)
				Gl.DeleteProgram(shaderProgram);
			// Render buffer
			if (renderBuffer != 0)
				Gl.DeleteRenderbuffers(renderBuffer);
			// Framebuffer
			if (framebuffer != 0)
				Gl.DeleteFramebuffers(framebuffer);
			// Vertex buffer
			if (vertexBuffer != 0)
				Gl.DeleteBuffers(vertexBuffer);
			// Vertex array
			if (vertexArray != 0)
				Gl.DeleteVertexArrays(vertexArray);

			#endregion

			// Because sharing is transitive, the tested object sharing is managed also by the sharing context
			rContextShare.mSharedObjectClasses = mSharedObjectClasses;

			// Make current this context
			MakeCurrent(true);
		}

		/// <summary>
		/// Object name space identifier.
		/// </summary>
		private Guid mObjectNameSpace = Guid.Empty;

		/// <summary>
		/// Sharing object classes.
		/// </summary>
		/// <remarks>
		/// This dictionary determine which object classes can be shared within this GraphicsContext object name
		/// space.
		/// </remarks>
		private ListDictionary mSharedObjectClasses;

		#endregion

		#region Context Currency

		/// <summary>
		/// Set this GraphicsContext current/uncurrent on current device.
		/// </summary>
		/// <param name="flag">
		/// A <see cref="System.Boolean"/> that specifies the currency of this GraphicsContext on the
		/// device context used to create this GraphicsContext.
		/// </param>
		/// <remarks>
		/// <para>
		/// The current device is defined as follow:
		/// - If this GraphicsContext has never been current on a thread, the current device context is the one specified at construction time. In the case
		///   this GraphicsContext was not constructed specifying a device context, the common device context is the used one. Otherwise...
		/// - The last device context used to make current this context, by calling <see cref="MakeCurrent(System.IntPtr,System.Boolean)"/> or 
		///   <see cref="MakeCurrent(System.Boolean)"/>.
		/// </para>
		/// </remarks>
		/// <exception cref="ObjectDisposedException">
		/// Exception throw if this GraphicsContext has been disposed. Once the GraphicsContext has been disposed it cannot be current again.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if this GraphicsContext cannot be made current/uncurrent on the device context specified at construction time.
		/// </exception>
		public void MakeCurrent(bool flag)
		{
			if (mCurrentDeviceContext == null)
				throw new ObjectDisposedException("no context associated with this GraphicsContext");

			// Already current?
			if (IsCurrent)
				return;

			MakeCurrent(mCurrentDeviceContext, flag);
		}

		/// <summary>
		/// Set this GraphicsContext current/uncurrent on device different from the one specified at construction time.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> that specifies the device context involved.
		/// </param>
		/// <param name="flag">
		/// A <see cref="System.Boolean"/> that specifies the currency of this GraphicsContext on the
		/// device context <paramref name="rDevice"/>.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception throw in the case <paramref name="rDevice"/> is <see cref="System.IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref="ObjectDisposedException">
		/// Exception throw if this GraphicsContext has been disposed. Once the GraphicsContext has been disposed it cannot be current again.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if this GraphicsContext cannot be made current/uncurrent on the device context specified by <paramref name="rDevice"/>.
		/// </exception>
		public void MakeCurrent(IDeviceContext deviceContext, bool flag)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");
			if (_DeviceContext == null)
				throw new ObjectDisposedException("no context associated with this GraphicsContext");

			int threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

			if (flag) {
				// Make this context current on device
				if (Gl.MakeContextCurrent(deviceContext, _RenderContext) == false)
					throw new InvalidOperationException("context cannot be current because error " + Marshal.GetLastWin32Error());

				// Cache current device context
				mCurrentDeviceContext = deviceContext;
				// Set current context on this thread (only on success)
				lock (_RenderThreadsLock) {
					_RenderThreads[threadId] = this;
				}

				switch (Environment.OSVersion.Platform) {
					case PlatformID.Unix:
						using (Glx.XLock xLock = new Glx.XLock(((XServerDeviceContext)deviceContext).Display)) {
							Gl.SyncDelegates();
						}
						break;
					default:
						Gl.SyncDelegates();
						break;
				}


			} else {
				// Make this context uncurrent on device
				bool res = Gl.MakeContextCurrent(deviceContext, _RenderContext);

				// Reset current context on this thread (even on error)
				lock (_RenderThreadsLock) {
					_RenderThreads[threadId] = null;
				}

				if (res == false)
					throw new InvalidOperationException("context cannot be uncurrent because error " + Marshal.GetLastWin32Error());
			}
		}

		/// <summary>
		/// Determine whether rendering context is current to the calling thread.
		/// </summary>
		/// <returns>
		/// It returns true if the render context is current on the calling thread, otherwise it returns false.
		/// </returns>
		public bool IsCurrent
		{
			get
			{
				int threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

				lock (_RenderThreadsLock) {
					GraphicsContext currentThreadContext;

					// Get context registered as current to the current thread
					if (_RenderThreads.TryGetValue(threadId, out currentThreadContext) == false)
						return (false);
					// Test identification corrispodence
					if (currentThreadContext != null)
						return (currentThreadContext._RenderContextId == _RenderContextId);
					else
						return (false);
				}
			}
		}

		/// <summary>
		/// Get the current GraphicsContext on the calling thread.
		/// </summary>
		/// <returns>
		/// It returns any GraphicsContext current on the calling thread. In the case no context is current, it returns null.
		/// </returns>
		public static GraphicsContext GetCurrentContext()
		{
			int threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;

			lock (_RenderThreadsLock) {
				GraphicsContext currentThreadContext;

				if (_RenderThreads.TryGetValue(threadId, out currentThreadContext) == false)
					return (null);

				return (currentThreadContext);
			}
		}

		/// <summary>
		/// Flush GraphicsContext commands.
		/// </summary>
		/// <remarks>
		/// Flushing rendering operations is automatically done by the system when it is more approriate. There's no need to
		/// call it manually.
		/// </remarks>
		public void Flush()
		{
			Gl.Flush();
		}

		/// <summary>
		/// Common (hidden) window used for getting device context without creating a new window.
		/// </summary>
		private static System.Windows.Forms.Form _HiddenWindow;

        /// <summary>
        /// Device context handle created from <see cref="_HiddenWindow"/>.
        /// </summary>
        private static IDeviceContext _HiddenWindowDevice;

		/// <summary>
		/// Device context handle referred by GraphicsContext at construction time.
		/// </summary>
		private IDeviceContext _DeviceContext;

		/// <summary>
		/// Device context handle referred by GraphicsContext when has became current.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It could be different from <see cref="_DeviceContext"/>. It will be used internally to make current this GraphicsContext
		/// on the correct device context.
		/// </para>
		/// <para>
		/// If its value is <see cref="System.IntPtr.Zero"/>, it means that this GraphicsContext has never been current on a thread.
		/// </para>
		/// </remarks>
		private IDeviceContext mCurrentDeviceContext;

		/// <summary>
		/// Flag indicating whether <see cref="mDeviceContext"/> is a device context for the entire screen. This means that
		/// no <see cref="RenderWindow"/> instance will release the device context, so this GraphicsContext instance will
		/// take care of releasing it.
		/// </summary>
		private readonly bool _CommonDeviceContext;

		/// <summary>
		/// Thread identifier which has created the device context. This field is meaninfull only in the case <see cref="_CommonDeviceContext"/> is
		/// true.
		/// </summary>
		/// <remarks>
		/// This value is used in the case the device context is the one offered by <see cref="HiddenWindow"/>. At Dispose time, if the calling thread
		/// identifier is not the same of the value of this field, an exception will be thrown becuase device context shall be released by the same
		/// thread which has allocated it.
		/// </remarks>
		private int _DeviceContextThreadId;

		/// <summary>
		/// Thread identifier which has created this GraphicsContext.
		/// </summary>
		/// <remarks>
		/// This information is used for checking whether a context can be shared with another one: contextes must be created
		/// by the same thread. This would avoid an InvalidOperationException caused by constructors.
		/// </remarks>
		private int _RenderContextThreadId;

		/// <summary>
		/// Rendering context handle.
		/// </summary>
		private IntPtr _RenderContext = IntPtr.Zero;

		/// <summary>
		/// Unique identifier of this GraphicsContext.
		/// </summary>
		private Guid _RenderContextId = Guid.NewGuid();

		/// <summary>
		/// Map between process threads and current render context.
		/// </summary>
		private static readonly Dictionary<int, GraphicsContext> _RenderThreads = new Dictionary<int, GraphicsContext>();

		/// <summary>
		/// Object used for synchronizing <see cref="_RenderThreads"/> accesses.
		/// </summary>
		private static readonly object _RenderThreadsLock = new object();

		#endregion

		#region IDisposable Implementation

		/// <summary>
		/// Finalizer.
		/// </summary>
		~GraphicsContext()
		{
			Dispose(false);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// </param>
		/// <remarks>
		/// This method shall be called by the same thread which has created this GraphicsContext, but only in the case the following
		/// constructors were called:
		/// - @ref GraphicsContext::GraphicsContext()
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if this GraphicsContext has not been disposed before finalization.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if it's not possible to release correctly the OpenGL context related to this GraphicsContext.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if the current thread is not the one which has constructed this GraphicsContext.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if it's not possible to release correctly the GDI device context related to this GraphicsContext.
		/// </exception>
		private void Dispose(bool disposing)
		{
			if ((disposing == false) && (_RenderContext != IntPtr.Zero))
				throw new InvalidOperationException("not disposed on finalization");

			if (disposing == true) {
				// Dispose unmanaged resources
				if (_RenderContext != IntPtr.Zero) {
					if (Gl.DeleteContext(_DeviceContext, _RenderContext) == false)
						throw new InvalidOperationException("unable to release OpenGL context");
					_RenderContext = IntPtr.Zero;
				}

				if (_DeviceContextThreadId != System.Threading.Thread.CurrentThread.ManagedThreadId)
					throw new InvalidOperationException("disposing on a different thread context");
                _DeviceContext.DecRef();
				_DeviceContext = null;

				// Remove context from the current ones
				int threadId = 0;
				bool threadCurrentFound = false;

				lock (_RenderThreadsLock) {
					foreach (KeyValuePair<int, GraphicsContext> pair in _RenderThreads) {
						if (Object.ReferenceEquals(pair.Value, this) == true) {
							threadId = pair.Key;
							threadCurrentFound = true;
							break;
						}
					}
				}

				if (threadCurrentFound == true)
					_RenderThreads[threadId] = null;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if it's not possible to release correctly the OpenGL context related to this GraphicsContext.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if the current thread is not the one which has constructed this GraphicsContext.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception throw if it's not possible to release correctly the GDI device context related to this GraphicsContext.
		/// </exception>
		public void Dispose()
		{
			GC.SuppressFinalize(this);
			Dispose(true);
		}

		#endregion
	}
}
