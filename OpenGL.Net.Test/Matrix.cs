
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
	[TestFixture, Category("Math")]
	internal class Matrix2x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x2f_Constructor1()
		{
			Matrix2x2f m = new Matrix2x2f(
				(float)0, (float)1, 
				(float)2, (float)3
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_Constructor2()
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
		public void Matrix2x2f_Constructor3()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = new Matrix2x2f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x2f_Columns()
		{
			Matrix2x2f m = CreateRandomMatrix();

			Vertex2f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

		}

		[Test]
		public void Matrix2x2f_Rows()
		{
			Matrix2x2f m = CreateRandomMatrix();

			Vertex2f r0 = m.Row0;
			Vertex2f r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x2f_Accessor()
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
		public void Matrix2x2f_MultiplyScalar()
		{
			Matrix2x2f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_MultiplyVertex2f()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			Vertex2f v = Vertex2f.Zero;
			Vertex2f r = m * v;
		}

		[Test]
		public void Matrix2x2f_MultiplyMatrix2x2f()
		{
			Matrix2x2f m1 = CreateSequenceMatrix();
			Matrix2x2f m2 = CreateSequenceMatrix();
			Matrix2x2f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2f_CastToArray()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_CastToMatrix2x2d()
		{
			Matrix2x2f m = CreateSequenceMatrix();
			Matrix2x2d mOther = (Matrix2x2d)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x2f_EqualityOperator()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x2f_InequalityOperator()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix2x2f_RotatedZ()
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
		public void Matrix2x2f_RotateZ()
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

		#region Transposition

		[Test]
		public void Matrix2x2f_Transposed()
		{
			Matrix2x2f m = CreateRandomMatrix();
			Matrix2x2f t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-5f));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-5f));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-5f));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x2f_Transpose()
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
		public void Matrix2x2f_Determinant()
		{
			Assert.AreEqual(1.0f, Matrix2x2f.Identity.Determinant);
		}

		[Test]
		public void Matrix2x2f_Inverse()
		{
			Matrix2x2f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix2x2f().Inverse);

			Matrix2x2f m = CreateInvertibleMatrix();
			Matrix2x2f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix2x2f_Invert()
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
		public void Matrix2x2f_AbsoluteEqualsToMatrix2x2f()
		{
			Matrix2x2f m = new Matrix2x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x2f.Zero, 0.50f));
			m[1, 1] = 0.0f;
		}

		[Test]
		public void Matrix2x2f_EqualsToMatrix2x2f()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2f_EqualsToObject()
		{
			Matrix2x2f m1 = CreateRandomMatrix();
			Matrix2x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2f_GetHashCode()
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
		public void Matrix2x2f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix2x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x3f_Constructor1()
		{
			Matrix2x3f m = new Matrix2x3f(
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x3f_Constructor2()
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
		public void Matrix2x3f_Constructor3()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = new Matrix2x3f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x3f_Columns()
		{
			Matrix2x3f m = CreateRandomMatrix();

			Vertex3f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

		}

		[Test]
		public void Matrix2x3f_Rows()
		{
			Matrix2x3f m = CreateRandomMatrix();

			Vertex2f r0 = m.Row0;
			Vertex2f r1 = m.Row1;
			Vertex2f r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x3f_Accessor()
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
		public void Matrix2x3f_MultiplyScalar()
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
		public void Matrix2x3f_CastToArray()
		{
			Matrix2x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x3f_CastToMatrix2x3d()
		{
			Matrix2x3f m = CreateSequenceMatrix();
			Matrix2x3d mOther = (Matrix2x3d)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x3f_EqualityOperator()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x3f_InequalityOperator()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix2x3f_Transposed()
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
		public void Matrix2x3f_AbsoluteEqualsToMatrix2x3f()
		{
			Matrix2x3f m = new Matrix2x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x3f.Zero, 0.50f));
			m[1, 2] = 0.0f;
		}

		[Test]
		public void Matrix2x3f_EqualsToMatrix2x3f()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3f_EqualsToObject()
		{
			Matrix2x3f m1 = CreateRandomMatrix();
			Matrix2x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3f_GetHashCode()
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
		public void Matrix2x3f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix2x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x4f_Constructor1()
		{
			Matrix2x4f m = new Matrix2x4f(
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-5f));
		}

		[Test]
		public void Matrix2x4f_Constructor2()
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
		public void Matrix2x4f_Constructor3()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = new Matrix2x4f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x4f_Columns()
		{
			Matrix2x4f m = CreateRandomMatrix();

			Vertex4f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

		}

		[Test]
		public void Matrix2x4f_Rows()
		{
			Matrix2x4f m = CreateRandomMatrix();

			Vertex2f r0 = m.Row0;
			Vertex2f r1 = m.Row1;
			Vertex2f r2 = m.Row2;
			Vertex2f r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x4f_Accessor()
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
		public void Matrix2x4f_MultiplyScalar()
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
		public void Matrix2x4f_CastToArray()
		{
			Matrix2x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix2x4f_CastToMatrix2x4d()
		{
			Matrix2x4f m = CreateSequenceMatrix();
			Matrix2x4d mOther = (Matrix2x4d)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x4f_EqualityOperator()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x4f_InequalityOperator()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix2x4f_Transposed()
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
		public void Matrix2x4f_AbsoluteEqualsToMatrix2x4f()
		{
			Matrix2x4f m = new Matrix2x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[0, 3] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 2] = 0.0f;
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix2x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix2x4f.Zero, 0.50f));
			m[1, 3] = 0.0f;
		}

		[Test]
		public void Matrix2x4f_EqualsToMatrix2x4f()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4f_EqualsToObject()
		{
			Matrix2x4f m1 = CreateRandomMatrix();
			Matrix2x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4f_GetHashCode()
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
		public void Matrix2x4f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x2f_Constructor1()
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
		public void Matrix3x2f_Constructor2()
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
		public void Matrix3x2f_Constructor3()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = new Matrix3x2f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x2f_Columns()
		{
			Matrix3x2f m = CreateRandomMatrix();

			Vertex2f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

			Vertex2f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);

		}

		[Test]
		public void Matrix3x2f_Rows()
		{
			Matrix3x2f m = CreateRandomMatrix();

			Vertex3f r0 = m.Row0;
			Vertex3f r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x2f_Accessor()
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
		public void Matrix3x2f_MultiplyScalar()
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
		public void Matrix3x2f_CastToArray()
		{
			Matrix3x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x2f_CastToMatrix3x2d()
		{
			Matrix3x2f m = CreateSequenceMatrix();
			Matrix3x2d mOther = (Matrix3x2d)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x2f_EqualityOperator()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x2f_InequalityOperator()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x2f_Transposed()
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
		public void Matrix3x2f_AbsoluteEqualsToMatrix3x2f()
		{
			Matrix3x2f m = new Matrix3x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x2f.Zero, 0.50f));
			m[2, 1] = 0.0f;
		}

		[Test]
		public void Matrix3x2f_EqualsToMatrix3x2f()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2f_EqualsToObject()
		{
			Matrix3x2f m1 = CreateRandomMatrix();
			Matrix3x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2f_GetHashCode()
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
		public void Matrix3x2f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x3f_Constructor1()
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
		public void Matrix3x3f_Constructor2()
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
		public void Matrix3x3f_Constructor3()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = new Matrix3x3f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_Constructor4()
		{
			Matrix4x4f m = new Matrix4x4f();
			Matrix3x3f c;

			Assert.Throws<ArgumentOutOfRangeException>(() => c = new Matrix3x3f(m, 4, 3));
			Assert.Throws<ArgumentOutOfRangeException>(() => c = new Matrix3x3f(m, 3, 4));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x3f_Columns()
		{
			Matrix3x3f m = CreateRandomMatrix();

			Vertex3f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

			Vertex3f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);

		}

		[Test]
		public void Matrix3x3f_Rows()
		{
			Matrix3x3f m = CreateRandomMatrix();

			Vertex3f r0 = m.Row0;
			Vertex3f r1 = m.Row1;
			Vertex3f r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x3f_Accessor()
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
		public void Matrix3x3f_MultiplyScalar()
		{
			Matrix3x3f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_MultiplyVertex3f()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			Vertex3f v = Vertex3f.Zero;
			Vertex3f r = m * v;
		}

		[Test]
		public void Matrix3x3f_MultiplyMatrix3x3f()
		{
			Matrix3x3f m1 = CreateSequenceMatrix();
			Matrix3x3f m2 = CreateSequenceMatrix();
			Matrix3x3f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3f_CastToArray()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x3f_CastToMatrix3x3d()
		{
			Matrix3x3f m = CreateSequenceMatrix();
			Matrix3x3d mOther = (Matrix3x3d)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x3f_EqualityOperator()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x3f_InequalityOperator()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix3x3f_RotatedX()
		{
			Matrix3x3f m = Matrix3x3f.RotatedX(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			Matrix3x3f r1 = Matrix3x3f.RotatedX(+90.0f);
			Matrix3x3f r2 = Matrix3x3f.RotatedX(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3f.Identity, 1e-5f));

			r1 = Matrix3x3f.RotatedX(+90.0f);
			r2 = Matrix3x3f.RotatedX(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex3f v = Matrix3x3f.RotatedX(+90.0f) * Vertex3f.UnitY;
			Assert.IsTrue(v.Equals(Vertex3f.UnitZ, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_RotateX()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			
			m.RotateX(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateX(+90.0f);
			m.RotateX(-90.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateX(+180.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.RotatedX(+180.0f), 1e-5f));

			m = Matrix3x3f.Identity;
			m.RotateX(+90.0f);
			Vertex3f v = m * Vertex3f.UnitY;
			Assert.IsTrue(v.Equals(Vertex3f.UnitZ, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_RotatedY()
		{
			Matrix3x3f m = Matrix3x3f.RotatedY(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			Matrix3x3f r1 = Matrix3x3f.RotatedY(+90.0f);
			Matrix3x3f r2 = Matrix3x3f.RotatedY(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3f.Identity, 1e-5f));

			r1 = Matrix3x3f.RotatedY(+90.0f);
			r2 = Matrix3x3f.RotatedY(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex3f v = Matrix3x3f.RotatedY(+90.0f) * Vertex3f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3f.UnitX, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_RotateY()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			
			m.RotateY(0.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateY(+90.0f);
			m.RotateY(-90.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.Identity, 1e-5f));

			m.RotateY(+180.0f);
			Assert.IsTrue(m.Equals(Matrix3x3f.RotatedY(+180.0f), 1e-5f));

			m = Matrix3x3f.Identity;
			m.RotateY(+90.0f);
			Vertex3f v = m * Vertex3f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3f.UnitX, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_RotatedZ()
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
		public void Matrix3x3f_RotateZ()
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
		public void Matrix3x3f_Scaled()
		{
			Matrix3x3f m = Matrix3x3f.Scaled(1.0f, 1.0f, 1.0f);
			Vertex3f v;
			
			v = m * Vertex3f.UnitX;
			Assert.IsTrue(Vertex3f.UnitX.Equals(v, 1e-5f));

			v = m * Vertex3f.UnitY;
			Assert.IsTrue(Vertex3f.UnitY.Equals(v, 1e-5f));

			v = m * Vertex3f.UnitZ;
			Assert.IsTrue(Vertex3f.UnitZ.Equals(v, 1e-5f));

			m = Matrix3x3f.Scaled(0.5f, 2.0f, 3.0f);

			v = m * Vertex3f.UnitX;
			Assert.IsTrue((Vertex3f.UnitX * 0.5f).Equals(v, 1e-5f));

			v = m * Vertex3f.UnitY;
			Assert.IsTrue((Vertex3f.UnitY * 2.0f).Equals(v, 1e-5f));

			v = m * Vertex3f.UnitZ;
			Assert.IsTrue((Vertex3f.UnitZ * 3.0f).Equals(v, 1e-5f));
		}

		[Test]
		public void Matrix3x3f_Scale()
		{
			Matrix3x3f m = Matrix3x3f.Identity;
			Vertex3f v;

			m.Scale(1.0f, 1.0f, 1.0f);

			v = m * Vertex3f.UnitX;
			Assert.IsTrue(Vertex3f.UnitX.Equals(v, 1e-5f));

			v = m * Vertex3f.UnitY;
			Assert.IsTrue(Vertex3f.UnitY.Equals(v, 1e-5f));

			v = m * Vertex3f.UnitZ;
			Assert.IsTrue(Vertex3f.UnitZ.Equals(v, 1e-5f));

			m.Scale(0.5f, 2.0f, 3.0f);

			v = m * Vertex3f.UnitX;
			Assert.IsTrue((Vertex3f.UnitX * 0.5f).Equals(v, 1e-5f));

			v = m * Vertex3f.UnitY;
			Assert.IsTrue((Vertex3f.UnitY * 2.0f).Equals(v, 1e-5f));

			v = m * Vertex3f.UnitZ;
			Assert.IsTrue((Vertex3f.UnitZ * 3.0f).Equals(v, 1e-5f));
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x3f_Transposed()
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
		public void Matrix3x3f_Transpose()
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
		public void Matrix3x3f_Determinant()
		{
			Assert.AreEqual(1.0f, Matrix3x3f.Identity.Determinant);
		}

		[Test]
		public void Matrix3x3f_Inverse()
		{
			Matrix3x3f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix3x3f().Inverse);

			Matrix3x3f m = CreateInvertibleMatrix();
			Matrix3x3f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix3x3f_Invert()
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
		public void Matrix3x3f_AbsoluteEqualsToMatrix3x3f()
		{
			Matrix3x3f m = new Matrix3x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[1, 2] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 1] = 0.0f;
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x3f.Zero, 0.50f));
			m[2, 2] = 0.0f;
		}

		[Test]
		public void Matrix3x3f_EqualsToMatrix3x3f()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3f_EqualsToObject()
		{
			Matrix3x3f m1 = CreateRandomMatrix();
			Matrix3x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3f_GetHashCode()
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
		public void Matrix3x3f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x4f_Constructor1()
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
		public void Matrix3x4f_Constructor2()
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
		public void Matrix3x4f_Constructor3()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = new Matrix3x4f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x4f_Columns()
		{
			Matrix3x4f m = CreateRandomMatrix();

			Vertex4f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

			Vertex4f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);
			Assert.AreEqual(c2.w, m[2, 3]);

		}

		[Test]
		public void Matrix3x4f_Rows()
		{
			Matrix3x4f m = CreateRandomMatrix();

			Vertex3f r0 = m.Row0;
			Vertex3f r1 = m.Row1;
			Vertex3f r2 = m.Row2;
			Vertex3f r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x4f_Accessor()
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
		public void Matrix3x4f_MultiplyScalar()
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
		public void Matrix3x4f_CastToArray()
		{
			Matrix3x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix3x4f_CastToMatrix3x4d()
		{
			Matrix3x4f m = CreateSequenceMatrix();
			Matrix3x4d mOther = (Matrix3x4d)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x4f_EqualityOperator()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x4f_InequalityOperator()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x4f_Transposed()
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
		public void Matrix3x4f_AbsoluteEqualsToMatrix3x4f()
		{
			Matrix3x4f m = new Matrix3x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[0, 3] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 2] = 0.0f;
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[1, 3] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 1] = 0.0f;
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 2] = 0.0f;
			m[2, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix3x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix3x4f.Zero, 0.50f));
			m[2, 3] = 0.0f;
		}

		[Test]
		public void Matrix3x4f_EqualsToMatrix3x4f()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4f_EqualsToObject()
		{
			Matrix3x4f m1 = CreateRandomMatrix();
			Matrix3x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4f_GetHashCode()
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
		public void Matrix3x4f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x2fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x2f_Constructor1()
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
		public void Matrix4x2f_Constructor2()
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
		public void Matrix4x2f_Constructor3()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = new Matrix4x2f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x2f_Columns()
		{
			Matrix4x2f m = CreateRandomMatrix();

			Vertex2f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

			Vertex2f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);

			Vertex2f c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);

		}

		[Test]
		public void Matrix4x2f_Rows()
		{
			Matrix4x2f m = CreateRandomMatrix();

			Vertex4f r0 = m.Row0;
			Vertex4f r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x2f_Accessor()
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
		public void Matrix4x2f_MultiplyScalar()
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
		public void Matrix4x2f_CastToArray()
		{
			Matrix4x2f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x2f_CastToMatrix4x2d()
		{
			Matrix4x2f m = CreateSequenceMatrix();
			Matrix4x2d mOther = (Matrix4x2d)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x2f_EqualityOperator()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x2f_InequalityOperator()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x2f_Transposed()
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
		public void Matrix4x2f_AbsoluteEqualsToMatrix4x2f()
		{
			Matrix4x2f m = new Matrix4x2f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[2, 1] = 0.0f;
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[3, 0] = 0.0f;
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x2f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x2f.Zero, 0.50f));
			m[3, 1] = 0.0f;
		}

		[Test]
		public void Matrix4x2f_EqualsToMatrix4x2f()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2f_EqualsToObject()
		{
			Matrix4x2f m1 = CreateRandomMatrix();
			Matrix4x2f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2f_GetHashCode()
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
		public void Matrix4x2f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x3fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x3f_Constructor1()
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
		public void Matrix4x3f_Constructor2()
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
		public void Matrix4x3f_Constructor3()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = new Matrix4x3f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x3f_Columns()
		{
			Matrix4x3f m = CreateRandomMatrix();

			Vertex3f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

			Vertex3f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);

			Vertex3f c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);
			Assert.AreEqual(c3.z, m[3, 2]);

		}

		[Test]
		public void Matrix4x3f_Rows()
		{
			Matrix4x3f m = CreateRandomMatrix();

			Vertex4f r0 = m.Row0;
			Vertex4f r1 = m.Row1;
			Vertex4f r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x3f_Accessor()
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
		public void Matrix4x3f_MultiplyScalar()
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
		public void Matrix4x3f_CastToArray()
		{
			Matrix4x3f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x3f_CastToMatrix4x3d()
		{
			Matrix4x3f m = CreateSequenceMatrix();
			Matrix4x3d mOther = (Matrix4x3d)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x3f_EqualityOperator()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x3f_InequalityOperator()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x3f_Transposed()
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
		public void Matrix4x3f_AbsoluteEqualsToMatrix4x3f()
		{
			Matrix4x3f m = new Matrix4x3f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[1, 2] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 1] = 0.0f;
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[2, 2] = 0.0f;
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 0] = 0.0f;
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 1] = 0.0f;
			m[3, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x3f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x3f.Zero, 0.50f));
			m[3, 2] = 0.0f;
		}

		[Test]
		public void Matrix4x3f_EqualsToMatrix4x3f()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3f_EqualsToObject()
		{
			Matrix4x3f m1 = CreateRandomMatrix();
			Matrix4x3f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3f_GetHashCode()
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
		public void Matrix4x3f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x4fTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x4f_Constructor1()
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
		public void Matrix4x4f_Constructor2()
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
		public void Matrix4x4f_Constructor3()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = new Matrix4x4f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x4f_Columns()
		{
			Matrix4x4f m = CreateRandomMatrix();

			Vertex4f c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4f c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

			Vertex4f c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);
			Assert.AreEqual(c2.w, m[2, 3]);

			Vertex4f c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);
			Assert.AreEqual(c3.z, m[3, 2]);
			Assert.AreEqual(c3.w, m[3, 3]);

		}

		[Test]
		public void Matrix4x4f_Rows()
		{
			Matrix4x4f m = CreateRandomMatrix();

			Vertex4f r0 = m.Row0;
			Vertex4f r1 = m.Row1;
			Vertex4f r2 = m.Row2;
			Vertex4f r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x4f_Accessor()
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
		public void Matrix4x4f_MultiplyScalar()
		{
			Matrix4x4f m = CreateSequenceMatrix();

			m = m * 2.0f;

			float idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx += 1.0f)
				Assert.That(idx * 2.0f, Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_MultiplyVertex4f()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			Vertex4f v = Vertex4f.Zero;
			Vertex4f r = m * v;
		}

		[Test]
		public void Matrix4x4f_MultiplyMatrix4x4f()
		{
			Matrix4x4f m1 = CreateSequenceMatrix();
			Matrix4x4f m2 = CreateSequenceMatrix();
			Matrix4x4f r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4f_CastToArray()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		[Test]
		public void Matrix4x4f_CastToMatrix4x4d()
		{
			Matrix4x4f m = CreateSequenceMatrix();
			Matrix4x4d mOther = (Matrix4x4d)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6f));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x4f_EqualityOperator()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x4f_InequalityOperator()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Projections

		[Test]
		public void Matrix4x4f_Ortho()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_Ortho2D()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho2D(0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Ortho2D(-1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Ortho2D(-1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_Frustrum()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4f_PerspectiveSymmetric()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(-1.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+180.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 0.0f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Perspective(+1.0f, 1.0f, 1.0f, 10.0f));
		}

		[Test]
		public void Matrix4x4f_PerspectiveAsymmetric()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(0.0f, 0.0f, -1.0f, +1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(-1.0f, +1.0f, 0.0f, 0.0f, 0.1f, 1000.0f));
			// Assert.Throws<ArgumentException>(() => Matrix4x4f.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4f.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 1.0f, 10.0f));
		}

		#endregion

		#region View Model

		[Test]
		public void Matrix4x4f_Position()
		{
			Matrix4x4f m = Matrix4x4f.Identity;

			Assert.AreEqual(Vertex3f.Zero, m.Position);
			
			m.Translate(1.0f, 0.0f, 0.0f);
			Assert.AreEqual(Vertex3f.UnitX, m.Position);

			m.Translate(0.0f, 1.0f, 0.0f);
			Assert.AreEqual(Vertex3f.UnitX + Vertex3f.UnitY, m.Position);

			m.Translate(0.0f, 0.0f, 1.0f);
			Assert.AreEqual(Vertex3f.UnitX + Vertex3f.UnitY + Vertex3f.UnitZ, m.Position);
		}

		[Test]
		public void Matrix4x4f_ForwardVector()
		{
			Matrix4x4f m = Matrix4x4f.Identity;

			Assert.AreEqual(-Vertex3f.UnitZ, m.ForwardVector);

			m.RotateY(-90.0f);
			Assert.IsTrue(Vertex3f.UnitX.Equals(m.ForwardVector, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_RightVector()
		{
			Matrix4x4f m = Matrix4x4f.Identity;

			Assert.AreEqual(Vertex3f.UnitX, m.RightVector);

			m.RotateY(-90.0f);
			Assert.IsTrue(Vertex3f.UnitZ.Equals(m.RightVector, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_UpVector()
		{
			Matrix4x4f m = Matrix4x4f.Identity;

			Assert.AreEqual(Vertex3f.UnitY, m.UpVector);

			m.RotateX(+90.0f);
			Assert.IsTrue(Vertex3f.UnitZ.Equals(m.UpVector, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_LookAt()
		{
			Matrix4x4f m = Matrix4x4f.LookAt(Vertex3f.UnitZ, Vertex3f.Zero, Vertex3f.UnitY);
			Assert.AreEqual(-Vertex3f.UnitZ, m.ForwardVector);
			Assert.AreEqual(Vertex3f.UnitY, m.UpVector);
			Assert.AreEqual(Vertex3f.UnitX, m.RightVector);
		}

		[Test]
		public void Matrix4x4f_LookAtDirection()
		{
			Matrix4x4f m = Matrix4x4f.LookAtDirection(Vertex3f.Zero, -Vertex3f.UnitZ, Vertex3f.UnitY);
			Assert.AreEqual(-Vertex3f.UnitZ, m.ForwardVector);
			Assert.AreEqual(Vertex3f.UnitY, m.UpVector);
			Assert.AreEqual(Vertex3f.UnitX, m.RightVector);

			m = Matrix4x4f.LookAtDirection(Vertex3f.Zero, Vertex3f.UnitY, Vertex3f.UnitY).Inverse;
			Assert.AreEqual(Vertex3f.UnitY, m.ForwardVector);
			Assert.AreEqual(Vertex3f.UnitZ, m.UpVector);
			Assert.AreEqual(Vertex3f.UnitX, m.RightVector);
		}

		#endregion

		#region Translation

		[Test]
		public void Matrix4x4f_Translated()
		{
			Matrix4x4f m = Matrix4x4f.Translated(0.0f, 1.0f, 2.0f);
			Vertex3f v = new Vertex3f(0.0f, 1.0f, 2.0f);

			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.Equals((Vertex3f)(m * Vertex4f.Zero), 1e-5f));
		}

		[Test]
		public void Matrix4x4f_Translate()
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
		public void Matrix4x4f_RotatedX()
		{
			Matrix4x4f m = Matrix4x4f.RotatedX(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			Matrix4x4f r1 = Matrix4x4f.RotatedX(+90.0f);
			Matrix4x4f r2 = Matrix4x4f.RotatedX(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4f.Identity, 1e-5f));

			r1 = Matrix4x4f.RotatedX(+90.0f);
			r2 = Matrix4x4f.RotatedX(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex4f v = Matrix4x4f.RotatedX(+90.0f) * Vertex4f.UnitY;
			Assert.IsTrue(v.Equals(Vertex4f.UnitZ, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_RotateX()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			
			m.RotateX(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateX(+90.0f);
			m.RotateX(-90.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateX(+180.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.RotatedX(+180.0f), 1e-5f));

			m = Matrix4x4f.Identity;
			m.RotateX(+90.0f);
			Vertex4f v = m * Vertex4f.UnitY;
			Assert.IsTrue(v.Equals(Vertex4f.UnitZ, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_RotatedY()
		{
			Matrix4x4f m = Matrix4x4f.RotatedY(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			Matrix4x4f r1 = Matrix4x4f.RotatedY(+90.0f);
			Matrix4x4f r2 = Matrix4x4f.RotatedY(-90.0f);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4f.Identity, 1e-5f));

			r1 = Matrix4x4f.RotatedY(+90.0f);
			r2 = Matrix4x4f.RotatedY(+180.0f);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-5f));

			Vertex4f v = Matrix4x4f.RotatedY(+90.0f) * Vertex4f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4f.UnitX, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_RotateY()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			
			m.RotateY(0.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateY(+90.0f);
			m.RotateY(-90.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.Identity, 1e-5f));

			m.RotateY(+180.0f);
			Assert.IsTrue(m.Equals(Matrix4x4f.RotatedY(+180.0f), 1e-5f));

			m = Matrix4x4f.Identity;
			m.RotateY(+90.0f);
			Vertex4f v = m * Vertex4f.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4f.UnitX, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_RotatedZ()
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
		public void Matrix4x4f_RotateZ()
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
		public void Matrix4x4f_Scaled()
		{
			Matrix4x4f m = Matrix4x4f.Scaled(1.0f, 1.0f, 1.0f);
			Vertex4f v;
			
			v = m * Vertex4f.UnitX;
			Assert.IsTrue(Vertex4f.UnitX.Equals(v, 1e-5f));

			v = m * Vertex4f.UnitY;
			Assert.IsTrue(Vertex4f.UnitY.Equals(v, 1e-5f));

			v = m * Vertex4f.UnitZ;
			Assert.IsTrue(Vertex4f.UnitZ.Equals(v, 1e-5f));

			m = Matrix4x4f.Scaled(0.5f, 2.0f, 3.0f);

			v = m * Vertex4f.UnitX;
			Assert.IsTrue((Vertex4f.UnitX * 0.5f).Equals(v, 1e-5f));

			v = m * Vertex4f.UnitY;
			Assert.IsTrue((Vertex4f.UnitY * 2.0f).Equals(v, 1e-5f));

			v = m * Vertex4f.UnitZ;
			Assert.IsTrue((Vertex4f.UnitZ * 3.0f).Equals(v, 1e-5f));
		}

		[Test]
		public void Matrix4x4f_Scale()
		{
			Matrix4x4f m = Matrix4x4f.Identity;
			Vertex4f v;

			m.Scale(1.0f, 1.0f, 1.0f);

			v = m * Vertex4f.UnitX;
			Assert.IsTrue(Vertex4f.UnitX.Equals(v, 1e-5f));

			v = m * Vertex4f.UnitY;
			Assert.IsTrue(Vertex4f.UnitY.Equals(v, 1e-5f));

			v = m * Vertex4f.UnitZ;
			Assert.IsTrue(Vertex4f.UnitZ.Equals(v, 1e-5f));

			m.Scale(0.5f, 2.0f, 3.0f);

			v = m * Vertex4f.UnitX;
			Assert.IsTrue((Vertex4f.UnitX * 0.5f).Equals(v, 1e-5f));

			v = m * Vertex4f.UnitY;
			Assert.IsTrue((Vertex4f.UnitY * 2.0f).Equals(v, 1e-5f));

			v = m * Vertex4f.UnitZ;
			Assert.IsTrue((Vertex4f.UnitZ * 3.0f).Equals(v, 1e-5f));
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x4f_Transposed()
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
		public void Matrix4x4f_Transpose()
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
		public void Matrix4x4f_Determinant()
		{
			Assert.AreEqual(1.0f, Matrix4x4f.Identity.Determinant);
		}

		[Test]
		public void Matrix4x4f_Inverse()
		{
			Matrix4x4f r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix4x4f().Inverse);

			Matrix4x4f m = CreateInvertibleMatrix();
			Matrix4x4f n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4f.Identity, 1e-2f));
		}

		[Test]
		public void Matrix4x4f_Invert()
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
		public void Matrix4x4f_AbsoluteEqualsToMatrix4x4f()
		{
			Matrix4x4f m = new Matrix4x4f();

			m[0, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 0] = 0.0f;
			m[0, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 1] = 0.0f;
			m[0, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 2] = 0.0f;
			m[0, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[0, 3] = 0.0f;
			m[1, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 0] = 0.0f;
			m[1, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 1] = 0.0f;
			m[1, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 2] = 0.0f;
			m[1, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[1, 3] = 0.0f;
			m[2, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 0] = 0.0f;
			m[2, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 1] = 0.0f;
			m[2, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 2] = 0.0f;
			m[2, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[2, 3] = 0.0f;
			m[3, 0] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 0] = 0.0f;
			m[3, 1] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 1] = 0.0f;
			m[3, 2] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 2] = 0.0f;
			m[3, 3] = 0.5f;
			Assert.IsFalse(m.Equals(Matrix4x4f.Zero, 0.25f));
			Assert.IsTrue(m.Equals(Matrix4x4f.Zero, 0.50f));
			m[3, 3] = 0.0f;
		}

		[Test]
		public void Matrix4x4f_EqualsToMatrix4x4f()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4f_EqualsToObject()
		{
			Matrix4x4f m1 = CreateRandomMatrix();
			Matrix4x4f m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4f_GetHashCode()
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
		public void Matrix4x4f_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix2x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x2d_Constructor1()
		{
			Matrix2x2d m = new Matrix2x2d(
				(double)0, (double)1, 
				(double)2, (double)3
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_Constructor2()
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
		public void Matrix2x2d_Constructor3()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = new Matrix2x2d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x2d_Columns()
		{
			Matrix2x2d m = CreateRandomMatrix();

			Vertex2d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

		}

		[Test]
		public void Matrix2x2d_Rows()
		{
			Matrix2x2d m = CreateRandomMatrix();

			Vertex2d r0 = m.Row0;
			Vertex2d r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x2d_Accessor()
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
		public void Matrix2x2d_MultiplyScalar()
		{
			Matrix2x2d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_MultiplyVertex2d()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			Vertex2d v = Vertex2d.Zero;
			Vertex2d r = m * v;
		}

		[Test]
		public void Matrix2x2d_MultiplyMatrix2x2d()
		{
			Matrix2x2d m1 = CreateSequenceMatrix();
			Matrix2x2d m2 = CreateSequenceMatrix();
			Matrix2x2d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2d_CastToArray()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_CastToMatrix2x2f()
		{
			Matrix2x2d m = CreateSequenceMatrix();
			Matrix2x2f mOther = (Matrix2x2f)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x2d_EqualityOperator()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x2d_InequalityOperator()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix2x2d_RotatedZ()
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
		public void Matrix2x2d_RotateZ()
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

		#region Transposition

		[Test]
		public void Matrix2x2d_Transposed()
		{
			Matrix2x2d m = CreateRandomMatrix();
			Matrix2x2d t = m.Transposed;

			Assert.That(m[0, 0], Is.EqualTo(t[0, 0]).Within(1e-10));
			Assert.That(m[0, 1], Is.EqualTo(t[1, 0]).Within(1e-10));
			Assert.That(m[1, 0], Is.EqualTo(t[0, 1]).Within(1e-10));
			Assert.That(m[1, 1], Is.EqualTo(t[1, 1]).Within(1e-10));
		}

		[Test]
		public void Matrix2x2d_Transpose()
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
		public void Matrix2x2d_Determinant()
		{
			Assert.AreEqual(1.0, Matrix2x2d.Identity.Determinant);
		}

		[Test]
		public void Matrix2x2d_Inverse()
		{
			Matrix2x2d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix2x2d().Inverse);

			Matrix2x2d m = CreateInvertibleMatrix();
			Matrix2x2d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix2x2d.Identity, 1e-2));
		}

		[Test]
		public void Matrix2x2d_Invert()
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
		public void Matrix2x2d_AbsoluteEqualsToMatrix2x2d()
		{
			Matrix2x2d m = new Matrix2x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x2d.Zero, 0.50));
			m[1, 1] = 0.0;
		}

		[Test]
		public void Matrix2x2d_EqualsToMatrix2x2d()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2d_EqualsToObject()
		{
			Matrix2x2d m1 = CreateRandomMatrix();
			Matrix2x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x2d_GetHashCode()
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
		public void Matrix2x2d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix2x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x3d_Constructor1()
		{
			Matrix2x3d m = new Matrix2x3d(
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x3d_Constructor2()
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
		public void Matrix2x3d_Constructor3()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = new Matrix2x3d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x3d_Columns()
		{
			Matrix2x3d m = CreateRandomMatrix();

			Vertex3d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

		}

		[Test]
		public void Matrix2x3d_Rows()
		{
			Matrix2x3d m = CreateRandomMatrix();

			Vertex2d r0 = m.Row0;
			Vertex2d r1 = m.Row1;
			Vertex2d r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x3d_Accessor()
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
		public void Matrix2x3d_MultiplyScalar()
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
		public void Matrix2x3d_CastToArray()
		{
			Matrix2x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x3d_CastToMatrix2x3f()
		{
			Matrix2x3d m = CreateSequenceMatrix();
			Matrix2x3f mOther = (Matrix2x3f)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x3d_EqualityOperator()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x3d_InequalityOperator()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix2x3d_Transposed()
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
		public void Matrix2x3d_AbsoluteEqualsToMatrix2x3d()
		{
			Matrix2x3d m = new Matrix2x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x3d.Zero, 0.50));
			m[1, 2] = 0.0;
		}

		[Test]
		public void Matrix2x3d_EqualsToMatrix2x3d()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3d_EqualsToObject()
		{
			Matrix2x3d m1 = CreateRandomMatrix();
			Matrix2x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x3d_GetHashCode()
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
		public void Matrix2x3d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix2x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix2x4d_Constructor1()
		{
			Matrix2x4d m = new Matrix2x4d(
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			);

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(m[c, r], Is.EqualTo(idx).Within(1e-10));
		}

		[Test]
		public void Matrix2x4d_Constructor2()
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
		public void Matrix2x4d_Constructor3()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = new Matrix2x4d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix2x4d_Columns()
		{
			Matrix2x4d m = CreateRandomMatrix();

			Vertex4d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

		}

		[Test]
		public void Matrix2x4d_Rows()
		{
			Matrix2x4d m = CreateRandomMatrix();

			Vertex2d r0 = m.Row0;
			Vertex2d r1 = m.Row1;
			Vertex2d r2 = m.Row2;
			Vertex2d r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix2x4d_Accessor()
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
		public void Matrix2x4d_MultiplyScalar()
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
		public void Matrix2x4d_CastToArray()
		{
			Matrix2x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix2x4d_CastToMatrix2x4f()
		{
			Matrix2x4d m = CreateSequenceMatrix();
			Matrix2x4f mOther = (Matrix2x4f)m;

			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix2x4d_EqualityOperator()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix2x4d_InequalityOperator()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix2x4d_Transposed()
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
		public void Matrix2x4d_AbsoluteEqualsToMatrix2x4d()
		{
			Matrix2x4d m = new Matrix2x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[0, 3] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 2] = 0.0;
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix2x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix2x4d.Zero, 0.50));
			m[1, 3] = 0.0;
		}

		[Test]
		public void Matrix2x4d_EqualsToMatrix2x4d()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4d_EqualsToObject()
		{
			Matrix2x4d m1 = CreateRandomMatrix();
			Matrix2x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix2x4d_GetHashCode()
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
		public void Matrix2x4d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x2d_Constructor1()
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
		public void Matrix3x2d_Constructor2()
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
		public void Matrix3x2d_Constructor3()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = new Matrix3x2d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x2d_Columns()
		{
			Matrix3x2d m = CreateRandomMatrix();

			Vertex2d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

			Vertex2d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);

		}

		[Test]
		public void Matrix3x2d_Rows()
		{
			Matrix3x2d m = CreateRandomMatrix();

			Vertex3d r0 = m.Row0;
			Vertex3d r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x2d_Accessor()
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
		public void Matrix3x2d_MultiplyScalar()
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
		public void Matrix3x2d_CastToArray()
		{
			Matrix3x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x2d_CastToMatrix3x2f()
		{
			Matrix3x2d m = CreateSequenceMatrix();
			Matrix3x2f mOther = (Matrix3x2f)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x2d_EqualityOperator()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x2d_InequalityOperator()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x2d_Transposed()
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
		public void Matrix3x2d_AbsoluteEqualsToMatrix3x2d()
		{
			Matrix3x2d m = new Matrix3x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x2d.Zero, 0.50));
			m[2, 1] = 0.0;
		}

		[Test]
		public void Matrix3x2d_EqualsToMatrix3x2d()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2d_EqualsToObject()
		{
			Matrix3x2d m1 = CreateRandomMatrix();
			Matrix3x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x2d_GetHashCode()
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
		public void Matrix3x2d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x3d_Constructor1()
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
		public void Matrix3x3d_Constructor2()
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
		public void Matrix3x3d_Constructor3()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = new Matrix3x3d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_Constructor4()
		{
			Matrix4x4d m = new Matrix4x4d();
			Matrix3x3d c;

			Assert.Throws<ArgumentOutOfRangeException>(() => c = new Matrix3x3d(m, 4, 3));
			Assert.Throws<ArgumentOutOfRangeException>(() => c = new Matrix3x3d(m, 3, 4));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x3d_Columns()
		{
			Matrix3x3d m = CreateRandomMatrix();

			Vertex3d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

			Vertex3d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);

		}

		[Test]
		public void Matrix3x3d_Rows()
		{
			Matrix3x3d m = CreateRandomMatrix();

			Vertex3d r0 = m.Row0;
			Vertex3d r1 = m.Row1;
			Vertex3d r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x3d_Accessor()
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
		public void Matrix3x3d_MultiplyScalar()
		{
			Matrix3x3d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_MultiplyVertex3d()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			Vertex3d v = Vertex3d.Zero;
			Vertex3d r = m * v;
		}

		[Test]
		public void Matrix3x3d_MultiplyMatrix3x3d()
		{
			Matrix3x3d m1 = CreateSequenceMatrix();
			Matrix3x3d m2 = CreateSequenceMatrix();
			Matrix3x3d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3d_CastToArray()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x3d_CastToMatrix3x3f()
		{
			Matrix3x3d m = CreateSequenceMatrix();
			Matrix3x3f mOther = (Matrix3x3f)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x3d_EqualityOperator()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x3d_InequalityOperator()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Rotation

		[Test]
		public void Matrix3x3d_RotatedX()
		{
			Matrix3x3d m = Matrix3x3d.RotatedX(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			Matrix3x3d r1 = Matrix3x3d.RotatedX(+90.0);
			Matrix3x3d r2 = Matrix3x3d.RotatedX(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3d.Identity, 1e-10));

			r1 = Matrix3x3d.RotatedX(+90.0);
			r2 = Matrix3x3d.RotatedX(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex3d v = Matrix3x3d.RotatedX(+90.0) * Vertex3d.UnitY;
			Assert.IsTrue(v.Equals(Vertex3d.UnitZ, 1e-10));
		}

		[Test]
		public void Matrix3x3d_RotateX()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			
			m.RotateX(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateX(+90.0);
			m.RotateX(-90.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateX(+180.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.RotatedX(+180.0), 1e-10));

			m = Matrix3x3d.Identity;
			m.RotateX(+90.0);
			Vertex3d v = m * Vertex3d.UnitY;
			Assert.IsTrue(v.Equals(Vertex3d.UnitZ, 1e-10));
		}

		[Test]
		public void Matrix3x3d_RotatedY()
		{
			Matrix3x3d m = Matrix3x3d.RotatedY(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			Matrix3x3d r1 = Matrix3x3d.RotatedY(+90.0);
			Matrix3x3d r2 = Matrix3x3d.RotatedY(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix3x3d.Identity, 1e-10));

			r1 = Matrix3x3d.RotatedY(+90.0);
			r2 = Matrix3x3d.RotatedY(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex3d v = Matrix3x3d.RotatedY(+90.0) * Vertex3d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3d.UnitX, 1e-10));
		}

		[Test]
		public void Matrix3x3d_RotateY()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			
			m.RotateY(0.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateY(+90.0);
			m.RotateY(-90.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.Identity, 1e-10));

			m.RotateY(+180.0);
			Assert.IsTrue(m.Equals(Matrix3x3d.RotatedY(+180.0), 1e-10));

			m = Matrix3x3d.Identity;
			m.RotateY(+90.0);
			Vertex3d v = m * Vertex3d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex3d.UnitX, 1e-10));
		}

		[Test]
		public void Matrix3x3d_RotatedZ()
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
		public void Matrix3x3d_RotateZ()
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
		public void Matrix3x3d_Scaled()
		{
			Matrix3x3d m = Matrix3x3d.Scaled(1.0f, 1.0f, 1.0f);
			Vertex3d v;
			
			v = m * Vertex3d.UnitX;
			Assert.IsTrue(Vertex3d.UnitX.Equals(v, 1e-10));

			v = m * Vertex3d.UnitY;
			Assert.IsTrue(Vertex3d.UnitY.Equals(v, 1e-10));

			v = m * Vertex3d.UnitZ;
			Assert.IsTrue(Vertex3d.UnitZ.Equals(v, 1e-10));

			m = Matrix3x3d.Scaled(0.5f, 2.0f, 3.0f);

			v = m * Vertex3d.UnitX;
			Assert.IsTrue((Vertex3d.UnitX * 0.5f).Equals(v, 1e-10));

			v = m * Vertex3d.UnitY;
			Assert.IsTrue((Vertex3d.UnitY * 2.0f).Equals(v, 1e-10));

			v = m * Vertex3d.UnitZ;
			Assert.IsTrue((Vertex3d.UnitZ * 3.0f).Equals(v, 1e-10));
		}

		[Test]
		public void Matrix3x3d_Scale()
		{
			Matrix3x3d m = Matrix3x3d.Identity;
			Vertex3d v;

			m.Scale(1.0f, 1.0f, 1.0f);

			v = m * Vertex3d.UnitX;
			Assert.IsTrue(Vertex3d.UnitX.Equals(v, 1e-10));

			v = m * Vertex3d.UnitY;
			Assert.IsTrue(Vertex3d.UnitY.Equals(v, 1e-10));

			v = m * Vertex3d.UnitZ;
			Assert.IsTrue(Vertex3d.UnitZ.Equals(v, 1e-10));

			m.Scale(0.5f, 2.0f, 3.0f);

			v = m * Vertex3d.UnitX;
			Assert.IsTrue((Vertex3d.UnitX * 0.5f).Equals(v, 1e-10));

			v = m * Vertex3d.UnitY;
			Assert.IsTrue((Vertex3d.UnitY * 2.0f).Equals(v, 1e-10));

			v = m * Vertex3d.UnitZ;
			Assert.IsTrue((Vertex3d.UnitZ * 3.0f).Equals(v, 1e-10));
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x3d_Transposed()
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
		public void Matrix3x3d_Transpose()
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
		public void Matrix3x3d_Determinant()
		{
			Assert.AreEqual(1.0, Matrix3x3d.Identity.Determinant);
		}

		[Test]
		public void Matrix3x3d_Inverse()
		{
			Matrix3x3d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix3x3d().Inverse);

			Matrix3x3d m = CreateInvertibleMatrix();
			Matrix3x3d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix3x3d.Identity, 1e-2));
		}

		[Test]
		public void Matrix3x3d_Invert()
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
		public void Matrix3x3d_AbsoluteEqualsToMatrix3x3d()
		{
			Matrix3x3d m = new Matrix3x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[1, 2] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 1] = 0.0;
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x3d.Zero, 0.50));
			m[2, 2] = 0.0;
		}

		[Test]
		public void Matrix3x3d_EqualsToMatrix3x3d()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3d_EqualsToObject()
		{
			Matrix3x3d m1 = CreateRandomMatrix();
			Matrix3x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x3d_GetHashCode()
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
		public void Matrix3x3d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix3x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix3x4d_Constructor1()
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
		public void Matrix3x4d_Constructor2()
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
		public void Matrix3x4d_Constructor3()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = new Matrix3x4d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix3x4d_Columns()
		{
			Matrix3x4d m = CreateRandomMatrix();

			Vertex4d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

			Vertex4d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);
			Assert.AreEqual(c2.w, m[2, 3]);

		}

		[Test]
		public void Matrix3x4d_Rows()
		{
			Matrix3x4d m = CreateRandomMatrix();

			Vertex3d r0 = m.Row0;
			Vertex3d r1 = m.Row1;
			Vertex3d r2 = m.Row2;
			Vertex3d r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix3x4d_Accessor()
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
		public void Matrix3x4d_MultiplyScalar()
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
		public void Matrix3x4d_CastToArray()
		{
			Matrix3x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix3x4d_CastToMatrix3x4f()
		{
			Matrix3x4d m = CreateSequenceMatrix();
			Matrix3x4f mOther = (Matrix3x4f)m;

			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix3x4d_EqualityOperator()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix3x4d_InequalityOperator()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix3x4d_Transposed()
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
		public void Matrix3x4d_AbsoluteEqualsToMatrix3x4d()
		{
			Matrix3x4d m = new Matrix3x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[0, 3] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 2] = 0.0;
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[1, 3] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 1] = 0.0;
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 2] = 0.0;
			m[2, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix3x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix3x4d.Zero, 0.50));
			m[2, 3] = 0.0;
		}

		[Test]
		public void Matrix3x4d_EqualsToMatrix3x4d()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4d_EqualsToObject()
		{
			Matrix3x4d m1 = CreateRandomMatrix();
			Matrix3x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix3x4d_GetHashCode()
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
		public void Matrix3x4d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x2dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x2d_Constructor1()
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
		public void Matrix4x2d_Constructor2()
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
		public void Matrix4x2d_Constructor3()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = new Matrix4x2d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x2d_Columns()
		{
			Matrix4x2d m = CreateRandomMatrix();

			Vertex2d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);

			Vertex2d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);

			Vertex2d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);

			Vertex2d c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);

		}

		[Test]
		public void Matrix4x2d_Rows()
		{
			Matrix4x2d m = CreateRandomMatrix();

			Vertex4d r0 = m.Row0;
			Vertex4d r1 = m.Row1;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x2d_Accessor()
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
		public void Matrix4x2d_MultiplyScalar()
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
		public void Matrix4x2d_CastToArray()
		{
			Matrix4x2d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x2d_CastToMatrix4x2f()
		{
			Matrix4x2d m = CreateSequenceMatrix();
			Matrix4x2f mOther = (Matrix4x2f)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x2d_EqualityOperator()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x2d_InequalityOperator()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x2d_Transposed()
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
		public void Matrix4x2d_AbsoluteEqualsToMatrix4x2d()
		{
			Matrix4x2d m = new Matrix4x2d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[2, 1] = 0.0;
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[3, 0] = 0.0;
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x2d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x2d.Zero, 0.50));
			m[3, 1] = 0.0;
		}

		[Test]
		public void Matrix4x2d_EqualsToMatrix4x2d()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2d_EqualsToObject()
		{
			Matrix4x2d m1 = CreateRandomMatrix();
			Matrix4x2d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x2d_GetHashCode()
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
		public void Matrix4x2d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x3dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x3d_Constructor1()
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
		public void Matrix4x3d_Constructor2()
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
		public void Matrix4x3d_Constructor3()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = new Matrix4x3d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x3d_Columns()
		{
			Matrix4x3d m = CreateRandomMatrix();

			Vertex3d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);

			Vertex3d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);

			Vertex3d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);

			Vertex3d c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);
			Assert.AreEqual(c3.z, m[3, 2]);

		}

		[Test]
		public void Matrix4x3d_Rows()
		{
			Matrix4x3d m = CreateRandomMatrix();

			Vertex4d r0 = m.Row0;
			Vertex4d r1 = m.Row1;
			Vertex4d r2 = m.Row2;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x3d_Accessor()
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
		public void Matrix4x3d_MultiplyScalar()
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
		public void Matrix4x3d_CastToArray()
		{
			Matrix4x3d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x3d_CastToMatrix4x3f()
		{
			Matrix4x3d m = CreateSequenceMatrix();
			Matrix4x3f mOther = (Matrix4x3f)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x3d_EqualityOperator()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x3d_InequalityOperator()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x3d_Transposed()
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
		public void Matrix4x3d_AbsoluteEqualsToMatrix4x3d()
		{
			Matrix4x3d m = new Matrix4x3d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[1, 2] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 1] = 0.0;
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[2, 2] = 0.0;
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 0] = 0.0;
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 1] = 0.0;
			m[3, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x3d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x3d.Zero, 0.50));
			m[3, 2] = 0.0;
		}

		[Test]
		public void Matrix4x3d_EqualsToMatrix4x3d()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3d_EqualsToObject()
		{
			Matrix4x3d m1 = CreateRandomMatrix();
			Matrix4x3d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x3d_GetHashCode()
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
		public void Matrix4x3d_ToString()
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

	[TestFixture, Category("Math")]
	internal class Matrix4x4dTest : TestBase
	{
		#region Constructors

		[Test]
		public void Matrix4x4d_Constructor1()
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
		public void Matrix4x4d_Constructor2()
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
		public void Matrix4x4d_Constructor3()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = new Matrix4x4d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Columns & Rows

		[Test]
		public void Matrix4x4d_Columns()
		{
			Matrix4x4d m = CreateRandomMatrix();

			Vertex4d c0 = m.Column0;
			Assert.AreEqual(c0.x, m[0, 0]);
			Assert.AreEqual(c0.y, m[0, 1]);
			Assert.AreEqual(c0.z, m[0, 2]);
			Assert.AreEqual(c0.w, m[0, 3]);

			Vertex4d c1 = m.Column1;
			Assert.AreEqual(c1.x, m[1, 0]);
			Assert.AreEqual(c1.y, m[1, 1]);
			Assert.AreEqual(c1.z, m[1, 2]);
			Assert.AreEqual(c1.w, m[1, 3]);

			Vertex4d c2 = m.Column2;
			Assert.AreEqual(c2.x, m[2, 0]);
			Assert.AreEqual(c2.y, m[2, 1]);
			Assert.AreEqual(c2.z, m[2, 2]);
			Assert.AreEqual(c2.w, m[2, 3]);

			Vertex4d c3 = m.Column3;
			Assert.AreEqual(c3.x, m[3, 0]);
			Assert.AreEqual(c3.y, m[3, 1]);
			Assert.AreEqual(c3.z, m[3, 2]);
			Assert.AreEqual(c3.w, m[3, 3]);

		}

		[Test]
		public void Matrix4x4d_Rows()
		{
			Matrix4x4d m = CreateRandomMatrix();

			Vertex4d r0 = m.Row0;
			Vertex4d r1 = m.Row1;
			Vertex4d r2 = m.Row2;
			Vertex4d r3 = m.Row3;
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x4d_Accessor()
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
		public void Matrix4x4d_MultiplyScalar()
		{
			Matrix4x4d m = CreateSequenceMatrix();

			m = m * 2.0;

			double idx = 0.0f;
			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx += 1.0)
				Assert.That(idx * 2.0, Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_MultiplyVertex4d()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			Vertex4d v = Vertex4d.Zero;
			Vertex4d r = m * v;
		}

		[Test]
		public void Matrix4x4d_MultiplyMatrix4x4d()
		{
			Matrix4x4d m1 = CreateSequenceMatrix();
			Matrix4x4d m2 = CreateSequenceMatrix();
			Matrix4x4d r = m1 * m2;
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4d_CastToArray()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		[Test]
		public void Matrix4x4d_CastToMatrix4x4f()
		{
			Matrix4x4d m = CreateSequenceMatrix();
			Matrix4x4f mOther = (Matrix4x4f)m;

			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mOther[c, r], Is.EqualTo(m[c, r]).Within(1e-6));
		}

		#endregion

		#region Equality Operators

		[Test]
		public void Matrix4x4d_EqualityOperator()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsTrue(m1 == m2);
		}

		[Test]
		public void Matrix4x4d_InequalityOperator()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsFalse(m1 != m2);
		}

		#endregion

		#region Projections

		[Test]
		public void Matrix4x4d_Ortho()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Ortho(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_Ortho2D()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho2D(0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Ortho2D(-1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Ortho2D(-1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_Frustrum()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(0.0f, 0.0f, -1.0f, +1.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, 0.0f, 0.0f, -1.0f, +1.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, 0.0f, 0.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Frustrum(-1.0f, +1.0f, -1.0f, +1.0f, -1.0f, +1.0f));
		}

		[Test]
		public void Matrix4x4d_PerspectiveSymmetric()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(-1.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+180.0f, 1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 0.0f, 1000.0f));
			Assert.Throws<ArgumentOutOfRangeException>(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Perspective(+1.0f, 1.0f, 1.0f, 10.0f));
		}

		[Test]
		public void Matrix4x4d_PerspectiveAsymmetric()
		{
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(0.0f, 0.0f, -1.0f, +1.0f, 0.1f, 1000.0f));
			Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(-1.0f, +1.0f, 0.0f, 0.0f, 0.1f, 1000.0f));
			// Assert.Throws<ArgumentException>(() => Matrix4x4d.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 10.0f, 1.0f));

			Assert.DoesNotThrow(() => Matrix4x4d.Perspective(-1.0f, +1.0f, -1.0f, +1.0f, 1.0f, 10.0f));
		}

		#endregion

		#region View Model

		[Test]
		public void Matrix4x4d_Position()
		{
			Matrix4x4d m = Matrix4x4d.Identity;

			Assert.AreEqual(Vertex3d.Zero, m.Position);
			
			m.Translate(1.0f, 0.0f, 0.0f);
			Assert.AreEqual(Vertex3d.UnitX, m.Position);

			m.Translate(0.0f, 1.0f, 0.0f);
			Assert.AreEqual(Vertex3d.UnitX + Vertex3d.UnitY, m.Position);

			m.Translate(0.0f, 0.0f, 1.0f);
			Assert.AreEqual(Vertex3d.UnitX + Vertex3d.UnitY + Vertex3d.UnitZ, m.Position);
		}

		[Test]
		public void Matrix4x4d_ForwardVector()
		{
			Matrix4x4d m = Matrix4x4d.Identity;

			Assert.AreEqual(-Vertex3d.UnitZ, m.ForwardVector);

			m.RotateY(-90.0f);
			Assert.IsTrue(Vertex3d.UnitX.Equals(m.ForwardVector, 1e-10));
		}

		[Test]
		public void Matrix4x4d_RightVector()
		{
			Matrix4x4d m = Matrix4x4d.Identity;

			Assert.AreEqual(Vertex3d.UnitX, m.RightVector);

			m.RotateY(-90.0f);
			Assert.IsTrue(Vertex3d.UnitZ.Equals(m.RightVector, 1e-10));
		}

		[Test]
		public void Matrix4x4d_UpVector()
		{
			Matrix4x4d m = Matrix4x4d.Identity;

			Assert.AreEqual(Vertex3d.UnitY, m.UpVector);

			m.RotateX(+90.0f);
			Assert.IsTrue(Vertex3d.UnitZ.Equals(m.UpVector, 1e-10));
		}

		[Test]
		public void Matrix4x4d_LookAt()
		{
			Matrix4x4d m = Matrix4x4d.LookAt(Vertex3d.UnitZ, Vertex3d.Zero, Vertex3d.UnitY);
			Assert.AreEqual(-Vertex3d.UnitZ, m.ForwardVector);
			Assert.AreEqual(Vertex3d.UnitY, m.UpVector);
			Assert.AreEqual(Vertex3d.UnitX, m.RightVector);
		}

		[Test]
		public void Matrix4x4d_LookAtDirection()
		{
			Matrix4x4d m = Matrix4x4d.LookAtDirection(Vertex3d.Zero, -Vertex3d.UnitZ, Vertex3d.UnitY);
			Assert.AreEqual(-Vertex3d.UnitZ, m.ForwardVector);
			Assert.AreEqual(Vertex3d.UnitY, m.UpVector);
			Assert.AreEqual(Vertex3d.UnitX, m.RightVector);

			m = Matrix4x4d.LookAtDirection(Vertex3d.Zero, Vertex3d.UnitY, Vertex3d.UnitY).Inverse;
			Assert.AreEqual(Vertex3d.UnitY, m.ForwardVector);
			Assert.AreEqual(Vertex3d.UnitZ, m.UpVector);
			Assert.AreEqual(Vertex3d.UnitX, m.RightVector);
		}

		#endregion

		#region Translation

		[Test]
		public void Matrix4x4d_Translated()
		{
			Matrix4x4d m = Matrix4x4d.Translated(0.0, 1.0, 2.0);
			Vertex3d v = new Vertex3d(0.0, 1.0, 2.0);

			Assert.AreEqual(v, m.Position);
			Assert.IsTrue(v.Equals((Vertex3d)(m * Vertex4d.Zero), 1e-10));
		}

		[Test]
		public void Matrix4x4d_Translate()
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
		public void Matrix4x4d_RotatedX()
		{
			Matrix4x4d m = Matrix4x4d.RotatedX(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			Matrix4x4d r1 = Matrix4x4d.RotatedX(+90.0);
			Matrix4x4d r2 = Matrix4x4d.RotatedX(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4d.Identity, 1e-10));

			r1 = Matrix4x4d.RotatedX(+90.0);
			r2 = Matrix4x4d.RotatedX(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex4d v = Matrix4x4d.RotatedX(+90.0) * Vertex4d.UnitY;
			Assert.IsTrue(v.Equals(Vertex4d.UnitZ, 1e-10));
		}

		[Test]
		public void Matrix4x4d_RotateX()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			
			m.RotateX(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateX(+90.0);
			m.RotateX(-90.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateX(+180.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.RotatedX(+180.0), 1e-10));

			m = Matrix4x4d.Identity;
			m.RotateX(+90.0);
			Vertex4d v = m * Vertex4d.UnitY;
			Assert.IsTrue(v.Equals(Vertex4d.UnitZ, 1e-10));
		}

		[Test]
		public void Matrix4x4d_RotatedY()
		{
			Matrix4x4d m = Matrix4x4d.RotatedY(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			Matrix4x4d r1 = Matrix4x4d.RotatedY(+90.0);
			Matrix4x4d r2 = Matrix4x4d.RotatedY(-90.0);
			Assert.IsTrue((r1 * r2).Equals(Matrix4x4d.Identity, 1e-10));

			r1 = Matrix4x4d.RotatedY(+90.0);
			r2 = Matrix4x4d.RotatedY(+180.0);
			Assert.IsTrue((r1 * r1).Equals(r2, 1e-10));

			Vertex4d v = Matrix4x4d.RotatedY(+90.0) * Vertex4d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4d.UnitX, 1e-10));
		}

		[Test]
		public void Matrix4x4d_RotateY()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			
			m.RotateY(0.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateY(+90.0);
			m.RotateY(-90.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.Identity, 1e-10));

			m.RotateY(+180.0);
			Assert.IsTrue(m.Equals(Matrix4x4d.RotatedY(+180.0), 1e-10));

			m = Matrix4x4d.Identity;
			m.RotateY(+90.0);
			Vertex4d v = m * Vertex4d.UnitZ;
			Assert.IsTrue(v.Equals(Vertex4d.UnitX, 1e-10));
		}

		[Test]
		public void Matrix4x4d_RotatedZ()
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
		public void Matrix4x4d_RotateZ()
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
		public void Matrix4x4d_Scaled()
		{
			Matrix4x4d m = Matrix4x4d.Scaled(1.0f, 1.0f, 1.0f);
			Vertex4d v;
			
			v = m * Vertex4d.UnitX;
			Assert.IsTrue(Vertex4d.UnitX.Equals(v, 1e-10));

			v = m * Vertex4d.UnitY;
			Assert.IsTrue(Vertex4d.UnitY.Equals(v, 1e-10));

			v = m * Vertex4d.UnitZ;
			Assert.IsTrue(Vertex4d.UnitZ.Equals(v, 1e-10));

			m = Matrix4x4d.Scaled(0.5f, 2.0f, 3.0f);

			v = m * Vertex4d.UnitX;
			Assert.IsTrue((Vertex4d.UnitX * 0.5f).Equals(v, 1e-10));

			v = m * Vertex4d.UnitY;
			Assert.IsTrue((Vertex4d.UnitY * 2.0f).Equals(v, 1e-10));

			v = m * Vertex4d.UnitZ;
			Assert.IsTrue((Vertex4d.UnitZ * 3.0f).Equals(v, 1e-10));
		}

		[Test]
		public void Matrix4x4d_Scale()
		{
			Matrix4x4d m = Matrix4x4d.Identity;
			Vertex4d v;

			m.Scale(1.0f, 1.0f, 1.0f);

			v = m * Vertex4d.UnitX;
			Assert.IsTrue(Vertex4d.UnitX.Equals(v, 1e-10));

			v = m * Vertex4d.UnitY;
			Assert.IsTrue(Vertex4d.UnitY.Equals(v, 1e-10));

			v = m * Vertex4d.UnitZ;
			Assert.IsTrue(Vertex4d.UnitZ.Equals(v, 1e-10));

			m.Scale(0.5f, 2.0f, 3.0f);

			v = m * Vertex4d.UnitX;
			Assert.IsTrue((Vertex4d.UnitX * 0.5f).Equals(v, 1e-10));

			v = m * Vertex4d.UnitY;
			Assert.IsTrue((Vertex4d.UnitY * 2.0f).Equals(v, 1e-10));

			v = m * Vertex4d.UnitZ;
			Assert.IsTrue((Vertex4d.UnitZ * 3.0f).Equals(v, 1e-10));
		}

		#endregion

		#region Transposition

		[Test]
		public void Matrix4x4d_Transposed()
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
		public void Matrix4x4d_Transpose()
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
		public void Matrix4x4d_Determinant()
		{
			Assert.AreEqual(1.0, Matrix4x4d.Identity.Determinant);
		}

		[Test]
		public void Matrix4x4d_Inverse()
		{
			Matrix4x4d r;

			Assert.Throws<InvalidOperationException>(() => r = new Matrix4x4d().Inverse);

			Matrix4x4d m = CreateInvertibleMatrix();
			Matrix4x4d n = m.Inverse;
			
			r = m * n;

			Assert.IsTrue(r.Equals(Matrix4x4d.Identity, 1e-2));
		}

		[Test]
		public void Matrix4x4d_Invert()
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
		public void Matrix4x4d_AbsoluteEqualsToMatrix4x4d()
		{
			Matrix4x4d m = new Matrix4x4d();

			m[0, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 0] = 0.0;
			m[0, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 1] = 0.0;
			m[0, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 2] = 0.0;
			m[0, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[0, 3] = 0.0;
			m[1, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 0] = 0.0;
			m[1, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 1] = 0.0;
			m[1, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 2] = 0.0;
			m[1, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[1, 3] = 0.0;
			m[2, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 0] = 0.0;
			m[2, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 1] = 0.0;
			m[2, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 2] = 0.0;
			m[2, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[2, 3] = 0.0;
			m[3, 0] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 0] = 0.0;
			m[3, 1] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 1] = 0.0;
			m[3, 2] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 2] = 0.0;
			m[3, 3] = 0.5;
			Assert.IsFalse(m.Equals(Matrix4x4d.Zero, 0.25));
			Assert.IsTrue(m.Equals(Matrix4x4d.Zero, 0.50));
			m[3, 3] = 0.0;
		}

		[Test]
		public void Matrix4x4d_EqualsToMatrix4x4d()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsTrue(m1.Equals(m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4d_EqualsToObject()
		{
			Matrix4x4d m1 = CreateRandomMatrix();
			Matrix4x4d m2 = m1;

			Assert.IsFalse(m1.Equals(null));
			Assert.IsFalse(m1.Equals((object)false));
			Assert.IsTrue(m1.Equals((object)m2));
			Assert.AreEqual(m1, m2);
		}

		[Test]
		public void Matrix4x4d_GetHashCode()
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
		public void Matrix4x4d_ToString()
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