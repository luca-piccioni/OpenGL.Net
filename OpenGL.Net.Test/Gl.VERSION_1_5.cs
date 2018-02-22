
// Copyright (C) 2015-2018 Luca Piccioni
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
	/// <summary>
	/// Test OpenGL 1.5 API.
	/// </summary>
	[TestFixture, Category("GL_VERSION_1_5")]
	internal class Gl_VERSION_1_5 : TestBaseGL
	{
		/// <summary>
		/// Test Gl.GenBuffer.
		/// </summary>
		[Test]
		public void TestGenBuffer()
		{
			if (!HasVersion(Gl.Version_150) && !HasExtension("GL_ARB_vertex_buffer_object") && !HasVersion(Gl.Version_100_ES) && !HasVersion(Gl.Version_200_ES))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object not supported or OpenGL ES 1.0/2.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				uint arrayBuffer = Gl.GenBuffer();
				try {
					Assert.AreNotEqual(0U, arrayBuffer, "Gl.GenBuffer failure");

					// It seems that on my system glIsBuffer returns true after glGenBuffer... anyone can confirm
					// Assert.IsFalse(Gl.IsBuffer(arrayBuffer));

					Gl.BindBuffer(BufferTarget.ArrayBuffer, arrayBuffer);
					Assert.IsTrue(Gl.IsBuffer(arrayBuffer));

				} finally {
					if (arrayBuffer != 0) {
						Gl.DeleteBuffers(arrayBuffer);
						Assert.IsFalse(Gl.IsBuffer(arrayBuffer), "Gl.DeleteBuffers failure");
					}
				}
			}
		}

		/// <summary>
		/// Test Gl.BufferData.
		/// </summary>
		[Test]
		public void TestBufferData()
		{
			if (!HasVersion(Gl.Version_150) && !HasExtension("GL_ARB_vertex_buffer_object") && !HasVersion(Gl.Version_100_ES) && !HasVersion(Gl.Version_200_ES))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object not supported or OpenGL ES 1.0/2.0");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				int arrayBufferGet;

				uint arrayBuffer = Gl.GenBuffer();
				try {
					Assert.AreNotEqual(0, arrayBuffer, "Gl.GenBuffer failure");
					Assert.IsFalse(Gl.IsBuffer(arrayBuffer));

					Gl.BindBuffer(BufferTarget.ArrayBuffer, arrayBuffer);
					Assert.IsTrue(Gl.IsBuffer(arrayBuffer));

					Gl.Get(Gl.ARRAY_BUFFER_BINDING, out arrayBufferGet);
					Assert.AreEqual((int)arrayBuffer, arrayBufferGet);

					Random random = new Random();
					byte[] arrayBufferData = new byte[64], arrayBufferDataGet = new byte[64];
					for (int i = 0; i < arrayBufferData.Length; i++)
						arrayBufferData[i] = (Byte)random.Next(Byte.MaxValue);

					int arrayBufferDataParam;

					Gl.BufferData(BufferTarget.ArrayBuffer, (uint)arrayBufferData.Length, arrayBufferData, BufferUsage.StaticDraw);

					Gl.GetBufferParameter(BufferTarget.ArrayBuffer, Gl.BUFFER_SIZE, out arrayBufferDataParam);
					Assert.AreEqual(arrayBufferData.Length, arrayBufferDataParam);

					Gl.GetBufferParameter(BufferTarget.ArrayBuffer, Gl.BUFFER_USAGE, out arrayBufferDataParam);
					Assert.AreEqual((int)BufferUsage.StaticDraw, arrayBufferDataParam);

#if !MONODROID
					if (HasVersion(Gl.Version_150) || HasExtension("GL_ARB_vertex_buffer_object")) {
						Gl.GetBufferSubData(BufferTarget.ArrayBuffer, IntPtr.Zero, (uint)arrayBufferData.Length, arrayBufferDataGet);
						for (int i = 0; i < arrayBufferDataGet.Length; i++)
							Assert.AreEqual(arrayBufferData[i], arrayBufferDataGet[i]);
					}
#endif

					Gl.BindBuffer(BufferTarget.ArrayBuffer, 0);
					Gl.Get(Gl.ARRAY_BUFFER_BINDING, out arrayBufferGet);
					Assert.AreEqual(0, arrayBufferGet);

				} finally {
					if (arrayBuffer != 0) {
						Gl.DeleteBuffers(new UInt32[] {  arrayBuffer });
						Assert.IsFalse(Gl.IsBuffer(arrayBuffer));
					}
				}
			}
		}

		/// <summary>
		/// Test Gl.MapBuffer.
		/// </summary>
		[Test]
		public void TestMapBuffer()
		{
			if (!HasVersion(Gl.Version_150) && !HasExtension("GL_ARB_vertex_buffer_object") && !HasExtension("GL_OES_mapbuffer"))
				Assert.Inconclusive("OpenGL 1.5 or GL_ARB_vertex_buffer_object or GL_OES_mapbuffer not supported");

			using (Device device = new Device())
			using (new GLContext(device))
			{
				int arrayBufferGet;

				uint arrayBuffer = Gl.GenBuffer();
				Assert.AreNotEqual(0U, arrayBuffer, "Gl.GenBuffer failure");

				try {
					Assert.IsFalse(Gl.IsBuffer(arrayBuffer));

					Gl.BindBuffer(BufferTarget.ArrayBuffer, arrayBuffer);
					Assert.IsTrue(Gl.IsBuffer(arrayBuffer));

					Gl.Get(Gl.ARRAY_BUFFER_BINDING, out arrayBufferGet);
					Assert.AreEqual((int)arrayBuffer, arrayBufferGet);

					Random random = new Random();
					byte[] arrayBufferData = new byte[64], arrayBufferDataGet = new byte[64];
					for (int i = 0; i < arrayBufferData.Length; i++)
						arrayBufferData[i] = (Byte)random.Next(Byte.MaxValue);
					Gl.BufferData(BufferTarget.ArrayBuffer, (uint)arrayBufferData.Length, arrayBufferData, BufferUsage.StaticDraw);

					IntPtr arrayBufferPtr = Gl.MapBuffer(BufferTarget.ArrayBuffer, BufferAccess.WriteOnly);
					Assert.AreNotEqual(IntPtr.Zero, arrayBufferPtr);
					try {
						IntPtr arrayBufferPtrGet;
						int arrayBufferPtrParam;

						Gl.GetBufferParameter(BufferTarget.ArrayBuffer, Gl.BUFFER_MAPPED, out arrayBufferPtrParam);
						Assert.AreEqual(Gl.TRUE, arrayBufferPtrParam);
						Gl.GetBufferParameter(BufferTarget.ArrayBuffer, Gl.BUFFER_ACCESS, out arrayBufferPtrParam);
						Assert.AreEqual((int)BufferAccess.WriteOnly, arrayBufferPtrParam);

						Gl.GetBufferPointer(BufferTarget.ArrayBuffer, Gl.BUFFER_MAP_POINTER, out arrayBufferPtrGet);
						Assert.AreEqual(arrayBufferPtr, arrayBufferPtrGet);
					} finally {
						Gl.UnmapBuffer(BufferTarget.ArrayBuffer);
					}
				} finally {
					Gl.DeleteBuffers(arrayBuffer);
					Assert.IsFalse(Gl.IsBuffer(arrayBuffer));
				}
			}
		}
	}
}
