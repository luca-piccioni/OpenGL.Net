
// Copyright (C) 2010-2012 Luca Piccioni
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
	/// Framebuffer attachable render buffer.
	/// </summary>
	public class RenderBuffer : GraphicsResource
	{
		#region Constructors

		/// <summary>
		/// Construct a render buffer.
		/// </summary>
		/// <param name="type">
		/// A <see cref="RenderBuffer.Type"/> that specifies the type of the buffer. This parameter
		/// influence the framebuffer attachment, and the possible formats.
		/// </param>
		/// <param name="glFormat">
		/// A <see cref="System.Int32"/> that specifies the internal OpenGL format for this
		/// RenderBuffer. From OpenGL 3.2 specification:
		/// @verbatim
		/// Implementations are required to support the same internal formats for renderbuffers
		/// as the required formats for textures enumerated in section 3.8.1, with the exception
		/// of the color formats labelled “texture-only”. Requesting one of these internal
		/// formats for a renderbuffer will allocate at least the internal component sizes and
		/// exactly the component types shown for that format in tables 3.12- 3.13.
		/// @endverbatim
		/// </param>
		public RenderBuffer(Type type, int glFormat)
		{
			// Set buffer type
			mType = type;
			// Store internal format
			mInternalFormat = glFormat;
		}

		#endregion

		#region Buffer Type & Format

		/// <summary>
		/// Buffer type.
		/// </summary>
		public enum Type
		{
			/// <summary>
			/// Color buffer.
			/// </summary>
			Color,
			/// <summary>
			/// Depth buffer.
			/// </summary>
			Depth,
			/// <summary>
			/// Stencil buffer.
			/// </summary>
			Stencil,
			/// <summary>
			/// Packed depth and stencil buffer.
			/// </summary>
			DepthStencil
		}

		/// <summary>
		/// Render buffer type.
		/// </summary>
		public Type BufferType { get { return (mType); } }

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		public uint Width { get { return (mWidth); } }

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		public uint Height { get { return (mHeight); } }

		/// <summary>
		/// Render buffer type.
		/// </summary>
		private Type mType;

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		private uint mWidth = 0;

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		private uint mHeight = 0;

		#endregion

		#region Buffer Allocation

		/// <summary>
		/// Allocate this RenderBuffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocation.
		/// </param>
		/// <param name="w">
		/// A <see cref="System.Int32"/> that specifies the width of the renderbuffer.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> that specifies the height of the renderbuffer.
		/// </param>
		public void Allocate(GraphicsContext ctx, uint w, uint h)
		{
			// Allocate buffer
			Gl.BindRenderbuffer(Gl.RENDERBUFFER, ObjectName);
			// Define buffer storage
			Gl.RenderbufferStorage(Gl.RENDERBUFFER, mInternalFormat, (int)w, (int)h);
		}

		/// <summary>
		/// Render buffer internal format.
		/// </summary>
		private int mInternalFormat;

		#endregion

		#region RenderResource Overrides

		/// <summary>
		/// Render buffer object class.
		/// </summary>
		internal static readonly Guid RenderBufferObjectClass = new Guid("DE480749-2F05-4872-A7E7-7D5B72AF79E8");

		/// <summary>
		/// Render buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (RenderBufferObjectClass); } }

		/// <summary>
		/// Determine whether this RenderBuffer really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this RenderBuffer exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this RenderBuffer (or is sharing with the creator).
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

			return (Gl.IsRenderbuffer(ObjectName));
		}

		/// <summary>
		/// Create a RenderBuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this RenderBuffer.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			return (Gl.GenRenderbuffer());
		}

		/// <summary>
		/// Delete a RenderBuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete this render buffer
			Gl.DeleteRenderbuffers(name);
		}

		#endregion
	}
}