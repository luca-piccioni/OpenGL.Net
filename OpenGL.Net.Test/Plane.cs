
// Copyright (C) 2016-2017 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	class PlaneTest
	{
		[Test]
		public void TestPosXPlane()
		{
			Plane plane = new Plane("X", Vertex3f.UnitX, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosX = new Vertex3f[] {
				new Vertex3f(1.0f, +1.0f, +1.0f),
				new Vertex3f(1.0f, +1.0f, -1.0f),
				new Vertex3f(1.0f, -1.0f, +1.0f),
				new Vertex3f(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosX)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegX = new Vertex3f[] {
				new Vertex3f(-1.0f, +1.0f, +1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegX)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(0.0f, +1.0f, +1.0f),
				new Vertex3f(0.0f, +1.0f, -1.0f),
				new Vertex3f(0.0f, -1.0f, +1.0f),
				new Vertex3f(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestPosYPlane()
		{
			Plane plane = new Plane("Y", Vertex3f.UnitY, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosY = new Vertex3f[] {
				new Vertex3f(+1.0f, 1.0f, +1.0f),
				new Vertex3f(+1.0f, 1.0f, -1.0f),
				new Vertex3f(-1.0f, 1.0f, +1.0f),
				new Vertex3f(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosY)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegY = new Vertex3f[] {
				new Vertex3f(+1.0f, -1.0f, +1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegY)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(+1.0f, 0.0f, +1.0f),
				new Vertex3f(+1.0f, 0.0f, -1.0f),
				new Vertex3f(-1.0f, 0.0f, +1.0f),
				new Vertex3f(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestPosZPlane()
		{
			Plane plane = new Plane("Z", Vertex3f.UnitZ, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosZ = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, 1.0f),
				new Vertex3f(+1.0f, -1.0f, 1.0f),
				new Vertex3f(-1.0f, +1.0f, 1.0f),
				new Vertex3f(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3f v in pointsPosZ)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegZ = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, -1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegZ)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, 0.0f),
				new Vertex3f(+1.0f, -1.0f, 0.0f),
				new Vertex3f(-1.0f, +1.0f, 0.0f),
				new Vertex3f(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestNegXPlane()
		{
			Plane plane = new Plane("-X", -Vertex3f.UnitX, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosX = new Vertex3f[] {
				new Vertex3f(1.0f, +1.0f, +1.0f),
				new Vertex3f(1.0f, +1.0f, -1.0f),
				new Vertex3f(1.0f, -1.0f, +1.0f),
				new Vertex3f(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosX)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegX = new Vertex3f[] {
				new Vertex3f(-1.0f, +1.0f, +1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegX)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(0.0f, +1.0f, +1.0f),
				new Vertex3f(0.0f, +1.0f, -1.0f),
				new Vertex3f(0.0f, -1.0f, +1.0f),
				new Vertex3f(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestNegYPlane()
		{
			Plane plane = new Plane("-Y", -Vertex3f.UnitY, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosY = new Vertex3f[] {
				new Vertex3f(+1.0f, 1.0f, +1.0f),
				new Vertex3f(+1.0f, 1.0f, -1.0f),
				new Vertex3f(-1.0f, 1.0f, +1.0f),
				new Vertex3f(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosY)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegY = new Vertex3f[] {
				new Vertex3f(+1.0f, -1.0f, +1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegY)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(+1.0f, 0.0f, +1.0f),
				new Vertex3f(+1.0f, 0.0f, -1.0f),
				new Vertex3f(-1.0f, 0.0f, +1.0f),
				new Vertex3f(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestNegZPlane()
		{
			Plane plane = new Plane("-Z", -Vertex3f.UnitZ, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosZ = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, 1.0f),
				new Vertex3f(+1.0f, -1.0f, 1.0f),
				new Vertex3f(-1.0f, +1.0f, 1.0f),
				new Vertex3f(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3f v in pointsPosZ)
				Assert.Less(plane.GetDistance(v), 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegZ = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, -1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegZ)
				Assert.Greater(plane.GetDistance(v), 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = new Vertex3f[] {
				new Vertex3f(+1.0f, +1.0f, 0.0f),
				new Vertex3f(+1.0f, -1.0f, 0.0f),
				new Vertex3f(-1.0f, +1.0f, 0.0f),
				new Vertex3f(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void TestDistance()
		{
			Plane plane = new Plane("ZDist", Vertex3f.UnitZ, 10.0f);

			Assert.AreEqual(-10.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 0.0f)));
			Assert.AreEqual(  0.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 10.0f)));
			Assert.AreEqual(+10.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 20.0f)));
		}

		[Test]
		public void TestProjectionFrustum()
		{
			PerspectiveProjectionMatrix projectionMatrix = new PerspectiveProjectionMatrix(90.0f, 1.0f, 1.0f, 10.0f);
			ModelMatrix modelMatrix = new ModelMatrix();

			IMatrix4x4 frustumMatrix = projectionMatrix * modelMatrix;

			Plane planeL = Plane.GetFrustumLeftPlane(frustumMatrix);
			Plane planeR = Plane.GetFrustumRightPlane(frustumMatrix);
			Plane planeB = Plane.GetFrustumBottomPlane(frustumMatrix);
			Plane planeT = Plane.GetFrustumTopPlane(frustumMatrix);

			Plane planeN = Plane.GetFrustumNearPlane(frustumMatrix);
			Assert.Greater(planeN.GetDistance(new Vertex3f(0.0f, 0.0f, -5.0f)), 0.0f);

			Plane planeF = Plane.GetFrustumFarPlane(frustumMatrix);
			Assert.Greater(planeF.GetDistance(new Vertex3f(0.0f, 0.0f, -5.0f)), 0.0f);
		}
	}
}
