
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Extension method for <see cref="Single"/> based typed.
	/// </summary>
	public static class SingleExtensions
	{
		/// <summary>
		/// Convert a <see cref="T:Single[]"/> to <see cref="T:Vertex4f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="T:Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="T:Vertex4f[]"/> equivalent to <paramref name="array"/>.
		/// </returns>
		public static Vertex4f[] ToVertex4f(this float[] array)
		{
			int structArrayLength = array.Length / 4;
			Vertex4f[] structArray = new Vertex4f[structArrayLength];

			for (int i = 0, j = 0; i < structArrayLength; i++, j += 4)
				structArray[i] = new Vertex4f(array[j + 0], array[j + 1], array[j + 2], array[j + 3]);

			return (structArray);
		}

		/// <summary>
		/// Convert a <see cref="T:Single[]"/> to <see cref="T:Vertex3f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="T:Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="T:Vertex3f[]"/> equivalent to <paramref name="array"/>.
		/// </returns>
		public static Vertex3f[] ToVertex3f(this float[] array)
		{
			int structArrayLength = array.Length / 3;
			Vertex3f[] structArray = new Vertex3f[structArrayLength];

			for (int i = 0, j = 0; i < structArrayLength; i++, j += 3)
				structArray[i] = new Vertex3f(array[j + 0], array[j + 1], array[j + 2]);

			return (structArray);
		}

		/// <summary>
		/// Convert a <see cref="T:Single[]"/> to <see cref="T:Vertex2f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="T:Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="T:Vertex2f[]"/> equivalent to <paramref name="array"/>.
		/// </returns>
		public static Vertex2f[] ToVertex2f(this float[] array)
		{
			int structArrayLength = array.Length / 2;
			Vertex2f[] structArray = new Vertex2f[structArrayLength];

			for (int i = 0, j = 0; i < structArrayLength; i++, j += 2)
				structArray[i] = new Vertex2f(array[j + 0], array[j + 1]);

			return (structArray);
		}

		/// <summary>
		/// Convert a <see cref="T:Single[]"/> to <see cref="T:ColorRGBAF[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="T:Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="T:ColorRGBAF[]"/> equivalent to <paramref name="array"/>.
		/// </returns>
		public static ColorRGBAF[] ToColorRGBAF(this float[] array)
		{
			int structArrayLength = array.Length / 4;
			ColorRGBAF[] structArray = new ColorRGBAF[structArrayLength];

			for (int i = 0, j = 0; i < structArrayLength; i++, j += 4)
				structArray[i] = new ColorRGBAF(array[j + 0], array[j + 1], array[j + 2], array[j + 3]);

			return (structArray);
		}

		/// <summary>
		/// Convert a <see cref="T:Single[]"/> to <see cref="T:ColorRGBF[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="T:Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="T:ColorRGBF[]"/> equivalent to <paramref name="array"/>.
		/// </returns>
		public static ColorRGBF[] ToColorRGBF(this float[] array)
		{
			int structArrayLength = array.Length / 3;
			ColorRGBF[] structArray = new ColorRGBF[structArrayLength];

			for (int i = 0, j = 0; i < structArrayLength; i++, j += 3)
				structArray[i] = new ColorRGBF(array[j + 0], array[j + 1], array[j + 2]);

			return (structArray);
		}
	}
}
