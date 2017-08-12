
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

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Math")]
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
