
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

		[Test(Description = "Test NativeWindow.Run()"), Timeout(1000)]
		public void TestRun()
		{
			NativeWindow nativeWindow;

			bool contextDestroying = false;

			using (nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextDestroying += (obj, e) => contextDestroying = true;

				nativeWindow.Create(0, 0, 640, 480);

				// Stop loop using Stop()
				using (Timer closeWindowTimer = new Timer(obj => ((NativeWindow)obj).Stop(), nativeWindow, 100, Timeout.Infinite)) {
					nativeWindow.Run();
				}

				// Stopping Run() with Stop() do not cause GL context disposition
				Assert.IsFalse(contextDestroying);
				Assert.IsFalse(nativeWindow.IsDisposed);

				// Stop loop using Destroy()
				using (Timer closeWindowTimer = new Timer(obj => ((NativeWindow)obj).Destroy(), nativeWindow, 100, Timeout.Infinite)) {
					nativeWindow.Run();
				}

				// Stopping Run() with Destroy() cause GL context disposition
				Assert.IsTrue(contextDestroying);
				Assert.IsFalse(nativeWindow.IsDisposed);
			}

			Assert.IsTrue(nativeWindow.IsDisposed);
		}

		[Test(Description = "Test NativeWindow.Show()")]
		public void TestVisibility()
		{
			int render = 0;

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Render += (obj, e) => render++;

				nativeWindow.Create(0, 0, 640, 480);
				nativeWindow.Show();

				// Showing the window cause a Render
				Assert.Greater(render, 0);
			}
		}

		[Test(Description = "Test NativeWindow.Invalidate()")]
		public void TestInvalidate()
		{
			int render = 0;

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 640, 480);
				nativeWindow.Show();

				nativeWindow.Render += (obj, e) => render++;
				
				// Invalidating the window cause a single Render
				nativeWindow.Invalidate();
				Assert.AreEqual(1, render);

				// Invalidating the window cause a single Render
				nativeWindow.Invalidate();
				Assert.AreEqual(2, render);
			}
		}

		private static void StopWindowCallback(object state)
		{
			((NativeWindow)state).Stop();
		}
	}
}
