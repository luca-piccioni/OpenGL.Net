
// Copyright (C) 2016 Luca Piccioni
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

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test ShadersLibrary class.
	/// </summary>
	[TestFixture]
	class ShadersLibraryTest : TestBase
	{
		[Test(Description = "Test CreateProgram(string)")]
		[TestCaseSource("ProgramIds")]
		public void TestCreateProgram(string programId)
		{
			ShadersLibrary.Program shaderProgramInfo = ShadersLibrary.Instance.GetProgram(programId);
			Assert.IsNotNull(shaderProgramInfo);

			//ShaderProgram shaderProgram = ShadersLibrary.Instance.CreateProgram(programId);
			//try {
			//	Assert.IsNotNull(shaderProgram);
			//	Assert.DoesNotThrow(delegate { shaderProgram.Create(_Context); });

			//	Assert.AreEqual(shaderProgramInfo.Attributes.Count, shaderProgram.ActiveAttributes.Count);
			//	foreach (ShadersLibrary.Program.Attribute attribute in shaderProgramInfo.Attributes) {
			//		Assert.IsTrue(shaderProgram.IsActiveAttribute(attribute.Name));
			//		Assert.AreEqual(attribute.Semantic, shaderProgram.GetAttributeSemantic(attribute.Name));
			//	}

			//	Assert.AreEqual(shaderProgramInfo.Uniforms.Count, shaderProgram.ActiveUniforms.Count);
			//	foreach (ShadersLibrary.Program.Uniform uniform in shaderProgramInfo.Uniforms) {
			//		Assert.IsTrue(shaderProgram.IsActiveUniform(uniform.Name));
			//	}
			//} finally {
			//	if (shaderProgram != null)
			//		shaderProgram.Dispose();
			//}
		}

		public string[] ProgramIds
		{
			get
			{
				List<string> programIds = new List<string>();

				programIds.Add("OpenGL.Standard");
				programIds.Add("OpenGL.Standard+Color");
				programIds.Add("OpenGL.Standard+VertexLighting");
				programIds.Add("OpenGL.CubeMapping");

				return (programIds.ToArray());
			}
		}

		[Test(Description = "Test ShaderLibrary objects compilation")]
		[TestCaseSource("ObjectIds")]
		public void TestCreateObject(string objectId)
		{
			ShadersLibrary.Object shaderObjectInfo = ShadersLibrary.Instance.GetObject(objectId);
			Assert.IsNotNull(shaderObjectInfo);

			ShaderObject shaderObject = shaderObjectInfo.Create();
			try {
				Assert.IsNotNull(shaderObject);
				Assert.DoesNotThrow(delegate { shaderObject.Create(_Context); });
			} finally {
				if (shaderObject != null)
					shaderObject.Dispose();
			}
		}

		public string[] ObjectIds
		{
			get
			{
				return (ShadersLibrary.Instance.Objects.ConvertAll(delegate (ShadersLibrary.Object item) { return (item.Path); }).ToArray());
			}
		}
	}
}
