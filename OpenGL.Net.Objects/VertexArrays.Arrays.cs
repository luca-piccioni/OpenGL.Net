
// Copyright (C) 2011-2015 Luca Piccioni
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
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OpenGL.Objects
{
	public partial class VertexArrays
	{
		/// <summary>
		/// Vertex array buffer interface.
		/// </summary>
		internal interface IVertexArray : IDisposable
		{
			/// <summary>
			/// Allocate resources used by this vertex array.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			void Create(GraphicsContext ctx);

			/// <summary>
			/// The <see cref="ArrayBufferBase"/> holding the array information.
			/// </summary>
			ArrayBufferBase Array { get; }

			/// <summary>
			/// The section of the array referred by this vertex array.
			/// </summary>
			ArrayBufferBase.IArraySection ArraySection { get; }

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
			/// <param name="programAttrib">
			/// The <see cref="ShaderProgram.AttributeBinding"/> that specifies the attribute information.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			void SetVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding programAttrib, string attributeName);

			/// <summary>
			/// Get an element from the array, as defined in the underlying VertexArrayObject instance.
			/// </summary>
			/// <typeparam name="T"></typeparam>
			/// <param name="index"></param>
			/// <returns></returns>
			T GetElement<T>(uint index) where T : struct;

			/// <summary>
			/// Set an element from the array, as defined in the underlying VertexArrayObject instance.
			/// </summary>
			/// <typeparam name="T"></typeparam>
			/// <param name="index"></param>
			/// <returns></returns>
			void SetElement<T>(T element, uint index) where T : struct;
		}

		/// <summary>
		/// A vertex array buffer.
		/// </summary>
		internal class VertexArray : IVertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an VertexArray for enabling vertex attribute.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferBase"/> which defines a vertex array buffer.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			public VertexArray(ArrayBufferBase arrayBuffer, uint sectionIndex)
			{
				if (arrayBuffer != null && arrayBuffer.ItemsCount == 0)
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
			public readonly ArrayBufferBase ArrayBuffer;

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

			[Conditional("GL_DEBUG")]
			internal void CheckVertexAttribute(GraphicsContext ctx, uint location)
			{
				if (ArrayBuffer != null) {
					ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayBaseType = (int)arraySection.ItemType.GetVertexBaseType();
					int arrayLength = (int)arraySection.ItemType.GetArrayLength();
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
					Gl.GetVertexAttribPointer(location, Gl.VERTEX_ATTRIB_ARRAY_POINTER, out vertexAttribPointer);
					Debug.Assert(vertexAttribPointer == new IntPtr(arraySection.Pointer.ToInt64() + arraySection.Offset.ToInt64()));
					// Array buffer binding
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, out vertexAttribArrayBufferBinding);
					Debug.Assert(vertexAttribArrayBufferBinding == ArrayBuffer.ObjectName);
					// Array size
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_SIZE, out vertexAttribArraySize);
					Debug.Assert(vertexAttribArraySize == arrayLength);
					// Array type
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_TYPE, out vertexAttribArrayType);
					Debug.Assert(vertexAttribArrayType == arrayBaseType);
					// Array normalized
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED, out vertexAttribArrayNormalized);
					Debug.Assert((vertexAttribArrayNormalized != 0) == arraySection.Normalized);
					// Array size
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_STRIDE, out vertexAttribArrayStride);
					Debug.Assert(vertexAttribArrayStride == arrayStride);
					// Attribute enabled
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
					Debug.Assert(vertexAttribArrayEnabled == Gl.TRUE);
				} else {
					int vertexAttribArrayEnabled;

					// Attribute disabled
					Gl.GetVertexAttrib(location, Gl.VERTEX_ATTRIB_ARRAY_ENABLED, out vertexAttribArrayEnabled);
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
			internal virtual void EnableVertexAttribute(GraphicsContext ctx, uint location, ShaderAttributeType type)
			{
				// Avoid rendundant buffer binding and relative vertex array setup
				if ((ctx.Extensions.VertexArrayObject_ARB || ctx.Version.IsCompatible(Gl.Version_300_ES)) && IsDirty == false) {
					// CheckVertexAttribute(ctx, location);
					return;
				}

				ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);
				int arrayStride = arraySection.Stride.ToInt32();

				ctx.Bind(ArrayBuffer);

				uint arrayRank = arraySection.ItemType.GetArrayRank();

				if (arrayRank == 1) {
					VertexAttribType arrayBaseType = (VertexAttribType)arraySection.ItemType.GetVertexBaseType();
					int arrayLength = (int)arraySection.ItemType.GetArrayLength();

					// Enable vertex attribute
					Gl.EnableVertexAttribArray(location);
					// Bind varying attribute to currently bound buffer object
					switch (ArrayBufferItem.GetArrayBaseType(type)) {
						case VertexBaseType.Float:
							Gl.VertexAttribPointer(
								location,
								arrayLength, arrayBaseType, arraySection.Normalized,
								arrayStride, arraySection.Offset
							);
							break;
						case VertexBaseType.Int:
						case VertexBaseType.UInt:
							Gl.VertexAttribIPointer(
								location,
								arrayLength, arrayBaseType,
								arrayStride, arraySection.Offset
								);
							break;
#if !MONODROID
						case VertexBaseType.Double:
							Gl.VertexAttribLPointer(
								location,
								arrayLength, arrayBaseType,
								arrayStride, arraySection.Offset
								);
							break;
#endif
						default:
							throw new NotSupportedException(String.Format("vertex attribute type {0} not supported", type));
					}

					// Set attribute divisor
					SetAttributeDivisor(ctx, location, type);
				} else {
					ArrayBufferItemType columnType = arraySection.ItemType.GetMatrixColumnType();
					uint columnOffset = columnType.GetItemSize();

					VertexAttribType arrayBaseType = (VertexAttribType)columnType.GetVertexBaseType();
					int arrayLength = (int)columnType.GetArrayLength();

					for (int i = 0; i < arrayRank; i++) {
						// Enable vertex attribute
						Gl.EnableVertexAttribArray((uint)(location + i));
						// Bind varying attribute to currently bound buffer object
						switch (ArrayBufferItem.GetArrayBaseType(type)) {
							case VertexBaseType.Float:
								Gl.VertexAttribPointer(
									(uint)(location + i),
									arrayLength, arrayBaseType, arraySection.Normalized,
									arrayStride, new IntPtr(arraySection.Offset.ToInt64() + columnOffset * i)
								);
								break;
							case VertexBaseType.Int:
							case VertexBaseType.UInt:
								Gl.VertexAttribIPointer(
									(uint)(location + i),
									arrayLength, arrayBaseType,
									arrayStride, new IntPtr(arraySection.Offset.ToInt64() + columnOffset * i)
									);
								break;
#if !MONODROID
							case VertexBaseType.Double:
								Gl.VertexAttribLPointer(
									(uint)(location + i),
									arrayLength, arrayBaseType,
									arrayStride, new IntPtr(arraySection.Offset.ToInt64() + columnOffset * i)
									);
								break;
#endif
							default:
								throw new NotSupportedException(String.Format("vertex attribute type {0} not supported", type));
						}
						// Set attribute divisor
						SetAttributeDivisor(ctx, (uint)(location + i), type);
					}
				}
			}

			internal virtual void SetAttributeDivisor(GraphicsContext ctx, uint location, ShaderAttributeType type)
			{
				if (ctx.Extensions.InstancedArrays)
					Gl.VertexAttribDivisor(location, 0);
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
			internal virtual void DisableVertexAttribute(GraphicsContext ctx, uint location)
			{
				// Enable vertex attribute
				Gl.DisableVertexAttribArray(location);
			}

			#endregion

#if !MONODROID

			#region Fixed Pipeline Attributes

			private void SetPositionAttribute(GraphicsContext ctx)
			{
				if (ArrayBuffer != null) {
					ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)arraySection.ItemType.GetArrayLength();
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ctx.Bind(ArrayBuffer);

					// Set vertex pointer
					Gl.VertexPointer(
						arrayLength, arraySection.ItemType.GetVertexPointerType(), arrayStride,
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
					ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)arraySection.ItemType.GetArrayLength();
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ctx.Bind(ArrayBuffer);

					// Set vertex pointer
					Gl.ColorPointer(
						arrayLength, arraySection.ItemType.GetColorPointerType(), arrayStride,
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
					ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)arraySection.ItemType.GetArrayLength();
					if (arrayLength != 3)
						throw new NotSupportedException(String.Format("normal pointer of length {0} not supported", arrayLength));

					// Bind the array buffer
					ctx.Bind(ArrayBuffer);

					// Set vertex pointer
					Gl.NormalPointer(
						arraySection.ItemType.GetNormalPointerType(), arraySection.Stride.ToInt32(),
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
					ArrayBufferBase.IArraySection arraySection = ArrayBuffer.GetArraySection(ArraySectionIndex);

					int arrayLength = (int)arraySection.ItemType.GetArrayLength();
					int arrayStride = arraySection.Stride.ToInt32();

					// Bind the array buffer
					ctx.Bind(ArrayBuffer);

					// Set vertex pointer
					Gl.TexCoordPointer(
						arrayLength, arraySection.ItemType.GetTexCoordPointerType(), arraySection.Stride.ToInt32(),
						arraySection.Pointer
					);
					// Enable vertex attribute
					Gl.EnableClientState(EnableCap.TextureCoordArray);
				} else
					Gl.DisableClientState(EnableCap.TextureCoordArray);
			}

			#endregion

#endif

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
			/// The <see cref="ArrayBufferBase"/> holding the array information.
			/// </summary>
			public ArrayBufferBase Array { get { return (ArrayBuffer); } }

			/// <summary>
			/// The section of the array referred by this vertex array.
			/// </summary>
			public ArrayBufferBase.IArraySection ArraySection { get { return (ArrayBuffer.GetArraySection(ArraySectionIndex)); } }

			/// <summary>
			/// Get the length of the vertex array.
			/// </summary>
			public uint Length { get { return (ArrayBuffer.ItemsCount); } }

			/// <summary>
			/// Set the vertex attribute.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for rendering.
			/// </param>
			/// <param name="programAttrib">
			/// The <see cref="ShaderProgram.AttributeBinding"/> that specifies the attribute information.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			public void SetVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding programAttrib, string attributeName)
			{
				if (attributeName == null)
					throw new ArgumentNullException("attributeName");

				if (programAttrib != null) {
					// Enable/Disable shader attribute
					if (ArrayBuffer != null)
						EnableVertexAttribute(ctx, programAttrib.Location, programAttrib.Type);
					else
						DisableVertexAttribute(ctx, programAttrib.Location);
				} else {
#if !MONODROID
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
#else
					throw new NotSupportedException("fixed pipeline not supported");
#endif
				}

				// Next time do not set bindings and array state if GL_ARB_vertex_array_object is supported
				IsDirty = false;
			}

			public T GetElement<T>(uint index) where T : struct
			{
				return (ArrayBuffer.GetElement<T>(index, ArraySectionIndex));
			}

			public void SetElement<T>(T element, uint index) where T : struct
			{
				ArrayBuffer.SetElement<T>(element, index, ArraySectionIndex);
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
		internal class DefaultVertexArray : IVertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an DefaultVertexArray for disabling vertex attribute, but assigning a default attribute for those
			/// shader programs using the attribute all the same.
			/// </summary>
			/// <param name="defaultAttribValue">
			/// A <see cref="ArrayBufferBase"/> which defines a vertex array buffer.
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
			/// The <see cref="ArrayBufferBase"/> holding the array information.
			/// </summary>
			public ArrayBufferBase Array { get { return (null); } }

			/// <summary>
			/// The section of the array referred by this vertex array.
			/// </summary>
			public ArrayBufferBase.IArraySection ArraySection { get { return (null); } }

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
			/// <param name="programAttrib">
			/// The <see cref="ShaderProgram.AttributeBinding"/> that specifies the attribute information.
			/// </param>
			/// <param name="attributeName">
			/// A <see cref="String"/> that specify the attribute which binds to this vertex array.
			/// </param>
			public void SetVertexAttribute(GraphicsContext ctx, ShaderProgram.AttributeBinding programAttrib, string attributeName)
			{
				if (programAttrib == null)
					throw new ArgumentNullException("programAttrib");
				if (attributeName == null)
					throw new ArgumentNullException("attributeName");

				switch (programAttrib.Type) {
					case ShaderAttributeType.Float:
						Gl.VertexAttrib1(programAttrib.Location, (float)DefaultValue.x);
						break;
					case ShaderAttributeType.Vec2:
						Gl.VertexAttrib2(programAttrib.Location, (float)DefaultValue.x, (float)DefaultValue.y);
						break;
					case ShaderAttributeType.Vec3:
						Gl.VertexAttrib3(programAttrib.Location, (float)DefaultValue.x, (float)DefaultValue.y, (float)DefaultValue.z);
						break;
					case ShaderAttributeType.Vec4:
						Gl.VertexAttrib4(programAttrib.Location, (float)DefaultValue.x, (float)DefaultValue.y, (float)DefaultValue.z, (float)DefaultValue.w);
						break;
					default:
						throw new NotImplementedException(String.Format("default value for attributes of type {0} not implemented", programAttrib.Type));
				}
			}

			public T GetElement<T>(uint index) where T : struct
			{
				throw new NotImplementedException();
			}

			public void SetElement<T>(T element, uint index) where T : struct
			{
				throw new NotImplementedException();
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
		internal class InstancedVertexArray : VertexArray
		{
			#region Constructors

			/// <summary>
			/// Construct an InstancedVertexArray for enabling instanced vertex attribute.
			/// </summary>
			/// <param name="arrayBuffer">
			/// A <see cref="ArrayBufferBase"/> which defines a vertex array buffer.
			/// </param>
			/// <param name="sectionIndex">
			/// A <see cref="UInt32"/> that specify the section of <paramref name="arrayBuffer"/>.
			/// </param>
			/// <param name="divisor">
			/// A <see cref="UInt32"/> that specify the number of instances that will pass between updates of the generic attribute.
			/// </param>
			public InstancedVertexArray(ArrayBufferBase arrayBuffer, uint sectionIndex, uint divisor) :
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
			internal override void EnableVertexAttribute(GraphicsContext ctx, uint location, ShaderAttributeType type)
			{
				if (!ctx.Extensions.InstancedArrays)
					throw new NotSupportedException("GL_ARB_instanced_arrays not implemented");

				// Base implementation
				base.EnableVertexAttribute(ctx, location, type);
			}

			internal override void SetAttributeDivisor(GraphicsContext ctx, uint location, ShaderAttributeType type)
			{
				// Attribute divisor
				for (int i = 0; i < type.GetArrayRank(); i++)
					Gl.VertexAttribDivisor((uint)(location + i), Divisor);
			}

			#endregion
		}

		#region SetArray

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferBase arrayBuffer, uint sectionIndex, string attributeName, string blockName)
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
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferBase arrayBuffer, string inputName, string blockName)
		{
			SetArray(arrayBuffer, 0, inputName, blockName);
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferBase arrayBuffer, uint sectionIndex, string semantic)
		{
			SetArray(arrayBuffer, sectionIndex, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Set an array buffer to a shader attribute.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetArray(ArrayBufferBase arrayBuffer, string semantic)
		{
			SetArray(arrayBuffer, 0, semantic, SemanticBlockName);
		}

		#endregion

		#region SetArrayDefault

		/// <summary>
		/// Set a default value to a shader attribute.
		/// </summary>
		/// <param name="defaultValue">
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
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferBase arrayBuffer, uint sectionIndex, uint divisor, string attributeName, string blockName)
		{
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
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferBase arrayBuffer, uint divisor, string inputName, string blockName)
		{
			SetInstancedArray(arrayBuffer, 0, divisor, inputName, blockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferBase arrayBuffer, uint sectionIndex, uint divisor, string semantic)
		{
			SetInstancedArray(arrayBuffer, sectionIndex, divisor, semantic, SemanticBlockName);
		}

		/// <summary>
		/// Set an array buffer to this vertex array.
		/// </summary>
		/// <param name="arrayBuffer">
		/// A <see cref="ArrayBufferBase"/> that specify the contents of the array.
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
		public void SetInstancedArray(ArrayBufferBase arrayBuffer, uint divisor, string semantic)
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
		internal void SetVertexArray(IVertexArray vertexArray, string attributeName, string blockName)
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
		internal IVertexArray GetVertexArray(string attributeName, string attributeBlock)
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
		internal IVertexArray GetVertexArray(string semantic)
		{
			return (GetVertexArray(semantic, SemanticBlockName));
		}

		internal IVertexArray GetVertexArray(string attributeName, ShaderProgram shaderProgram)
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
		/// The vertex array length, based on the property <see cref="ArrayBufferBase.GpuItemsCount"/> of the
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
		[Conditional("GL_DEBUG")]
		private void Validate()
		{
			if (_VertexArrays.Count == 0)
				throw new InvalidOperationException("no array");
		}

		/// <summary>
		/// Determine the actual <see cref="IVertexArray"/> instances used for drawing.
		/// </summary>
		internal virtual IEnumerable<IVertexArray> DrawArrays { get { return (_VertexArrays.Values); } }

		/// <summary>
		/// Array buffer objects required by this vertex array object.
		/// </summary>
		private readonly Dictionary<string, IVertexArray> _VertexArrays = new Dictionary<string, IVertexArray>();

		/// <summary>
		/// Special name for the attributes relative to a semantic.
		/// </summary>
		private const string SemanticBlockName = "##Semantic";
	}
}
