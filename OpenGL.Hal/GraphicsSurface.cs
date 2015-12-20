
// Copyright (C) 2009-2015 Luca Piccioni
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
	/// Render surface interface. 
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
	public abstract class GraphicsSurface : GraphicsResource
	{
		#region Constructors
		
		/// <summary>
		/// Render surface static constructor.
		/// </summary>
		static GraphicsSurface()
		{
			// This (internal) routine is used to force the execution of the GraphicsContext
			// static constructor. Once accessing to GraphicsSurface instances, the GraphicsContext
			// capabilities shall be known.
			GraphicsContext.Touch();
		}

		/// <summary>
		/// GraphicsSurface constructor (zero size).
		/// </summary>
		protected GraphicsSurface() { }

		/// <summary>
		/// GraphicsSurface constructor specifying extents. 
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> that specifies the surface width.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> that specifies the surface height.
		/// </param>
		protected GraphicsSurface(uint w, uint h)
		{
			// Store extents
			mWidth = w;
			mHeight = h;
		}
		
		#endregion
		
		#region Device Context Management
		
		/// <summary>
		/// Obtain device context associated with this GraphicsSurface. 
		/// </summary>
		/// <returns>
		/// A <see cref="IDeviceContext"/>
		/// </returns>
		public abstract IDeviceContext GetDeviceContext();
		
		#endregion
		
		#region Extents Management
		
		/// <summary>
		/// GraphicsSurface width property. 
		/// </summary>
		public virtual uint Width
		{
			get { return (mWidth); }
			protected internal set {
				// Store surface width
				mWidth = value;
				// Notify extents changes
				mSizeChanged = true;
			}
		}
		
		/// <summary>
		/// GraphicsSurface height property. 
		/// </summary>
		public virtual uint Height
		{
			get { return (mHeight); }
			protected internal set {
				// Store surface height
				mHeight = value;
				// Notify extents changes
				mSizeChanged = true;
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
		private uint mWidth;

		/// <summary>
		/// GraphicsSurface width. 
		/// </summary>
		private uint mHeight;

		/// <summary>
		/// Flag indicating whether surface extents are changed. 
		/// </summary>
		protected bool mSizeChanged = true;
		
		#endregion
		
		#region Runtime Surface Buffers Management

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
		public abstract GraphicsBuffersFormat BufferFormat { get; }

		#region Surface Clearing

		/// <summary>
		/// Clear all Surface buffers.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for clearing buffers.
		/// </param>
		public void Clear(GraphicsContext ctx)
		{
			Clear(ctx, BufferFormat.BuffersMask);
		}

		/// <summary>
		/// Clear surface buffers.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for clearing buffers.
		/// </param>
		/// <param name="bufferMask">
		/// A <see cref="GraphicsBuffersFormat.BufferType"/> indicating which buffers to clear.
		/// </param>
		public void Clear(GraphicsContext ctx, GraphicsBuffersFormat.BufferType bufferMask)
		{
			// Update clear values (only what is necessary)
			if ((bufferMask & GraphicsBuffersFormat.BufferType.Color) != 0)
				Gl.ClearColor(mClearColor.Red, mClearColor.Green, mClearColor.Blue, mClearColor.Alpha);
			if ((bufferMask & GraphicsBuffersFormat.BufferType.Depth) != 0)
				Gl.ClearDepth(mClearDepth);
			if ((bufferMask & GraphicsBuffersFormat.BufferType.Stencil) != 0)
				Gl.ClearStencil(mClearStencil);
			
			// Clear
			Gl.Clear(GetClearFlags(bufferMask));
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

		private static ClearBufferMask GetClearFlags(GraphicsBuffersFormat.BufferType bufferMask)
		{
			ClearBufferMask clearFlags = 0;

			if ((bufferMask & GraphicsBuffersFormat.BufferType.Color) != 0)
				clearFlags |= ClearBufferMask.ColorBufferBit;
			if ((bufferMask & GraphicsBuffersFormat.BufferType.Depth) != 0)
				clearFlags |= ClearBufferMask.DepthBufferBit;
			if ((bufferMask & GraphicsBuffersFormat.BufferType.Stencil) != 0)
				clearFlags |= ClearBufferMask.StencilBufferBit;

			return (clearFlags);
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

		#region sRGB Support

		/// <summary>
		/// Enable sRGB color correction on this GraphicsSurface.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>.
		/// </param>
		/// <param name="surfaceFormat">
		/// A <see cref="GraphicsBuffersFormat"/> that specify this GraphicsSurface format.
		/// </param>
		/// <remarks>
		/// This routine can be called only in the case GraphicsContext.Caps.GlExtensions.FramebufferSRGB_ARB is supported.
		/// </remarks>
		protected void EnableSRGB(GraphicsContext ctx, GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.ColorSRGB) == false)
				throw new InvalidOperationException("surface has no sRGB buffer");
			if ((ctx.Caps.GlExtensions.FramebufferSRGB_ARB == false) && (ctx.Caps.GlExtensions.FramebufferSRGB_EXT == false))
				throw new InvalidOperationException("no framebuffer sRGB extension supported");

			Gl.Enable(EnableCap.FramebufferSrgb);
		}

		/// <summary>
		/// Disable sRGB color correction on this GraphicsSurface.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>.
		/// </param>
		/// <param name="surfaceFormat">
		/// A <see cref="GraphicsBuffersFormat"/> that specify this GraphicsSurface format.
		/// </param>
		protected void DisableSRGB(GraphicsContext ctx, GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.ColorSRGB) == false)
				throw new InvalidOperationException("surface has no sRGB buffer");
			if ((ctx.Caps.GlExtensions.FramebufferSRGB_ARB == false) && (ctx.Caps.GlExtensions.FramebufferSRGB_EXT == false))
				throw new InvalidOperationException("no framebuffer sRGB extension supported");

			Gl.Disable(EnableCap.FramebufferSrgb);
		}

		/// <summary>
		/// Check whether sRGB color correction on this GraphicsSurface is enabled.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/>.
		/// </param>
		/// <param name="surfaceFormat">
		/// 
		/// </param>
		/// <returns>
		/// Is returns a boolean value indicating whether sRGB color correction on this GraphicsSurface is enabled.
		/// </returns>
		protected bool IsEnabledSRGB(GraphicsContext ctx, GraphicsBuffersFormat surfaceFormat)
		{
			if (surfaceFormat.HasBuffer(GraphicsBuffersFormat.BufferType.ColorSRGB) == false)
				throw new InvalidOperationException("surface has no sRGB buffer");
			if ((ctx.Caps.GlExtensions.FramebufferSRGB_ARB == false) && (ctx.Caps.GlExtensions.FramebufferSRGB_EXT == false))
				throw new InvalidOperationException("no framebuffer sRGB extension supported");

			return (Gl.IsEnabled(EnableCap.FramebufferSrgb));
		}

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
		/// A <see cref="ReadBufferMode"/> that specifies the read buffer where the colors are read from.
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
			foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
				if (image.Stride % alignment == 0) {
					Gl.PixelStore(PixelStoreParameter.PackAlignment, alignment);
					break;
				}
			}

			// Grab frame buffer pixels
			PixelFormat rFormat = Pixel.GetGlFormat(pType);
			PixelType rType = Pixel.GetPixelType(pType);

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
		/// A <see cref="ReadBufferMode"/> that specifies the read buffer where the colors are read from.
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> that specifies the x coordinate of the lower left corder of the rectangle area to read.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> that specifies the y coordinate of the lower left corder of the rectangle area to read.
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
			Gl.CopyTexImage2D(texture.TextureTarget, (int)level, Pixel.GetGlInternalFormat(texture.PixelLayout, ctx), (int)x, (int)y, (int)texture.Width, (int)texture.Height, 0);

			// Unbind from reading
			UnbindRead(ctx);
			// Reset read configuration
			Gl.ReadBuffer(Gl.NONE);
		}

		#endregion
	}
}
