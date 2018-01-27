
// Copyright (C) 2018 Luca Piccioni
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
using System.Diagnostics.CodeAnalysis;

namespace OpenGL
{
	/// <summary>
	/// Extensions for <see cref="double"/>.
	/// </summary>
	[SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
	public static class DoubleExtensions
	{
		/// <summary>
		/// Indicates whether the this <see cref="double"/> is relatively equal to another <see cref="double"/>.
		/// </summary>
		/// <param name="other">
		/// The <see cref="double"/> to compare with this float.
		/// </param>
		/// <param name="precision">
		/// The <see cref="double"/> that specifies the relative error tollerance, intended as fraction of the range.
		/// </param>
		/// <returns>
		/// It returns true if the this float is relatively equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public static bool RelativelyEquals(this double thisValue, double value, double epsilon)
		{
			double absA = Math.Abs(thisValue);
			double absB = Math.Abs(value);
			double diff = Math.Abs(thisValue - value);

			if (thisValue == value)
				return true;

			if (thisValue == 0.0f || value == 0.0f || diff < double.Epsilon) 
				return diff < epsilon;
			
			return diff / (absA + absB) < epsilon;
		}
	}
}
