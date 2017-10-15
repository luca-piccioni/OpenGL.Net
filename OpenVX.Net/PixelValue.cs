
// Copyright (C) 2017 Luca Piccioni
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

using System.Runtime.InteropServices;

namespace OpenVX
{
	/// <summary>
	/// Union that describes the value of a pixel for any image format. Use the field corresponding to the image format.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct PixelValue
	{
		/// <summary>
		/// Pixel value for <see cref="DfImage.Rgb"/>.
		/// </summary>
		[FieldOffset(0)]
		public byte R;

		/// <summary>
		/// Pixel value for <see cref="DfImage.Rgb"/>.
		/// </summary>
		[FieldOffset(1)]
		public byte G;

		/// <summary>
		/// Pixel value for <see cref="DfImage.Rgb"/>.
		/// </summary>
		[FieldOffset(2)]
		public byte B;

		/// <summary>
		/// Pixel value for <see cref="DfImage.Rgb"/>.
		/// </summary>
		[FieldOffset(3)]
		public byte X;

		/// <summary>
		/// Pixel value for all YUV formats in <see cref="DfImage"/>.
		/// </summary>
		[FieldOffset(0)]
		public byte Y;

		/// <summary>
		/// Pixel value for all YUV formats in <see cref="DfImage"/>.
		/// </summary>
		[FieldOffset(1)]
		public byte U;

		/// <summary>
		/// Pixel value for all YUV formats in <see cref="DfImage"/>.
		/// </summary>
		[FieldOffset(2)]
		public byte V;

		/// <summary>
		/// Pixel value for <see cref="DfImage.U8"/>.
		/// </summary>
		[FieldOffset(0)]
		public byte U8;

		/// <summary>
		/// Pixel value for <see cref="DfImage.U16"/>.
		/// </summary>
		[FieldOffset(0)]
		public ushort U16;

		/// <summary>
		/// Pixel value for <see cref="DfImage.S16"/>.
		/// </summary>
		[FieldOffset(0)]
		public short S16;

		/// <summary>
		/// Pixel value for <see cref="DfImage.U32"/>.
		/// </summary>
		[FieldOffset(0)]
		public uint U32;

		/// <summary>
		/// Pixel value for <see cref="DfImage.S32"/>.
		/// </summary>
		[FieldOffset(0)]
		public int S32;
	}
}
