
// Copyright (C) 2018 Luca Piccioni
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
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Math")]
	internal class HalfFloatTest
	{
		[Test]
		[SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
		public void HalfFloat_Constructors()
		{
			Assert.Throws<ArithmeticException>(() => new HalfFloat(+float.MaxValue));
			Assert.Throws<ArithmeticException>(() => new HalfFloat(-float.MaxValue));

			Assert.DoesNotThrow(() => new HalfFloat(0.0f));
			Assert.DoesNotThrow(() => new HalfFloat(float.PositiveInfinity));
			Assert.DoesNotThrow(() => new HalfFloat(float.NegativeInfinity));
			Assert.DoesNotThrow(() => new HalfFloat(float.NaN));
			Assert.DoesNotThrow(() => new HalfFloat(float.Epsilon));
			Assert.DoesNotThrow(() => new HalfFloat(+HalfFloat.MaxValue));
			Assert.DoesNotThrow(() => new HalfFloat(-HalfFloat.MaxValue));
			Assert.DoesNotThrow(() => new HalfFloat(+HalfFloat.MinValue));
			Assert.DoesNotThrow(() => new HalfFloat(-HalfFloat.MinValue));
			Assert.DoesNotThrow(() => new HalfFloat(HalfFloat.Epsilon));
		}

		[Test]
		public void HalfFloat_Is()
		{
			Assert.IsTrue(new HalfFloat(0.0f).IsZero);
			Assert.IsFalse(new HalfFloat(1.0f).IsZero);
			Assert.IsFalse(new HalfFloat(HalfFloat.Epsilon).IsZero);

			Assert.IsTrue(new HalfFloat(float.NaN).IsNaN);
			Assert.IsFalse(new HalfFloat(0.0f).IsNaN);

			Assert.IsTrue(new HalfFloat(float.PositiveInfinity).IsPositiveInfinity);
			Assert.IsFalse(new HalfFloat(0.0f).IsPositiveInfinity);
			Assert.IsTrue(new HalfFloat(float.NegativeInfinity).IsNegativeInfinity);
			Assert.IsFalse(new HalfFloat(0.0f).IsNegativeInfinity);
		}
	}
}
