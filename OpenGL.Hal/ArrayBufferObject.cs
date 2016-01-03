
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Array buffer object.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This class is a <see cref="BufferObject"/> specialized for storing data to be issued to a shader program execution.
	/// </para>
	/// <para>
	/// The following information defines the array items layout:
	/// - <see cref="ArrayType"/>: the property describe entirely the single item data layout.
	/// - <see cref="ArrayBaseType"/>: the base type of the data component.
	/// - <see cref="ItemCount"/>: the number of items stored in this ArrayBufferObject.
	/// - <see cref="ItemSize"/>: the size of each item in array, in basic machine units.
	/// - <see cref="Interleaved"/>: a boolean flag indicating whether different data types are interleaved regularly in the array.
	/// </para>
	/// </remarks>
	public class ArrayBufferObject : BufferObject
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="System.UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(VertexBaseType vertexBaseType, uint vertexLength, Hint hint)
			: this(vertexBaseType, vertexLength, 1, hint)
		{
			
		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on CPU side.
		/// </summary>
		/// <param name="vertexBaseType">
		/// A <see cref="VertexBaseType"/> describing the item components base type on CPU side.
		/// </param>
		/// <param name="vertexLength">
		/// A <see cref="System.UInt32"/> that specify how many components have the array item.
		/// </param>
		/// <param name="vertexRank">
		/// A <see cref="System.UInt32"/> that specify how many columns have the array item of matrix type.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank, Hint hint)
			: base(BufferTargetARB.ArrayBuffer, hint)
		{
			try {
				if (vertexBaseType == VertexBaseType.Undefined)
					throw new ArgumentException("invalid base type", "vertexBaseType");
				if (vertexLength < 1 || vertexLength > 4)
					throw new ArgumentOutOfRangeException("vertexLength", vertexLength, "it must be in the range [1..4]");
				if (vertexRank < 1 || vertexRank > 4)
					throw new ArgumentOutOfRangeException("vertexRank", vertexRank, "it must be in the range [1..4]");

				// Store GPU array type
				_ArrayType = ArrayBufferItem.GetArrayType(vertexBaseType, vertexLength, vertexRank);
				Debug.Assert(_ArrayType != ArrayBufferItemType.Complex);
				// Store base type
				_ArrayBaseType = vertexBaseType;
				// Determine array item size
				_ItemSize = ArrayBufferItem.GetArrayItemSize(vertexBaseType) * vertexLength * vertexRank;

				SubArrays = new List<SubArrayBuffer>(1);
				SubArrays.Add(new SubArrayBuffer(_ArrayBaseType, vertexLength));
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		/// <summary>
		/// Construct an ArrayBufferObject specifying its item layout on GPU side.
		/// </summary>
		/// <param name="format">
		/// A <see cref="ArrayBufferItemType"/> describing the item base type on GPU side.
		/// </param>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(ArrayBufferItemType format, Hint hint)
			: base(BufferTargetARB.ArrayBuffer, hint)
		{
			try {
				// Store array type
				_ArrayType = format;
				// Determine base type and item size, if possible
				if (format != ArrayBufferItemType.Complex) {
					_ArrayBaseType = ArrayBufferItem.GetArrayBaseType(format);
					_ItemSize = ArrayBufferItem.GetArrayItemSize(format);

					SubArrays = new List<SubArrayBuffer>(1);
					SubArrays.Add(new SubArrayBuffer(format));
				}
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Array Buffer Information

		/// <summary>
		/// The array buffer object element type, on CPU side.
		/// </summary>
		public ArrayBufferItemType ArrayType { get { return (_ArrayType); } }

		/// <summary>
		/// The array buffer object element base type.
		/// </summary>
		public VertexBaseType ArrayBaseType { get { return (_ArrayBaseType); } }

		/// <summary>
		/// Array buffer object items count.
		/// </summary>
		public uint ItemCount
		{
			get { return (_ItemCount); }
			protected set { _ItemCount = value; }
		}

		/// <summary>
		/// Array buffer object items size, in bytes.
		/// </summary>
		public uint ItemSize
		{
			get { return (_ItemSize); }
			protected set { _ItemSize = value; }
		}

		/// <summary>
		/// Array buffer is interleaved.
		/// </summary>
		public bool Interleaved
		{
			get { return (_Interleaved); }
			protected set { _Interleaved = value; }
		}

		/// <summary>
		/// The array buffer object element type.
		/// </summary>
		private readonly ArrayBufferItemType _ArrayType;

		/// <summary>
		/// The array buffer object element base type.
		/// </summary>
		private readonly VertexBaseType _ArrayBaseType = VertexBaseType.Undefined;

		/// <summary>
		/// Array buffer object items count.
		/// </summary>
		private uint _ItemCount;

		/// <summary>
		/// Data item size, in basic machine units (bytes).
		/// </summary>
		private uint _ItemSize;

		/// <summary>
		/// Array buffer is interleaved.
		/// </summary>
		private bool _Interleaved;

		#endregion

		#region Array Buffer Data Definition

		/// <summary>
		/// Define this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="itemsCount">
		/// A <see cref="UInt32"/> that specify the number of elements hold by this
		/// ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// <para>
		/// Client memory is always allocated.
		/// </para>
		/// </remarks>
		public void Define(uint itemsCount)
		{
			if (itemsCount == 0)
				throw new ArgumentException("invalid", "itemsCount");

			// Store item count
			ItemCount = itemsCount;
			// Allocate buffer
			Allocate(ItemCount * ItemSize);
		}

		/// <summary>
		/// Define this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used to define this ArrayBufferObject.
		/// </param>
		/// <param name="itemsCount">
		/// A <see cref="UInt32"/> that specify the number of elements hold by this
		/// ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// <para>
		/// Client memory is allocated only if <see cref="BufferObject.BufferHint"/> if different from
		/// <see cref=""/>.
		/// </para>
		/// </remarks>
		public void Define(GraphicsContext ctx, uint itemsCount)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			if (Exists(ctx)) {
				if (MemoryBuffer != null)
					MemoryBuffer.Realloc(itemsCount * ItemSize);
				ItemCount = itemsCount;
			} else {
				Define(itemsCount);
				Create(ctx);
			}
		}

		/// <summary>
		/// Define this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="items">
		/// A <see cref="Array"/> that specify the elements hold by this ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// The array <paramref name="items"/> is copied onto the buffer respecting the ArrayBufferObject item stride.
		/// </remarks>
		public void Define(Array items)
		{
			if (items.Length == 0)
				throw new ArgumentException("invalid", "items");

			Type clientType = items.GetType().GetElementType();
			if (clientType.IsValueType == false)
				throw new ArgumentException("not array of values", "items");

			int clientItemSize = Marshal.SizeOf(clientType);
			if (clientItemSize > ItemSize)
				throw new ArgumentException("array item type too big for this ArrayBufferObject", "items");

			EnsureSize((uint)items.Length);

			for (int i = 0; i < items.Length; i++)
				Marshal.StructureToPtr(items.GetValue(i), new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + ItemSize * i), false);
		}

		/// <summary>
		/// Define this ArrayBufferObject by specifing only the number of items.
		/// </summary>
		/// <param name="itemsCount">
		/// A <see cref="UInt32"/> that specify the number of elements hold by this
		/// ArrayBufferObject.
		/// </param>
		public void EnsureSize(uint itemsCount)
		{
			if (itemsCount <= ItemCount)
				return;

			// Store item count
			ItemCount = itemsCount;
			// Allocate buffer
			Reallocate(ItemCount * ItemSize);
		}

		#endregion

		#region Array Buffer Data Access

		/// <summary>
		/// Gets data from this ArrayBufferObject.
		/// </summary>
		/// <typeparam name='T'>
		/// The type parameter that determine the type of the data to read. This type could be different from the real
		/// ArrayBufferObject items.
		/// </typeparam>
		/// <param name='index'>
		/// The zero-based index of the element to read. The basic machine unit offset of the element to read is
		/// determine by the size of the type <typeparamref name="T"/>.
		/// </param>
		/// <returns>
		/// An element of this ArrayBufferObject, of type <typeparamref name="T"/>, at index <paramref name="index"/>.
		/// </returns>
		public T GetData<T>(uint index) where T : struct
		{
			IntPtr bufferPtr = new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + index * Marshal.SizeOf(typeof(T)));

			return ((T)Marshal.PtrToStructure(bufferPtr, typeof(T)));
		}

		/// <summary>
		/// Sets data to this ArrayBufferObject.
		/// </summary>
		/// <typeparam name="T">
		/// The type parameter that determine the type of the data to read. This type could be different from the real
		/// ArrayBufferObject elements.
		/// </typeparam>
		/// <param name="value">
		/// A <typeparamref name="T"/> that is the value to store in this ArrayBufferObject.
		/// </param>
		/// <param name='index'>
		/// The zero-based index of the element to read. The basic machine unit offset of the element to read is
		/// determine by the size of the type <typeparamref name="T"/>.
		/// </param>
		public void SetData<T>(T value, uint index) where T : struct
		{
			IntPtr bufferPtr = new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + index * Marshal.SizeOf(typeof(T)));

			Marshal.StructureToPtr(value, bufferPtr, false);
		}

		#endregion

		#region To Array

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public Array ToArray()
		{
			Array genericArray;

			switch (ArrayType) {
				case ArrayBufferItemType.Byte:
					genericArray = new SByte[ItemCount];
					break;
				case ArrayBufferItemType.Byte2:
					genericArray = new Vertex2b[ItemCount];
					break;
				case ArrayBufferItemType.Byte3:
					genericArray = new Vertex3b[ItemCount];
					break;
				case ArrayBufferItemType.Byte4:
					genericArray = new Vertex4b[ItemCount];
					break;
				case ArrayBufferItemType.UByte:
					genericArray = new Byte[ItemCount];
					break;
				case ArrayBufferItemType.UByte2:
					genericArray = new Vertex2ub[ItemCount];
					break;
				case ArrayBufferItemType.UByte3:
					genericArray = new Vertex3ub[ItemCount];
					break;
				case ArrayBufferItemType.UByte4:
					genericArray = new Vertex4ub[ItemCount];
					break;
				case ArrayBufferItemType.Short:
					genericArray = new Int16[ItemCount];
					break;
				case ArrayBufferItemType.Short2:
					genericArray = new Vertex2s[ItemCount];
					break;
				case ArrayBufferItemType.Short3:
					genericArray = new Vertex3s[ItemCount];
					break;
				case ArrayBufferItemType.Short4:
					genericArray = new Vertex4s[ItemCount];
					break;
				case ArrayBufferItemType.UShort:
					genericArray = new UInt16[ItemCount];
					break;
				case ArrayBufferItemType.UShort2:
					genericArray = new Vertex2us[ItemCount];
					break;
				case ArrayBufferItemType.UShort3:
					genericArray = new Vertex3us[ItemCount];
					break;
				case ArrayBufferItemType.UShort4:
					genericArray = new Vertex4us[ItemCount];
					break;
				case ArrayBufferItemType.Int:
					genericArray = new Int32[ItemCount];
					break;
				case ArrayBufferItemType.Int2:
					genericArray = new Vertex2i[ItemCount];
					break;
				case ArrayBufferItemType.Int3:
					genericArray = new Vertex3i[ItemCount];
					break;
				case ArrayBufferItemType.Int4:
					genericArray = new Vertex4i[ItemCount];
					break;
				case ArrayBufferItemType.UInt:
					genericArray = new UInt32[ItemCount];
					break;
				case ArrayBufferItemType.UInt2:
					genericArray = new Vertex2ui[ItemCount];
					break;
				case ArrayBufferItemType.UInt3:
					genericArray = new Vertex3ui[ItemCount];
					break;
				case ArrayBufferItemType.UInt4:
					genericArray = new Vertex4ui[ItemCount];
					break;
				case ArrayBufferItemType.Float:
					genericArray = new Single[ItemCount];
					break;
				case ArrayBufferItemType.Float2:
					genericArray = new Vertex2f[ItemCount];
					break;
				case ArrayBufferItemType.Float3:
					genericArray = new Vertex3f[ItemCount];
					break;
				case ArrayBufferItemType.Float4:
					genericArray = new Vertex4f[ItemCount];
					break;
				case ArrayBufferItemType.Double:
					genericArray = new Double[ItemCount];
					break;
				case ArrayBufferItemType.Double2:
					genericArray = new Vertex2d[ItemCount];
					break;
				case ArrayBufferItemType.Double3:
					genericArray = new Vertex3d[ItemCount];
					break;
				case ArrayBufferItemType.Double4:
					genericArray = new Vertex4d[ItemCount];
					break;
				case ArrayBufferItemType.Half:
					genericArray = new HalfFloat[ItemCount];
					break;
				case ArrayBufferItemType.Half2:
					genericArray = new Vertex2hf[ItemCount];
					break;
				case ArrayBufferItemType.Half3:
					genericArray = new Vertex3hf[ItemCount];
					break;
				case ArrayBufferItemType.Half4:
					genericArray = new Vertex4hf[ItemCount];
					break;
				default:
					throw new InvalidOperationException(String.Format("array type {0} not supported", ArrayType));
			}

			// Copy from buffer data to array data
			Memory.MemoryCopy(genericArray, MemoryBuffer.AlignedBuffer, ItemCount * ItemSize);

			return (genericArray);
		}

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <typeparam name="T">
		/// 
		/// </typeparam>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public T[] ToArray<T>() where T : struct { return (ToArray<T>(ItemCount)); }

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <typeparam name="T">
		/// An arbitrary structure defining the returned array item. It doesn't need to be correlated with the ArrayBufferObject
		/// layout.
		/// </typeparam>
		/// <param name="arrayLength">
		/// A <see cref="System.UInt32"/> that specify the number of elements of the returned array.
		/// </param>
		/// <returns>
		/// It returns an array having all items stored by this ArrayBufferObject.
		/// </returns>
		public T[] ToArray<T>(uint arrayLength) where T : struct
		{
			T[] array = new T[ItemCount];
			uint sizeOfType = (uint)Marshal.SizeOf(typeof(T));

			if (arrayLength * sizeOfType > ItemCount * ItemSize)
				throw new InvalidOperationException(String.Format("size of {0}[{1}] greater than array buffer", GetType(), arrayLength));

			// Copy from buffer data to array data
			Memory.MemoryCopy(array, MemoryBuffer.AlignedBuffer, arrayLength * sizeOfType);

			return (array);
		}

		#endregion

		#region Sub-Array Abstraction

		/// <summary>
		/// Sub-array information.
		/// </summary>
		/// <remarks>
		/// Using this buffer fragmentation, it is possible to define multiple buffers allocated into a single
		/// one (packing and/or inteleaving).
		/// </remarks>
		[DebuggerDisplay("SubArrayBuffer Offset={ArrayOffset} Stride={ArrayStride}")]
		protected internal class SubArrayBuffer : ArrayBufferItem
		{
			public SubArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength)
				: base(vertexBaseType, vertexLength)
			{
				
			}

			public SubArrayBuffer(VertexBaseType vertexBaseType, uint vertexLength, uint vertexRank)
				: base(vertexBaseType, vertexLength, vertexRank)
			{

			}

			/// <summary>
			/// Construct an SubArrayBuffer from a <see cref="ArrayBufferItemType"/>.
			/// </summary>
			/// <param name="vertexArrayType">
			/// A <see cref="ArrayBufferItemType"/> that synthetize all informations about a vertex array buffer item.
			/// </param>
			public SubArrayBuffer(ArrayBufferItemType vertexArrayType)
				: base(vertexArrayType)
			{
				
			}

			/// <summary>
			/// Construct an SubArrayBuffer from a <see cref="ArrayBufferItemAttribute"/>.
			/// </summary>
			/// <param name="attribute">
			/// A <see cref="ArrayBufferItemAttribute"/> describing the vertex array buffer item.
			/// </param>
			public SubArrayBuffer(ArrayBufferItemAttribute attribute)
				: base(attribute)
			{

			}

			/// <summary>
			/// The offset for accessing to the sub-array.
			/// </summary>
			public IntPtr ArrayOffset;

			/// <summary>
			/// The stride for accessing to the next sub-array item.
			/// </summary>
			public uint ArrayStride;
		}

		/// <summary>
		/// Number of vertex streams specified in this ArrayBufferObject.
		/// </summary>
		protected internal uint SubArrayCount { get { return ((uint)SubArrays.Count); } }

		/// <summary>
		/// Information about array buffer vertex stream.
		/// </summary>
		internal SubArrayBuffer GetSubArrayInfo(uint streamIndex)
		{
			return (SubArrays[(int)streamIndex]);
		}

		/// <summary>
		/// Sub-array compositing this ArrayBufferObject.
		/// </summary>
		protected List<SubArrayBuffer> SubArrays;

		/// <summary>
		/// Detect array configuration of an array buffer item.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="interleaved"></param>
		/// <returns></returns>
		protected List<SubArrayBuffer> DetectSubArrays(Type type, out bool interleaved)
		{
			// Test for simple buffer
			SubArrayBuffer subarray = DetectSubArray(type);
			if (subarray != null) {
				List<SubArrayBuffer> uniqueArray = new List<SubArrayBuffer>(1);
				uniqueArray.Add(subarray);
				interleaved = false;
				return (uniqueArray);
			}

			// Test for interleaved sub arrays
			List<SubArrayBuffer> subArrays = DetectInterleavedSubArrays(type);
			if (subArrays != null) {
				interleaved = true;
				return (subArrays);
			}

			interleaved = false;

			return (null);
		}

		/// <summary>
		/// Detect sub-array configuration of a structure (interleaved sub-arrays)
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		protected List<SubArrayBuffer> DetectInterleavedSubArrays(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			FieldInfo[] typeFields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

			if (typeFields.Length == 0)
				throw new InvalidOperationException(String.Format("type {0} has no public field", type.FullName));

			List<SubArrayBuffer> subArrays = new List<SubArrayBuffer>();
			uint structStride = (uint)Marshal.SizeOf(type);

			foreach (FieldInfo typeField in typeFields) {
				SubArrayBuffer subarray = DetectSubArray(typeField.FieldType);

				// Sub-array must have
				if (subarray == null)
					throw new InvalidOperationException(String.Format("field {0}.{1} is not a array buffer item", type.FullName, typeField.Name));

				// Determine sub-array offset
				subarray.ArrayOffset = Marshal.OffsetOf(type, typeField.Name);
				subarray.ArrayStride = structStride;

				// Collect sub-array
				subArrays.Add(subarray);
			}

			return (subArrays);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		protected SubArrayBuffer DetectSubArray(Type type)
		{
			ArrayBufferItemAttribute itemAttribute = (ArrayBufferItemAttribute)Attribute.GetCustomAttribute(type, typeof(ArrayBufferItemAttribute));

			if (itemAttribute == null) {
				if (type.IsValueType && type.IsPrimitive) {
					if      (type == typeof(float))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.Float, 1);
					else if (type == typeof(double))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.Double, 1);
					else if (type == typeof(int))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.Int, 1);
					else if (type == typeof(short))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.Short, 1);
					else if (type == typeof(uint))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.UInt, 1);
					else if (type == typeof(ushort))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.UShort, 1);
					else if (type == typeof(byte))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.UByte, 1);
					else if (type == typeof(sbyte))
						itemAttribute = new ArrayBufferItemAttribute(VertexBaseType.Byte, 1);
					else
						return (null);

					Debug.Assert(itemAttribute != null);

					return (new SubArrayBuffer(itemAttribute));
				} else
					return (null);
			} else {
				return (new SubArrayBuffer(itemAttribute));
			}
		}

		#endregion

		#region Strongly Typed Array Factory

		/// <summary>
		/// Create an array buffer object, using the generic class <see cref="ArrayBufferObject{T}"/>, depending on a <see cref="ArrayBufferItemType"/>.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that determine the generic argument of the created array buffer object.
		/// </param>
		/// <param name="hint">
		/// A <see cref="BufferObject.Hint"/> required for creating a <see cref="ArrayBufferObject"/>.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		public static ArrayBufferObject CreateArrayObject(ArrayBufferItemType vertexArrayType, Hint hint)
		{
			switch (vertexArrayType) {
				case ArrayBufferItemType.Byte:
					return (new ArrayBufferObject<sbyte>(hint));
				case ArrayBufferItemType.Byte2:
					return (new ArrayBufferObject<Vertex2b>(hint));
				case ArrayBufferItemType.Byte3:
					return (new ArrayBufferObject<Vertex3b>(hint));
				case ArrayBufferItemType.Byte4:
					return (new ArrayBufferObject<Vertex4b>(hint));
				case ArrayBufferItemType.UByte:
					return (new ArrayBufferObject<byte>(hint));
				case ArrayBufferItemType.UByte2:
					return (new ArrayBufferObject<Vertex2ub>(hint));
				case ArrayBufferItemType.UByte3:
					return (new ArrayBufferObject<Vertex3ub>(hint));
				case ArrayBufferItemType.UByte4:
					return (new ArrayBufferObject<Vertex4ub>(hint));
				case ArrayBufferItemType.Short:
					return (new ArrayBufferObject<short>(hint));
				case ArrayBufferItemType.Short2:
					return (new ArrayBufferObject<Vertex2s>(hint));
				case ArrayBufferItemType.Short3:
					return (new ArrayBufferObject<Vertex3s>(hint));
				case ArrayBufferItemType.Short4:
					return (new ArrayBufferObject<Vertex4s>(hint));
				case ArrayBufferItemType.UShort:
					return (new ArrayBufferObject<ushort>(hint));
				case ArrayBufferItemType.UShort2:
					return (new ArrayBufferObject<Vertex2us>(hint));
				case ArrayBufferItemType.UShort3:
					return (new ArrayBufferObject<Vertex3us>(hint));
				case ArrayBufferItemType.UShort4:
					return (new ArrayBufferObject<Vertex4us>(hint));
				case ArrayBufferItemType.Int:
					return (new ArrayBufferObject<Int32>(hint));
				case ArrayBufferItemType.Int2:
					return (new ArrayBufferObject<Vertex2i>(hint));
				case ArrayBufferItemType.Int3:
					return (new ArrayBufferObject<Vertex3i>(hint));
				case ArrayBufferItemType.Int4:
					return (new ArrayBufferObject<Vertex4i>(hint));
				case ArrayBufferItemType.UInt:
					return (new ArrayBufferObject<UInt32>(hint));
				case ArrayBufferItemType.UInt2:
					return (new ArrayBufferObject<Vertex2ui>(hint));
				case ArrayBufferItemType.UInt3:
					return (new ArrayBufferObject<Vertex3ui>(hint));
				case ArrayBufferItemType.UInt4:
					return (new ArrayBufferObject<Vertex4ui>(hint));
				case ArrayBufferItemType.Float:
					return (new ArrayBufferObject<Single>(hint));
				case ArrayBufferItemType.Float2:
					return (new ArrayBufferObject<Vertex2f>(hint));
				case ArrayBufferItemType.Float3:
					return (new ArrayBufferObject<Vertex3f>(hint));
				case ArrayBufferItemType.Float4:
					return (new ArrayBufferObject<Vertex4f>(hint));
				case ArrayBufferItemType.Float2x4:
					return (new ArrayBufferObject<Matrix2x4>(hint));
				case ArrayBufferItemType.Float4x4:
					return (new ArrayBufferObject<Matrix4>(hint));
				case ArrayBufferItemType.Double:
					return (new ArrayBufferObject<Double>(hint));
				case ArrayBufferItemType.Double2:
					return (new ArrayBufferObject<Vertex2d>(hint));
				case ArrayBufferItemType.Double3:
					return (new ArrayBufferObject<Vertex3d>(hint));
				case ArrayBufferItemType.Double4:
					return (new ArrayBufferObject<Vertex4d>(hint));
				case ArrayBufferItemType.Half:
					return (new ArrayBufferObject<HalfFloat>(hint));
				case ArrayBufferItemType.Half2:
					return (new ArrayBufferObject<Vertex2hf>(hint));
				case ArrayBufferItemType.Half3:
					return (new ArrayBufferObject<Vertex3hf>(hint));
				case ArrayBufferItemType.Half4:
					return (new ArrayBufferObject<Vertex4hf>(hint));
				default:
					throw new ArgumentException(String.Format("vertex array type {0} not supported", vertexArrayType));
			}
		}

		#endregion

		#region Core Copy

		private void CopyCore(IntPtr dst, Array src, uint srcItemSize, uint srcOffset, uint srcCount)
		{
			if (dst == IntPtr.Zero)
				throw new ArgumentException("invalid pointer", "dst");
			if (src == null)
				throw new ArgumentNullException("src");
			if (srcItemSize > ItemSize)
				throw new ArgumentException("too large", "srcItemSize");
			if (src.Length < srcCount)
				throw new ArgumentException("exceed array length", "srcCount");
			if (src.Length < srcOffset + srcCount)
				throw new ArgumentException("exceed array length", "srcOffset");

			GCHandle arrayHandle = GCHandle.Alloc(src, GCHandleType.Pinned);
			try {
				unsafe
				{
					byte* arrayPtr = (byte*)arrayHandle.AddrOfPinnedObject().ToPointer();
					byte* dstPtr = (byte*)dst.ToPointer();

					// Take into account source offset
					arrayPtr += srcItemSize * srcOffset;

					if (srcItemSize != ItemSize) {
						// Respect this ArrayBufferObject item stride
						for (uint i = 0; i < srcCount; i++, arrayPtr += srcItemSize, dstPtr += ItemSize)
							Memory.MemoryCopy(dstPtr, arrayPtr, srcItemSize);
					} else {
						Memory.MemoryCopy(dstPtr, arrayPtr, srcItemSize * srcCount);
					}
				}
			} finally {
				arrayHandle.Free();
			}
		}

		#endregion

		#region Copy(Array array, uint offset, uint count)

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
		public void Copy(Array array)
		{
			Copy(array, 0, (uint)array.Length);
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
		public void Copy(Array array, uint count)
		{
			Copy(array, 0, count);
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
		public void Copy(Array array, uint offset, uint count)
		{
			if (array == null)
				throw new ArgumentNullException("array");
			if (array.Rank != 1)
				throw new ArgumentException(String.Format("copying from array of rank {0} not supported", array.Rank));
			if (count == 0)
				return;

			Type arrayElementType = array.GetType().GetElementType();
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new ArgumentException("invalid array element type", "array");

			// The base type should be corresponding
			ArrayBufferItemType arrayElementVertexType = ArrayBufferItem.GetArrayType(arrayElementType);
			if (_ArrayBaseType != ArrayBufferItem.GetArrayBaseType(arrayElementVertexType))
				throw new ArgumentException(String.Format("source base type of {0} incompatible with destination base type of {1}", arrayElementType.Name, _ArrayBaseType), "array");

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = ArrayBufferItem.GetArrayItemSize(arrayElementVertexType);
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", "array");

			// Memory buffer shall be able to contains all data
			if (MemoryBuffer == null || MemoryBuffer.Size < ItemSize * count)
				Reallocate(ItemSize * count);

			// Copy on buffer
			CopyCore(MemoryBuffer.AlignedBuffer, array, arrayItemSize, offset, count);
		}

		#endregion

		#region Copy(GraphicsContext ctx, Array array, uint offset, uint count)

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
		public void Copy(GraphicsContext ctx, Array array)
		{
			Copy(ctx, array, 0, (uint)array.Length);
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
		public void Copy(GraphicsContext ctx, Array array, uint count)
		{
			Copy(ctx, array, 0, count);
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
		public void Copy(GraphicsContext ctx, Array array, uint offset, uint count)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (array == null)
				throw new ArgumentNullException("array");
			if (array.Rank != 1)
				throw new ArgumentException(String.Format("copying from array of rank {0} not supported", array.Rank));
			if (count == 0)
				return;

			Type arrayElementType = array.GetType().GetElementType();
			if (arrayElementType == null || !arrayElementType.IsValueType)
				throw new ArgumentException("invalid array element type", "array");

			// The base type should be corresponding
			ArrayBufferItemType arrayElementVertexType = ArrayBufferItem.GetArrayType(arrayElementType);
			if (_ArrayBaseType != ArrayBufferItem.GetArrayBaseType(arrayElementVertexType))
				throw new ArgumentException(String.Format("source base type of {0} incompatible with destination base type of {1}", arrayElementType.Name, _ArrayBaseType), "array");

			// Array element item size cannot exceed ItemSize
			uint arrayItemSize = ArrayBufferItem.GetArrayItemSize(arrayElementVertexType);
			if (arrayItemSize > ItemSize)
				throw new ArgumentException("array element type too big", "array");

			if (Exists(ctx)) {
				// Reallocate array buffer object, if necessary
				if (BufferSize < ItemSize * count) {
					// Update the buffer size
					BufferSize = ItemSize * count;
					// Define data on GPU
					CreateObject(ctx);
				}
			} else {
				// Update the buffer size
				BufferSize = ItemSize * count;
				// Create array buffer object, and define data on GPU
				Create(ctx);
			}

			// Copy data mapping GPU buffer
			Map(ctx, BufferAccessARB.WriteOnly);
			try {
				// Copy on buffer
				CopyCore(MappedBuffer, array, arrayItemSize, offset, count);
			} finally {
				Unmap(ctx);
			}
		}

		#endregion

		#region Copy with Indices

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index.
		/// </summary>
		/// <param name="buffer">
		/// An <see cref="ArrayBufferObject"/> that specify the source data buffer to copy.
		/// </param>
		/// <param name="indices">
		/// An array of indices indicating the order of the vertices copied from <paramref name="buffer"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="System.UInt32"/> that specify how many elements to copy from <paramref name="buffer"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="System.UInt32"/> that specify the first index considered from <paramref name="indices"/>. A
		/// value of 0 indicates that the indices are considered from the first one.
		/// </param>
		/// <param name="stride">
		/// A <see cref="System.UInt32"/> that specify the offset between two indexes considered for the copy operations
		/// from <paramref name="indices"/>. A value of 1 indicates that all considered indices are contiguos.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffer"/> or <paramref name="indices"/> are null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="count"/> or <paramref name="stride"/> equals to 0.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the combination of <paramref name="count"/>, <paramref name="offset"/> and
		/// <paramref name="stride"/> will cause a <paramref name="indices"/> array access out of its bounds.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this <see cref="ArrayBufferObject"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBufferObject buffer, uint[] indices, uint count, uint offset, uint stride)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (indices == null)
				throw new ArgumentNullException("indices");
			if (count == 0)
				throw new ArgumentException("invalid", "count");
			if (stride == 0)
				throw new ArgumentException("invalid", "stride");
			if (offset + ((count - 1) * stride) > indices.Length)
				throw new InvalidOperationException("indices out of bounds");
			if (_ArrayBaseType != buffer._ArrayBaseType)
				throw new InvalidOperationException("base type mismatch");

			Define(count);

			unsafe {
				byte* dstPtr = (byte*)MemoryBuffer.AlignedBuffer.ToPointer();

				for (uint i = 0; i < count; i++, dstPtr += ItemSize) {
					uint arrayIndex = indices[(i * stride) + offset];

					// Position 'srcPtr' to the indexed element
					byte* srcPtr = ((byte*)buffer.MemoryBuffer.AlignedBuffer.ToPointer()) + (ItemSize * arrayIndex);

					// Copy the 'arrayIndex'th element
					Memory.MemoryCopy(dstPtr, srcPtr, ItemSize);
				}
			}

			ItemCount = count;
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer">
		/// An <see cref="ArrayBufferObject"/> that specify the source data buffer to copy.
		/// </param>
		/// <param name="vcount">
		/// An array of integers indicating the number of the vertices of the polygon copied from <paramref name="buffer"/>. This parameter
		/// indicated how many polygons to copy (the array length). Each item specify the number of vertices composing the polygon.
		/// </param>
		/// <param name="indices">
		/// An array of indices indicating the order of the vertices copied from <paramref name="buffer"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="System.UInt32"/> that specify the first index considered from <paramref name="indices"/>. A
		/// value of 0 indicates that the indices are considered from the first one.
		/// </param>
		/// <param name="stride">
		/// A <see cref="System.UInt32"/> that specify the offset between two indexes considered for the copy operations
		/// from <paramref name="indices"/>. A value of 1 indicates that all considered indices are contiguos.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffer"/>, <paramref name="indices"/> or <paramref name="vcount"/> are null.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this <see cref="ArrayBufferObject"/> have a complex data layout, of it has a vertex
		/// base type different from <paramref name="buffer"/>.
		/// </exception>
		/// <remarks>
		/// <para>
		/// After a successfull copy operation, the previous buffer is discarded replaced by the copied buffer from
		/// <paramref name="buffer"/>.
		/// </para>
		/// </remarks>
		public void Copy(ArrayBufferObject buffer, uint[] indices, uint[] vcount, uint offset, uint stride)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (indices == null)
				throw new ArgumentNullException("indices");
			if (vcount == null)
				throw new ArgumentNullException("indices");
			if (stride == 0)
				throw new ArgumentException("invalid", "stride");

			if (_ArrayType == ArrayBufferItemType.Complex)
				throw new InvalidOperationException("complex buffer");
			if (_ArrayBaseType != buffer._ArrayBaseType)
				throw new InvalidOperationException("base type mismatch");

			// Allocate array buffer
			uint minVertices = UInt32.MaxValue, maxVertices = UInt32.MinValue;

			Array.ForEach(vcount, delegate(uint v) {
          		minVertices = Math.Min(v, minVertices);
				maxVertices = Math.Max(v, maxVertices);
          	});

			if ((minVertices < 3) && (maxVertices >= 3))
				throw new ArgumentException("ambigous polygons set", "vcount");

			uint totalVerticesCount = 0;

			Array.ForEach(vcount, delegate(uint v) {
				if (v == 4) {
          			totalVerticesCount += 6;			// Triangulate quad with two triangles
				} else if (v > 4) {
					totalVerticesCount += (v - 2) * 3;	// Triangulate as if it is a polygon
				} else {
					Debug.Assert(v == 3);
					totalVerticesCount += 3;			// Exactly a triangle
				}
			});

			Define(totalVerticesCount);

			// Copy polygons (triangulate)
			uint count = 0;

			unsafe {
				byte* dstPtr = (byte*)MemoryBuffer.AlignedBuffer.ToPointer();
				uint indicesIndex = offset;

				for (uint i = 0; i < vcount.Length; i++) {
					uint verticesCount = vcount[i];
					uint[] verticesIndices;

					if (verticesCount == 4) {
						verticesIndices = new uint[6];
						verticesIndices[0] = indices[indicesIndex + (0 * stride)];
						verticesIndices[1] = indices[indicesIndex + (1 * stride)];
						verticesIndices[2] = indices[indicesIndex + (2 * stride)];
						verticesIndices[3] = indices[indicesIndex + (0 * stride)];
						verticesIndices[4] = indices[indicesIndex + (2 * stride)];
						verticesIndices[5] = indices[indicesIndex + (3 * stride)];

						indicesIndex += 4 * stride;
					} else if (verticesCount > 4) {
						uint triCount = verticesCount - 2;
						uint pivotIndex = indicesIndex;

						verticesIndices = new uint[triCount * 3];

						// Copy polygon indices
						for (uint tri = 0; tri < triCount; tri++) {
							verticesIndices[tri * 3 + 0] = indices[pivotIndex];
							verticesIndices[tri * 3 + 1] = indices[indicesIndex + (tri + 2) * stride];
							verticesIndices[tri * 3 + 2] = indices[indicesIndex + (tri + 1) * stride];
						}

						indicesIndex += verticesCount * stride;
					} else {
						verticesIndices = new uint[verticesCount];
						for (int j = 0; j < verticesCount; j++, indicesIndex += stride)
							verticesIndices[j] = indices[indicesIndex];
					}

					count += (uint) verticesIndices.Length;

					for (uint j = 0; j < verticesIndices.Length; j++, dstPtr += ItemSize) {
						// Position 'srcPtr' to the indexed element
						byte* srcPtr = ((byte*) buffer.MemoryBuffer.AlignedBuffer.ToPointer()) + (ItemSize * verticesIndices[j]);
						// Copy the 'arrayIndex'th element
						Memory.MemoryCopy(dstPtr, srcPtr, ItemSize);
					}
				}
			}

			ItemCount = count;
		}

		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="indices"></param>
		/// <param name="count"></param>
		public void Copy(ArrayBufferObject buffer, ElementBufferObject indices, uint count)
		{
			Copy(buffer, indices, count, 0, 1);
		}
		
		/// <summary>
		/// Copy from an ArrayBufferObject with an indirection defined by an index (polygon tessellation).
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="indices"></param>
		/// <param name="count"></param>
		/// <param name="offset"></param>
		/// <param name="stride"></param>
		public void Copy(ArrayBufferObject buffer, ElementBufferObject indices, uint count, uint offset, uint stride)
		{
			uint[] indicesArray;

			switch (indices.ItemType) {
				case DrawElementsType.UnsignedByte:
					indicesArray = Array.ConvertAll<byte, uint>(indices.ToArray<byte>(), delegate(byte item) { return (uint)item; });
					break;
				case DrawElementsType.UnsignedShort:
					indicesArray = Array.ConvertAll<ushort, uint>(indices.ToArray<ushort>(), delegate(ushort item) { return (uint)item; });
					break;
				case DrawElementsType.UnsignedInt:
					indicesArray = indices.ToArray<uint>();
					break;
				default:
					throw new InvalidOperationException(String.Format("element type {0} not supportted", indices.ItemType));
			}

			Copy(buffer, indicesArray, count, offset, stride);
		}

		#endregion

		#region Array Item Layout Conversion

		/// <summary>
		/// Copy this array buffer object to another one (strongly typed), but having a different array item type.
		/// </summary>
		/// <typeparam name="T">
		/// A structure type used to determine the array items layout of the converted ArrayBufferObject.
		/// </typeparam>
		/// <returns>
		/// It returns a copy of this ArrayBufferObject, but having a different array item. The returned instance is actually
		/// a <see cref="ArrayBufferObject"/>; if it is desiderable a strongly typed <see cref="ArrayBufferObject"/>, use
		/// <see cref="ConvertItemType"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the array base type of this ArrayBufferObject (<see cref="ArrayBaseType"/>) is different to the one
		/// derived from <typeparamref name="T"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the number of base components of this ArrayBufferObject cannot be mapped into the base components
		/// count derived from <typeparamref name="T"/>.
		/// </exception>
		public ArrayBufferObject<T> ConvertItemType<T>() where T : struct
		{
			ArrayBufferItemType vertexArrayType = ArrayBufferItem.GetArrayType(typeof(T));

			return ((ArrayBufferObject<T>)ConvertItemType(vertexArrayType));
		}

		/// <summary>
		/// Copy this array buffer object to another one, but having a different array item type.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that specify the returned <see cref="ArrayBufferObject"/> item type.
		/// </param>
		/// <returns>
		/// It returns a copy of this ArrayBufferObject, but having a different array item. The returned instance is actually
		/// a <see cref="ArrayBufferObject"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception thrown if the array base type of this ArrayBufferObject (<see cref="ArrayBaseType"/>) is different to the one
		/// derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the number of base components of this ArrayBufferObject cannot be mapped into the base components
		/// count derived from <paramref name="vertexArrayType"/>.
		/// </exception>
		public ArrayBufferObject ConvertItemType(ArrayBufferItemType vertexArrayType)
		{
			if (ArrayBaseType != ArrayBufferItem.GetArrayBaseType(vertexArrayType))
				throw new ArgumentException("base type mismatch", "vertexArrayType");

			uint componentsCount = ItemCount * ArrayBufferItem.GetArrayLength(ArrayType) * ArrayBufferItem.GetArrayRank(ArrayType);
			uint convComponentsCount = ArrayBufferItem.GetArrayLength(vertexArrayType) * ArrayBufferItem.GetArrayRank(vertexArrayType);

			Debug.Assert(componentsCount >= convComponentsCount);
			if ((componentsCount % convComponentsCount) != 0)
				throw new InvalidOperationException("components length incompatibility");

			ArrayBufferObject arrayObject = CreateArrayObject(vertexArrayType, BufferHint);

			// Different item count due different lengths
			arrayObject.Define(componentsCount / convComponentsCount);
			// Memory is copied
			Memory.MemoryCopy(arrayObject.MemoryBuffer.AlignedBuffer, MemoryBuffer.AlignedBuffer, MemoryBuffer.Size);

			return (arrayObject);
		}

		#endregion
	}

	/// <summary>
	/// Stronly typed array buffer object.
	/// </summary>
	/// <typeparam name="T">
	/// A structure that holds the array item data. Typically this type match a <see cref="IVertex"/> or <see cref="IColor"/> implementation,
	/// but it could any value type.
	/// </typeparam>
	public class ArrayBufferObject<T> : ArrayBufferObject where T : struct
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specify the data buffer usage hints.
		/// </param>
		public ArrayBufferObject(Hint hint)
			: base(ArrayBufferItem.GetArrayType(typeof(T)), hint)
		{
			try {
				bool interleaved;

				// Determine basic type information
				SubArrays = DetectSubArrays(typeof (T), out interleaved);
				// The item is represented by 'T'
				ItemSize = (uint) Marshal.SizeOf(typeof (T));
				Interleaved = interleaved;
			} catch {
				// Avoid finalizer assertion failure (don't call dispose since it's virtual)
				GC.SuppressFinalize(this);
				throw;
			}
		}

		#endregion

		#region Array Buffer Data Definition

		/// <summary>
		/// Define this ArrayBufferObject by specifing an array of <typeparamref name="T"/>.
		/// </summary>
		/// <param name="items">
		/// An array that specify the contents of this ArrayBufferObject.
		/// </param>
		public void Define(T[] items)
		{
			if (items == null)
				throw new ArgumentNullException("items");
			if (items.Length == 0)
				throw new ArgumentException("zero items", "items");
			if ((BufferHint != Hint.StaticCpuDraw) && (BufferHint != Hint.DynamicCpuDraw))
				throw new InvalidOperationException(String.Format("conflicting hint {0}", BufferHint));

			// Store item count
			Define((uint)items.Length);
			// Copy the buffer
			Memory.MemoryCopy(MemoryBuffer.AlignedBuffer, items, ItemCount * ItemSize);
		}

		#endregion

		#region Array Buffer Access

		/// <summary>
		/// Accessor to ArrayBufferObject items.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public T this[uint index]
		{
			get
			{
				if ((MemoryBuffer == null) || (MemoryBuffer.AlignedBuffer == IntPtr.Zero))
					throw new InvalidOperationException("not defined");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				return ((T) Marshal.PtrToStructure(new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + (index * ItemSize)), typeof(T)));
			}
			set
			{
				if ((MemoryBuffer == null) || (MemoryBuffer.AlignedBuffer == IntPtr.Zero))
					throw new InvalidOperationException("not defined");
				if (index >= ItemCount)
					throw new ArgumentException("index out of bounds", "index");

				Marshal.StructureToPtr(value, new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + (index * ItemSize)), false);
			}
		}

		#endregion

		#region To Array

		/// <summary>
		/// Convert this array buffer object in a strongly-typed array.
		/// </summary>
		/// <returns></returns>
		public new T[] ToArray()
		{
			T[] array = new T[ItemCount];

			// Copy the buffer
			Memory.MemoryCopy(array, MemoryBuffer.AlignedBuffer, ItemCount * ItemSize);

			return (array);
		}

		#endregion

		#region Array Buffer Mapping

		/// <summary>
		/// Set an item to this mapped BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="value">
		/// A <typeparamref name="T"/> that specify the mapped BufferObject element.
		/// </param>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specify the offset applied to the mapped BufferObject where <paramref name="value"/>
		/// is stored. The offset is expressed in number of items from the beginning of the array buffer object, indeed
		/// dependent on the <typeparamref name="T"/> size in bytes.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this ArrayBufferObject is not mapped (<see cref="BufferObject.IsMapped"/>).
		/// </exception>
		public void MapSet(GraphicsContext ctx, T value, Int64 offset) { MapSet<T>(ctx, value, offset * ItemSize); }

		/// <summary>
		/// Get an element from this mapped BufferObject.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="offset">
		/// A <see cref="Int64"/> that specify the offset applied to the mapped BufferObject. The offset is expressed
		/// in number of items from the beginning of the array buffer object, indeed dependent on the <typeparamref name="T"/>
		/// size in bytes.
		/// </param>
		/// <returns>
		/// It returns a structure of type <typeparamref name="T"/>, read from the mapped BufferObject
		/// </returns>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this ArrayBufferObject is not mapped (<see cref="BufferObject.IsMapped"/>).
		/// </exception>
		public T MapGet(GraphicsContext ctx, Int64 offset) { return (MapGet<T>(ctx, offset * ItemSize)); }

		#endregion

		#region Join Multiple ArrayBufferObject

		/// <summary>
		/// Join a set of compatible buffers.
		/// </summary>
		/// <param name="buffers">
		/// An array of <see cref="ArrayBufferObject"/> instances to be packed sequentially on this ArrayBufferObject.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffers"/> is null or any item in <paramref name="buffers"/> array
		/// is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="buffers"/> length is less than two (minimum number of ArrayBufferObject
		/// to join).
		/// </exception>
		/// <remarks>
		/// <para>
		/// This ArrayBufferObject will store sequentially all the items stored in <paramref name="buffers"/>.
		/// </para>
		/// </remarks>
		public void Join(params ArrayBufferObject<T>[] buffers)
		{
			if (buffers == null)
				throw new ArgumentNullException("buffers");
			if (buffers.Length <= 1)
				throw new ArgumentException("not enought buffers", "buffers");

			// Since T is the same for 'buffers' and 'this', they are compatible for every T, even if
			// T is a complex structure

			// Collect array buffer objects statistics
			uint bufferSize = 0, itemCount = 0;

			for (int i = 0; i < buffers.Length; i++) {
				if (buffers[i] == null)
					throw new ArgumentNullException("buffers[" + i + "]");

				bufferSize += buffers[i].BufferSize;
				itemCount += buffers[i].ItemCount;
			}

			// Allocate the array buffer object
			Allocate(bufferSize);

			// Join buffers into a single one
			bufferSize = 0;
			for (int i = 0; i < buffers.Length; i++) {
				IntPtr src = buffers[i].MemoryBuffer.AlignedBuffer;
				IntPtr dst = new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + bufferSize);

				// Copy 'i'th buffer content
				Memory.MemoryCopy(dst, src, buffers[i].BufferSize);
				// Next buffer offset
				bufferSize += buffers[i].BufferSize;
			}

			// Item count is the sum of the items found in 'buffers'
			ItemCount = itemCount;
		}

		#endregion
	}

	/// <summary>
	/// An packed or interleaved set of buffer objects.
	/// </summary>
	/// <remarks>
	/// <para>
	/// 
	/// </para>
	/// </remarks>
	public abstract class ComplexArrayBufferObject : ArrayBufferObject
	{
		#region Constructors

		/// <summary>
		/// Construct an ArrayBufferObject.
		/// </summary>
		/// <param name="hint">
		/// An <see cref="BufferObject.Hint"/> that specify the data buffer usage hints.
		/// </param>
		public ComplexArrayBufferObject(Hint hint)
			: base(ArrayBufferItemType.Complex, hint)
		{
			ItemSize = 0;
			ItemCount = 0;
		}

		#endregion

		#region Packing & Interleaving

		/// <summary>
		/// Pack a set of buffers.
		/// </summary>
		/// <param name="buffers">
		/// An array of <see cref="ArrayBufferObject"/> instances to be packed sequentially on this ArrayBufferObject.
		/// </param>
		/// <remarks>
		/// Each buffer specified in <paramref name="buffers"/> will be copied into this ArrayBufferObject as sub-array.
		/// The order of sub-arrays is defined by the order of the ArrayBufferObject instances in <paramref name="buffers"/>.
		/// </remarks>
		public void Pack(params ArrayBufferObject[] buffers)
		{
			if (buffers == null)
				throw new ArgumentNullException("buffers");
			if (buffers.Length <= 1)
				throw new ArgumentException("not enought buffers", "buffers");

			// Collect buffer statistics
			uint bufferOffset = 0;
			uint bufferSize = 0, bufferItemsCount = buffers[0].ItemCount, bufferItemSize = 0;

			for (int i = 0; i < buffers.Length; i++) {
				if (buffers[i] == null)
					throw new ArgumentNullException("buffers["+i+"]");
				if (buffers[i].ItemCount != bufferItemsCount)
					throw new ArgumentException("items count mismatch", "buffers["+i+"]");
				if (buffers[i].Interleaved)
					throw new ArgumentException("interleaved buffer", "buffers["+i+"]");

				// Determine total buffer size
				bufferSize += buffers[i].BufferSize;
				// Determine total item size (not really useful)
				bufferItemSize += buffers[i].ItemSize;
			}

			// Define packed buffer layout
			List<SubArrayBuffer> packedArrays = new List<SubArrayBuffer>();

			for (int i = 0; i < buffers.Length; i++) {
				SubArrayBuffer sourceArray = buffers[i].GetSubArrayInfo(0);
				ArrayBufferItemAttribute arrayBufferAttrs = new ArrayBufferItemAttribute(sourceArray.BaseType, sourceArray.ArrayLength);
				SubArrayBuffer packedArray = new SubArrayBuffer(arrayBufferAttrs);

				packedArray.ArrayOffset = new IntPtr(bufferOffset);
				packedArrays.Add(packedArray);

				bufferOffset += buffers[i].BufferSize;
			}

			// Pack data
			Allocate(bufferSize);

			bufferSize = 0;
			for (int i = 0; i < buffers.Length; i++) {
				IntPtr src = new IntPtr(buffers[i].MemoryBuffer.AlignedBuffer.ToInt64());
				IntPtr dst = new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + bufferSize);

				Memory.MemoryCopy(dst, src, buffers[i].BufferSize);

				bufferSize += buffers[i].BufferSize;
			}

			// Define this packed buffer
			SubArrays = packedArrays;
			ItemCount = bufferItemsCount;
			ItemSize = bufferItemSize;
			Interleaved = false;
		}

		/// <summary>
		/// Interleave a set of buffers.
		/// </summary>
		/// <param name="buffers">
		/// A set of <see cref="ArrayBufferObject"/> which has to be interleaved with each other.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="buffers"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="buffers"/> length is less than two.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if one of the items in <paramref name="buffers"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if one of the items in <paramref name="buffers"/> is already inteleaved.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if not all the items in <paramref name="buffers"/> has the same items count.
		/// </exception>
		public void Interleave(params ArrayBufferObject[] buffers)
		{
			if (buffers == null)
				throw new ArgumentNullException("buffers");
			if (buffers.Length <= 1)
				throw new ArgumentException("not enought buffers", "buffers");

			// Collect buffer statistics
			uint itemsCount = buffers[0].ItemCount;
			uint itemSize = 0;
			uint[] itemOffset = new uint[buffers.Length];

			for (int i = 0; i < buffers.Length; i++) {
				if (buffers[i] == null)
					throw new ArgumentNullException("buffers["+i+"]");
				if (buffers[i].Interleaved)
					throw new ArgumentException("interleaved buffer", "buffers["+i+"]");
				if (buffers[i].ItemCount != itemsCount)
					throw new ArgumentException("items count mismatch", "buffers["+i+"]");

				// Determine interleaved field offset
				itemOffset[i] = itemSize;
				// Collect item size
				itemSize += buffers[i].ItemSize;
			}

			// Define interleaved buffer layout
			List<SubArrayBuffer> interleavedArrays = new List<SubArrayBuffer>();

			for (int i = 0; i < buffers.Length; i++) {
				SubArrayBuffer sourceArray = buffers[i].GetSubArrayInfo(0);
				ArrayBufferItemAttribute arrayBufferAttrs = new ArrayBufferItemAttribute(sourceArray.BaseType, sourceArray.ArrayLength);
				SubArrayBuffer interleavedArray = new SubArrayBuffer(arrayBufferAttrs);

				interleavedArray.ArrayOffset = new IntPtr(itemOffset[i]);
				interleavedArray.ArrayStride = itemSize;

				interleavedArrays.Add(interleavedArray);
			}

			// Interleave data
			Allocate(itemSize * itemsCount);

			for (int i = 0; i < itemsCount; i++) {
				for (int j = 0; j < buffers.Length; j++) {
					IntPtr src = new IntPtr(buffers[j].MemoryBuffer.AlignedBuffer.ToInt64() + (buffers[j].ItemSize * i));
					IntPtr dst = new IntPtr(MemoryBuffer.AlignedBuffer.ToInt64() + (i * itemSize) + interleavedArrays[j].ArrayOffset.ToInt64());

					Memory.MemoryCopy(dst, src, buffers[j].ItemSize);
				}
			}

			// Define this interleaved buffer
			SubArrays = interleavedArrays;
			ItemCount = itemsCount;
			Interleaved = true;
		}

		#endregion
	}
}