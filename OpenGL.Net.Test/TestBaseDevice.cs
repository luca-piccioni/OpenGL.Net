
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
using System.Collections.Generic;
using System.Threading;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating a device context used for testing.
	/// </summary>
#if !NETCORE && !MONODROID
	[Apartment(ApartmentState.STA)]
#endif
	internal abstract class TestBaseDevice
	{
		#region Device

		protected class Device : IDisposable
		{
			public Device() :
				this(new DevicePixelFormat(24))
			{

			}

			public Device(DevicePixelFormat pixelFormat)
			{
				if (DeviceContext.IsPBufferSupported) {
					_NativePBuffer = DeviceContext.CreatePBuffer(pixelFormat, 64, 64);
					Context = DeviceContext.Create(_NativePBuffer);
				} else
					Assert.Inconclusive("no UI backend available");
			}

			private readonly INativePBuffer _NativePBuffer;

			public readonly DeviceContext Context;

			public void Dispose()
			{
				Context?.Dispose();
				_NativePBuffer?.Dispose();
			}
		}

		#endregion
	}
}
