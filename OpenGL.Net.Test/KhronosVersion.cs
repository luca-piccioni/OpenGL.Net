
// Copyright (C) 2017-2018 Luca Piccioni
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
using System.Diagnostics.CodeAnalysis;
using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	[SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
	[SuppressMessage("ReSharper", "EqualExpressionComparison")]
	[SuppressMessage("ReSharper", "UnusedVariable")]
	internal class KhronosVersionTest
	{
		[Test]
		public void KhronosVersion_Constructor1()
		{
			KhronosVersion version;

			version = new KhronosVersion(1, 0, "api");
			Assert.AreEqual(version.Major, 1);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 0);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, null);
		}

		[Test]
		public void KhronosVersion_Constructor2()
		{
			KhronosVersion version;

			version = new KhronosVersion(1, 0, 3, "api");
			Assert.AreEqual(version.Major, 1);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 3);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, null);
		}

		[Test]
		public void KhronosVersion_Constructor3()
		{
			Assert.Throws<ArgumentNullException>(() => new KhronosVersion(1, 1, 2, null, "prof"));
			Assert.Throws<ArgumentException>(() => new KhronosVersion(-1, 1, 2, "api", "prof"));
			Assert.Throws<ArgumentException>(() => new KhronosVersion(1, -1, 2, "api", "prof"));
			Assert.Throws<ArgumentException>(() => new KhronosVersion(1, 1, -2, "api", "prof"));

			KhronosVersion version = new KhronosVersion(2, 0, 4, "api", "prof");
			Assert.AreEqual(version.Major, 2);
			Assert.AreEqual(version.Minor, 0);
			Assert.AreEqual(version.Revision, 4);
			Assert.AreEqual(version.Api, "api");
			Assert.AreEqual(version.Profile, "prof");
		}

		[Test]
		public void KhronosVersion_Constructor4()
		{
			Assert.Throws<ArgumentNullException>(() => new KhronosVersion(null, "prof"));

			KhronosVersion baseVersion = new KhronosVersion(1, 2, 3, "api");

			KhronosVersion version = new KhronosVersion(baseVersion, "prof");
			Assert.AreEqual(baseVersion.Major, version.Major);
			Assert.AreEqual(baseVersion.Minor, version.Minor);
			Assert.AreEqual(baseVersion.Revision, version.Revision);
			Assert.AreEqual(baseVersion.Api, version.Api);
			Assert.AreEqual("prof", version.Profile);

			Assert.DoesNotThrow(() => new KhronosVersion(baseVersion, null));
		}

		[Test]
		public void KhronosVersion_VersionID()
		{
			Assert.AreEqual(110, new KhronosVersion(1, 1, KhronosVersion.ApiGl).VersionId);
			Assert.AreEqual(120, new KhronosVersion(1, 2, 1, KhronosVersion.ApiGl).VersionId);
			Assert.AreEqual(460, new KhronosVersion(4, 6, KhronosVersion.ApiGl).VersionId);
		}

		[Test]
		public void KhronosVersion_OperatorEquality()
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

		[Test]
		public void KhronosVersion_OperatorInequality()
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

		[Test]
		public void KhronosVersion_OperatorGreater()
		{
			KhronosVersion a, b;

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 1, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 2, 0, KhronosVersion.ApiWgl);
				bool ret = a > b;
			});

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a > null);
			Assert.IsFalse(null > a);
			Assert.IsFalse(a > a);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a > b);

			b = new KhronosVersion(0, 9, 0, "api");
			Assert.IsTrue(a > b);

			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsFalse(a > b);
		}

		[Test]
		public void KhronosVersion_OperatorLess()
		{
			KhronosVersion a, b;

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 1, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 2, 0, KhronosVersion.ApiWgl);
				bool ret = a < b;
			});

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a < null);
			Assert.IsFalse(null < a);
			Assert.IsFalse(a < a);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a < b);

			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsTrue(a < b);

			b = new KhronosVersion(0, 9, 0, "api");
			Assert.IsFalse(a < b);
		}

		[Test]
		public void KhronosVersion_OperatorGreaterOrEquals()
		{
			KhronosVersion a, b;

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 1, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 2, 0, KhronosVersion.ApiWgl);
				bool ret = a >= b;
			});

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a >= null);
			Assert.IsFalse(null >= a);
			Assert.IsTrue(a >= a);

			b = new KhronosVersion(0, 9, 0, "api");
			Assert.IsTrue(a >= b);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsTrue(a >= b);

			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsFalse(a >= b);
		}

		[Test]
		public void KhronosVersion_OperatorLessOrEquals()
		{
			KhronosVersion a, b;

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 1, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 2, 0, KhronosVersion.ApiWgl);
				bool ret = a <= b;
			});

			a = new KhronosVersion(1, 0, 0, "api");
			Assert.IsFalse(a <= null);
			Assert.IsFalse(null <= a);
			Assert.IsTrue(a <= a);

			b = new KhronosVersion(1, 1, 0, "api");
			Assert.IsTrue(a <= b);

			b = new KhronosVersion(1, 0, 0, "api");
			Assert.IsTrue(a <= b);

			b = new KhronosVersion(0, 9, 0, "api");
			Assert.IsFalse(a <= b);
		}

		[Test]
		public void KhronosVersion_ParseFeature()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosVersion.ParseFeature(null));

			Assert.AreEqual(new KhronosVersion(1, 0, KhronosVersion.ApiGl), KhronosVersion.ParseFeature("GL_VERSION_1_0"));
			Assert.AreEqual(new KhronosVersion(2, 1, KhronosVersion.ApiGl), KhronosVersion.ParseFeature("GL_VERSION_2_1"));
			Assert.AreEqual(new KhronosVersion(1, 4, KhronosVersion.ApiEgl), KhronosVersion.ParseFeature("EGL_VERSION_1_4"));
			Assert.AreEqual(new KhronosVersion(1, 4, KhronosVersion.ApiGlx), KhronosVersion.ParseFeature("GLX_VERSION_1_4"));
			Assert.AreEqual(new KhronosVersion(1, 0, KhronosVersion.ApiWgl), KhronosVersion.ParseFeature("WGL_VERSION_1_0"));
			Assert.AreEqual(new KhronosVersion(1, 0, KhronosVersion.ApiGles1), KhronosVersion.ParseFeature("GL_VERSION_ES_CM_1_0"));
			Assert.AreEqual(new KhronosVersion(3, 2, KhronosVersion.ApiGles2), KhronosVersion.ParseFeature("GL_ES_VERSION_3_2"));
			Assert.AreEqual(new KhronosVersion(2, 0, KhronosVersion.ApiGlsc2), KhronosVersion.ParseFeature("GL_SC_VERSION_2_0"));
		}

		[Test]
		public void KhronosVersion_Parse1()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosVersion.Parse(null));
			Assert.Throws<ArgumentException>(() => KhronosVersion.Parse("3"));
			Assert.Throws<ArgumentException>(() => KhronosVersion.Parse("4a"));

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

			// Parse 1.y.z ES
			v = KhronosVersion.Parse("1.0 ES");
			Assert.AreEqual(1, v.Major);
			Assert.AreEqual(0, v.Minor);
			Assert.AreEqual(0, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGles1, v.Api);
			Assert.AreEqual(null, v.Profile);

			// Parse x.yz
			v = KhronosVersion.Parse("4.50");
			Assert.AreEqual(4, v.Major);
			Assert.AreEqual(5, v.Minor);
			Assert.AreEqual(0, v.Revision);
			Assert.AreEqual(KhronosVersion.ApiGl, v.Api);
			Assert.AreEqual(null, v.Profile);
		}

		[Test]
		public void KhronosVersion_Parse2()
		{
			Assert.Throws<ArgumentNullException>(() => KhronosVersion.Parse(null, KhronosVersion.ApiEgl));

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

		[Test]
		public void KhronosVersion_IsCompatible()
		{
			KhronosVersion v = new KhronosVersion(1, 0, KhronosVersion.ApiGl);

			Assert.Throws<ArgumentNullException>(() => v.IsCompatible(null));
			Assert.IsTrue(v.IsCompatible(v));
			Assert.IsFalse(v.IsCompatible(new KhronosVersion(1, 0, KhronosVersion.ApiEgl)));
			Assert.IsFalse(v.IsCompatible(new KhronosVersion(2, 0, KhronosVersion.ApiGl)));
			Assert.IsFalse(v.IsCompatible(new KhronosVersion(1, 1, KhronosVersion.ApiGl)));
			Assert.IsFalse(v.IsCompatible(new KhronosVersion(1, 0, 1, KhronosVersion.ApiGl)));
		}

		[Test]
		[SuppressMessage("ReSharper", "ReturnValueOfPureMethodIsNotUsed")]
		public void KhronosVersion_ToString()
		{
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, KhronosVersion.ApiGl).ToString());
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl).ToString());
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl, null).ToString());
			Assert.DoesNotThrow(() => new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility).ToString());
			Assert.DoesNotThrow(() => new KhronosVersion(Gl.Version_150, KhronosVersion.ProfileCompatibility).ToString());

			Assert.AreEqual("Version=1.0 API=gl", new KhronosVersion(1, 0, KhronosVersion.ApiGl).ToString());
			Assert.AreEqual("Version=2.0 API=egl", new KhronosVersion(2, 0, KhronosVersion.ApiEgl).ToString());
			Assert.AreEqual("Version=1.0.3 API=gl", new KhronosVersion(1, 0, 3, KhronosVersion.ApiGl).ToString());
			Assert.AreEqual("Version=3.2 API=gl Profile=compatibility",  new KhronosVersion(3, 2, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility).ToString());
		}

		class DerivedVersion : KhronosVersion
		{
			public DerivedVersion() : base(1, 0, ApiGl) { }
		}

		[Test]
		public void KhronosVersion_EqualsKhronosVersion()
		{
			KhronosVersion v = new KhronosVersion(1, 0, KhronosVersion.ApiGl);

			Assert.IsFalse(v.Equals(null));
			Assert.IsTrue(v.Equals(new DerivedVersion()));
			Assert.IsTrue(v.Equals(v));

			Assert.IsFalse(v.Equals(new KhronosVersion(1, 0, KhronosVersion.ApiEgl)));
			Assert.IsFalse(v.Equals(new KhronosVersion(2, 0, KhronosVersion.ApiGl)));
			Assert.IsFalse(v.Equals(new KhronosVersion(1, 1, KhronosVersion.ApiGl)));
			Assert.IsFalse(v.Equals(new KhronosVersion(1, 0, 1, KhronosVersion.ApiGl)));

			// No profile matches versions with profile
			Assert.IsTrue(v.Equals(new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCore)));
			// If profile defined, it must match
			Assert.IsTrue(
				new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility).Equals(
				new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility))
			);
			Assert.IsFalse(
				new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCompatibility).Equals(
				new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl, KhronosVersion.ProfileCore))
			);
		}

		[Test]
		[SuppressMessage("ReSharper", "SuspiciousTypeConversion.Global")]
		public void KhronosVersion_EqualsObject()
		{
			KhronosVersion v;

			v = new KhronosVersion(1, 0, KhronosVersion.ApiGl);
			Assert.IsFalse(v.Equals((object)null));
			Assert.IsFalse(v.Equals(1));
			Assert.IsFalse(v.Equals(new Vertex4f()));
			Assert.IsTrue(v.Equals((object)new DerivedVersion()));
			Assert.IsTrue(v.Equals((object)v));
		}

#if !MONODROID

		[Test]
		public void KhronosVersion_HashCode()
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

		[Test]
		public void KhronosVersion_CompareTo()
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
				// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
				a.CompareTo(b);
			});

			Assert.Throws(typeof(InvalidOperationException), () => {
				a = new KhronosVersion(1, 0, 0, KhronosVersion.ApiGl);
				b = new KhronosVersion(1, 0, 0, KhronosVersion.ApiWgl);
				// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
				a.CompareTo(b);
			});

			// Profile does not affect comparison


		}
	}
}
