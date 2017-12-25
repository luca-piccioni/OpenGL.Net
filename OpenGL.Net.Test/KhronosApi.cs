
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

#pragma warning disable 649

using System;
using System.Reflection;

using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	class KhronosApiTest
	{
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_4_3", Profile = "core")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug")]
		[RequiredByFeature("GL_KHR_debug", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2", Profile = "core")]
		public static IntPtr GetPointer;

		[Test]
		public void TestIsCompatibleField()
		{
			FieldInfo fi = typeof(KhronosApiTest).GetField("GetPointer", BindingFlags.Static | BindingFlags.Public);
			Gl.Extensions extensions = new Gl.Extensions();

			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, Gl.Version_100, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_110, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_150, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_210, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_300, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_310, extensions));

			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCore), extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_400, KhronosVersion.ProfileCore), extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_410, KhronosVersion.ProfileCore), extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_420, KhronosVersion.ProfileCore), extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_430, KhronosVersion.ProfileCore), extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_440, KhronosVersion.ProfileCore), extensions));

			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_320, KhronosVersion.ProfileCompatibility), extensions));
			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_400, KhronosVersion.ProfileCompatibility), extensions));
			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_410, KhronosVersion.ProfileCompatibility), extensions));
			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_420, KhronosVersion.ProfileCompatibility), extensions));
			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_430, KhronosVersion.ProfileCompatibility), extensions));
			Assert.IsTrue(KhronosApi.IsCompatibleField(fi, new KhronosVersion(Gl.Version_440, KhronosVersion.ProfileCompatibility), extensions));

			// Not sure how Profile can affect this...
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_100_ES, extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, Gl.Version_200_ES, extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, Gl.Version_300_ES, extensions));
			Assert.IsFalse(KhronosApi.IsCompatibleField(fi, Gl.Version_310_ES, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_320_ES, extensions));

			extensions.EnableExtension("GL_EXT_vertex_array");
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_100, extensions));

			extensions.EnableExtension("GL_KHR_debug");
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_100, extensions));
			Assert.IsTrue (KhronosApi.IsCompatibleField(fi, Gl.Version_200_ES, extensions));
		}
	}
}
