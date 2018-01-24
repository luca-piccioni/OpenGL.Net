
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
			Matrix2x2f m1 = new Matrix2x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix2x2f m2 = new Matrix2x2f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2f_TestCastToArray()
		{
			Matrix2x2f m = new Matrix2x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x2f_TestToString()
		{
			Matrix2x2f m = new Matrix2x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix2x3f m1 = new Matrix2x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix2x3f m2 = new Matrix2x3f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x3f_TestCastToArray()
		{
			Matrix2x3f m = new Matrix2x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x3f_TestToString()
		{
			Matrix2x3f m = new Matrix2x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix2x4f m1 = new Matrix2x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix2x4f m2 = new Matrix2x4f(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x4f_TestCastToArray()
		{
			Matrix2x4f m = new Matrix2x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x4f_TestToString()
		{
			Matrix2x4f m = new Matrix2x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x2f m1 = new Matrix3x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix3x2f m2 = new Matrix3x2f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x2f_TestCastToArray()
		{
			Matrix3x2f m = new Matrix3x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x2f_TestToString()
		{
			Matrix3x2f m = new Matrix3x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x3f m1 = new Matrix3x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix3x3f m2 = new Matrix3x3f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3f_TestCastToArray()
		{
			Matrix3x3f m = new Matrix3x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x3f_TestToString()
		{
			Matrix3x3f m = new Matrix3x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x4f m1 = new Matrix3x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix3x4f m2 = new Matrix3x4f(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x4f_TestCastToArray()
		{
			Matrix3x4f m = new Matrix3x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x4f_TestToString()
		{
			Matrix3x4f m = new Matrix3x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x2f m1 = new Matrix4x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix4x2f m2 = new Matrix4x2f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x2f_TestCastToArray()
		{
			Matrix4x2f m = new Matrix4x2f(new[] {
				(float)0, (float)1, 
				(float)2, (float)3, 
				(float)4, (float)5, 
				(float)6, (float)7
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x2f_TestToString()
		{
			Matrix4x2f m = new Matrix4x2f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x3f m1 = new Matrix4x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix4x3f m2 = new Matrix4x3f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x3f_TestCastToArray()
		{
			Matrix4x3f m = new Matrix4x3f(new[] {
				(float)0, (float)1, (float)2, 
				(float)3, (float)4, (float)5, 
				(float)6, (float)7, (float)8, 
				(float)9, (float)10, (float)11
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x3f_TestToString()
		{
			Matrix4x3f m = new Matrix4x3f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x4f m1 = new Matrix4x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});
			Matrix4x4f m2 = new Matrix4x4f(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-5f));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4f_TestCastToArray()
		{
			Matrix4x4f m = new Matrix4x4f(new[] {
				(float)0, (float)1, (float)2, (float)3, 
				(float)4, (float)5, (float)6, (float)7, 
				(float)8, (float)9, (float)10, (float)11, 
				(float)12, (float)13, (float)14, (float)15
			});
			float[] mArray = (float[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-5f));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x4f_TestToString()
		{
			Matrix4x4f m = new Matrix4x4f(new[] {
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), 
				Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f), Next(0.0f, 1.0f)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix2x2d m1 = new Matrix2x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix2x2d m2 = new Matrix2x2d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x2d_TestCastToArray()
		{
			Matrix2x2d m = new Matrix2x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 4);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x2d_TestToString()
		{
			Matrix2x2d m = new Matrix2x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix2x3d m1 = new Matrix2x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix2x3d m2 = new Matrix2x3d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x3d_TestCastToArray()
		{
			Matrix2x3d m = new Matrix2x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x3d_TestToString()
		{
			Matrix2x3d m = new Matrix2x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix2x4d m1 = new Matrix2x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix2x4d m2 = new Matrix2x4d(m1);

			for (uint c = 0; c < 2; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix2x4d_TestCastToArray()
		{
			Matrix2x4d m = new Matrix2x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 2; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix2x4d_TestToString()
		{
			Matrix2x4d m = new Matrix2x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x2d m1 = new Matrix3x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix3x2d m2 = new Matrix3x2d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x2d_TestCastToArray()
		{
			Matrix3x2d m = new Matrix3x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 6);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x2d_TestToString()
		{
			Matrix3x2d m = new Matrix3x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x3d m1 = new Matrix3x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix3x3d m2 = new Matrix3x3d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x3d_TestCastToArray()
		{
			Matrix3x3d m = new Matrix3x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 9);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x3d_TestToString()
		{
			Matrix3x3d m = new Matrix3x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix3x4d m1 = new Matrix3x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix3x4d m2 = new Matrix3x4d(m1);

			for (uint c = 0; c < 3; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix3x4d_TestCastToArray()
		{
			Matrix3x4d m = new Matrix3x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 3; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix3x4d_TestToString()
		{
			Matrix3x4d m = new Matrix3x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x2d m1 = new Matrix4x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix4x2d m2 = new Matrix4x2d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 2; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x2d_TestCastToArray()
		{
			Matrix4x2d m = new Matrix4x2d(new[] {
				(double)0, (double)1, 
				(double)2, (double)3, 
				(double)4, (double)5, 
				(double)6, (double)7
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 8);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 2; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x2d_TestToString()
		{
			Matrix4x2d m = new Matrix4x2d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x3d m1 = new Matrix4x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix4x3d m2 = new Matrix4x3d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 3; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x3d_TestCastToArray()
		{
			Matrix4x3d m = new Matrix4x3d(new[] {
				(double)0, (double)1, (double)2, 
				(double)3, (double)4, (double)5, 
				(double)6, (double)7, (double)8, 
				(double)9, (double)10, (double)11
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 12);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 3; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x3d_TestToString()
		{
			Matrix4x3d m = new Matrix4x3d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
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
			Matrix4x4d m1 = new Matrix4x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});
			Matrix4x4d m2 = new Matrix4x4d(m1);

			for (uint c = 0; c < 4; c++) for (uint r = 0; r < 4; r++)
				Assert.That(m1[c, r], Is.EqualTo(m2[c, r]).Within(1e-10));
		}

		#endregion

		#region Cast Operators

		[Test]
		public void Matrix4x4d_TestCastToArray()
		{
			Matrix4x4d m = new Matrix4x4d(new[] {
				(double)0, (double)1, (double)2, (double)3, 
				(double)4, (double)5, (double)6, (double)7, 
				(double)8, (double)9, (double)10, (double)11, 
				(double)12, (double)13, (double)14, (double)15
			});
			double[] mArray = (double[])m;

			Assert.IsNotNull(mArray);
			Assert.AreEqual(mArray.Length, 16);
			for (uint c = 0, idx = 0; c < 4; c++) for (uint r = 0; r < 4; r++, idx++)
				Assert.That(mArray[idx], Is.EqualTo(m[c, r]).Within(1e-10));
		}

		#endregion

		#region Object Overrides

		[Test]
		public void Matrix4x4d_TestToString()
		{
			Matrix4x4d m = new Matrix4x4d(new[] {
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), 
				Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0), Next(0.0, 1.0)
			});

			Assert.DoesNotThrow(() => m.ToString());
			Assert.IsNotNull(m.ToString());
		}

		#endregion
	}

}