
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
using System.Collections.Generic;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture]
	[Category("Framework_DeviceContext")]
	class DeviceContextTest
	{
		[Test(Description = "Test CreatePBuffer")]
		public void TestCreatePBuffer()
		{
			if (DeviceContext.IsPBufferSupported == false)
				Assert.Inconclusive("platform don't support P-Buffers");

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
			EnsurePlatform();
			TestCreate1_Core();
		}

		[Test(Description = "Test Create() [EGL]")]
		public void TestCreate1_EGL()
		{
			EnsureEGL();
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
			EnsurePlatform();
			TestCreate3_Core();
		}

		[Test(Description = "Test Create(INativePBuffer) [EGL]")]
		public void TestCreate3_EGL()
		{
			EnsureEGL();
			TestCreate3_Core();
		}

		private void TestCreate3_Core()
		{
			if (DeviceContext.IsPBufferSupported == false)
				Assert.Inconclusive("platform don't support P-Buffers");

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

		[Test(Description = "Test UseCase 1")]
		public void TestUserCase1()
		{
			EnsurePlatform();
			TestUserCase1_Core();
		}

		[Test(Description = "Test UseCase 1 (EGL)")]
		public void TestUserCase1_EGL()
		{
			EnsureEGL();
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
			EnsurePlatform();
			TestUserCase3_Core();
		}

		[Test(Description = "Test UseCase 3 [EGL]")]
		public void TestUserCase3_EGL()
		{
			EnsureEGL();
			TestUserCase3_Core();
		}

		private void TestUserCase3_Core()
		{
			if (DeviceContext.IsPBufferSupported == false)
				Assert.Inconclusive("platform don't support P-Buffers");

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

		[Test(Description = "Test AvailableAPIs")]
		public void TestAvailableAPIs()
		{
			EnsurePlatform();
			TestAvailableAPIs_Core();
		}

		[Test(Description = "Test AvailableAPIs [EGL]")]
		public void TestAvailableAPIs_EGL()
		{
			EnsureEGL();
			TestAvailableAPIs_Core();
		}

		private void TestAvailableAPIs_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				Assert.IsNotNull(deviceContext.AvailableAPIs);
				CollectionAssert.IsNotEmpty(deviceContext.AvailableAPIs);
			}
		}

		[Test(Description = "Test GetAvailableAPIs")]
		public void TestGetAvailableAPIs()
		{
			EnsurePlatform();
			TestGetAvailableAPIs_Core();
		}

		[Test(Description = "Test GetAvailableAPIs [EGL]")]
		public void TestGetAvailableAPIs_EGL()
		{
			EnsureEGL();
			TestGetAvailableAPIs_Core();
		}

		private void TestGetAvailableAPIs_Core()
		{
			IEnumerable<string> availableAPIs = DeviceContext.GetAvailableAPIs();

			Assert.IsNotNull(availableAPIs);
			CollectionAssert.IsNotEmpty(availableAPIs);

			Console.WriteLine("Available APIs:");
			foreach (string api in availableAPIs)
				Console.WriteLine("- " + api);
		}

		[Test(Description = "Test DefaultAPI")]
		public void TestDefaultAPI_Core()
		{
			// Cannot be initialized to null
			Assert.IsNotNull(DeviceContext.DefaultAPI);
			// Cannot be set to null
			Assert.Throws<InvalidOperationException>(delegate () {
				DeviceContext.DefaultAPI = null;
			}, "unsupported API");
			// Can be set to allowed values
			DeviceContext.DefaultAPI = KhronosVersion.ApiGles1;
			Assert.AreEqual(KhronosVersion.ApiGles1, DeviceContext.DefaultAPI);
			DeviceContext.DefaultAPI = KhronosVersion.ApiGles2;
			Assert.AreEqual(KhronosVersion.ApiGles2, DeviceContext.DefaultAPI);
			DeviceContext.DefaultAPI = KhronosVersion.ApiGlsc2;
			Assert.AreEqual(KhronosVersion.ApiGlsc2, DeviceContext.DefaultAPI);
			DeviceContext.DefaultAPI = KhronosVersion.ApiVg;
			Assert.AreEqual(KhronosVersion.ApiVg, DeviceContext.DefaultAPI);
			DeviceContext.DefaultAPI = KhronosVersion.ApiGl;					// Restore default
			Assert.AreEqual(KhronosVersion.ApiGl, DeviceContext.DefaultAPI);
			// Cannot be set to unknown values
			Assert.Throws<InvalidOperationException>(delegate () {
				DeviceContext.DefaultAPI = "OtherAPI";
			}, "unsupported API");
		}

		[Test(Description = "Test CreateContext(IntPtr)")]
		public void TestCreateContext()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");

			TestCreateContext_Core();
		}

		[Test(Description = "Test CreateContext(IntPtr) [EGL]")]
		public void TestCreateContext_EGL()
		{
			EnsureEGL();
			TestCreateContext_Core();
		}

		private void TestCreateContext_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = IntPtr.Zero;

				Assert.DoesNotThrow(delegate() { glContext = deviceContext.CreateContext(IntPtr.Zero); });
				try {
					Assert.AreNotEqual(IntPtr.Zero, glContext);
					Assert.DoesNotThrow(delegate() { deviceContext.MakeCurrent(glContext); });

					Assert.DoesNotThrow(delegate() { deviceContext.MakeCurrent(IntPtr.Zero); });
				} finally {
					if (glContext != IntPtr.Zero)
						deviceContext.DeleteContext(glContext);
				}
			}
		}

		[Test(Description = "Test CreateContext(IntPtr)")]
		[TestCaseSource("TestDefaultAPIs")]
		public void TestCreateContext_DefaultAPI(string api)
		{
			EnsurePlatform();
			DeviceContext.DefaultAPI = api;
			TestCreateContext_DefaultAPI_Core(api);
		}

		[Test(Description = "Test CreateContext(IntPtr) [EGL]")]
		[TestCaseSource("TestDefaultAPIs")]
		public void TestCreateContext_DefaultAPI_EGL(string api)
		{
			EnsureEGL();
			DeviceContext.DefaultAPI = api;
			TestCreateContext_DefaultAPI_Core(api);
		}

		private static IEnumerable<string> TestDefaultAPIs
		{
			get { return (DeviceContext.GetAvailableAPIs()); }
		}

		private void TestCreateContext_DefaultAPI_Core(string api)
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				List<string> availableAPIs = new List<string>(deviceContext.AvailableAPIs);

				if (availableAPIs.Contains(api) == false)
					Assert.Inconclusive("underlying device is unable to support '" + api + "'");

				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);;
				Assert.AreNotEqual(IntPtr.Zero, glContext);

				try {
					if (deviceContext.MakeCurrent(glContext) == false)
						Assert.Fail("unable to make current");
					
					string glVersionString = Gl.GetString(StringName.Version);
					KhronosVersion glVersion = KhronosVersion.Parse(glVersionString);

					switch (api) {
						case KhronosVersion.ApiGlsc2:
							// SC2 is a special case: based on ES2
							Assert.AreEqual(KhronosVersion.ApiGles2, glVersion.Api);
							break;
						default:
							Assert.AreEqual(api, glVersion.Api);
							break;
					}

					deviceContext.MakeCurrent(IntPtr.Zero);
				} finally {
					if (glContext != IntPtr.Zero)
						deviceContext.DeleteContext(glContext);
				}
			}
		}

		private void TestCreateContextAttrib_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = IntPtr.Zero;

				Assert.DoesNotThrow(delegate() { glContext = deviceContext.CreateContext(IntPtr.Zero); });
				try {
					Assert.AreNotEqual(IntPtr.Zero, glContext);
					Assert.DoesNotThrow(delegate() { deviceContext.MakeCurrent(glContext); });

					Assert.DoesNotThrow(delegate() { deviceContext.MakeCurrent(IntPtr.Zero); });
				} finally {
					if (glContext != IntPtr.Zero)
						deviceContext.DeleteContext(glContext);
				}
			}
		}

		[Test(Description = "Test GetCurrentContext()")]
		public void TestGetCurrentContext()
		{
			EnsurePlatform();
			TestGetCurrentContext_Core();
		}

		[Test(Description = "Test GetCurrentContext() [EGL]")]
		public void TestGetCurrentContext_EGL()
		{
			EnsureEGL();
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

		#region Common

		private static void EnsurePlatform()
		{
			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired == true)
				Assert.Inconclusive("EGL-only platform");
		}

		private static void EnsureEGL()
		{
			if (Egl.IsAvailable == false)
				Assert.Inconclusive("EGL not available");

			// Ensure running without EGL
			Egl.IsRequired = true;
			if (Egl.IsRequired == false)
				Assert.Inconclusive("EGL not available");
		}

		#endregion
	}
}
