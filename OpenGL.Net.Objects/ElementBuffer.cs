
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// Element buffer object.
	/// </summary>
	public class ElementBuffer : ArrayBufferBase, ArrayBufferBase.IArraySection
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject, implictly used with <see cref="BufferUsage.StaticDraw"/>.
		/// </summary>
		/// <param name="elementType">
		/// The <see cref="DrawElementsType"/> that specify how vertices are interpreted.
		/// </param>
		public ElementBuffer(DrawElementsType elementType) :
			this(elementType, MapBufferUsageMask.None)
		{

		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// The <see cref="DrawElementsType"/> that specify how vertices are interpreted.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBuffer(DrawElementsType elementType, BufferUsage hint) :
			base(BufferTarget.ElementArrayBuffer, GetItemSize(elementType), hint)
		{
			ElementsType = elementType;
			RestartIndexKey = GetDefaultRestartIndex(elementType);
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// The <see cref="DrawElementsType"/> that specify how vertices are interpreted.
		/// </param>
		/// <param name="usageMask">
		/// An <see cref="MapBufferUsageMask"/> that specify the buffer storage usage mask.
		/// </param>
		public ElementBuffer(DrawElementsType elementType, MapBufferUsageMask usageMask) :
			base(BufferTarget.ElementArrayBuffer, GetItemSize(elementType), usageMask)
		{
			ElementsType = elementType;
			RestartIndexKey = GetDefaultRestartIndex(elementType);
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// 
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		protected ElementBuffer(Type elementType, BufferUsage hint) :
			base(BufferTarget.ElementArrayBuffer, GetItemSize(elementType), hint)
		{
			ElementsType = GetDrawElementsType(elementType);
			RestartIndexKey = GetDefaultRestartIndex(elementType);
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="elementType">
		/// 
		/// </param>
		/// <param name="usageMask">
		/// An <see cref="MapBufferUsageMask"/> that specify the buffer storage usage mask.
		/// </param>
		protected ElementBuffer(Type elementType, MapBufferUsageMask usageMask) :
			base(BufferTarget.ElementArrayBuffer, GetItemSize(elementType), usageMask)
		{
			ElementsType = GetDrawElementsType(elementType);
			RestartIndexKey = GetDefaultRestartIndex(elementType);
		}

		private static uint GetItemSize(DrawElementsType drawElementsType)
		{
			switch (drawElementsType) {
				case DrawElementsType.UnsignedByte:
					return 1;
				case DrawElementsType.UnsignedShort:
					return 2;
				case DrawElementsType.UnsignedInt:
					return 4;
				default:
					throw new ArgumentException("type not supported", nameof(drawElementsType));
			}
		}

		private static uint GetItemSize(Type elementType)
		{
			switch (Type.GetTypeCode(elementType)) {
				case TypeCode.Byte:
					return 1;
				case TypeCode.UInt16:
					return 2;
				case TypeCode.UInt32:
					return 3;
				default:
					throw new ArgumentException("type not supported", nameof(elementType));
			}
		}

		private static uint GetDefaultRestartIndex(DrawElementsType drawElementsType)
		{
			switch (drawElementsType) {
				case DrawElementsType.UnsignedByte:
					return 0x000000FF;
				case DrawElementsType.UnsignedShort:
					return 0x0000FFFF;
				case DrawElementsType.UnsignedInt:
					return 0xFFFFFFFF;
				default:
					throw new ArgumentException("type not supported", nameof(drawElementsType));
			}
		}

		private static uint GetDefaultRestartIndex(Type elementType)
		{
			switch (Type.GetTypeCode(elementType)) {
				case TypeCode.Byte:
					return 0x000000FF;
				case TypeCode.UInt16:
					return 0x0000FFFF;
				case TypeCode.UInt32:
					return 0xFFFFFFFF;
				default:
					throw new ArgumentException("type not supported", nameof(elementType));
			}
		}

		private static DrawElementsType GetDrawElementsType(Type elementType)
		{
			switch (Type.GetTypeCode(elementType)) {
				case TypeCode.Byte:
					return DrawElementsType.UnsignedByte;
				case TypeCode.UInt16:
					return DrawElementsType.UnsignedShort;
				case TypeCode.UInt32:
					return DrawElementsType.UnsignedInt;
				default:
					throw new ArgumentException("type not supported", nameof(elementType));
			}
		}

		#endregion

		#region Elements Type

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
						return ArrayBufferItemType.UByte;
					case DrawElementsType.UnsignedShort:
						return ArrayBufferItemType.UShort;
					case DrawElementsType.UnsignedInt:
						return ArrayBufferItemType.UInt;
					default:
						throw new NotSupportedException();
				}
			}
		}

		#endregion
		
		#region Primitive Restart
		
		/// <summary>
		/// Flag that specify whether the restart index is enabled for this ElementBufferObject. It defaults to false.
		/// </summary>
		public bool RestartIndexEnabled;

		/// <summary>
		/// The restart index value (fixed).
		/// </summary>
		public readonly uint RestartIndexKey;

		/// <summary>
		/// Utility routine for extracting 
		/// </summary>
		/// <param name="count">
		/// 
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		private int[] GetRestartIndices(out IntPtr[] count)
		{
			if (MappedBuffer == IntPtr.Zero)
				throw new InvalidOperationException("GPU buffer is not accessible");

			switch (ElementsType) {
				case DrawElementsType.UnsignedByte:
					return GetRestartIndices_UnsignedByte(out count);
				case DrawElementsType.UnsignedShort:
					return GetRestartIndices_UnsignedShort(out count);
				case DrawElementsType.UnsignedInt:
					return GetRestartIndices_UnsignedInt(out count);
				default:
					throw new NotSupportedException();
			}
		}

		private int[] GetRestartIndices_UnsignedByte(out IntPtr[] count)
		{
			unsafe {
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				byte* indicesPtr = (byte*)MappedBuffer.ToPointer();
				byte restartIndex = (byte)(RestartIndexKey & 0x000000FF);

				offsets.Add(0);
				for (int i = 0; i < ItemsCount; i++, indicesPtr++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemsCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return offsets.ToArray();
			}
		}

		private int[] GetRestartIndices_UnsignedShort(out IntPtr[] count)
		{
			unsafe
			{
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				ushort* indicesPtr = (ushort*)MappedBuffer.ToPointer();
				ushort restartIndex = (ushort)(RestartIndexKey & 0x0000FFFF);

				for (int i = 0; i < ItemsCount; i++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemsCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return offsets.ToArray();
			}
		}

		private int[] GetRestartIndices_UnsignedInt(out IntPtr[] count)
		{
			unsafe
			{
				List<int> offsets = new List<int>();
				List<IntPtr> counts = new List<IntPtr>();
				uint* indicesPtr = (uint*)MappedBuffer.ToPointer();
				uint restartIndex = RestartIndexKey;

				for (int i = 0; i < ItemsCount; i++) {
					if (indicesPtr[i] == restartIndex) {
						int previousIndex = offsets[offsets.Count - 1];

						counts.Add(new IntPtr(i - previousIndex));
						offsets.Add(i + 1);
					}
				}
				counts.Add(new IntPtr((int)ItemsCount - offsets[offsets.Count - 1]));

				Debug.Assert(offsets.Count == counts.Count);
				count = counts.ToArray();

				return offsets.ToArray();
			}
		}

		/// <summary>
		/// Offset of the primitives at each restart.
		/// </summary>
		internal int[] PrimitiveRestartOffsets;

		/// <summary>
		/// Number of indices composing the restarted primitives.
		/// </summary>
		internal IntPtr[] PrimitiveRestartCounts;

		#endregion

		#region Get Index

		public uint GetIndex(uint index)
		{
			uint vIndex;

			switch (ElementsType) {
				case DrawElementsType.UnsignedByte:
					vIndex = GetElementCore<byte>(index, 0);
					break;
				case DrawElementsType.UnsignedShort:
					vIndex = GetElementCore<ushort>(index, 0);
					break;
				case DrawElementsType.UnsignedInt:
					vIndex = GetElementCore<uint>(index, 0);
					break;
				default:
					throw new NotSupportedException(ElementsType + " not supported");
			}

			return vIndex;
		}

		#endregion

		#region Overrides

		/// <summary>
		/// Get the count of the array sections aggregated in this ArrayBufferObjectBase.
		/// </summary>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override uint ArraySectionsCount { get { return 1; } }

		/// <summary>
		/// Get the specified section information.
		/// </summary>
		/// <param name="index">
		/// The <see cref="UInt32"/> that specify the array section index.
		/// </param>
		/// <returns>
		/// It returns the <see cref="ArrayBufferBase.IArraySection"/> defining the array section.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected internal override IArraySection GetArraySection(uint index) { return this; }

		/// <summary>
		/// Convert the client buffer in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an <see cref="Array"/> having all items stored by this ArrayBufferObjectBase.
		/// </returns>
		public override Array ToArray()
		{
			if (MappedBuffer == IntPtr.Zero)
				throw new InvalidOperationException("GPU buffer is not accessible");

			Array genericArray = CreateArray(ArrayType, ItemsCount);

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
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			Array genericArray = CreateArray(ArrayType, ItemsCount);

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

		/// <summary>
		/// Actually create this BufferObject resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject has not client memory allocated and the hint is different from
		/// <see cref="BufferHint.StaticCpuDraw"/> or <see cref="BufferHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Base implementation
			base.CreateObject(ctx);
			// Compute necessary information to support primitive restart even if the platform does not implement it
			if (!ctx.Extensions.PrimitiveRestart && !ctx.Extensions.PrimitiveRestart_NV && RestartIndexEnabled)
				PrimitiveRestartOffsets = GetRestartIndices(out PrimitiveRestartCounts);
		}

		#endregion

		#region ArrayBufferObjectBase.IArraySection Implementation

		/// <summary>
		/// The type of the elements of the array section.
		/// </summary>
		ArrayBufferItemType IArraySection.ItemType { get { throw new NotImplementedException(); } }

		/// <summary>
		/// Get whether the array elements should be meant normalized (fixed point precision values).
		/// </summary>
		bool IArraySection.Normalized { get { return false; } }

		/// <summary>
		/// Get the actual array buffer pointer. It could be <see cref="IntPtr.Zero"/> indicating an actual GPU
		/// buffer reference.
		/// </summary>
		IntPtr IArraySection.Pointer { get { return GpuBufferAddress; } }

		/// <summary>
		/// Offset of the first element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Offset { get { return IntPtr.Zero; } }

		/// <summary>
		/// Offset between two element of the array section, in bytes.
		/// </summary>
		IntPtr IArraySection.Stride { get { return IntPtr.Zero; } }

		#endregion
	}

	/// <summary>
	/// Element buffer object.
	/// </summary>
	/// <typeparam name="T">
	/// The generic type must be <see cref="Byte"/>, <see cref="UInt16"/> or <see cref="UInt32"/>, otherwise
	/// the constructors will throw an exception.
	/// </typeparam>
	public class ElementBuffer<T> : ElementBuffer where T : struct, IConvertible
	{
		#region Constructors

		/// <summary>
		/// Construct an ElementBufferObject, implictly used with <see cref="BufferHint.StaticCpuDraw"/>.
		/// </summary>
		public ElementBuffer() :
			this(MapBufferUsageMask.None)
		{

		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferUsage"/> that specify the data buffer usage hints.
		/// </param>
		public ElementBuffer(BufferUsage hint) :
			base(typeof(T), hint)
		{
			
		}

		/// <summary>
		/// Construct an ElementBufferObject.
		/// </summary>
		/// <param name="usageMask">
		/// An <see cref="MapBufferUsageMask"/> that specify the buffer storage usage mask.
		/// </param>
		public ElementBuffer(MapBufferUsageMask usageMask) :
			base(typeof(T), usageMask)
		{
			
		}

		#endregion

		#region Restart Index

		/// <summary>
		/// The default restart index for this ElementBuffer.
		/// </summary>
		public static uint DefaultRestartIndex
		{
			get
			{
				switch (Type.GetTypeCode(typeof(T))) {
					case TypeCode.Byte:
						return 0x000000FF;
					case TypeCode.UInt16:
						return 0x0000FFFF;
					case TypeCode.UInt32:
						return 0xFFFFFFFF;
					default:
						throw new NotSupportedException($"type {typeof(T)} not supported");
				}
			}
		}

		#endregion
	}
}