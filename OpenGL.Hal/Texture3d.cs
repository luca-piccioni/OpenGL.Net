
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
using System.Diagnostics;

namespace OpenGL
{
	/// <summary>
	/// Three dimensional texture.
	/// </summary>
	[DebuggerDisplay("Texture3d [ Pixel:{mPixelFormat} Width:{Width} Height:{Height} Depth:{Depth} ]")]
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
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specifies the texture depth.
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
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specifies the texture depth.
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
			public EmptyTechnique(TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint depth)
			{
				Target = target;
				PixelLayout = pixelFormat;
				Width = width;
				Height = height;
				Depth = depth;
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			readonly PixelLayout PixelLayout;

			/// <summary>
			/// Texture width.
			/// </summary>
			readonly uint Width;

			/// <summary>
			/// Texture height.
			/// </summary>
			readonly uint Height;

			/// <summary>
			/// Texture depth.
			/// </summary>
			readonly uint Depth;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = Pixel.GetGlFormat(PixelLayout);
				int internalFormat = Pixel.GetGlInternalFormat(PixelLayout, ctx);

				// Define empty texture
				Gl.TexImage3D(Target, 0, internalFormat, (int)Width, (int)Height, (int)Depth, 0, format, /* Unused */ PixelType.UnsignedByte, null);
				GraphicsException.CheckErrors();
			}
		}

		/// <summary>
		/// Technique defining a texture based on images.
		/// </summary>
		class ImageTechnique : Technique
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
			/// <param name="images">
			/// The image set of the texture.
			/// </param>
			public ImageTechnique(TextureTarget target, PixelLayout pixelFormat, Image[] images)
			{
				if (images == null)
					throw new ArgumentNullException("images");
				if (images.Length == 0)
					throw new ArgumentException("no images", "images");
				if (!Array.TrueForAll(images, delegate(Image item) { return (item != null); }))
					throw new ArgumentException("null item in image set", "images");
				if (!Array.TrueForAll(images, delegate(Image item) { return (item.Width == images[0].Width && item.Height == images[0].Height); }))
					throw new ArgumentException("eterogeneous size in image set", "images");

				Target = target;
				PixelLayout = pixelFormat;
				Images = images;
				Array.ForEach(Images, delegate(Image image) { image.IncRef(); });	// Referenced
			}

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget Target;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout PixelLayout;

			/// <summary>
			/// The images that represents the texture data.
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
				int internalFormat = Pixel.GetGlInternalFormat(PixelLayout, ctx);
				uint width = Images[0].Width, height = Images[0].Height;

				Gl.TexImage3D(Target, 0, internalFormat, (int)width, (int)height, Images.Length, 0, /* Unused */ OpenGL.PixelFormat.Red, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				GraphicsException.CheckErrors();

				for (int i = 0; i < Images.Length; i++) {
					Image image = Images[i];

					PixelFormat format = Pixel.GetGlFormat(image.PixelLayout);
					PixelType type = Pixel.GetPixelType(image.PixelLayout);

					// Set pixel transfer
					foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
						if ((image.Stride % alignment) != 0)
							continue;
						Gl.PixelStore(PixelStoreParameter.UnpackAlignment, alignment);
						GraphicsException.DebugCheckErrors();
						break;
					}

					// Upload texture contents
					Gl.TexSubImage3D(Target, 0, 0, 0, i, (int)width, (int)height, 1, format, type, image.ImageBuffer);
					GraphicsException.CheckErrors();
				}
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				Array.ForEach(Images, delegate(Image image) { image.DecRef(); });
			}
		}

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specifies the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specifies the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specifies the texture depth.
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
			// Setup texture information
			PixelLayout = format;
			_Width = width;
			_Height = height;
			_Depth = depth;

			// Setup technique for creation
			SetTechnique(new EmptyTechnique(TextureTarget, format, width, height, depth));
		}

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
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
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specifies the texture depth.
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

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="images">
		/// An array of <see cref="Image"/> that specifies the texture data.
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

			uint width = images[0].Width, height = images[0].Height;

			// Setup texture information
			PixelLayout = format;
			_Width = width;
			_Height = height;
			_Depth = (uint)images.Length;

			// Setup technique for creation
			SetTechnique(new ImageTechnique(TextureTarget, format, images));
		}

		/// <summary>
		/// Create a Texture3d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this Texture.
		/// </param>
		/// <param name="images">
		/// An array of <see cref="Image"/> that specifies the texture data.
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
		public override uint Depth { get { return (_Depth); } }

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
		internal override int SamplerType { get { return (Gl.SAMPLER_3D); } }

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
		private uint _Depth;

		#endregion
	}
}
