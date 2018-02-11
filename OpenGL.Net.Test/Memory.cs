
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
	[TestFixture]
	internal class MemoryTest
	{
		[Test]
		public static void Memory_TestCopy()
		{
			float[] a1 = new float[16];
			for (int i = 0; i < a1.Length; i++)
				a1[i] = TestContext.CurrentContext.Random.NextFloat();
			float[] a2 = new float[a1.Length];

			Memory.Copy(a2, a1, (uint)(4 * a1.Length));
			for (int i = 0; i < a1.Length; i++)
				Assert.AreEqual(a1[i], a2[i]);

			uint[] ui1 = new uint[16];
			for (int i = 0; i < ui1.Length; i++)
				ui1[i] = 0x05050505;
			byte[] b2 = new byte[ui1.Length * 4];
			Memory.Copy(b2, ui1, (uint)b2.Length);
			foreach (byte b in b2)
				Assert.AreEqual((byte)0x05, b);
		}
	}
}
