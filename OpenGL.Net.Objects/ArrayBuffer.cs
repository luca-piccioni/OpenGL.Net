
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// Single array buffer object.
	/// </summary>
	public class ArrayBuffer : ArrayBufferBase, ArrayBufferBase.IArraySection
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength, BufferUsage hint) :
			this(vertexBaseType, vertexLength, 1, hint)
		{

		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="vertexRank">
		/// A <see cref="UInt32"/> that specify how many columns have the array item of matrix type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank, BufferUsage hint) :
			this(vertexBaseType.GetArrayBufferType(vertexLength, vertexRank), hint)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBuffer(ArrayBufferItemType format, BufferUsage hint) :
			base(hint)
		{
			try {
				// Store array type
				_ArrayType = format;
				// Determine array item size
				ItemSize = format.GetItemSize();
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength, MapBufferUsageMask usageMask) :
			this(vertexBaseType, vertexLength, 1, usageMask)
		{

		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="vertexRank">
		/// A <see cref="UInt32"/> that specify how many columns have the array item of matrix type.
		/// </param>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank, MapBufferUsageMask usageMask) :
			this(vertexBaseType.GetArrayBufferType(vertexLength, vertexRank), usageMask)
		{

		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBuffer(ArrayBufferItemType format, MapBufferUsageMask usageMask) :
			base(usageMask)
		{
			try {
				// Store array type
				_ArrayType = format;
				// Determine array item size
				ItemSize = format.GetItemSize();
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Array Buffer Information

		/// <summary>
		/// The array buffer object element type, on CPU side.
		/// </summary>
		public ArrayBufferItemType ArrayType { get { return (_ArrayType); } }

		/// <summary>
		/// The array buffer object element type.
		/// </summary>
		private readonly ArrayBufferItemType _ArrayType;

		#endregion

		#region To Array

		#region ToArray<T>()

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <typeparam name="T">
		/// The type of elements of the returned array.
		/// </typeparam>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public T[] ToArray<T>() where T : struct { return (ToArray<T>(CpuItemsCount)); }

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <typeparam name="T">
		/// An arbitrary structure defining the returned array item. It doesn't need to be correlated with the ArrayBufferObject
		/// layout.
		/// </typeparam>
		/// <param name="arrayLength">
		/// A <see cref="UInt32"/> that specify the number of elements of the returned array.
		/// </param>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public T[] ToArray<T>(uint arrayLength) where T : struct
		{
			if (arrayLength > CpuItemsCount)
				throw new ArgumentOutOfRangeException("arrayLength", arrayLength, "cannot exceed items count");
			if (CpuBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			Type arrayElementType = typeof(T);
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new InvalidOperationException("invalid array element type");

			// The base type should be corresponding
			ArrayBufferItemType arrayElementVertexType = ArrayBufferItem.GetArrayType(arrayElementType);
			if (_ArrayType.GetVertexBaseType() != arrayElementVertexType.GetVertexBaseType())
				throw new InvalidOperationException(String.Format("source base type of {0} incompatible with destination base type of {1}", arrayElementType.Name, _ArrayType.GetVertexBaseType()));

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = arrayElementVertexType.GetItemSize();
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", "array");

			T[] array = new T[arrayLength];

			// Copy from buffer data to array data
			CopyArray(array, arrayItemSize, CpuBufferAddress, ItemSize, 0, arrayLength);

			return (array);
		}

		#endregion

		#endregion

		#region Strongly Typed Array Factory

		/// <summary>
		/// Create an array buffer object, using the generic class <see cref="ArrayBuffer{T}"/>, depending on a <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that determine the generic argument of the created array buffer object.
		/// </param>
		/// <param name="hint">
		/// A <see cref="BufferUsage"/> required for creating a <see cref="ArrayBuffer"/>.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		public static ArrayBuffer CreateArrayObject(ArrayBufferItemType vertexArrayType, BufferUsage hint)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
					return (new ArrayBuffer<sbyte>(hint));
				case ArrayBufferItemType.Byte2:
					return (new ArrayBuffer<Vertex2b>(hint));
				case ArrayBufferItemType.Byte3:
					return (new ArrayBuffer<Vertex3b>(hint));
				case ArrayBufferItemType.Byte4:
					return (new ArrayBuffer<Vertex4b>(hint));
				case ArrayBufferItemType.UByte:
					return (new ArrayBuffer<byte>(hint));
				case ArrayBufferItemType.UByte2:
					return (new ArrayBuffer<Vertex2ub>(hint));
				case ArrayBufferItemType.UByte3:
					return (new ArrayBuffer<Vertex3ub>(hint));
				case ArrayBufferItemType.UByte4:
					return (new ArrayBuffer<Vertex4ub>(hint));
				case ArrayBufferItemType.Short:
					return (new ArrayBuffer<short>(hint));
				case ArrayBufferItemType.Short2:
					return (new ArrayBuffer<Vertex2s>(hint));
				case ArrayBufferItemType.Short3:
					return (new ArrayBuffer<Vertex3s>(hint));
				case ArrayBufferItemType.Short4:
					return (new ArrayBuffer<Vertex4s>(hint));
				case ArrayBufferItemType.UShort:
					return (new ArrayBuffer<ushort>(hint));
				case ArrayBufferItemType.UShort2:
					return (new ArrayBuffer<Vertex2us>(hint));
				case ArrayBufferItemType.UShort3:
					return (new ArrayBuffer<Vertex3us>(hint));
				case ArrayBufferItemType.UShort4:
					return (new ArrayBuffer<Vertex4us>(hint));
				case ArrayBufferItemType.Int:
					return (new ArrayBuffer<int>(hint));
				case ArrayBufferItemType.Int2:
					return (new ArrayBuffer<Vertex2i>(hint));
				case ArrayBufferItemType.Int3:
					return (new ArrayBuffer<Vertex3i>(hint));
				case ArrayBufferItemType.Int4:
					return (new ArrayBuffer<Vertex4i>(hint));
				case ArrayBufferItemType.UInt:
					return (new ArrayBuffer<uint>(hint));
				case ArrayBufferItemType.UInt2:
					return (new ArrayBuffer<Vertex2ui>(hint));
				case ArrayBufferItemType.UInt3:
					return (new ArrayBuffer<Vertex3ui>(hint));
				case ArrayBufferItemType.UInt4:
					return (new ArrayBuffer<Vertex4ui>(hint));
				case ArrayBufferItemType.Float:
					return (new ArrayBuffer<float>(hint));
				case ArrayBufferItemType.Float2:
					return (new ArrayBuffer<Vertex2f>(hint));
				case ArrayBufferItemType.Float3:
					return (new ArrayBuffer<Vertex3f>(hint));
				case ArrayBufferItemType.Float4:
					return (new ArrayBuffer<Vertex4f>(hint));
				case ArrayBufferItemType.Float2x4:
					return (new ArrayBuffer<Matrix2x4f>(hint));
				case ArrayBufferItemType.Float4x4:
					return (new ArrayBuffer<Matrix4x4f>(hint));
				case ArrayBufferItemType.Double:
					return (new ArrayBuffer<double>(hint));
				case ArrayBufferItemType.Double2:
					return (new ArrayBuffer<Vertex2d>(hint));
				case ArrayBufferItemType.Double3:
					return (new ArrayBuffer<Vertex3d>(hint));
				case ArrayBufferItemType.Double4:
					return (new ArrayBuffer<Vertex4d>(hint));
				case ArrayBufferItemType.Half:
					return (new ArrayBuffer<HalfFloat>(hint));
				case ArrayBufferItemType.Half2:
					return (new ArrayBuffer<Vertex2hf>(hint));
				case ArrayBufferItemType.Half3:
					return (new ArrayBuffer<Vertex3hf>(hint));
				case ArrayBufferItemType.Half4:
					return (new ArrayBuffer<Vertex4hf>(hint));
				default:
					throw new ArgumentException(String.Format("vertex array type {0} not supported", vertexArrayType));
			}
		}

		#endregion

		#region Copy with Indices

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index.
		/// </summary>
		/// <param name="buffer">
		/// An <see cref="ArrayBuffer"/> that specify the source data buffer to copy.
		/// </param>
		/// <param name="indices">
		/// An array of indices indicating the order of the vertices copied from <paramref name="buffer"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify how many elements to copy from <paramref name="buffer"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first index considered from <paramref name="indices"/>. A
		/// value of 0 indicates that the indices are considered from the first one.
		/// </param>
		/// <param name="stride">
		/// A <see cref="UInt32"/> that specify the offset between two indexes considered for the copy operations
		/// from <paramref name="indices"/>. A value of 1 indicates that all considered indices are contiguos.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffer"/> or <paramref name="indices"/> are null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="count"/> or <paramref name="stride"/> equals to 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the combination of <paramref name="count"/>, <paramref name="offset"/> and
		/// <paramref name="stride"/> will cause a <paramref name="indices"/> array access out of its bounds.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this <see cref="ArrayBuffer"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBuffer buffer, uint[] indices, uint count, uint offset, uint stride)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (indices == null)
				throw new ArgumentNullException("indices");
			if (count == 0)
				throw new ArgumentException("invalid", "count");
			if (stride == 0)
				throw new ArgumentException("invalid", "stride");
			if (offset + ((count - 1) * stride) > indices.Length)
				throw new InvalidOperationException("indices out of bounds");
			if (_ArrayType.GetVertexBaseType() != buffer._ArrayType.GetVertexBaseType())
				throw new InvalidOperationException("base type mismatch");

			Create(count);

			unsafe {
				byte* dstPtr = (byte*)CpuBufferAddress.ToPointer();

				for (uint i = 0; i < count; i++, dstPtr += ItemSize) {
					uint arrayIndex = indices[(i * stride) + offset];

					// Position 'srcPtr' to the indexed element
					byte* srcPtr = ((byte*)buffer.CpuBufferAddress.ToPointer()) + (ItemSize * arrayIndex);

					// Copy the 'arrayIndex'th element
					Memory.Copy(dstPtr, srcPtr, ItemSize);
				}
			}
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer">
		/// An <see cref="ArrayBuffer"/> that specify the source data buffer to copy.
		/// </param>
		/// <param name="vcount">
		/// An array of integers indicating the number of the vertices of the polygon copied from <paramref name="buffer"/>. This parameter
		/// indicated how many polygons to copy (the array length). Each item specify the number of vertices composing the polygon.
		/// </param>
		/// <param name="indices">
		/// An array of indices indicating the order of the vertices copied from <paramref name="buffer"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first index considered from <paramref name="indices"/>. A
		/// value of 0 indicates that the indices are considered from the first one.
		/// </param>
		/// <param name="stride">
		/// A <see cref="UInt32"/> that specify the offset between two indexes considered for the copy operations
		/// from <paramref name="indices"/>. A value of 1 indicates that all considered indices are contiguos.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffer"/>, <paramref name="indices"/> or <paramref name="vcount"/> are null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this <see cref="ArrayBuffer"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBuffer buffer, uint[] indices, uint[] vcount, uint offset, uint stride)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (indices == null)
				throw new ArgumentNullException("indices");
			if (vcount == null)
				throw new ArgumentNullException("indices");
			if (stride == 0)
				throw new ArgumentException("invalid", "stride");
			if (_ArrayType.GetVertexBaseType() != buffer._ArrayType.GetVertexBaseType())
				throw new InvalidOperationException("base type mismatch");

			// Allocate array buffer
			uint minVertices = UInt32.MaxValue, maxVertices = UInt32.MinValue;

			Array.ForEach(vcount, delegate (uint v) {
				minVertices = Math.Min(v, minVertices);
				maxVertices = Math.Max(v, maxVertices);
			});

			if ((minVertices < 3) && (maxVertices >= 3))
				throw new ArgumentException("ambigous polygons set", "vcount");

			uint totalVerticesCount = 0;

			Array.ForEach(vcount, delegate (uint v) {
				if (v == 4) {
					totalVerticesCount += 6;            // Triangulate quad with two triangles
				} else if (v > 4) {
					totalVerticesCount += (v - 2) * 3;  // Triangulate as if it is a polygon
				} else {
					Debug.Assert(v == 3);
					totalVerticesCount += 3;            // Exactly a triangle
				}
			});

			Create(totalVerticesCount);

			// Copy polygons (triangulate)
			uint count = 0;

			unsafe {
				byte* dstPtr = (byte*)CpuBufferAddress.ToPointer();
				uint indicesIndex = offset;

				for (uint i = 0; i < vcount.Length; i++) {
					uint verticesCount = vcount[i];
					uint[] verticesIndices;

					if (verticesCount == 4) {
						verticesIndices = new uint[6];
						verticesIndices[0] = indices[indicesIndex + (0 * stride)];
						verticesIndices[1] = indices[indicesIndex + (1 * stride)];
						verticesIndices[2] = indices[indicesIndex + (2 * stride)];
						verticesIndices[3] = indices[indicesIndex + (0 * stride)];
						verticesIndices[4] = indices[indicesIndex + (2 * stride)];
						verticesIndices[5] = indices[indicesIndex + (3 * stride)];

						indicesIndex += 4 * stride;
					} else if (verticesCount > 4) {
						uint triCount = verticesCount - 2;
						uint pivotIndex = indicesIndex;

						verticesIndices = new uint[triCount * 3];

						// Copy polygon indices
						for (uint tri = 0; tri < triCount; tri++) {
							verticesIndices[tri * 3 + 0] = indices[pivotIndex];
							verticesIndices[tri * 3 + 1] = indices[indicesIndex + (tri + 2) * stride];
							verticesIndices[tri * 3 + 2] = indices[indicesIndex + (tri + 1) * stride];
						}

						indicesIndex += verticesCount * stride;
					} else {
						verticesIndices = new uint[verticesCount];
						for (int j = 0; j < verticesCount; j++, indicesIndex += stride)
							verticesIndices[j] = indices[indicesIndex];
					}

					count += (uint)verticesIndices.Length;

					for (uint j = 0; j < verticesIndices.Length; j++, dstPtr += ItemSize) {
						// Position 'srcPtr' to the indexed element
						byte* srcPtr = ((byte*)buffer.CpuBufferAddress.ToPointer()) + (ItemSize * verticesIndices[j]);
						// Copy the 'arrayIndex'th element
						Memory.Copy(dstPtr, srcPtr, ItemSize);
					}
				}
			}
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="indices"></param>
		/// <param name="count"></param>
		public void Copy(ArrayBuffer buffer, ElementBuffer indices, uint count)
		{
			Copy(buffer, indices, count, 0, 1);
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="indices"></param>
		/// <param name="count"></param>
		/// <param name="offset"></param>
		/// <param name="stride"></param>
		public void Copy(ArrayBuffer buffer, ElementBuffer indices, uint count, uint offset, uint stride)
		{
			uint[] indicesArray;

			switch (indices.ElementsType) {
				case DrawElementsType.UnsignedByte:
					indicesArray = Array.ConvertAll<byte, uint>((byte[])indices.ToArray(), delegate (byte item) { return (uint)item; });
					break;
				case DrawElementsType.UnsignedShort:
					indicesArray = Array.ConvertAll<ushort, uint>((ushort[])indices.ToArray(), delegate (ushort item) { return (uint)item; });
					break;
				case DrawElementsType.UnsignedInt:
					indicesArray = (uint[])indices.ToArray();
					break;
				default:
					throw new InvalidOperationException(String.Format("element type {0} not supportted", indices.ElementsType));
			}

			Copy(buffer, indicesArray, count, offset, stride);
		}

		#endregion

		#region Array Item Layout Conversion

		/// <summary>
		/// Copy this array buffer object to another one (strongly typed), but having a different array item type.
		/// </summary>
		/// <typeparam name="T">
		/// A structure type used to determine the array items layout of the converted ArrayBufferObject.
		/// </typeparam>
		/// <returns>
		/// It returns a copy of this ArrayBufferObject, but having a different array item. The returned instance is actually
		/// a <see cref="ArrayBuffer"/>; if it is desiderable a strongly typed <see cref="ArrayBuffer"/>, use
		/// <see cref="ConvertItemType"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the array base type of this ArrayBufferObject (<see cref="ArrayBaseType"/>) is different to the one
		/// derived from <typeparamref name="T"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the number of base components of this ArrayBufferObject cannot be mapped into the base components
		/// count derived from <typeparamref name="T"/>.
		/// </exception>
		public ArrayBuffer<T> ConvertItemType<T>() where T : struct
		{
			ArrayBufferItemType vertexArrayType = ArrayBufferItem.GetArrayType(typeof(T));

			return ((ArrayBuffer<T>)ConvertItemType(vertexArrayType));
		}

		/// <summary>
		/// Copy this array buffer object to another one, but having a different array item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that specify the returned <see cref="ArrayBuffer"/> item type.
		/// </param>
		/// <returns>
		/// It returns a copy of this ArrayBufferObject, but having a different array item. The returned instance is actually
		/// a <see cref="ArrayBuffer"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the array base type of this ArrayBufferObject (<see cref="ArrayBaseType"/>) is different to the one
		/// derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the number of base components of this ArrayBufferObject cannot be mapped into the base components
		/// count derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		public ArrayBuffer ConvertItemType(ArrayBufferItemType vertexArrayType)
		{
			if (_ArrayType.GetVertexBaseType() != vertexArrayType.GetVertexBaseType())
				throw new ArgumentException("base type mismatch", "vertexArrayType");

			uint componentsCount = CpuItemsCount * ArrayType.GetArrayLength() * ArrayType.GetArrayRank();
			uint convComponentsCount = vertexArrayType.GetArrayLength() * vertexArrayType.GetArrayRank();

			Debug.Assert(componentsCount >= convComponentsCount);
			if ((componentsCount % convComponentsCount) != 0)
				throw new InvalidOperationException("components length incompatibility");

			ArrayBuffer arrayObject = CreateArrayObject(vertexArrayType, Hint);

			// Different item count due different lengths
			arrayObject.Create(componentsCount / convComponentsCount);
			// Memory is copied
			Memory.Copy(arrayObject.CpuBufferAddress, CpuBufferAddress, CpuBufferSize);

			return (arrayObject);
		}

		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal override uint ArraySectionsCount { get { return (ItemsCount > 0 ? 1U : 0U); } }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="ArrayBufferBase.IArraySection"/> defining the array section.
		/// </returns>
		protected internal override IArraySection GetArraySection(uint index)
		{
			if (index >= ArraySectionsCount)
				throw new ArgumentOutOfRangeException("greater or equal to ArraySectionsCount", index, "index");

			return (this);
		}

		/// <summary>
		/// Convert the client buffer in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		public override Array ToArray()
		{
			if (CpuBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			Array genericArray = CreateArray(ArrayType, CpuItemsCount);

			// Copy from buffer data to array data
			Memory.Copy(genericArray, CpuBufferAddress, CpuItemsCount * ItemSize);

			return (genericArray);
		}

		/// <summary>
		/// Convert the GPU buffer in a strongly-typed array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> that has created this ArrayBufferObject.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this ArrayBufferObject does not exist for <paramref name="ctx"/>.
		/// </exception>
		public override Array ToArray(GraphicsContext ctx)
		{
			CheckThisExistence(ctx);

			Array genericArray = CreateArray(ArrayType, GpuItemsCount);

			// By checking existence, it's sure that we map the GPU buffer
			Map(ctx, BufferAccess.ReadOnly);
			try {
				// Copy from mapped data to array data
				Memory.Copy(genericArray, MappedBuffer, GpuItemsCount * ItemSize);
			} finally {
				Unmap(ctx);
			}

			return (genericArray);
		}

		#endregion

		#region ArrayBufferObjectBase.IArraySection Implementation

		/// <summary>
		/// The type of the elements of the array section.
		/// </summary>
		ArrayBufferItemType IArraySection.ItemType { get { return (ArrayType); } }

		/// <summary>
		/// Get whether the array elements should be meant normalized (fixed point precision values).
		/// </summary>
		bool IArraySection.Normalized { get { return (false); } }

		/// <summary>
		/// Get the actual array buffer pointer. It could be <see cref="IntPtr.Zero"/> indicating an actual GPU
		/// buffer reference.
		/// </summary>
		IntPtr IArraySection.Pointer { get { return (GpuBufferAddress); } }

		/// <summary>
		/// Offset of the first element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Offset { get { return (IntPtr.Zero); } }

		/// <summary>
		/// Offset between two element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Stride { get { return (IntPtr.Zero); } }

		#endregion
	}

	/// <summary>
	/// Strongly typed array buffer object.
	/// </summary>
	/// <typeparam name="T">
	/// A structure that holds the array item data.
	/// </typeparam>
	public class ArrayBuffer<T> : ArrayBuffer where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct a static ArrayBufferObject.
		/// </summary>
		public ArrayBuffer() :
			this(MapBufferUsageMask.None)
		{

		}

		/// <summary>
		/// Construct an ArrayBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBuffer(BufferUsage hint) :
			base(ArrayBufferItem.GetArrayType(typeof(T)), hint)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferObject.
		/// </summary>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBuffer(MapBufferUsageMask usageMask) :
			base(ArrayBufferItem.GetArrayType(typeof(T)), usageMask)
		{
			
		}

		#endregion

		#region Min/Max

		/// <summary>
		/// Get the minimum of the values
		/// </summary>
		/// <returns></returns>
		public T Min()
		{
			try {
				Map();
				unsafe {
					void* arrayPtr = MappedBuffer.ToPointer();
					object maxValue;

					// Note: support JIT optimization based on typeof(T)

					if        (typeof(T) == typeof(Vertex4f)) {
						maxValue = Vertex4f.Min((Vertex4f*)arrayPtr, CpuBufferSize /  Vertex4f.Size);
					} else if (typeof(T) == typeof(Vertex3f)) {
						maxValue = Vertex3f.Min((Vertex3f*)arrayPtr, CpuBufferSize / Vertex3f.Size);
					} else if (typeof(T) == typeof(Vertex2f)) {
						maxValue = Vertex2f.Min((Vertex2f*)arrayPtr, CpuBufferSize /  Vertex2f.Size);
					} else

					if        (typeof(T) == typeof(Vertex2b)) {
						maxValue = Vertex2b.Min((Vertex2b*)arrayPtr, CpuBufferSize / Vertex2b.Size);
					} else if (typeof(T) == typeof(Vertex2ub)) {
						maxValue = Vertex2ub.Min((Vertex2ub*)arrayPtr, CpuBufferSize /  Vertex2ub.Size);
					} else if (typeof(T) == typeof(Vertex2s)) {
						maxValue = Vertex2s.Min((Vertex2s*)arrayPtr, CpuBufferSize /  Vertex2s.Size);
					} else if (typeof(T) == typeof(Vertex2us)) {
						maxValue = Vertex2us.Min((Vertex2us*)arrayPtr, CpuBufferSize /  Vertex2us.Size);
					} else if (typeof(T) == typeof(Vertex2i)) {
						maxValue = Vertex2i.Min((Vertex2i*)arrayPtr, CpuBufferSize /  Vertex2i.Size);
					} else if (typeof(T) == typeof(Vertex2ui)) {
						maxValue = Vertex2ui.Min((Vertex2ui*)arrayPtr, CpuBufferSize /  Vertex2ui.Size);
					} else if (typeof(T) == typeof(Vertex2d)) {
						maxValue = Vertex2d.Min((Vertex2d*)arrayPtr, CpuBufferSize /  Vertex2d.Size);
					} else if (typeof(T) == typeof(Vertex2hf)) {
						maxValue = Vertex2hf.Min((Vertex2hf*)arrayPtr, CpuBufferSize /  Vertex2hf.Size);
					} else if (typeof(T) == typeof(Vertex3b)) {
						maxValue = Vertex3b.Min((Vertex3b*)arrayPtr, CpuBufferSize /  Vertex3b.Size);
					} else if (typeof(T) == typeof(Vertex3ub)) {
						maxValue = Vertex3ub.Min((Vertex3ub*)arrayPtr, CpuBufferSize /  Vertex3ub.Size);
					} else if (typeof(T) == typeof(Vertex3s)) {
						maxValue = Vertex3s.Min((Vertex3s*)arrayPtr, CpuBufferSize /  Vertex3s.Size);
					} else if (typeof(T) == typeof(Vertex3us)) {
						maxValue = Vertex3us.Min((Vertex3us*)arrayPtr, CpuBufferSize /  Vertex3us.Size);
					} else if (typeof(T) == typeof(Vertex3i)) {
						maxValue = Vertex3i.Min((Vertex3i*)arrayPtr, CpuBufferSize /  Vertex3i.Size);
					} else if (typeof(T) == typeof(Vertex3ui)) {
						maxValue = Vertex3ui.Min((Vertex3ui*)arrayPtr, CpuBufferSize /  Vertex3ui.Size);
					} else if (typeof(T) == typeof(Vertex3d)) {
						maxValue = Vertex3d.Min((Vertex3d*)arrayPtr, CpuBufferSize /  Vertex3d.Size);
					} else if (typeof(T) == typeof(Vertex3hf)) {
						maxValue = Vertex3hf.Min((Vertex3hf*)arrayPtr, CpuBufferSize /  Vertex3hf.Size);
					} else if (typeof(T) == typeof(Vertex4b)) {
						maxValue = Vertex4b.Min((Vertex4b*)arrayPtr, CpuBufferSize /  Vertex4b.Size);
					} else if (typeof(T) == typeof(Vertex4ub)) {
						maxValue = Vertex4ub.Min((Vertex4ub*)arrayPtr, CpuBufferSize /  Vertex4ub.Size);
					} else if (typeof(T) == typeof(Vertex4s)) {
						maxValue = Vertex4s.Min((Vertex4s*)arrayPtr, CpuBufferSize /  Vertex4s.Size);
					} else if (typeof(T) == typeof(Vertex4us)) {
						maxValue = Vertex4us.Min((Vertex4us*)arrayPtr, CpuBufferSize /  Vertex4us.Size);
					} else if (typeof(T) == typeof(Vertex4i)) {
						maxValue = Vertex4i.Min((Vertex4i*)arrayPtr, CpuBufferSize /  Vertex4i.Size);
					} else if (typeof(T) == typeof(Vertex4ui)) {
						maxValue = Vertex4ui.Min((Vertex4ui*)arrayPtr, CpuBufferSize /  Vertex4ui.Size);
					} else if (typeof(T) == typeof(Vertex4d)) {
						maxValue = Vertex4d.Min((Vertex4d*)arrayPtr, CpuBufferSize /  Vertex4d.Size);
					} else if (typeof(T) == typeof(Vertex4hf)) {
						maxValue = Vertex4hf.Min((Vertex4hf*)arrayPtr, CpuBufferSize /  Vertex4hf.Size);
					} else
						throw new NotSupportedException(String.Format("the type {0} is not supported", typeof(T)));
			
					return ((T)maxValue);
				}
			} finally {
				Unmap();
			}
		}

		/// <summary>
		/// Get the maximum of the values
		/// </summary>
		/// <returns></returns>
		public T Max()
		{
			try {
				Map();
				unsafe {
					void* arrayPtr = MappedBuffer.ToPointer();
					object maxValue;

					// Note: support JIT optimization based on typeof(T)

					if        (typeof(T) == typeof(Vertex4f)) {
						maxValue = Vertex4f.Max((Vertex4f*)arrayPtr, CpuBufferSize / Vertex4f.Size);
					} else if (typeof(T) == typeof(Vertex3f)) {
						maxValue = Vertex3f.Max((Vertex3f*)arrayPtr, CpuBufferSize / Vertex3f.Size);
					} else if (typeof(T) == typeof(Vertex2f)) {
						maxValue = Vertex2f.Max((Vertex2f*)arrayPtr, CpuBufferSize / Vertex2f.Size);
					} else

					if        (typeof(T) == typeof(Vertex2b)) {
						maxValue = Vertex2b.Max((Vertex2b*)arrayPtr, CpuBufferSize / Vertex2b.Size);
					} else if (typeof(T) == typeof(Vertex2ub)) {
						maxValue = Vertex2ub.Max((Vertex2ub*)arrayPtr, CpuBufferSize / Vertex2ub.Size);
					} else if (typeof(T) == typeof(Vertex2s)) {
						maxValue = Vertex2s.Max((Vertex2s*)arrayPtr, CpuBufferSize / Vertex2s.Size);
					} else if (typeof(T) == typeof(Vertex2us)) {
						maxValue = Vertex2us.Max((Vertex2us*)arrayPtr, CpuBufferSize / Vertex2us.Size);
					} else if (typeof(T) == typeof(Vertex2i)) {
						maxValue = Vertex2i.Max((Vertex2i*)arrayPtr, CpuBufferSize / Vertex2i.Size);
					} else if (typeof(T) == typeof(Vertex2ui)) {
						maxValue = Vertex2ui.Max((Vertex2ui*)arrayPtr, CpuBufferSize / Vertex2ui.Size);
					} else if (typeof(T) == typeof(Vertex2d)) {
						maxValue = Vertex2d.Max((Vertex2d*)arrayPtr, CpuBufferSize / Vertex2d.Size);
					} else if (typeof(T) == typeof(Vertex2hf)) {
						maxValue = Vertex2hf.Max((Vertex2hf*)arrayPtr, CpuBufferSize / Vertex2hf.Size);
					} else if (typeof(T) == typeof(Vertex3b)) {
						maxValue = Vertex3b.Max((Vertex3b*)arrayPtr, CpuBufferSize / Vertex3b.Size);
					} else if (typeof(T) == typeof(Vertex3ub)) {
						maxValue = Vertex3ub.Max((Vertex3ub*)arrayPtr, CpuBufferSize / Vertex3ub.Size);
					} else if (typeof(T) == typeof(Vertex3s)) {
						maxValue = Vertex3s.Max((Vertex3s*)arrayPtr, CpuBufferSize / Vertex3s.Size);
					} else if (typeof(T) == typeof(Vertex3us)) {
						maxValue = Vertex3us.Max((Vertex3us*)arrayPtr, CpuBufferSize / Vertex3us.Size);
					} else if (typeof(T) == typeof(Vertex3i)) {
						maxValue = Vertex3i.Max((Vertex3i*)arrayPtr, CpuBufferSize / Vertex3i.Size);
					} else if (typeof(T) == typeof(Vertex3ui)) {
						maxValue = Vertex3ui.Max((Vertex3ui*)arrayPtr, CpuBufferSize / Vertex3ui.Size);
					} else if (typeof(T) == typeof(Vertex3d)) {
						maxValue = Vertex3d.Max((Vertex3d*)arrayPtr, CpuBufferSize / Vertex3d.Size);
					} else if (typeof(T) == typeof(Vertex3hf)) {
						maxValue = Vertex3hf.Max((Vertex3hf*)arrayPtr, CpuBufferSize / Vertex3hf.Size);
					} else if (typeof(T) == typeof(Vertex4b)) {
						maxValue = Vertex4b.Max((Vertex4b*)arrayPtr, CpuBufferSize / Vertex4b.Size);
					} else if (typeof(T) == typeof(Vertex4ub)) {
						maxValue = Vertex4ub.Max((Vertex4ub*)arrayPtr, CpuBufferSize / Vertex4ub.Size);
					} else if (typeof(T) == typeof(Vertex4s)) {
						maxValue = Vertex4s.Max((Vertex4s*)arrayPtr, CpuBufferSize / Vertex4s.Size);
					} else if (typeof(T) == typeof(Vertex4us)) {
						maxValue = Vertex4us.Max((Vertex4us*)arrayPtr, CpuBufferSize / Vertex4us.Size);
					} else if (typeof(T) == typeof(Vertex4i)) {
						maxValue = Vertex4i.Max((Vertex4i*)arrayPtr, CpuBufferSize / Vertex4i.Size);
					} else if (typeof(T) == typeof(Vertex4ui)) {
						maxValue = Vertex4ui.Max((Vertex4ui*)arrayPtr, CpuBufferSize / Vertex4ui.Size);
					} else if (typeof(T) == typeof(Vertex4d)) {
						maxValue = Vertex4d.Max((Vertex4d*)arrayPtr, CpuBufferSize / Vertex4d.Size);
					} else if (typeof(T) == typeof(Vertex4hf)) {
						maxValue = Vertex4hf.Max((Vertex4hf*)arrayPtr, CpuBufferSize / Vertex4hf.Size);
					} else
						throw new NotSupportedException(String.Format("the type {0} is not supported", typeof(T)));
			
					return ((T)maxValue);
				}
			} finally {
				Unmap();
			}
		}

		/// <summary>
		/// Get the minimum and the maximum of the values.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		public void MinMax(out T min, out T max)
		{
			try {
				Map();
				unsafe {
					void* arrayPtr = MappedBuffer.ToPointer();
					object minValue, maxValue;

					// Note: support JIT optimization based on typeof(T)

					if        (typeof(T) == typeof(Vertex4f)) {
						Vertex4f vmin, vmax;
						Vertex4f.MinMax((Vertex4f*)arrayPtr, CpuBufferSize / Vertex4f.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3f)) {
						Vertex3f vmin, vmax;
						Vertex3f.MinMax((Vertex3f*)arrayPtr, CpuBufferSize / Vertex3f.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2f)) {
						Vertex2f vmin, vmax;
						Vertex2f.MinMax((Vertex2f*)arrayPtr, CpuBufferSize / Vertex2f.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else 
					
					if (typeof(T) == typeof(Vertex2b)) {
						Vertex2b vmin, vmax;
						Vertex2b.MinMax((Vertex2b*)arrayPtr, CpuBufferSize / Vertex2b.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2ub)) {
						Vertex2ub vmin, vmax;
						Vertex2ub.MinMax((Vertex2ub*)arrayPtr, CpuBufferSize / Vertex2ub.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2s)) {
						Vertex3f vmin, vmax;
						Vertex3f.MinMax((Vertex3f*)arrayPtr, CpuBufferSize / Vertex3f.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2us)) {
						Vertex2us vmin, vmax;
						Vertex2us.MinMax((Vertex2us*)arrayPtr, CpuBufferSize / Vertex2us.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2i)) {
						Vertex2i vmin, vmax;
						Vertex2i.MinMax((Vertex2i*)arrayPtr, CpuBufferSize / Vertex2i.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2ui)) {
						Vertex2ui vmin, vmax;
						Vertex2ui.MinMax((Vertex2ui*)arrayPtr, CpuBufferSize / Vertex2ui.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2d)) {
						Vertex2d vmin, vmax;
						Vertex2d.MinMax((Vertex2d*)arrayPtr, CpuBufferSize / Vertex2d.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex2hf)) {
						Vertex2hf vmin, vmax;
						Vertex2hf.MinMax((Vertex2hf*)arrayPtr, CpuBufferSize / Vertex2hf.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3b)) {
						Vertex3b vmin, vmax;
						Vertex3b.MinMax((Vertex3b*)arrayPtr, CpuBufferSize / Vertex3b.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3ub)) {
						Vertex3ub vmin, vmax;
						Vertex3ub.MinMax((Vertex3ub*)arrayPtr, CpuBufferSize / Vertex3ub.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3s)) {
						Vertex3s vmin, vmax;
						Vertex3s.MinMax((Vertex3s*)arrayPtr, CpuBufferSize / Vertex3s.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3us)) {
						Vertex3us vmin, vmax;
						Vertex3us.MinMax((Vertex3us*)arrayPtr, CpuBufferSize / Vertex3us.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3i)) {
						Vertex3i vmin, vmax;
						Vertex3i.MinMax((Vertex3i*)arrayPtr, CpuBufferSize / Vertex3i.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3ui)) {
						Vertex3ui vmin, vmax;
						Vertex3ui.MinMax((Vertex3ui*)arrayPtr, CpuBufferSize / Vertex3ui.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3d)) {
						Vertex3d vmin, vmax;
						Vertex3d.MinMax((Vertex3d*)arrayPtr, CpuBufferSize / Vertex3d.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex3hf)) {
						Vertex3hf vmin, vmax;
						Vertex3hf.MinMax((Vertex3hf*)arrayPtr, CpuBufferSize / Vertex3hf.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4b)) {
						Vertex4b vmin, vmax;
						Vertex4b.MinMax((Vertex4b*)arrayPtr, CpuBufferSize / Vertex4b.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4ub)) {
						Vertex4ub vmin, vmax;
						Vertex4ub.MinMax((Vertex4ub*)arrayPtr, CpuBufferSize / Vertex4ub.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4s)) {
						Vertex4s vmin, vmax;
						Vertex4s.MinMax((Vertex4s*)arrayPtr, CpuBufferSize / Vertex4s.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4us)) {
						Vertex4us vmin, vmax;
						Vertex4us.MinMax((Vertex4us*)arrayPtr, CpuBufferSize / Vertex4us.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4i)) {
						Vertex4i vmin, vmax;
						Vertex4i.MinMax((Vertex4i*)arrayPtr, CpuBufferSize / Vertex4i.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4ui)) {
						Vertex4ui vmin, vmax;
						Vertex4ui.MinMax((Vertex4ui*)arrayPtr, CpuBufferSize / Vertex4ui.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4d)) {
						Vertex4d vmin, vmax;
						Vertex4d.MinMax((Vertex4d*)arrayPtr, CpuBufferSize / Vertex4d.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else if (typeof(T) == typeof(Vertex4hf)) {
						Vertex4hf vmin, vmax;
						Vertex4hf.MinMax((Vertex4hf*)arrayPtr, CpuBufferSize / Vertex4hf.Size, out vmin, out vmax);
						minValue = vmin; maxValue = vmax;
					} else
						throw new NotSupportedException(String.Format("the type {0} is not supported", typeof(T)));
			
					min = (T)minValue;
					max = (T)maxValue;
				}
			} finally {
				Unmap();
			}
		}

		#endregion

		#region To Array

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public new T[] ToArray()
		{
			return (ToArray<T>());
		}

		#endregion
	}
}