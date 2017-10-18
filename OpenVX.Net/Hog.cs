
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

#pragma warning disable 169

namespace OpenVX
{
	/// <summary>
	/// The HOG descriptor structure.
	/// </summary>
	public struct Hog
	{
		/// <summary>
		/// The histogram cell width.
		/// </summary>
		public int CellWidth;

		/// <summary>
		/// The histogram cell height.
		/// </summary>
		public int CellHeight; 

		/// <summary>
		/// The histogram block width. Must be divisible by <see cref="CellWidth"/>.
		/// </summary>
		public int BlockWidth;

		/// <summary>
		/// The histogram block height. Must be divisible by CellHeight.
		/// </summary>
		public int BlockHeight;

		/// <summary>
		/// The histogram block stride within the window . Must be an integral number of CellWidth and CellHeight.
		/// </summary>
		public int BlockStride;

		/// <summary>
		/// The histogram size.
		/// </summary>
		public int NumBins;

		/// <summary>
		/// The feature descriptor window width.
		/// </summary>
		public int WindowWidth;

		/// <summary>
		///  The feature descriptor window height.
		/// </summary>
		public int WindowHeight;

		/// <summary>
		/// The feature descriptor window stride.
		/// </summary>
		public int WindowStride;

		/// <summary>
		/// The threshold for the minimum L2 value for a histogram bin used in block normalization, default is 0.2.
		/// </summary>
		public float Threshold;
	}
}
