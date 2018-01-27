
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
			Matrix2x2f m = new Matrix2x2f(
				(float)0, (float)1, 
				(float)2, (float)3
			);

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
			Matrix2x2f m = Matrix2x2f.RotatedZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix2x2f.Identity, 1e-5f));

			Matrix2x2f r1 = Matrix2x2f.RotatedZ(+90.0f);
			Matrix2x2f r2 = Matrix2x2f.RotatedZ(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix2x2f.Identity, 1e-5f));

			r1 = Matrix2x2f.RotatedZ(+90.0f);
			r2 = Matrix2x2f.RotatedZ(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

		}

		[Test]
		public void Matrix2x2f_TestRotateZ()
		{
			Matrix2x2f m = Matrix2x2f.Identity;
			
			m.RotateZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix2x2f.Identity, 1e-5f));

			m.RotateZ(+90.0f);
			m.RotateZ(-90.0f);
			Assert.IsTrue(m.Equals(Matrix2x2f.Identity, 1e-5f));

			m.RotateZ(+180.0f);
			Assert.IsTrue(m.Equals(Matrix2x2f.RotatedZ(+180.0f), 1e-5f));

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
			Assert.AreEqual(1.0f, Matrix2x2f.Identity.Determinant);
		}

		[Test]
		public void Matrix2x2f_TestInverse()
		{
			Matrix2x2f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix2x2f().Inverse);

			Matrix2x2f m = CreateInvertibleMatrix();
			Matrix2x2f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix2x2f_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix2x2f().Invert());

			Matrix2x2f m = CreateInvertibleMatrix();
			Matrix2x2f n = m;

			m.Invert();

			Matrix2x2f r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2f.Identity, 1e-2f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x2f_TestAbsoluteEqualsToMatrix2x2f()
		{
			Matrix2x2f m = new Matrix2x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
		}

		[Test]
		public void Matrix2x2f_TestRelativelyEqualsToMatrix2x2f()
		{
			
		}

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

		private static Matrix2x2f CreateInvertibleMatrix()
		{
			Matrix2x2f m = new Matrix2x2f();

			m[0, 0] = Next(1.0f, 2.0f);
			m[0, 1] = Next(0.0f, 0.5f);
			m[1, 0] = Next(0.0f, 0.5f);
			m[1, 1] = Next(1.0f, 2.0f);

			return m;
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
			Matrix2x3f m = new Matrix2x3f(
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			);

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
		public void Matrix2x3f_TestAbsoluteEqualsToMatrix2x3f()
		{
			Matrix2x3f m = new Matrix2x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
		}

		[Test]
		public void Matrix2x3f_TestRelativelyEqualsToMatrix2x3f()
		{
			
		}

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
			Matrix2x4f m = new Matrix2x4f(
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			);

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
		public void Matrix2x4f_TestAbsoluteEqualsToMatrix2x4f()
		{
			Matrix2x4f m = new Matrix2x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
		}

		[Test]
		public void Matrix2x4f_TestRelativelyEqualsToMatrix2x4f()
		{
			
		}

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
			Matrix3x2f m = new Matrix3x2f(
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5
			);

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
		public void Matrix3x2f_TestAbsoluteEqualsToMatrix3x2f()
		{
			Matrix3x2f m = new Matrix3x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
		}

		[Test]
		public void Matrix3x2f_TestRelativelyEqualsToMatrix3x2f()
		{
			
		}

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
			Matrix3x3f m = new Matrix3x3f(
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8
			);

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
			Matrix3x3f m = Matrix3x3f.RotatedX(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			Matrix3x3f r1 = Matrix3x3f.RotatedX(+90.0f);
			Matrix3x3f r2 = Matrix3x3f.RotatedX(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3f.Identity, 1e-5f));

			r1 = Matrix3x3f.RotatedX(+90.0f);
			r2 = Matrix3x3f.RotatedX(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestRotateX()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			
			m.RotateX(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateX(+90.0f);
			m.RotateX(-90.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateX(+180.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.RotatedX(+180.0f), 1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestRotatedY()
		{
			Matrix3x3f m = Matrix3x3f.RotatedY(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			Matrix3x3f r1 = Matrix3x3f.RotatedY(+90.0f);
			Matrix3x3f r2 = Matrix3x3f.RotatedY(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3f.Identity, 1e-5f));

			r1 = Matrix3x3f.RotatedY(+90.0f);
			r2 = Matrix3x3f.RotatedY(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestRotateY()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			
			m.RotateY(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateY(+90.0f);
			m.RotateY(-90.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateY(+180.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.RotatedY(+180.0f), 1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestRotatedZ()
		{
			Matrix3x3f m = Matrix3x3f.RotatedZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			Matrix3x3f r1 = Matrix3x3f.RotatedZ(+90.0f);
			Matrix3x3f r2 = Matrix3x3f.RotatedZ(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3f.Identity, 1e-5f));

			r1 = Matrix3x3f.RotatedZ(+90.0f);
			r2 = Matrix3x3f.RotatedZ(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex3f v = Matrix3x3f.RotatedZ(+90.0f) * Vertex3f.UnitX;
			Assert.IsTrue(v.Equals(Vertex3f.UnitY, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_TestRotateZ()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			
			m.RotateZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateZ(+90.0f);
			m.RotateZ(-90.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateZ(+180.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.RotatedZ(+180.0f), 1e-5f));

			m = Matrix3x3f.Identity;
			m.RotateZ(+90.0f);
			Vertex3f v = m * Vertex3f.UnitX;
			Assert.IsTrue(v.Equals(Vertex3f.UnitY, 1e-5f));
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
			Assert.AreEqual(1.0f, Matrix3x3f.Identity.Determinant);
		}

		[Test]
		public void Matrix3x3f_TestInverse()
		{
			Matrix3x3f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix3x3f().Inverse);

			Matrix3x3f m = CreateInvertibleMatrix();
			Matrix3x3f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix3x3f_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix3x3f().Invert());

			Matrix3x3f m = CreateInvertibleMatrix();
			Matrix3x3f n = m;

			m.Invert();

			Matrix3x3f r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3f.Identity, 1e-2f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x3f_TestAbsoluteEqualsToMatrix3x3f()
		{
			Matrix3x3f m = new Matrix3x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
		}

		[Test]
		public void Matrix3x3f_TestRelativelyEqualsToMatrix3x3f()
		{
			
		}

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

		private static Matrix3x3f CreateInvertibleMatrix()
		{
			Matrix3x3f m = new Matrix3x3f();

			m[0, 0] = Next(1.0f, 2.0f);
			m[0, 1] = Next(0.0f, 0.5f);
			m[0, 2] = Next(0.0f, 0.5f);
			m[1, 0] = Next(0.0f, 0.5f);
			m[1, 1] = Next(1.0f, 2.0f);
			m[1, 2] = Next(0.0f, 0.5f);
			m[2, 0] = Next(0.0f, 0.5f);
			m[2, 1] = Next(0.0f, 0.5f);
			m[2, 2] = Next(1.0f, 2.0f);

			return m;
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
			Matrix3x4f m = new Matrix3x4f(
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11
			);

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
		public void Matrix3x4f_TestAbsoluteEqualsToMatrix3x4f()
		{
			Matrix3x4f m = new Matrix3x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
		}

		[Test]
		public void Matrix3x4f_TestRelativelyEqualsToMatrix3x4f()
		{
			
		}

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
			Matrix4x2f m = new Matrix4x2f(
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5, 
				(float)6, (float)7
			);

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
		public void Matrix4x2f_TestAbsoluteEqualsToMatrix4x2f()
		{
			Matrix4x2f m = new Matrix4x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
		}

		[Test]
		public void Matrix4x2f_TestRelativelyEqualsToMatrix4x2f()
		{
			
		}

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
			Matrix4x3f m = new Matrix4x3f(
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8, 
				(float)9, (float)10, (float)11
			);

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
		public void Matrix4x3f_TestAbsoluteEqualsToMatrix4x3f()
		{
			Matrix4x3f m = new Matrix4x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
		}

		[Test]
		public void Matrix4x3f_TestRelativelyEqualsToMatrix4x3f()
		{
			
		}

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
			Matrix4x4f m = new Matrix4x4f(
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11, 
				(float)12, (float)13, (float)14, (float)15
			);

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
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_TestOrtho2D()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho2D(0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho2D(-1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Ortho2D(-1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_TestFrustrum()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_TestPerspectiveSymmetric()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(-1.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+180.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 0.0f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 1.0f, 10.0f));
		}

		[Test]
		public void Matrix4x4f_TestPerspectiveAsymmetric()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(0.0f, 0.0f, -1.0f, +1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(-1.0f, +1.0f, 0.0f, 0.0f, 0.1f, 1000.0f));
			// Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 1.0f, 10.0f));
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
			Assert.IsTrue(v.Equals((Vertex3f)(m * Vertex4f.Zero), 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestTranslate()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			Vertex3f v = new Vertex3f(0.0f, 1.0f, 2.0f);
			
			m.Translate(0.0f, 1.0f, 2.0f);
			
			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.Equals((Vertex3f)(m * Vertex3f.Zero), 1e-5f));
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix4x4f_TestRotatedX()
		{
			Matrix4x4f m = Matrix4x4f.RotatedX(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			Matrix4x4f r1 = Matrix4x4f.RotatedX(+90.0f);
			Matrix4x4f r2 = Matrix4x4f.RotatedX(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4f.Identity, 1e-5f));

			r1 = Matrix4x4f.RotatedX(+90.0f);
			r2 = Matrix4x4f.RotatedX(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestRotateX()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			
			m.RotateX(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateX(+90.0f);
			m.RotateX(-90.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateX(+180.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.RotatedX(+180.0f), 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestRotatedY()
		{
			Matrix4x4f m = Matrix4x4f.RotatedY(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			Matrix4x4f r1 = Matrix4x4f.RotatedY(+90.0f);
			Matrix4x4f r2 = Matrix4x4f.RotatedY(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4f.Identity, 1e-5f));

			r1 = Matrix4x4f.RotatedY(+90.0f);
			r2 = Matrix4x4f.RotatedY(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestRotateY()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			
			m.RotateY(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateY(+90.0f);
			m.RotateY(-90.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateY(+180.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.RotatedY(+180.0f), 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestRotatedZ()
		{
			Matrix4x4f m = Matrix4x4f.RotatedZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			Matrix4x4f r1 = Matrix4x4f.RotatedZ(+90.0f);
			Matrix4x4f r2 = Matrix4x4f.RotatedZ(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4f.Identity, 1e-5f));

			r1 = Matrix4x4f.RotatedZ(+90.0f);
			r2 = Matrix4x4f.RotatedZ(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex4f v = Matrix4x4f.RotatedZ(+90.0f) * Vertex4f.UnitX;
			Assert.IsTrue(v.Equals(Vertex4f.UnitY, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_TestRotateZ()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			
			m.RotateZ(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateZ(+90.0f);
			m.RotateZ(-90.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateZ(+180.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.RotatedZ(+180.0f), 1e-5f));

			m = Matrix4x4f.Identity;
			m.RotateZ(+90.0f);
			Vertex4f v = m * Vertex4f.UnitX;
			Assert.IsTrue(v.Equals(Vertex4f.UnitY, 1e-5f));
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
			Assert.AreEqual(1.0f, Matrix4x4f.Identity.Determinant);
		}

		[Test]
		public void Matrix4x4f_TestInverse()
		{
			Matrix4x4f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix4x4f().Inverse);

			Matrix4x4f m = CreateInvertibleMatrix();
			Matrix4x4f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix4x4f_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix4x4f().Invert());

			Matrix4x4f m = CreateInvertibleMatrix();
			Matrix4x4f n = m;

			m.Invert();

			Matrix4x4f r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4f.Identity, 1e-2f));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x4f_TestAbsoluteEqualsToMatrix4x4f()
		{
			Matrix4x4f m = new Matrix4x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
		}

		[Test]
		public void Matrix4x4f_TestRelativelyEqualsToMatrix4x4f()
		{
			
		}

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

		private static Matrix4x4f CreateInvertibleMatrix()
		{
			Matrix4x4f m = new Matrix4x4f();

			m[0, 0] = Next(1.0f, 2.0f);
			m[0, 1] = Next(0.0f, 0.5f);
			m[0, 2] = Next(0.0f, 0.5f);
			m[0, 3] = Next(0.0f, 0.5f);
			m[1, 0] = Next(0.0f, 0.5f);
			m[1, 1] = Next(1.0f, 2.0f);
			m[1, 2] = Next(0.0f, 0.5f);
			m[1, 3] = Next(0.0f, 0.5f);
			m[2, 0] = Next(0.0f, 0.5f);
			m[2, 1] = Next(0.0f, 0.5f);
			m[2, 2] = Next(1.0f, 2.0f);
			m[2, 3] = Next(0.0f, 0.5f);
			m[3, 0] = Next(0.0f, 0.5f);
			m[3, 1] = Next(0.0f, 0.5f);
			m[3, 2] = Next(0.0f, 0.5f);
			m[3, 3] = Next(1.0f, 2.0f);

			return m;
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
			Matrix2x2d m = new Matrix2x2d(
				(double)0, (double)1, 
				(double)2, (double)3
			);

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
			Matrix2x2d m = Matrix2x2d.RotatedZ(0.0);
			Assert.IsTrue(m.Equals(Matrix2x2d.Identity, 1e-10));

			Matrix2x2d r1 = Matrix2x2d.RotatedZ(+90.0);
			Matrix2x2d r2 = Matrix2x2d.RotatedZ(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix2x2d.Identity, 1e-10));

			r1 = Matrix2x2d.RotatedZ(+90.0);
			r2 = Matrix2x2d.RotatedZ(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

		}

		[Test]
		public void Matrix2x2d_TestRotateZ()
		{
			Matrix2x2d m = Matrix2x2d.Identity;
			
			m.RotateZ(0.0);
			Assert.IsTrue(m.Equals(Matrix2x2d.Identity, 1e-10));

			m.RotateZ(+90.0);
			m.RotateZ(-90.0);
			Assert.IsTrue(m.Equals(Matrix2x2d.Identity, 1e-10));

			m.RotateZ(+180.0);
			Assert.IsTrue(m.Equals(Matrix2x2d.RotatedZ(+180.0), 1e-10));

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
			Assert.AreEqual(1.0, Matrix2x2d.Identity.Determinant);
		}

		[Test]
		public void Matrix2x2d_TestInverse()
		{
			Matrix2x2d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix2x2d().Inverse);

			Matrix2x2d m = CreateInvertibleMatrix();
			Matrix2x2d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2d.Identity, 1e-2));
		}

		[Test]
		public void Matrix2x2d_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix2x2d().Invert());

			Matrix2x2d m = CreateInvertibleMatrix();
			Matrix2x2d n = m;

			m.Invert();

			Matrix2x2d r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2d.Identity, 1e-2));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix2x2d_TestAbsoluteEqualsToMatrix2x2d()
		{
			Matrix2x2d m = new Matrix2x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
		}

		[Test]
		public void Matrix2x2d_TestRelativelyEqualsToMatrix2x2d()
		{
			
		}

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

		private static Matrix2x2d CreateInvertibleMatrix()
		{
			Matrix2x2d m = new Matrix2x2d();

			m[0, 0] = Next(1.0, 2.0);
			m[0, 1] = Next(0.0, 0.5);
			m[1, 0] = Next(0.0, 0.5);
			m[1, 1] = Next(1.0, 2.0);

			return m;
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
			Matrix2x3d m = new Matrix2x3d(
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			);

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
		public void Matrix2x3d_TestAbsoluteEqualsToMatrix2x3d()
		{
			Matrix2x3d m = new Matrix2x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
		}

		[Test]
		public void Matrix2x3d_TestRelativelyEqualsToMatrix2x3d()
		{
			
		}

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
			Matrix2x4d m = new Matrix2x4d(
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			);

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
		public void Matrix2x4d_TestAbsoluteEqualsToMatrix2x4d()
		{
			Matrix2x4d m = new Matrix2x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
		}

		[Test]
		public void Matrix2x4d_TestRelativelyEqualsToMatrix2x4d()
		{
			
		}

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
			Matrix3x2d m = new Matrix3x2d(
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5
			);

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
		public void Matrix3x2d_TestAbsoluteEqualsToMatrix3x2d()
		{
			Matrix3x2d m = new Matrix3x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
		}

		[Test]
		public void Matrix3x2d_TestRelativelyEqualsToMatrix3x2d()
		{
			
		}

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
			Matrix3x3d m = new Matrix3x3d(
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8
			);

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
			Matrix3x3d m = Matrix3x3d.RotatedX(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			Matrix3x3d r1 = Matrix3x3d.RotatedX(+90.0);
			Matrix3x3d r2 = Matrix3x3d.RotatedX(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3d.Identity, 1e-10));

			r1 = Matrix3x3d.RotatedX(+90.0);
			r2 = Matrix3x3d.RotatedX(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));
		}

		[Test]
		public void Matrix3x3d_TestRotateX()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			
			m.RotateX(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateX(+90.0);
			m.RotateX(-90.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateX(+180.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.RotatedX(+180.0), 1e-10));
		}

		[Test]
		public void Matrix3x3d_TestRotatedY()
		{
			Matrix3x3d m = Matrix3x3d.RotatedY(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			Matrix3x3d r1 = Matrix3x3d.RotatedY(+90.0);
			Matrix3x3d r2 = Matrix3x3d.RotatedY(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3d.Identity, 1e-10));

			r1 = Matrix3x3d.RotatedY(+90.0);
			r2 = Matrix3x3d.RotatedY(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));
		}

		[Test]
		public void Matrix3x3d_TestRotateY()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			
			m.RotateY(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateY(+90.0);
			m.RotateY(-90.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateY(+180.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.RotatedY(+180.0), 1e-10));
		}

		[Test]
		public void Matrix3x3d_TestRotatedZ()
		{
			Matrix3x3d m = Matrix3x3d.RotatedZ(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			Matrix3x3d r1 = Matrix3x3d.RotatedZ(+90.0);
			Matrix3x3d r2 = Matrix3x3d.RotatedZ(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3d.Identity, 1e-10));

			r1 = Matrix3x3d.RotatedZ(+90.0);
			r2 = Matrix3x3d.RotatedZ(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex3d v = Matrix3x3d.RotatedZ(+90.0) * Vertex3d.UnitX;
			Assert.IsTrue(v.Equals(Vertex3d.UnitY, 1e-10));
		}

		[Test]
		public void Matrix3x3d_TestRotateZ()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			
			m.RotateZ(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateZ(+90.0);
			m.RotateZ(-90.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateZ(+180.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.RotatedZ(+180.0), 1e-10));

			m = Matrix3x3d.Identity;
			m.RotateZ(+90.0);
			Vertex3d v = m * Vertex3d.UnitX;
			Assert.IsTrue(v.Equals(Vertex3d.UnitY, 1e-10));
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
			Assert.AreEqual(1.0, Matrix3x3d.Identity.Determinant);
		}

		[Test]
		public void Matrix3x3d_TestInverse()
		{
			Matrix3x3d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix3x3d().Inverse);

			Matrix3x3d m = CreateInvertibleMatrix();
			Matrix3x3d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3d.Identity, 1e-2));
		}

		[Test]
		public void Matrix3x3d_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix3x3d().Invert());

			Matrix3x3d m = CreateInvertibleMatrix();
			Matrix3x3d n = m;

			m.Invert();

			Matrix3x3d r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3d.Identity, 1e-2));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix3x3d_TestAbsoluteEqualsToMatrix3x3d()
		{
			Matrix3x3d m = new Matrix3x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
		}

		[Test]
		public void Matrix3x3d_TestRelativelyEqualsToMatrix3x3d()
		{
			
		}

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

		private static Matrix3x3d CreateInvertibleMatrix()
		{
			Matrix3x3d m = new Matrix3x3d();

			m[0, 0] = Next(1.0, 2.0);
			m[0, 1] = Next(0.0, 0.5);
			m[0, 2] = Next(0.0, 0.5);
			m[1, 0] = Next(0.0, 0.5);
			m[1, 1] = Next(1.0, 2.0);
			m[1, 2] = Next(0.0, 0.5);
			m[2, 0] = Next(0.0, 0.5);
			m[2, 1] = Next(0.0, 0.5);
			m[2, 2] = Next(1.0, 2.0);

			return m;
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
			Matrix3x4d m = new Matrix3x4d(
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11
			);

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
		public void Matrix3x4d_TestAbsoluteEqualsToMatrix3x4d()
		{
			Matrix3x4d m = new Matrix3x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
		}

		[Test]
		public void Matrix3x4d_TestRelativelyEqualsToMatrix3x4d()
		{
			
		}

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
			Matrix4x2d m = new Matrix4x2d(
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5, 
				(double)6, (double)7
			);

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
		public void Matrix4x2d_TestAbsoluteEqualsToMatrix4x2d()
		{
			Matrix4x2d m = new Matrix4x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
		}

		[Test]
		public void Matrix4x2d_TestRelativelyEqualsToMatrix4x2d()
		{
			
		}

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
			Matrix4x3d m = new Matrix4x3d(
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8, 
				(double)9, (double)10, (double)11
			);

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
		public void Matrix4x3d_TestAbsoluteEqualsToMatrix4x3d()
		{
			Matrix4x3d m = new Matrix4x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
		}

		[Test]
		public void Matrix4x3d_TestRelativelyEqualsToMatrix4x3d()
		{
			
		}

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
			Matrix4x4d m = new Matrix4x4d(
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11, 
				(double)12, (double)13, (double)14, (double)15
			);

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
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_TestOrtho2D()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho2D(0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho2D(-1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Ortho2D(-1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_TestFrustrum()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_TestPerspectiveSymmetric()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(-1.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+180.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 0.0f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 1.0f, 10.0f));
		}

		[Test]
		public void Matrix4x4d_TestPerspectiveAsymmetric()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(0.0f, 0.0f, -1.0f, +1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(-1.0f, +1.0f, 0.0f, 0.0f, 0.1f, 1000.0f));
			// Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 1.0f, 10.0f));
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
			Assert.IsTrue(v.Equals((Vertex3d)(m * Vertex4d.Zero), 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestTranslate()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			Vertex3d v = new Vertex3d(0.0, 1.0, 2.0);
			
			m.Translate(0.0, 1.0, 2.0);
			
			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.Equals((Vertex3d)(m * Vertex3d.Zero), 1e-10));
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix4x4d_TestRotatedX()
		{
			Matrix4x4d m = Matrix4x4d.RotatedX(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			Matrix4x4d r1 = Matrix4x4d.RotatedX(+90.0);
			Matrix4x4d r2 = Matrix4x4d.RotatedX(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4d.Identity, 1e-10));

			r1 = Matrix4x4d.RotatedX(+90.0);
			r2 = Matrix4x4d.RotatedX(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestRotateX()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			
			m.RotateX(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateX(+90.0);
			m.RotateX(-90.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateX(+180.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.RotatedX(+180.0), 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestRotatedY()
		{
			Matrix4x4d m = Matrix4x4d.RotatedY(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			Matrix4x4d r1 = Matrix4x4d.RotatedY(+90.0);
			Matrix4x4d r2 = Matrix4x4d.RotatedY(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4d.Identity, 1e-10));

			r1 = Matrix4x4d.RotatedY(+90.0);
			r2 = Matrix4x4d.RotatedY(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestRotateY()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			
			m.RotateY(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateY(+90.0);
			m.RotateY(-90.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateY(+180.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.RotatedY(+180.0), 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestRotatedZ()
		{
			Matrix4x4d m = Matrix4x4d.RotatedZ(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			Matrix4x4d r1 = Matrix4x4d.RotatedZ(+90.0);
			Matrix4x4d r2 = Matrix4x4d.RotatedZ(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4d.Identity, 1e-10));

			r1 = Matrix4x4d.RotatedZ(+90.0);
			r2 = Matrix4x4d.RotatedZ(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex4d v = Matrix4x4d.RotatedZ(+90.0) * Vertex4d.UnitX;
			Assert.IsTrue(v.Equals(Vertex4d.UnitY, 1e-10));
		}

		[Test]
		public void Matrix4x4d_TestRotateZ()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			
			m.RotateZ(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateZ(+90.0);
			m.RotateZ(-90.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateZ(+180.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.RotatedZ(+180.0), 1e-10));

			m = Matrix4x4d.Identity;
			m.RotateZ(+90.0);
			Vertex4d v = m * Vertex4d.UnitX;
			Assert.IsTrue(v.Equals(Vertex4d.UnitY, 1e-10));
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
			Assert.AreEqual(1.0, Matrix4x4d.Identity.Determinant);
		}

		[Test]
		public void Matrix4x4d_TestInverse()
		{
			Matrix4x4d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix4x4d().Inverse);

			Matrix4x4d m = CreateInvertibleMatrix();
			Matrix4x4d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4d.Identity, 1e-2));
		}

		[Test]
		public void Matrix4x4d_TestInvert()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix4x4d().Invert());

			Matrix4x4d m = CreateInvertibleMatrix();
			Matrix4x4d n = m;

			m.Invert();

			Matrix4x4d r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4d.Identity, 1e-2));
		}

		#endregion


		#region IEquatable Implementation

		[Test]
		public void Matrix4x4d_TestAbsoluteEqualsToMatrix4x4d()
		{
			Matrix4x4d m = new Matrix4x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
		}

		[Test]
		public void Matrix4x4d_TestRelativelyEqualsToMatrix4x4d()
		{
			
		}

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

		private static Matrix4x4d CreateInvertibleMatrix()
		{
			Matrix4x4d m = new Matrix4x4d();

			m[0, 0] = Next(1.0, 2.0);
			m[0, 1] = Next(0.0, 0.5);
			m[0, 2] = Next(0.0, 0.5);
			m[0, 3] = Next(0.0, 0.5);
			m[1, 0] = Next(0.0, 0.5);
			m[1, 1] = Next(1.0, 2.0);
			m[1, 2] = Next(0.0, 0.5);
			m[1, 3] = Next(0.0, 0.5);
			m[2, 0] = Next(0.0, 0.5);
			m[2, 1] = Next(0.0, 0.5);
			m[2, 2] = Next(1.0, 2.0);
			m[2, 3] = Next(0.0, 0.5);
			m[3, 0] = Next(0.0, 0.5);
			m[3, 1] = Next(0.0, 0.5);
			m[3, 2] = Next(0.0, 0.5);
			m[3, 3] = Next(1.0, 2.0);

			return m;
		}

		#endregion
	}

}