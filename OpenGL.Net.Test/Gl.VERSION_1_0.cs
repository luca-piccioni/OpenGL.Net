
// Copyright (C) 2015-2018 Luca Piccioni
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
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 1.0 API.
	/// </summary>
	[TestFixture, Category("GL_VERSION_1_0")]
	internal class Gl_VERSION_1_0 : TestBaseGL
	{
		/// <summary>
		/// Test Gl.GetString.
		/// </summary>
		[Test]
		public void TestGetString()
		{
			if (!HasVersion(Gl.Version_100) && !HasVersion(Gl.Version_100_ES))
				Assert.Inconclusive("OpenGL 1.0 or OpenGL ES 1.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				#region Gl.VERSION

				string vendor = Gl.GetString(StringName.Vendor);

				Assert.IsNotNull(vendor);
				Console.WriteLine("Vendor: {0}", vendor);

				#endregion

				#region Gl.RENDERER

				string rendered = Gl.GetString(StringName.Renderer);

				Assert.IsNotNull(vendor);
				Console.WriteLine("Renderer: {0}", rendered);

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
		}

		/// <summary>
		/// Mainly used for testing glGet using an OpenGL state.
		/// </summary>
		[Test]
		public void TestCullFace()
		{
			if (!HasVersion(Gl.Version_100) && !HasVersion(Gl.Version_100_ES))
				Assert.Inconclusive("OpenGL 1.0 or OpenGL ES 1.0");

			using (Device device = new Device())
			using (new GLContext(device))
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
		}

		/// <summary>
		/// Mainly used for testing glGen* and glDelete* commands.
		/// </summary>
		[Test]
		public void TestGenTexture()
		{
			if (!HasVersion(Gl.Version_100) && !HasVersion(Gl.Version_100_ES))
				Assert.Inconclusive("OpenGL 1.1 or OpenGL ES 1.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint[] textureObjects = new uint[3];
				uint textureObject;

				textureObject = Gl.GenTexture();	
				Assert.AreNotEqual(0, textureObject);
				// Note: fails? I misunderstood GL specs?
				// Assert.IsFalse(Gl.IsTexture(textureObject));

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
}
