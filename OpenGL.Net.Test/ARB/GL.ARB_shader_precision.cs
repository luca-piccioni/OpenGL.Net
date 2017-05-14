
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
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test GL_ARB_shader_precision.
	/// </summary>
	[TestFixture]
	// [Context(ContextRequired = ContextAttribute.ContextMode.CoreProfile)]
	class Gl_ARB_shader_precision : GlShaderTestBase
	{
		#region Setup & Tear Down

		/// <summary>
		/// Create required resources for tests defined in this class.
		/// </summary>
		[TestFixtureSetUp]
		public new void FixtureSetUp()
		{

		}

		/// <summary>
		/// Release resources allocated by <see cref="FixtureSetUp"/>.
		/// </summary>
		[TestFixtureTearDown]
		public new void FixtureTearDown()
		{
			
		}

		#endregion

		/// <summary>
		/// Context used for testing shader program precision.
		/// </summary>
		public abstract class ShaderPrecisionContext : IDisposable
		{
			#region Constructors

			public ShaderPrecisionContext(string methodName)
			{
				if (methodName == null)
					throw new ArgumentNullException("methodName");

				MethodName = methodName;
			}

			#endregion

			#region Resources

			public void CreateResources()
			{
				try {
					Program = CreateProgram(MethodName);
					ProgramInput = CreateBuffer(1024, Inputs);
					ProgramOutput = CreateBuffer(1024);
					ReferenceOutput = Outputs;
				} catch {
					Dispose();
					throw;
				}
			}

			private static UInt32 CreateProgram(string methodName)
			{
				UInt32 shaderProgram = 0;
				UInt32 vertexSkeleton = 0, vertexMethod = 0;

				try {
					string vertexSkeletonSource = LoadShaderFromManifest("OpenGL.Test.ARB.Gl.ARB_shader_precision.glvs");
					vertexSkeleton = CreateShaderObject(ShaderType.VertexShader, new string[] { vertexSkeletonSource });

					string vertexMethodSource = GenerateTestMethod(methodName);
					vertexMethod = CreateShaderObject(ShaderType.VertexShader, new string[] { vertexMethodSource });

					shaderProgram = Gl.CreateProgram();

					// Define feedback varyings
					List<string> feedbackVaryings = new List<string>();
					feedbackVaryings.Add("vertexOut");
					Gl.TransformFeedbackVaryings(shaderProgram, varyings, Gl.SEPARATE_ATTRIBS);

					LinkShaderProgram(shaderProgram, vertexSkeleton, vertexMethod);

					// Check feedback state
					int feebackVaryings, feebackVaryingsMaxLength;
					Gl.GetProgram(shaderProgram, Gl.TRANSFORM_FEEDBACK_VARYINGS, out feebackVaryings);
					Gl.GetProgram(shaderProgram, Gl.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH, out feebackVaryingsMaxLength);

					return (shaderProgram);
				} catch {
					if (vertexSkeleton != 0)
						Gl.DeleteShader(vertexSkeleton);
					if (vertexMethod != 0)
						Gl.DeleteShader(vertexMethod);
					if (shaderProgram != 0)
						Gl.DeleteProgram(shaderProgram);
					throw;
				}
			}

			static string[] varyings = new string[] { "vertexOut" };

			private static UInt32 CreateBuffer(uint size)
			{
				return (CreateBuffer(size, null));
			}

			private static UInt32 CreateBuffer(uint size, float[] data)
			{
				UInt32 buffer = 0;

				try {
					buffer = Gl.GenBuffer();

					Gl.BindBuffer(BufferTarget.ArrayBuffer, buffer);

					if (data != null) {
						GCHandle dataHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
						try {
							Gl.BufferData(BufferTarget.ArrayBuffer, size, dataHandle.AddrOfPinnedObject(), BufferUsage.StaticDraw);
						} finally {
							dataHandle.Free();
						}
					} else
						Gl.BufferData(BufferTarget.ArrayBuffer, size, IntPtr.Zero, BufferUsage.StaticDraw);

					return (buffer);
				} catch {
					if (buffer != 0)
						Gl.DeleteBuffers(buffer);
					throw;
				}
			}

			private static string GenerateTestMethod(string methodName)
			{
				if (methodName == null)
					throw new ArgumentNullException("methodName");

				StringBuilder sb = new StringBuilder();

				sb.Append("#version 150\n");
				sb.Append("float TestMethod(float v) {\n");
				sb.AppendFormat("return ({0}(v));\n", methodName);
				sb.Append("}\n");

				return (sb.ToString());
			}

			/// <summary>
			/// The method tested for precision.
			/// </summary>
			private readonly string MethodName;

			/// <summary>
			/// Program computing values.
			/// </summary>
			public UInt32 Program;

			/// <summary>
			/// Buffer object holding the input values.
			/// </summary>
			public UInt32 ProgramInput;

			/// <summary>
			/// Buffer object holding the computed values.
			/// </summary>
			public UInt32 ProgramOutput;

			/// <summary>
			/// The reference output to be compared with <see cref="ProgramOutput"/>.
			/// </summary>
			public float[] ReferenceOutput;

			#endregion

			#region Inputs and Outputs

			/// <summary>
			/// Get the shader program inputs.
			/// </summary>
			protected abstract float[] Inputs { get; }

			/// <summary>
			/// Get the shader program reference outputs.
			/// </summary>
			protected abstract float[] Outputs { get; }

			#endregion

			#region Precision

			private void CheckShaderPrecision(float[] shaderOutput)
			{
				float highestAbsError = 0.0f;
				float highestRelError = 0.0f;

				for (int i = 0; i < ReferenceOutput.Length; i++) {
					float absError = Math.Abs(shaderOutput[i] - ReferenceOutput[i]);
					float relError = Math.Abs(shaderOutput[i] - ReferenceOutput[i]) / ReferenceOutput[i];

					highestAbsError = Math.Max(highestAbsError, absError);
					highestRelError = Math.Max(highestRelError, relError);
				}

				Console.WriteLine("Precision for {0}:", MethodName);
				Console.WriteLine("  - Maximum absolute error: {0}", highestAbsError);
				Console.WriteLine("  - Maximum relative error: {0}", highestRelError);
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose resources.
			/// </summary>
			public void Dispose()
			{
				if (Program != 0)
					Gl.DeleteProgram(Program);
				if (ProgramInput != 0)
					Gl.DeleteBuffers(ProgramInput);
				if (ProgramOutput != 0)
					Gl.DeleteBuffers(ProgramOutput);

				Program = ProgramInput = ProgramOutput = 0;
			}

			#endregion
		}

		/// <summary>
		/// Context used for testing shader program precision for trigonometric functions.
		/// </summary>
		public abstract class TrigonometricShaderPrecisionContext : ShaderPrecisionContext
		{
			#region Constructors

			public TrigonometricShaderPrecisionContext(string methodName)
				: base(methodName)
			{
				
			}

			#endregion

			#region ShaderPrecisionContext Overrides

			/// <summary>
			/// Get the shader program inputs.
			/// </summary>
			protected override float[] Inputs
			{
				get
				{
					const double MIN = -Math.PI * 2.0, MAX = +Math.PI / 720.0f;

					List<float> inputs = new List<float>();

					// Radians from -2PI to +2PI
					for (double i = MIN; i <= MAX; i += (MAX - MIN) / 720.0)
						inputs.Add((float)i);

					return (inputs.ToArray());
				}
			}

			#endregion
		}

		/// <summary>
		/// Context used for testing shader program precision for sin function.
		/// </summary>
		public class SinShaderPrecisionContext : TrigonometricShaderPrecisionContext
		{
			#region Constructors

			public SinShaderPrecisionContext()
				: base("sin")
			{
				
			}

			#endregion

			#region ShaderPrecisionContext Overrides

			/// <summary>
			/// Get the shader program reference outputs.
			/// </summary>
			protected override float[] Outputs
			{
				get
				{
					float[] inputs = Inputs;
					float[] outputs = new float[inputs.Length];

					for (int i = 0; i < inputs.Length; i++)
						outputs[i] = (float)Math.Sin(inputs[i]);

					return (outputs);
				}
			}

			#endregion
		}

		/// <summary>
		/// Test GLSL function precision.
		/// </summary>
		/// <remarks>
		/// This test aim to measure the shader execution default precision. It uses a shader program and
		/// a transform feedback buffer to compute a specific set of values. The values computed by the shader
		/// program are get back, and compared with the correponding values computed on CPU.
		/// </remarks>
		[Test(Description = "Test default shader precision")]
		[TestCaseSource("PrecisionContextes")]
		public void TestDefaultPrecision(ShaderPrecisionContext ctx)
		{
			if (!HasVersion(2, 0) && !IsGlExtensionSupported("GL_ARB_vertex_shader"))
				Assert.Inconclusive("OpenGL 2.0 or GL_ARB_vertex_shader not supported");
			if (!HasVersion(3, 0) && !IsGlExtensionSupported("GL_EXT_transform_feedback"))
				Assert.Inconclusive("OpenGL 3.0 or GL_EXT_transform_feedback not supported");

			// Create resources required for test
			ctx.CreateResources();

			// Set program input
			BindShaderProgramAttrib(ctx.Program, ctx.ProgramInput, "vertexIn");
			// Set program output
			Gl.BindBuffer(BufferTarget.TransformFeedbackBuffer, ctx.ProgramOutput);

			// Draw on feedback buffer using program
			Gl.UseProgram(ctx.Program);

			// Transform feedback
			Gl.BeginTransformFeedback(Gl.POINTS);
			Gl.DrawArrays(PrimitiveType.Points, 0, ctx.ReferenceOutput.Length);
			Gl.EndTransformFeedback();

			// Get program computation result
			float[] feedbackData = new float[ctx.ReferenceOutput.Length];
			Gl.GetBufferSubData(BufferTarget.TransformFeedbackBuffer, IntPtr.Zero, (uint)feedbackData.Length, feedbackData);

			// Check precision

		}

		/// <summary>
		/// Test cases for this test fixture.
		/// </summary>
		public ShaderPrecisionContext[] PrecisionContextes
		{
			get
			{
				List<ShaderPrecisionContext> precisionContextes = new List<ShaderPrecisionContext>();

				precisionContextes.Add(new SinShaderPrecisionContext());

				return (precisionContextes.ToArray());
			}
		}
	}
}
