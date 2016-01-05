
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

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test ArrayBufferObject class.
	/// </summary>
	[TestFixture]
	class ArrayBufferObjectTest : TestBase
	{
		#region ArrayBufferObject(VertexBaseType, uint, BufferObjectHint)

		/// <summary>
		/// Test ArrayBufferObject default values after construction.
		/// </summary>
		[Test]
		public void ConstructorDefaultValues()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				Assert.AreEqual(BufferObjectHint.StaticCpuDraw, arrayBuffer.Hint);

				Assert.AreEqual(ArrayBufferItemType.Float3, arrayBuffer.ArrayType);
				Assert.AreEqual(0, arrayBuffer.ItemCount);
				Assert.AreEqual(12, arrayBuffer.ItemSize);
			}
		}

		#endregion

		#region ArrayBufferObject.Create(uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Create1()
		{
			Create1_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Create1_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				Create1_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		private void Create1_Core()
		{
			ArrayBufferObject arrayBufferRef = null;

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				// Create client memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(16);

				// Still not existing
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				// ItemCount reflect client buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// Actually define GPU buffer
				arrayBuffer.Create(_Context);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null) {
				Assert.IsTrue(arrayBufferRef.IsDisposed);
				Assert.IsFalse(arrayBufferRef.Exists(_Context));
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void Create1_Exception1()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(0);
			}
		}

		#endregion

		#region ArrayBufferObject.Create(GraphicsContext, uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void Create2()
		{
			Create2_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void Create2_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				Create2_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		private void Create2_Core()
		{
			ArrayBufferObject arrayBufferRef = null;

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				// Create GPU memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(_Context, 16);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// We should be able to issue a new buffer
				arrayBuffer.Create(_Context, 32);
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(32, arrayBuffer.ItemCount);
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(32 * arrayBuffer.ItemSize, arrayBuffer.BufferSize);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null) {
				Assert.IsTrue(arrayBufferRef.IsDisposed);
				Assert.IsFalse(arrayBufferRef.Exists(_Context));
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void Create2_Exception1()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create((GraphicsContext)null, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void Create2_Exception2()
		{
			_Context.MakeCurrent(false);

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void Create2_Exception3()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		#endregion

		#region Create(Array array, uint offset, uint count)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Create3()
		{
			Create3_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Create3_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				Create3_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		private void Create3_Core()
		{
			ArrayBufferObject arrayBufferRef = null;

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				// Create client memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(new float[16]);

				// Still not existing
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				// ItemCount reflect client buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// Actually define GPU buffer
				arrayBuffer.Create(_Context);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null) {
				Assert.IsTrue(arrayBufferRef.IsDisposed);
				Assert.IsFalse(arrayBufferRef.Exists(_Context));
			}
		}

		#endregion

		#region ArrayBufferObject.Create(GraphicsContext, uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void Create4()
		{
			Create4_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void Create4_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				Create4_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		private void Create4_Core()
		{
			ArrayBufferObject arrayBufferRef = null;

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				// Create GPU memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(_Context, new float[16]);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(16, arrayBuffer.ItemCount);

				// We should be able to issue a new buffer
				arrayBuffer.Create(_Context, new float[32]);
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(32, arrayBuffer.ItemCount);
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(32 * arrayBuffer.ItemSize, arrayBuffer.BufferSize);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null) {
				Assert.IsTrue(arrayBufferRef.IsDisposed);
				Assert.IsFalse(arrayBufferRef.Exists(_Context));
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void Create4_Exception1()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create((GraphicsContext)null, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void Create4_Exception2()
		{
			_Context.MakeCurrent(false);

			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void Create4_Exception3()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		#endregion
	}
}
