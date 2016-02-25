
// Copyright (C) 2016 Luca Piccioni
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
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using OSGeo.GDAL;

using OpenGL.Collections;

namespace OpenGL.Scene
{
	/// <summary>
	/// Terrain database abstraction.
	/// </summary>
	public static class Terrain
	{
		#region Constructors

		/// <summary>
		/// Static constructor.
		/// </summary>
		static Terrain()
		{
			GdalImageCodecPlugin.AllRegister();
		}

		#endregion

		/// <summary>
		/// Query information about a dataset modeling terrain information.
		/// </summary>
		/// <param name="databaseRootPath">
		/// A <see cref="String"/> that specify the path of the directory containins the terrain information.
		/// </param>
		/// /// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="databaseRootPath"/> is null.
		/// </exception>
		public static void Query(string databaseRootPath)
		{
			if (databaseRootPath == null)
				throw new ArgumentNullException("databasePath");

			string[] datasetFiles = Directory.GetFiles(databaseRootPath, "*.*", SearchOption.AllDirectories);

			foreach (string datasetPath in datasetFiles) {
				try {
					using (Dataset dataset = Gdal.OpenShared(datasetPath, Access.GA_ReadOnly)) {
						// Determine terrain dataset information and collect it
						switch (dataset.GetDriver().ShortName) {
							// Elevation datasets
							case "EHdr":        // USGS DEM
								if (datasetPath.ToLowerInvariant().EndsWith(".dem") == false)
									continue;
								_GeoElevationTree.Insert(new GeoElevationTerrainDataset(datasetPath, dataset));
								break;
							case "SRTMHGT":		// USGS SRTM
								_GeoElevationTree.Insert(new GeoElevationTerrainDataset(datasetPath, dataset));
								break;
							default:
								throw new NotSupportedException(String.Format("driver {0} is not supported"));
						}
					}
				} catch (Exception exception) {

				}
			}
		}

		public static void GenerateMipmaps(int lod)
		{

		}

		/// <summary>
		/// Geographic dataset.
		/// </summary>
		[DebuggerDisplay("GeoTerrainDataset: Position={Position} Size={Size}")]
		class GeoTerrainDataset : IGeoTreeNode
		{
			#region Constructors

			/// <summary>
			/// Construct a GeoTerrainDataset defining the database path.
			/// </summary>
			/// <param name="datasetPath">
			/// A <see cref="String"/> that specify the dataset path.
			/// </param>
			/// <param name="dataset">
			/// The <see cref="Dataset"/> corresponding to <paramref name="datasetPath"/>. This parameters is not
			/// hold by this instance.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="datasetPath"/> or <paramref name="dataset"/> are null.
			/// </exception>
			public GeoTerrainDataset(string datasetPath, Dataset dataset)
			{
				if (datasetPath == null)
					throw new ArgumentNullException("datasetPath");
				if (dataset == null)
					throw new ArgumentNullException("dataset");

				Path = datasetPath;

				ExtractGeoInformation(dataset, new Rectangle(0, 0, dataset.RasterXSize, dataset.RasterYSize));
				ExtractBlockInformation(dataset);
			}

			/// <summary>
			/// Construct a custom GeoTerrainDataset.
			/// </summary>
			/// <param name="parent">
			/// A <see cref="GeoTerrainDataset"/> that specify the parent dataset creating this instance.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="parent"/> is null.
			/// </exception>
			protected GeoTerrainDataset(GeoTerrainDataset parent)
			{
				if (parent == null)
					throw new ArgumentNullException("parent");

				Debug.Assert(parent.Path != null);
				Path = parent.Path;
			}

			#endregion

			#region Dataset Information

			/// <summary>
			/// Dataset path.
			/// </summary>
			public readonly string Path;

			/// <summary>
			/// Extract all information required from the specified dataset.
			/// </summary>
			/// <param name="dataset">
			/// The <see cref="Dataset"/> from which the information must be extracted.
			/// </param>
			protected void ExtractGeoInformation(Dataset dataset, Rectangle area)
			{
				if (dataset == null)
					throw new ArgumentNullException("dataset");

				// Geographic area
				// Geographic area
				double[] geoTransform = new double[6];
				double[] lat = new double[2], lon = new double[2];

				dataset.GetGeoTransform(geoTransform);
				Gdal.ApplyGeoTransform(geoTransform, area.Left, area.Bottom, out lon[0], out lat[0]);
				Gdal.ApplyGeoTransform(geoTransform, area.Right, area.Top, out lon[1], out lat[1]);

				Latitude = (lat[0] + lat[1]) / 2.0;
				Longitude = (lon[0] + lon[1]) / 2.0;
				Width = Math.Abs(lat[0] - lat[1]);
				Height = Math.Abs(lon[0] - lon[1]);

				// Textel precision
				double w1 = Vincenty.GetDistance(new Vertex2d(lon[0], lat[0]), new Vertex2d(lon[1], lat[0]));
				double w2 = Vincenty.GetDistance(new Vertex2d(lon[0], lat[1]), new Vertex2d(lon[1], lat[1]));
				double h1 = Vincenty.GetDistance(new Vertex2d(lon[0], lat[0]), new Vertex2d(lon[0], lat[1]));
				double h2 = Vincenty.GetDistance(new Vertex2d(lon[1], lat[0]), new Vertex2d(lon[1], lat[1]));

				double wp = ((w1 + w2) / 2.0) / (double)area.Width;
				double hp = ((h1 + h2) / 2.0) / (double)area.Height;

				_TextelPrecision = (wp + hp) / 2.0;

				
			}

			#endregion

			#region Geographic References

			/// <summary>
			/// Position of the center of the dataset, in degrees using geodedic coordinates.
			/// </summary>
			public Vertex2d Position;

			/// <summary>
			/// Longitude of the center of the dataset, in degrees.
			/// </summary>
			public double Longitude
			{
				get { return (Position.x); }
				set { Position.x = value; }
			}

			/// <summary>
			/// Latitude of the center of the dataset, in degrees.
			/// </summary>
			public double Latitude
			{
				get { return (Position.y); }
				set { Position.y = value; }
			}

			/// <summary>
			/// Size of the dataset, 
			/// </summary>
			public Vertex2d Size;

			/// <summary>
			/// Width of the of the dataset, in degrees.
			/// </summary>
			public double Width
			{
				get { return (Size.x); }
				set { Size.x = value; }
			}

			/// <summary>
			/// Height of the dataset, in degrees.
			/// </summary>
			public double Height
			{
				get { return (Size.y); }
				set { Size.y = value; }
			}

			#endregion

			#region Blocks

			/// <summary>
			/// Blocks defined for this geographic dataset.
			/// </summary>
			public IEnumerable<GeoTerrainDataset> Blocks { get { return (_Blocks); } }

			/// <summary>
			/// Get the size of the blocks composing the dataset.
			/// </summary>
			public Vertex2i BlockSize { get { return (_BlockSize); } }

			/// <summary>
			/// Extract all information required from the specified dataset.
			/// </summary>
			/// <param name="dataset">
			/// The <see cref="Dataset"/> from which the information must be extracted.
			/// </param>
			protected void ExtractBlockInformation(Dataset dataset)
			{
				if (dataset == null)
					throw new ArgumentNullException("dataset");

				// Block size
				using (Band datasetBand = dataset.GetRasterBand(1)) {
					datasetBand.GetBlockSize(out _BlockSize.x, out _BlockSize.y);

					// Do not expose "rows": find a suitable block size
					if (_BlockSize.x == 1 || _BlockSize.y == 1) {
						const int DefaultBlockSize = 2048;

						int blockSize = Math.Min(DefaultBlockSize, GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize);

						_BlockSize = new Vertex2i(blockSize, blockSize);
					}

					_BlockSize.x = Math.Min(_BlockSize.x, GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize);
					_BlockSize.y = Math.Min(_BlockSize.y, GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize);
				}

				// Cache blocks definitions
				_Blocks = new List<GeoTerrainDataset>();
				for (int x = 0; x < dataset.RasterXSize; x += _BlockSize.x) {
					for (int y = 0; y < dataset.RasterYSize; y += _BlockSize.y) {
						int wBlock = _BlockSize.x, hBlock = _BlockSize.y;

						if (x + wBlock > dataset.RasterXSize)
							wBlock = dataset.RasterXSize - x;
						if (y + hBlock > dataset.RasterYSize)
							hBlock = dataset.RasterYSize - y;

						_Blocks.Add(new GeoTerrainDatasetBlock(this, dataset, new Rectangle(x, y, wBlock, hBlock)));
					}
				}
			}

			/// <summary>
			/// Size of the blocks composing the dataset.
			/// </summary>
			private Vertex2i _BlockSize;

			/// <summary>
			/// Cached list of blocks defining this dataset.
			/// </summary>
			private List<GeoTerrainDataset> _Blocks;

			#endregion

			#region Precision

			/// <summary>
			/// Get the average precision of a dataset textel, in meters.
			/// </summary>
			private double TextelPrecision { get { return (_TextelPrecision); } }

			/// <summary>
			/// The average precision of a dataset textel, in meters.
			/// </summary>
			private double _TextelPrecision;

			#endregion

			#region Mipmapping



			#endregion

			#region IGeoTreeNode Implementation

			/// <summary>
			/// Get the identifier of the geographic node.
			/// </summary>
			Guid IGeoTreeNode.Id { get { return (_Id); } }

			/// <summary>
			/// Get the geographic area covered by this node.
			/// </summary>
			GeoTreeArea IGeoTreeNode.Area { get { return (new GeoTreeArea(Position, Size)); } }

			/// <summary>
			/// Created on fly.
			/// </summary>
			private readonly Guid _Id = Guid.NewGuid();

			#endregion
		}

		/// <summary>
		/// Geographic dataset block.
		/// </summary>
		class GeoTerrainDatasetBlock : GeoTerrainDataset
		{
			#region Constructors

			/// <summary>
			/// Construct a GeoTerrainDataset defining the database path.
			/// </summary>
			/// <param name="parent">
			/// A <see cref="GeoTerrainDataset"/> that specify the parent dataset creating this instance.
			/// </param>
			/// <param name="dataset">
			/// The <see cref="Dataset"/> corresponding to <paramref name="datasetPath"/>. This parameters is not
			/// hold by this instance.
			/// </param>
			/// <param name="area">
			/// 
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="parent"/> or <paramref name="dataset"/> are null.
			/// </exception>
			public GeoTerrainDatasetBlock(GeoTerrainDataset parent, Dataset dataset, Rectangle area) : base(parent)
			{
				if (dataset == null)
					throw new ArgumentNullException("dataset");

				ExtractGeoInformation(dataset, area);
			}

			#endregion
		}

		/// <summary>
		/// Geographic dataset holding elevation information.
		/// </summary>
		class GeoElevationTerrainDataset : GeoTerrainDataset
		{
			#region Constructors

			/// <summary>
			/// Construct a GeoElevationTerrainDataset defining the database path.
			/// </summary>
			/// <param name="datasetPath">
			/// A <see cref="String"/> that specify the dataset path.
			/// </param>
			/// <param name="dataset">
			/// The <see cref="Dataset"/> corresponding to <paramref name="datasetPath"/>. This parameters is not
			/// hold by this instance.
			/// </param>
			/// <exception cref="ArgumentNullException">
			/// Exception thrown if <paramref name="datasetPath"/> or <paramref name="dataset"/> are null.
			/// </exception>
			public GeoElevationTerrainDataset(string datasetPath, Dataset dataset) :
				base(datasetPath, dataset)
			{
				
			}

			#endregion
		}

		/// <summary>
		/// The <see cref="GeoTree{GeoElevationTerrainDataset}"/> indexing known elevation data.
		/// </summary>
		/// <remarks>
		/// The subdivisions are targeted to reach 1 deg of granularity.
		/// Using longitude (as larger area to partition), 360 is less than 2^9; indeed recommended depth is 9. Final leaf
		/// node covers 0.70 x 0.35 degrees. Maybe lower depths have acceptable performances.
		/// </remarks>
		private static readonly GeoTree<GeoElevationTerrainDataset> _GeoElevationTree = new GeoTree<GeoElevationTerrainDataset>(8);
	}
}
