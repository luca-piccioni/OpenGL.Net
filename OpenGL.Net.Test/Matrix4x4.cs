
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Runtime.CompilerServices;

using NUnit.Framework;

#if HAVE_NUMERICS
using System.Numerics;

using Mat4x4 = System.Numerics.Matrix4x4;
#endif

namespace OpenGL.Test
{
	[TestFixture]
	internal class Matrix4x4Test
	{
		private Matrix4x4 CreateRandomMatrix()
		{
			return CreateRandomMatrix(new Random());
		}

		private Matrix4x4 CreateRandomMatrix(Random random)
		{
			float[] components = new float[16];

			for (int i = 0; i < components.Length; i++)
				components[i] = (float)random.NextDouble();

			return new Matrix4x4(components);
		}

		#region Constructors

		[Test]
		public void Matrix4x4_Constructor1()
		{
			Matrix4x4 m = new Matrix4x4();

			Assert.AreEqual(4, m.Width);
			Assert.AreEqual(4, m.Height);

			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					Assert.AreEqual(0.0f, m[c, r]);
		}

		[Test]
		public void Matrix4x4_Constructor2()
		{
			Matrix4x4 m = CreateRandomMatrix();

			Assert.AreEqual(4, m.Width);
			Assert.AreEqual(4, m.Height);

			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					Assert.AreNotEqual(float.Epsilon, m[c, r]);
		}

		[Test]
		public void Matrix4x4_Constructor2_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix4x4 m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix4x4((float[])null));
		}

		[Test]
		public void Matrix4x4_Constructor3()
		{
			Matrix4x4 m = CreateRandomMatrix();
			Matrix4x4 cm = new Matrix4x4(m);

			Assert.AreEqual(m.Width, cm.Width);
			Assert.AreEqual(m.Height, cm.Height);
			for (uint c = 0; c < 4; c++)
				for (uint r = 0; r < 4; r++)
					Assert.AreEqual(m[c, r], cm[c, r]);
		}

		[Test]
		public void Matrix4x4_Constructor4_Exceptions()
		{
			// ReSharper disable once NotAccessedVariable
			Matrix4x4 m;

			Assert.Throws<ArgumentNullException>(() => m = new Matrix4x4((Matrix4x4)null));
		}

		#endregion

		#region Operators

		[Test]
		public void Matrix4x4_MulVertex4()
		{
			Random r = new Random();
			Matrix4x4 m = CreateRandomMatrix();
			Vertex4f v = new Vertex4f((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble());

			Vertex4f p = m * v;

			Matrix4x4 inv = m.GetInverseMatrix();

			Vertex4f invp = inv * p;

			Assert.IsTrue(((Vertex3f)v).Equals((Vertex3f)invp, 1e-4f));
		}

		#endregion
		
		#region Matrix Overrides

		[Test]
		public void Matrix4x4_Clone()
		{
			Matrix4x4 m = CreateRandomMatrix();
			Matrix c = null;

			Assert.DoesNotThrow(() => c = m.Clone());
			Assert.AreNotSame(m, c);
			Assert.AreEqual(m.GetType(), c.GetType(), "Clone() mast return the same matrix type");
		}

		#endregion
	}
}
