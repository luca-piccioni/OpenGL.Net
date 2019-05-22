
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

using OpenGL.Objects;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	[TestFixture]
	public class TextureTest : TestBase
	{
		protected static void Texture_DefaultConstructor(Texture texture)
		{
			Assert.AreEqual(PixelLayout.None, texture.PixelLayout);
			Assert.AreEqual(Vertex3ui.Zero, texture.Size);
			Assert.AreEqual(0, texture.Width);
			Assert.AreEqual(0, texture.Height);
			Assert.AreEqual(0, texture.Depth);

			Assert.AreEqual(0, texture.BaseLevel);
			Assert.AreEqual(0, texture.MipmapMaxLevel);
			Assert.DoesNotThrow(() => texture.HasMipMapLevel(0));
			Assert.AreEqual(false, texture.IsMipmapComplete);

			Assert.AreNotEqual(null, texture.SamplerParams);
			Assert.AreEqual(null, texture.Sampler);

			Assert.AreEqual(false, texture.IsDirty);
			// Default is immutable
			Assert.AreEqual(true, texture.Immutable);
		}
	}
}
