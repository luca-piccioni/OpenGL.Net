
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

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

		#region ToArray()

		/// <summary>
		/// Test <see cref="ArrayBufferObject.ToArray()"/>.
		/// </summary>
		/// <param name="vertexBaseType"></param>
		/// <param name="vertexLength"></param>
		/// <param name="array"></param>
		public void TestToArray_Core(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(vertexBaseType, vertexLength, BufferObjectHint.StaticCpuDraw)) {
				// Create client buffer
				arrayBuffer.Create(array);
				// ToArray() must be equal to array
				CollectionAssert.AreEqual(array, arrayBuffer.ToArray());

				// Create GPU buffer
				arrayBuffer.Create(_Context);
				// ToArray() must be equal to array
				CollectionAssert.AreEqual(array, arrayBuffer.ToArray(_Context));

				// Create a reversed array from test array
				Array arrayReverse = Array.CreateInstance(array.GetType().GetElementType(), array.Length);
				Array.Copy(array, arrayReverse, array.Length);
				Array.Reverse(arrayReverse);
				CollectionAssert.AreEquivalent(array, arrayReverse);

				// Update client buffer
				arrayBuffer.Create(arrayReverse);
				// Client buffer is updated, but not the GPU buffer
				CollectionAssert.AreEqual(arrayReverse, arrayBuffer.ToArray());
			}
		}

		[Test, TestCaseSource("TestToArrayValues")]
		public void TestToArray(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			TestToArray_Core(vertexBaseType, vertexLength, array);
		}

		[Test, TestCaseSource("TestToArrayValues")]
		public void TestToArray_NoExtension(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				TestToArray_Core(vertexBaseType, vertexLength, array);
			} finally {
				_Context.PopCaps();
			}
		}

		private static object[] TestToArrayValues
		{
			get
			{
				List<object> values = new List<object>();

				values.Add(new object[] { VertexBaseType.Float, 1U, CreateArray<float>() });
				values.Add(new object[] { VertexBaseType.Float, 2U, CreateArray<Vertex2f>() });
				values.Add(new object[] { VertexBaseType.Float, 3U, CreateArray<Vertex3f>() });
				values.Add(new object[] { VertexBaseType.Float, 4U, CreateArray<Vertex4f>() });

				return (values.ToArray());
			}
		}
		
		private static Array CreateArray<T>()
		{
			T[] array = new T[16];
			Random random = new Random();
			int arrayItemSize = Marshal.SizeOf(typeof(T));

			switch (ArrayBufferItem.GetArrayBaseType(typeof(T))) {
				case VertexBaseType.Float:
					unsafe {
						GCHandle arrayHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
						try {
							float* arrayPtr = (float*)arrayHandle.AddrOfPinnedObject().ToPointer();

							for (int i = 0; i < (array.Length * arrayItemSize) / Marshal.SizeOf(typeof(float)); i++)
								arrayPtr[i] = (float)random.NextDouble();
						} finally {
							arrayHandle.Free();
						}
					}
					break;
			}

			return (array);
		}

		#endregion

		#region ToArray(GraphicsContext)

		/// <summary>
		/// Test <see cref="ArrayBufferObject.ToArray()"/>.
		/// </summary>
		/// <param name="vertexBaseType"></param>
		/// <param name="vertexLength"></param>
		/// <param name="array"></param>
		public void TestToArrayCtx_Core(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(vertexBaseType, vertexLength, BufferObjectHint.StaticCpuDraw)) {
				// Without creation, ToArray(GraphicsContext) will throw an exception
				Assert.Throws<InvalidOperationException>(delegate () { arrayBuffer.ToArray(_Context); });

				// Create client buffer
				arrayBuffer.Create(array);
				// ToArray() must be equal to array
				CollectionAssert.AreEqual(array, arrayBuffer.ToArray());

				// Without creation, ToArray(GraphicsContext) will throw an exception
				Assert.Throws<InvalidOperationException>(delegate () { arrayBuffer.ToArray(_Context); });

				// Create GPU buffer
				arrayBuffer.Create(_Context);
				// ToArray() must be equal to array
				CollectionAssert.AreEqual(array, arrayBuffer.ToArray(_Context));

				// Create a reversed array from test array
				Array arrayReverse = Array.CreateInstance(array.GetType().GetElementType(), array.Length);
				Array.Copy(array, arrayReverse, array.Length);
				Array.Reverse(arrayReverse);
				CollectionAssert.AreEquivalent(array, arrayReverse);

				// Update client buffer
				arrayBuffer.Create(arrayReverse);
				// Client buffer is updated, but not the GPU buffer
				CollectionAssert.AreEqual(arrayReverse, arrayBuffer.ToArray());
				CollectionAssert.AreNotEqual(arrayReverse, arrayBuffer.ToArray(_Context));

				// Update GPU buffer
				arrayBuffer.Create(_Context);
				CollectionAssert.AreEqual(arrayReverse, arrayBuffer.ToArray(_Context));
			}
		}

		[Test, TestCaseSource("TestToArrayValues")]
		public void TestToArrayCtx(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			TestToArrayCtx_Core(vertexBaseType, vertexLength, array);
		}

		[Test, TestCaseSource("TestToArrayValues")]
		public void TestToArrayCtx_NoExtension(VertexBaseType vertexBaseType, uint vertexLength, Array array)
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				TestToArrayCtx_Core(vertexBaseType, vertexLength, array);
			} finally {
				_Context.PopCaps();
			}
		}

		#endregion

		#region ArrayBufferObjectBase.Map Performance

		private void MapPerformance_Core()
		{
			const int TestMaxTime = 30, TestMaxSize = 1024 * 1024 * 16;
			const int TestSizeStep = 1024;

			// Determine test array size;
			Vertex3f[] testArray = new Vertex3f[TestSizeStep];

			Stopwatch crono = new Stopwatch();
			int testCalibrationLoops = 0;
			crono.Start();
			do {
				for (int i = 0; i < TestSizeStep; i++, testCalibrationLoops++) {
					Vertex3f testElement = testArray[i];
					testElement = testElement.Normalized;
				}
			} while (crono.ElapsedMilliseconds < TestMaxTime);
			crono.Stop();

			// Allocate and initialize test array
			int testArraySize = Math.Min(TestMaxSize, 1024 * 512);

			testArray = new Vertex3f[testArraySize];

			Stopwatch cronoArray = new Stopwatch();
			Stopwatch cronoBuffer = new Stopwatch();

			cronoArray.Start();
			for (int i = 0; i < testArray.Length; i++) {
				Vertex3f testElement = testArray[i];
				testElement = testElement.Normalized;
			}
			cronoArray.Stop();

			// Test mapped buffer access performance respect the native array access
			using (ArrayBufferObject arrayBuffer = new ArrayBufferObject(VertexBaseType.Float, 3, BufferObjectHint.StaticCpuDraw)) {
				arrayBuffer.Create(_Context, testArray);

				cronoBuffer.Start();
				arrayBuffer.Map(_Context, BufferAccessARB.ReadOnly);
				for (uint i = 0; i < arrayBuffer.ItemCount; i++) {
					Vertex3f testElement = arrayBuffer.Get(_Context, i); ;
					testElement = testElement.Normalized;
				}
				arrayBuffer.Unmap(_Context);
				cronoBuffer.Stop();
			}

			Console.WriteLine("Map performance timings: Array={0} ms buffer={1} ms", cronoArray.ElapsedMilliseconds, cronoBuffer.ElapsedMilliseconds);
			Assert.That((float)cronoArray.ElapsedMilliseconds / (float)cronoBuffer.ElapsedMilliseconds < 1.5f);
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapPerformance()
		{
			MapPerformance_Core();
		}

		/// <summary>
		/// Test <see cref="ArrayBufferObject.Create(uint)"/>.
		/// </summary>
		[Test]
		public void MapPerformance_NoExtension()
		{
			_Context.PushCaps();
			try {
				// Disable GL_ARB_vertex_array_object
				_Context.Caps.GlExtensions.VertexBufferObject_ARB = false;

				MapPerformance_Core();
			} finally {
				_Context.PopCaps();
			}
		}

		#endregion
	}
}
