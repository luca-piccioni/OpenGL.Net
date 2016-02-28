
// Copyright (C) 2015 Luca Piccioni
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

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test Texture2d class.
	/// </summary>
	[TestFixture]
	class Texture2dTest : TestBase
	{
		/// <summary>
		/// Test.
		/// </summary>
		[Test]
		public void TestCreate()
		{
			Texture2d texture = null;

			// Create(uint, uint, PixelLayout)
			try {
				texture = new Texture2d();
				Assert.IsFalse(texture.Exists(_Context));

				texture.Create(16, 16, PixelLayout.RGB24);
				Assert.IsFalse(texture.Exists(_Context));

				texture.Create(_Context);
				Assert.IsTrue(texture.Exists(_Context));
			} finally {
				if (texture != null)
					texture.Dispose(_Context);
				texture = null;
			}

			// Create(GraphicsContext, uint, uint, PixelLayout)
			try {
				texture = new Texture2d();
				Assert.IsFalse(texture.Exists(_Context));

				texture.Create(_Context, 16, 32, PixelLayout.RGB24);
				Assert.IsTrue(texture.Exists(_Context));

				Assert.AreEqual(16, texture.Width);
				Assert.AreEqual(32, texture.Height);
				Assert.AreEqual(PixelLayout.RGB24, texture.PixelLayout);
			} finally {
				if (texture != null)
					texture.Dispose(_Context);
				texture = null;
			}
		}

		/// <summary>
		/// Test <see cref="Texture2d.Create(GraphicsContext, uint, uint, PixelLayout, uint)"/>.
		/// </summary>
		[Test]
		public void TestCreate2()
		{
			using (Texture2d texture = new Texture2d()) {
				texture.Create(_Context, 16, 16, PixelLayout.RGB24, 1);
				texture.MipmapBaseLevel = 1;

				Assert.AreEqual(16, texture.Width);
				Assert.AreEqual(16, texture.Height);

				Assert.AreEqual(32, texture.BaseSize.x);
				Assert.AreEqual(32, texture.BaseSize.y);
				Assert.AreEqual(1, texture.BaseSize.z);
			}
		}
	}
}
