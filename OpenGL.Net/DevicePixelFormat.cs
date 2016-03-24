
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
	/// Pixel format description.
	/// </summary>
	[DebuggerDisplay("DevicePixelFormat: Idx={FormatIndex} Color={ColorBits} Depth={DepthBits} Stencil={StencilBits} Ms={MultisampleBits} sRGB={SRGBCapable} DB={DoubleBuffer}")]
	public sealed class DevicePixelFormat
	{
		#region Pixel Format Information

		/// <summary>
		/// Pixel format index.
		/// </summary>
		public int FormatIndex;

		/// <summary>
		/// Flag indicating whether this pixel format provide canonical (normalized) unsigned integer RGBA color.
		/// </summary>
		public bool RgbaUnsigned;

		/// <summary>
		/// Flag indicating whether this pixel format provide RGBA color composed by single-precision floating-point.
		/// </summary>
		public bool RgbaFloat;

		/// <summary>
		/// Pixel format can be used for rendering on windows.
		/// </summary>
		public bool RenderWindow;

		/// <summary>
		/// Pixel format can be used for rendering on memory buffers.
		/// </summary>
		public bool RenderBuffer;

		/// <summary>
		/// Pixel format can be used for rendering on pixel buffer objects.
		/// </summary>
		public bool RenderPBuffer;

		/// <summary>
		/// Pixel format support double buffering.
		/// </summary>
		public bool DoubleBuffer;

		/// <summary>
		/// Method used for swapping back buffers (WGL only).
		/// </summary>
		/// <remarks>
		/// It can assume the values Wgl.SWAP_EXCHANGE, SWAP_COPY, or SWAP_UNDEFINED in the case DoubleBuffer is false.
		/// </remarks>
		public int SwapMethod;

		/// <summary>
		/// Pixel format support stereo buffering.
		/// </summary>
		public bool StereoBuffer;

		/// <summary>
		/// Color bits (without alpha).
		/// </summary>
		public int ColorBits;

		/// <summary>
		/// Red bits.
		/// </summary>
		public int RedBits;

		/// <summary>
		/// Green bits.
		/// </summary>
		public int GreenBits;

		/// <summary>
		/// Blue bits.
		/// </summary>
		public int BlueBits;

		/// <summary>
		/// Alpha bits.
		/// </summary>
		public int AlphaBits;

		/// <summary>
		/// Depth buffer bits.
		/// </summary>
		public int DepthBits;

		/// <summary>
		/// Stencil buffer bits.
		/// </summary>
		public int StencilBits;

		/// <summary>
		/// Multisample bits.
		/// </summary>
		public int MultisampleBits;

		/// <summary>
		/// sRGB conversion capability.
		/// </summary>
		public bool SRGBCapable;

		/// <summary>
		/// GLX framebuffer configuration (valid only for X11).
		/// </summary>
		/// <remarks>
		/// This value is obtained by calling Glx.GetFBConfigs or Glx.ChooseFBConfig.
		/// </remarks>
		public IntPtr XFbConfig;

		/// <summary>
		/// GLX visual information (valid only for X11).
		/// </summary>
		/// <remarks>
		/// This value is obtained by GetVisualFromFBConfig using <see cref="XFbConfig"/>.
		/// </remarks>
		public Glx.XVisualInfo XVisualInfo;

		#endregion
	}
}
