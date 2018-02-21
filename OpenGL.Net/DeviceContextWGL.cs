
// Copyright (C) 2012-2018 Luca Piccioni
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

// Support for WGL_ARB_multisample or WGL_EXT_multisample
#define SUPPORT_MULTISAMPLE
// Support for WGL_ARB_pbuffer
#define SUPPORT_PBUFFER
// Support WGL_ARB_framebuffer_sRGB or WGL_EXT_framebuffer_sRGB
#define SUPPORT_FRAMEBUFFER_SRGB
// Support WGL_ARB_pixel_format_float || WGL_ATI_pixel_format_float
#define SUPPORT_PIXEL_FORMAT_FLOAT
// Support WGL_EXT_pixel_format_packed_float
#define SUPPORT_PIXEL_FORMAT_PACKED_FLOAT
// 
#undef CHOOSE_PIXEL_FORMAT_FALLBACK

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
// ReSharper disable once RedundantUsingDirective
using System.Reflection;				// Do not delete me! .NET Core include extension methods
using System.Runtime.InteropServices;

using Khronos;

// ReSharper disable RedundantAssignment
// ReSharper disable InvertIf
// ReSharper disable RedundantIfElseBlock
// ReSharper disable SwitchStatementMissingSomeCases
// ReSharper disable InheritdocConsiderUsage

namespace OpenGL
{
	/// <summary>
	/// Device context for MS Windows platform.
	/// </summary>
	internal sealed class DeviceContextWGL : DeviceContext
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextWGL"/> class.
		/// </summary>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		/// <remarks>
		/// The created instance will be bound to the (hidden) window used for initializing <see cref="Gl"/>. The device contextes
		/// created by using this constructor are meant to render on framebuffer objects.
		/// </remarks>
		public DeviceContextWGL()
		{
			if (Gl.NativeWindow == null)
				throw new InvalidOperationException("no underlying native window", Gl.InitializationException);

			_WindowHandle = Gl.NativeWindow.Handle;

			IsPixelFormatSet = true;		// We do not want to reset pixel format

			DeviceContext = Wgl.GetDC(_WindowHandle);
			if (DeviceContext == IntPtr.Zero)
				throw new InvalidOperationException("unable to get device context");
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextWGL"/> class.
		/// </summary>
		/// <param name='windowHandle'>
		/// A <see cref="IntPtr"/> that specifies the window handle used to create the device context.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="windowHandle"/> is <see cref="IntPtr.Zero"/>.
		/// </exception>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		/// <remarks>
		/// The <paramref name="windowHandle"/> must be an handle to a native window. It is normally created by calling
		/// CreateWindow(Ex)? methods.
		/// </remarks>
		public DeviceContextWGL(IntPtr windowHandle)
		{
			if (windowHandle == IntPtr.Zero)
				throw new ArgumentException("null handle", nameof(windowHandle));

			_WindowHandle = windowHandle;

			DeviceContext = Wgl.GetDC(_WindowHandle);
			if (DeviceContext == IntPtr.Zero)
				throw new InvalidOperationException("unable to get device context");
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DeviceContextWGL"/> class.
		/// </summary>
		/// <param name='nativeBuffer'>
		/// A <see cref="INativePBuffer"/> that specifies the P-Buffer used to create the device context.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="nativeBuffer"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="nativeBuffer"/> is not an instance created by
		/// <see cref="DeviceContext.CreatePBuffer(DevicePixelFormat, uint, uint)"/>.
		/// </exception>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public DeviceContextWGL(INativePBuffer nativeBuffer)
		{
			if (nativeBuffer == null)
				throw new ArgumentNullException(nameof(nativeBuffer));

			NativePBuffer nativePBuffer = nativeBuffer as NativePBuffer;
			if (nativePBuffer == null)
				throw new ArgumentException("INativePBuffer not created with DeviceContext.CreatePBuffer");

			if (!Wgl.CurrentExtensions.Pbuffer_ARB && !Wgl.CurrentExtensions.Pbuffer_EXT)
				throw new InvalidOperationException("WGL_(ARB|EXT)_pbuffer not supported");

			_WindowHandle = nativePBuffer.Handle;

			DeviceContext = Wgl.CurrentExtensions.Pbuffer_ARB ? Wgl.GetPbufferDCARB(nativePBuffer.Handle) : Wgl.GetPbufferDCEXT(nativePBuffer.Handle);
			if (DeviceContext == IntPtr.Zero)
				throw new InvalidOperationException("unable to get device context");
			_DeviceContextPBuffer = true;

			IsPixelFormatSet = true;
		}

		#endregion

		#region Device Information

		/// <summary>
		/// The device context of the control.
		/// </summary>
		internal IntPtr DeviceContext { get; private set; }

		/// <summary>
		/// The window handle.
		/// </summary>
		private IntPtr _WindowHandle;

		/// <summary>
		/// Flag indicating whether <see cref="DeviceContext"/> is obtained by using GetPbufferDC* and
		/// <see cref="_WindowHandle"/> is obtained by using CreatePbuffer*.
		/// </summary>
		private readonly bool _DeviceContextPBuffer;

		#endregion

		#region Window Factory

		/// <summary>
		/// Determine whether the hosting platform is able to create a P-Buffer.
		/// </summary>
		public new static bool IsPBufferSupported => Wgl.CurrentExtensions != null && (Wgl.CurrentExtensions.Pbuffer_ARB || Wgl.CurrentExtensions.Pbuffer_EXT);

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
				: this(1, 1, 16, 16)
			{

			}

			/// <summary>
			/// Default constructor.
			/// </summary>
			public NativeWindow(int x, int y, uint width, uint height)
			{
				try {
					// Register window class
					WNDCLASSEX windowClass = new WNDCLASSEX();
					const string defaultWindowClass = "OpenGL.Net2";

					windowClass.cbSize = Marshal.SizeOf(typeof(WNDCLASSEX));
					windowClass.style = (int)(UnsafeNativeMethods.CS_HREDRAW | UnsafeNativeMethods.CS_VREDRAW | UnsafeNativeMethods.CS_OWNDC);
					windowClass.lpfnWndProc = Marshal.GetFunctionPointerForDelegate(_WindowsWndProc);
#if   NETSTANDARD1_1 || NETSTANDARD1_4
					windowClass.hInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).GetTypeInfo().Assembly.FullName); // XXX
#elif NETSTANDARD2_0 || NETCORE
					windowClass.hInstance = UnsafeNativeMethods.GetModuleHandle(typeof(Gl).GetTypeInfo().Assembly.Location);
#else
					windowClass.hInstance = Marshal.GetHINSTANCE(typeof(Gl).Module);
#endif
					windowClass.lpszClassName = defaultWindowClass;

					if ((_ClassAtom = UnsafeNativeMethods.RegisterClassEx(ref windowClass)) == 0)
						throw new Win32Exception(Marshal.GetLastWin32Error());

					// Create window
					const uint defaultWindowStyleEx = UnsafeNativeMethods.WS_EX_APPWINDOW | UnsafeNativeMethods.WS_EX_WINDOWEDGE;
					const uint defaultWindowStyle = UnsafeNativeMethods.WS_OVERLAPPED | UnsafeNativeMethods.WS_CLIPCHILDREN | UnsafeNativeMethods.WS_CLIPSIBLINGS;

					_Handle = UnsafeNativeMethods.CreateWindowEx(
						defaultWindowStyleEx, windowClass.lpszClassName, string.Empty, defaultWindowStyle,
						x, y, (int)width, (int)height,
						IntPtr.Zero, IntPtr.Zero, windowClass.hInstance, IntPtr.Zero
					);

					if (_Handle == IntPtr.Zero)
						throw new Win32Exception(Marshal.GetLastWin32Error());
				} catch {
					Dispose();
					throw;
				}
			}

			#endregion

			#region P/Invoke

			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
			[SuppressMessage("ReSharper", "InconsistentNaming")]
			[SuppressMessage("ReSharper", "MemberCanBePrivate.Local")]
			[SuppressMessage("ReSharper", "FieldCanBeMadeReadOnly.Local")]
			private struct WNDCLASSEX {
				public int cbSize;
				public int style;
				public IntPtr lpfnWndProc; 
				public int cbClsExtra;
				public int cbWndExtra;
				public IntPtr hInstance;
				public IntPtr hIcon;
				public IntPtr hCursor;
				public IntPtr hbrBackground;
				[MarshalAs(UnmanagedType.LPTStr)]
				public string lpszMenuName;
				[MarshalAs(UnmanagedType.LPTStr)]
				public string lpszClassName;
				public IntPtr hIconSm;
			}

			[SuppressMessage("ReSharper", "InconsistentNaming")]
			private static class UnsafeNativeMethods
			{
				// CLASS STYLE
				public const uint CS_VREDRAW =	0x0001;
				public const uint CS_HREDRAW =	0x0002;
				public const uint CS_OWNDC =		0x0020;

				// WINDOWS STYLE
				public const uint WS_CLIPCHILDREN =			0x2000000;
				public const uint WS_CLIPSIBLINGS =			0x4000000;
				public const uint WS_OVERLAPPED =				0x0;

				// WINDOWS STYLE EX
				public const uint WS_EX_APPWINDOW =			0x00040000;
				public const uint WS_EX_WINDOWEDGE =			0x00000100;

				internal delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

				[DllImport("user32.dll", EntryPoint = "DefWindowProc", SetLastError = true)]
				internal static extern IntPtr DefWindowProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

				[DllImport("user32.dll", EntryPoint = "RegisterClassEx", SetLastError = true, CharSet = CharSet.Unicode)]
				internal static extern ushort RegisterClassEx([In] ref WNDCLASSEX lpWndClass);

				[DllImport("user32.dll", EntryPoint = "UnregisterClass", SetLastError = true)]
				public static extern bool UnregisterClass(ushort lpClassAtom, IntPtr hInstance);

				[DllImport("user32.dll", EntryPoint = "CreateWindowEx", SetLastError = true, CharSet = CharSet.Unicode)]
				internal static extern IntPtr CreateWindowEx(uint dwExStyle, string lpClassName, string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);

				[DllImport("user32.dll", SetLastError = true)]
				internal static extern bool DestroyWindow(IntPtr hWnd);

				[DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
				internal static extern IntPtr GetModuleHandle(string lpModuleName);
			}

			private static IntPtr WindowsWndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
			{
				return UnsafeNativeMethods.DefWindowProc(hWnd, msg, wParam, lParam);
			}

			private static readonly UnsafeNativeMethods.WndProc _WindowsWndProc = WindowsWndProc;

			#endregion

			#region INativeWindow Implementation

			/// <summary>
			/// Get the display handle associated this instance.
			/// </summary>
			IntPtr INativeWindow.Display => IntPtr.Zero;

			/// <summary>
			/// Get the native window handle.
			/// </summary>
			IntPtr INativeWindow.Handle => _Handle;

			/// <summary>
			/// The native window handle.
			/// </summary>
			private IntPtr _Handle;

			/// <summary>
			/// The atom associated to the window class.
			/// </summary>
			private ushort _ClassAtom;

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public void Dispose()
			{
				if (_Handle != IntPtr.Zero) {
					UnsafeNativeMethods.DestroyWindow(_Handle);
					_Handle = IntPtr.Zero;
				}

				if (_ClassAtom != 0) {
#if NETSTANDARD1_1 || NETSTANDARD1_4 || NETSTANDARD2_0 || NETCORE
					// XXX
#else
					UnsafeNativeMethods.UnregisterClass(_ClassAtom, Marshal.GetHINSTANCE(typeof(Gl).Module));
#endif
					_ClassAtom = 0;
				}
			}

			#endregion
		}

		/// <summary>
		/// P-Buffer implementation for Windows.
		/// </summary>
		internal class NativePBuffer : INativePBuffer
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
			[RequiredByFeature("WGL_ARB__pbuffer")]
			public NativePBuffer(DevicePixelFormat pixelFormat, uint width, uint height)
			{
				if (pixelFormat == null)
					throw new ArgumentNullException(nameof(pixelFormat));

				if (!Wgl.CurrentExtensions.Pbuffer_ARB && !Wgl.CurrentExtensions.Pbuffer_EXT)
					throw new NotSupportedException("WGL_(ARB|EXT)_pbuffer not implemented");
				if (Gl.NativeWindow == null)
					throw new InvalidOperationException("no underlying native window", Gl.InitializationException);

				try {
					// Uses screen device context
					_DeviceContext = Wgl.GetDC(Gl.NativeWindow.Handle);

					// Choose appropriate pixel format
					pixelFormat.RenderWindow = false;	// XXX
					pixelFormat.RenderPBuffer = true;
					pixelFormat.DoubleBuffer = true;

					int pixelFormatIndex = ChoosePixelFormat(_DeviceContext, pixelFormat);

					Handle = Wgl.CurrentExtensions.Pbuffer_ARB ? Wgl.CreatePbufferARB(_DeviceContext, pixelFormatIndex, (int)width, (int)height, new[] { 0 }) : Wgl.CreatePbufferEXT(_DeviceContext, pixelFormatIndex, (int)width, (int)height, new[] { 0 });
					if (Handle == IntPtr.Zero)
						throw new InvalidOperationException("unable to create P-Buffer", GetPlatformExceptionCore());
				} catch {
					Dispose();
					throw;
				}
			}

			#endregion

			#region Handles

			/// <summary>
			/// The device context used for allocating the P-Buffer resources.
			/// </summary>
			private IntPtr _DeviceContext;
			
			/// <summary>
			/// Get the P-Buffer handle.
			/// </summary>
			[RequiredByFeature("WGL_ARB__pbuffer")]
			public IntPtr Handle { get; private set; }

			#endregion

			#region INativePBuffer Implementation

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			[RequiredByFeature("WGL_ARB__pbuffer")]
			public void Dispose()
			{
				if (Handle != IntPtr.Zero) {
					if (Wgl.CurrentExtensions.Pbuffer_ARB) {
						bool res = Wgl.DestroyPbufferARB(Handle);
						Debug.Assert(res);
					} else {
						bool res = Wgl.DestroyPbufferEXT(Handle);
						Debug.Assert(res);
					}
					
					Handle = IntPtr.Zero;
				}

				if (_DeviceContext != IntPtr.Zero) {
					Wgl.ReleaseDC(IntPtr.Zero, _DeviceContext);
					_DeviceContext = IntPtr.Zero;
				}
			}

			#endregion
		}

		#endregion

		#region DeviceContext Overrides

		/// <summary>
		/// Get this DeviceContext API version.
		/// </summary>
		public override KhronosVersion Version => new KhronosVersion(1, 0, KhronosVersion.ApiWgl);

		/// <summary>
		/// Create a simple context.
		/// </summary>
		/// <returns>
		/// A <see cref="IntPtr"/> that represents the handle of the created context. If the context cannot be
		/// created, it returns IntPtr.Zero.
		/// </returns>
		internal override IntPtr CreateSimpleContext()
		{
			// Define most compatible pixel format
			Wgl.PIXELFORMATDESCRIPTOR pfd = new Wgl.PIXELFORMATDESCRIPTOR(24);

			// Find pixel format match
			pfd.dwFlags |= Wgl.PixelFormatDescriptorFlags.DepthDontCare | Wgl.PixelFormatDescriptorFlags.DoublebufferDontCare | Wgl.PixelFormatDescriptorFlags.StereoDontCare;

			int pFormat = Wgl.ChoosePixelFormat(DeviceContext, ref pfd);
			Debug.Assert(pFormat != 0);

			// Get exact description of the pixel format
			bool res = Wgl.DescribePixelFormat(DeviceContext, pFormat, (uint)pfd.nSize, ref pfd) != 0;
			Debug.Assert(res);

			// Set pixel format before creating OpenGL context
			res = Wgl.SetPixelFormat(DeviceContext, pFormat, ref pfd);
			Debug.Assert(res);

			// Create a dummy OpenGL context to retrieve initial informations.
			IntPtr rContext = CreateContext(IntPtr.Zero);
			Debug.Assert(rContext != IntPtr.Zero);

			return rContext;
		}

		/// <summary>
		/// Get the APIs available on this device context. The API tokens are space separated, and they can be
		/// found in <see cref="KhronosVersion"/> definition.
		/// </summary>
		public override IEnumerable<string> AvailableAPIs => GetAvailableApis();

		/// <summary>
		/// Get the APIs available on the WGL device context.
		/// </summary>
		/// <returns></returns>
		internal static string[] GetAvailableApis()
		{
			List<string> deviceApi = new List<string> { KhronosVersion.ApiGl };

			// OpenGL ES via WGL_EXT_create_context_es(2)?_profile
			if (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContextEsProfile_EXT) {
				deviceApi.Add(KhronosVersion.ApiGles1);
				deviceApi.Add(KhronosVersion.ApiGles2);
				// OpenGL SC2 is based on OpenGL ES2
				deviceApi.Add(KhronosVersion.ApiGlsc2);
			}

			return deviceApi.ToArray();
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
			if (Wgl.CurrentExtensions == null || Wgl.CurrentExtensions.CreateContext_ARB == false) {
				IntPtr renderContext = Wgl.CreateContext(DeviceContext);
				if (renderContext == IntPtr.Zero)
					throw new WglException(Marshal.GetLastWin32Error());

				if (sharedContext != IntPtr.Zero) {
					bool res = Wgl.ShareLists(renderContext, sharedContext);
					if (res == false)
						throw new WglException(Marshal.GetLastWin32Error());
				}

				return renderContext;
			} else
				return CreateContextAttrib(sharedContext, new[] { Gl.NONE });
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
		[RequiredByFeature("WGL_ARB_create_context")]
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
		[RequiredByFeature("WGL_ARB_create_context")]
		public override IntPtr CreateContextAttrib(IntPtr sharedContext, int[] attribsList, KhronosVersion api)
		{
			if (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContext_ARB == false)
				throw new InvalidOperationException("WGL_ARB_create_context not supported");
			if (attribsList != null && attribsList.Length == 0)
				throw new ArgumentException("zero length array", nameof(attribsList));
			if (attribsList != null && attribsList[attribsList.Length - 1] != Gl.NONE)
				throw new ArgumentException("not zero-terminated array", nameof(attribsList));

			// Defaults null attributes
			if (attribsList == null)
				attribsList = new[] { Gl.NONE };

			IntPtr ctx;

			if (api != null) {
				List<int> adulteredAttribs = new List<int>(attribsList);

				// Support check
				switch (api.Api) {
					case KhronosVersion.ApiGl:
						break;
					case KhronosVersion.ApiGles1:
					case KhronosVersion.ApiGles2:
					case KhronosVersion.ApiGlsc2:
						if (Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.CreateContextEsProfile_EXT == false)
							throw new NotSupportedException("OpenGL ES API not supported");
						break;
					default:
						throw new NotSupportedException($"'{api.Api}' API not supported");
				}

				// Remove trailing 0
				if (adulteredAttribs.Count > 0 && adulteredAttribs[adulteredAttribs.Count - 1] == Gl.NONE)
					adulteredAttribs.RemoveAt(adulteredAttribs.Count - 1);

				// Add required attributes
				int major = api.Major, minor = api.Minor, profileMask = 0;

				switch (api.Api) {
					case KhronosVersion.ApiGl:
						switch (api.Profile) {
							case KhronosVersion.ProfileCompatibility:
								profileMask |= (int)Wgl.CONTEXT_COMPATIBILITY_PROFILE_BIT_ARB;
								break;
							case KhronosVersion.ProfileCore:
								profileMask |= (int)Wgl.CONTEXT_CORE_PROFILE_BIT_ARB;
								break;
							case null:
								// No specific profile required, leaving the default (core profile)
								break;
							default:
								throw new NotSupportedException($"'{api.Profile}' Profile not supported");
						}
						break;
					case KhronosVersion.ApiGles1:
						// Ignore API version: force always to 1.0
						major = 1;
						minor = 0;
						profileMask |= (int)Wgl.CONTEXT_ES_PROFILE_BIT_EXT;
						break;
					case KhronosVersion.ApiGles2:
					case KhronosVersion.ApiGlsc2:
						major = 2;
						minor = 0;
						profileMask |= (int)Wgl.CONTEXT_ES_PROFILE_BIT_EXT;
						break;
					default:
						throw new NotSupportedException($"'{api.Api}' API not supported");
				}

				// Add/Replace attributes
				int majorVersionIndex, minorVersionIndex;

				if ((majorVersionIndex = adulteredAttribs.FindIndex(item => item == Wgl.CONTEXT_MAJOR_VERSION_ARB)) >= 0)
					adulteredAttribs[majorVersionIndex + 1] = major;
				else
					adulteredAttribs.AddRange(new[] { Wgl.CONTEXT_MAJOR_VERSION_ARB, major });

				if ((minorVersionIndex = adulteredAttribs.FindIndex(item => item == Wgl.CONTEXT_MINOR_VERSION_ARB)) >= 0)
					adulteredAttribs[minorVersionIndex + 1] = minor;
				else
					adulteredAttribs.AddRange(new[] { Wgl.CONTEXT_MINOR_VERSION_ARB, api.Minor });

				if (profileMask != 0) {
					int profileMaskIndex;
					if ((profileMaskIndex = adulteredAttribs.FindIndex(item => item == Wgl.CONTEXT_PROFILE_MASK_ARB)) >= 0)
						adulteredAttribs[profileMaskIndex + 1] = profileMask;
					else
						adulteredAttribs.AddRange(new[] { Wgl.CONTEXT_PROFILE_MASK_ARB, profileMask });
				}

				// Restore trailing 0
				adulteredAttribs.Add(Gl.NONE);

				ctx = Wgl.CreateContextAttribsARB(DeviceContext, sharedContext, adulteredAttribs.ToArray());
			} else
				ctx = Wgl.CreateContextAttribsARB(DeviceContext, sharedContext, attribsList);

			if (ctx == IntPtr.Zero)
				throw new WglException(Marshal.GetLastWin32Error());

			return (ctx);
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
			// Avoid actual call to wglMakeCurrent if it is not necessary
			// Efficient on simple/nominal applications
			IntPtr currentContext = Wgl.GetCurrentContext(), currentDc = Wgl.GetCurrentDC();
			if (ctx == currentContext && DeviceContext == currentDc)
				return true;

			// Base implementation
			return base.MakeCurrent(ctx);
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
			return Wgl.MakeCurrent(DeviceContext, ctx);
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

			return Wgl.DeleteContext(ctx);
		}

		/// <summary>
		/// Swap the buffers of a device.
		/// </summary>
		public override void SwapBuffers()
		{
			Wgl.UnsafeNativeMethods.GdiSwapBuffersFast(DeviceContext);
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
		[RequiredByFeature("WGL_EXT_swap_control")]
		public override bool SwapInterval(int interval)
		{
			if (Wgl.CurrentExtensions.SwapControl_EXT == false)
				throw new InvalidOperationException("WGL_EXT_swap_control not supported");
			if (interval == -1 && Wgl.CurrentExtensions.SwapControlTear_EXT == false)
				throw new InvalidOperationException("WGL_EXT_swap_control_tear not supported");

			return Wgl.SwapIntervalEXT(interval);
		}

		/// <summary>
		/// Query platform extensions available.
		/// </summary>
		internal override void QueryPlatformExtensions()
		{
			Wgl.CurrentExtensions = new Wgl.Extensions();
			Wgl.CurrentExtensions.Query(this);
		}

		/// <summary>
		/// Gets the platform exception relative to the last operation performed.
		/// </summary>
		/// <returns>
		/// The platform exception relative to the last operation performed.
		/// </returns>
		[SuppressMessage("Microsoft.Interoperability", "CA1404:CallGetLastErrorImmediatelyAfterPInvoke")]
		public override Exception GetPlatformException()
		{
			return GetPlatformExceptionCore();
		}

		/// <summary>
		/// Gets the platform exception relative to the last operation performed.
		/// </summary>
		/// <returns>
		/// The platform exception relative to the last operation performed.
		/// </returns>
		internal static Exception GetPlatformExceptionCore()
		{
			Exception platformException = null;

			int win32Error = Marshal.GetLastWin32Error();
			if (win32Error != 0)
				platformException = new Win32Exception(win32Error);

			return platformException;
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

				// Query pixel formats
				_PixelFormatCache = Wgl.CurrentExtensions != null && Wgl.CurrentExtensions.PixelFormat_ARB ? GetPixelFormats_ARB_pixel_format(Wgl.CurrentExtensions) : GetPixelFormats_Win32();

				return _PixelFormatCache;
			}
		}

		[RequiredByFeature("WGL_ARB_pixel_format")]
		private DevicePixelFormatCollection GetPixelFormats_ARB_pixel_format(Wgl.Extensions wglExtensions)
		{
			// Get the number of pixel formats
			int[] countFormatAttribsCodes = { Wgl.NUMBER_PIXEL_FORMATS_ARB };
			int[] countFormatAttribsValues = new int[countFormatAttribsCodes.Length];

			Wgl.GetPixelFormatAttribARB(DeviceContext, 1, 0, (uint)countFormatAttribsCodes.Length, countFormatAttribsCodes, countFormatAttribsValues);

			// Request configurations
			List<int> pixelFormatAttribsCodes = new List<int>(12)
			{
				Wgl.SUPPORT_OPENGL_ARB,		// Required to be Gl.TRUE
				Wgl.ACCELERATION_ARB,		// Required to be Wgl.FULL_ACCELERATION or Wgl.ACCELERATION_ARB
				Wgl.PIXEL_TYPE_ARB,
				Wgl.DRAW_TO_WINDOW_ARB,
				Wgl.DRAW_TO_BITMAP_ARB,
				Wgl.DOUBLE_BUFFER_ARB,
				Wgl.SWAP_METHOD_ARB,
				Wgl.STEREO_ARB,
				Wgl.COLOR_BITS_ARB,
				Wgl.DEPTH_BITS_ARB,
				Wgl.STENCIL_BITS_ARB
			};

#if SUPPORT_MULTISAMPLE
			// Multisample extension
			if (wglExtensions.Multisample_ARB || wglExtensions.Multisample_EXT) {
				pixelFormatAttribsCodes.Add(Wgl.SAMPLE_BUFFERS_ARB);
				pixelFormatAttribsCodes.Add(Wgl.SAMPLES_ARB);
			}
			int pixelFormatAttribMultisampleIndex = pixelFormatAttribsCodes.Count - 1;
#endif

#if SUPPORT_PBUFFER
			if (wglExtensions.Pbuffer_ARB || wglExtensions.Pbuffer_EXT) {
				pixelFormatAttribsCodes.Add(Wgl.DRAW_TO_PBUFFER_ARB);
			}
			int pixelFormatAttribPBufferIndex = pixelFormatAttribsCodes.Count - 1;
#endif

#if SUPPORT_FRAMEBUFFER_SRGB
			// Framebuffer sRGB extension
			if (wglExtensions.FramebufferSRGB_ARB || wglExtensions.FramebufferSRGB_EXT)
				pixelFormatAttribsCodes.Add(Wgl.FRAMEBUFFER_SRGB_CAPABLE_ARB);
			int pixelFormatAttribFramebufferSrgbIndex = pixelFormatAttribsCodes.Count - 1;
#endif

			// Create pixel format collection
			DevicePixelFormatCollection pixelFormats = new DevicePixelFormatCollection();

			// Retrieve information about available pixel formats
			int[] pixelFormatAttribValues = new int[pixelFormatAttribsCodes.Count];

			for (int pixelFormatIndex = 1; pixelFormatIndex < countFormatAttribsValues[0]; pixelFormatIndex++) {
				DevicePixelFormat pixelFormat = new DevicePixelFormat();

				Wgl.GetPixelFormatAttribARB(DeviceContext, pixelFormatIndex, 0, (uint)pixelFormatAttribsCodes.Count, pixelFormatAttribsCodes.ToArray(), pixelFormatAttribValues);

				// Check minimum requirements
				if (pixelFormatAttribValues[0] != Gl.TRUE)
					continue;       // No OpenGL support
				if (pixelFormatAttribValues[1] != Wgl.FULL_ACCELERATION_ARB)
					continue;       // No hardware acceleration

				switch (pixelFormatAttribValues[2]) {
					case Wgl.TYPE_RGBA_ARB:
#if SUPPORT_PIXEL_FORMAT_FLOAT
					case Wgl.TYPE_RGBA_FLOAT_ARB:
#endif
#if SUPPORT_PIXEL_FORMAT_PACKED_FLOAT
					case Wgl.TYPE_RGBA_UNSIGNED_FLOAT_EXT:
#endif
						break;
					default:
						continue;       // Ignored pixel type
				}

				// Collect pixel format attributes
				pixelFormat.FormatIndex = pixelFormatIndex;

				switch (pixelFormatAttribValues[2]) {
					case Wgl.TYPE_RGBA_ARB:
						pixelFormat.RgbaUnsigned = true;
						break;
					case Wgl.TYPE_RGBA_FLOAT_ARB:
						pixelFormat.RgbaFloat = true;
						break;
					case Wgl.TYPE_RGBA_UNSIGNED_FLOAT_EXT:
						pixelFormat.RgbaFloat = pixelFormat.RgbaUnsigned = true;
						break;
				}

				pixelFormat.RenderWindow = pixelFormatAttribValues[3] == Gl.TRUE;
				pixelFormat.RenderBuffer = pixelFormatAttribValues[4] == Gl.TRUE;

				pixelFormat.DoubleBuffer = pixelFormatAttribValues[5] == Gl.TRUE;
				pixelFormat.SwapMethod = pixelFormatAttribValues[6];
				pixelFormat.StereoBuffer = pixelFormatAttribValues[7] == Gl.TRUE;

				pixelFormat.ColorBits = pixelFormatAttribValues[8];
				pixelFormat.DepthBits = pixelFormatAttribValues[9];
				pixelFormat.StencilBits = pixelFormatAttribValues[10];

#if SUPPORT_MULTISAMPLE
				if (wglExtensions.Multisample_ARB || wglExtensions.Multisample_EXT) {
					Debug.Assert(pixelFormatAttribMultisampleIndex >= 0);
					pixelFormat.MultisampleBits = pixelFormatAttribValues[pixelFormatAttribMultisampleIndex];
				}
#endif

#if SUPPORT_PBUFFER
				if (wglExtensions.Pbuffer_ARB || wglExtensions.Pbuffer_EXT) {
					Debug.Assert(pixelFormatAttribPBufferIndex >= 0);
					pixelFormat.RenderPBuffer = pixelFormatAttribValues[pixelFormatAttribPBufferIndex] == Gl.TRUE;
				}
#endif

#if SUPPORT_FRAMEBUFFER_SRGB
				if (wglExtensions.FramebufferSRGB_ARB || wglExtensions.FramebufferSRGB_EXT) {
					Debug.Assert(pixelFormatAttribFramebufferSrgbIndex >= 0);
					pixelFormat.SRGBCapable = pixelFormatAttribValues[pixelFormatAttribFramebufferSrgbIndex] != 0;
				}
#endif

				pixelFormats.Add(pixelFormat);
			}

			return pixelFormats;
		}

		private DevicePixelFormatCollection GetPixelFormats_Win32()
		{
			DevicePixelFormatCollection pixelFormats = new DevicePixelFormatCollection();
			Wgl.PIXELFORMATDESCRIPTOR pixelDescr = new Wgl.PIXELFORMATDESCRIPTOR();
			int pixelFormatsCount = Wgl.DescribePixelFormat(DeviceContext, 0, 0, ref pixelDescr);

			for (int i = 1; i <= pixelFormatsCount; i++) {
				Wgl.DescribePixelFormat(DeviceContext, i, (uint)Marshal.SizeOf(typeof(Wgl.PIXELFORMATDESCRIPTOR)), ref pixelDescr);

				if ((pixelDescr.dwFlags & Wgl.PixelFormatDescriptorFlags.SupportOpenGL) == 0)
					continue;

				DevicePixelFormat pixelFormat = new DevicePixelFormat
				{
					FormatIndex = i,
					RgbaUnsigned = true,
					RgbaFloat = false,
					RenderWindow = true,
					RenderBuffer = false,
					DoubleBuffer = (pixelDescr.dwFlags & Wgl.PixelFormatDescriptorFlags.Doublebuffer) != 0,
					SwapMethod = 0,
					StereoBuffer = (pixelDescr.dwFlags & Wgl.PixelFormatDescriptorFlags.Stereo) != 0,
					ColorBits = pixelDescr.cColorBits,
					DepthBits = pixelDescr.cDepthBits,
					StencilBits = pixelDescr.cStencilBits,
					MultisampleBits = 0,
					RenderPBuffer = false,
					SRGBCapable = false
				};

				pixelFormats.Add(pixelFormat);
			}

			return pixelFormats;
		}

		/// <summary>
		/// Pixel formats available on this DeviceContext (cache).
		/// </summary>
		private DevicePixelFormatCollection _PixelFormatCache;

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		public override void ChoosePixelFormat(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException(nameof(pixelFormat));

			if (IsPixelFormatSet)
				throw new InvalidOperationException("pixel format already set");

			// Choose pixel format
			int pixelFormatIndex = ChoosePixelFormat(DeviceContext, pixelFormat);
			
			// Set choosen pixel format
			Wgl.PIXELFORMATDESCRIPTOR pDescriptor = new Wgl.PIXELFORMATDESCRIPTOR();

			if (Wgl.SetPixelFormat(DeviceContext, pixelFormatIndex, ref pDescriptor) == false)
				throw new InvalidOperationException("unable to set pixel format", GetPlatformException());

			IsPixelFormatSet = true;
		}

		/// <summary>
		/// Set the device pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specifies the pixel format to set.
		/// </param>
		private static int ChoosePixelFormat(IntPtr deviceContext, DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException(nameof(pixelFormat));

			List<int> attribIList = new List<int>();
			uint[] countFormatAttribsValues = new uint[1];
			int[] choosenFormats = new int[4];

			attribIList.AddRange(new[] { Wgl.SUPPORT_OPENGL_ARB, Gl.TRUE });
			if (pixelFormat.RenderWindow)
				attribIList.AddRange(new[] { Wgl.DRAW_TO_WINDOW_ARB, Gl.TRUE });
			if (pixelFormat.RenderPBuffer)
				attribIList.AddRange(new[] { Wgl.DRAW_TO_PBUFFER_ARB, Gl.TRUE });

			if (pixelFormat.RgbaUnsigned)
				attribIList.AddRange(new[] { Wgl.PIXEL_TYPE_ARB, Wgl.TYPE_RGBA_ARB });
			if (pixelFormat.RgbaFloat)
				attribIList.AddRange(new[] { Wgl.PIXEL_TYPE_ARB, Wgl.TYPE_RGBA_FLOAT_ARB });

			if (pixelFormat.ColorBits > 0)
				attribIList.AddRange(new[] { Wgl.COLOR_BITS_ARB, pixelFormat.ColorBits });
			if (pixelFormat.DepthBits > 0)
				attribIList.AddRange(new[] { Wgl.DEPTH_BITS_ARB, pixelFormat.DepthBits });
			if (pixelFormat.StencilBits > 0)
				attribIList.AddRange(new[] { Wgl.STENCIL_BITS_ARB, pixelFormat.StencilBits });

			if (pixelFormat.DoubleBuffer)
				attribIList.AddRange(new[] { Wgl.DOUBLE_BUFFER_ARB, 1 });
			attribIList.Add(0);

			// Let choose pixel formats
			if (!Wgl.ChoosePixelFormatARB(deviceContext, attribIList.ToArray(), new List<float>().ToArray(), (uint)choosenFormats.Length, choosenFormats, countFormatAttribsValues))
				throw new InvalidOperationException("unable to choose pixel format", GetPlatformExceptionCore());

			return choosenFormats[0];
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
			if (IsPixelFormatSet)
				throw new InvalidOperationException("pixel format already set");

#if CHOOSE_PIXEL_FORMAT_FALLBACK
			try {
#endif
				Wgl.PIXELFORMATDESCRIPTOR pDescriptor = new Wgl.PIXELFORMATDESCRIPTOR();

				// Note (from MSDN): Setting the pixel format of a window more than once can lead to significant complications for the Window Manager
				// and for multithread applications, so it is not allowed. An application can only set the pixel format of a window one time. Once a
				// window's pixel format is set, it cannot be changed.

				if (Wgl.DescribePixelFormat(DeviceContext, pixelFormat.FormatIndex, (uint)pDescriptor.nSize, ref pDescriptor) == 0)
					throw new InvalidOperationException($"unable to describe pixel format {pixelFormat.FormatIndex}", GetPlatformException());

				// Set choosen pixel format
				if (!Wgl.SetPixelFormat(DeviceContext, pixelFormat.FormatIndex, ref pDescriptor))
					throw new InvalidOperationException($"unable to set pixel format {pixelFormat.FormatIndex}", GetPlatformException());

#if CHOOSE_PIXEL_FORMAT_FALLBACK
			} catch (InvalidOperationException) {
				// Try using default ChoosePixelFormat*
				SetDisplayablePixelFormat(pixelFormat);
			}
#endif

			IsPixelFormatSet = true;
		}

#if CHOOSE_PIXEL_FORMAT_FALLBACK

		/// <summary>
		/// Set pixel format by letting the driver choose the best pixel format following the criteria.
		/// </summary>
		/// <param name="pixelFormat">
		/// 
		/// </param>
		private void SetDisplayablePixelFormat(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException("pixelFormat");

			List<int> attribIList = new List<int>();
			List<float> attribFList = new List<float>();
			Wgl.PIXELFORMATDESCRIPTOR pDescriptor = new Wgl.PIXELFORMATDESCRIPTOR();
			uint[] countFormatAttribsValues = new uint[1];
			int[] choosenFormats = new int[4];

			// Let choose pixel formats
			if (!Wgl.ChoosePixelFormatARB(_DeviceContext, attribIList.ToArray(), attribFList.ToArray(), (uint)choosenFormats.Length, choosenFormats, countFormatAttribsValues)) {
				Win32Exception innerException = new Win32Exception(Marshal.GetLastWin32Error());
				throw new InvalidOperationException(String.Format("unable to choose pixel format: {0}", innerException.Message), innerException);
			}
			
			// Set choosen pixel format
			if (Wgl.SetPixelFormat(_DeviceContext, choosenFormats[0], ref pDescriptor) == false) {
				Win32Exception innerException = new Win32Exception(Marshal.GetLastWin32Error());
				throw new InvalidOperationException(String.Format("unable to set pixel format {0}: {1}", pixelFormat.FormatIndex, innerException.Message), innerException);
			}
		}

#endif

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether the disposition is requested explictly.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Release device context
				if (DeviceContext != IntPtr.Zero) {
					if (_DeviceContextPBuffer == false) {
						bool res = Wgl.ReleaseDC(_WindowHandle, DeviceContext);
						Debug.Assert(res);
					} else {
						int res = Wgl.ReleasePbufferDCARB(_WindowHandle, DeviceContext);
						Debug.Assert(res == 1);
					}

					DeviceContext = IntPtr.Zero;
					_WindowHandle = IntPtr.Zero;
				}
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}