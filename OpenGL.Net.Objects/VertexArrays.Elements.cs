
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL.Objects
{
	public partial class VertexArrays
	{
		/// <summary>
		/// Vertex array element interface.
		/// </summary>
		public interface IElement
		{

		}

		/// <summary>
		/// Abstract vertex array element.
		/// </summary>
		protected internal abstract class Element : IElement, IDisposable
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="Objects.VertexArrays"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how elements are interpreted.
			/// </param>
			protected Element(Objects.VertexArrays vao, PrimitiveType mode)
			{
				if (vao == null)
					throw new ArgumentNullException("vao");
				_VertexArrayObject = vao;
				ElementsMode = mode;
			}

			/// <summary>
			/// The <see cref="Objects.VertexArrays"/> to which this element belongs to.
			/// </summary>
			protected readonly Objects.VertexArrays _VertexArrayObject;

			#endregion

			#region Primitive Mode

			/// <summary>
			/// The primitive used for interpreting the sequence of the array elements.
			/// </summary>
			public readonly PrimitiveType ElementsMode;

			/// <summary>
			/// Create a copy of this element, but <see cref="ElementsMode"/> is forced to be <see cref="PrimitiveType.Points"/>.
			/// </summary>
			public abstract Element AsPoint();

			#endregion

			#region Operations

			/// <summary>
			/// Ensure that all required resources are created.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public virtual void Create(GraphicsContext ctx) { }

			/// <summary>
			/// Draw the element.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public abstract void Draw(GraphicsContext ctx);

			/// <summary>
			/// Draw the element, applying an offset and a count.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specifies the offset of the first element to draw.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specifies the number of items to draw.
			/// </param>
			public abstract void Draw(GraphicsContext ctx, uint offset, uint count);

			/// <summary>
			/// Draw the elements instances
			/// </summary>
			///  <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="instances">
			/// A <see cref="UInt32"/> that specify the number of instances to draw.
			/// </param>
			public abstract void DrawInstanced(GraphicsContext ctx, uint instances);

			#endregion

			#region Generation Methods

			/// <summary>
			/// Generate normals for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public virtual void GenerateNormals(Objects.VertexArrays vertexArray)
			{
				throw new NotImplementedException();
			}

			/// <summary>
			/// Generate texture coordinates for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public virtual void GenerateTexCoord(Objects.VertexArrays vertexArray, VertexArrayTexGenDelegate genTexCoordCallback)
			{
				throw new NotImplementedException();
			}

			/// <summary>
			/// Generate tangents for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public virtual void GenerateTangents(Objects.VertexArrays vertexArray)
			{
				throw new NotImplementedException();
			}

			/// <summary>
			/// Generate bitangents for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public virtual void GenerateBitangents(Objects.VertexArrays vertexArray)
			{
				throw new NotImplementedException();
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this Element.
			/// </summary>
			public virtual void Dispose()
			{
				
			}

			#endregion
		}

		/// <summary>
		/// Vertex array element drawing vertices directly (<see cref="Gl.DrawArrays(PrimitiveType, int, int)"/>.
		/// </summary>
		protected internal class ArrayElement : Element
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="Objects.VertexArrays"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public ArrayElement(Objects.VertexArrays vao, PrimitiveType mode, uint offset, uint count) :
				base(vao, mode)
			{
				ElementOffset = offset;
				ElementCount = count;
			}

			/// <summary>
			/// Specify which elements shall be drawn.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <remarks>
			/// The array elements count is implictly defined as the vertex array length at <see cref="Draw(GraphicsContext)"/>
			/// execution time.
			/// </remarks>
			public ArrayElement(Objects.VertexArrays vao, PrimitiveType mode) :
				this(vao, mode, 0, 0)
			{
				
			}

			#endregion

			#region Array Range

			/// <summary>
			/// The offset for sending element for drawing.
			/// </summary>
			public readonly uint ElementOffset;

			/// <summary>
			/// The number of array elements to draw.
			/// </summary>
			/// <remarks>
			/// In the case this field equals to 0, it means that all array elements defined in the vertex array shall be drawn.
			/// </remarks>
			public readonly uint ElementCount;

			#endregion

			#region Element Overrides

			/// <summary>
			/// Create a copy of this element, but <see cref="ElementsMode"/> is forced to be <see cref="PrimitiveType.Points"/>.
			/// </summary>
			public override Element AsPoint() { return (new ArrayElement(_VertexArrayObject, PrimitiveType.Points, ElementOffset, ElementCount)); }

			/// <summary>
			/// Draw the elements.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public override void Draw(GraphicsContext ctx)
			{
				uint count = ElementCount != 0 ? ElementCount : _VertexArrayObject.ArrayLength;

				Gl.DrawArrays(ElementsMode, (int)ElementOffset, (int)count);
			}

			/// <summary>
			/// Draw the element, applying an offset and a count.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specifies the offset of the first element to draw.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specifies the number of items to draw.
			/// </param>
			public override void Draw(GraphicsContext ctx, uint offset, uint count)
			{
				Gl.DrawArrays(ElementsMode, (int)(ElementOffset + offset), (int)count);
			}

			/// <summary>
			/// Draw the elements instances
			/// </summary>
			///  <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="instances">
			/// A <see cref="UInt32"/> that specify the number of instances to draw.
			/// </param>
			public override void DrawInstanced(GraphicsContext ctx, uint instances)
			{
				uint count = ElementCount != 0 ? ElementCount : _VertexArrayObject.ArrayLength;

				Gl.DrawArraysInstanced(ElementsMode, (int)ElementOffset, (int)count, (int)instances);
			}

			/// <summary>
			/// Generate normals for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public override void GenerateNormals(Objects.VertexArrays vertexArray)
			{
				IVertexArray positionArray = vertexArray.GetVertexArray(VertexArraySemantic.Position);
				if (positionArray == null)
					throw new InvalidOperationException("position semantic not set");

				IVertexArray normalArray = vertexArray.GetVertexArray(VertexArraySemantic.Normal);
				if (normalArray == null)
					throw new InvalidOperationException("normal semantic not set");
				if (normalArray.Array == null)
					throw new InvalidOperationException("normal array not set");

				if (positionArray.Array != null)
					positionArray.Array.Map();
				normalArray.Array.Map();

				try {
					switch (ElementsMode) {
						case PrimitiveType.Triangles:
							switch (positionArray.ArraySection.ItemType) {
								case ArrayBufferItemType.Float3:
									GenerateNormalsTriangle3f(positionArray, normalArray);
									break;
								case ArrayBufferItemType.Float4:
									GenerateNormalsTriangle4f(positionArray, normalArray);
									break;
								default:
									throw new NotSupportedException("normals generation not supported for elements of type " + positionArray.ArraySection.ItemType);
							}
							break;
						default:
							throw new NotSupportedException("normals generation not supported for primitive " + ElementsMode);
					}
				} finally {
					if (positionArray.Array != null)
						positionArray.Array.Unmap();
					normalArray.Array.Unmap();
				}
			}

			#region Normals Generation

			private void GenerateNormalsTriangle4f(IVertexArray positionArray, IVertexArray normalArray)
			{
				uint count = (ElementCount != 0 ? ElementCount : _VertexArrayObject.ArrayLength) / 3;

				for (uint i = 0, v = ElementOffset; i < count; i++) {
					Vertex3f v0 = (Vertex3f)positionArray.GetElement<Vertex4f>(v++);
					Vertex3f v1 = (Vertex3f)positionArray.GetElement<Vertex4f>(v++);
					Vertex3f v2 = (Vertex3f)positionArray.GetElement<Vertex4f>(v++);

					Vertex3f n = ((v2 - v0) ^ (v1 - v0)).Normalized;

					normalArray.SetElement<Vertex3f>(n, v - 2);
					normalArray.SetElement<Vertex3f>(n, v - 1);
					normalArray.SetElement<Vertex3f>(n, v - 0);
				}
			}

			private void GenerateNormalsTriangle3f(IVertexArray positionArray, IVertexArray normalArray)
			{
				uint count = (ElementCount != 0 ? ElementCount : _VertexArrayObject.ArrayLength) / 3;

				for (uint i = 0, v = ElementOffset; i < count; i++) {
					Vertex3f v0 = positionArray.GetElement<Vertex3f>(v++);
					Vertex3f v1 = positionArray.GetElement<Vertex3f>(v++);
					Vertex3f v2 = positionArray.GetElement<Vertex3f>(v++);

					Vertex3f n = ((v2 - v0) ^ (v1 - v0)).Normalized;

					normalArray.SetElement<Vertex3f>(n, v - 2);
					normalArray.SetElement<Vertex3f>(n, v - 1);
					normalArray.SetElement<Vertex3f>(n, v - 0);
				}
			}

			#endregion

			/// <summary>
			/// Generate tangents for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public override void GenerateTangents(Objects.VertexArrays vertexArray)
			{
				IVertexArray positionArray = vertexArray.GetVertexArray(VertexArraySemantic.Position);
				if (positionArray == null)
					throw new InvalidOperationException("position semantic not set");
				IVertexArray texArray = vertexArray.GetVertexArray(VertexArraySemantic.TexCoord);
				if (texArray == null)
					throw new InvalidOperationException("texture semantic not set");

				IVertexArray normalArray = vertexArray.GetVertexArray(VertexArraySemantic.Normal);
				if (normalArray == null)
					throw new InvalidOperationException("normal semantic not set");
				if (normalArray.Array == null)
					throw new InvalidOperationException("normal array not set");

				IVertexArray tanArray = vertexArray.GetVertexArray(VertexArraySemantic.Tangent);
				if (tanArray == null)
					throw new InvalidOperationException("tangent semantic not set");
				if (tanArray.Array == null)
					throw new InvalidOperationException("tangent array not set");

				IVertexArray bitanArray = vertexArray.GetVertexArray(VertexArraySemantic.Bitangent);
				if (bitanArray == null)
					throw new InvalidOperationException("bitangent semantic not set");
				if (bitanArray.Array == null)
					throw new InvalidOperationException("bitangent array not set");

				if (positionArray.Array != null)
					positionArray.Array.Map();
				if (texArray.Array != null)
					texArray.Array.Map();
				normalArray.Array.Map();
				tanArray.Array.Map();
				bitanArray.Array.Map();

				try {
					switch (ElementsMode) {
						case PrimitiveType.Triangles:
							switch (positionArray.ArraySection.ItemType) {
								case ArrayBufferItemType.Float4:
									GenerateTangentsTriangle4f(positionArray, normalArray, texArray, tanArray, bitanArray);
									break;
								default:
									throw new NotSupportedException("normals generation not supported for elements of type " + positionArray.ArraySection.ItemType);
							}
							break;
						default:
							throw new NotSupportedException("normals generation not supported for primitive " + ElementsMode);
					}
				} finally {
					if (positionArray.Array != null)
						positionArray.Array.Unmap();
					if (texArray.Array != null)
						texArray.Array.Unmap();
					normalArray.Array.Unmap();
					tanArray.Array.Unmap();
					bitanArray.Array.Unmap();
				}
			}

			#region Tangents Generation

			private void GenerateTangentsTriangle4f(IVertexArray positionArray, IVertexArray normalArray, IVertexArray texArray, IVertexArray tanArray, IVertexArray bitanArray)
			{
				uint count = (ElementCount != 0 ? ElementCount : _VertexArrayObject.ArrayLength) / 3;

				for (uint i = 0, v = ElementOffset; i < count; i++, v += 3) {
					Vertex3f v0 = (Vertex3f)positionArray.GetElement<Vertex4f>(v);
					Vertex3f v1 = (Vertex3f)positionArray.GetElement<Vertex4f>(v + 1);
					Vertex3f v2 = (Vertex3f)positionArray.GetElement<Vertex4f>(v + 2);

					Vertex2f t0 = texArray.GetElement<Vertex2f>(v);
					Vertex2f t1 = texArray.GetElement<Vertex2f>(v + 1);
					Vertex2f t2 = texArray.GetElement<Vertex2f>(v + 2);

					Vertex3f dv1 = v1 - v0, dv2 = v2 - v0;
					Vertex2f dt1 = t1 - t0, dt2 = t2 - t0;
					float w = 1.0f / (dt1.x * dt2.y - dt1.y * dt2.x);

					Vertex3f tgVector, btVector;

					if (Single.IsInfinity(w) == false) {
						tgVector = (dv1 * dt2.y - dv2 * dt1.y) * w;
						tgVector.Normalize();

						btVector = (dv2 * dt1.x - dv1 * dt2.x) * w;
						btVector.Normalize();

						Vertex3f n = normalArray.GetElement<Vertex3f>(v).Normalized;

						n.Normalize();

						if (((n ^ tgVector) * btVector) < 0.0f)
							tgVector = tgVector * -1.0f;
					} else {
						// Degenerate triangles does not contribute
						tgVector = btVector = Vertex3f.Zero;
					}

					tanArray.SetElement<Vertex3f>(tgVector, v);
					tanArray.SetElement<Vertex3f>(tgVector, v + 1);
					tanArray.SetElement<Vertex3f>(tgVector, v + 2);

					bitanArray.SetElement<Vertex3f>(btVector, v);
					bitanArray.SetElement<Vertex3f>(btVector, v + 1);
					bitanArray.SetElement<Vertex3f>(btVector, v + 2);
				}
			}

			#endregion

			#endregion
		}

		/// <summary>
		/// Vertex array element drawing vertices directly (<see cref="Gl.MultiDrawArrays(PrimitiveType, int[], int[], int)"/>.
		/// </summary>
		protected internal class MultiArrayElement : Element
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="Objects.VertexArrays"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="offsets">
			/// A <see cref="T:Int32[]"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="counts">
			/// A <see cref="T:Int32[]"/> that specify the number of array elements drawn.
			/// </param>
			public MultiArrayElement(Objects.VertexArrays vao, PrimitiveType mode, int[] offsets, int[] counts) :
				base(vao, mode)
			{
				if (offsets == null)
					throw new ArgumentNullException("offset");
				if (counts == null)
					throw new ArgumentNullException("count");
				if (offsets.Length == 0)
					throw new ArgumentException("invalid size", "offset");
				if (counts.Length != offsets.Length)
					throw new ArgumentException("no mtaching length with offsets", "count");

				ArrayOffsets = offsets;
				ArrayCounts = counts;
			}

			#endregion

			#region Array Range

			/// <summary>
			/// The offset for sending element for drawing.
			/// </summary>
			public readonly int[] ArrayOffsets;

			/// <summary>
			/// The number of array elements to draw.
			/// </summary>
			/// <remarks>
			/// In the case this field equals to 0, it means that all array elements defined in the vertex array shall be drawn.
			/// </remarks>
			public readonly int[] ArrayCounts;

			#endregion

			#region Element Overrides

			/// <summary>
			/// Create a copy of this element, but <see cref="ElementsMode"/> is forced to be <see cref="PrimitiveType.Points"/>.
			/// </summary>
			public override Element AsPoint() { return (new MultiArrayElement(_VertexArrayObject, PrimitiveType.Points, ArrayOffsets, ArrayCounts)); }

			/// <summary>
			/// Draw the elements.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public override void Draw(GraphicsContext ctx)
			{
				if (ctx == null)
					throw new ArgumentNullException("ctx");
				if (ctx.IsCurrent == false)
					throw new ArgumentException("not current", "ctx");

				Gl.MultiDrawArrays(ElementsMode, ArrayOffsets, ArrayCounts, ArrayOffsets.Length);
			}

			/// <summary>
			/// Draw the element, applying an offset and a count.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specifies the offset of the first element to draw.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specifies the number of items to draw.
			/// </param>
			public override void Draw(GraphicsContext ctx, uint offset, uint count)
			{
				throw new NotImplementedException("TBD");
			}

			/// <summary>
			/// Draw the elements instances
			/// </summary>
			///  <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="instances">
			/// A <see cref="UInt32"/> that specify the number of instances to draw.
			/// </param>
			public override void DrawInstanced(GraphicsContext ctx, uint instances)
			{
				throw new NotSupportedException();
			}

			#endregion
		}

		/// <summary>
		/// A collection of indices reference input arrays (<see cref="Gl.DrawElements(PrimitiveType, int, DrawElementsType, IntPtr)"/>).
		/// </summary>
		protected internal class IndexedElement : ArrayElement
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of element indices.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="VertexArrays"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBuffer"/> containing the indices of the drawn vertices.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn elements indices.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of element indices drawn.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="indices"/> is null.
			/// </exception>
			public IndexedElement(VertexArrays vao, PrimitiveType mode, ElementBuffer indices, uint offset, uint count) :
				base(vao, mode, offset, count)
			{
				if (indices == null)
					throw new ArgumentNullException("indices");

				ArrayIndices = indices;
				ArrayIndices.IncRef();
			}

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of element indices.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="VertexArrays"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBuffer"/> containing the indices of the drawn vertices.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="indices"/> is null.
			/// </exception>
			/// <remarks>
			/// The element indices count is implictly defined by <paramref name="indices"/> at <see cref="Draw(GraphicsContext)"/>
			/// execution time.
			/// </remarks>
			public IndexedElement(VertexArrays vao, PrimitiveType mode, ElementBuffer indices) :
				this(vao, mode, indices, 0, 0)
			{

			}

			#endregion

			#region Element Array

			/// <summary>
			/// An integral buffer that specify vertices by they index.
			/// </summary>
			public readonly ElementBuffer ArrayIndices;

			#endregion

			#region ArrayElement Overrides

			/// <summary>
			/// Create a copy of this element, but <see cref="ElementsMode"/> is forced to be <see cref="PrimitiveType.Points"/>.
			/// </summary>
			public override Element AsPoint()
			{
				return (new IndexedElement(_VertexArrayObject, PrimitiveType.Points, ArrayIndices, ElementOffset, ElementCount));
			}

			/// <summary>
			/// Ensure that all required resources are created.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				CheckCurrentContext(ctx);

				if (ArrayIndices.Exists(ctx) == false)
					ArrayIndices.Create(ctx);
			}

			/// <summary>
			/// Draw the elements.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public override void Draw(GraphicsContext ctx)
			{
				CheckCurrentContext(ctx);

				ArrayBufferBase.IArraySection arraySection = ArrayIndices.GetArraySection(0);
				Debug.Assert(arraySection != null);

				// Element array must be (re)bound
				ctx.Bind(ArrayIndices, true);

				// Enable restart primitive?
				if (ArrayIndices.RestartIndexEnabled) {
					if (ctx.Extensions.PrimitiveRestart || ctx.Extensions.PrimitiveRestart_NV) {
						new State.PrimitiveRestartState(ArrayIndices.RestartIndexKey).Apply(ctx, null);

						// Draw elements with primitive restart
						DrawElements(ctx, arraySection.Pointer);
					} else {
						// Note: uses MultiDrawElements to emulate the primitive restart feature; PrimitiveRestartOffsets and
						// PrimitiveRestartCounts are computed at element buffer creation time
						Gl.MultiDrawElements(ElementsMode, ArrayIndices.PrimitiveRestartOffsets, ArrayIndices.ElementsType, ArrayIndices.PrimitiveRestartCounts, ArrayIndices.PrimitiveRestartOffsets.Length);
					}
				} else {
					uint count = (ElementCount == 0) ? ArrayIndices.GpuItemsCount : ElementCount;
					Debug.Assert(count - ElementOffset <= ArrayIndices.GpuItemsCount, "element indices array out of bounds");

					// Disable primitive restart, if enabled
					if (ctx.Extensions.PrimitiveRestart || ctx.Extensions.PrimitiveRestart_NV)
						State.PrimitiveRestartState.DefaultState.Apply(ctx, null);

					// Draw vertex arrays by indices
					DrawElements(ctx, arraySection.Pointer);
				}
			}

			/// <summary>
			/// Draw the element, applying an offset and a count.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specifies the offset of the first element to draw.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specifies the number of items to draw.
			/// </param>
			public override void Draw(GraphicsContext ctx, uint offset, uint count)
			{
				throw new NotImplementedException("TBD");
			}

			/// <summary>
			/// Draw the elements instances
			/// </summary>
			///  <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="instances">
			/// A <see cref="UInt32"/> that specify the number of instances to draw.
			/// </param>
			public override void DrawInstanced(GraphicsContext ctx, uint instances)
			{
				CheckCurrentContext(ctx);

				ArrayBufferBase.IArraySection arraySection = ArrayIndices.GetArraySection(0);
				Debug.Assert(arraySection != null);

				// Element array must be (re)bound
				ctx.Bind(ArrayIndices, true);

				// Enable restart primitive?
				if (ArrayIndices.RestartIndexEnabled) {
					if (ctx.Extensions.PrimitiveRestart || ctx.Extensions.PrimitiveRestart_NV) {
						new State.PrimitiveRestartState(ArrayIndices.RestartIndexKey).Apply(ctx, null);

						DrawElementsInstanced(ctx, arraySection.Pointer, instances);
					} else {
						throw new NotSupportedException("DrawInstanced primitive restart emulation not supported");
					}
				} else {
					uint count = (ElementCount == 0) ? ArrayIndices.GpuItemsCount : ElementCount;
					Debug.Assert(count - ElementOffset <= ArrayIndices.GpuItemsCount, "element indices array out of bounds");

					// Disable primitive restart, if enabled
					if (ctx.Extensions.PrimitiveRestart || ctx.Extensions.PrimitiveRestart_NV)
						State.PrimitiveRestartState.DefaultState.Apply(ctx, null);

					// Draw vertex arrays by indices
					DrawElementsInstanced(ctx, arraySection.Pointer, instances);
				}
			}

			/// <summary>
			/// Draw the elements indices.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			protected virtual void DrawElements(GraphicsContext ctx, IntPtr pointer)
			{
				uint count = (ElementCount == 0) ? ArrayIndices.GpuItemsCount : ElementCount;
				Debug.Assert(count - ElementOffset <= ArrayIndices.GpuItemsCount, "element indices array out of bounds");

				// Draw elements as usual
				Gl.DrawElements(ElementsMode, (int)count, ArrayIndices.ElementsType, pointer);
			}

			/// <summary>
			/// Draw the elements indices.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			protected virtual void DrawElementsInstanced(GraphicsContext ctx, IntPtr pointer, uint instances)
			{
				uint count = (ElementCount == 0) ? ArrayIndices.GpuItemsCount : ElementCount;
				Debug.Assert(count - ElementOffset <= ArrayIndices.GpuItemsCount, "element indices array out of bounds");

				// Draw elements
				Gl.DrawElementsInstanced(ElementsMode, (int)count, ArrayIndices.ElementsType, pointer, (int)instances);
			}

			/// <summary>
			/// Generate texture coordinates for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public override void GenerateTexCoord(VertexArrays vertexArray, VertexArrayTexGenDelegate genTexCoordCallback)
			{
				IVertexArray positionArray = vertexArray.GetVertexArray(VertexArraySemantic.Position);
				if (positionArray == null)
					throw new InvalidOperationException("position semantic not set");

				IVertexArray texArray = vertexArray.GetVertexArray(VertexArraySemantic.TexCoord);
				if (texArray == null)
					throw new InvalidOperationException("texture semantic not set");
				if (texArray.Array == null)
					throw new InvalidOperationException("texture array not set");

				if (positionArray.Array != null)
					positionArray.Array.Map();
				texArray.Array.Map();
				ArrayIndices.Map();

				try {
					switch (ElementsMode) {
						case PrimitiveType.Triangles:
						case PrimitiveType.TriangleStrip:
							switch (positionArray.ArraySection.ItemType) {
								case ArrayBufferItemType.Float3:
									GenerateTexCoordsTriangle3f(positionArray, texArray, genTexCoordCallback);
									break;
								default:
									throw new NotSupportedException("normals generation not supported for elements of type " + positionArray.ArraySection.ItemType);
							}
							break;
						default:
							throw new NotSupportedException("normals generation not supported for primitive " + ElementsMode);
					}
				} finally {
					if (positionArray.Array != null)
						positionArray.Array.Unmap();
					texArray.Array.Unmap();
					ArrayIndices.Unmap();
				}
			}

			private void GenerateTexCoordsTriangle3f(IVertexArray positionArray, IVertexArray texArray, VertexArrayTexGenDelegate genTexCoordCallback)
			{
				for (uint i = 0, v = ElementOffset; i < ArrayIndices.CpuItemsCount; i++, v++) {
					uint vIndex = ArrayIndices.GetIndex(v);

					Vertex3f v0 = positionArray.GetElement<Vertex3f>(vIndex);

					texArray.SetElement<Vertex2f>(genTexCoordCallback(v0), vIndex);
				}
			}

			/// <summary>
			/// Generate tangents for this Element.
			/// </summary>
			/// <param name="vertexArray">
			/// The <see cref="Objects.VertexArrays"/>
			/// </param>
			public override void GenerateTangents(Objects.VertexArrays vertexArray)
			{
				IVertexArray positionArray = vertexArray.GetVertexArray(VertexArraySemantic.Position);
				if (positionArray == null)
					throw new InvalidOperationException("position semantic not set");
				IVertexArray texArray = vertexArray.GetVertexArray(VertexArraySemantic.TexCoord);
				if (texArray == null)
					throw new InvalidOperationException("texture semantic not set");

				IVertexArray normalArray = vertexArray.GetVertexArray(VertexArraySemantic.Normal);
				if (normalArray == null)
					throw new InvalidOperationException("normal semantic not set");
				if (normalArray.Array == null)
					throw new InvalidOperationException("normal array not set");

				IVertexArray tanArray = vertexArray.GetVertexArray(VertexArraySemantic.Tangent);
				if (tanArray == null)
					throw new InvalidOperationException("tangent semantic not set");
				if (tanArray.Array == null)
					throw new InvalidOperationException("tangent array not set");

				IVertexArray bitanArray = vertexArray.GetVertexArray(VertexArraySemantic.Bitangent);
				if (bitanArray == null)
					throw new InvalidOperationException("bitangent semantic not set");
				if (bitanArray.Array == null)
					throw new InvalidOperationException("bitangent array not set");

				if (positionArray.Array != null)
					positionArray.Array.Map();
				if (texArray.Array != null)
					texArray.Array.Map();
				normalArray.Array.Map();
				tanArray.Array.Map();
				bitanArray.Array.Map();
				ArrayIndices.Map();

				try {
					switch (ElementsMode) {
						case PrimitiveType.TriangleStrip:
							switch (positionArray.ArraySection.ItemType) {
								case ArrayBufferItemType.Float3:
									GenerateTangentsTriangleStrip3f(positionArray, normalArray, texArray, tanArray, bitanArray);
									break;
								default:
									throw new NotSupportedException("normals generation not supported for elements of type " + positionArray.ArraySection.ItemType);
							}
							break;
						default:
							throw new NotSupportedException("normals generation not supported for primitive " + ElementsMode);
					}
				} finally {
					if (positionArray.Array != null)
						positionArray.Array.Unmap();
					if (texArray.Array != null)
						texArray.Array.Unmap();
					normalArray.Array.Unmap();
					tanArray.Array.Unmap();
					bitanArray.Array.Unmap();
					ArrayIndices.Unmap();
				}
			}

			#region Tangents Generation

			private void GenerateTangentsTriangleStrip3f(IVertexArray positionArray, IVertexArray normalArray, IVertexArray texArray, IVertexArray tanArray, IVertexArray bitanArray)
			{
				uint count = ElementCount != 0 ? ElementCount : ArrayIndices.CpuItemsCount;

				uint     i0, i1, i2;
				Vertex3f v0, v1, v2;
				Vertex2f t0, t1, t2;

				i0 = ArrayIndices.GetIndex(ElementOffset);
				i1 = ArrayIndices.GetIndex(ElementOffset + 1);

				v0 = positionArray.GetElement<Vertex3f>(i0);
				v1 = positionArray.GetElement<Vertex3f>(i1);

				t0 = texArray.GetElement<Vertex2f>(i0);
				t1 = texArray.GetElement<Vertex2f>(i1);

				for (uint i = 0, v = ElementOffset + 2; i < count - 2; i++, v++) {
					// Next triangle
					i2 = ArrayIndices.GetIndex(v);
					v2 = positionArray.GetElement<Vertex3f>(i2);
					t2 = texArray.GetElement<Vertex2f>(i2);

					// Compute tangent & bitangent
					Vertex3f dv1 = v1 - v0, dv2 = v2 - v0;
					Vertex2f dt1 = t1 - t0, dt2 = t2 - t0;

					float w = 1.0f / (dt1.x * dt2.y - dt1.y * dt2.x);

					Vertex3f tgVector, btVector;

					if (Single.IsInfinity(w) == false) {
						tgVector = (dv1 * dt2.y - dv2 * dt1.y) * w;
						tgVector.Normalize();

						btVector = (dv2 * dt1.x - dv1 * dt2.x) * w;
						btVector.Normalize();

						//Vertex3f n = normalArray.GetElement<Vertex3f>(i2);
							
						//n.Normalize();

						//if (((n ^ tgVector) * btVector) < 0.0f)
						//	tgVector = tgVector * -1.0f;
					} else {
						// Degenerate triangles does not contribute
						tgVector = btVector = Vertex3f.Zero;
					}

					// Store (accumulate adjacent triangles)
					Vertex3f tg0 = tanArray.GetElement<Vertex3f>(i0) + tgVector;
					Vertex3f tg1 = tanArray.GetElement<Vertex3f>(i1) + tgVector;
					Vertex3f tg2 = tanArray.GetElement<Vertex3f>(i2) + tgVector;

					tanArray.SetElement<Vertex3f>(tg0, i0);
					tanArray.SetElement<Vertex3f>(tg1, i1);
					tanArray.SetElement<Vertex3f>(tg2, i2);

					Vertex3f bt0 = bitanArray.GetElement<Vertex3f>(i0) + btVector;
					Vertex3f bt1 = bitanArray.GetElement<Vertex3f>(i1) + btVector;
					Vertex3f bt2 = bitanArray.GetElement<Vertex3f>(i2) + btVector;

					bitanArray.SetElement<Vertex3f>(bt0, i0);
					bitanArray.SetElement<Vertex3f>(bt1, i1);
					bitanArray.SetElement<Vertex3f>(bt2, i2);

					// Prepare for next triangle
					i0 = i1;
					i1 = i2;
				}
			}

			#endregion

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public override void Dispose()
			{
				// Base implementation
				base.Dispose();
				// Dereference array buffer
				if (ArrayIndices != null)
					ArrayIndices.DecRef();
			}

			#endregion
		}

		/// <summary>
		/// Specify the entire array to be drawn sequentially.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <returns>
		/// It returns the index of the element set.
		/// </returns>
		public int SetElementArray(PrimitiveType mode)
		{
			// Store element array (entire buffer)
			_Elements.Add(new ArrayElement(this, mode));

			return (_Elements.Count - 1);
		}

		/// <summary>
		/// Specify the entire array to be drawn sequentially.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of array elements drawn.
		/// </param>
		public int SetElementArray(PrimitiveType mode, uint offset, uint count)
		{
			// Store element array (entire buffer)
			_Elements.Add(new ArrayElement(this, mode, offset, count));

			return (_Elements.Count - 1);
		}

		/// <summary>
		/// Set a buffer object which specify the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBuffer"/> that specify a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		public int SetElementArray(PrimitiveType mode, ElementBuffer bufferObject)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");

			// Store element array
			_Elements.Add(new IndexedElement(this, mode, bufferObject));

			return (_Elements.Count - 1);
		}

		/// <summary>
		/// Set a buffer object which specify the element arrays.
		/// </summary>
		/// <param name="mode">
		/// A <see cref="PrimitiveType"/> that specify how arrays elements are interpreted.
		/// </param>
		/// <param name="bufferObject">
		/// A <see cref="ElementBuffer"/> that specify a sequence of indices that defines the
		/// array element sequence.
		/// </param>
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the offset applied to the drawn elements indices.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of element indices drawn.
		/// </param>
		public int SetElementArray(PrimitiveType mode, ElementBuffer bufferObject, uint offset, uint count)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");

			// Store element array
			_Elements.Add(new IndexedElement(this, mode, bufferObject, offset, count));

			return (_Elements.Count - 1);
		}

		/// <summary>
		/// Get the vertex array element by its index.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public IElement GetElementArray(int index)
		{
			if (index < 0 || index >= _Elements.Count)
				throw new ArgumentOutOfRangeException("index");

			return (_Elements[index]);
		}

		/// <summary>
		/// Combine a set of array elements to form a multi-draw compatible element.
		/// </summary>
		/// <param name="multiElements">
		/// A <see cref="IEnumerable{IElement}"/> that specifies all elements to be drawn using multi-draw
		/// primitive.
		/// </param>
		/// <returns>
		/// It returns a <see cref="IElement"/> that allow drawing <paramref name="multiElements"/> at once
		/// using the multi-draw primitive.
		/// </returns>
		public IElement CombineArrayElements(IEnumerable<IElement> multiElements)
		{
			if (multiElements == null)
				throw new ArgumentNullException("multiElements");

			List<int> multiOffsets = new List<int>();
			List<int> multiCounts = new List<int>();
			PrimitiveType? multiPrimitive = null;

			foreach (IElement element in multiElements) {
				ArrayElement arrayElement = (ArrayElement)element;

				if (multiPrimitive.HasValue && (multiPrimitive.Value != arrayElement.ElementsMode))
					throw new ArgumentException("multi-draw with multiple element modes", "multiElements");
				multiPrimitive = arrayElement.ElementsMode;
				multiOffsets.Add((int)arrayElement.ElementOffset);
				multiCounts.Add((int)arrayElement.ElementCount);
			}

			if (multiPrimitive.HasValue == false)
				throw new ArgumentException("no items", "multiElements");

			return (new MultiArrayElement(this, multiPrimitive.Value, multiOffsets.ToArray(), multiCounts.ToArray()));
		}

		/// <summary>
		/// Determine the actual <see cref="Element"/> instances used for drawing.
		/// </summary>
		protected virtual IEnumerable<IElement> DrawElements { get { return (_Elements); } }

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		private readonly List<IElement> _Elements = new List<IElement>();
	}
}
