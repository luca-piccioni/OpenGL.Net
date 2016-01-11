
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
	[TestFixture()]
	class VertexArrayObjectTest : TestBase
	{
		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="vertexArray"></param>
		private void ConstructionDefaulValues(VertexArrayObject vertexArray)
		{
			Assert.AreEqual(0, vertexArray.ArrayLength);
		}

		/// <summary>
		/// Test for default values after construction.
		/// </summary>
		/// <param name="vertexArray"></param>
		private void DispositionDefaulValues(VertexArrayObject vertexArray)
		{

		}

		private void VertexArrayBufferValues(VertexArrayObject vertexArray, string attributeName, string blockName, ArrayBufferObjectBase arrayBuffer, uint arraySectionIndex)
		{
			VertexArrayObject.VertexArray vertexArrayBuffer = vertexArray.GetVertexArray(attributeName, blockName);

			Assert.IsFalse(arrayBuffer.IsDisposed);
			Assert.IsNotNull(vertexArrayBuffer);
			Assert.AreSame(arrayBuffer, vertexArrayBuffer.ArrayBuffer);
			Assert.AreEqual(arraySectionIndex, vertexArrayBuffer.ArraySectionIndex);
		}

		private void VertexArrayBufferValues(VertexArrayObject vertexArray, string attributeSemantic, ArrayBufferObjectBase arrayBuffer, uint arraySectionIndex)
		{
			VertexArrayObject.VertexArray vertexArrayBuffer = vertexArray.GetVertexArray(attributeSemantic);

			Assert.IsFalse(arrayBuffer.IsDisposed);
			Assert.IsNotNull(vertexArrayBuffer);
			Assert.AreSame(arrayBuffer, vertexArrayBuffer.ArrayBuffer);
			Assert.AreEqual(arraySectionIndex, vertexArrayBuffer.ArraySectionIndex);
		}

		#region SetArray(ArrayBufferObject, uint, string, string)

		[Test]
		public void SetArraySectionByBlock()
		{
			ArrayBufferObjectBase arrayBuffer1 = null, arrayBuffer2 = null, arrayBuffer3 = null;

			try {
				arrayBuffer1 = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
				arrayBuffer1.Create(16);

				arrayBuffer2 = new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer2.Create(16);

				arrayBuffer3 = new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer3.Create(16);

				using (VertexArrayObject vertexArray = new VertexArrayObject()) {
					// Set array buffers to different attributes
					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer1, 0, "attribute1", null); });
					VertexArrayBufferValues(vertexArray, "attribute1", null, arrayBuffer1, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, 0, "attribute2", null); });
					VertexArrayBufferValues(vertexArray, "attribute2", null, arrayBuffer2, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, 1, "attribute3", null); });
					VertexArrayBufferValues(vertexArray, "attribute3", null, arrayBuffer2, 1);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer3, 2, "attribute4", null); });
					VertexArrayBufferValues(vertexArray, "attribute4", null, arrayBuffer3, 2);
				}

				Assert.IsTrue(arrayBuffer1.IsDisposed);
				Assert.IsTrue(arrayBuffer2.IsDisposed);
				Assert.IsTrue(arrayBuffer3.IsDisposed);
			} finally {
				if (arrayBuffer1 != null && !arrayBuffer1.IsDisposed)
					arrayBuffer1.Dispose();
				if (arrayBuffer2 != null && !arrayBuffer2.IsDisposed)
					arrayBuffer2.Dispose();
				if (arrayBuffer3 != null && !arrayBuffer3.IsDisposed)
					arrayBuffer3.Dispose();
			}
		}

		[Test]
		public void SetArraySectionByBlock_Exception1()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				// attributeName is null
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, 0, null, null); });
				// attributeName is empty
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, 0, String.Empty, null); });
			}
		}

		[Test]
		public void SetArraySectionByBlock_Exception2()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
					// arrayBuffer is empty
					Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(arrayBuffer, 0, "attributeName", null); });
				}
			}
		}

		[Test]
		public void SetArraySectionByBlock_Exception3()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
					// Create the array buffer
					arrayBuffer.Create(16);
					// sectionIndex is out of range
					Assert.Throws(Is.InstanceOf(typeof(ArgumentOutOfRangeException)), delegate () { vertexArray.SetArray(arrayBuffer, 1, "attributeName", null); });
				}
			}
		}

		#endregion

		#region SetArray(ArrayBufferObject, string, string)

		[Test]
		public void SetArrayByBlock()
		{
			ArrayBufferObjectBase arrayBuffer1 = null, arrayBuffer2 = null, arrayBuffer3 = null;

			try {
				arrayBuffer1 = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
				arrayBuffer1.Create(16);

				arrayBuffer2 = new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer2.Create(16);

				arrayBuffer3 = new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer3.Create(16);

				using (VertexArrayObject vertexArray = new VertexArrayObject()) {
					// Set array buffers to different attributes
					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer1, "attribute1", null); });
					VertexArrayBufferValues(vertexArray, "attribute1", null, arrayBuffer1, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, "attribute2", null); });
					VertexArrayBufferValues(vertexArray, "attribute2", null, arrayBuffer2, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, "attribute3", null); });
					VertexArrayBufferValues(vertexArray, "attribute3", null, arrayBuffer2, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer3, "attribute4", null); });
					VertexArrayBufferValues(vertexArray, "attribute4", null, arrayBuffer3, 0);
				}

				Assert.IsTrue(arrayBuffer1.IsDisposed);
				Assert.IsTrue(arrayBuffer2.IsDisposed);
				Assert.IsTrue(arrayBuffer3.IsDisposed);
			} finally {
				if (arrayBuffer1 != null && !arrayBuffer1.IsDisposed)
					arrayBuffer1.Dispose();
				if (arrayBuffer2 != null && !arrayBuffer2.IsDisposed)
					arrayBuffer2.Dispose();
				if (arrayBuffer3 != null && !arrayBuffer3.IsDisposed)
					arrayBuffer3.Dispose();
			}
		}

		[Test]
		public void SetArrayByBlock_Exception1()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				// attributeName is null
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, null, null); });
				// attributeName is empty
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, String.Empty, null); });
			}
		}

		[Test]
		public void SetArrayByBlock_Exception2()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
					// arrayBuffer is empty
					Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(arrayBuffer, "attributeName", null); });
				}
			}
		}

		#endregion

		#region SetArray(ArrayBufferObject, uint, string)

		[Test]
		public void SetArraySectionBySemantic()
		{
			ArrayBufferObjectBase arrayBuffer1 = null, arrayBuffer2 = null, arrayBuffer3 = null;

			try {
				arrayBuffer1 = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw);
				arrayBuffer1.Create(16);

				arrayBuffer2 = new ArrayBufferObjectInterleaved(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer2.Create(16);

				arrayBuffer3 = new ArrayBufferObjectPacked(typeof(ComplexVertexElement), BufferObjectHint.StaticCpuDraw);
				arrayBuffer3.Create(16);

				using (VertexArrayObject vertexArray = new VertexArrayObject()) {
					// Set array buffers to different attributes
					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer1, 0, VertexArraySemantic.Position); });
					VertexArrayBufferValues(vertexArray, VertexArraySemantic.Position, arrayBuffer1, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, 0, VertexArraySemantic.Color); });
					VertexArrayBufferValues(vertexArray, VertexArraySemantic.Color, arrayBuffer2, 0);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer2, 1, VertexArraySemantic.Normal); });
					VertexArrayBufferValues(vertexArray, VertexArraySemantic.Normal, arrayBuffer2, 1);

					Assert.DoesNotThrow(delegate () { vertexArray.SetArray(arrayBuffer3, 2, VertexArraySemantic.TexCoord); });
					VertexArrayBufferValues(vertexArray, VertexArraySemantic.TexCoord, arrayBuffer3, 2);
				}

				Assert.IsTrue(arrayBuffer1.IsDisposed);
				Assert.IsTrue(arrayBuffer2.IsDisposed);
				Assert.IsTrue(arrayBuffer3.IsDisposed);
			} finally {
				if (arrayBuffer1 != null && !arrayBuffer1.IsDisposed)
					arrayBuffer1.Dispose();
				if (arrayBuffer2 != null && !arrayBuffer2.IsDisposed)
					arrayBuffer2.Dispose();
				if (arrayBuffer3 != null && !arrayBuffer3.IsDisposed)
					arrayBuffer3.Dispose();
			}
		}

		[Test]
		public void SetArraySectionBySemantic_Exception1()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				// attributeName is null
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, 0, null); });
				// attributeName is empty
				Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(null, 0, String.Empty); });
			}
		}

		[Test]
		public void SetArraySectionBySemantic_Exception2()
		{
			using (VertexArrayObject vertexArray = new VertexArrayObject()) {
				using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
					// arrayBuffer is empty
					Assert.Throws(Is.InstanceOf(typeof(ArgumentException)), delegate () { vertexArray.SetArray(arrayBuffer, 1, VertexArraySemantic.Position); });
				}
			}
		}

		#endregion

		#region Draw(GraphicsContext)

		[Test]
		public void Draw_Exception1()
		{
			Vertex2f[] vertices = new Vertex2f[] {
				new Vertex2f(0.0f, 0.0f),
				new Vertex2f(1.0f, 0.0f),
				new Vertex2f(1.0f, 1.0f),
				new Vertex2f(0.0f, 1.0f),
			};

			using (VertexArrayObject vao = new VertexArrayObject()) {
				// Setup ABO (Position)
				ArrayBufferObject abo = new ArrayBufferObject(VertexBaseType.Float, 2, BufferObjectHint.StaticCpuDraw);
				abo.Create(vertices);

				// Setup VAO
				vao.SetArray(abo, VertexArraySemantic.Position);
				vao.SetElementArray(PrimitiveType.TriangleStrip);
				vao.Create(_Context);

				using (State.GraphicsStateSet currentState = State.GraphicsStateSet.GetDefaultSet()) {
					// Set transform state
					State.TransformStateBase stateTransform = (State.TransformStateBase)currentState[State.TransformStateBase.StateId];

					stateTransform.ModelView.SetIdentity();

					// Apply state
					currentState.Apply(_Context);
					// Draw
					Assert.DoesNotThrow(delegate () { vao.Draw(_Context); });
				}
			}
		}

		#endregion
	}
}
