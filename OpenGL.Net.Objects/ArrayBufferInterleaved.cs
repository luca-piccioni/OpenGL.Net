
// Copyright (C) 2017 Luca Piccioni
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
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	public class ArrayBufferObjectInterleaved<T> : ArrayBufferBase where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObjectInterleaved specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObjectInterleaved(BufferUsage hint) :
			base(hint)
		{
			try {
				// Determine array item size
				ItemSize = (uint)Marshal.SizeOf(typeof(T));
				// Detect interleaved fields using reflection (cached)
				List<InterleavedSectionBase> typeSections = ScanTypeSections();
				// Get array sections for this instance
				_InterleavedSections = typeSections.ConvertAll(delegate (InterleavedSectionBase item) {
					return (new InterleavedSection(this, item));
				});
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct an ArrayBufferObjectInterleaved specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBufferObjectInterleaved(MapBufferUsageMask usageMask) :
			base(usageMask)
		{
			try {
				// Determine array item size
				ItemSize = (uint)Marshal.SizeOf(typeof(T));
				// Detect interleaved fields using reflection (cached)
				List<InterleavedSectionBase> typeSections = ScanTypeSections();
				// Get array sections for this instance
				_InterleavedSections = typeSections.ConvertAll(delegate (InterleavedSectionBase item) {
					return (new InterleavedSection(this, item));
				});
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		private static List<InterleavedSectionBase> ScanTypeSections()
		{
			List<InterleavedSectionBase> typeSections;

			// Determine array item size
			uint itemSize = (uint)Marshal.SizeOf(typeof(T));

			if (_TypeSections.TryGetValue(typeof(T), out typeSections) == false) {
				// Cache for type
				typeSections = new List<InterleavedSectionBase>();

				foreach (FieldInfo field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) {
					InterleavedSectionBase structSection = new InterleavedSectionBase();
					
					structSection.ItemType = ArrayBufferItem.GetArrayType(field.FieldType);
					structSection.Normalized = false;
					structSection.Offset = Marshal.OffsetOf<T>(field.Name);
					structSection.Stride = new IntPtr(itemSize);

					typeSections.Add(structSection);
				}

				_TypeSections.Add(typeof(T), typeSections);
			}

			return (typeSections);
		}

		private static readonly Dictionary<Type, List<InterleavedSectionBase>> _TypeSections = new Dictionary<Type, List<InterleavedSectionBase>>();

		#endregion

		#region Interleaved Sections

		class InterleavedSectionBase : IArraySection
		{
			public ArrayBufferItemType ItemType { get; set; }

			public bool Normalized { get; set; }

			public IntPtr Offset { get; set; }

			public virtual IntPtr Pointer { get; set; }

			public IntPtr Stride { get; set; }
		}

		class InterleavedSection : InterleavedSectionBase
		{
			public InterleavedSection(ArrayBufferBase arrayBuffer, InterleavedSectionBase otherSection)
			{
				_ParentArray = arrayBuffer;

				ItemType = otherSection.ItemType;
				Normalized = otherSection.Normalized;
				Offset = otherSection.Offset;
				Stride = otherSection.Stride;
			}

			private ArrayBufferBase _ParentArray;

			public override IntPtr Pointer
			{
				get { return (_ParentArray.GpuBufferAddress); }
			}
		}

		private readonly List<InterleavedSection> _InterleavedSections;
			
		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal override uint ArraySectionsCount { get { return ((uint)_InterleavedSections.Count); } }

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

			return (_InterleavedSections[(int)index]);
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

			T[] genericArray = new T[CpuItemsCount];

			// Copy from buffer data to array data
			Memory.MemoryCopy(genericArray, CpuBufferAddress, CpuItemsCount * ItemSize);

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

			T[] genericArray = new T[GpuItemsCount];

			// By checking existence, it's sure that we map the GPU buffer
			Map(ctx, BufferAccess.ReadOnly);
			try {
				// Copy from mapped data to array data
				Memory.MemoryCopy(genericArray, MappedBuffer, GpuItemsCount * ItemSize);
			} finally {
				Unmap(ctx);
			}

			return (genericArray);
		}

		#endregion
	}
}
