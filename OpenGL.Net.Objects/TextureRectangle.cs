
// Copyright (C) 2010-2016 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Two dimensional texture using rectangle coordinates.
	/// </summary>
	[DebuggerDisplay("TextureRectangle: Width={Width} Height={Height} Format={PixelLayout}")]
	public class TextureRectangle : Texture2d
	{
		#region Constructors

		/// <summary>
		/// Construct an undefined TextureRectangle.
		/// </summary>
		/// <remarks>
		/// <para>
		/// It creates Texture object which has not defined extents, internal format and textels. To define this texture, call one
		/// of <see cref="Texture2d.Create"/> or <see cref="Texture2d.CreateLazy"/> methods (except <see cref="Texture2d.Create(GraphicsContext)"/>).
		/// </para>
		/// </remarks>
		public TextureRectangle()
		{

		}

		/// <summary>
		/// Create TextureRectangle data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
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
		/// Exception thrown if <paramref name="ctx"/> is null and no context is current to the calling thread.
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
		public TextureRectangle(uint width, uint height, PixelLayout format) : base(width, height, format)
		{
			
		}

		/// <summary>
		/// Create TextureRectangle data, defining only the extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture. If it null, the current context
		/// will be used.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
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
		public TextureRectangle(GraphicsContext ctx, uint width, uint height, PixelLayout format) : base(ctx, width, height, format)
		{
			
		}

		#endregion

		#region Texture2d Overrides

		/// <summary>
		/// Texture mapmaps level count (including the base level).
		/// </summary>
		/// <remarks>
		/// <para>
		/// If this texture is not defined, this property shall return 0.
		/// </para>
		/// <para>
		/// If texture target doesn't support mipmapping, this property shall return 1, if it is defined.
		/// </para>
		/// </remarks>
		protected override uint MipmapLevels { get { return (1); } }

		/// <summary>
		/// Generate mipmaps for this Texture.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for generating texture mipmaps.
		/// </param>
		public override void GenerateMipmaps(GraphicsContext ctx)
		{
			throw new InvalidOperationException("TextureRectangle doesn't support mipmapping");
		}

		/// <summary>
		/// Generate mipmaps for this Texture.
		/// </summary>
		/// <remarks>
		/// The mipmaps are generated when executing <see cref="CreateName(GraphicsContext)"/>.
		/// </remarks>
		public override void GenerateMipmaps()
		{
			throw new InvalidOperationException("TextureRectangle doesn't support mipmapping");
		}

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return (TextureTarget.TextureRectangle); } }


		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal override int SamplerType
		{
			get
			{
				if (PixelLayout.IsGlIntegerPixel()) {
					if (PixelLayout.IsGlSignedIntegerPixel())
						return (Gl.INT_SAMPLER_2D_RECT);
					if (PixelLayout.IsGlUnsignedIntegerPixel())
						return (Gl.UNSIGNED_INT_SAMPLER_2D_RECT);

					throw new NotSupportedException(String.Format("integer pixel format {0} not supported", PixelLayout));
				} else
					return (Gl.SAMPLER_2D_RECT);
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

			if (!ctx.Extensions.TextureRectangle_ARB && !ctx.Extensions.TextureRectangle_NV)
				throw new NotSupportedException("GL_ARB|NV_texture_rectangle not supported");

			// Base implementation
			base.Create(ctx);
		}

		#endregion
	}
}
