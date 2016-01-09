
// Copyright (C) 2009-2015 Luca Piccioni
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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Single array buffer object.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class is a <see cref="BufferObject"/> specialized for storing data to be issued to a shader program execution.
	/// </para>
	/// <para>
	/// The following information defines the array items layout:
	/// - <see cref="ArrayType"/>: the property describe entirely the single item data layout.
	/// - <see cref="ArrayBaseType"/>: the base type of the data component.
	/// - <see cref="ItemCount"/>: the number of items stored in this ArrayBufferObject.
	/// - <see cref="ItemSize"/>: the size of each item in array, in basic machine units.
	/// - <see cref="Interleaved"/>: a boolean flag indicating whether different data types are interleaved regularly in the array.
	/// </para>
	/// </remarks>
	public class ArrayBufferObject : ArrayBufferObjectBase, ArrayBufferObjectBase.IArraySection
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
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(VertexBaseType vertexBaseType, uint vertexLength, BufferObjectHint hint) :
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
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank, BufferObjectHint hint) :
			this(ArrayBufferItem.GetArrayType(vertexBaseType, vertexLength, vertexRank), hint)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(ArrayBufferItemType format, BufferObjectHint hint) :
			base(hint)
		{
			try {
				// Store array type
				_ArrayType = format;
				// Determine array item size
				ItemSize = ArrayBufferItem.GetArrayItemSize(format);
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

		#region Client Buffer Access

		/// <summary>
		/// Gets data from this ArrayBufferObject.
		/// </summary>
		/// <typeparam name='T'>
		/// The type parameter that determine the type of the data to read. This type could be different from the real
		/// ArrayBufferObject items.
		/// </typeparam>
		/// <param name='index'>
		/// The zero-based index of the element to read. The basic machine unit offset of the element to read is
		/// determine by the size of the type <typeparamref name="T"/>.
		/// </param>
		/// <returns>
		/// An element of this ArrayBufferObject, of type <typeparamref name="T"/>, at index <paramref name="index"/>.
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has no client memory allocated.
		/// </exception>
		/// <remarks>
		/// This method differs from <see cref="BufferObject.MapGet{T}(GraphicsContext, long)"/> since it doesn't
		/// require a GraphicsContext for buffer access.
		/// </remarks>
		public T GetClientData<T>(uint index) where T : struct
		{
			IntPtr clientBufferAddress = ClientBufferAddress;

			if (clientBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			IntPtr bufferPtr = new IntPtr(clientBufferAddress.ToInt64() + index * Marshal.SizeOf(typeof(T)));

			return ((T)Marshal.PtrToStructure(bufferPtr, typeof(T)));
		}

		/// <summary>
		/// Sets data to this ArrayBufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// The type parameter that determine the type of the data to read. This type could be different from the real
		/// ArrayBufferObject elements.
		/// </typeparam>
		/// <param name="value">
		/// A <typeparamref name="T"/> that is the value to store in this ArrayBufferObject.
		/// </param>
		/// <param name='index'>
		/// The zero-based index of the element to read. The basic machine unit offset of the element to read is
		/// determine by the size of the type <typeparamref name="T"/>.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has no client memory allocated.
		/// </exception>
		/// <remarks>
		/// This method differs from <see cref="BufferObject.MapSet{T}(GraphicsContext, long)"/> since it doesn't
		/// require a GraphicsContext for buffer access.
		/// </remarks>
		public void SetClientData<T>(T value, uint index) where T : struct
		{
			IntPtr clientBufferAddress = ClientBufferAddress;

			if (clientBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			IntPtr bufferPtr = new IntPtr(clientBufferAddress.ToInt64() + index * Marshal.SizeOf(typeof(T)));

			Marshal.StructureToPtr(value, bufferPtr, false);
		}

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
		public T[] ToArray<T>() where T : struct { return (ToArray<T>(ItemCount)); }

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
			if (arrayLength > ItemCount)
				throw new ArgumentOutOfRangeException("arrayLength", arrayLength, "cannot exceed items count");
			if (ClientBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			Type arrayElementType = typeof(T);
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new InvalidOperationException("invalid array element type");

			// The base type should be corresponding
			ArrayBufferItemType arrayElementVertexType = ArrayBufferItem.GetArrayType(arrayElementType);
			if (ArrayBufferItem.GetArrayBaseType(_ArrayType) != ArrayBufferItem.GetArrayBaseType(arrayElementVertexType))
				throw new InvalidOperationException(String.Format("source base type of {0} incompatible with destination base type of {1}", arrayElementType.Name, ArrayBufferItem.GetArrayBaseType(_ArrayType)));

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = ArrayBufferItem.GetArrayItemSize(arrayElementVertexType);
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", "array");

			T[] array = new T[arrayLength];

			// Copy from buffer data to array data
			CopyArray(array, arrayItemSize, ClientBufferAddress, ItemSize, 0, arrayLength);

			return (array);
		}

		#endregion

		#endregion

		#region Strongly Typed Array Factory

		/// <summary>
		/// Create an array buffer object, using the generic class <see cref="ArrayBufferObject{T}"/>, depending on a <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that determine the generic argument of the created array buffer object.
		/// </param>
		/// <param name="hint">
		/// A <see cref="BufferObjectHint"/> required for creating a <see cref="ArrayBufferObject"/>.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		public static ArrayBufferObject CreateArrayObject(ArrayBufferItemType vertexArrayType, BufferObjectHint hint)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
					return (new ArrayBufferObject<sbyte>(hint));
				case ArrayBufferItemType.Byte2:
					return (new ArrayBufferObject<Vertex2b>(hint));
				case ArrayBufferItemType.Byte3:
					return (new ArrayBufferObject<Vertex3b>(hint));
				case ArrayBufferItemType.Byte4:
					return (new ArrayBufferObject<Vertex4b>(hint));
				case ArrayBufferItemType.UByte:
					return (new ArrayBufferObject<byte>(hint));
				case ArrayBufferItemType.UByte2:
					return (new ArrayBufferObject<Vertex2ub>(hint));
				case ArrayBufferItemType.UByte3:
					return (new ArrayBufferObject<Vertex3ub>(hint));
				case ArrayBufferItemType.UByte4:
					return (new ArrayBufferObject<Vertex4ub>(hint));
				case ArrayBufferItemType.Short:
					return (new ArrayBufferObject<short>(hint));
				case ArrayBufferItemType.Short2:
					return (new ArrayBufferObject<Vertex2s>(hint));
				case ArrayBufferItemType.Short3:
					return (new ArrayBufferObject<Vertex3s>(hint));
				case ArrayBufferItemType.Short4:
					return (new ArrayBufferObject<Vertex4s>(hint));
				case ArrayBufferItemType.UShort:
					return (new ArrayBufferObject<ushort>(hint));
				case ArrayBufferItemType.UShort2:
					return (new ArrayBufferObject<Vertex2us>(hint));
				case ArrayBufferItemType.UShort3:
					return (new ArrayBufferObject<Vertex3us>(hint));
				case ArrayBufferItemType.UShort4:
					return (new ArrayBufferObject<Vertex4us>(hint));
				case ArrayBufferItemType.Int:
					return (new ArrayBufferObject<Int32>(hint));
				case ArrayBufferItemType.Int2:
					return (new ArrayBufferObject<Vertex2i>(hint));
				case ArrayBufferItemType.Int3:
					return (new ArrayBufferObject<Vertex3i>(hint));
				case ArrayBufferItemType.Int4:
					return (new ArrayBufferObject<Vertex4i>(hint));
				case ArrayBufferItemType.UInt:
					return (new ArrayBufferObject<UInt32>(hint));
				case ArrayBufferItemType.UInt2:
					return (new ArrayBufferObject<Vertex2ui>(hint));
				case ArrayBufferItemType.UInt3:
					return (new ArrayBufferObject<Vertex3ui>(hint));
				case ArrayBufferItemType.UInt4:
					return (new ArrayBufferObject<Vertex4ui>(hint));
				case ArrayBufferItemType.Float:
					return (new ArrayBufferObject<Single>(hint));
				case ArrayBufferItemType.Float2:
					return (new ArrayBufferObject<Vertex2f>(hint));
				case ArrayBufferItemType.Float3:
					return (new ArrayBufferObject<Vertex3f>(hint));
				case ArrayBufferItemType.Float4:
					return (new ArrayBufferObject<Vertex4f>(hint));
				case ArrayBufferItemType.Float2x4:
					return (new ArrayBufferObject<Matrix2x4>(hint));
				case ArrayBufferItemType.Float4x4:
					return (new ArrayBufferObject<Matrix4>(hint));
				case ArrayBufferItemType.Double:
					return (new ArrayBufferObject<Double>(hint));
				case ArrayBufferItemType.Double2:
					return (new ArrayBufferObject<Vertex2d>(hint));
				case ArrayBufferItemType.Double3:
					return (new ArrayBufferObject<Vertex3d>(hint));
				case ArrayBufferItemType.Double4:
					return (new ArrayBufferObject<Vertex4d>(hint));
				case ArrayBufferItemType.Half:
					return (new ArrayBufferObject<HalfFloat>(hint));
				case ArrayBufferItemType.Half2:
					return (new ArrayBufferObject<Vertex2hf>(hint));
				case ArrayBufferItemType.Half3:
					return (new ArrayBufferObject<Vertex3hf>(hint));
				case ArrayBufferItemType.Half4:
					return (new ArrayBufferObject<Vertex4hf>(hint));
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
		/// An <see cref="ArrayBufferObject"/> that specify the source data buffer to copy.
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
		/// Exception thrown if this <see cref="ArrayBufferObject"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBufferObject buffer, uint[] indices, uint count, uint offset, uint stride)
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
			if (ArrayBufferItem.GetArrayBaseType(_ArrayType) != ArrayBufferItem.GetArrayBaseType(buffer._ArrayType))
				throw new InvalidOperationException("base type mismatch");

			Create(count);

			unsafe {
				byte* dstPtr = (byte*)ClientBufferAddress.ToPointer();

				for (uint i = 0; i < count; i++, dstPtr += ItemSize) {
					uint arrayIndex = indices[(i * stride) + offset];

					// Position 'srcPtr' to the indexed element
					byte* srcPtr = ((byte*)buffer.ClientBufferAddress.ToPointer()) + (ItemSize * arrayIndex);

					// Copy the 'arrayIndex'th element
					Memory.MemoryCopy(dstPtr, srcPtr, ItemSize);
				}
			}
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer">
		/// An <see cref="ArrayBufferObject"/> that specify the source data buffer to copy.
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
		/// Exception thrown if this <see cref="ArrayBufferObject"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBufferObject buffer, uint[] indices, uint[] vcount, uint offset, uint stride)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (indices == null)
				throw new ArgumentNullException("indices");
			if (vcount == null)
				throw new ArgumentNullException("indices");
			if (stride == 0)
				throw new ArgumentException("invalid", "stride");
			if (ArrayBufferItem.GetArrayBaseType(_ArrayType) != ArrayBufferItem.GetArrayBaseType(buffer._ArrayType))
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
				byte* dstPtr = (byte*)ClientBufferAddress.ToPointer();
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
						byte* srcPtr = ((byte*)buffer.ClientBufferAddress.ToPointer()) + (ItemSize * verticesIndices[j]);
						// Copy the 'arrayIndex'th element
						Memory.MemoryCopy(dstPtr, srcPtr, ItemSize);
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
		public void Copy(ArrayBufferObject buffer, ElementBufferObject indices, uint count)
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
		public void Copy(ArrayBufferObject buffer, ElementBufferObject indices, uint count, uint offset, uint stride)
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
		/// a <see cref="ArrayBufferObject"/>; if it is desiderable a strongly typed <see cref="ArrayBufferObject"/>, use
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
		public ArrayBufferObject<T> ConvertItemType<T>() where T : struct
		{
			ArrayBufferItemType vertexArrayType = ArrayBufferItem.GetArrayType(typeof(T));

			return ((ArrayBufferObject<T>)ConvertItemType(vertexArrayType));
		}

		/// <summary>
		/// Copy this array buffer object to another one, but having a different array item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that specify the returned <see cref="ArrayBufferObject"/> item type.
		/// </param>
		/// <returns>
		/// It returns a copy of this ArrayBufferObject, but having a different array item. The returned instance is actually
		/// a <see cref="ArrayBufferObject"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the array base type of this ArrayBufferObject (<see cref="ArrayBaseType"/>) is different to the one
		/// derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the number of base components of this ArrayBufferObject cannot be mapped into the base components
		/// count derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		public ArrayBufferObject ConvertItemType(ArrayBufferItemType vertexArrayType)
		{
			if (ArrayBufferItem.GetArrayBaseType(_ArrayType) != ArrayBufferItem.GetArrayBaseType(vertexArrayType))
				throw new ArgumentException("base type mismatch", "vertexArrayType");

			uint componentsCount = ItemCount * ArrayBufferItem.GetArrayLength(ArrayType) * ArrayBufferItem.GetArrayRank(ArrayType);
			uint convComponentsCount = ArrayBufferItem.GetArrayLength(vertexArrayType) * ArrayBufferItem.GetArrayRank(vertexArrayType);

			Debug.Assert(componentsCount >= convComponentsCount);
			if ((componentsCount % convComponentsCount) != 0)
				throw new InvalidOperationException("components length incompatibility");

			ArrayBufferObject arrayObject = CreateArrayObject(vertexArrayType, Hint);

			// Different item count due different lengths
			arrayObject.Create(componentsCount / convComponentsCount);
			// Memory is copied
			Memory.MemoryCopy(arrayObject.ClientBufferAddress, ClientBufferAddress, ClientBufferSize);

			return (arrayObject);
		}

		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal override uint ArraySectionsCount { get { return (ItemCount > 0 ? 1U : 0U); } }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="IArraySection"/> defining the array section.
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
			if (ClientBufferAddress == IntPtr.Zero)
				throw new InvalidOperationException("no client buffer");

			Array genericArray = CreateArray(ArrayType, ItemCount);

			// Copy from buffer data to array data
			Memory.MemoryCopy(genericArray, ClientBufferAddress, ItemCount * ItemSize);

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
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			Array genericArray = CreateArray(ArrayType, ItemCount);

			// By checking existence, it's sure that we map the GPU buffer
			Map(ctx, BufferAccessARB.ReadOnly);
			try {
				// Copy from mapped data to array data
				Memory.MemoryCopy(genericArray, MappedBuffer, ItemCount * ItemSize);
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
	/// Stronly typed array buffer object.
	/// </summary>
	/// <typeparam name="T">
	/// A structure that holds the array item data. Typically this type match a <see cref="IVertex"/> or <see cref="IColor"/> implementation,
	/// but it could any value type.
	/// </typeparam>
	public class ArrayBufferObject<T> : ArrayBufferObject where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(BufferObjectHint hint)
			: base(ArrayBufferItem.GetArrayType(typeof(T)), hint)
		{
			
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