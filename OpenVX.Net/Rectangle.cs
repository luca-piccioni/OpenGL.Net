
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
	/// The rectangle data structure that is shared with the users. The area of the rectangle can be computed as (end_x-start_x)*(end_y-start_y)
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Rectangle
	{
		/// <summary>
		/// The Start X coordinate.
		/// </summary>
		public uint StartX;

		/// <summary>
		/// The Start Y coordinate.
		/// </summary>
		public uint StartY;

		/// <summary>
		/// The End X coordinate.
		/// </summary>
		public uint EndX;

		/// <summary>
		/// The End Y coordinate.
		/// </summary>
		public uint EndY;
	}
}
