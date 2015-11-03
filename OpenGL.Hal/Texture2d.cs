
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
using System.Diagnostics;
using System.Drawing;

using Image = Derm.Raster.Image;

namespace OpenGL
{
	/// <summary>
	/// Two dimensional texture.
	/// </summary>
	/// <remarks>
	/// <para>
	/// 
	/// </para>
	/// <para>
	/// 
	/// </para>
	/// </remarks>
	[DebuggerDisplay("Texture2d [ Pixel:{mPixelFormat} Width:{Width} Height:{Height} ]")]
	public class Texture2d : TextureBase
	{
		#region Constructors

		/// <summary>
		/// Construct an undefined Texture2d.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It creates Texture object which has not defined extents, internal format and textels. To define this texture, call one
		/// of Create" methods (except <see cref="Create(GraphicsContext)"/>).
		/// </para>
		/// </remarks>
		public Texture2d()
		{

		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelFormat"/> determining the texture internal format.
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
		public Texture2d(uint width, uint height, PixelFormat format)
		{
			Create(width, height, format);
		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture. If it null, the current context
		/// will be used.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelFormat"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is greater than
		/// the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="ctx"/> (or by the current context is <paramref name="ctx"/> is
		/// null), and <paramref name="width"/> or <paramref name="height"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public Texture2d(GraphicsContext ctx, uint width, uint height, PixelFormat format)
		{
			Create(ctx, width, height, format);
		}
		
		#endregion

		#region Texture Creation

		/// <summary>
		/// Technique defining an empty texture.
		/// </summary>
		class EmptyTechnique : Technique
		{
			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="target">
			/// A <see cref="System.Int32"/> that specify the texture target.
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
			public EmptyTechnique(int target, PixelFormat pixelFormat, uint width, uint height)
			{
				Target = target;
				PixelFormat = pixelFormat;
				Width = width;
				Height = height;
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly int Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelFormat PixelFormat;

			/// <summary>
			/// Texture width.
			/// </summary>
			readonly uint Width;

			/// <summary>
			/// Texture height.
			/// </summary>
			readonly uint Height;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int format = Pixel.GetGlFormat(PixelFormat);
				int internalFormat = Pixel.GetGlInternalFormat(PixelFormat, ctx);

				// Define empty texture
				Gl.TexImage2D(Target, 0, internalFormat, (int)Width, (int)Height, 0, format, /* Unused */ Gl.UNSIGNED_BYTE, null);
				GraphicsException.CheckErrors();
			}
		}

		/// <summary>
		/// Technique defining a texture based on image.
		/// </summary>
		class ImageTechnique : Technique
		{
			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="target">
			/// A <see cref="System.Int32"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="image">
			/// The width of the texture.
			/// </param>
			public ImageTechnique(int target, PixelFormat pixelFormat, Image image)
			{
				if (image == null)
					throw new ArgumentNullException("image");

				Target = target;
				PixelFormat = pixelFormat;
				Image = image;
				Image.IncRef();		// Referenced
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly int Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelFormat PixelFormat;

			/// <summary>
			/// The image that represents the texture data.
			/// </summary>
			private readonly Image Image;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(PixelFormat, ctx);

				int type = Pixel.GetGlDataFormat(Image.PixelFormat);
				int format = Pixel.GetGlFormat(Image.PixelFormat);

				// Set pixel transfer
				foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
					if ((Image.Stride % alignment) != 0)
						continue;
					Gl.PixelStore(Gl.UNPACK_ALIGNMENT, alignment);
					GraphicsException.DebugCheckErrors();
					break;
				}

				// Upload texture contents
				Gl.TexImage2D(Target, 0, internalFormat, (int)Image.Width, (int)Image.Height, 0, format, type, Image.ImageBuffer);
				GraphicsException.CheckErrors();
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (Image != null)
					Image.DecRef();
			}
		}

		/// <summary>
		/// Create a Texture2d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelFormat"/> determining the texture internal format.
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
		public void Create(uint width, uint height, PixelFormat format)
		{
			// Check context compatibility
			CheckCapabilities(width, height, Depth, format);

			// Setup texture information
			PixelFormat = format;
			mWidth = width;
			mHeight = height;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(TextureTarget, format, width, height));
		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelFormat"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> or <paramref name="height"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
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
		public void Create(GraphicsContext ctx, uint width, uint height, PixelFormat format)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Define technique
			Create(width, height, format);
			// Actually create texture
			Create(ctx);
		}

		/// <summary>
		/// Create Texture2d data from a Image instance.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Derm.Raster.Image"/> holding the texture data.
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
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="image"/> format (<see cref="Image.PixelFormat"/> is not a supported internal format.
		/// </exception>
		public void Create(Image image)
		{
			if (image == null)
				throw new ArgumentNullException("image");

			// Check context compatibility
			CheckCapabilities(image.Width, image.Height, 1, image.PixelFormat);

			// Setup texture information
			PixelFormat = image.PixelFormat;
			mWidth = image.Width;
			mHeight = image.Height;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(TextureTarget, image.PixelFormat, image));
		}

		/// <summary>
		/// Create Texture2d from a Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture. If it null, the current context
		/// will be used.
		/// </param>
		/// <param name="image">
		/// An <see cref="Derm.Raster.Image"/> holding the texture data.
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
		public void Create(GraphicsContext ctx, Image image)
		{
			// Define texture technique
			Create(image);
			// Define texture
			Create(ctx);
		}

		public void Create(Bitmap bitmap)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");

			// Create image from bitmap
			Image image = CoreImagingImageCodecPlugin.LoadFromBitmap(bitmap, new MediaCodecCriteria());
			// Bitmaps must be flipped
			image.FlipVertically();

			// Create with Image as usual
			Create(image);
		}

		public void Create(GraphicsContext ctx, Bitmap bitmap)
		{
			// Define texture technique
			Create(bitmap);
			// Define texture
			Create(ctx);
		}

		#endregion

		#region Texture Download

		/// <summary>
		/// Download Texture2D data to an Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for downloading texture data.
		/// </param>
		/// <param name="pType">
		/// A <see cref="PixelFormat"/> determining the pixel format of the downloaded data.
		/// </param>
		/// <returns>
		/// </returns>
		public Image Get(GraphicsContext ctx, PixelFormat pType)
		{
			return (Get(ctx, pType, TextureTarget)[0]);
		}

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Texture width.
		/// </summary>
		public override uint Width { get { return (mWidth); } }

		/// <summary>
		/// Texture height.
		/// </summary>
		public override uint Height { get { return (mHeight); } }

		/// <summary>
		/// Texture depth.
		/// </summary>
		/// <remarks>
		/// Only Texture3d target has a depth. For every else texture target, it is set to 1.
		/// </remarks>
		public override uint Depth { get { return (1); } }

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override int TextureTarget { get { return (Gl.TEXTURE_2D); } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get {
				if (Pixel.IsGlIntegerPixel(PixelFormat)) {
					if (Pixel.IsGlSignedIntegerPixel(PixelFormat))
						return (Gl.INT_SAMPLER_2D);
					if (Pixel.IsGlUnsignedIntegerPixel(PixelFormat))
						return (Gl.UNSIGNED_INT_SAMPLER_2D);

					throw new NotSupportedException(String.Format("integer pixel format {0} not correctly supported", PixelFormat));
				} else
					return (Gl.SAMPLER_2D);
			}
		}

		/// <summary>
		/// Texture width.
		/// </summary>
		private uint mWidth;

		/// <summary>
		/// Texture height.
		/// </summary>
		private uint mHeight;

		#endregion
	}
}
