
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

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	abstract class ArrayBufferBaseTest : BufferTest
	{
		protected void ArrayBufferBase_TestEmptyTechnique_NonZero(ArrayBufferBase arrayBuffer)
		{
			Assert.IsFalse(arrayBuffer.Immutable);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Cannot create an empty CPU buffer
			Assert.Throws(Is.InstanceOf<ArgumentException>(), delegate { arrayBuffer.Create(0); });
			// Cannot create an empty GPU buffer
			Assert.Throws(Is.InstanceOf<ArgumentException>(), delegate { arrayBuffer.Create(_Context, 0); });
		}

		protected void ArrayBufferBase_TestEmptyTechnique_CreateOnline(ArrayBufferBase arrayBuffer)
		{
			Assert.IsFalse(arrayBuffer.Immutable);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);
			Assert.AreEqual(0u, arrayBuffer.CpuBufferSize);
			Assert.AreEqual(0u, arrayBuffer.GpuBufferSize);

			// Create empty buffer on GPU
			arrayBuffer.Create(_Context, 16);
			Assert.AreEqual(0u, arrayBuffer.CpuBufferSize);
			Assert.Greater(arrayBuffer.GpuBufferSize, 0u);
			Assert.AreEqual(16u, arrayBuffer.ItemsCount);
		}

		protected void ArrayBufferBase_TestEmptyTechnique_CreateOffline(ArrayBufferBase arrayBuffer)
		{
			Assert.IsFalse(arrayBuffer.Immutable);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Create empty buffer, without uploading on GPU
			arrayBuffer.Create(16);
			Assert.AreNotEqual(0u, arrayBuffer.CpuBufferSize);
			Assert.AreNotEqual(0u, arrayBuffer.ItemsCount);
			Assert.AreEqual(0u, arrayBuffer.GpuBufferSize);

			// Uploads to GPU
			arrayBuffer.Create(_Context);
			Assert.Greater(arrayBuffer.GpuBufferSize, 0u);
			Assert.AreEqual(16u, arrayBuffer.ItemsCount);
		}

		protected void ArrayBufferBase_TestArrayTechnique_NonZero(ArrayBufferBase arrayBuffer)
		{
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Cannot create with empty CPU array
			Assert.Throws(Is.InstanceOf<ArgumentException>(), delegate { arrayBuffer.Create(new byte[0]); });
			// Cannot create with empty GPU array
			Assert.Throws(Is.InstanceOf<ArgumentException>(), delegate { arrayBuffer.Create(_Context, new byte[0]); });
		}

		protected void ArrayBufferBase_TestArrayTechnique_CreateOnline(ArrayBufferBase arrayBuffer)
		{
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);
			Assert.AreEqual(0u, arrayBuffer.CpuBufferSize);
			Assert.AreEqual(0u, arrayBuffer.GpuBufferSize);

			arrayBuffer.Create(_Context, new ushort[16]);
			Assert.AreNotEqual(0u, arrayBuffer.GpuBufferSize);
		}

		protected void ArrayBufferBase_TestArrayTechnique_CreateOffline(ArrayBufferBase arrayBuffer)
		{
			Assert.AreEqual(0u, arrayBuffer.CpuBufferSize);
			Assert.AreEqual(0u, arrayBuffer.GpuBufferSize);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			arrayBuffer.Create(new ushort[16]);
			Assert.AreEqual(0u, arrayBuffer.GpuBufferSize);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Uploads to GPU
			arrayBuffer.Create(_Context);
			Assert.AreNotEqual(0u, arrayBuffer.GpuBufferSize);
		}
	}
}
