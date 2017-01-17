
// Copyright (C) 2015-2016 Luca Piccioni
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

#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

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
			string assemblyPath = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Egl)).Location);
			string anglePath = null;

			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
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
					break;
				case Platform.Id.Linux:
					// Note: on RPi libEGL.so depends on libGLESv2.so, so it's required to pre-load the shared library
					GetProcAddressX11.Instance.GetLibraryHandle("libGLESv2.so");
					break;
			}

			// Include ANGLE path, if any
			if (anglePath != null && Directory.Exists(anglePath))
				OpenGL.GetProcAddress.GetProcAddressOS.AddLibraryDirectory(Path.Combine(assemblyPath, anglePath));

			// Load procedures
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment("Querying EGL from {0}", platformLibrary);
				BindAPI<Egl>(platformLibrary, OpenGL.GetProcAddress.GetProcAddressOS);
				LogComment("EGL availability: {0}", IsAvailable);
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment("EGL not available:\n{0}", exception.ToString());
			}

			// Support for BCM VideoCore API
			if (IsAvailable && Bcm.IsAvailable) {
				// This need to be executed before any EGL/GL routine
				Bcm.bcm_host_init();
			}

#if DEBUG
			string envEglInit = Environment.GetEnvironmentVariable("EGL_INIT");

			if (envEglInit != null && envEglInit == "NO")
				return;
#endif

			// Get EGL information
			if (IsAvailable) {
				IntPtr eglDisplay = GetDisplay(new IntPtr(DEFAULT_DISPLAY));

				try {
					if (Initialize(eglDisplay, null, null) == false)
						throw new InvalidOperationException("unable to initialize EGL");

					// Query EGL version
					string eglVersionString = QueryString(eglDisplay, VERSION);
					_CurrentVersion = KhronosVersion.Parse(eglVersionString, KhronosVersion.ApiEgl);
					// Query EGL vendor
					_Vendor = QueryString(eglDisplay, VENDOR);
					// Client APIs
					if (_CurrentVersion >= Version_120) {
						string clientApisString = QueryString(eglDisplay, CLIENT_APIS);
						_AvailableApis = System.Text.RegularExpressions.Regex.Split(clientApisString, " ");
					}
				} finally {
					Terminate(eglDisplay);
				}
			}
		}

		/// <summary>
		/// Flag indicating whether <see cref="Egl"/> has been initialized.
		/// </summary>
		private static bool _Initialized;

		#endregion

		#region Versions, Extensions and Limits

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
		/// Get or set whether <see cref="DeviceContextFactory"/> should create an EGL device context, if available.
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
		internal const string Library = "libEGL.dll";

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

		#region Procedure Logging

		/// <summary>
		/// Query <see cref="Egl"/> enumeration names, for logging purposes.
		/// </summary>
		/// <remarks>
		/// After having called this method, the method <see cref="LogFunction"/> will output known enumeration
		/// names instead of the numerical value.
		/// </remarks>
		public static void QueryLogContext()
		{
			_LogContext = QueryLogContext(typeof(Egl));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValue">
		/// A <see cref="Int32"/> that specifies the enumeration value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValue"/> as hexadecimal value. If the
		/// name of the enumeration value is detected, it returns the relative OpenGL specification name.
		/// </returns>
		protected static new string LogEnumName(int enumValue)
		{
			string enumName;

			if (_LogContext.EnumNames != null && _LogContext.EnumNames.TryGetValue(enumValue, out enumName))
				return (enumName);
			else
				return (KhronosApi.LogEnumName(enumValue));
		}

		/// <summary>
		/// Log an enumeration value.
		/// </summary>
		/// <param name="enumValues">
		/// An array of <see cref="Int32"/> that specifies the enumeration values.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="enumValues"/> as hexadecimal value.
		/// </returns>
		protected static new string LogEnumName(int[] enumValues)
		{
			if (enumValues.Length > 4) {
				return ("{ ... }");
			} else {
				StringBuilder sb = new StringBuilder();

				sb.Append("{");
				foreach (int enumValue in enumValues)
					sb.AppendFormat("{0},", LogEnumName(enumValue));
				if (enumValues.Length > 0)
					sb.Remove(sb.Length - 1, 1);
				sb.Append("}");

				return (sb.ToString());
			}
		}

		/// <summary>
		/// Log an bitmask value.
		/// </summary>
		/// <param name="bitmaskName">
		/// A <see cref="String"/> that specifies the enumeration bitmask name.
		/// </param>
		/// <param name="bitmaskValue">
		/// A <see cref="Int32"/> that specifies the enumeration bitmask value.
		/// </param>
		/// <returns>
		/// It returns a <see cref="String"/> that represents <paramref name="bitmaskValue"/>.
		/// </returns>
		protected static new string LogEnumBitmask(string bitmaskName, long bitmaskValue)
		{
			Dictionary<long, String> bitmaskNames;

			if (_LogContext.EnumBitmasks.TryGetValue(bitmaskName, out bitmaskNames) == false)
				return (KhronosApi.LogEnumBitmask(bitmaskName, bitmaskValue));

			return (KhronosApi.LogEnumBitmask(bitmaskValue, bitmaskNames));
		}

		/// <summary>
		/// Enumeration names indexed by their value.
		/// </summary>
		private static LogContext _LogContext = new LogContext();

		#endregion

		#region Required External Declarations

		/// <summary>
		/// Structure corresponding to EGLClientPixmapHI.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		public struct ClientPixmap
		{
			public IntPtr Data;

			public Int32 Width;

			public Int32 Height;

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
