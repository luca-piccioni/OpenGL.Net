
// Copyright (C) 2017 Luca Piccioni
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
using System.Reflection;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture(Category = "Framework_KhronosApi")]
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
