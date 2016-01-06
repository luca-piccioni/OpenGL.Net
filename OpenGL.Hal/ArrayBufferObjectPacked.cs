
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
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Array buffer object aggregating multiple arrays.
	/// </summary>
	public class ArrayBufferObjectPacked : ArrayBufferObjectAggregated
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObjectInterleaved specifying its item layout on CPU side.
		/// </summary>
		/// <param name="arrayItemType">
		/// A <see cref="Type"/> describing the type of the array item.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObjectPacked(Type arrayItemType, BufferObjectHint hint) :
			base(arrayItemType, hint)
		{
			// Get fields for defining array item definition
			FieldInfo[] arrayItemTypeFields = arrayItemType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			if (arrayItemTypeFields.Length == 0)
				throw new ArgumentException("no public fields", "arrayItemType");

			// Allocate type information arrays
			_FieldsSize = new uint[arrayItemTypeFields.Length];
			_FieldsOffset = new IntPtr[arrayItemTypeFields.Length];
			_ClientBufferOffsets = new IntPtr[arrayItemTypeFields.Length];
			_BufferOffsets = new IntPtr[arrayItemTypeFields.Length];

			// Determine array sections stride
			int structStride = Marshal.SizeOf(arrayItemType);

			for (int i = 0; i < arrayItemTypeFields.Length; i++) {
				FieldInfo arrayItemTypeField = arrayItemTypeFields[i];
				ArraySection arraySection = new ArraySection(arrayItemTypeField.FieldType);

				// Store field size: used for re-computing section offsets
				_FieldsSize[i] = (uint)Marshal.SizeOf(arrayItemTypeField.FieldType);
				// Store field offset: used for locating field in input arrays
				_FieldsOffset[i] = Marshal.OffsetOf(arrayItemType, arrayItemTypeField.Name);

				// Array section offset is re-computed each time the item count is defined
				arraySection.ItemOffset = IntPtr.Zero;
				// Determine array section stride
				arraySection.ItemStride = new IntPtr(_FieldsSize[i]);
				// Mission Normalized property management: add attributes?
				arraySection.Normalized = false;

				ArraySections.Add(arraySection);
			}

			// Determine array item size
			ItemSize = (uint)structStride;
		}

		#endregion

		#region Fields Information

		/// <summary>
		/// Fields size, in bytes.
		/// </summary>
		private readonly uint[] _FieldsSize;

		/// <summary>
		/// Fields size, in bytes.
		/// </summary>
		private readonly IntPtr[] _FieldsOffset;

		/// <summary>
		/// Offset of the array section, if they are referred to the client buffer.
		/// </summary>
		private readonly IntPtr[] _ClientBufferOffsets;

		/// <summary>
		/// Offset of the array section, if they are referred to the GPU buffer.
		/// </summary>
		private readonly IntPtr[] _BufferOffsets;

		#endregion

		#region ArrayBufferObjectAggregated Overrides

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
		public override void Create(uint itemsCount)
		{
			// Base implementation
			base.Create(itemsCount);
			// Reset array section offsets
			ResetArraySectionOffsets(_ClientBufferOffsets, itemsCount);
		}

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
		public override void Create(GraphicsContext ctx, uint itemsCount)
		{
			// Base implementation
			base.Create(ctx, itemsCount);
			// Reset array section offsets

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
		/// Exception thrown if <paramref name="offset"/> or <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public override void Create(Array array, uint offset, uint count)
		{
			// Base implementation
			base.Create(array, offset, count);
			// Reset array section offsets
			ResetArraySectionOffsets(_ClientBufferOffsets, count);
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
		/// Exception thrown if <paramref name="offset"/> or <paramref name="count"/> let exceed the array boundaries.
		/// </exception>
		public override void Create(GraphicsContext ctx, Array array, uint offset, uint count)
		{
			// Base implementation
			base.Create(ctx, array, offset, count);
			// Reset array section offsets

		}

		/// <summary>
		/// Create this PackedArrayBufferObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object. The object space of this <see cref="GraphicsContext"/> is used
		/// to generate <see cref="ObjectName"/>, and all contextes sharing lists with this parameter can handle this IGraphicsResource.
		/// The <see cref="GraphicsContext"/> shall be current to the calling thread.
		/// </param>
		/// <seealso cref="Delete"/>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the object has been already created.
		/// </exception>
		public override void Create(GraphicsContext ctx)
		{
			// Base implementation
			base.Create(ctx);

		}

		private void ResetArraySectionOffsets(IntPtr[] offsets, uint itemsCount)
		{
			Debug.Assert(offsets != null);
			Debug.Assert(offsets.Length == _FieldsSize.Length);

			uint fieldOffset = 0;

			for (int i = 0; i < offsets.Length; i++) {
				offsets[i] = new IntPtr(fieldOffset);
				fieldOffset += itemsCount * _FieldsSize[i];
			}
		}

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
		protected override void CopyBuffer(IntPtr buffer, Array array, uint arrayItemSize, uint offset, uint count)
		{
			
		}

		#endregion
	}

	/// <summary>
	/// Array buffer object aggregating multiple arrays.
	/// </summary>
	public class PackedArrayBufferObject<T> : ArrayBufferObjectPacked
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObjectInterleaved.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		public PackedArrayBufferObject(BufferObjectHint hint) :
			base(typeof(T), hint)
		{

		}

		#endregion
	}
}
