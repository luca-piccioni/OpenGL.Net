
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
using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// Sampler parameters.
	/// </summary>
	public class SamplerParameters
	{
		#region Filtering

		/// <summary>
		/// Minification filter.
		/// </summary>
		public TextureMinFilter MinFilter = TextureMinFilter.NearestMipmapLinear;

		/// <summary>
		/// Magnification filter.
		/// </summary>
		public TextureMagFilter MagFilter = TextureMagFilter.Linear;

		#endregion

		#region Wrap Mode

		/// <summary>
		/// Wrapping on S coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordS = TextureWrapMode.Repeat;

		/// <summary>
		/// Wrapping on T coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordT = TextureWrapMode.Repeat;

		/// <summary>
		/// Wrapping on R coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordR = TextureWrapMode.Repeat;

		#endregion

		#region Comparison Mode

		/// <summary>
		/// Enable texture compararison.
		/// </summary>
		public bool CompareMode;

		/// <summary>
		/// Texture comparison function.
		/// </summary>
		public DepthFunction CompareFunc = DepthFunction.Lequal;

		#endregion

		#region Cloning

		/// <summary>
		/// Clone this SamplerParameters.
		/// </summary>
		/// <returns>
		/// It returns a clone of this SamplerParameters.
		/// </returns>
		public SamplerParameters Clone()
		{
			return ((SamplerParameters)MemberwiseClone());
		}

		#endregion
	}
}
