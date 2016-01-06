
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
	public class ElementBufferObject : ArrayBufferObjectBase
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBufferObject(Type elementType, BufferObjectHint hint)
			: base(BufferTargetARB.ElementArrayBuffer, hint)
		{
			try {
				if (elementType == null)
					throw new ArgumentNullException("elementType");

				// Determine array item size
				switch (Type.GetTypeCode(elementType)) {
					case TypeCode.Byte:
						ElementsType = DrawElementsType.UnsignedByte;
						break;
					case TypeCode.UInt16:
						ElementsType = DrawElementsType.UnsignedShort;
						break;
					case TypeCode.UInt32:
						ElementsType = DrawElementsType.UnsignedInt;
						break;
					default:
						throw new ArgumentException("not supported type", "element type");
				}

				_RuntimeType = elementType;
				ItemSize = (uint)Marshal.SizeOf(elementType);

				Debug.Assert(_RuntimeType.GetInterface("IConvertible") != null);
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Elements Type

		/// <summary>
		/// The <see cref="Type"/> that corresponds to <see cref="ElementsType"/>.
		/// </summary>
		private readonly Type _RuntimeType;

		/// <summary>
		/// The type of the array elements.
		/// </summary>
		internal readonly DrawElementsType ElementsType;

		/// <summary>
		/// Get the <see cref="ArrayBufferItemType"/> corresponding to <see cref="ElementsType"/>.
		/// </summary>
		private ArrayBufferItemType ArrayType
		{
			get
			{
				switch (ElementsType) {
					case DrawElementsType.UnsignedByte:
						return (ArrayBufferItemType.UByte);
					case DrawElementsType.UnsignedShort:
						return (ArrayBufferItemType.UShort);
					case DrawElementsType.UnsignedInt:
						return (ArrayBufferItemType.UInt);
					default:
						throw new NotSupportedException();
				}
			}
		}

		#endregion

		#region Element Buffer Access

		/// <summary>
		/// Get or set the item stored in the client buffer of this ElementBufferObject.
		/// </summary>
		/// <param name="index">
		/// A <see cref="UInt32"/> that specify the item index.
		/// </param>
		public uint this[uint index]
		{
			get
			{
				IntPtr clientBufferAddress = ClientBufferAddress;

				if (clientBufferAddress == IntPtr.Zero)
					throw new InvalidOperationException("no client buffer");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				IConvertible value = (IConvertible)Marshal.PtrToStructure(new IntPtr(clientBufferAddress.ToInt64() + (index * ItemSize)), _RuntimeType);

				return (value.ToUInt32(NumberFormatInfo.InvariantInfo));
			}
			set
			{
				IntPtr clientBufferAddress = ClientBufferAddress;

				if (clientBufferAddress == IntPtr.Zero)
					throw new InvalidOperationException("no client buffer");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				object convertedValue;

				switch (ElementsType) {
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
						throw new InvalidOperationException("invalid item type " + ElementsType);
				}

				Marshal.StructureToPtr(convertedValue, new IntPtr(clientBufferAddress.ToInt64() + (index * ItemSize)), false);
			}
		}

		#endregion
		
		#region Primitive Restart
		
		/// <summary>
		/// The restart index enabled.
		/// </summary>
		public bool RestartIndexEnabled;

		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override uint ArraySectionsCount { get { throw new NotImplementedException(); } }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="IArraySection"/> defining the array section.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override IArraySection GetArraySection(uint index) { throw new NotImplementedException(); }

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
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBufferObject(BufferObjectHint hint) :
			base(typeof(T), hint)
		{
			
		}

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

			Create(totalVerticesCount);

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
	}
}