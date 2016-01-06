
// Copyright (C) 2011-2015 Luca Piccioni
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
		#region Vertex Arrays Definition

		/// <summary>
		/// A vertex array buffer.
		/// </summary>
		protected class VertexArray : IDisposable
		{
			/// <summary>
			/// Construct an VertexArray.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferObjectBase"/> which defines a vertex array data.
			/// </param>
			public VertexArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex)
			{
				if (arrayBuffer == null)
					throw new ArgumentNullException("arrayBuffer");
				if (arrayBuffer.ItemCount == 0)
					throw new ArgumentException("zero items", "arrayBuffer");
				if (sectionIndex >= arrayBuffer.ArraySectionsCount)
					throw new ArgumentException("out of bounds", "sectionIndex");

				ArrayBuffer = arrayBuffer;
				ArrayBuffer.IncRef();
				ArraySectionIndex = sectionIndex;
			}

			/// <summary>
			/// The vertex array buffer object.
			/// </summary>
			public readonly ArrayBufferObjectBase ArrayBuffer;

			/// <summary>
			/// The vertex array sub-buffer index.
			/// </summary>
			public readonly uint ArraySectionIndex;

			/// <summary>
			/// Dirty flag at vertex array level.
			/// </summary>
			public bool IsDirty = true;

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				ArrayBuffer.DecRef();
			}
		}

		/// <summary>
		/// Link an array buffer to an attribute of this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObject"/> that specify the contents of the array.
		/// </param>
		/// <param name="sectionIndex">
		/// A <see cref="UInt32"/> that specify the <paramref name="arrayBuffer"/> sub-array index.
		/// </param>
		/// <param name="attributeName">
		/// A <see cref="String"/> that specify the name of the attribute variable.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="String"/> that specify the name of the attribute block encolosing <paramref name="semantic"/>. It
		/// can be null.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="arrayBuffer"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="arrayBuffer"/> has no items.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="sectionIndex"/> specify an invalid section of <paramref name="arrayBuffer"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="semantic"/> is null or is not a valid input name.
		/// </exception>
		public void SetArray(ArrayBufferObject arrayBuffer, uint sectionIndex, string attributeName, string blockName)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid name", "attributeName");

			VertexArray vertexArray, previousVertexArray;

			// Dispose previous vertex array
			if (_VertexArrays.TryGetValue(attributeName, out previousVertexArray))
				previousVertexArray.Dispose();
			// Map buffer object with attribute name
			_VertexArrays[attributeName] = vertexArray = new VertexArray(arrayBuffer, sectionIndex);

			// Map buffer object with input name including block name also
			if (blockName != null) {
				// Attribute referenced in block
				attributeName = String.Format("{0}.{1}", blockName, attributeName);

				// Dispose previous vertex array
				if (_VertexArrays.TryGetValue(attributeName, out previousVertexArray))
					previousVertexArray.Dispose();
				// Map buffer object with attribute name
				_VertexArrays[attributeName] = vertexArray;
			}

			// Compute the actual vertex array length
			UpdateVertexArrayLength();
			// Update vertex arrays
			_VertexArrayDirty = true;
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObject"/> that specify the contents of the array.
		/// </param>
		/// <param name="sectionIndex">
		/// A <see cref="UInt32"/> that specify the <paramref name="arrayBuffer"/> sub-array index.
		/// </param>
		/// <param name="inputName">
		/// A <see cref="String"/> that specify the name of the input variable.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="String"/> that specify the name of the input block encolosing <paramref name="inputName"/>. It
		/// can be null.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="arrayBuffer"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="arrayBuffer"/> has no items.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="inputName"/> is null or is not a valid input name.
		/// </exception>
		public void SetArray(ArrayBufferObject arrayBuffer, string inputName, string blockName)
		{
			SetArray(arrayBuffer, 0, inputName, blockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObject"/> that specify the contents of the array.
		/// </param>
		/// <param name="sectionIndex">
		/// A <see cref="UInt32"/> that specify the <paramref name="arrayBuffer"/> sub-array index.
		/// </param>
		/// <param name="semantic">
		/// A <see cref="String"/> that specify the attribute semantic. Normally a constant of <see cref="VertexArraySemantic"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="arrayBuffer"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="arrayBuffer"/> has no items.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="sectionIndex"/> specify an invalid section of <paramref name="arrayBuffer"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="semantic"/> is null or is not a valid semantic name.
		/// </exception>
		public void SetArray(ArrayBufferObject arrayBuffer, uint sectionIndex, string semantic)
		{
			SetArray(arrayBuffer, sectionIndex, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObject"/> that specify the contents of the array.
		/// </param>
		/// <param name="semantic">
		/// A <see cref="String"/> that specify the attribute semantic. Normally a constant of <see cref="VertexArraySemantic"/>.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="arrayBuffer"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception throw if <paramref name="arrayBuffer"/> has no items.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="semantic"/> is null or is not a valid semantic name.
		/// </exception>
		public void SetArray(ArrayBufferObject arrayBuffer, string semantic)
		{
			SetArray(arrayBuffer, 0, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Get an array buffer object collected by this vertex array object.
		/// </summary>
		/// <param name="attributeName">
		/// A <see cref="String"/> that specify the attribute name.
		/// </param>
		/// <param name="attributeBlock">
		/// A <see cref="String"/> that specify the attribute block declaring <paramref name="attributeName"/>.
		/// </param>
		/// <returns>
		/// It returns the array corresponding to the attribute having the name <paramref name="attributeName"/>.
		/// </returns>
		private VertexArray GetVertexArray(string attributeName, string attributeBlock)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid attribute name", "attributeName");

			VertexArray vertexArray;

			if (attributeBlock != null)
				attributeName = String.Format("{0}.{1}", attributeBlock, attributeName);

			if (_VertexArrays.TryGetValue(attributeName, out vertexArray) == false)
				return (null);

			return (vertexArray);
		}

		/// <summary>
		/// Get an array buffer object collected by this vertex array object.
		/// </summary>
		/// <param name="semantic">
		/// A <see cref="String"/> that specify the attribute semantic.
		/// </param>
		/// <returns>
		/// It returns the array corresponding to the semantic <paramref name="semantic"/>.
		/// </returns>
		private VertexArray GetVertexArray(string semantic)
		{
			return (GetVertexArray(semantic, SemanticBlockName));
		}

		/// <summary>
		/// The the minimum length of the arrays compositing this vertex array.
		/// </summary>
		private void UpdateVertexArrayLength()
		{
			uint minLength = UInt32.MaxValue;

			foreach (KeyValuePair<string, VertexArray> pair in _VertexArrays)
				minLength = Math.Min(minLength, pair.Value.ArrayBuffer.ItemCount);

			_VertexArrayLength = minLength;
		}

		/// <summary>
		/// Validate this vertex array.
		/// </summary>
		/// <returns></returns>
		[Conditional("DEBUG")]
		private void Validate()
		{
			if (_VertexArrays.Count == 0)
				throw new InvalidOperationException("no array");
		}

		/// <summary>
		/// Array buffer objects required by this vertex array object.
		/// </summary>
		protected readonly Dictionary<string, VertexArray> _VertexArrays = new Dictionary<string, VertexArray>();

		/// <summary>
		/// Special name for the attributes relative to a semantic.
		/// </summary>
		private const string SemanticBlockName = "##Semantic";

		/// <summary>
		/// Number of items of the collected buffer objects.
		/// </summary>
		private uint _VertexArrayLength;

		#endregion

		#region Vertex Elements Definition

		/// <summary>
		/// A collection of indices reference input arrays.
		/// </summary>
		protected class AttributeElements : IDisposable
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
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
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
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
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


			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				if (ArrayIndices != null)
					ArrayIndices.DecRef();
			}
		}

		/// <summary>
		/// Specify the entire array to be drawn sequentially.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		public void SetElementArray(PrimitiveType mode)
		{
			// Store element array (entire buffer)
			_Elements.Add(new AttributeElements(mode));
		}

		/// <summary>
		/// Set a buffer object which specify the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="Primitive"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBufferObject"/> that specify a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		public void SetElementArray(PrimitiveType mode, ElementBufferObject bufferObject)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");

			// Store element array
			_Elements.Add(new AttributeElements(mode, bufferObject));
		}

		/// <summary>
		/// Set a buffer object which specify the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBufferObject"/> that specify a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		public void SetElementArray(PrimitiveType mode, ElementBufferObject bufferObject, uint offset, uint count)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");

			// Store element array
			_Elements.Add(new AttributeElements(mode, bufferObject, offset, count));
		}

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		protected readonly List<AttributeElements> _Elements = new List<AttributeElements>();

		#endregion

#if false

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

			ArrayBufferObjectBase positionBuffer = positionArray.Array;

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
				ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);

				normalBuffer.Create(positionBuffer.ItemCount);
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

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);

			try {
				normalBuffer.Create(positionArray.ItemCount);

				for (uint i = 0; i < positionArray.ItemCount; i += 3) {
					Vertex3f p0 = positionArray.GetClientData<Vertex3f>(i + 0);
					Vertex3f p1 = positionArray.GetClientData<Vertex3f>(i + 1);
					Vertex3f p2 = positionArray.GetClientData<Vertex3f>(i + 2);

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
		/// A <see cref="UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
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
		/// A <see cref="UInt32"/> that specify the offset of the considered <paramref name="positionIndices"/> items.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
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

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);

			try {
				normalBuffer.Create(positionArray.ItemCount);

				// Reset normal buffer (cumulate normals)
				for (uint i = 0; i < positionArray.ItemCount; i++)
					normalBuffer[i] = Vertex3f.Zero;

				for (uint i = 0; i < positionIndices.ItemCount; i += 3 * positionIndicesStride) {
					uint p0Index = positionIndices[positionIndicesOffset + i + 0 * positionIndicesStride];
					uint p1Index = positionIndices[positionIndicesOffset + i + 1 * positionIndicesStride];
					uint p2Index = positionIndices[positionIndicesOffset + i + 2 * positionIndicesStride];

					Vertex3f p0 = positionArray.GetClientData<Vertex3f>(p0Index);
					Vertex3f p1 = positionArray.GetClientData<Vertex3f>(p1Index);
					Vertex3f p2 = positionArray.GetClientData<Vertex3f>(p2Index);

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
		/// A <see cref="UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
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
		/// A <see cref="UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
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
		/// A <see cref="UInt32[]"/> that specify the indices used for sequencing the vertices from <paramref name="positionArray"/>.
		/// </param>
		/// <param name="positionIndicesOffset">
		/// A <see cref="UInt32"/> that specify the offset of the considered <paramref name="positionIndices"/> items.
		/// </param>
		/// <param name="positionIndicesStride">
		/// A <see cref="UInt32"/> that specify the stride between subsequent <paramref name="positionIndices"/> items.
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

			ArrayBufferObject<Vertex3f> normalBuffer = new ArrayBufferObject<Vertex3f>(BufferObjectHint.StaticCpuDraw);

			try {
				normalBuffer.Create(positionArray.ItemCount);

				// Reset normal buffer (cumulate normals)
				for (uint i = 0; i < positionArray.ItemCount; i++)
					normalBuffer[i] = Vertex3f.Zero;

				for (uint i = 0; i < positionIndices.Length; i += 3 * positionIndicesStride) {
					uint p0Index = positionIndices[positionIndicesOffset + i + 0 * positionIndicesStride];
					uint p1Index = positionIndices[positionIndicesOffset + i + 1 * positionIndicesStride];
					uint p2Index = positionIndices[positionIndicesOffset + i + 2 * positionIndicesStride];

					Vertex3f p0 = positionArray.GetClientData<Vertex3f>(p0Index);
					Vertex3f p1 = positionArray.GetClientData<Vertex3f>(p1Index);
					Vertex3f p2 = positionArray.GetClientData<Vertex3f>(p2Index);

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

#endif

		#region Vertex Array Application

		/// <summary>
		/// Draw the attributes of this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shader">
		/// The <see cref="ShaderProgram"/> used for drawing the vertex arrays.
		/// </param>
		public virtual void DrawVertexArray(GraphicsContext ctx, ShaderProgram shader)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent)
				throw new ArgumentException("not current", "ctx");
			if (shader == null)
				throw new ArgumentNullException("no shader");
			if (shader.Exists(ctx) == false)
				throw new ArgumentException("not existing", "shader");
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");
			if (_Elements.Count == 0)
				throw new InvalidOperationException("no elements defined");

			// If vertex was modified after creation, don't miss to create array buffers
			if (_VertexArrayDirty) CreateObject(ctx);

			// Set vertex arrays
			SetVertexArrayState(ctx, shader);

			// Uses shader
			shader.Bind(ctx);
			// Issue rendering using shader
			foreach (AttributeElements attributeElements in _Elements) {
				if (_FeedbackBuffer != null)
					_FeedbackBuffer.Begin(ctx, attributeElements.ElementsMode);
				
				DrawAttributeElement(ctx, attributeElements);
				
				if (_FeedbackBuffer != null)
					_FeedbackBuffer.End(ctx);
			}
		}

		/// <summary>
		/// Set the vertex arrays state for the shader program.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> on which the shader program is bound.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> on which the vertex arrays shall be bound.
		/// </param>
		protected void SetVertexArrayState(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB) {
				// Bind this vertex array
				Gl.BindVertexArray(ObjectName);
			}

			// Short path?
			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && !_VertexArrayDirty)
				return;

			foreach (string attributeName in shaderProgram.ActiveAttributes) {
				VertexArray shaderVertexArray;

				// Get the buffer object containing data for vertex shader attribute
				if ((shaderVertexArray = GetVertexArray(attributeName, null)) == null) {
					// Failed, try using attribute semantic, if any
					string semantic = shaderProgram.GetAttributeSemantic(attributeName);

					if (semantic != null)
						shaderVertexArray = GetVertexArray(semantic);
				}

				if (shaderVertexArray == null)
					continue;

				// Avoid rendundant buffer binding and relative vertex array setup
				if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && shaderVertexArray.IsDirty == false)
					continue;

				// Bind the array buffer object
				shaderVertexArray.ArrayBuffer.Bind(ctx);

				// Select the array section to point
				ArrayBufferObjectBase.IArraySection arraySection = shaderVertexArray.ArrayBuffer.GetArraySection(shaderVertexArray.ArraySectionIndex);
				int arrayBaseType = (int)ArrayBufferItem.GetArrayBaseType(arraySection.ItemType);
				int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
				int arrayStride = arraySection.Stride.ToInt32();
				
				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);

				// Bind varying attribute to currently bound buffer object
				switch (GetArrayBaseType(attributeBinding.Type)) {
					case VertexBaseType.Float:
						Gl.VertexAttribPointer(
							attributeBinding.Location,
							arrayLength, arrayBaseType, arraySection.Normalized,
							arrayStride, arraySection.Offset
						);
						break;
					case VertexBaseType.Int:
					case VertexBaseType.UInt:
						Gl.VertexAttribIPointer(
							attributeBinding.Location,
							arrayLength, arrayBaseType,
							arrayStride, arraySection.Offset
							);
						break;
					case VertexBaseType.Double:
						Gl.VertexAttribLPointer(
							attributeBinding.Location,
							arrayLength, arrayBaseType,
							arrayStride, arraySection.Offset
							);
						break;
				}
				
				// Enable vertex attribute
				Gl.EnableVertexAttribArray(attributeBinding.Location);

				// Next time do not set bindings and array state if GL_ARB_vertex_array_object is supported
				shaderVertexArray.IsDirty = false;
			}

			// Next time do not set inputs if GL_ARB_vertex_array_object is supported
			_VertexArrayDirty = false;
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
		protected void DrawAttributeElement(GraphicsContext ctx, AttributeElements attributeElement)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (attributeElement == null)
				throw new ArgumentNullException("attributeElement");

			ElementBufferObject elementIndices = attributeElement.ArrayIndices;

			if (elementIndices == null) {
				uint count = (attributeElement.ElementCount == 0) ? _VertexArrayLength : attributeElement.ElementCount;

				Debug.Assert(count - attributeElement.ElementOffset <= _VertexArrayLength, "element array out of bounds");
			
				//if (mFeedbackBuffer != null)
				//	mFeedbackBuffer.Begin(ctx, attributeElement.ElementsMode);
				
				// Draw vertex array sequentially
				Gl.DrawArrays(attributeElement.ElementsMode, (int)attributeElement.ElementOffset, (int)count);
			
				//if (mFeedbackBuffer != null)
				//	mFeedbackBuffer.End(ctx);
			} else {
				uint count = (attributeElement.ElementCount == 0) ? elementIndices.ItemCount : attributeElement.ElementCount;

				Debug.Assert(count - attributeElement.ElementOffset <= elementIndices.ItemCount, "element indices array out of bounds");

				// Element array must be (re)bound
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
		private bool _VertexArrayDirty = true;

		#endregion
	
		#region Transform Feedback
		
		public void SetTransformFeedback(FeedbackBufferObject feedbackObject)
		{
			if (_FeedbackBuffer != null)
				_FeedbackBuffer.DecRef();
		
			_FeedbackBuffer = feedbackObject;
		
			if (_FeedbackBuffer != null)
				_FeedbackBuffer.IncRef();
		}
	
		public void SetSymmetricTransformFeedback()
		{
			
		}
	
		private FeedbackBufferObject _FeedbackBuffer;
		
		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("821E9AC8-6118-4543-B561-7C85BB998287");

		/// <summary>
		/// Vertex array object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

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
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
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

			return (!RequiresName(ctx) || Gl.IsVertexArray(ObjectName));
		}

		/// <summary>
		/// Determine whether this object requires a name bound to a context or not.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns always false. Names are managed manually
		/// </returns>
		protected override bool RequiresName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (ctx.Caps.GlExtensions.VertexArrayObject_ARB);
		}

		/// <summary>
		/// Create a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this buffer object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this BufferObject.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		protected override uint CreateName(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");

			Debug.Assert(ctx.Caps.GlExtensions.VertexArrayObject_ARB);

			return (Gl.GenVertexArray());
		}

		/// <summary>
		/// Delete a BufferObject name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this buffer object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current on the calling thread.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject does not exist.
		/// </exception>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current");
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");

			Debug.Assert(ctx.Caps.GlExtensions.VertexArrayObject_ARB);

			// Delete buffer object
			Gl.DeleteVertexArrays(name);
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
		/// <see cref="BufferObjectHint.StaticCpuDraw"/> or <see cref="BufferObjectHint.DynamicCpuDraw"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this BufferObject is currently mapped.
		/// </exception>
		protected override void CreateObject(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");

			// Validate vertex array object
			Validate();

			// Create vertex arrays
			foreach (VertexArray vertexArray in _VertexArrays.Values) {
				if (vertexArray.ArrayBuffer.Exists(ctx) == false)
					vertexArray.ArrayBuffer.Create(ctx);
			}

			// Create element arrays
			foreach (AttributeElements element in _Elements) {
				if (element.ArrayIndices != null && element.ArrayIndices.Exists(ctx) == false)
					element.ArrayIndices.Create(ctx);	
			}
		
			// Create feedback buffer
			if (_FeedbackBuffer != null)
				_FeedbackBuffer.Create(ctx);
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting managed/unmanaged resources.
		/// </summary>
		/// <param name="disposing">
		/// A <see cref="Boolean"/> indicating whether this method is called by <see cref="Dispose()"/>. If it is false,
		/// this method is called by the finalizer.
		/// </param>
		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);
			// Dispose related resources
			if (disposing) {
				// Unreference all collected array buffer objects
				foreach (VertexArray vertexArray in _VertexArrays.Values)
					vertexArray.Dispose();
				// Unreference all collected array indices
				foreach (AttributeElements vertexIndices in _Elements)
					vertexIndices.Dispose();
			}
		}

		#endregion
	}
}
