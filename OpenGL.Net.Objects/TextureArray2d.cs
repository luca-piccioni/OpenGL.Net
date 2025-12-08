
// Copyright (C) 2016-2017 Luca Piccioni
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
using System.Drawing;

namespace OpenGL.Objects
{
	/// <summary>
	/// Two dimensional array texture.
	/// </summary>
	public class TextureArray2d : Texture
	{
		#region Constructors

		/// <summary>
		/// Construct an undefined TextureArray2d.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It creates Texture object which has not defined extents, internal format and textels. To define this texture, call one
		/// of Create" methods (except <see cref="Create(GraphicsContext)"/>).
		/// </para>
		/// </remarks>
		public TextureArray2d()
		{

		}

		/// <summary>
		/// Create TextureArray2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="layers">
		/// A <see cref="UInt32"/> that specify the texture layers.
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by the current context and <paramref name="width"/>
		/// or <paramref name="height"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public TextureArray2d(uint width, uint height, uint layers, PixelLayout format)
		{
			Create(width, height, layers, format);
		}

		#endregion

		#region Create

		/// <summary>
		/// Technique defining an empty texture.
		/// </summary>
		class EmptyTechnique : Technique
		{
			#region Constructors

			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specifies the texture target.
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
			/// <param name="layers">
			/// A <see cref="UInt32"/> that specifies the number of layers defining the texture array.
			/// </param>
			/// <param name="level">
			/// A <see cref="UInt32"/> that specifies the mipmap level affected.
			/// </param>
			public EmptyTechnique(TextureArray2d texture, TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint layers, uint level)
			{
				_TextureArray2d = texture;
				_Target = target;
				_PixelFormat = pixelFormat;
				_Width = width;
				_Height = height;
				_Layers = layers;
				_Level = level;
			}

			#endregion

			#region Technique Overrides

			/// <summary>
			/// The <see cref="TextureArray2d"/> affected by this Technique.
			/// </summary>
			protected readonly TextureArray2d _TextureArray2d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			protected readonly TextureTarget _Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			protected readonly PixelLayout _PixelFormat;

			/// <summary>
			/// Texture width.
			/// </summary>
			protected readonly uint _Width;

			/// <summary>
			/// Texture height.
			/// </summary>
			protected readonly uint _Height;

			/// <summary>
			/// Texture layers.
			/// </summary>
			protected readonly uint _Layers;

			/// <summary>
			/// Texture mipmap level.
			/// </summary>
			protected readonly uint _Level;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				InternalFormat internalFormat = _PixelFormat.ToInternalFormat();
				PixelFormat format = _PixelFormat.ToDataFormat();

				// Define empty texture
				Gl.TexImage3D(_Target, (int)_Level, internalFormat, (int)_Width, (int)_Height, (int)_Layers, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				// Define texture properties
				_TextureArray2d.SetMipmap(_PixelFormat, _Width, _Height, _Layers, _Level);
			}

			#endregion
		}

		/// <summary>
		/// Technique defining an immutable empty texture.
		/// </summary>
		class ImmutableEmptyTechnique : EmptyTechnique
		{
			#region Constructors

			/// <summary>
			/// Construct a ImmutableEmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> affected by this Technique.
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
			/// <param name="layers">
			/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
			/// </param>
			public ImmutableEmptyTechnique(TextureArray2d texture, TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint layers) :
				this(texture, target, pixelFormat, width, height, layers, GetMipmapCompleteLevels(width, height, 1, 0))
			{

			}

			/// <summary>
			/// Construct a ImmutableEmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> affected by this Technique.
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
			/// <param name="layers">
			/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
			/// </param>
			/// <param name="levels">
			/// A <see cref="UInt32"/> that specify the number of levels defining the texture array.
			/// </param>
			public ImmutableEmptyTechnique(TextureArray2d texture, TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint layers, uint levels) :
				base(texture, target, pixelFormat, width, height, layers, 0)
			{
				if (levels == 0)
					throw new ArgumentException("invalid value", nameof(levels));
				_MipmapLevels = levels;
			}

			#endregion

			#region EmptyTechnique Overrides

			/// <summary>
			/// Texture mipmaps levels.
			/// </summary>
			protected readonly uint _MipmapLevels;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				// Define storage
				if (ctx.Extensions.TextureStorage_ARB == false) {
					PixelFormat format = _PixelFormat.ToDataFormat();
					InternalFormat internalFormat = _PixelFormat.ToInternalFormat();

					for (uint level = 0, w = _Width, h = _Height; level < _MipmapLevels; level++, w = Math.Max(1, w / 2), h = Math.Max(1, h / 2))
						Gl.TexImage3D(_Target, (int)level, internalFormat, (int)w, (int)h, (int)_Layers, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				} else {
					SizedInternalFormat internalFormat = _PixelFormat.ToSizedInternalFormat();

					Gl.TexStorage3D(_Target, (int)_MipmapLevels, internalFormat, (int)_Width, (int)_Height, (int)_Layers);
				}

				// Define mipmap array
				for (uint level = 0, w = _Width, h = _Height; level < _MipmapLevels; level++, w = Math.Max(1, w / 2), h = Math.Max(1, h / 2))
					_TextureArray2d.SetMipmap(_PixelFormat, w, h, _Layers, level);
			}

			#endregion
		}

		#region Create(width, height, layers, PixelLayout)

		/// <summary>
		/// Create a TextureArray2d, defining the texture size (for level 0) and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height, in pixels.
		/// </param>
		/// <param name="layers">
		/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
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
		public void Create(uint width, uint height, uint layers, PixelLayout format)
		{
			Technique technique;

			if (Immutable)
				technique = new ImmutableEmptyTechnique(this, TextureTarget, format, width, height, layers);
			else
				technique = new EmptyTechnique(this, TextureTarget, format, width, height, layers, 0);

			SetTechnique(technique);
		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
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
		/// <param name="layers">
		/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="ctx"/>, and <paramref name="width"/> or <paramref name="height"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(GraphicsContext ctx, uint width, uint height, uint layers, PixelLayout format)
		{
			CheckCurrentContext(ctx);

			Create(width, height, layers, format);
			Create(ctx);
		}

		#endregion

		#region Create(width, height, layers, PixelLayout, levels)

		/// <summary>
		/// Create a TextureArray2d, defining the texture size (for level 0) and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height, in pixels.
		/// </param>
		/// <param name="layers">
		/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <param name="levels">
		/// A <see cref="UInt32"/> that specifies the number of mipmap levels to define.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> or <paramref name="levels"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
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
		public void Create(uint width, uint height, uint layers, PixelLayout format, uint levels)
		{
			if (Immutable == false)
				throw new InvalidOperationException("must be immutable");
			SetTechnique(new ImmutableEmptyTechnique(this, TextureTarget, format, width, height, layers, levels));
		}

		/// <summary>
		/// Create a TextureArray2d, defining the texture size (for level 0) and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width, in pixels.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height, in pixels.
		/// </param>
		/// <param name="layers">
		/// A <see cref="UInt32"/> that specify the number of layers defining the texture array.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <param name="levels">
		/// A <see cref="UInt32"/> that specifies the number of mipmap levels to define.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> or <paramref name="levels"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
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
		public void Create(GraphicsContext ctx, uint width, uint height, uint layers, PixelLayout format, uint levels)
		{
			CheckCurrentContext(ctx);

			Create(width, height, layers, format, levels);
			Create(ctx);
		}

		#endregion

		#endregion

		#region Update

		/// <summary>
		/// Technique updating a texture based on image.
		/// </summary>
		private class ImageUpdateTechnique : Technique
		{
			#region Constructors

			/// <summary>
			/// Construct a ImageTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specifies the texture target.
			/// </param>
			/// <param name="image">
			/// A <see cref="Image"/> that specifies the texture array image for the specified layer.
			/// </param>
			/// <param name="layer">
			/// The depth of <paramref name="image"/> within <paramref name="texture"/>.
			/// </param>
			public ImageUpdateTechnique(TextureArray2d texture, TextureTarget target, Image image, uint layer) :
				this(texture, target, 0, image, layer)
			{

			}

			/// <summary>
			/// Construct a ImageTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specifies the texture target.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
			/// </param>
			/// <param name="image">
			/// A <see cref="Image"/> that specifies the texture array image for the specified layer.
			/// </param>
			/// <param name="layer">
			/// The depth of <paramref name="image"/> within <paramref name="texture"/>.
			/// </param>
			public ImageUpdateTechnique(TextureArray2d texture, TextureTarget target, uint level, Image image, uint layer)
			{
				if (image == null)
					throw new ArgumentNullException(nameof(image));

				_TextureArray2d = texture;
				_Target = target;
				_Level = level;
				_Image = image;
				_Image.IncRef();
				_ImageLayer = layer;
			}

			#endregion

			#region Technique Overrides

			/// <summary>
			/// The <see cref="TextureArray2d"/> affected by this Technique.
			/// </summary>
			protected readonly TextureArray2d _TextureArray2d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			protected readonly TextureTarget _Target;

			/// <summary>
			/// The specific level of the target to define. Defaults to zero.
			/// </summary>
			protected readonly uint _Level;

			/// <summary>
			/// The image that represents the texture data.
			/// </summary>
			protected readonly Image _Image;

			/// <summary>
			/// The index of the texture array for <see cref="_Image"/>.
			/// </summary>
			protected readonly uint _ImageLayer;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				// Define array layers
				PixelFormat format = _Image.PixelLayout.ToDataFormat();
				PixelType type = _Image.PixelLayout.ToPixelType();

				// Set pixel alignment
				State.PixelUnpackState.Align(_Image.Stride).Apply(ctx, null);

				// Upload texture contents
				Gl.TexSubImage3D(_Target, (int)_Level, 0, 0, (int)_ImageLayer, (int)_Image.Width, (int)_Image.Height, 1, format, type, _Image.ImageBuffer);
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				_Image.DecRef();
			}

			#endregion
		}

		#region Update(Image, Layer)

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		public void Update(Image image, uint layer)
		{
			SetTechnique(new ImageUpdateTechnique(this, TextureTarget, image, layer));
		}

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for updating this Texture.
		/// </param>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		public void Update(GraphicsContext ctx, Image image, uint layer)
		{
			Update(image, layer);
			Create(ctx);
		}

		#endregion

		#region Update(Image, Layer, Level)

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <param name="level">
		/// The mipmap level to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		public void Update(Image image, uint layer, uint level)
		{
			SetTechnique(new ImageUpdateTechnique(this, TextureTarget, level, image, layer));
		}

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for updating this Texture.
		/// </param>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <param name="level">
		/// The mipmap level to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		public void Update(GraphicsContext ctx, Image image, uint layer, uint level)
		{
			Update(image, layer, level);
			Create(ctx);
		}

		#endregion

#if !MONODROID

		#region Update(Bitmap, Layer)

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="bitmap">
		/// An <see cref="Bitmap"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="bitmap"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> format (<see cref="Image.PixelLayout"/> is not a supported internal format.
		/// </exception>
		public void Update(Bitmap bitmap, uint layer)
		{
			if (layer >= Depth)
				throw new ArgumentOutOfRangeException("layer", "exceeding upper boundary");

			// Fictive array for defining only one layer
			Image image = CoreImagingImageCodecPlugin.LoadFromBitmap(bitmap, new ImageCodecCriteria());

			SetTechnique(new ImageUpdateTechnique(this, TextureTarget, image, layer));
		}

		/// <summary>
		/// Update a TextureArray2d layer.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for updating this Texture.
		/// </param>
		/// <param name="bitmap">
		/// An <see cref="Bitmap"/> holding the texture data.
		/// </param>
		/// <param name="layer">
		/// A <see cref="uint"/> that specify the texture layer to update.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="bitmap"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="image"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="bitmap"/> format (<see cref="Image.PixelLayout"/> is not a supported internal format.
		/// </exception>
		public void Update(GraphicsContext ctx, Bitmap bitmap, uint layer)
		{
			Update(bitmap, layer);
			Create(ctx);
		}

		#endregion

#endif

		#endregion

		#region Copy

		/// <summary>
		/// Copy a <see cref="TextureArray2d"/> into this TextureArray2d.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for copying.
		/// </param>
		/// <param name="otherTexture">
		/// The <see cref="TextureArray2d"/> holding the source pixels.
		/// </param>
		public void Copy(GraphicsContext ctx, TextureArray2d otherTexture)
		{
			CheckCurrentContext(ctx);
			CheckThatExistence(ctx, otherTexture);

			if (otherTexture.Width > Width || otherTexture.Height > Height || otherTexture.Depth > Depth)
				throw new ArgumentException("source extents too large", nameof(otherTexture));
			if (otherTexture.MipmapLevels > MipmapLevels)
				throw new ArgumentException("source levels too large", nameof(otherTexture));

			if (ctx.Version >= Gl.Version_430 || ctx.Extensions.CopyImage_ARB) {

				// Copy all levels using CopyImageSubData

				for (uint level = 0; level < otherTexture.MipmapLevels; ++level) {
					Gl.CopyImageSubData(
						otherTexture.ObjectName, (CopyImageSubDataTarget)otherTexture.TextureTarget, (int)level, 0, 0, 0,
						ObjectName, (CopyImageSubDataTarget)TextureTarget, (int)level, 0, 0, 0,
						(int)otherTexture.Width, (int)otherTexture.Height, (int)otherTexture.Depth
					);
				}

			} else
				throw new NotSupportedException();
		}

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return TextureTarget.Texture2dArray; } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get
			{
				if (PixelLayout.IsIntegerPixel()) {
					if (PixelLayout.IsSignedIntegerPixel())
						return Gl.INT_SAMPLER_2D_ARRAY;
					if (PixelLayout.IsUnsignedIntegerPixel())
						return Gl.UNSIGNED_INT_SAMPLER_2D_ARRAY;

					throw new NotSupportedException(String.Format("integer pixel format {0} not supported", PixelLayout));
				} else
					return Gl.SAMPLER_2D_ARRAY;
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

			if (ctx.Extensions.TextureArray_EXT == false)
				throw new NotSupportedException("GL_EXT_texture_array not supported");

			// Base implementation
			base.Create(ctx);
		}

		#endregion
	}
}
