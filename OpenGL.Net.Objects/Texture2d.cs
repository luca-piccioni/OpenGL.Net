
// Copyright (C) 2009-2017 Luca Piccioni
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
using System.Diagnostics;
using System.Drawing;
using System.Threading;
#if NET45
using System.Threading.Tasks;
#endif

namespace OpenGL.Objects
{
	/// <summary>
	/// Two dimensional texture.
	/// </summary>
	[DebuggerDisplay("Texture2d: Name={ObjectName} Width={Width} Height={Height} Format={PixelLayout}")]
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
		private class EmptyTechnique : Technique
		{
			#region Constructors

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
			/// The specific level of the target to be defined.
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
			public EmptyTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, uint width, uint height)
			{
				_Texture2d = texture;
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Width = width;
				_Height = height;
			}

			#endregion

			#region Technique Overrides

			/// <summary>
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </summary>
			protected readonly Texture2d _Texture2d;

			/// <summary>
			/// The texture target to use for creating the empty texture.
			/// </summary>
			protected readonly TextureTarget _Target;

			/// <summary>
			/// The specific level of the target to define. Defaults to zero.
			/// </summary>
			protected readonly uint _Level;

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
				Gl.TexImage2D(_Target, (int)_Level, internalFormat, (int)_Width, (int)_Height, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				// Define texture properties
				_Texture2d.SetMipmap(_PixelFormat, _Width, _Height, 1, _Level);
			}

			#endregion
		}

		/// <summary>
		/// Technique defining an immutable empty texture.
		/// </summary>
		private class ImmutableEmptyTechnique : EmptyTechnique
		{
			#region Constructors

			/// <summary>
			/// Construct a ImmutableEmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
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
			public ImmutableEmptyTechnique(Texture2d texture, TextureTarget target, PixelLayout pixelFormat, uint width, uint height) :
				this(texture, target, pixelFormat, width, height, GetMipmapCompleteLevels(width, height, 1, 0))
			{

			}

			/// <summary>
			/// Construct a ImmutableEmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
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
			/// <param name="levels">
			/// A <see cref="UInt32"/> that specify the number of levels defining the texture.
			/// </param>
			public ImmutableEmptyTechnique(Texture2d texture, TextureTarget target, PixelLayout pixelFormat, uint width, uint height, uint levels) :
				base(texture, target, 0, pixelFormat, width, height)
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
			private readonly uint _MipmapLevels;

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
						Gl.TexImage2D(_Target, (int)level, internalFormat, (int)w, (int)h, 0, format, /* Unused */ PixelType.UnsignedByte, IntPtr.Zero);
				} else {
					SizedInternalFormat internalFormat = _PixelFormat.ToSizedInternalFormat();
					
					Gl.TexStorage2D(_Target, (int)_MipmapLevels, internalFormat, (int)_Width, (int)_Height);
				}

				// Define mipmap array
				for (uint level = 0, w = _Width, h = _Height; level < _MipmapLevels; level++, w = Math.Max(1, w / 2), h = Math.Max(1, h / 2))
					_Texture2d.SetMipmap(_PixelFormat, w, h, 1, level);
			}

			#endregion
		}

		#region Create(width, height, pixelformat)

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
			Technique technique;

			if (Immutable)
				technique = new ImmutableEmptyTechnique(this, TextureTarget, format, width, height);
			else
				technique = new EmptyTechnique(this, TextureTarget, 0, format, width, height);

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

		#region Create(width, height, level, pixelformat)

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
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level to create/update.
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
		public void Create(uint width, uint height, uint level, PixelLayout format)
		{
			if (Immutable)
				throw new InvalidOperationException("immutable texture");

			SetTechnique(new EmptyTechnique(this, TextureTarget, level, format, width, height));
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
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level to create/update.
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
		public void Create(GraphicsContext ctx, uint width, uint height, uint level, PixelLayout format)
		{
			CheckCurrentContext(ctx);

			// Define technique
			Create(width, height, level, format);
			// Actually create texture
			Create(ctx);
		}

		#endregion

		#region Create(width, height, pixelformat, levels)

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
		public void Create(uint width, uint height, PixelLayout format, uint levels)
		{
			Technique technique;

			if (Immutable)
				technique = new ImmutableEmptyTechnique(this, TextureTarget, format, width, height, levels);
			else
				technique = new EmptyTechnique(this, TextureTarget, 0, format, width, height);

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
		public void Create(GraphicsContext ctx, uint width, uint height, PixelLayout format, uint levels)
		{
			CheckCurrentContext(ctx);

			// Define technique
			Create(width, height, format, levels);
			// Actually create texture
			Create(ctx);
		}

		#endregion

		/// <summary>
		/// Technique defining a texture based on memory pointer.
		/// </summary>
		private class UnmanagedTechnique : Technique
		{
			#region Constructors

			/// <summary>
			/// Construct a UnmanagedTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="unmanagedPtr">
			/// The <see cref="IntPtr"/> holding the texture data.
			/// </param>
			/// <param name="lineStride">
			/// The line stride of the data pointed by <paramref name="unmanagedPtr"/>.
			/// </param>
			public UnmanagedTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride)
			{
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_UnmanagedPtr = unmanagedPtr;
				_Width = width;
				_Height = height;
				_LineStride = lineStride;
			}

			#endregion

			#region Technique Overrides

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
			/// The image that represents the texture data.
			/// </summary>
			private readonly IntPtr _UnmanagedPtr;

			/// <summary>
			/// The unmanaged image width, in pixels.
			/// </summary>
			private readonly uint _Width;

			/// <summary>
			/// The unmanaged image height, in pixels.
			/// </summary>
			private readonly uint _Height;

			/// <summary>
			/// The unmanaged image line stride.
			/// </summary>
			private readonly uint _LineStride;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = _PixelFormat.ToDataFormat();
				PixelType type = _PixelFormat.ToPixelType();

				// Set pixel unpack
				new State.PixelUnpackState(_PixelFormat, _LineStride).Apply(ctx, null);
				// Upload texture contents
				Gl.TexSubImage2D(_Target, (int)_Level, 0, 0, (int)_Width, (int)_Height, format, type, _UnmanagedPtr);
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				// Nothing to do
			}

			#endregion
		}

		#region Create(PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level)

		public void Create(PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level = 0)
		{
			// Define storage, the uploads image
			Create(width, height, pixelFormat);
			SetTechnique(new UnmanagedTechnique(this, TextureTarget, level, pixelFormat, unmanagedPtr, width, height, lineStride));
		}

		public void Create(GraphicsContext ctx, PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level = 0)
		{
			// Define texture technique
			Create(pixelFormat, unmanagedPtr, width, height, lineStride, level);
			// Define texture
			Create(ctx);
		}

		#endregion

		/// <summary>
		/// Technique defining a texture based on arrays.
		/// </summary>
		private class ArrayTechnique : Technique
		{
			/// <summary>
			/// Construct a ArrayTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="array">
			/// The <see cref="Array"/> that holds the texture data.
			/// </param>
			public ArrayTechnique(Texture2d texture, uint level, PixelLayout pixelFormat, Array array, uint width, uint height)
			{
				if (texture == null)
					throw new ArgumentNullException(nameof(texture));
				if (array == null)
					throw new ArgumentNullException(nameof(array));
				if (array.Rank > 1)
					throw new ArgumentException("multi-dimensional array greater than 1", nameof(array));

				_Texture = texture;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Array = array;
				_Width = width;
				_Height = height;
			}

			/// <summary>
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </summary>
			protected readonly Texture2d _Texture;

			/// <summary>
			/// The specific level of the target to define. Defaults to zero.
			/// </summary>
			protected readonly uint _Level;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			protected readonly PixelLayout _PixelFormat;

			/// <summary>
			/// The array that represents the texture data.
			/// </summary>
			protected readonly Array _Array;

			/// <summary>
			/// The width of the image specified by <see cref="_Array"/>, in pixels.
			/// </summary>
			protected readonly uint _Width;

			/// <summary>
			/// The height of the image specified by <see cref="_Array"/>, in pixels.
			/// </summary>
			protected readonly uint _Height;

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
				PixelType type = _PixelFormat.ToPixelType();

				// Set pixel unpack
				new State.PixelUnpackState(_PixelFormat, _Width * _PixelFormat.GetBytesCount()).Apply(ctx, null);
				// Upload texture contents (defining storage)
				Gl.TexImage2D(_Texture.TextureTarget, (int)_Level, internalFormat, (int)_Width, (int)_Height, 0, format, type, _Array);
				// Define texture properties
				_Texture.SetMipmap(_PixelFormat, _Width, _Height, 1, _Level);
			}
		}

		#region Create(Array, width, height, pixelFormat)

		/// <summary>
		/// Create a Texture2d, defining the texture extents and the internal format.
		/// </summary>
		/// <param name="array">
		/// The managed array holding the texture data.
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
		public void Create(Array array, uint width, uint height, PixelLayout format)
		{
			SetTechnique(new ArrayTechnique(this, 0, format, array, width, height));
		}

		#endregion

		/// <summary>
		/// Technique defining a texture based on image.
		/// </summary>
		class ImageTechnique : Technique
		{
			#region Constructors

			/// <summary>
			/// Construct a EmptyTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="target">
			/// A <see cref="TextureTarget"/> that specify the texture target.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="image">
			/// The <see cref="Image"/> holding the texture data.
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
			/// The <see cref="Image"/> holding the texture data.
			/// </param>
			public ImageTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, Image image)
			{
				if (image == null)
					throw new ArgumentNullException(nameof(image));

				_Texture2d = texture;
				_Target = target;
				_Level = level;
				_PixelFormat = pixelFormat;
				_Image = image;
				_Image.IncRef();		// Referenced
			}

            #endregion

            #region Technique Overrides

            /// <summary>
            /// The <see cref="Texture2d"/> affected by this Technique.
            /// </summary>
            protected readonly Texture2d _Texture2d;

            /// <summary>
            /// The texture target to use for creating the empty texture.
            /// </summary>
            protected readonly TextureTarget _Target;

            /// <summary>
            /// The specific level of the target to define. Defaults to zero.
            /// </summary>
            protected readonly uint _Level;

			/// <summary>
			/// The internal pixel format of textel.
			/// </summary>
			protected readonly PixelLayout _PixelFormat;

            /// <summary>
            /// The image that represents the texture data.
            /// </summary>
            protected readonly Image _Image;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				InternalFormat internalFormat = _Image.PixelLayout.ToInternalFormat();
				PixelFormat format = _Image.PixelLayout.ToDataFormat();
				PixelType type = _Image.PixelLayout.ToPixelType();

				// Set pixel unpack
				new State.PixelUnpackState(_PixelFormat, _Image.Stride).Apply(ctx, null);
				// Upload texture contents
				Gl.TexImage2D(_Target, (int)_Level, internalFormat, (int)_Image.Width, (int)_Image.Height, 0, format, type, _Image.ImageBuffer);
				// Update mipmap metadata
				_Texture2d.SetMipmap(_Image.PixelLayout, _Image.Width, _Image.Height, 0, _Level);
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Image != null)
					_Image.DecRef();
			}

			#endregion
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
				throw new ArgumentNullException(nameof(image));

			// Define storage, the uploads image
			Create(image.Width, image.Height, image.PixelLayout);
			Update(image, 0);
		}

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

#if !MONODROID

		#region Create(Bitmap)

		public void Create(Bitmap bitmap)
		{
			if (bitmap == null)
				throw new ArgumentNullException(nameof(bitmap));

			// Create image from bitmap
			Image image = CoreImagingImageCodecPlugin.LoadFromBitmap(bitmap, new ImageCodecCriteria());
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

#endif

		#region Create(Image, Level)

		/// <summary>
		/// Create Texture2d data from a Image instance.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level to create/update.
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
		public void Create(Image image, uint level)
		{
			if (image == null)
				throw new ArgumentNullException(nameof(image));

			// Setup technique for creation
			SetTechnique(new ImageTechnique(this, TextureTarget, level, image.PixelLayout, image));
		}

		#endregion

		#endregion

		#region Load

#if NET45

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
				throw new ArgumentNullException(nameof(path));

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

#endif

		#endregion

		#region Update

		/// <summary>
		/// Technique updating a texture based on arrays.
		/// </summary>
		private class ArrayUpdateTechnique : ArrayTechnique
		{
			/// <summary>
			/// Construct a ArrayTechnique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture2d"/> affected by this Technique.
			/// </param>
			/// <param name="level">
			/// The specific level of the target to define. Defaults to zero.
			/// </param>
			/// <param name="pixelFormat">
			/// The texture pixel format.
			/// </param>
			/// <param name="array">
			/// The <see cref="Array"/> that holds the texture data.
			/// </param>
			public ArrayUpdateTechnique(Texture2d texture, uint level, PixelLayout pixelFormat, Array array, uint width, uint height, uint xOffset, uint yOffset) :
				base(texture, level, pixelFormat, array, width, height)
			{
				_OffsetX = xOffset;
				_OffsetY = yOffset;
			}

			/// <summary>
			/// Specifies a texel offset in the x direction within the texture array.
			/// </summary>
			private readonly uint _OffsetX;

			/// <summary>
			/// Specifies a texel offset in the y direction within the texture array.
			/// </summary>
			private readonly uint _OffsetY;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = _PixelFormat.ToDataFormat();
				PixelType type = _PixelFormat.ToPixelType();

				// Set pixel unpack
				new State.PixelUnpackState(_PixelFormat, _Width * _PixelFormat.GetBytesCount()).Apply(ctx, null);
				
				// Upload texture contents (storage must be defined previously)
				Gl.TexSubImage2D(_Texture.TextureTarget, (int) _Level, (int)_OffsetX, (int)_OffsetY, (int)_Width, (int)_Height, format, type, _Array);
			}
		}

		#region Update(Array, width, height, pixelFormat, xOffset, yOffset)

		/// <summary>
		/// Update a Texture2d.
		/// </summary>
		/// <param name="array">
		/// The managed array holding the texture data.
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
		public void Update(Array array, uint width, uint height, PixelLayout format, uint xOffset = 0, uint yOffset = 0)
		{
			SetTechnique(new ArrayUpdateTechnique(this, 0, format, array, width, height, xOffset, yOffset));
		}

		#endregion

		/// <summary>
		/// Technique updating a texture based on image.
		/// </summary>
		private class ImageUpdateTechnique : ImageTechnique
		{
			#region Constructors

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
			/// The <see cref="Image"/> holding the texture data.
			/// </param>
			public ImageUpdateTechnique(Texture2d texture, TextureTarget target, PixelLayout pixelFormat, Image image) :
				base(texture, target, 0, pixelFormat, image)
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
            /// The <see cref="Image"/> holding the texture data.
            /// </param>
            public ImageUpdateTechnique(Texture2d texture, TextureTarget target, uint level, PixelLayout pixelFormat, Image image) :
                base(texture, target, level, pixelFormat, image)
            {
                
            }

			#endregion

			#region Technique Overrides

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public override void Create(GraphicsContext ctx)
			{
				PixelFormat format = _Image.PixelLayout.ToDataFormat();
				PixelType type = _Image.PixelLayout.ToPixelType();

				// Set pixel unpack
				new State.PixelUnpackState(_PixelFormat, _Image.Stride).Apply(ctx, null);
				// Upload texture contents
				Gl.TexSubImage2D(_Target, (int)_Level, 0, 0, (int)_Image.Width, (int)_Image.Height, format, type, _Image.ImageBuffer);

				// Remarks: do not update mipmap metadata: already defined
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public override void Dispose()
			{
				if (_Image != null)
					_Image.DecRef();
			}

			#endregion
		}

		#region Update(Image)

		/// <summary>
		/// Update a Texture2d.
		/// </summary>
		/// <param name="image">
		/// An <see cref="Image"/> holding the texture data.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level to create/update.
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
		public void Update(Image image, uint level)
		{
			SetTechnique(new ImageUpdateTechnique(this, TextureTarget, level, image.PixelLayout, image));
		}

		#endregion

		#region Update(PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level)

		public void Update(PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level = 0)
		{
			// Update texture
			SetTechnique(new UnmanagedTechnique(this, TextureTarget, level, pixelFormat, unmanagedPtr, width, height, lineStride));
		}

		public void Update(GraphicsContext ctx, PixelLayout pixelFormat, IntPtr unmanagedPtr, uint width, uint height, uint lineStride, uint level = 0)
		{
			// Update texture
			Update(pixelFormat, unmanagedPtr, width, height, lineStride, level);
			// Force update
			Create(ctx);
		}

		#endregion

		#endregion

#if !MONODROID

		#region Texture Download

		/// <summary>
		/// Download Texture2D data to an Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for downloading texture data.
		/// </param>
		/// <param name="pixelFormat">
		/// A <see cref="PixelLayout"/> determining the pixel format of the downloaded data.
		/// </param>
		/// <param name="level">
		/// A <see cref="UInt32"/> that specify the texture level.
		/// </param>
		/// <returns>
		/// It return the <see cref="Image"/> holding the content of this texture.
		/// </returns>
		public Image Get(GraphicsContext ctx, PixelLayout pixelFormat, uint level)
		{
			return (Get(ctx, pixelFormat, TextureTarget, level));
		}

		#endregion

#endif

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

				return baseSize;
			}
		}

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public override TextureTarget TextureTarget { get { return TextureTarget.Texture2d; } }

		/// <summary>
		/// Uniform sampler type for managing this texture.
		/// </summary>
		internal override int SamplerType
		{
			get {
				if (PixelLayout.IsIntegerPixel()) {
					if (PixelLayout.IsSignedIntegerPixel())
						return Gl.INT_SAMPLER_2D;
					if (PixelLayout.IsUnsignedIntegerPixel())
						return Gl.UNSIGNED_INT_SAMPLER_2D;

					throw new NotSupportedException(String.Format("integer pixel format {0} not correctly supported", PixelLayout));
				} else
					return Gl.SAMPLER_2D;
			}
		}

		#endregion
	}
}
