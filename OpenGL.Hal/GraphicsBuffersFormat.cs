
// Copyright (C) 2011-2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Surface pixel format configuration.
	/// </summary>
	[DebuggerDisplay("GraphicsBuffersFormat: Color={ColorType} Depth={DepthBits} Stencil={StencilBits} MS={MultisampleBits} DB={DoubleBuffers}")]
	public sealed class GraphicsBuffersFormat
	{
		#region Constructors

		/// <summary>
		/// Default surface format (any).
		/// </summary>
		public GraphicsBuffersFormat()
		{

		}

		/// <summary>
		/// Surface format with specified color (no depth, no stencil, no multisample, no double/stereo buffering).
		/// </summary>
		/// <param name="color">
		/// A <see cref="PixelLayout"/> that specify the format of the color buffer.
		/// </param>
		public GraphicsBuffersFormat(PixelLayout color) :
			this(color, 0)
		{
			
		}

		/// <summary>
		/// Surface format with specified color (no depth, no stencil, no multisample, no double/stereo buffering).
		/// </summary>
		/// <param name="color">
		/// A <see cref="PixelLayout"/> that specify the format of the color buffer.
		/// </param>
		/// <param name="depth">
		/// 
		/// </param>
		public GraphicsBuffersFormat(PixelLayout color, uint depth)
		{
			_ColorType = color;
			_DepthBits = depth;
		}

		#endregion

		#region Buffer Type

		/// <summary>
		/// Get a mask of surface buffers.
		/// </summary>
		public GraphicsBufferType BuffersMask
		{
			get
			{
				GraphicsBufferType buffersMask = _SurfaceBuffers;

				if (_DepthBits > 0)
					buffersMask |= GraphicsBufferType.Depth;
				if (_StencilBits > 0)
					buffersMask |= GraphicsBufferType.Stencil;
				if (_MultisampleBits > 0)
					buffersMask |= GraphicsBufferType.Multisample;

				return (_SurfaceBuffers);
			}
		}

		/// <summary>
		/// Double buffering.
		/// </summary>
		public bool DoubleBuffers
		{
			get { return ((_SurfaceBuffers & GraphicsBufferType.Double) != 0); }
			set { if (value) _SurfaceBuffers |= GraphicsBufferType.Double; else _SurfaceBuffers &= ~GraphicsBufferType.Double; }
		}

		/// <summary>
		/// Get the complete clear bit-mask for clearing all buffers defined by this configuration.
		/// </summary>
		public uint ClearMask
		{
			get
			{
				uint mask = 0;

				// Has color?
				if ((BuffersMask & GraphicsBufferType.Color) != 0)
					mask |= Gl.COLOR_BUFFER_BIT;
				// Has depth?
				if ((BuffersMask & GraphicsBufferType.Depth) != 0)
					mask |= Gl.DEPTH_BUFFER_BIT;
				// Has Stencil?
				if ((BuffersMask & GraphicsBufferType.Stencil) != 0)
					mask |= Gl.STENCIL_BUFFER_BIT;

				return (mask);
			}
		}

		/// <summary>
		/// Surface buffers. 
		/// </summary>
		private GraphicsBufferType _SurfaceBuffers = GraphicsBufferType.Color | GraphicsBufferType.Double;

		#endregion
		
		#region Buffers Definition

		/// <summary>
		/// Color buffer pixel format.
		/// </summary>
		public PixelLayout ColorType
		{
			get { return (_ColorType); }
			set { _ColorType = value; }
		}

		/// <summary>
		/// Determine whether the surface configuration required an unsigned integer (normalized) pixel.
		/// </summary>
		private bool RequiredUnsignedPixel { get { return (Pixel.IsGlUnsignedPixel(ColorType)); } }

		/// <summary>
		/// Determine whether the surface configuration required a floating-point pixel.
		/// </summary>
		private bool RequiresFloatPixel { get { return (Pixel.IsGlFloatPixel(ColorType)); } }

		/// <summary>
		/// Color buffer pixel format.
		/// </summary>
		private PixelLayout _ColorType = PixelLayout.None;

		/// <summary>
		/// Minimum bits required for each color component, including alpha component.
		/// </summary>
		private Vertex4ui _ColorBits = new Vertex4ui();

		/// <summary>
		/// Depth buffer bits.
		/// </summary>
		public uint DepthBits
		{
			get { return (_DepthBits); }
			set { _DepthBits = value; }
		}

		/// <summary>
		/// Depth buffer bits.
		/// </summary>
		private uint _DepthBits;

		/// <summary>
		/// Stencil buffer bits.
		/// </summary>
		public uint StencilBits
		{
			get { return (_StencilBits); }
			set { _StencilBits = value; }
		}

		/// <summary>
		/// Stencil buffer bits.
		/// </summary>
		private uint _StencilBits;

		/// <summary>
		/// Multisample buffer bits.
		/// </summary>
		public uint MultisampleBits
		{
			get { return (_MultisampleBits); }
			set { _MultisampleBits = value; }
		}

		/// <summary>
		/// Multisample buffer bits.
		/// </summary>
		private uint _MultisampleBits;

		#endregion

		#region ChoosePixelFormat

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pFormat"></param>
		/// <returns></returns>
		public delegate bool ValidBuffersFormatDelegate(DevicePixelFormat pFormat);
		
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
		/// <exception cref="Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat(DeviceContext deviceContext)
		{
			return (ChoosePixelFormat(deviceContext, null));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <param name="deviceContext">
		/// A <see cref="DeviceContext"/> used for selecting the surface pixel format.
		/// </param>
		/// <param name="formatFilter">
		/// Delegate used for filtering pixel formats.
		/// </param>
		/// <returns>
		/// <para>
		/// It returns the closest macthing pixel format to this Surface configuration.
		/// </para>
		/// </returns>
		/// <exception cref="Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		public DevicePixelFormat ChoosePixelFormat(DeviceContext deviceContext, ValidBuffersFormatDelegate formatFilter)
		{
			if (deviceContext == null)
				throw new ArgumentNullException("deviceContext");

			return (ChoosePixelFormat(deviceContext.PixelsFormats, formatFilter));
		}
		
		/// <summary>
		/// Obtain best macthing surface configuration supported by actual implementation.
		/// </summary>
		/// <param name="pixelFormats">
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
		/// <exception cref="Exception">
		/// This exception is thrown when no pixel format was found for matching surface buffer
		/// configuration using the specified buffer policy.
		/// </exception>
		/// <remarks>
		/// Each system offer a limited number of possible configuration, which has to be choosen to
		/// allocated correctly a system Surface.
		/// These pixel formats are fetched during the static constructor of <see cref="GraphicsContext"/>,
		/// and this routine selects one of the available pixel format.
		/// </remarks>
		private DevicePixelFormat ChoosePixelFormat(DevicePixelFormatCollection pixelFormats, ValidBuffersFormatDelegate formatFilter)
		{
			if (pixelFormats == null)
				throw new ArgumentNullException("pFormats");

			// Custom filtering
			if (formatFilter != null)
				pixelFormats.RemoveAll(delegate(DevicePixelFormat match) { return (formatFilter(match) == false); });

			// Filter
			pixelFormats.RemoveAll(delegate(DevicePixelFormat match) {
				if ((RequiredUnsignedPixel && !match.RgbaUnsigned) || (RequiredUnsignedPixel && !match.RgbaUnsigned))
					return (true);
				if (match.RedBits < _ColorBits.x || match.GreenBits < _ColorBits.y || match.BlueBits < _ColorBits.z || match.AlphaBits < _ColorBits.w)
					return (true);
				if (((BuffersMask & GraphicsBufferType.Double) != 0) && !match.DoubleBuffer)
					return (true);
				if (match.DepthBits < _DepthBits)
					return (true);
				if (match.StencilBits < _StencilBits)
					return (true);
				if (match.MultisampleBits < _MultisampleBits)
					return (true);

				return (false);
			});

			if (pixelFormats.Count > 0) {
#if false
				if (Environment.OSVersion.Platform == PlatformID.Unix) {
					pFormats.RemoveAll(delegate(DevicePixelFormat match) {
						return (match.DoubleBuffer == false);
					});
				}
#endif
				pixelFormats.Sort(delegate(DevicePixelFormat a, DevicePixelFormat b) {
					int comp;

					if ((comp = a.DoubleBuffer.CompareTo(b.DoubleBuffer)) != 0)
						return (comp);
					if ((comp = a.ColorBits.CompareTo(b.ColorBits)) != 0)
						return (comp);
					if ((comp = a.DepthBits.CompareTo(b.DepthBits)) != 0)
						return (comp);
					if ((comp = a.MultisampleBits.CompareTo(b.MultisampleBits)) != 0)
						return (comp);
					if ((comp = a.StencilBits.CompareTo(b.StencilBits)) != 0)
						return (comp);

					return (a.FormatIndex.CompareTo(b.FormatIndex));
				});

				return (pixelFormats[0]);
			} else {
				StringBuilder sb = new StringBuilder();

				sb.Append("unable to find any suitable window pixel format with ");
				if ((BuffersMask & GraphicsBufferType.Color) != 0)
					sb.AppendFormat("Color={0},", ColorType);
				if ((BuffersMask & GraphicsBufferType.ColorSRGB) != 0)
					sb.AppendFormat("sRGB Color={0},", ColorType);
				if (DepthBits > 0)
					sb.AppendFormat("Depth={0},", DepthBits);
				if (StencilBits > 0)
					sb.AppendFormat("Stencil={0},", StencilBits);
				if (MultisampleBits > 0)
					sb.AppendFormat("Multisample={0},", MultisampleBits);
				if ((BuffersMask & GraphicsBufferType.Double) != 0)
					sb.AppendFormat("DoubleBuffer,");
				sb.Remove(sb.Length - 1, 1);

				throw new InvalidOperationException(sb.ToString());
			}
		}

		/// <summary>
		/// Confirm pixel format assigned to this surface. XXX
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> defining the available surface buffers
		/// and their definitions.
		/// </param>
		/// <remarks>
		/// This routine shall be called after a successfull call to SetPixelFormat.
		/// </remarks>
		public void SetBufferConfiguration(DevicePixelFormat pixelFormat)
		{
			_SurfaceBuffers = 0;

			if (pixelFormat.ColorBits > 0) {
				if (pixelFormat.SRGBCapable == false)
					_SurfaceBuffers |= GraphicsBufferType.Color;
				else
					_SurfaceBuffers |= GraphicsBufferType.ColorSRGB;
			}

			if (pixelFormat.DoubleBuffer)
				_SurfaceBuffers |= GraphicsBufferType.Double;
			if (pixelFormat.DepthBits > 0)
				_SurfaceBuffers |= GraphicsBufferType.Depth;
			if (pixelFormat.StencilBits > 0)
				_SurfaceBuffers |= GraphicsBufferType.Stencil;
			if (pixelFormat.MultisampleBits > 0)
				_SurfaceBuffers |= GraphicsBufferType.Multisample;

			switch (pixelFormat.ColorBits) {
				case 8:
					_ColorType = PixelLayout.RGB8;
					break;
				case 16:
					_ColorType = PixelLayout.RGB16;
					break;
				case 24:
					_ColorType = PixelLayout.RGB24;
					break;
				case 32:
					_ColorType = PixelLayout.RGBA32;
					break;
				default:
					throw new InvalidOperationException("invalid pixel format composed by " + pixelFormat.ColorBits + " bits");
			}

			_DepthBits = (uint)pixelFormat.DepthBits;

			_StencilBits = (uint)pixelFormat.StencilBits;

			_MultisampleBits = (uint)pixelFormat.MultisampleBits;
		}

		#endregion

		#region Deep Copy

		/// <summary>
		/// Copy this RenderSurfaceFormat.
		/// </summary>
		/// <returns>
		/// It returns a deep copy of this RenderSurfaceFormat.
		/// </returns>
		public GraphicsBuffersFormat Copy()
		{
			return ((GraphicsBuffersFormat)MemberwiseClone());
		}

		#endregion
	}
}
