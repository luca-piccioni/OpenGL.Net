
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Graphics surface interface. 
	/// </summary>
	/// <remarks>
	/// <para>
	/// A GraphicsSurface is able to store the result of a rendering operation. This class
	/// represents the final component of a RenderPipeline, but it could be used as data
	/// source for another RenderPipeline.
	/// </para>
	/// <para>
	/// A GraphicsSurface is defined by a set of buffers; each buffer is defined by a type,
	/// which specify the how use the buffer contents. Each buffer type defines the available
	/// formats for data storage. 
	/// </para>
	/// </remarks>
	public abstract class GraphicsSurface : GraphicsResource, IGraphicsSurface
	{
		#region Constructors

		/// <summary>
		/// GraphicsSurface constructor (zero size).
		/// </summary>
		protected GraphicsSurface() { }

		/// <summary>
		/// GraphicsSurface constructor specifying extents. 
		/// </summary>
		/// <param name="w">
		/// A <see cref="Int32"/> that specify the surface width.
		/// </param>
		/// <param name="h">
		/// A <see cref="Int32"/> that specify the surface height.
		/// </param>
		protected GraphicsSurface(uint w, uint h)
		{
			// Store extents
			_Width = w;
			_Height = h;
		}
		
		#endregion
		
		#region Device Context Management
		
		/// <summary>
		/// Obtain device context associated with this GraphicsSurface. 
		/// </summary>
		/// <returns>
		/// A <see cref="DeviceContext"/>
		/// </returns>
		public abstract DeviceContext GetDeviceContext();
		
		#endregion
		
		#region Extents Management
		
		/// <summary>
		/// GraphicsSurface width property. 
		/// </summary>
		public virtual uint Width
		{
			get { return (_Width); }
			protected internal set {
				// Store surface width
				_Width = value;
				// Notify extents changes
				_SizeChanged = true;
			}
		}
		
		/// <summary>
		/// GraphicsSurface height property. 
		/// </summary>
		public virtual uint Height
		{
			get { return (_Height); }
			protected internal set {
				// Store surface height
				_Height = value;
				// Notify extents changes
				_SizeChanged = true;
			}
		}
		
		/// <summary>
		/// GraphicsSurface aspect ratio property.  
		/// </summary>
		public float AspectRatio
		{
			get { return ((float)Width / (float)Height); }
		}
		
		/// <summary>
		/// GraphicsSurface height. 
		/// </summary>
		private uint _Width;

		/// <summary>
		/// GraphicsSurface width. 
		/// </summary>
		private uint _Height;

		/// <summary>
		/// Flag indicating whether surface extents are changed. 
		/// </summary>
		protected bool _SizeChanged = true;
		
		#endregion
		
		#region Runtime Surface Buffers Management

		/// <summary>
		/// Current surface configuration.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This read-only property shall return a <see cref="DevicePixelFormat"/> indicating the current
		/// buffer configuration. The object returned shall not be used to modify this GraphicsSurface buffers,
		/// but it shall be used to know which is the buffer configuration.
		/// </para>
		/// </remarks>
		public abstract DevicePixelFormat BufferFormat { get; }

		#region Surface Clearing

		/// <summary>
		/// Clear all Surface buffers.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for clearing buffers.
		/// </param>
		public void Clear(GraphicsContext ctx)
		{
			Clear(ctx, ClearBufferMask.ColorBufferBit);
		}

		/// <summary>
		/// Clear surface buffers.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for clearing buffers.
		/// </param>
		/// <param name="bufferMask">
		/// A <see cref="ClearBufferMask"/> indicating which buffers to clear.
		/// </param>
		public void Clear(GraphicsContext ctx,  ClearBufferMask bufferMask)
		{
			// Update clear values (only what is necessary)
			if ((bufferMask & ClearBufferMask.ColorBufferBit) != 0)
				Gl.ClearColor(mClearColor.r, mClearColor.g, mClearColor.b, mClearColor.a);
#if !MONODROID
			if ((bufferMask & ClearBufferMask.DepthBufferBit) != 0)
				Gl.ClearDepth(mClearDepth);
#else
			if ((bufferMask & ClearBufferMask.DepthBufferBit) != 0)
				Gl.ClearDepth((float)mClearDepth);
#endif
			if ((bufferMask & ClearBufferMask.StencilBufferBit) != 0)
				Gl.ClearStencil(mClearStencil);
			
			// Clear
			Gl.Clear(bufferMask);
		}

		/// <summary>
		/// Set the color used for clearing this GraphicsSurface color buffer.
		/// </summary>
		/// <param name="color">
		/// A <see cref="ColorRGBAF"/> which holds the RGBA values used for clearing
		/// this GraphicsSurface color buffer.
		/// </param>
		public void SetClearColor(ColorRGBAF color)
		{
			// Store clear color
			mClearColor = color;
		}

		/// <summary>
		/// Set the depth used for clearing this GraphicsSurface depth buffer.
		/// </summary>
		/// <param name="depth">
		/// A <see cref="Double"/> which holds the depth value used for clearing
		/// this GraphicsSurface depth buffer.
		/// </param>
		public void SetClearDepth(Double depth)
		{
			// Store clear depth
			mClearDepth = depth;
		}

		/// <summary>
		/// Set the value used for clearing this GraphicsSurface stencil buffer.
		/// </summary>
		/// <param name="stencil">
		/// A <see cref="Int32"/> which holds the stencil value used for clearing
		/// this GraphicsSurface stencil buffer.
		/// </param>
		public void SetClearStencil(Int32 stencil)
		{
			// Store clear stencil
			mClearStencil = stencil;
		}

		/// <summary>
		/// Clear color used for clearing the GraphicsSurface color buffer.
		/// </summary>
		private ColorRGBAF mClearColor = new ColorRGBAF(0.0f, 0.0f, 0.0f);

		/// <summary>
		/// Clear color used for clearing the GraphicsSurface depth buffer.
		/// </summary>
		private Double mClearDepth = 1.0;

		/// <summary>
		/// Clear value used for clearing the GraphicsSurface stencil buffer.
		/// </summary>
		private Int32 mClearStencil;
		
		#endregion

		#endregion

		#region Surface Buffers Swapping

		/// <summary>
		/// Determine whether this surface has to be swapped.
		/// </summary>
		public abstract bool Swappable { get; }
		
		/// <summary>
		/// Gets or sets the buffer swap interval desired on this surface.
		/// </summary>
		public abstract int SwapInterval { get; set; }
		
		/// <summary>
		/// Swap render surface. 
		/// </summary>
		public abstract void SwapSurface();

		#endregion

		#region Surface Bindings

		/// <summary>
		/// Bind this GraphicsSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its rendering result to this GraphicsSurface.
		/// </param>
		public virtual void BindDraw(GraphicsContext ctx) { }

		/// <summary>
		/// Unbind this GraphicsSurface for drawing.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its rendering result from this GraphicsSurface.
		/// </param>
		public virtual void UnbindDraw(GraphicsContext ctx) { }

		/// <summary>
		/// Bind this GraphicsSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich associate its read result to this GraphicsSurface.
		/// </param>
		public virtual void BindRead(GraphicsContext ctx) { }

		/// <summary>
		/// Unbind this GraphicsSurface for reading.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> to wich disassociate its read result from this GraphicsSurface.
		/// </param>
		public virtual void UnbindRead(GraphicsContext ctx) { }

		#endregion

		#region Surface Reading & Copying

		/// <summary>
		/// Read this GraphicsSurface color buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>
		/// </param>
		/// <param name="rBuffer">
		/// A <see cref="ReadBufferMode"/> that specify the read buffer where the colors are read from.
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
		protected Image ReadBuffer(GraphicsContext ctx, ReadBufferMode rBuffer, uint x, uint y, uint width, uint height, PixelLayout pType)
		{
			Image image = null;

			if ((x + width > Width) || (y + height > Height))
				throw new ArgumentException("specified region lies outside the GraphicsSurface");

			// Bind for reading
			BindRead(ctx);
			// Set for reading
			Gl.ReadBuffer(rBuffer);

			// Allocate image holding data read
			image = new Image();
			image.Create(pType, width, height);

			// Set pixel transfer
			State.PixelAlignmentState.Pack(image.Stride).Apply(ctx, null);

			// Grab frame buffer pixels
			PixelFormat rFormat = pType.ToDataFormat();
			PixelType rType = pType.ToPixelType();

			Gl.ReadPixels((int)x, (int)y, (int)width, (int)height, rFormat, rType, image.ImageBuffer);

			// Unbind from reading
			UnbindRead(ctx);

			return (image);
		}

		/// <summary>
		/// Copy this GraphicsSurface color buffer into a buffer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which is bound to this GraphicsSurface.
		/// </param>
		/// <param name="rBuffer">
		/// A <see cref="ReadBufferMode"/> that specify the read buffer where the colors are read from.
		/// </param>
		/// <param name="x">
		/// A <see cref="Int32"/> that specify the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="Int32"/> that specify the y coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="texture">
		/// A <see cref="Texture"/> that will hold the buffer data.
		/// </param>
		/// <param name="level">
		/// The level of the texture <paramref name="texture"/> to be written.
		/// </param>
		/// <returns>
		/// It returns an <see cref="Image"/> representing the current read buffer <paramref name="rBuffer"/>.
		/// </returns>
		protected void CopyBuffer(GraphicsContext ctx, ReadBufferMode rBuffer, uint x, uint y, ref Texture texture, uint level)
		{
			if (texture == null)
				throw new ArgumentNullException("texture");
			if (texture.Exists(ctx) == false)
				throw new ArgumentException("not exists", "texture");
			if ((x + texture.Width > Width) || (y + texture.Height > Height))
				throw new ArgumentException("specified region lies outside the GraphicsSurface");

			// Bind for reading
			BindRead(ctx);
			// Set for reading
			Gl.ReadBuffer(rBuffer);

			// Copy pixels from read buffer to texture
			Gl.CopyTexImage2D(texture.TextureTarget, (int)level, texture.PixelLayout.ToInternalFormat(), (int)x, (int)y, (int)texture.Width, (int)texture.Height, 0);

			// Unbind from reading
			UnbindRead(ctx);
			// Reset read configuration
			Gl.ReadBuffer(Gl.NONE);
		}

		#endregion

		#region IGraphicsSurface Implementation

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint IGraphicsSurface.Width { get { return (_Width); } }

		/// <summary>
		/// The width of the surface, in pixels.
		/// </summary>
		uint IGraphicsSurface.Height { get { return (_Height); } }

		#endregion
	}
}
