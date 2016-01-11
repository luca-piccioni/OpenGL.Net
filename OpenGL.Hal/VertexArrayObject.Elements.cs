
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
	public partial class VertexArrayObject
	{
		/// <summary>
		/// Abstract vertex array element.
		/// </summary>
		protected internal abstract class Element : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="vao">
			/// The <see cref="VertexArrayObject"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how elements are interpreted.
			/// </param>
			protected Element(VertexArrayObject vao, PrimitiveType mode)
			{
				if (vao == null)
					throw new ArgumentNullException("vao");
				_VertexArrayObject = vao;
				ElementsMode = mode;
			}

			/// <summary>
			/// The <see cref="VertexArrayObject"/> to which this element belongs to.
			/// </summary>
			protected readonly VertexArrayObject _VertexArrayObject;

			#endregion

			#region Primitive Mode

			/// <summary>
			/// The primitive used for interpreting the sequence of the array elements.
			/// </summary>
			public readonly PrimitiveType ElementsMode;

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
			/// Draw the elements.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			public abstract void Draw(GraphicsContext ctx);

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
			/// The <see cref="VertexArrayObject"/> to which this element belongs to.
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
			public ArrayElement(VertexArrayObject vao, PrimitiveType mode, uint offset, uint count) :
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
			public ArrayElement(VertexArrayObject vao, PrimitiveType mode) :
				this(vao, mode, 0, 0)
			{
				
			}

			#endregion

			#region Array Range

			/// <summary>
			/// The offset for sending element for drawing.
			/// </summary>
			/// <remarks>
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
			/// The <see cref="VertexArrayObject"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="offsets">
			/// A <see cref="Int32[]"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="counts">
			/// A <see cref="Int32[]"/> that specify the number of array elements drawn.
			/// </param>
			public MultiArrayElement(VertexArrayObject vao, PrimitiveType mode, int[] offsets, int[] counts) :
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
			/// <remarks>
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
			/// The <see cref="VertexArrayObject"/> to which this element belongs to.
			/// </param>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices.
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
			public IndexedElement(VertexArrayObject vao, PrimitiveType mode, ElementBufferObject indices, uint offset, uint count) :
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
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="indices"/> is null.
			/// </exception>
			/// <remarks>
			/// The element indices count is implictly defined by <paramref name="indices"/> at <see cref="Draw(GraphicsContext)"/>
			/// execution time.
			/// </remarks>
			public IndexedElement(VertexArrayObject vao, PrimitiveType mode, ElementBufferObject indices) :
				this(vao, mode, indices, 0, 0)
			{

			}

			#endregion

			#region Element Array

			/// <summary>
			/// An integral buffer that specify vertices by they index.
			/// </summary>
			public readonly ElementBufferObject ArrayIndices;

			#endregion

			#region ArrayElement Overrides

			/// <summary>
			/// Ensure that all required resources are created.
			/// </summary>
			/// <param name="ctx">
			/// The <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				if (ctx == null)
					throw new ArgumentNullException("ctx");
				if (ctx.IsCurrent == false)
					throw new ArgumentException("not current", "ctx");

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
				if (ctx == null)
					throw new ArgumentNullException("ctx");
				if (ctx.IsCurrent == false)
					throw new ArgumentException("not current", "ctx");

				ArrayBufferObjectBase.IArraySection arraySection = ArrayIndices.GetArraySection(0);
				Debug.Assert(arraySection != null);

				// Element array must be (re)bound
				ArrayIndices.Bind(ctx);

				// Enable restart primitive?
				if (ArrayIndices.RestartIndexEnabled) {
					Debug.Assert(ElementCount != 0, "specified ElementCount but primitive restart enabled");

					if (PrimitiveRestart.IsPrimitiveRestartSupported(ctx)) {
						// Enable primitive restart
						PrimitiveRestart.EnablePrimitiveRestart(ctx, ArrayIndices.ElementsType);
						// Draw elements as usual
						Gl.DrawElements(ElementsMode, (int)ElementCount, ArrayIndices.ElementsType, arraySection.Pointer);
						// Disable primitive restart
						PrimitiveRestart.DisablePrimitiveRestart(ctx);
					} else {
						// Note: uses MultiDrawElements to emulate the primitive restart feature; PrimitiveRestartOffsets and
						// PrimitiveRestartCounts are computed at element buffer creation time
						Gl.MultiDrawElements(ElementsMode, ArrayIndices.PrimitiveRestartOffsets, ArrayIndices.ElementsType, ArrayIndices.PrimitiveRestartCounts, ArrayIndices.PrimitiveRestartOffsets.Length);
					}
				} else {
					uint count = (ElementCount == 0) ? ArrayIndices.ItemCount : ElementCount;
					Debug.Assert(count - ElementOffset <= ArrayIndices.ItemCount, "element indices array out of bounds");

					// Draw vertex arrays by indices
					Gl.DrawElements(ElementsMode, (int)count, ArrayIndices.ElementsType, arraySection.Pointer);
				}
			}

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
		public void SetElementArray(PrimitiveType mode)
		{
			// Store element array (entire buffer)
			_Elements.Add(new ArrayElement(this, mode));
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
		public void SetElementArray(PrimitiveType mode, uint offset, uint count)
		{
			// Store element array (entire buffer)
			_Elements.Add(new ArrayElement(this, mode, offset, count));
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
			_Elements.Add(new IndexedElement(this, mode, bufferObject));
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
		/// <param name="offset">
		/// A <see cref="UInt32"/> that specify the offset applied to the drawn elements indices.
		/// </param>
		/// <param name="count">
		/// A <see cref="UInt32"/> that specify the number of element indices drawn.
		/// </param>
		public void SetElementArray(PrimitiveType mode, ElementBufferObject bufferObject, uint offset, uint count)
		{
			if (bufferObject == null)
				throw new ArgumentNullException("bufferObject");
			if (bufferObject.RestartIndexEnabled && (count != 0))
				throw new ArgumentException("invalid count", "count");

			// Store element array
			_Elements.Add(new IndexedElement(this, mode, bufferObject, offset, count));
		}

		/// <summary>
		/// Determine the actual <see cref="Element"/> instances used for drawing.
		/// </summary>
		protected virtual IEnumerable<Element> DrawElements { get { return (_Elements); } }

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		protected readonly List<Element> _Elements = new List<Element>();
	}
}
