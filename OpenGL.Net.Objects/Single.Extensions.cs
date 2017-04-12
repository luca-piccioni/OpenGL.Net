
  // Copyright (C) 2009-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// Extension method for <see cref="Single"/> based typed.
	/// </summary>
	public static class SingleExtensions
	{
		/// <summary>
		/// Convert a <see cref="Single[]"/> to <see cref="Vertex4f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="Vertex4f[]"/> equivalent to <paramref name="array"/>.
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
		/// Convert a <see cref="Single[]"/> to <see cref="Vertex3f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="Vertex3f[]"/> equivalent to <paramref name="array"/>.
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
		/// Convert a <see cref="Single[]"/> to <see cref="Vertex2f[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="Vertex2f[]"/> equivalent to <paramref name="array"/>.
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
		/// Convert a <see cref="Single[]"/> to <see cref="ColorRGBAF[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="ColorRGBAF[]"/> equivalent to <paramref name="array"/>.
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
		/// Convert a <see cref="Single[]"/> to <see cref="ColorRGBF[]"/>.
		/// </summary>
		/// <param name="array">
		/// The <see cref="Single[]"/> to be converted.
		/// </param>
		/// <returns>
		/// It returns the <see cref="ColorRGBF[]"/> equivalent to <paramref name="array"/>.
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
