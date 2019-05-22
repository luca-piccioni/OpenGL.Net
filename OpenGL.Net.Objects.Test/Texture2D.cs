
// Copyright (C) 2019 Luca Piccioni
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

namespace OpenGL.Objects.Test
{
	[TestFixture]
	public class Texture2DTest : TextureTest
	{
		[Test]
		public void Texture2D_DefaultConstructor()
		{
			using (Texture2D texture = new Texture2D()) {
				Texture_DefaultConstructor(texture);
			}
		}

		[Test]
		public void Texture2D_CreateEmptyImmutable()
		{
			using (Texture2D texture = new Texture2D()) {

				texture.Create(64, 64, PixelLayout.RGBA32);
				Assert.AreEqual(true, texture.IsDirty);

				Assert.AreEqual(PixelLayout.None, texture.PixelLayout);
				Assert.AreEqual(Vertex3ui.Zero, texture.Size);
				Assert.AreEqual(0, texture.Width);
				Assert.AreEqual(0, texture.Height);
				Assert.AreEqual(0, texture.Depth);

				Assert.IsTrue(texture.Immutable);

				texture.Create(_Context);
				Assert.AreEqual(PixelLayout.RGBA32, texture.PixelLayout);
				Assert.AreEqual(new Vertex3ui(64, 64, 1), texture.Size);
				Assert.AreEqual(64, texture.Width);
				Assert.AreEqual(64, texture.Height);
				Assert.AreEqual(1, texture.Depth);

				// Immutable textures are always mipmap complete
				Assert.IsTrue(texture.IsMipmapComplete);
				// Cannot re-define texture storage
				Assert.Throws<InvalidOperationException>(() => texture.Create(16, 16, PixelLayout.BGRA32));
				Assert.Throws<InvalidOperationException>(() => texture.Create(_Context, 16, 16, PixelLayout.BGRA32));

				Assert.DoesNotThrow(() => texture.Create(_Context));

				texture.AutomaticMipmaps = true;
				Assert.DoesNotThrow(() => texture.Create(_Context));
			}
		}

		[Test]
		public void Texture2D_CreateEmptyMutable()
		{
			using (Texture2D texture = new Texture2D() { Immutable = false }) {

				texture.Create(64, 64, PixelLayout.RGBA32);
				Assert.AreEqual(true, texture.IsDirty);

				Assert.AreEqual(PixelLayout.None, texture.PixelLayout);
				Assert.AreEqual(Vertex3ui.Zero, texture.Size);
				Assert.AreEqual(0, texture.Width);
				Assert.AreEqual(0, texture.Height);
				Assert.AreEqual(0, texture.Depth);

				Assert.IsFalse(texture.Immutable);

				texture.Create(_Context);
				Assert.AreEqual(PixelLayout.RGBA32, texture.PixelLayout);
				Assert.AreEqual(new Vertex3ui(64, 64, 1), texture.Size);
				Assert.AreEqual(64, texture.Width);
				Assert.AreEqual(64, texture.Height);
				Assert.AreEqual(1, texture.Depth);

				// Immutable textures are always mipmap complete
				Assert.IsTrue(texture.IsMipmapComplete);
				// Cannot re-define texture storage
				Assert.DoesNotThrow(() => texture.Create(16, 16, PixelLayout.BGRA32));
				Assert.IsTrue(texture.IsDirty);
				Assert.DoesNotThrow(() => texture.Create(_Context, 128, 128, PixelLayout.BGRA32));
				Assert.IsFalse(texture.IsDirty);

				Assert.DoesNotThrow(() => texture.Create(_Context));

				texture.AutomaticMipmaps = true;
				Assert.DoesNotThrow(() => texture.Create(_Context));
			}
		}
	}
}
