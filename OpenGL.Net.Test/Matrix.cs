
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

using NUnit.Framework;

// ReSharper disable InconsistentNaming
// ReSharper disable RedundantCast
// ReSharper disable ReturnValueOfPureMethodIsNotUsed
// ReSharper disable ObjectCreationAsStatement
// ReSharper disable SuspiciousTypeConversion.Global
// ReSharper disable RedundantAssignment

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Math")]
	internal class Matrix2x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x2f_TestConstructor1()
		{
			Matrix2x2f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x2f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x2f(new[] { 
				(float)0, (float)1, 
				(float)2, (float)3
			} , 1));

			Matrix2x2f m = new Matrix2x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_TestConstructor3()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = new Matrix2x2f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x2f_TestAccessor()
		{
			Matrix2x2f m = new Matrix2x2f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
		}

		[Test]
		public void Matrix2x2f_TestMultiplyScalar()
		{
			Matrix2x2f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_TestMultiplyVertex2f()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			Vertex2f v = Vertex2f.Zero;
			Vertex2f r = m * v;
		}

		[Test]
		public void Matrix2x2f_TestMultiplyMatrix2x2f()
		{
			Matrix2x2f m1 = CreateSequenceMatrix();
			Matrix2x2f m2 = CreateSequenceMatrix();
			Matrix2x2f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2f_TestCastToArray()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_TestCastToMatrix()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x2f_TestEqualityOperator()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x2f_TestInequalityOperator()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix2x2f_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix2x2f_TestRotateZ()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x2f_TestTransposed()
		{
			Matrix2x2f m = CreateRandomMatrix();
			Matrix2x2f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_TestTranspose()
		{
			Matrix2x2f m = CreateRandomMatrix();
			Matrix2x2f n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix2x2f_TestDeterminant()
		{

		}

		[Test]
		public void Matrix2x2f_TestInverse()
		{

		}

		[Test]
		public void Matrix2x2f_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x2f_TestEqualsToMatrix2x2f()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2f_TestEqualsToObject()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2f_TestGetHashCode()
		{
			Matrix2x2f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x2f_TestToString()
		{
			Matrix2x2f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x2f CreateRandomMatrix()
		{
			return new Matrix2x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix2x2f CreateSequenceMatrix()
		{
			return new Matrix2x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix2x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x3f_TestConstructor1()
		{
			Matrix2x3f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x3f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x3f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x3f(new[] { 
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			} , 1));

			Matrix2x3f m = new Matrix2x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x3f_TestConstructor3()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = new Matrix2x3f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x3f_TestAccessor()
		{
			Matrix2x3f m = new Matrix2x3f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
		}

		[Test]
		public void Matrix2x3f_TestMultiplyScalar()
		{
			Matrix2x3f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x3f_TestCastToArray()
		{
			Matrix2x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x3f_TestCastToMatrix()
		{
			Matrix2x3f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x3f_TestEqualityOperator()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x3f_TestInequalityOperator()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x3f_TestTransposed()
		{
			Matrix2x3f m = CreateRandomMatrix();
			Matrix3x2f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x3f_TestEqualsToMatrix2x3f()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3f_TestEqualsToObject()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3f_TestGetHashCode()
		{
			Matrix2x3f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x3f_TestToString()
		{
			Matrix2x3f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x3f CreateRandomMatrix()
		{
			return new Matrix2x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix2x3f CreateSequenceMatrix()
		{
			return new Matrix2x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix2x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x4f_TestConstructor1()
		{
			Matrix2x4f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x4f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x4f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x4f(new[] { 
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			} , 1));

			Matrix2x4f m = new Matrix2x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x4f_TestConstructor3()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = new Matrix2x4f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x4f_TestAccessor()
		{
			Matrix2x4f m = new Matrix2x4f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
		}

		[Test]
		public void Matrix2x4f_TestMultiplyScalar()
		{
			Matrix2x4f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x4f_TestCastToArray()
		{
			Matrix2x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x4f_TestCastToMatrix()
		{
			Matrix2x4f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x4f_TestEqualityOperator()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x4f_TestInequalityOperator()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x4f_TestTransposed()
		{
			Matrix2x4f m = CreateRandomMatrix();
			Matrix4x2f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x4f_TestEqualsToMatrix2x4f()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4f_TestEqualsToObject()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4f_TestGetHashCode()
		{
			Matrix2x4f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x4f_TestToString()
		{
			Matrix2x4f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x4f CreateRandomMatrix()
		{
			return new Matrix2x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix2x4f CreateSequenceMatrix()
		{
			return new Matrix2x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x2f_TestConstructor1()
		{
			Matrix3x2f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x2f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x2f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x2f(new[] { 
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5
			} , 1));

			Matrix3x2f m = new Matrix3x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x2f_TestConstructor3()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = new Matrix3x2f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x2f_TestAccessor()
		{
			Matrix3x2f m = new Matrix3x2f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
		}

		[Test]
		public void Matrix3x2f_TestMultiplyScalar()
		{
			Matrix3x2f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x2f_TestCastToArray()
		{
			Matrix3x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x2f_TestCastToMatrix()
		{
			Matrix3x2f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x2f_TestEqualityOperator()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x2f_TestInequalityOperator()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x2f_TestTransposed()
		{
			Matrix3x2f m = CreateRandomMatrix();
			Matrix2x3f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x2f_TestEqualsToMatrix3x2f()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2f_TestEqualsToObject()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2f_TestGetHashCode()
		{
			Matrix3x2f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x2f_TestToString()
		{
			Matrix3x2f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x2f CreateRandomMatrix()
		{
			return new Matrix3x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix3x2f CreateSequenceMatrix()
		{
			return new Matrix3x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x3f_TestConstructor1()
		{
			Matrix3x3f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x3f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x3f(new[] { 
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8
			} , 1));

			Matrix3x3f m = new Matrix3x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestConstructor3()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = new Matrix3x3f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x3f_TestAccessor()
		{
			Matrix3x3f m = new Matrix3x3f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
		}

		[Test]
		public void Matrix3x3f_TestMultiplyScalar()
		{
			Matrix3x3f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestMultiplyVertex3f()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			Vertex3f v = Vertex3f.Zero;
			Vertex3f r = m * v;
		}

		[Test]
		public void Matrix3x3f_TestMultiplyMatrix3x3f()
		{
			Matrix3x3f m1 = CreateSequenceMatrix();
			Matrix3x3f m2 = CreateSequenceMatrix();
			Matrix3x3f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3f_TestCastToArray()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestCastToMatrix()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			Matrix3x3 mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x3f_TestEqualityOperator()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x3f_TestInequalityOperator()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix3x3f_TestRotatedX()
		{

		}

		[Test]
		public void Matrix3x3f_TestRotateX()
		{

		}

		[Test]
		public void Matrix3x3f_TestRotatedY()
		{

		}

		[Test]
		public void Matrix3x3f_TestRotateY()
		{

		}

		[Test]
		public void Matrix3x3f_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix3x3f_TestRotateZ()
		{

		}

		#endregion

		#region Scaling

		[Test]
		public void Matrix3x3f_TestScaled()
		{

		}

		[Test]
		public void Matrix3x3f_TestScale()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x3f_TestTransposed()
		{
			Matrix3x3f m = CreateRandomMatrix();
			Matrix3x3f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestTranspose()
		{
			Matrix3x3f m = CreateRandomMatrix();
			Matrix3x3f n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(n[0, 2], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(n[1, 2], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(n[2, 0], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(n[2, 1], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(n[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix3x3f_TestDeterminant()
		{

		}

		[Test]
		public void Matrix3x3f_TestInverse()
		{

		}

		[Test]
		public void Matrix3x3f_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x3f_TestEqualsToMatrix3x3f()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3f_TestEqualsToObject()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3f_TestGetHashCode()
		{
			Matrix3x3f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x3f_TestToString()
		{
			Matrix3x3f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x3f CreateRandomMatrix()
		{
			return new Matrix3x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix3x3f CreateSequenceMatrix()
		{
			return new Matrix3x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x4f_TestConstructor1()
		{
			Matrix3x4f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x4f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x4f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x4f(new[] { 
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11
			} , 1));

			Matrix3x4f m = new Matrix3x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix3x4f_TestConstructor3()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = new Matrix3x4f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x4f_TestAccessor()
		{
			Matrix3x4f m = new Matrix3x4f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 3] = r;
			Assert.That(r, Is.EqualTo(m[2, 3]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 3]);
		}

		[Test]
		public void Matrix3x4f_TestMultiplyScalar()
		{
			Matrix3x4f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x4f_TestCastToArray()
		{
			Matrix3x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x4f_TestCastToMatrix()
		{
			Matrix3x4f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
			Assert.That(mReference[2, 3], Is.EqualTo(m[2, 3]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x4f_TestEqualityOperator()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x4f_TestInequalityOperator()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x4f_TestTransposed()
		{
			Matrix3x4f m = CreateRandomMatrix();
			Matrix4x3f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-5f));
			Assert.That(m[2, 3], Is.EqualTo(t[3, 2]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x4f_TestEqualsToMatrix3x4f()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4f_TestEqualsToObject()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4f_TestGetHashCode()
		{
			Matrix3x4f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x4f_TestToString()
		{
			Matrix3x4f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x4f CreateRandomMatrix()
		{
			return new Matrix3x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix3x4f CreateSequenceMatrix()
		{
			return new Matrix3x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x2f_TestConstructor1()
		{
			Matrix4x2f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x2f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x2f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x2f(new[] { 
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5, 
				(float)6, (float)7
			} , 1));

			Matrix4x2f m = new Matrix4x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5, 
				(float)6, (float)7
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x2f_TestConstructor3()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = new Matrix4x2f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x2f_TestAccessor()
		{
			Matrix4x2f m = new Matrix4x2f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
		}

		[Test]
		public void Matrix4x2f_TestMultiplyScalar()
		{
			Matrix4x2f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x2f_TestCastToArray()
		{
			Matrix4x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x2f_TestCastToMatrix()
		{
			Matrix4x2f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-5f));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x2f_TestEqualityOperator()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x2f_TestInequalityOperator()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x2f_TestTransposed()
		{
			Matrix4x2f m = CreateRandomMatrix();
			Matrix2x4f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-5f));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x2f_TestEqualsToMatrix4x2f()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2f_TestEqualsToObject()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2f_TestGetHashCode()
		{
			Matrix4x2f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x2f_TestToString()
		{
			Matrix4x2f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x2f CreateRandomMatrix()
		{
			return new Matrix4x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix4x2f CreateSequenceMatrix()
		{
			return new Matrix4x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5, 
				(float)6, (float)7
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x3f_TestConstructor1()
		{
			Matrix4x3f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x3f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x3f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x3f(new[] { 
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8, 
				(float)9, (float)10, (float)11
			} , 1));

			Matrix4x3f m = new Matrix4x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8, 
				(float)9, (float)10, (float)11
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x3f_TestConstructor3()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = new Matrix4x3f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x3f_TestAccessor()
		{
			Matrix4x3f m = new Matrix4x3f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 2] = r;
			Assert.That(r, Is.EqualTo(m[3, 2]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 2]);
		}

		[Test]
		public void Matrix4x3f_TestMultiplyScalar()
		{
			Matrix4x3f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x3f_TestCastToArray()
		{
			Matrix4x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x3f_TestCastToMatrix()
		{
			Matrix4x3f m = CreateSequenceMatrix();
			Matrix mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-5f));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-5f));
			Assert.That(mReference[3, 2], Is.EqualTo(m[3, 2]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x3f_TestEqualityOperator()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x3f_TestInequalityOperator()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x3f_TestTransposed()
		{
			Matrix4x3f m = CreateRandomMatrix();
			Matrix3x4f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-5f));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-5f));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-5f));
			Assert.That(m[3, 2], Is.EqualTo(t[2, 3]).Within(1e-5f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x3f_TestEqualsToMatrix4x3f()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3f_TestEqualsToObject()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3f_TestGetHashCode()
		{
			Matrix4x3f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x3f_TestToString()
		{
			Matrix4x3f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x3f CreateRandomMatrix()
		{
			return new Matrix4x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix4x3f CreateSequenceMatrix()
		{
			return new Matrix4x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8, 
				(float)9, (float)10, (float)11
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x4f_TestConstructor1()
		{
			Matrix4x4f m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x4f(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x4f(new[] { 
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11, 
				(float)12, (float)13, (float)14, (float)15
			} , 1));

			Matrix4x4f m = new Matrix4x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11, 
				(float)12, (float)13, (float)14, (float)15
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestConstructor3()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = new Matrix4x4f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x4f_TestAccessor()
		{
			Matrix4x4f m = new Matrix4x4f();
			float r;

			r = Next(0.0f, 1.0f);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[2, 3] = r;
			Assert.That(r, Is.EqualTo(m[2, 3]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 2] = r;
			Assert.That(r, Is.EqualTo(m[3, 2]).Within(1e-5f));
			r = Next(0.0f, 1.0f);
			m[3, 3] = r;
			Assert.That(r, Is.EqualTo(m[3, 3]).Within(1e-5f));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 4] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 2] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 3] = 0.0f);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 3]);
		}

		[Test]
		public void Matrix4x4f_TestMultiplyScalar()
		{
			Matrix4x4f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestMultiplyVertex4f()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			Vertex4f v = Vertex4f.Zero;
			Vertex4f r = m * v;
		}

		[Test]
		public void Matrix4x4f_TestMultiplyMatrix4x4f()
		{
			Matrix4x4f m1 = CreateSequenceMatrix();
			Matrix4x4f m2 = CreateSequenceMatrix();
			Matrix4x4f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4f_TestCastToArray()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestCastToMatrix()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			Matrix4x4 mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-5f));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-5f));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
			Assert.That(mReference[2, 3], Is.EqualTo(m[2, 3]).Within(1e-5f));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-5f));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-5f));
			Assert.That(mReference[3, 2], Is.EqualTo(m[3, 2]).Within(1e-5f));
			Assert.That(mReference[3, 3], Is.EqualTo(m[3, 3]).Within(1e-5f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x4f_TestEqualityOperator()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x4f_TestInequalityOperator()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Projections

		[Test]
		public void Matrix4x4f_TestOrtho()
		{

		}

		[Test]
		public void Matrix4x4f_TestOrtho2D()
		{

		}

		[Test]
		public void Matrix4x4f_TestFrustrum()
		{

		}

		[Test]
		public void Matrix4x4f_TestPerspectiveSymmetric()
		{

		}

		[Test]
		public void Matrix4x4f_TestPerspectiveAsymmetric()
		{

		}

		#endregion

		#region View Model

		[Test]
		public void Matrix4x4f_TestPosition()
		{
			Assert.AreEqual(Vertex3f.Zero, Matrix4x4f.Identity.Position);
		}

		[Test]
		public void Matrix4x4f_TestForwardVector()
		{
			Assert.AreEqual(-Vertex3f.UnitZ, Matrix4x4f.Identity.ForwardVector);
		}

		[Test]
		public void Matrix4x4f_TestRightVector()
		{
			Assert.AreEqual(Vertex3f.UnitX, Matrix4x4f.Identity.RightVector);
		}

		[Test]
		public void Matrix4x4f_TestUpVector()
		{
			Assert.AreEqual(Vertex3f.UnitY, Matrix4x4f.Identity.UpVector);
		}

		[Test]
		public void Matrix4x4f_TestLookAt()
		{

		}

		[Test]
		public void Matrix4x4f_TestLookAtDirection()
		{

		}

		#endregion

		#region Translation

		[Test]
		public void Matrix4x4f_TestTranslated()
		{
			Matrix4x4f m = Matrix4x4f.Translated(0.0f, 1.0f, 2.0f);
			Vertex3f v = new Vertex3f(0.0f, 1.0f, 2.0f);

			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.RelativelyEquals((Vertex3f)(m * Vertex4f.Zero), 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestTranslate()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			Vertex3f v = new Vertex3f(0.0f, 1.0f, 2.0f);
			
			m.Translate(0.0f, 1.0f, 2.0f);
			
			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.RelativelyEquals((Vertex3f)(m * Vertex3f.Zero), 1e-5f));
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix4x4f_TestRotatedX()
		{

		}

		[Test]
		public void Matrix4x4f_TestRotateX()
		{

		}

		[Test]
		public void Matrix4x4f_TestRotatedY()
		{

		}

		[Test]
		public void Matrix4x4f_TestRotateY()
		{

		}

		[Test]
		public void Matrix4x4f_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix4x4f_TestRotateZ()
		{

		}

		#endregion

		#region Scaling

		[Test]
		public void Matrix4x4f_TestScaled()
		{

		}

		[Test]
		public void Matrix4x4f_TestScale()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x4f_TestTransposed()
		{
			Matrix4x4f m = CreateRandomMatrix();
			Matrix4x4f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-5f));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-5f));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-5f));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-5f));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-5f));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-5f));
			Assert.That(m[2, 3], Is.EqualTo(t[3, 2]).Within(1e-5f));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-5f));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-5f));
			Assert.That(m[3, 2], Is.EqualTo(t[2, 3]).Within(1e-5f));
			Assert.That(m[3, 3], Is.EqualTo(t[3, 3]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestTranspose()
		{
			Matrix4x4f m = CreateRandomMatrix();
			Matrix4x4f n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-5f));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-5f));
			Assert.That(n[0, 2], Is.EqualTo(m[2, 0]).Within(1e-5f));
			Assert.That(n[0, 3], Is.EqualTo(m[3, 0]).Within(1e-5f));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-5f));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-5f));
			Assert.That(n[1, 2], Is.EqualTo(m[2, 1]).Within(1e-5f));
			Assert.That(n[1, 3], Is.EqualTo(m[3, 1]).Within(1e-5f));
			Assert.That(n[2, 0], Is.EqualTo(m[0, 2]).Within(1e-5f));
			Assert.That(n[2, 1], Is.EqualTo(m[1, 2]).Within(1e-5f));
			Assert.That(n[2, 2], Is.EqualTo(m[2, 2]).Within(1e-5f));
			Assert.That(n[2, 3], Is.EqualTo(m[3, 2]).Within(1e-5f));
			Assert.That(n[3, 0], Is.EqualTo(m[0, 3]).Within(1e-5f));
			Assert.That(n[3, 1], Is.EqualTo(m[1, 3]).Within(1e-5f));
			Assert.That(n[3, 2], Is.EqualTo(m[2, 3]).Within(1e-5f));
			Assert.That(n[3, 3], Is.EqualTo(m[3, 3]).Within(1e-5f));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix4x4f_TestDeterminant()
		{

		}

		[Test]
		public void Matrix4x4f_TestInverse()
		{

		}

		[Test]
		public void Matrix4x4f_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x4f_TestEqualsToMatrix4x4f()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4f_TestEqualsToObject()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4f_TestGetHashCode()
		{
			Matrix4x4f m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 2] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 3] = Next(0.0f, 1.0f);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x4f_TestToString()
		{
			Matrix4x4f m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x4f CreateRandomMatrix()
		{
			return new Matrix4x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
		}

		private static Matrix4x4f CreateSequenceMatrix()
		{
			return new Matrix4x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11, 
				(float)12, (float)13, (float)14, (float)15
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix2x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x2d_TestConstructor1()
		{
			Matrix2x2d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x2d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x2d(new[] { 
				(double)0, (double)1, 
				(double)2, (double)3
			} , 1));

			Matrix2x2d m = new Matrix2x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_TestConstructor3()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = new Matrix2x2d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x2d_TestAccessor()
		{
			Matrix2x2d m = new Matrix2x2d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
		}

		[Test]
		public void Matrix2x2d_TestMultiplyScalar()
		{
			Matrix2x2d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_TestMultiplyVertex2d()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			Vertex2d v = Vertex2d.Zero;
			Vertex2d r = m * v;
		}

		[Test]
		public void Matrix2x2d_TestMultiplyMatrix2x2d()
		{
			Matrix2x2d m1 = CreateSequenceMatrix();
			Matrix2x2d m2 = CreateSequenceMatrix();
			Matrix2x2d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2d_TestCastToArray()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_TestCastToMatrix()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x2d_TestEqualityOperator()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x2d_TestInequalityOperator()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix2x2d_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix2x2d_TestRotateZ()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x2d_TestTransposed()
		{
			Matrix2x2d m = CreateRandomMatrix();
			Matrix2x2d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_TestTranspose()
		{
			Matrix2x2d m = CreateRandomMatrix();
			Matrix2x2d n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix2x2d_TestDeterminant()
		{

		}

		[Test]
		public void Matrix2x2d_TestInverse()
		{

		}

		[Test]
		public void Matrix2x2d_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x2d_TestEqualsToMatrix2x2d()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2d_TestEqualsToObject()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2d_TestGetHashCode()
		{
			Matrix2x2d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x2d_TestToString()
		{
			Matrix2x2d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x2d CreateRandomMatrix()
		{
			return new Matrix2x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix2x2d CreateSequenceMatrix()
		{
			return new Matrix2x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix2x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x3d_TestConstructor1()
		{
			Matrix2x3d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x3d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x3d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x3d(new[] { 
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			} , 1));

			Matrix2x3d m = new Matrix2x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x3d_TestConstructor3()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = new Matrix2x3d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x3d_TestAccessor()
		{
			Matrix2x3d m = new Matrix2x3d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
		}

		[Test]
		public void Matrix2x3d_TestMultiplyScalar()
		{
			Matrix2x3d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x3d_TestCastToArray()
		{
			Matrix2x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x3d_TestCastToMatrix()
		{
			Matrix2x3d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x3d_TestEqualityOperator()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x3d_TestInequalityOperator()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x3d_TestTransposed()
		{
			Matrix2x3d m = CreateRandomMatrix();
			Matrix3x2d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x3d_TestEqualsToMatrix2x3d()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3d_TestEqualsToObject()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3d_TestGetHashCode()
		{
			Matrix2x3d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x3d_TestToString()
		{
			Matrix2x3d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x3d CreateRandomMatrix()
		{
			return new Matrix2x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix2x3d CreateSequenceMatrix()
		{
			return new Matrix2x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix2x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x4d_TestConstructor1()
		{
			Matrix2x4d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x4d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix2x4d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix2x4d(new[] { 
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			} , 1));

			Matrix2x4d m = new Matrix2x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			});

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x4d_TestConstructor3()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = new Matrix2x4d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x4d_TestAccessor()
		{
			Matrix2x4d m = new Matrix2x4d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
		}

		[Test]
		public void Matrix2x4d_TestMultiplyScalar()
		{
			Matrix2x4d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x4d_TestCastToArray()
		{
			Matrix2x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x4d_TestCastToMatrix()
		{
			Matrix2x4d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 2);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x4d_TestEqualityOperator()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x4d_TestInequalityOperator()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix2x4d_TestTransposed()
		{
			Matrix2x4d m = CreateRandomMatrix();
			Matrix4x2d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x4d_TestEqualsToMatrix2x4d()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4d_TestEqualsToObject()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4d_TestGetHashCode()
		{
			Matrix2x4d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x4d_TestToString()
		{
			Matrix2x4d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix2x4d CreateRandomMatrix()
		{
			return new Matrix2x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix2x4d CreateSequenceMatrix()
		{
			return new Matrix2x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x2d_TestConstructor1()
		{
			Matrix3x2d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x2d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x2d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x2d(new[] { 
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5
			} , 1));

			Matrix3x2d m = new Matrix3x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x2d_TestConstructor3()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = new Matrix3x2d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x2d_TestAccessor()
		{
			Matrix3x2d m = new Matrix3x2d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
		}

		[Test]
		public void Matrix3x2d_TestMultiplyScalar()
		{
			Matrix3x2d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x2d_TestCastToArray()
		{
			Matrix3x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x2d_TestCastToMatrix()
		{
			Matrix3x2d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x2d_TestEqualityOperator()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x2d_TestInequalityOperator()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x2d_TestTransposed()
		{
			Matrix3x2d m = CreateRandomMatrix();
			Matrix2x3d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x2d_TestEqualsToMatrix3x2d()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2d_TestEqualsToObject()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2d_TestGetHashCode()
		{
			Matrix3x2d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x2d_TestToString()
		{
			Matrix3x2d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x2d CreateRandomMatrix()
		{
			return new Matrix3x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix3x2d CreateSequenceMatrix()
		{
			return new Matrix3x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x3d_TestConstructor1()
		{
			Matrix3x3d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x3d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x3d(new[] { 
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8
			} , 1));

			Matrix3x3d m = new Matrix3x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_TestConstructor3()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = new Matrix3x3d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x3d_TestAccessor()
		{
			Matrix3x3d m = new Matrix3x3d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
		}

		[Test]
		public void Matrix3x3d_TestMultiplyScalar()
		{
			Matrix3x3d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_TestMultiplyVertex3d()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			Vertex3d v = Vertex3d.Zero;
			Vertex3d r = m * v;
		}

		[Test]
		public void Matrix3x3d_TestMultiplyMatrix3x3d()
		{
			Matrix3x3d m1 = CreateSequenceMatrix();
			Matrix3x3d m2 = CreateSequenceMatrix();
			Matrix3x3d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3d_TestCastToArray()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_TestCastToMatrix()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			MatrixDouble3x3 mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x3d_TestEqualityOperator()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x3d_TestInequalityOperator()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix3x3d_TestRotatedX()
		{

		}

		[Test]
		public void Matrix3x3d_TestRotateX()
		{

		}

		[Test]
		public void Matrix3x3d_TestRotatedY()
		{

		}

		[Test]
		public void Matrix3x3d_TestRotateY()
		{

		}

		[Test]
		public void Matrix3x3d_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix3x3d_TestRotateZ()
		{

		}

		#endregion

		#region Scaling

		[Test]
		public void Matrix3x3d_TestScaled()
		{

		}

		[Test]
		public void Matrix3x3d_TestScale()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x3d_TestTransposed()
		{
			Matrix3x3d m = CreateRandomMatrix();
			Matrix3x3d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_TestTranspose()
		{
			Matrix3x3d m = CreateRandomMatrix();
			Matrix3x3d n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(n[0, 2], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(n[1, 2], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(n[2, 0], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(n[2, 1], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(n[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix3x3d_TestDeterminant()
		{

		}

		[Test]
		public void Matrix3x3d_TestInverse()
		{

		}

		[Test]
		public void Matrix3x3d_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x3d_TestEqualsToMatrix3x3d()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3d_TestEqualsToObject()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3d_TestGetHashCode()
		{
			Matrix3x3d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x3d_TestToString()
		{
			Matrix3x3d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x3d CreateRandomMatrix()
		{
			return new Matrix3x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix3x3d CreateSequenceMatrix()
		{
			return new Matrix3x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix3x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x4d_TestConstructor1()
		{
			Matrix3x4d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x4d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix3x4d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix3x4d(new[] { 
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11
			} , 1));

			Matrix3x4d m = new Matrix3x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11
			});

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix3x4d_TestConstructor3()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = new Matrix3x4d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x4d_TestAccessor()
		{
			Matrix3x4d m = new Matrix3x4d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 3] = r;
			Assert.That(r, Is.EqualTo(m[2, 3]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 3]);
		}

		[Test]
		public void Matrix3x4d_TestMultiplyScalar()
		{
			Matrix3x4d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x4d_TestCastToArray()
		{
			Matrix3x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x4d_TestCastToMatrix()
		{
			Matrix3x4d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 3);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
			Assert.That(mReference[2, 3], Is.EqualTo(m[2, 3]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x4d_TestEqualityOperator()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x4d_TestInequalityOperator()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix3x4d_TestTransposed()
		{
			Matrix3x4d m = CreateRandomMatrix();
			Matrix4x3d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-10));
			Assert.That(m[2, 3], Is.EqualTo(t[3, 2]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x4d_TestEqualsToMatrix3x4d()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4d_TestEqualsToObject()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4d_TestGetHashCode()
		{
			Matrix3x4d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x4d_TestToString()
		{
			Matrix3x4d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix3x4d CreateRandomMatrix()
		{
			return new Matrix3x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix3x4d CreateSequenceMatrix()
		{
			return new Matrix3x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x2d_TestConstructor1()
		{
			Matrix4x2d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x2d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x2d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x2d(new[] { 
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5, 
				(double)6, (double)7
			} , 1));

			Matrix4x2d m = new Matrix4x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5, 
				(double)6, (double)7
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x2d_TestConstructor3()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = new Matrix4x2d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x2d_TestAccessor()
		{
			Matrix4x2d m = new Matrix4x2d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
		}

		[Test]
		public void Matrix4x2d_TestMultiplyScalar()
		{
			Matrix4x2d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x2d_TestCastToArray()
		{
			Matrix4x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x2d_TestCastToMatrix()
		{
			Matrix4x2d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 2);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-10));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x2d_TestEqualityOperator()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x2d_TestInequalityOperator()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x2d_TestTransposed()
		{
			Matrix4x2d m = CreateRandomMatrix();
			Matrix2x4d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-10));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x2d_TestEqualsToMatrix4x2d()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2d_TestEqualsToObject()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2d_TestGetHashCode()
		{
			Matrix4x2d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x2d_TestToString()
		{
			Matrix4x2d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x2d CreateRandomMatrix()
		{
			return new Matrix4x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix4x2d CreateSequenceMatrix()
		{
			return new Matrix4x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5, 
				(double)6, (double)7
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x3d_TestConstructor1()
		{
			Matrix4x3d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x3d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x3d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x3d(new[] { 
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8, 
				(double)9, (double)10, (double)11
			} , 1));

			Matrix4x3d m = new Matrix4x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8, 
				(double)9, (double)10, (double)11
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x3d_TestConstructor3()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = new Matrix4x3d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x3d_TestAccessor()
		{
			Matrix4x3d m = new Matrix4x3d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 2] = r;
			Assert.That(r, Is.EqualTo(m[3, 2]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 3]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 2]);
		}

		[Test]
		public void Matrix4x3d_TestMultiplyScalar()
		{
			Matrix4x3d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x3d_TestCastToArray()
		{
			Matrix4x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x3d_TestCastToMatrix()
		{
			Matrix4x3d m = CreateSequenceMatrix();
			MatrixDouble mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 3);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-10));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-10));
			Assert.That(mReference[3, 2], Is.EqualTo(m[3, 2]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x3d_TestEqualityOperator()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x3d_TestInequalityOperator()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x3d_TestTransposed()
		{
			Matrix4x3d m = CreateRandomMatrix();
			Matrix3x4d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-10));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-10));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-10));
			Assert.That(m[3, 2], Is.EqualTo(t[2, 3]).Within(1e-10));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x3d_TestEqualsToMatrix4x3d()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3d_TestEqualsToObject()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3d_TestGetHashCode()
		{
			Matrix4x3d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x3d_TestToString()
		{
			Matrix4x3d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x3d CreateRandomMatrix()
		{
			return new Matrix4x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix4x3d CreateSequenceMatrix()
		{
			return new Matrix4x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8, 
				(double)9, (double)10, (double)11
			});
		}

		#endregion
	}

	[TestFixture]
	[Category("Math")]
	internal class Matrix4x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x4d_TestConstructor1()
		{
			Matrix4x4d m = CreateSequenceMatrix();

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_TestConstructor2()
		{
			Assert.Throws<ArgumentNullException>(() => new Matrix4x4d(null, 0));
			Assert.Throws<ArgumentException>(() => new Matrix4x4d(new[] { 
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11, 
				(double)12, (double)13, (double)14, (double)15
			} , 1));

			Matrix4x4d m = new Matrix4x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11, 
				(double)12, (double)13, (double)14, (double)15
			});

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_TestConstructor3()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = new Matrix4x4d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x4d_TestAccessor()
		{
			Matrix4x4d m = new Matrix4x4d();
			double r;

			r = Next(0.0, 1.0);
			m[0, 0] = r;
			Assert.That(r, Is.EqualTo(m[0, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 1] = r;
			Assert.That(r, Is.EqualTo(m[0, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 2] = r;
			Assert.That(r, Is.EqualTo(m[0, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[0, 3] = r;
			Assert.That(r, Is.EqualTo(m[0, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 0] = r;
			Assert.That(r, Is.EqualTo(m[1, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 1] = r;
			Assert.That(r, Is.EqualTo(m[1, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 2] = r;
			Assert.That(r, Is.EqualTo(m[1, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[1, 3] = r;
			Assert.That(r, Is.EqualTo(m[1, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 0] = r;
			Assert.That(r, Is.EqualTo(m[2, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 1] = r;
			Assert.That(r, Is.EqualTo(m[2, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 2] = r;
			Assert.That(r, Is.EqualTo(m[2, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[2, 3] = r;
			Assert.That(r, Is.EqualTo(m[2, 3]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 0] = r;
			Assert.That(r, Is.EqualTo(m[3, 0]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 1] = r;
			Assert.That(r, Is.EqualTo(m[3, 1]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 2] = r;
			Assert.That(r, Is.EqualTo(m[3, 2]).Within(1e-10));
			r = Next(0.0, 1.0);
			m[3, 3] = r;
			Assert.That(r, Is.EqualTo(m[3, 3]).Within(1e-10));

			Assert.Throws<ArgumentOutOfRangeException>(() => m[0, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[0, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[1, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[1, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[2, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[2, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[3, 4] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[3, 4]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 0] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 0]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 1] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 1]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 2] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 2]);
			Assert.Throws<ArgumentOutOfRangeException>(() => m[4, 3] = 0.0);
			Assert.Throws<ArgumentOutOfRangeException>(() => r = m[4, 3]);
		}

		[Test]
		public void Matrix4x4d_TestMultiplyScalar()
		{
			Matrix4x4d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_TestMultiplyVertex4d()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			Vertex4d v = Vertex4d.Zero;
			Vertex4d r = m * v;
		}

		[Test]
		public void Matrix4x4d_TestMultiplyMatrix4x4d()
		{
			Matrix4x4d m1 = CreateSequenceMatrix();
			Matrix4x4d m2 = CreateSequenceMatrix();
			Matrix4x4d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4d_TestCastToArray()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_TestCastToMatrix()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			MatrixDouble4x4 mReference = m;

			Assert.AreEqual(mReference.Width, 4);
			Assert.AreEqual(mReference.Height, 4);

			Assert.That(mReference[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(mReference[0, 1], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(mReference[0, 2], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(mReference[0, 3], Is.EqualTo(m[0, 3]).Within(1e-10));
			Assert.That(mReference[1, 0], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(mReference[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(mReference[1, 2], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(mReference[1, 3], Is.EqualTo(m[1, 3]).Within(1e-10));
			Assert.That(mReference[2, 0], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(mReference[2, 1], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(mReference[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
			Assert.That(mReference[2, 3], Is.EqualTo(m[2, 3]).Within(1e-10));
			Assert.That(mReference[3, 0], Is.EqualTo(m[3, 0]).Within(1e-10));
			Assert.That(mReference[3, 1], Is.EqualTo(m[3, 1]).Within(1e-10));
			Assert.That(mReference[3, 2], Is.EqualTo(m[3, 2]).Within(1e-10));
			Assert.That(mReference[3, 3], Is.EqualTo(m[3, 3]).Within(1e-10));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x4d_TestEqualityOperator()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x4d_TestInequalityOperator()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Projections

		[Test]
		public void Matrix4x4d_TestOrtho()
		{

		}

		[Test]
		public void Matrix4x4d_TestOrtho2D()
		{

		}

		[Test]
		public void Matrix4x4d_TestFrustrum()
		{

		}

		[Test]
		public void Matrix4x4d_TestPerspectiveSymmetric()
		{

		}

		[Test]
		public void Matrix4x4d_TestPerspectiveAsymmetric()
		{

		}

		#endregion

		#region View Model

		[Test]
		public void Matrix4x4d_TestPosition()
		{
			Assert.AreEqual(Vertex3d.Zero, Matrix4x4d.Identity.Position);
		}

		[Test]
		public void Matrix4x4d_TestForwardVector()
		{
			Assert.AreEqual(-Vertex3d.UnitZ, Matrix4x4d.Identity.ForwardVector);
		}

		[Test]
		public void Matrix4x4d_TestRightVector()
		{
			Assert.AreEqual(Vertex3d.UnitX, Matrix4x4d.Identity.RightVector);
		}

		[Test]
		public void Matrix4x4d_TestUpVector()
		{
			Assert.AreEqual(Vertex3d.UnitY, Matrix4x4d.Identity.UpVector);
		}

		[Test]
		public void Matrix4x4d_TestLookAt()
		{

		}

		[Test]
		public void Matrix4x4d_TestLookAtDirection()
		{

		}

		#endregion

		#region Translation

		[Test]
		public void Matrix4x4d_TestTranslated()
		{
			Matrix4x4d m = Matrix4x4d.Translated(0.0, 1.0, 2.0);
			Vertex3d v = new Vertex3d(0.0, 1.0, 2.0);

			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.RelativelyEquals((Vertex3d)(m * Vertex4d.Zero), 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestTranslate()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			Vertex3d v = new Vertex3d(0.0, 1.0, 2.0);
			
			m.Translate(0.0, 1.0, 2.0);
			
			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.RelativelyEquals((Vertex3d)(m * Vertex3d.Zero), 1e-10));
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix4x4d_TestRotatedX()
		{

		}

		[Test]
		public void Matrix4x4d_TestRotateX()
		{

		}

		[Test]
		public void Matrix4x4d_TestRotatedY()
		{

		}

		[Test]
		public void Matrix4x4d_TestRotateY()
		{

		}

		[Test]
		public void Matrix4x4d_TestRotatedZ()
		{

		}

		[Test]
		public void Matrix4x4d_TestRotateZ()
		{

		}

		#endregion

		#region Scaling

		[Test]
		public void Matrix4x4d_TestScaled()
		{

		}

		[Test]
		public void Matrix4x4d_TestScale()
		{

		}

		#endregion

		#region Tranposition

		[Test]
		public void Matrix4x4d_TestTransposed()
		{
			Matrix4x4d m = CreateRandomMatrix();
			Matrix4x4d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[0, 2], Is.EqualTo(t[2, 0]).Within(1e-10));
			Assert.That(m[0, 3], Is.EqualTo(t[3, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
			Assert.That(m[1, 2], Is.EqualTo(t[2, 1]).Within(1e-10));
			Assert.That(m[1, 3], Is.EqualTo(t[3, 1]).Within(1e-10));
			Assert.That(m[2, 0], Is.EqualTo(t[0, 2]).Within(1e-10));
			Assert.That(m[2, 1], Is.EqualTo(t[1, 2]).Within(1e-10));
			Assert.That(m[2, 2], Is.EqualTo(t[2, 2]).Within(1e-10));
			Assert.That(m[2, 3], Is.EqualTo(t[3, 2]).Within(1e-10));
			Assert.That(m[3, 0], Is.EqualTo(t[0, 3]).Within(1e-10));
			Assert.That(m[3, 1], Is.EqualTo(t[1, 3]).Within(1e-10));
			Assert.That(m[3, 2], Is.EqualTo(t[2, 3]).Within(1e-10));
			Assert.That(m[3, 3], Is.EqualTo(t[3, 3]).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_TestTranspose()
		{
			Matrix4x4d m = CreateRandomMatrix();
			Matrix4x4d n = m;

			m.Transpose();

			Assert.That(n[0, 0], Is.EqualTo(m[0, 0]).Within(1e-10));
			Assert.That(n[0, 1], Is.EqualTo(m[1, 0]).Within(1e-10));
			Assert.That(n[0, 2], Is.EqualTo(m[2, 0]).Within(1e-10));
			Assert.That(n[0, 3], Is.EqualTo(m[3, 0]).Within(1e-10));
			Assert.That(n[1, 0], Is.EqualTo(m[0, 1]).Within(1e-10));
			Assert.That(n[1, 1], Is.EqualTo(m[1, 1]).Within(1e-10));
			Assert.That(n[1, 2], Is.EqualTo(m[2, 1]).Within(1e-10));
			Assert.That(n[1, 3], Is.EqualTo(m[3, 1]).Within(1e-10));
			Assert.That(n[2, 0], Is.EqualTo(m[0, 2]).Within(1e-10));
			Assert.That(n[2, 1], Is.EqualTo(m[1, 2]).Within(1e-10));
			Assert.That(n[2, 2], Is.EqualTo(m[2, 2]).Within(1e-10));
			Assert.That(n[2, 3], Is.EqualTo(m[3, 2]).Within(1e-10));
			Assert.That(n[3, 0], Is.EqualTo(m[0, 3]).Within(1e-10));
			Assert.That(n[3, 1], Is.EqualTo(m[1, 3]).Within(1e-10));
			Assert.That(n[3, 2], Is.EqualTo(m[2, 3]).Within(1e-10));
			Assert.That(n[3, 3], Is.EqualTo(m[3, 3]).Within(1e-10));
		}

		#endregion

		#region Inversion

		[Test]
		public void Matrix4x4d_TestDeterminant()
		{

		}

		[Test]
		public void Matrix4x4d_TestInverse()
		{

		}

		[Test]
		public void Matrix4x4d_TestInvert()
		{

		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x4d_TestEqualsToMatrix4x4d()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4d_TestEqualsToObject()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4d_TestGetHashCode()
		{
			Matrix4x4d m = CreateRandomMatrix();
			int hashCode, cache = 0;
			
			Assert.DoesNotThrow(() => cache = m.GetHashCode());

			m[0, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[0, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[1, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[2, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 0] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 1] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 2] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
			m[3, 3] = Next(0.0, 1.0);
			hashCode = m.GetHashCode();
			Assert.AreNotEqual(cache, hashCode);
			cache = hashCode;
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x4d_TestToString()
		{
			Matrix4x4d m = CreateRandomMatrix();

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion

		#region Utilities

		private static Matrix4x4d CreateRandomMatrix()
		{
			return new Matrix4x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
		}

		private static Matrix4x4d CreateSequenceMatrix()
		{
			return new Matrix4x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11, 
				(double)12, (double)13, (double)14, (double)15
			});
		}

		#endregion
	}

}