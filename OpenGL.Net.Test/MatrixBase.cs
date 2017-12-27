
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
	internal class MatrixBaseTest
	{
		private Matrix CreateRandomMatrix(uint w, uint h)
		{
			return CreateRandomMatrix(new Random(), w, h);
		}

		private Matrix CreateRandomMatrix(Random random, uint w, uint h)
		{
			float[] components = new float[w * h];

			for (int i = 0; i < components.Length; i++)
				components[i] = (float)random.NextDouble();

			return new Matrix(w, h, components);
		}

		#region Constructors

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void Matrix_Constructor1(uint w, uint h)
		{
			Matrix m = new Matrix(w, h);

			Assert.AreEqual(w, m.Width);
			Assert.AreEqual(h, m.Height);

			for (uint c = 0; c < w; c++)
				for (uint r = 0; r < h; r++)
					Assert.AreEqual(0.0f, m[c, r]);
		}

		[Test]
		public void Matrix_Constructor1_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentException>(() => m = new Matrix(0, 2));
			Assert.Throws<ArgumentException>(() => m = new Matrix(2, 0));
		}

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void Matrix_Constructor2(uint w, uint h)
		{
			Random random = new Random();
			float[] components = new float[w * h];
			for (int i = 0; i < components.Length; i++)
				components[i] = (float)random.NextDouble();

			Matrix m = new Matrix(w, h, components);

			Assert.AreEqual(w, m.Width);
			Assert.AreEqual(h, m.Height);

			for (uint c = 0; c < w; c++)
				for (uint r = 0; r < h; r++)
					Assert.AreEqual(components[c * h + r], m[c, r]);
		}

		[Test]
		public void Matrix_Constructor2_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentException>(() => m = new Matrix(0, 2, null));
			Assert.Throws<ArgumentException>(() => m = new Matrix(2, 0, null));
			Assert.Throws<ArgumentNullException>(() => m = new Matrix(2, 2, null));
			Assert.Throws<ArgumentException>(() => m = new Matrix(2, 2, 1.0f, 2.0f, 3.0f));
			Assert.DoesNotThrow(() => m = new Matrix(2, 2, 1.0f, 2.0f, 3.0f, 4.0f, 5.0f));
		}

		[Test]
		public void Matrix_Constructor3()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			AssertComplement(m, 0, 0);
			AssertComplement(m, 1, 2);
			AssertComplement(m, 2, 1);
		}

		private void AssertComplement(Matrix m, uint c, uint r)
		{
			Matrix cm = new Matrix(m, c, r);

			Assert.AreEqual(m.Width - 1, cm.Width);
			Assert.AreEqual(m.Height - 1, cm.Height);

			for (uint ic = 0; ic < cm.Width; ic++)
			for (uint ir = 0; ir < cm.Height; ir++)
			{
				uint cx = ic < c ? ic : ic + 1;
				uint cy = ir < r ? ir : ir + 1;
					
				Assert.AreEqual(m[cx, cy], cm[ic, ir]);
			}
		}

		[Test]
		public void Matrix_Constructor3_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix(null, 0, 0));
			Assert.Throws<ArgumentException>(() => m = new Matrix(new Matrix(1, 1), 0, 0));
			Assert.Throws<ArgumentOutOfRangeException>(() => m = new Matrix(new Matrix(2, 2), 2, 0));
			Assert.Throws<ArgumentOutOfRangeException>(() => m = new Matrix(new Matrix(2, 2), 0, 2));
		}

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void Matrix_Constructor4(uint w, uint h)
		{
			Matrix m = CreateRandomMatrix(w, h);
			Matrix cm = new Matrix(m);

			Assert.AreEqual(m.Width, cm.Width);
			Assert.AreEqual(m.Height, cm.Height);
			for (uint c = 0; c < w; c++)
				for (uint r = 0; r < h; r++)
					Assert.AreEqual(m[c, r], cm[c, r]);
		}

		[Test]
		public void Matrix_Constructor4_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix(null));
		}

		[Test]
		public void Matrix_Constructor5()
		{
			// TODO
		}

		[Test]
		public void Matrix_Constructor5_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix((IMatrix)null));
		}

		#endregion

		#region Buffer

		[Test]
		public void Matrix_Buffer()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m = CreateRandomMatrix(2, 2);
			float[] buffer = m.Buffer;

			Assert.IsNotNull(buffer);
			Assert.AreNotSame(m.Buffer, buffer);
			Assert.AreEqual(buffer[0], m[0, 0]);
			Assert.AreEqual(buffer[0], m.Buffer[0]);

			Assert.AreNotEqual(float.NaN, buffer[0]);
			buffer[0] = float.NaN;
			Assert.AreNotEqual(buffer[0], m[0, 0]);
			Assert.AreNotEqual(buffer[0], m.Buffer[0]);
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix_Accessor()
		{
			Matrix m = CreateRandomMatrix(2, 2);
			float[] buffer = m.Buffer;

			for (uint c = 0, i = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++, i++)
					Assert.AreEqual(m[c, r], buffer[i]);

			for (uint c = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++)
				{
					m[c, r] = float.NaN;
					Assert.AreEqual(float.NaN, m[c, r]);
				}
		}

		[Test]
		public void Matrix_Accessor_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 2);
			// ReSharper disable once NotAccessedVariable
			float c;

			Assert.Throws<ArgumentException>(() => c = m[2, 0]);
			Assert.Throws<ArgumentException>(() => c = m[0, 2]);
			Assert.Throws<ArgumentException>(() => m[2, 0] = float.NaN);
			Assert.Throws<ArgumentException>(() => m[0, 2] = float.NaN);
		}

		[Test]
		public void Matrix_OperatorAdd()
		{
			Matrix m = new Matrix(2, 2, +1.0f, -0.5f, +2.0f, -1.5f);
			Matrix n = new Matrix(2, 2, -1.0f, +0.5f, -2.0f, +1.5f);
			Matrix o = m + n;

			for (uint c = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++)
					Assert.AreEqual(0.0f, o[c, r]);
		}

		[Test]
		public void Matrix_OperatorAdd_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m = CreateRandomMatrix(2, 2), r;

			Assert.Throws<ArgumentNullException>(() => r = m + null);
			Assert.Throws<ArgumentNullException>(() => r = null + m);
			Assert.Throws<ArgumentException>(() => r = m + new Matrix(1, 2));
			Assert.Throws<ArgumentException>(() => r = m + new Matrix(2, 1));
		}

		[Test]
		public void Matrix_OperatorMulScalar()
		{
			Matrix m = new Matrix(2, 2, 1.0f, 1.0f, 1.0f, 1.0f);
			Matrix m05 = m * 0.5f;
			Matrix m20 = m * 2.0f;

			Assert.AreEqual(m.Width, m05.Width);
			Assert.AreEqual(m.Width, m20.Width);

			Assert.AreEqual(m.Height, m05.Height);
			Assert.AreEqual(m.Height, m20.Height);

			for (uint c = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++)
				{
					Assert.AreEqual(0.5f, m05[c, r]);
					Assert.AreEqual(2.0f, m20[c, r]);
				}
		}

		[Test]
		public void Matrix_OperatorMulScalar_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix r;

			Assert.Throws<ArgumentNullException>(() => r = (Matrix)null * 0.5f);
		}

		[Test]
		public void Matrix_OperatorDiv()
		{
			Matrix m = new Matrix(2, 2, 1.0f, 1.0f, 1.0f, 1.0f);
			Matrix m05 = m / 0.5f;
			Matrix m20 = m / 2.0f;

			Assert.AreEqual(m.Width, m05.Width);
			Assert.AreEqual(m.Width, m20.Width);

			Assert.AreEqual(m.Height, m05.Height);
			Assert.AreEqual(m.Height, m20.Height);

			for (uint c = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++)
				{
					Assert.AreEqual(2.0f, m05[c, r]);
					Assert.AreEqual(0.5f, m20[c, r]);
				}
		}

		[Test]
		public void Matrix_OperatorDiv_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix r;

			Assert.Throws<ArgumentNullException>(() => r = (Matrix)null / 0.5f);
		}

		[Test]
		public void Matrix_OperatorMulMatrix()
		{

		}

		[Test]
		public void Matrix_OperatorMulMatrix_Exceptions()
		{
			
		}

		#endregion

		#region Matrix Functions

		[Test]
		public virtual void Matrix_Set()
		{
			Matrix m = CreateRandomMatrix(2, 3);
			Matrix z = new Matrix(2, 3);

			m.Set(z);

			for (uint c = 0; c < 2; c++)
				for (uint r = 0; r < 2; r++)
					Assert.AreEqual(0.0f, m[c, r]);

			m = CreateRandomMatrix(2, 3);
			m.Set((IMatrix)z);

			for (uint c = 0; c < 2; c++)
				for (uint r = 0; r < 2; r++)
					Assert.AreEqual(0.0f, m[c, r]);
		}

		[Test]
		public virtual void Matrix_Set_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 3);

			Assert.Throws<ArgumentNullException>(() => m.Set(null));
			Assert.Throws<ArgumentNullException>(() => m.Set((IMatrix)null));

			Assert.Throws<ArgumentException>(() => m.Set(new Matrix(3, 3)));
			Assert.Throws<ArgumentException>(() => m.Set((IMatrix)new Matrix(3, 3)));

			Assert.Throws<ArgumentException>(() => m.Set(new Matrix(2, 2)));
			Assert.Throws<ArgumentException>(() => m.Set((IMatrix)new Matrix(2, 2)));
		}

		[Test]
		public void Matrix_SetVoid()
		{
			Matrix m = CreateRandomMatrix(2, 3);

			m.SetVoid();

			for (uint c = 0; c < 2; c++)
				for (uint r = 0; r < 2; r++)
					Assert.AreEqual(0.0f, m[c, r]);
		}

		[Test]
		public void Matrix_SetIdentity()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			Assert.IsFalse(m.IsIdentity());

			m.SetIdentity();
			Assert.IsTrue(m.IsIdentity());
		}

		[Test]
		public void Matrix_Transpose()
		{
			Matrix m = CreateRandomMatrix(2, 3);
			Matrix t = m.Transpose();

			Assert.AreEqual(m.Width, t.Height);
			Assert.AreEqual(m.Height, t.Width);
		}

		[Test]
		public void Matrix_Clone()
		{
			Matrix m = CreateRandomMatrix(2, 2);
			Matrix c = null;

			Assert.DoesNotThrow(() => c = m.Clone());
			Assert.AreNotSame(m, c);
			Assert.AreEqual(m.GetType(), c.GetType(), "Clone() mast return the same matrix type");
		}

		[Test]
		public void Matrix_GetColumn()
		{
			Matrix m = CreateRandomMatrix(2, 2);
			float[] c;

			c = m.GetColumn(0);
			Assert.IsNotNull(c);
			Assert.AreEqual(2, c.Length);

			c = m.GetColumn(1);
			Assert.IsNotNull(c);
			Assert.AreEqual(2, c.Length);
		}

		[Test]
		public void Matrix_GetColumn_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 2);

			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetColumn(2));
		}

		[Test]
		public void Matrix_GetRow()
		{
			Matrix m = CreateRandomMatrix(2, 2);
			float[] c;

			c = m.GetRow(0);
			Assert.IsNotNull(c);
			Assert.AreEqual(2, c.Length);

			c = m.GetRow(1);
			Assert.IsNotNull(c);
			Assert.AreEqual(2, c.Length);
		}

		[Test]
		public void Matrix_GetRow_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 2);

			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetRow(2));
		}

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void Matrix_ToArray(uint w, uint h)
		{
			Matrix m = CreateRandomMatrix(w, h);
			float[] mArray = m.ToArray();

			Assert.IsNotNull(mArray);
			Assert.AreEqual(w * h, (uint)mArray.Length);
			Assert.AreNotSame(m.ToArray(), mArray);
			CollectionAssert.AreEqual(m.Buffer, mArray);
		}

		#endregion

		#region Square Matrix Functions

		[Test]
		public void Matrix_IsSquare()
		{
			Assert.IsTrue(new Matrix(2, 2).IsSquare);
			Assert.IsFalse(new Matrix(2, 3).IsSquare);
		}

		[Test]
		public void Matrix_IsIdentity()
		{
			Matrix m = new Matrix(5, 5);
			Assert.IsFalse(m.IsIdentity());

			m.SetIdentity();
			Assert.IsTrue(m.IsIdentity());

			const float epsilon = 0.1f;

			m[0, 0] = 1.0f - epsilon / 2.0f;
			Assert.IsFalse(m.IsIdentity());
			Assert.IsTrue(m.IsIdentity(epsilon));
			Assert.IsTrue(m.IsIdentity((double)epsilon));

			m.SetIdentity();
			Matrix inv = m.GetInverseMatrix();
			Assert.IsTrue(inv.IsIdentity());
		}

		[Test]
		public void Matrix_GetDeterminant()
		{
			Assert.AreNotEqual(0.0f, CreateRandomMatrix(2, 2).GetDeterminant());
			Assert.AreNotEqual(0.0f, CreateRandomMatrix(3, 3).GetDeterminant());
			Assert.AreNotEqual(0.0f, CreateRandomMatrix(4, 4).GetDeterminant());
			Assert.AreNotEqual(0.0f, CreateRandomMatrix(1, 1).GetDeterminant());
			Assert.AreEqual(0.0f, new Matrix(4, 4).GetDeterminant());
		}

		[Test]
		public void Matrix_GetDeterminant_Exceptions()
		{
			Assert.Throws<InvalidOperationException>(() => new Matrix(2, 3).GetInverseMatrix());
			Assert.Throws<InvalidOperationException>(() => new Matrix(3, 2).GetInverseMatrix());
		}

		[Test, TestCase(4u), TestCase(3u), TestCase(2u), TestCase(1u)]
		public void Matrix_GetInverseMatrix(uint size)
		{
			Matrix m = CreateRandomMatrix(size, size);
			Matrix i = m.GetInverseMatrix();

			Assert.AreEqual(m.Width, i.Width);
			Assert.AreEqual(m.Height, i.Height);

			Matrix r = m * i;

			Assert.IsTrue(r.IsIdentity(1e-4));
		}

		[Test]
		public void Matrix_GetInverseMatrix_Exceptions()
		{
			// Non-square
			Assert.Throws<InvalidOperationException>(() => new Matrix(2, 3).GetInverseMatrix());
			// Singular
			Assert.Throws<InvalidOperationException>(() => new Matrix(3, 3).GetInverseMatrix());
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix_ToString()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
			Assert.DoesNotThrow(() => m.ToString());
		}

		#endregion

		#region IEquatable<Matrix> Implementation

		[Test]
		public void Matrix_EqualsMatrix()
		{
			Matrix m = CreateRandomMatrix(3, 3);
			m[0, 0] = 0.0f;

			Assert.IsTrue(m.Equals(m));
			Assert.IsFalse(m.Equals(null));
			Assert.IsFalse(m.Equals(new Matrix(3, 2)));
			Assert.IsFalse(m.Equals(new Matrix(2, 2)));

			Matrix c = m.Clone();

			Assert.IsTrue(m.Equals(c));

			c[0, 0] = 1e-5f;
			Assert.IsFalse(m.Equals(c));
		}

		[Test]
		public void Matrix_EqualsObject()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			Assert.IsTrue(m.Equals((object)m));
			Assert.IsFalse(m.Equals((object)null));
			// ReSharper disable once SuspiciousTypeConversion.Global
			Assert.IsFalse(m.Equals(1.0f));
		}

		[Test]
		public void Matrix_GetHashCode()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
			Assert.DoesNotThrow(() => m.GetHashCode());

			Matrix c = m.Clone();
			Assert.AreNotEqual(m.GetHashCode(), c.GetHashCode());
		}

		#endregion
	}
}
