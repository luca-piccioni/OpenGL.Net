
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

using OpenGL.Collections;

namespace OpenGL.Scene
{
	/// <summary>
	/// Geometry clipmap implementation.
	/// </summary>
	public partial class GeometryClipmapObject
	{
		#region Elevation Textures

		/// <summary>
		/// 
		/// </summary>
		class ElevationTexture : Texture2d
		{
			#region Constructors

			/// <summary>
			/// Construct an ElevationTexture specifying the unique identifier of the elevation block.
			/// </summary>
			/// <param name="terrainBlock">
			/// 
			/// </param>
			public ElevationTexture(Terrain.ITerrainBlock terrainBlock)
			{
				TerrainBlock = terrainBlock;
			}

			#endregion

			#region Terrain Properties

			/// <summary>
			/// 
			/// </summary>
			public readonly Terrain.ITerrainBlock TerrainBlock;

			/// <summary>
			/// 
			/// </summary>
			public DateTime UpdateTime;

			#endregion

			#region Create

			/// <summary>
			/// 
			/// </summary>
			/// <param name="lod"></param>
			public void Create(uint lod)
			{
				using (Image lodImage = TerrainBlock.ExtractImage(lod)) {
					Create(lodImage, lod);
				}
			}

			#endregion
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="geoArea">
		/// 
		/// </param>
		/// <param name="precision">
		/// 
		/// </param>
		private void CreateElevationTextures(GeoTreeArea geoArea, Vertex2d precision)
		{
			foreach (Terrain.ITerrainBlock terrainBlock in Terrain.SelectElevationBlocks(geoArea)) {
				ElevationTexture elevationTexture;

				// COllect texture if not defined yet
				if (_ElevationTextures.TryGetValue(terrainBlock.Id, out elevationTexture)) {
					elevationTexture = new ElevationTexture(terrainBlock);
					LinkResource(elevationTexture);

					_ElevationTextures.Add(terrainBlock.Id, elevationTexture);
				}

				// Do not dispose texture
				elevationTexture.UpdateTime = DateTime.UtcNow;

				// Determine which LOD need to be present
				uint lod = 0;

				for (double lodPrecision = terrainBlock.TextelPrecision; precision.x > lodPrecision; lodPrecision /= 2.0, lod++);

				// Mipmap already loaded?
				if (_ElevationTexture.HasMipMapLevel(lod))
					continue;

				// Load mipmap
				elevationTexture.Create(lod);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private readonly Dictionary<Guid, ElevationTexture> _ElevationTextures = new Dictionary<Guid, ElevationTexture>();

		#endregion
	}
}
