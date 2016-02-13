
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

#define CLIPMAP_COLOR_DEBUG

#define CLIPMAP_CAP

#define POSITION_CORRECTION

#define TEXTURING_ELEVATION

#undef CULLING_CLIPMAP_CAP

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL.Scene
{
	/// <summary>
	/// Geometry clipmap implementation.
	/// </summary>
	public partial class GeometryClipmapObject : SceneGraphObject
	{
		#region Constructors

		/// <summary>
		/// Construct a GeometryClipmapObject.
		/// </summary>
		/// <param name="rank">
		/// A <see cref="UInt16"/> that specify the number of LODs composing this GeometryClipmapObject using a logarithmic scale.
		/// </param>
		/// <param name="levels">
		/// A <see cref="UInt16"/> that specify the number of levels to draw.
		/// </param>
		/// <param name="unit">
		/// A <see cref="Single"/> that specify the size of a single quad unit.
		/// </param>
		public GeometryClipmapObject(ushort rank, ushort levels, float unit)
		{
			if (GraphicsContext.CurrentCaps.GlExtensions.InstancedArrays == false)
				throw new NotSupportedException();
			if (PrimitiveRestart.IsPrimitiveRestartSupported() == false)
				throw new NotSupportedException();

			// Clipmap properties
			ClipmapVertices = (uint)Math.Pow(2.0, Math.Max(rank, 4.0)) - 1;
			BlockVertices = (ClipmapVertices + 1) / 4;
			ClipmapLevels = levels;
			BlockQuadUnit = unit;

			// Define clipmap resources
			_ClipmapLevels = new ClipmapLevel[levels];
			// Default the elevation sources (defaults to no sources)
			_TerrainElevationSources = new ITerrainElevationSource[ClipmapLevels];
			// Define geometry clipmap program
			_GeometryClipmapProgram = ShadersLibrary.Instance.CreateProgram("GeometryClipmap");
			LinkResource(_GeometryClipmapProgram);
			// Create elevation texture
			uint elevationTextureSize = ClipmapVertices + 1;

			// Clamp texture size, if necessary
			if (elevationTextureSize > GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize)
				elevationTextureSize = (uint)GraphicsContext.CurrentCaps.Limits.MaxTexture2DSize;

			_ElevationTexture = new TextureArray2d(elevationTextureSize, elevationTextureSize, ClipmapLevels, PixelLayout.GRAYF);
			_ElevationTexture.MinFilter = Texture.Filter.Nearest;
			_ElevationTexture.MagFilter = Texture.Filter.Nearest;
			_ElevationTexture.WrapCoordR = Texture.Wrap.Clamp;
			_ElevationTexture.WrapCoordS = Texture.Wrap.Clamp;
			LinkResource(_ElevationTexture);

			// Define geometry clipmap vertex arrays
			CreateVertexArrays();
		}

		#endregion

		#region Definition

		/// <summary>
		/// The number of vertices composing a line of the clipmap level.
		/// </summary>
		public readonly uint ClipmapVertices;

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap level.
		/// </summary>
		private uint ClipmapSubdivs { get { return (ClipmapVertices - 1); } }

		/// <summary>
		/// The number of vertices composing a line of the clipmap block.
		/// </summary>
		public readonly uint BlockVertices;

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap block.
		/// </summary>
		private uint BlockSubdivs { get { return (BlockVertices - 1); } }

		/// <summary>
		/// Get the number of vertices composing a line of the clipmap level exterior.
		/// </summary>
		private uint ExteriorVertices { get { return (ClipmapVertices + 4); } }

		/// <summary>
		/// Get the number of subdivisions composing a line of the clipmap level exterior.
		/// </summary>
		private uint ExteriorSubdivs { get { return (ExteriorVertices - 1); } }

		/// <summary>
		/// Number of levels composing this geometry clipmap.
		/// </summary>
		public readonly ushort ClipmapLevels;

		/// <summary>
		/// The world units that occupy a single quad of a block.
		/// </summary>
		public readonly float BlockQuadUnit;

		#endregion

		#region Geometry Clipmap Levels

		/// <summary>
		/// Geometry clipmap level abstarction.
		/// </summary>
		private class ClipmapLevel : IDisposable
		{
			#region Constructors

			/// <summary>
			/// Construct a ClipmapLevel.
			/// </summary>
			/// <param name="texture">
			/// The <see cref="TextureArray2d"/> holding the elevation data for every clipmap.
			/// </param>
			/// <param name="lod">
			/// A <see cref="UInt32"/> that specify texture array LOD.
			/// </param>
			public ClipmapLevel(TextureArray2d texture, uint lod)
			{
				if (texture == null)
					throw new ArgumentNullException("texture");
				if (texture.Height < lod)
					throw new ArgumentOutOfRangeException("lod", "exceed clipmap levels");

				Texture = texture;
				Texture.IncRef();
				Lod = lod;
			}

			#endregion

			#region Level Information

			/// <summary>
			/// The underlying texture array storing clipmap elevation data.
			/// </summary>
			public readonly TextureArray2d Texture;

			/// <summary>
			/// The Level Of Detail of the texture (i.e. the texture array level).
			/// </summary>
			public readonly uint Lod;

			#endregion

			#region IDisposable Implementation

			/// <summary>
			/// Dispose resources.
			/// </summary>
			public void Dispose()
			{
				Texture.DecRef();
			}

			#endregion
		}

		/// <summary>
		/// Clipmap levels abstraction.
		/// </summary>
		private readonly ClipmapLevel[] _ClipmapLevels;

		public bool PositionCorrection
		{
			get { return (_PositionCorrection); }
			set
			{
				_PositionCorrection = value;
			}
		}

		private bool _PositionCorrection = true;

		#endregion

		#region Geometry Clipmap Blocks

		/// <summary>
		/// Geometry clipmap instanced attribute.
		/// </summary>
		/// <remarks>
		/// Each Clipmap block defines instanced attributes for the geometry clipmap block.
		/// </remarks>
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct ClipmapBlockInstance
		{
			#region Constructors

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit) :
				this(n, m, x, y, lod, unit, new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f))
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			/// <param name="color">
			/// The debugging color of the block.
			/// </param>
			public ClipmapBlockInstance(uint n, uint m, int x, int y, uint lod, float unit, ColorRGBAF color) :
				this(n, m, m, x, y, lod, unit, color)
			{

			}

			/// <summary>
			/// Construct a ClipmapBlock.
			/// </summary>
			/// <param name="n">
			/// Number of vertices composing the clipmap level (used for texturing).
			/// </param>
			/// <param name="m">
			/// The number of vertices defining the block area normalized in the range [0.0, 1.0].
			/// </param>
			/// <param name="x">
			/// The offset on X axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="y">
			/// The offset on Z axis of the lower-left corner of the block, in block quad units (position and texturing).
			/// </param>
			/// <param name="lod">
			/// The Level Of Detail of the block (determine which clipmap level is included into, indeed the scale factor).
			/// </param>
			/// <param name="unit">
			/// The unit of a block quad (scale factor).
			/// </param>
			/// <param name="color">
			/// The debugging color of the block.
			/// </param>
			public ClipmapBlockInstance(uint n, uint mw, uint mh, int x, int y, uint lod, float unit, ColorRGBAF color)
			{
				if (mw < 2)
					throw new ArgumentOutOfRangeException("mw");
				if (mh < 2)
					throw new ArgumentOutOfRangeException("mh");

				float scale = (float)Math.Pow(2.0, lod) * unit;

				// Position offset and scale
				Offset = new Vertex4f(x, y, mw - 1, mh - 1) * scale;		// Position is always build on clipmap grid
				// Texture coordinate offset and scale
				float texNormalizedSize = (1.0f - (1.0f / (n + 1)));

				float clipmapLevelSize = (float)(n - 1);
				float clipmapLevelSize2 = clipmapLevelSize / 2.0f;
				float x1TexOffset = (x + clipmapLevelSize2) / clipmapLevelSize;
				float y1TexOffset = (y + clipmapLevelSize2) / clipmapLevelSize;

				float x2TexOffset = (x + mw - 1 + clipmapLevelSize2) / clipmapLevelSize;
				float y2TexOffset = (y + mh - 1 + clipmapLevelSize2) / clipmapLevelSize;

				float xTexScale = (float)(mw - 1) / (n + 1);
				float yTexScale = (float)(mh - 1) / (n + 1);

				MapOffset = new Vertex4f(x1TexOffset, y1TexOffset, xTexScale, yTexScale) * texNormalizedSize;
				// LOD
				Lod = new Vertex2f(lod, lod);
				// Instance color
#if CLIPMAP_COLOR_DEBUG
				BlockColor = color;
#else
				BlockColor = new ColorRGBAF(1.0f, 1.0f, 1.0f, 1.0f);
#endif
			}

			#endregion

			#region Level Of Detail

			public void SetTextureLod(uint n, uint lod)
			{
				float texNormalizedSizeLod0 = (1.0f - (1.0f / (n + 1)));
				float texNormalizedSizeLod1 = (1.0f - (1.0f / ((n + 1) * 2)));

				// LOD - access to coarser texture, but mantains the position offset/scale
				// Note: because this, we need Linear filter for texturing for this block
				Lod = new Vertex2f(Lod.X + 1.0f, Lod.Y);
				// Scale to next LOD
				Vertex4f mapOffset = MapOffset / texNormalizedSizeLod0;		// Normalize in range [0.0,1.0]

				float x = (mapOffset.X + 0.5f) / 2.0f;
				float y = (mapOffset.Y + 0.5f) / 2.0f;
				float x2 = ((mapOffset.X + mapOffset.Z) + 0.5f) / 2.0f;
				float y2 = ((mapOffset.Y + mapOffset.W) + 0.5f) / 2.0f;

				MapOffset = new Vertex4f(x, y, (x2 - x) / texNormalizedSizeLod0, (y2 - y) / texNormalizedSizeLod0) * texNormalizedSizeLod0;
			}

			#endregion

			#region Structure

			/// <summary>
			/// Position offset (XY) and scale (ZW).
			/// </summary>
			public Vertex4f Offset;

			/// <summary>
			/// Texture coordinate offset (XY) and scale (ZW).
			/// </summary>
			public Vertex4f MapOffset;

			/// <summary>
			/// The texture level of detail.
			/// </summary>
			public Vertex2f Lod;

			/// <summary>
			/// Debugging color for instancing.
			/// </summary>
			public ColorRGBAF BlockColor;

			#endregion
		}

		/// <summary>
		/// Blocks array.
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesClipmapBlock = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (horizontal).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesRingFixH = new List<ClipmapBlockInstance>(), _InstancesRingFixV = new List<ClipmapBlockInstance>();

		/// <summary>
		/// Ring fix (vertical).
		/// </summary>
		private readonly List<ClipmapBlockInstance> _InstancesExteriorH = new List<ClipmapBlockInstance>(), _InstancesExteriorV = new List<ClipmapBlockInstance>();

		#endregion

		#region Elevation Texture Update

		/// <summary>
		/// Factory pattern interface for creating <see cref="ITerrainElevationSource"/> instances.
		/// </summary>
		public interface ITerrainElevationFactory
		{
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
			ITerrainElevationSource CreateTerrainElevationSource(uint lod, uint size, float unitScale);
		}

		/// <summary>
		/// Interface implemented by those objects able to provide terrain elevation data, feeding information required
		/// to implement the geometry clipmap.
		/// </summary>
		public interface ITerrainElevationSource : IDisposable
		{
			/// <summary>
			/// Get the terrain elevation map corresponding to the specified position.
			/// </summary>
			/// <param name="viewPosition">
			/// The <see cref="Vertex3d"/> that specify the current view position, using an absolute cartesian reference system.
			/// </param>
			/// <returns>
			/// It returns the <see cref="Image"/> that contains the terrain elevation data corresponding to <paramref name="viewPosition"/>.
			/// </returns>
			/// <remarks>
			/// <para>
			/// 
			/// </para>
			/// </remarks>
			Image GetTerrainElevationMap(Vertex3d viewPosition);
		}

		/// <summary>
		/// Set the default terrain elevation factory.
		/// </summary>
		/// <param name="lat">
		/// The <see cref="Double"/> that specify the reference latitude coordinate, in degrees.
		/// </param>
		/// <param name="lon">
		/// The <see cref="Double"/> that specify the reference longitude coordinate, in degrees.
		/// </param>
		public void SetTerrainElevationFactory(string databaseRoot, double lat, double lon)
		{
			SetTerrainElevationFactory(new DefaultTerrainElevationFactory(databaseRoot, lat, lon));
		}

		/// <summary>
		/// Set the terrain elevation source.
		/// </summary>
		/// <param name="terrainElevationFactory">
		/// The <see cref="ITerrainElevationFactory"/> that is able to create the terrain elevation sources for each
		/// geometry clipmap level.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="terrainElevationFactory"/> is null.
		/// </exception>
		public void SetTerrainElevationFactory(ITerrainElevationFactory terrainElevationFactory)
		{
			if (terrainElevationFactory == null)
				throw new ArgumentNullException("terrainElevationFactory");

			for (ushort i = 0; i < ClipmapLevels; i++) {
				if (_TerrainElevationSources[i] != null)
					_TerrainElevationSources[i].Dispose();
				_TerrainElevationSources[i] = terrainElevationFactory.CreateTerrainElevationSource(i, ClipmapVertices + 1, BlockQuadUnit);
			}
		}

		/// <summary>
		/// The source of the terrain elevation maps.
		/// </summary>
		private readonly ITerrainElevationSource[] _TerrainElevationSources;

		#endregion

		#region Resources

		/// <summary>
		/// Create vertex arrays required for drawing the geometry clipmap blocks.
		/// </summary>
		private void CreateVertexArrays()
		{
			#region Clipmap Blocks

			// Create position array buffer ((n+1) x (n+1) vertices equally spaced)
			// Note: this array is shared with ring fixes
			ArrayBufferObject<Vertex2f> arrayBufferPosition = CreateClipmapBlockPositionArray();

			// Create elements indices
			// Note: this array is shared with ring fixes (horizontal)
			ElementBufferObject<ushort> arrayBufferIndices = CreateClipmapBlockElementArray();

			// Instances list (total instances to be culled)
			GenerateLevelBlocks();
			// Instances
			_ArrayClipmapBlockInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayClipmapBlockInstances.Create((uint)_InstancesClipmapBlock.Count);

			// Create blocks array
			_BlockArray = CreateVertexArrays(arrayBufferPosition, _ArrayClipmapBlockInstances, arrayBufferIndices, 0, 0);
			LinkResource(_BlockArray);

			#endregion

			#region Clipmap Ring Fixes (Horizontal)

			// Instances list (total instances to be culled)
			GenerateRingFixInstancesH();
			// Instances
			_ArrayRingFixHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayRingFixHInstances.Create((uint)_InstancesRingFixH.Count);

			// Create ring fixes array
			_RingFixArrayH = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixHInstances, arrayBufferIndices, 0, BlockVertices * 4 + 3);
			LinkResource(_RingFixArrayH);

			#endregion

			#region Clipmap Ring Fixes (Vertical)

			// Create custom elements indices for ring fixes (vertical only)
			ElementBufferObject<ushort> arrayBufferIndicesV = CreateRingFixVElementArray();

			// Instances list (total instances to be culled)
			GenerateRingFixInstancesV();
			// Instances
			_ArrayRingFixVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.StaticCpuDraw);
			_ArrayRingFixVInstances.Create((uint)_InstancesRingFixV.Count);

			// Vertex array
			_RingFixArrayV = CreateVertexArrays(arrayBufferPosition, _ArrayRingFixVInstances, arrayBufferIndicesV, 0, 0);
			LinkResource(_RingFixArrayV);

			#endregion

			#region Exterior (Horizontal)

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorHPosition = CreateExteriorHPositionArray();

			// Create elements indices
			ElementBufferObject<ushort> exteriorHIndices = CreateExteriorHElementArray();

			// Instances list (total instances to be culled)
			GenerateExteriorInstancesH();
			// Instances
			_ArrayExteriorHInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorHInstances.Create((uint)_InstancesExteriorH.Count);

			// Vertex array
			_LevelExteriorH = CreateVertexArrays(exteriorHPosition, _ArrayExteriorHInstances, exteriorHIndices, 0, 0);
			LinkResource(_LevelExteriorH);

			#endregion

			#region Exterior (Vertical)

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorVPosition = CreateExteriorVPositionArray();

			// Create elements indices
			ElementBufferObject<ushort> exteriorVIndices = CreateExteriorVElementArray();

			// Instances list (total instances to be culled)
			GenerateExteriorInstancesV();
			// Instances
			_ArrayExteriorVInstances = new ArrayBufferObjectInterleaved<ClipmapBlockInstance>(BufferObjectHint.DynamicCpuDraw);
			_ArrayExteriorVInstances.Create((uint)_InstancesExteriorV.Count);

			// Vertex array
			_LevelExteriorV = CreateVertexArrays(exteriorVPosition, _ArrayExteriorVInstances, exteriorVIndices, 0, 0);
			LinkResource(_LevelExteriorV);

			#endregion

			#region Cap Exterior

			// Vertex array
			_LevelCapExterior = new VertexArrayObject();
			LinkResource(_LevelCapExterior);

			_LevelCapExterior.SetArrayDefault(new Vertex4f(), "hal_BlockOffset", null);
			_LevelCapExterior.SetArrayDefault(new Vertex4f(), "hal_MapOffset", null);
			_LevelCapExterior.SetArrayDefault(new Vertex4f(), "hal_Lod", null);
			_LevelCapExterior.SetArrayDefault(new Vertex4f(), "hal_BlockColor", null);

			#endregion
		}

		private ArrayBufferObject<Vertex2f> CreateClipmapBlockPositionArray()
		{
			ArrayBufferObject<Vertex2f> arrayBufferPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			arrayBufferPosition.Create((uint)(BlockVertices * BlockVertices));
			arrayBufferPosition.Map();

			float positionStep = 1.0f / BlockSubdivs;
			uint positionIndex = 0;
			
			for (float y = 0.0f; y <= 1.0f; y += positionStep) {
				for (float x = 0.0f; x <= 1.0f; x += positionStep, positionIndex++) {
					Debug.Assert(positionIndex < arrayBufferPosition.ClientItemCount);
					arrayBufferPosition.Set(new Vertex2f(x, y), positionIndex);
				}
			}
			arrayBufferPosition.Unmap();

			return (arrayBufferPosition);
		}

		private ElementBufferObject<ushort> CreateClipmapBlockElementArray()
		{
			ElementBufferObject<ushort> arrayBufferIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> arrayBufferElements = new List<ushort>();

			arrayBufferIndices.RestartIndexEnabled = true;

			for (short i = 0; i < BlockSubdivs; i++) {
				ushort baseIndex = (ushort)(i * (BlockSubdivs + 1));

				arrayBufferElements.Add((ushort)(baseIndex));

				for (ushort x = 0; x < BlockSubdivs; x++) {
					arrayBufferElements.Add((ushort)(baseIndex + x + BlockSubdivs + 1));
					arrayBufferElements.Add((ushort)(baseIndex + x + 1));
				}
				arrayBufferElements.Add((ushort)(baseIndex + BlockSubdivs + 1 + BlockSubdivs));

				if (i < BlockSubdivs - 1)
					arrayBufferElements.Add((ushort)arrayBufferIndices.RestartIndexKey);
			}

			arrayBufferIndices.Create(arrayBufferElements.ToArray());

			return (arrayBufferIndices);
		}

		private ElementBufferObject<ushort> CreateRingFixVElementArray()
		{
			ElementBufferObject<ushort> arrayBufferIndicesV = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> arrayBufferElementsV = new List<ushort>();

			arrayBufferIndicesV.RestartIndexEnabled = true;

			for (ushort i = 0; i < 2; i++) {
				ushort baseIndex = i;

				arrayBufferElementsV.Add((ushort)(baseIndex));

				for (ushort y = 0; y < BlockSubdivs; y++) {
					arrayBufferElementsV.Add((ushort)(baseIndex + (y * BlockVertices) + 1));
					arrayBufferElementsV.Add((ushort)(baseIndex + ((y + 1) * BlockVertices)));
				}
				arrayBufferElementsV.Add((ushort)(baseIndex + (BlockSubdivs * BlockVertices) + 1));

				if (i < 1)
					arrayBufferElementsV.Add((ushort)arrayBufferIndicesV.RestartIndexKey);
			}

			arrayBufferIndicesV.Create(arrayBufferElementsV.ToArray());

			return (arrayBufferIndicesV);
		}

		private ArrayBufferObject<Vertex2f> CreateExteriorHPositionArray()
		{
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			// Create position array buffer
			ArrayBufferObject<Vertex2f> exteriorHPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			exteriorHPosition.Create((uint)(ExteriorVertices * 2));
			exteriorHPosition.Map();

			float xPositionStep = 1.0f / ExteriorkSubdivs;
			uint positionIndex = 0;

			for (float y = 0.0f; y <= 1.0f; y += 1.0f) {
				float x = 0.0f;

				for (int i = 0; i < ExteriorVertices; i++, x += xPositionStep, positionIndex++) {
					Debug.Assert(positionIndex < exteriorHPosition.ClientItemCount);
					exteriorHPosition.Set(new Vertex2f((float)x, y), positionIndex);
				}
			}
			exteriorHPosition.Unmap();
			Debug.Assert(positionIndex == exteriorHPosition.ClientItemCount);

			return (exteriorHPosition);
		}

		private ElementBufferObject<ushort> CreateExteriorHElementArray()
		{
			// Create elements indices
			ElementBufferObject<ushort> exteriorHIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> exteriorHElements = new List<ushort>();

			exteriorHIndices.RestartIndexEnabled = false; // Only 1 strip, primitive restart not required

			exteriorHElements.Add(0);

			for (ushort x = 0; x < ExteriorSubdivs; x++) {
				exteriorHElements.Add((ushort)(x + ExteriorSubdivs + 1));
				exteriorHElements.Add((ushort)(x + 1));
			}
			exteriorHElements.Add((ushort)(ExteriorVertices * 2 - 1));

			exteriorHIndices.Create(exteriorHElements.ToArray());

			return (exteriorHIndices);
		}

		private ArrayBufferObject<Vertex2f> CreateExteriorVPositionArray()
		{
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			ArrayBufferObject<Vertex2f> exteriorVPosition = new ArrayBufferObject<Vertex2f>(BufferObjectHint.StaticCpuDraw);

			exteriorVPosition.Create((uint)((ClipmapVertices + 4) * 2));
			exteriorVPosition.Map();

			float yPositionStep = 1.0f / ExteriorkSubdivs;
			uint positionIndex = 0;

			for (float x = 0.0f; x <= 1.0f; x += 1.0f) {
				float y = 0.0f;

				for (int i = 0; i < ExteriorVertices; i++, y += yPositionStep, positionIndex++) {
					Debug.Assert(positionIndex < exteriorVPosition.ClientItemCount);
					exteriorVPosition.Set(new Vertex2f((float)x, y), positionIndex);
				}
			}
			exteriorVPosition.Unmap();
			Debug.Assert(positionIndex == exteriorVPosition.ClientItemCount);

			return (exteriorVPosition);
		}

		private ElementBufferObject<ushort> CreateExteriorVElementArray()
		{
			ElementBufferObject<ushort> exteriorVIndices = new ElementBufferObject<ushort>(BufferObjectHint.StaticCpuDraw);
			List<ushort> exteriorVElements = new List<ushort>();

			exteriorVIndices.RestartIndexEnabled = false; // Only 1 strip, primitive restart not required

			exteriorVElements.Add(0);

			for (ushort x = 0; x < ExteriorSubdivs; x++) {
				exteriorVElements.Add((ushort)(x + ExteriorSubdivs + 1));
				exteriorVElements.Add((ushort)(x + 1));
			}
			exteriorVElements.Add((ushort)(ExteriorVertices * 2 - 1));

			exteriorVIndices.Create(exteriorVElements.ToArray());

			return (exteriorVIndices);
		}

		private VertexArrayObject CreateVertexArrays(ArrayBufferObjectBase positions, ArrayBufferObjectBase instances, ElementBufferObject indices, uint offset, uint count)
		{
			VertexArrayObject vertexArray = new VertexArrayObject();

			// Reuse position array buffer
			vertexArray.SetArray(positions, VertexArraySemantic.Position);

			vertexArray.SetInstancedArray(instances, 0, 1, "hal_BlockOffset", null);
			vertexArray.SetInstancedArray(instances, 1, 1, "hal_MapOffset", null);
			vertexArray.SetInstancedArray(instances, 2, 1, "hal_Lod", null);
			vertexArray.SetInstancedArray(instances, 3, 1, "hal_BlockColor", null);

			// Reuse indices array buffer, but limiting to 2 triangle strips
			vertexArray.SetElementArray(PrimitiveType.TriangleStrip, indices, offset, count);

			return (vertexArray);
		}

		private void GenerateLevelBlocks()
		{
			ColorRGBAF ColorEven = new ColorRGBAF(0.5f, 0.5f, 0.5f);
			ColorRGBAF ColorOdd = new ColorRGBAF(0.7f, 0.7f, 0.7f);

			int semiClipmapSize = ((int)ClipmapVertices - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				// Line 1
				yBlock = -semiClipmapSize;
				// Line 1 - 2 left
				xBlock = -semiClipmapSize;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
				// Line 1 - 2 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));

				// Line 2
				yBlock += (int)(BlockVertices - 1);
				// Line 2 - 1 left
				xBlock = -semiClipmapSize;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Bottom right
				xBlock = +semiClipmapSize - (int)BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 3
				yBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				// Line 3 - 1 left
				xBlock = -semiClipmapSize;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));
				// Line 3 - 1 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs;
				_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit));

				// Line 4
				yBlock = +semiClipmapSize - (int)BlockSubdivs;
				// Line 4 - 2 left
				xBlock = -semiClipmapSize;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
				// Line 4 - 2 right
				xBlock = +semiClipmapSize - (int)BlockSubdivs * 2;
				for (int i = 0; i < 2; i++, xBlock += (int)BlockSubdivs)
					_InstancesClipmapBlock.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, (i % 2) == 0 ? ColorEven : ColorOdd));
			}
		}

		private void GenerateRingFixInstancesH()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);

			int semiClipmapSize = ((int)ClipmapVertices - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize;
				yBlock = -1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixH.Add(clipmapBlockInstance);

				xBlock = (int)(+semiClipmapSize - BlockSubdivs);
				yBlock = -1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixH.Add(clipmapBlockInstance);
			}
		}

		private void GenerateRingFixInstancesV()
		{
			ColorRGBAF RingFixColor = new ColorRGBAF(1.0f, 0.0f, 1.0f);

			int semiClipmapSize = ((int)ClipmapVertices - 1) / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -1;
				yBlock = -semiClipmapSize;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixV.Add(clipmapBlockInstance);

				xBlock = -1;
				yBlock = (int)(+semiClipmapSize - BlockSubdivs);
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, RingFixColor);
				_InstancesRingFixV.Add(clipmapBlockInstance);
			}
		}

		private void GenerateExteriorInstancesH()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 0.5f, 0.5f);
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels - 1; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = +semiClipmapSize;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorH.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = +semiClipmapSize + 1;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, ExteriorVertices, 2, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorH.Add(clipmapBlockInstance);
			}
		}

		private void GenerateExteriorInstancesV()
		{
			ColorRGBAF ExteriorColor = new ColorRGBAF(1.0f, 0.5f, 0.5f);
			uint ExteriorVertices = ClipmapVertices + 4;
			ushort ExteriorkSubdivs = (ushort)(ExteriorVertices - 1);

			int semiClipmapSize = (int)ClipmapSubdivs / 2;
			int xBlock, yBlock;

			for (ushort level = 0; level < ClipmapLevels - 1; level++) {
				ClipmapBlockInstance clipmapBlockInstance;

				xBlock = -semiClipmapSize - 1;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = -semiClipmapSize - 2;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = +semiClipmapSize;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorV.Add(clipmapBlockInstance);

				xBlock = +semiClipmapSize + 1;
				yBlock = -semiClipmapSize - 2;
				clipmapBlockInstance = new ClipmapBlockInstance(ClipmapVertices, 2, ExteriorVertices, (int)xBlock, (int)yBlock, level, BlockQuadUnit, ExteriorColor);
				clipmapBlockInstance.SetTextureLod(ClipmapVertices, (uint)(level + 1));
				_InstancesExteriorV.Add(clipmapBlockInstance);
			}
		}

		/// <summary>
		/// Generate a <see cref="List{ClipmapBlockInstance}"/> defining instances to cap the clipmap level.
		/// </summary>
		/// <param name="level">
		/// The <see cref="UInt32"/> that specify the level of the cap.
		/// </param>
		/// <returns>
		/// It returns a <see cref="List{ClipmapBlockInstance}"/> defining instances parameters used for capping
		/// the geometry clipmap cap to be draw with <see cref="_BlockArray"/>.
		/// </returns>
		private List<ClipmapBlockInstance> GenerateLevelBlocksCap(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			ushort BlockSubdivs = (ushort)(BlockVertices - 1);
			int offsetx = -1, offsety = -1;

			int semiClipmapSize = ((int)ClipmapVertices - 1) / 2;

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)offsetx, (int)offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs + offsetx, (int)offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)offsetx, (int)-BlockSubdivs + offsety, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs + offsetx, (int)-BlockSubdivs + offsety, level, BlockQuadUnit));

			return (capBlocks);
		}

		private List<ClipmapBlockInstance> GenerateLevelBlocksCapFixH(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)-BlockSubdivs - 1, (int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, -1, (int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, +1, (int)BlockSubdivs - 1, level, BlockQuadUnit));

			return (capBlocks);
		}

		private List<ClipmapBlockInstance> GenerateLevelBlocksCapFixV(uint level)
		{
			List<ClipmapBlockInstance> capBlocks = new List<ClipmapBlockInstance>();

			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)BlockSubdivs - 1, -(int)BlockSubdivs - 1, level, BlockQuadUnit));
			capBlocks.Add(new ClipmapBlockInstance(ClipmapVertices, BlockVertices, (int)BlockSubdivs - 1, -1, level, BlockQuadUnit));

			return (capBlocks);
		}

		/// <summary>
		/// Shader program used for drawing geometry clipmap.
		/// </summary>
		private ShaderProgram _GeometryClipmapProgram;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayClipmapBlockInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayRingFixHInstances, _ArrayRingFixVInstances;

		/// <summary>
		/// Array buffer object defining instances attributes.
		/// </summary>
		private ArrayBufferObjectInterleaved<ClipmapBlockInstance> _ArrayExteriorHInstances, _ArrayExteriorVInstances;

		/// <summary>
		/// Vertex arrays for drawing 
		/// </summary>
		private VertexArrayObject _BlockArray;

		/// <summary>
		/// Vertex arrays for drawing ring fix (horizontal and vertical patches).
		/// </summary>
		private VertexArrayObject _RingFixArrayH, _RingFixArrayV;

		/// <summary>
		/// Vertex arrays for drawing level exterior (horizontal and vertical patches).
		/// </summary>
		private VertexArrayObject _LevelExteriorH, _LevelExteriorV;

		/// <summary>
		/// Vertex arrays for drawing level cap exterior.
		/// </summary>
		private VertexArrayObject _LevelCapExterior;

		/// <summary>
		/// Elevation texture.
		/// </summary>
		private TextureArray2d _ElevationTexture;

		#endregion

		#region SceneGraphObject Overrides

		/// <summary>
		/// Draw this SceneGraphObject hierarchy.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected internal override void Draw(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctx");

			Vertex3d currentPosition = (Vertex3d)ctxScene.CurrentView.LocalModel.Position;

			// Compute visible clipmap levels
			const float HeightGain = 2.5f;

			float viewerHeight = currentPosition.Y;
			float clipmap0Size = BlockQuadUnit * (ClipmapVertices - 1);

			_CurrentLevel = 0;
			while (clipmap0Size * Math.Pow(2.0, _CurrentLevel) < viewerHeight * HeightGain)
				_CurrentLevel++;

			// Base implementation
			base.Draw(ctx, ctxScene);
		}

		/// <summary>
		/// Draw this SceneGraphObject instance.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for drawing.
		/// </param>
		/// <param name="ctxScene">
		/// The <see cref="SceneGraphContext"/> used for drawing.
		/// </param>
		protected override void DrawThis(GraphicsContext ctx, SceneGraphContext ctxScene)
		{
			if (ctxScene == null)
				throw new ArgumentNullException("ctx");

			CheckCurrentContext(ctx);

			ctxScene.GraphicsStateStack.Current.Apply(ctx, _GeometryClipmapProgram);

			// Update elevation maps
			Vertex3d viewPosition = ctxScene.CurrentView.LocalModel.Position;

			if (PositionCorrection) {
				for (ushort i = 0; i < ClipmapLevels; i++) {
					if (_TerrainElevationSources[i] == null)
						continue;

					Image elevationMap = _TerrainElevationSources[i].GetTerrainElevationMap(viewPosition);
					if (elevationMap == null)
						continue;       // No update required

#if TEXTURING_ELEVATION
					_ElevationTexture.Create(ctx, PixelLayout.GRAY16S, elevationMap, i);
#endif
				}
			}

			ctx.Bind(_GeometryClipmapProgram);
			_GeometryClipmapProgram.ResetTextureUnits();
			_GeometryClipmapProgram.SetUniform(ctx, "hal_ElevationMap", _ElevationTexture);

			if (PositionCorrection) {
				// Set grid offsets
				Vertex3d currentPosition = ctxScene.CurrentView.LocalModel.Position;
				Vertex2f[] gridOffsets = new Vertex2f[ClipmapLevels];

				for (uint level = 0; level < ClipmapLevels; level++) {
					double positionModule = BlockQuadUnit * Math.Pow(2.0, level);
					Vertex3d gridPositionOffset = currentPosition - (currentPosition % positionModule);
					double x = gridPositionOffset.x, y = gridPositionOffset.z;

					gridOffsets[level] = new Vertex2f((float)x, (float)y);
				}
#if POSITION_CORRECTION
				_GeometryClipmapProgram.SetUniform(ctx, "hal_GridOffset", gridOffsets);
#endif
			}

			// Instance culling
			List<ClipmapBlockInstance> instancesClipmapBlock = new List<ClipmapBlockInstance>(_InstancesClipmapBlock);
			List<ClipmapBlockInstance> instancesRingFixH = new List<ClipmapBlockInstance>(_InstancesRingFixH);
			List<ClipmapBlockInstance> instancesRingFixV = new List<ClipmapBlockInstance>(_InstancesRingFixV);

			// Base LOD cap instances
#if CLIPMAP_CAP
#if CULLING_CLIPMAP_CAP
			// Include cap in clipmap blocks
			instancesClipmapBlock.AddRange(GenerateLevelBlocksCap(_CurrentLevel));
			instancesRingFixH.AddRange(GenerateLevelBlocksCapFixH(_CurrentLevel));
			instancesRingFixV.AddRange(GenerateLevelBlocksCapFixV(_CurrentLevel));
#else
			// Include cap in clipmap blocks
			instancesClipmapBlock.AddRange(GenerateLevelBlocksCap(0));
			instancesRingFixH.AddRange(GenerateLevelBlocksCapFixH(0));
			instancesRingFixV.AddRange(GenerateLevelBlocksCapFixV(0));
#endif
#endif
			_InstancesExteriorH.Clear();
			GenerateExteriorInstancesH();
			_InstancesExteriorV.Clear();
			GenerateExteriorInstancesV();

			// Cull instances
			uint instancesClipmapBlockCount = CullInstances(ctx, instancesClipmapBlock, _ArrayClipmapBlockInstances);
			uint instancesRingFixHCount = CullInstances(ctx, instancesRingFixH, _ArrayRingFixHInstances);
			uint instancesRingFixVCount = CullInstances(ctx, instancesRingFixV, _ArrayRingFixVInstances);
			uint instancesExteriorHCount = CullInstances(ctx, _InstancesExteriorH, _ArrayExteriorHInstances);
			uint instancesExteriorVCount = CullInstances(ctx, _InstancesExteriorV, _ArrayExteriorVInstances);

			// Draw clipmap blocks using instanced rendering
			if (instancesClipmapBlockCount > 0)
				_BlockArray.DrawInstanced(ctx, _GeometryClipmapProgram, instancesClipmapBlockCount);
			if (instancesRingFixHCount > 0)
				_RingFixArrayH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixHCount);
			if (instancesRingFixVCount > 0)
				_RingFixArrayV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesRingFixVCount);
			if (instancesExteriorHCount > 0)
				_LevelExteriorH.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorHCount);
			if (instancesExteriorVCount > 0)
				_LevelExteriorV.DrawInstanced(ctx, _GeometryClipmapProgram, instancesExteriorVCount);
		}

		/// <summary>
		/// Filter an array of <see cref="ClipmapBlockInstance"/> and updates the specifies array buffer.
		/// </summary>
		/// <param name="ctx">
		/// The <see cref="GraphicsContext"/> used for updating <paramref name="arrayBuffer"/>.
		/// </param>
		/// <param name="instances">
		/// The <see cref="List{ClipmapBlockInstance}"/> to be filtered.
		/// </param>
		/// <param name="arrayBuffer">
		/// The <see cref="ArrayBufferObjectInterleaved{ClipmapBlockInstance}"/> to be updated.
		/// </param>
		/// <returns>
		/// It returns the number of items of <paramref name="instances"/> filtered.
		/// </returns>
		private uint CullInstances(GraphicsContext ctx, List<ClipmapBlockInstance> instances, ArrayBufferObjectInterleaved<ClipmapBlockInstance> arrayBuffer)
		{
			List<ClipmapBlockInstance> cull = new List<ClipmapBlockInstance>(instances);

#if CULLING_CLIPMAP_CAP

			// Filter by level
			// Exclude finer levels depending on viewer height
			cull = cull.FindAll(delegate (ClipmapBlockInstance item) {
				return (item.Lod >= _CurrentLevel);
			});

#endif
			//cull = cull.FindAll(delegate (ClipmapBlockInstance item) {
			//	return (item.Lod.Y != 0);
			//});

			// Update instance arrays
			if (cull.Count > 0)
				arrayBuffer.Update(ctx, cull.ToArray());

			return ((uint)cull.Count);
		}

		/// <summary>
		/// Temporary field used by <see cref="Draw"/> and <see cref="DrawThis"/>.
		/// </summary>
		private uint _CurrentLevel;

		protected override void Dispose(bool disposing)
		{
			// Base implementation
			base.Dispose(disposing);

			// Dispose previous terrain elevation sources
			for (ushort i = 0; i < ClipmapLevels; i++)
				if (_TerrainElevationSources[i] != null)
					_TerrainElevationSources[i].Dispose();
		}

		#endregion
	}
}
