
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
using System.Threading;
using NUnit.Framework;

namespace OpenGL.CoreUI.Test
{
	[TestFixture(Category = "Toolkit_CoreUI")]
	class NativeWindowTest
	{
		[Test(Description = "Test NativeWindow.Create()")]
		public void TestFactory()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// Handle is not created after instantiation
				Assert.AreEqual(IntPtr.Zero, nativeWindow.Handle);
			}
		}

		[Test(Description = "Test NativeWindow.Create(int,int,uint,uint)")]
		public void TestCreate()
		{
			NativeWindow nativeWindow;

			bool contextCreated = false;
			bool contextDestroying = false;

			using (nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextCreated += (obj, e) => contextCreated = true;
				nativeWindow.ContextDestroying += (obj, e) => contextDestroying = true;

				nativeWindow.Create(0, 0, 640, 480);

				// Create causes GL context creation
				Assert.IsTrue(contextCreated);
				Assert.IsFalse(contextDestroying);
			}

			// Disposition causes GL context disposition
			Assert.IsTrue(contextDestroying);
		}

		[Test(Description = "Test NativeWindow.Run()"), Timeout(3000)]
		public void TestRun()
		{
			NativeWindow nativeWindow;

			bool contextDestroying = false;

			using (nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextDestroying += (obj, e) => contextDestroying = true;

				nativeWindow.Create(0, 0, 640, 480);

				using (Timer closeWindowTimer = new Timer(obj => ((NativeWindow)obj).Stop(), nativeWindow, 2000, Timeout.Infinite)) {
					nativeWindow.Run();
				}

				// Stopping Run() do not causes GL context disposition
				Assert.IsFalse(contextDestroying);
				Assert.IsFalse(nativeWindow.IsDisposed);
			}

			Assert.IsTrue(contextDestroying);
			Assert.IsTrue(nativeWindow.IsDisposed);
		}

		private static void CloseWindowCallback(object state)
		{
			((NativeWindow)state).Stop();
		}
	}
}
