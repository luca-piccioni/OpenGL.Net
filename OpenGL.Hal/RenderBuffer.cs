
// Copyright (C) 2010-2015 Luca Piccioni
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
		/// A <see cref="Type"/> that specifies the type of the buffer. This parameter
		/// influence the framebuffer attachment, and the possible formats.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="PixelLayout"/> that specifies the internal OpenGL format for this
		/// RenderBuffer. From OpenGL 3.2 specification:
		/// @verbatim
		/// Implementations are required to support the same internal formats for renderbuffers
		/// as the required formats for textures enumerated in section 3.8.1, with the exception
		/// of the color formats labelled “texture-only”. Requesting one of these internal
		/// formats for a renderbuffer will allocate at least the internal component sizes and
		/// exactly the component types shown for that format in tables 3.12- 3.13.
		/// @endverbatim
		/// </param>
		public RenderBuffer(Type type, PixelLayout internalFormat, uint w, uint h)
		{
			if (w >= GraphicsContext.CurrentCaps.Limits.MaxRenderBufferSize)
				throw new ArgumentException("exceed maximum size", "w");
			if (h >= GraphicsContext.CurrentCaps.Limits.MaxRenderBufferSize)
				throw new ArgumentException("exceed maximum size", "w");

			// Set buffer type
			_Type = type;
			// Store internal format
			_InternalFormat = internalFormat;
			_Width = w;
			_Height = h;
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
		public Type BufferType { get { return (_Type); } }

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		public uint Width { get { return (_Width); } }

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		public uint Height { get { return (_Height); } }

		/// <summary>
		/// Render buffer type.
		/// </summary>
		private Type _Type;

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		private uint _Width;

		/// <summary>
		/// RenderBuffer width.
		/// </summary>
		private uint _Height;

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
			Gl.RenderbufferStorage(Gl.RENDERBUFFER, Pixel.GetGlInternalFormat(_InternalFormat, ctx), (int)w, (int)h);
		}

		/// <summary>
		/// Render buffer internal format.
		/// </summary>
		private PixelLayout _InternalFormat;

		#endregion

		#region GraphicsResource Overrides

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
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
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
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			int currentBinding;

			Gl.Get(Gl.RENDERBUFFER_BINDING, out currentBinding);
			Gl.BindRenderbuffer(Gl.RENDERBUFFER, ObjectName);

			// Define buffer storage
			Gl.RenderbufferStorage(Gl.RENDERBUFFER, Pixel.GetGlInternalFormat(_InternalFormat, ctx), (int)_Width, (int)_Height);
			// Restore previous RenderBuffer binding
			Gl.BindRenderbuffer(Gl.RENDERBUFFER, (uint)currentBinding);
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