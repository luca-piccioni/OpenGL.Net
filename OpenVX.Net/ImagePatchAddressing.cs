
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

using System.Runtime.InteropServices;

namespace OpenVX
{
	/// <summary>
	/// The addressing image patch structure is used by the Host only to address pixels in an image patch.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct ImagePatchAddressing
	{
		/// <summary>
		/// Width of patch in X dimension in pixels.
		/// </summary>
		public uint DimensionX;

		/// <summary>
		/// Height of patch in Y dimension in pixels.
		/// </summary>
		public uint DimensionY;

		/// <summary>
		/// Stride in X dimension in bytes.
		/// </summary>
		public int StrideX;

		/// <summary>
		/// Stride in Y dimension in bytes.
		/// </summary>
		public int StrideY;

		/// <summary>
		/// Scale of X dimension. For sub-sampled planes this is the scaling factor of the dimension of the plane in relation to
		/// the zero plane. Use <see cref="ScaleUnity"/> in the numerator.
		/// </summary>
		public uint ScaleX;

		/// <summary>
		/// Scale of Y dimension. For sub-sampled planes this is the scaling factor of the dimension of the plane in relation to
		/// the zero plane. Use <see cref="ScaleUnity"/> in the numerator.
		/// </summary>
		public uint ScaleY;

		/// <summary>
		/// Step of X dimension in pixels.
		/// </summary>
		public uint StepX;

		/// <summary>
		/// Step of Y dimension in pixels.
		/// </summary>
		public uint StepY;
	}
}
