
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

namespace OpenGL
{
	public partial class Glx
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
			/// A <see cref="DeviceContextGLX"/> that specifies the device context to query extensions for.
			/// </param>
			internal void Query(DeviceContextGLX deviceContext)
			{
				if (deviceContext == null)
					throw new ArgumentNullException("deviceContext");

				LogComment("Query GLX extensions.");

				string glxExtensions = null;
				int[] majorArg = new int[1], minorArg = new int[1];

				using (Glx.XLock xLock = new Glx.XLock(deviceContext.Display)) {
					Glx.QueryVersion(deviceContext.Display, majorArg, minorArg);

					if ((majorArg[0] >= 1) && (minorArg[0] >= 1))
						glxExtensions = Glx.QueryExtensionsString(deviceContext.Display, 0);
				}

				Query(new KhronosVersion(majorArg[0], minorArg[0], KhronosVersion.ApiGlx), glxExtensions ?? String.Empty);
			}

			/// <summary>
			/// Clone this instance.
			/// </summary>
			/// <returns>
			/// It returns a deep copy of this Extension.
			/// </returns>
			public Extensions Clone()
			{
				return ((Extensions)MemberwiseClone());
			}
		}
	}
}
