
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
		/// A collection of indices reference input arrays.
		/// </summary>
		protected internal class VertexElementArray : IDisposable
		{
			#region Constructors

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
			public VertexElementArray(PrimitiveType mode, ElementBufferObject indices, uint offset, uint count)
			{
				ElementsMode = mode;
				ElementOffset = offset;
				ElementCount = count;
				ArrayIndices = indices;

				if (ArrayIndices != null)
					ArrayIndices.IncRef();
			}

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
			public VertexElementArray(PrimitiveType mode, ElementBufferObject indices) :
				this(mode, indices, 0, 0)
			{

			}

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
			public VertexElementArray(PrimitiveType mode, uint offset, uint count) :
				this(mode, null, offset, count)
			{

			}

			/// <summary>
			/// Specify how all elements shall be drawn.
			/// </summary>
			/// <param name="mode">
			/// A <see cref="PrimitiveType"/> that indicates how array elements are interpreted.
			/// </param>
			public VertexElementArray(PrimitiveType mode) :
				this(mode, null, 0, 0)
			{

			}

			#endregion

			#region Element Array

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
			/// to draw, otherwise it indicates the offset (in bytes) of the first element of
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

			#endregion

			#region Vertex Elements

			/// <summary>
			/// Draw the elements defined by this VertexElementArray.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for drawing.
			/// </param>
			/// <param name="vertexArray">
			/// The <see cref="VertexArrayObject"/> which this VertexElementArray belongs to.
			/// </param>
			public virtual void Draw(GraphicsContext ctx, ShaderProgram shaderProgram, VertexArrayObject vertexArray)
			{
				if (ArrayIndices != null)
					DrawElements(ctx, vertexArray);
				else
					DrawArrays(ctx, vertexArray);
			}

			private void DrawElements(GraphicsContext ctx, VertexArrayObject vertexArray)
			{
				uint count = (ElementCount == 0) ? ArrayIndices.ItemCount : ElementCount;

				Debug.Assert(count - ElementOffset <= ArrayIndices.ItemCount, "element indices array out of bounds");

				// Element array must be (re)bound
				ArrayIndices.Bind(ctx);
				// Enable restart primitive?
				if (ArrayIndices.RestartIndexEnabled)
					PrimitiveRestart.EnablePrimitiveRestart(ctx, ArrayIndices.ElementsType);
				// Draw vertex arrays by indices XXX ElementOffset
				Gl.DrawElements(ElementsMode, (int)count, ArrayIndices.ElementsType, IntPtr.Zero /* (int)ElementOffset */);
				// Keep robust the restart_primitive state
				if (ArrayIndices.RestartIndexEnabled)
					PrimitiveRestart.DisablePrimitiveRestart(ctx);
			}

			private void DrawArrays(GraphicsContext ctx, VertexArrayObject vertexArray)
			{
				uint count = (ElementCount == 0) ? vertexArray._VertexArrayLength : ElementCount;

				Debug.Assert(count - ElementOffset <= vertexArray._VertexArrayLength, "element array out of bounds");

				// Draw vertex array sequentially
				Gl.DrawArrays(ElementsMode, (int)ElementOffset, (int)count);
			}

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose this VertexArray.
			/// </summary>
			public void Dispose()
			{
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
			_Elements.Add(new VertexElementArray(mode));
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
			_Elements.Add(new VertexElementArray(mode, bufferObject));
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
			_Elements.Add(new VertexElementArray(mode, bufferObject, offset, count));
		}

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		protected readonly List<VertexElementArray> _Elements = new List<VertexElementArray>();
	}
}
