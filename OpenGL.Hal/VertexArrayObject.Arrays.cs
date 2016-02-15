
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
		/// Vertex array buffer interface.
		/// </summary>
		protected internal interface IVertexArray : IDisposable
		{
			/// <summary>
			/// Allocate resources used by this vertex array.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			void Create(GraphicsContext ctx);

			/// <summary>
			/// Get the length of the vertex array.
			/// </summary>
			uint Length { get; }

			/// <summary>
			/// Set the vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			/// <param name="shaderProgram">
			/// The <see cref="ShaderProgram"/> that is used for rendering.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			void SetVertexAttribute(GraphicsContext ctx, ShaderProgram shaderProgram, string attributeName);
		}

		/// <summary>
		/// A vertex array buffer.
		/// </summary>
		protected internal class VertexArray : IVertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an VertexArray for enabling vertex attribute.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferObjectBase"/> which defines a vertex array buffer.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			public VertexArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex)
			{
				if (arrayBuffer != null && arrayBuffer.ItemCount == 0)
					throw new ArgumentException("zero items", "arrayBuffer");
				if (arrayBuffer != null && sectionIndex >= arrayBuffer.ArraySectionsCount)
					throw new ArgumentOutOfRangeException("out of bounds", "sectionIndex");

				ArrayBuffer = arrayBuffer;
				if (ArrayBuffer != null)
					ArrayBuffer.IncRef();
				ArraySectionIndex = sectionIndex;
			}

			/// <summary>
			/// Construct an VertexArray for disabling vertex attribute.
			/// </summary>
			/// <param name="reset">
			/// A <see cref="Boolean"/> that specify whether the vertex attribute should be disabled at the
			/// chance.
			/// </param>
			public VertexArray(bool reset)
			{
				// Force vertex attribute reset (disabled)
				IsDirty = reset;
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
					Debug.Assert(vertexAttribPointer == new IntPtr(arraySection.Pointer.ToInt64() + arraySection.Offset.ToInt64()));
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

					// Attribute disabled
					Gl.GetVertexAttrib(attributeBinding.Location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
					Debug.Assert(vertexAttribArrayEnabled == Gl.FALSE);
				}
			}

			#region Shader Attributes

			/// <summary>
			/// Enable the generic vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> on which the shader program is bound.
			/// </param>
			/// <param name="attributeBinding">
			/// The <see cref="ShaderProgram.AttributeBinding"/> representing the generic vertex attribute.
			/// </param>
			internal virtual void EnableVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
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
				switch (ArrayBufferItem.GetArrayBaseType(attributeBinding.Type)) {
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
					default:
						throw new NotSupportedException(String.Format("vertex attribute type {0} not supported", attributeBinding.Type));
				}

				// Enable vertex attribute
				Gl.EnableVertexAttribArray(attributeBinding.Location);
			}

			/// <summary>
			/// Disable the generic vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> on which the shader program is bound.
			/// </param>
			/// <param name="attributeBinding">
			/// The <see cref="ShaderProgram.AttributeBinding"/> representing the generic vertex attribute.
			/// </param>
			internal virtual void DisableVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
			{
				// Enable vertex attribute
				Gl.DisableVertexAttribArray(attributeBinding.Location);
			}

			#endregion

			#region Fixed Pipeline Attributes

			private void SetPositionAttribute(GraphicsContext ctx)
			{
				if (ArrayBuffer != null) {
					ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ArrayBuffer.Bind(ctx);

					// Set vertex pointer
					Gl.VertexPointer(
						arrayLength, ArrayBufferItem.GetVertexPointerType(arraySection.ItemType), arrayStride,
						arraySection.Pointer
					);
					// Enable vertex attribute
					Gl.EnableClientState(EnableCap.VertexArray);	
				} else
					Gl.DisableClientState(EnableCap.VertexArray);
				
			}

			private void SetColorAttribute(GraphicsContext ctx)
			{
				if (ArrayBuffer != null) {
					ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ArrayBuffer.Bind(ctx);

					// Set vertex pointer
					Gl.ColorPointer(
						arrayLength, ArrayBufferItem.GetColorPointerType(arraySection.ItemType), arrayStride,
						arraySection.Pointer
					);
					// Enable vertex attribute
					Gl.EnableClientState(EnableCap.ColorArray);
				} else
					Gl.DisableClientState(EnableCap.ColorArray);
			}

			private void SetNormalAttribute(GraphicsContext ctx)
			{
				if (ArrayBuffer != null) {
					ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
					if (arrayLength != 3)
						throw new NotSupportedException(String.Format("normal pointer of length {0} not supported", arrayLength));

					// Bind the array buffer
					ArrayBuffer.Bind(ctx);

					// Set vertex pointer
					Gl.NormalPointer(
						ArrayBufferItem.GetNormalPointerType(arraySection.ItemType), arraySection.Stride.ToInt32(),
						arraySection.Pointer
					);
					// Enable vertex attribute
					Gl.EnableClientState(EnableCap.NormalArray);
				} else
					Gl.DisableClientState(EnableCap.NormalArray);
			}

			private void SetTexCoordAttribute(GraphicsContext ctx)
			{
				if (ArrayBuffer != null) {
					ArrayBufferObjectBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)ArrayBufferItem.GetArrayLength(arraySection.ItemType);
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ArrayBuffer.Bind(ctx);

					// Set vertex pointer
					Gl.TexCoordPointer(
						arrayLength, ArrayBufferItem.GetTexCoordPointerType(arraySection.ItemType), arraySection.Stride.ToInt32(),
						arraySection.Pointer
					);
					// Enable vertex attribute
					Gl.EnableClientState(EnableCap.TextureCoordArray);
				} else
					Gl.DisableClientState(EnableCap.TextureCoordArray);
			}

			#endregion

			#endregion

			#region IVertexArray Implementation

			/// <summary>
			/// Allocate resources used by this vertex array.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			public void Create(GraphicsContext ctx)
			{
				if (ArrayBuffer.Exists(ctx) == false)
					ArrayBuffer.Create(ctx);
			}

			/// <summary>
			/// Get the length of the vertex array.
			/// </summary>
			public uint Length { get { return (ArrayBuffer.ItemCount); } }

			/// <summary>
			/// Set the vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			/// <param name="shaderProgram">
			/// The <see cref="ShaderProgram"/> that is used for rendering.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			public void SetVertexAttribute(GraphicsContext ctx, ShaderProgram shaderProgram, string attributeName)
			{
				if (attributeName == null)
					throw new ArgumentNullException("attributeName");

				if (shaderProgram != null) {
					ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);

					// Avoid rendundant buffer binding and relative vertex array setup
					if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && IsDirty == false) {
						CheckVertexAttribute(ctx, attributeBinding);
						return;
					}

					// Enable/Disable shader attribute
					if (ArrayBuffer != null)
						EnableVertexAttribute(ctx, attributeBinding);
					else
						DisableVertexAttribute(ctx, attributeBinding);
				} else {
					switch (attributeName) {
						case VertexArraySemantic.Position:
							SetPositionAttribute(ctx);
							break;
						case VertexArraySemantic.Color:
							SetColorAttribute(ctx);
							break;
						case VertexArraySemantic.Normal:
							SetNormalAttribute(ctx);
							break;
						case VertexArraySemantic.TexCoord:
							SetTexCoordAttribute(ctx);
							break;
						default:
							throw new NotSupportedException(String.Format("attribute {0} not supported on fixed pipeline", attributeName));
					}
				}
				

				// Next time do not set bindings and array state if GL_ARB_vertex_array_object is supported
				IsDirty = false;
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
		/// A vertex default value.
		/// </summary>
		protected internal class DefaultVertexArray : IVertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an DefaultVertexArray for disabling vertex attribute, but assigning a default attribute for those
			/// shader programs using the attribute all the same.
			/// </summary>
			/// <param name="defaultAttribValue">
			/// A <see cref="ArrayBufferObjectBase"/> which defines a vertex array buffer.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			public DefaultVertexArray(Vertex4d defaultAttribValue)
			{
				DefaultValue = defaultAttribValue;
			}

			#endregion

			#region Default Attribute Value

			/// <summary>
			/// Default vertex attribute value.
			/// </summary>
			private Vertex4d DefaultValue;

			#endregion

			#region IVertexArray Implementation

			/// <summary>
			/// Allocate resources used by this vertex array.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			public void Create(GraphicsContext ctx)
			{
				
			}

			/// <summary>
			/// Get the length of the vertex array.
			/// </summary>
			public uint Length { get { return (0); } }

			/// <summary>
			/// Set the vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			/// <param name="shaderProgram">
			/// The <see cref="ShaderProgram"/> that is used for rendering.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			public void SetVertexAttribute(GraphicsContext ctx, ShaderProgram shaderProgram, string attributeName)
			{
				if (attributeName == null)
					throw new ArgumentNullException("attributeName");

				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);

				switch (attributeBinding.Type) {
					case ShaderAttributeType.Float:
						Gl.VertexAttrib1(attributeBinding.Location, (float)DefaultValue.x);
						break;
					case ShaderAttributeType.Vec2:
						Gl.VertexAttrib2(attributeBinding.Location, (float)DefaultValue.x, (float)DefaultValue.y);
						break;
					case ShaderAttributeType.Vec3:
						Gl.VertexAttrib3(attributeBinding.Location, (float)DefaultValue.x, (float)DefaultValue.y, (float)DefaultValue.z);
						break;
					case ShaderAttributeType.Vec4:
						Gl.VertexAttrib4(attributeBinding.Location, (float)DefaultValue.x, (float)DefaultValue.y, (float)DefaultValue.z, (float)DefaultValue.w);
						break;
					default:
						throw new NotImplementedException(String.Format("default value for attributes of type {0} not implemented", attributeBinding.Type));
				}
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
				
			}

			#endregion
		}

		/// <summary>
		/// An instanced vertex array buffer.
		/// </summary>
		protected internal class InstancedVertexArray : VertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an InstancedVertexArray for enabling instanced vertex attribute.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferObjectBase"/> which defines a vertex array buffer.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			/// <param name="divisor">
			/// A <see cref="UInt32"/> that specify the number of instances that will pass between updates of the generic attribute.
			/// </param>
			public InstancedVertexArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex, uint divisor) :
				base(arrayBuffer, sectionIndex)
			{
				if (divisor == 0)
					throw new ArgumentException("invalid value", "divisor");

				Divisor = divisor;
			}

			#endregion

			#region Instanced Array Information

			/// <summary>
			/// The number of instances that will pass between updates of the generic attribute.
			/// </summary>
			public readonly uint Divisor;

			#endregion

			#region VertexArray Overrides

			/// <summary>
			/// Enable the generic vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> on which the shader program is bound.
			/// </param>
			/// <param name="attributeBinding">
			/// The <see cref="ShaderProgram.AttributeBinding"/> representing the generic vertex attribute.
			/// </param>
			internal override void EnableVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
			{
				// Base implementation
				base.EnableVertexAttribute(ctx, attributeBinding);
				// Attribute divisor
				Gl.VertexAttribDivisor(attributeBinding.Location, Divisor);
			}

			/// <summary>
			/// Disable the generic vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> on which the shader program is bound.
			/// </param>
			/// <param name="attributeBinding">
			/// The <see cref="ShaderProgram.AttributeBinding"/> representing the generic vertex attribute.
			/// </param>
			internal override void DisableVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding attributeBinding)
			{
				// Base implementation
				base.DisableVertexAttribute(ctx, attributeBinding);
				// Attribute divisor (not instanced)
				Gl.VertexAttribDivisor(attributeBinding.Location, 0);
			}

			#endregion
		}

		#region SetArray

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex, string attributeName, string blockName)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid name", "attributeName");

			// Set vertex array
			SetVertexArray(new VertexArray(arrayBuffer, sectionIndex), attributeName, blockName);
			// Compute the actual vertex array length
			UpdateVertexArrayLength();
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferObjectBase arrayBuffer, string inputName, string blockName)
		{
			SetArray(arrayBuffer, 0, inputName, blockName);
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex, string semantic)
		{
			SetArray(arrayBuffer, sectionIndex, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferObjectBase arrayBuffer, string semantic)
		{
			SetArray(arrayBuffer, 0, semantic, SemanticBlockName);
		}

		#endregion

		#region SetArrayDefault

		/// <summary>
		/// Set a default value to a shader attribute.
		/// </summary>
		/// <<param name="defaultValue">
		/// A <see cref="Vertex4d"/> that specify the default value of the attribute.
		/// </param>
		/// <param name="attributeName">
		/// A <see cref="String"/> that specify the name of the attribute variable.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="String"/> that specify the name of the input block encolosing <paramref name="inputName"/>. It
		/// can be null.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="inputName"/> is null or is not a valid input name.
		/// </exception>
		public void SetArrayDefault(Vertex4d defaultValue, string attributeName, string blockName)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid name", "attributeName");

			// Set vertex array
			SetVertexArray(new DefaultVertexArray(defaultValue), attributeName, blockName);
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="defaultValue">
		/// A <see cref="Vertex4d"/> that specify the default value of the attribute.
		/// </param>
		/// <param name="semantic">
		/// A <see cref="String"/> that specify the attribute semantic. Normally a constant of <see cref="VertexArraySemantic"/>.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="semantic"/> is null or is not a valid semantic name.
		/// </exception>
		public void SetArrayDefault(Vertex4d defaultValue, string semantic)
		{
			SetArrayDefault(defaultValue, semantic, SemanticBlockName);
		}

		#endregion

		#region SetInstancedArray

		/// <summary>
		/// Link an array buffer to an attribute of this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex, uint divisor, string attributeName, string blockName)
		{
			if (GraphicsContext.CurrentCaps.GlExtensions.InstancedArrays == false)
				throw new InvalidOperationException("instanced arrays not support by current implementation");
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid name", "attributeName");

			// Set vertex array
			SetVertexArray(new InstancedVertexArray(arrayBuffer, sectionIndex, divisor), attributeName, blockName);
			// Note: instanced vertex arrays do not contribute to vertex array length. Do not update vertex arrays length
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferObjectBase arrayBuffer, uint divisor, string inputName, string blockName)
		{
			SetInstancedArray(arrayBuffer, 0, divisor, inputName, blockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferObjectBase arrayBuffer, uint sectionIndex, uint divisor, string semantic)
		{
			SetInstancedArray(arrayBuffer, sectionIndex, divisor, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferObjectBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferObjectBase arrayBuffer, uint divisor, string semantic)
		{
			SetInstancedArray(arrayBuffer, 0, divisor, semantic, SemanticBlockName);
		}

		#endregion

		/// <summary>
		/// Set an array buffer object collected by this vertex array object.
		/// </summary>
		/// <param name="vertexArray">
		/// The <see cref="VertexArray"/> that defined the vertex attribute buffer.
		/// </param>
		/// <param name="attributeName">
		/// A <see cref="String"/> that specify the attribute name.
		/// </param>
		/// <param name="blockName">
		/// A <see cref="String"/> that specify the attribute block declaring <paramref name="attributeName"/>.
		/// </param>
		protected void SetVertexArray(IVertexArray vertexArray, string attributeName, string blockName)
		{
			if (vertexArray == null)
				throw new ArgumentNullException("vertexArray");
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid name", "attributeName");

			IVertexArray previousVertexArray;

			// Dispose previous vertex array
			if (_VertexArrays.TryGetValue(attributeName, out previousVertexArray))
				previousVertexArray.Dispose();
			// Map buffer object with attribute name
			_VertexArrays[attributeName] = vertexArray;

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

			// Update vertex arrays
			_VertexArrayDirty = true;
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
		protected internal IVertexArray GetVertexArray(string attributeName, string attributeBlock)
		{
			if (String.IsNullOrEmpty(attributeName))
				throw new ArgumentException("invalid attribute name", "attributeName");

			IVertexArray vertexArray;

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
		protected internal IVertexArray GetVertexArray(string semantic)
		{
			return (GetVertexArray(semantic, SemanticBlockName));
		}

		protected internal IVertexArray GetVertexArray(string attributeName, ShaderProgram shaderProgram)
		{
			IVertexArray shaderVertexArray;

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
		/// The vertex array length, based on the property <see cref="ArrayBufferObjectBase.ItemCount"/> of the
		/// array objects compositing this vertex array.
		/// </summary>
		public uint ArrayLength
		{
			get { return (_VertexArrayLength); }
		}

		/// <summary>
		/// The the minimum length of the arrays compositing this vertex array.
		/// </summary>
		private void UpdateVertexArrayLength()
		{
			if (_VertexArrays.Count == 0)
				throw new InvalidOperationException("no arrays");

			uint minLength = UInt32.MaxValue;

			foreach (KeyValuePair<string, IVertexArray> pair in _VertexArrays)
				minLength = Math.Min(minLength, pair.Value.Length);

			_VertexArrayLength = minLength;
		}

		/// <summary>
		/// Number of items of the collected buffer objects.
		/// </summary>
		private uint _VertexArrayLength;

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
		/// Determine the actual <see cref="IVertexArray"/> instances used for drawing.
		/// </summary>
		protected virtual IEnumerable<IVertexArray> DrawArrays { get { return (_VertexArrays.Values); } }

		/// <summary>
		/// Array buffer objects required by this vertex array object.
		/// </summary>
		protected readonly Dictionary<string, IVertexArray> _VertexArrays = new Dictionary<string, IVertexArray>();

		/// <summary>
		/// Special name for the attributes relative to a semantic.
		/// </summary>
		private const string SemanticBlockName = "##Semantic";
	}
}
