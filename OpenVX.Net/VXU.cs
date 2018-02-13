
// Copyright (C) 2017 Luca Piccioni
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
using System.Runtime.InteropServices;

using Khronos;

namespace OpenVX
{
	/// <summary>
	/// OpenVX bindings.
	/// </summary>
	public partial class VXU : KhronosApi
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static VXU()
		{
			// Before linking procedures, append OpenVX directory in path
			string assemblyPath = GetAssemblyLocation();
			string vxPath = null;

			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					if (assemblyPath != null) {
#if DEBUG
						if (IntPtr.Size == 8)
							vxPath = Path.Combine(assemblyPath, @"AMDOVX\Debug\x64");
						else
							vxPath = Path.Combine(assemblyPath, @"AMDOVX\Debug\x86");
#else
						if (IntPtr.Size == 8)
							vxPath = Path.Combine(assemblyPath, @"AMDOVX\Release\x64");
						else
							vxPath = Path.Combine(assemblyPath, @"AMDOVX\Release\x86");
#endif
					}
					break;
			}

#if NETSTANDARD1_1
			if (vxPath != null)
				Khronos.GetProcAddressOS.AddLibraryDirectory(Path.Combine(assemblyPath, anglePath));
#else
			if (vxPath != null && Directory.Exists(vxPath))
				Khronos.GetProcAddressOS.AddLibraryDirectory(Path.Combine(assemblyPath, vxPath));
#endif

			// Load procedures
			string platformLibrary = GetPlatformLibrary();

			LogComment($"Querying OpenVX from {platformLibrary}");
			BindAPI<VX>(platformLibrary, KhronosApi.GetProcAddressOS, null);
		}

		#endregion

		#region API Binding

		/// <summary>
		/// Get the library name used for loading OpenGL functions.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="String"/> that specifies the library name to be used.
		/// </returns>
		private static string GetPlatformLibrary()
		{
			switch (Platform.CurrentPlatformId) {
				default:
					return (Library);
			}
		}

		/// <summary>
		/// Default import library.
		/// </summary>
		private const string Library = "OpenVX.dll";

		#endregion

		#region Error Handling

		/// <summary>
		/// OpenGL error checking.
		/// </summary>
		/// <param name="returnValue">
		/// A <see cref="Object"/> that specifies the function returned value, if any.
		/// </param>
		[Conditional("VX_DEBUG")]
		private static void DebugCheckErrors(Status returnValue)
		{
			if (returnValue != Status.Success)
				throw new InvalidOperationException("command status " + returnValue);
		}

		#endregion
	}
}
