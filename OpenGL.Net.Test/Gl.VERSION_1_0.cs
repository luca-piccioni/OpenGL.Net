
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
	/// Test OpenGL 1.0 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_1_0 : GlTestBase
	{
		/// <summary>
		/// Mainly used for testing glGet using an OpenGL state.
		/// </summary>
		[Test]
		public void TestCullFace()
		{
			foreach (CullFaceMode cullFaceMode in (CullFaceMode[])Enum.GetValues(typeof(CullFaceMode))) {
				int getCullFaceMode;
				int[] getCullFaceModev;

				Gl.CullFace(cullFaceMode);

				getCullFaceMode = 0;
				Gl.Get(GetPName.CullFaceMode, out getCullFaceMode);
				Assert.AreEqual((int)cullFaceMode, getCullFaceMode);

				getCullFaceMode = 0;
				Gl.Get(Gl.CULL_FACE_MODE, out getCullFaceMode);
				Assert.AreEqual((int)cullFaceMode, getCullFaceMode);

				getCullFaceModev = new int[1];
				Gl.Get(GetPName.CullFaceMode, getCullFaceModev);
				Assert.AreEqual((int)cullFaceMode, getCullFaceModev[0]);

				getCullFaceModev = new int[1];
				Gl.Get(Gl.CULL_FACE_MODE, getCullFaceModev);
				Assert.AreEqual((int)cullFaceMode, getCullFaceModev[0]);
			}
		}
	}
}
