
// Copyright (C) 2009-2012 Luca Piccioni
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
using System.Collections.Generic;

namespace OpenGL
{
	/// <summary>
	/// Rendering framebuffer.
	/// </summary>
	/// <remarks>
	/// </remarks>
	public sealed class RenderFramebuffer : RenderSurface
	{
		#region Framebuffer Attachments

		/// <summary>
		/// Generic attachment to RenderFramebuffer.
		/// </summary>
		private abstract class Attachment : IDisposable
		{
			#region Base Operations

			/// <summary>
			/// Create the resource of this attachment.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating this attachment.
			/// </param>
			public abstract void Create(GraphicsContext ctx);

			/// <summary>
			/// Attach this Attachment.
			/// </summary>
			/// <param name="target">
			/// The target of the attachment.
			/// </param>
			/// <param name="attachmentIndex"></param>
			public abstract void Attach(int target, int attachmentIndex);

			/// <summary>
			/// Attachment is dirty (potentionally not bound to this framebuffer)
			/// </summary>
			public bool Dirty = true;

			#endregion

			#region Extents

			public abstract uint Width { get; }

			public abstract uint Height { get; }

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public abstract void Dispose();

			#endregion
		}

		/// <summary>
		/// RenderBuffer attachment to RenderFramebuffer.
		/// </summary>
		private class RenderBufferAttachment : Attachment
		{
			#region Constructors

			public RenderBufferAttachment(RenderBuffer buffer)
			{
				if (buffer == null)
					throw new ArgumentNullException("buffer");

				Buffer = buffer;
				Buffer.IncRef();
			}

			#endregion

			#region Attachment Information

			/// <summary>
			/// The attached texture.
			/// </summary>
			public readonly RenderBuffer Buffer;

			#endregion

			#region Attachment Overrides

			/// <summary>
			/// Create the resource of this attachment.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating this attachment.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				if (!Buffer.Exists(ctx))
					Buffer.Create(ctx);
			}

			public override void Attach(int target, int attachment)
			{
 				// Attach render buffer
				Gl.FramebufferRenderbuffer(target, attachment, Gl.RENDERBUFFER, Buffer.ObjectName);
			}

			public override uint Width { get { return (Buffer.Width); } }

			public override uint Height { get { return (Buffer.Height); } }

			public override void Dispose()
			{
				Buffer.DecRef();
			}

			#endregion
		}

		/// <summary>
		/// Texture attachment to RenderFramebuffer.
		/// </summary>
		private class RenderTextureAttachment : Attachment
		{
			#region Constructors

			public RenderTextureAttachment(Texture texture)
				: this(texture, 0)
			{
				
			}

			public RenderTextureAttachment(Texture texture, uint textureLevel)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");

				Texture = texture;
				Texture.IncRef();

				TextureLevel = textureLevel;

				// Derive texture target from Texture
				TextureTarget = Texture.TextureTarget;
			}

			protected RenderTextureAttachment(Texture texture, uint textureLevel, TextureTarget textureTarget)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");

				Texture = texture;
				Texture.IncRef();

				TextureLevel = textureLevel;

				TextureTarget = textureTarget;
			}

			#endregion

			#region Attachment Information

			/// <summary>
			/// The attached texture.
			/// </summary>
			public readonly Texture Texture;

			/// <summary>
			/// The texture level used for attachment.
			/// </summary>
			public readonly uint TextureLevel;

			/// <summary>
			/// The attached texture target.
			/// </summary>
			public readonly TextureTarget TextureTarget;

			#endregion

			#region Attachment Overrides

			/// <summary>
			/// Create the resource of this attachment.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for creating this attachment.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				if (!Texture.Exists(ctx))
					Texture.Create(ctx);
			}

			public override void Attach(int target, int attachment)
			{
				// Attach color texture
				Gl.FramebufferTexture2D(target, attachment, (int)TextureTarget, Texture.ObjectName, (int)TextureLevel);
			}

			public override uint Width { get { return (Texture.Width); } }

			public override uint Height { get { return (Texture.Height); } }

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				Texture.DecRef();
			}

			#endregion
		}

		private class RenderTextureRectangleAttachment : RenderTextureAttachment
		{
			#region Constructors

			public RenderTextureRectangleAttachment(TextureRectangle texture)
				: base(texture, 0)
			{

			}

			#endregion
		}

		private class RenderTextureCubeAttachment : RenderTextureAttachment
		{
			#region Constructors

			public RenderTextureCubeAttachment(TextureCube texture, TextureCube.CubeFace cubeFace)
				: this(texture, cubeFace, 0)
			{
				
			}

			public RenderTextureCubeAttachment(TextureCube texture, TextureCube.CubeFace cubeFace, uint textureLevel)
				: base(texture, textureLevel, TextureCube.GetTextureCubeTarget(cubeFace))
			{
				
			}

			#endregion

			#region Attachment Overrides

			public override void Attach(int target, int attachment)
			{
				// Attach color texture
				Gl.FramebufferTexture2D(target, attachment, (int)TextureTarget, Texture.ObjectName, (int)TextureLevel);
			}

			#endregion
		}

		#endregion

		#region Color Buffer Attachment

		/// <summary>
		/// Attach a render buffer image to color buffer.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="RenderBuffer"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(RenderBuffer buffer)
		{
			AttachColor(buffer, 0);
		}

		/// <summary>
		/// Attach a render buffer image to color buffer.
		/// </summary>
		/// <param name="buffer">
		/// A <see cref="RenderBuffer"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		public void AttachColor(RenderBuffer buffer, uint attachmentIndex)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.BufferType != RenderBuffer.Type.Color)
				throw new ArgumentException("buffer is not a color buffer type");
			if (attachmentIndex >= GraphicsContext.CurrentCaps.Limits.MaxColorAttachments)
				throw new ArgumentException("attachment index '" + attachmentIndex + "' is greater than the maximum allowed");

			AttachColor(new RenderBufferAttachment(buffer), attachmentIndex);
		}

		/// <summary>
		/// Attach a 2D texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture2d"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(Texture2d texture)
		{
			AttachColor(texture, 0, 0);
		}

		/// <summary>
		/// Attach a 2D texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture2d"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		public void AttachColor(Texture2d texture, uint attachmentIndex)
		{
			AttachColor(texture, attachmentIndex, 0);
		}

		/// <summary>
		/// Attach a 2D texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specifies the texture level to bind.
		/// </param>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		public void AttachColor(Texture2d texture, uint attachmentIndex, uint level)
		{
			if ((level != 0) && (level > (uint)Math.Log(level, 2.0)))
				throw new ArgumentException("level greater than maximum allowed");

			AttachColor(new RenderTextureAttachment(texture, level), attachmentIndex);
		}

		/// <summary>
		/// Attach a rectangle texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(TextureRectangle texture)
		{
			AttachColor(texture, 0);
		}

		/// <summary>
		/// Attach a rectangle texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		public void AttachColor(TextureRectangle texture, uint attachmentIndex)
		{
			AttachColor(new RenderTextureAttachment(texture), attachmentIndex);
		}

		public void AttachColor(TextureCube texture, TextureCube.CubeFace cubeFace)
		{
			AttachColor(texture, cubeFace, 0);
		}

		public void AttachColor(TextureCube texture, TextureCube.CubeFace cubeFace, uint attachmentIndex)
		{
			AttachColor(texture, cubeFace, attachmentIndex, 0);
		}

		public void AttachColor(TextureCube texture, TextureCube.CubeFace cubeFace, uint attachmentIndex, uint level)
		{
			AttachColor(new RenderTextureCubeAttachment(texture, cubeFace, level), attachmentIndex);
		}

		/// <summary>
		/// Attach a texture image to color buffer.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="Attachment"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		private void AttachColor(Attachment attachment, uint attachmentIndex)
		{
			if (attachment == null)
				throw new ArgumentNullException("attachment");
			if (attachmentIndex >= GraphicsContext.CurrentCaps.Limits.MaxColorAttachments)
				throw new ArgumentException("attachment index '" + attachmentIndex + "' is greater than the maximum allowed");

			// Detach
			DetachColor(attachmentIndex);
			// Reset color attachment
			mColorBuffers[attachmentIndex] = attachment;
		}

		/// <summary>
		/// Detach a color attachment.
		/// </summary>
		/// <param name="attachmentIndex">
		/// A <see cref="UInt32"/> that specifies the framebuffer color attachment index.
		/// </param>
		public void DetachColor(uint attachmentIndex)
		{
			if (attachmentIndex >= GraphicsContext.CurrentCaps.Limits.MaxColorAttachments)
				throw new ArgumentException("attachment index '" + attachmentIndex + "' is greater than the maximum allowed");

			if (mColorBuffers[attachmentIndex] != null) {
				mColorBuffers[attachmentIndex].Dispose();
				mColorBuffers[attachmentIndex] = null;
			}
		}

		/// <summary>
		/// Detach all color attachment.
		/// </summary>
		public void DetachColors()
		{
			for (uint i = 0; i < (uint)GraphicsContext.CurrentCaps.Limits.MaxColorAttachments; i++)
				DetachColor(i);
		}

		/// <summary>
		/// RenderBuffers used as color attachment.
		/// </summary>
		private readonly Attachment[] mColorBuffers = new Attachment[GraphicsContext.CurrentCaps.Limits.MaxColorAttachments];

		#endregion

		#region Depth Buffer Attachment

		public void AttachDepth(RenderBuffer buffer)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.BufferType != RenderBuffer.Type.Depth)
				throw new ArgumentException("buffer is not a color buffer type");

			AttachDepth(new RenderBufferAttachment(buffer));
		}

		public void AttachDepth(Texture2d texture)
		{
			AttachDepth(texture, 0);
		}

		public void AttachDepth(Texture2d texture, uint level)
		{
			AttachDepth(new RenderTextureAttachment(texture, level));
		}

		public void AttachDepth(TextureRectangle texture)
		{
			AttachDepth(new RenderTextureRectangleAttachment(texture));
		}

		private void AttachDepth(Attachment attachment)
		{
			if (attachment == null)
				throw new ArgumentNullException("attachment");

			DetachDepth();

			mDepthAttachment = attachment;
		}

		/// <summary>
		/// Detach depth buffer.
		/// </summary>
		public void DetachDepth()
		{
			if (mDepthAttachment != null) {
				mDepthAttachment.Dispose();
				mDepthAttachment = null;
			}
		}

		/// <summary>
		/// Depth attachment.
		/// </summary>
		private Attachment mDepthAttachment;

		#endregion

		#region Stencil Buffer Attachment

		/// <summary>
		/// 
		/// </summary>
		/// <param name="buffer"></param>
		public void AttachStencil(RenderBuffer buffer)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.BufferType != RenderBuffer.Type.Stencil)
				throw new ArgumentException("buffer is not a stencil buffer type");

			// Reset buffer color attachment
			mStencilBuffer = buffer;
		}

		/// <summary>
		/// Detach stencil buffer.
		/// </summary>
		public void DetachStencil()
		{
			mStencilBuffer = null;
		}

		/// <summary>
		/// RenderBuffer used as depth attachment.
		/// </summary>
		private RenderBuffer mStencilBuffer = null;

		#endregion

		#region Framebuffer Grabbing

		/// <summary>
		/// Read this RenderSurface color buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="attachment">
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="width">
		/// A <see cref="System.Int32"/> that specifies the width of the rectangle area to read.
		/// </param>
		/// <param name="height">
		/// A <see cref="System.Int32"/> that specifies the height of the rectangle area to read.
		/// </param>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/> which determine the pixel storage of the returned image.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Image"/> representing the current read buffer <paramref name="rBuffer"/>.
		/// </returns>
		public Image ReadColorBuffer(GraphicsContext ctx, uint attachment, uint x, uint y, uint width, uint height, PixelLayout pType)
		{
			return (ReadBuffer(ctx, (ReadBufferMode)(Gl.COLOR_ATTACHMENT0 + (int)attachment), x, y, width, height, pType));
		}

		/// <summary>
		/// Copy this RenderSurface color buffer into a buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="attachment">
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="texture">
		/// </param>
		/// <param name="level">
		/// </param>
		public void CopyColorBuffer(GraphicsContext ctx, uint attachment, uint x, uint y, ref Texture texture, uint level)
		{
			CopyBuffer(ctx, (ReadBufferMode)(Gl.COLOR_ATTACHMENT0 + (int)attachment), x, y, ref texture, level);
		}

		#endregion

		#region RenderSurface Overrides

		/// <summary>
		/// RenderSurface width property. 
		/// </summary>
		public override uint Width
		{
			get {
				uint width = UInt32.MaxValue;

				for (int i = 0; i < GraphicsContext.CurrentCaps.Limits.MaxColorAttachments; i++) {
					if (mColorBuffers[i] != null)
						width = Math.Min(width, mColorBuffers[i].Width);
				}

				return ((width != UInt32.MaxValue) ? width : 0);
			}
		}
		
		/// <summary>
		/// RenderSurface height property. 
		/// </summary>
		public override uint Height
		{
			get {
				uint height = UInt32.MaxValue;

				for (int i = 0; i < GraphicsContext.CurrentCaps.Limits.MaxColorAttachments; i++) {
					if (mColorBuffers[i] != null)
						height = Math.Min(height, mColorBuffers[i].Height);
				}

				return ((height != UInt32.MaxValue) ? height : 0);
			}
		}

		/// <summary>
		/// Get the device context associated to this RenderFramebuffer. 
		/// </summary>
		/// <returns>
		/// It always returns <see cref="IntPtr.Zero"/>, since no device context is related to this render
		/// surface.
		/// </returns>
		public override IDeviceContext GetDeviceContext()
		{
			return (null);
		}

		/// <summary>
		/// Current surface configuration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This read-only property shall return a <see cref="RenderSurfaceFormat"/> indicating the current
		/// buffer configuration. The object returned shall not be used to modify this RenderSurface buffers,
		/// but it shall be used to know which is the buffer configuration.
		/// </para>
		/// </remarks>
		public override RenderSurfaceFormat BufferFormat
		{
			get
			{
				RenderSurfaceFormat bufferFormat = new RenderSurfaceFormat();

				// It has a color buffer?

				// It has a depth buffer?

				// It has a stencil buffer?

				// No double buffering and stereo buffering

				return (bufferFormat);
			}
		}

		/// <summary>
		/// Bind this RenderSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its rendering result to this RenderSurface.
		/// </param>
		public override void BindDraw(GraphicsContext ctx)
		{
			// Bind this framebuffer
			Gl.BindFramebuffer(Gl.DRAW_FRAMEBUFFER, ObjectName);

			// Object actually created
			mObjectBound = true;

			List<int> drawBuffers = new List<int>();
			
			for (uint i = 0; i < GraphicsContext.CurrentCaps.Limits.MaxColorAttachments; i++) {
				// Reset dirty binding points
				if ((mColorBuffers[i] != null) && mColorBuffers[i].Dirty) {
					// Ensure created buffer
					mColorBuffers[i].Create(ctx);
					// Ensure attached buffer
					mColorBuffers[i].Attach(Gl.DRAW_FRAMEBUFFER, Gl.COLOR_ATTACHMENT0 + (int)i);
					mColorBuffers[i].Dirty = false;
				}

				// Collect draw buffers
				if (mColorBuffers[i] != null)
					drawBuffers.Add(Gl.COLOR_ATTACHMENT0 + (int)i);
			}

			// Validate completeness status
			Validate(ctx);

			// Update draw buffers
			Gl.DrawBuffers(drawBuffers.ToArray());
		}

		/// <summary>
		/// Unbind this RenderSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its rendering result from this RenderSurface.
		/// </param>
		public override void UnbindDraw(GraphicsContext ctx)
		{
			// Switch to default framebuffer
			Gl.BindFramebuffer(Gl.DRAW_FRAMEBUFFER, InvalidObjectName);
			// Object actually created
			mObjectBound = true;
		}

		/// <summary>
		/// Bind this RenderSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its read result to this RenderSurface.
		/// </param>
		public override void BindRead(GraphicsContext ctx)
		{
			// Bind this framebuffer
			Gl.BindFramebuffer(Gl.READ_FRAMEBUFFER, ObjectName);

			// Reset dirty binding points
			for (uint i = 0; i < GraphicsContext.CurrentCaps.Limits.MaxColorAttachments; i++) {
				if ((mColorBuffers[i] != null) && mColorBuffers[i].Dirty) {
					// Ensure created buffer
					mColorBuffers[i].Create(ctx);
					// Ensure attached buffer
					mColorBuffers[i].Attach(Gl.DRAW_FRAMEBUFFER, Gl.COLOR_ATTACHMENT0 + (int)i);
					mColorBuffers[i].Dirty = false;
				}
			}

			// Object actually created
			mObjectBound = true;
		}

		/// <summary>
		/// Unbind this RenderSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its read result from this RenderSurface.
		/// </param>
		public override void UnbindRead(GraphicsContext ctx)
		{
			// Switch to default framebuffer
			Gl.BindFramebuffer(Gl.READ_FRAMEBUFFER, InvalidObjectName);
			// Object actually created
			mObjectBound = true;
		}
		
		/// <summary>
		/// Validate this RenderFramebuffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for validating this RenderFramebuffer.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown whenever this RenderFramebuffer is not valid.
		/// </exception>
		private static void Validate(GraphicsContext ctx)
		{
			int status;

			// Check frambuffer completeness
			status = Gl.CheckFramebufferStatus(Gl.FRAMEBUFFER);
			
			if (status != Gl.FRAMEBUFFER_COMPLETE) {
				string msg;

				switch (status) {
					case Gl.FRAMEBUFFER_UNDEFINED:
						msg = "undefined";
						break;
					case Gl.FRAMEBUFFER_INCOMPLETE_ATTACHMENT:
						msg = "incomplete attachment";
						break;
					case Gl.FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT:
						msg = "incomplete missing attachment";
						break;
					case Gl.FRAMEBUFFER_INCOMPLETE_READ_BUFFER:
						msg = "incomplete read buffer";
						break;
					case Gl.FRAMEBUFFER_UNSUPPORTED:
						msg = "unsupported";
						break;
					case Gl.FRAMEBUFFER_INCOMPLETE_MULTISAMPLE:
						msg = "incomplete multisample";
						break;
					case Gl.FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS:
						msg = "incomplete layer targets";
						break;
					default:
						msg = "unknown error";
						break;
				}

				throw new GraphicsException((ErrorCode)status, String.Format("framebuffer not complete ({0})", msg));
			}
		}

		/// <summary>
		/// Determine whether this surface has to be swapped.
		/// </summary>
		/// <remarks>
		/// This routine returns always 'false', since the framebuffer cannot be defined with a double buffer.
		/// </remarks>
		public override bool Swappable { get { return (false); } }
		
		/// <summary>
		/// Gets or sets the buffer swap interval desired on this surface.
		/// </summary>
		/// <remarks>
		/// This property returns always 0.
		/// </remarks>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if this property is set with any value.
		/// </exception>
		public override int SwapInterval
		{
			get { return (0); }
			set { throw new InvalidOperationException("framebuffer can set a swap interval"); }
		}

		/// <summary>
		/// Swap render surface. 
		/// </summary>
		/// <exception cref="InvalidOperationException">
		/// This exception is always thrown since <see cref="Swappable"/> returns always 'false'.
		/// </exception>
		/// <remarks>
		/// Do not call this routine.
		/// </remarks>
		public override void SwapSurface()
		{
			throw new InvalidOperationException("framebuffer can't swap");
		}

		#endregion

		#region RenderResource Overrides

		/// <summary>
		/// RenderResource object class.
		/// </summary>
		internal static readonly Guid FramebufferObjectClass = new Guid("7A8F2D14-9A8D-4CD9-BFAD-5E10CA1C33CE");

		/// <summary>
		/// RenderResource object class.
		/// </summary>
		public override Guid ObjectClass { get { return (FramebufferObjectClass); } }

		/// <summary>
		/// Determine whether this RenderFramebuffer really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this RenderFramebuffer exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IRenderResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this RenderFramebuffer (or is sharing with the creator).
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

			return (!mObjectBound || Gl.IsFramebuffer(ObjectName));
		}

		/// <summary>
		/// Create a RenderFramebuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this RenderResource.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected override uint CreateName(GraphicsContext ctx)
		{
			return (Gl.GenFramebuffer());
		}

		/// <summary>
		/// Delete a RenderFramebuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="System.UInt32"/> that specifies the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete program
			Gl.DeleteFramebuffers(ObjectName);
		}

		/// <summary>
		/// 
		/// </summary>
		private bool mObjectBound;

		#endregion
	}
}
