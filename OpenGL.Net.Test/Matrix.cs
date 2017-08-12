
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
using System.Runtime.CompilerServices;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Math")]
	class MatrixTest
	{
		#region Multiply

		[Test]
		public void MatrixMul()
		{
			Matrix m = new Matrix(new float[] {
				1.0f, 0.0f, 0.0f, 0.0f,
				0.0f, 1.0f, 0.0f, 0.0f,
				0.0f, 0.0f, 1.0f, 0.0f,
				-1.0f, -2.0f, -3.0f, +1.0f
			}, 4, 4);
			Matrix n = new Matrix(new float[] {
				1.0f,
				2.0f,
				3.0f,
				1.0f
			}, 1, 4);

			Matrix p = m * n;

			Assert.AreEqual(1, p.Width);
			Assert.AreEqual(4, p.Height);
		}

		[Test]
		public void MatrixMul2()
		{
			ProjectionMatrix proj = new OrthoProjectionMatrix(-1.0f, 0.5f, 0.0f, 1.0f, 0.1f, 3.0f);
			ModelMatrix model = new ModelMatrix();

			model.Translate(2.0f, -4.0f, 1.125f);
			model.RotateX(30.0f);

			Matrix r1 = proj * model;

			Matrix m = new Matrix(proj.ToArray(), 4, 4), n = new Matrix(model.ToArray(), 4, 4);

			Matrix r2 = m * n;
		}

		#endregion
	}
}
