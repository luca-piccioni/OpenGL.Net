
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

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	class ShaderStorageBufferTest : BufferTest
	{
		[Test]
		public void ShaderStorageBuffer_TestCreation()
		{
			using (ShaderStorageBuffer ssbo = new ShaderStorageBuffer(BufferUsage.DynamicDraw)) {
				ssbo.Create(_Context, (uint)Math.Min(1024 * 1024, _Context.Limits.MaxShaderStorageBlockSize));
			}
		}

		[Test]
		public void ShaderStorageBuffer_TestShaderProgram()
		{
			if (!_Context.Extensions.ComputeShader_ARB)
				Assert.Inconclusive("GL_ARB_compute_shader not supported");
			if (!_Context.Extensions.ShaderStorageBufferObject_ARB)
				Assert.Inconclusive("GL_ARB_shader_storage_buffer_object not supported");

			const uint Size = 1024;

			using (ShaderProgram program = new ShaderProgram("")) 
			using (Shader computeShader = new Shader(ShaderType.ComputeShader))
			using (ShaderStorageBuffer storageBuffer = new ShaderStorageBuffer(MapBufferUsageMask.MapReadBit))
			{
				computeShader.LoadSource(new[] {
					"#version 430",
					"layout(local_size_x = 1, local_size_y = 1) in;",
					"layout(std430, binding = 3) buffer glo_Buffer {",
					"	uint data[];",
					"};",
					"",
					"void main() {",
					"	data[gl_WorkGroupID.x * gl_WorkGroupID.y] = uint(gl_WorkGroupID.x * gl_WorkGroupID.y);",
					"}"
				});
				program.Attach(computeShader);
				program.Create(_Context);

				storageBuffer.Create(_Context, Size * Size * 4);

				program.SetStorageBuffer(_Context, "glo_Buffer", storageBuffer);
				program.Compute(_Context, Size, Size);

				program.MemoryBarrier(MemoryBarrierMask.ShaderStorageBarrierBit);

				uint[] storage = new uint[Size * Size];

				storageBuffer.Load(_Context, storage, Size * Size * 4);

				for (uint x = 0; x < Size; x++)
					for (uint y = 0; y < Size; y++)
						Assert.AreEqual(x * y, storage[x * y]);
			}
		}

		#region Overrides

		protected override void CreateCpuBuffer(Buffer buffer)
		{
			ShaderStorageBuffer arrayBuffer = (ShaderStorageBuffer)buffer;

			// Create CPU buffer with 16 elements
			arrayBuffer.Create(16);
		}

		protected override void CreateGpuBuffer(Buffer buffer)
		{
			ShaderStorageBuffer arrayBuffer = (ShaderStorageBuffer)buffer;

			// Create CPU buffer with 16 elements
			arrayBuffer.Create(_Context, 16);
		}

		#endregion
	}
}
