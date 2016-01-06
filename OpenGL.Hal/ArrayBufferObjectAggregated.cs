
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

namespace OpenGL
{
	/// <summary>
	/// Array buffer object aggregating multiple arrays.
	/// </summary>
	public abstract class ArrayBufferObjectAggregated : ArrayBufferObjectBase
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObjectAggregated.
		/// </summary>
		/// <param name="arrayItemType">
		/// A <see cref="Type"/> describing the type of the array item.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObjectHint"/> that specify the data buffer usage hints.
		/// </param>
		protected ArrayBufferObjectAggregated(Type arrayItemType, BufferObjectHint hint) :
			base(hint)
		{
			try {
				if (arrayItemType == null)
					throw new ArgumentNullException("arrayItemType");
				if (arrayItemType.IsValueType == false)
					throw new ArgumentException("not a value type", "arrayItemType");
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Array section information.
		/// </summary>
		[DebuggerDisplay("ArraySection: Offset={ArrayOffset} Stride={ArrayStride}")]
		protected class ArraySection : ArrayBufferItem, IArraySection
		{
			#region Constructors

			/// <summary>
			/// Construct an SubArrayBuffer from a <see cref="ArrayBufferItemAttribute"/>.
			/// </summary>
			/// <param name="arrayItemType">
			/// A <see cref="Type"/> describing the vertex array buffer item type.
			/// </param>
			public ArraySection(Type arrayItemType) :
				base(GetArrayType(arrayItemType))
			{

			}

			#endregion

			#region Definition

			/// <summary>
			/// Get whether the array elements should be meant normalized (fixed point precision values).
			/// </summary>
			public bool ValueNormalized;

			/// <summary>
			/// The offset for accessing to the array section, in bytes.
			/// </summary>
			public IntPtr ItemOffset;

			/// <summary>
			/// The stride for accessing to the next array section item, in bytes.
			/// </summary>
			public IntPtr ItemStride;

			#endregion

			#region IArraySection Implementation

			/// <summary>
			/// The type of the elements of the array section.
			/// </summary>
			ArrayBufferItemType IArraySection.ItemType { get { return (ArrayType); } }

			/// <summary>
			/// Get whether the array elements should be meant normalized (fixed point precision values).
			/// </summary>
			bool IArraySection.Normalized { get { return (ValueNormalized); } }

			/// <summary>
			/// Offset of the first element of the array section, in bytes.
			/// </summary>
			IntPtr IArraySection.Offset { get { return (ItemOffset); } }

			/// <summary>
			/// Offset between two element of the array section, in bytes.
			/// </summary>
			IntPtr IArraySection.Stride { get { return (ItemStride); } }

			#endregion
		}

		/// <summary>
		/// Array sections compositing this ArrayBufferObjectAggregated.
		/// </summary>
		protected readonly List<ArraySection> ArraySections = new List<ArraySection>();

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal override uint ArraySectionsCount { get { return ((uint)ArraySections.Count); } }

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

			return (ArraySections[(int)index]);
		}

		/// <summary>
		/// Convert the client buffer in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		public override Array ToArray()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
