
// Copyright (C) 2016-2018 Luca Piccioni
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

namespace OpenGL.Test
{
	[TestFixture, Category("Math")]
	internal class PlanefTest : TestBase
	{
		[Test]
		public void Planef_PosXPlane()
		{
			Planef plane = new Planef(Vertex3f.UnitX, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosX = {
				new Vertex3f(1.0f, +1.0f, +1.0f),
				new Vertex3f(1.0f, +1.0f, -1.0f),
				new Vertex3f(1.0f, -1.0f, +1.0f),
				new Vertex3f(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosX)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegX = {
				new Vertex3f(-1.0f, +1.0f, +1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegX)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(0.0f, +1.0f, +1.0f),
				new Vertex3f(0.0f, +1.0f, -1.0f),
				new Vertex3f(0.0f, -1.0f, +1.0f),
				new Vertex3f(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_PosYPlane()
		{
			Planef plane = new Planef(Vertex3f.UnitY, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosY = {
				new Vertex3f(+1.0f, 1.0f, +1.0f),
				new Vertex3f(+1.0f, 1.0f, -1.0f),
				new Vertex3f(-1.0f, 1.0f, +1.0f),
				new Vertex3f(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosY)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegY = {
				new Vertex3f(+1.0f, -1.0f, +1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegY)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(+1.0f, 0.0f, +1.0f),
				new Vertex3f(+1.0f, 0.0f, -1.0f),
				new Vertex3f(-1.0f, 0.0f, +1.0f),
				new Vertex3f(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_PosZPlane()
		{
			Planef plane = new Planef(Vertex3f.UnitZ, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosZ = {
				new Vertex3f(+1.0f, +1.0f, 1.0f),
				new Vertex3f(+1.0f, -1.0f, 1.0f),
				new Vertex3f(-1.0f, +1.0f, 1.0f),
				new Vertex3f(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3f v in pointsPosZ)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegZ = {
				new Vertex3f(+1.0f, +1.0f, -1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegZ)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(+1.0f, +1.0f, 0.0f),
				new Vertex3f(+1.0f, -1.0f, 0.0f),
				new Vertex3f(-1.0f, +1.0f, 0.0f),
				new Vertex3f(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_NegXPlane()
		{
			Planef plane = new Planef(-Vertex3f.UnitX, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosX = {
				new Vertex3f(1.0f, +1.0f, +1.0f),
				new Vertex3f(1.0f, +1.0f, -1.0f),
				new Vertex3f(1.0f, -1.0f, +1.0f),
				new Vertex3f(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosX)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegX = {
				new Vertex3f(-1.0f, +1.0f, +1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegX)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(0.0f, +1.0f, +1.0f),
				new Vertex3f(0.0f, +1.0f, -1.0f),
				new Vertex3f(0.0f, -1.0f, +1.0f),
				new Vertex3f(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_NegYPlane()
		{
			Planef plane = new Planef(-Vertex3f.UnitY, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosY = {
				new Vertex3f(+1.0f, 1.0f, +1.0f),
				new Vertex3f(+1.0f, 1.0f, -1.0f),
				new Vertex3f(-1.0f, 1.0f, +1.0f),
				new Vertex3f(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsPosY)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegY = {
				new Vertex3f(+1.0f, -1.0f, +1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, +1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegY)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(+1.0f, 0.0f, +1.0f),
				new Vertex3f(+1.0f, 0.0f, -1.0f),
				new Vertex3f(-1.0f, 0.0f, +1.0f),
				new Vertex3f(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_NegZPlane()
		{
			Planef plane = new Planef(-Vertex3f.UnitZ, 0.0f);

			// Positive half-space
			Vertex3f[] pointsPosZ = {
				new Vertex3f(+1.0f, +1.0f, 1.0f),
				new Vertex3f(+1.0f, -1.0f, 1.0f),
				new Vertex3f(-1.0f, +1.0f, 1.0f),
				new Vertex3f(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3f v in pointsPosZ)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3f[] pointsNegZ = {
				new Vertex3f(+1.0f, +1.0f, -1.0f),
				new Vertex3f(+1.0f, -1.0f, -1.0f),
				new Vertex3f(-1.0f, +1.0f, -1.0f),
				new Vertex3f(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3f v in pointsNegZ)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3f[] pointsZero = {
				new Vertex3f(+1.0f, +1.0f, 0.0f),
				new Vertex3f(+1.0f, -1.0f, 0.0f),
				new Vertex3f(-1.0f, +1.0f, 0.0f),
				new Vertex3f(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3f v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planef_Distance()
		{
			Planef plane = new Planef(Vertex3f.UnitZ, 10.0f);

			Assert.AreEqual(-10.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 0.0f)));
			Assert.AreEqual(  0.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 10.0f)));
			Assert.AreEqual(+10.0f, plane.GetDistance(new Vertex3f(0.0f, 0.0f, 20.0f)));
		}

		// [Test]
		public void Planef_ProjectionFrustum()
		{
			Matrix4x4f projectionMatrix = Matrix4x4f.Perspective(90.0f, 1.0f, 1.0f, 10.0f);
			Matrix4x4f modelMatrix = Matrix4x4f.Identity;

			Matrix4x4f frustumMatrix = projectionMatrix * modelMatrix;

			Planef planeL = Planef.GetFrustumLeftPlane(frustumMatrix);
			Planef planeR = Planef.GetFrustumRightPlane(frustumMatrix);
			Planef planeB = Planef.GetFrustumBottomPlane(frustumMatrix);
			Planef planeT = Planef.GetFrustumTopPlane(frustumMatrix);

			Planef planeN = Planef.GetFrustumNearPlane(frustumMatrix);
			Assert.IsTrue(planeN.GetDistance(new Vertex3f(0.0f, 0.0f, -5.0f)) > 0.0f);

			Planef planeF = Planef.GetFrustumFarPlane(frustumMatrix);
			// Assert.IsTrue(planeF.GetDistance(new Vertex3f(0.0f, 0.0f, -5.0f)) > 0.0f);
		}
	}
	[TestFixture, Category("Math")]
	internal class PlanedTest : TestBase
	{
		[Test]
		public void Planed_PosXPlane()
		{
			Planed plane = new Planed(Vertex3d.UnitX, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosX = {
				new Vertex3d(1.0f, +1.0f, +1.0f),
				new Vertex3d(1.0f, +1.0f, -1.0f),
				new Vertex3d(1.0f, -1.0f, +1.0f),
				new Vertex3d(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsPosX)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegX = {
				new Vertex3d(-1.0f, +1.0f, +1.0f),
				new Vertex3d(-1.0f, +1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, +1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegX)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(0.0f, +1.0f, +1.0f),
				new Vertex3d(0.0f, +1.0f, -1.0f),
				new Vertex3d(0.0f, -1.0f, +1.0f),
				new Vertex3d(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_PosYPlane()
		{
			Planed plane = new Planed(Vertex3d.UnitY, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosY = {
				new Vertex3d(+1.0f, 1.0f, +1.0f),
				new Vertex3d(+1.0f, 1.0f, -1.0f),
				new Vertex3d(-1.0f, 1.0f, +1.0f),
				new Vertex3d(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsPosY)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegY = {
				new Vertex3d(+1.0f, -1.0f, +1.0f),
				new Vertex3d(+1.0f, -1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, +1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegY)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(+1.0f, 0.0f, +1.0f),
				new Vertex3d(+1.0f, 0.0f, -1.0f),
				new Vertex3d(-1.0f, 0.0f, +1.0f),
				new Vertex3d(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_PosZPlane()
		{
			Planed plane = new Planed(Vertex3d.UnitZ, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosZ = {
				new Vertex3d(+1.0f, +1.0f, 1.0f),
				new Vertex3d(+1.0f, -1.0f, 1.0f),
				new Vertex3d(-1.0f, +1.0f, 1.0f),
				new Vertex3d(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3d v in pointsPosZ)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegZ = {
				new Vertex3d(+1.0f, +1.0f, -1.0f),
				new Vertex3d(+1.0f, -1.0f, -1.0f),
				new Vertex3d(-1.0f, +1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegZ)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(+1.0f, +1.0f, 0.0f),
				new Vertex3d(+1.0f, -1.0f, 0.0f),
				new Vertex3d(-1.0f, +1.0f, 0.0f),
				new Vertex3d(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_NegXPlane()
		{
			Planed plane = new Planed(-Vertex3d.UnitX, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosX = {
				new Vertex3d(1.0f, +1.0f, +1.0f),
				new Vertex3d(1.0f, +1.0f, -1.0f),
				new Vertex3d(1.0f, -1.0f, +1.0f),
				new Vertex3d(1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsPosX)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegX = {
				new Vertex3d(-1.0f, +1.0f, +1.0f),
				new Vertex3d(-1.0f, +1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, +1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegX)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(0.0f, +1.0f, +1.0f),
				new Vertex3d(0.0f, +1.0f, -1.0f),
				new Vertex3d(0.0f, -1.0f, +1.0f),
				new Vertex3d(0.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_NegYPlane()
		{
			Planed plane = new Planed(-Vertex3d.UnitY, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosY = {
				new Vertex3d(+1.0f, 1.0f, +1.0f),
				new Vertex3d(+1.0f, 1.0f, -1.0f),
				new Vertex3d(-1.0f, 1.0f, +1.0f),
				new Vertex3d(-1.0f, 1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsPosY)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegY = {
				new Vertex3d(+1.0f, -1.0f, +1.0f),
				new Vertex3d(+1.0f, -1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, +1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegY)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(+1.0f, 0.0f, +1.0f),
				new Vertex3d(+1.0f, 0.0f, -1.0f),
				new Vertex3d(-1.0f, 0.0f, +1.0f),
				new Vertex3d(-1.0f, 0.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_NegZPlane()
		{
			Planed plane = new Planed(-Vertex3d.UnitZ, 0.0f);

			// Positive half-space
			Vertex3d[] pointsPosZ = {
				new Vertex3d(+1.0f, +1.0f, 1.0f),
				new Vertex3d(+1.0f, -1.0f, 1.0f),
				new Vertex3d(-1.0f, +1.0f, 1.0f),
				new Vertex3d(-1.0f, -1.0f, 1.0f),
			};

			foreach (Vertex3d v in pointsPosZ)
				Assert.IsTrue(plane.GetDistance(v) < 0.0f);

			// Negative half-space
			Vertex3d[] pointsNegZ = {
				new Vertex3d(+1.0f, +1.0f, -1.0f),
				new Vertex3d(+1.0f, -1.0f, -1.0f),
				new Vertex3d(-1.0f, +1.0f, -1.0f),
				new Vertex3d(-1.0f, -1.0f, -1.0f),
			};

			foreach (Vertex3d v in pointsNegZ)
				Assert.IsTrue(plane.GetDistance(v) > 0.0f);

			// On-plane 
			Vertex3d[] pointsZero = {
				new Vertex3d(+1.0f, +1.0f, 0.0f),
				new Vertex3d(+1.0f, -1.0f, 0.0f),
				new Vertex3d(-1.0f, +1.0f, 0.0f),
				new Vertex3d(-1.0f, -1.0f, 0.0f),
			};

			foreach (Vertex3d v in pointsZero)
				Assert.AreEqual(0.0f, plane.GetDistance(v));
		}

		[Test]
		public void Planed_Distance()
		{
			Planed plane = new Planed(Vertex3d.UnitZ, 10.0f);

			Assert.AreEqual(-10.0f, plane.GetDistance(new Vertex3d(0.0f, 0.0f, 0.0f)));
			Assert.AreEqual(  0.0f, plane.GetDistance(new Vertex3d(0.0f, 0.0f, 10.0f)));
			Assert.AreEqual(+10.0f, plane.GetDistance(new Vertex3d(0.0f, 0.0f, 20.0f)));
		}

		// [Test]
		public void Planed_ProjectionFrustum()
		{
			Matrix4x4d projectionMatrix = Matrix4x4d.Perspective(90.0f, 1.0f, 1.0f, 10.0f);
			Matrix4x4d modelMatrix = Matrix4x4d.Identity;

			Matrix4x4d frustumMatrix = projectionMatrix * modelMatrix;

			Planed planeL = Planed.GetFrustumLeftPlane(frustumMatrix);
			Planed planeR = Planed.GetFrustumRightPlane(frustumMatrix);
			Planed planeB = Planed.GetFrustumBottomPlane(frustumMatrix);
			Planed planeT = Planed.GetFrustumTopPlane(frustumMatrix);

			Planed planeN = Planed.GetFrustumNearPlane(frustumMatrix);
			Assert.IsTrue(planeN.GetDistance(new Vertex3d(0.0f, 0.0f, -5.0f)) > 0.0f);

			Planed planeF = Planed.GetFrustumFarPlane(frustumMatrix);
			// Assert.IsTrue(planeF.GetDistance(new Vertex3d(0.0f, 0.0f, -5.0f)) > 0.0f);
		}
	}
}