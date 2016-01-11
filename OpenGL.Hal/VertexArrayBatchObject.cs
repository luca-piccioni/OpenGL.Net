
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

using System.Collections.Generic;

namespace OpenGL
{
	/// <summary>
	/// A collection of vertex arrays and vertex indices.
	/// </summary>
	public class VertexArrayBatchObject : VertexArrayObject
	{
		#region Vertex Array Batch

		protected void BatchElements()
		{
			List<Element> batchElements = new List<Element>();
			List<Element> batchArrayElements = new List<Element>();
			List<Element> batchIndexElements = new List<Element>();

			// Sort batch elements, to ease batch processing
			// Element groups:
			//   1. Non-indexed primitives (DrawArrays -> MultiDrawArrays)
			//   2. Indexed primitives (DrawElements -> MultiDrawElements)
			// Each group is sorted using the generated primitive, in order to group similar primitives.

			// Split elements
			foreach (Element element in _BatchElements) {
				if (element is IndexedElement)
					batchIndexElements.Add(element);
				else
					batchArrayElements.Add(element);
			}

			//
			batchArrayElements.Sort(delegate (Element x, Element y) {
				IndexedElement xElement = (IndexedElement)x;
				IndexedElement yElement = (IndexedElement)y;

				// 1. compare ElementsMode
				int elementMode = x.ElementsMode.CompareTo(y.ElementsMode);
				if (elementMode != 0)
					return (elementMode);

				// 2. compare ArrayBuffer

				return (0);
			});

			// Re-initialize batch elements
			_BatchElements.Clear();
			_BatchElements.AddRange(_Elements);
		}

		/// <summary>
		/// Collection of elements for drawing arrays.
		/// </summary>
		protected readonly List<Element> _BatchElements = new List<Element>();

		#endregion

		#region VertexArrayObject Overrides

		/// <summary>
		/// Determine the actual <see cref="Element"/> instances used for drawing.
		/// </summary>
		protected override IEnumerable<Element> DrawElements { get { return (_Elements); } }

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
			// Batch elements
			BatchElements();
			// Base implementation
			base.CreateObject(ctx);
		}

		#endregion
	}
}
