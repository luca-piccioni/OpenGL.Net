
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
using System.Runtime.InteropServices;

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	struct ComplexVertexElement
	{
		/// <summary>
		/// Position attribute.
		/// </summary>
		public Vertex3f Position;

		/// <summary>
		/// Color attribute.
		/// </summary>
		public ColorRGBA32 Color;

		/// <summary>
		/// Texture coordinates attribute.
		/// </summary>
		public Vertex2f TexCoords;
	}

	/// <summary>
	/// Test ArrayBufferObject class.
	/// </summary>
	[TestFixture(typeof(ArrayBufferObject))]
	[TestFixture(typeof(ElementBufferObject))]
	[TestFixture(typeof(ArrayBufferObjectInterleaved))]
	[TestFixture(typeof(ArrayBufferObjectPacked))]
	class ArrayBufferObjectBaseTest<T> : TestBase where T : ArrayBufferObjectBase
	{
		/// <summary>
		/// Create a <see cref="ArrayBufferObjectBase"/> for testing.
		/// </summary>
		/// <returns>
		/// It returns the <see cref="ArrayBufferObjectBase"/> instance to test.
		/// </returns>
		private static ArrayBufferObjectBase CreateInstance()
		{
			if (typeof(T) == typeof(ArrayBufferObject))
				return (new ArrayBufferObject(ArrayBufferItemType.Float, BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ElementBufferObject))
				return (new ElementBufferObject(DrawElementsType.UnsignedInt, BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ArrayBufferObjectInterleaved))
				return (new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw));
			else if (typeof(T) == typeof(ArrayBufferObjectPacked))
				return (new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw));

			Assert.Inconclusive("Type argument not implemented");

			return (null);
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
		/// <param name="arrayBuffer"></param>
		private void ConstructionDefaulValues(ArrayBufferObjectBase arrayBuffer)
		{
			Assert.AreEqual(0, arrayBuffer.ItemCount);
			Assert.AreEqual(0, arrayBuffer.ClientItemCount);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="arrayBuffer"></param>
		private void DispositionDefaulValues(ArrayBufferObjectBase arrayBuffer)
		{
			Assert.AreEqual(0, arrayBuffer.ItemCount);
			Assert.AreEqual(0, arrayBuffer.ClientItemCount);
		}

		#region ArrayBufferObjectBase.Create(uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		private void CreateCount_Core()
		{
			const uint TestItemCount = 16;

			ArrayBufferObjectBase arrayBufferRef = null;

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				ConstructionDefaulValues(arrayBuffer);

				// Create client buffer
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(TestItemCount);

				// Still not existing
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				// ItemCount reflect client buffer size
				Assert.AreEqual(TestItemCount, arrayBuffer.ItemCount);
				Assert.AreEqual(TestItemCount, arrayBuffer.ClientItemCount);

				// Actually define GPU buffer
				arrayBuffer.Create(_Context);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(TestItemCount, arrayBuffer.ItemCount);
				// ClientItemCount can be 0 (client buffer disposed) or ItemCount
				Assert.IsTrue(arrayBuffer.ClientItemCount == 0 || arrayBuffer.ClientItemCount == arrayBuffer.ItemCount);

				// Define a new client buffer, different from previous
				arrayBuffer.Create(TestItemCount * 2);

				// Still exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// GPU buffer item count hasn't changed
				Assert.AreEqual(TestItemCount, arrayBuffer.ItemCount);
				// Client buffer item count respect the last request
				Assert.AreEqual(TestItemCount * 2, arrayBuffer.ClientItemCount);

				// Actually update GPU buffer
				uint prevObjectName = arrayBuffer.ObjectName;

				arrayBuffer.Create(_Context);
				// Still exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// No new object has been created
				Assert.AreEqual(prevObjectName, arrayBuffer.ObjectName);
				// GPU buffer item count has been updated
				Assert.AreEqual(TestItemCount * 2, arrayBuffer.ItemCount);
				// ClientItemCount can be 0 (client buffer disposed) or ItemCount
				Assert.IsTrue(arrayBuffer.ClientItemCount == 0 || arrayBuffer.ClientItemCount == arrayBuffer.ItemCount);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null)
				DispositionDefaulValues(arrayBufferRef);
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void CreateCount()
		{
			CreateCount_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void CreateCount_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				CreateCount_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateCount_Exception1()
		{
			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create(0);
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Create(GraphicsContext, uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		private void CreateCtxCount_Core()
		{
			const uint TestItemCount = 16;

			ArrayBufferObjectBase arrayBufferRef = null;

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				ConstructionDefaulValues(arrayBuffer);

				// Create GPU memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(_Context, TestItemCount);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(TestItemCount, arrayBuffer.ItemCount);
				// ClientItemCount can be 0 (client buffer disposed) or ItemCount
				Assert.IsTrue(arrayBuffer.ClientItemCount == 0 || arrayBuffer.ClientItemCount == arrayBuffer.ItemCount);

				// We should be able to issue a new buffer
				arrayBuffer.Create(_Context, TestItemCount * 2);
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual(TestItemCount * 2, arrayBuffer.ItemCount);
				// ClientItemCount can be 0 (client buffer disposed) or ItemCount
				Assert.IsTrue(arrayBuffer.ClientItemCount == 0 || arrayBuffer.ClientItemCount == arrayBuffer.ItemCount);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null) {
				Assert.AreEqual(0, arrayBufferRef.ItemCount);
				Assert.AreEqual(0, arrayBufferRef.ClientItemCount);
			}
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void CreateCtxCount()
		{
			CreateCtxCount_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void CreateCtxCount_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				CreateCtxCount_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void CreateCtxCount_Exception1()
		{
			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create((GraphicsContext)null, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateCtxCount_Exception2()
		{
			_Context.MakeCurrent(false);

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateCtxCount_Exception3()
		{
			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Create(Array array, uint offset, uint count)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		private void CreateArray_Core()
		{
			Array testArray = CreateTestArray();

			ArrayBufferObjectBase arrayBufferRef = null;

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				ConstructionDefaulValues(arrayBuffer);

				// Create client memory
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				arrayBuffer.Create(testArray);

				// Still not existing
				Assert.IsFalse(arrayBuffer.Exists(_Context));
				// ItemCount reflect client buffer size
				Assert.AreEqual((uint)testArray.Length, arrayBuffer.ItemCount);

				// Actually define GPU buffer
				arrayBuffer.Create(_Context);

				// Now exists
				Assert.IsTrue(arrayBuffer.Exists(_Context));
				// ItemCount reflect the GPU buffer size
				Assert.AreEqual((uint)testArray.Length, arrayBuffer.ItemCount);

				// Test after disposition
				arrayBufferRef = arrayBuffer;
			}

			if (arrayBufferRef != null)
				DispositionDefaulValues(arrayBufferRef);
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void CreateArray()
		{
			CreateArray_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void CreateArray_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				CreateArray_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Create(GraphicsContext, uint)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, Array)"/>.
		/// </summary>
		private void CreateCtxArray_Core()
		{
			ArrayBufferObjectBase arrayBufferRef = null;

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				ConstructionDefaulValues(arrayBuffer);

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

			if (arrayBufferRef != null)
				DispositionDefaulValues(arrayBufferRef);
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void CreateCtxArray()
		{
			CreateCtxArray_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>.
		/// </summary>
		[Test]
		public void CreateCtxArray_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				CreateCtxArray_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void CreateCtxArray_Exception1()
		{
			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create((GraphicsContext)null, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateCtxArray_Exception2()
		{
			_Context.MakeCurrent(false);

			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		/// <summary>
		/// Test execptions on <see cref="ArrayBufferObject.Create(GraphicsContext, uint)"/>
		/// </summary>
		[Test, ExpectedException(typeof(ArgumentException))]
		public void CreateCtxArray_Exception3()
		{
			using (ArrayBufferObjectBase arrayBuffer = CreateInstance()) {
				arrayBuffer.Create(_Context, 0);
			}
		}

		#endregion
	}
}
