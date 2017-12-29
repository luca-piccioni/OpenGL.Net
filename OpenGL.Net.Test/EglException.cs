
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

namespace OpenGL.Test
{
	[TestFixture, Category("GL")]
	internal class EglExceptionTest
	{
		/// <summary>
		/// Test Gl.QueryContextVersion.
		/// </summary>
		[Test, TestCaseSource(nameof(EglErrorCodes))]
		public void EglException_Constructor1(int errorCode)
		{
			EglException eglException = null;

			Assert.DoesNotThrow(() => eglException = new EglException(errorCode));
			Assert.AreEqual(errorCode, eglException.ErrorCode);
			Assert.IsNotNull(eglException.Message);
		}

		private static int[] EglErrorCodes => new[]
		{
			Egl.SUCCESS,
			Egl.NOT_INITIALIZED,
			Egl.BAD_ACCESS,
			Egl.BAD_ALLOC,
			Egl.BAD_ATTRIBUTE,
			Egl.BAD_CONTEXT,
			Egl.BAD_CONFIG,
			Egl.BAD_CURRENT_SURFACE,
			Egl.BAD_DISPLAY,
			Egl.BAD_SURFACE,
			Egl.BAD_MATCH,
			Egl.BAD_PARAMETER,
			Egl.BAD_NATIVE_PIXMAP,
			Egl.BAD_NATIVE_WINDOW,
			Egl.CONTEXT_LOST,

			0x2999,				// Not existing error code
		};
	}
}
