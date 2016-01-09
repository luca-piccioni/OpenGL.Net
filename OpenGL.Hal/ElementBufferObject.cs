
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

				// Determine ElementsType and default RestartIndexKey
				switch (Type.GetTypeCode(elementType)) {
					case TypeCode.Byte:
						ElementsType = DrawElementsType.UnsignedByte;
						RestartIndexKey = 0x000000FF;
						break;
					case TypeCode.UInt16:
						ElementsType = DrawElementsType.UnsignedShort;
						RestartIndexKey = 0x0000FFFF;
						break;
					case TypeCode.UInt32:
						ElementsType = DrawElementsType.UnsignedInt;
						RestartIndexKey = 0xFFFFFFFF;
						break;
					default:
						throw new ArgumentException("type not supported", "elementType");
				}

				// Store element type
				_RuntimeType = elementType;
				// Determine the element size, in bytes
				ItemSize = (uint)Marshal.SizeOf(elementType);
				// The element type must implement IConvertible
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
		
		#region Primitive Restart
		
		/// <summary>
		/// The restart index enabled.
		/// </summary>
		public bool RestartIndexEnabled;

		/// <summary>
		/// The restart index value (fixed).
		/// </summary>
		public readonly uint RestartIndexKey;

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
	}
}