
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

		private KhronosVersion[] KnownVersions
		{
			get
			{
				List<KhronosVersion> knownVersions = new List<KhronosVersion>();

				knownVersions.Add(Gl.Version_100);
				knownVersions.Add(Gl.Version_110);
				knownVersions.Add(Gl.Version_120);
				knownVersions.Add(Gl.Version_130);
				knownVersions.Add(Gl.Version_140);
				knownVersions.Add(Gl.Version_150);
				knownVersions.Add(Gl.Version_200);
				knownVersions.Add(Gl.Version_210);
				knownVersions.Add(Gl.Version_300);
				knownVersions.Add(Gl.Version_310);
				knownVersions.Add(Gl.Version_320);
				knownVersions.Add(Gl.Version_330);
				knownVersions.Add(Gl.Version_400);
				knownVersions.Add(Gl.Version_410);
				knownVersions.Add(Gl.Version_420);
				knownVersions.Add(Gl.Version_430);
				knownVersions.Add(Gl.Version_440);
				knownVersions.Add(Gl.Version_450);

				return (knownVersions.ToArray());
			}
			
		}

		/// <summary>
		/// Test version properties.
		/// </summary>
		[Test]
		public void TestVersion()
		{
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
