
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

namespace OpenGL
{
	/// <summary>
	/// Cube texture.
	/// </summary>
	[DebuggerDisplay("TextureCube [ Pixel:{mPixelFormat} Size:{Width} ]")]
	public class TextureCube : Texture
	{
		#region Constructors
		
		#endregion

		#region Texture Creation

		/// <summary>
		/// Enuemartion defining cube texture faces.
		/// </summary>
		public enum CubeFace : int
		{
			/// <summary>
			/// Positive X-axis face.
			/// </summary>
			XPositive = 0,
			/// <summary>
			/// Negative X-axis face.
			/// </summary>s
			XNegative,
			/// <summary>
			/// Positive Y-axis face.
			/// </summary>
			YPositive,
			/// <summary>
			/// Negative Y-axis face.
			/// </summary>
			YNegative,
			/// <summary>
			/// Positive Z-axis face.
			/// </summary>
			ZPositive,
			/// <summary>
			/// Negative Z-axis face.
			/// </summary>
			ZNegative,
		}

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
			/// <param name="size">
			/// The size of the texture.
			/// </param>
			public EmptyTechnique(PixelLayout pixelFormat, uint size)
			{
				PixelLayout = pixelFormat;
				Size = size;
			}

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelLayout PixelLayout;

			/// <summary>
			/// Texture size.
			/// </summary>
			readonly uint Size;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(PixelLayout, ctx);

				// Define empty texture
				for (int i = 0; i < 6; i++) {
					Gl.TexImage2D(_CubeTargets[i], 0, internalFormat, (int)Size, (int)Size, 0, /* Unused */ PixelFormat.Rgb, /* Unused */ PixelType.UnsignedByte, null);
					GraphicsException.CheckErrors();
				}
			}
		}

		/// <summary>
		/// Technique defining a texture based on image.
		/// </summary>
		class ImageTechnique : Technique
		{
			/// <summary>
			/// Construct a ImageTechnique.
			/// </summary>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="images">
			/// The texture data.
			/// </param>
			public ImageTechnique(PixelLayout pixelFormat, Image[] images)
			{
				if (images == null)
					throw new ArgumentNullException("images");
				if (images.Length != 6)
					throw new ArgumentException("images count mismatch", "images");
				if (Array.TrueForAll(images, delegate(Image image) { return (image.Width == image.Height); }) == false)
					throw new ArgumentException("not square images", "images");
				if (Array.TrueForAll(images, delegate(Image image) { return (image.Width == images[0].Width); }) == false)
					throw new ArgumentException("images size mismatch", "images");

				PixelLayout = pixelFormat;
				Images = new Image[6];
				Array.Copy(images, Images, 6);
			}

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelLayout PixelLayout;

			/// <summary>
			/// The images that represents the texture data.
			/// </summary>
			readonly Image[] Images;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(PixelLayout, ctx);
				PixelFormat format = Pixel.GetGlFormat(PixelLayout);
				PixelType type = Pixel.GetPixelType(PixelLayout);

				for (int i = 0; i < 6; i++) {
					Image image = Images[i];

					// Set pixel transfer
					foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
						if ((image.Stride % alignment) != 0)
							continue;
						Gl.PixelStore(PixelStoreParameter.UnpackAlignment, alignment);
						GraphicsException.DebugCheckErrors();
						break;
					}

					// Upload texture contents
					Gl.TexImage2D(_CubeTargets[i], 0, internalFormat, (int)image.Width, (int)image.Height, 0, format, type, image.ImageBuffer);
					GraphicsException.CheckErrors();
				}
			}
		}

		public void Create(PixelLayout internalFormat, uint size)
		{
			// Check context compatibility
			CheckCapabilities(size, size, Depth, internalFormat);

			// Setup texture information
			mSize = size;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(internalFormat, size));
		}

		public void Create(GraphicsContext ctx, PixelLayout internalFormat, uint size)
		{
			// Check context compatibility
			CheckCapabilities(size, size, Depth, internalFormat);

			// Setup texture information
			mSize = size;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(internalFormat, size));
			// Actually create texture
			Create(ctx);
		}

		public void Create(PixelLayout internalFormat, Image[] images)
		{
			if (images == null)
				throw new ArgumentNullException("images");
			if (images[0] == null)
				throw new ArgumentException("no image", "images");

			// Trust about size (full checks will be done in SetTechnique)
			uint size = images[0].Width;

			// Check context compatibility
			CheckCapabilities(size, size, Depth, internalFormat);

			// Setup texture information
			mSize = size;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(internalFormat, images));
		}

		public void Create(GraphicsContext ctx, PixelLayout internalFormat, Image[] images)
		{
			if (images == null)
				throw new ArgumentNullException("images");
			if (images[0] == null)
				throw new ArgumentException("no image", "images");

			// Trust about size (full checks will be done in SetTechnique)
			uint size = images[0].Width;

			// Check context compatibility
			CheckCapabilities(size, size, Depth, internalFormat);

			// Setup texture information
			mSize = size;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(internalFormat, images));
			// Actually create texture
			Create(ctx);
		}

		public static TextureTarget GetTextureCubeTarget(CubeFace cubeFace)
		{
			if ((int)cubeFace < 0 || (int)cubeFace >= _CubeTargets.Length)
				throw new ArgumentOutOfRangeException("cubeFace");
			return (_CubeTargets[(int)cubeFace]);
		}

		/// <summary>
		/// TextureCube target ordering.
		/// </summary>
		/// <remarks>
		/// It must following <see cref="CubeFace"/>.
		/// </remarks>
		private static readonly TextureTarget[] _CubeTargets = new TextureTarget[] {
			TextureTarget.TextureCubeMapPositiveX,
			TextureTarget.TextureCubeMapNegativeX,
			TextureTarget.TextureCubeMapPositiveY,
			TextureTarget.TextureCubeMapNegativeY,
			TextureTarget.TextureCubeMapPositiveZ,
			TextureTarget.TextureCubeMapNegativeZ
		};

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Texture width.
		/// </summary>
		public override uint Width { get { return (mSize); } }

		/// <summary>
		/// Texture height.
		/// </summary>
		public override uint Height { get { return (mSize); } }

		/// <summary>
		/// Texture depth.
		/// </summary>
		/// <remarks>
		/// Only Texture3d target has a depth. For every else texture target, it is set to 1.
		/// </remarks>
		public override uint Depth { get { return (1); } }

		/// <summary>
		/// Texture size (cube map textures have equal width and height).
		/// </summary>
		public uint Size { get { return (mSize); } }

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return (TextureTarget.TextureCubeMap); } }

		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal override int SamplerType { get { return (Gl.SAMPLER_CUBE); } }

		/// <summary>
		/// Texture size (width and height are the same).
		/// </summary>
		private uint mSize;

		#endregion
	}
}
