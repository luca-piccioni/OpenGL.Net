
// Copyright (C) 2015-2017 Luca Piccioni
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
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Abstract base test creating an OpenGL context used for testing.
	/// </summary>
	[TestFixture]
#if !NETCORE
	[Apartment(ApartmentState.STA)]
#endif
	[Category("Graphics")]
	abstract class TestBaseGLSL : TestBaseGL
	{
		#region Shader Management

		/// <summary>
		/// Creates and compiles a shader object.
		/// </summary>
		/// <param name="shaderType">
		/// Specifies the type of shader to be created.
		/// </param>
		/// <param name="source">
		/// Specifies an array of pointers to strings containing the source code to be loaded into the shader.
		/// </param>
		/// <returns>
		/// It returns a shader object of type <paramref name="shaderType"/>.
		/// </returns>
		protected static UInt32 CreateShaderObject(ShaderType shaderType, string[] source)
		{
			UInt32 shaderObject = 0;

			try {
				shaderObject = Gl.CreateShader(shaderType);
				Gl.ShaderSource(shaderObject, source);
				Gl.CompileShader(shaderObject);

				int compileStatus;

				Gl.GetShader(shaderObject, ShaderParameterName.CompileStatus, out compileStatus);
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

			Gl.GetProgram(shaderProgram, ProgramProperty.LinkStatus, out linkStatus);
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

			Gl.GetProgram(shaderProgram, ProgramProperty.ActiveAttributes, out activeAttributes);
			Gl.GetProgram(shaderProgram, ProgramProperty.ActiveAttributeMaxLength, out activeAttributeMaxLength);
			for (int i = 0; i < activeAttributes; i++) {
				StringBuilder activeAttributeName = new StringBuilder(activeAttributeMaxLength);
				int activeAttributeNameLength, activeAttributeSize, activeAttributeType;

				Gl.GetActiveAttrib(shaderProgram, (uint)i, activeAttributeMaxLength, out activeAttributeNameLength, out activeAttributeSize, out activeAttributeType, activeAttributeName);

				if (activeAttributeName.ToString() == attributeName) {
					Gl.BindBuffer(BufferTarget.ArrayBuffer, buffer);
					Gl.VertexAttribPointer((uint)i, activeAttributeSize, (VertexAttribType)activeAttributeType, false, 0, IntPtr.Zero);

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
