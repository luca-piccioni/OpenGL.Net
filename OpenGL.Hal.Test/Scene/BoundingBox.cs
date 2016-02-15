
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

using System.Collections.Generic;

using NUnit.Framework;

using OpenGL.Scene;

namespace OpenGL.Hal.Test.Scene
{
	[TestFixture]
	class BoundingBoxTest
	{
		[Test]
		public void TestPerspectiveFrustumNoModelView()
		{
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix();
			BoundingBox boundingBox;

			projectionMatrix.SetPerspective(60.0f, 1.0f, 0.5f, 15.0f);

			IEnumerable<Plane> planes = Plane.GetFrustumPlanes(projectionMatrix);

			boundingBox = new BoundingBox(
				new Vertex3f(-1000.0f, 0.0f, 5.0f),
				new Vertex3f(-1100.0f, 1.0f, 6.0f)
			);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			boundingBox = new BoundingBox(
				new Vertex3f(+1000.0f, 0.0f, 5.0f),
				new Vertex3f(+1100.0f, 1.0f, 6.0f)
			);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			boundingBox = new BoundingBox(
				new Vertex3f(-0.5f, -0.5f, -1.0f),
				new Vertex3f(+0.5f, +0.5f, -5.0f)
			);
			Assert.IsFalse(boundingBox.IsClipped(planes));
		}

		[Test]
		public void TestPerspectiveFrustum()
		{
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix();
			ModelMatrix modelMatrix = new ModelMatrix();
			BoundingBox boundingBox;

			projectionMatrix.SetPerspective(60.0f, 1.0f, 0.5f, 15.0f);
			modelMatrix.RotateY(90.0f);

			IEnumerable<Plane> planes = Plane.GetFrustumPlanes(projectionMatrix * modelMatrix);

			boundingBox = new BoundingBox(
				new Vertex3f(-0.5f, 0.0f, -0.5f),
				new Vertex3f(+0.5f, 1.0f, +0.5f)
			);
			Assert.IsFalse(boundingBox.IsClipped(planes));
		}
	}
}
