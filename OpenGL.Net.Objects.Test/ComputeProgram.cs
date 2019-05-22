
// Copyright (C) 2019 Luca Piccioni
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
using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	[TestFixture]
	class ComputeProgramTest : TestBase
	{
		[Test(Description = "Test ComputeProgram.SetUniformImage"), Category("Objects")]
		public void ComputeProgram_SetUniformImage()
		{
			const uint Size = 1024;

			using (ShaderProgram computeProgram = new ShaderProgram("OpenGL.Objects.Test.ComputeProgram"))
			using (Shader computeShader = new Shader(ShaderType.ComputeShader))
			using (Texture2D texture0 = new Texture2D())
			using (Texture2D texture1 = new Texture2D(Size / 2, Size / 2, PixelLayout.R8))
			{
				computeShader.LoadSource(new[] {
					"#version 430",
					"layout(local_size_x = 1, local_size_y = 1) in;",
					"layout(r8) uniform image2D glo_ImageInput;",
					"layout(r8) uniform image2D glo_ImageOutput;",
					"",
					"void main() {",
					"	ivec2 glo_ImageOutputCoords = ivec2(gl_GlobalInvocationID.xy);",
					"	vec2 ndc = glo_ImageOutputCoords / imageSize(glo_ImageOutput).xy;",
					"	ivec2 glo_ImageInputCoords = ivec2(ndc * imageSize(glo_ImageInput).xy);",
					"",
					"	vec4 v00 = imageLoad(glo_ImageInput, glo_ImageInputCoords + ivec2(0, 0));",
					"	vec4 v01 = imageLoad(glo_ImageInput, glo_ImageInputCoords + ivec2(0, 1));",
					"	vec4 v10 = imageLoad(glo_ImageInput, glo_ImageInputCoords + ivec2(1, 0));",
					"	vec4 v11 = imageLoad(glo_ImageInput, glo_ImageInputCoords + ivec2(1, 1));",
					"	vec4 max = max(max(v00, v01), max(v10, v11));",
					"",
					"	imageStore(glo_ImageOutput, glo_ImageOutputCoords, max);",
					"}"
				});
				computeProgram.Attach(computeShader);
				computeProgram.Create(_Context);

				using (Image image = new Image(PixelLayout.R8, Size, Size)) {
					for (uint y = 0; y < image.Height; y++) {
						for (uint x = 0; x < image.Width; x++) {
							if ((x % 2) == 0 && (y % 2) == 0)
								image.SetPixel(x, y, (byte)254);
							else
								image.SetPixel(x, y, (byte)0);
						}
					}
					texture0.Create(_Context, image);
				}
				
				texture1.Create(_Context);

				// SetUniformImage requires the program bound
				// TODO: evaluate to call bind implicitly in SetUniformImage
				_Context.Bind(computeProgram);

				computeProgram.SetUniformImage(_Context, "glo_ImageInput", texture0, BufferAccess.ReadOnly);
				computeProgram.SetUniformImage(_Context, "glo_ImageOutput", texture1, BufferAccess.WriteOnly);

				computeProgram.Compute(_Context, texture1.Width, texture1.Height);
				computeProgram.MemoryBarrier(MemoryBarrierMask.BufferUpdateBarrierBit);

				using (Image result = texture1.Get(_Context, PixelLayout.R8, 0)) {
					for (uint y = 0; y < result.Height; y++) {
						for (uint x = 0; x < result.Width; x++) {
							byte pixel = result.GetPixel<byte>(x, y);
							Assert.AreEqual(pixel, 254);
						}
					}
				}
			}
		}

		public void ComputeProgram_BindUniformImage()
		{

		}
	}
}
