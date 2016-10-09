
// Copyright (C) 2012-2015 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Pixel color space.
	/// </summary>
	public enum PixelSpace
	{
		/// <summary>
		/// Grayscale.
		/// </summary>
		Red,
		/// <summary>
		/// Gray scale and Alpha.
		/// </summary>
		GrayAlpha,
		/// <summary>
		/// RGB.
		/// </summary>
		Rgb,
		/// <summary>
		/// sRGB.
		/// </summary>
		sRgb,
		/// <summary>
		/// sBGR.
		/// </summary>
		sBgr,
		/// <summary>
		/// RGB and Alpha
		/// </summary>
		Rgba,
		/// <summary>
		/// Linear BGR.
		/// </summary>
		Bgr,
		/// <summary>
		/// BGR and Alpha.
		/// </summary>
		Bgra,
		/// <summary>
		/// Luminance/chrominance.
		/// </summary>
		YUV,
		/// <summary>
		/// Cyan, Magenta and Yellow.
		/// </summary>
		CMY,
		/// <summary>
		/// Cyan, Magenta, Yellow and Black.
		/// </summary>
		CMYK,
		/// <summary>
		/// Cyan, Magenta, Yellow, Black and Alpha.
		/// </summary>
		CMYKA,
		/// <summary>
		/// Depth.
		/// </summary>
		Depth,
		/// <summary>
		/// Combined depth/stencil.
		/// </summary>
		DepthStencil,
		/// <summary>
		/// Integral integer texture.
		/// </summary>
		Integer,
	}
}

