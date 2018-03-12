
// Copyright (C) 2010-2017 Luca Piccioni
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

namespace OpenGL.Objects
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
		/// A <see cref="Type"/> that specify the type of the buffer. This parameter
		/// influence the framebuffer attachment, and the possible formats.
		/// </param>
		/// <param name="internalFormat">
		/// A <see cref="PixelLayout"/> that specify the internal OpenGL format for this
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
			if (w >= Gl.CurrentLimits.MaxRenderbufferSize)
				throw new ArgumentException("exceed maximum size", "w");
			if (h >= Gl.CurrentLimits.MaxRenderbufferSize)
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
		/// A <see cref="Int32"/> that specify the width of the renderbuffer.
		/// </param>
		/// <param name="h">
		/// A <see cref="Int32"/> that specify the height of the renderbuffer.
		/// </param>
		public void Allocate(GraphicsContext ctx, uint w, uint h)
		{
			// Allocate buffer
			Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, ObjectName);
			// Define buffer storage
			Gl.RenderbufferStorage(RenderbufferTarget.Renderbuffer, _InternalFormat.ToInternalFormat(), (int)w, (int)h);
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
		internal static readonly Guid ThisObjectClass = new Guid("DE480749-2F05-4872-A7E7-7D5B72AF79E8");

		/// <summary>
		/// Render buffer object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

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
			Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, ObjectName);

			// Define buffer storage
			Gl.RenderbufferStorage(RenderbufferTarget.Renderbuffer, _InternalFormat.ToInternalFormat(), (int)_Width, (int)_Height);
			// Restore previous RenderBuffer binding
			Gl.BindRenderbuffer(RenderbufferTarget.Renderbuffer, (uint)currentBinding);
		}

		/// <summary>
		/// Delete a RenderBuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete this render buffer
			Gl.DeleteRenderbuffers(name);
		}

		#endregion
	}
}