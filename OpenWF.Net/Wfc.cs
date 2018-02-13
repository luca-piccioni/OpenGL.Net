
// Copyright (C) 2015-2017 Luca Piccioni
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

using Khronos;

namespace OpenWF
{
	/// <summary>
	/// Modern OpenGL bindings: OpenWF Composition API.
	/// </summary>
	public partial class Wfc : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Wfc()
		{
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.Linux:
					// Note: on RPi libWFC.so depends on libGLESv2.so, so it's required to pre-load the shared library
					GetProcAddressLinux.GetLibraryHandle("libGLESv2.so");
					break;
			}

			// Load procedures
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment($"Querying OpenWF Compositor from {platformLibrary}");
				BindAPI<Wfc>(platformLibrary, GetProcAddressOS, null);
				LogComment($"OpenWF Compositor availability: {IsAvailable}");
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment($"OpenWF Compositor not available:\n{exception}");
			}
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether OpenWF Composition layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.pwfcCompose != null); } }

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
					return ("libWFC.so");
				default:
					return (Library);
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string Library = "libWFC.dll";

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenWF Composition error checking.
		/// </summary>
		public static void CheckErrors(WFCErrorCode errorCode)
		{
			if (errorCode != WFCErrorCode.ErrorNone)
				throw new InvalidOperationException(String.Format("OpenWF error: {0}", errorCode));
		}

		/// <summary>
		/// OpenWF Composition error checking.
		/// </summary>
		private static void DebugCheckErrors(object returnValue)
		{
			
		}

		#endregion
	}
}
