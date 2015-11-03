
// Copyright (C) 2009-2011 Luca Piccioni
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//   
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Diagnostics;

using Derm.Render;

namespace Derm.Raster
{
	/// <summary>
	/// Layered image.
	/// </summary>
	/// <remarks>
	/// </remarks>
	public class LayerImage<T> : Image where T : IColor, new()
	{
		#region Constructor & Destructor

		/// <summary>
		/// Construct a LayerImage.
		/// </summary>
		public LayerImage() : this(0, 0)
		{

		}

		/// <summary>
		/// Construct a LayerImage specifying the image extents.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/> that specifies the width of the image.
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/> that specifies the height of the image.
		/// </param>
		public LayerImage(uint w, uint h) : this(w, h, 1, 1)
		{

		}

		/// <summary>
		/// Construct a LayerImage specifying the image extents and chrominance layers sampling.
		/// </summary>
		public LayerImage(uint w, uint h, uint xsamples, uint ysamples)
		{
			// Store image extents
			Width = w; Height = h;
			// Store sampling factors
			mLayerXSamples = xsamples;
			mLayerYSamples = ysamples;

			// Allocate pixel data
			AllocatePixelData(Width, Height);
		}

		#endregion

		#region Image Buffer Management

		/// <summary>
		/// Allocate pixel data buffer.
		/// </summary>
		/// <param name="w">
		/// A <see cref="System.Int32"/>
		/// </param>
		/// <param name="h">
		/// A <see cref="System.Int32"/>
		/// </param>
		public override void AllocatePixelData(uint w, uint h)
		{
			// Determine pixel size
			mPixelSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(T));

			// Store image extents
			Width = w; Height = h;
			// Allocate room for pixel data
			if ((w > 0) && (h > 0)) {
				// Allocate layers
				mImage = new T[LAYER_COUNT][,];
				// Allocate layers data: main layer
				mImage[0] = new T[w, h];
				// Allocate layers data: additional layers
				for (int i = 0; i < LAYER_COUNT; i++)
					mImage[i] = new T[w / mLayerXSamples, h / mLayerYSamples];
			} else
				mImage = null;
		}

		/// <summary>
		/// Number of layers composing this LayerImage.
		/// </summary>
		protected const int LAYER_COUNT = 3;

		/// <summary>
		/// LayerImage pixel data.
		/// </summary>
		protected T[][,] mImage = null;

		#endregion

		#region Layer Sampling

		/// <summary>
		/// Chrominance horizontal sampling.
		/// </summary>
		public uint XSampling { get { return (mLayerXSamples); } }

		/// <summary>
		/// Chrominance vertical sampling.
		/// </summary>
		public uint YSampling { get { return (mLayerYSamples); } }

		/// <summary>
		/// Width sampling of layers composing this LayerImage.
		/// </summary>
		protected uint mLayerXSamples = 1;
		/// <summary>
		/// Height sampling of layers composing this LayerImage.
		/// </summary>
		protected uint mLayerYSamples = 1;

		#endregion

		#region Image Implementation

		/// <summary>
		/// Image pixel format.
		/// </summary>
		/// <returns>
		/// It returns a <see cref="Pixel.Type"/> that specifies the image color resolution.
		/// </returns>
		public override Pixel.Type PixelFormat
		{
			get {
				return (Pixel.Type.RGB24);		// XXX
			}
		}

		/// <summary>
		/// Pixel data buffer.
		/// </summary>
		public override object GetPixelData(uint layer)
		{
			return (mImage[layer]);
		}

		/// <summary>
		/// Pixel data accessor.
		/// </summary>
		/// <param name="layer">
		/// A <see cref="System.Int32"/> indicating the layer to fetch pixel data.
		/// </param>
		/// <param name="x">
		/// A <see cref="System.Int32"/> indicating the horizontal coordinate of the pixel. The
		/// left corners has the coordinate 0.
		/// </param>
		/// <param name="y">
		/// A <see cref="System.Int32"/> indicating the vertical coordinate of the pixel. The
		/// bottom corners has the coordinate 0.
		/// </param>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// <para>
		/// This indexer allow an uniform access to the Image pixel data. Since the data could be stored
		/// in many data types (see <see cref="Pixel.Type"/> enumeration), the only color type able to
		/// map every possible value is the <see cref="ColorRGBAF"/>.
		/// </para>
		/// </remarks>
		public override IColor this[uint layer, uint x, uint y]
		{
			get {
				return (mImage[layer][y, x]);
			}
			set {
				T pProto = new T();
			}
		}

		#endregion
	}
}

