
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
		private static NativeWindowStyle[] NativeWindowStyles
		{
			get
			{
				return new NativeWindowStyle[] {
					NativeWindowStyle.None,
					NativeWindowStyle.Border,
					NativeWindowStyle.Caption,
					NativeWindowStyle.Resizeable
				};
			}
		}

		[Test(Description = "Test NativeWindow.Create()")]
		public void TestFactory()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// Display not reference till instantiation
				Assert.AreEqual(IntPtr.Zero, nativeWindow.Display);
				// Handle is not created after instantiation
				Assert.AreEqual(IntPtr.Zero, nativeWindow.Handle);

				// Note: test Dispose() without Create()
			}
		}

		[Test(Description = "Test NativeWindow.ContextVersion")]
		public void TestContextVersion()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, is it null
				Assert.IsNull(nativeWindow.ContextVersion);

				nativeWindow.ContextVersion = Gl.Version_100;
				Assert.AreEqual(Gl.Version_100, nativeWindow.ContextVersion);

				nativeWindow.ContextVersion = Gl.Version_460;
				Assert.AreEqual(Gl.Version_460, nativeWindow.ContextVersion);

				// Nullable
				nativeWindow.ContextVersion = null;
				Assert.IsNull(nativeWindow.ContextVersion);
			}
		}

		[Test(Description = "Test NativeWindow.DebugContext")]
		public void TestDebugContext()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, is it EnabledInDebugger
				Assert.AreEqual(NativeWindow.AttributePermission.EnabledInDebugger, nativeWindow.DebugContext);

				nativeWindow.DebugContext = NativeWindow.AttributePermission.DonCare;
				Assert.AreEqual(NativeWindow.AttributePermission.DonCare, nativeWindow.DebugContext);
			}
		}

		[Test(Description = "Test NativeWindow.ForwardCompatibleContext")]
		public void TestForwardCompatibleContext()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, is it DonCare
				Assert.AreEqual(NativeWindow.AttributePermission.DonCare, nativeWindow.ForwardCompatibleContext);

				nativeWindow.ForwardCompatibleContext = NativeWindow.AttributePermission.Enabled;
				Assert.AreEqual(NativeWindow.AttributePermission.Enabled, nativeWindow.ForwardCompatibleContext);
			}
		}

		[Test(Description = "Test NativeWindow.RobustContext")]
		public void TestForwardRobustContext()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, is it DonCare
				Assert.AreEqual(NativeWindow.AttributePermission.DonCare, nativeWindow.RobustContext);

				nativeWindow.RobustContext = NativeWindow.AttributePermission.Enabled;
				Assert.AreEqual(NativeWindow.AttributePermission.Enabled, nativeWindow.RobustContext);
			}
		}

		[Test(Description = "Test NativeWindow.ColorBits")]
		public void TestColorBits()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, 24 bits as usual
				Assert.AreEqual(24, nativeWindow.ColorBits);

				nativeWindow.ColorBits = 16;
				Assert.AreEqual(16, nativeWindow.ColorBits);

				// Arbitrary values are accepted
				nativeWindow.ColorBits = 64;
				Assert.AreEqual(64, nativeWindow.ColorBits);

				// Event zero is accepted
				nativeWindow.ColorBits = 0;
				Assert.AreEqual(0, nativeWindow.ColorBits);
			}
		}

		[Test(Description = "Test NativeWindow.DepthBits")]
		public void TestDepthBits()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, no depth buffer
				Assert.AreEqual(0, nativeWindow.DepthBits);

				nativeWindow.DepthBits = 24;
				Assert.AreEqual(24, nativeWindow.DepthBits);
			}
		}

		[Test(Description = "Test NativeWindow.StencilBits")]
		public void TestStencilBits()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, no stencil buffer
				Assert.AreEqual(0, nativeWindow.StencilBits);

				nativeWindow.StencilBits = 24;
				Assert.AreEqual(24, nativeWindow.StencilBits);
			}
		}

		[Test(Description = "Test NativeWindow.MultisampleBits")]
		public void TestMultisampleBits()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, no multisample
				Assert.AreEqual(0, nativeWindow.MultisampleBits);

				nativeWindow.MultisampleBits = 8;
				Assert.AreEqual(8, nativeWindow.MultisampleBits);
			}
		}

		[Test(Description = "Test NativeWindow.DoubleBuffer")]
		public void TestDoubleBuffer()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, double buffering
				Assert.AreEqual(true, nativeWindow.DoubleBuffer);

				nativeWindow.DoubleBuffer = false;
				Assert.AreEqual(false, nativeWindow.DoubleBuffer);
			}
		}

		[Test(Description = "Test NativeWindow.SwapInterval")]
		public void TestSwapInterval()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, V-Sync enabled
				Assert.AreEqual(1, nativeWindow.SwapInterval);

				nativeWindow.SwapInterval = 0;
				Assert.AreEqual(0, nativeWindow.SwapInterval);
			}
		}

		// [Test(Description = "Test NativeWindow.Animation"), Timeout(8000)]
		public void TestAnimation()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, no animation
				Assert.AreEqual(false, nativeWindow.Animation);

				// Runtime functionality
				int render = 0;

				nativeWindow.Animation = true;
				Assert.AreEqual(true, nativeWindow.Animation);

				nativeWindow.Create(0, 0, 128, 128, NativeWindowStyle.Overlapped);

				// Must be visible
				nativeWindow.Show();

				nativeWindow.Render += (obj, e) => render++;
				Assert.AreEqual(0, render);

				// Run for 0.5 secs
				using (Timer closeWindowTimer = new Timer(obj => ((NativeWindow)obj).Stop(), nativeWindow, 500, Timeout.Infinite)) {
					render = 0;

					nativeWindow.Run();
				}

				// More than 1 frame drawn
				Assert.Greater(render, 1);

				// Run for 1 sec, but at 0.5 secs starts animation
				nativeWindow.Animation = false;

				using (Timer closeWindowTimer = new Timer(obj => ((NativeWindow)obj).Stop(), nativeWindow, 1000, Timeout.Infinite)) {
					using (Timer animationTimer = new Timer(obj => ((NativeWindow)obj).Animation = true, nativeWindow, 500, Timeout.Infinite)) {
						render = 0;

						nativeWindow.Run();
					}
				}

				// More than 1 frame drawn
				Assert.Greater(render, 1);
			}
		}

		// [Test(Description = "Test NativeWindow.AnimationTime")]
		public void TestAnimationTime()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// By default, continuos animation
				Assert.AreEqual(0, nativeWindow.AnimationTime);

				nativeWindow.AnimationTime = 10;
				Assert.AreEqual(10, nativeWindow.AnimationTime);
			}
		}

		[Test(Description = "Test NativeWindow.Create(int,int,uint,uint,NativeWindowStyle)")]
		public void TestCreate()
		{
			NativeWindow nativeWindow;

			bool contextCreated = false;
			bool contextDestroying = false;

			using (nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextCreated += (obj, e) => contextCreated = true;
				nativeWindow.ContextDestroying += (obj, e) => contextDestroying = true;

				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				// Create causes GL context creation
				Assert.IsTrue(contextCreated);
				Assert.IsFalse(contextDestroying);
			}

			// Disposition causes GL context disposition
			Assert.IsTrue(contextDestroying);
		}

		[Test(Description = "Test NativeWindow.CreateDeviceContext(): multisample fallback")]
		public void TestCreateDeviceContext_MultisampleFallback()
		{
			const uint impossibleMultisampleBits = 2048;

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// Requires too much multisampling...
				nativeWindow.MultisampleBits = impossibleMultisampleBits;

				Assert.DoesNotThrow(() => nativeWindow.Create(0, 0, 128, 128, NativeWindowStyle.Overlapped));
				Assert.LessOrEqual(nativeWindow.MultisampleBits, impossibleMultisampleBits);
			}
		}

		// [Test(Description = "Test NativeWindow.Run()"), Timeout(1000)]
		public void TestRun()
		{
			NativeWindow nativeWindow;

			bool contextDestroying = false;

			using (nativeWindow = NativeWindow.Create()) {
				nativeWindow.ContextDestroying += (obj, e) => contextDestroying = true;

				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

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

		[Test(Description = "Test NativeWindow.Location"), TestCaseSource(nameof(NativeWindowStyles)), Ignore("TODO")]
		public void TestLocation(NativeWindowStyle style)
		{
			// Note: if other Windows hooks installed are hacking Win32 messages, this test may lead to false negatives

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// Throws exceptions if not created
				Point value;
				Assert.Throws<InvalidOperationException>(() => value = nativeWindow.Location);
				Assert.Throws<InvalidOperationException>(() => nativeWindow.Location = new Point(128, 128));

				nativeWindow.Create(128, 256, 64, 64, style);
				nativeWindow.Show();

				// Location follows creation parameters
				Assert.AreEqual(new Point(128, 256), nativeWindow.Location);

				nativeWindow.Location = new Point(256, 64);
				Assert.AreEqual(new Point(256, 64), nativeWindow.Location);
			}
		}

		[Test(Description = "Test NativeWindow.ClientSize"), TestCaseSource(nameof(NativeWindowStyles)), Ignore("TODO")]
		public void TestClientSize(NativeWindowStyle style)
		{
			// Note: if other Windows hooks installed are hacking Win32 messages, this test may lead to false negatives

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				int resize = 0;

				// Throws exceptions if not created
				Size value;
				Assert.Throws<InvalidOperationException>(() => value = nativeWindow.ClientSize);
				Assert.Throws<InvalidOperationException>(() => nativeWindow.ClientSize = new Size(128, 128));

				nativeWindow.Resize += (object obj, EventArgs e) => resize++;
				nativeWindow.Create(0, 0, 128, 256, style);

				// ClientSize follows creation parameters
				Assert.AreEqual(new Size(128, 256), nativeWindow.ClientSize);
				// Creation shall not raise resize event (instead of must?)
				Assert.AreEqual(0, resize);

				nativeWindow.ClientSize = new Size(256, 64);
				Assert.AreEqual(new Size(256, 64), nativeWindow.ClientSize);
				Assert.AreEqual(1, resize);
			}
		}

		[Test(Description = "Test NativeWindow.Show()")]
		public void TestVisibility()
		{
			int render = 0;

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Render += (obj, e) => render++;

				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);
				nativeWindow.Show();

				// Showing the window cause a Render
				Assert.Greater(render, 0);
			}
		}

		[Test(Description = "Test NativeWindow.Styles (Caption)")]
		public void TestStyles_Caption()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				TestStyles_Generic(nativeWindow, NativeWindowStyle.Caption);
			}
		}

		[Test(Description = "Test NativeWindow.Styles (Border)")]
		public void TestStyles_Border()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				TestStyles_Generic(nativeWindow, NativeWindowStyle.Border);
			}
		}

		[Test(Description = "Test NativeWindow.Styles (Resizeable)")]
		public void TestStyles_Resizeable()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				TestStyles_Generic(nativeWindow, NativeWindowStyle.Resizeable);
			}
		}

		private void TestStyles_Generic(NativeWindow window, NativeWindowStyle style)
		{
			if ((window.SupportedStyles & style) == 0)
				Assert.Inconclusive(style + " style not supported");

			window.Styles = NativeWindowStyle.None;
			Assert.AreEqual(NativeWindowStyle.None, window.Styles & style, "window should not have style " + style);

			window.Styles |= style;
			Assert.AreNotEqual(NativeWindowStyle.None, window.Styles & style);

			window.Styles = window.Styles & ~style;
			Assert.AreEqual(NativeWindowStyle.None, window.Styles & style);
		}

		[Test(Description = "Test NativeWindow.Fullscreen")]
		public void TestFullscreen()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				// Throws exceptions if not created
				bool value;
				Assert.Throws<InvalidOperationException>(() => value = nativeWindow.Fullscreen);
				Assert.Throws<InvalidOperationException>(() => nativeWindow.Fullscreen = true);

				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				Assert.IsFalse(nativeWindow.Fullscreen);

				nativeWindow.Fullscreen = true;
				Assert.IsTrue(nativeWindow.Fullscreen);

				Point p;
				Size s;
				NativeWindowStyle styles;

				// Getters are not affected by Fullscreen state
				Assert.DoesNotThrow(() => p = nativeWindow.Location);
				Assert.DoesNotThrow(() => s = nativeWindow.ClientSize);
				Assert.DoesNotThrow(() => styles = nativeWindow.Styles);
				// Setters throws InvalidOperationException
				Assert.Throws<InvalidOperationException>(() => nativeWindow.Location = Point.Empty);
				Assert.Throws<InvalidOperationException>(() => nativeWindow.ClientSize = new Size(256, 256));
				Assert.Throws<InvalidOperationException>(() => nativeWindow.Styles = nativeWindow.Styles);
				Assert.Throws<InvalidOperationException>(() => nativeWindow.Styles = NativeWindowStyle.Overlapped);

				nativeWindow.Fullscreen = false;
				Assert.IsFalse(nativeWindow.Fullscreen);

				// Reset fullscreen to the actual value, should avoid unecessary operations
				nativeWindow.Fullscreen = false;
				Assert.IsFalse(nativeWindow.Fullscreen);
			}
		}

		[Test(Description = "Test NativeWindow.Invalidate()")]
		public void TestInvalidate()
		{
			int render = 0;

			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);
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

		[Test(Description = "Test NativeWindow.IsKeyPressed()")]
		public void TestIsKeyPressed()
		{
			using (NativeWindow nativeWindow = NativeWindow.Create()) {
				KeyCode keyPress, keyUnpress;
				int keyPressCount = 0, keyUnpressCount = 0;

				nativeWindow.Create(0, 0, 640, 480, NativeWindowStyle.None);

				nativeWindow.KeyDown += (object obj, NativeWindowKeyEventArgs e) => { keyPress = e.Key; keyPressCount++; };
				nativeWindow.KeyUp += (object obj, NativeWindowKeyEventArgs e) => { keyUnpress = e.Key; keyUnpressCount++; };

				// Note: test IsKeyPressed values during KeyDown and KeyUp events
				nativeWindow.KeyDown += (object obj, NativeWindowKeyEventArgs e) => Assert.IsTrue(nativeWindow.IsKeyPressed(e.Key));
				nativeWindow.KeyUp += (object obj, NativeWindowKeyEventArgs e) => Assert.IsFalse(nativeWindow.IsKeyPressed(e.Key));

				foreach (KeyCode key in Enum.GetValues(typeof(KeyCode))) {
					// None is not supported
					if (key == KeyCode.None || key == KeyCode.MaxKeycode)
						continue;

					keyPress = keyUnpress = KeyCode.None;
					keyPressCount = keyUnpressCount = 0;

					// Emulates the key press
					nativeWindow.EmulatesKeyPress(key);

					// KeyDown event raised once
					Assert.AreEqual(key, keyPress);
					Assert.AreEqual(1, keyPressCount);

					// KeyUp event raised once
					Assert.AreEqual(key, keyUnpress);
					Assert.AreEqual(1, keyUnpressCount);
				}
			}
		}
	}
}
