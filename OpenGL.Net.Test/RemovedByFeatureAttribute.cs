// Copyright (C) 2017 Luca Piccioni
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

using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	class RemovedByFeatureAttributeTest
	{
		[Test(Description = "Test RemovedByFeatureAttribute(string featureName)")]
		[TestCase("GL_VERSION_1_0", 1, 0, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_1_1", 1, 1, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_1_2", 1, 2, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_1_3", 1, 3, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_1_4", 1, 4, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_1_5", 1, 5, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_2_0", 2, 0, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_2_1", 2, 1, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_3_0", 3, 0, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_3_1", 3, 1, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_3_2", 3, 2, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_0", 4, 0, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_1", 4, 1, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_2", 4, 2, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_3", 4, 3, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_4", 4, 4, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_4_5", 4, 5, 0, KhronosVersion.ApiGl)]
		[TestCase("GL_VERSION_ES_CM_1_0", 1, 0, 0, KhronosVersion.ApiGles1)]
		[TestCase("GL_ES_VERSION_2_0", 2, 0, 0, KhronosVersion.ApiGles2)]
		[TestCase("GL_ES_VERSION_3_0", 3, 0, 0, KhronosVersion.ApiGles2)]
		[TestCase("GL_ES_VERSION_3_1", 3, 1, 0, KhronosVersion.ApiGles2)]
		[TestCase("GL_ES_VERSION_3_2", 3, 2, 0, KhronosVersion.ApiGles2)]
		[TestCase("GL_SC_VERSION_2_0", 2, 0, 0, KhronosVersion.ApiGlsc2)]
		public void RemovedByFeatureAttribute_Constructor1(string feature, int major, int minor, int revision, string api)
		{
			RemovedByFeatureAttribute a = new RemovedByFeatureAttribute(feature);

			Assert.AreEqual(feature, a.FeatureName);
			Assert.IsNotNull(a.FeatureVersion);
			Assert.AreEqual(new KhronosVersion(major, minor, revision, api), a.FeatureVersion);
			Assert.IsNull(a.FeatureVersion.Profile);

			// a.Api does not follow a.FeatureVersion.Api: code generator must always specify Api explictly
			Assert.AreEqual(KhronosVersion.ApiGl, a.Api);
		}

		[Test(Description = "Test RemovedByFeatureAttribute(string featureName)")]
		[TestCase("GL_3DFX_multisample")]
		[TestCase("GL_ARB_multisample")]
		[TestCase("AnythingThanFeatures")]
		public void RemovedByFeatureAttribute_Constructor2(string feature)
		{
			RemovedByFeatureAttribute a = new RemovedByFeatureAttribute(feature);

			Assert.AreEqual(feature, a.FeatureName);
			Assert.IsNull(a.FeatureVersion);
			Assert.IsNull(a.Profile);

			// a.Api does not follow a.FeatureVersion.Api: code generator must always specify Api explictly
			Assert.AreEqual(KhronosVersion.ApiGl, a.Api);
		}

		[Test(Description = "Test RemovedByFeatureAttribute(string featureName) ArgumentException")]
		[TestCase(null)]
		[TestCase("")]
		public void RemovedByFeatureAttribute_Constructor1_ArgumentException(string feature)
		{
			Assert.Throws<ArgumentException>(() => new RemovedByFeatureAttribute(feature));
		}

		[Test(Description = "Test IsRemoved(KhronosVersion version, KhronosApi.ExtensionsCollection extensions)")]
		public void RemovedByFeatureAttribute_IsRemoved()
		{
			RemovedByFeatureAttribute a;

			// Version
			a = new RemovedByFeatureAttribute("GL_VERSION_1_1");
			Assert.IsTrue(a.IsRemoved(Gl.Version_110, null));
			Assert.IsFalse(a.IsRemoved(Gl.Version_100, null));

			// All versions greater than the requirement are supported
			Assert.IsTrue(a.IsRemoved(Gl.Version_120, null));
			Assert.IsTrue(a.IsRemoved(Gl.Version_200, null));
			Assert.IsTrue(a.IsRemoved(Gl.Version_450, null));

			// a.FeatureVersion.Profile is null: any profile match
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_110, KhronosVersion.ProfileCompatibility), null));

			a = new RemovedByFeatureAttribute("GL_VERSION_3_2");
			a.Profile = KhronosVersion.ProfileCompatibility;

			// a.FeatureVersion.Profile is not null: specific profile match...
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCompatibility), null));
			Assert.IsFalse(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), null));
			// ...and even unspecified profile
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_320, null), null));

			// a.Api must match (no regex)
			Assert.IsFalse(a.IsRemoved(new KhronosVersion(Gl.Version_320_ES, KhronosVersion.ProfileCore), null));

			// Extension
			a = new RemovedByFeatureAttribute("GL_ARB_multisample");
			Assert.IsFalse(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), null));

			Gl.Extensions extensions = new Gl.Extensions();

			Assert.IsFalse(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), extensions));

			extensions.EnableExtension("GL_ARB_multisample");
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), extensions));
			// Note: extensions.MultisampleARB is not altered by EnableExtension

			// Version/Profile
			a = new RemovedByFeatureAttribute("GL_VERSION_3_2");
			a.Profile = "core|compatibility";
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), null));
			Assert.IsTrue(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCompatibility), null));
			Assert.IsFalse(a.IsRemoved(new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCommon), null));
		}

		[Test(Description = "Test IsSupported(KhronosVersion version, KhronosApi.ExtensionsCollection extensions) ArgumentNullException")]
		public void RemovedByFeatureAttribute_IsSupported_ArgumentNullException()
		{
			RemovedByFeatureAttribute a = new RemovedByFeatureAttribute("GL_VERSION_1_0");
			Gl.Extensions extensions = new Gl.Extensions();
			
			Assert.DoesNotThrow(() => a.IsRemoved(Gl.Version_100, extensions));
			Assert.DoesNotThrow(() => a.IsRemoved(Gl.Version_100, null));

			Assert.Throws<ArgumentNullException>(() => a.IsRemoved(null, extensions));
		}
	}
}
