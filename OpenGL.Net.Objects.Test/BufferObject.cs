
// Copyright (C) 2016-2017 Luca Piccioni
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

namespace OpenGL.Objects.Test
{
	[TestFixture(typeof(ArrayBuffer))]
	[TestFixture(typeof(ElementBuffer))]
	class BufferObjectTest<T> : TestBase where T : Buffer
	{
		public void ExampleCreateArrayBufferObject(GraphicsContext ctx)
		{
			using (ArrayBuffer<Vertex3f> vertexPosition = new ArrayBuffer<Vertex3f>(BufferUsage.StaticDraw)) {
				// Define CPU data
				vertexPosition.Create(new Vertex3f[] {
					Vertex3f.UnitX, Vertex3f.UnitY, Vertex3f.UnitZ
				});
				// Create GPU data
				vertexPosition.Create(ctx);
			}
			
			using (ArrayBuffer<ColorRGBAF> vertexColor = new ArrayBuffer<ColorRGBAF>(BufferUsage.StaticDraw)) {
				// Define GPU items count
				vertexColor.Create(256);
				// Reserve GPU memory
				vertexColor.Create(ctx);
				// Update
				vertexColor.Create(ctx, new ColorRGBAF[] { ColorRGBAF.ColorRed, ColorRGBAF.ColorGreen, ColorRGBAF.ColorBlue });
			}

			// By ArrayBufferItemType
			using (ArrayBuffer buffer = ArrayBuffer.CreateArrayObject(ArrayBufferItemType.Float3x3, BufferUsage.StaticDraw)) {
				// ...
			}
		}

		/// <summary>
		/// Create a <see cref="ArrayBufferBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferBase"/> instance to test.
		/// </returns>
		private static Buffer CreateInstance()
		{
			if (typeof(T) == typeof(ArrayBuffer))
				return (new ArrayBuffer(ArrayBufferItemType.Float3, BufferUsage.StaticDraw));
			else if (typeof(T) == typeof(ElementBuffer))
				return (new ElementBuffer(DrawElementsType.UnsignedInt, BufferUsage.StaticDraw));

			Assert.Inconclusive("Type argument not implemented");

			return (null);
		}

		/// <summary>
		/// Create a <see cref="ArrayBufferBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferBase"/> instance to test.
		/// </returns>
		private void CreateClientInstance(Buffer buffer)
		{
			if (buffer.GetType() == typeof(ArrayBuffer)) {
				ArrayBuffer arrayBufferObject = (ArrayBuffer)buffer;

				arrayBufferObject.Create(CreateTestArray());
			} else if (buffer.GetType() == typeof(ElementBuffer)) {
				ElementBuffer elementBufferObject = (ElementBuffer)buffer;

				elementBufferObject.Create(CreateTestArray());
			}
		}

		/// <summary>
		/// Create a <see cref="ArrayBufferBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferBase"/> instance to test.
		/// </returns>
		private void CreateGpuInstance(Buffer buffer)
		{
			if (buffer.GetType() == typeof(ArrayBuffer)) {
				ArrayBuffer arrayBufferObject = (ArrayBuffer)buffer;

				arrayBufferObject.Create(_Context, CreateTestArray());
			} else if (buffer.GetType() == typeof(ElementBuffer)) {
				ElementBuffer elementBufferObject = (ElementBuffer)buffer;

				elementBufferObject.Create(_Context, CreateTestArray());
			}
		}

		private static Array CreateTestArray()
		{
			if (typeof(T) == typeof(ArrayBuffer)) {
				return (new float[16]);
			} else if (typeof(T) == typeof(ElementBuffer)) {
				return (new uint[16]);
			}

			Assert.Inconclusive("Type argument not implemented");

			return (null);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="buffer"></param>
		private void ConstructionDefaulValues(Buffer buffer)
		{
			Assert.AreEqual(0U, buffer.CpuBufferSize);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="buffer"></param>
		private void DispositionDefaulValues(Buffer buffer)
		{
			Assert.AreEqual(0U, buffer.CpuBufferSize);
		}

		#region ArrayBufferObjectBase.Map()

		public void Map_Core()
		{
			Buffer bufferRef = null;

			using (Buffer buffer = CreateInstance()) {
				ConstructionDefaulValues(buffer);

				// Initially not existing
				Assert.IsFalse(buffer.Exists(_Context));
				// Now it is possible to map
				Assert.Throws(Is.InstanceOf<Exception>(), delegate () { buffer.Map(); });

				// Create a client instance
				CreateClientInstance(buffer);
				// Still not existing
				Assert.IsFalse(buffer.Exists(_Context));

				// Now it is possible to map
				Assert.DoesNotThrow(delegate () { buffer.Map(); });
				// We are notmapped
				Assert.IsTrue(buffer.IsMapped);

				// Unmap
				Assert.DoesNotThrow(delegate () { buffer.Unmap(_Context); });
				// We are not mapped
				Assert.IsFalse(buffer.IsMapped);

				// Test after disposition
				bufferRef = buffer;
			}

			if (bufferRef != null)
				DispositionDefaulValues(bufferRef);
		}

		/// <summary>
		/// Test <see cref="ArrayBuffer.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Map()
		{
			Map_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBuffer.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Map_NoExtension()
		{
			Gl.PushExtensions();
			try {
				// Disable GL_ARB_vertex_array_object
				Gl.CurrentExtensions.VertexBufferObject_ARB = false;

				Map_Core();
			} finally {
				Gl.PopExtensions();
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Map(GraphicsContext)

		public void MapCtx_Core()
		{
			Buffer bufferRef = null;

			using (Buffer buffer = CreateInstance()) {
				ConstructionDefaulValues(buffer);

				// Initially not existing
				Assert.IsFalse(buffer.Exists(_Context));
				// Now it is possible to map
				Assert.Throws(Is.InstanceOf<Exception>(), delegate () { buffer.Map(_Context, BufferAccess.ReadWrite); });

				// Create a client instance
				CreateClientInstance(buffer);
				// Still not existing
				Assert.IsFalse(buffer.Exists(_Context), "BufferObject not existing (client)");

				// Now it is possible to map
				Assert.Throws<InvalidOperationException>(delegate () { buffer.Map(_Context, BufferAccess.ReadWrite); });
				// We are notmapped
				Assert.IsFalse(buffer.IsMapped);

				// Unmap
				Assert.Throws<InvalidOperationException>(delegate () { buffer.Unmap(_Context); });
				// We are not mapped
				Assert.IsFalse(buffer.IsMapped);

				// Create a GPU instance
				CreateGpuInstance(buffer);
				// Now exist
				Assert.IsTrue(buffer.Exists(_Context));

				// Now it is possible to map
				Assert.DoesNotThrow(delegate () { buffer.Map(_Context, BufferAccess.ReadWrite); });
				// We are mapped
				Assert.IsTrue(buffer.IsMapped);

				// Unmap
				Assert.DoesNotThrow(delegate () { buffer.Unmap(_Context); });
				// We are not mapped
				Assert.IsFalse(buffer.IsMapped);

				// Test after disposition
				bufferRef = buffer;
			}

			if (bufferRef != null)
				DispositionDefaulValues(bufferRef);
		}

		/// <summary>
		/// Test <see cref="ArrayBuffer.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapCtx()
		{
			MapCtx_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBuffer.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapCtx_NoExtension()
		{
			Gl.PushExtensions();
			try {
				// Disable GL_ARB_vertex_array_object
				Gl.CurrentExtensions.VertexBufferObject_ARB = false;

				MapCtx_Core();
			} finally {
				Gl.PopExtensions();
			}
		}

		#endregion
	}
}
