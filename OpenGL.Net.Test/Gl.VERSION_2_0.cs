
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
	/// Test OpenGL 2.0 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_2_0 : GlTestBase
	{
		/// <summary>
		/// Test Gl.CreateProgram.
		/// </summary>
		[Test]
		public void TestCreateProgram()
		{
			if (!HasVersion(2, 0))
				Assert.Inconclusive("OpenGL 2.0");

			uint program = Gl.CreateProgram();
			try {
				Assert.AreNotEqual(0, program, "Gl.CreateProgram failure");
				Assert.IsTrue(Gl.IsProgram(program));
			} finally {
				if (program != 0) {
					Gl.DeleteProgram(program);
					// Assert.IsFalse(Gl.IsProgram(program), "Gl.DeleteProgram failure");
				}
			}
		}

		/// <summary>
		/// Test Gl.CreateProgram.
		/// </summary>
		[Test]
		public void TestCreateShader()
		{
			if (!HasVersion(2, 0))
				Assert.Inconclusive("OpenGL 2.0");

			uint shader = Gl.CreateShader(Gl.VERTEX_SHADER);
			try {
				Assert.AreNotEqual(0, shader, "Gl.CreateShader failure");
				Assert.IsTrue(Gl.IsShader(shader));

				int shaderGet;

				Gl.GetShader(shader, Gl.SHADER_TYPE, out shaderGet);
				Assert.AreEqual(Gl.VERTEX_SHADER, shaderGet);
				Gl.GetShader(shader, Gl.DELETE_STATUS, out shaderGet);
				Assert.AreEqual(Gl.FALSE, shaderGet);
				Gl.GetShader(shader, Gl.COMPILE_STATUS, out shaderGet);
				Assert.AreEqual(Gl.FALSE, shaderGet);

			} finally {
				if (shader != 0) {
					Gl.DeleteShader(shader);
					// Assert.IsFalse(Gl.IsShader(shader), "Gl.DeleteShader failure");
				}
			}
		}
	}
}
