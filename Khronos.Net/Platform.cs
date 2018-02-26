
// Copyright (C) 2016-2018 Luca Piccioni
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
using System.IO;
using System.Reflection;
#if !NETFRAMEWORK
using System.Runtime.InteropServices;
#endif

namespace Khronos
{
	/// <summary>
	/// Detected platforms.
	/// </summary>
	public static class Platform
	{
		/// <summary>
		/// Static constructor.
		/// </summary>
		static Platform()
		{
			// Cache platform ID
			CurrentPlatformId = GetCurrentPlatform();
			// Detect Mono environment
			_MonoVersion = DetectMonoEnvironment();
		}

		/// <summary>
		/// Platform identifiers.
		/// </summary>
		public enum Id
		{
			/// <summary>
			/// Microsoft Windows NT.
			/// </summary>
			WindowsNT,

			/// <summary>
			/// GNU/Linux.
			/// </summary>
			Linux,

			/// <summary>
			/// Apple MacOS.
			/// </summary>
			MacOS,

			/// <summary>
			/// Android.
			/// </summary>
			Android,

			/// <summary>
			/// Unknown platform.
			/// </summary>
			Unknown,
		}

		/// <summary>
		/// Get the current platform ID.
		/// </summary>
		public static Id CurrentPlatformId { get; internal set; }

		/// <summary>
		/// Detected the current platform at runtime.
		/// </summary>
		/// <returns>
		/// It returns the detected platform.
		/// </returns>
		private static Id GetCurrentPlatform()
		{
#if !MONODROID
#if NETFRAMEWORK
			// Framework platform
			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32NT:
					return Id.WindowsNT;
				case PlatformID.Unix:
					// Android special case
					if (Type.GetType("Android.OS.Build, Mono.Android.dll") != null)
						return Id.Android;

					// Other cases: Linux, MacOS
					string unixName = DetectUnixKernel();

					switch (unixName) {
						case "Darwin":
							return Id.MacOS;
						default:
							return Id.Linux;
					}
				case PlatformID.MacOSX:
					return Id.MacOS;
				default:
					return Id.Unknown;
			}
#else
			if      (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
				return (Id.WindowsNT);
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
				return (Id.Linux);
			else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
				return (Id.MacOS);
			else
				return (Id.Unknown);
#endif
#else       // !MONODROID
			return (Id.Android);
#endif
		}

		/// <summary>
		/// Executes "uname" which returns a string representing the name of the
		/// underlying Unix kernel.
		/// </summary>
		/// <returns>
		/// "Unix", "Linux", "Darwin" or null.
		/// </returns>
		/// <remarks>
		/// Source code from "Mono: A Developer's Notebook"
		/// </remarks>
		private static string DetectUnixKernel()
		{
#if NETSTANDARD1_1 || NETSTANDARD1_4
			// XXX
#else
			ProcessStartInfo startInfo = new ProcessStartInfo {
				Arguments = "-s",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			};

			foreach (string unameprog in new[] { "/usr/bin/uname", "/bin/uname", "uname" }) {
				// Avoid exception handling
				if (File.Exists(unameprog) == false)
					continue;

				try {
					startInfo.FileName = unameprog;
					using (Process uname = Process.Start(startInfo)) {
						if (uname != null)
							return uname.StandardOutput.ReadLine()?.Trim();
					}
				} catch (FileNotFoundException) {
					// The requested executable doesn't exist, try next one.
				} catch (System.ComponentModel.Win32Exception) {
					// Fail-safe
				}
			}
#endif
			return null;
		}

		/// <summary>
		/// Get whether the running runtime is Mono.
		/// </summary>
		public static bool RunningMono { get { return _MonoVersion != null; } }

		/// <summary>
		/// The Mono display name, if any.
		/// </summary>
		private static readonly string _MonoVersion;

		/// <summary>
		/// Detect the Mono environment.
		/// </summary>
		/// <returns>
		/// It returns the version string of Mono, if running with it.
		/// </returns>
		private static string DetectMonoEnvironment()
		{
			Type monoRuntime = Type.GetType("Mono.Runtime", false);

			if (monoRuntime != null) {
				string runningVersion = "generic";
				try {
#if NETSTANDARD1_1 || NETSTANDARD1_4
					MethodInfo getDisplayName = monoRuntime.GetTypeInfo().GetDeclaredMethod("GetDisplayName");
#else
					MethodInfo getDisplayName = monoRuntime.GetMethod("GetDisplayName", BindingFlags.Static | BindingFlags.NonPublic);
#endif
					if (getDisplayName != null)
						runningVersion = getDisplayName.Invoke(null, new object[0]) as string;
				} catch { /* Ignore */ }

				return runningVersion;
			} else
				return null;
		}
	}
}
