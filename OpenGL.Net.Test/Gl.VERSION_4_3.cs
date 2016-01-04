
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

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 4.3 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_4_3 : GlTestBase
	{
		/// <summary>
		/// Test Gl.GetString.
		/// </summary>
		[Test]
		public void TestGetStringi()
		{
			if (!HasVersion(4, 3))
				Assert.Inconclusive("OpenGL 4.3 not implemented");

			#region Gl.SHADING_LANGUAGE_VERSION

			int numShadingLanguage;

			Gl.Get(GetPName.NumShadingLanguageVersions, out numShadingLanguage);

			Console.WriteLine("Found {0} GL Shading Language versions:", numShadingLanguage);
			for (uint i = 0; i < (uint)numShadingLanguage; i++) {
				string shadingLanguageVersion = Gl.GetString((int)StringName.ShadingLanguageVersion, i);
				Console.WriteLine("- {0}", shadingLanguageVersion);
			}

			#endregion
		}
	}
}
