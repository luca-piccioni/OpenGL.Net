
// Copyright (C) 2016-2018 Luca Piccioni
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

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	public class MemoryTest
	{
		[Test]
		public void Memory_TestUseSystemCopy()
		{
			bool useSystemCopy;

			Assert.DoesNotThrow(() => Memory.UseSystemCopy = true);
			Assert.DoesNotThrow(() => useSystemCopy = Memory.UseSystemCopy);
			Assert.DoesNotThrow(() => Memory.UseSystemCopy = false);
			Assert.DoesNotThrow(() => useSystemCopy = Memory.UseSystemCopy);

			Assert.DoesNotThrow(() => Memory.UseSystemCopy = true);
			Assert.DoesNotThrow(() => Memory.UseSystemCopy = true);
		}

		[Test, TestCase(true), TestCase(false)]
		public void Memory_TestCopy(bool systemCopy)
		{
			Memory.UseSystemCopy = systemCopy;
			if (systemCopy != Memory.UseSystemCopy)
				Assert.Inconclusive();

			// No exception is checked: values passed directly to the implementation

			int[] dstArray = { 1, 2, 3, 4 };
			float[] srcArray = {1.0f, 2.0f, 3.0f, 4.0f};

			using (MemoryLock srcArrayLock = new MemoryLock(srcArray)) {
				Memory.Copy(dstArray, srcArrayLock.Address, 4 * 4);
			}

			for (int i = 0; i < srcArray.Length; i++)
				srcArray[i] = 0.0f;

			using (MemoryLock dstArrayLock = new MemoryLock(dstArray)) {
				Memory.Copy(srcArray, dstArrayLock.Address, 4 * 4);
			}

			for (int i = 0; i < srcArray.Length; i++)
				Assert.AreEqual((float)(i + 1), srcArray[i]);
		}
	}
}
