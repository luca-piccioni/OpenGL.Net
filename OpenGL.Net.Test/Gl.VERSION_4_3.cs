
// Copyright (C) 2015-2017 Luca Piccioni
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
	/// <summary>
	/// Test OpenGL 4.3 API.
	/// </summary>
	[TestFixture]
	[Category("GL_VERSION_4_3")]
	class Gl_VERSION_4_3 : TestBaseGL
	{
		/// <summary>
		/// Test Gl.GetString.
		/// </summary>
		[Test]
		public void TestGetStringi()
		{
			if (!HasVersion(Gl.Version_430))
				Assert.Inconclusive("OpenGL 4.3 not implemented");

			using (Device device = new Device())
			using (new GLContext(device))
			{

#if !MONODROID

				#region Gl.SHADING_LANGUAGE_VERSION

				int numShadingLanguage;

				Gl.Get(GetPName.NumShadingLanguageVersions, out numShadingLanguage);

				Console.WriteLine("Found {0} GL Shading Language versions:", numShadingLanguage);
				for (uint i = 0; i < (uint)numShadingLanguage; i++) {
					string shadingLanguageVersion = Gl.GetString(StringName.ShadingLanguageVersion, i);
					Console.WriteLine("- {0}", shadingLanguageVersion);
				}

				#endregion

#endif

			}
		}
	}
}
