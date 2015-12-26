
// Copyright (C) 2015 Luca Piccioni
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

namespace OpenGL
{
	public partial class Wgl
	{
		/// <summary>
		/// Extension support listing.
		/// </summary>
		public partial class Extensions : ExtensionsCollection
		{
			/// <summary>
			/// Query the extensions supported by current platform.
			/// </summary>
			/// <param name="deviceContext">
			/// A <see cref="WindowsDeviceContext"/> that specifies the device context to query extensions for.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="deviceContext"/> is null.
			/// </exception>
			public void Query(WindowsDeviceContext deviceContext)
			{
				if (deviceContext == null)
					throw new ArgumentNullException("deviceContext");

				LogComment("Query WGL extensions.");

				string wglExtensions = null;

				if (Delegates.pwglGetExtensionsStringARB != null) {
					wglExtensions = GetExtensionsStringARB(deviceContext.DeviceContext);
				} else if (Delegates.pwglGetExtensionsStringEXT != null) {
					wglExtensions = GetExtensionsStringEXT();
				}

				Query(new KhronosVersion(1, 0), wglExtensions ?? String.Empty);
			}
		}
	}
}
