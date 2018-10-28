
// Copyright (C) 2017 Luca Piccioni
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
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL.Objects
{
	public class ArrayBufferInterleaved<T> : ArrayBufferBase where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct a mutable ArrayBufferInterleaved specifying its item layout on GPU side.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferInterleaved(BufferUsage hint) :
			base(BufferTarget.ArrayBuffer, hint)
		{
			try {
				// Determine array item size
				ItemSize = (uint)Marshal.SizeOf(typeof(T));
				// Detect interleaved fields using reflection (cached)
				List<InterleavedSectionBase> typeSections = ScanTypeSections();
				// Get array sections for this instance
				_InterleavedSections = typeSections.ConvertAll(item => new InterleavedSection(this, item));
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct an immutable ArrayBufferInterleaved specifying its item layout on GPU side.
		/// </summary>
		/// <param name="usageMask">
		/// A <see cref="MapBufferUsageMask"/> that specifies the data buffer usage mask.
		/// </param>
		public ArrayBufferInterleaved(MapBufferUsageMask usageMask) :
			base(BufferTarget.ArrayBuffer, usageMask)
		{
			try {
				// Determine array item size
				ItemSize = (uint)Marshal.SizeOf(typeof(T));
				// Detect interleaved fields using reflection (cached)
				List<InterleavedSectionBase> typeSections = ScanTypeSections();
				// Get array sections for this instance
				_InterleavedSections = typeSections.ConvertAll(item => new InterleavedSection(this, item));
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		private static List<InterleavedSectionBase> ScanTypeSections()
		{
			List<InterleavedSectionBase> typeSections;

			if (_TypeSections.TryGetValue(typeof(T), out typeSections))
				return typeSections;

			// Cache for type
			uint itemSize = (uint)Marshal.SizeOf(typeof(T));

			typeSections = new List<InterleavedSectionBase>();

			foreach (FieldInfo field in typeof(T).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)) {
				typeSections.Add(new InterleavedSectionBase {
					ItemType = ArrayBufferItem.GetArrayType(field.FieldType),
					Normalized = false,
					Offset = Marshal.OffsetOf(typeof(T), field.Name),
					Stride = new IntPtr(itemSize)
				});
			}

			_TypeSections.Add(typeof(T), typeSections);

			return typeSections;
		}

		private static readonly Dictionary<Type, List<InterleavedSectionBase>> _TypeSections = new Dictionary<Type, List<InterleavedSectionBase>>();

		#endregion

		#region Interleaved Sections

		private class InterleavedSectionBase : IArraySection
		{
			public ArrayBufferItemType ItemType { get; set; }

			public bool Normalized { get; set; }

			public IntPtr Offset { get; set; }

			public virtual IntPtr Pointer { get; set; }

			public IntPtr Stride { get; set; }
		}

		private class InterleavedSection : InterleavedSectionBase
		{
			public InterleavedSection(ArrayBufferBase arrayBuffer, InterleavedSectionBase otherSection)
			{
				_ParentArray = arrayBuffer;

				ItemType = otherSection.ItemType;
				Normalized = otherSection.Normalized;
				Offset = otherSection.Offset;
				Stride = otherSection.Stride;
			}

			private readonly ArrayBufferBase _ParentArray;

			public override IntPtr Pointer
			{
				get { return _ParentArray.GpuBufferAddress; }
			}
		}

		private readonly List<InterleavedSection> _InterleavedSections;
			
		#endregion

		#region ArrayBufferObjectBase Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		protected internal override uint ArraySectionsCount { get { return (uint)_InterleavedSections.Count; } }

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
				throw new ArgumentOutOfRangeException(nameof(index), index, "greater or equal to ArraySectionsCount");

			return _InterleavedSections[(int)index];
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
			Memory.Copy(genericArray, CpuBufferAddress, CpuItemsCount * ItemSize);

			return genericArray;
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
				Memory.Copy(genericArray, MappedBuffer, GpuItemsCount * ItemSize);
			} finally {
				Unmap(ctx);
			}

			return genericArray;
		}

		#endregion
	}
}
