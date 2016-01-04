
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

using NUnit.Framework;

namespace OpenGL.Hal.Test
{
	/// <summary>
	/// Test ArrayBufferObject class.
	/// </summary>
	[TestFixture]
	class ArrayBufferObjectTest : TestBase
	{
		/// <summary>
		/// Test Line program vertex shader object.
		/// </summary>
		[Test]
		public void ConstructorDefaultValues()
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				Assert.AreEqual(BufferObjectHint.StaticCpuDraw, arrayBuffer.BufferHint);

				Assert.AreEqual(VertexBaseType.Float, arrayBuffer.ArrayBaseType);
				Assert.AreEqual(ArrayBufferItemType.Float3, arrayBuffer.ArrayType);
				Assert.AreEqual(0, arrayBuffer.ItemCount);
				Assert.AreEqual(12, arrayBuffer.ItemSize);
				Assert.IsFalse(arrayBuffer.Interleaved);
			}
		}

		[Test]
		public void CreateClear()
		{
			CreateClearCore();
		}

		[Test]
		public void CreateClearNoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexArrayObject_ARB = false;

				CreateClearCore();
			} finally {
				_Context.PopCaps();
			}
		}

		private void CreateClearCore()
		{
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
			}
		}
	}
}
