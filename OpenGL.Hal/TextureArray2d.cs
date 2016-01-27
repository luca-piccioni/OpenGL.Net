
// Copyright (C) 2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Two dimensional array texture.
	/// </summary>
	[DebuggerDisplay("TextureArray2d: Pixel={mPixelFormat} Width={Width} Height={Height}")]
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
			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
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
			public EmptyTechnique(TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint layers)
			{
				Target = target;
				PixelFormat = pixelFormat;
				Width = width;
				Height = height;
				Layers = layers;
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelLayout PixelFormat;

			/// <summary>
			/// Texture width.
			/// </summary>
			readonly uint Width;

			/// <summary>
			/// Texture height.
			/// </summary>
			readonly uint Height;

			/// <summary>
			/// Texture layers.
			/// </summary>
			readonly uint Layers;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = Pixel.GetGlFormat(PixelFormat);
				int internalFormat = Pixel.GetGlInternalFormat(PixelFormat, ctx);

				// Define empty texture
				Gl.TexImage3D(Target, 0, internalFormat, (int)Width, (int)Height, (int)Layers, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
			}
		}

		#region Create(uint, uint, uint, PixelLayout)

		/// <summary>
		/// Create a TextureArray2d, defining the texture extents and the internal format.
		/// </summary>
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
			// Setup texture information
			PixelLayout = format;
			_Width = width;
			_Height = height;
			_Layers = layers;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(TextureTarget, format, width, height, layers));
		}

		#endregion

		#region Create(GraphicsContext, uint, uint, PixelLayout)

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
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Define technique
			Create(width, height, layers, format);
			// Actually create texture
			Create(ctx);
		}

		#endregion

		/// <summary>
		/// Technique defining a texture based on image.
		/// </summary>
		class ImageTechnique : Technique
		{
			/// <summary>
			/// Construct a ImageTechnique.
			/// </summary>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The <see cref="PixelLayout"/> that specify texture pixel format.
			/// </param>
			/// <param name="image">
			/// A <see cref="Image[]"/> that specify the texture array layers.
			/// </param>
			public ImageTechnique(TextureTarget target, PixelLayout pixelFormat, Image[] images)
			{
				if (images == null)
					throw new ArgumentNullException("images");
				if (images.Length == 0)
					throw new ArgumentException("no image layers", "images");
				if (Array.TrueForAll(images, delegate (Image item) { return (item != null); }) == false)
					throw new ArgumentException("null image layer", "images");
				if (Array.TrueForAll(images, delegate (Image item) { return (item.Width == images[0].Width && item.Height == images[0].Height); }) == false)
					throw new ArgumentException("non-uniform image layers extents", "images");

				Target = target;
				PixelFormat = pixelFormat;
				Images = images;
				foreach (Image image in images)
					if (image != null) image.IncRef();
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout PixelFormat;

			/// <summary>
			/// The image that represents the texture data.
			/// </summary>
			private readonly Image[] Images;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(PixelFormat, ctx);

				// Define texture storage
				Gl.TexImage3D(Target, 0, internalFormat, (int)Images[0].Width, (int)Images[0].Height, Images.Length, 0, /* Unused */ OpenGL.PixelFormat.Rgb, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				// Define array layers
				for (int layer = 0; layer < Images.Length; layer++) {
					PixelFormat format = Pixel.GetGlFormat(Images[0].PixelLayout);
					PixelType type = Pixel.GetPixelType(Images[0].PixelLayout);

					// Set pixel transfer (may vary from image to image)
					foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
						if ((Images[layer].Stride % alignment) != 0)
							continue;
						Gl.PixelStore(PixelStoreParameter.UnpackAlignment, alignment);
						break;
					}

					// Upload texture contents
					Gl.TexSubImage3D(Target, 0, 0, 0, 0, (int)Images[layer].Width, (int)Images[layer].Height, layer, format, type, Images[layer].ImageBuffer);
				}
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				foreach (Image image in Images)
					if (image != null) image.DecRef();
			}
		}

		#region Create(PixelLayout, Image[])

		/// <summary>
		/// Create Texture2d data from a Image instance.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="images"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="images"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="images"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="images"/> width or height are
		/// not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="images"/> format (<see cref="Image.PixelFormat"/> is not a supported internal format.
		/// </exception>
		public void Create(PixelLayout internalFormat, Image[] images)
		{
			// Setup texture information
			PixelLayout = internalFormat;
			_Width = images[0].Width;
			_Height = images[0].Height;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(TextureTarget, internalFormat, images));
		}

		#endregion

		#region Create(GraphicsContext, PixelLayout, Image[])

		/// <summary>
		/// Create Texture2d from a Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture. If it null, the current context
		/// will be used.
		/// </param>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="image"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> pixel data is not allocated (i.e. image not defined).
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> width or height are greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="ctx"/> (or the current context if <paramref name="ctx"/> is
		/// null), and <paramref name="image"/> width or height are not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> format (<see cref="Image.PixelFormat"/> is not a supported internal format.
		/// </exception>
		public void Create(GraphicsContext ctx, PixelLayout internalFormat, Image[] images)
		{
			// Define texture technique
			Create(internalFormat, images);
			// Define texture
			Create(ctx);
		}

		#endregion

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Texture width.
		/// </summary>
		public override uint Width { get { return (_Width); } }

		/// <summary>
		/// Texture height.
		/// </summary>
		public override uint Height { get { return (_Height); } }

		/// <summary>
		/// Texture depth.
		/// </summary>
		/// <remarks>
		/// Only Texture3d target has a depth. For every else texture target, it is set to 1.
		/// </remarks>
		public override uint Depth { get { return (_Layers); } }

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return (TextureTarget.Texture2dArray); } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get
			{
				if (Pixel.IsGlIntegerPixel(PixelLayout)) {
					if (Pixel.IsGlSignedIntegerPixel(PixelLayout))
						return (Gl.INT_SAMPLER_2D_ARRAY);
					if (Pixel.IsGlUnsignedIntegerPixel(PixelLayout))
						return (Gl.UNSIGNED_INT_SAMPLER_2D_ARRAY);

					throw new NotSupportedException(String.Format("integer pixel format {0} not correctly supported", PixelLayout));
				} else
					return (Gl.SAMPLER_2D_ARRAY);
			}
		}

		/// <summary>
		/// Texture width.
		/// </summary>
		private uint _Width;

		/// <summary>
		/// Texture height.
		/// </summary>
		private uint _Height;

		/// <summary>
		/// Texture layers.
		/// </summary>
		private uint _Layers;

		#endregion
	}
}
