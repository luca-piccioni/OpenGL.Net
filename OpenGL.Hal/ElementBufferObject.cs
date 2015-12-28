
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
using System.Globalization;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Element buffer object.
	/// </summary>
	public abstract class ElementBufferObject : BufferObject
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specifies the data buffer usage hints.
		/// </param>
		protected ElementBufferObject(Hint hint)
			: base(BufferTargetARB.ElementArrayBuffer, hint)
		{

		}

		#endregion

		#region Abstract Interface

		/// <summary>
		/// Element array buffer object items count.
		/// </summary>
		public abstract uint ItemCount { get; }

		/// <summary>
		/// The element item size, in bytes.
		/// </summary>
		public abstract uint ItemSize { get; }

		/// <summary>
		/// The element buffer indices type.
		/// </summary>
		internal abstract DrawElementsType ItemType { get; }

		#endregion

		#region Element Buffer Access

		/// <summary>
		/// Get or set ElementBufferObject items.
		/// </summary>
		/// <param name="index">
		/// A <see cref="System.UInt32"/> that specify the item index.
		/// </param>
		public uint this[uint index]
		{
			get
			{
				if ((MemoryBuffer == null) || (MemoryBuffer.AlignedBuffer == IntPtr.Zero))
					throw new InvalidOperationException("not defined");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				Type structType;

				switch (ItemType) {
					case DrawElementsType.UnsignedByte:
						structType = typeof(byte);
						break;
					case DrawElementsType.UnsignedShort:
						structType = typeof(UInt16);
						break;
					case DrawElementsType.UnsignedInt:
						structType = typeof(UInt32);
						break;
					default:
						throw new InvalidOperationException("invalid item type " + ItemType);
				}

				IConvertible value = (IConvertible) Marshal.PtrToStructure(new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + (index * ItemSize)), structType);

				return (value.ToUInt32(NumberFormatInfo.InvariantInfo));
			}
			set
			{
				if ((MemoryBuffer == null) || (MemoryBuffer.AlignedBuffer == IntPtr.Zero))
					throw new InvalidOperationException("not defined");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				object convertedValue;

				switch (ItemType) {
					case DrawElementsType.UnsignedByte:
						convertedValue = (byte) (value & 0xFF);
						break;
					case DrawElementsType.UnsignedShort:
						convertedValue = (ushort) (value & 0xFFFF);
						break;
					case DrawElementsType.UnsignedInt:
						convertedValue = value;
						break;
					default:
						throw new InvalidOperationException("invalid item type " + ItemType);
				}

				Marshal.StructureToPtr(convertedValue, new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + (index * ItemSize)), false);
			}
		}

		#endregion
		
		#region Primitive Restart
		
		/// <summary>
		/// The restart index enabled.
		/// </summary>
		public bool RestartIndexEnabled;
		
		#endregion
		
		#region To Array

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public Array ToArray()
		{
			switch (ItemType) {
				case DrawElementsType.UnsignedByte:
					return (ToArray<byte>());
				case DrawElementsType.UnsignedShort:
					return (ToArray<ushort>());
				case DrawElementsType.UnsignedInt:
					return (ToArray<uint>());
				default:
					throw new InvalidOperationException(String.Format("element type {0} not supported", ItemType));
			}
		}

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <typeparam name="T">
		/// 
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
		/// A <see cref="System.UInt32"/> that specify the number of elements of the returned array.
		/// </param>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public T[] ToArray<T>(uint arrayLength) where T : struct
		{
			T[] array = new T[ItemCount];
			uint sizeOfType = (uint)Marshal.SizeOf(typeof(T));

			if (arrayLength * sizeOfType > ItemCount * ItemSize)
				throw new InvalidOperationException(String.Format("size of {0}[{1}] greater than array buffer", GetType(), arrayLength));

			// Copy from buffer data to array data
			Memory.MemoryCopy(array, MemoryBuffer.AlignedBuffer, arrayLength * sizeOfType);

			return (array);
		}

		#endregion
	}

	/// <summary>
	/// Element buffer object.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class ElementBufferObject<T> : ElementBufferObject where T : struct, IConvertible
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specifies the data buffer usage hints.
		/// </param>
		public ElementBufferObject(Hint hint) : base(hint)
		{
			// The item is represented by 'T'
			mItemSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));
			// Determine the item type by size
			switch (mItemSize) {
				case 1:
					mItemType = DrawElementsType.UnsignedByte;
					break;
				case 2:
					mItemType = DrawElementsType.UnsignedShort;
					break;
				case 4:
					mItemType = DrawElementsType.UnsignedInt;
					break;
				default:
					throw new InvalidOperationException(String.Format("invalid generic type {0}", typeof(T)));
			}
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specifies the data buffer usage hints.
		/// </param>
		public ElementBufferObject(T[] indices, Hint hint) : this(hint)
		{
			Define(indices);
		}

		#endregion

		#region Element Buffer Data Definition

		/// <summary>
		/// Define this ElementBufferObject by specifing only the number of <typeparamref name="T"/> items.
		/// </summary>
		/// <param name="items">
		/// A <see cref="T"/> that specify the contents of this ElementBufferObject.
		/// </param>
		public void Define(T[] items)
		{
			if (items == null)
				throw new ArgumentNullException("items");
			if (items.Length == 0)
				throw new ArgumentException("zero items", "items");
			if ((BufferHint != Hint.StaticCpuDraw) && (BufferHint != Hint.DynamicCpuDraw))
				throw new InvalidOperationException(String.Format("conflicting hint {0}", BufferHint));

			// Store item count
			mItemCount = (uint)items.Length;

			// Allocate buffer
			Allocate((uint)items.Length * mItemSize);
			// Copy the buffer
			GCHandle ppData = GCHandle.Alloc(items, GCHandleType.Pinned);
			try {
				unsafe {
					byte* arrayPtr = (byte*) ppData.AddrOfPinnedObject().ToPointer();
					byte* dstPtr = (byte*) MemoryBuffer.AlignedBuffer.ToPointer();

					Memory.MemoryCopy(dstPtr, arrayPtr, (uint)items.Length * mItemSize);
				}
			} finally {
				ppData.Free();
			}
		}

		/// <summary>
		/// Define this ElementBufferObject by specifing only the number of <typeparamref name="T"/> items.
		/// </summary>
		/// <param name="itemsCount">
		/// A <see cref="System.UInt32"/> that specify the number of <typeparamref name="T"/> hold by this
		/// ArrayBufferObject.
		/// </param>
		public void Define(uint itemsCount)
		{
			// Store item count
			mItemCount = itemsCount;
			// Allocate buffer
			Allocate(itemsCount * mItemSize);
		}

		/// <summary>
		/// The element item size, in bytes.
		/// </summary>
		public override uint ItemSize { get { return (mItemSize); } }

		/// <summary>
		/// The element buffer indicates type.
		/// </summary>
		internal override DrawElementsType ItemType { get { return (mItemType); } }

		/// <summary>
		/// Data item size, in basic machine units (bytes).
		/// </summary>
		private readonly uint mItemSize;

		/// <summary>
		/// Data item type.
		/// </summary>
		private readonly DrawElementsType mItemType;

		#endregion

		#region Element Buffer Conversion

		/// <summary>
		/// 
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="verticesCount"></param>
		public void Triangulate(ElementBufferObject<T> buffer, uint[] verticesCount)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (verticesCount == null)
				throw new ArgumentNullException("verticesCount");

			// Allocate array buffer
			uint minVertices = UInt32.MaxValue, maxVertices = UInt32.MinValue;

			Array.ForEach(verticesCount, delegate(uint v) {
          		minVertices = Math.Min(v, minVertices);
				maxVertices = Math.Max(v, maxVertices);
          	});

			if ((minVertices < 3) && (maxVertices >= 3))
				throw new ArgumentException("ambigous polygons set", "verticesCount");

			uint totalVerticesCount = 0;

			Array.ForEach(verticesCount, delegate(uint v) {
				if (v == 4) {
          			totalVerticesCount += 6;			// Triangulate quad with two triangles
				} else if (v > 4) {
					totalVerticesCount += (v - 2) * 3;	// Triangulate as if it is a polygon
				} else {
					Debug.Assert(v == 3);
					totalVerticesCount += 3;			// Exactly a triangle
				}
			});

			Define(totalVerticesCount);

			// Copy polygons (triangulate)
			uint thisIndicesIndex = 0, indicesIndex = 0;

			for (uint i = 0; i < verticesCount.Length; i++) {
				uint polygonVertices = verticesCount[i];

				if (polygonVertices == 4) {
					this[thisIndicesIndex++] = buffer[indicesIndex + 0];
					this[thisIndicesIndex++] = buffer[indicesIndex + 1];
					this[thisIndicesIndex++] = buffer[indicesIndex + 2];
					this[thisIndicesIndex++] = buffer[indicesIndex + 0];
					this[thisIndicesIndex++] = buffer[indicesIndex + 2];
					this[thisIndicesIndex++] = buffer[indicesIndex + 3];

					indicesIndex += 4;
				} else if (polygonVertices > 4) {
					uint triCount = polygonVertices - 2;
					uint pivotIndex = indicesIndex;

					// Copy polygon indices
					for (uint tri = 0; tri < triCount; tri++) {
						this[thisIndicesIndex++] = buffer[pivotIndex];
						this[thisIndicesIndex++] = buffer[indicesIndex + (tri + 2)];
						this[thisIndicesIndex++] = buffer[indicesIndex + (tri + 1)];
					}

					indicesIndex += polygonVertices;
				} else {
					for (int j = 0; j < polygonVertices; j++, indicesIndex += 1)
						this[thisIndicesIndex++] = buffer[indicesIndex];
				}
			}
		}

		#endregion

		#region ElementBufferObject Overrides

		/// <summary>
		/// Element array buffer object items count.
		/// </summary>
		public override uint ItemCount { get { return (mItemCount); } }

		/// <summary>
		/// Element array buffer object items count.
		/// </summary>
		private uint mItemCount;

		#endregion
	}
}