
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

using Khronos;

using NUnit.Framework;

namespace OpenGL.Test
{
	[TestFixture, Category("GL")]
	internal class DeviceContextTest : TestBaseDevice
	{
		[Test(Description = "Test CreatePBuffer")]
		public void DeviceContext_CreatePBuffer()
		{
			EnsurePlatform();
			DeviceContext_CreatePBuffer_Core();
		}

		[Test(Description = "Test CreatePBuffer [EGL]")]
		public void DeviceContext_CreatePBuffer_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_CreatePBuffer_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		public void DeviceContext_CreatePBuffer_Core()
		{
			if (DeviceContext.IsPBufferSupported == false)
				Assert.Inconclusive("platform don't support P-Buffers");

			INativePBuffer nativePBuffer = null;

			Assert.Throws<ArgumentNullException>(() => DeviceContext.CreatePBuffer(null, 64, 64));

			// P-Buffer creation should be possible on every platform
			Assert.DoesNotThrow(() => nativePBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 64, 64));
			Assert.IsNotNull(nativePBuffer);

			// Release resources
			nativePBuffer.Dispose();
		}

		[Test(Description = "Test Create()")]
		public void DeviceContext_Create1()
		{
			EnsurePlatform();
			DeviceContext_Create1_Core();
		}

		[Test(Description = "Test Create() [EGL]")]
		public void DeviceContext_Create1_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_Create1_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_Create1_Core()
		{
			DeviceContext deviceContext = null;

			// "Windowless" DeviceContext creation should be possible on every platform
			Assert.DoesNotThrow(() => deviceContext = DeviceContext.Create());
			Assert.IsNotNull(deviceContext);

			// Release resources
			deviceContext.Dispose();
		}

		[Test(Description = "Test Create(IntPtr, IntPtr)")]
		public void DeviceContext_Create2()
		{
			Assert.Inconclusive("not implemented yet");
		}

		[Test(Description = "Test Create(INativePBuffer)")]
		public void DeviceContext_Create3()
		{
			EnsurePlatform();
			DeviceContext_Create3_Core();
		}

		[Test(Description = "Test Create(INativePBuffer) [EGL]")]
		public void DeviceContext_Create3_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_Create3_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_Create3_Core()
		{
			if (DeviceContext.IsPBufferSupported == false)
				Assert.Inconclusive("platform don't support P-Buffers");

			DeviceContext deviceContext = null;

			using (INativePBuffer nativePBuffer = DeviceContext.CreatePBuffer(new DevicePixelFormat(24), 64, 64)) {
				Assert.DoesNotThrow(() => deviceContext = DeviceContext.Create(nativePBuffer));
				Assert.IsNotNull(nativePBuffer);

				// Release resources
				deviceContext.Dispose();
			}
		}

		[Test(Description = "Test RefCount, IncRef, DecRef")]
		public void DeviceContext_ReferenceCount()
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
		public void DeviceContext_UserCase1()
		{
			EnsurePlatform();
			DeviceContext_UserCase1_Core();
		}

		[Test(Description = "Test UseCase 1 (EGL)")]
		public void DeviceContext_UserCase1_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_UserCase1_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_UserCase1_Core()
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
		public void DeviceContext_UserCase3()
		{
			EnsurePlatform();
			DeviceContext_UserCase3_Core();
		}

		[Test(Description = "Test UseCase 3 [EGL]")]
		public void DeviceContext_UserCase3_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_UserCase3_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_UserCase3_Core()
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
		public void DeviceContext_AvailableAPIs()
		{
			EnsurePlatform();
			DeviceContext_AvailableAPIs_Core();
		}

		[Test(Description = "Test AvailableAPIs [EGL]")]
		public void DeviceContext_AvailableAPIs_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_AvailableAPIs_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_AvailableAPIs_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				Assert.IsNotNull(deviceContext.AvailableAPIs);
				CollectionAssert.IsNotEmpty(deviceContext.AvailableAPIs);
			}
		}

		[Test(Description = "Test GetAvailableAPIs")]
		public void DeviceContext_GetAvailableAPIs()
		{
			EnsurePlatform();
			DeviceContext_GetAvailableAPIs_Core();
		}

		[Test(Description = "Test GetAvailableAPIs [EGL]")]
		public void DeviceContext_GetAvailableAPIs_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_GetAvailableAPIs_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private static void DeviceContext_GetAvailableAPIs_Core()
		{
			IEnumerable<string> availableAPIs = DeviceContext.GetAvailableAPIs();

			Assert.IsNotNull(availableAPIs);
			CollectionAssert.IsNotEmpty(availableAPIs);

			Console.WriteLine("Available APIs:");
			foreach (string api in availableAPIs)
				Console.WriteLine("- " + api);
		}

		[Test(Description = "Test DefaultAPI")]
		public void DeviceContext_DefaultAPI_Core()
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
			Assert.Throws<InvalidOperationException>(() => DeviceContext.DefaultAPI = "OtherAPI", "unsupported API");
		}

		[Test(Description = "Test CreateContext(IntPtr)")]
		public void DeviceContext_CreateContext()
		{
			EnsurePlatform();
			DeviceContext_CreateContext_Core();
		}

		[Test(Description = "Test CreateContext(IntPtr) [EGL]")]
		public void DeviceContext_CreateContext_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_CreateContext_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_CreateContext_Core()
		{
			using (Device device = new Device())
			{
				IntPtr glContext = IntPtr.Zero;

				Assert.DoesNotThrow(() => glContext = device.Context.CreateContext(IntPtr.Zero));
				try {
					Assert.AreNotEqual(IntPtr.Zero, glContext);
					Assert.DoesNotThrow(() => { device.Context.MakeCurrent(glContext); });

					Assert.DoesNotThrow(() => { device.Context.MakeCurrent(IntPtr.Zero); });
				} finally {
					if (glContext != IntPtr.Zero)
						device.Context.DeleteContext(glContext);
				}
			}
		}

		[Test(Description = "Test CreateContext(IntPtr)"), TestCaseSource(nameof(TestDefaultAPIs))]
		public void DeviceContext_CreateContext_DefaultAPI(string api)
		{
			EnsurePlatform();
			DeviceContext.DefaultAPI = api;
			DeviceContext_CreateContext_DefaultAPI_Core(api);
		}

		[Test(Description = "Test CreateContext(IntPtr) [EGL]"), TestCaseSource(nameof(TestDefaultAPIs))]
		public void DeviceContext_CreateContext_DefaultAPI_EGL(string api)
		{
			EnsureEGL();
			try {
				DeviceContext.DefaultAPI = api;
				DeviceContext_CreateContext_DefaultAPI_Core(api);
			} finally {
				Egl.IsRequired = false;
			}
		}

		private static IEnumerable<string> TestDefaultAPIs { get { return DeviceContext.GetAvailableAPIs(); } }

		private void DeviceContext_CreateContext_DefaultAPI_Core(string api)
		{
			using (Device device = new Device())
			{
				DeviceContext deviceContext = device.Context;
				List<string> availableAPIs = new List<string>(deviceContext.AvailableAPIs);

				if (availableAPIs.Contains(api) == false)
					Assert.Inconclusive("underlying device is unable to support '" + api + "'");

				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);
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

		private void DeviceContext_CreateContextAttrib_Core()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				if (deviceContext.IsPixelFormatSet == false)
					deviceContext.ChoosePixelFormat(new DevicePixelFormat(24));

				IntPtr glContext = IntPtr.Zero;

				Assert.DoesNotThrow(() => glContext = deviceContext.CreateContext(IntPtr.Zero));
				try {
					Assert.AreNotEqual(IntPtr.Zero, glContext);
					Assert.DoesNotThrow(() => deviceContext.MakeCurrent(glContext));

					Assert.DoesNotThrow(() => deviceContext.MakeCurrent(IntPtr.Zero));
				} finally {
					if (glContext != IntPtr.Zero)
						deviceContext.DeleteContext(glContext);
				}
			}
		}

		[Test(Description = "Test GetCurrentContext()")]
		public void DeviceContext_GetCurrentContext()
		{
			EnsurePlatform();
			DeviceContext_GetCurrentContext_Core();
		}

		[Test(Description = "Test GetCurrentContext() [EGL]")]
		public void DeviceContext_GetCurrentContext_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_GetCurrentContext_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private static void DeviceContext_GetCurrentContext_Core()
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

		[Test(Description = "Test DeleteContext(IntPtr)")]
		public void DeviceContext_DeleteContext()
		{
			EnsurePlatform();
			DeviceContext_DeleteContext_Core();
		}

		[Test(Description = "Test DeleteContext(IntPtr) [EGL]")]
		public void DeviceContext_DeleteContext_EGL()
		{
			EnsureEGL();
			try {
				DeviceContext_DeleteContext_Core();
			} finally {
				Egl.IsRequired = false;
			}
		}

		private void DeviceContext_DeleteContext_Core()
		{
			using (Device device = new Device())
				Assert.Throws<ArgumentException>(() => device.Context.DeleteContext(IntPtr.Zero));
		}

		// P-Buffer backend has pixel format already set...
		//[Test(Description = "Test ChoosePixelFormat()")]
		//public void DeviceContext_ChoosePixelFormat()
		//{
		//	EnsurePlatform();
		//	DeviceContext_ChoosePixelFormat_Core();
		//}

		//[Test(Description = "Test ChoosePixelFormat() [EGL]")]
		//public void DeviceContext_ChoosePixelFormat_EGL()
		//{
		//	EnsureEGL();
		//	try {
		//		DeviceContext_ChoosePixelFormat_Core();
		//	} finally {
		//		Egl.IsRequired = false;
		//	}
		//}

		//private void DeviceContext_ChoosePixelFormat_Core()
		//{
		//	using (Device device = new Device()) {
		//		Assert.Throws<ArgumentNullException>(() => device.Context.ChoosePixelFormat(null));
		//	}
		//}

		#region Common

		private static void EnsurePlatform()
		{
#if !MONODROID
			// Determine whether use EGL as device context backend
			if (Egl.IsAvailable) {
				// Explict initialization? WGL backend is not available
				string envPlatform = Environment.GetEnvironmentVariable("OPENGL_NET_PLATFORM");
				if (envPlatform != null && envPlatform == "EGL")
					Assert.Inconclusive("WGL not available when OPENGL_NET_PLATFORM=EGL");
			}
#endif

			// Ensure running without EGL
			Egl.IsRequired = false;
			if (Egl.IsRequired)
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
