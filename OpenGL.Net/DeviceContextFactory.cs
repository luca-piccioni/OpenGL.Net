
// Copyright (C) 2013-2015 Luca Piccioni
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
using System.Windows.Forms;

namespace OpenGL
{
	/// <summary>
	/// Device context factory.
	/// </summary>
	public class DeviceContextFactory
	{
		/// <summary>
		/// Create the specified window.
		/// </summary>
		/// <param name='window'>
		/// A <see cref="Control"/> which handle is used to create the device context.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="window"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the handle of <see cref="window"/> is not created.
		/// </exception>
		/// <exception cref='NotSupportedException'>
		/// Exception thrown if the current platform is not supported.
		/// </exception>
		public static IDeviceContext Create(Control window)
		{
			if (window == null)
				throw new ArgumentNullException("window");
			if (window.Handle == IntPtr.Zero)
				throw new ArgumentException("handle not created", "window");

			switch (Environment.OSVersion.Platform) {
				case PlatformID.Win32Windows:
				case PlatformID.Win32S:
				case PlatformID.Win32NT:
				case PlatformID.WinCE:
					return (new WindowsDeviceContext(window));
				case PlatformID.Unix:
					// return (new XServerDeviceContext(window));
				default:
					throw new NotSupportedException(String.Format("platform {0} not supported", Environment.OSVersion));
			}
		}
	}
}