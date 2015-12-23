
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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

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
			// Create common hidden window
			_HiddenWindow = new System.Windows.Forms.Form();
			// Create device context
			_HiddenWindowDevice = DeviceContextFactory.Create(_HiddenWindow);
			_HiddenWindowDevice.IncRef();

			// Create basic OpenGL context
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
			if (Gl.MakeContextCurrent(_HiddenWindowDevice, rContext) == false)
				throw new Exception("unable to make current");

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
				case PlatformID.Win32S:
				case PlatformID.Win32Windows:
				case PlatformID.WinCE:
					// Synchronize WGL entry points (now that we have a render context)
					Wgl.SyncDelegates();
					break;
			}

			// Obtain current OpenGL implementation
			string glVersion = Gl.GetString(StringName.Version);
			_CurrentVersion = KhronosVersion.Parse(glVersion);

			// Obtain current OpenGL Shading Language version
			string glslVersion = Gl.GetString(StringName.ShadingLanguageVersion);
			_CurrentShadingVersion = GlslVersion.Parse(glslVersion);
			// Query OpenGL extensions (current OpenGL implementation, CurrentCaps)
			_CurrentCaps = GraphicsCapabilities.Query(null, _HiddenWindowDevice);

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
			Wgl.PIXELFORMATDESCRIPTOR pfd = new Wgl.PIXELFORMATDESCRIPTOR(24);
			int pFormat;
			bool res;

			// Find pixel format match
			pFormat = Wgl.ChoosePixelFormat(winDeviceContext.DeviceContext, ref pfd);
			Debug.Assert(pFormat != 0);

			// Get exact description of the pixel format
			res = Wgl.DescribePixelFormat(winDeviceContext.DeviceContext, pFormat, (uint)pfd.nSize, ref pfd);
			Debug.Assert(res);

			// Set pixel format before creating OpenGL context
			res = Wgl.SetPixelFormat(winDeviceContext.DeviceContext, pFormat, ref pfd);
			Debug.Assert(res);

			// Create a dummy OpenGL context to retrieve initial informations.
			rContext = Wgl.CreateContext(winDeviceContext.DeviceContext);
			Debug.Assert(rContext != IntPtr.Zero);

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
		internal static void Touch() { _CurrentCaps.GetHashCode(); }

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
			CreateRenderContext(_HiddenWindowDevice, null, _CurrentVersion);
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
			CreateRenderContext(deviceContext, null, _CurrentVersion);
		}

		/// <summary>
		/// Construct a GraphicsContext implementing the current OpenGL version.
		/// </summary>
		/// <param name="hSharedContext">
		/// A <see cref="GraphicsContext"/> that specifies the render context which has to be linked this this Render context (to share resource with it).
		/// In the case this parameter is null, this is equivalent to <see cref="OpenGL.Render.GraphicsContext.ctor"/>
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
			CreateRenderContext(_HiddenWindowDevice, hSharedContext, _CurrentVersion);
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
			CreateRenderContext(deviceContext, hSharedContext, _CurrentVersion);
		}

		/// <summary>
		/// Construct a GraphicsContext specifying the implemented OpenGL version.
		/// </summary>
		/// <param name="version">
		/// A <see cref="KhronosVersion"/> that specifies the minimum OpenGL version required to implement.
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
		public GraphicsContext(KhronosVersion version, GraphicsContext hSharedContext)
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
		/// A <see cref="KhronosVersion"/> that specifies the minimum OpenGL version required to implement.
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
		public GraphicsContext(KhronosVersion version, IDeviceContext deviceContext, GraphicsContext hSharedContext)
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
		/// A <see cref="KhronosVersion"/> that specifies the minimum OpenGL version required to implement.
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
		private void CreateRenderContext(IDeviceContext deviceContext, GraphicsContext hSharedContext, KhronosVersion version)
		{
			try {
				IntPtr pSharedContext = (hSharedContext != null) ? hSharedContext._RenderContext : IntPtr.Zero;

#if DEBUG
				mConstructorStackTrace = Environment.StackTrace;
#endif

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
				if ((version != _CurrentVersion) && ((CurrentCaps.PlatformExtensions.CreateContext_ARB == false) && (CurrentCaps.PlatformExtensions.CreateContextProfile_ARB == false)))
					throw new ArgumentException("unable to specify OpenGL version when GL_ARB_create_context[_profile] is not supported");

#if false
				if ((sVersionDb[version].ForwardCompatible == true) && ((CurrentCaps.PlatformExtensions.CreateContext_ARB == false) && (CurrentCaps.PlatformExtensions.CreateContextProfile_ARB == false)))
					throw new ArgumentException("unable to specify forward-compatible OpenGL version when GL_ARB_create_context[_profile] is not supported");
#endif

				// Store device context handle
				_DeviceContext = deviceContext;
				_DeviceContext.IncRef();

				if ((CurrentCaps.PlatformExtensions.CreateContext_ARB || CurrentCaps.PlatformExtensions.CreateContextProfile_ARB) && (version.Major >= 3)) {
					List<int> cAttributes = new List<int>();
					int rContextFlags = 0;

					// Requires a specific version
					Debug.Assert(Wgl.CONTEXT_MAJOR_VERSION_ARB == Glx.CONTEXT_MAJOR_VERSION_ARB);
					Debug.Assert(Wgl.CONTEXT_MINOR_VERSION_ARB == Glx.CONTEXT_MINOR_VERSION_ARB);
					cAttributes.AddRange(new int[] {
						Wgl.CONTEXT_MAJOR_VERSION_ARB, version.Major,
						Wgl.CONTEXT_MINOR_VERSION_ARB, version.Minor
					});

					// Context flags
					Debug.Assert(Wgl.CONTEXT_FLAGS_ARB == Glx.CONTEXT_FLAGS_ARB);
					Debug.Assert(Wgl.CONTEXT_DEBUG_BIT_ARB == Glx.CONTEXT_DEBUG_BIT_ARB);
					Debug.Assert(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB == Glx.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
#if false
					// Context flags: forward compatible context
					if (sVersionDb[version].ForwardCompatible == true)
						rContextFlags |= (int)(Wgl.CONTEXT_FORWARD_COMPATIBLE_BIT_ARB);
#endif
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

						throw new InvalidOperationException("unable to create context " + version.Major + "." + version.Minor, platformException);
					}
				} else {
					// Create rendering context
					if ((_RenderContext = Gl.CreateContext(_DeviceContext, pSharedContext)) == IntPtr.Zero)
						throw new InvalidOperationException("unable to create context " + version.Major + "." + version.Minor);
				}

				GraphicsContext rContextCurrent = GetCurrentContext();		// Back current context, if any
				IDeviceContext rContextCurrentDevice = (rContextCurrent != null) ? rContextCurrent.mCurrentDeviceContext : null;

				// This will cause OpenGL operation flushed... not too bad
				MakeCurrent(deviceContext, true);

				// Get the current OpenGL implementation supported by this GraphicsContext
				_Version = KhronosVersion.Parse(Gl.GetString(StringName.Version));
				// Get the current OpenGL Shading Language implementation supported by this GraphicsContext
				_ShadingVersion = KhronosVersion.Parse(Gl.GetString(StringName.ShadingLanguageVersion));
				// Determine the compatibility profile
				KhronosVersion compatibilityVersion = new KhronosVersion(3, 1);

				_CompatibilityProfile = (version < compatibilityVersion) && (_Version >= compatibilityVersion);

				// Cache context capabilities for this version
				if (_GraphicsCapsDb.ContainsKey(_Version) == false)
					_GraphicsCapsDb[_Version] = GraphicsCapabilities.Query(this, deviceContext);

				// Determine this GraphicsContext object name space and garbage service
				if (hSharedContext != null) {
					// Sharing same object name space
					_ObjectNameSpace = hSharedContext._ObjectNameSpace;

					// Test for effective sharing
					TestSharingObjects(hSharedContext);
				} else {
					// Reserved object name space
					_ObjectNameSpace = Guid.NewGuid();

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
		/// Get the OpenGL version currently implemented.
		/// </summary>
		public static KhronosVersion CurrentVersion { get { return (_CurrentVersion); } }

		/// <summary>
		/// The OpenGL version implemented by this GraphicsContext.
		/// </summary>
		public KhronosVersion Version { get { return (_Version); } }

		/// <summary>
		/// OpenGL version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL versions versions cannot be requested to be implemented.
		/// </remarks>
		private static KhronosVersion _CurrentVersion;

		/// <summary>
		/// The OpenGL version implemented by this GraphicsContext.
		/// </summary>
		private KhronosVersion _Version;

		/// <summary>
		/// Get the OpenGL Shading Language version currently implemented.
		/// </summary>
		public static KhronosVersion CurrentShadingVersion { get { return (_CurrentShadingVersion); } }

		/// <summary>
		/// The OpenGL Shading Language version implemented by this GraphicsContext.
		/// </summary>
		public KhronosVersion ShadingVersion { get { return (_ShadingVersion); } }

		/// <summary>
		/// OpenGL Shading Language version currently implemented.
		/// </summary>
		/// <remarks>
		/// Higher OpenGL Shading Language versions cannot be requested to be implemented.
		/// </remarks>
		private static GlslVersion _CurrentShadingVersion;

		/// <summary>
		/// The OpenGL Shading Language version implemented by this GraphicsContext.
		/// </summary>
		private KhronosVersion _ShadingVersion;

		/// <summary>
		/// The compatibility profile presence implemented by this GraphicsContext.
		/// </summary>
		public bool CompatibilityProfile { get { return (_CompatibilityProfile); } }

		/// <summary>
		/// Compatibility profile enabled (only for versions greater than OpenGL 3.0).
		/// </summary>
		private bool _CompatibilityProfile;

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
				return (_GraphicsCapsDb[Version]);
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
				return (_CurrentCaps);
			}
		}

		/// <summary>
		/// Rendering context capabilities.
		/// </summary>
		/// <remarks>
		/// The <see cref="Capabilities"/> class is meant to represent a set of extensions and limits for a particoular OpenGL implementation. This
		/// means also that the render capabilities are dependent on the current context on the executing thread.
		/// </remarks>
		private static readonly GraphicsCapabilities _CurrentCaps;

		/// <summary>
		/// Map OpenGL capabilities to a specific OpenGL version.
		/// </summary>
		/// <remarks>
		/// The use of this map suppose that the capabilities doesn't change between context having the same OpenGL version. At this
		/// moment is not clear if it really is.
		/// </remarks>
		private static readonly Dictionary<KhronosVersion, GraphicsCapabilities> _GraphicsCapsDb = new Dictionary<KhronosVersion, GraphicsCapabilities>();

		#endregion

		#region Object Namespace

		/// <summary>
		/// GraphicsContext object namespace.
		/// </summary>
		public Guid ObjectNameSpace { get { return (_ObjectNameSpace); } }

		/// <summary>
		/// Object namespace identifier.
		/// </summary>
		private Guid _ObjectNameSpace = Guid.Empty;

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

			if (Caps.GlExtensions.TextureObject_EXT) {
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

			if (Caps.GlExtensions.ShaderObjects_ARB) {
				// Generate shader object name
				shader = Gl.CreateShader(Gl.VERTEX_SHADER);
				// Self test
				if (Gl.IsShader(shader) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Shader Program

			if (Caps.GlExtensions.VertexShader_ARB) {
				// Generate shader program object name
				shaderProgram = Gl.CreateProgram();
				// Self test
				if (Gl.IsProgram(shaderProgram) == false)
					throw new NotSupportedException();
			}

			#endregion

			#region Render Buffer

			if (Caps.GlExtensions.FramebufferObject_ARB) {
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

			if (Caps.GlExtensions.FramebufferObject_ARB) {
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

			if (Caps.GlExtensions.VertexBufferObject_ARB) {
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

			if (Caps.GlExtensions.VertexArrayObject_ARB) {
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
				_Log.Debug("- Texture objects are shared.");
			}

			if ((shader != 0) && (Gl.IsShader(shader) == true)) {
				mSharedObjectClasses.Add(ShaderObject.ShaderObjectClass, ShaderObject.ShaderObjectClass);
				_Log.Debug("- Shader objects are shared.");
			}

			if ((shaderProgram != 0) && (Gl.IsProgram(shaderProgram) == true)) {
				mSharedObjectClasses.Add(ShaderProgram.ShaderProgramObjectClass, ShaderProgram.ShaderProgramObjectClass);
				_Log.Debug("- Shader programs are shared.");
			}

			if ((renderBuffer != 0) && (Gl.IsRenderbuffer(renderBuffer) == true)) {
				mSharedObjectClasses.Add(RenderBuffer.RenderBufferObjectClass, RenderBuffer.RenderBufferObjectClass);
				_Log.Debug("- Render buffer objects are shared.");
			}

			if ((vertexBuffer != 0) && (Gl.IsBuffer(vertexBuffer) == true)) {
				mSharedObjectClasses.Add(BufferObject.BufferObjectClass, BufferObject.BufferObjectClass);
				_Log.Debug("- Vertex buffer objects are shared.");
			}

			if ((vertexArray != 0) && (Gl.IsVertexArray(vertexArray) == true)) {
				mSharedObjectClasses.Add(VertexArrayObject.VertexArrayObjectClass, VertexArrayObject.VertexArrayObjectClass);
				_Log.Debug("- Vertex array objects are shared.");
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
		/// Flag indicating whether <see cref="_DeviceContext"/> is a device context for the entire screen. This means that
		/// no <see cref="GraphicsWindow"/> instance will release the device context, so this GraphicsContext instance will
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

		#region Shader Include Library

		/// <summary>
		/// 
		/// </summary>
		internal ShaderIncludeLibrary IncludeLibrary { get { return (_ShaderIncludeLibrary); } }

		/// <summary>
		/// The shader include library used for compiling shaders.
		/// </summary>
		private ShaderIncludeLibrary _ShaderIncludeLibrary = new ShaderIncludeLibrary();

		#endregion

		#region Logging

		/// <summary>
		/// Logger of this class.
		/// </summary>
		private static readonly ILogger _Log = Log.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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
						if (ReferenceEquals(pair.Value, this) == true) {
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
