
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// ReSharper disable InheritdocConsiderUsage
// ReSharper disable ConvertIfStatementToReturnStatement

namespace OpenGL
{
	/// <summary>
	/// List of pixel format descriptions.
	/// </summary>
	[DebuggerDisplay("DevicePixelFormatCollection: Count={" + nameof(Count) + "}")]
	public class DevicePixelFormatCollection : List<DevicePixelFormat>
	{
		/// <summary>
		/// Choose a <see cref="DevicePixelFormat"/>
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specify the minimum requirements
		/// </param>
		/// <returns></returns>
		public List<DevicePixelFormat> Choose(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException(nameof(pixelFormat));

			List<DevicePixelFormat> pixelFormats = new List<DevicePixelFormat>(this);

			pixelFormats.RemoveAll(delegate (DevicePixelFormat item) {

				if (pixelFormat.RgbaUnsigned != item.RgbaUnsigned)
					return true;
				if (pixelFormat.RgbaFloat  != item.RgbaFloat)
					return true;

				if (pixelFormat.RenderWindow && !item.RenderWindow)
					return true;
				if (pixelFormat.RenderPBuffer && !item.RenderPBuffer)
					return true;
				if (pixelFormat.RenderBuffer && !item.RenderBuffer)
					return true;

				if (item.ColorBits < pixelFormat.ColorBits)
					return true;
				if (item.RedBits < pixelFormat.RedBits)
					return true;
				if (item.GreenBits < pixelFormat.GreenBits)
					return true;
				if (item.BlueBits < pixelFormat.BlueBits)
					return true;
				if (item.AlphaBits < pixelFormat.AlphaBits)
					return true;

				if (item.DepthBits < pixelFormat.DepthBits)
					return true;
				if (item.StencilBits < pixelFormat.StencilBits)
					return true;
				if (item.MultisampleBits < pixelFormat.MultisampleBits)
					return true;

				if (pixelFormat.DoubleBuffer && !item.DoubleBuffer)
					return true;

				if (pixelFormat.SRGBCapable && !item.SRGBCapable)
					return true;

				return false;
			});

			List<DevicePixelFormat> pixelFormatsCopy = pixelFormats.Select(devicePixelFormat => devicePixelFormat.Copy()).ToList();

			// Sort (ascending by resource occupation)
			pixelFormatsCopy.Sort(delegate (DevicePixelFormat x, DevicePixelFormat y) {
				int compare;

				if ((compare = x.ColorBits.CompareTo(y.ColorBits)) != 0)
					return compare;
				if ((compare = x.DepthBits.CompareTo(y.DepthBits)) != 0)
					return compare;
				if ((compare = x.StencilBits.CompareTo(y.StencilBits)) != 0)
					return compare;
				if ((compare = x.MultisampleBits.CompareTo(y.MultisampleBits)) != 0)
					return compare;

				if ((compare = y.DoubleBuffer.CompareTo(x.DoubleBuffer)) != 0)
					return compare;

				return 0;
			});

			return pixelFormatsCopy;
		}

		/// <summary>
		/// Try to guess why <see cref="Choose(DevicePixelFormat)"/> is not returning any pixel format.
		/// </summary>
		/// <param name="pixelFormat">
		/// A <see cref="DevicePixelFormat"/> that specify the minimum requirements
		/// </param>
		/// <returns>
		/// It returns a string indicating the actual reason behind a failure in pixel format selection using <paramref name="pixelFormat"/>.
		/// </returns>
		public string GuessChooseError(DevicePixelFormat pixelFormat)
		{
			if (pixelFormat == null)
				throw new ArgumentNullException(nameof(pixelFormat));

			List<DevicePixelFormat> pixelFormats = new List<DevicePixelFormat>(this);

			pixelFormats.RemoveAll(delegate (DevicePixelFormat item) {
				if (pixelFormat.RgbaUnsigned != item.RgbaUnsigned)
					return true;
				if (pixelFormat.RgbaFloat != item.RgbaFloat)
					return true;

				return false;
			});
			if (pixelFormats.Count == 0)
				return $"no RGBA pixel type matching (RGBAui={pixelFormat.RgbaUnsigned}, RGBAf={pixelFormat.RgbaFloat})";

			pixelFormats.RemoveAll(delegate (DevicePixelFormat item) {
				if (pixelFormat.RenderWindow && !item.RenderWindow)
					return true;
				if (pixelFormat.RenderPBuffer && !item.RenderPBuffer)
					return true;
				if (pixelFormat.RenderBuffer && !item.RenderBuffer)
					return true;

				return false;
			});

			if (pixelFormats.Count == 0)
				return
					$"no surface matching (Window={pixelFormat.RenderWindow}, PBuffer={pixelFormat.RenderPBuffer}, RenderBuffer={pixelFormat.RenderBuffer})";

			pixelFormats.RemoveAll(delegate (DevicePixelFormat item) {
				if (item.ColorBits < pixelFormat.ColorBits)
					return true;
				if (item.RedBits < pixelFormat.RedBits)
					return true;
				if (item.GreenBits < pixelFormat.GreenBits)
					return true;
				if (item.BlueBits < pixelFormat.BlueBits)
					return true;
				if (item.AlphaBits < pixelFormat.AlphaBits)
					return true;

				return false;
			});

			if (pixelFormats.Count == 0)
				return
					$"no color bits combination matching ({pixelFormat.ColorBits} bits, {{{pixelFormat.RedBits}|{pixelFormat.BlueBits}|{pixelFormat.GreenBits}|{pixelFormat.AlphaBits}}})";

			pixelFormats.RemoveAll(item => item.DepthBits < pixelFormat.DepthBits);
			if (pixelFormats.Count == 0)
				return $"no depth bits matching (Depth >= {pixelFormat.DepthBits})";

			pixelFormats.RemoveAll(item => item.StencilBits < pixelFormat.StencilBits);
			if (pixelFormats.Count == 0)
				return $"no stencil bits matching (Bits >= {pixelFormat.StencilBits})";

			pixelFormats.RemoveAll(item => item.MultisampleBits < pixelFormat.MultisampleBits);
			if (pixelFormats.Count == 0)
				return $"no multisample bits matching (Samples >= {pixelFormat.MultisampleBits})";

			pixelFormats.RemoveAll(item => pixelFormat.DoubleBuffer && !item.DoubleBuffer);
			if (pixelFormats.Count == 0)
				return $"no double-buffer matching (DB={pixelFormat.DoubleBuffer})";

			pixelFormats.RemoveAll(item => pixelFormat.SRGBCapable && !item.SRGBCapable);
			if (pixelFormats.Count == 0)
				return $"no sRGB matching (sRGB={pixelFormat.SRGBCapable})";
			
			return "no error";
		}

		/// <summary>
		/// Copy this DevicePixelFormatCollection.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="DevicePixelFormatCollection"/> equivalent to this DevicePixelFormatCollection.
		/// </returns>
		public DevicePixelFormatCollection Copy()
		{
			DevicePixelFormatCollection pixelFormats = new DevicePixelFormatCollection();

			pixelFormats.AddRange(this.Select(devicePixelFormat => devicePixelFormat.Copy()));

			return pixelFormats;
		}
	}
}
