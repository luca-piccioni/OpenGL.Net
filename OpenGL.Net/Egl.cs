﻿
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Modern OpenGL bindings: EGL, Native Platform Interface.
	/// </summary>
	public partial class Egl : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Egl()
		{
#if !NETSTANDARD1_1
			// Optional initialization
			string envEglStaticInit = Environment.GetEnvironmentVariable("OPENGL_NET_EGL_STATIC_INIT");
			if (envEglStaticInit != null && envEglStaticInit == "NO")
				return;
#endif
			// Do not automatically initialize Egl on Android & Debug configurations
			Initialize();
		}

		/// <summary>
		/// Initialize OpenGL namespace static environment. This method shall be called before any other classes methods.
		/// </summary>
		public static void Initialize()
		{
			if (_Initialized == true)
				return; // Already initialized
			_Initialized = true;

			// Before linking procedures, append ANGLE directory in path
			string assemblyPath = GetAssemblyLocation();
			string anglePath = null;

			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					if (assemblyPath != null) {
#if DEBUG
						if (IntPtr.Size == 8)
							anglePath = Path.Combine(assemblyPath, @"ANGLE\winrt10d\x64");
						else
							anglePath = Path.Combine(assemblyPath, @"ANGLE\winrt10d\x86");
#else
						if (IntPtr.Size == 8)
							anglePath = Path.Combine(assemblyPath, @"ANGLE\winrt10\x64");
						else
							anglePath = Path.Combine(assemblyPath, @"ANGLE\winrt10\x86");
#endif
					}
					break;
				case Platform.Id.Linux:
					// Note: on RPi libEGL.so depends on libGLESv2.so, so it's required to pre-load the shared library
					// Note: maybe a configurable and generic method for pre-loading assemblies may be introduced
					GetProcAddressLinux.GetLibraryHandle("libGLESv2.so", false);
					break;
			}

			// Include ANGLE path, if any
#if NETSTANDARD1_1
			if (anglePath != String.Empty)
				OpenGL.GetProcAddressOS.AddLibraryDirectory(Path.Combine(assemblyPath, anglePath));
#else
			if (anglePath != null && Directory.Exists(anglePath))
				OpenGL.GetProcAddressOS.AddLibraryDirectory(Path.Combine(assemblyPath, anglePath));
#endif

			// Load procedures
			BindAPI();

			if (IsAvailable == false)
				return;

#if DEBUG
			string envEglInit = Environment.GetEnvironmentVariable("EGL_INIT");

			if (envEglInit != null && envEglInit == "NO")
				return;
#endif

			// Platform initialization
			EglEventArgs args = new EglEventArgs();

			RaiseEglInitializing(args);

			// Get EGL information
			IntPtr eglDisplay = Egl.GetDisplay(args.Display);

			try {
				if (Initialize(eglDisplay, null, null) == false)
					throw new InvalidOperationException("unable to initialize EGL");

				// Query EGL version
				string eglVersionString = QueryString(eglDisplay, VERSION);
				_CurrentVersion = KhronosVersion.Parse(eglVersionString, KhronosVersion.ApiEgl);
				// Query EGL vendor
				_Vendor = QueryString(eglDisplay, VENDOR);
				// Client APIs
				List<string> clientApis = new List<string>();

				if (_CurrentVersion >= Version_120) {
					string clientApisString = QueryString(eglDisplay, CLIENT_APIS);
					string[] clientApiTokens = System.Text.RegularExpressions.Regex.Split(clientApisString, " ");

					foreach (string api in DeviceContextEGL.ConvertApiNames(clientApiTokens))
						clientApis.Add(api);
				}

				_AvailableApis = clientApis.ToArray();

				// Null device context for querying extensions
				using (DeviceContextEGL deviceContext = new DeviceContextEGL(args.Display, IntPtr.Zero)) {
					_CurrentExtensions = new Extensions();
					_CurrentExtensions.Query(deviceContext);
				}
			} finally {
				Terminate(eglDisplay);
			}
		}

		/// <summary>
		/// Flag indicating whether <see cref="Egl"/> has been initialized.
		/// </summary>
		private static bool _Initialized;

		#endregion

		#region Versions & Platform Extensions

		/// <summary>
		/// EGL version currently implemented.
		/// </summary>
		public static KhronosVersion CurrentVersion { get { return (_CurrentVersion); } }

		/// <summary>
		/// EGL version currently implemented.
		/// </summary>
		private static KhronosVersion _CurrentVersion;

		/// <summary>
		/// Get the EGL vendor.
		/// </summary>
		public static string CurrentVendor { get { return (_Vendor); } }

		/// <summary>
		/// EGL vendor.
		/// </summary>
		private static string _Vendor;

		/// <summary>
		/// EGL available APIs.
		/// </summary>
		internal static string[] _AvailableApis;

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		public static Extensions CurrentExtensions { get { return (_CurrentExtensions); } }

		/// <summary>
		/// OpenGL extension support.
		/// </summary>
		internal static Extensions _CurrentExtensions;

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether EGL layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.peglInitialize != null); } }

		/// <summary>
		/// Get or set whether <see cref="DeviceContext"/> should create an EGL handles, if available.
		/// </summary>
		public static bool IsRequired
		{
			get
			{
				switch (Platform.CurrentPlatformId) {
					case Platform.Id.Android:
						return (true);
					default:
						return (_IsRequired && IsAvailable);
				}
			}
			set { _IsRequired = value; }
		}

		/// <summary>
		/// Flag for requesting an EGL device context, if available.
		/// </summary>
		private static bool _IsRequired;

		/// <summary>
		/// Bind Windows EGL delegates.
		/// </summary>
		private static void BindAPI()
		{
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment("Querying EGL from {0}", platformLibrary);
				BindAPI<Egl>(platformLibrary, GetProcAddressOS, CurrentVersion);
				LogComment("EGL availability: {0}", IsAvailable);
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment("EGL not available:\n{0}", exception.ToString());
			}
		}

		/// <summary>
		/// Get the library name used for loading OpenGL functions.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the library name to be used.
		/// </returns>
		private static string GetPlatformLibrary()
		{
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.Linux:
					return ("libEGL.so");
				default:
					return (Library);
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string Library = "libEGL";

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		[Conditional("GL_DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			int error = GetError();

			if (error != SUCCESS)
				throw new EglException(error);
		}

		#endregion

		#region Command Logging

		/// <summary>
		/// Load an API command call.
		/// </summary>
		/// <param name="name">
		/// A <see cref="String"/> that specifies the name of the API command.
		/// </param>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the returned value, if any.
		/// </param>
		/// <param name="args">
		/// A <see cref="T:Object[]"/> that specifies the API command arguments, if any.
		/// </param>
		[Conditional("GL_DEBUG")]
		protected static new void LogCommand(string name, object returnValue, params object[] args)
		{
			if (_LogContext == null)
				_LogContext = new KhronosLogContext(typeof(Egl));
			RaiseLog(new KhronosLogEventArgs(_LogContext, name, args, returnValue));
		}

		/// <summary>
		/// Context for logging enumerant names instead of numerical values.
		/// </summary>
		private static KhronosLogContext _LogContext;

		#endregion

		#region Required External Declarations

		/// <summary>
		/// Structure corresponding to EGLClientPixmapHI.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct ClientPixmap
		{
			/// <summary>
			/// Pointer to the client pixmap data.
			/// </summary>
			public IntPtr Data;

			/// <summary>
			/// Width of client pixmap, in pixels.
			/// </summary>
			public Int32 Width;

			/// <summary>
			/// Height of client pixmap, in pixels.
			/// </summary>
			public Int32 Height;

			/// <summary>
			/// Stride of the client pixmap row, in bytes.
			/// </summary>
			public Int32 Stride;
		}

		/// <summary>
		/// Delegate corresponding to EGLSetBlobFuncANDROID.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keySize"></param>
		/// <param name="value"></param>
		/// <param name="valueSize"></param>
		public delegate void SetBlobFuncDelegate(IntPtr key, UInt32 keySize, IntPtr value, UInt32 valueSize);

		/// <summary>
		/// Delegate corresponding to EGLGetBlobFuncANDROID.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keySize"></param>
		/// <param name="value"></param>
		/// <param name="valueSize"></param>
		public delegate void GetBlobFuncDelegate(IntPtr key, UInt32 keySize, [Out] IntPtr value, UInt32 valueSize);

		/// <summary>
		/// Delegate corresponding to EGLDEBUGPROCKHR.
		/// </summary>
		/// <param name="error"></param>
		/// <param name="command"></param>
		/// <param name="messageType"></param>
		/// <param name="threadLabel"></param>
		/// <param name="objectLabel"></param>
		/// <param name="message"></param>
		public delegate void DebugProcKHR(uint error, string command, int messageType, IntPtr threadLabel, IntPtr objectLabel, string message);

		#endregion
	}
}
