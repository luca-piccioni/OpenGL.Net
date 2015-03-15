
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

using System;
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 1.0 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_1_0 : GlTestBase
	{
		/// <summary>
		/// Test Gl.GetString(Gl.EXTENSIONS)
		/// </summary>
		[Test]
		public void TestGetString()
		{
			#region Gl.VERSION

			string vendor = Gl.GetString(StringName.Vendor);

			Assert.IsNotNull(vendor);
			Console.WriteLine("Vendor: {0}", vendor);

			#endregion

			#region Gl.RENDERER

			string rendered = Gl.GetString(StringName.Renderer);

			Assert.IsNotNull(vendor);
			Console.WriteLine("Rendered: {0}", rendered);

			#endregion

			#region Gl.VERSION

			string version = Gl.GetString(StringName.Version);

			Assert.IsNotNull(version);
			Console.WriteLine("Version: {0}", version);

			#endregion

			#region Gl.EXTENSIONS

			string extensions = Gl.GetString(StringName.Extensions);

			Assert.IsNotNull(extensions);

			// No exposed extensions? No more assertion
			if (extensions == String.Empty)
				return;

			string[] extensionIds = Regex.Split(extensions, " ");

			// Filter empty IDs
			extensionIds = Array.FindAll(extensionIds, delegate(string item) { return (item.Trim().Length > 0); });

			Console.WriteLine("Found {0} GL extensions:", extensionIds.Length);
			foreach (string extensionId in extensionIds)
				Console.WriteLine("- {0}", extensionId);

			Assert.IsTrue(Regex.IsMatch(extensions, @"((WGL|GLX|GL)_(\w+)( +)?)+"));

			#endregion
		}

		/// <summary>
		/// Mainly used for testing glGet using an OpenGL state.
		/// </summary>
		[Test]
		public void TestCullFace()
		{
			foreach (CullFaceMode cullFaceMode in (CullFaceMode[])Enum.GetValues(typeof(CullFaceMode))) {
				int getCullFaceMode;
				int[] getCullFaceModev;

				Gl.CullFace(cullFaceMode);

				getCullFaceMode = 0;
				Gl.Get(GetPName.CullFaceMode, out getCullFaceMode);
				Assert.AreEqual((int)cullFaceMode, getCullFaceMode);

				getCullFaceMode = 0;
				Gl.Get(Gl.CULL_FACE_MODE, out getCullFaceMode);
				Assert.AreEqual((int)cullFaceMode, getCullFaceMode);

				getCullFaceModev = new int[1];
				Gl.Get(GetPName.CullFaceMode, getCullFaceModev);
				Assert.AreEqual((int)cullFaceMode, getCullFaceModev[0]);

				getCullFaceModev = new int[1];
				Gl.Get(Gl.CULL_FACE_MODE, getCullFaceModev);
				Assert.AreEqual((int)cullFaceMode, getCullFaceModev[0]);
			}
		}

		/// <summary>
		/// Mainly used for testing glTex* commands.
		/// </summary>
		[Test]
		public void TestGenTexture()
		{
			if (!HasVersion(1, 1))
				Assert.Inconclusive("OpenGL 1.1");

			uint[] textureObjects = new uint[3];
			uint textureObject;

			textureObject = Gl.GenTexture();	
			Assert.AreNotEqual(0, textureObject);
			Assert.IsFalse(Gl.IsTexture(textureObject));

			try {
				Gl.BindTexture(TextureTarget.Texture2d, textureObject);
				Assert.IsTrue(Gl.IsTexture(textureObject));
			} finally {
				Gl.DeleteTextures(textureObject);
				Assert.IsFalse(Gl.IsTexture(textureObject));
			}

			Gl.GenTextures(textureObjects);
			try {
				for (int i = 0; i < textureObjects.Length; i++) {
					Assert.AreNotEqual(0, textureObjects[i]);
					Assert.IsFalse(Gl.IsTexture(textureObjects[i]));
				
					Gl.BindTexture(TextureTarget.Texture2d, textureObjects[i]);
					Assert.IsTrue(Gl.IsTexture(textureObjects[i]));
				}
			} finally {
				for (int i = 0; i < textureObjects.Length; i++) {
					if (Gl.IsTexture(textureObjects[i])) {
						Gl.DeleteTextures(textureObjects[i]);
						Assert.IsFalse(Gl.IsTexture(textureObjects[i]));
					}
				}
			}

			Gl.GenTextures(textureObjects);
			try {
				for (int i = 0; i < textureObjects.Length; i++) {
					Assert.AreNotEqual(0, textureObjects[i]);
					Assert.IsFalse(Gl.IsTexture(textureObjects[i]));

					Gl.BindTexture(TextureTarget.Texture2d, textureObjects[i]);
					Assert.IsTrue(Gl.IsTexture(textureObjects[i]));
				}
			} finally {
				Gl.DeleteTextures(textureObjects);
				for (int i = 0; i < textureObjects.Length; i++)
					Assert.IsFalse(Gl.IsTexture(textureObjects[i]));
			}

			Gl.GenTextures(textureObjects);
			try {
				for (int i = 0; i < textureObjects.Length; i++) {
					Assert.AreNotEqual(0, textureObjects[i]);
					Assert.IsFalse(Gl.IsTexture(textureObjects[i]));

					Gl.BindTexture(TextureTarget.Texture2d, textureObjects[i]);
					Assert.IsTrue(Gl.IsTexture(textureObjects[i]));
				}
			} finally {
				Gl.DeleteTextures(textureObjects[0], textureObjects[1], textureObjects[2]);
				for (int i = 0; i < textureObjects.Length; i++)
					Assert.IsFalse(Gl.IsTexture(textureObjects[i]));
			}
		}
	}
}
