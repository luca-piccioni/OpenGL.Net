
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

namespace OpenGL.Test
{
	[TestFixture]
	[Category("DeviceContext")]
	class DeviceContextTest
	{
		[Test(Description = "Test CreatePBuffer")]
		public void TestCreatePBuffer()
		{
			// Inconclusive test?
			switch (Platform.CurrentPlatformId) {
				case Platform.Id.WindowsNT:
					if (Wgl.CurrentExtensions.Pbuffer_ARB == false && Wgl.CurrentExtensions.Pbuffer_EXT == false)
						Assert.Inconclusive("no WGL_ARB_pbuffer or WGL_EXT_pbuffer support");
					break;
			}

			INativePBuffer nativePBuffer = null;

			// P-Buffer creation should be possible on every platform
			Assert.DoesNotThrow(delegate () {
				nativePBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 64, 64);
			});
			Assert.IsNotNull(nativePBuffer);

			// Release resources
			nativePBuffer.Dispose();
		}

		[Test(Description = "Test Create()")]
		public void TestCreate1()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestCreate1_Core();
		}

		[Test(Description = "Test Create() [EGL]")]
		public void TestCreate1_EGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");

			TestCreate1_Core();
		}

		private void TestCreate1_Core()
		{
			DeviceContext deviceContext = null;

			// "Windowless" DeviceContext creation should be possible on every platform
			Assert.DoesNotThrow(delegate () {
				deviceContext = DeviceContext.Create();
			});
			Assert.IsNotNull(deviceContext);

			// Release resources
			deviceContext.Dispose();
		}

		[Test(Description = "Test Create(IntPtr, IntPtr)")]
		public void TestCreate2()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Create(INativePBuffer)")]
		public void TestCreate3()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestCreate3_Core();
		}

		[Test(Description = "Test Create(INativePBuffer) [EGL]")]
		public void TestCreate3_EGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");

			TestCreate3_Core();
		}

		private void TestCreate3_Core()
		{
			DeviceContext deviceContext = null;

			using (INativePBuffer nativePBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 64, 64)) {
				Assert.DoesNotThrow(delegate () {
					deviceContext = DeviceContext.Create(nativePBuffer);
				});
				Assert.IsNotNull(nativePBuffer);

				// Release resources
				deviceContext.Dispose();
			}
		}

		[Test(Description = "Test DefaultApi")]
		public void TestDefaultApi()
		{
			// Cannot be initialized to null
			Assert.IsNotNull(DeviceContext.DefaultApi);
			// Cannot be set to null
			Assert.Throws<InvalidOperationException>(delegate () {
				DeviceContext.DefaultApi = null;
			}, "unsupported API");
			// Can be set to allowed values
			DeviceContext.DefaultApi = KhronosVersion.ApiGles1;
			Assert.AreEqual(KhronosVersion.ApiGles1, DeviceContext.DefaultApi);
			DeviceContext.DefaultApi = KhronosVersion.ApiGles2;
			Assert.AreEqual(KhronosVersion.ApiGles2, DeviceContext.DefaultApi);
			DeviceContext.DefaultApi = KhronosVersion.ApiGlsc2;
			Assert.AreEqual(KhronosVersion.ApiGlsc2, DeviceContext.DefaultApi);
			DeviceContext.DefaultApi = KhronosVersion.ApiVg;
			Assert.AreEqual(KhronosVersion.ApiVg, DeviceContext.DefaultApi);
			DeviceContext.DefaultApi = KhronosVersion.ApiGl;					// Restore default
			Assert.AreEqual(KhronosVersion.ApiGl, DeviceContext.DefaultApi);
			// Cannot be set to unknown values
			Assert.Throws<InvalidOperationException>(delegate () {
				DeviceContext.DefaultApi = "OtherAPI";
			}, "unsupported API");
		}

		[Test(Description = "Test RefCount, IncRef, DecRef")]
		public void TestReferenceCount()
		{
			// By default, runs without EGL
			Egl.IsRequired = false;

			using (DeviceContext deviceContext = DeviceContext.Create()) {
				Assert.AreEqual(0, deviceContext.RefCount);
				Assert.IsFalse(deviceContext.IsDisposed);

				deviceContext.IncRef();
				Assert.AreEqual(1, deviceContext.RefCount);
				Assert.IsFalse(deviceContext.IsDisposed);

				deviceContext.IncRef();
				Assert.AreEqual(2, deviceContext.RefCount);
				Assert.IsFalse(deviceContext.IsDisposed);

				deviceContext.DecRef();
				Assert.AreEqual(1, deviceContext.RefCount);
				Assert.IsFalse(deviceContext.IsDisposed);

				deviceContext.DecRef();
				Assert.AreEqual(0, deviceContext.RefCount);
				Assert.IsTrue(deviceContext.IsDisposed);
			}
		}

		[Test(Description = "Test GetCurrentContext()")]
		public void TestGetCurrentContext()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestGetCurrentContext_Core();
		}

		[Test(Description = "Test GetCurrentContext() [EGL]")]
		public void TestGetCurrentContext_EGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");

			TestGetCurrentContext_Core();
		}

		private void TestGetCurrentContext_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr currentContext = DeviceContext.GetCurrentContext();

				// Initially no current context
				Assert.AreEqual(IntPtr.Zero, currentContext);

				IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);
				try {
					deviceContext.MakeCurrent(glContext);

					// No the previously GL context is current on this thread
					currentContext = DeviceContext.GetCurrentContext();
					Assert.AreEqual(glContext, currentContext);

					deviceContext.MakeCurrent(IntPtr.Zero);
				} finally {
					deviceContext.DeleteContext(glContext);
				}
			}
		}

		[Test(Description = "Test UseCase 1")]
		public void TestUserCase1()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestUserCase1_Core();
		}

		[Test(Description = "Test UseCase 1 (EGL)")]
		public void TestUserCase1_EGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");

			TestUserCase1_Core();
		}

		private void TestUserCase1_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);

				deviceContext.MakeCurrent(glContext);
				// Perform drawing...
				deviceContext.MakeCurrent(IntPtr.Zero);
				deviceContext.DeleteContext(glContext);
			}
		}

		[Test(Description = "Test UseCase 3")]
		public void TestUserCase3()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestUserCase3_Core();
		}

		[Test(Description = "Test UseCase 3 [EGL]")]
		public void TestUserCase3_EGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");

			TestUserCase3_Core();
		}

		private void TestUserCase3_Core()
		{
			using (INativePBuffer nativePBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 64, 64)) {
				using (DeviceContext deviceContext = DeviceContext.Create(nativePBuffer)) {
					// The pixel format is already defined by INativePBuffer
					Assert.IsTrue(deviceContext.IsPixelFormatSet);

					IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);

					deviceContext.MakeCurrent(glContext);
					// Perform drawing...
					deviceContext.MakeCurrent(IntPtr.Zero);
					deviceContext.DeleteContext(glContext);
				}
			}
		}
	}
}
