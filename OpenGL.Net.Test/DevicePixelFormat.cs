
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

using System.Diagnostics.CodeAnalysis;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class DevicePixelFormatTest
	{
		[Test]
		public void DevicePixelFormat_Constructor1()
		{
			// ReSharper disable once ObjectCreationAsStatement
			Assert.DoesNotThrow(() => new DevicePixelFormat());
		}

		[Test]
		public void DevicePixelFormat_Constructor2()
		{
			// ReSharper disable once ObjectCreationAsStatement
			Assert.DoesNotThrow(() => new DevicePixelFormat(24));

			DevicePixelFormat pf = new DevicePixelFormat(32);

			Assert.AreEqual(32, pf.ColorBits);
			Assert.IsTrue(pf.RgbaUnsigned);
			Assert.IsTrue(pf.RenderWindow);
		}

		[Test]
		public void DevicePixelFormat_Copy()
		{
			DevicePixelFormat pf1 = new DevicePixelFormat(24);
			DevicePixelFormat pf2 = pf1.Copy();

			Assert.AreNotSame(pf1, pf2);
		}

		[Test]
		[SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
		public void DevicePixelFormat_ToString()
		{
			// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
			Assert.DoesNotThrow(() => new DevicePixelFormat().ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ RgbaUnsigned = true }.ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ RgbaFloat = true }.ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ SRGBCapable = true }.ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ RenderWindow = true }.ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ RenderBuffer = true }.ToString());
			Assert.DoesNotThrow(() => new DevicePixelFormat{ RenderPBuffer = true }.ToString());
		}
	}
}
