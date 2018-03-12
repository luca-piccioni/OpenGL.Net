
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
using System.Diagnostics;

namespace OpenGL.Objects
{
	/// <summary>
	/// Three dimensional texture.
	/// </summary>
	public class Texture3d : Texture
	{
		#region Constructors

		/// <summary>
		/// Construct an undefined Texture3d.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It creates Texture object which has not defined extents, internal format and textels. To define this texture, call one
		/// of Create" methods (except <see cref="Create(GraphicsContext)"/>).
		/// </para>
		/// </remarks>
		public Texture3d()
		{

		}

		/// <summary>
		/// Construct a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="width"/> or <paramref name="height"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public Texture3d(uint width, uint height, uint depth, PixelLayout format)
		{
			Create(width, height, depth, format);
		}

		/// <summary>
		/// Construct a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="width"/> or <paramref name="height"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public Texture3d(GraphicsContext ctx, uint width, uint height, uint depth, PixelLayout format)
		{
			Create(ctx, width, height, depth, format);
		}

		#endregion

		#region Create

		/// <summary>
		/// Technique defining an empty texture.
		/// </summary>
		class EmptyTechnique : Technique
		{
			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture3d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="width">
			/// The width of the texture.
			/// </param>
			/// <param name="height">
			/// The height of the texture.
			/// </param>
			/// <param name="depth">
			/// The depth of the texture.
			/// </param>
			public EmptyTechnique(Texture3d texture, TextureTarget target, uint level, PixelLayout pixelFormat, uint width, uint height, uint depth) :
				base(texture)
			{
				_Texture3d = texture;
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Width = width;
				_Height = height;
				_Depth = depth;
			}

			/// <summary>
			/// The <see cref="Texture3d"/> affected by this Technique.
			/// </summary>
			private readonly Texture3d _Texture3d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget _Target;

			/// <summary>
			/// The specific level of the target to define. Defaults to zero.
			/// </summary>
			private readonly uint _Level;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout _PixelFormat;

			/// <summary>
			/// Texture width.
			/// </summary>
			private readonly uint _Width;

			/// <summary>
			/// Texture height.
			/// </summary>
			private readonly uint _Height;

			/// <summary>
			/// Texture depth.
			/// </summary>
			private readonly uint _Depth;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = _PixelFormat.ToDataFormat();
				InternalFormat internalFormat = _PixelFormat.ToInternalFormat();

				// Define empty texture
				Gl.TexImage3D(_Target, (int)_Level, internalFormat, (int)_Width, (int)_Height, (int)_Depth, 0, format, /* Unused */ PixelType.UnsignedByte, null);
				// Define texture properties
				_Texture3d.SetMipmap(_PixelFormat, _Width, _Height, _Depth, _Level);
			}
		}

		#region Create(uint, uint, uint, PixelLayout)

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="width"/> or <paramref name="height"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(uint width, uint height, uint depth, PixelLayout format)
		{
			// Setup technique for creation
			SetTechnique(new EmptyTechnique(this, TextureTarget, 0, format, width, height, depth));
		}

		#endregion

		#region Create(GraphicsContext, uint, uint, uint, PixelLayout)

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="width"/> or <paramref name="height"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(GraphicsContext ctx, uint width, uint height, uint depth, PixelLayout format)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Define technique
			Create(width, height, depth, format);
			// Actually create texture
			Create(ctx);
		}

		#endregion

		/// <summary>
		/// Technique defining a texture based on images.
		/// </summary>
		class ImageTechnique : Technique
		{
			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture3d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="images">
			/// The image set of the texture.
			/// </param>
			public ImageTechnique(Texture3d texture, TextureTarget target, PixelLayout pixelFormat, Image[] images) :
				base(texture)
			{
				if (images == null)
					throw new ArgumentNullException("images");
				if (images.Length == 0)
					throw new ArgumentException("no images", "images");
				if (!Array.TrueForAll(images, delegate(Image item) { return (item != null); }))
					throw new ArgumentException("null item in image set", "images");
				if (!Array.TrueForAll(images, delegate(Image item) { return (item.Width == images[0].Width && item.Height == images[0].Height); }))
					throw new ArgumentException("eterogeneous size in image set", "images");

				_Texture3d = texture;
				_Target = target;
				_PixelFormat = pixelFormat;
				_Images = images;
				Array.ForEach(_Images, delegate(Image image) { image.IncRef(); });	// Referenced
			}

			/// <summary>
			/// The <see cref="Texture3d"/> affected by this Technique.
			/// </summary>
			private readonly Texture3d _Texture3d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget _Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout _PixelFormat;

			/// <summary>
			/// The images that represents the texture data.
			/// </summary>
			private readonly Image[] _Images;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				InternalFormat internalFormat = _PixelFormat.ToInternalFormat();
				uint width = _Images[0].Width, height = _Images[0].Height;

				Gl.TexImage3D(_Target, 0, internalFormat, (int)width, (int)height, _Images.Length, 0, /* Unused */ OpenGL.PixelFormat.Red, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);

				for (int i = 0; i < _Images.Length; i++) {
					Image image = _Images[i];

					PixelFormat format = image.PixelLayout.ToDataFormat();
					PixelType type = image.PixelLayout.ToPixelType();

					// Set pixel alignment
					State.PixelAlignmentState.Unpack(image.Stride).Apply(ctx, null);

					// Upload texture contents
					Gl.TexSubImage3D(_Target, 0, 0, 0, i, (int)width, (int)height, 1, format, type, image.ImageBuffer);
				}

				// Define texture properties
				_Texture3d.SetMipmap(_PixelFormat, width, height, (uint)_Images.Length, 0);
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				Array.ForEach(_Images, delegate(Image image) { image.DecRef(); });
			}
		}

		#region Create(Image[], PixelLayout)

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="images">
		/// An array of <see cref="Image"/> that specify the texture data.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="images"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="images"/> has no items, or every item hasn't the same width and height.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if width, height or depth is greater than the maximum allowed for 3D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and width, height or depth 
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(Image[] images, PixelLayout format)
		{
			if (images == null)
				throw new ArgumentNullException("images");
			if (images.Length == 0)
				throw new ArgumentException("no images", "images");
			if (!Array.TrueForAll(images, delegate(Image item) { return (item != null); }))
				throw new ArgumentException("null item in image set", "images");
			if (!Array.TrueForAll(images, delegate(Image item) { return (item.Width == images[0].Width && item.Height == images[0].Height); }))
				throw new ArgumentException("eterogeneous size in image set", "images");

			// Setup technique for creation
			SetTechnique(new ImageTechnique(this, TextureTarget, format, images));
		}

		#endregion

		#region Create(GraphicsContext, Image[], PixelLayout)

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="images">
		/// An array of <see cref="Image"/> that specify the texture data.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="images"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="images"/> has no items, or every item hasn't the same width and height.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if width, height or depth is greater than the maximum allowed for 3D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and width, height or depth 
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(GraphicsContext ctx, Image[] images, PixelLayout format)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Define technique
			Create(images, format);
			// Actually create texture
			Create(ctx);
		}

		#endregion

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return (TextureTarget.Texture3d); } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get
			{
				if (PixelLayout.IsIntegerPixel()) {
					if (PixelLayout.IsSignedIntegerPixel())
						return (Gl.INT_SAMPLER_3D);
					if (PixelLayout.IsUnsignedIntegerPixel())
						return (Gl.UNSIGNED_INT_SAMPLER_3D);

					throw new NotSupportedException(String.Format("integer pixel format {0} not supported", PixelLayout));
				} else
					return (Gl.SAMPLER_3D);
			}
		}

		/// <summary>
		/// Create this GraphicsResource, checking if the requires OpenGL extensions are.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object.
		/// </param>
		public override void Create(GraphicsContext ctx)
		{
			// Check extensions support
			CheckValidContext(ctx);

			if (!ctx.Extensions.Texture3D_EXT && !ctx.Extensions.Texture3D_OES)
				throw new NotSupportedException("GL_EXT|OES_texture3D not supported");

			// Base implementation
			base.Create(ctx);
		}

		#endregion
	}
}
