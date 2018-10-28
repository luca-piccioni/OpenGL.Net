
// Copyright (C) 2009-2017 Luca Piccioni
// 
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
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	/// <summary>
	/// Array buffer object base class. This class is a <see cref="Buffer"/> specialized for storing data to be issued to a shader program execution.
	/// </summary>
	/// <remarks>
	/// Implements array buffer, indeed a an array of elements. Implements:
	/// - Buffer description: element size and count
	/// - Element access (getter and setter)
	/// - Creation (CPU, empty, CPU array, GPU empty, GPU array)
	/// - Copy-write (CPU array)
	/// - Copy-read (CPU array)
	/// </remarks>
	public abstract class ArrayBufferBase : Buffer
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObjectBase.
		/// </summary>
		/// <param name="bufferTarget">
		/// A <see cref="BufferTarget"/> that specifies the buffer target.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		protected ArrayBufferBase(BufferTarget bufferTarget, BufferUsage hint) :
			base(bufferTarget, hint)
		{

		}

		/// <summary>
		/// Construct an ArrayBufferObjectBase.
		/// </summary>
		/// <param name="bufferTarget">
		/// A <see cref="BufferTarget"/> that specify the buffer target.
		/// </param>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		protected ArrayBufferBase(BufferTarget bufferTarget, MapBufferUsageMask usageMask) :
			base(bufferTarget, usageMask)
		{

		}

		#endregion

		#region Item Size

		/// <summary>
		/// Get the size of the item of this array buffer object, in bytes.
		/// </summary>
		public uint ItemSize
		{
			get { return _ItemSize; }
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

		#region Items Count

		/// <summary>
		/// Get the GPU items count, if this ArrayBufferBase is created; otherwise it returns the
		/// CPU items count.
		/// </summary>
		public uint ItemsCount
		{
			get {
				uint gpuItemsCount = GpuItemsCount;

				if (gpuItemsCount > 0)
					return gpuItemsCount;

				return CpuItemsCount;
			}
		}

		/// <summary>
		/// Get the item count allocated for this array buffer object. In the case this ArrayBufferObject
		/// has not been created yet, it returns the size of the client buffer.
		/// </summary>
		public uint GpuItemsCount
		{
			get { return GpuBufferSize / ItemSize; }
		}

		/// <summary>
		/// Get the item count allocated in the client buffer of this buffer object. In the case this ArrayBufferObject
		/// has not been defined yet, or the client buffer has been disposed due the context creation, it returns 0.
		/// </summary>
		public uint CpuItemsCount
		{
			get { return CpuBufferSize / ItemSize; }
		}

		#endregion

		#region Element Access

		/// <summary>
		/// Set an element to this mapped ArrayBufferObjectBase.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this ArrayBufferObjectBase element.
		/// </typeparam>
		/// <param name="value">
		/// A <typeparamref name="T"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="index">
		/// A <see cref="uint"/> that specify the index of the element to set.
		/// </param>
		/// <param name="sectionIndex">
		/// A <see cref="uint"/> that specifies the array section index for supporting packed/interleaved arrays.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="IsMapped"/>).
		/// </exception>
		public void SetElement<T>(T value, uint index, uint sectionIndex) where T : struct
		{
			IArraySection arraySection = GetArraySection(sectionIndex);
			uint stride = arraySection.Stride != IntPtr.Zero ? (uint)arraySection.Stride.ToInt32() : ItemSize;
			ulong itemOffset = (ulong)arraySection.Offset.ToInt64() + stride * index;

			Set(value, itemOffset);
		}

		/// <summary>
		/// Get an element from this mapped BufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// A structure representing this BufferObject element.
		/// </typeparam>
		/// <param name="index">
		/// A <see cref="uint"/> that specify the index of the element to get.
		/// </param>
		/// <param name="sectionIndex">
		/// A <see cref="uint"/> that specifies the array section index for supporting packed/interleaved arrays.
		/// </param>
		/// <returns>
		/// It returns a structure of type <typeparamref name="T"/>, read from the mapped BufferObject
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is not mapped (<see cref="Buffer.IsMapped"/>).
		/// </exception>
		public T GetElement<T>(uint index, uint sectionIndex) where T : struct
		{
			IArraySection arraySection = GetArraySection(sectionIndex);
			uint stride = arraySection.Stride != IntPtr.Zero ? (uint)arraySection.Stride.ToInt32() : ItemSize;
			ulong itemOffset = (ulong)arraySection.Offset.ToInt64() + stride * index;

			return Get<T>(itemOffset);
		}

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
			/// Get the actual array buffer pointer. It could be <see cref="IntPtr.Zero"/> indicating an actual GPU
			/// buffer reference.
			/// </summary>
			IntPtr Pointer { get; }

			/// <summary>
			/// Offset of the first element of the array section, in bytes.
			/// </summary>
			/// <remarks>
			/// It should NOT take into account the client buffer address, even if the GL_ARB_vertex_buffer_object extension
			/// is not supported by current implementation. It indicates an actual offset, in bytes.
			/// </remarks>
			IntPtr Offset { get; }

			/// <summary>
			/// Offset between two element of the array section, in bytes. If it is <see cref="IntPtr.Zero"/> it means that
			/// items are tighly packed.
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
		/// The <see cref="uint"/> that specify the array section index.
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
		/// A <see cref="uint"/> that specify the number of elements hold by this ArrayBufferObject.
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
				throw new ArgumentException("invalid", nameof(itemsCount));

			// Allocate buffer
			CreateCpuBuffer(itemsCount * ItemSize);
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
		/// A <see cref="uint"/> that specify the number of elements hold by this ArrayBufferObject.
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
			CheckCurrentContext(ctx);

			if (itemsCount == 0)
				throw new ArgumentException("invalid", nameof(itemsCount));

			// Object already existing: resize client buffer, if any
			if (CpuBufferAddress != IntPtr.Zero)
				CreateCpuBuffer(itemsCount * ItemSize);
			// If not exists, set GPU buffer size; otherwise keep in synch with client buffer size
			CpuBufferSize = itemsCount * ItemSize;
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
		/// A <see cref="uint"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
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
				throw new ArgumentException("zero not allowed", nameof(count));

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = CheckArrayItemSize(array);

			// Ensure that ClientBufferSize returns the correct client buffer size
			CpuBufferSize = 0;
			// Memory buffer shall be able to contains all data
			if (CpuBufferSize < ItemSize * count)
				CreateCpuBuffer(ItemSize * count);

			// Copy on buffer
			CopyBuffer(CpuBufferAddress, array, arrayItemSize, offset, count);
		}

		/// <summary>
		/// Copy data from any source supported.
		/// </summary>
		/// <param name="array">
		/// The source array where the data comes from.
		/// </param>
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
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
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the rank of <paramref name="array"/> is different from 1.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if it is not possible to determine the element type of the array <paramref name="array"/>, or if the base type of
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
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
		/// A <see cref="uint"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the size of the elements of <paramref name="array"/> is larger than <see cref="ItemSize"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="offset"/> or <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public virtual void Create(GraphicsContext ctx, Array array, uint offset, uint count)
		{
			CheckCurrentContext(ctx);

			if (count == 0)
				throw new ArgumentException("zero not allowed", nameof(count));

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = CheckArrayItemSize(array);

			// Ensure enought buffer
			Create(ctx, count);
			// Copy data mapping GPU buffer
			Map(ctx, BufferAccess.WriteOnly);
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
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
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
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="array"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="uint"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
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
				throw new ArgumentNullException(nameof(array));
			if (array.Rank != 1)
				throw new ArgumentException($"copying from array of rank {array.Rank} not supported");

			Type arrayElementType = array.GetType().GetElementType();
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new ArgumentException("invalid array element type", nameof(array));

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = (uint)Marshal.SizeOf(arrayElementType);
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", nameof(array));

			return arrayItemSize;
		}

		#endregion

		#region Update

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
		/// A <see cref="uint"/> that specify the first element to be copied.
		/// </param>
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
		/// </exception>
		public virtual void Update(GraphicsContext ctx, Array array, uint offset, uint count)
		{
			CheckThisExistence(ctx);

			if (count == 0)
				throw new ArgumentException("zero not allowed", nameof(count));
			if (IsMapped)
				throw new InvalidOperationException("mapped");

			// Check whether this GPU buffer overflow that required array
			uint arrayItemSize = CheckArrayItemSize(array);

			// Buffer  must be bound
			ctx.Bind(this);

			if (arrayItemSize * count > GpuBufferSize)
				CreateGpuBuffer(ctx, arrayItemSize * count, IntPtr.Zero);

			// Copy data mapping GPU buffer
			Map(ctx, BufferAccess.WriteOnly);
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
		/// <param name="count">
		/// A <see cref="uint"/> that specify the number of items to copy. The items to copy are referred in terms
		/// of the data layout of this <see cref="ArrayBuffer"/>, not of the element type of <paramref name="array"/>!
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
		/// </exception>
		public void Update(GraphicsContext ctx, Array array, uint count)
		{
			Update(ctx, array, 0, count);
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
		/// the array elements is not compatible with the base type of this <see cref="ArrayBuffer"/>.
		/// </exception>
		public void Update(GraphicsContext ctx, Array array)
		{
			Update(ctx, array, 0, (uint)array.Length);
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
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="Array"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="src"/> must be copied.
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
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="Array"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="src"/> must be copied.
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
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
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
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="src"/>.
		/// </param>
		/// <param name="srcIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="srcCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="src"/> must be copied.
		/// </param>
		protected static void CopyArray(
			IntPtr dst, IntPtr dstOffset, IntPtr dstStride, uint dstItemSize,
			Array src, IntPtr srcOffset, IntPtr srcStride, uint srcItemSize,
			uint srcIndex, uint srcCount)
		{
			if (dst == IntPtr.Zero)
				throw new ArgumentException("invalid pointer", nameof(dst));
			if (src == null)
				throw new ArgumentNullException(nameof(src));
			if (srcItemSize > dstItemSize)
				throw new ArgumentException("too large", nameof(srcItemSize));
			if (src.Length < srcCount)
				throw new ArgumentException("exceed array length", nameof(srcCount));
			if (src.Length < srcIndex + srcCount)
				throw new ArgumentException("exceed array length", nameof(srcOffset));

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

					if (srcItemSize != dstItemSize || srcStride != new IntPtr(srcItemSize) || dstStride != new IntPtr(dstItemSize)) {

						// The copy element-by-element is performed is one or more of the following conditions is true:
						// - The src/dst item sizes doesn't match
						// - The src/dst stride doesn't match with the respective item sizes

						for (uint i = 0; i < srcCount; i++, arrayPtr += srcStride.ToInt64(), dstPtr += dstStride.ToInt64())
							Memory.Copy(dstPtr, arrayPtr, srcItemSize);
					} else {
						Memory.Copy(dstPtr, arrayPtr, srcItemSize * srcCount);
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
		/// <param name="dstItemSize">
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="IntPtr"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="dst"/> must be copied.
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
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
		/// </param>
		/// <param name="src">
		/// The <see cref="IntPtr"/> that specify the source data to be copied.
		/// </param>
		/// <param name="srcStride">
		/// A <see cref="IntPtr"/> that specify the number of bytes between two consecutive elements in the source memory.
		/// </param>
		/// <param name="srcItemSize">
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="dst"/> must be copied.
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
		/// A <see cref="uint"/> that specify the size of the elements in the destination memory.
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
		/// A <see cref="uint"/> that specify the size of the elements of <paramref name="dst"/>.
		/// </param>
		/// <param name="dstIndex">
		/// A <see cref="uint"/> that specify the array offset (in elements) where the copy starts.
		/// </param>
		/// <param name="dstCount">
		/// A <see cref="uint"/> that specify the number of elements of <paramref name="dst"/> must be copied.
		/// </param>
		protected static void CopyArray(
			Array dst, IntPtr dstOffset, IntPtr dstStride, uint dstItemSize,
			IntPtr src, IntPtr srcOffset, IntPtr srcStride, uint srcItemSize,
			uint dstIndex, uint dstCount)
		{
			if (dst == null)
				throw new ArgumentNullException(nameof(dst));
			if (src == IntPtr.Zero)
				throw new ArgumentException("invalid pointer", nameof(src));
			if (srcItemSize > dstItemSize)
				throw new ArgumentException("too large", nameof(dstItemSize));
			if (dst.Length < dstCount)
				throw new ArgumentException("exceed array length", nameof(dstCount));
			if (dst.Length < dstIndex + dstCount)
				throw new ArgumentException("exceed array length", nameof(dstOffset));

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

					if (srcItemSize != dstItemSize || srcStride != new IntPtr(srcItemSize) || dstStride != new IntPtr(dstItemSize)) {
						// Respect this ArrayBufferObject item stride
						for (uint i = 0; i < dstCount; i++, arrayPtr += dstStride.ToInt64(), srcPtr += srcStride.ToInt64())
							Memory.Copy(arrayPtr, srcPtr, dstItemSize);
					} else {
						Memory.Copy(arrayPtr, srcPtr, dstItemSize * dstCount);
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
		public abstract Array ToArray(GraphicsContext ctx);

		/// <summary>
		/// Create a strongly typed array following <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="itemCount">
		/// A <see cref="uint"/> that specify the length of the array returned.
		/// </param>
		/// <returns>
		/// It returns an uninitialized array, strongly typed depending on <see cref="ArrayBufferItemType"/>, with
		/// the length equals to <paramref name="itemCount"/>.
		/// </returns>
		protected Array CreateArray(ArrayBufferItemType arrayBufferItemType, uint itemCount)
		{
			switch (arrayBufferItemType) {

				case ArrayBufferItemType.Byte:
					return new sbyte[itemCount];
				case ArrayBufferItemType.Byte2:
					return new Vertex2b[itemCount];
				case ArrayBufferItemType.Byte3:
					return new Vertex3b[itemCount];
				case ArrayBufferItemType.Byte4:
					return new Vertex4b[itemCount];

				case ArrayBufferItemType.UByte:
					return new byte[itemCount];
				case ArrayBufferItemType.UByte2:
					return new Vertex2ub[itemCount];
				case ArrayBufferItemType.UByte3:
					return new Vertex3ub[itemCount];
				case ArrayBufferItemType.UByte4:
					return new Vertex4ub[itemCount];

				case ArrayBufferItemType.Short:
					return new short[itemCount];
				case ArrayBufferItemType.Short2:
					return new Vertex2s[itemCount];
				case ArrayBufferItemType.Short3:
					return new Vertex3s[itemCount];
				case ArrayBufferItemType.Short4:
					return new Vertex4s[itemCount];

				case ArrayBufferItemType.UShort:
					return new ushort[itemCount];
				case ArrayBufferItemType.UShort2:
					return new Vertex2us[itemCount];
				case ArrayBufferItemType.UShort3:
					return new Vertex3us[itemCount];
				case ArrayBufferItemType.UShort4:
					return new Vertex4us[itemCount];

				case ArrayBufferItemType.Int:
					return new int[itemCount];
				case ArrayBufferItemType.Int2:
					return new Vertex2i[itemCount];
				case ArrayBufferItemType.Int3:
					return new Vertex3i[itemCount];
				case ArrayBufferItemType.Int4:
					return new Vertex4i[itemCount];

				case ArrayBufferItemType.UInt:
					return new uint[itemCount];
				case ArrayBufferItemType.UInt2:
					return new Vertex2ui[itemCount];
				case ArrayBufferItemType.UInt3:
					return new Vertex3ui[itemCount];
				case ArrayBufferItemType.UInt4:
					return new Vertex4ui[itemCount];

				case ArrayBufferItemType.Float:
					return new float[itemCount];
				case ArrayBufferItemType.Float2:
					return new Vertex2f[itemCount];
				case ArrayBufferItemType.Float3:
					return new Vertex3f[itemCount];
				case ArrayBufferItemType.Float4:
					return new Vertex4f[itemCount];

				case ArrayBufferItemType.Double:
					return new double[itemCount];
				case ArrayBufferItemType.Double2:
					return new Vertex2d[itemCount];
				case ArrayBufferItemType.Double3:
					return new Vertex3d[itemCount];
				case ArrayBufferItemType.Double4:
					return new Vertex4d[itemCount];

				case ArrayBufferItemType.Half:
					return new HalfFloat[itemCount];
				case ArrayBufferItemType.Half2:
					return new Vertex2hf[itemCount];
				case ArrayBufferItemType.Half3:
					return new Vertex3hf[itemCount];
				case ArrayBufferItemType.Half4:
					return new Vertex4hf[itemCount];

				default:
					throw new NotImplementedException($"array type {arrayBufferItemType} not yet implemented");
			}
		}

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
			CheckValidContext(ctx);

			return ctx.Extensions.VertexBufferObject_ARB;
		}

		#endregion
	}
}
