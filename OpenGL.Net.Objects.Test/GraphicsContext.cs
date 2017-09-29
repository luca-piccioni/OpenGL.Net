
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

using Khronos;

using NUnit.Framework;

namespace OpenGL.Objects.Test
{
	/// <summary>
	/// Test GraphicsContext class.
	/// </summary>
	[TestFixture]
	class GraphicsContextTest
	{
		[Test(Description = "Test GraphicsContext(DeviceContext, IntPtr)")]
		public void TestConstructorRaw()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				// Create a context manually
				IntPtr glContext = deviceContext.CreateContext(IntPtr.Zero);

				// Create a GraphicsContext on glContext
				GraphicsContext graphicsContext = null;

				try {
					Assert.DoesNotThrow(delegate { graphicsContext = new GraphicsContext(deviceContext, glContext); });
					TestConstructProperties(graphicsContext);

					Assert.AreEqual(glContext, graphicsContext.Handle, "GL context handle different from original");
					Assert.IsTrue(deviceContext.RefCount > 0, "DeviceContext is not referenced");
				} finally {
					if (graphicsContext != null) {
						graphicsContext.Dispose();
						TestDisposedProperties(graphicsContext);
					}
				}

				Assert.IsTrue(deviceContext.RefCount == 0, "DeviceContext was not referenced");

				// Context won't be deleted by GraphicsContext in this case
				deviceContext.DeleteContext(glContext);
			}
		}

		[Test(Description = "Test GraphicsContext(DeviceContext, GraphicsContext, KhronosVersion, GraphicsContextFlags)")]
		public void TestConstructor()
		{
			using (DeviceContext deviceContext = DeviceContext.Create()) {
				GraphicsContext graphicsContext;

				using (graphicsContext = new GraphicsContext(deviceContext)) {
					TestConstructProperties(graphicsContext);
				}
				TestDisposedProperties(graphicsContext);
			}
		}

		private void TestConstructProperties(GraphicsContext graphicsContext)
		{
			if (graphicsContext == null)
				throw new ArgumentNullException("graphicsContext");

			Assert.IsTrue(graphicsContext.IsCurrent, "not current");
			Assert.IsNotNull(graphicsContext.Version, "Version is null");
			if (graphicsContext.ShadingVersion != null)
				Assert.AreEqual(graphicsContext.ShadingVersion.Api, KhronosVersion.ApiGlsl, "GLSL version API is incorrect");
			Assert.AreNotEqual(IntPtr.Zero, graphicsContext.Handle, "GL context handle is zero");
			Assert.AreNotEqual(Guid.Empty, graphicsContext.ObjectNameSpace, "no object namespace");
		}

		private void TestDisposedProperties(GraphicsContext graphicsContext)
		{
			if (graphicsContext == null)
				throw new ArgumentNullException("graphicsContext");

			Assert.AreEqual(IntPtr.Zero, graphicsContext.Handle, "GL context handle is not zero");
			Assert.AreEqual(Guid.Empty, graphicsContext.ObjectNameSpace, "object namespace still defined");
		}
	}
}
