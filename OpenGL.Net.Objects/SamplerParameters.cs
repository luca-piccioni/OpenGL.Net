
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
		/// Minification filter property.
		/// </summary>
		public TextureMinFilter MinFilter
		{
			get { return (_MinFilter); }
			set
			{
				if (_MinFilter != value)
					_MinFilterDirty = true;
				_MinFilter = value;
			}
		}

		/// <summary>
		/// Minification filter.
		/// </summary>
		private TextureMinFilter _MinFilter = TextureMinFilter.NearestMipmapLinear;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _MinFilterDirty;

		/// <summary>
		/// Magnification filter property.
		/// </summary>
		public TextureMagFilter MagFilter
		{
			get { return (_MagFilter); }
			set
			{
				if (_MagFilter != value)
					_MagFilterDirty = true;
				_MagFilter = value;
			}
		}

		/// <summary>
		/// Magnification filter.
		/// </summary>
		private TextureMagFilter _MagFilter = TextureMagFilter.Linear;

		/// <summary>
		/// Flag for applying <see cref="_MagFilter"/> only if changes.
		/// </summary>
		private bool _MagFilterDirty;

		#endregion

		#region Wrap Mode

		/// <summary>
		/// Wrapping on texture S coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordS
		{
			get { return (_WrapS); }
			set
			{
				if (_WrapS != value)
					_WrapSDirty = true;
				_WrapS = value;
			}
		}

		/// <summary>
		/// Wrapping on S coordinate.
		/// </summary>
		private TextureWrapMode _WrapS = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapSDirty;

		/// <summary>
		/// Wrapping on texture T coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordT
		{
			get { return (_WrapT); }
			set
			{
				if (_WrapT != value)
					_WrapTDirty = true;
				_WrapT = value;
			}
		}

		/// <summary>
		/// Wrapping on T coordinate.
		/// </summary>
		private TextureWrapMode _WrapT = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapTDirty;

		/// <summary>
		/// Wrapping on texture R coordinate.
		/// </summary>
		public TextureWrapMode WrapCoordR
		{
			get { return (_WrapR); }
			set
			{
				if (_WrapR != value)
					_WrapRDirty = true;
				_WrapR = value;
			}
		}

		/// <summary>
		/// Wrapping on R coordinate.
		/// </summary>
		private TextureWrapMode _WrapR = TextureWrapMode.Repeat;

		/// <summary>
		/// Flag for applying <see cref="_MinFilter"/> only if changes.
		/// </summary>
		private bool _WrapRDirty;

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
			SamplerParameters samplerParameters = (SamplerParameters)MemberwiseClone();

			samplerParameters._MinFilterDirty = false;
			samplerParameters._MagFilterDirty = false;
			samplerParameters._WrapSDirty = false;
			samplerParameters._WrapRDirty = false;
			samplerParameters._WrapTDirty = false;

			return (samplerParameters);
		}

		#endregion

		#region Texture Unit Parameters

		internal void TexParameters(Sampler sampler)
		{
			if (_MinFilterDirty) {
				Gl.SamplerParameter(sampler.ObjectName, (int)TextureParameterName.TextureMinFilter, (int)MinFilter);
				_MinFilterDirty = false;
			}
			
			if (_MagFilterDirty) {
				Gl.SamplerParameter(sampler.ObjectName, (int)TextureParameterName.TextureMagFilter, (int)MagFilter);
				_MagFilterDirty = false;
			}
			
			if (_WrapRDirty) {
				Gl.SamplerParameter(sampler.ObjectName, (int)TextureParameterName.TextureWrapR, (int)WrapCoordR);
				_WrapRDirty = false;
			}
			
			if (_WrapSDirty) {
				Gl.SamplerParameter(sampler.ObjectName, (int)TextureParameterName.TextureWrapS, (int)WrapCoordS);
				_WrapSDirty = false;
			}
			
			if (_WrapTDirty) {
				Gl.SamplerParameter(sampler.ObjectName, (int)TextureParameterName.TextureWrapT, (int)WrapCoordT);
				_WrapTDirty = false;
			}
		}

		#endregion
	}
}
