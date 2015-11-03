
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

namespace OpenGL
{
	/// <summary>
	/// One dimensional texture.
	/// </summary>
	public class Texture1d : Texture
	{
		#region Constructors

		
		#endregion

		#region Texture 1D Data Management

		/// <summary>
		/// Upload Texture1D data from an Image instance, allocating it immediately using a GraphicsContext.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for uploading texture data.
		/// </param>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <remarks>
		/// 
		/// </remarks>
		public void Set(GraphicsContext ctx, Image image)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent() == false)
				throw new ArgumentException("ctx.IsCurrent() == false");
			if (image == null)
				throw new ArgumentNullException("image");
			if ((image.Width == 0) || (image.Height == 0))
				throw new ArgumentException("image.Width == 0 || image.Height == 0");
			if (image.Height != 1)
				throw new ArgumentException("image.Height != 1");

			// Reference pixel data
			mTextureData = image;
			// Derive texture pixel format from 'image' if it is not defined yet
			if (PixelFormat != PixelFormat.None) {
				// Check whether texture pixel format is compatible with the image pixel format
				if (Pixel.IsSupportedSetDataFormat(image.PixelFormat, PixelFormat, ctx) == false)
					throw new InvalidOperationException(String.Format("textel format {0} incompatible with data pixel format {1}", image.PixelFormat, PixelFormat));
			} else {
				// Check whether texture pixel format is compatible with the image pixel format
				if (Pixel.IsSupportedDataFormat(image.PixelFormat, ctx) == false)
					throw new InvalidOperationException(String.Format("not supported data pixel format {1}", image.PixelFormat));
				PixelFormat = image.PixelFormat;
			}
			// Texture extents
			mWidth  = image.Width;

			// Upload texture data
			Set(ctx);
		}

		/// <summary>
		/// Upload Texture1D data.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for uploading texture data.
		/// </param>
		private void Set(GraphicsContext ctx)
		{
			// Create texture if necessary
			Create(ctx);

			// Bind this Texture
			Bind(ctx);
			// Upload texture data
			int internalFormat = Pixel.GetGlInternalFormat(PixelFormat, ctx);
			int type = Pixel.GetGlDataFormat(mTextureData.PixelFormat);
			int format = Pixel.GetGlFormat(mTextureData.PixelFormat);

			// Set pixel transfer
			foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
				if (mTextureData.Stride % alignment == 0) {
					Gl.PixelStore(Gl.UNPACK_ALIGNMENT, alignment);
					GraphicsException.DebugCheckErrors();
					break;
				}
			}

			// Upload texture contents
			Gl.TexImage1D(Gl.TEXTURE_1D, 0, internalFormat, (int)Width, 0, format, type, mTextureData.ImageBuffer);
			GraphicsException.DebugCheckErrors();
			// Unbind this texture
			Unbind(ctx);

			// Data no more required
			mTextureData = null;
		}

		/// <summary>
		/// Pixel data.
		/// </summary>
		private Image mTextureData = null;

		#endregion

		#region Texture Overrides

		/// <summary>
		/// Texture width.
		/// </summary>
		public override uint Width { get { return (mWidth); } }

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
		public override int TextureTarget { get { return (Gl.TEXTURE_1D); } }

		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal override int SamplerType { get { return (Gl.SAMPLER_1D); } }

		/// <summary>
		/// Texture width.
		/// </summary>
		private uint mWidth = 0;

		#endregion
	}
}
