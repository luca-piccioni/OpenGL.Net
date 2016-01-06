
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
	public partial class VertexArrayObject : GraphicsResource
	{
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
		public virtual void Draw(GraphicsContext ctx, ShaderProgram shader)
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
			foreach (VertexElementArray attributeElements in _Elements) {
				if (_FeedbackBuffer != null)
					_FeedbackBuffer.Begin(ctx, attributeElements.ElementsMode);

				attributeElements.Draw(ctx, this);
				
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
			if (ctx.Caps.GlExtensions.VertexArrayObject_ARB && !_VertexArrayDirty) {
				CheckVertexAttributes(ctx, shaderProgram);
				return;
			}

			foreach (string attributeName in shaderProgram.ActiveAttributes) {
				VertexArray shaderVertexArray = GetVertexArray(attributeName, shaderProgram);
				if (shaderVertexArray == null)
					continue;
				
				// Set vertex array state
				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);

				shaderVertexArray.SetVertexAttribute(ctx, shaderProgram, attributeBinding);
			}

			// Next time do not set inputs if GL_ARB_vertex_array_object is supported
			_VertexArrayDirty = false;
		}

		/// <summary>
		/// Utility routine for checking the vertex array state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> on which the shader program is bound.
		/// </param>
		/// <param name="shaderProgram">
		/// A <see cref="ShaderProgram"/> on which the vertex arrays shall be bound.
		/// </param>
		private void CheckVertexAttributes(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			// Vertex array state overall check
			foreach (string attributeName in shaderProgram.ActiveAttributes) {
				ShaderProgram.AttributeBinding attributeBinding = shaderProgram.GetActiveAttribute(attributeName);
				VertexArray shaderVertexArray = GetVertexArray(attributeName, shaderProgram);
				if (shaderVertexArray == null)
					continue;

				shaderVertexArray.CheckVertexAttribute(ctx, attributeBinding);
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
			foreach (VertexElementArray element in _Elements) {
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
				foreach (VertexElementArray vertexIndices in _Elements)
					vertexIndices.Dispose();
			}
		}

		#endregion
	}
}
