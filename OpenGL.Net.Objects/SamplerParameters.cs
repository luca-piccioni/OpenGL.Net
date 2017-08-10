
// Copyright (C) 2017 Luca Piccioni
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
