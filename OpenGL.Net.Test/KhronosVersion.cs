
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
using System.Collections.Generic;

using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	class KhronosVersionTest
	{
		[Test(Description = "Test KhronosVersion(int major, int minor, string api)")]
		public void TestConstructor1()
		{
			KhronosVersion version;

			version = new KhronosVersion(1, 0, "api");
			Assert.AreEqual(version.Major, 1);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 0);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, null);
		}

		[Test(Description = "Test KhronosVersion(int major, int minor, int revision, string api)")]
		public void TestConstructor2()
		{
			KhronosVersion version;

			version = new KhronosVersion(1, 0, 3, "api");
			Assert.AreEqual(version.Major, 1);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 3);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, null);
		}

		[Test(Description = "Test KhronosVersion(int major, int minor, int revision, string api, string profile)")]
		public void TestConstructor3()
		{
			KhronosVersion version;

			version = new KhronosVersion(2, 0, 4, "api", "prof");
			Assert.AreEqual(version.Major, 2);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 4);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, "prof");
		}

		[Test(Description = "Test KhronosVersion(int major, int minor, int revision, string api, string profile) ArgumentException")]
		[TestCase(0, 1, 2)]
		[TestCase(1, -1, 2)]
		[TestCase(1, 1, -2)]
		public void TestConstructor3_ArgumentException(int major, int minor, int revision)
		{
			Assert.Throws<ArgumentException>(() => new KhronosVersion(major, minor, revision, "api", "prof"));
		}

		[Test(Description = "Test KhronosVersion(int major, int minor, int revision, string api, string profile) ArgumentNullException")]
		[TestCase(null, "prof")]
		public void TestConstructor3_ArgumentNullException(string api, string profile)
		{
			Assert.Throws<ArgumentNullException>(() => new KhronosVersion(1, 1, 2, api, profile));
		}

		[Test(Description = "Test KhronosVersion(KhronosVersion other, string profile)")]
		public void TestConstructor4()
		{
			KhronosVersion baseVersion = new KhronosVersion(1, 2, 3, "api");
			KhronosVersion version;

			version = new KhronosVersion(baseVersion, "prof");
			Assert.AreEqual(baseVersion.Major, version.Major);
			Assert.AreEqual(baseVersion.Minor, version.Minor);
			Assert.AreEqual(baseVersion.Revision, version.Revision);
			Assert.AreEqual(baseVersion.Api, version.Api);
			Assert.AreEqual("prof", version.Profile);

			Assert.DoesNotThrow(delegate() { new KhronosVersion(baseVersion, null); });
		}

		[Test(Description = "Test KhronosVersion(KhronosVersion other, string profile) ArgumentNullException")]
		public void TestConstructor4_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => new KhronosVersion(null, "prof"));
		}

		[Test(Description = "Test KhronosVersion.operator==")]
		public void TestOperatorEquality()
		{
			KhronosVersion a, b;

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a == null);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsTrue(a == b);

			// a.Major not matching
			b = new KhronosVersion(2, 0, 0, "api");
			Assert.IsFalse(a == b);

			// a.Minor not matching
			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsFalse(a == b);

			// a.Revision not matching
			b = new KhronosVersion(1, 0, 1, "api");
			Assert.IsFalse(a == b);

			// a.Api is not matching
			b = new KhronosVersion(1, 0, 0, "api2");
			Assert.IsFalse(a == b);

			// a.Profile is null: match any profile
			a = new KhronosVersion(1, 0, 0, "api", null);
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsTrue(a == b);

			// b.Profile is null: match any profile
			a = new KhronosVersion(1, 0, 0, "api", "profile");
			b = new KhronosVersion(1, 0, 0, "api", null);
			Assert.IsTrue(a == b);

			// a.Profile/b.Profile are not null: match profile also
			a = new KhronosVersion(1, 0, 0, "api", "profile");
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsTrue(a == b);

			// a.Profile is not matching
			a = new KhronosVersion(1, 0, 0, "api", "profile2");
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsFalse(a == b);
		}

		[Test(Description = "Test KhronosVersion.operator!=")]
		public void TestOperatorInequality()
		{
			KhronosVersion a, b;

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsTrue(a != null);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a != b);

			// a.Major not matching
			b = new KhronosVersion(2, 0, 0, "api");
			Assert.IsTrue(a != b);

			// a.Minor not matching
			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsTrue(a != b);

			// a.Revision not matching
			b = new KhronosVersion(1, 0, 1, "api");
			Assert.IsTrue(a != b);

			// a.Api is not matching
			b = new KhronosVersion(1, 0, 0, "api2");
			Assert.IsTrue(a != b);

			// a.Profile is null: match any profile
			a = new KhronosVersion(1, 0, 0, "api", null);
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsFalse(a != b);

			// b.Profile is null: match any profile
			a = new KhronosVersion(1, 0, 0, "api", "profile");
			b = new KhronosVersion(1, 0, 0, "api", null);
			Assert.IsFalse(a != b);

			// a.Profile/b.Profile are not null: match profile also
			a = new KhronosVersion(1, 0, 0, "api", "profile");
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsFalse(a != b);

			// a.Profile is not matching
			a = new KhronosVersion(1, 0, 0, "api", "profile2");
			b = new KhronosVersion(1, 0, 0, "api", "profile");
			Assert.IsTrue(a != b);
		}

		[Test(Description = "Parse(string input)")]
		public void TestParse1()
		{
			KhronosVersion v;

			// Parse x.y
			v = KhronosVersion.Parse("3.2");
			Assert.AreEqual(3, v.Major);
			Assert.AreEqual(2, v.Minor);
			Assert.AreEqual(0, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGl, v.Api);
			Assert.AreEqual(null, v.Profile);

			// Parse x.y.z
			v = KhronosVersion.Parse("1.2.1");
			Assert.AreEqual(1, v.Major);
			Assert.AreEqual(2, v.Minor);
			Assert.AreEqual(1, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGl, v.Api);
			Assert.AreEqual(null, v.Profile);

			// Parse x.y.z ES
			v = KhronosVersion.Parse("2.0.17 ES");
			Assert.AreEqual(2, v.Major);
			Assert.AreEqual(0, v.Minor);
			Assert.AreEqual(17, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGles2, v.Api);
			Assert.AreEqual(null, v.Profile);

			// Parse x.y.z ES
			v = KhronosVersion.Parse("4.50");
			Assert.AreEqual(4, v.Major);
			Assert.AreEqual(5, v.Minor);
			Assert.AreEqual(0, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGl, v.Api);
			Assert.AreEqual(null, v.Profile);
		}

		[Test(Description = "Parse(string input) ArgumentNullException")]
		public void TestParse1_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosVersion.Parse(null));
		}

		[Test(Description = "Parse(string input) ArgumentException")]
		[TestCase("3")]
		[TestCase("4a")]
		public void TestParse1_ArgumentException(string pattern)
		{
			Assert.Throws<ArgumentException>(() => KhronosVersion.Parse(pattern));
		}

		[Test(Description = "Parse(string input, string api)")]
		public void TestParse2()
		{
			KhronosVersion v;

			// Parse x.y
			v = KhronosVersion.Parse("1.4", KhronosVersion.ApiEgl);
			Assert.AreEqual(1, v.Major);
			Assert.AreEqual(4, v.Minor);
			Assert.AreEqual(0, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiEgl, v.Api);
			Assert.AreEqual(null, v.Profile);

			// Parse x.y.z
			v = KhronosVersion.Parse("1.5.14", KhronosVersion.ApiEgl);
			Assert.AreEqual(1, v.Major);
			Assert.AreEqual(5, v.Minor);
			Assert.AreEqual(14, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiEgl, v.Api);
			Assert.AreEqual(null, v.Profile);
		}

		[Test(Description = "Parse(string input, string api) ArgumentNullException")]
		public void TestParse2_ArgumentNullException()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosVersion.Parse(null, KhronosVersion.ApiEgl));
		}

		[Test(Description = "ToString()")]
		public void TestToString()
		{
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, KhronosVersion.ApiGl));
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl));
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl, null));
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility));
			Assert.DoesNotThrow(() => new KhronosVersion(Gl.Version_150, KhronosVersion.ProfileCompatibility));
		}

		class DerivedVersion : KhronosVersion
		{
			public DerivedVersion() : base(1, 0, ApiGl) { }
		}

		[Test(Description = "Test Equals(object obj)")]
		public void TestEquals()
		{
			KhronosVersion v;

			v = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			Assert.AreNotEqual(v, null);
			Assert.AreNotEqual(null, v);
			Assert.AreNotEqual(v, 1);
			Assert.AreNotEqual(v, new Vertex4f());
			Assert.AreEqual(v,new DerivedVersion());
			Assert.AreEqual(v, v);
		}

#if !MONODROID

		[Test(Description = "Test GetHashCode()")]
		public void TestHashCode()
		{
			KhronosVersion v;
			List<int> hashes = new List<int>();
			int h;

			v = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 1, KhronosVersion.ApiGl);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 1, 1, KhronosVersion.ApiGl);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 1, 1, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 1, 1, KhronosVersion.ApiGl, KhronosVersion.ProfileCore);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 0, KhronosVersion.ApiWgl);
			CollectionAssert.DoesNotContain(hashes, h = v.GetHashCode());
			hashes.Add(h);

			v = new KhronosVersion(1, 0, KhronosVersion.ApiWgl);
			CollectionAssert.Contains(hashes, h = v.GetHashCode());
			hashes.Add(h);
		}

#endif

		[Test(Description = "CompareTo(KhronosVersion other)")]
		public void TestCompareTo()
		{
			KhronosVersion a, b;

			// Major version
			a = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			b = new KhronosVersion(2, 0, KhronosVersion.ApiGl);
			Assert.IsTrue(0 > a.CompareTo(b));

			a = new KhronosVersion(2, 0, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			Assert.IsTrue(0 < a.CompareTo(b));

			// Minor version
			a = new KhronosVersion(1, 1, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			Assert.IsTrue(0 < a.CompareTo(b));

			a = new KhronosVersion(1, 4, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 2, KhronosVersion.ApiGl);
			Assert.IsTrue(0 < a.CompareTo(b));

			a = new KhronosVersion(1, 4, KhronosVersion.ApiGl);
			b = new KhronosVersion(2, 2, KhronosVersion.ApiGl);
			Assert.IsTrue(0 > a.CompareTo(b));

			// Revision
			a = new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 0, 1, KhronosVersion.ApiGl);
			Assert.IsTrue(0 > a.CompareTo(b));

			a = new KhronosVersion(1, 0, 15, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 0, 1, KhronosVersion.ApiGl);
			Assert.IsTrue(0 < a.CompareTo(b));

			a = new KhronosVersion(1, 0, 15, KhronosVersion.ApiGl);
			b = new KhronosVersion(1, 20, 1, KhronosVersion.ApiGl);
			Assert.IsTrue(0 > a.CompareTo(b));

			a = new KhronosVersion(1, 4, 15, KhronosVersion.ApiGl);
			b = new KhronosVersion(10, 0, 1, KhronosVersion.ApiGl);
			Assert.IsTrue(0 > a.CompareTo(b));

			// Different API
			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 4, 15, KhronosVersion.ApiGl);
				b = new KhronosVersion(10, 0, 1, KhronosVersion.ApiWgl);
				a.CompareTo(b);
			});

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 0, 0, KhronosVersion.ApiWgl);
				a.CompareTo(b);
			});

			// Profile does not affect comparison


		}
	}
}
