
// MIT License
// 
// Copyright (c) 2017 Luca Piccioni
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

namespace OpenVX
{
	/// <summary>
	/// Input parameters for a convolution operation.
	/// </summary>
	public struct NnConvolutionParams
	{
		/// <summary>
		/// Number of elements added at each side in the x dimension of the input.
		/// </summary>
		public uint PaddingX;

		/// <summary>
		/// Number of elements added at each side in the y dimension of the input.
		/// </summary>
		public uint PaddingY;

		/// <summary>
		/// 
		/// </summary>
		public ConvertPolicy OverflowPolicy;

		/// <summary>
		/// 
		/// </summary>
		public RoundPolicy RoundingPolicy;

		/// <summary>
		/// Rounding method for calculating output dimensions.
		/// </summary>
		public int DownScaleSizeRounding; /*!< \brief  See <tt>\ref vx_nn_rounding_type_e</tt> */

		/// <summary>
		/// “inflate” the kernel by inserting zeros between the kernel elements in the x direction.
		/// The value is the number of zeros to insert.
		/// </summary>
		public uint DilationX;

		/// <summary>
		/// “inflate” the kernel by inserting zeros between the kernel elements in the y direction.
		/// The value is the number of zeros to insert.
		/// </summary>
		public uint DilationY;
	}
}
