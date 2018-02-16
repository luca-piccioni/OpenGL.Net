
// Copyright (C) 2016-2017 Luca Piccioni
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

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class MemoryLockTest
	{
		[Test]
		public static void MemoryLock_TestAddress()
		{
			float[] array = new float[16];

			// Allow null argument
			Assert.DoesNotThrow(() => { using (new MemoryLock(null)) {} });
			// Nominal case does not throw exceptions
			Assert.DoesNotThrow(() => { using (new MemoryLock(array)) {} });
			// Null argument lead to IntPtr.Zero
			using (MemoryLock nullLock = new MemoryLock(null)) {
				Assert.AreEqual(IntPtr.Zero, nullLock.Address);
			}
			
			MemoryLock arrayLock = new MemoryLock(array);
			try {
				// Existing reference have non-null pointer
				Assert.AreNotEqual(IntPtr.Zero, arrayLock.Address);
			} finally { arrayLock.Dispose(); }
			// Address reset to IntPtr.Zero after disposition
			Assert.AreEqual(IntPtr.Zero, arrayLock.Address);
			// Allow multiple Dispose()
			Assert.DoesNotThrow(() => arrayLock.Dispose());
		}
	}
}
