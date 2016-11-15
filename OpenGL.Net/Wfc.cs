
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

using System;
using System.Diagnostics;

namespace OpenGL
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
			// Load procedures
			string platformLibrary = GetPlatformLibrary();
			try {
				LogComment("Querying OpenWF Compositor from {0}", platformLibrary);
				BindAPI<Egl>(platformLibrary, GetProcAddress.GetProcAddressOS);
				LogComment("OpenWF Compositor availability: {0}", IsAvailable);
			} catch (Exception exception) {
				/* Fail-safe (it may fail due Egl access) */
				LogComment("OpenWF Compositor not available:\n{0}", exception.ToString());
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
		[Conditional("DEBUG")]
		private static void DebugCheckErrors(object returnValue)
		{
			
		}

		#endregion
	}
}
