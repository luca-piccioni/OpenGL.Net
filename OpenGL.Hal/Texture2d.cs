
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
using System.Threading;
using System.Threading.Tasks;

namespace OpenGL
{
	/// <summary>
	/// Two dimensional texture.
	/// </summary>
	[DebuggerDisplay("Texture2d: Width={Width} Height={Height}")]
	public class Texture2d : Texture
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
		public Texture2d(uint width, uint height, PixelLayout format)
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
		public Texture2d(GraphicsContext ctx, uint width, uint height, PixelLayout format)
		{
			Create(ctx, width, height, format);
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
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
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
			public EmptyTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, uint width, uint height) :
				base(texture)
			{
				_Texture2d = texture;
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Width = width;
				_Height = height;
			}

			/// <summary>
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </summary>
			private readonly Texture2d _Texture2d;

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
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(_PixelFormat, ctx);
				PixelFormat format = Pixel.GetGlFormat(_PixelFormat);

				// Define empty texture
				Gl.TexImage2D(_Target, (int)_Level, internalFormat, (int)_Width, (int)_Height, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				// Define texture properties
				_Texture2d.PixelLayout = _PixelFormat;
				_Texture2d._Width = _Width;
				_Texture2d._Height = _Height;
			}
		}

		#region Create(uint, uint, PixelLayout)

		/// <summary>
		/// Create a Texture2d, defining the texture extents and the internal format.
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
		public void Create(uint width, uint height, PixelLayout format)
		{
			// Set creation technique
			SetTechnique(new EmptyTechnique(this, TextureTarget, 0, format, width, height));
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
		public void Create(GraphicsContext ctx, uint width, uint height, PixelLayout format)
		{
			CheckCurrentContext(ctx);

			// Define technique
			Create(width, height, format);
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
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="image">
			/// The width of the texture.
			/// </param>
			public ImageTechnique(Texture2d texture, TextureTarget target, PixelLayout pixelFormat, Image image) :
				this(texture, target, 0, pixelFormat, image)
			{

			}

			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="image">
			/// The width of the texture.
			/// </param>
			public ImageTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, Image image) :
				base(texture)
			{
				if (image == null)
					throw new ArgumentNullException("image");

				_Texture2d = texture;
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Image = image;
				_Image.IncRef();		// Referenced
			}

			/// <summary>
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </summary>
			private readonly Texture2d _Texture2d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			private readonly TextureTarget _Target;

			/// <summary>
			/// The specific level of the target to define. Defaults to zero.
			/// </summary>
			public readonly uint _Level;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			private readonly PixelLayout _PixelFormat;

			/// <summary>
			/// The image that represents the texture data.
			/// </summary>
			private readonly Image _Image;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				int internalFormat = Pixel.GetGlInternalFormat(_PixelFormat, ctx);
				PixelFormat format = Pixel.GetGlFormat(_Image.PixelLayout);
				PixelType type = Pixel.GetPixelType(_Image.PixelLayout);

				// Set pixel transfer
				foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
					if ((_Image.Stride % alignment) != 0)
						continue;
					Gl.PixelStore(PixelStoreParameter.UnpackAlignment, alignment);
					break;
				}

				// Upload texture contents
				Gl.TexImage2D(_Target, (int)_Level, internalFormat, (int)_Image.Width, (int)_Image.Height, 0, format, type, _Image.ImageBuffer);
				// Define texture properties
				_Texture2d.PixelLayout = _PixelFormat;
				_Texture2d._Width = _Image.Width;
				_Texture2d._Height = _Image.Height;
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Image != null)
					_Image.DecRef();
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

			// Setup technique for creation
			SetTechnique(new ImageTechnique(this, TextureTarget, image.PixelLayout, image));
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

		#endregion

		#region Load

		#region LoadAsync(string)

		/// <summary>
		/// Load asynchronously from a file.
		/// </summary>
		/// <param name="path">
		/// A <see cref="String"/> that specify the path of the image to load.
		/// </param>
		public void LoadAsync(string path)
		{
			if (path == null)
				throw new ArgumentNullException("path");

			CancelLoadAsync();

			_LoadTaskCancel = new CancellationTokenSource();
			_LoadTask = new Task(new Action(delegate () {
				// Define texture using image
				Create(ImageCodec.Instance.Load(path));

				// No more cancellable
				_LoadTaskCancel.Dispose();
				_LoadTaskCancel = null;
				// Dispose resources
				_LoadTask = null;
			}), _LoadTaskCancel.Token, TaskCreationOptions.LongRunning | TaskCreationOptions.PreferFairness);
			// Execute load
			_LoadTask.Start();
		}

		/// <summary>
		/// Cancel a <see cref="LoadAsync"/> execution.
		/// </summary>
		public void CancelLoadAsync()
		{
			if (_LoadTaskCancel != null) {
				_LoadTaskCancel.Cancel();
				_LoadTaskCancel.Dispose();
				_LoadTaskCancel = null;
			}

			_LoadTask = null;
		}

		#endregion

		/// <summary>
		/// Current load task.
		/// </summary>
		private Task _LoadTask;

		/// <summary>
		/// Cancellation token used for cancelling <see cref="_LoadTask"/>.
		/// </summary>
		private CancellationTokenSource _LoadTaskCancel;

		#endregion

		#region Texture Download

		/// <summary>
		/// Download Texture2D data to an Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for downloading texture data.
		/// </param>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/> determining the pixel format of the downloaded data.
		/// </param>
		/// <returns>
		/// </returns>
		public Image Get(GraphicsContext ctx, PixelLayout pType)
		{
			return (Get(ctx, pType, TextureTarget)[0]);
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
		public override uint Depth { get { return (1); } }

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return (TextureTarget.Texture2d); } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get {
				if (Pixel.IsGlIntegerPixel(PixelLayout)) {
					if (Pixel.IsGlSignedIntegerPixel(PixelLayout))
						return (Gl.INT_SAMPLER_2D);
					if (Pixel.IsGlUnsignedIntegerPixel(PixelLayout))
						return (Gl.UNSIGNED_INT_SAMPLER_2D);

					throw new NotSupportedException(String.Format("integer pixel format {0} not correctly supported", PixelLayout));
				} else
					return (Gl.SAMPLER_2D);
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

		#endregion
	}
}
