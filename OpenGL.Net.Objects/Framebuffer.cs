
// Copyright (C) 2009-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// OpenGL framebuffer.
	/// </summary>
	public class Framebuffer : GraphicsSurface
	{
		#region Framebuffer Attachments

		/// <summary>
		/// Generic attachment to Framebuffer.
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
			/// <param name="attachment">
			/// The index of the attachment, in case the attachment type allow multiple attachments (i.e. color).
			/// </param>
			public abstract void Attach(FramebufferTarget target, FramebufferAttachment attachment);

			/// <summary>
			/// Attachment is dirty (potentionally not bound to this framebuffer)
			/// </summary>
			public bool Dirty = true;

			#endregion

			#region Extents

			/// <summary>
			/// The width of the attachment, in pixels.
			/// </summary>
			public abstract uint Width { get; }

			/// <summary>
			/// The height of the attachment, in pixels.
			/// </summary>
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
		/// RenderBuffer attachment to Framebuffer.
		/// </summary>
		private class RenderBufferAttachment : Attachment
		{
			#region Constructors

			/// <summary>
			/// Construct a RenderBufferAttachment that attach a <see cref="RenderBuffer"/>.
			/// </summary>
			/// <param name="buffer">
			/// The <see cref="RenderBuffer"/> to attach to a Framebuffer.
			/// </param>
			public RenderBufferAttachment(RenderBuffer buffer)
			{
				if (buffer == null)
					throw new ArgumentNullException("buffer");

				_Buffer = buffer;
				_Buffer.IncRef();
			}

			#endregion

			#region Attachment Information

			/// <summary>
			/// The attached <see cref="RenderBuffer"/>.
			/// </summary>
			public RenderBuffer Buffer { get { return (_Buffer); } }

			/// <summary>
			/// The attached <see cref="RenderBuffer"/>.
			/// </summary>
			public RenderBuffer _Buffer;

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
				if (Buffer.Exists(ctx) == false)
					Buffer.Create(ctx);
			}

			/// <summary>
			/// Attach this Attachment.
			/// </summary>
			/// <param name="target">
			/// The target of the attachment.
			/// </param>
			/// <param name="attachment">
			/// The index of the attachment, in case the attachment type allow multiple attachments (i.e. color).
			/// </param>
			public override void Attach(FramebufferTarget target, FramebufferAttachment attachment)
			{
 				// Attach render buffer
				Gl.FramebufferRenderbuffer(target, attachment, RenderbufferTarget.Renderbuffer, Buffer.ObjectName);
			}

			/// <summary>
			/// The width of the attachment, in pixels.
			/// </summary>
			public override uint Width { get { return (Buffer.Width); } }

			/// <summary>
			/// The height of the attachment, in pixels.
			/// </summary>
			public override uint Height { get { return (Buffer.Height); } }

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Buffer != null) {
					_Buffer.DecRef();
					_Buffer = null;
				}
			}

			#endregion
		}

		/// <summary>
		/// Texture attachment to Framebuffer.
		/// </summary>
		private class TextureAttachment : Attachment
		{
			#region Constructors

			/// <summary>
			/// Construct a TextureAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture"/> to be attached to a Framebuffer.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureAttachment(Texture texture)
				: this(texture, 0)
			{
				
			}

			/// <summary>
			/// Construct a TextureAttachment specifing the texture and its level.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="textureLevel">
			/// A <see cref="UInt32"/> that specify the level of <paramref name="texture"/> to be attached.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureAttachment(Texture texture, uint textureLevel)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");

				_Texture = texture;
				_Texture.IncRef();
				TextureLevel = textureLevel;
				TextureTarget = Texture.TextureTarget;
			}

			/// <summary>
			/// Construct a TextureAttachment specifing the texture, its level and possibly a specific texture target.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="textureLevel">
			/// A <see cref="UInt32"/> that specify the level of <paramref name="texture"/> to be attached.
			/// </param>
			/// <param name="textureTarget">
			/// A specific <see cref="TextureTarget"/> to used with <see cref="Gl.FramebufferTexture2D"/>.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			protected TextureAttachment(Texture texture, uint textureLevel, TextureTarget textureTarget)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");

				_Texture = texture;
				_Texture.IncRef();
				TextureLevel = textureLevel;
				TextureTarget = textureTarget;
			}

			#endregion

			#region Attachment Information

			/// <summary>
			/// The attached texture.
			/// </summary>
			public Texture Texture { get { return (_Texture); } }

			/// <summary>
			/// The attached texture.
			/// </summary>
			public Texture _Texture;

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

			/// <summary>
			/// Attach this Attachment.
			/// </summary>
			/// <param name="target">
			/// The target of the attachment.
			/// </param>
			/// <param name="attachment">
			/// The index of the attachment, in case the attachment type allow multiple attachments (i.e. color).
			/// </param>
			public override void Attach(FramebufferTarget target, FramebufferAttachment attachment)
			{
				// Attach color texture
				Gl.FramebufferTexture2D(target, attachment, TextureTarget, Texture.ObjectName, (int)TextureLevel);
			}

			/// <summary>
			/// The width of the attachment, in pixels.
			/// </summary>
			public override uint Width
			{
				get
				{
					uint w = Texture.Width;

					for (uint lod = 0; lod < TextureLevel; lod++)
						w = Math.Max(1, w / 2);

					return (w);
				}
			}

			/// <summary>
			/// The height of the attachment, in pixels.
			/// </summary>
			public override uint Height
			{
				get
				{
					uint h = Texture.Width;

					for (uint lod = 0; lod < TextureLevel; lod++)
						h = Math.Max(1, h / 2);

					return (h);
				}
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Texture != null) {
					_Texture.DecRef();
					_Texture = null;
				}
			}

			#endregion
		}

#if !MONODROID

		/// <summary>
		/// Texture attachment to Framebuffer (specialization for <see cref="TextureRectangle"/>).
		/// </summary>
		private class TextureRectangleAttachment : TextureAttachment
		{
			#region Constructors

			/// <summary>
			/// Construct a TextureRectangleAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureRectangle"/> to be attached to a Framebuffer.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureRectangleAttachment(TextureRectangle texture)
				: base(texture, 0)
			{

			}

			#endregion
		}

#endif

		/// <summary>
		/// Texture attachment to Framebuffer (specialization for <see cref="TextureCube"/>).
		/// </summary>
		private class TextureCubeAttachment : TextureAttachment
		{
			#region Constructors

			/// <summary>
			/// Construct a TextureCubeAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureCube"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="cubeFace">
			/// The specific <see cref="TextureCube.CubeFace"/> to attach to a Framebuffer.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureCubeAttachment(TextureCube texture, TextureCube.CubeFace cubeFace)
				: this(texture, cubeFace, 0)
			{
				
			}

			/// <summary>
			/// Construct a TextureCubeAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureCube"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="cubeFace">
			/// The specific <see cref="TextureCube.CubeFace"/> to attach to a Framebuffer.
			/// </param>
			/// <param name="textureLevel">
			/// A <see cref="UInt32"/> that specify the level of <paramref name="texture"/> to be attached.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureCubeAttachment(TextureCube texture, TextureCube.CubeFace cubeFace, uint textureLevel)
				: base(texture, textureLevel, TextureCube.GetTextureCubeTarget(cubeFace))
			{
				
			}

			#endregion
		}

		/// <summary>
		/// Texture attachment to Framebuffer (specialization for <see cref="TextureArray2d"/> and <see cref="Texture3d"/>).
		/// </summary>
		private class TextureArrayAttachment : TextureAttachment
		{
			#region Constructors

			/// <summary>
			/// Construct a Texture3dAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureCube"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="layer">
			/// A <see cref="UInt32"/> the specify the layer of <paramref name="texture"/> to attach.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureArrayAttachment(TextureArray2d texture, uint layer)
				: this(texture, layer, 0)
			{
				
			}

			/// <summary>
			/// Construct a Texture3dAttachment specifing the texture.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureCube"/> to be attached to a Framebuffer.
			/// </param>
			/// <param name="layer">
			/// A <see cref="UInt32"/> the specify the layer of <paramref name="texture"/> to attach.
			/// </param>
			/// <param name="textureLevel">
			/// A <see cref="UInt32"/> that specify the level of <paramref name="texture"/> to be attached.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public TextureArrayAttachment(TextureArray2d texture, uint layer, uint textureLevel)
				: base(texture, textureLevel)
			{
				Depth = layer;
			}

			#endregion

			#region Attachment Information

			/// <summary>
			/// The depth of the 2D texture to attach.
			/// </summary>
			public readonly uint Depth;

			#endregion

			#region TextureAttachment Overrides

			/// <summary>
			/// Attach this Attachment.
			/// </summary>
			/// <param name="target">
			/// The target of the attachment.
			/// </param>
			/// <param name="attachment">
			/// The index of the attachment, in case the attachment type allow multiple attachments (i.e. color).
			/// </param>
			public override void Attach(FramebufferTarget target, FramebufferAttachment attachment)
			{
				// Attach color texture
				Gl.FramebufferTextureLayer(target, attachment, Texture.ObjectName, (int)TextureLevel, (int)Depth);
			}

			#endregion
		}

		#endregion

		#region Color Buffer Attachment

		#region AttachColor(RenderBuffer)

		/// <summary>
		/// Attach a render buffer image to color buffer.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="RenderBuffer"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(uint attachmentIndex, RenderBuffer buffer)
		{
			if (buffer == null)
				throw new ArgumentNullException("buffer");
			if (buffer.BufferType != RenderBuffer.Type.Color)
				throw new ArgumentException("buffer is not a color buffer type");

			AttachColor(attachmentIndex, new RenderBufferAttachment(buffer));
		}

		#endregion

		#region AttachColor(Texture2d)

		/// <summary>
		/// Attach a 2D texture image to color buffer.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		/// <param name="texture">
		/// A <see cref="Texture2d"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(uint attachmentIndex, Texture2d texture)
		{
			AttachColor(attachmentIndex, new TextureAttachment(texture));
		}

		/// <summary>
		/// Attach a 2D texture image to color buffer.
		/// </summary>
		/// <param name="texture">
		/// A <see cref="Texture"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level to bind.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		public void AttachColor(uint attachmentIndex, Texture2d texture, uint level)
		{
			AttachColor(attachmentIndex, new TextureAttachment(texture, level));
		}

		#endregion

#if !MONODROID

		#region AttachColor(TextureRectangle)

		/// <summary>
		/// Attach a rectangle texture image to color buffer.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		/// <param name="texture">
		/// A <see cref="Texture"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		public void AttachColor(uint attachmentIndex, TextureRectangle texture)
		{
			AttachColor(attachmentIndex, new TextureAttachment(texture));
		}

		#endregion

#endif

		#region AttachColor(TextureCube)

		public void AttachColor(uint attachmentIndex, TextureCube texture, TextureCube.CubeFace cubeFace)
		{
			AttachColor(attachmentIndex, new TextureCubeAttachment(texture, cubeFace));
		}

		public void AttachColor(uint attachmentIndex, TextureCube texture, TextureCube.CubeFace cubeFace, uint level)
		{
			AttachColor(attachmentIndex, new TextureCubeAttachment(texture, cubeFace, level));
		}

		#endregion

		#region AttachColor(TextureArray2d)

		public void AttachColor(uint attachmentIndex, TextureArray2d texture, uint layer)
		{
			AttachColor(attachmentIndex, new TextureArrayAttachment(texture, layer));
		}

		public void AttachColor(uint attachmentIndex, TextureArray2d texture, uint layer, uint level)
		{
			AttachColor(attachmentIndex, new TextureArrayAttachment(texture, layer, level));
		}

		#endregion

		/// <summary>
		/// Attach a texture image to color buffer.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		/// <param name="attachment">
		/// A <see cref="Attachment"/> which will be used for read/write operation on this RenderFrambuffer.
		/// </param>
		private void AttachColor(uint attachmentIndex, Attachment attachment)
		{
			if (attachment == null)
				throw new ArgumentNullException("attachment");
			if (attachmentIndex >= Gl.CurrentLimits.MaxColorAttachments)
				throw new ArgumentException(String.Format("attachment index {0} is greater than the maximum allowed", attachmentIndex), "attachmentIndex");

			// Detach
			DetachColor(attachmentIndex);
			// Reset color attachment
			_ColorBuffers[attachmentIndex] = attachment;
		}

		/// <summary>
		/// Detach a color attachment.
		/// </summary>
		/// <param name="attachment">
		/// A <see cref="UInt32"/> that specify the framebuffer color attachment index.
		/// </param>
		public void DetachColor(uint attachmentIndex)
		{
			if (attachmentIndex >= Gl.CurrentLimits.MaxColorAttachments)
				throw new ArgumentException(String.Format("attachment index {0} is greater than the maximum allowed", attachmentIndex), "attachmentIndex");

			if (_ColorBuffers[attachmentIndex] != null) {
				_ColorBuffers[attachmentIndex].Dispose();
				_ColorBuffers[attachmentIndex] = null;
			}
		}

		/// <summary>
		/// Detach all color attachment.
		/// </summary>
		public void DetachColors()
		{
			for (uint i = 0; i < (uint)Gl.CurrentLimits.MaxColorAttachments; i++)
				DetachColor(i);
		}

		/// <summary>
		/// RenderBuffers used as color attachment.
		/// </summary>
		private readonly Attachment[] _ColorBuffers = new Attachment[Gl.CurrentLimits.MaxColorAttachments];

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
			AttachDepth(new TextureAttachment(texture, level));
		}

#if !MONODROID

		public void AttachDepth(TextureRectangle texture)
		{
			AttachDepth(new TextureRectangleAttachment(texture));
		}

#endif

		private void AttachDepth(Attachment attachment)
		{
			if (attachment == null)
				throw new ArgumentNullException("attachment");

			DetachDepth();

			_DepthAttachment = attachment;
		}

		/// <summary>
		/// Detach depth buffer.
		/// </summary>
		public void DetachDepth()
		{
			if (_DepthAttachment != null) {
				_DepthAttachment.Dispose();
				_DepthAttachment = null;
			}
		}

		/// <summary>
		/// Depth attachment.
		/// </summary>
		private Attachment _DepthAttachment;

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
			_StencilBuffer = buffer;
		}

		/// <summary>
		/// Detach stencil buffer.
		/// </summary>
		public void DetachStencil()
		{
			_StencilBuffer = null;
		}

		/// <summary>
		/// RenderBuffer used as depth attachment.
		/// </summary>
		private RenderBuffer _StencilBuffer = null;

		#endregion

		#region Framebuffer Grabbing

		/// <summary>
		/// Read this GraphicsSurface color buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="attachment">
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> that specify the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specify the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="width">
		/// A <see cref="Int32"/> that specify the width of the rectangle area to read.
		/// </param>
		/// <param name="height">
		/// A <see cref="Int32"/> that specify the height of the rectangle area to read.
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
		/// Copy this GraphicsSurface color buffer into a buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="attachment">
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> that specify the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specify the y coordinate of the lower left corder of the rectangle area to read.
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

		#region GraphicsSurface Overrides

		/// <summary>
		/// GraphicsSurface width property. 
		/// </summary>
		public override uint Width
		{
			get {
				uint width = UInt32.MaxValue;

				for (int i = 0; i < Gl.CurrentLimits.MaxColorAttachments; i++) {
					if (_ColorBuffers[i] != null)
						width = Math.Min(width, _ColorBuffers[i].Width);
				}

				return ((width != UInt32.MaxValue) ? width : 0);
			}
		}
		
		/// <summary>
		/// GraphicsSurface height property. 
		/// </summary>
		public override uint Height
		{
			get {
				uint height = UInt32.MaxValue;

				for (int i = 0; i < Gl.CurrentLimits.MaxColorAttachments; i++) {
					if (_ColorBuffers[i] != null)
						height = Math.Min(height, _ColorBuffers[i].Height);
				}

				return ((height != UInt32.MaxValue) ? height : 0);
			}
		}

		/// <summary>
		/// Get the device context associated to this Framebuffer. 
		/// </summary>
		/// <returns>
		/// It always returns <see cref="IntPtr.Zero"/>, since no device context is related to this render
		/// surface.
		/// </returns>
		public override DeviceContext GetDeviceContext()
		{
			return (null);
		}

		/// <summary>
		/// Current surface configuration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This read-only property shall return a <see cref="GraphicsBuffersFormat"/> indicating the current
		/// buffer configuration. The object returned shall not be used to modify this GraphicsSurface buffers,
		/// but it shall be used to know which is the buffer configuration.
		/// </para>
		/// </remarks>
		public override DevicePixelFormat BufferFormat
		{
			get
			{
				DevicePixelFormat bufferFormat = new DevicePixelFormat();

				// It has a color buffer?

				// It has a depth buffer?

				// It has a stencil buffer?

				// No double buffering and stereo buffering

				return (bufferFormat);
			}
		}

		/// <summary>
		/// Bind this GraphicsSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its rendering result to this GraphicsSurface.
		/// </param>
		public override void BindDraw(GraphicsContext ctx)
		{
			// Bind this framebuffer
			Gl.BindFramebuffer(FramebufferTarget.DrawFramebuffer, ObjectName);

			List<int> drawBuffers = new List<int>();
			
			for (uint i = 0; i < Gl.CurrentLimits.MaxColorAttachments; i++) {
				// Reset dirty binding points
				if ((_ColorBuffers[i] != null) && _ColorBuffers[i].Dirty) {
					// Ensure created buffer
					_ColorBuffers[i].Create(ctx);
					// Ensure attached buffer
					_ColorBuffers[i].Attach(FramebufferTarget.DrawFramebuffer,  FramebufferAttachment.ColorAttachment0 + (int)i);
					_ColorBuffers[i].Dirty = false;
				}

				// Collect draw buffers
				if (_ColorBuffers[i] != null)
					drawBuffers.Add(Gl.COLOR_ATTACHMENT0 + (int)i);
			}

			if (_DepthAttachment != null && _DepthAttachment.Dirty) {
				// Ensure created buffer
				_DepthAttachment.Create(ctx);
				// Ensure attached buffer
				_DepthAttachment.Attach(FramebufferTarget.DrawFramebuffer, FramebufferAttachment.DepthAttachment);
				_DepthAttachment.Dirty = false;
			}

			// Validate completeness status
			Validate(ctx);

			// Update draw buffers
			Gl.DrawBuffers(drawBuffers.ToArray());
		}

		/// <summary>
		/// Unbind this GraphicsSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its rendering result from this GraphicsSurface.
		/// </param>
		public override void UnbindDraw(GraphicsContext ctx)
		{
			// Switch to default framebuffer
			Gl.BindFramebuffer(FramebufferTarget.DrawFramebuffer, InvalidObjectName);
#if !MONODROID
			Gl.DrawBuffers(Gl.BACK_LEFT);
#endif
			// Gl.DrawBuffer(DrawBufferMode.BackLeft);
		}

		/// <summary>
		/// Bind this GraphicsSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its read result to this GraphicsSurface.
		/// </param>
		public override void BindRead(GraphicsContext ctx)
		{
			// Bind this framebuffer
			Gl.BindFramebuffer(FramebufferTarget.ReadFramebuffer, ObjectName);

			// Reset dirty binding points
			for (uint i = 0; i < Gl.CurrentLimits.MaxColorAttachments; i++) {
				if ((_ColorBuffers[i] != null) && _ColorBuffers[i].Dirty) {
					// Ensure created buffer
					_ColorBuffers[i].Create(ctx);
					// Ensure attached buffer
					_ColorBuffers[i].Attach(FramebufferTarget.DrawFramebuffer, FramebufferAttachment.ColorAttachment0 + (int)i);
					_ColorBuffers[i].Dirty = false;
				}
			}
		}

		/// <summary>
		/// Unbind this GraphicsSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its read result from this GraphicsSurface.
		/// </param>
		public override void UnbindRead(GraphicsContext ctx)
		{
			// Switch to default framebuffer
			Gl.BindFramebuffer(FramebufferTarget.ReadFramebuffer, InvalidObjectName);
		}
		
		/// <summary>
		/// Validate this Framebuffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for validating this Framebuffer.
		/// </param>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown whenever this Framebuffer is not valid.
		/// </exception>
		private static void Validate(GraphicsContext ctx)
		{
			// Check frambuffer completeness
			FramebufferStatus status = Gl.CheckFramebufferStatus(FramebufferTarget.Framebuffer);

			if (status != FramebufferStatus.FramebufferComplete) {
				switch (status) {
					case FramebufferStatus.FramebufferComplete:
						return;		// No error
					case FramebufferStatus.FramebufferUndefined:
						throw new InvalidOperationException("framebuffer undefined");
					case FramebufferStatus.FramebufferIncompleteAttachment:
						throw new InvalidOperationException("framebuffer incomplete attachment");
					case FramebufferStatus.FramebufferIncompleteMissingAttachment:
						throw new InvalidOperationException("framebuffer incomplete missing attachment");
#if !MONODROID
					case FramebufferStatus.FramebufferIncompleteReadBuffer:
						throw new InvalidOperationException("framebuffer incomplete read buffer");
#endif
					case FramebufferStatus.FramebufferUnsupported:
						throw new InvalidOperationException("framebuffer unsupported");
					case FramebufferStatus.FramebufferIncompleteMultisample:
						throw new InvalidOperationException("framebuffer incomplete multisample");
					case FramebufferStatus.FramebufferIncompleteLayerTargets:
						throw new InvalidOperationException("framebuffer incomplete layer targets");
					default:
						throw new InvalidOperationException(String.Format("unknown error code 0x{0}", status.ToString("X8")));
				}
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

		#region GraphicsResource Overrides

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("7A8F2D14-9A8D-4CD9-BFAD-5E10CA1C33CE");

		/// <summary>
		/// GraphicsResource object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this Framebuffer really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Framebuffer exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this Framebuffer (or is sharing with the creator).
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
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (Gl.IsFramebuffer(ObjectName));
		}

		/// <summary>
		/// Create a Framebuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this GraphicsResource.
		/// </returns>
		/// <exception cref="NotImplementedException">
		/// Exception always thrown.
		/// </exception>
		protected override uint CreateName(GraphicsContext ctx)
		{
			return (Gl.GenFramebuffer());
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

			Gl.Get(Gl.READ_FRAMEBUFFER_BINDING, out currentBinding);
			Gl.BindFramebuffer(FramebufferTarget.ReadFramebuffer, ObjectName);

			// Restore previous Framebuffer bound
			Gl.BindFramebuffer(FramebufferTarget.ReadFramebuffer, (uint)currentBinding);
		}

		/// <summary>
		/// Delete a Framebuffer name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete program
			Gl.DeleteFramebuffers(ObjectName);
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
			if (disposing) {
				for (int i = 0; i < _ColorBuffers.Length; i++) {
					Attachment attachment  = _ColorBuffers[i];

					if (attachment != null) {
						attachment.Dispose();
						_ColorBuffers[i] = null;
					}
				}

				if (_DepthAttachment != null) {
					_DepthAttachment.Dispose();
					_DepthAttachment = null;
				}
				
				if (_StencilBuffer != null) {
					_StencilBuffer.Dispose();
					_StencilBuffer = null;
				}
			}

			// Base implementation
			base.Dispose(disposing);
		}

		#endregion
	}
}
