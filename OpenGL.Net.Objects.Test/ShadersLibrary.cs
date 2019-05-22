
// Copyright (C) 2016-2019 Luca Piccioni
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
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test ShadersLibrary class.
	/// </summary>
	[TestFixture(Category = @"Objects\ShadersLibrary")]
	class ShadersLibraryTest : TestBase
	{
		[Test]
		public void ShadersLibrary_SaveTo()
		{
			ShadersLibrary shadersLibrary = new ShadersLibrary();

			shadersLibrary.Includes = new List<ShadersLibrary.Include>();
			shadersLibrary.Includes.Add(
				new ShadersLibrary.Include() {
				 Path = "/Absolute/Path/To/Include", Resource = "Some.Resource.Identifier"
				}
			);

			shadersLibrary.Objects = new List<ShadersLibrary.Object>();
			shadersLibrary.Objects.Add(
				new ShadersLibrary.Object() {
					Resource = "Some.Object.Resource",
					TestStage = "VertexShader"
				}
			);
			shadersLibrary.Objects[0].Symbols = new ShadersLibrary.SymbolList();
			shadersLibrary.Objects[0].Symbols.Add("DEFINE_SYMBOL");

			shadersLibrary.Programs = new List<ShadersLibrary.Program>();
			shadersLibrary.Programs.Add(new ShadersLibrary.Program() {
				Id = "TestProgram",
			});
			shadersLibrary.Programs[0].Objects = new List<ShadersLibrary.Object>();
			shadersLibrary.Programs[0].Objects.Add(new ShadersLibrary.Object() {
				Resource = "Some.Object.Resource",
				Stage = ShaderType.VertexShader,
			});
			shadersLibrary.Programs[0].Attributes = new List<ShadersLibrary.Attribute>();
			shadersLibrary.Programs[0].Attributes.Add(new ShadersLibrary.Attribute() {
				Name = "test_Attribute",
				Location = -1,
				Semantic = "Position"
			});
			
			byte[] shaderLibraryBytes;

			using (MemoryStream memoryStream = new MemoryStream()) {
				shadersLibrary.Save(memoryStream);
				shaderLibraryBytes = memoryStream.ToArray();
			}

			string shaderLibraryText = Encoding.UTF8.GetString(shaderLibraryBytes);
		}

		[Test(Description = "Test CreateProgram(string)")]
		[TestCaseSource(nameof(ProgramIds))]
		public void ShadersLibrary_CompileProgram(string programId)
		{
			ShadersLibrary.Program shaderProgramInfo = ShadersLibrary.Instance.GetProgram(programId);
			Assert.IsNotNull(shaderProgramInfo);

			ShaderProgram shaderProgram = _Context.CreateProgram(programId);
			try {
				Assert.IsNotNull(shaderProgram);
				Assert.DoesNotThrow(delegate {
					shaderProgram.Create(_Context);
				});

				// Output program information
				Console.WriteLine("Shader program: {0}", shaderProgram.Identifier);
				Console.WriteLine("Active attributes: {0}", shaderProgram.ActiveAttributes.Count);
				foreach (string attributeName in shaderProgram.ActiveAttributes)
					Console.WriteLine("  - {0}", attributeName);
				Console.WriteLine("Active uniforms: {0}", shaderProgram.ActiveUniforms.Count);
				foreach (string attributeName in shaderProgram.ActiveUniforms)
					Console.WriteLine("  - {0}", attributeName);

				//Assert.GreaterOrEqual(shaderProgram.ActiveAttributes.Count, shaderProgramInfo.Attributes.Count);
				//foreach (ShadersLibrary.Program.Attribute attribute in shaderProgramInfo.Attributes) {
				//	Assert.IsTrue(shaderProgram.IsActiveAttribute(attribute.Name));
				//	Assert.AreEqual(attribute.Semantic, shaderProgram.GetAttributeSemantic(attribute.Name));
				//	Assert.AreEqual(attribute.Location, shaderProgram.GetAttributeLocation(attribute.Name));
				//}

				//Assert.GreaterOrEqual(shaderProgram.ActiveUniforms.Count, shaderProgramInfo.Uniforms.Count);
				//foreach (ShadersLibrary.Program.Uniform uniform in shaderProgramInfo.Uniforms) {
				//	Assert.IsTrue(shaderProgram.IsActiveUniform(uniform.Name));
				//}
			} finally {
				shaderProgram?.Dispose();
			}
		}

		/// <summary>
		/// Shader programs available in OpenGL.Net.Objects.
		/// </summary>
		public static IEnumerable<string> ProgramIds
		{
			get
			{
				return ShadersLibrary.Instance.GetPrograms();
			}
		}

		/// <summary>
		/// Object context.
		/// </summary>
		public class ObjectContext
		{
			public ObjectContext(string id, ShaderType type)
			{
				ObjectId = id;
				ObjectType = type;
			}

			/// <summary>
			/// The identifier of the shader to be compiled.
			/// </summary>
			public readonly string ObjectId;

			/// <summary>
			/// The <see cref="ShaderType"/> of the shader.
			/// </summary>
			public readonly ShaderType ObjectType;

			/// <summary>
			/// Shader compiler parameters.
			/// </summary>
			public ShaderCompilerContext CompilerParams;

			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();

				sb.AppendFormat("{0}/{1}", ObjectId, ObjectType);

				return (sb.ToString());
			}
		}

		[Test(Description = "Test ShaderLibrary objects compilation")]
		[TestCaseSource(nameof(ObjectIds))]
		public void ShadersLibrary_CompileObject(ObjectContext ctx)
		{
			ShadersLibrary.Object shaderObjectInfo = ShadersLibrary.Instance.GetObject(ctx.ObjectId);
			Assert.IsNotNull(shaderObjectInfo);

			Shader shaderObject = shaderObjectInfo.Create(ctx.ObjectType);
			try {
				Assert.IsNotNull(shaderObject);
				Assert.DoesNotThrow(delegate { shaderObject.Create(_Context); });
			} finally {
				shaderObject?.Dispose();
			}
		}

		/// <summary>
		/// Shader object compilation set available in OpenGL.Net.Objects.
		/// </summary>
		public static ObjectContext[] ObjectIds
		{
			get
			{
				List<ObjectContext> objectIds = new List<ObjectContext>();

				foreach (ShadersLibrary.Object obj in ShadersLibrary.Instance.Objects) {
					foreach (ShaderType objStage in obj.Stages)
						objectIds.Add(new ObjectContext(obj.Resource, objStage));
				}

				return (objectIds.ToArray());
			}
		}
	}
}
