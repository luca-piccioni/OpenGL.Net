
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
using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class DevicePixelFormatCollectionTest
	{
		[Test]
		public void DevicePixelFormat_Constructor1()
		{
			// ReSharper disable once ObjectCreationAsStatement
			Assert.DoesNotThrow(() => new DevicePixelFormatCollection());
		}

		[Test]
		public void DevicePixelFormat_Choose_Exceptions()
		{
			// ReSharper disable once ObjectCreationAsStatement
			Assert.Throws<ArgumentNullException>(() => new DevicePixelFormatCollection().Choose(null));
		}

		[Test]
		public void DevicePixelFormat_GuessChooseError()
		{
			DevicePixelFormatCollection pixelFormatCollection = new DevicePixelFormatCollection {
				// Hostile pixel format
				new DevicePixelFormat()
			};
			string error;

			// No unsigned pixel format
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RgbaUnsigned = true, RgbaFloat = false });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No unsigned+float pixel format
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RgbaUnsigned = true, RgbaFloat = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No float pixel format
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RgbaUnsigned = false, RgbaFloat = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);

			// No render to window
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RenderWindow = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No render to P-Buffer
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RenderPBuffer = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No render to native buffer
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RenderBuffer = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);

			// Not enought color bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { ColorBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);

			// Note: does rgba bits are collected in all platforms?

			// Not enought (red) color bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { RedBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// Not enought (green) color bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { GreenBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// Not enought (blue) color bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { BlueBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// Not enought (alpha) color bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { AlphaBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);

			// Not enought depth bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { DepthBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// Not enought stencil bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { StencilBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// Not enought multisample bits
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { MultisampleBits = 1 });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No double buffer
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { DoubleBuffer = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);
			// No sRGB buffer
			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat { SRGBCapable = true });
			Assert.IsNotNull(error);
			Assert.AreNotEqual("no error", error);

			// Handle special case
			pixelFormatCollection = new DevicePixelFormatCollection {
				// Basic pixel format
				new DevicePixelFormat(24)
			};

			error = pixelFormatCollection.GuessChooseError(new DevicePixelFormat(24));
			Assert.IsNotNull(error);
			Assert.AreEqual("no error", error);
		}

		[Test]
		public void DevicePixelFormat_GuessChooseError_Exceptions()
		{
			DevicePixelFormatCollection pixelFormatCollection = new DevicePixelFormatCollection();

			Assert.Throws<ArgumentNullException>(() => pixelFormatCollection.GuessChooseError(null));
		}

		[Test]
		public void DevicePixelFormat_Copy()
		{
			DevicePixelFormatCollection c1 = new DevicePixelFormatCollection {
				new DevicePixelFormat { ColorBits = 32 },
				new DevicePixelFormat { ColorBits = 24 }
			};
			DevicePixelFormatCollection c2 = c1.Copy();

			Assert.AreNotSame(c1, c2);
			Assert.AreEqual(c1.Count, c2.Count);
			CollectionAssert.AllItemsAreNotNull(c2);
		}
	}
}
