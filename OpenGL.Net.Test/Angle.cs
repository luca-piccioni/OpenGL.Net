
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
	[TestFixture, Category("Math")]
	internal class AngleTest
	{
		[Test]
		public void Angle_Normalize360Double()
		{
			Assert.AreEqual(0.0, Angle.Normalize360(+360.0));
			Assert.AreEqual(0.0, Angle.Normalize360(+720.0));
			Assert.AreEqual(0.0, Angle.Normalize360(-360.0));
			Assert.AreEqual(0.0, Angle.Normalize360(-720.0));
			Assert.IsTrue(double.IsNaN(Angle.Normalize360(double.NaN)));
		}

		[Test]
		public void Angle_Normalize360Single()
		{
			Assert.AreEqual(0.0f, Angle.Normalize360(+360.0f));
			Assert.AreEqual(0.0f, Angle.Normalize360(+720.0f));
			Assert.AreEqual(0.0f, Angle.Normalize360(-360.0f));
			Assert.AreEqual(0.0f, Angle.Normalize360(-720.0f));
			Assert.IsTrue(float.IsNaN(Angle.Normalize360(float.NaN)));
		}

		[Test]
		public void Angle_ToDegreesDouble()
		{
			Assert.AreEqual(+180.0, Angle.ToDegrees(+Math.PI));
			Assert.AreEqual(-180.0, Angle.ToDegrees(-Math.PI));
			Assert.IsTrue(double.IsNaN(Angle.ToDegrees(double.NaN)));
		}

		[Test]
		public void Angle_ToDegreesSingle()
		{
			Assert.AreEqual(+180.0f, Angle.ToDegrees((float)+Math.PI));
			Assert.AreEqual(-180.0f, Angle.ToDegrees((float)-Math.PI));
			Assert.IsTrue(float.IsNaN(Angle.ToDegrees(float.NaN)));
		}

		[Test]
		public void Angle_ToRadiansDouble()
		{
			Assert.AreEqual(+Math.PI, Angle.ToRadians(+180.0));
			Assert.AreEqual(-Math.PI, Angle.ToRadians(-180.0));
			Assert.IsTrue(double.IsNaN(Angle.ToRadians(double.NaN)));
		}

		[Test]
		public void Angle_ToRadiansSingle()
		{
			Assert.AreEqual((float)+Math.PI, Angle.ToRadians(+180.0f));
			Assert.AreEqual((float)-Math.PI, Angle.ToRadians(-180.0f));
			Assert.IsTrue(float.IsNaN(Angle.ToRadians(float.NaN)));
		}
	}
}
