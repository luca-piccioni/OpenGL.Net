
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
		private static Matrix CreateRandomMatrix(uint w, uint h)
		{
			return CreateRandomMatrix(new Random(), w, h);
		}

		private static Matrix CreateRandomMatrix(Random random, uint w, uint h)
		{
			float[] components = new float[w * h];

			for (int i = 0; i < components.Length; i++)
				components[i] = (float)random.NextDouble();

			return new Matrix(w, h, components);
		}

		#region Constructors

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void MatrixBase_Constructor1(uint w, uint h)
		{
			Matrix m = new Matrix(w, h);

			Assert.AreEqual(w, m.Width);
			Assert.AreEqual(h, m.Height);

			for (uint c = 0; c < w; c++)
				for (uint r = 0; r < h; r++)
					Assert.AreEqual(0.0f, m[c, r]);
		}

		[Test]
		public void MatrixBase_Constructor1_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentException>(() => m = new Matrix(0, 2));
			Assert.Throws<ArgumentException>(() => m = new Matrix(2, 0));
		}

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void MatrixBase_Constructor2(uint w, uint h)
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
		public void MatrixBase_Constructor2_Exceptions()
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
		public void MatrixBase_Constructor3()
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
		public void MatrixBase_Constructor3_Exceptions()
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
		public void MatrixBase_Constructor4(uint w, uint h)
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
		public void MatrixBase_Constructor4_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix(null));
		}

		[Test]
		public void MatrixBase_Constructor5()
		{
			// TODO
		}

		[Test]
		public void MatrixBase_Constructor5_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix((IMatrix)null));
		}

		#endregion

		#region Buffer

		[Test]
		public void MatrixBase_Buffer()
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
		public void MatrixBase_Accessor()
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
		public void MatrixBase_Accessor_Exceptions()
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
		public void MatrixBase_OperatorAdd()
		{
			Matrix m = new Matrix(2, 2, +1.0f, -0.5f, +2.0f, -1.5f);
			Matrix n = new Matrix(2, 2, -1.0f, +0.5f, -2.0f, +1.5f);
			Matrix o = m + n;

			for (uint c = 0; c < m.Width; c++)
				for (uint r = 0; r < m.Height; r++)
					Assert.AreEqual(0.0f, o[c, r]);
		}

		[Test]
		public void MatrixBase_OperatorAdd_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix m = CreateRandomMatrix(2, 2), r;

			Assert.Throws<ArgumentNullException>(() => r = m + null);
			Assert.Throws<ArgumentNullException>(() => r = null + m);
			Assert.Throws<ArgumentException>(() => r = m + new Matrix(1, 2));
			Assert.Throws<ArgumentException>(() => r = m + new Matrix(2, 1));
		}

		[Test]
		public void MatrixBase_OperatorMulScalar()
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
		public void MatrixBase_OperatorMulScalar_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix r;

			Assert.Throws<ArgumentNullException>(() => r = (Matrix)null * 0.5f);
		}

		[Test]
		public void MatrixBase_OperatorDiv()
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
		public void MatrixBase_OperatorDiv_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix r;

			Assert.Throws<ArgumentNullException>(() => r = (Matrix)null / 0.5f);
		}

		[Test]
		public void MatrixBase_OperatorMulMatrix()
		{

		}

		[Test]
		public void MatrixBase_OperatorMulMatrix_Exceptions()
		{
			
		}

		#endregion

		#region Matrix Functions

		[Test]
		public void MatrixBase_GetColumn()
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
		public void MatrixBase_GetColumn_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 2);

			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetColumn(2));
		}

		[Test]
		public void MatrixBase_GetRow()
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
		public void MatrixBase_GetRow_Exceptions()
		{
			Matrix m = CreateRandomMatrix(2, 2);

			Assert.Throws<ArgumentOutOfRangeException>(() => m.GetRow(2));
		}

		[Test]
		[TestCase(1u, 2u), TestCase(2u, 1u), TestCase(2u, 2u)]
		public void MatrixBase_ToArray(uint w, uint h)
		{
			Matrix m = CreateRandomMatrix(w, h);
			float[] mArray = m.ToArray();

			Assert.IsNotNull(mArray);
			Assert.AreEqual(w * h, (uint)mArray.Length);
			Assert.AreNotSame(m.ToArray(), mArray);
			CollectionAssert.AreEqual(m.Buffer, mArray);
		}

		#endregion

		#region Object Overrides

		[Test]
		public void MatrixBase_ToString()
		{
			Matrix m = CreateRandomMatrix(3, 3);

			// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
			Assert.DoesNotThrow(() => m.ToString());
		}

		#endregion
	}
}
