
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

using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Tests for <see cref="Quaternion"/>.
	/// </summary>
	[TestFixture, Category("Math")]
	class QuaternionTest
	{
		[Test]
		public void Quaternion_TestConstructor1()
		{
			Quaternion q = new Quaternion(0.0, 1.0, 2.0, 3.0);

			Assert.AreEqual(0.0, q.X);
			Assert.AreEqual(1.0, q.Y);
			Assert.AreEqual(2.0, q.Z);
			Assert.AreEqual(3.0, q.W);
		}

		[Test, TestCaseSource(nameof(Quaternion_TestConstructor2_Cases))]
		public void Quaternion_TestConstructor2(Vertex3f rVector)
		{
			Quaternion q = new Quaternion(rVector, 0.0f);

			Assert.AreEqual(rVector, q.RotationVector);
			Assert.AreEqual(0.0f, q.RotationAngle);
		}

		private static IEnumerable<Vertex3f> Quaternion_TestConstructor2_Cases
		{
			get
			{
				yield return Vertex3f.UnitX;
				yield return Vertex3f.UnitY;
				yield return Vertex3f.UnitZ;
				yield return (Vertex3f.UnitX + Vertex3f.UnitY + Vertex3f.UnitZ).Normalized;
			}
		}

		[Test]
		public void Quaternion_TestCastMatrix3x3f()
		{
			Quaternion q;
			Vertex3f v;

			q = new Quaternion(Vertex3f.UnitX, 90.0f);
			v = q * Vertex3f.UnitY;
			Assert.IsTrue(v.Equals(Vertex3f.UnitZ, 1e-5f));

			q = new Quaternion(Vertex3f.UnitY, 90.0f);
			v = q * Vertex3f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3f.UnitX, 1e-5f));

			q = new Quaternion(Vertex3f.UnitZ, 90.0f);
			v = q * Vertex3f.UnitX;
			Assert.IsTrue(v.Equals(Vertex3f.UnitY, 1e-5f));
		}

		[Test]
		public void Quaternion_TestCastMatrix3x3d()
		{
			Quaternion q;
			Vertex3d v;

			q = new Quaternion(Vertex3f.UnitX, 90.0f);
			v = q * Vertex3d.UnitY;
			Assert.IsTrue(v.Equals(Vertex3d.UnitZ, 1e-5f));

			q = new Quaternion(Vertex3f.UnitY, 90.0f);
			v = q * Vertex3d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3d.UnitX, 1e-5f));

			q = new Quaternion(Vertex3f.UnitZ, 90.0f);
			v = q * Vertex3d.UnitX;
			Assert.IsTrue(v.Equals(Vertex3d.UnitY, 1e-5f));
		}

		[Test]
		public void Quaternion_TestCastMatrix4x4f()
		{
			Quaternion q;
			Vertex4f v;

			q = new Quaternion(Vertex3f.UnitX, 90.0f);
			v = q * Vertex4f.UnitY;
			Assert.IsTrue(v.Equals(Vertex4f.UnitZ, 1e-5f));

			q = new Quaternion(Vertex3f.UnitY, 90.0f);
			v = q * Vertex4f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4f.UnitX, 1e-5f));

			q = new Quaternion(Vertex3f.UnitZ, 90.0f);
			v = q * Vertex4f.UnitX;
			Assert.IsTrue(v.Equals(Vertex4f.UnitY, 1e-5f));
		}

		[Test]
		public void Quaternion_TestCastMatrix4x4d()
		{
			Quaternion q;
			Vertex4d v;

			q = new Quaternion(Vertex3f.UnitX, 90.0f);
			v = q * Vertex4d.UnitY;
			Assert.IsTrue(v.Equals(Vertex4d.UnitZ, 1e-5f));

			q = new Quaternion(Vertex3f.UnitY, 90.0f);
			v = q * Vertex4d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4d.UnitX, 1e-5f));

			q = new Quaternion(Vertex3f.UnitZ, 90.0f);
			v = q * Vertex4d.UnitX;
			Assert.IsTrue(v.Equals(Vertex4d.UnitY, 1e-5f));
		}
	}
}
