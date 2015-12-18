
// Copyright (C) 2011-2013 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// A collection of vertex arrays and vertex indices.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Vertex arrays are collected by semantic or name. The array buffers corresponding to vertex attributes
	/// can have any memory layout (offset and interleaving).
	/// 
	/// </para>
	/// <para>
	/// Vertex arrays are rendered using a collection of vertex elements. Each vertex element issue a rendering
	/// command, referencing the vertex array data directly or using a deferencing index.
	/// </para>
	/// <para>
	/// A vertex array can have associated a shader program, and an render state set. Those two objects defines
	/// the rendering result of the collected arrays.
	/// </para>
	/// </remarks>
	public class VertexArrayObject : GraphicsResource
	{
		#region Vertex Array Definition

		/// <summary>
		/// Get whether this VertexArrayObject has defined a vertex array by semantic name.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the vertex array semantic.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this VertexArrayObject has defined the
		/// vertex array having the semantic equals to <paramref name="semantic"/>.
		/// </returns>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="semantic"/> is null or empty.
		/// </exception>
		public bool HasArray(string semantic)
		{
			if (String.IsNullOrEmpty(semantic))
				throw new ArgumentException("invalid", "semantic");

			return (mVertexArrays.ContainsKey(String.Format("##Semantic.{0}", semantic)));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="semantic"></param>
		/// <returns></returns>
		public ArrayBufferObject GetArray(string semantic)
		{
			if (semantic == null)
				throw new ArgumentNullException("semantic");

			VertexArray vertexArray;

			if (mVertexArrays.TryGetValue(String.Format("##Semantic.{0}", semantic), out vertexArray) == false)
				throw new InvalidOperationException("no array " + semantic);
			
			Debug.Assert(vertexArray != null);

			return (vertexArray.Array);
		}

		/// <summary>
		/// Set an array buffer object to this array.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the array semantic. Typically this value is a string field
		/// of <see cref="VertexArraySemantic"/>, but it could be any string value.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ArrayBufferObject"/> that specifies the contents of the array.
		/// </param>
		public void SetArray(string semantic, ArrayBufferObject bufferObject)
		{
			SetArray(semantic, "##Semantic", bufferObject, 0);
		}

		/// <summary>
		/// Set an array buffer object sub-array to this array.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the array semantic. Typically this value is a string field
		/// of <see cref="VertexArraySemantic"/>, but it could be any string value.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ArrayBufferObject"/> that specifies the contents of the array.
		/// </param>
		/// <param name="fieldIndex">
		/// A <see cref="System.UInt32"/> that specifies the <paramref name="bufferObject"/> sub-array index.
		/// </param>
		public void SetArray(string semantic, ArrayBufferObject bufferObject, uint fieldIndex)
		{
			SetArray(semantic, "##Semantic", bufferObject, fieldIndex);
		}

		/// <summary>
		/// Set an array buffer object to this array.
		/// </summary>
		/// <param name="inputName">
		/// A <see cref="System.String"/> that specifies the name of the array binding.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="System.String"/> that specifies the name of the array binding block. It can be null
		/// for indicating the use of the default group (global scope).
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ArrayBufferObject"/> that specifies the contents of the array.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="inputName"/> is null or is not a valid input name.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bufferObject"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="bufferObject"/> is an interleaved buffer object or it has no items
		/// defined.
		/// </exception>
		public void SetArray(string inputName, string blockName, ArrayBufferObject bufferObject)
		{
			SetArray(inputName, blockName, bufferObject, 0);
		}

		/// <summary>
		/// Set an array buffer object sub-array to this array.
		/// </summary>
		/// <param name="inputName">
		/// A <see cref="System.String"/> that specifies the name of the array binding.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="System.String"/> that specifies the name of the array binding block.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ArrayBufferObject"/> that specifies the contents of the array.
		/// </param>
		/// <param name="fieldIndex">
		/// A <see cref="System.UInt32"/> that specifies the <paramref name="bufferObject"/> sub-array index.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="inputName"/> is null or is not a valid input name.
		/// </exception>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="bufferObject"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="bufferObject"/> is not an interleaved buffer object.
		/// </exception>
		public void SetArray(string inputName, string blockName, ArrayBufferObject bufferObject, uint fieldIndex)
		{
			if (String.IsNullOrEmpty(inputName))
				throw new ArgumentException("invalid name", "inputName");
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");
			if (bufferObject.ItemCount == 0)
				throw new ArgumentException("zero items", "bufferObject");
			if (fieldIndex >= bufferObject.SubArrayCount)
				throw new ArgumentException("out of bounds", "fieldIndex");

			// Map buffer object with input name
			mVertexArrays[inputName] = new VertexArray(bufferObject);
			mVertexArrays[inputName].Array.IncRef();
			// Map buffer object with input name including block name also
			if (blockName != null) {
				mVertexArrays[String.Format("{0}.{1}", blockName, inputName)] = mVertexArrays[inputName];
				mVertexArrays[String.Format("{0}.{1}", blockName, inputName)].Array.IncRef();
			}

			// Set sub-array!
			mVertexArrays[inputName].SubArray = fieldIndex;

			// Compute the actual vertex array length
			UpdateVertexArrayLength();
		}

		/// <summary>
		/// Get an array buffer object collected by this vertex array object.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="System.String"/> that specify the attribute name.
		/// </param>
		/// <returns>
		/// It returns the array corresponding to the semantic <paramref name="semantic"/>.
		/// </returns>
		private VertexArray GetVertexArray(string semantic)
		{
			return (GetVertexArray(semantic, "##Semantic"));
		}

		/// <summary>
		/// Get an array buffer object collected by this vertex array object.
		/// </summary>
		/// <param name="attributeName">
		/// A <see cref="System.String"/> that specify the attribute name.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="System.String"/> that specify the input block declaring <paramref name="attributeName"/>.
		/// </param>
		/// <returns>
		/// It returns the array corresponding to the attribute having the name <paramref name="attributeName"/>.
		/// </returns>
		private VertexArray GetVertexArray(string attributeName, string blockName)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid attribute name", "attributeName");

			VertexArray vertexArray;
			
			if (blockName != null)
				attributeName = String.Format("{0}.{1}", blockName, attributeName);

			if (mVertexArrays.TryGetValue(attributeName, out vertexArray) == false)
				return (null);

			return (vertexArray);
		}

		/// <summary>
		/// The the minimum length of the arrays compositing this vertex array.
		/// </summary>
		private void UpdateVertexArrayLength()
		{
			uint minLength = UInt32.MaxValue;

			foreach (KeyValuePair<string, VertexArray> pair in mVertexArrays)
				minLength = Math.Min(minLength, pair.Value.Array.ItemCount);

			mVertexArrayLength = minLength;
		}

		private void CheckMultiDrawAvailability()
		{
			
		}

		/// <summary>
		/// Validate this vertex array.
		/// </summary>
		/// <returns></returns>
		[Conditional("DEBUG")]
		private void Validate()
		{
			if (mVertexArrays.Count == 0)
				throw new InvalidOperationException("no array");
			//if (Elements.Count == 0)
			//	throw new InvalidOperationException("no element array");
		}

		/// <summary>
		/// A vertex array.
		/// </summary>
		protected class VertexArray
		{
			/// <summary>
			/// Construct an VertexArray.
			/// </summary>
			/// <param name="bufferObject">
			/// A <see cref="ArrayBufferObject"/> which defines a vertex array data.
			/// </param>
			public VertexArray(ArrayBufferObject bufferObject)
			{
				if (bufferObject == null)
					throw new ArgumentNullException("bufferObject");
				Array = bufferObject;
			}

			/// <summary>
			/// The vertex array buffer object.
			/// </summary>
			public readonly ArrayBufferObject Array;

			/// <summary>
			/// The vertex array sub-buffer index.
			/// </summary>
			public uint SubArray
			{
				get { return (mSubArray); }
				set
				{
					if (value >= Array.SubArrayCount)
						throw new InvalidOperationException("sub-array index out of bounds");
					mSubArray = value;
				}
			}

			/// <summary>
			/// The vertex array sub-buffer index.
			/// </summary>
			private uint mSubArray;
		}

		/// <summary>
		/// Arrays defined by this vertex array object.
		/// </summary>
		protected readonly Dictionary<string, VertexArray> mVertexArrays = new Dictionary<string, VertexArray>();

		/// <summary>
		/// Number of items of the collected buffer objects.
		/// </summary>
		private uint mVertexArrayLength;

		#endregion

		#region Vertex Elements Definition

		/// <summary>
		/// Specify the entire array to be drawn sequentially.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		public void SetElementArray(PrimitiveType mode)
		{
			// Store element array (entire buffer)
			Elements.Add(new AttributeElements(mode));

			CheckMultiDrawAvailability();
		}

		/// <summary>
		/// Set a buffer object which specifies the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="Primitive"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBufferObject"/> that specifies a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		public void SetElementArray(PrimitiveType mode, ElementBufferObject bufferObject)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");
			if (bufferObject.BufferType != BufferTargetARB.ElementArrayBuffer)
				throw new ArgumentException("not an ElementBufferObject", "bufferObject");

			// Store element array
			Elements.Add(new AttributeElements(mode, bufferObject));
		}

		/// <summary>
		/// Set a buffer object which specifies the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBufferObject"/> that specifies a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		public void SetElementArray(PrimitiveType mode, ElementBufferObject bufferObject, uint offset, uint count)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");
			if (bufferObject.BufferType != BufferTargetARB.ElementArrayBuffer)
				throw new ArgumentException("not an ElementBufferObject", "bufferObject");

			// Store element array
			Elements.Add(new AttributeElements(mode, bufferObject, offset, count));
		}

		/// <summary>
		/// A collection of indices reference input arrays.
		/// </summary>
		protected internal class AttributeElements
		{
			/// <summary>
			/// Specify how all elements shall be drawn.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			public AttributeElements(PrimitiveType mode) : this(mode, null, 0, 0) { }

			/// <summary>
			/// Specify which elements shall be drawn, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="offset">
			/// A <see cref="System.UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="System.UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public AttributeElements(PrimitiveType mode, uint offset, uint count) : this(mode, null, offset, count) { }

			/// <summary>
			/// Specify which elements shall be drawn by indexing them.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices. If it null, no indices are
			/// used for drawing; instead, all array elements are drawns, starting from the first one. If it is not null, all
			/// indices are drawn starting from the first one.
			/// </param>
			public AttributeElements(PrimitiveType mode, ElementBufferObject indices) : this(mode, indices, 0, 0) { }

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices. If it null, no indices are
			/// used for drawing; instead, <paramref name="count"/> contiguos array elements are drawns, starting from
			/// <paramref name="offset"/>. If it is not null, <paramref name="count"/> indices are drawn starting from
			/// <paramref name="offset"/>.
			/// </param>
			/// <param name="offset">
			/// A <see cref="System.UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="System.UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public AttributeElements(PrimitiveType mode, ElementBufferObject indices, uint offset, uint count)
			{
				ElementsMode = mode;
				ElementOffset = offset;
				ElementCount = count;
				ArrayIndices = indices;

				if (ArrayIndices != null)
					ArrayIndices.IncRef();
			}

			/// <summary>
			/// The primitive used for interpreting the sequence of the array elements.
			/// </summary>
			public readonly PrimitiveType ElementsMode;

			/// <summary>
			/// The offset for sending element for drawing.
			/// </summary>
			/// <remarks>
			/// <para>
			/// If <see cref="ArrayIndices"/> is null, this member indicates the first index of the array item
			/// to draw, otherwise it indicates the offset (in basic machine unit) of the first element of
			/// <see cref="ArrayIndices"/> to draw.
			/// </para>
			/// </remarks>
			public readonly uint ElementOffset;

			/// <summary>
			/// The number of array elements to draw.
			/// </summary>
			/// <remarks>
			/// <para>
			/// If <see cref="ArrayIndices"/> is null, this member indicates how many array elements are drawn, otherwise
			/// it indicates how many array indices are drawn.
			/// </para>
			/// <para>
			/// In the case this field equals to 0, it means that all array elements shall be drawn.
			/// </para>
			/// </remarks>
			public readonly uint ElementCount;

			/// <summary>
			/// An integral buffer that specify vertices by they index.
			/// </summary>
			public readonly ElementBufferObject ArrayIndices;
		}

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		protected internal readonly List<AttributeElements>  Elements = new List<AttributeElements>();

		#endregion

		#region Normal Generation

		/// <summary>
		/// Generate normal array for this vertex array.
		/// </summary>
		/// <remarks>
		/// <para>
		/// Normal array is required for light shading, and it's computable from the position array information. The position array
		/// information shall be defined, and the array shall have the array type <see cref="VertexArrayType.Vec3"/>.
		/// </para>
		/// <para>
		/// This routine performs different computation in the case arrays are dereferenced by an element buffer.
		/// </para>
		/// </remarks>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if this vertex array defines multiple vertices element indices, or the only element buffer
		/// is not a <see cref="Primitive.Triangle"/> primitive.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the position array is not defined by this vertex array, or it has the wrong array type.
		/// </exception>
		public void GenerateNormals()
		{
			if (Elements.Count != 1)
				throw new NotSupportedException("multiple elements");
			if (Elements[0].ElementsMode != PrimitiveType.Triangles)
				throw new NotSupportedException("not triangles");

			VertexArray positionArray = GetVertexArray(VertexArraySemantic.Position);
			if (positionArray == null)
				throw new InvalidOperationException("no position semantic");

			ArrayBufferObject positionBuffer = positionArray.Array;

			if (positionBuffer.ArrayType == ArrayBufferItemType.Float3) {
				// General normal buffer for this vertex array
				ArrayBufferObject<Vertex3f> normalBuffer;

				if (Elements[0].ArrayIndices == null)
					normalBuffer = GenerateNormals(positionBuffer);
				else
					normalBuffer = GenerateNormals(positionBuffer, Elements[0].ArrayIndices);

				SetArray(VertexArraySemantic.Normal, normalBuffer);
			} else if (positionBuffer.ArrayType == ArrayBufferItemType.Float2) {
				// General normal buffer for this vertex array
				ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObject.Hint.StaticCpuDraw);

				normalBuffer.Define(positionBuffer.ItemCount);
				// Reset normal buffer (cumulate normals)
				for (uint i = 0; i < positionBuffer.ItemCount; i++)
					normalBuffer[i] = Vertex3f.UnitZ;

				SetArray(VertexArraySemantic.Normal, normalBuffer);
			}
		}

		/// <summary>
		/// Generate a normal array from a plain position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is equals for every vertex belonging to the same triangle (triangle flat shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray)
		{
			if (positionArray == null)
				throw new ArgumentNullException("positionArray");
			if (positionArray.ArrayType != ArrayBufferItemType.Float3)
				throw new ArgumentException("invalid array type", "positionArray");

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObject.Hint.StaticCpuDraw);

			try {
				normalBuffer.Define(positionArray.ItemCount);

				for (uint i = 0; i < positionArray.ItemCount; i += 3) {
					Vertex3f p0 = positionArray.GetData<Vertex3f>(i + 0);
					Vertex3f p1 = positionArray.GetData<Vertex3f>(i + 1);
					Vertex3f p2 = positionArray.GetData<Vertex3f>(i + 2);

					Vertex3f normal = (p1 - p0) ^ (p2 - p0);

					normal.Normalize();

					normalBuffer[i + 0] = normal;
					normalBuffer[i + 1] = normal;
					normalBuffer[i + 2] = normal;
				}

				return (normalBuffer);

			} catch {
				normalBuffer.Dispose();
				throw;
			}
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="ElementBufferObject"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, ElementBufferObject positionIndices)
		{
			return (GenerateNormals(positionArray, positionIndices, 1));
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="ElementBufferObject"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="System.UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, ElementBufferObject positionIndices, uint positionIndicesStride)
		{
			return (GenerateNormals(positionArray, positionIndices, 0, positionIndicesStride));
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="ElementBufferObject"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesOffset">
		/// A <see cref="System.UInt32"/> that specify the offset of the considered <paramref name="positionIndices"/> items.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="System.UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, ElementBufferObject positionIndices, uint positionIndicesOffset, uint positionIndicesStride)
		{
			if (positionArray == null)
				throw new ArgumentNullException("positionArray");
			if (positionIndices == null)
				throw new ArgumentNullException("positionIndices");
			if (positionArray.ArrayType != ArrayBufferItemType.Float3)
				throw new ArgumentException("invalid array type", "positionArray");
			if (positionIndicesStride == 0)
				throw new ArgumentException("invalid", "positionIndicesStride");

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObject.Hint.StaticCpuDraw);

			try {
				normalBuffer.Define(positionArray.ItemCount);

				// Reset normal buffer (cumulate normals)
				for (uint i = 0; i < positionArray.ItemCount; i++)
					normalBuffer[i] = Vertex3f.Zero;

				for (uint i = 0; i < positionIndices.ItemCount; i += 3 * positionIndicesStride) {
					uint p0Index = positionIndices[positionIndicesOffset + i + 0 * positionIndicesStride];
					uint p1Index = positionIndices[positionIndicesOffset + i + 1 * positionIndicesStride];
					uint p2Index = positionIndices[positionIndicesOffset + i + 2 * positionIndicesStride];

					Vertex3f p0 = positionArray.GetData<Vertex3f>(p0Index);
					Vertex3f p1 = positionArray.GetData<Vertex3f>(p1Index);
					Vertex3f p2 = positionArray.GetData<Vertex3f>(p2Index);

					Vertex3f normal = (p1 - p0) ^ (p2 - p0);

					if (Math.Abs(normal.Module()) >= Single.Epsilon)
						normal.Normalize();

					normalBuffer[p0Index] = normalBuffer[p0Index] + normal;
					normalBuffer[p1Index] = normalBuffer[p1Index] + normal;
					normalBuffer[p2Index] = normalBuffer[p2Index] + normal;
				}

				// Normalize normal buffer
				for (uint i = 0; i < positionArray.ItemCount; i++) {
					Vertex3f normal = normalBuffer[i];
					if (Math.Abs(normal.Module()) >= Single.Epsilon)
						normal.Normalize();
					normalBuffer[i] = normal;
				}

				return (normalBuffer);

			} catch {
				normalBuffer.Dispose();
				throw;
			}
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="System.UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, uint[] positionIndices)
		{
			return (GenerateNormals(positionArray, positionIndices, 1));
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="System.UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="System.UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, uint[] positionIndices, uint positionIndicesStride)
		{
			return (GenerateNormals(positionArray, positionIndices, 0, positionIndicesStride));
		}

		/// <summary>
		/// Generate a normal array from a indexed position array.
		/// </summary>
		/// <param name="positionArray">
		/// A <see cref="ArrayBufferObject"/> that specify the position array, from which normals are computed.
		/// </param>
		/// <param name="positionIndices">
		/// A <see cref="System.UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesOffset">
		/// A <see cref="System.UInt32"/> that specify the offset of the considered <paramref name="positionIndices"/> items.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="System.UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
		/// </param>
		/// <returns>
		/// It returns a <see cref="ArrayBufferObject{Vertex3f}"/> that is the normal array derived from <paramref name="positionArray"/>. Each
		/// position vertex has associated a normal vector, that is shared to every vertex referenced with the same index (triangle smooth shading).
		/// </returns>
		public static ArrayBufferObject<Vertex3f> GenerateNormals(ArrayBufferObject positionArray, uint[] positionIndices, uint positionIndicesOffset, uint positionIndicesStride)
		{
			if (positionArray == null)
				throw new ArgumentNullException("positionArray");
			if (positionIndices == null)
				throw new ArgumentNullException("positionIndices");
			if (positionArray.ArrayType != ArrayBufferItemType.Float3)
				throw new ArgumentException("invalid array type", "positionArray");
			if (positionIndicesStride == 0)
				throw new ArgumentException("invalid", "positionIndicesStride");

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObject.Hint.StaticCpuDraw);

			try {
				normalBuffer.Define(positionArray.ItemCount);

				// Reset normal buffer (cumulate normals)
				for (uint i = 0; i < positionArray.ItemCount; i++)
					normalBuffer[i] = Vertex3f.Zero;

				for (uint i = 0; i < positionIndices.Length; i += 3 * positionIndicesStride) {
					uint p0Index = positionIndices[positionIndicesOffset + i + 0 * positionIndicesStride];
					uint p1Index = positionIndices[positionIndicesOffset + i + 1 * positionIndicesStride];
					uint p2Index = positionIndices[positionIndicesOffset + i + 2 * positionIndicesStride];

					Vertex3f p0 = positionArray.GetData<Vertex3f>(p0Index);
					Vertex3f p1 = positionArray.GetData<Vertex3f>(p1Index);
					Vertex3f p2 = positionArray.GetData<Vertex3f>(p2Index);

					Vertex3f normal = (p1 - p0) ^ (p2 - p0);

					if (Math.Abs(normal.Module()) >= Single.Epsilon)
						normal.Normalize();

					normalBuffer[p0Index] = normalBuffer[p0Index] + normal;
					normalBuffer[p1Index] = normalBuffer[p1Index] + normal;
					normalBuffer[p2Index] = normalBuffer[p2Index] + normal;
				}

				// Normalize normal buffer
				for (uint i = 0; i < positionArray.ItemCount; i++) {
					Vertex3f normal = normalBuffer[i];
					if (Math.Abs(normal.Module()) >= Single.Epsilon)
						normal.Normalize();
					normalBuffer[i] = normal;
				}

				return (normalBuffer);

			} catch {
				normalBuffer.Dispose();
				throw;
			}
		}

		#endregion

		#region Vertex Array Application

		/// <summary>
		/// Render this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing this vertex array.
		/// </param>
		public virtual void DrawVertexArray(GraphicsContext ctx, ShaderProgram shader)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (shader == null)
				throw new InvalidOperationException("no shader");
			if (shader.IsLinked == false)
				throw new InvalidOperationException("shader not linked");
			//if (!Exists(ctx))
			//	throw new InvalidOperationException("not existing");		XXX
			if (Elements.Count == 0)
				throw new InvalidOperationException("no elements defined");

			// Set vertex arrays
			SetShaderProgramAttributes(ctx, shader);
			
			// Issue rendering using shader
			foreach (AttributeElements attributeElements in Elements) {
				
				// Uses shader
				shader.Bind(ctx);
				
				if (mFeedbackBuffer != null)
					mFeedbackBuffer.Begin(ctx, attributeElements.ElementsMode);
				
				RenderAttributeElement(ctx, attributeElements);
				
				if (mFeedbackBuffer != null)
					mFeedbackBuffer.End(ctx);
			}
				
		}

		/// <summary>
		/// Bind the vertex arrays to the shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> on which the shader program is bound.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> on which the vertex arrays shall be bound.
		/// </param>
		protected void SetShaderProgramAttributes(GraphicsContext ctx, ShaderProgram shaderProgram)
		{	
			// Vertex array object supported?
			if (mSupportVertexArray) {
				if (mVertexArrayDirty)
					CreateName(ctx);	// How to rename an object??? XXX

				// Avoid to re-bind vertex array
				int currentBinding;

				Gl.Get(Gl.VERTEX_ARRAY_BINDING, out currentBinding);

				if (ObjectName == currentBinding)
					return;
				
				// Bind this vertex array
				Gl.BindVertexArray(ObjectName);

				if (mVertexArrayDirty == false)
					return;		// Vertex attributes configuration already defined
			}

			foreach (string inputName in shaderProgram.ActiveAttributes) {
				VertexArray shaderVertexArray;

				// Get the buffer object containing data for vertex shader attribute
				if ((shaderVertexArray = GetVertexArray(inputName, null)) == null) {

					// Failed, try using attribute semantic, if any

					string semantic = shaderProgram.GetAttributeSemantic(inputName);

					if (semantic != null)
						shaderVertexArray = GetVertexArray(semantic);
				}

				if (shaderVertexArray == null)
					continue;

				shaderVertexArray.Array.Bind(ctx);

				// A single array buffer object could contains multiple sub-array
				ArrayBufferObject.SubArrayBuffer subArrayBuffer = shaderVertexArray.Array.GetSubArrayInfo(shaderVertexArray.SubArray);
				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(inputName);

				// Bind varying attribute to currently bound buffer object
				switch (GetArrayBaseType(attributeBinding.Type)) {
					case VertexBaseType.Float:
						Gl.VertexAttribPointer(
							attributeBinding.Location,
							(int) subArrayBuffer.ArrayLength, (int) subArrayBuffer.BaseType, subArrayBuffer.Normalized,
							(int) subArrayBuffer.ArrayStride, subArrayBuffer.ArrayOffset.ToInt32()
							);
						break;
					case VertexBaseType.Int:
					case VertexBaseType.UInt:
						Gl.VertexAttribIPointer(
							attributeBinding.Location,
							(int) subArrayBuffer.ArrayLength, (int) subArrayBuffer.BaseType,
							(int) subArrayBuffer.ArrayStride, subArrayBuffer.ArrayOffset
							);
						break;
					case VertexBaseType.Double:
						Gl.VertexAttribLPointer(
							attributeBinding.Location,
							(int) subArrayBuffer.ArrayLength, (int) subArrayBuffer.BaseType,
							(int) subArrayBuffer.ArrayStride, subArrayBuffer.ArrayOffset
							);
						break;
				}
				
				// Enable vertex attribute
				Gl.EnableVertexAttribArray(attributeBinding.Location);
			}

			// Next time do not set inputs
			mVertexArrayDirty = false;
		}

		/// <summary>
		/// Renders the attribute elements.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="attributeElement">
		/// Attribute elements to be rendered.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		protected void RenderAttributeElement(GraphicsContext ctx, AttributeElements attributeElement)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (attributeElement == null)
				throw new ArgumentNullException("attributeElement");

			ElementBufferObject elementIndices = attributeElement.ArrayIndices;

			if (elementIndices == null) {
				uint count = (attributeElement.ElementCount == 0) ? mVertexArrayLength : attributeElement.ElementCount;

				Debug.Assert(count - attributeElement.ElementOffset <= mVertexArrayLength, "element array out of bounds");
			
				//if (mFeedbackBuffer != null)
				//	mFeedbackBuffer.Begin(ctx, attributeElement.ElementsMode);
				
				// Draw vertex array sequentially
				Gl.DrawArrays(attributeElement.ElementsMode, (int)attributeElement.ElementOffset, (int)count);
			
				//if (mFeedbackBuffer != null)
				//	mFeedbackBuffer.End(ctx);
			} else {
				uint count = (attributeElement.ElementCount == 0) ? elementIndices.ItemCount : attributeElement.ElementCount;

				Debug.Assert(count - attributeElement.ElementOffset <= elementIndices.ItemCount, "element indices array out of bounds");

				// Element array must be bound
				elementIndices.Bind(ctx);
				// Enable restart primitive?
				if (elementIndices.RestartIndexEnabled)
					PrimitiveRestart.EnablePrimitiveRestart(ctx, elementIndices.ItemType);
				// Draw vertex arrays by indices
				Gl.DrawElements(attributeElement.ElementsMode, (int)count, elementIndices.ItemType, (int)attributeElement.ElementOffset);
				// Keep robust the restart_primitive state
				if (elementIndices.RestartIndexEnabled)
					PrimitiveRestart.DisablePrimitiveRestart(ctx);
			}
		}
	
		/// <summary>
		/// Get the array components base type of the vertex array buffer item.
		/// </summary>
		/// <param name="vertexArrayType">
		/// A <see cref="ArrayBufferItemType"/> that describe the vertex array buffer item.
		/// </param>
		/// <returns>
		/// It returns a <see cref="VertexBaseType"/> indicating  the type of the components of
		/// the vertex array buffer item.
		/// </returns>
		private static VertexBaseType GetArrayBaseType(ShaderAttributeType shaderAttributeType)
		{
			switch (shaderAttributeType) {
				case ShaderAttributeType.Float:
				case ShaderAttributeType.Vec2:
				case ShaderAttributeType.Vec3:
				case ShaderAttributeType.Vec4:
				case ShaderAttributeType.Mat2x2:
				case ShaderAttributeType.Mat3x3:
				case ShaderAttributeType.Mat4x4:
				case ShaderAttributeType.Mat2x3:
				case ShaderAttributeType.Mat2x4:
				case ShaderAttributeType.Mat3x2:
				case ShaderAttributeType.Mat3x4:
				case ShaderAttributeType.Mat4x2:
				case ShaderAttributeType.Mat4x3:
					return (VertexBaseType.Float);
				case ShaderAttributeType.Int:
				case ShaderAttributeType.IntVec2:
				case ShaderAttributeType.IntVec3:
				case ShaderAttributeType.IntVec4:
					return (VertexBaseType.Int);
				case ShaderAttributeType.UInt:
				case ShaderAttributeType.UIntVec2:
				case ShaderAttributeType.UIntVec3:
				case ShaderAttributeType.UIntVec4:
					return (VertexBaseType.UInt);
				case ShaderAttributeType.Double:
				case ShaderAttributeType.DoubleVec2:
				case ShaderAttributeType.DoubleVec3:
				case ShaderAttributeType.DoubleVec4:
				case ShaderAttributeType.DoubleMat2x2:
				case ShaderAttributeType.DoubleMat3x3:
				case ShaderAttributeType.DoubleMat4x4:
				case ShaderAttributeType.DoubleMat2x3:
				case ShaderAttributeType.DoubleMat2x4:
				case ShaderAttributeType.DoubleMat3x2:
				case ShaderAttributeType.DoubleMat3x4:
				case ShaderAttributeType.DoubleMat4x2:
				case ShaderAttributeType.DoubleMat4x3:
					return (VertexBaseType.Double);
				default:
					throw new ArgumentException(String.Format("unrecognized shader attribute type {0}", shaderAttributeType));
			}
		}
	
		/// <summary>
		/// Flag indicating whether the vertex array is dirty due buffer object changes.
		/// </summary>
		private bool mVertexArrayDirty = true;

		#endregion
	
		#region Transform Feedback
		
		public void SetTransformFeedback(FeedbackBufferObject feedbackObject)
		{
			if (mFeedbackBuffer != null)
				mFeedbackBuffer.DecRef();
		
			mFeedbackBuffer = feedbackObject;
		
			if (mFeedbackBuffer != null)
				mFeedbackBuffer.IncRef();
		}
	
		public void SetSymmetricTransformFeedback()
		{
			
		}
	
		private FeedbackBufferObject mFeedbackBuffer;
		
		#endregion

		#region RenderResource Overrides

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		internal static readonly Guid VertexArrayObjectClass = new Guid("821E9AC8-6118-4543-B561-7C85BB998287");

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		public override Guid ObjectClass { get { return (VertexArrayObjectClass); } }

		/// <summary>
		/// Determine whether this BufferObject really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this BufferObject exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this BufferObject (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return ((mSupportVertexArray != true) || (Gl.IsVertexArray(ObjectName)));
		}

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this RenderResource implementation requires a name
		/// generation on creation. In the case this routine returns true, the routine <see cref="CreateName"/>
		/// will be called (and it must be overriden). In  the case this routine returns false, the routine
		/// <see cref="CreateName"/> won't be called (and indeed it is not necessary to override it) and a
		/// name is generated automatically in a context-independent manner.
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			return (ctx.Caps.GlExtensions.VertexArrayObject_ARB);
		}

		/// <summary>
		/// Create a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this BufferObject.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Determine vertex array support
			mSupportVertexArray = true;

			return (Gl.GenVertexArray());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			if (mSupportVertexArray) {
				// Delete buffer object
				Gl.DeleteVertexArrays(name);
			}
		}

		/// <summary>
		/// Actually create this RenderResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			// Validate vertex array object
			Validate();

			// Create vertex arrays
			foreach (VertexArray inputArray in mVertexArrays.Values) {
				if (inputArray.Array.Exists(ctx) == false)
					inputArray.Array.Create(ctx);
			}
			// Create element array
			foreach (AttributeElements attributeElements in Elements) {
				if (attributeElements.ArrayIndices != null && !attributeElements.ArrayIndices.Exists(ctx))
					attributeElements.ArrayIndices.Create(ctx);	
			}
		
			if (mFeedbackBuffer != null)
				mFeedbackBuffer.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="System.Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				// Unreference all collected array buffer objects
				foreach (VertexArray vertexArray in mVertexArrays.Values)
					vertexArray.Array.DecRef();
				// Unreference all collected array indices
				foreach (AttributeElements vertexIndices in Elements)
					if (vertexIndices.ArrayIndices != null)
						vertexIndices.ArrayIndices.DecRef();
			}
		}

		/// <summary>
		/// Flag indicating whether used context really support vertex arrays.
		/// </summary>
		private bool mSupportVertexArray;

		#endregion
	}
}
