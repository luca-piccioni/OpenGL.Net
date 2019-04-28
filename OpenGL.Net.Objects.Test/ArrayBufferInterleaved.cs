
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

using System.Runtime.InteropServices;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	class ArrayBufferInterleavedTest
	{
		/// <summary>
		/// Structure representing a vertex. This information is stored in inteleaved mode on GPU.
		/// </summary>
		[StructLayout(LayoutKind.Explicit, Size = 52)]
		public struct Vertex
		{
			[FieldOffset(0)]
			public Vertex3f Position;

			[FieldOffset(12)]
			public ColorRGBAF Color;

			[FieldOffset(28)]
			public Vertex2f TexCoord;

			[FieldOffset(36)]
			public Vertex3f Normal;

			[FieldOffset(48)]
			public int Material;
		}

		public void ArrayBufferInterleaved_TestScan()
		{
			using (ArrayBufferInterleaved<Vertex> arrayBuffer = new ArrayBufferInterleaved<Vertex>(BufferUsage.DynamicDraw)) {
				Assert.AreEqual(5u, arrayBuffer.ArraySectionsCount);

				arrayBuffer.Create(16);
			}
		}
	}
}
