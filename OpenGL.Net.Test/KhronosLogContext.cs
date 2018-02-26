
// Copyright (C) 2018 Luca Piccioni
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
using System.Diagnostics.CodeAnalysis;
using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("Framework")]
	internal class KhronosLogContextTest
	{
		[SuppressMessage("ReSharper", "UnusedMember.Local")]
		[SuppressMessage("ReSharper", "InconsistentNaming")]
		private class TestApi : KhronosApi
		{
			[RequiredByFeature("GL_TEST")]
			public const int NONE = 0;

			[RequiredByFeature("GL_TEST")]
			public const int ONE = 1;

			[RequiredByFeature("GL_TEST")]
			public const int TWO = 2;

			/// <summary>
			/// Value ignored because it has no RequiredByFeatureAttribute.
			/// </summary>
			public const int IGNORED1 = -1;

			/// <summary>
			/// Value ignored because it is not a literal.
			/// </summary>
			[RequiredByFeature("GL_TEST")]
			public static readonly int IGNORED2 = -2;
		}

		[Test]
		public void KhronosLosContext_Constructor()
		{
			KhronosLogContext ctx = null;

			Assert.Throws<ArgumentNullException>(() => ctx = new KhronosLogContext(null));
			Assert.DoesNotThrow(() => ctx = new KhronosLogContext(typeof(TestApi)));

			Assert.AreEqual("NONE", ctx.GetEnumName(0));
			Assert.AreEqual("ONE", ctx.GetEnumName(1));
			Assert.AreEqual("TWO", ctx.GetEnumName(2));
			Assert.IsNull(ctx.GetEnumName(-1));
			Assert.IsNull(ctx.GetEnumName(-2));
		}

		[Test]
		public void KhronosLosContext_ToString()
		{
			KhronosLogContext ctx = new KhronosLogContext(typeof(TestApi));

			Assert.Throws<ArgumentNullException>(() => ctx.ToString(null, null, null));

			Assert.AreEqual("glCommand()", ctx.ToString("glCommand", null, null));
			Assert.AreEqual("glCommand() = -1", ctx.ToString("glCommand", -1, null));
			Assert.AreEqual("glCommand(15)", ctx.ToString("glCommand", null, new object[] { 15 }));
			Assert.AreEqual("glCommand(\"value\")", ctx.ToString("glCommand", null, new object[] { "value" }));
			Assert.AreEqual("glCommand(0x00000000)", ctx.ToString("glCommand", null, new object[] { IntPtr.Zero }));
			Assert.AreEqual("glCommand({15,16,17})", ctx.ToString("glCommand", null, new object[] { new int[] { 15, 16, 17 } }));

		}
	}
}
