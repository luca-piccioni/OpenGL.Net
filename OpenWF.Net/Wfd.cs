
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

using System.Diagnostics;

namespace OpenWF
{
	/// <summary>
	/// Modern OpenGL bindings: OpenWF, Display API.
	/// </summary>
	public partial class Wfd : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Wfd()
		{
			// Load procedures
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment("Querying OpenWF Display from {0}", platformLibrary);
				BindAPI<Wfd>(platformLibrary, GetProcAddress.GetProcAddressOS);
				LogComment("OpenWF Display availability: {0}", IsAvailable);
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment("OpenWF Display not available:\n{0}", exception.ToString());
			}
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Get whether EGL layer is avaialable.
		/// </summary>
		public static bool IsAvailable { get { return (Delegates.pwfdCreateDevice != null); } }

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
					return ("libWFD.so");
				default:
					return (Library);
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		internal const string Library = "libWFD.dll";

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		[Conditional("GL_DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			
		}

		#endregion
	}
}
