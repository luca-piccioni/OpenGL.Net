
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

namespace OpenGL.Hal.Test
{
	[TestFixture]
	class PlaneTest : TestBase
	{
		[Test]
		public void TestGetFrustumLeftPlane()
		{
			ProjectionMatrix projectionMatrix;
			ModelMatrix modelMatrix;
			Matrix4x4 mvp;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumLeftPlane(projectionMatrix);
			Assert.AreEqual(Vertex3f.UnitX, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);

			// Rotate by 90 deg on Y axis
			modelMatrix = new ModelMatrix();
			modelMatrix.RotateY(90.0f);
			mvp = projectionMatrix * modelMatrix;

			plane = Plane.GetFrustumLeftPlane(mvp);
			Assert.AreEqual(Vertex3f.UnitZ, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);

			// Rotate by 180 deg on Y axis
			modelMatrix = new ModelMatrix();
			modelMatrix.RotateY(180.0f);
			mvp = projectionMatrix * modelMatrix;

			plane = Plane.GetFrustumLeftPlane(mvp);
			Assert.AreEqual(-Vertex3f.UnitX, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestGetFrustumRightPlane()
		{
			ProjectionMatrix projectionMatrix;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumRightPlane(projectionMatrix);
			Assert.AreEqual(-Vertex3f.UnitX, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestGetFrustumBottomPlane()
		{
			ProjectionMatrix projectionMatrix;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumBottomPlane(projectionMatrix);
			Assert.AreEqual(Vertex3f.UnitY, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestGetFrustumTopPlane()
		{
			ProjectionMatrix projectionMatrix;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumTopPlane(projectionMatrix);
			Assert.AreEqual(-Vertex3f.UnitY, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestGetFrustumFarPlane()
		{
			ProjectionMatrix projectionMatrix;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumFarPlane(projectionMatrix);
			Assert.AreEqual(Vertex3f.UnitZ, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestGetFrustumNearPlane()
		{
			ProjectionMatrix projectionMatrix;
			Plane plane;

			// Orthographic projection
			projectionMatrix = new OrthoProjectionMatrix(-2.0f, +2.0f, -2.0f, +2.0f, -2.0f, +2.0f);
			plane = Plane.GetFrustumNearPlane(projectionMatrix);
			Assert.AreEqual(-Vertex3f.UnitZ, plane.Normal);
			Assert.AreEqual(-2.0f, plane.Distance);
		}

		[Test]
		public void TestPerspectiveFrustum()
		{
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix();

			projectionMatrix.SetPerspective(60.0f, 1.0f, 0.5f, 100.0f);

			IEnumerable<Plane> planes = Plane.GetFrustumPlanes(projectionMatrix);

			foreach (Plane plane in planes)
				Assert.GreaterOrEqual(plane.GetDistance(-Vertex3f.UnitZ), 0.0f);
		}
	}
}
