
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
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Toolkit_GlControl")]
	class GlControlTest
	{
		[Test(Description = "Test Single thread management")]
		public void TestMinimalCase()
		{
			using (TestForm testForm = new TestForm()) {
				using (System.Threading.Timer taskDelay = new System.Threading.Timer(delegate (object state) {
					testForm.Invoke(new Action(delegate() { testForm.Close(); }));
				}, null, 7500, Timeout.Infinite)) {
					Application.Run(testForm);
				}
			}
		}

		[Test(Description = "Test Single thread management")]
		public void TestMultithread()
		{
			int closeTimeout = Debugger.IsAttached ? 60000 * 5 : 7500;

			Thread uiThread = new Thread(delegate () {
				using (TestForm testForm = new TestForm()) {
					using (System.Threading.Timer taskDelay = new System.Threading.Timer(delegate (object state) {
						testForm.Close();
					}, null, closeTimeout, Timeout.Infinite)) {
						Application.Run(testForm);
					}
				}
			});

			uiThread.Start();

			Thread uiThread2 = new Thread(delegate () {
				using (TestForm testForm = new TestForm()) {
					using (System.Threading.Timer taskDelay = new System.Threading.Timer(delegate (object state) {
						testForm.Close();
					}, null, closeTimeout, Timeout.Infinite)) {
						Application.Run(testForm);
					}
				}
			});

			uiThread2.Start();

			uiThread.Join();
			uiThread2.Join();
		}
	}
}
