
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
using System.IO;
using System.Reflection;
using System.Text;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating an OpenGL context used for testing.
	/// </summary>
	[TestFixture]
	abstract class GlShaderTestBase : GlTestBase
	{
		#region Shader Management

		/// <summary>
		/// Creates and compiles a shader object.
		/// </summary>
		/// <param name="shaderType">
		/// Specifies the type of shader to be created. Must be one of Gl.COMPUTE_SHADER, Gl.VERTEX_SHADER, Gl.TESS_CONTROL_SHADER, 
		/// Gl.TESS_EVALUATION_SHADER, Gl.GEOMETRY_SHADER, or Gl.FRAGMENT_SHADER.
		/// </param>
		/// <param name="source">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <returns>
		/// It returns a shader object of type <paramref name="shaderType"/>.
		/// </returns>
		protected static UInt32 CreateShaderObject(int shaderType, string[] source)
		{
			UInt32 shaderObject = 0;

			try {
				shaderObject = Gl.CreateShader(shaderType);
				Gl.ShaderSource(shaderObject, source);
				Gl.CompileShader(shaderObject);

				int compileStatus;

				Gl.GetShader(shaderObject, Gl.COMPILE_STATUS, out compileStatus);
				if (compileStatus == Gl.FALSE) {
					StringBuilder log = new StringBuilder(4096);
					int logLength;

					Gl.GetShaderInfoLog(shaderObject, log.Capacity, out logLength, log);

					throw new InvalidOperationException(log.ToString());
				}

				return (shaderObject);
			} catch {
				if (shaderObject != 0)
					Gl.DeleteShader(shaderObject);
				throw;
			}
		}

		/// <summary>
		/// Creates and links a shader program.
		/// </summary>
		/// <param name="shaderProgram">
		/// 
		/// </param>
		/// <param name="shaderObjects">
		/// 
		/// </param>
		/// <returns></returns>
		protected static void LinkShaderProgram(UInt32 shaderProgram, params UInt32[] shaderObjects)
		{
			for (int i = 0; i < shaderObjects.Length; i++)
				Gl.AttachShader(shaderProgram, shaderObjects[i]);

			Gl.LinkProgram(shaderProgram);

			int linkStatus;

			Gl.GetProgram(shaderProgram, Gl.LINK_STATUS, out linkStatus);
			if (linkStatus == Gl.FALSE) {
				StringBuilder log = new StringBuilder(4096);
				int logLength;

				Gl.GetProgramInfoLog(shaderProgram, log.Capacity, out logLength, log);

				throw new InvalidOperationException(log.ToString());
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="shaderProgram"></param>
		/// <param name="buffer"></param>
		/// <param name="attributeName"></param>
		protected static void BindShaderProgramAttrib(UInt32 shaderProgram, UInt32 buffer, string attributeName)
		{
			int activeAttributes, activeAttributeMaxLength;

			Gl.GetProgram(shaderProgram, Gl.ACTIVE_ATTRIBUTES, out activeAttributes);
			Gl.GetProgram(shaderProgram, Gl.ACTIVE_SUBROUTINE_MAX_LENGTH, out activeAttributeMaxLength);
			for (int i = 0; i < activeAttributes; i++) {
				StringBuilder activeAttributeName = new StringBuilder(activeAttributeMaxLength);
				int activeAttributeNameLength, activeAttributeSize, activeAttributeType;

				Gl.GetActiveAttrib(shaderProgram, (uint)i, activeAttributeMaxLength, out activeAttributeNameLength, out activeAttributeSize, out activeAttributeType, activeAttributeName);

				if (activeAttributeName.ToString() == attributeName) {
					Gl.BindBuffer(BufferTargetARB.ArrayBuffer, buffer);
					Gl.VertexAttribPointer((uint)i, activeAttributeSize, activeAttributeType, false, 0, IntPtr.Zero);

					return;
				}
			}

			throw new InvalidOperationException(String.Format("attribute {0} not active"));
		}

		#endregion

		#region Text Processing

		/// <summary>
		/// Load shader source from a menifest resource.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specifies the manifest resource name.
		/// </param>
		/// <returns></returns>
		protected static string LoadShaderFromManifest(string path)
		{
			using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path)) {
				using (StreamReader sr = new StreamReader(stream)) {
					return (sr.ReadToEnd());
				}
			}
		}

		#endregion
	}
}
