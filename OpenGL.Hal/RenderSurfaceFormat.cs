
// Copyright (C) 2011-2013 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;

namespace OpenGL
{
	/// <summary>
	/// Surface pixel format configuration.
	/// </summary>
	[DebuggerDisplay("RenderSurfaceFormat Color={ColorType} Depth={DepthBits} Stencil={StencilBits} MS={MultisampleBits} DB={DoubleBuffers}")]
	public sealed class RenderSurfaceFormat
	{
		#region Constructors

		/// <summary>
		/// Default surface format (8 bit RGB color, no depth, no stencil, no multisample, no double/stereo buffering).
		/// </summary>
		public RenderSurfaceFormat()
			: this(PixelLayout.RGB24)	// Most commonly supported format
		{

		}

		/// <summary>
		/// Surface format with specified color (no depth, no stencil, no multisample, no double/stereo buffering).
		/// </summary>
		/// <param name="color">
		/// A <see cref="PixelLayout"/> that specify the format of the color buffer.
		/// </param>
		/// <remarks>
		/// <para>
		/// The buffer configurations are considered required but degradable. If it necessary a specific resolution,
		/// define those configurations using the related <i>Define*</i> routine.
		/// </para>
		/// </remarks>
		public RenderSurfaceFormat(PixelLayout color)
		{
			DefineColorBuffer(color);
		}

		/// <summary>
		/// Surface format with specified color and depth (no stencil, no multisample, no double/stereo buffering).
		/// </summary>
		/// <param name="color">
		/// A <see cref="PixelLayout"/> that specify the format of the color buffer.
		/// </param>
		/// <param name="depth">
		/// A <see cref="System.UInt32"/> that specify the bit count of the depth buffer fragment.
		/// </param>
		/// <remarks>
		/// <para>
		/// The buffer configurations are considered required but degradable. If it necessary a specific resolution,
		/// define those configurations using the related <i>Define*</i> routine.
		/// </para>
		/// </remarks>
		public RenderSurfaceFormat(PixelLayout color, uint depth)
		{
			DefineColorBuffer(color);
			DefineDepthBuffer(depth);
		}

		#endregion

		#region Buffer Management

		/// <summary>
		/// Buffer definitions.
		/// </summary>
		/// <remarks>
		/// This enumeration specify surface buffers available of each RenderSurface, or duplication
		/// of defined buffers for double buffering or stereoscopic buffers.
		/// </remarks>
		[Flags]
		public enum BufferType {
			/// <summary>
			/// Surface has color buffer. 
			/// </summary>
			Color =				0x8001,
			/// <summary>
			/// Surface has color buffer, but encoded in sRGB color space.
			/// </summary>
			ColorSRGB =			0x8000,
			/// <summary>
			/// Surface has depth buffer.
			/// </summary>
			Depth =				0x0002,
			/// <summary>
			/// Surface has stencil buffer.
			/// </summary>
			Stencil =			0x0004,
			/// <summary>
			/// Multisample buffer.
			/// </summary>
			Multisample =		0x0008,
			/// <summary>
			/// Double buffers (front and back)
			/// </summary>
			Double =			0x0010,
			/// <summary>
			/// Stereo buffers (left and right buffers)
			/// </summary>
			Stereo =			0x0020,
		}

		/// <summary>
		/// Buffer definition policy. 
		/// </summary>
		public enum BufferPolicy
		{
			/// <summary>
			/// The buffer definition is completely optional. Other policies will be
			/// preponderant in the buffer configuration matching.
			/// </summary>
			DontCare,
			/// <summary>
			/// The buffer definition is required to match. Buffers configuration that
			/// don't satify buffer definition are not considered.
			/// </summary>
			Required,
			/// <summary>
			/// The buffer definition is required, but a minor definition is allowed to
			/// consider buffer configuration.
			/// </summary>
			RequiredAndDegradable
		}

		/// <summary>
		/// Get a mask of surface buffers.
		/// </summary>
		public BufferType BuffersMask { get { return (mSurfaceBuffers); } }

		/// <summary>
		/// Determine whether this RenderSurface has allocated a certain buffer. 
		/// </summary>
		/// <param name="sBuffer">
		/// A <see cref="System.Int32"/> which could be one of the following values:
		/// - <see cref="BufferType.Color"/>
		/// - <see cref="BufferType.Depth"/>
		/// - <see cref="BufferType.Stencil"/>
		/// - <see cref="BufferType.Multisample"/>
		/// - <see cref="BufferType.Double"/>
		/// - <see cref="BufferType.Stereo"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether the buffer specified in <paramref name="sBuffer"/> it shall
		/// be allocated.
		/// </returns>
		public bool HasBuffer(BufferType sBuffer)
		{
			return ((mSurfaceBuffers & sBuffer) != 0);
		}

		/// <summary>
		/// Determine whether a RenderSurface buffer is required.
		/// </summary>
		/// <param name="sBuffer">
		/// A <see cref="System.Int32"/> which could be one of the following values:
		/// - <see cref="BufferType.Color"/>
		/// - <see cref="BufferType.Depth"/>
		/// - <see cref="BufferType.Stencil"/>
		/// - <see cref="BufferType.Multisample"/>
		/// - <see cref="BufferType.Double"/>
		/// - <see cref="BufferType.Stereo"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether the buffer specified in <paramref name="sBuffer"/>
		/// it was requested with Surface interface using <see cref="BufferPolicy.Required"/> or 
		/// <see cref="BufferPolicy.RequiredAndDegradable"/>.
		/// </returns>
		public bool IsRequiredBuffer(BufferType sBuffer)
		{
			return ((mRequiredSurfaceBuffers & sBuffer) != 0);
		}
						 
		/// <summary>
		/// Determine whether a RenderSurface buffer is degradable.
		/// </summary>
		/// <param name="sBuffer">
		/// A <see cref="System.Int32"/> which could be one of the following values:
		/// - <see cref="BufferType.Color"/>
		/// - <see cref="BufferType.Depth"/>
		/// - <see cref="BufferType.Stencil"/>
		/// - <see cref="BufferType.Multisample"/>
		/// - <see cref="BufferType.Double"/>
		/// - <see cref="BufferType.Stereo"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether the buffer specified in <paramref name="sBuffer"/>
		/// it was requested with Surface interface using <see cref="BufferPolicy.RequiredAndDegradable"/>.
		/// </returns>
		public bool IsDegradableBuffer(BufferType sBuffer)
		{
			return ((mDegradableSurfaceBuffers & sBuffer) != 0);
		}

		/// <summary>
		/// Determine whether a buffer was requested.
		/// </summary>
		/// <param name="sBuffer">
		/// A <see cref="System.Int32"/> which could be one of the following values:
		/// - <see cref="BufferType.Color"/>
		/// - <see cref="BufferType.Depth"/>
		/// - <see cref="BufferType.Stencil"/>
		/// - <see cref="BufferType.Multisample"/>
		/// - <see cref="BufferType.Double"/>
		/// - <see cref="BufferType.Stereo"/>
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> indicating whether the buffer specified in <paramref name="sBuffer"/>
		/// it was not requested with Surface interface.
		/// </returns>
		public bool IsIgnoredBuffer(BufferType sBuffer)
		{
			return (!IsRequiredBuffer(sBuffer));
		}

		/// <summary>
		/// Define a buffer in this configuration.
		/// </summary>
		/// <param name="bType">
		/// A <see cref="BufferType"/> indicating the buffer to define.
		/// </param>
		/// <param name="bPolicy">
		/// A <see cref="BufferPolicy"/> specifing the buffer definition policy.
		/// </param>
		private void DefineBuffer(BufferType bType, BufferPolicy bPolicy)
		{
			// Store color buffer definition policy
			switch (bPolicy) {
				case BufferPolicy.DontCare:
					mRequiredSurfaceBuffers &= ~bType;
					mDegradableSurfaceBuffers &= ~bType;
					break;
				case BufferPolicy.Required:
					mRequiredSurfaceBuffers |= bType;
					mDegradableSurfaceBuffers &= ~bType;
					break;
				case BufferPolicy.RequiredAndDegradable:
					mRequiredSurfaceBuffers |= bType;
					mDegradableSurfaceBuffers |= bType;
					break;
			}
			// Define buffer
			mSurfaceBuffers |= bType;
		}


		/// <summary>
		/// Undef a buffer in this configuration
		/// </summary>
		/// <param name="bType">
		/// A <see cref="BufferType"/> indicating the buffer to undefine.
		/// </param>
		private void UndefineBuffer(BufferType bType)
		{
			// Undefine buffer
			mSurfaceBuffers &= ~bType;
			mRequiredSurfaceBuffers &= ~bType;
			mDegradableSurfaceBuffers &= ~bType;
		}

		/// <summary>
		/// Surface buffers. 
		/// </summary>
		private BufferType mSurfaceBuffers;

		/// <summary>
		/// Required surface buffers flags. 
		/// </summary>
		/// <remarks>
		/// In the case the mask has a buffer type bit set, indicates that buffer type is required for
		/// RenderSurface creation.
		/// </remarks>
		private BufferType mRequiredSurfaceBuffers;

		/// <summary>
		/// Degradable surface buffers flags.
		/// </summary>
		/// <remarks>
		/// In the case the mask has a buffer type bit set, indicates
		/// that buffer type is required, and its format could be degraded
		/// to achieve RenderSurface creation. 
		/// </remarks>
		private BufferType mDegradableSurfaceBuffers;

		#endregion
		
		#region Specific Format
		
		/// <summary>
		/// Define RenderSurface format index. 
		/// </summary>
		/// <param name="formatIndex">
		/// A <see cref="System.Int32"/>
		/// </param>
		public void DefineFormatIndex(int formatIndex) { DefineFormatIndex(formatIndex, BufferPolicy.RequiredAndDegradable); }
		
		/// <summary>
		/// Define RenderSurface format index. 
		/// </summary>
		/// <param name="formatIndex">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineFormatIndex(int formatIndex, BufferPolicy policy)
		{
			mFormatIndex = formatIndex;
			mFormatPolicy = policy;
		}
		
		/// <summary>
		/// Undefine RenderSurface format index.
		/// </summary>
		public void UndefineFormatIndex()
		{
			// Undefine buffer
			mFormatIndex = -1;
		}
		
		/// <summary>
		/// The index of the pixel format.
		/// </summary>
		public int FormatIndex { get { return (mFormatIndex); } }
		
		/// <summary>
		/// The index of the pixel format.
		/// </summary>
		private int mFormatIndex = -1;
		
		/// <summary>
		/// The policy applied to the format index.
		/// </summary>
		private BufferPolicy mFormatPolicy;
		
		#endregion

		#region Color Buffer Definition

		/// <summary>
		/// Define RenderSurface color buffer. 
		/// </summary>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/>
		/// </param>
		public void DefineColorBuffer(PixelLayout pType) { DefineColorBuffer(pType, BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define RenderSurface color buffer. 
		/// </summary>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineColorBuffer(PixelLayout pType, BufferPolicy policy)
		{
			if (pType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type", "pType");
			
			// Define buffer
			DefineBuffer(BufferType.Color, policy);
			// Set color buffer bits.
			mColorType = pType;
		}

		/// <summary>
		/// Undefine RenderSurface color buffer. 
		/// </summary>
		public void UndefineColorBuffer()
		{
			// Undefine buffer
			UndefineBuffer(BufferType.Color);
			// Set no pixel type
			mColorType = PixelLayout.None;
		}

		/// <summary>
		/// Define RenderSurface color buffer. 
		/// </summary>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/>
		/// </param>
		public void DefineColorSRGBBuffer(PixelLayout pType) { DefineColorSRGBBuffer(pType, BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define RenderSurface color buffer. 
		/// </summary>
		/// <param name="pType">
		/// A <see cref="PixelLayout"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineColorSRGBBuffer(PixelLayout pType, BufferPolicy policy)
		{
			if (pType == PixelLayout.None)
				throw new ArgumentException("invalid pixel type", "pType");

			// Define buffer
			DefineBuffer(BufferType.ColorSRGB, policy);
			// Set color buffer bits.
			mColorType = pType;
		}

		/// <summary>
		/// Undefine RenderSurface color buffer. 
		/// </summary>
		public void UndefineColorSRGBBuffer()
		{
			// Undefine buffer
			UndefineBuffer(BufferType.ColorSRGB);
			// Set no pixel type
			mColorType = PixelLayout.None;
		}

		/// <summary>
		/// Determine whether the surface configuration required a floating-point pixel.
		/// </summary>
		public bool RequiresFloatPixel
		{
			get {
				return (Pixel.IsGlFloatPixel(ColorType));
			}
		}

		/// <summary>
		/// Determine whether the surface configuration required an unsigned integer (normalized) pixel.
		/// </summary>
		public bool RequiredUnsignedPixel
		{
			get {
				return (Pixel.IsGlUnsignedPixel(ColorType));
			}
		}

		/// <summary>
		/// Color buffer pixel format.
		/// </summary>
		public PixelLayout ColorType { get { return (mColorType); } }

		/// <summary>
		/// Color buffer pixel format.
		/// </summary>
		private PixelLayout mColorType = PixelLayout.None;

		#endregion

		#region Depth Buffer Definition

		/// <summary>
		/// Define RenderSurface depth buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		public void DefineDepthBuffer(uint bits) { DefineDepthBuffer(bits, BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define RenderSurface depth buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineDepthBuffer(uint bits, BufferPolicy policy)
		{
			if (bits == 0)
				throw new ArgumentException("zero bits", "bits");
			
			// Define buffer
			DefineBuffer(BufferType.Depth, policy);
			// Set depth buffer bits
			mDepthBits = bits;
		}

		/// <summary>
		/// Undefine RenderSurface depth buffer.
		/// </summary>
		public void UndefineDepthBuffer()
		{
			// Undefine buffer
			UndefineBuffer(BufferType.Depth);
			// Set depth buffer bits to 0
			mDepthBits = 0;
		}

		/// <summary>
		/// Depth buffer bits.
		/// </summary>
		public uint DepthBits { get { return (mDepthBits); } }

		/// <summary>
		/// Depth buffer bits.
		/// </summary>
		private uint mDepthBits;

		#endregion

		#region Stencil Buffer Definition

		/// <summary>
		/// Define RenderSurface stencil buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		public void DefineStencilBuffer(uint bits) { DefineStencilBuffer(bits, BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define RenderSurface stencil buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineStencilBuffer(uint bits, BufferPolicy policy)
		{
			if (bits == 0)
				throw new ArgumentException("zero bits", "bits");
			
			// Define buffer
			DefineBuffer(BufferType.Stencil, policy);
			// Set depth buffer bits
			mStencilBits = bits;
		}

		/// <summary>
		/// Undefine RenderSurface stencil buffer.
		/// </summary>
		public void UndefineStencilBuffer()
		{
			// Undefine buffer
			UndefineBuffer(BufferType.Stencil);
			// Set depth buffer bits to 0
			mStencilBits = 0;
		}

		/// <summary>
		/// Stencil buffer bits.
		/// </summary>
		public uint StencilBits { get { return (mStencilBits); } }

		/// <summary>
		/// Stencil buffer bits.
		/// </summary>
		private uint mStencilBits;

		#endregion

		#region Multisample Buffer Definition

		/// <summary>
		/// Define RenderSurface multisample buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		public void DefineMultisampleBuffer(uint bits) { DefineMultisampleBuffer(bits, BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define RenderSurface multisample buffer.
		/// </summary>
		/// <param name="bits">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineMultisampleBuffer(uint bits, BufferPolicy policy)
		{
			if (bits == 0)
				throw new ArgumentException("zero bits", "bits");
			
			// Define buffer
			DefineBuffer(BufferType.Multisample, policy);
			// Set multisample bits
			mMultisampleBits = bits;
		}

		/// <summary>
		/// Undefine multisample buffer.
		/// </summary>
		public void UndefineMultisampleBuffer()
		{ 
			// Undefine buffer
			UndefineBuffer(BufferType.Multisample);
			// Set multisample bits to 0
			mMultisampleBits = 0;
		}

		/// <summary>
		/// Multisample buffer bits.
		/// </summary>
		public uint MultisampleBits { get { return (mMultisampleBits); } }

		/// <summary>
		/// Multisample buffer bits.
		/// </summary>
		private uint mMultisampleBits;

		#endregion

		#region Double Buffer Definition

		/// <summary>
		/// Define double buffered RenderSurface.
		/// </summary>
		public void DefineDoubleBuffers() { DefineDoubleBuffers(BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define double buffered RenderSurface.
		/// </summary>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineDoubleBuffers(BufferPolicy policy)
		{
			// Define buffer
			DefineBuffer(BufferType.Double, policy);
			// Set double buffer flag
			mDoubleBuffers = true;
		}

		/// <summary>
		/// Undefine double buffered RenderSurface.
		/// </summary>
		public void UndefineDoubleBuffers()
		{ 
			// Undefine buffer
			UndefineBuffer(BufferType.Double);
			// Reset double buffer flag
			mDoubleBuffers = false;
		}

		/// <summary>
		/// Double buffered surface.
		/// </summary>
		public bool DoubleBuffers { get { return (mDoubleBuffers); } }

		/// <summary>
		/// Double buffered surface.
		/// </summary>
		private bool mDoubleBuffers = true;

		#endregion

		#region Stereo Buffer Definition

		/// <summary>
		/// Define double buffered RenderSurface.
		/// </summary>
		public void DefineStereoBuffers() { DefineStereoBuffers(BufferPolicy.RequiredAndDegradable); }

		/// <summary>
		/// Define double buffered RenderSurface.
		/// </summary>
		/// <param name="policy">
		/// A <see cref="BufferPolicy"/>
		/// </param>
		public void DefineStereoBuffers(BufferPolicy policy)
		{
			// Define buffer
			DefineBuffer(BufferType.Stereo, policy);
			// Set stereo buffer flag
			mStereoBuffers = true;
		}

		/// <summary>
		/// Undefine double buffered RenderSurface.
		/// </summary>
		public void UndefineStereoBuffers()
		{
			// Undefine buffer
			UndefineBuffer(BufferType.Stereo);
			// Reset stereo buffer flag
			mStereoBuffers = false;
		}

		/// <summary>
		/// Stereo buffered surface.
		/// </summary>
		public bool StereoBuffers { get { return (mStereoBuffers); } }

		/// <summary>
		/// Stereo buffered surface.
		/// </summary>
		private bool mStereoBuffers;

		#endregion

		#region Clearing Flags

		/// <summary>
		/// Get the complete clear bit-mask for clearing all buffers defined by this configuration.
		/// </summary>
		public uint ClearMask
		{
			get
			{
				uint mask = 0;

				// Has color?
				if (HasBuffer(BufferType.Color) || HasBuffer(BufferType.ColorSRGB))
					mask |= Gl.COLOR_BUFFER_BIT;
				// Has depth?
				if (HasBuffer(BufferType.Depth))
					mask |= Gl.DEPTH_BUFFER_BIT;
				// Has Stencil?
				if (HasBuffer(BufferType.Stencil))
					mask |= Gl.STENCIL_BUFFER_BIT;

				return (mask);
			}
		}

		#endregion

		#region Device Pixel Format

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pFormat"></param>
		/// <returns></returns>
		public delegate bool ValidatePixelFormatDelegate(DevicePixelFormat pFormat);
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="System.Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat()
		{
			return (ChoosePixelFormat((ValidatePixelFormatDelegate)null));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation, but not requiring a device context.
		/// </summary>
		/// <param name="formatFilter">
		/// Delegate used for filtering pixel formats.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="System.Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat(ValidatePixelFormatDelegate formatFilter)
		{
			return (ChoosePixelFormat(GraphicsContext.CurrentCaps.WindowPixelFormats, formatFilter));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <param name="deviceContext">
		/// Surface device context.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="System.Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat(IDeviceContext deviceContext)
		{
			return (ChoosePixelFormat(deviceContext, null));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="IDeviceContext"/> used for selecting the surface pixel format.
		/// </param>
		/// <param name="formatFilter">
		/// Delegate used for filtering pixel formats.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="System.Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat(IDeviceContext deviceContext, ValidatePixelFormatDelegate formatFilter)
		{
			List<DevicePixelFormat> pFormats;

			try {
				// Logging in this case is not required (pixel formats 
				Logger.Enabled = false;
				// Request pixel formats for this device context
				pFormats = GraphicsContext.QueryPixelFormats(deviceContext);
			} finally {
				// Enable logging (even on exceptions)
				Logger.Enabled = true;
			}

			return (ChoosePixelFormat(pFormats, formatFilter));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <param name="pFormats">
		/// A <see cref="List{DevicePixelFormat}"/> specifying the actual available device formats.
		/// </param>
		/// <param name="formatFilter">
		/// Delegate used for filtering pixel formats.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="System.Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		private DevicePixelFormat ChoosePixelFormat(List<DevicePixelFormat> pFormats, ValidatePixelFormatDelegate formatFilter)
		{
			// Custom filtering
			if (formatFilter != null)
				pFormats.RemoveAll(delegate(DevicePixelFormat match) { return (formatFilter(match) == false); });

			#region Format Index

			// Select by specific format index
			if (FormatIndex >= 0) {
				DevicePixelFormat specificPixelFormat = pFormats.Find(delegate(DevicePixelFormat obj) {
					return (obj.FormatIndex == FormatIndex);
				});
				
				if (specificPixelFormat != null)
					return (specificPixelFormat);
				
				if (mFormatPolicy == BufferPolicy.Required)
					pFormats.Clear();		// Go thru other selections, failing with InvalidOperationException
			}

			#endregion

			#region Remove Incompatible Pixel Types

			// Select by color data type
			pFormats.RemoveAll(delegate(DevicePixelFormat match) {
				return (RequiredUnsignedPixel && !match.RgbaUnsigned) || (RequiredUnsignedPixel && !match.RgbaUnsigned);
			});

			#endregion

			#region Filter sRGB Formats

			// Filter sRGB color configurations
			if (IsRequiredBuffer(BufferType.ColorSRGB)) {
				bool degradable = IsDegradableBuffer(BufferType.ColorSRGB);
				int sRgbFormatCount = pFormats.FindAll(delegate(DevicePixelFormat match) {
					return (match.SRGBCapable);
				}).Count;

				if (degradable == false && sRgbFormatCount > 0) {
					pFormats.RemoveAll(delegate(DevicePixelFormat match) {
						return (!match.SRGBCapable || match.ColorBits == 0 || (!degradable && match.ColorBits < Pixel.GetPixelFormat(ColorType).PixelBits));
					});
				} else if (degradable == true) {
					pFormats.RemoveAll(delegate(DevicePixelFormat match) {
						return ((match.ColorBits == 0) || (!degradable && match.ColorBits < Pixel.GetPixelFormat(ColorType).PixelBits));
					});
				} else
					pFormats.Clear();
			} else if (IsRequiredBuffer(BufferType.Color)) {
				bool degradable = IsDegradableBuffer(BufferType.Color);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return ((match.ColorBits == 0) || (!degradable && match.ColorBits < Pixel.GetPixelFormat(ColorType).PixelBits));
				});
			}

			#endregion

			#region Filter Depth

			// Filter depth configurations
			if (IsRequiredBuffer(BufferType.Depth)) {
				bool degradable = IsDegradableBuffer(BufferType.Depth);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (match.DepthBits == 0 || (!degradable && match.DepthBits < DepthBits));
				});
			}

			#endregion

			#region Filter Stencil

			// Filter stencil configurations
			if (IsRequiredBuffer(BufferType.Stencil)) {
				bool degradable = IsDegradableBuffer(BufferType.Stencil);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (match.StencilBits == 0 || (!degradable && match.StencilBits < StencilBits));
				});
			}

			#endregion

			#region Filter Multisample

			// Filter multisample configurations
			if (IsRequiredBuffer(BufferType.Multisample)) {
				bool degradable = IsDegradableBuffer(BufferType.Multisample);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (/* match.MultisampleBits == 0 || */ (!degradable && match.MultisampleBits < MultisampleBits));
				});
			} else {
				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (match.MultisampleBits > 0);
				});
			}

			#endregion

			#region Filter Double Buffers

			// Filter double buffer configurations
			if (IsRequiredBuffer(BufferType.Double)) {
				bool degradable = IsDegradableBuffer(BufferType.Double);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (!match.DoubleBuffer /* && !degradable */);
				});
			} else {
				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (match.DoubleBuffer);
				});
			}

			#endregion

			// Filter stereo buffer configurations
			if (IsRequiredBuffer(BufferType.Stereo)) {
				bool degradable = IsDegradableBuffer(BufferType.Stereo);

				pFormats.RemoveAll(delegate(DevicePixelFormat match) {
					return (!degradable && match.StereoBuffer != StereoBuffers);
				});
			}

			if (pFormats.Count > 0) {
#if false
				if (Environment.OSVersion.Platform == PlatformID.Unix) {
					pFormats.RemoveAll(delegate(DevicePixelFormat match) {
						return (match.DoubleBuffer == false);
					});
				}
#endif
				// Prefer double buffered formats
				pFormats.Sort(delegate(DevicePixelFormat a, DevicePixelFormat b) {
					return (GetPixelFormatPriority(a).CompareTo(GetPixelFormatPriority(b)));
				});

				return (pFormats[0]);
			} else {
				StringBuilder sb = new StringBuilder();

				sb.Append("unable to find any suitable window pixel format with ");
				if (FormatIndex >= 0)
					sb.AppendFormat("Index={0},", FormatIndex);
				if (IsRequiredBuffer(BufferType.Color))
					sb.AppendFormat("Color={0},", ColorType);
				if (IsRequiredBuffer(BufferType.ColorSRGB))
					sb.AppendFormat("sRGB Color={0},", ColorType);
				if (IsRequiredBuffer(BufferType.Depth))
					sb.AppendFormat("Depth={0},", DepthBits);
				if (IsRequiredBuffer(BufferType.Stencil))
					sb.AppendFormat("Stencil={0},", StencilBits);
				if (IsRequiredBuffer(BufferType.Multisample))
					sb.AppendFormat("Multisample={0},", MultisampleBits);
				if (IsRequiredBuffer(BufferType.Double))
					sb.AppendFormat("DoubleBuffer={0},", DoubleBuffers);
				sb.Remove(sb.Length - 1, 1);

				throw new InvalidOperationException(sb.ToString());
			}
		}

		private int GetPixelFormatPriority(DevicePixelFormat pixelFormat)
		{
			int priority = 0;

			if (!IsRequiredBuffer(BufferType.Depth) && pixelFormat.DepthBits > 0)
				priority -= 1;
			if (!IsRequiredBuffer(BufferType.Stencil) && pixelFormat.StencilBits > 0)
				priority -= 1;
			if (!IsRequiredBuffer(BufferType.Multisample) && pixelFormat.MultisampleBits > 0)
				priority -= 1;

			if (pixelFormat.DoubleBuffer)
				priority += 3;

			return (priority);
		}

		/// <summary>
		/// Confirm pixel format assigned to this surface. XXX
		/// </summary>
		/// <param name="pFormat">
		/// A <see cref="DevicePixelFormat"/> defining the available surface buffers
		/// and their definitions.
		/// </param>
		/// <remarks>
		/// This routine shall be called after a successfull call to SetPixelFormat.
		/// </remarks>
		public void SetBufferConfiguration(DevicePixelFormat pFormat)
		{
			// Determine available buffers
			mSurfaceBuffers = 0;
			if (pFormat.ColorBits > 0) {
				if (pFormat.SRGBCapable == false)
					mSurfaceBuffers |= BufferType.Color;
				else
					mSurfaceBuffers |= BufferType.ColorSRGB;
			}
			if (pFormat.DepthBits > 0)
				mSurfaceBuffers |= BufferType.Depth;
			if (pFormat.StencilBits > 0)
				mSurfaceBuffers |= BufferType.Stencil;
			if (pFormat.MultisampleBits > 0)
				mSurfaceBuffers |= BufferType.Multisample;
			if (pFormat.DoubleBuffer == true)
				mSurfaceBuffers |= BufferType.Double;
			if (pFormat.StereoBuffer == true)
				mSurfaceBuffers |= BufferType.Stereo;

			// Store buffer definitions
			switch (pFormat.ColorBits) {
				case 8:
					mColorType = PixelLayout.RGB8;
					break;
				case 16:
					mColorType = PixelLayout.RGB16;
					break;
				case 24:
					mColorType = PixelLayout.RGB24;
					break;
				case 32:
					mColorType = PixelLayout.RGBA32;
					break;
				default:
					throw new InvalidOperationException("invalid pixel format composed by " + pFormat.ColorBits + " bits");
			}
			mDepthBits = (uint)pFormat.DepthBits;
			mStencilBits = (uint)pFormat.StencilBits;
			mMultisampleBits = (uint)pFormat.MultisampleBits;
			mDoubleBuffers = pFormat.DoubleBuffer;
			mStereoBuffers = pFormat.StereoBuffer;
		}

		#endregion

		#region Deep Copy

		/// <summary>
		/// Copy this RenderSurfaceFormat.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this RenderSurfaceFormat.
		/// </returns>
		public RenderSurfaceFormat Copy()
		{
			return ((RenderSurfaceFormat)MemberwiseClone());
		}

		#endregion
	}
}
