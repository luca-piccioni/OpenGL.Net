
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

namespace OpenGL
{
	/// <summary>
	/// Texture.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Textures are object holding a set of data, that can be accessed within a shader using a set of coordinates. Textures classes
	/// derives from <see cref="Texture"/>, which define a base implementation without specifying the texture dimensionality.
	/// </para>
	/// <para>
	/// Texture can be one dimensional (<see cref="Texture1d"/>), two dimensional (<see cref="Texture2d"/>), three dimensional
	/// (<see cref="Texture3d"/>), cube mapped (<see cref="TextureCube"/>).
	/// </para>
	/// </remarks>
	[DebuggerDisplay("Texture: Pixel={PixelLayout}")]
	public abstract class Texture : GraphicsResource, IBindingResource
	{
		#region Internal Format

		/// <summary>
		/// Texture pixel format.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		public PixelLayout PixelLayout
		{
			get { return (_PixelFormat); }
			set {
				// Store pixel format
				_PixelFormat = value;
				// Check for swizzle
				SetupTextelSwizzle();
			}
		}

		/// <summary>
		/// Pixel format.
		/// </summary>
		/// <remarks>
		/// This member determine the texture internal format.
		/// </remarks>
		private PixelLayout _PixelFormat = PixelLayout.None;

		#endregion

		#region Texture Object

		/// <summary>
		/// Determine whether defined Texture data shall be released after having
		/// defined this Texture.
		/// </summary>
		/// <remarks>
		/// <para>
		/// By default, this property is set to true. It is considered only in the case the GL_EXT_texture_object is supported.
		/// </para>
		/// </remarks>
		public bool AutoReleaseData
		{
			get { return (_AutoRelease); }
			set { _AutoRelease = value; }
		}

		/// <summary>
		/// Flag for releasing data on upload.
		/// </summary>
		private bool _AutoRelease = GraphicsContext.CurrentCaps.GlExtensions.TextureObject_EXT;

		#endregion

		#region Texture Extents

		/// <summary>
		/// Texture width.
		/// </summary>
		/// <remarks>
		/// Every texture target has a width.
		/// </remarks>
		public abstract uint Width { get; }

		/// <summary>
		/// Texture width.
		/// </summary>
		/// <remarks>
		/// Every texture target has a height, except:
		/// - Texture1d: this target has an height always equals to 1
		/// </remarks>
		public abstract uint Height { get; }

		/// <summary>
		/// Texture depth.
		/// </summary>
		/// <remarks>
		/// Only Texture3d target has a depth. For every else texture target, it is set to 1.
		/// </remarks>
		public abstract uint Depth { get; }

		#endregion

		#region Capability Support

		/// <summary>
		/// Check whether the texture extents are compatible with context capabilities.
		/// </summary>
		/// <param name="caps">
		/// A <see cref="GraphicsCapabilities"/> determining the underlying texture capabilities.
		/// </param>
		/// <param name="width">
		/// A <see cref="UInt32"/> that specify the texture width.
		/// </param>
		/// <param name="height">
		/// A <see cref="UInt32"/> that specify the texture height.
		/// </param>
		/// <param name="depth">
		/// A <see cref="UInt32"/> that specify the texture depth.
		/// </param>
		/// <param name="format">
		/// A <see cref="OpenGL.PixelLayout"/> that specify the texture internal format.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception throw if <paramref name="caps"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="width"/>, <paramref name="height"/> or <paramref name="depth"/> is greater than
		/// the maximum allowed for the specific texture target.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if NPOT texture are not supported by <paramref name="caps"/>, and <paramref name="width"/>, <paramref name="height"/>
		/// or <paramref name="depth"/> is not a power-of-two value.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="format"/> is not a supported internal format.
		/// </exception>
		private void CheckCapabilities(GraphicsCapabilities caps, uint width, uint height, uint depth, PixelLayout format)
		{
			if (caps == null)
				throw new ArgumentNullException("caps");
			if (caps.GlExtensions == null)
				throw new ArgumentException("caps GL extensions not queried", "caps");
			if (caps.Limits == null)
				throw new ArgumentException("caps Limits not queried", "caps");
		
			// Texture maximum size
			switch (TextureTarget) {
				case TextureTarget.Texture1d:
					if (width > caps.Limits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", caps.Limits.MaxTexture2DSize));
					break;
				case TextureTarget.Texture2d:
					if (width > caps.Limits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", caps.Limits.MaxTexture2DSize));
					if (height > caps.Limits.MaxTexture2DSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", caps.Limits.MaxTexture2DSize));
					break;
				case TextureTarget.TextureRectangle:
					if (width > caps.Limits.MaxTextureRectSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", caps.Limits.MaxTextureRectSize));
					if (height > caps.Limits.MaxTextureRectSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", caps.Limits.MaxTextureRectSize));
					break;
				case TextureTarget.Texture3d:
					if (width > caps.Limits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", caps.Limits.MaxTexture3DSize));
					if (height > caps.Limits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", caps.Limits.MaxTexture3DSize));
					if (depth > caps.Limits.MaxTexture3DSize)
						throw new ArgumentException(String.Format("depth greater than maximum allowed ({0})", caps.Limits.MaxTexture3DSize));
					break;
				case TextureTarget.TextureCubeMap:
					if (width > caps.Limits.MaxTextureCubeSize)
						throw new ArgumentException(String.Format("width greater than maximum allowed ({0})", caps.Limits.MaxTextureCubeSize));
					if (height > caps.Limits.MaxTextureCubeSize)
						throw new ArgumentException(String.Format("height greater than maximum allowed ({0})", caps.Limits.MaxTextureCubeSize));
					break;
				default:
					throw new NotImplementedException("not implemented checks on texture " + GetType());
			}
			// Texture not-power-of-two
			if (caps.GlExtensions.TextureNonPowerOfTwo_ARB == false) {
				if (IsPowerOfTwo(width) == false)
					throw new ArgumentException(String.Format("NPOT texture width not supported (width is {0})", width));
				if (IsPowerOfTwo(height) == false)
					throw new ArgumentException(String.Format("NPOT texture height not supported (height is {0})", height));
				if (IsPowerOfTwo(depth) == false)
					throw new ArgumentException(String.Format("NPOT texture depth not supported (height is {0})", height));
			}
			// Texture internal format
			if (Pixel.IsSupportedInternalFormat(format) == false)
				throw new ArgumentException(String.Format("not supported texture internal format {0}", format), "format");
		}

		/// <summary>
		/// Determine whether an integer is a power-of-two value.
		/// </summary>
		/// <param name="x">
		/// A <see cref="UInt32"/> that specify the value to test.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether <paramref name="x"/> is a power-of-two value.
		/// </returns>
		private static bool IsPowerOfTwo(uint x)
		{
			return (x & (x - 1)) == 0;
		}

		/// <summary>
		/// Download Texture data to an Image instance.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for downloading texture data.
		/// </param>
		/// <param name="pType">
		/// A <see cref="OpenGL.PixelLayout"/> determining the pixel format of the downloaded data.
		/// </param>
		/// <param name="target">
		/// A <see cref="TextureTarget"/> that specify the texture target.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		protected Image[] Get(GraphicsContext ctx, PixelLayout pType, TextureTarget target)
		{
			// Bind this Texture
			ctx.Bind(this);

			// Get texture extents
			int width, height;

			Gl.GetTexLevelParameter(TextureTarget, 0, GetTextureParameter.TextureWidth, out width);
			Gl.GetTexLevelParameter(TextureTarget, 0, GetTextureParameter.TextureHeight, out height);
			if ((width <= 0) || (height <= 0))
				throw new InvalidOperationException(String.Format("invalid texture extents {0}x{1}", width, height));

			// Create image
			Image image = new Image(pType, (uint)width, (uint)height);

			// Set pixel transfer
			foreach (int alignment in new int[] { 8, 4, 2, 1 }) {
				if (image.Stride % alignment == 0) {
					Gl.PixelStore(PixelStoreParameter.PackAlignment, alignment);
					break;
				}
			}

			// Download texture contents
			Gl.GetTexImage(target, 0, Pixel.GetGlFormat(pType), Pixel.GetPixelType(pType), image.ImageBuffer);

			// Unbind this texture
			ctx.Unbind(this);

			return (new Image[] { image });
		}

		#endregion

		#region Mipmapping

		/// <summary>
		/// Request the creation of this Texture mipmaps.
		/// </summary>
		/// <remarks>
		/// This routine shall be called before Texture creation. In the case it is called after the texture has
		/// been created, it has not effect untill the texture is updated.
		/// </remarks>
		public void RequestMipmapsCreation()
		{
			_RequiresMipMaps = true;
		}

		/// <summary>
		/// Generate mipmaps for this Texture.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for generating texture mipmaps.
		/// </param>
		internal virtual void GenerateMipmaps(GraphicsContext ctx)
		{
			GenerateMipmaps(ctx, TextureTarget);
		}

		/// <summary>
		/// Generate mipmaps for this Texture, replacing mipmaps level from 1 to <see cref="MipmapLevels"/> - 1.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for mipmapping definition.
		/// </param>
		/// <param name="target">
		/// A <see cref="TextureTarget"/> indicating the target for generating
		/// bitmaps.
		/// </param>
		protected void GenerateMipmaps(GraphicsContext ctx, TextureTarget target)
		{
			// Bind this Texture
			ctx.Bind(this);
			// Generate mipmaps
			Gl.GenerateMipmap((int)target);
			// Unbind this texture
			ctx.Unbind(this);

			// Now texture has mipmaps
			_HasMipMaps = true;
		}

		/// <summary>
		/// Flag indicating whether this Texture has mipmaps definition.
		/// </summary>
		/// <remarks>
		/// This flag specify whether this Texture has mipmaps, or not. By
		/// </remarks>
		public bool HasMipmaps
		{
			get { return (_HasMipMaps); }
			protected set { _HasMipMaps = value; }
		}

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
		protected virtual uint MipmapLevels
		{
			get {
				uint maxSize = Math.Max(Math.Max(Width, Height), Depth);

				if (maxSize > 0)
					return (1 + (uint)Math.Floor(Math.Log(maxSize, 2.0)));
				else
					return (0);
			}
		}

		/// <summary>
		/// Compute the mipmap size.
		/// </summary>
		/// <param name="lod">
		/// A <see cref="UInt32"/> that specify the mipmap level.
		/// </param>
		/// <returns>
		/// It returns a <see cref="Vertex3ui"/> that contains the mipmap width, height and depth.
		/// </returns>
		protected Vertex3ui GetMipmapSize(uint lod)
		{
			Vertex3ui baseSize = new Vertex3ui(Width, Height, Depth);
			uint div = (uint)Math.Pow(2.0, lod);

			Vertex3ui mipmapSize = baseSize / div;

			mipmapSize.x = Math.Max(1, mipmapSize.x);
			mipmapSize.y = Math.Max(1, mipmapSize.y);
			mipmapSize.z = Math.Max(1, mipmapSize.z);

			return (mipmapSize);
		}

		/// <summary>
		/// Flag indicating whether this Texture shall ghave mipmaps created automatically at creationg time.
		/// </summary>
		private bool _RequiresMipMaps;

		/// <summary>
		/// Flag indicating whether this Texture has mipmaps defined (actually).
		/// </summary>
		private bool _HasMipMaps;

		/// <summary>
		/// The index of the lowest (base) define mipmap level.
		/// </summary>
		private int _MipmapMinLevel = -1;

		/// <summary>
		/// The index of the highest (base) define mipmap level.
		/// </summary>
		private int _MipmapMaxLevel = -1;

		#endregion

		#region Filter

		/// <summary>
		/// Texture filter.
		/// </summary>
		public enum Filter
		{
			/// <summary>
			/// Keep the nearest pixel.
			/// </summary>
			Nearest,
			/// <summary>
			/// Linearly interpolate pixels in neightboor.
			/// </summary>
			Linear
		}
		
		/// <summary>
		/// Minification filter property.
		/// </summary>
		public Filter MinFilter
		{
			get { return (_MinFilter); }
			set
			{
				if (_MinFilter != value)
					_MinFilterDirty = true;
				_MinFilter = value;
			}
		}

		/// <summary>
		/// Minification filter consider mipmaps for filtering.
		/// </summary>
		public Filter MipFilter
		{
			get { return (_MipFilter); }
			set
			{
				if (_MipFilter != value)
					_MipFilterDirty = true;
				_MipFilter = value;
			}
		}
		
		/// <summary>
		/// Magnification filter property.
		/// </summary>
		public Filter MagFilter
		{
			get { return (_MagFilter); }
			set
			{
				if (_MagFilter != value)
					_MagFilterDirty = true;
				_MagFilter = value;
			}
		}

		/// <summary>
		/// Minification filter.
		/// </summary>
		private Filter _MinFilter = Filter.Linear;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _MinFilterDirty = true;

		/// <summary>
		/// Minification filter consider mipmaps (relevant only when texture has mipmaps).
		/// </summary>
		private Filter _MipFilter = Filter.Nearest;

		/// <summary>
		/// Flag for applying <see cref="_MipFilter"/> only if changes.
		/// </summary>
		private bool _MipFilterDirty = true;

		/// <summary>
		/// Magnification filter.
		/// </summary>
		private Filter _MagFilter = Filter.Nearest;

		/// <summary>
		/// Flag for applying <see cref="_MagFilter"/> only if changes.
		/// </summary>
		private bool _MagFilterDirty = true;
		
		#endregion

		#region Wrapping

		/// <summary>
		/// Texture wrapping mode.
		/// </summary>
		public enum Wrap
		{
			/// <summary>
			/// Texture coordinates are clamped to the valid range.
			/// </summary>
			Clamp = Gl.CLAMP_TO_EDGE,
			/// <summary>
			/// Texture coordinates are wrapped around the valid range.
			/// </summary>
			Repeat = Gl.REPEAT,
			/// <summary>
			/// Texture coordinates are wrapped around the valid range, but mirrored.
			/// </summary>
			MirroredRepeat = Gl.MIRRORED_REPEAT
		}

		/// <summary>
		/// Wrapping on texture S coordinate.
		/// </summary>
		public Wrap WrapCoordS
		{
			get { return (_WrapS); }
			set
			{
				if (_WrapS != value)
					_WrapSDirty = true;
				_WrapS = value;
			}
		}

		/// <summary>
		/// Wrapping on texture T coordinate.
		/// </summary>
		public Wrap WrapCoordT
		{
			get { return (_WrapT); }
			set
			{
				if (_WrapT != value)
					_WrapTDirty = true;
				_WrapT = value;
			}
		}

		/// <summary>
		/// Wrapping on texture R coordinate.
		/// </summary>
		public Wrap WrapCoordR
		{
			get { return (_WrapR); }
			set
			{
				if (_WrapR != value)
					_WrapRDirty = true;
				_WrapR = value;
			}
		}

		/// <summary>
		/// Wrapping on S coordinate.
		/// </summary>
		private Wrap _WrapS = Wrap.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapSDirty = true;

		/// <summary>
		/// Wrapping on T coordinate.
		/// </summary>
		private Wrap _WrapT = Wrap.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapTDirty = true;

		/// <summary>
		/// Wrapping on R coordinate.
		/// </summary>
		private Wrap _WrapR = Wrap.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapRDirty = true;

		#endregion

		#region Swizzle

		/// <summary>
		/// Texture swizzled components.
		/// </summary>
		public enum Swizzle
		{
			/// <summary>
			/// Zero.
			/// </summary>
			Zero = Gl.ZERO,
			/// <summary>
			/// One.
			/// </summary>
			One = Gl.ONE,
			/// <summary>
			/// Red.
			/// </summary>
			Red = Gl.RED,
			/// <summary>
			/// Green.
			/// </summary>
			Green = Gl.GREEN,
			/// <summary>
			/// Blue.
			/// </summary>
			Blue = Gl.BLUE,
			/// <summary>
			/// Alpha.
			/// </summary>
			Alpha = Gl.ALPHA
		}

		/// <summary>
		/// Get or set the swizzle map for red component.
		/// </summary>
		public Swizzle SizzleRed { get { return (_TextelSwizzle[0]); } set { _TextelSwizzle[0] = value; } }

		/// <summary>
		/// Get or set the swizzle map for green component.
		/// </summary>
		public Swizzle SizzleGreen { get { return (_TextelSwizzle[1]); } set { _TextelSwizzle[1] = value; } }

		/// <summary>
		/// Get or set the swizzle map for blue component.
		/// </summary>
		public Swizzle SizzleBlue { get { return (_TextelSwizzle[2]); } set { _TextelSwizzle[2] = value; } }

		/// <summary>
		/// Get or set the swizzle map for alpha component.
		/// </summary>
		public Swizzle SizzleAlpha { get { return (_TextelSwizzle[3]); } set { _TextelSwizzle[3] = value; } }

		/// <summary>
		/// Setup texture textel components swizzle.
		/// </summary>
		/// <remarks>
		/// Texture swizzle is a way to set/clone/mix textel components during the shaders execution. It
		/// is mainly used for grayscale textures, cloning the R component in the G and B components;
		/// sometimes is used to ignore A components, since the data specify it by it is not meaninfull.
		/// </remarks>
		private void SetupTextelSwizzle()
		{
			if (GraphicsContext.CurrentCaps.GlExtensions.TextureSwizzle_ARB) {
				switch (_PixelFormat) {

					#region GRAY Internal Formats

					case PixelLayout.GRAY8:
					case PixelLayout.GRAY16:
					case PixelLayout.GRAY16S:
					case PixelLayout.GRAYF:
					case PixelLayout.GRAYHF:
						// Emulated Gl.LUMINANCE textel format
						_TextelSwizzleRGBA = new int[] {
							Gl.RED,
							Gl.RED,
							Gl.RED,
							Gl.ONE
						};
						break;

					#endregion

					default:
						// By default, no swizzle is required
						_TextelSwizzleRGBA = null;
						break;
				}
			}
		}

		/// <summary>
		/// Texture textel swizzle setup.
		/// </summary>
		/// <remarks>
		/// When this member is set to null, no textel components swizzle is required.
		/// </remarks>
		private int[] _TextelSwizzleRGBA;

		/// <summary>
		/// Texture textel swizzle setup.
		/// </summary>
		/// <remarks>
		/// When this member is set to null, not textel components swizzle
		/// is required.
		/// </remarks>
		private readonly Swizzle[] _TextelSwizzle = new Swizzle[] { Swizzle.Red, Swizzle.Green, Swizzle.Blue, Swizzle.Alpha };

		#endregion

		#region Parameters

		/// <summary>
		/// Apply this Texture parameters.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for setting texture parameter.
		/// </param>
		/// <remarks>
		/// Tipically this routine is implemented by simply calling the routine
		/// <see cref="ApplyParameters(GraphicsContext,int)"/>.
		/// </remarks>
		public virtual void ApplyParameters(GraphicsContext ctx)
		{
			ApplyParameters(ctx, TextureTarget);
		}

		/// <summary>
		/// Apply Texture parameters of specific target.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for setting texture parameter.
		/// </param>
		/// <param name="target">
		/// A <see cref="TextureTarget"/> that specify the Texture target.
		/// </param>
		protected void ApplyParameters(GraphicsContext ctx, TextureTarget target)
		{
			int iParam;

			#region Minification Filter

			if (_HasMipMaps) {
				switch (MinFilter) {
					case Filter.Nearest:
						switch (MipFilter) {
							case Filter.Nearest:
								iParam = Gl.NEAREST_MIPMAP_NEAREST;
								break;
							case Filter.Linear:
								iParam = Gl.NEAREST_MIPMAP_LINEAR;
								break;
							default:
								throw new NotSupportedException(String.Format("unknown mipmap minification filter {0}", MipFilter));
						}
						break;
					case Filter.Linear:
						switch (MipFilter) {
							case Filter.Nearest:
								iParam = Gl.LINEAR_MIPMAP_NEAREST;
								break;
							case Filter.Linear:
								iParam = Gl.LINEAR_MIPMAP_LINEAR;
								break;
							default:
								throw new NotSupportedException(String.Format("unknown mipmap minification filter {0}", MipFilter));
						}
						break;
					default:
						throw new NotSupportedException(String.Format("unknown minification filter {0}", MinFilter));
				}

				// Set minification filter (with mipmaps)
				if (_MinFilterDirty || _MipFilterDirty)
					Gl.TexParameter(target, TextureParameterName.TextureMinFilter, iParam);
				_MinFilterDirty = _MipFilterDirty = false;
			} else {
				switch (MinFilter) {
					case Filter.Nearest:
						iParam = Gl.NEAREST;
						break;
					case Filter.Linear:
						iParam = Gl.LINEAR;
						break;
					default:
						throw new NotSupportedException(String.Format("unknown minification filter {0}", MinFilter));
				}
				// Set minification filter (without mipmaps)
				if (_MinFilterDirty)
					Gl.TexParameter(target, TextureParameterName.TextureMinFilter, iParam);
				_MinFilterDirty = false;
			}

			#endregion

			#region Magnification Filter

			switch (MagFilter) {
				case Filter.Nearest:
					iParam = Gl.NEAREST;
					break;
				case Filter.Linear:
					iParam = Gl.LINEAR;
					break;
				default:
					throw new NotSupportedException(String.Format("unknown magnification filter {0}", MagFilter));
			}

			// Set minification filter (without mipmaps)
			if (_MagFilterDirty)
				Gl.TexParameter(target, TextureParameterName.TextureMagFilter, iParam);
			_MagFilterDirty = false;

			#endregion

			#region Wrapping

			if (target != TextureTarget.TextureRectangle) {
				// Wrap S coordinate
				if (_WrapRDirty)
					Gl.TexParameter(target, TextureParameterName.TextureWrapS, (int)WrapCoordS);
				_WrapRDirty = false;
				// Wrap T coordinate
				if (_WrapTDirty)
					Gl.TexParameter(target, TextureParameterName.TextureWrapT, (int)WrapCoordT);
				_WrapTDirty = false;
				// Wrap R coordinate
				if (_WrapRDirty)
					Gl.TexParameter(target, TextureParameterName.TextureWrapR, (int)WrapCoordR);
				_WrapRDirty = false;
			}

			#endregion

			#region Textel Components Swizzle

			if ((_TextelSwizzleRGBA != null) && (ctx.Caps.GlExtensions.TextureSwizzle_ARB)) {
				// Set components swizzle setup
				Gl.TexParameter(target, (TextureParameterName)Gl.TEXTURE_SWIZZLE_RGBA, _TextelSwizzleRGBA);
			}

			#endregion

			#region Mipmap Levels

			Debug.Assert(_MipmapMinLevel <= _MipmapMaxLevel);
			if (_MipmapMinLevel >= 0)
				Gl.TexParameter(TextureTarget, (TextureParameterName)Gl.TEXTURE_BASE_LEVEL, _MipmapMinLevel);
			if (_MipmapMaxLevel >= 0)
				Gl.TexParameter(TextureTarget, (TextureParameterName)Gl.TEXTURE_MAX_LEVEL, _MipmapMaxLevel);

			#endregion
		}

		#endregion

		#region Binding

		/// <summary>
		/// Determine the derived Texture target.
		/// </summary>
		/// <remarks>
		/// In the case a this Texture is defined by multiple targets (i.e. cube map textures), this property
		/// shall returns always 0.
		/// </remarks>
		public abstract TextureTarget TextureTarget { get; }

		#endregion

		#region Shader Uniform Binding

		/// <summary>
		/// Uniform sampler type for managing this Texture.
		/// </summary>
		internal abstract int SamplerType { get; }

		#endregion

		#region Technique

		/// <summary>
		/// Get whether the Texture has data to be updated.
		/// </summary>
		public bool IsDirty { get { return (_Technique != null); } }

		/// <summary>
		/// Technique for creating Texture2d objects.
		/// </summary>
		protected abstract class Technique : IDisposable
		{
			/// <summary>
			/// Construct a Technique.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="Texture"/> affected by this Technique.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="texture"/> is null.
			/// </exception>
			public Technique(Texture texture)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");
				_Texture = texture;
			}

			/// <summary>
			/// The <see cref="Texture"/> affected by this Technique.
			/// </summary>
			protected readonly Texture _Texture;

			/// <summary>
			/// Create the texture, using this technique.
			/// </summary>
			/// <param name="ctx">
			/// A <see cref="GraphicsContext"/> used for allocating resources.
			/// </param>
			public abstract void Create(GraphicsContext ctx);

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public virtual void Dispose() { }
		}

		/// <summary>
		/// Set the technique used for creating this Texture.
		/// </summary>
		/// <param name="technique">
		/// 
		/// </param>
		protected void SetTechnique(Technique technique)
		{
			if (technique == null)
				throw new ArgumentNullException("technique");

			// Dispose previous technique, if any
			if (_Technique != null)
				_Technique.Dispose();
			// Replace technique
			_Technique = technique;
		}

		/// <summary>
		/// Technique used for creating this texture.
		/// </summary>
		private Technique _Technique;

		#endregion

		#region GraphicsResource Overrides

		/// <summary>
		/// Texture object class.
		/// </summary>
		internal static readonly Guid ThisObjectClass = new Guid("0B0FA1F6-76B2-4B6A-B2B2-319D9E330FB1");

		/// <summary>
		/// Texture object class.
		/// </summary>
		public override Guid ObjectClass { get { return (ThisObjectClass); } }

		/// <summary>
		/// Determine whether this Texture really exists for a specific context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> that would have created (or a sharing one) the object. This context shall be current to
		/// the calling thread.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this Texture exists in the object space of <paramref name="ctx"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// The object existence is done by checking a valid object by its name <see cref="IGraphicsResource.ObjectName"/>. This routine will test whether
		/// <paramref name="ctx"/> has created this Texture (or is sharing with the creator).
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="ctx"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="ctx"/> is not current to the calling thread.
		/// </exception>
		public override bool Exists(GraphicsContext ctx)
		{
			// Object name space test (and 'ctx' sanity checks)
			if (base.Exists(ctx) == false)
				return (false);

			return (!ctx.Caps.GlExtensions.TextureObject_EXT || Gl.IsTexture(ObjectName));
		}

		/// <summary>
		/// Create a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for creating this object name.
		/// </param>
		/// <returns>
		/// It returns a valid object name for this Texture.
		/// </returns>
		protected override uint CreateName(GraphicsContext ctx)
		{
			// Generate texture name
			return (Gl.GenTexture());
		}

		/// <summary>
		/// Delete a Texture name.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for deleting this object name.
		/// </param>
		/// <param name="name">
		/// A <see cref="UInt32"/> that specify the object name to delete.
		/// </param>
		protected override void DeleteName(GraphicsContext ctx, uint name)
		{
			// Delete texture name
			Gl.DeleteTextures(name);
		}

		/// <summary>
		/// Actually create this GraphicsResource resources.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for allocating resources.
		/// </param>
		protected override void CreateObject(GraphicsContext ctx)
		{
			CheckCurrentContext(ctx);

			// Bind this texture
			Gl.BindTexture(TextureTarget, ObjectName);
			ctx.Bind(this);

			// In the case of no technique, texture will exists but it will be undefined

			if (_Technique != null) {
				// Create texture using technique
				_Technique.Create(ctx);
				// Technique no more useful: dispose it
				_Technique.Dispose();
				_Technique = null;
			
				// Generate mipmaps, if requested
				if (_RequiresMipMaps)
					GenerateMipmaps(ctx);
			}

			// Clear binding point
			ctx.Unbind(this);
		}

		#endregion

		#region IBindingResource Implementation

		/// <summary>
		/// Get the identifier of the binding point.
		/// </summary>
		int IBindingResource.BindingTarget
		{
			get
			{
				// All-in-one implementation for all targets
				switch ((int)TextureTarget) {
					case Gl.TEXTURE_1D:
						return (Gl.TEXTURE_BINDING_1D);
					case Gl.TEXTURE_2D:
						return (Gl.TEXTURE_BINDING_2D);
					case Gl.TEXTURE_3D:
						return (Gl.TEXTURE_BINDING_3D);

					case Gl.TEXTURE_CUBE_MAP:
						return (Gl.TEXTURE_BINDING_CUBE_MAP);

					case Gl.TEXTURE_RECTANGLE:
						return (Gl.TEXTURE_BINDING_RECTANGLE);

					case Gl.TEXTURE_1D_ARRAY:
						return (Gl.TEXTURE_BINDING_1D_ARRAY);
					case Gl.TEXTURE_2D_ARRAY:
						return (Gl.TEXTURE_BINDING_2D_ARRAY);
					case Gl.TEXTURE_CUBE_MAP_ARRAY:
						return (Gl.TEXTURE_BINDING_CUBE_MAP_ARRAY);

					case Gl.TEXTURE_2D_MULTISAMPLE:
						return (Gl.TEXTURE_BINDING_2D_MULTISAMPLE);
						case Gl.TEXTURE_2D_MULTISAMPLE_ARRAY:
						return (Gl.TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY);

					default:
						throw new NotSupportedException();
				}
				
			}
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Bind(GraphicsContext ctx)
		{
			CheckThisExistence(ctx);

			// Bind
			Gl.BindTexture(TextureTarget, ObjectName);
		}

		/// <summary>
		/// Bind this IBindingResource.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for binding.
		/// </param>
		void IBindingResource.Unbind(GraphicsContext ctx)
		{
			CheckThisExistence(ctx);

			// Bind
			Gl.BindTexture(TextureTarget, InvalidObjectName);
		}

		/// <summary>
		/// Check whether this IBindingResource is currently bound on the specified graphics context.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> used for querying the current binding state.
		/// </param>
		/// <returns>
		/// It returns a boolean value indicating whether this IBindingResource is currently bound on <paramref name="ctx"/>.
		/// </returns>
		bool IBindingResource.IsBound(GraphicsContext ctx)
		{
			int currentTexture;
			
			Gl.Get(((IBindingResource)this).BindingTarget, out currentTexture);

			return (currentTexture == (int)ObjectName);
		}

		#endregion
	}
}
