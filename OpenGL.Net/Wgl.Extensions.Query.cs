
// Copyright (C) 2015-2017 Luca Piccioni
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
			/// A <see cref="DeviceContextWGL"/> that specifies the device context to query extensions for.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="deviceContext"/> is null.
			/// </exception>
			internal void Query(DeviceContextWGL deviceContext)
			{
				if (deviceContext == null)
					throw new ArgumentNullException("deviceContext");

				LogComment("Query WGL extensions.");

				string wglExtensions = null;

				BindAPIFunction<Wgl>(Library, "wglGetExtensionsStringARB", GetProcAddressGL, null, null);
				BindAPIFunction<Wgl>(Library, "wglGetExtensionsStringEXT", GetProcAddressGL, null, null);

				if (Delegates.pwglGetExtensionsStringARB != null) {
					wglExtensions = GetExtensionsStringARB(deviceContext.DeviceContext);
				} else if (Delegates.pwglGetExtensionsStringEXT != null) {
					wglExtensions = GetExtensionsStringEXT();
				}

				Query(Version_100, wglExtensions ?? String.Empty);
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
