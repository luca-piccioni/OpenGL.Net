
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

namespace OpenGL
{
	/// <summary>
	/// Array buffer object base class.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class is a <see cref="BufferObject"/> specialized for storing data to be issued to a shader program execution.
	/// </para>
	/// </remarks>
	public abstract class ArrayBufferObjectBase : BufferObject
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
		/// <param name="vertexRank">
		/// A <see cref="UInt32"/> that specify how many columns have the array item of matrix type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		protected ArrayBufferObjectBase(BufferObjectHint hint) :
			base(BufferTargetARB.ArrayBuffer, hint)
		{
			
		}

		#endregion

		#region Array Buffer Information

		/// <summary>
		/// Get the item count allocated for this array buffer object. In the case this ArrayBufferObject
		/// has not been created yet, it returns the size of the client buffer.
		/// </summary>
		public uint ItemCount
		{
			get { return (BufferSize != 0 ? BufferSize / ItemSize : ClientBufferSize / ItemSize); }
		}

		/// <summary>
		/// Get the item count allocated in the client buffer of this buffer object. In the case this ArrayBufferObject
		/// has not been defined yet, it returns 0.
		/// </summary>
		public uint ClientItemCount
		{
			get { return (ClientBufferSize / ItemSize); }
		}

		/// <summary>
		/// Get the size of the item of this array buffer object, in bytes.
		/// </summary>
		public uint ItemSize
		{
			get { return (_ItemSize); }
			protected set
			{
				if (value == 0)
					throw new InvalidOperationException("invalid value");
				_ItemSize = value;
			}
		}

		/// <summary>
		/// Size of the storage of the array buffer object, in basic machine units (bytes).
		/// </summary>
		private uint _ItemSize;

		#endregion

		#region Array Section Interface

		/// <summary>
		/// Interface abstracting an array section.
		/// </summary>
		/// <remarks>
		/// The properties defined in this interface are meant to be used with the actual <see cref="Gl.VertexAttribPointer"/> call.
		/// </remarks>
		protected internal interface IArraySection
		{
			/// <summary>
			/// The type of the elements of the array section.
			/// </summary>
			ArrayBufferItemType ItemType { get; }

			/// <summary>
			/// Get whether the array elements should be meant normalized (fixed point precision values).
			/// </summary>
			bool Normalized { get; }

			/// <summary>
			/// Offset of the first element of the array section, in bytes.
			/// </summary>
			/// <remarks>
			/// It should take into account the client buffer address, if the GL_ARB_vertex_buffer_object extension
			/// is not supported by current implementation.
			/// </remarks>
			IntPtr Offset { get; }

			/// <summary>
			/// Offset between two element of the array section, in bytes.
			/// </summary>
			IntPtr Stride { get; }
		}

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal abstract uint ArraySectionsCount { get; }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="IArraySection"/> defining the array section.
		/// </returns>
		protected internal abstract IArraySection GetArraySection(uint index);

		#endregion

		#region Create

		#region Create(uint itemsCount)

		/// <summary>
		/// Create this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="itemsCount">
		/// A <see cref="UInt32"/> that specify the number of elements hold by this ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// <para>
		/// Previous content of the client buffer is discarded.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="itemsCount"/> is zero.
		/// </exception>
		public virtual void Create(uint itemsCount)
		{
			if (itemsCount == 0)
				throw new ArgumentException("invalid", "itemsCount");

			// Allocate buffer
			AllocateClientBuffer(itemsCount * ItemSize);
		}

		#endregion

		#region Create(GraphicsContext ctx, uint itemsCount)

		/// <summary>
		/// Create this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to define this ArrayBufferObject.
		/// </param>
		/// <param name="itemsCount">
		/// A <see cref="UInt32"/> that specify the number of elements hold by this ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// <para>
		/// Previous content of the client buffer is discarded, if any was defined.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="itemsCount"/> is zero.
		/// </exception>
		public virtual void Create(GraphicsContext ctx, uint itemsCount)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (itemsCount == 0)
				throw new ArgumentException("invalid", "itemsCount");

			// Object already existing: resize client buffer, if any
			if (ClientBufferAddress != IntPtr.Zero)
				AllocateClientBuffer(itemsCount * ItemSize);
			// If not exists, set GPU buffer size; otherwise keep in synch with client buffer size
			ClientBufferSize = itemsCount * ItemSize;
			// Allocate object
			Create(ctx);
		}

		#endregion

		#region Create(Array array, uint offset, uint count)

		/// <summary>
		/// Copy data from any source supported.
		/// </summary>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="offset"/> or <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public virtual void Create(Array array, uint offset, uint count)
		{
			if (count == 0)
				throw new ArgumentException("zero not allowed", "count");

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = CheckArrayItemSize(array);

			// Ensure that ClientBufferSize returns the correct client buffer size
			ClientBufferSize = 0;
			// Memory buffer shall be able to contains all data
			if (ClientBufferSize < ItemSize * count)
				AllocateClientBuffer(ItemSize * count);

			// Copy on buffer
			CopyBuffer(ClientBufferAddress, array, arrayItemSize, offset, count);
		}

		/// <summary>
		/// Copy data from any source supported.
		/// </summary>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public void Create(Array array, uint count)
		{
			Create(array, 0, count);
		}

		/// <summary>
		/// Copy data from any source supported.
		/// </summary>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		public void Create(Array array)
		{
			Create(array, 0, (uint)array.Length);
		}

		#endregion

		#region Create(GraphicsContext ctx, Array array, uint offset, uint count)

		/// <summary>
		/// Copy data from any source supported, uploading data.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for copying data.
		/// </param>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> or <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="offset"/> or <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public virtual void Create(GraphicsContext ctx, Array array, uint offset, uint count)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (count == 0)
				throw new ArgumentException("zero not allowed", "count");

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = CheckArrayItemSize(array);

			// Ensure enought buffer
			Create(ctx, count);
			// Copy data mapping GPU buffer
			Map(ctx, BufferAccessARB.WriteOnly);
			try {
				// Copy on buffer
				CopyBuffer(MappedBuffer, array, arrayItemSize, offset, count);
			} finally {
				Unmap(ctx);
			}
		}

		/// <summary>
		/// Copy data from any source supported, uploading data.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for copying data.
		/// </param>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> or <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public void Create(GraphicsContext ctx, Array array, uint count)
		{
			Create(ctx, array, 0, count);
		}

		/// <summary>
		/// Copy data from any source supported, uploading data.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for copying data.
		/// </param>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> or <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBufferObject"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		public void Create(GraphicsContext ctx, Array array)
		{
			Create(ctx, array, 0, (uint)array.Length);
		}

		#endregion

		/// <summary>
		/// Copy an <see cref="Array"/> to a buffer.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="IntPtr"/> that specify the buffer address.
		/// </param>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="arrayItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="array"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBufferObject"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		protected virtual void CopyBuffer(IntPtr buffer, Array array, uint arrayItemSize, uint offset, uint count)
		{
			CopyArray(buffer, ItemSize, array, arrayItemSize, offset, count);
		}

		/// <summary>
		/// Safety checks on input array instance.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Array"/> to be checked for validity and compatibility with this ArrayBufferObjectBase instance.
		/// </param>
		/// <returns>
		/// It returns the size of the element of <paramref name="array"/>, in bytes.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="array"/> has a rank greater than 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="array"/> element type is not a value type.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="array"/> element type size is greater than <see cref="ItemSize"/>.
		/// </exception>
		private uint CheckArrayItemSize(Array array)
		{
			if (array == null)
				throw new ArgumentNullException("array");
			if (array.Rank != 1)
				throw new ArgumentException(String.Format("copying from array of rank {0} not supported", array.Rank));

			Type arrayElementType = array.GetType().GetElementType();
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new ArgumentException("invalid array element type", "array");

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = (uint)Marshal.SizeOf(arrayElementType);
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", "array");

			return (arrayItemSize);
		}

		#endregion

		#region Copy Array

		/// <summary>
		/// Copy to pinned memory the items defined by an array, item by item, respecting item strides and offsets.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="IntPtr"/> that specify the destination memory address.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="Array"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="src"/> must be copied.
		/// </param>
		protected static void CopyArray(
			IntPtr dst, uint dstItemSize,
			Array src, uint srcItemSize,
			uint srcIndex, uint srcCount)
		{
			CopyArray(dst, IntPtr.Zero, IntPtr.Zero, dstItemSize, src, IntPtr.Zero, IntPtr.Zero, srcItemSize, srcIndex, srcCount);
		}

		/// <summary>
		/// Copy to pinned memory the items defined by an array, item by item, respecting item strides and offsets.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="IntPtr"/> that specify the destination memory address.
		/// </param>
		/// <param name="dstStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the destination memory.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="Array"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="src"/> must be copied.
		/// </param>
		protected static void CopyArray(
			IntPtr dst, IntPtr dstStride, uint dstItemSize,
			Array src, IntPtr srcStride, uint srcItemSize,
			uint srcIndex, uint srcCount)
		{
			CopyArray(dst, IntPtr.Zero, dstStride, dstItemSize, src, IntPtr.Zero, srcStride, srcItemSize, srcIndex, srcCount);
		}

		/// <summary>
		/// Copy to pinned memory the items defined by an array, item by item, respecting item strides and offsets.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="IntPtr"/> that specify the destination memory address.
		/// </param>
		/// <param name="dstOffset">
		/// A <see cref="IntPtr"/> that specify the offset of the actual destination memory address respect <paramref name="dst"/>, in bytes.
		/// </param>
		/// <param name="dstStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the destination memory.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="Array"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcOffset">
		/// A <see cref="IntPtr"/> that specify the offset of the actual source memory address respect <paramref name="src"/>, in bytes.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="src"/> must be copied.
		/// </param>
		protected static void CopyArray(
			IntPtr dst, IntPtr dstOffset, IntPtr dstStride, uint dstItemSize,
			Array src, IntPtr srcOffset, IntPtr srcStride, uint srcItemSize,
			uint srcIndex, uint srcCount)
		{
			if (dst == IntPtr.Zero)
				throw new ArgumentException("invalid pointer", "dst");
			if (src == null)
				throw new ArgumentNullException("src");
			if (srcItemSize > dstItemSize)
				throw new ArgumentException("too large", "srcItemSize");
			if (src.Length < srcCount)
				throw new ArgumentException("exceed array length", "srcCount");
			if (src.Length < srcIndex + srcCount)
				throw new ArgumentException("exceed array length", "srcOffset");

			if (srcStride == IntPtr.Zero)
				srcStride = new IntPtr(srcItemSize);
			if (dstStride == IntPtr.Zero)
				dstStride = new IntPtr(dstItemSize);

			GCHandle arrayHandle = GCHandle.Alloc(src, GCHandleType.Pinned);
			try {
				unsafe
				{
					byte* arrayPtr = (byte*)arrayHandle.AddrOfPinnedObject().ToPointer();
					byte* dstPtr = (byte*)dst.ToPointer();

					// Consider source offset
					arrayPtr += srcOffset.ToInt64();
					// Take into account source index
					arrayPtr += srcItemSize * srcIndex;

					// Consider destination offset
					dstPtr += dstOffset.ToInt64();

					if ((srcItemSize != dstItemSize) || (srcStride != new IntPtr(srcItemSize)) || (dstStride != new IntPtr(dstItemSize))) {

						// The copy element-by-element is performed is one or more of the following conditions is true:
						// - The src/dst item sizes doesn't match
						// - The src/dst stride doesn't match with the respective item sizes

						for (uint i = 0; i < srcCount; i++, arrayPtr += srcStride.ToInt64(), dstPtr += dstStride.ToInt64())
							Memory.MemoryCopy(dstPtr, arrayPtr, srcItemSize);
					} else {
						Memory.MemoryCopy(dstPtr, arrayPtr, srcItemSize * srcCount);
					}
				}
			} finally {
				arrayHandle.Free();
			}
		}

		/// <summary>
		/// Copy from pinned memory the items defined by an array, item by item, respecting item strides.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="Array"/> that specify the destination memory where copy to.
		/// </param>
		/// <param name="dstStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the destination memory.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="IntPtr"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="dst"/> must be copied.
		/// </param>
		protected static void CopyArray(
			Array dst, uint dstItemSize,
			IntPtr src, uint srcItemSize,
			uint dstIndex, uint dstCount)
		{
			CopyArray(dst, IntPtr.Zero, IntPtr.Zero, dstItemSize, src, IntPtr.Zero, IntPtr.Zero, srcItemSize, dstIndex, dstCount);
		}

		/// <summary>
		/// Copy from pinned memory the items defined by an array, item by item, respecting item strides.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="Array"/> that specify the destination memory where copy to.
		/// </param>
		/// <param name="dstStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the destination memory.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="IntPtr"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="dst"/> must be copied.
		/// </param>
		protected static void CopyArray(
			Array dst, IntPtr dstStride, uint dstItemSize,
			IntPtr src, IntPtr srcStride, uint srcItemSize,
			uint dstIndex, uint dstCount)
		{
			CopyArray(dst, IntPtr.Zero, dstStride, dstItemSize, src, IntPtr.Zero, srcStride, srcItemSize, dstIndex, dstCount);
		}

		/// <summary>
		/// Copy from pinned memory the items defined by an array, item by item, respecting item strides.
		/// </summary>
		/// <param name="dst">
		/// The <see cref="Array"/> that specify the destination memory where copy to.
		/// </param>
		/// <param name="dstStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the destination memory.
		/// </param>
		/// <param name="dstItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="IntPtr"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcOffset">
		/// A <see cref="IntPtr"/> that specify the offset of the actual source memory address respect <paramref name="src"/>, in bytes.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="UInt32"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="UInt32"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="UInt32"/> that specify the number of elements of <paramref name="dst"/> must be copied.
		/// </param>
		protected static void CopyArray(
			Array dst, IntPtr dstOffset, IntPtr dstStride, uint dstItemSize,
			IntPtr src, IntPtr srcOffset, IntPtr srcStride, uint srcItemSize,
			uint dstIndex, uint dstCount)
		{
			if (dst == null)
				throw new ArgumentNullException("dst");
			if (src == IntPtr.Zero)
				throw new ArgumentException("invalid pointer", "src");
			if (srcItemSize > dstItemSize)
				throw new ArgumentException("too large", "dstItemSize");
			if (dst.Length < dstCount)
				throw new ArgumentException("exceed array length", "dstCount");
			if (dst.Length < dstIndex + dstCount)
				throw new ArgumentException("exceed array length", "dstOffset");

			if (srcStride == IntPtr.Zero)
				srcStride = new IntPtr(srcItemSize);
			if (dstStride == IntPtr.Zero)
				dstStride = new IntPtr(dstItemSize);

			GCHandle arrayHandle = GCHandle.Alloc(dst, GCHandleType.Pinned);
			try {
				unsafe
				{
					byte* arrayPtr = (byte*)arrayHandle.AddrOfPinnedObject().ToPointer();
					byte* srcPtr = (byte*)src.ToPointer();

					// Take into account destination offset
					arrayPtr += dstItemSize * dstIndex;

					// Consider source offset
					arrayPtr += dstOffset.ToInt64();
					// Take into account source index
					arrayPtr += dstItemSize * dstIndex;

					// Consider destination offset
					srcPtr += srcOffset.ToInt64();

					if ((srcItemSize != dstItemSize) || (srcStride != new IntPtr(srcItemSize)) || (dstStride != new IntPtr(dstItemSize))) {
						// Respect this ArrayBufferObject item stride
						for (uint i = 0; i < dstCount; i++, arrayPtr += dstStride.ToInt64(), srcPtr += srcStride.ToInt64())
							Memory.MemoryCopy(arrayPtr, srcPtr, dstItemSize);
					} else {
						Memory.MemoryCopy(arrayPtr, srcPtr, dstItemSize * dstCount);
					}
				}
			} finally {
				arrayHandle.Free();
			}
		}

		#endregion

		#region To Array

		/// <summary>
		/// Convert the client buffer in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		public abstract Array ToArray();

		#endregion

		#region BufferObject Overrides

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns a boolean value indicating whether this GraphicsResource implementation requires a name
		/// generation on creation. In the case this routine returns true, the routine <see cref="CreateName"/>
		/// will be called (and it must be overriden). In  the case this routine returns false, the routine
		/// <see cref="CreateName"/> won't be called (and indeed it is not necessary to override it) and a
		/// name is generated automatically in a context-independent manner.
		/// </para>
		/// <para>
		/// This implementation check the GL_ARB_vertex_array_object extension availability.
		/// </para>
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (ctx.Caps.GlExtensions.VertexBufferObject_ARB);
		}

		#endregion
	}
}
