
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
			Vertex3f bboxPosition;

			projectionMatrix.SetPerspective(60.0f, 1.0f, 1.0f, 10.0f);

			IEnumerable<Plane> planes = Plane.GetFrustumPlanes(projectionMatrix);

			bboxPosition = new Vertex3f(-0.5f, -0.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsFalse(boundingBox.IsClipped(planes));

			bboxPosition = new Vertex3f(-10.5f, -10.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsTrue(boundingBox.IsClipped(planes));
		}

		[Test]
		public void TestPerspectiveFrustum()
		{
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix();
			ModelMatrix modelMatrix = new ModelMatrix();
			BoundingBox boundingBox;
			Vertex3f bboxPosition;

			projectionMatrix.SetPerspective(60.0f, 1.0f, 0.5f, 15.0f);
			modelMatrix.Translate(new Vertex3f(-1000.0f, 00.0f, 0.0f));

			IEnumerable<Plane> planes = Plane.GetFrustumPlanes(projectionMatrix * modelMatrix);

			bboxPosition = new Vertex3f(-0.5f, -0.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			bboxPosition = new Vertex3f(-10.5f, -10.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			bboxPosition = new Vertex3f(999.5f, -0.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsFalse(boundingBox.IsClipped(planes));

			modelMatrix.SetIdentity();
			modelMatrix.RotateY(180.0f);
			planes = Plane.GetFrustumPlanes(projectionMatrix * modelMatrix);

			bboxPosition = new Vertex3f(-10.5f, -10.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			bboxPosition = new Vertex3f(999.5f, -0.5f, -3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsTrue(boundingBox.IsClipped(planes));

			bboxPosition = new Vertex3f(-0.5f, -0.5f, +3.0f);
			boundingBox = new BoundingBox(bboxPosition, bboxPosition + Vertex3f.One);
			Assert.IsFalse(boundingBox.IsClipped(planes));
		}
	}
}
