
// Copyright (C) 2012-2013 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// A collection of patch arrays.
	/// </summary>
	public class PatchArrayObject : VertexArrayObject
	{
		#region Patch Elements Definitions

		/// <summary>
		/// A collection of indices reference input arrays.
		/// </summary>
		class PatchAttributeElement : IndexedElement
		{
			/// <summary>
			/// Specify how all elements shall be drawn.
			/// </summary>
			/// <param name="patchCount">
			/// A <see cref="UInt32"/> that specify how many vertices has a single patch.
			/// </param>
			public PatchAttributeElement(uint patchCount) : this(patchCount, null, 0, 0) { }

			/// <summary>
			/// Specify which elements shall be drawn, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="patchCount">
			/// A <see cref="UInt32"/> that specify how many vertices has a single patch.
			/// </param>
			/// <param name="offset">
			/// A <see cref="UInt32"/> that specify the offset applied to the drawn array elements.
			/// </param>
			/// <param name="count">
			/// A <see cref="UInt32"/> that specify the number of array elements drawn.
			/// </param>
			public PatchAttributeElement(uint patchCount, uint offset, uint count) : this(patchCount, null, offset, count) { }

			/// <summary>
			/// Specify which elements shall be drawn by indexing them.
			/// </summary>
			/// <param name="patchCount">
			/// A <see cref="UInt32"/> that specify how many vertices has a single patch.
			/// </param>
			/// <param name="indices">
			/// A <see cref="ElementBufferObject"/> containing the indices of the drawn vertices. If it null, no indices are
			/// used for drawing; instead, all array elements are drawns, starting from the first one. If it is not null, all
			/// indices are drawn starting from the first one.
			/// </param>
			public PatchAttributeElement(uint patchCount, ElementBufferObject indices) : this(patchCount, indices, 0, 0) { }

			/// <summary>
			/// Specify which elements shall be drawn by indexing them, specifying an offset and the number of elements.
			/// </summary>
			/// <param name="patchCount">
			/// A <see cref="UInt32"/> that specify how many vertices has a single patch.
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
			public PatchAttributeElement(uint patchCount, ElementBufferObject indices, uint offset, uint count)
				: base(PrimitiveType.Patches, indices, offset, count)
			{
				PatchCount = patchCount;
			}

			/// <summary>
			/// The number of vertices defining a single patch.
			/// </summary>
			public readonly uint PatchCount;
		}

		public void SetPatchArray(uint patchCount)
		{
			if (patchCount < 3)
				throw new ArgumentException("invalid", "patchCount");
			if (_PatchElement != null)
				throw new InvalidOperationException("only one patch element is supported");

			_PatchElement = new PatchAttributeElement(patchCount);
		}

		public void SetPatchArray(uint patchCount, ElementBufferObject bufferObject)
		{
			if (patchCount < 3)
				throw new ArgumentException("invalid", "patchCount");
			if (_PatchElement != null)
				throw new InvalidOperationException("only one patch element is supported");

			_PatchElement = new PatchAttributeElement(patchCount, bufferObject);
		}

		public void SetPatchArray(uint patchCount, ElementBufferObject bufferObject, uint offset, uint count)
		{
			if (patchCount < 3)
				throw new ArgumentException("invalid", "patchCount");
			if (_PatchElement != null)
				throw new InvalidOperationException("only one patch element is supported");

			_PatchElement = new PatchAttributeElement(patchCount, bufferObject, offset, count);
		}

		/// <summary>
		/// Element for drawing patches.
		/// </summary>
		private PatchAttributeElement _PatchElement;

		#endregion

		#region VertexArrayObject Overrides

		/// <summary>
		/// Render this vertex array.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for rendering.
		/// </param>
		/// <param name="shaderProgram">
		/// The <see cref="ShaderProgram"/> used for drawing this vertex array.
		/// </param>
		public override void Draw(GraphicsContext ctx, ShaderProgram shaderProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent == false)
				throw new ArgumentException("not current", "ctx");
			if (shaderProgram == null)
				throw new ArgumentNullException("shaderProgram");
			if (shaderProgram.Exists(ctx) == false)
				throw new ArgumentException("not existing", "shaderProgram");
			if (Exists(ctx) == false)
				throw new InvalidOperationException("not existing");
			if (_Elements.Count == 0 && _PatchElement == null)
				throw new InvalidOperationException("no elements defined");

			if (_PatchElement != null) {
				// Setup patch vertices
				Gl.PatchParameter(Gl.PATCH_VERTICES, (int)_PatchElement.PatchCount);

				// GL_PATCH_DEFAULT_OUTER_LEVEL | GL_PATCH_DEFAULT_INNER_LEVEL

				// Set vertex arrays
				SetVertexArrayState(ctx, shaderProgram);
				// Uses shader
				shaderProgram.Bind(ctx);
				// Draw patches
				_PatchElement.Draw(ctx);
			}

			// Based implementation
			if (_Elements.Count > 0)
				base.Draw(ctx, shaderProgram);
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

			// Here is the most appropriate point where to check patch support by current OpenGL implementation.
			if (Gl.CurrentExtensions.TessellationShader_ARB == false)
				throw new NotSupportedException("GL_ARB_tesselation_shader_ARB not supported by current implementation");

			// Base implementation
			return (base.CreateName(ctx));
		}

		protected override void CreateObject(GraphicsContext ctx)
		{
			// Base implementation
			base.CreateObject(ctx);

			if ((_PatchElement != null) && (_PatchElement.ArrayIndices != null))
				_PatchElement.ArrayIndices.Create(ctx);
		}

		#endregion
	}
}
