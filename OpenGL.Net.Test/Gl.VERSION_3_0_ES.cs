
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

using System;
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 1.0 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_3_0_ES : Gl_VERSION_3_0
	{
		[Test]
		public void TestEglAvailable() { Assert.IsTrue(Egl.IsAvailable); }

		/// <summary>
		/// Determine whether this test is testing OpenGL ES API.
		/// </summary>
		protected override bool IsEsTest
		{
			get { return (true); }
		}
	}
}
