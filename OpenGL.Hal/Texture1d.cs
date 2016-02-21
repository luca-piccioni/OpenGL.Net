
// Copyright (C) 2009-2016 Luca Piccioni
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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;

namespace OpenGL
{
	/// <summary>
	/// One dimensional texture.
	/// </summary>
	[DebuggerDisplay("Texture1d: Width={Width}")]
	public class Texture1d : Texture
	{
		#region Constructors

		/// <summary>
		/// Construct an undefined Texture1d.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It creates Texture object which has not defined extents, internal format and textels. To define this texture, call one
		/// of Create" methods (except <see cref="Create(GraphicsContext)"/>).
		/// </para>
		/// </remarks>
		public Texture1d()
		{

		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is greater than the maximum allowed for 1D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by the current context and <paramref name="width"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public Texture1d(uint width, PixelLayout format)
		{
			Create(width, format);
		}

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture. If it null, the current context
		/// will be used.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelFormat.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is greater than the maximum allowed for 2D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="ctx"/> and <paramref name="width"/>
		/// is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public Texture1d(GraphicsContext ctx, uint width, PixelLayout format)
		{
			Create(ctx, width, format);
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
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="width">
			/// The width of the texture.
			/// </param>
			public EmptyTechnique(PixelLayout pixelFormat, uint width)
			{
				PixelFormat = pixelFormat;
				Width = width;
			}

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelLayout PixelFormat;

			/// <summary>
			/// Texture width.
			/// </summary>
			readonly uint Width;

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
				Gl.TexImage1D(TextureTarget.Texture1d, 0, internalFormat, (int)Width, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
			}
		}

		#region Create(uint, PixelLayout)

		/// <summary>
		/// Create a Texture1d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is greater than the maximum allowed for 1D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by current context, and <paramref name="width"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(uint width, PixelLayout format)
		{
			// Setup texture information
			PixelLayout = format;
			_Width = width;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(format, width));
		}

		#endregion

		#region Create(GraphicsContext, uint, PixelLayout)

		/// <summary>
		/// Create Texture2d data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="format">
		/// A <see cref="PixelLayout"/> determining the texture internal format.
		/// </param>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is zero.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> equals to <see cref="PixelLayout.None"/>.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/> is greater than the maximum allowed for 1D textures.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="ctx"/>, and <paramref name="width"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		public void Create(GraphicsContext ctx, uint width, PixelLayout format)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			// Define technique
			Create(width, format);
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
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="image">
			/// The width of the texture.
			/// </param>
			public ImageTechnique(PixelLayout pixelFormat, Image image)
			{
				if (image == null)
					throw new ArgumentNullException("image");
				if (image.Height != 1)
					throw new ArgumentException("height greater than 1", "image");

				PixelFormat = pixelFormat;
				Image = image;
				Image.IncRef();		// Referenced
			}

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout PixelFormat;

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
				PixelFormat format = Pixel.GetGlFormat(Image.PixelLayout);
				PixelType type = Pixel.GetPixelType(Image.PixelLayout);

				// Set pixel transfer
				foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
					if ((Image.Stride % alignment) != 0)
						continue;
					Gl.PixelStore(PixelStoreParameter.UnpackAlignment, alignment);
					break;
				}

				// Upload texture contents
				Gl.TexImage1D(TextureTarget.Texture1d, 0, internalFormat, (int)Image.Width, 0, format, type, Image.ImageBuffer);
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

		#region Create(Image)

		/// <summary>
		/// Create Texture2d data from a Image instance.
		/// </summary>
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

			// Setup texture information
			PixelLayout = image.PixelLayout;
			_Width = image.Width;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(image.PixelLayout, image));
		}

		#endregion

		#region Create(GraphicsContext, Image)

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
		public void Create(GraphicsContext ctx, Image image)
		{
			// Define texture technique
			Create(image);
			// Define texture
			Create(ctx);
		}

		#endregion

		#region Create(Bitmap)

		public void Create(Bitmap bitmap)
		{
			if (bitmap == null)
				throw new ArgumentNullException("bitmap");

			// Create image from bitmap
			Image image = CoreImagingImageCodecPlugin.LoadFromBitmap(bitmap, new ImageCodecCriteria());
			// Bitmaps must be flipped
			image.FlipVertically();

			// Create with Image as usual
			Create(image);
		}

		#endregion

		#region Create(GraphicsContext, Bitmap)

		public void Create(GraphicsContext ctx, Bitmap bitmap)
		{
			// Define texture technique
			Create(bitmap);
			// Define texture
			Create(ctx);
		}

		#endregion

		#region CreateFromResource(string, string)

		/// <summary>
		/// Create Texture1d data from an embedded resource.
		/// </summary>
		/// <param name="resourcePath">
		/// An <see cref="String"/> that specify the embedded resource path.
		/// </param>
		/// <param name="format">
		/// An <see cref="String"/> that specify the embedded resource image format.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="resourcePath"/> or <paramref name="format"/> is null.
		/// </exception>
		public void CreateFromResource(string resourcePath, string format)
		{
			if (resourcePath == null)
				throw new ArgumentNullException("image");
			if (format == null)
				throw new ArgumentNullException("format");

			using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath)) {
				if (resourceStream == null)
					throw new ArgumentException("no such resource", "resourcePath");
				Image resourceImage = ImageCodec.Instance.Load(resourceStream, format);

				// Setup technique for creation
				SetTechnique(new ImageTechnique(resourceImage.PixelLayout, resourceImage));

				// Setup texture information
				PixelLayout = resourceImage.PixelLayout;
				_Width = resourceImage.Width;
			}
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
		public override uint Height { get { return (1); } }

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
		public override TextureTarget TextureTarget { get { return (TextureTarget.Texture1d); } }

		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal override int SamplerType { get { return (Gl.SAMPLER_1D); } }

		/// <summary>
		/// Texture width.
		/// </summary>
		private uint _Width = 0;

		#endregion
	}
}
