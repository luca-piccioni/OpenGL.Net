
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

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	[TestFixture(Category = "Objects")]
	class ArrayBufferTest : ArrayBufferBaseTest
	{
		[Test]
		public void ArrayBuffer_TestEmptyTechnique_NonZero()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestEmptyTechnique_NonZero(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestEmptyTechnique_CreateOnline()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestEmptyTechnique_CreateOnline(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestEmptyTechnique_CreateOffline()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestEmptyTechnique_CreateOffline(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestArrayTechnique_NonZero()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestArrayTechnique_NonZero(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestArrayTechnique_CreateOnline()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestArrayTechnique_CreateOnline(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestArrayTechnique_CreateOffline()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestEmptyTechnique_CreateOffline(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestMap()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				base.ArrayBufferBase_TestMap(arrayBuffer);
			}
		}

		[Test]
		public void ArrayBuffer_TestCreateNonImmutable()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, BufferUsage.DynamicDraw)) {
				// Using BufferUsage constructor make array buffer mutable
				Assert.IsFalse(arrayBuffer.Immutable);

				// Create on-line
				Assert.DoesNotThrow(() => arrayBuffer.Create(_Context, 16));
				// Being mutable, is can be reset even if size
				Assert.DoesNotThrow(() => arrayBuffer.Create(_Context, 32));
			}
		}

		[Test]
		public void ArrayBuffer_TestCreateImmutable()
		{
			using (ArrayBuffer arrayBuffer = new ArrayBuffer(ArrayBufferItemType.Float4, MapBufferUsageMask.DynamicStorageBit)) {
				// Using MapBufferUsageMask constructor make array buffer immutable
				Assert.IsTrue(arrayBuffer.Immutable);

				// Create on-line
				Assert.DoesNotThrow(() => arrayBuffer.Create(_Context, 16));
				// Being immutable, it cannot change size
				Assert.Throws<GlException>(() => arrayBuffer.Create(_Context, 32));
			}
		}

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
