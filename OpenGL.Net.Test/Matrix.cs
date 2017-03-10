
// Copyright (C) 2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Runtime.CompilerServices;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
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
