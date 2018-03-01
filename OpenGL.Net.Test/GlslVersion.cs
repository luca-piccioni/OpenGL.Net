
// Copyright (C) 2018 Luca Piccioni
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
using System.Collections.Generic;
using Khronos;
using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class GlslVersionTest
	{
		[Test]
		public void GlslVersion_Constructor1()
		{
			Assert.Throws<ArgumentNullException>(() => new GlslVersion(1, 1, null));
			Assert.Throws<ArgumentException>(() => new GlslVersion(1, -1, "api"));

			GlslVersion version;

			version = new GlslVersion(1, 5, "api");
			Assert.AreEqual(1, version.Major);
			Assert.AreEqual(5, version.Minor);
			Assert.AreEqual(0, version.Revision);
			Assert.AreEqual(150, version.VersionId);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, null);
		}

		[Test, TestCaseSource(nameof(GlslVersion_Parse_CasesSource))]
		public void GlslVersion_Parse(string input, GlslVersion result)
		{
			Assert.Throws<ArgumentNullException>(() =>  GlslVersion.Parse(null));

			Assert.AreEqual(result, GlslVersion.Parse(input));
		}

		private static IEnumerable<object> GlslVersion_Parse_CasesSource
		{
			get
			{
				yield return new object[] { "1.5", new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "1.5.0", new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "1.5.1", new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "1.5.0 ES", new GlslVersion(1, 5, KhronosVersion.ApiEssl) };
				yield return new object[] { "1.5.0 ES2", new GlslVersion(1, 5, KhronosVersion.ApiEssl) };
				yield return new object[] { "4.5.0 NVIDIA", new GlslVersion(4, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "4.50 NVIDIA", new GlslVersion(4, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "4.50 NVIDIA ES", new GlslVersion(4, 5, KhronosVersion.ApiEssl) };
			}
		}

		[Test, TestCaseSource(nameof(GlslVersion_ParseApi_CasesSource))]
		public void GlslVersion_ParseApi(string input, string api, GlslVersion result)
		{
			Assert.Throws<ArgumentNullException>(() =>  GlslVersion.Parse(null, null));
			Assert.Throws<ArgumentException>(() =>  GlslVersion.Parse("1", null));
			Assert.Throws<NotSupportedException>(() =>  GlslVersion.Parse("1.5", "unknown"));

			Assert.AreEqual(result, GlslVersion.Parse(input, api));
		}

		private static IEnumerable<object> GlslVersion_ParseApi_CasesSource
		{
			get
			{
				yield return new object[] { "1.5", null, new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "1.5", KhronosVersion.ApiGlsl, new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };
				yield return new object[] { "1.5", KhronosVersion.ApiGl, new GlslVersion(1, 5, KhronosVersion.ApiGlsl) };

				yield return new object[] { "1.5", KhronosVersion.ApiEssl, new GlslVersion(1, 5, KhronosVersion.ApiEssl) };
				yield return new object[] { "1.5", KhronosVersion.ApiGles2, new GlslVersion(1, 5, KhronosVersion.ApiEssl) };
				yield return new object[] { "1.5", KhronosVersion.ApiGlsc2, new GlslVersion(1, 5, KhronosVersion.ApiEssl) };
			}
		}
	}
}
