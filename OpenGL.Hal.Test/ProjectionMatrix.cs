
// Copyright (C) 2016 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test ProjectionMatrix class.
	/// </summary>
	[TestFixture(typeof(OrthoProjectionMatrix))]
	[TestFixture(typeof(PerspectiveProjectionMatrix))]
	class ProjectionMatrixTest<T> where T : ProjectionMatrix
	{
		/// <summary>
		/// Test <see cref="ProjectionMatrix.Far"/>.
		/// </summary>
		[Test]
		public void Far()
		{
			for (int i = 0; i < 10; i++) {
				float far = (float)Math.Pow(2.0f, i);

				ProjectionMatrix projectionMatrix = Create(0.1f, far);

				Assert.AreEqual(far, projectionMatrix.Far, 1.0f, String.Format("precision loss at far={0}", far));
			}
		}

		private ProjectionMatrix Create(float near, float far)
		{
			if (typeof(T) == typeof(OrthoProjectionMatrix))
				return (new OrthoProjectionMatrix(0.0f, 1.0f, 0.0f, 1.0f, near, far));
			else if (typeof(T) == typeof(PerspectiveProjectionMatrix))
				return (new PerspectiveProjectionMatrix(60.0f, 1.0f, near, far));

			Assert.Inconclusive();
			return (null);
		}
	}
}
