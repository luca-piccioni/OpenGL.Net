
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
			base(BufferTarget.ArrayBuffer, (uint)Marshal.SizeOf(typeof(T)), hint)
		{
			try {
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
			base(BufferTarget.ArrayBuffer, (uint)Marshal.SizeOf(typeof(T)), usageMask)
		{
			try {
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

		#endregion

		#region Interleaved Sections

		/// <summary>
		/// An <see cref="ArrayBufferBase.IArraySection"/>, but inteleaved with other <see cref="InterleavedSectionBase"/>.
		/// </summary>
		/// <remarks>
		/// Roughly a <see cref="InterleavedSectionBase"/> represents a field of a structure, representing the interleaved
		/// vertices. Offset and types are defined directory from a generic type.
		/// </remarks>
		private class InterleavedSectionBase : IArraySection
		{
			/// <summary>
			/// The type of the elements of the array section.
			/// </summary>
			public ArrayBufferItemType ItemType { get; set; }

			/// <summary>
			/// Get whether the array elements should be meant normalized (fixed point precision values).
			/// </summary>
			public bool Normalized { get; set; }

			/// <summary>
			/// Get the actual array buffer pointer. This is meant as offset of the currently CPU/GPU buffer.
			/// </summary>
			public virtual IntPtr Pointer { get; set; }

			/// <summary>
			/// Offset of the first element of the array section, in bytes.
			/// </summary>
			/// <remarks>
			/// It should NOT take into account the client buffer address, even if the GL_ARB_vertex_buffer_object extension
			/// is not supported by current implementation. It indicates an actual offset, in bytes.
			/// </remarks>
			public IntPtr Offset { get; set; }

			/// <summary>
			/// Offset between two element of the array section, in bytes. This is the structure size.
			/// </summary>
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

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
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

		private readonly List<InterleavedSection> _InterleavedSections;

		#endregion

		#region Item Access

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
		/// Exception thrown if this BufferObject is not mapped (<see cref="Buffer.IsMapped"/>).
		/// </exception>
		public void SetElement(T value, uint index)
		{
			uint stride = ItemSize;
			ulong itemOffset = stride * index;

			Set(value, itemOffset);
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
		/// Exception thrown if this BufferObject is not mapped (<see cref="Buffer.IsMapped"/>).
		/// </exception>
		public void SetElement<ElementType>(ElementType value, uint index, uint sectionIndex) where ElementType : struct
		{
			SetElementCore(value, index, sectionIndex);
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
		public ElementType GetElement<ElementType>(uint index, uint sectionIndex) where ElementType : struct
		{
			return GetElementCore<ElementType>(index, sectionIndex);
		}

		#endregion

		#region Overrides

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
			if (MappedBuffer == IntPtr.Zero)
				throw new InvalidOperationException("GPU buffer is inaccessible");

			T[] genericArray = new T[ItemsCount];

			// Copy from buffer data to array data
			Memory.Copy(genericArray, MappedBuffer, ItemsCount * ItemSize);

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

			T[] genericArray = new T[ItemsCount];

			// By checking existence, it's sure that we map the GPU buffer
			Map(ctx, BufferAccess.ReadOnly);
			try {
				// Copy from mapped data to array data
				Memory.Copy(genericArray, MappedBuffer, ItemsCount * ItemSize);
			} finally {
				Unmap(ctx);
			}

			return genericArray;
		}

		#endregion
	}
}
