
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

using Khronos;

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

				using (XLock xLock = new XLock(deviceContext.Display)) {
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
