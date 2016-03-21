
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

using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test GraphicsContext class.
	/// </summary>
	[TestFixture]
	class GraphicsContextTest : TestBase
	{
		[Test, TestCaseSource("KnownVersions")]
		public void TestConstructionByVersion(KhronosVersion version)
		{
			if (version > GraphicsContext.CurrentVersion)
				Assert.Inconclusive();

			using (GraphicsContext ctx = new GraphicsContext(null, version)) {
				Assert.IsTrue(ctx.Version >= version);
			}
		}

		private KhronosVersion[] KnownVersions
		{
			get
			{
				List<KhronosVersion> knownVersions = new List<KhronosVersion>();

				knownVersions.Add(new KhronosVersion(1, 0, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(1, 1, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(1, 2, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(1, 3, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(1, 4, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(1, 5, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(2, 0, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(2, 1, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(3, 0, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(3, 1, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(3, 2, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(3, 3, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 0, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 1, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 2, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 3, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 4, KhronosVersion.ApiGl));
				knownVersions.Add(new KhronosVersion(4, 5, KhronosVersion.ApiGl));

				return (knownVersions.ToArray());
			}
			
		}

		/// <summary>
		/// Test version properties.
		/// </summary>
		[Test]
		public void TestVersion()
		{
			// Static information
			Assert.IsNotNull(GraphicsContext.CurrentVersion);
			Assert.IsNotNull(GraphicsContext.CurrentShadingVersion);

			Assert.IsNotNull(_Context.Version);
			Assert.IsNotNull(_Context.ShadingVersion);
		}

		/// <summary>
		/// Test.
		/// </summary>
		[Test]
		public void TestCurrency()
		{
			// Initially the context is current on test thread
			Assert.IsTrue(_Context.IsCurrent);

			_Context.MakeCurrent(false);
			Assert.IsFalse(_Context.IsCurrent);

			_Context.MakeCurrent(true);
			Assert.IsTrue(_Context.IsCurrent);

			Assert.AreSame(_Context, GraphicsContext.GetCurrentContext());

			_Context.MakeCurrent(false);
			Assert.AreSame(null, GraphicsContext.GetCurrentContext());
		}
	}
}
