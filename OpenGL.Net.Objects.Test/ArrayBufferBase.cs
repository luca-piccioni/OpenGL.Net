
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
		#region ArrayBufferBase.Create

		/// <summary>
		/// Test ArrayBufferBase creation using <see cref="ArrayBufferBase.Create(uint)"/>.
		/// </summary>
		/// <param name="arrayBuffer">
		/// The <see cref="ArrayBufferBase"/> instance to test. It is required to be mutable.
		/// </param>
		protected void TestCreateEmpty(ArrayBufferBase arrayBuffer)
		{
			// Buffer must be mutable
			Assert.IsFalse(arrayBuffer.Immutable);

			// No GPU buffer is allocated
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);
			// Cannot create an empty CPU buffer
			Assert.Throws(Is.InstanceOf<ArgumentException>(), delegate { arrayBuffer.Create(0); });

			// Create empty GPU buffer
			arrayBuffer.Create(16);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Current GPU buffer can be re-defined
			arrayBuffer.Create(32);
			Assert.AreEqual(0u, arrayBuffer.ItemsCount);

			// Uploads data on GPU
			arrayBuffer.Create(_Context);
			Assert.AreEqual(32u, arrayBuffer.ItemsCount);

			// CPU buffer can be re-defined while holding GPU buffer
			Assert.DoesNotThrow(() => arrayBuffer.Create(64));
			Assert.AreEqual(32u, arrayBuffer.ItemsCount);

			// Uploads data on GPU (reallocation)
			arrayBuffer.Create(_Context);
			Assert.AreEqual(64u, arrayBuffer.ItemsCount);
		}

		#endregion
	}
}
