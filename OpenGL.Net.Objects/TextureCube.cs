
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Cube texture.
	/// </summary>
	public class TextureCube : Texture
	{
		#region Cube Targets

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

		internal static TextureTarget GetTextureCubeTarget(CubeFace cubeFace)
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
			/// The <see cref="TextureCube"/> affected by this Technique.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="size">
			/// The size of the texture.
			/// </param>
			public EmptyTechnique(TextureCube texture, PixelLayout pixelFormat, uint size) :
				base(texture)
			{
				_TextureCube = texture;
				_PixelFormat = pixelFormat;
				_Size = size;
			}

			/// <summary>
			/// The <see cref="TextureCube"/> affected by this Technique.
			/// </summary>
			private readonly TextureCube _TextureCube;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout _PixelFormat;

			/// <summary>
			/// Texture size.
			/// </summary>
			private readonly uint _Size;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = _PixelFormat.GetGlInternalFormat();

				// Define empty texture
				for (int i = 0; i < 6; i++)
					Gl.TexImage2D(_CubeTargets[i], 0, internalFormat, (int)_Size, (int)_Size, 0, /* Unused */ PixelFormat.Rgb, /* Unused */ PixelType.UnsignedByte, null);
				// Define texture properties
				_TextureCube.SetMipmap(_PixelFormat, _Size, _Size, 1, 0);
			}
		}

		#region Create(uint, PixelLayout)

		public void Create(uint size, PixelLayout internalFormat)
		{
			// Setup technique for creation
			SetTechnique(new EmptyTechnique(this, internalFormat, size));
		}

		#endregion

		#region Create(GraphicsContext, uint, PixelLayout)

		public void Create(GraphicsContext ctx, uint size, PixelLayout internalFormat)
		{
			// Setup technique for creation
			SetTechnique(new EmptyTechnique(this, internalFormat, size));
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
			/// <param name="texture">
			/// The <see cref="TextureCube"/> affected by this Technique.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="images">
			/// The texture data.
			/// </param>
			public ImageTechnique(TextureCube texture, PixelLayout pixelFormat, Image[] images) :
				base(texture)
			{
				if (images == null)
					throw new ArgumentNullException("images");
				if (images.Length != 6)
					throw new ArgumentException("images count mismatch", "images");
				if (Array.TrueForAll(images, delegate(Image image) { return (image.Width == image.Height); }) == false)
					throw new ArgumentException("not square images", "images");
				if (Array.TrueForAll(images, delegate(Image image) { return (image.Width == images[0].Width); }) == false)
					throw new ArgumentException("images size mismatch", "images");

				_TextureCube = texture;
				_PixelFormat = pixelFormat;
				_Images = new Image[6];
				Array.Copy(images, _Images, 6);
			}

			/// <summary>
			/// The <see cref="TextureCube"/> affected by this Technique.
			/// </summary>
			private readonly TextureCube _TextureCube;

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
				int internalFormat = _PixelFormat.GetGlInternalFormat();
				PixelFormat format = _PixelFormat.GetGlFormat();
				PixelType type = _PixelFormat.GetPixelType();

				for (int i = 0; i < 6; i++) {
					Image image = _Images[i];

					// Set pixel alignment
					State.PixelAlignmentState.Unpack(image.Stride).ApplyState(ctx, null);

					// Upload texture contents
					Gl.TexImage2D(_CubeTargets[i], 0, internalFormat, (int)image.Width, (int)image.Height, 0, format, type, image.ImageBuffer);
				}

				// Define texture properties
				_TextureCube.SetMipmap(_PixelFormat, _Images[0].Width, _Images[0].Height, 1, 0);
			}
		}

		#region Create(PixelLayout, Image[])

		public void Create(PixelLayout internalFormat, Image[] images)
		{
			// Setup technique for creation
			SetTechnique(new ImageTechnique(this, internalFormat, images));
		}

		#endregion

		#region Create(GraphicsContext, PixelLayout, Image[])

		public void Create(GraphicsContext ctx, PixelLayout internalFormat, Image[] images)
		{
			// Setup technique for creation
			SetTechnique(new ImageTechnique(this, internalFormat, images));
			// Actually create texture
			Create(ctx);
		}

		#endregion

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Texture size, in pixels, of the level 0 of the texture.
		/// </summary>
		public override Vertex3ui BaseSize
		{
			get
			{
				Vertex3ui baseSize = base.BaseSize;

				baseSize.z = 1;

				return (baseSize);
			}
		}

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

		#endregion
	}
}
