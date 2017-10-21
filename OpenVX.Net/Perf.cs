
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

#pragma warning disable 169

using System.Runtime.InteropServices;

namespace OpenVX
{
	/// <summary>
	/// The performance measurement structure. The time or durations are in units of nano seconds.
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct Perf
	{
		/// <summary>
		/// Holds the last measurement.
		/// </summary>
		public ulong Tmp;

		/// <summary>
		/// Holds the first measurement in a set.
		/// </summary>
		public ulong Begin;

		/// <summary>
		/// Holds the last measurement in a set.
		/// </summary>
		public ulong End;

		/// <summary>
		/// Holds the summation of durations.
		/// </summary>
		public ulong Sum;

		/// <summary>
		/// Holds the average of the durations.
		/// </summary>
		public ulong Avg;

		/// <summary>
		/// Holds the minimum of the durations.
		/// </summary>
		public ulong Min;

		/// <summary>
		/// Holds the number of measurements.
		/// </summary>
		public ulong Num;

		/// <summary>
		/// Holds the maximum of the durations.
		/// </summary>
		public ulong Max;
	}
}
