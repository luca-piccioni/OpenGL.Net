
// Copyright (C) 2016 Luca Piccioni
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
	[TestFixture(typeof(ArrayBufferObject))]
	[TestFixture(typeof(ElementBufferObject))]
	[TestFixture(typeof(ArrayBufferObjectInterleaved))]
	[TestFixture(typeof(ArrayBufferObjectPacked))]
	class BufferObjectTest<T> : TestBase where T : BufferObject
	{
		/// <summary>
		/// Create a <see cref="ArrayBufferObjectBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferObjectBase"/> instance to test.
		/// </returns>
		private static BufferObject CreateInstance()
		{
			if (typeof(T) == typeof(ArrayBufferObject))
				return (new ArrayBufferObject(ArrayBufferItemType.Float3, BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ElementBufferObject))
				return (new ElementBufferObject(typeof(uint), BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ArrayBufferObjectInterleaved))
				return (new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ArrayBufferObjectPacked))
				return (new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw));

			Assert.Inconclusive("Type argument not implemented");

			return (null);
		}

		/// <summary>
		/// Create a <see cref="ArrayBufferObjectBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferObjectBase"/> instance to test.
		/// </returns>
		private void CreateClientInstance(BufferObject buffer)
		{
			if (buffer.GetType() == typeof(ArrayBufferObject)) {
				ArrayBufferObject arrayBufferObject = (ArrayBufferObject)buffer;

				arrayBufferObject.Create(CreateTestArray());

			} else if (buffer.GetType() == typeof(ElementBufferObject)) {
				
			} else if (buffer.GetType() == typeof(ArrayBufferObjectInterleaved)) {

			} else if (buffer.GetType() == typeof(ArrayBufferObjectPacked)) {
				
			}
		}

		/// <summary>
		/// Create a <see cref="ArrayBufferObjectBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferObjectBase"/> instance to test.
		/// </returns>
		private void CreateGpuInstance(BufferObject buffer)
		{
			if (buffer.GetType() == typeof(ArrayBufferObject)) {
				ArrayBufferObject arrayBufferObject = (ArrayBufferObject)buffer;

				arrayBufferObject.Create(_Context, CreateTestArray());

			} else if (buffer.GetType() == typeof(ElementBufferObject)) {

			} else if (buffer.GetType() == typeof(ArrayBufferObjectInterleaved)) {

			} else if (buffer.GetType() == typeof(ArrayBufferObjectPacked)) {

			}
		}

		private static Array CreateTestArray()
		{
			if (typeof(T) == typeof(ArrayBufferObject)) {
				return (new float[16]);
			} else if (typeof(T) == typeof(ElementBufferObject)) {
				return (new uint[16]);
			} else if ((typeof(T) == typeof(ArrayBufferObjectInterleaved)) || (typeof(T) == typeof(ArrayBufferObjectPacked))) {
				return (new ComplexVertexElement[16]);
			}

			Assert.Inconclusive("Type argument not implemented");

			return (null);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="buffer"></param>
		private void ConstructionDefaulValues(BufferObject buffer)
		{
			Assert.AreEqual(0, buffer.BufferSize);
			Assert.AreEqual(0, buffer.ClientBufferSize);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="buffer"></param>
		private void DispositionDefaulValues(BufferObject buffer)
		{
			Assert.AreEqual(0, buffer.BufferSize);
			Assert.AreEqual(0, buffer.ClientBufferSize);
		}

		#region ArrayBufferObjectBase.Map()

		public void Map_Core()
		{
			BufferObject bufferRef = null;

			using (BufferObject buffer = CreateInstance()) {
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
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Map()
		{
			Map_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void Map_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				Map_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Map(GraphicsContext)

		public void MapCtx_Core()
		{
			BufferObject bufferRef = null;

			using (BufferObject buffer = CreateInstance()) {
				ConstructionDefaulValues(buffer);

				// Initially not existing
				Assert.IsFalse(buffer.Exists(_Context));
				// Now it is possible to map
				Assert.Throws(Is.InstanceOf<Exception>(), delegate () { buffer.Map(_Context, BufferAccessARB.ReadWrite); });

				// Create a client instance
				CreateClientInstance(buffer);
				// Still not existing
				Assert.IsFalse(buffer.Exists(_Context));

				// Now it is possible to map
				Assert.Throws<InvalidOperationException>(delegate () { buffer.Map(_Context, BufferAccessARB.ReadWrite); });
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
				Assert.DoesNotThrow(delegate () { buffer.Map(_Context, BufferAccessARB.ReadWrite); });
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
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapCtx()
		{
			MapCtx_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapCtx_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				MapCtx_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		#endregion
	}
}
