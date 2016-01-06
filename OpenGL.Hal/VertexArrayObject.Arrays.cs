
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
using System.Diagnostics;
using System.Collections.Generic;

namespace OpenGL
{
	public partial class VertexArrayObject
	{
		/// <summary>
		/// A vertex array buffer.
		/// </summary>
		protected class VertexArray : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Construct an VertexArray.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferObjectBase"/> which defines a vertex array data.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			public VertexArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex)
			{
				if (arrayBuffer != null && arrayBuffer.ItemCount == 0)
					throw new ArgumentException("zero items", "arrayBuffer");
				if (arrayBuffer != null && sectionIndex >= arrayBuffer.ArraySectionsCount)
					throw new ArgumentException("out of bounds", "sectionIndex");

				ArrayBuffer = arrayBuffer;
				if (ArrayBuffer != null)
					ArrayBuffer.IncRef();
				ArraySectionIndex = sectionIndex;
			}

			#endregion

			#region Array Information

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

			#endregion

			#region Vertex Attribute

			internal void SetVertexAttribute(GraphicsContext ctx, ShaderProgram shaderProgram, ShaderProgram.AttributeBinding attributeBinding)
			{
				// Enable/Disable attribute
				if (ArrayBuffer != null)
					EnableVertexAttribute(ctx, shaderProgram, attributeBinding);
				else
					DisableVertexAttribute(ctx, attributeBinding);

				// Next time do not set bindings and array state if GL_ARB_vertex_array_object is supported
				IsDirty = false;
			}

			[Conditional("DEBUG")]
			internal void CheckVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
			{
				if (ArrayBuffer != null) {
					ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayBaseType = (int)ArrayBufferItem.GetArrayBaseType(arraySection.ItemType);
					int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
					int arrayStride = arraySection.Stride.ToInt32();

					// Check effective state
					IntPtr vertexAttribPointer;
					int vertexAttribArrayBufferBinding;
					int vertexAttribArraySize;
					int vertexAttribArrayType;
					int vertexAttribArrayNormalized;
					int vertexAttribArrayStride;
					int vertexAttribArrayEnabled;

					// Attribute pointer/offset
					Gl.GetVertexAttribPointer(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_POINTER, out vertexAttribPointer);
					Debug.Assert(vertexAttribPointer == arraySection.Offset);
					// Array buffer binding
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, out vertexAttribArrayBufferBinding);
					Debug.Assert(vertexAttribArrayBufferBinding == ArrayBuffer.ObjectName);
					// Array size
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_SIZE, out vertexAttribArraySize);
					Debug.Assert(vertexAttribArraySize == arrayLength);
					// Array type
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_TYPE, out vertexAttribArrayType);
					Debug.Assert(vertexAttribArrayType == arrayBaseType);
					// Array normalized
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, out vertexAttribArrayNormalized);
					Debug.Assert((vertexAttribArrayNormalized != 0) == arraySection.Normalized);
					// Array size
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_STRIDE, out vertexAttribArrayStride);
					Debug.Assert(vertexAttribArrayStride == arrayStride);
					// Attribute enabled
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
					Debug.Assert(vertexAttribArrayEnabled == Gl.TRUE);
				} else {
					int vertexAttribArrayEnabled;

					// Attribute enabled
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
					Debug.Assert(vertexAttribArrayEnabled == Gl.FALSE);
				}
			}

			private void EnableVertexAttribute(GraphicsContext ctx, ShaderProgram shaderProgram, ShaderProgram.AttributeBinding attributeBinding)
			{
				ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

				int arrayBaseType = (int)ArrayBufferItem.GetArrayBaseType(arraySection.ItemType);
				int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
				int arrayStride = arraySection.Stride.ToInt32();

				// Avoid rendundant buffer binding and relative vertex array setup
				if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && IsDirty == false) {
					CheckVertexAttribute(ctx, attributeBinding);
					return;
				}

				// Bind the array buffer
				ArrayBuffer.Bind(ctx);

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
			}

			private void DisableVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
			{
				// Avoid rendundant buffer binding and relative vertex array setup
				if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && IsDirty == false) {
#if DEBUG
					// Check effective state
					int vertexAttribArrayEnabled;

					// Attribute enabled
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
					Debug.Assert(vertexAttribArrayEnabled == Gl.TRUE);
#endif
					return;
				}

				// Enable vertex attribute
				Gl.DisableVertexAttribArray(attributeBinding.Location);
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				if (ArrayBuffer != null)
					ArrayBuffer.DecRef();
			}

			#endregion
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

		private VertexArray GetVertexArray(string attributeName, ShaderProgram shaderProgram)
		{
			VertexArray shaderVertexArray;

			// Get the buffer object containing data for vertex shader attribute
			if ((shaderVertexArray = GetVertexArray(attributeName, (string)null)) == null) {
				// Failed, try using attribute semantic, if any
				string semantic = shaderProgram.GetAttributeSemantic(attributeName);

				if (semantic != null)
					shaderVertexArray = GetVertexArray(semantic);
			}

			return (shaderVertexArray);
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
	}
}
