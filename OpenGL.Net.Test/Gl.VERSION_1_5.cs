
// Copyright (C) 2015 Luca Piccioni
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

using NUnit.Framework;

namespace OpenGL.Test
{
	/// <summary>
	/// Test OpenGL 1.5 API.
	/// </summary>
	[TestFixture]
	class Gl_VERSION_1_5 : GlTestBase
	{
		/// <summary>
		/// Test Gl.GenBuffer.
		/// </summary>
		[Test]
		public void TestGenBuffer()
		{
			if (!HasVersion(1, 5) && !IsGlExtensionSupported("GL_ARB_vertex_buffer_object"))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object");

			uint arrayBuffer = Gl.GenBuffer();
			try {
				Assert.AreNotEqual(0, arrayBuffer, "Gl.GenBuffer failure");
				Assert.IsTrue(Gl.IsBuffer(arrayBuffer));
			} finally {
				if (arrayBuffer != 0) {
					Gl.DeleteBuffers(arrayBuffer);
					Assert.IsFalse(Gl.IsBuffer(arrayBuffer), "Gl.DeleteBuffers failure");
				}
			}
		}

		/// <summary>
		/// Test Gl.BufferData.
		/// </summary>
		[Test]
		public void TestBufferData()
		{
			if (!HasVersion(1, 5) && !IsGlExtensionSupported("GL_ARB_vertex_buffer_object"))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object");

			int arrayBufferGet;

			uint arrayBuffer = Gl.GenBuffer();
			try {
				Assert.AreNotEqual(0, arrayBuffer, "Gl.GenBuffer failure");
				Assert.IsTrue(Gl.IsBuffer(arrayBuffer));

				Gl.BindBuffer(BufferTargetARB.ArrayBuffer, arrayBuffer);
				Gl.Get(Gl.ARRAY_BUFFER_BINDING, out arrayBufferGet);
				Assert.AreEqual((int)arrayBuffer, arrayBufferGet);

				Random random = new Random();
				byte[] arrayBufferData = new byte[64], arrayBufferDataGet = new byte[64];
				for (int i = 0; i < arrayBufferData.Length; i++)
					arrayBufferData[i] = (Byte)random.Next(Byte.MaxValue);

				int arrayBufferDataParam;
				Gl.BufferData(BufferTargetARB.ArrayBuffer, (uint)arrayBufferData.Length, arrayBufferData, BufferUsageARB.StaticDraw);
				Gl.GetBufferParameter(BufferTargetARB.ArrayBuffer, Gl.BUFFER_SIZE, out arrayBufferDataParam);
				Assert.AreEqual(arrayBufferData.Length, arrayBufferDataParam);
				Gl.GetBufferParameter(BufferTargetARB.ArrayBuffer, Gl.BUFFER_USAGE, out arrayBufferDataParam);
				Assert.AreEqual((int)BufferUsageARB.StaticDraw, arrayBufferDataParam);

				Gl.GetBufferSubData(BufferTargetARB.ArrayBuffer, IntPtr.Zero, (uint)arrayBufferData.Length, arrayBufferDataGet);
				for (int i = 0; i < arrayBufferDataGet.Length; i++)
					Assert.AreEqual(arrayBufferData[i], arrayBufferDataGet[i]);
			} finally {
				if (arrayBuffer != 0) {
					Gl.DeleteBuffers(arrayBuffer);
					Assert.IsFalse(Gl.IsBuffer(arrayBuffer));
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[Test]
		public void TestMapBuffer()
		{
			if (!HasVersion(1, 5) && !IsGlExtensionSupported("GL_ARB_vertex_buffer_object"))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object");

			int arrayBufferGet;

			uint arrayBuffer = Gl.GenBuffer();
			Assert.AreNotEqual(0, arrayBuffer, "Gl.GenBuffer failure");

			try {
				Assert.IsTrue(Gl.IsBuffer(arrayBuffer));

				Gl.BindBuffer(BufferTargetARB.ArrayBuffer, arrayBuffer);
				Gl.Get(Gl.ARRAY_BUFFER_BINDING, out arrayBufferGet);
				Assert.AreEqual((int)arrayBuffer, arrayBufferGet);

				Random random = new Random();
				byte[] arrayBufferData = new byte[64], arrayBufferDataGet = new byte[64];
				for (int i = 0; i < arrayBufferData.Length; i++)
					arrayBufferData[i] = (Byte)random.Next(Byte.MaxValue);
				Gl.BufferData(BufferTargetARB.ArrayBuffer, (uint)arrayBufferData.Length, arrayBufferData, BufferUsageARB.StaticDraw);

				IntPtr arrayBufferPtr = Gl.MapBuffer(BufferTargetARB.ArrayBuffer, BufferAccessARB.ReadOnly);
				Assert.AreNotEqual(IntPtr.Zero, arrayBufferPtr);
				try {
					IntPtr arrayBufferPtrGet;
					int arrayBufferPtrParam;

					Gl.GetBufferParameter(BufferTargetARB.ArrayBuffer, Gl.BUFFER_MAPPED, out arrayBufferPtrParam);
					Assert.AreEqual(Gl.TRUE, arrayBufferPtrParam);
					Gl.GetBufferParameter(BufferTargetARB.ArrayBuffer, Gl.BUFFER_ACCESS, out arrayBufferPtrParam);
					Assert.AreEqual((int)BufferAccessARB.ReadOnly, arrayBufferPtrParam);

					Gl.GetBufferPointer(BufferTargetARB.ArrayBuffer, Gl.BUFFER_MAP_POINTER, arrayBufferPtrGet);

				} finally {
					Gl.UnmapBuffer(BufferTargetARB.ArrayBuffer);
				}
			} finally {
				Gl.DeleteBuffers(arrayBuffer);
				Assert.IsFalse(Gl.IsBuffer(arrayBuffer));
			}
		}
	}
}
