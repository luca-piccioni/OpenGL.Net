
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
using System.Text;

namespace OpenGL
{
	/// <summary>
	/// Pixel format description.
	/// </summary>
	[DebuggerDisplay(
		"DevicePixelFormat: " +
		"Idx={FormatIndex} Color={ColorBits} Depth={DepthBits} Stencil={StencilBits} DB={DoubleBuffer} " +
		"Ms={MultisampleBits} sRGB={SRGBCapable}"
	)]
	public sealed class DevicePixelFormat
	{
		#region Constructors

		/// <summary>
		/// Parameterless constructor.
		/// </summary>
		public DevicePixelFormat()
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="colorBits"></param>
		public DevicePixelFormat(int colorBits)
		{
			RgbaUnsigned = true;
			RenderWindow = true;
			ColorBits = colorBits;
		}

		#endregion

		#region Format Identification

		/// <summary>
		/// Pixel format index.
		/// </summary>
		public int FormatIndex;

		#endregion

		#region Pixel Type

		/// <summary>
		/// Flag indicating whether this pixel format provide canonical (normalized) unsigned integer RGBA color.
		/// </summary>
		public bool RgbaUnsigned;

		/// <summary>
		/// Flag indicating whether this pixel format provide RGBA color composed by single-precision floating-point.
		/// </summary>
		public bool RgbaFloat;

		#endregion

		#region Surfaces

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

		#endregion

		#region Double Buffering

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

		#endregion

		#region Buffers bits

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

		#endregion

#if !MONODROID

		#region Platform Specific (GLX)

		/// <summary>
		/// GLX framebuffer configuration (valid only for X11).
		/// </summary>
		/// <remarks>
		/// This value is obtained by calling Glx.GetFBConfigs or Glx.ChooseFBConfig.
		/// </remarks>
		internal IntPtr XFbConfig;

		/// <summary>
		/// GLX visual information (valid only for X11).
		/// </summary>
		/// <remarks>
		/// This value is obtained by GetVisualFromFBConfig using <see cref="XFbConfig"/>.
		/// </remarks>
		internal Glx.XVisualInfo XVisualInfo;

		#endregion

#endif

		#region Copy

		/// <summary>
		/// Copy this DevicePixelFormat
		/// </summary>
		/// <returns>
		/// It returns a <see cref="DevicePixelFormat"/> equals to this DevicePixelFormat.
		/// </returns>
		public DevicePixelFormat Copy()
		{
			return (DevicePixelFormat)MemberwiseClone();
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Represent this object with a String.
		/// </summary>
		/// <returns>
		/// Guess it.
		/// </returns>
		public override string ToString()
		{
			StringBuilder pixelType = new StringBuilder();

			if (RgbaUnsigned) pixelType.Append("U");
			if (RgbaFloat) pixelType.Append("F");
			if (SRGBCapable) pixelType.Append("s");

			StringBuilder surfaceType = new StringBuilder();

			if (RenderWindow) surfaceType.Append("W");
			if (RenderBuffer) surfaceType.Append("B");
			if (RenderPBuffer) surfaceType.Append("P");

			return $"Idx={FormatIndex} Pixel={pixelType} Color={ColorBits} Depth={DepthBits} Stencil={StencilBits} Ms={MultisampleBits} DB={DoubleBuffer}, Surface={surfaceType}";
		}

		#endregion
	}
}
