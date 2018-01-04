
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

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("EGL")]
	internal class EglTest
	{
		[Test]
		public void Egl_Initialize()
		{
			// It shall not throw any exception, even if it is not available
			Assert.DoesNotThrow(Egl.Initialize);
			// It shall not throw any exception, even if called multiple times
			Assert.DoesNotThrow(Egl.Initialize);
		}

		[Test]
		public void Egl_Available()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			Assert.IsNotNull(Egl.CurrentVersion);
			Assert.IsNotNull(Egl.CurrentVendor);
			Assert.IsNotNull(Egl.CurrentExtensions);
		}

		[Test]
		public void Egl_NotAvailable()
		{
			if (Egl.IsAvailable)
				Assert.Inconclusive("EGL available");

			Assert.IsNull(Egl.CurrentVersion);
			Assert.IsNull(Egl.CurrentVendor);
			Assert.IsNull(Egl.CurrentExtensions);
		}

		[Test]
		public void Egl_IsRequired()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			Egl.IsRequired = false;
			if (Egl.IsRequired)
				Assert.Inconclusive("EGL is mandatory");
			Assert.IsFalse(Egl.IsRequired);

			Egl.IsRequired = true;
			Assert.IsTrue(Egl.IsRequired);

			Egl.IsRequired = false;
			Assert.IsFalse(Egl.IsRequired);
		}
	}
}
