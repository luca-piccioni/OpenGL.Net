
// Copyright (C) 2017 Luca Piccioni
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
	[TestFixture(Category = "Objects")]
	class ArrayBufferTest : ArrayBufferBaseTest
	{
		#region ArrayBuffer.Create

		[Test]
		public void TestCreateEmpty()
		{
			List<ArrayBuffer> source = new List<ArrayBuffer>();

			foreach (ArrayBufferItemType arrayBufferItemType in Enum.GetValues(typeof(ArrayBufferItemType))) {
				source.AddRange(new[] {
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StreamDraw),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StaticRead),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StreamCopy),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.DynamicDraw),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.DynamicRead),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.DynamicCopy),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StreamDraw),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StreamRead),
						new ArrayBuffer(arrayBufferItemType, BufferUsage.StreamCopy),
				});
			}

			TestResources.AddRange(source);

			// Test ArrayBufferBase interface
			foreach (ArrayBuffer arrayBuffer in source)
				base.TestCreateEmpty(arrayBuffer);
		}

		#endregion

		#region Overrides

		protected override void CreateCpuBuffer(Buffer buffer)
		{
			ArrayBuffer arrayBuffer = (ArrayBuffer)buffer;

			// Create CPU buffer with 16 elements
			arrayBuffer.Create(16);
		}

		protected override void CreateGpuBuffer(Buffer buffer)
		{
			ArrayBuffer arrayBuffer = (ArrayBuffer)buffer;

			// Create CPU buffer with 16 elements
			arrayBuffer.Create(_Context, 16);
		}

		#endregion
	}
}
