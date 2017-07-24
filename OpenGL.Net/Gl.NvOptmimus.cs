
// Copyright (C) 2017 Luca Piccioni
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
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// NVIDIA specific functions.
	/// </summary>
	public partial class Gl
	{
		#region NvOptimusEnablement (NOT Working)

		const uint PAGE_READWRITE = 0x04;

		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

		/// <summary>
		/// Idea and code inspired by https://github.com/lmagder/OptimusEnablementNET/.
		/// </summary>
		public static void NvOptimusEnablementExport()
		{
			try {
				IntPtr moduleHandle = Marshal.GetHINSTANCE(Assembly.GetEntryAssembly().GetModules()[0]);
				IntPtr nvOptimusEnablementExportAddress = GetProcAddress.GetProcAddressOS.GetProcAddress(moduleHandle, "NvOptimusEnablement");

				if (nvOptimusEnablementExportAddress != IntPtr.Zero) {
					uint oldProtect = 0;

					// Let be writeable
					if (VirtualProtect(nvOptimusEnablementExportAddress, 4, PAGE_READWRITE, out oldProtect)) {
						unsafe {
							uint* dwordValuePtr = (uint*)nvOptimusEnablementExportAddress.ToPointer();

							// Set the NV Optimus flag
							// Note: Overwrites NvOptimusEnablement_Placeholder pointer
							*dwordValuePtr = NvOptimusEnablement;
						}
						VirtualProtect(nvOptimusEnablementExportAddress, 4, oldProtect, out oldProtect);
					}
				}
			} catch {

			}
		}

		/// <summary>
		/// Valid of the NvOptimusEnablement (new in Driver Release 302).
		/// </summary>
		private static uint NvOptimusEnablement = 1;

		#endregion
	}
}
