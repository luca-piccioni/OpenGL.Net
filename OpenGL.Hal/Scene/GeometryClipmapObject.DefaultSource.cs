
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
using System.Diagnostics;
using System.Drawing;

using OSGeo.GDAL;

namespace OpenGL.Scene
{
	public partial class GeometryClipmapObject
	{
		/// <summary>
		/// Default terrain elevation factory.
		/// </summary>
		private class DefaultTerrainElevationFactory : ITerrainElevationFactory
		{
			#region Constructors

			/// <summary>
			/// Static constructor.
			/// </summary>
			static DefaultTerrainElevationFactory()
			{
				try {
					Gdal.AllRegister();
				} catch {
					
				}
			}

			public DefaultTerrainElevationFactory(string databaseRoot, double lat, double lon, uint maxLod)
			{
				if (databaseRoot == null)
					throw new ArgumentNullException("databaseRoot");

				// Open the dataset.
				try {
					_DatabaseDataset = Gdal.OpenShared(databaseRoot, Access.GA_ReadOnly);

					if (_DatabaseDataset.RasterCount != 1)
						throw new NotSupportedException();

					DatabaseRoot = databaseRoot;

					using (Band band = _DatabaseDataset.GetRasterBand(1)) {
						switch (band.GetColorInterpretation()) {
							case ColorInterp.GCI_Undefined:
								switch (_DatabaseDataset.GetDriver().ShortName) {
									case "SRTMHGT":
									case "VRT":
										break;
									default:
										throw new NotSupportedException("unknown GDAL driver");
								}
								break;
							default:
								throw new NotSupportedException("unknown color interpretation");
						}
					}

					// Determine current position
					double[] datasetTransform = new double[6], datasetInvTransform = new double[6];
					_DatabaseDataset.GetGeoTransform(datasetTransform);
					Gdal.InvGeoTransform(datasetTransform, datasetInvTransform);

					double xCurrentPosition, yCurrentPosition;
					Gdal.ApplyGeoTransform(datasetInvTransform, lon, lat, out xCurrentPosition, out yCurrentPosition);

					// Let the higher levels to be pixel aligned
					int x = (int)Math.Floor(xCurrentPosition), y = (int)Math.Floor(yCurrentPosition);
					int maxLodStride = (int)Math.Pow(2.0, maxLod);

					x -= x % maxLodStride;
					y -= y % maxLodStride;

					x = Math.Max(x, 0);
					y = Math.Max(y, 0);

					Gdal.ApplyGeoTransform(datasetTransform, x, y, out lon, out lat);

					Latitude = lat;
					Longitude = lon;
				} catch {
					// Ensure GDAL object disposition
					if (_DatabaseDataset != null)
						_DatabaseDataset.Dispose();
					// Exception
					throw;
				}
			}

			#endregion

			#region Geographic Reference

			/// <summary>
			/// The root of the terrain elevation database.
			/// </summary>
			public readonly string DatabaseRoot;

			/// <summary>
			/// Dataset handle.
			/// </summary>
			private readonly Dataset _DatabaseDataset;

			/// <summary>
			/// Latitude coordinate, in degrees.
			/// </summary>
			public readonly double Latitude;

			/// <summary>
			/// Longitude coordinate, in degrees.
			/// </summary>
			public readonly double Longitude;

			#endregion

			#region ITerrainElevationFactory Implementation

			/// <summary>
			/// Creates the <see cref="ITerrainElevationSource"/> for the specified LOD.
			/// </summary>
			/// <param name="lod">
			/// A <see cref="UInt32"/> that specify the Level Of Detail of the terrain elevation data.
			/// </param>
			/// <param name="size">
			/// A <see cref="UInt32"/> that specify the size of the required terrain elevation source, in pixels, to be
			/// applied for both extents.
			/// </param>
			/// <param name="unitScale">
			/// A <see cref="Single"/> that specify the scale to be applied to a single terrain elevation fragment, in meters.
			/// </param>
			/// <returns>
			/// It returns a <see cref="ITerrainElevationSource"/> that satisfy the specified parameters.
			/// </returns>
			public ITerrainElevationSource CreateTerrainElevationSource(uint lod, uint size, float unitScale)
			{
				return (new DefaultTerrainElevationSource(_DatabaseDataset, Latitude, Longitude, size, lod, unitScale));
			}

			#endregion
		}

		/// <summary>
		/// Default terrain elevation source.
		/// </summary>
		private class DefaultTerrainElevationSource : ITerrainElevationSource
		{
			#region Constructors

			public DefaultTerrainElevationSource(Dataset databaseDataset, double lat, double lon, uint size, uint lod, float unitScale)
			{
				if (databaseDataset == null)
					throw new ArgumentNullException("databaseDataset");

				// IDisposable referenced
				_DatabaseDataset = databaseDataset;
				_DatabaseDataset.IncRef();

				// Determine current position
				double[] datasetTransform = new double[6], datasetInvTransform = new double[6];
				_DatabaseDataset.GetGeoTransform(datasetTransform);
				Gdal.InvGeoTransform(datasetTransform, datasetInvTransform);

				double xCurrentPosition, yCurrentPosition;
				Gdal.ApplyGeoTransform(datasetInvTransform, lon, lat, out xCurrentPosition, out yCurrentPosition);

				// Let the higher levels to be pixel aligned
				int x = (int)Math.Floor(xCurrentPosition), y = (int)Math.Floor(yCurrentPosition);
				
				_CurrentTexPosition = _OriginPosition = new Vertex2d(x, y);

				Latitude = lat;
				Longitude = lon;
				Lod = lod;
				UnitScale = unitScale;

				_TerrainElevation = new Image(PixelLayout.GRAY16S, size, size);
				_TerrainElevation.IncRef();
			}

			#endregion

			#region Geographic Reference

			/// <summary>
			/// 
			/// </summary>
			private readonly Dataset _DatabaseDataset;

			/// <summary>
			/// Latitude coordinate, in degrees.
			/// </summary>
			public double Latitude;

			/// <summary>
			/// Longitude coordinate, in degrees.
			/// </summary>
			public double Longitude;

			/// <summary>
			/// Level of detail requested for this terrain elevation source.
			/// </summary>
			public readonly uint Lod;

			/// <summary>
			/// 
			/// </summary>
			public readonly float UnitScale;

			/// <summary>
			/// The cartesian position within the terrain elevation dataset corresponding to the coordinates <see cref="Latitude"/> and
			/// <see cref="Longitude"/>. It corresponds with the world coordinate (0,0,0).
			/// </summary>
			private Vertex2d _OriginPosition;

			/// <summary>
			/// 
			/// </summary>
			private Vertex2d _CurrentViewPosition;

			/// <summary>
			/// 
			/// </summary>
			private Vertex2d _CurrentTexPosition;

			#endregion

			#region Terrain Elevation Management

			/// <summary>
			/// The updated terrain elevation.
			/// </summary>
			private Image _TerrainElevation;

			private bool _TerrainElevationInitialized;

			#endregion

			#region ITerrainElevationSource Implementation

			/// <summary>
			/// Get the terrain elevation map corresponding to the specified position.
			/// </summary>
			/// <param name="viewPosition">
			/// The <see cref="Vertex2d"/> that specify the current view position, using an absolute cartesian reference system.
			/// </param>
			/// <returns>
			/// It returns the <see cref="Image"/> that contains the terrain elevation data corresponding to <paramref name="viewPosition"/>.
			/// </returns>
			public Image GetTerrainElevationMap(Vertex2d viewPosition)
			{
				// Apply clipmap offset
				double lodUnitScale = Math.Pow(2.0, Lod) * UnitScale;
				Vertex2d texturePositionOffset = viewPosition - _CurrentViewPosition;

				texturePositionOffset /= lodUnitScale;

				// Determine whether an texture update is not required
				bool xNormOffset = texturePositionOffset.x > -1.0 && texturePositionOffset.x < 1.0;
				bool yNormOffset = texturePositionOffset.y > -1.0 && texturePositionOffset.y < 1.0;
				if (xNormOffset && yNormOffset && _TerrainElevationInitialized)
					return (null);

				// Discard fractional part, move towards zero
				texturePositionOffset = new Vertex2d(Math.Truncate(texturePositionOffset.x), Math.Truncate(texturePositionOffset.y));

				// Determine the dataset section to load
				Rectangle datasetSection = new Rectangle(0, 0, (int)_TerrainElevation.Width, (int)_TerrainElevation.Height);
				Vertex2d rasterPosition = _CurrentTexPosition + (texturePositionOffset * Math.Pow(2.0, Lod));

				double w2 = _TerrainElevation.Width / 2, h2 = _TerrainElevation.Height / 2;

				// Specify the LOD 0 size
				// Note: the dataset should have overviews, in order to make CPU friendly update
				w2 *= Math.Pow(2.0, Lod);
				h2 *= Math.Pow(2.0, Lod);

				double x1 = rasterPosition.x - w2, x2 = rasterPosition.x + w2;
				double y1 = rasterPosition.y - h2, y2 = rasterPosition.y + h2;

				datasetSection.X = (int)Math.Floor(x1);
				datasetSection.Y = (int)Math.Floor(y1);
				datasetSection.Width = (int)Math.Floor(x2 - x1);
				Debug.Assert(datasetSection.Width % _TerrainElevation.Width == 0);
				datasetSection.Height = (int)Math.Floor(y2 - y1);
				Debug.Assert(datasetSection.Height % _TerrainElevation.Height == 0);

				// Update current terrain elevation, following the updated position
				ImageCodecCriteria datasetCriteria = new ImageCodecCriteria();
				datasetCriteria.ImageSection = datasetSection;
				
				GdalImageCodecPlugin.Load_GrayIndex(_DatabaseDataset, 1, datasetCriteria, _TerrainElevation);

				// Update current positions
				_CurrentTexPosition = rasterPosition;
				_CurrentViewPosition = _CurrentViewPosition + (texturePositionOffset * lodUnitScale);;

				// Trace.TraceInformation("Texture LOD {0} reposition: {1}", Lod, _CurrentTexPosition);

				// Allow first time initialization
				_TerrainElevationInitialized = true;

				return (_TerrainElevation);
			}

			/// <summary>
			/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
			/// </summary>
			public void Dispose()
			{
				_TerrainElevation.DecRef();
				_DatabaseDataset.DecRef();
			}

			#endregion
		}
	}
}
